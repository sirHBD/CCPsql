Imports System.Windows.Forms

Public Class dProductAdd

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Validate()
        Me.ValidateChildren()

    'Check to determine if there are errors
        Dim xErr As Boolean = False
        For Each ctrl As Control In Me.GroupBox1.Controls
            If Len(Me.ErrorProvider1.GetError(ctrl)) > 0 Then
            xErr = True
            End If
        Next

        If xErr = True Then
        My.Forms.ApplicationStartupForm.ss1.Text = "Product not added/changed due to errors"
        Me.DialogResult = DialogResult.None
            Else
            Me.BindingSource1.EndEdit()
            Try
                Me.TblProductTableAdapter1.Update(Me.DsProdDB1.tblProduct)

                If Len(Me.Tag) = 0 Then
                    My.Forms.ApplicationStartupForm.ss1.Text = "New Row added for product " & Me.txtProdCode.Text
                Else
                    My.Forms.ApplicationStartupForm.ss1.Text = "Product " & Me.txtProdCode.Text & " updated"
                End If
            Catch ex As Exception
                MsgBox("Can not enter a duplicate product code", My.Settings.SysName)
            End Try


            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dProductAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    My.Forms.ApplicationStartupForm.ss1.Text = ""
    Me.GroupBox1.BackColor = myGBColor
    Me.TblProductTableAdapter1.Fill(Me.DsProdDB1.tblProduct)
    If Len(Me.Tag) = 0 Then
    Me.BindingSource1.AddNew()
    Me.Text = My.Settings.SysName & " - " & "Add New Product"
        If MiscCode.GetCoNo() IsNot Nothing Then
        Me.txtCoID.Text = MiscCode.GetCoNo()
        Me.txtCoID.Enabled = False
        Else
        MsgBox("A company must be created before products can be registered", , My.Settings.SysName & " - Add a product")
        Me.Close()
        End If
    Else
    Me.BindingSource1.Filter = "idtblProduct = " & Me.Tag
    Me.Text = My.Settings.SysName & " - " & "Edit Product"
    End If

    End Sub

    Private Sub dProductAdd_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub dProductAdd_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Invalidate()

    End Sub

    Private Sub txtCoID_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCoID.Validating
        If MiscCode.IsMandatoryOK(sender.text) = True Then
        Me.ErrorProvider1.SetError(sender, "")
        Else
        Me.ErrorProvider1.SetError(sender, "Mandatory Field - Can not contain nothing")
        End If
    End Sub

    Private Sub txtProdCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtProdCode.Validating

        If MiscCode.IsMandatoryOK(sender.text) = True Then
        Me.ErrorProvider1.SetError(sender, "")
        Else
        Me.ErrorProvider1.SetError(sender, "Mandatory Field - Can not contain nothing")
        End If


    End Sub

    Private Sub txtProdDesc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtProdDesc.Validating
        If MiscCode.IsMandatoryOK(sender.text) = True Then
        Me.ErrorProvider1.SetError(sender, "")
        Else
        Me.ErrorProvider1.SetError(sender, "Mandatory Field - Can not contain nothing")
        End If
    End Sub

    Private Sub txtSpec1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSpec1.Validating
        If MiscCode.IsMandatoryOK(sender.text) = True Then
        Me.ErrorProvider1.SetError(sender, "")
        Else
        Me.ErrorProvider1.SetError(sender, "Mandatory Field - Can not contain nothing")
        End If
    End Sub

End Class
