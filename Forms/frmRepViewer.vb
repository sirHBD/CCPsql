Imports Microsoft.Reporting.WinForms
Imports Microsoft.Office.Interop
Imports System.IO


Public Class frmRepViewer

    Private Sub frmRepViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.SysName & " - " & "View reports"

        Dim xRpt As String = Me.Tag
        Select Case xRpt

            Case "ProductList"
                Me.TblProductTableAdapter1.Fill(Me.MyProdDBDataSet.tblProduct)
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CCP.rptProductList.rdlc"
                Me.ReportViewer1.RefreshReport()

            Case "tsRpt_AssHis"
                Me.ReportViewer1.Reset()

            Case "CoInfo"
                Me.ReportViewer1.Reset()
                TblCoInfoTableAdapter.Fill(Me.MyProdDBDataSet.tblCoInfo)
                Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                ReportDataSource1.Name = "TheUnwantedDS"
                ReportDataSource1.Value = Me.rptBindingSource
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CCP.rptCoInfo.rdlc"
                Me.ReportViewer1.RefreshReport()

            Case "Quote"
                Me.ReportViewer1.Reset()
                LstQuoteHeaderDetailsTableAdapter1.Fill(Me.MyProdDBDataSet.lstQuoteHeaderDetails, xId2Print)
                Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                ReportDataSource1.Name = "ds"
                ReportDataSource1.Value = Me.MyProdDBDataSet.lstQuoteHeaderDetails
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CCP.rptQuote.rdlc"
                Me.ReportViewer1.RefreshReport()

            Case "Tax Invoice"
                Me.ReportViewer1.Reset()
                LstInvoiceHeaderDetailsTableAdapter1.Fill(Me.MyProdDBDataSet.lstInvoiceHeaderDetails, xId2Print)
                Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                ReportDataSource1.Name = "ds1"
                ReportDataSource1.Value = Me.MyProdDBDataSet.lstInvoiceHeaderDetails
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CCP.rptInvoice.rdlc"
                Me.ReportViewer1.RefreshReport()

            Case "Receipt"
                Me.ReportViewer1.Reset()
                LstReceiptsTableAdapter1.Fill(Me.MyProdDBDataSet.lstReceipts, xId2Print)
                Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                ReportDataSource1.Name = "ds1"
                ReportDataSource1.Value = Me.MyProdDBDataSet.lstReceipts
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CCP.rptReceipt.rdlc"
                Me.ReportViewer1.RefreshReport()

            Case "ReceiptPerDocument"
                Me.ReportViewer1.Reset()
                LstReceiptsTableAdapter1.FillByQuote(Me.MyProdDBDataSet.lstReceipts, xId2Print)
                Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                ReportDataSource1.Name = "ds1"
                ReportDataSource1.Value = Me.MyProdDBDataSet.lstReceipts
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CCP.rptReceipt.rdlc"
                Me.ReportViewer1.RefreshReport()

            Case "Production order"
                Me.ReportViewer1.Reset()
                LstPOHeaderDetailsTableAdapter2.Fill(Me.MyProdDBDataSet.lstPOHeaderDetails, xId2Print)
                Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                ReportDataSource1.Name = "ds1"
                ReportDataSource1.Value = Me.MyProdDBDataSet.lstPOHeaderDetails
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CCP.rptProdOrder.rdlc"
                Me.ReportViewer1.RefreshReport()

            Case "JC"
                Me.ReportViewer1.Reset()
                LstJCDetailsTableAdapter1.Fill(Me.MyProdDBDataSet.lstJCDetails, xId2Print)
                Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                ReportDataSource1.Name = "ds1"
                ReportDataSource1.Value = Me.MyProdDBDataSet.lstJCDetails

                Dim instance As LocalReport = Me.ReportViewer1.LocalReport
                AddHandler Me.ReportViewer1.LocalReport.SubreportProcessing, AddressOf Me.Subreport1ProcessingEventHandler

                Dim instance1 As LocalReport = Me.ReportViewer1.LocalReport
                AddHandler Me.ReportViewer1.LocalReport.SubreportProcessing, AddressOf Me.Subreport2ProcessingEventHandler

                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CCP.rptJobCard.rdlc"
                Me.ReportViewer1.RefreshReport()
        End Select
    End Sub
    Public Sub Subreport1ProcessingEventHandler(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)


        Me.TblJCMaterialTableAdapter1.Fill(Me.MyProdDBDataSet.tblJCMaterial, xId2Print)

        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        ReportDataSource2.Name = "da1"
        ReportDataSource2.Value = Me.MyProdDBDataSet.tblJCMaterial

        e.DataSources.Add(New ReportDataSource("da1", Me.MyProdDBDataSet.Tables("tblJCMaterial")))

    End Sub

    Public Sub Subreport2ProcessingEventHandler(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)


        Me.TblJCLabourTableAdapter1.Fill(Me.MyProdDBDataSet.tblJCLabour, xId2Print)

        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        ReportDataSource3.Name = "db1"
        ReportDataSource3.Value = Me.MyProdDBDataSet.tblJCMaterial

        e.DataSources.Add(New ReportDataSource("db1", Me.MyProdDBDataSet.Tables("tblJCLabour")))

    End Sub

    Private Sub ts_Email_PDF_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Shared Sub Save(ByVal viewer As ReportViewer, ByVal savePath As String)
        Dim Bytes() As Byte = viewer.LocalReport.Render("PDF", "", Nothing, Nothing, Nothing, Nothing, Nothing)

        Using Stream As New FileStream(savePath, FileMode.Create)
            Stream.Write(Bytes, 0, Bytes.Length)
        End Using
    End Sub

    Private Sub ts_Save_PDF_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Shared Sub OpenEmail(ByVal xDocType As String, ByVal xRepViewer As Object)
        Dim Outlook As Outlook.Application
        Dim Mail As Outlook.MailItem
        Dim Acc As Outlook.Account

        Outlook = New Outlook.Application()
        Mail = Outlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)
        If Len(PrintingVariables.toEmail) > 0 Then Mail.To = MiscCode.MNS(PrintingVariables.toEmail.ToString()) Else Mail.To = ""
        Mail.Subject = xDocType & " " & xId2Print

        'If you have multiple accounts you could change it in sender:
        For Each Acc In Outlook.Session.Accounts
            'Select first pop3 for instance.
            If Acc.AccountType = Microsoft.Office.Interop.Outlook.OlAccountType.olPop3 Then
                Mail.Sender = Acc.DisplayName
            End If
        Next

        'Take default account if no sender...
        'If Not sender Is Nothing Then Mail.Sender = sender.CurrentUser.AddressEntry

        'Save Current report and Attach files
        Dim xFileFolder As String = My.Settings.SaveFolder & xDocType & xId2Print & ".pdf"
        Save(xRepViewer, xFileFolder)

        Mail.Attachments.Add(xFileFolder)

        'Append some text:
        Mail.HTMLBody &= ""

        Mail.Display()
    End Sub

    Private Sub frmRepViewer_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub frmRepViewer_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Me.Invalidate()
    End Sub

    Public Sub SaveWord(ByVal viewer As ReportViewer, ByVal savePath As String)
        Dim Bytes() As Byte = viewer.LocalReport.Render("Word", "", Nothing, Nothing, Nothing, Nothing, Nothing)

        Using Stream As New FileStream(savePath, FileMode.Create)
            Stream.Write(Bytes, 0, Bytes.Length)
        End Using
    End Sub

    Public Sub SaveExcel(ByVal viewer As ReportViewer, ByVal savePath As String)
        Dim Bytes() As Byte = viewer.LocalReport.Render("Excel", "", Nothing, Nothing, Nothing, Nothing, Nothing)

        Using Stream As New FileStream(savePath, FileMode.Create)
            Stream.Write(Bytes, 0, Bytes.Length)
        End Using
    End Sub

    Private Sub ts1_Close_Click(sender As System.Object, e As System.EventArgs) Handles ts1_Close.Click
        Me.Close()
    End Sub

    Private Sub ts1_Email_Click(sender As System.Object, e As System.EventArgs) Handles ts1_Email.Click

        Dim RV As New ReportViewer()
        RV = ReportViewer1
        OpenEmail(Me.Tag, RV)
    End Sub

    Private Sub ts1_Print_Click(sender As System.Object, e As System.EventArgs) Handles ts1_Print.Click
        Me.ReportViewer1.PrintDialog()
    End Sub

    Private Sub ts1_Exp_Word_Click(sender As System.Object, e As System.EventArgs) Handles ts1_Exp_Word.Click
        Dim xFileFolder As String = My.Settings.SaveFolder & Me.Tag & xId2Print & ".doc"
        SaveWord(Me.ReportViewer1, xFileFolder)
        MsgBox("File " & xFileFolder & " was created", , My.Settings.SysName)

    End Sub

    Private Sub ts1_Exp_Excel_Click(sender As System.Object, e As System.EventArgs) Handles ts1_Exp_Excel.Click
        Dim xFileFolder As String = My.Settings.SaveFolder & Me.Tag & xId2Print & ".xlsx"
        SaveWord(Me.ReportViewer1, xFileFolder)
        MsgBox("File " & xFileFolder & " was created", , My.Settings.SysName)
    End Sub

    Private Sub ts1_Exp_PDF_Click(sender As System.Object, e As System.EventArgs) Handles ts1_Exp_PDF.Click
        Dim xFileFolder As String = My.Settings.SaveFolder & Me.Tag & xId2Print & ".pdf"
        Save(Me.ReportViewer1, xFileFolder)
        MsgBox("File " & xFileFolder & " was created", , My.Settings.SysName)
    End Sub

End Class

Public Module PrintingVariables
    Public xId2Print As Integer
    Public toEmail As String

End Module