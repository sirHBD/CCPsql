Imports System.Math

Public Class frmOutputPerMonth

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

        Me.LstTotalsperMonthTableAdapter.Fill(Me.DsOHDB.lstTotalsperMonth)
        Me.LstLabCostperMonthTableAdapter1.Fill(Me.DsOHDB.lstLabCostperMonth)
        Me.LstMatCostperMonthTableAdapter1.Fill(Me.DsOHDB.lstMatCostperMonth)


    Me.Text = My.Settings.SysName & " - " & "Reports (Income Statement)"
    Me.dgv.BackgroundColor = myGBColor

    Me.dgv.DataSource = Nothing
    Dim xMonths As ArrayList = FillMonths()
        Dim xi As Integer
        For xi = 0 To xMonths.Count - 1
            dgv.Columns(xi + 1).HeaderText = xMonths(xi)
        Next



    Dim i As Integer
    Dim xUnits, xTotUnits As Decimal

    Me.dgv.Rows.Add()
    dgv.Rows(0).Cells(0).Value = "Units to be sold"
    For i = 0 To xMonths.Count - 1
    dgv.Rows(0).Cells(i + 1).Value = DsOHDB.lstTotalsperMonth.Compute("Sum(decVolume)", "txtPeriodDescriptor = " & "'" & xMonths(i) & "'")

    If IsDBNull(dgv.Rows(0).Cells(i + 1).Value) = False Then
    xTotUnits = xTotUnits + CDec(dgv.Rows(0).Cells(i + 1).Value)
    End If
    Next
        dgv.Rows(0).Cells(i + 1).Value = Round(xTotUnits, 0)


        Me.dgv.Rows.Add()
        Dim xTotSales As Decimal
    i = 0
    For i = 0 To xMonths.Count - 1
        dgv.Rows(1).Cells(0).Value = " --- Sales ---"
            If IsDBNull(DsOHDB.lstTotalsperMonth.Compute("Sum(decGrossIncome)", "txtPeriodDescriptor = " & "'" & xMonths(i) & "'")) = False Then
            dgv.Rows(1).Cells(i + 1).Value = Round(DsOHDB.lstTotalsperMonth.Compute("Sum(decGrossIncome)", "txtPeriodDescriptor = " & "'" & xMonths(i) & "'"))
            Else
            dgv.Rows(1).Cells(i + 1).Value = 0
            End If

            If IsDBNull(dgv.Rows(1).Cells(i + 1).Value) = False Then
                xTotSales = xTotSales + dgv.Rows(1).Cells(i + 1).Value
            End If
        Next
        dgv.Rows(1).Cells(i + 1).Value = Round(xTotSales, 2)



        Me.dgv.Rows.Add()
        Dim xTotMatCost As Decimal
    i = 0
    For i = 0 To xMonths.Count - 1
    dgv.Rows(2).Cells(0).Value = "Material Cost"
    Dim xMatUnitCost As Decimal
    If IsDBNull(DsOHDB.lstMatCostperMonth.Compute("Sum(TotMatCost)", "txtPeriodDescriptor = " & "'" & xMonths(i) & "'")) Then
    xMatUnitCost = 0
    Else
    xMatUnitCost = CDec(DsOHDB.lstMatCostperMonth.Compute("Sum(TotMatCost)", "txtPeriodDescriptor = " & "'" & xMonths(i) & "'"))
    dgv.Rows(2).Cells(i + 1).Value = Round(CDec(DsOHDB.lstMatCostperMonth.Compute("Sum(TotMatCost)", "txtPeriodDescriptor = " & "'" & xMonths(i) & "'")), 2)
    End If
        'If Len(dgv.Rows(0).Cells(i + 1).Value) = 0 Then
        'xUnits = 0
        'Else
        'xUnits = dgv.Rows(0).Cells(i + 1).Value
        'End If
            If IsDBNull(dgv.Rows(2).Cells(i + 1).Value) = False Then
                xTotMatCost = xTotMatCost + dgv.Rows(2).Cells(i + 1).Value
            End If
    Next
        dgv.Rows(2).Cells(i + 1).Value = Round(xTotMatCost, 2)


        Me.dgv.Rows.Add()
        Dim xTotLabCost As Decimal
    i = 0
    For i = 0 To xMonths.Count - 1
    dgv.Rows(3).Cells(0).Value = "Labour Cost"

        Dim xLabUnitCost As Decimal
        If IsDBNull(DsOHDB.lstLabCostperMonth.Compute("Sum(TotCost)", "txtPeriodDescriptor = " & "'" & xMonths(i) & "'")) Then
        xLabUnitCost = 0
        Else
        xLabUnitCost = CDec(DsOHDB.lstLabCostperMonth.Compute("Sum(TotCost)", "txtPeriodDescriptor = " & "'" & xMonths(i) & "'"))
        dgv.Rows(3).Cells(i + 1).Value = Round(CDec(DsOHDB.lstLabCostperMonth.Compute("Sum(TotCost)", "txtPeriodDescriptor = " & "'" & xMonths(i) & "'")), 2)
        End If

    'If Len(dgv.Rows(0).Cells(i + 1).Value) = 0 Then
    'xUnits = 0
    'Else
    'xUnits = dgv.Rows(0).Cells(i + 1).Value
    'End If

    'dgv.Rows(3).Cells(i + 1).Value = xUnits * xLabUnitCost
            If IsDBNull(dgv.Rows(3).Cells(i + 1).Value) = False Then
                xTotLabCost = xTotLabCost + dgv.Rows(3).Cells(i + 1).Value
            End If
    Next
        dgv.Rows(3).Cells(i + 1).Value = Round(xTotLabCost, 2)


        Me.dgv.Rows.Add()
        Dim xTotGross As Decimal

    i = 0
    dgv.Rows(4).Cells(0).Value = "Gross Profit/Loss"
    For i = 0 To xMonths.Count - 1
    dgv.Rows(4).Cells(i + 1).Value = Round(CDec(dgv.Rows(1).Cells(i + 1).Value) - (CDec(dgv.Rows(2).Cells(i + 1).Value) + CDec(dgv.Rows(3).Cells(i + 1).Value)), 2)
    dgv.Rows(4).DefaultCellStyle.BackColor = Color.Gray
    Dim FS As New Font("Arial", 8, FontStyle.Italic)
    dgv.Rows(4).DefaultCellStyle.Font = FS
    'dgv.Rows(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            If IsDBNull(dgv.Rows(4).Cells(i + 1).Value) = False Then
                xTotGross = xTotGross + Round(CDec(dgv.Rows(1).Cells(i + 1).Value) - (CDec(dgv.Rows(2).Cells(i + 1).Value) + CDec(dgv.Rows(3).Cells(i + 1).Value)), 2)
            End If
        Next
        dgv.Rows(4).Cells(i + 1).Value = xTotGross



        Me.dgv.Rows.Add()
        Dim xTotOH As Decimal

    i = 0
    dgv.Rows(5).Cells(0).Value = "Overheads"
    Dim xOH As String = Me.TblOHTableAdapter1.GetTotOH
    Dim xOHRate As Double = CDec(xOH / xTotUnits)

    For i = 0 To xMonths.Count - 1

        If IsDBNull(dgv.Rows(0).Cells(i + 1).Value) Then
        xUnits = 0
        Else
        xUnits = dgv.Rows(0).Cells(i + 1).Value
        End If

    dgv.Rows(5).Cells(i + 1).Value = Round((xOHRate * xUnits), 2)
            If IsDBNull(dgv.Rows(5).Cells(i + 1).Value) = False Then
                xTotOH = xTotOH + dgv.Rows(5).Cells(i + 1).Value
            End If

        Next
        dgv.Rows(5).Cells(i + 1).Value = Round(xTotOH, 2)



        Me.dgv.Rows.Add()
        Dim xTotNet As Decimal

    i = 0
    dgv.Rows(6).Cells(0).Value = "Net Income"
    For i = 0 To xMonths.Count - 1
    dgv.Rows(6).Cells(i + 1).Value = Round(CDec(dgv.Rows(4).Cells(i + 1).Value) - CDec(dgv.Rows(5).Cells(i + 1).Value), 2)
    dgv.Rows(6).DefaultCellStyle.BackColor = Color.Gray
    Dim FS As New Font("Arial", 8, FontStyle.Italic)
    dgv.Rows(6).DefaultCellStyle.Font = FS
            If IsDBNull(dgv.Rows(6).Cells(i + 1).Value) = False Then
                xTotNet = xTotNet + Round(CDec(dgv.Rows(4).Cells(i + 1).Value) - CDec(dgv.Rows(5).Cells(i + 1).Value), 2)
            End If

        Next
        dgv.Rows(6).Cells(i + 1).Value = Round(xTotNet, 2)

    For Each col As DataGridViewColumn In dgv.Columns

        If col.Index > 0 Then
        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
            If col.Index > 13 Then
            col.Visible = False
            End If

            
    Next

    dgv.AllowUserToAddRows = False
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

    Private Sub PrintRecordToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrintRecordToolStripMenuItem.Click

        Dim wapp As Microsoft.Office.Interop.Excel.Application


        Dim wsheet As Microsoft.Office.Interop.Excel.Worksheet


        Dim wbook As Microsoft.Office.Interop.Excel.Workbook

        wapp = New Microsoft.Office.Interop.Excel.Application

        wapp.Visible = True

        wbook = wapp.Workbooks.Add()

        wsheet = wbook.ActiveSheet


        Dim iX As Integer


        Dim iY As Integer


        Dim iC As Integer


        For iC = 0 To dgv.Columns.Count - 1

            wsheet.Cells(1, iC + 1).Value = dgv.Columns(iC).HeaderText

            wsheet.Cells(1, iC + 1).font.bold = True


        Next

        wsheet.Rows(2).select()


        For iX = 0 To dgv.Rows.Count - 1


            For iY = 0 To dgv.Columns.Count - 1

                wsheet.Cells(iX + 1, iY + 1).value = dgv(iY, iX).Value.ToString


            Next


        Next

        wapp.Visible = True

        wapp.UserControl = True

    End Sub

    Private Sub CloseFormToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseFormToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class