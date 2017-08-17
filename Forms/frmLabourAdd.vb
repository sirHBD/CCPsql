Public Class frmLabourAdd

    Private Sub frmLabourAdd_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub frmLabourAdd_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    Me.Invalidate()
    End Sub

    Private Sub frmLabourAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    'TODO: This line of code loads data into the 'DsProdDB.tblOperation' table. You can move, or remove it, as needed.
    Me.TblOperationTableAdapter.Fill(Me.DsProdDB.tblOperation)
    Me.TblElementTableAdapter1.Fill(Me.DsProdDB.tblElement)
    Me.TblActivityTableAdapter1.Fill(Me.DsProdDB.tblActivity)

    'TODO: This line of code loads data into the 'DsProdDB.tblProdLink' table. You can move, or remove it, as needed.
    Me.TblProdLinkTableAdapter.Fill(Me.DsProdDB.tblProdLink)
    

    'Now Fill staff comboboxes
    If Me.cBox_Operator.Items.Count > 0 Then Me.cBox_Operator.Items.Clear()

        Me.TblStaffTableAdapter1.Fill(Me.DsProdDB.tblStaff)
        If Me.DsProdDB.tblStaff.Rows.Count > 0 Then
        For Each xRow As DataRow In Me.DsProdDB.tblStaff.Rows
        Me.cBox_Operator.Items.Add(xRow.Item("txtEmpName"))
        Next
        End If

        If Me.cBox_StaffGroup.Items.Count > 0 Then Me.cBox_StaffGroup.Items.Clear()

        Me.TblStaffTableAdapter1.FillByStaffCategory(Me.DsProdDB.tblStaff)
        If Me.DsProdDB.tblStaff.Rows.Count > 0 Then
        For Each xRow As DataRow In Me.DsProdDB.tblStaff.Rows
        Me.cBox_StaffGroup.Items.Add(xRow.Item("txtEmpCategory"))
        Next
        End If

    'Fill Product combo box
        Me.TblProductTableAdapter.FillByComboInfo(Me.DsProdDB.tblProduct)
        Me.ComboBox2.DataSource = Me.DsProdDB.tblProduct
        Me.ComboBox2.DisplayMember = "ComboInfo"
        Me.ComboBox2.ValueMember = "idtblProduct"
        Me.TblProdLinkBindingSource.Filter = "FK_tblProduct = " & 0
        Me.dgvProductLink.Visible = False
    End Sub

    Private Sub EditCurrentRecordToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Panel2.Visible = True

    End Sub

    Private Sub AddNewRecordToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddNewRecordToolStripMenuItem.Click
        Me.Panel2.Visible = True
        Me.TblElementTableAdapter1.Fill(Me.DsProdDB.tblElement)
        Me.PictureBox2.Enabled = False
        Me.PictureBox3.Enabled = False

        

    End Sub

    Private Sub cBox_Element_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBox_Element.SelectionChangeCommitted

    Dim xElementID As Integer = Me.cBox_Element.SelectedItem.row.id_tblElement
    Dim dsTMP As DataSet
    dsTMP = Me.DsProdDB.Copy

    Me.TblActivityTableAdapter1.FillByElementID(dsTMP.Tables("tblActivity"), xElementID)
    Me.cBox_Activity.DataSource = dsTMP.Tables("tblActivity")
    Me.PictureBox1.Enabled = False
    Me.PictureBox2.Enabled = True

    End Sub

    Private Sub cBox_Activity_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBox_Activity.SelectionChangeCommitted

    Dim xActivityID As Integer = Me.cBox_Activity.SelectedItem.row.id_tblActivity
    Me.TblOperationTableAdapter.FillByActivityID(Me.DsProdDB.tblOperation, xActivityID)
    Me.PictureBox1.Enabled = False
    Me.PictureBox2.Enabled = False
    Me.PictureBox3.Enabled = True

    End Sub

    Private Sub cBox_Operator_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBox_Operator.Enter
        If cBox_StaffGroup.Enabled = False Then cBox_StaffGroup.Enabled = True
    End Sub

    Private Sub cBox_Operator_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBox_Operator.Leave
        If Len(sender.text) > 0 Then
        Me.cBox_StaffGroup.Text = Nothing
        Me.cBox_StaffGroup.Enabled = False
        End If
    End Sub

    Private Sub cBox_StaffGroup_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBox_StaffGroup.Leave
        If Len(sender.text) = 0 And Len(Me.cBox_Operator.Text) = 0 Then
        ErrorProvider1.SetError(sender, "Both Staff Group and Operator can not be blank")
            Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Function CalcLabCost()
    Dim xEmpRate As Decimal
    Dim xEmpNum As Integer

    If Len(Me.cBox_StaffGroup.Text) > 0 Then
    Me.TblStaffTableAdapter1.Fill(Me.DsProdDB.tblStaff)
    xEmpRate = Me.DsProdDB.tblStaff.Compute("Sum(dblRateperHour)", "txtEmpCategory = " & "'" & Me.cBox_StaffGroup.Text & "'")
    xEmpNum = Me.DsProdDB.tblStaff.Compute("Count(id_tblStaff)", "txtEmpCategory = " & "'" & Me.cBox_StaffGroup.Text & "'")
    Return (xEmpRate / xEmpNum) * Me.TextBox2.Text
        Else
        Me.TblStaffTableAdapter1.Fill(Me.DsProdDB.tblStaff)
        xEmpRate = Me.DsProdDB.tblStaff.Compute("Sum(dblRateperHour)", "txtEmpName = " & "'" & Me.cBox_Operator.Text & "'")
        xEmpNum = 1
        Return (xEmpRate / xEmpNum) * Me.TextBox2.Text
    End If
    End Function

    Private Sub TextBox2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Validated
    If Len(Me.ErrorProvider1.GetError(sender)) = 0 Then

    'Now apply the calculated rate based on the time speciier
    Dim xTimeSpec As String = Me.ComboBox1.Text

  Select Case xTimeSpec
    Case "Year"
    'This calculation must be fixed
    Me.TextBox3.Text = CalcLabCost() * (360 * 8)
    Case "Month"
    'This calculation must be fixed
    Me.TextBox3.Text = CalcLabCost() * (22 * 8)
    Case "Week"
    'This calculation must be fixed
    Me.TextBox3.Text = CalcLabCost() * (22 * 8)
    Case "Day"
    'This calculation must be fixed
    Me.TextBox3.Text = CalcLabCost() * (8)
    Case "Hour"
    Me.TextBox3.Text = CalcLabCost() * CDec(Me.TextBox1.Text)
    Case "Minute"
    Me.TextBox3.Text = (CalcLabCost() / 60) * CDec(Me.TextBox1.Text)
   Case "Second"
    Me.TextBox3.Text = CalcLabCost() / (60 * 60) * CDec(Me.TextBox1.Text)
    Case Else
     Me.TextBox3.Text = 0
