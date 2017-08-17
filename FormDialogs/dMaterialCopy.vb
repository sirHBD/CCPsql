Imports System.Windows.Forms

Public Class dMaterialCopy

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        xCopyID = Me.ComboBox2.SelectedValue
        Me.Label1.Text = "Copy Material Links from "
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dMaterialCopy_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Forms.ApplicationStartupForm.ss1.Text = String.Empty
        Me.Text = My.Settings.SysName & " - " & "Material Link copy"
        Me.Label1.Text = Me.Label1.Text & " " & xCopyDesc
        Me.TblProductTableAdapter1.FillByComboInfo(Me.DsProdDB1.tblProduct)
        Me.ComboBox2.DataSource = Me.DsProdDB1.tblProduct
        Me.ComboBox2.DisplayMember = "ComboInfo"
        Me.ComboBox2.ValueMember = "idtblProduct"
        Me.OK_Button.Enabled = False

    End Sub

    Private Sub dMaterialCopy_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub dMaterialCopy_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Invalidate()
    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectionChangeCommitted
        Me.OK_Button.Enabled = True
    End Sub
End Class
