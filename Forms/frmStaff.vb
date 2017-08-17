Imports System.Math
Imports System.Data.SqlClient

Public Class frmStaff
Dim tmpDS As DataSet

    Private Sub frmStaff_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = My.Settings.SysName & " - " & "Labour"
        Me.DataGridView1.BackgroundColor = myGBColor
        Me.dgvProductLink.BackgroundColor = myGBColor
        Me.TreeView1.BackColor = myGBColor
        Me.DataGridView3.BackgroundColor = myGBColor
        Me.dgv_JobTitle.BackgroundColor = myGBColor

        Me.TblStaffTableAdapter1.Fill(Me.DsProdDB.tblStaff)
        Me.TblCoInfoTableAdapter1.Fill(Me.DsProdDB.tblCoInfo)
        Me.LstStaffGroupsTableAdapter1.Fill(Me.DsProdDB.lstStaffGroups)
        Me.TblJobTitleTableAdapter1.Fill(Me.DsProdDB.tblJobTitle)
        Me.RadioButton1.Checked = True
        
    End Sub

    Private Sub frmStaff_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub frmStaff_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    Me.Invalidate()
    End Sub

    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        Me.Validate()
        Me.TblStaffBindingSource.EndEdit()
        Me.TblStaffTableAdapter1.Update(Me.DsProdDB.tblStaff)
    End Sub

    Private Sub DataGridView1_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView1.RowValidating

        If IsDBNull(Me.DataGridView1.CurrentRow.Cells("TxtRateDataGridViewTextBoxColumn").Value) Then
        Me.DataGridView1.CurrentRow.ErrorText = "Can not save staff member with no rate"
            Else
            'Me.DataGridView1.CurrentRow.Cells("DblRatePerHourDataGridViewTextBoxColumn").Value = GetRatePerHour(Me.DataGridView1.CurrentRow.Cells("TxtRateDataGridViewTextBoxColumn").Value, Me.DataGridView1.CurrentRow.Cells("TxtRateDescriptorDataGridViewTextBoxColumn").Value)
            End If

    End Sub

    Private Function GetRatePerHour(ByVal xRate As Decimal, ByVal xType As String)

        Dim xNorHour As Decimal = Me.DsProdDB.tblCoInfo.Rows(0).Item("dblNormalLabHours")
        Dim xFriHour As Decimal = Me.DsProdDB.tblCoInfo.Rows(0).Item("dblFridayLabHours")

        Select Case xType
            Case "Hour"
            Return Round(xRate, 3)
            Case "Week"
            Return Round(xRate / ((xNorHour * 4) + xFriHour), 3)
            Case "Day"
            Dim div As Decimal = ((xNorHour * 4) + xFriHour) / 5
            Return Round(xRate / div, 3)
            Case "Month"
            Dim div As Decimal = ((xNorHour * 4) + xFriHour) * 4
            Return Round(xRate / div, 3)
            Case Else
            Return 0

        End Select


    End Function

    Private Sub TabPage_LabActivities_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage_LabActivities.Enter
    Me.TblDeptTableAdapter1.Fill(Me.DsActivityDB1.tblDept)
    Me.TblElementTableAdapter2.Fill(Me.DsActivityDB1.tblElement)
    Me.TblActivityTableAdapter2.Fill(Me.DsActivityDB1.tblActivity)
    Me.TblActivityBindingSource.Filter = "FK_idtblelement = " & 0
    Me.DataGridView3.Columns(0).Visible = False
        'Populate Tree structure
        TreeView1.Nodes.Clear()
        Me.TreeView1.Nodes.Add(New TreeNode("List of Departments"))
        Dim tNode = TreeView1.Nodes(0)
        PopulateTree1(tNode)
        tNode.Expand()
    End Sub

    Private Sub PopulateTree1(ByRef inTreeNode As TreeNode)

        Dim SQLstr As String
        Dim ds As New DataSet
        SQLstr = "SELECT idtblDept, txtDepName, numSortOrder From tblDept Order by numSortOrder"
        Dim sqlAdapter1 As New SqlDataAdapter(SQLstr, My.Settings.ConnectionString1)
        sqlAdapter1.Fill(ds, "Depts")
        Dim xBatchCount As Integer = ds.Tables("Depts").Rows.Count

        Dim parentrow As DataRow
        Dim parenttable As DataTable
        parenttable = ds.Tables("Depts")

        For Each parentrow In parenttable.Rows
            Dim parentnode As TreeNode
            Dim strLabel As String = parentrow.Item(1)
            parentnode = New TreeNode(strLabel)
            inTreeNode.Nodes.Add(parentnode)
            parentnode.Tag = "S" & parentrow.Item(0)

            SQLstr = "Select id_tblElement, txtElementDesc from tblElement where FK_tblDept = " & parentrow.Item(0) & " Order by numSortOrder"
            Dim sqlAdapter2 As New SqlDataAdapter(SQLstr, My.Settings.ConnectionString1)
            sqlAdapter2.Fill(ds, "Operations")

            Dim ChildNode As TreeNode
            Dim SecondRow As DataRow
            Dim SecondTable As DataTable
            SecondTable = ds.Tables("Operations")

            For Each SecondRow In SecondTable.Rows
                If IsDBNull(SecondRow.Item(1)) = False Then strLabel = SecondRow.Item(1) Else strLabel = "...."

                ChildNode = New TreeNode(strLabel)
                parentnode.Nodes.Add(ChildNode)
                ChildNode.Tag = "T" & SecondRow.Item(0)

                'PopulateTree1_SubNodes(parentrow.Item(0), SecondRow.Item(1), ChildNode)

            Next SecondRow
            ds.Tables("Operations").Clear()
        Next parentrow

    End Sub

    'Private Sub PopulateTree1_SubNodes(ByVal TechType As String, ByVal CourseCat As String, ByRef inTreeNode As TreeNode)
    '    Dim SQLstr As String
    '    Dim ds As New DataSet
    '    SQLstr = "SELECT Distinct IDtblCourse, txtCourseCode, txtCourseName From tblCourse WHERE txtTraineeType =" & q & TechType & q & " AND txtCourseCat = " & q & CourseCat & q
    '    Dim sqlAdapter1 As New OleDbDataAdapter(SQLstr, My.Settings.conTMS)
    '    sqlAdapter1.Fill(ds, "CourseDetail")
    '    Dim xBatchCount As Integer = ds.Tables("CourseDetail").Rows.Count

    '    Dim parentrow As DataRow
    '    Dim parenttable As DataTable
    '    parenttable = ds.Tables("CourseDetail")

    '    For Each parentrow In parenttable.Rows
    '    Dim parentnode As TreeNode
    '    Dim strLabel As String = parentrow.Item(1) & " - " & parentrow.Item(2)
    '    parentnode = New TreeNode(strLabel)
    '    inTreeNode.Nodes.Add(parentnode)
    '    parentnode.Tag = "B" & parentrow.Item(0)

    '    Next parentrow

    'End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
    Dim xSelString As String = TreeView1.SelectedNode.Tag
    Dim xSelParent As String
    Dim xSelTopNode As String

    Try
    If String.IsNullOrEmpty(xSelString) Then 'Or xSelString Is Nothing Then ' Or xSelString.StartsWith("S") Then Exit Sub
    Me.TblActivityBindingSource.Filter = "FK_idtblElement = " & 0
    Exit Sub
    End If
    Catch ex As NullReferenceException
    Me.TblActivityBindingSource.Filter = "FK_idtblElement = " & 0
    Exit Sub
    End Try

    If xSelString.StartsWith("S") Or xSelString Is Nothing Then
    Me.TblActivityBindingSource.Filter = "FK_idtblElement = " & 0
    Exit Sub
    End If

        If xSelString.StartsWith("T") Then

            xSelParent = TreeView1.SelectedNode.Parent.Text
            xSelTopNode = TreeView1.SelectedNode.Parent.Parent.Text
            Dim xRecID As Integer = xSelString.Remove(0, 1)
            Me.TblActivityBindingSource.Filter = "FK_idtblElement = " & xRecID
            Me.DataGridView3.Columns(0).Visible = False
        End If


    End Sub

    Private Sub TabPage_LabActivities_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TabPage_LabActivities.Paint
    Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub TabPage_LabActivities_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage_LabActivities.Resize


    MiscCode.ResizeGrid(Me.DataGridView3)
    Me.Invalidate()

    End Sub

    Private Sub DataGridView3_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView3.RowValidating

    If Me.TreeView1.SelectedNode Is Nothing Then Exit Sub

    Dim xElementID As Integer = Me.TreeView1.SelectedNode.Tag.ToString.Remove(0, 1)

    Dim xRec As DataRow = Me.TblActivityBindingSource.Current.row
    If xRec.RowState = DataRowState.Detached And IsDBNull(xRec.Item("FK_idtblElement")) Then

    xRec.Item("FK_idtblElement") = xElementID

    End If

    End Sub

    Private Sub DataGridView3_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.RowValidated
        Me.Validate()
        Me.TblActivityBindingSource.EndEdit()
        Me.TblActivityTableAdapter2.Update(Me.DsActivityDB1.tblActivity)
    End Sub

    Private Sub TabPage_LabStd_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage_LabStd.Enter

    Me.TblDeptTableAdapter1.Fill(Me.DsActivityDB1.tblDept)
    Me.TblElementTableAdapter2.Fill(Me.DsActivityDB1.tblElement)
    Me.TblActivityTableAdapter2.Fill(Me.DsActivityDB1.tblActivity)

    'TODO: This line of code loads data into the 'DsProdDB.tblProdLink' table. You can move, or remove it, as needed.
        Me.DsProdDB.EnforceConstraints = False
        Me.TblProdLinkTableAdapter.Fill(Me.DsProdDB.tblProdLink)

    'Reset any filters if they exist
    Me.TblDeptBindingSource.Filter = Nothing
    Me.TblElementBindingSource.Filter = Nothing
    Me.TblActivityBindingSource.Filter = Nothing
    Me.TblProdLinkBindingSource.Filter = Nothing

    'Populate the temporary dataset for use in the Datagrid
    tmpDS = Me.DsProdDB.Clone
        'Fill Product combo box
        If RadioButton1.Checked = True Then
            If Len(Me.Tag) = 0 Then
                Me.TblProductTableAdapter.FillByComboInfo(Me.DsProdDB.tblProduct)
                Me.ComboBox2.DataSource = Me.DsProdDB.tblProduct
                Me.ComboBox2.DisplayMember = "ComboInfo"
                Me.ComboBox2.ValueMember = "idtblProduct"
                Me.TblProdLinkBindingSource.Filter = "FK_tblProduct = " & 0
                Me.dgvProductLink.Visible = True
            Else

                Me.TblProductTableAdapter.FillByComboInfo(Me.DsProdDB.tblProduct)
                Me.ComboBox2.DataSource = Me.DsProdDB.tblProduct
                Me.ComboBox2.DisplayMember = "ComboInfo"
                Me.ComboBox2.ValueMember = "idtblProduct"
                ' Me.TblProdLinkBindingSource.Filter = "FK_tblProduct = " & Me.Tag
                Me.ComboBox2.SelectedValue = Me.Tag
                FilldgvLabStandard(Me.Tag)
            End If
        Else
            Me.TblMaterialTableAdapter1.FillByComponent(Me.DsProdDB.tblMaterial)
            Me.ComboBox2.DataSource = Me.DsProdDB.tblMaterial
            Me.ComboBox2.DisplayMember = "Combovalue"
            Me.ComboBox2.ValueMember = "id_tblMaterial"
        End If


    End Sub

    Private Sub dgvProductLink_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductLink.CellEndEdit
    Dim xCell As DataGridViewCell = dgvProductLink.CurrentCell
        If xCell.ColumnIndex = 4 Then
            'Populate the Staff column
            If IsDBNull(dgvProductLink.CurrentRow.Cells("dgv_txtLabourParameter").Value) Then
                dgvProductLink.CurrentRow.Cells("Staff_Member").Value = "---Average---"
            Else
                dgvProductLink.CurrentRow.Cells("Staff_Member").Value = dgvProductLink.CurrentRow.Cells("dgv_txtLabourParameter").Value
            End If
        End If
    End Sub

    Private Sub dgvProductLink_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvProductLink.DataError
        MsgBox("A data error has occured - contact the administrator")

    End Sub

    Private Sub dgvProductLink_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvProductLink.Leave
        Try
        Me.Validate()
        Me.TblProdLinkBindingSource.EndEdit()
        Me.TblProdLinkTableAdapter.Update(Me.DsProdDB.tblProdLink)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectionChangeCommitted

        Me.ComboBox2.DropDownStyle = ComboBoxStyle.Simple

        If Me.RadioButton1.Checked = True Then
            Me.TblActivityBindingSource.Filter = Nothing
            Try
                Me.dgvProductLink.DataSource = Nothing
                Dim xProdID As Integer = Me.ComboBox2.SelectedValue
                Me.TblProdLinkBindingSource.Filter = "fk_tblProduct = " & xProdID
                Me.TblProdLinkBindingSource.Sort = "fk_tblDept, fk_tblElement"
                If Me.dgvProductLink.DataSource Is Nothing Then Me.dgvProductLink.DataSource = TblProdLinkBindingSource
                Me.dgvProductLink.Visible = True
                Me.dgvProductLink.Refresh()
            Catch ex As Exception
            End Try
        Else
            Me.TblActivityBindingSource.Filter = Nothing
            Try
                Me.dgvProductLink.DataSource = Nothing
                Dim xCompID As Integer = Me.ComboBox2.SelectedValue
                Me.TblProdLinkBindingSource.Filter = "fk_tblMaterial = " & xCompID
                Me.TblProdLinkBindingSource.Sort = "fk_tblDept, fk_tblElement"
                If Me.dgvProductLink.DataSource Is Nothing Then Me.dgvProductLink.DataSource = TblProdLinkBindingSource
                Me.dgvProductLink.Visible = True
                Me.dgvProductLink.Refresh()
            Catch ex As Exception
            End Try

        End If

        Me.ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub TabPage_LabOpsStaff_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage_LabOpsStaff.Enter
        Me.TblStaffTableAdapter1.Fill(Me.DsProdDB.tblStaff)
        MiscCode.ResizeGrid(Me.DataGridView1)
    End Sub

    Private Sub TabPage_LabOpsStaff_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage_LabOpsStaff.Resize
        MiscCode.ResizeGrid(Me.DataGridView1)
    End Sub

    Private Sub TabPage_LabStd_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage_LabStd.Resize
    
    MiscCode.ResizeGrid(Me.dgvProductLink)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
    Dim xSelectTab As String = Me.TabControl1.SelectedTab.Text
    xComboID = Me.ComboBox2.SelectedValue

    Select Case xSelectTab
    Case "Activities"
        Dim dia As Form = diaDeptEleAct
        xStaffToolstrip = sender
        dia.Text = My.Settings.SysName & " - " & "Add New Dept/Operation/Activity"
                If Me.TreeView1.SelectedNode Is Nothing Then
                    dia.Tag = ""
                Else

                    If Not Me.DataGridView3.CurrentRow Is Nothing Then
                        dia.Tag = Me.DataGridView3.CurrentRow.Cells("IdtblActivityDataGridViewTextBoxColumn").Value
                    Else
                        dia.Tag = Me.TreeView1.SelectedNode.Tag
                    End If
                End If

                dia.ShowDialog()

                If dia.DialogResult = DialogResult.OK Then
                    'Populate Tree structure
                    TreeView1.Nodes.Clear()
                    Me.TreeView1.Nodes.Add(New TreeNode("List of Departments"))
                    Dim tNode = TreeView1.Nodes(0)
                    PopulateTree1(tNode)
                    tNode.Expand()
                End If

            Case "Labour Standard"

                If IsNumeric(Me.ComboBox2.SelectedValue) Then
                    Dim dia As Form = diaLabourLink
                    xStaffToolstrip = sender
                    dia.Text = "Add a new Labour Link"
                    xComboID = Me.ComboBox2.SelectedValue
                    If Me.RadioButton1.Checked = True Then
                        dia.Tag = "Product"
                    Else
                        dia.Tag = "Component"
                    End If

                    dia.ShowDialog()


                    If dia.DialogResult = DialogResult.OK Then
                        Me.TblProdLinkBindingSource.EndEdit()
                        Me.TblProdLinkTableAdapter.Fill(Me.DsProdDB.tblProdLink)
                        Me.dgvProductLink.Refresh()
                    End If
                    dia.Close()
                Else
                    MsgBox("No Product selected ")
                End If

            Case "Operational Staff"
                Me.TblStaffBindingSource.EndEdit()
                Dim dia As Form = diaStaffAdd
                xStaffToolstrip = sender
                dia.Text = "Add a new employee"
                xComboID = Me.ComboBox2.SelectedValue
                dia.ShowDialog()


                If dia.DialogResult = DialogResult.OK Then
                    Me.TblStaffBindingSource.EndEdit()
                    Me.TblStaffTableAdapter1.Fill(Me.DsProdDB.tblStaff)
                    Me.DataGridView1.Refresh()
                End If
                dia.Close()

            Case "Job/Task descriptions"
                Dim dia As New diaJobTitle
                xStaffToolstrip = sender
                dia.Text = "Manage job titles"
                dia.ShowDialog()


                If dia.DialogResult = DialogResult.OK Then
                    Me.TblJobTitleBindingSource.EndEdit()
                    Me.TblJobTitleTableAdapter1.Fill(Me.DsProdDB.tblJobTitle)
                    Me.DataGridView1.Refresh()
                End If
                dia.Close()
        End Select
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
    Dim xSelectTab As String = Me.TabControl1.SelectedTab.Text
    xComboID = Me.ComboBox2.SelectedValue
        Try
            Select Case xSelectTab
                Case "Activities"
                    Dim dia As Form = diaDeptEleAct
                    xStaffToolstrip = sender
                    dia.Text = My.Settings.SysName & " - " & "Add New Dept/Operation/Activity"
                    If Not Me.DataGridView3.CurrentRow Is Nothing Then
                        dia.Tag = Me.DataGridView3.CurrentRow.Cells("IdtblActivityDataGridViewTextBoxColumn").Value
                    Else
                        dia.Tag = Me.TreeView1.SelectedNode.Tag
                    End If

                    dia.ShowDialog()

                    If dia.DialogResult = DialogResult.OK Then
                        'Populate Tree structure
                        TreeView1.Nodes.Clear()
                        Me.TreeView1.Nodes.Add(New TreeNode("List of Departments"))
                        Dim tNode = TreeView1.Nodes(0)
                        PopulateTree1(tNode)
                        tNode.Expand()
                    End If
                Case "Labour Standard"
                    Dim dia As Form = diaLabourLink
                    xLabourLinkID = Me.dgvProductLink.CurrentRow.Cells("IdtblProdLinkDataGridViewTextBoxColumn").Value
                    xStaffToolstrip = sender
                    dia.Text = "Edit a labour link record"
                    dia.ShowDialog()

                    If dia.DialogResult = DialogResult.OK Then
                        FilldgvLabStandard(Me.ComboBox2.SelectedValue)
                    End If

                Case "Operational Staff"
                    Dim dia As Form = diaStaffAdd
                    xLabourLinkID = Me.DataGridView1.CurrentRow.Cells("IdtblStaffDataGridViewTextBoxColumn").Value
                    xStaffToolstrip = sender
                    dia.ShowDialog()
                    If dia.DialogResult = DialogResult.OK Then
                        Me.TblStaffTableAdapter1.Fill(Me.DsProdDB.tblStaff)
                        Me.DataGridView1.Refresh()
                    End If

                Case "Job/Task descriptions"
                    Dim dia As Form = diaJobTitle
                    xLabourLinkID = Me.dgv_JobTitle.CurrentRow.Cells("IdtblJobTitlesDataGridViewTextBoxColumn").Value
                    xStaffToolstrip = sender
                    dia.ShowDialog()
                    If dia.DialogResult = DialogResult.OK Then
                        Me.TblJobTitleTableAdapter1.Fill(Me.DsProdDB.tblJobTitle)
                        Me.DataGridView1.Refresh()
                    End If
            End Select
        Catch ex As NullReferenceException
            MsgBox("No record was selected")
        End Try

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        Dim xArr = Me.TblActivityBindingSource.Current.row.itemarray
        Me.TblActivityTableAdapter2.Delete(xArr(0), xArr(1), xArr(2), xArr(3), xArr(4), xArr(5))

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click

        Dim dia As Form = diaDeptEleAct
        xStaffToolstrip = Me.ToolStripButton2
        dia.Text = My.Settings.SysName & " - " & "Add New Dept/Operation/Activity"
        dia.Tag = Me.DataGridView3.CurrentRow.Cells("IdtblActivityDataGridViewTextBoxColumn").Value
        dia.ShowDialog()

        If dia.DialogResult = DialogResult.OK Then

        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
    Dim dia As Form = diaLabourCopy
    xCopyDesc = Me.ComboBox2.Text
    dia.ShowDialog()
    Dim xReply As MsgBoxResult

        If dia.DialogResult = Windows.Forms.DialogResult.OK Then
        'Check if the copied to product contains values
        Dim xCheckValue As String = MiscCode.GetValueonID(xCopyID, "fk_tblProduct", "tblProdLink", "fk_tblProduct")
        If String.IsNullOrEmpty(xCheckValue) = False Then
        xReply = MiscCode.DisplayError("008")
        End If
            If xReply = MsgBoxResult.Ok Or String.IsNullOrEmpty(xCheckValue) = True Then
                For Each xRow As DataGridViewRow In Me.dgvProductLink.Rows
                    Dim xEffPer As Double = MiscCode.GetEffPer(xRow.Cells("Fk_tblDept").Value)
                    Dim xStaffID As Integer
                    Me.TblProdLinkTableAdapter.Insert(xCopyID, Nothing, xRow.Cells("Fk_tblDept").Value, xRow.Cells("FktblElementDataGridViewTextBoxColumn").Value, xRow.Cells("dgv_FK_tblActivity").Value, 0, xRow.Cells("DblValueDataGridViewTextBoxColumn").Value, xRow.Cells("TxtValueDescDataGridViewTextBoxColumn").Value, xRow.Cells("DblFreqDataGridViewTextBoxColumn").Value, MiscCode.MNS((xRow.Cells("txtLabourParameter").Value)), xRow.Cells("dblLabourCost").Value, MiscCode.GetLabourHours(xRow.Cells("TxtValueDescDataGridViewTextBoxColumn").Value, xRow.Cells("DblValueDataGridViewTextBoxColumn").Value), MiscCode.GetLabourHours(xRow.Cells("TxtValueDescDataGridViewTextBoxColumn").Value, xRow.Cells("DblAdjValueDataGridViewTextBoxColumn").Value), (xRow.Cells("dblValue").Value * xEffPer) / 100, (xRow.Cells("dblLabourCost").Value * xEffPer) / 100)
                Next
                '(xRow.Cells("dblLabourCost").Value * xEffPer) / 100
            Me.TblProdLinkBindingSource.EndEdit()
            Me.TblProdLinkTableAdapter.Update(Me.DsProdDB.tblProdLink)
            Me.TblProdLinkTableAdapter.Fill(Me.DsProdDB.tblProdLink)
                FilldgvLabStandard(Me.ComboBox2.SelectedValue)
                My.Forms.ApplicationStartupForm.ss1.Text = "Values copied from " & xCopyDesc
                
            Else
            My.Forms.ApplicationStartupForm.ss1.Text = "Operation cancelled by user"
            End If
        End If

    xCopyDesc = String.Empty
    xCopyID = Nothing
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
    Dim dia As Form = diaLabourCopy
    Dim xReply As MsgBoxResult
    xCopyDesc = Me.ComboBox2.Text
    dia.ShowDialog()

    If dia.DialogResult = Windows.Forms.DialogResult.OK Then
    'Check if the copied to product contains values
    Dim xCheckValue As String = MiscCode.GetValueonID(xCopyID, "fk_tblProduct", "tblProdLink", "fk_tblProduct")
    If String.IsNullOrEmpty(xCheckValue) = False Then
    xReply = MiscCode.DisplayError("008")
    End If
            If xReply = MsgBoxResult.Ok Or String.IsNullOrEmpty(xCheckValue) = True Then
                If dia.DialogResult = Windows.Forms.DialogResult.OK Then
                For Each xRow As DataGridViewRow In Me.dgvProductLink.Rows
                    If xRow.Selected = True Then
                            Dim xEffPer As Double = MiscCode.GetEffPer(xRow.Cells("Fk_tblDept").Value)
                            Me.TblProdLinkTableAdapter.Insert(xCopyID, Nothing, xRow.Cells("Fk_tblDept").Value, xRow.Cells("FktblElementDataGridViewTextBoxColumn").Value, xRow.Cells("FktblActivityDataGridViewTextBoxColumn").Value, 0, xRow.Cells("DblValueDataGridViewTextBoxColumn").Value, xRow.Cells("TxtValueDescDataGridViewTextBoxColumn").Value, xRow.Cells("DblFreqDataGridViewTextBoxColumn").Value, MiscCode.MNS((xRow.Cells("txtLabourParameter").Value)), _
                                                              xRow.Cells("dblLabourCost").Value, MiscCode.GetLabourHours(xRow.Cells("TxtValueDescDataGridViewTextBoxColumn").Value, xRow.Cells("DblValueDataGridViewTextBoxColumn").Value), MiscCode.GetLabourHours(xRow.Cells("TxtValueDescDataGridViewTextBoxColumn").Value, xRow.Cells("DblAdjValueDataGridViewTextBoxColumn").Value), xRow.Cells("dblValue").Value / ((100 - xEffPer) * 100), xRow.Cells("dblLabourCost").Value / ((100 - xEffPer) * 100))
                            ', xRow.Cells("dblLabourCost").Value / ((100 - xEffPer) * 100)
                        End If

                Next
                Me.TblProdLinkBindingSource.EndEdit()
                Me.TblProdLinkTableAdapter.Update(Me.DsProdDB.tblProdLink)
                Me.TblProdLinkTableAdapter.Fill(Me.DsProdDB.tblProdLink)
                Me.TblProdLinkBindingSource.Filter = "FK_tblProduct = " & xCopyID
                Me.ComboBox2.SelectedValue = xCopyID
                My.Forms.ApplicationStartupForm.ss1.Text = "Selected values copied from " & xCopyDesc
            Else
                My.Forms.ApplicationStartupForm.ss1.Text = "Operation cancelled by user"
                End If
            End If

    End If
    xCopyDesc = String.Empty
    xCopyID = Nothing
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
    If sender Is Nothing Then Exit Sub
    Dim xMatLinkID As Integer
    xMatLinkID = Me.TblProdLinkBindingSource.Current.row.Item("id_TblProdLink")
    Me.TblProdLinkBindingSource.Current.row.delete()
    Me.Validate()
    Me.TblProdLinkBindingSource.EndEdit()
    Me.TblProdLinkTableAdapter.Update(Me.DsProdDB.tblProdLink)
    My.Forms.ApplicationStartupForm.ss1.Text = "Record No " & xMatLinkID & " deleted"
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
    My.Forms.ApplicationStartupForm.ss1.Text = String.Empty
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
    Dim xSelectTab As String = Me.TabControl1.SelectedTab.Text

    Select xSelectTab
    Case "Activities"
    Me.DsActivityDB1.RejectChanges()
    Me.DataGridView3.Refresh()
    Case "Operational Staff"
    Me.DsProdDB.RejectChanges()
    Me.DataGridView1.Refresh()
    End Select

    End Sub

    Private Sub FilldgvLabStandard(ByVal xProdID As Integer)

        Me.TblProdLinkTableAdapter.Fill(Me.DsProdDB.tblProdLink)

        'Reset any filters if they exist
        Me.TblDeptBindingSource.Filter = Nothing
        Me.TblElementBindingSource.Filter = Nothing
        Me.TblActivityBindingSource.Filter = Nothing
        Me.TblProdLinkBindingSource.Filter = Nothing

        'Populate the temporary dataset for use in the Datagrid
        tmpDS = Me.DsProdDB.Clone


        ' Dim xProdID As Integer = Me.ComboBox2.SelectedValue
        If RadioButton1.Checked = True Then
            Me.TblProdLinkBindingSource.Filter = "fk_tblProduct = " & xProdID
        Else
            Me.TblProdLinkBindingSource.Filter = "fk_tblMaterial = " & xProdID
        End If


        Me.dgvProductLink.Visible = True
        Me.dgvProductLink.Invalidate()
        Me.dgvProductLink.Refresh()
    End Sub

    Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
        Me.Close()
    End Sub

    Private Sub TabPage1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TabPage1.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub TabPage1s_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage1.Resize


        MiscCode.ResizeGrid(Me.dgv_JobTitle)
        Me.Invalidate()

    End Sub

    Private Sub TabPage1_Enter(sender As Object, e As System.EventArgs) Handles TabPage1.Enter

        Me.TblJobTitleTableAdapter1.Fill(Me.DsProdDB.tblJobTitle)
        Me.TblJobTitleBindingSource.Sort = "FK_tblDeptID"
        Me.dgv_JobTitle.Columns(0).Visible = False
        Me.dgv_JobTitle.AllowUserToAddRows = False


    End Sub
    
    Private Sub dgv_JobTitle_Validated(sender As Object, e As System.EventArgs) Handles dgv_JobTitle.Validated
        Try
            Me.Validate()
            Me.TblJobTitleBindingSource.EndEdit()
            Me.TblJobTitleTableAdapter1.Update(Me.DsProdDB.tblJobTitle)
        Catch ex As Exception
            MsgBox("Error encountered when trying to update record", , My.Settings.SysName)
        End Try

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton1.Checked = True Then
            If Len(Me.Tag) = 0 Then
                Me.TblProductTableAdapter.FillByComboInfo(Me.DsProdDB.tblProduct)
                Me.ComboBox2.DataSource = Me.DsProdDB.tblProduct
                Me.ComboBox2.DisplayMember = "ComboInfo"
                Me.ComboBox2.ValueMember = "idtblProduct"
                Me.TblProdLinkBindingSource.Filter = "FK_tblProduct = " & 0
                Me.dgvProductLink.Visible = True
            Else

                Me.TblProductTableAdapter.FillByComboInfo(Me.DsProdDB.tblProduct)
                Me.ComboBox2.DataSource = Me.DsProdDB.tblProduct
                Me.ComboBox2.DisplayMember = "ComboInfo"
                Me.ComboBox2.ValueMember = "idtblProduct"
                Me.ComboBox2.SelectedValue = Me.Tag
                FilldgvLabStandard(Me.Tag)
            End If
        Else
            Me.TblMaterialTableAdapter1.FillByComponent(Me.DsProdDB.tblMaterial)
            Me.ComboBox2.DataSource = Me.DsProdDB.tblMaterial
            Me.ComboBox2.DisplayMember = "Column1"
            Me.ComboBox2.ValueMember = "id_tblMaterial"

            If Me.dgvProductLink.Rows.Count > 0 Then Me.dgvProductLink.DataSource = Nothing 'Me.dgvProductLink.Rows.Clear()

            End If
    End Sub


End Class
Module StaffVariables
Public xStaffToolstrip As Object
Public xLabourLinkID As Integer
End Module