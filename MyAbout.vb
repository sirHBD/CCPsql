Public NotInheritable Class MyAbout
Public xConn As String
    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = My.Application.Info.ProductName
           If System.Diagnostics.Debugger.IsAttached = False Then
            Try
            LabelVersion.Text = "Version - " & My.Application.Deployment.CurrentVersion.ToString
            Catch ex As Exception
            LabelVersion.Text = "Not set"
            End Try

            Else
            LabelVersion.Text = "Debug Mode"
            End If

        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description

        Try
            xConn = MiscCode.MNS(My.Settings.ConnectionString1)
            If xConn.Length > 0 Then
            Dim xDBArr() As String = xConn.Split("=")
            Me.TextBoxDescription.Text = Me.TextBoxDescription.Text & vbCrLf & "Current database connection " & vbCrLf & xDBArr(2)
                Else
                Me.TextBoxDescription.Text = Me.TextBoxDescription.Text & vbCrLf & "No Database connection found"
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Dim frm As Form = frmChangeDB
        frm.Tag = xConn
        frm.Show()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim dia As New diaWhatNew
        dia.Show()
    End Sub
End Class
