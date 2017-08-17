Imports System.Windows.Forms

Public Class diaMatAdd

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    Me.Validate()
    Me.ValidateChildren()

    'Check to determine if there are errors
        Dim xErr As Boolean = False
        For Each ctrl As Control In Me.Controls
            If Len(Me.ErrorProvider1.GetError(ctrl)) > 0 Then
            xErr = True
            End If
        Next

        If xErr = True Then
        My.Forms.ApplicationStartupForm.ss1.Text = "Errors found - Can not save"
            Else

            'Before saving check for duplicates and issue warning
            If xToolStrip.Name = "ToolStripButton1" Then
            Dim xHasRec As String
                xHasRec = MiscCode.bdQuickFind(My.Settings.ConnectionString1, "txtMaterialNo", Me.TextBox1.Text, "tblMaterial", "", "")
                If String.IsNullOrEmpty(xHasRec) = False Then
                Dim xRes As MsgBoxResult = MsgBox("Another material with this code was found.  Are you sure?", MsgBoxStyle.OkCancel, My.Settings.SysName)
                    If xRes = MsgBoxResult.Cancel Then
                    Return
                    End If
                End If
            End If


            Me.TblMaterialBindingSource.EndEdit()
            Dim xRowState As DataRowState = Me.TblMaterialBindingSource.Current.row.rowstate
                If xRowState = DataRowState.Added Then

                Me.TblMaterialTableAdapter1.Update(Me.DsMatDB.tblMaterial)
                My.Forms.ApplicationStartupForm.ss1.Text = "New Row added for product " & Me.TextBox1.Text
                End If
                If xRowState = DataRowState.Modified Then

                Me.TblMaterialTableAdapter1.Update(Me.DsMatDB.tblMaterial)
                My.Forms.ApplicationStartupForm.ss1.Text = "Product " & Me.TextBox1.Text & " modified - Now updating Material links"
                MiscCode.UpdateMaterialLinks(Me.TextBox6.Text, xCopyID)
                MiscCode.UpdateComponentLinks(Me.TextBox6.Text, xCopyID)
                End If
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub diaMatAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    My.Forms.ApplicationStartupForm.ss1.Text = String.Empty

    Me.TblMaterialTableAdapter1.Fill(Me.DsMatDB.tblMaterial)
        If xToolStrip.Name = "ToolStripButton1" Then
                If Len(Me.TblMaterialBindingSource.Filter) > 0 Then
                Me.TblMaterialBindingSource.RemoveFilter()
                End If
        Me.TblMaterialBindingSource.AddNew()
        Me.Text = My.Settings.SysName & " - " & "Add Another Material"
        End If
        If xToolStrip.Name = "ToolStripButton2" Then
        Me.TblMaterialBindingSource.Filter = "id_tblMaterial = " & xCopyID
        Me.Text = My.Settings.SysName & " - " & "Edit selected Material"
        End If
    End Sub

    Private Sub diaMatAdd_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub diaMatAdd_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Invalidate()
    End Sub

    Private Sub TextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        If MiscCode.IsMandatoryOK(sender.text) = True Then
        Me.ErrorProvider1.SetError(sender, "")
        Else
        Me.ErrorProvider1.SetError(sender, "Mandatory Field - Can not contain nothing")
        End If
    End Sub

    Private Sub TextBox2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox2.Validating
        If MiscCode.IsMandatoryOK(sender.text) = True Then
        Me.ErrorProvider1.SetError(sender, "")
        Else
        Me.ErrorProvider1.SetError(sender, "Mandatory Field - Can not contain nothing")
        End If
    End Sub

    Private Sub TextBox6_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox6.Validating
        If MiscCode.IsNumericOK(sender.text) = True Then
        Me.ErrorProvider1.SetError(sender, "")
        Else
        Me.ErrorProvider1.SetError(sender, "Mandatory Field - Can not contain nothing and must be numeric")
        End If

        
    End Sub

    Private Sub ComboBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBox1.Validating
    If MiscCode.IsMandatoryOK(sender.text) = True Then
        Me.ErrorProvider1.SetError(sender, "")
        Else
        Me.ErrorProvider1.SetError(sender, "Mandatory Field - Can not contain nothing")
        End If
    End Sub

    
End Class
