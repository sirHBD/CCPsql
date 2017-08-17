Imports System.Windows.Forms

Public Class diaNotes

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub diaNotes_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.LstQuoteHeadersTableAdapter1.Fill(Me.DsAccounting.lstQuoteHeaders)

        Dim xCase As String = Me.Tag
        Select xCase
            Case Is = "Edit"
                Me.Text = My.Settings.SysName & " - " & "Edit previous quote"
                Me.RichTextBox1.Visible = False
                Me.Label1.Visible = True
                Me.ComboBox1.Visible = True
                Me.Label2.Visible = False
                Me.TextBox1.Visible = False

            Case "Quote"
                Me.Text = My.Settings.SysName & " - " & "Quote notes"
                Me.RichTextBox1.Visible = True
                Me.Label1.Visible = False
                Me.ComboBox1.Visible = False
                Me.Label2.Visible = False
                Me.TextBox1.Visible = False

            Case "Tax Invoice"
                Me.Text = My.Settings.SysName & " - " & "Invoice additional information"
                Me.RichTextBox1.Visible = True
                Me.Label1.Visible = False
                Me.ComboBox1.Visible = False
                Me.Label2.Visible = True
                Me.TextBox1.Visible = True

            Case "PO"
                Me.Text = My.Settings.SysName & " - " & "Production order additional information"
                Me.RichTextBox1.Visible = True
                Me.Label1.Visible = False
                Me.ComboBox1.Visible = False
                Me.Label2.Visible = False
                Me.TextBox1.Visible = False
        End Select




    End Sub

    Private Sub diaNotes_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)

    End Sub

    Private Sub diaNotes_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Invalidate()

    End Sub
End Class
