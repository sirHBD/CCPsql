Imports System.Windows.Forms

Public Class diaMatLink
Const q = "'"

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

     'Save if no errors exist
        If xErr = True Then
        Me.DsMatDB1.RejectChanges()
        MsgBox("Could not save due to errors", , My.Settings.SysName)
        My.Forms.ApplicationStartupForm.ss1.Text = "Could not save due to errors"
            Else


            If xToolStrip.Text = "New Record" Then Me.bsMatLink.AddNew()

            Me.bsMatLink.Current.row.item("fk_tblProduct") = xComboID
            Me.bsMatLink.Current.row.item("fk_tblMaterial") = Me.ComboBox1.SelectedValue
            Me.bsMatLink.Current.row.item("dblMatQty") = Me.TextBox2.Text
            Me.bsMatLink.Current.row.item("dblMatCost") = Me.TextBox3.Text
            Me.bsMatLink.Current.row.item("dblWasteFactor") = Me.TextBox4.Text
            Me.bsMatLink.EndEdit()
            Me.TblMatLinkTableAdapter1.Update(Me.DsMatDB1.tblMatLink)

                If xToolStrip.Text = "New Record" Then
                My.Forms.ApplicationStartupForm.ss1.Text = "Material link for Product " & xComboID & " added"
                Else
                My.Forms.ApplicationStartupForm.ss1.Text = "Material link for Product " & xComboID & " changed"
                End If
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub diaMatLink_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    My.Forms.ApplicationStartupForm.ss1.Text = String.Empty
    'TODO: This line of code loads data into the 'DsMatDB1.tblMaterial' table. You can move, or remove it, as needed.
    Me.TblMaterialTableAdapter.Fill(Me.DsMatDB1.tblMaterial)
    Me.TblMatLinkTableAdapter1.Fill(Me.DsMatDB1.tblMatLink)

    If xToolStrip.ToString = "Edit Record" Then
    Me.ComboBox1.Enabled = False
            Me.bsMatLink.Filter = "id_tblMatLink = " & xMatLinkID '"fk_tblProduct = " & xComboID & " and fk_tblmaterial = " & xMatID
            Me.ComboBox1.SelectedValue = xMatID
            Me.TextBox1.Text = Me.DsMatDB1.tblMaterial.FindByid_tblMaterial(Me.ComboBox1.SelectedValue).Item("txtMaterialUnit")
    Me.TextBox2.Text = Me.bsMatLink.Current.row.item("dblMatQty")
    Me.TextBox3.Text = Me.bsMatLink.Current.row.item("dblMatCost")

    End If
        Me.TblMaterialBindingSource.Sort = "Comboboxvalue"

    End Sub

    Private Sub diaMatLink_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub diaMatLink_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Invalidate()
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted

    If xComboID > 0 Then
            Me.TextBox1.Text = Me.DsMatDB1.tblMaterial.FindByid_tblMaterial(Me.ComboBox1.SelectedValue).Item("txtMaterialUnit")
    Me.TextBox2.Focus()
    End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
    Me.Validate()
    End Sub

    Private Sub TextBox2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Validated
    If Len(Me.ErrorProvider1.GetError(sender)) = 0 Then
            Dim xPrice As Decimal = Me.DsMatDB1.tblMaterial.FindByid_tblMaterial(Me.ComboBox1.SelectedValue).Item("dblMaterialPrice")
            If Me.TextBox4.Text > 0 Then
                xPrice = xPrice * (1 + (Me.TextBox4.Text / 100))
            End If
            Me.TextBox3.Text = Me.TextBox2.Text * xPrice
    End If

    End Sub

    Private Sub TextBox2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox2.Validating
        If IsNumeric(sender.text) Then
        Me.ErrorProvider1.SetError(sender, "")
        Else
        Me.ErrorProvider1.SetError(sender, "Only numeric numbers allowed")
        End If
    End Sub

    Private Sub TextBox4_Validated(sender As Object, e As System.EventArgs) Handles TextBox4.Validated
        If Len(Me.ErrorProvider1.GetError(sender)) = 0 Then
            Dim xPrice As Decimal = Me.DsMatDB1.tblMaterial.FindByid_tblMaterial(Me.ComboBox1.SelectedValue).Item("dblMaterialPrice")
            If Me.TextBox4.Text > 0 Then
                xPrice = xPrice * (1 + (Me.TextBox4.Text / 100))
            End If
            Me.TextBox3.Text = Me.TextBox2.Text * xPrice
        End If
    End Sub

    
    Private Sub TextBox4_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox4.Validating
        If IsNumeric(sender.text) Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Only numeric numbers allowed")
        End If
    End Sub

    
End Class
