Imports System.Data.SqlClient
Imports System.Math


Public Class frmOutputCF
Private Sub frmOutputPerMonth_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub frmOutputPerMonth_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    Me.Invalidate()
    End Sub

    Private Sub frmOutputPerMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'DsOHDB.lstTotalsperMonth' table. You can move, or remove it, as needed.
    'Me.LstTotalsperMonthTableAdapter.Fill(Me.DsOHDB.lstTotalsperMonth)
    'Me.LstLabCostperMonthTableAdapter1.Fill(Me.DsOHDB.lstLabCostperMonth)
    'Me.LstMatCostperMonthTableAdapter1.Fill(Me.DsOHDB.lstMatCostperMonth)
    'Fil Dataset
    Dim Mystr As String = "Select * From tblCoInfo"
        Dim Con As New SqlConnection(My.Settings.ConnectionString1)
    Con.Open()
        Dim OLEDBAdapter As New SqlDataAdapter(Mystr, Con)
        'Dim OLEDBCommBuilder As SqlDataAdapterBuilder = New SqlDataAdapterBuilder(OLEDBAdapter)
        Dim myCommand As New SqlDataAdapter(Mystr, Con)
    'myCommand.ExecuteNonQuery()
    Dim ds As New DataSet
    OLEDBAdapter.Fill(ds, "Balances")

    Mystr = "Select * from lstReceivablesPerMonth"
        Dim oledbadapter1 As New SqlDataAdapter(Mystr, Con)
    oledbadapter1.Fill(ds, "Receivables")

    Mystr = "Select * from lstPayablesPerMonth"
        Dim oledbadapter2 As New SqlDataAdapter(Mystr, Con)
    oledbadapter2.Fill(ds, "Payables")

    Mystr = "Select * from lstLabCostPerMonth"
        Dim oledbadapter3 As New SqlDataAdapter(Mystr, Con)
    oledbadapter3.Fill(ds, "LabCost")

        Mystr = "Select * from lstOHperMonth"
        Dim oledbadapter4 As New SqlDataAdapter(Mystr, Con)
        oledbadapter4.Fill(ds, "OHTot")



    Me.Text = My.Settings.SysName & " - " & "Reports (Cash Flow Statement)"
    Me.dgv.BackgroundColor = myGBColor

    Me.dgv.DataSource = Nothing
    Dim xMonths As ArrayList = FillMonths()
        FillMonths()
        Dim xi As Integer
        For xi = 0 To xMonths.Count - 1
            dgv.Columns(xi + 1).HeaderText = xMonths(xi)
        Next


    Dim i As Integer
    Dim xPay, xRec, xCash As Decimal
    xCash = ds.Tables("Balances").Rows(0).Item("dblCashOB")

    Me.dgv.Rows.Add()
    dgv.Rows(0).Cells(0).Value = "Opening Cash Balance"
    dgv.Rows(0).Cells(1).Value = Round(xCash, 2)
    Me.dgv.Rows.Add()
    Me.dgv.Rows.Add()
    dgv.Rows(2).Cells(0).Value = "Cash In"
    Me.dgv.Rows.Add()
    dgv.Rows(3).Cells(0).Value = "Sales Receipts"
    Me.dgv.Rows.Add()
    Me.dgv.Rows.Add()
    dgv.Rows(5).Cells(0).Value = "Cash Out"
    Me.dgv.Rows.Add()
    dgv.Rows(6).Cells(0).Value = "Direct Materials"
    Me.dgv.Rows.Add()
    dgv.Rows(7).Cells(0).Value = "Direct Labour"
    Me.dgv.Rows.Add()
    dgv.Rows(8).Cells(0).Value = "Overheads"

    For i = 0 To xMonths.Count - 1
Try
        If IsDBNull(ds.Tables("Receivables").Rows(i).Item("sumOfDecGrossIncome")) Then
        xRec = 0
        Else
        xRec = ds.Tables("Receivables").Rows(i).Item("sumOfDecGrossIncome")
        End If
        dgv.Rows(3).Cells(i + 1).Value = Round(xRec, 2)

        'xPay = ds.Tables("Payables").Compute("Sum(SumOfTotMatCost)", "PayMonth = " & (i + 1))
        If IsDBNull(ds.Tables("Payables").Compute("Sum(SumOfTotMatCost)", "PayMonth = " & (i + 1))) Then
        xPay = 0
        Else
        xPay = ds.Tables("Payables").Compute("Sum(SumOfTotMatCost)", "PayMonth = " & (i + 1))
        End If
        dgv.Rows(6).Cells(i + 1).Value = Round(xPay, 2)

        Dim xLabUnitCost As Decimal
        If IsDBNull(ds.Tables("labCost").Compute("Sum(TotCost)", "txtPeriodDescriptor = " & "'" & xMonths(i) & "'")) Then
        xLabUnitCost = 0
        Else
        xLabUnitCost = CDec(ds.Tables("labCost").Compute("Sum(TotCost)", "txtPeriodDescriptor = " & "'" & xMonths(i) & "'"))
        dgv.Rows(7).Cells(i + 1).Value = Round(CDec(ds.Tables("labCost").Compute("Sum(TotCost)", "txtPeriodDescriptor = " & "'" & xMonths(i) & "'")), 2)
        End If

                Dim xTotOH As Decimal = CDec(ds.Tables("OHTot").Rows(0).Item("TotOH"))

                Dim xOHCost As Decimal = xTotOH / 12
                dgv.Rows(8).Cells(i + 1).Value = xOHCost

                xCash = (xCash + xRec) - (xPay + xOHCost + xLabUnitCost)
                dgv.Rows(0).Cells(i + 2).Value = Round(xCash, 2)

            Catch ex As Exception
                ds.Clear()
                Con.Close()
            End Try


    Next


    ds.Clear()
    Con.Close()

End Sub

Private Function FillMonths() As ArrayList
   Dim xYE As Date = Me.TblCoInfoTableAdapter1.FillByYEDATE
        Dim xStartDate As Date = DateAdd(DateInterval.Month, 1, xYE)
        Dim xMonth As String = MonthName(Month(xStartDate)).ToString
        Dim xArr As New ArrayList
        xArr.Add(xMonth.Substring(0, 3))
        Dim i As Integer
        For i = 0 To 10
            xStartDate = DateAdd(DateInterval.Month, 1, xStartDate)
            xMonth = MonthName(Month(xStartDate)).ToString
            xArr.Add(xMonth.Substring(0, 3))
        Next
    Return xArr
    End Function

End Class