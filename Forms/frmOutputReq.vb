Public Class frmOutputReq
Dim xShowUnits As Boolean
Dim xShowValue As Boolean

    Private Sub frmOutputReq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'DsProdDB.tblProdBud' table. You can move, or remove it, as needed.
    Me.LstMatCostperMonthTableAdapter1.FillByDistinctMatID(Me.DsREQ1.lstMatCostperMonth)
    Me.Text = My.Settings.SysName & " - " & "Requirements"
    Me.dgvLabRequirement.BackgroundColor = myGBColor
    Me.dgvMaterialReq.BackgroundColor = myGBColor


    Me.dgvMaterialReq.DataSource = Nothing
    Dim xHeaderList As ArrayList = FillMonths()
    FillMonths()
    Dim i As Integer

    'Add the columns
    For i = 0 To xHeaderList.Count - 1
    Me.dgvMaterialReq.Columns.Add(xHeaderList(i), xHeaderList(i))
    dgvMaterialReq.Columns(xHeaderList(i).ToString).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    'dgvMaterialReq.Columns(xHeaderList(i).ToString).DefaultCellStyle.Format = "c"
    Next

    'Now start loading the requirments
    Dim xMatCount As Integer = Me.DsREQ1.lstMatCostperMonth.Rows.Count
    Dim xMatID As Integer

    For i = 0 To xMatCount - 1
    xMatID = Me.DsREQ1.lstMatCostperMonth.Rows(i).Item("FK_tblMaterial")
    Dim xArr(11, 0) As Decimal
    xArr = FillRows(xMatID)
    Dim x As Integer
    Me.dgvMaterialReq.Rows.Add()
    Me.dgvMaterialReq.Rows.Add()
    Dim xRow As Integer
    If i = 0 Then
    xRow = 0
        Else
        xRow = i * 2
    End If

    Dim xCol As Integer = 2
    dgvMaterialReq.Rows(xRow).Cells(0).Value = DsREQ1.lstMatCostperMonth.Rows(i).Item("txtMaterialDesc")
    Dim xLen As Integer = xArr.GetLength(0)

        For x = 0 To xLen - 1
        dgvMaterialReq.Rows(xRow).Cells(1).Value = "Quantity"
        dgvMaterialReq.Rows(xRow).Cells(xCol).Value = Math.Round(xArr(x, 0), 1)
        dgvMaterialReq.Rows(xRow + 1).Cells(1).Value = "Value"
        dgvMaterialReq.Rows(xRow + 1).Cells(xCol).Value = Math.Round(xArr(x, 1), 1)
        xCol = xCol + 1
        Next

    Next

    xShowUnits = True
    xShowValue = True

    If Me.Tag = "Labour" Then
    TabControl1.SelectedTab = TabPage2
    End If
    End Sub

    Private Sub frmOutputReq_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub frmOutputReq_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    Me.Invalidate()
    End Sub

    Private Function FillMonths() As ArrayList
    Dim xArr As New ArrayList
    xArr.Add("Description")
    xArr.Add("")

        Dim xYE As Date = Me.TblCoInfoTableAdapter1.FillByYEDATE
        Dim xStartDate As Date = DateAdd(DateInterval.Month, 1, xYE)
        Dim xMonth As String = MonthName(Month(xStartDate)).ToString
        xArr.Add(xMonth.Substring(0, 3))
        Dim i As Integer
        For i = 2 To 12
            xStartDate = DateAdd(DateInterval.Month, 1, xStartDate)
            xMonth = MonthName(Month(xStartDate)).ToString
            xArr.Add(xMonth.Substring(0, 3))
        Next

    Return xArr
    End Function

    Private Shared Function FillRows(ByVal xID As Integer) As Decimal(,)

        Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        Try
            myConnection.Open()
            'opening the connection

            Dim myCommand = New SqlClient.SqlCommand
            myCommand = New SqlClient.SqlCommand("Select fk_tblMaterial, txtMaterialDesc, txtPeriodDescriptor, SUM(decVolume) AS totSalesVol, SUM(TotMatCost) AS TotMatCost, SUM(dblMatQty) AS totMatReq, AVG(dblMatCost) AS AveMatCost, Sum([decVolume]*[dblMatQty]) as TotMatQtyRecalc FROM lstMatCostperMonth GROUP BY fk_tblMaterial, txtMaterialDesc, txtPeriodDescriptor HAVING(SUM(TotMatCost) > 0) " & " and FK_tblMaterial = " & xID & " Order BY fk_tblMaterial, txtPeriodDescriptor", myConnection)
            Dim ds As New DataSet
            Dim myAdaptor As New SqlClient.SqlDataAdapter(myCommand)
            myAdaptor.Fill(ds, "RowRec")
            Dim xCount As Integer = ds.Tables(0).Rows.Count
            Dim RowArr(11, 1) As Decimal
            Dim i As Integer

            For i = 0 To xCount - 1

                Dim xMonth As String = ds.Tables(0).Rows(i).Item("txtPeriodDescriptor")
                Select Case xMonth
                    Case "Jan"
                        RowArr(0, 0) = ds.Tables(0).Rows(i).Item("totMatQtyRecalc")
                        RowArr(0, 1) = Math.Round(ds.Tables(0).Rows(i).Item("totMatCost"), 2)
                    Case "Feb"
                        RowArr(1, 0) = ds.Tables(0).Rows(i).Item("totMatQtyRecalc")
                        RowArr(1, 1) = Math.Round(ds.Tables(0).Rows(i).Item("totMatCost"), 2)
                    Case "Mar"
                        RowArr(2, 0) = ds.Tables(0).Rows(i).Item("totMatQtyRecalc")
                        RowArr(2, 1) = Math.Round(ds.Tables(0).Rows(i).Item("totMatCost"), 2)
                    Case "Apr"
                        RowArr(3, 0) = ds.Tables(0).Rows(i).Item("totMatQtyRecalc")
                        RowArr(3, 1) = Math.Round(ds.Tables(0).Rows(i).Item("totMatCost"), 2)
                    Case "May"
                        RowArr(4, 0) = ds.Tables(0).Rows(i).Item("totMatQtyRecalc")
                        RowArr(4, 1) = Math.Round(ds.Tables(0).Rows(i).Item("totMatCost"), 2)
                    Case "Jun"
                        RowArr(5, 0) = ds.Tables(0).Rows(i).Item("totMatQtyRecalc")
                        RowArr(5, 1) = Math.Round(ds.Tables(0).Rows(i).Item("totMatCost"), 2)
                    Case "Jul"
                        RowArr(6, 0) = ds.Tables(0).Rows(i).Item("totMatQtyRecalc")
                        RowArr(6, 1) = Math.Round(ds.Tables(0).Rows(i).Item("totMatCost"), 2)
                    Case "Aug"
                        RowArr(7, 0) = ds.Tables(0).Rows(i).Item("totMatQtyRecalc")
                        RowArr(7, 1) = Math.Round(ds.Tables(0).Rows(i).Item("totMatCost"))
                    Case "Sep"
                        RowArr(8, 0) = ds.Tables(0).Rows(i).Item("totMatQtyRecalc")
                        RowArr(8, 1) = Math.Round(ds.Tables(0).Rows(i).Item("totMatCost"), 2)
                    Case "Oct"
                        RowArr(9, 0) = ds.Tables(0).Rows(i).Item("totMatQtyRecalc")
                        RowArr(9, 1) = Math.Round(ds.Tables(0).Rows(i).Item("totMatCost"), 2)
                    Case "Nov"
                        RowArr(10, 0) = ds.Tables(0).Rows(i).Item("totMatQtyRecalc")
                        RowArr(10, 1) = Math.Round(ds.Tables(0).Rows(i).Item("totMatCost"), 2)
                    Case "Dec"
                        RowArr(11, 0) = ds.Tables(0).Rows(i).Item("totMatQtyRecalc")
                        RowArr(11, 1) = Math.Round(ds.Tables(0).Rows(i).Item("totMatCost"), 2)
                End Select

            Next

            Return RowArr

        Catch ex As Exception

            Return Nothing


        End Try

    End Function

    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        Me.LstLabCostperMonthTableAdapter1.FillByDistinctActID(Me.DsREQ1.lstLabCostperMonth)

        Me.dgvLabRequirement.DataSource = Nothing

        Dim xHeaderList As ArrayList = FillMonths()
        FillMonths()
        Dim i As Integer
        If Me.dgvLabRequirement.Columns.Count > 0 Then Exit Sub

        'Add the columns
        For i = 0 To xHeaderList.Count - 1
            Me.dgvLabRequirement.Columns.Add(xHeaderList(i), xHeaderList(i))
            dgvLabRequirement.Columns(xHeaderList(i).ToString).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvMaterialReq.Columns(xHeaderList(i).ToString).DefaultCellStyle.Format = "c"
        Next

        'Now start loading the requirments
        Dim xActCount As Integer = Me.DsREQ1.lstLabCostperMonth.Rows.Count

        Dim xIdAct As Integer
        Dim xIDOps As Integer
        Dim xIDDept As Integer

        For i = 0 To xActCount - 1
            Try
                xIDDept = Me.DsREQ1.lstLabCostperMonth.Rows(i).Item("FK_tblDept")
                xIDOps = Me.DsREQ1.lstLabCostperMonth.Rows(i).Item("FK_tblElement")
                xIdAct = Me.DsREQ1.lstLabCostperMonth.Rows(i).Item("FK_tblActivity")
            Catch ex As InvalidCastException
            End Try

            'Dim xArr(11, 0) As Decimal
            Dim xArr

            Try
                xArr = FillActivityRows(xIdAct, xIDOps, xIDDept)

                If xArr Is Nothing Then
                    MsgBox("Data errors found Unable to display", , My.Settings.SysName)
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("An error occured when trying to fill the activity rows - Please advise the system administrator", , "Cost Coach Pro messages")
                Exit Sub
            End Try

            Dim x As Integer
            Me.dgvLabRequirement.Rows.Add()
            'Me.dgvLabRequirement.Rows.Add()

            'If i = 0 Then
            'xRow = 0
            '    Else
            '    xRow = i * 2
            'End If

            Dim xCol As Integer = 2
            dgvLabRequirement.Rows(i).Cells(0).Value = DsREQ1.lstLabCostperMonth.Rows(i).Item("ActDesc")
            Dim xLen As Integer = xArr.GetLength(0)

            For x = 0 To xLen - 1
                'dgvLabRequirement.Rows(xRow).Cells(1).Value = "Quantity"
                'dgvLabRequirement.Rows(xRow).Cells(xCol).Value = Math.Round(xArr(x, 0), 1)
                dgvLabRequirement.Rows(i).Cells(1).Value = "Value"
                dgvLabRequirement.Rows(i).Cells(xCol).Value = Math.Round(xArr(x, 1), 2)
                xCol = xCol + 1
            Next
            xIdAct = 0
            xIDDept = 0
            xIDOps = 0

        Next
    End Sub

    Private Shared Function FillActivityRows(ByVal xActID As Integer, ByVal xOpsID As Integer, ByVal xDeptID As Integer) As Decimal(,)

        Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        Try
            myConnection.Open()
            'opening the connection

            Dim myCommand = New SqlClient.SqlCommand
            If xDeptID > 0 And xOpsID > 0 And xActID > 0 Then
                myCommand = New SqlClient.SqlCommand("Select ActDesc, fk_tblDept, fk_tblElement, fk_tblActivity, txtPeriodDescriptor, SUM(decVolume) AS totSalesVol, SUM(TotCost) AS TotLabCost, SUM(dblValue) AS totLabReq FROM lstLabCostperMonth GROUP BY ActDesc, fk_tblDept, fk_tblElement, fk_tblActivity, txtPeriodDescriptor HAVING(SUM(TotCost) > 0) " & " and FK_tblDept = " & xDeptID & " and FK_tblElement = " & xOpsID & " and FK_tblActivity = " & xActID & " Order BY txtPeriodDescriptor", myConnection)
            End If
            If xDeptID > 0 And xOpsID > 0 And xActID = 0 Then
                myCommand = New SqlClient.SqlCommand("Select ActDesc, fk_tblDept, fk_tblElement, fk_tblActivity, txtPeriodDescriptor, SUM(decVolume) AS totSalesVol, SUM(TotCost) AS TotLabCost, SUM(dblValue) AS totLabReq FROM lstLabCostperMonth GROUP BY ActDesc, fk_tblDept, fk_tblElement, fk_tblActivity, txtPeriodDescriptor HAVING(SUM(TotCost) > 0) " & " and FK_tblDept = " & xDeptID & " and FK_tblElement = " & xOpsID & " Order BY txtPeriodDescriptor", myConnection)
            End If
            If xDeptID > 0 And xOpsID = 0 And xActID = 0 Then
                myCommand = New SqlClient.SqlCommand("Select ActDesc, fk_tblDept, fk_tblElement, fk_tblActivity, txtPeriodDescriptor, SUM(decVolume) AS totSalesVol, SUM(TotCost) AS TotLabCost, SUM(dblValue) AS totLabReq FROM lstLabCostperMonth GROUP BY ActDesc, fk_tblDept, fk_tblElement, fk_tblActivity, txtPeriodDescriptor HAVING(SUM(TotCost) > 0) " & " and FK_tblDept = " & xDeptID & " Order BY txtPeriodDescriptor", myConnection)
            End If

            Dim ds As New DataSet
            Dim myAdaptor As New SqlClient.SqlDataAdapter(myCommand)
            myAdaptor.Fill(ds, "RowRec")
            Dim xCount As Integer = ds.Tables(0).Rows.Count
            Dim RowArr(11, 1) As Decimal
            Dim i As Integer

            For i = 0 To xCount - 1

                Dim xMonth As String = ds.Tables(0).Rows(i).Item("txtPeriodDescriptor")
                Select Case xMonth
                    Case "Jan"
                        'RowArr(0, 0) = ds.Tables(0).Rows(i).Item("totlabReq") * ds.Tables(0).Rows(i).Item("totSalesVol")
                        RowArr(0, 1) = ds.Tables(0).Rows(i).Item("totlabCost")
                    Case "Feb"
                        'RowArr(1, 0) = Math.Round((ds.Tables(0).Rows(i).Item("totLabReq") * ds.Tables(0).Rows(i).Item("totSalesVol")), 1)
                        RowArr(1, 1) = ds.Tables(0).Rows(i).Item("totLabCost")
                    Case "Mar"
                        'RowArr(2, 0) = Math.Round((ds.Tables(0).Rows(i).Item("totLabReq") * ds.Tables(0).Rows(i).Item("totSalesVol")), 1)
                        RowArr(2, 1) = ds.Tables(0).Rows(i).Item("totLabCost")
                    Case "Apr"
                        'RowArr(3, 0) = Math.Round((ds.Tables(0).Rows(i).Item("totLabReq") * ds.Tables(0).Rows(i).Item("totSalesVol")), 1)
                        RowArr(3, 1) = ds.Tables(0).Rows(i).Item("totLabCost")
                    Case "May"
                        'RowArr(4, 0) = Math.Round((ds.Tables(0).Rows(i).Item("totLabReq") * ds.Tables(0).Rows(i).Item("totSalesVol")), 1)
                        RowArr(4, 1) = ds.Tables(0).Rows(i).Item("totLabCost")
                    Case "Jun"
                        'RowArr(5, 0) = Math.Round((ds.Tables(0).Rows(i).Item("totLabReq") * ds.Tables(0).Rows(i).Item("totSalesVol")), 1)
                        RowArr(5, 1) = ds.Tables(0).Rows(i).Item("totLabCost")
                    Case "Jul"
                        'RowArr(6, 0) = Math.Round((ds.Tables(0).Rows(i).Item("totLabReq") * ds.Tables(0).Rows(i).Item("totSalesVol")), 1)
                        RowArr(6, 1) = ds.Tables(0).Rows(i).Item("totLabCost")
                    Case "Aug"
                        'RowArr(7, 0) = Math.Round((ds.Tables(0).Rows(i).Item("totLabReq") * ds.Tables(0).Rows(i).Item("totSalesVol")), 1)
                        RowArr(7, 1) = ds.Tables(0).Rows(i).Item("totLabCost")
                    Case "Sep"
                        'RowArr(8, 0) = Math.Round((ds.Tables(0).Rows(i).Item("totLabReq") * ds.Tables(0).Rows(i).Item("totSalesVol")), 1)
                        RowArr(8, 1) = ds.Tables(0).Rows(i).Item("totLabCost")
                    Case "Oct"
                        'RowArr(9, 0) = (ds.Tables(0).Rows(i).Item("totLabReq") * ds.Tables(0).Rows(i).Item("totSalesVol"))
                        RowArr(9, 1) = ds.Tables(0).Rows(i).Item("totLabCost")
                    Case "Nov"
                        'RowArr(10, 0) = (ds.Tables(0).Rows(i).Item("totLabReq") * ds.Tables(0).Rows(i).Item("totSalesVol"))
                        RowArr(10, 1) = ds.Tables(0).Rows(i).Item("totLabCost")
                    Case "Dec"
                        'RowArr(11, 0) = (ds.Tables(0).Rows(i).Item("totLabReq") * ds.Tables(0).Rows(i).Item("totSalesVol"))
                        RowArr(11, 1) = ds.Tables(0).Rows(i).Item("totLabCost")
                End Select

            Next

            Return RowArr

        Catch ex As Exception
            Return Nothing

        End Try

    End Function

    Private Sub HideShowUnitsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cm_HideUnits.Click

    If xShowUnits = True Then
    Dim xDesc As String = String.Empty
    For Each xrow As DataGridViewRow In Me.dgvMaterialReq.Rows
        If xrow.Cells(1).Value = "Quantity" Then
        xrow.Visible = False
        If IsDBNull(xrow.Cells(0).Value) = False Then xDesc = xrow.Cells(0).Value Else xDesc = ""
            Else
            xrow.Cells(0).Value = xDesc
        End If
    xShowUnits = False
    Me.cm_HideValue.Enabled = False
    Next
        Else
        For Each xrow As DataGridViewRow In Me.dgvMaterialReq.Rows
        If xrow.Cells(1).Value = "Quantity" Then
        xrow.Visible = True
        End If
    xShowUnits = True
    Me.cm_HideValue.Enabled = True
    Next
    End If


    End Sub

    Private Sub cm_HideValue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cm_HideValue.Click
    If xShowValue = True Then

    For Each xrow As DataGridViewRow In Me.dgvMaterialReq.Rows
        If xrow.Cells(1).Value = "Value" Then
        xrow.Visible = False
        End If
    xShowValue = False
    Me.cm_HideUnits.Enabled = False
    Next
        Else
        For Each xrow As DataGridViewRow In Me.dgvMaterialReq.Rows
        If xrow.Cells(1).Value = "Value" Then
        xrow.Visible = True
        End If
    xShowValue = True
    Me.cm_HideUnits.Enabled = True
    Next
    End If
    End Sub

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
        Dim dgv As DataGridView
        If TabPage1.Focus = True Then
            dgv = Me.dgvMaterialReq
        Else
            dgv = Me.dgvLabRequirement
        End If


        For iC = 0 To dgv.Columns.Count - 1
            wsheet.Cells(1, iC + 1).Value = dgv.Columns(iC).HeaderText
            wsheet.Cells(1, iC + 1).font.bold = True
        Next

        'wsheet.Rows(2).select()

        For iX = 0 To dgv.Rows.Count - 1
            For iY = 0 To dgv.Columns.Count - 1
                If Len(MiscCode.MNS(dgv(iY, iX).Value)) = 0 Then

                Else
                    wsheet.Cells(iX + 2, iY + 1).value = MiscCode.MNS(dgv(iY, iX).Value.ToString)
                End If

            Next
        Next

        wapp.Visible = True
        wapp.UserControl = True
    End Sub

    Private Sub CloseFormToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseFormToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class