End Select

    End If

    Me.TextBox3.Text = Math.Round(CDec(Me.TextBox3.Text), 3)

    End Sub

    Private Sub TextBox2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox2.Validating
    If IsNumeric(Me.TextBox2.Text) Then
    Me.ErrorProvider1.SetError(sender, "")
    Else
    Me.ErrorProvider1.SetError(sender, "Must enter a numerical value")
    End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

    Me.Validate()

    'Check to determine if there are errors
        Dim xErr As Boolean = False
        For Each ctrl As Control In Me.Panel2.Controls
            If Len(Me.ErrorProvider1.GetError(ctrl)) > 0 Then
            xErr = True
            End If
        Next

    'Save if no errors exist
        If xErr = True Then
        Me.DsProdDB.RejectChanges()
        MsgBox("Could not save due to errors", , My.Settings.SysName)
        Else
        Try
        Dim xProductID As Integer = Me.ComboBox2.SelectedValue
        Dim xDeptID As Integer = 9999
        Dim xElementID As Integer = Me.cBox_Element.SelectedItem.row.id_tblElement
        Dim xActivityID As Integer = Me.cBox_Activity.SelectedItem.row.id_tblActivity
                'Me.TblProdLinkTableAdapter.insert(xProductID, xDeptID, xElementID, xActivityID, 0, CDec(Me.TextBox1.Text), Me.ComboBox1.Text, CDec(Me.TextBox2.Text), "", CDec(Me.TextBox3.Text), 0, 0)
        'Me.TblProdLinkTableAdapter.Update(DsProdDB.tblProdLink)
        Me.TblProdLinkTableAdapter.FillByProduct(Me.DsProdDB.tblProdLink, xProductID)
        Catch ex As Exception
        MsgBox("Oooops")
        End Try

        End If
    End Sub

    Private Sub dgvProductLink_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductLink.CellEndEdit
    Dim xCell As DataGridViewCell = dgvProductLink.CurrentCell
    If xCell.ColumnIndex = 2 Then
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
    Dim xProdID As Integer = Me.ComboBox2.SelectedValue
    Me.TblProdLinkBindingSource.Filter = "fk_tblProduct = " & xProdID
    Me.dgvProductLink.Visible = True
    Me.dgvProductLink.Refresh()

    End Sub
End Class