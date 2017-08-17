Public Class frmOH

    Private Sub frmOH_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim xOH As Decimal
        Dim xVol As Decimal

        Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        myConnection.Open()
        Dim myCommand = New SqlClient.SqlCommand("Select Sum(dblOHAmount) AS TotOH from tblOH", myConnection)
        ' myCommand = New SqlClient.SqlCommand("Select Sum(dblOHAmount) AS TotOH from tblOH", myConnection)
        Dim dr = myCommand.ExecuteReader()
        If dr.hasrows() = True Then
            While dr.read()
                If String.IsNullOrEmpty(dr.item("TotOH").ToString()) = False Then
                    xOH = dr.item("TotOH")
                Else
                    xOH = 0
                End If

            End While
        End If
        dr.Close()

        myCommand = New SqlClient.SqlCommand("Select Sum(decVolume) as TotVol from tblProdBud", myConnection)
        dr = myCommand.ExecuteReader()
        If dr.hasrows() = True Then
            While dr.read()
                xVol = dr.item("TotVol")
            End While
        End If

        If xVol > 0 Then
            My.Settings.tmpOHRec = xOH / xVol
        End If

        dr.close()
        myConnection.Close()
    End Sub

    Private Sub frmOH_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub frmOH_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Invalidate()
        MiscCode.ResizeGrid(Me.DataGridView1)
    End Sub

    Private Sub frmOH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsOHDB.tblOH' table. You can move, or remove it, as needed.
        Me.TblOHTableAdapter.Fill(Me.DsOHDB.tblOH)
        Me.DataGridView1.BackgroundColor = myGBColor

    End Sub

    Private Sub DataGridView1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Leave
        Me.Validate()
        Me.TblOHBindingSource.EndEdit()
        Me.TblOHTableAdapter.Update(Me.DsOHDB.tblOH)
    End Sub

    Private Sub CloseFormToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseFormToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class