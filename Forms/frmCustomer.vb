Imports System.Math
Imports System.Data.OleDb

Public Class frmCustomer

    Private Sub frmCustomer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = My.Settings.SysName & " - " & "Customer"
        Me.DataGridView1.BackgroundColor = myGBColor

        Me.TblCustomerTableAdapter1.Fill(Me.DsAccounting1.tblCustomer)
        

    End Sub

    Private Sub frmCustomer_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub frmCustomer_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Invalidate()
    End Sub

    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        Me.Validate()
        Me.TblCustomerBindingSource.EndEdit()
        Me.TblCustomerTableAdapter1.Update(Me.DsAccounting1.tblCustomer)
    End Sub

    Private Sub DataGridView1_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView1.RowValidating

        

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim dia As Form = diaCustomerAdd
        xStaffToolstrip = sender
        dia.Text = "Add a new customer"
        dia.Tag = "New"
        dia.ShowDialog()


        If dia.DialogResult = DialogResult.OK Then
            Me.TblCustomerBindingSource.EndEdit()
            Me.TblCustomerTableAdapter1.Fill(Me.DsAccounting1.tblCustomer)
            Me.DataGridView1.Refresh()
        End If
        dia.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim dia As Form = diaCustomerAdd
        xStaffToolstrip = sender
        dia.Text = "Add a new customer"
        dia.Tag = Me.DataGridView1.CurrentRow.Cells(0).Value
        dia.ShowDialog()


        If dia.DialogResult = DialogResult.OK Then
            Me.TblCustomerBindingSource.EndEdit()
            Me.TblCustomerTableAdapter1.Fill(Me.DsAccounting1.tblCustomer)
            Me.DataGridView1.Refresh()
        End If
        dia.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click

        
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        My.Forms.ApplicationStartupForm.ss1.Text = String.Empty
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        

    End Sub

    Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
        Me.Close()
    End Sub
End Class
