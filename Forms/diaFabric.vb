Imports System.Windows.Forms

Public Class diaFabric

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub diaFabric_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DsAccounting.tblProduct' table. You can move, or remove it, as needed.
        Me.TblMaterialTableAdapter2.FillByDirect(Me.DsAccounting.tblMaterial)
        Me.Text = My.Settings.SysName & " - " & "Fabric Management"
    End Sub
    Private Sub diaFabric_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)

    End Sub

    Private Sub diaFabric_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Invalidate()

    End Sub

    Private Sub DataGridView1_RowEnter(sender As Object, e As System.EventArgs) Handles DataGridView1.RowEnter
        If String.IsNullOrEmpty(Me.TextBox1.Text) Then Return
        'If Me.TextBox1.Text < 0 Then Me.DataGridView1.ReadOnly = False
    End Sub

    Private Sub DataGridView1_RowValidated(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        Me.TblMaterialBindingSource.EndEdit()
        Me.TblMaterialTableAdapter2.Update(Me.DsAccounting.tblMaterial)
        Me.DataGridView1.ReadOnly = True


    End Sub


    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Me.TextBox1.Text = Me.DataGridView1.CurrentRow.Cells(0).Value & "|" & Me.DataGridView1.CurrentRow.Cells(1).Value & "|" & Me.DataGridView1.CurrentRow.Cells(2).Value & "|" & Me.DataGridView1.CurrentRow.Cells(3).Value & "|" & Me.DataGridView1.CurrentRow.Cells(4).Value & "|" & Me.DataGridView1.CurrentRow.Cells(5).Value & "|" & Me.DataGridView1.CurrentRow.Cells(6).Value & "|" & Me.DataGridView1.CurrentRow.Cells(7).Value & "|" & Me.DataGridView1.CurrentRow.Cells(8).Value
    End Sub

    Private Sub TblMaterialBindingSource_AddingNew(sender As Object, e As System.ComponentModel.AddingNewEventArgs) Handles TblMaterialBindingSource.AddingNew
        Me.DataGridView1.ReadOnly = False
        Me.DataGridView1.Rows(Me.DataGridView1.NewRowIndex).Cells("TxtTypeDataGridViewTextBoxColumn").Value = "Direct"
    End Sub
End Class
