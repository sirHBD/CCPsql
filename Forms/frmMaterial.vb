Public Class frmMaterial

    Private Sub frmMaterial_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    My.Forms.ApplicationStartupForm.ss1.Text = String.Empty
    End Sub

    Private Sub frmMaterial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.Text = My.Settings.SysName & " - " & "Materials"

    'TODO: This line of code loads data into the 'DsMatDB.tblMaterial' table. You can move, or remove it, as needed.
    Me.TblMaterialTableAdapter.Fill(Me.DsMatDB.tblMaterial)
    Me.DataGridView2.BackgroundColor = myGBColor
        Me.dgvMaterial.BackgroundColor = myGBColor
        Me.DataGridView3.BackgroundColor = myGBColor
        Me.dgvComponent.BackgroundColor = myGBColor
        Me.IdtblMatLinkDataGridViewTextBoxColumn.Visible = False

        Me.dgvComponent.Location = New Point(2, 4)
        Me.dgvComponent.Anchor = AnchorStyles.Top
        Me.dgvComponent.Anchor = AnchorStyles.Left
        Me.dgvComponent.Anchor = AnchorStyles.Right
        Me.dgvComponent.Anchor = AnchorStyles.Bottom
        Me.dgvComponent.Height = 412
        Me.dgvComponent.Width = 869

    End Sub

    Private Sub frmMaterial_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)

    End Sub

    Private Sub frmMaterial_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Invalidate()

    End Sub

    Private Sub TabPage_MatDet_Enter(sender As Object, e As System.EventArgs) Handles TabPage_MatDet.Enter
        Me.TblMaterialTableAdapter.Fill(Me.DsMatDB.tblMaterial)
    End Sub

    Private Sub TabPage_MatDet_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TabPage_MatDet.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
        MiscCode.ResizeGrid(Me.dgvMaterial)
    End Sub

    Private Sub TabPage_MatStan_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TabPage_MatStan.Paint
        Me.IdtblMatLinkDataGridViewTextBoxColumn.Visible = False

        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)

        'Dim xRec As New Rectangle

        'ControlPaint.DrawComboButton(e.Graphics, New Rectangle(50, 10, 20, 20), ButtonState.Normal)

    End Sub

    Private Sub TabPage_MatAct_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TabPage_MatAct.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub TabPage_ProdMatDet_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage_MatDet.Resize
        Me.Invalidate()

    End Sub

    Private Sub TabPage_MatStan_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage_MatStan.Enter

        Me.TblMatLinkTableAdapter.Fill(Me.DsMatDB.tblMatLink)
        Me.TblProductTableAdapter2.FillByComboInfo(Me.DsProdDB1.tblProduct)

        If Me.DsProdDB1.tblProduct.Rows.Count = 0 Then Exit Sub

        If Len(Me.Tag) = 0 Then
            Dim xProdId As Integer = Me.DsProdDB1.tblProduct.Rows(0).Item("idtblProduct")
            Me.ComboBox2.DataSource = Me.DsProdDB1.tblProduct
            Me.ComboBox2.DisplayMember = "ComboInfo"
            Me.ComboBox2.ValueMember = "idtblProduct"
            Me.ComboBox2.SelectedIndex = 0
            xComboID = Me.ComboBox2.SelectedValue

            Me.tblMatLinkBindingsource.Filter = "fk_tblProduct = " & xProdId
        Else
            Dim xProdId As Integer = Me.Tag
            Me.ComboBox2.DataSource = Me.DsProdDB1.tblProduct
            Me.ComboBox2.DisplayMember = "ComboInfo"
            Me.ComboBox2.ValueMember = "idtblProduct"
            Me.ComboBox2.SelectedValue = xProdId


            Me.tblMatLinkBindingsource.Filter = "fk_tblProduct = " & xProdId
        End If

        

    End Sub

    Private Sub TabPage_ProdMatAct_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage_MatAct.Resize
        Me.Invalidate()
    End Sub

    Private Sub dgvMaterial_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvMaterial.CellValidating

    If Me.dgvMaterial.CurrentRow Is Nothing Then Exit Sub

    Dim Thisview As DataGridView = CType(sender, DataGridView)
    Dim ThisCell As DataGridViewCell = sender.CurrentCell

    Dim xCellCol As Integer = Me.dgvMaterial.CurrentCell.ColumnIndex
    Dim xCellName As String = Me.dgvMaterial.Columns(xCellCol).Name
    Dim xCell As DataGridViewCell = Me.dgvMaterial.CurrentCell

    If xCellName = "TxtMaterialNoDataGridViewTextBoxColumn" Or _
    xCellName = "TxtMaterialDescDataGridViewTextBoxColumn" Or _
    xCellName = "DblMaterialPriceDataGridViewTextBoxColumn" _
    Or xCellName = "TxtMaterialUnitDataGridViewTextBoxColumn" Then
    Dim xCellValue As String = ThisCell.EditedFormattedValue
        If MiscCode.IsMandatoryOK(MiscCode.MNS(xCellValue)) = True Then
        Thisview.Rows(e.RowIndex).Cells(e.ColumnIndex).ErrorText = ""
        Else
        Thisview.Rows(e.RowIndex).Cells(e.ColumnIndex).ErrorText = "Mandatory Field"
        End If
    End If
    End Sub

    Private Sub dgvMaterial_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvMaterial.DataError
        MsgBox("A data error occured - " & e.Context.ToString, , My.Settings.SysName)

        If e.Context = DataGridViewDataErrorContexts.Commit Then
            MsgBox("Commit error")
            e.ThrowException = False
        End If

        If e.Context = DataGridViewDataErrorContexts.CurrentCellChange Then
            MsgBox("Cell Change")
        End If

        If e.Context = DataGridViewDataErrorContexts.Display Then
            MsgBox("Display error", , My.Settings.SysName)
            e.ThrowException = False
        End If


        If (TypeOf (e.Exception) Is ConstraintException) Then
            Dim view As DataGridView = CType(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "DataError"
            e.ThrowException = False
        End If
    End Sub

    Private Sub dgvMaterial_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvMaterial.Resize
            Me.dgvMaterial.Invalidate()
            MiscCode.ResizeGrid(Me.dgvMaterial)
    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectionChangeCommitted
    Me.IdtblMatLinkDataGridViewTextBoxColumn.Visible = False
    Dim xProductId As Integer = Me.ComboBox2.SelectedValue
    xComboID = xProductId
        Me.tblMatLinkBindingsource.Filter = "FK_tblProduct = " & xProductId


    Me.DataGridView2.Visible = True
    Me.DataGridView2.Refresh()
    End Sub

    Private Sub dgvMaterial_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMaterial.RowLeave

    'Determine if changes exist


    Me.Validate()

    'Check to determine if there are errors
    'Not working must check
        Dim xErr As Boolean = False
        For Each ctrl As Control In Me.dgvMaterial.Controls
            If Len(Me.dgvErr.GetError(ctrl)) > 0 Then
            xErr = True
            End If
        Next

    Dim xHasChanges As Object = Me.DsMatDB.tblMaterial.GetChanges
    If xHasChanges Is Nothing Then Exit Sub

        If xErr = False Then
            'First delete the record form the material link table
            For Each dr As DataRow In Me.DsMatDB.tblMaterial.Rows
                If dr.RowState = DataRowState.Deleted Then
                Dim xOldID As Integer = dr("id_tblMaterial", DataRowVersion.Original)
                Me.TblMatLinkTableAdapter.DeletePerMaterial(xOldID)
                End If
            Next
            Me.tblMatLinkBindingsource.EndEdit()
            Me.TblMatLinkTableAdapter.Update(Me.DsMatDB.tblMatLink)

        'Now do the update or deletion of the material tables
        Me.Validate()
        Me.TblMaterialBindingSource.EndEdit()
        Me.TblMaterialTableAdapter.Update(Me.DsMatDB.tblMaterial)
        'MsgBox("Record Saved", , My.Settings.SysName & " Message System")
        Me.DsMatDB.AcceptChanges()
                If Len(Me.TblMaterialBindingSource.Filter) > 0 Then
                Me.TblMaterialBindingSource.RemoveFilter()
                End If
            Else
            MsgBox("Could not save due to errors", , My.Settings.SysName & " Error System")
            End If

    End Sub

    Private Sub TabControl1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Resize

    Me.Invalidate()

    End Sub

    Private Sub TabPage_MatStan_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage_MatStan.SizeChanged
    ''Now move the controls resize the controls to fill the screen
    'Dim xCtrlWidth As Integer = Me.TabPage_MatStan.Width
    'Dim xCtrlHeight As Integer = Me.TabPage_MatStan.Height
    'Dim xPanWith As Integer = Me.GroupBox1.Width
    'Dim xStart As Integer = xCtrlWidth - Me.GroupBox1.Width
    'Me.GroupBox1.Location = New Point(xStart, Me.GroupBox1.Location.Y)
    'Me.Panel1.Location = New Point(xStart, Me.Panel1.Location.Y)
    'Me.DataGridView2.Width = xCtrlWidth - Me.Panel1.Width - 10
    ''Me.DataGridView2.Columns("IdtblMatLinkDataGridViewTextBoxColumn").Visible = False
    'MiscCode.ResizeGrid(Me.DataGridView2)
    ''Me.TabPage_MatStan.Refresh()
    End Sub

    Private Sub tblMatLinkBindingsource_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tblMatLinkBindingsource.CurrentItemChanged
    If sender Is Nothing Or sender.current Is Nothing Then Exit Sub
    xMatID = Me.tblMatLinkBindingsource.Current.row.Item("FK_TblMaterial")
    End Sub

    Private Sub btnDelMatLink_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    If sender Is Nothing Then Exit Sub
    Dim xMatLinkID As Integer
    xMatLinkID = Me.tblMatLinkBindingsource.Current.row.Item("id_TblMatLink")
    Me.tblMatLinkBindingsource.Current.row.delete()
    Me.Validate()
    Me.tblMatLinkBindingsource.EndEdit()
    Me.TblMatLinkTableAdapter.Update(Me.DsMatDB.tblMatLink)
    My.Forms.ApplicationStartupForm.ss1.Text = "Record No " & xMatLinkID & " deleted"
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
    Dim dia As Form = dMaterialCopy
    xCopyDesc = Me.ComboBox2.Text
    dia.ShowDialog()
    Dim xReply As MsgBoxResult

        If dia.DialogResult = Windows.Forms.DialogResult.OK Then
        'Check if the copied to product contains values
        Dim xCheckValue As String = MiscCode.GetValueonID(xCopyID, "fk_tblProduct", "tblMatLink", "fk_tblProduct")
        If String.IsNullOrEmpty(xCheckValue) = False Then
        xReply = MiscCode.DisplayError("008")
        End If
            If xReply = MsgBoxResult.Yes Or String.IsNullOrEmpty(xCheckValue) = True Then
                For Each xRow As DataGridViewRow In Me.DataGridView2.Rows
                    Try
                        Me.TblMatLinkTableAdapter.Insert(xCopyID, xRow.Cells("FktblMaterialDataGridViewTextBoxColumn").Value, xRow.Cells("DblMatQtyDataGridViewTextBoxColumn").Value, xRow.Cells("DblMatCostDataGridViewTextBoxColumn").Value, xRow.Cells("dgv_dblWasteFactor").Value)
                    Catch ex As Exception
                        MsgBox("An error occured during the copy process.  Something is wrong with the data.  Investigate and retry", MsgBoxStyle.Information, My.Settings.SysName)
                    End Try

                Next

            Me.tblMatLinkBindingsource.EndEdit()
            Me.TblMatLinkTableAdapter.Update(Me.DsMatDB.tblMatLink)
            Me.TblMatLinkTableAdapter.Fill(Me.DsMatDB.tblMatLink)
            Me.tblMatLinkBindingsource.Filter = "FK_tblProduct = " & xCopyID
            Me.ComboBox2.SelectedValue = xCopyID
            Me.DataGridView2.Refresh()
            My.Forms.ApplicationStartupForm.ss1.Text = "Values copied from " & xCopyDesc
            Else
            My.Forms.ApplicationStartupForm.ss1.Text = "Operation cancelled by user"
            End If
        End If

    xCopyDesc = String.Empty
    xCopyID = Nothing
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
    Dim dia As Form = dMaterialCopy
    Dim xReply As MsgBoxResult
    xCopyDesc = Me.ComboBox2.Text
    dia.ShowDialog()

    If dia.DialogResult = Windows.Forms.DialogResult.OK Then
    'Check if the copied to product contains values
    Dim xCheckValue As String = MiscCode.GetValueonID(xCopyID, "fk_tblProduct", "tblMatLink", "fk_tblProduct")
    If String.IsNullOrEmpty(xCheckValue) = False Then
    xReply = MiscCode.DisplayError("008")
    End If
            If xReply = MsgBoxResult.Yes Or String.IsNullOrEmpty(xCheckValue) = True Then
                If dia.DialogResult = Windows.Forms.DialogResult.OK Then
                For Each xRow As DataGridViewRow In Me.DataGridView2.Rows
                    If xRow.Selected = True Then
                            Me.TblMatLinkTableAdapter.Insert(xCopyID, xRow.Cells("FktblMaterialDataGridViewTextBoxColumn").Value, xRow.Cells("DblMatQtyDataGridViewTextBoxColumn").Value, xRow.Cells("DblMatCostDataGridViewTextBoxColumn").Value, xRow.Cells("dgv_dblWasteFactor").Value)
                    End If

                Next
                Me.tblMatLinkBindingsource.EndEdit()
                Me.TblMatLinkTableAdapter.Update(Me.DsMatDB.tblMatLink)
                Me.TblMatLinkTableAdapter.Fill(Me.DsMatDB.tblMatLink)
                Me.tblMatLinkBindingsource.Filter = "FK_tblProduct = " & xCopyID
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

    Private Sub ToolStripMenuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
    btnDelMatLink_Click(Me.DataGridView2, Nothing)
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click

    If sender Is Nothing Then Exit Sub
    Dim xDelID As Integer
    xDelID = Me.TblMaterialBindingSource.Current.row.Item("id_TblMaterial")
    Me.TblMaterialBindingSource.Current.row.delete()

    Me.DsMatDB.AcceptChanges()
    Me.dgvMaterial.Refresh()
    My.Forms.ApplicationStartupForm.ss1.Text = "Record No " & xDelID & " deleted"
    End Sub

    Private Sub DataGridView2_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView2.DataError

        'Validate that no materials were deleted
        For Each xRow As DataRow In Me.DsMatDB.tblMatLink.Rows
            Try
                Dim x As Integer = Me.TblMaterialBindingSource.Find("id_tblMaterial", xRow("FK_tblMaterial"))
                If x = -1 Then
                    Dim xProdID As Integer = xRow("FK_tblProduct")
                    Dim strSQL As String = "Delete from tblMatLink where FK_tblMaterial = " & xRow("FK_tblMaterial")
                    Dim xCon As New SqlClient.SqlConnection(My.Settings.ConnectionString1)
                    Dim xComm As New SqlClient.SqlCommand(strSQL, xCon)
                    xCon.Open()
                    xComm.ExecuteNonQuery()
                    xCon.Close()

                    Me.TblMatLinkTableAdapter.Fill(Me.DsMatDB.tblMatLink)
                    Me.tblMatLinkBindingsource.ResetBindings(False)
                    Me.tblMatLinkBindingsource.Filter = "fk_tblProduct = " & xProdID
                End If
            Catch ex As Exception
                e.Cancel = True
                MsgBox("The product was linked to material that no longer exist.  The link was removed", , My.Settings.SysName)
            Finally
                'MsgBox("The product was linked to material that no longer exist.  The link was removed", , My.Settings.SysName)
            End Try

        Next

        MsgBox("A data error occured - " & e.Context.ToString, , My.Settings.SysName)

    If e.Context = DataGridViewDataErrorContexts.Commit Then
    MsgBox("Commit error")
    e.ThrowException = False
    End If

    If e.Context = DataGridViewDataErrorContexts.CurrentCellChange Then
    MsgBox("Cell Change")
    End If

    If e.Context = DataGridViewDataErrorContexts.Display Then
    MsgBox("Display error", , My.Settings.SysName)
    e.ThrowException = False
    End If


    If (TypeOf (e.Exception) Is ConstraintException) Then
    Dim view As DataGridView = CType(sender, DataGridView)
    view.Rows(e.RowIndex).ErrorText = "DataError"
    e.ThrowException = False
    End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
    Dim xSelectTab As String = Me.TabControl1.SelectedTab.Text

    Select Case xSelectTab
    Case "Material Detail"
        Dim dia As Form = diaMatAdd
        xToolStrip = sender
        dia.ShowDialog()

        If dia.DialogResult = DialogResult.OK Then
        Me.TblMaterialBindingSource.EndEdit()
        Me.TblMaterialTableAdapter.Fill(Me.DsMatDB.tblMaterial)
        Me.dgvMaterial.Refresh()
        End If
        dia.Close()

    Case "Material Standard"
        Dim dia As Form = diaMatLink
        xToolStrip = sender
        dia.Text = "Add a new Material Link"
        dia.ShowDialog()

        If dia.DialogResult = DialogResult.OK Then
        Me.tblMatLinkBindingsource.EndEdit()
        Me.TblMatLinkTableAdapter.Fill(Me.DsMatDB.tblMatLink)
        Me.DataGridView2.Refresh()
        End If
                dia.Close()

            Case "Component Detail"
                Me.TblMaterialTableAdapter.Fill(Me.DsMatDB.tblMaterial)
                Me.ListBox1.ClearSelected()
                Me.dgvComponent.Visible = False
                Me.GroupBox1.Visible = True
                Me.GroupBox2.Visible = True
                Me.lblFormStatus.Text = "Insert"

        End Select

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim xSelectTab As String = Me.TabControl1.SelectedTab.Text

    Select xSelectTab
            Case "Component Detail"
                If Me.lblFormStatus.Text = "Insert" Then
                    SaveComponent()
                Else
                    UpdateComponent()
                End If

                Me.GroupBox1.Visible = False
                Me.GroupBox2.Visible = False
                Me.TblMaterialTableAdapter.FillByComponentOnly(Me.DsMatDB.tblMaterial)
                Me.dgvComponent.Visible = True
            Case Else
                My.Forms.ApplicationStartupForm.ss1.Text = "All records saved"
        End Select

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
    Dim xSelectTab As String = Me.TabControl1.SelectedTab.Text

    Select Case xSelectTab
        Case "Material Detail"
        Me.DsMatDB.RejectChanges()
        Me.dgvMaterial.Refresh()
        My.Forms.ApplicationStartupForm.ss1.Text = "Unsaved changes rejected by user"

        Case "Material Standard"
        Me.DsMatDB.RejectChanges()
        Me.DataGridView2.Refresh()
                My.Forms.ApplicationStartupForm.ss1.Text = "Unsaved changes rejected by user"

            Case "Component Detail"
                Me.DsMatDB.RejectChanges()
                Me.DataGridView2.Refresh()
                My.Forms.ApplicationStartupForm.ss1.Text = "Unsaved changes rejected by user"
        End Select

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
    Me.Close()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
    My.Forms.ApplicationStartupForm.ss1.Text = String.Empty
    End Sub

    Private Sub TabPage_Component_Enter(sender As Object, e As System.EventArgs) Handles TabPage_Component.Enter
       
        Me.TblMaterialTableAdapter.FillByComponentOnly(Me.DsMatDB.tblMaterial)
        Me.GroupBox1.Visible = False
        Me.GroupBox2.Visible = False

        Me.dgvComponent.Visible = True
        Me.dgvComponent.Location = New Point(2, 4)
        Me.dgvComponent.Anchor = AnchorStyles.Top
        Me.dgvComponent.Anchor = AnchorStyles.Left
        Me.dgvComponent.Anchor = AnchorStyles.Right
        Me.dgvComponent.Anchor = AnchorStyles.Bottom
        Me.dgvComponent.Height = 412
        Me.dgvComponent.Width = 869
        Me.dgvComponent.Dock = DockStyle.Fill

        Me.Refresh()
        Me.dgvComponent.Invalidate()

    End Sub

    Private Sub TabPage_Component_Leave(sender As Object, e As System.EventArgs) Handles TabPage_Component.Leave
        Me.TblMaterialTableAdapter.Fill(Me.DsMatDB.tblMaterial)
        Me.TblMatLinkTableAdapter.Fill(Me.DsMatDB.tblMatLink)
    End Sub

    Private Sub TabPage_MatStan_Leave(sender As Object, e As System.EventArgs) Handles TabPage_MatStan.Leave
        Me.TblMaterialTableAdapter.Fill(Me.DsMatDB.tblMaterial)
        Me.TblMatLinkTableAdapter.Fill(Me.DsMatDB.tblMatLink)
    End Sub

    Private Sub TabPage_Component_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles TabPage_Component.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click

        If Me.DataGridView3.Rows.Count > 0 Then
            Me.DataGridView3.Rows.Clear()
        End If

        Dim iRow As Integer
        For Each xItem As Object In ListBox1.SelectedItems
            Me.DataGridView3.Rows.Add()
            Me.DataGridView3.Rows(iRow).Cells(0).Value = xItem("id_tblMaterial")
            Me.DataGridView3.Rows(iRow).Cells(1).Value = xItem("ComboboxValue")
            Me.DataGridView3.Rows(iRow).Cells(2).Value = xItem("txtMaterialUnit")
            Me.DataGridView3.Rows(iRow).Cells(4).Value = Math.Round(xItem("dblMaterialPrice"), 4)
            iRow = iRow + 1
        Next

        MsgBox("Please enter the quantities needed for each material")

    End Sub

    Private Sub ListBox1_Enter(sender As Object, e As System.EventArgs) Handles ListBox1.Enter
        Me.ListBox1.ClearSelected()
    End Sub

    Private Sub DataGridView3_CellValidating(sender As Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DataGridView3.CellValidating
        If Me.DataGridView3.CurrentRow Is Nothing Then Exit Sub

        Dim xCell As DataGridViewCell = Me.DataGridView3.CurrentCell
        If xCell.ColumnIndex = 3 Then
            If Len(xCell.EditedFormattedValue) > 0 Then
                Me.DataGridView3.CurrentRow.Cells("dgv3_Cost").Value = Decimal.Parse(xCell.EditedFormattedValue) * Decimal.Parse(Me.DataGridView3.CurrentRow.Cells("dgv3_costPerUnit").Value)
            Else
                Me.DataGridView3.CurrentRow.Cells("dgv3_Cost").Value = 0
            End If
        End If


    End Sub

    Private Sub SaveComponent()

        'First validate that all important fields has been completed.
        Dim MyFormHasErrors As Boolean = False
        If Len(Me.TextBox1.Text) = 0 Then
            Me.TextBox1.BackColor = Color.DeepPink
            MyFormHasErrors = True
        Else
            MyFormHasErrors = False
            Me.TextBox1.BackColor = DefaultBackColor
        End If

        If Len(Me.ComboBox1.Text) = 0 Then
            Me.ComboBox1.BackColor = Color.DeepPink
        Else
            MyFormHasErrors = False
            Me.ComboBox1.BackColor = DefaultBackColor
        End If

        If Me.DataGridView3.Rows.Count = 0 Then
            MyFormHasErrors = True
            Me.DataGridView3.BackgroundColor = Color.DeepPink
        Else
            MyFormHasErrors = False
            Me.DataGridView3.BackgroundColor = myGBColor
        End If

        If MyFormHasErrors = True Then
            MsgBox("The form as errors on that needs to be corrected before it can be saved.")
            Exit Sub
        End If

        Dim strSql As String = String.Empty
        Dim xCon As New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        Dim xComm As New SqlClient.SqlCommand(strSql, xCon)
        Dim xNewId As Integer

        Try
            Dim xCost As Decimal
            For Each yRow As DataGridViewRow In Me.DataGridView3.Rows
                xCost = xCost + Decimal.Parse(yRow.Cells("dgv3_Cost").Value)
            Next
            xCost = xCost / Decimal.Parse(Me.TextBox5.Text)
            strSql = "Insert into tblMaterial Values(" & "'Component-001'" & ",'" & Me.TextBox1.Text.ToString() & "', '" & Me.ComboBox1.Text.ToString() & "', " & xCost & ", '" & Me.TextBox2.Text.ToString() & "', '" & Me.TextBox3.Text.ToString() & "', '" & Me.TextBox4.Text.ToString() & "', 'Component')" & "; Select scope_identity()"
            xComm.CommandText = strSql

            xCon.Open()
            xNewId = xComm.ExecuteScalar()
        Catch ex As Exception
            MsgBox("Could not save the material" & vbCrLf & ex.Message.ToString)
            xCon.Close()
            Exit Sub
        End Try


        Try
            For Each xRow As DataGridViewRow In Me.DataGridView3.Rows
                Dim xMatLink As Integer = Integer.Parse(xRow.Cells(0).Value)
                strSql = "Select * from tblMaterial where id_tblMaterial = " & xMatLink
                Dim ds As New DataSet
                Dim xAdap1 As New SqlClient.SqlDataAdapter(strSql, xCon)
                xAdap1.Fill(ds, "Mat")
                If ds.Tables("Mat").Rows.Count > 0 Then
                    strSql = "Insert into tblComponent Values(" & xNewId & "," & xMatLink & ",'" & ds.Tables("Mat").Rows(0).Item("txtMaterialNo").ToString() & "','" & ds.Tables("Mat").Rows(0).Item("txtMaterialDesc").ToString() & "', '" & ds.Tables("Mat").Rows(0).Item("txtMaterialUnit").ToString() & "', " & Decimal.Parse(ds.Tables("Mat").Rows(0).Item("dblMaterialPrice").ToString()) & ", '" & ds.Tables("Mat").Rows(0).Item("txtMatspec1").ToString() & "', '" & ds.Tables("Mat").Rows(0).Item("txtMatspec2").ToString() & "', '" & ds.Tables("Mat").Rows(0).Item("txtMatspec3").ToString() & "', '" & ds.Tables("Mat").Rows(0).Item("txtType").ToString() & "'," & Decimal.Parse(Me.TextBox5.Text) & ", " & Decimal.Parse(xRow.Cells(3).Value) & "," & Decimal.Parse(xRow.Cells(5).Value) & ", '" & Me.ComboBox1.Text.ToString() & "')"
                    xComm.CommandText = strSql
                    xComm.ExecuteNonQuery()
                End If

            Next
            xCon.Close()
        Catch ex As Exception
            MsgBox("Could not save the component - rolling back" & vbCrLf & ex.Message.ToString)
            strSql = "Delete from tblMaterial where id_tblMaterial = " & xNewId
            xComm.CommandText = strSql
            xComm.ExecuteNonQuery()
            xCon.Close()
            Exit Sub
        End Try



        xCon.Close()

        'Clear all controls
        For Each c As Windows.Forms.Control In GroupBox1.Controls
            c.Text = String.Empty
        Next
        Me.TextBox5.Text = "1"
        Me.DataGridView3.Rows.Clear()



    End Sub

    Private Sub UpdateComponent()

        'First validate that all important fields has been completed.
        Dim MyFormHasErrors As Boolean = False
        If Len(Me.TextBox1.Text) = 0 Then
            Me.TextBox1.BackColor = Color.DeepPink
            MyFormHasErrors = True
        Else
            MyFormHasErrors = False
            Me.TextBox1.BackColor = DefaultBackColor
        End If

        If Len(Me.ComboBox1.Text) = 0 Then
            Me.ComboBox1.BackColor = Color.DeepPink
        Else
            MyFormHasErrors = False
            Me.ComboBox1.BackColor = DefaultBackColor
        End If

        If Me.DataGridView3.Rows.Count = 0 Then
            MyFormHasErrors = True
            Me.DataGridView3.BackgroundColor = Color.DeepPink
        Else
            MyFormHasErrors = False
            Me.DataGridView3.BackgroundColor = myGBColor
        End If

        If MyFormHasErrors = True Then
            MsgBox("The form as errors on that needs to be corrected before it can be saved.")
            Exit Sub
        End If

        Dim strSql As String = String.Empty
        Dim xCon As New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        Dim xComm As New SqlClient.SqlCommand(strSql, xCon)
        Dim xMaterialId As Integer = Me.lblMaterialID.Text

        Try
            Dim xCost As Decimal
            For Each yRow As DataGridViewRow In Me.DataGridView3.Rows
                xCost = xCost + Decimal.Parse(yRow.Cells("dgv3_Cost").Value)
            Next
            xCost = xCost / Decimal.Parse(Me.TextBox5.Text)
            strSql = "Update tblMaterial Set txtMaterialDesc = '" & Me.TextBox1.Text.ToString() & "', txtMaterialUnit = '" & Me.ComboBox1.Text.ToString() & "', dblMaterialPrice = " & xCost & ", txtMatSpec1 = '" & Me.TextBox2.Text.ToString() & "', txtMatSpec2 = '" & Me.TextBox3.Text.ToString() & "', txtMatSpec3 = '" & Me.TextBox4.Text.ToString() & "' where id_tblMaterial = " & xMaterialId
            xComm.CommandText = strSql

            xCon.Open()
            xComm.ExecuteScalar()
        Catch ex As Exception
            MsgBox("Could not save the material" & vbCrLf & ex.Message.ToString)
            xCon.Close()
            Exit Sub
        End Try


        Try
            For Each xRow As DataGridViewRow In Me.DataGridView3.Rows
                Dim xMatLink As Integer = Integer.Parse(xRow.Cells(6).Value)
                strSql = "Select * from tblMaterial where id_tblMaterial = " & xMatLink
                Dim ds As New DataSet
                Dim xAdap1 As New SqlClient.SqlDataAdapter(strSql, xCon)
                xAdap1.Fill(ds, "Mat")
                'If ds.Tables("Mat").Rows.Count > 0 Then
                strSql = "Update tblComponent set FK_ComponentLinkID = " & xMaterialId & ", FK_MaterialLinkID = " & xMatLink & ", txtMaterialNo = '" & ds.Tables("Mat").Rows(0).Item("txtMaterialNo").ToString() & "', txtMaterialDesc = '" & ds.Tables("Mat").Rows(0).Item("txtMaterialDesc").ToString() & "', txtMaterialUnit = '" & ds.Tables("Mat").Rows(0).Item("txtMaterialUnit").ToString() & "', dblMaterialPrice = " & Decimal.Parse(ds.Tables("Mat").Rows(0).Item("dblMaterialPrice").ToString()) & ", txtMatSpec1 = '" & ds.Tables("Mat").Rows(0).Item("txtMatspec1").ToString() & "', txtMatSpec2 = '" & ds.Tables("Mat").Rows(0).Item("txtMatspec2").ToString() & "', txtMatSpec3 = '" & ds.Tables("Mat").Rows(0).Item("txtMatspec3").ToString() & "', txtType = '" & ds.Tables("Mat").Rows(0).Item("txtType").ToString() & "', dblBatchSize = " & Decimal.Parse(Me.TextBox5.Text) & ", dblCompQty = " & Decimal.Parse(xRow.Cells(3).Value) & ", dblCompCost = " & Decimal.Parse(xRow.Cells(5).Value) & ", txtBatchUOM = '" & Me.ComboBox1.Text.ToString() & "' where id_tblComponent = " & xRow.Cells(0).Value
                xComm.CommandText = strSql
                xComm.ExecuteNonQuery()
                'End If

            Next
            xCon.Close()
        Catch ex As Exception
            MsgBox("Could not save the component - rolling back" & vbCrLf & ex.Message.ToString)
            strSql = "Delete from tblMaterial where id_tblMaterial = " & xNewId
            xComm.CommandText = strSql
            xComm.ExecuteNonQuery()
            xCon.Close()
            Exit Sub
        End Try



        xCon.Close()

        'Clear all controls
        For Each c As Windows.Forms.Control In GroupBox1.Controls
            c.Text = String.Empty
        Next
        Me.TextBox5.Text = "1"
        Me.DataGridView3.Rows.Clear()



    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As System.EventArgs) Handles ToolStripButton2.Click

        Dim xSelectTab As String = Me.TabControl1.SelectedTab.Text

        Select Case xSelectTab
            Case "Material Detail"
                Dim dia As Form = diaMatAdd
                xToolStrip = sender
                xCopyID = Me.dgvMaterial.CurrentRow.Cells("IdtblMaterialDataGridViewTextBoxColumn").Value
                If Me.dgvMaterial.CurrentRow.Cells("txtType").Value = "Component" Then
                    MsgBox("Please edit components in the Component tab", , My.Settings.SysName)
                    Exit Sub
                End If
                dia.ShowDialog()

                If dia.DialogResult = DialogResult.OK Then
                    Me.TblMaterialBindingSource.EndEdit()
                    Me.TblMaterialTableAdapter.Fill(Me.DsMatDB.tblMaterial)
                    If Len(Me.TblMaterialBindingSource.Filter) > 0 Then
                        Me.TblMaterialBindingSource.RemoveFilter()
                    End If
                    Me.dgvMaterial.Refresh()
                End If

                xCopyID = Nothing

            Case "Material Standard"
                Dim dia As Form = diaMatLink
                xToolStrip = sender
                dia.Text = "Edit Material Link"
                xComboID = Me.tblMatLinkBindingsource.Current.row.item("Fk_tblProduct")
                xMatLinkID = Me.tblMatLinkBindingsource.Current.row.item("id_tblMatLink")
                dia.ShowDialog()

                If dia.DialogResult = DialogResult.OK Then
                    Me.tblMatLinkBindingsource.EndEdit()
                    Me.TblMatLinkTableAdapter.Fill(Me.DsMatDB.tblMatLink)
                    Me.DataGridView2.Refresh()
                End If


            Case "Component Detail"

                If Me.DataGridView3.Rows.Count > 0 Then Me.DataGridView3.Rows.Clear()

                Dim xCompID As Integer = Integer.Parse(Me.dgvComponent.CurrentRow.Cells("DataGridViewTextBoxColumn1").Value)
                Me.dgvComponent.Visible = False
                Me.GroupBox1.Visible = True
                Me.GroupBox2.Visible = True
                Me.lblMaterialID.Text = xCompID

                Me.DsMatDB.EnforceConstraints = False
                Me.TblComponentTableAdapter1.FillByComponentLinkID(Me.DsMatDB.tblComponent, xCompID)
                Me.TblMaterialTableAdapter.Fill(Me.DsMatDB.tblMaterial)
                Me.TblMaterialBindingSource.Filter = "id_tblMaterial = " & xCompID

                Me.TextBox1.Text = Me.TblMaterialBindingSource.Current.row.item("txtMaterialDesc").ToString()
                Me.TextBox2.Text = Me.TblMaterialBindingSource.Current.row.item("txtMatSpec1").ToString()
                Me.TextBox3.Text = Me.TblMaterialBindingSource.Current.row.item("txtMatSpec2").ToString()
                Me.TextBox4.Text = Me.TblMaterialBindingSource.Current.row.item("txtMatSpec3").ToString()
                Me.ComboBox1.SelectedItem = Me.TblMaterialBindingSource.Current.row.item("txtMaterialUnit").ToString()
                Me.TextBox5.Text = Me.DsMatDB.tblComponent.Rows(0).Item("dblBatchSize").ToString()

                'Fill the datagrid
                Dim i As Integer
                For Each xRow As DataRow In Me.DsMatDB.tblComponent.Rows
                    Me.DataGridView3.Rows.Add()
                    Me.DataGridView3.Rows(i).Cells(0).Value = xRow.Item(0)
                    Me.DataGridView3.Rows(i).Cells(1).Value = xRow.Item(4)
                    Me.DataGridView3.Rows(i).Cells(2).Value = xRow.Item(5)
                    Me.DataGridView3.Rows(i).Cells(3).Value = xRow.Item("dblCompQty")
                    Me.DataGridView3.Rows(i).Cells(4).Value = xRow.Item("dblMaterialPrice")
                    Me.DataGridView3.Rows(i).Cells(5).Value = xRow.Item("dblCompCost")
                    Me.DataGridView3.Rows(i).Cells(6).Value = xRow.Item("FK_MaterialLinkID")
                    i = i + 1
                Next

                Me.TblMaterialBindingSource.Filter = ""
                Me.TblMaterialBindingSource.ResetBindings(False)
                Me.ListBox1.Refresh()
                Me.lblFormStatus.Text = "Update"
        End Select

    End Sub

End Class

    Module MatVariables
    Public xCopyID As Integer
    Public xCopyDesc As String
    Public xToolStrip As ToolStripButton
    Public xComboID As Integer
    Public xMatID As Integer
    Public xMatLinkID As Integer

    End Module