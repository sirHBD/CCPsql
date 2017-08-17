Imports System.Net.Mail
Imports System.Net
Imports System.Threading

Public Class Mailer
        
    Public Shared Function GetMailParameters(ByVal xType As String, ByVal xConEDI As String) As ArrayList

        Dim xFunctionArray As New ArrayList
        Dim ds As New DataSet
        Dim da As SqlClient.SqlDataAdapter
        da = New SqlClient.SqlDataAdapter("Select * from tblEmailSettings where txtMailType = " & "'" & xType & "'", xConEDI)
        Dim cb As New SqlClient.SqlCommandBuilder(da)
        da.Fill(ds, "MailInfo")

        If ds.Tables("MailInfo").Rows.Count > 0 Then
            Dim rMail As DataRow = ds.Tables(0).Rows(0)
            xFunctionArray.Add(rMail.Item("txtSmTPServer").ToString)
            xFunctionArray.Add(rMail.Item("txtPop3Server").ToString)
            xFunctionArray.Add(rMail.Item("txtUser").ToString)
            xFunctionArray.Add(rMail.Item("txtPwd").ToString)
            xFunctionArray.Add(rMail.Item("txtSSLState").ToString)
            xFunctionArray.Add(rMail.Item("txtDefaultCredentials").ToString)
            xFunctionArray.Add(rMail.Item("txtFromAddress").ToString)
            xFunctionArray.Add(rMail.Item("txtToAddress").ToString)
            xFunctionArray.Add(rMail.Item("txtCopyAddress").ToString)

        End If

        Return xFunctionArray


    End Function

    Public Shared Sub SendMail(ByVal xSMTP As String, ByVal xUser As String, ByVal xPwd As String, ByVal xTo As String, ByVal xFrom As String, ByVal xCC As String, ByVal xBCC As String, ByVal xSubject As String, Optional ByVal xAttach As String = "", Optional ByVal xBody As String = "")

        'create the mail message
        Dim mail As New MailMessage()
        Dim smtp As New SmtpClient(xSMTP)
        smtp.UseDefaultCredentials = False
        Dim xStartTime As DateTime


        Try

            'set the addresses
            Dim xaddress = xFrom.Split(";")
            Dim i As Integer
            For i = 0 To xaddress.Length - 1
                mail.From = New MailAddress(Trim(xaddress(i)))
                mail.Sender = New MailAddress(Trim(xaddress(i)))
            Next

            Array.Clear(xaddress, 0, xaddress.Length)
            xaddress = xTo.Split(";")
            For i = 0 To xaddress.Length - 1
                mail.To.Add(Trim(xaddress(i)))
            Next

            Array.Clear(xaddress, 0, xaddress.Length)
            xaddress = xCC.Split(";")
            For i = 0 To xaddress.Length - 1
                If xaddress(i) <> "" Then mail.CC.Add(Trim(xaddress(i)))
            Next

            Array.Clear(xaddress, 0, xaddress.Length)
            xaddress = xBCC.Split(";")
            For i = 0 To xaddress.Length - 1
                If xaddress(i) <> "" Then mail.Bcc.Add(Trim(xaddress(i)))
            Next

            'set the content
            If String.IsNullOrEmpty(xSubject) = False Then mail.Subject = xSubject '& "(" & My.Computer.Name & ")"

            If String.IsNullOrEmpty(TestEmailVariable.xBody) = False Then
                mail.Body = TestEmailVariable.xBody & vbCrLf & "(" & My.Computer.Name & ")"
            Else
                mail.Body = xBody & vbCrLf & "(" & My.Computer.Name & ")"
            End If


            'Create attachement if required
            If xAttach <> "" Then

                Dim xattachArr = xAttach.Split(";")
                Dim iNum As Integer
                For iNum = 0 To xattachArr.Length - 1
                    If Len(xattachArr(iNum)) > 0 Then
                        Dim oAtt As New Mail.Attachment(xattachArr(iNum))
                        mail.Attachments.Add(oAtt)
                    End If
                Next

            End If


            'send the message
            'Dim smtp1 As New SmtpClient("127.0.0.1")
            'Dim smtp As New SmtpClient(xSMTP)

            'to authenticate we set the username and password properites on the SmtpClient
            smtp.Credentials = New NetworkCredential(xUser, xPwd)
            smtp.Timeout = 100000
            'smtp.EnableSsl = False
            'If My.Computer.Name.ToUpper = "DOWLINGSERVER" Or My.Computer.Name.ToUpper = "BARRY-VAIO" Then
            smtp.Port = 25
            'Else
            'smtp.Port = 587
            'End If

            smtp.DeliveryMethod = SmtpDeliveryMethod.Network

            xStartTime = Now()
            smtp.Send(mail)

            'Thread.Sleep(7500)

        Catch ex As SmtpException
            Dim xTime As TimeSpan = xStartTime.Subtract(Now())

            MsgBox("Mail message could not be send to " & xTo & " due to an SMTP Exeption - Time elaspsed is " & xTime.ToString & " See message " & vbCrLf & ex.Message.ToString)
        Catch ex1 As Exception
            MsgBox("Mail could not be compiled. See exception message below - " & vbCrLf & ex1.Message.ToString)

        Finally

            mail.Dispose()
            smtp.Dispose()

        End Try
    End Sub 'Authenticate
End Class
Module TestEmailVariable
    Public xType As Integer
    Public xTo As String
    Public xCC As String
    Public xBCC As String
    Public xBody As String
End Module

