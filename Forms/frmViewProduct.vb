Public Class frmViewProduct

    Private Sub frmViewProduct_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Text = My.Settings.SysName & " - " & "View product image"
        If Me.PictureBox1.Image Is Nothing Then Me.PictureBox1.Visible = False
        If Me.PictureBox2.Image Is Nothing Then Me.PictureBox2.Visible = False
        If Me.PictureBox3.Image Is Nothing Then Me.PictureBox3.Visible = False
    End Sub

    Private Sub frmViewProduct_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub frmViewProduct_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Me.Invalidate()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        If fd.ShowDialog() = DialogResult.OK Then
            Me.PictureBox2.ImageLocation = fd.FileName
            Me.PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
            Me.PictureBox2.Visible = True
        Else
            Me.PictureBox2.Visible = False
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As System.EventArgs) Handles Label1.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        If fd.ShowDialog() = DialogResult.OK Then
            Me.PictureBox1.ImageLocation = fd.FileName
            Me.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            Me.PictureBox1.Visible = True
        Else
            Me.PictureBox1.Visible = False
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As System.EventArgs) Handles Label3.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        If fd.ShowDialog() = DialogResult.OK Then
            Me.PictureBox3.ImageLocation = fd.FileName
            Me.PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
            Me.PictureBox3.Visible = True
        Else
            Me.PictureBox3.Visible = False
        End If
    End Sub
End Class