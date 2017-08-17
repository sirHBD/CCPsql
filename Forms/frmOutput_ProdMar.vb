Imports System.Data.OleDb

Public Class frmOutput_ProdMar

    Private Sub frmOutputPerMonth_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub frmOutputPerMonth_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Invalidate()
    End Sub

    Private Sub frmOutputPerMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = My.Settings.SysName & " - " & "Product Margins"

        Dim xCoNo As String = MiscCode.GetCoNo


        'TODO: This line of code loads data into the 'DsOHDB.lstTotalsperMonth' table. You can move, or remove it, as needed.
        Try
            Me.LstMarginsperProductTableAdapter1.Fill(Me.DsOHDB1.lstMarginsperProduct)
            Me.LstlabCostperProduct_TotalTableAdapter1.Fill(Me.DsOHDB1.lstlabCostperProduct_Total)

            Me.TblOHTableAdapter1.Fill(Me.DsOHDB1.tblOH)
        Catch ex As Exception
            MsgBox("Could not display" & vbCrLf & ex.Message)
        End Try

        Me.dgv.BackgroundColor = myGBColor
        Me.ToolTip1.SetToolTip(dgv, String.Empty)

        Me.dgv.DataSource = Nothing
        Dim xC As Integer

        For xC = 0 To Me.dgv.Columns.Count - 1
            Me.dgv.Columns.RemoveAt(0)
        Next
        Dim xHeaderList As ArrayList = FillHeader()
        FillHeader()
        Dim i As Integer
        Dim xTotUnits As Decimal
        Dim xOHTotalAmount As Decimal = 0
        Try
            xTotUnits = DsOHDB1.lstMarginsperProduct.Compute("Sum(TotVol)", Nothing)

            'Add Datagrid Colums
            Dim xProdCount As Integer = Me.DsOHDB1.lstMarginsperProduct.Count
            For i = 0 To xHeaderList.Count - 1
                Me.dgv.Columns.Add(xHeaderList(i), xHeaderList(i))
                dgv.Columns(xHeaderList(i).ToString).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(xHeaderList(i).ToString).Width = 95
                dgv.Columns(xHeaderList(i).ToString).DefaultCellStyle.Format = "c"
                If i = 1 Then dgv.Columns(1).Visible = False
            Next
            dgv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgv.Columns(0).DefaultCellStyle.Format = "g"
            dgv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgv.Columns(1).DefaultCellStyle.Format = "g"
            dgv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgv.Columns(2).DefaultCellStyle.Format = "g"
            dgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns(3).DefaultCellStyle.Format = "g"
            dgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns(4).DefaultCellStyle.Format = "p2"
            dgv.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns(12).DefaultCellStyle.Format = "p2"

            If CheckBox1.Checked = False Then
                'now Populate the rows
                Dim xCol As Integer
                For i = 0 To xProdCount - 1
                    Me.dgv.Rows.Add()
                    dgv.Rows(i).Cells(xCol).Value = DsOHDB1.lstMarginsperProduct.Rows(i).Item(14)
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = DsOHDB1.lstMarginsperProduct.Rows(i).Item(0)
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = DsOHDB1.lstMarginsperProduct.Rows(i).Item(1) & " - " & DsOHDB1.lstMarginsperProduct.Rows(i).Item("txtProdSpec1")
                    dgv.Rows(i).Cells(xCol).Tag = DsOHDB1.lstMarginsperProduct.Rows(i).Item("txtProdSpec1")
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = Math.Round((DsOHDB1.lstMarginsperProduct.Rows(i).Item(12) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(5)), 4)
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = (DsOHDB1.lstMarginsperProduct.Rows(i).Item(5) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(4))
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = DsOHDB1.lstMarginsperProduct.Rows(i).Item(6) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = DsOHDB1.lstMarginsperProduct.Rows(i).Item(10) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = DsOHDB1.lstMarginsperProduct.Rows(i).Item(11) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = DsOHDB1.lstMarginsperProduct.Rows(i).Item(12) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)

                    Dim xOHAllocationType As String = String.Empty

                    xOHAllocationType = MiscCode.GetValueonID(xCoNo, "idtblCoInfo", "tblCoInfo", "txtOHAllocationType")
                    Dim xOH As Decimal
                    Dim xOHRate As Double

                    Select Case xOHAllocationType
                        Case "PerSQM"
                            xOH = MiscCode.GetOHRatePerSQM

                            If DsOHDB1.lstMarginsperProduct.Rows(i).Item("txtProdSpec1") = "2070" Then
                                xOHRate = xOH * 2.07
                            End If
                            If DsOHDB1.lstMarginsperProduct.Rows(i).Item("txtProdSpec1") = "127" Then
                                xOHRate = xOH * 0.127
                            End If
                            If DsOHDB1.lstMarginsperProduct.Rows(i).Item("txtProdSpec1") = "89" Then
                                xOHRate = xOH * 0.089
                            End If
                            xCol = xCol + 1
                            dgv.Rows(i).Cells(xCol).Value = (DsOHDB1.lstMarginsperProduct.Rows(i).Item(4) * xOHRate) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)
                        Case "ProdHours"
                            xOH = MiscCode.GetOHRatePerMinute
                            xOHRate = xOH

                            Dim xTime As Decimal = 0
                            Me.LstLabCostperProductTableAdapter1.FillByProductID(Me.DsOHDB1.lstLabCostperProduct, DsOHDB1.lstMarginsperProduct.Rows(i).Item(0))
                            Me.LstlabCostperProduct_TotalTableAdapter1.FillByProductID(Me.DsOHDB1.lstlabCostperProduct_Total, DsOHDB1.lstMarginsperProduct.Rows(i).Item(0))
                            For Each xRow As DataRow In Me.DsOHDB1.lstLabCostperProduct.Rows
                                Dim xTimeUnit As String = xRow.Item("txtValueDesc")

                                Select Case xTimeUnit
                                    Case "Minute"
                                        xTime = xTime + xRow.Item("sumOfdblValue")
                                    Case "Hour"
                                        xTime = xTime + (xRow.Item("sumOfdblValue") * 60)
                                    Case "Second"
                                        xTime = xTime + (xRow.Item("sumOfdblValue") / 60)
                                    Case Else

                                End Select
                            Next



                            xCol = xCol + 1
                            dgv.Rows(i).Cells(xCol).Value = (xOHRate * xTime) '(DsOHDB1.lstMarginsperProduct.Rows(i).Item(4) * (xOHRate * xTime))
                            xOHTotalAmount = xOHTotalAmount + ((xOHRate * xTime) * DsOHDB1.lstMarginsperProduct.Rows(i).Item(4))

                        Case ("LabourHours")

                            xOH = MiscCode.GetOHRate
                            xOHRate = xOH

                            Dim xTime As Decimal = 0
                            Dim xLabourHours As Decimal = 0
                            Dim xLabourCost As Decimal = 0
                            Me.LstLabCostperProductTableAdapter1.FillByProductID(Me.DsOHDB1.lstLabCostperProduct, DsOHDB1.lstMarginsperProduct.Rows(i).Item(0))
                            For Each xRow As DataRow In Me.DsOHDB1.lstLabCostperProduct.Rows
                                Dim xTimeUnit As String = xRow.Item("txtValueDesc")
                                xLabourCost = MiscCode.FillLabourByProduct(DsOHDB1.lstMarginsperProduct.Rows(i).Item(0), -1, 48, 0, xLabourHours)
                                Select Case xTimeUnit
                                    Case "Minute"
                                        xTime = xTime + xRow.Item("sumOfdblValue")
                                    Case "Hour"
                                        xTime = xTime + (xRow.Item("sumOfdblValue") * 60)
                                    Case "Second"
                                        xTime = xTime + (xRow.Item("sumOfdblValue") / 60)
                                    Case Else

                                End Select


                            Next


                            xCol = xCol + 1
                            'dgv.Rows(i).Cells(xCol).Value = (xOHRate * xTime) '(DsOHDB1.lstMarginsperProduct.Rows(i).Item(4) * (xOHRate * xTime))
                            dgv.Rows(i).Cells(xCol).Value = (xOHRate * xLabourHours) * DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)
                            'xOHTotalAmount = xOHTotalAmount + ((xOHRate * xTime) * DsOHDB1.lstMarginsperProduct.Rows(i).Item(4))
                            xOHTotalAmount = xOHTotalAmount + ((xOHRate * xLabourHours) * DsOHDB1.lstMarginsperProduct.Rows(i).Item(4))


                           



                    End Select


                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = (dgv.Rows(i).Cells(xCol - 2).Value - dgv.Rows(i).Cells(xCol - 1).Value)
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = Math.Round(dgv.Rows(i).Cells(xCol - 1).Value / (DsOHDB1.lstMarginsperProduct.Rows(i).Item(5) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)), 4)
                    xCol = 0


                Next






            Else
                Dim xCol As Integer
                For i = 0 To xProdCount - 1
                    Me.dgv.Rows.Add()
                    dgv.Rows(i).Cells(xCol).Value = DsOHDB1.lstMarginsperProduct.Rows(i).Item(14)
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = DsOHDB1.lstMarginsperProduct.Rows(i).Item(0)
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = DsOHDB1.lstMarginsperProduct.Rows(i).Item(1)
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = Math.Round((DsOHDB1.lstMarginsperProduct.Rows(i).Item(9) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(5)), 4)
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = (DsOHDB1.lstMarginsperProduct.Rows(i).Item(5) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(4))
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = DsOHDB1.lstMarginsperProduct.Rows(i).Item(6) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = DsOHDB1.lstMarginsperProduct.Rows(i).Item(7) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = DsOHDB1.lstMarginsperProduct.Rows(i).Item(8) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)
                    xCol = xCol + 1
                    dgv.Rows(i).Cells(xCol).Value = DsOHDB1.lstMarginsperProduct.Rows(i).Item(9) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)
                    'Dim xOH As String = Me.TblOHTableAdapter1.GetTotOH
                    Dim xOHAllocationType As String = String.Empty
                    xOHAllocationType = MiscCode.GetValueonID(xCoNo, "idtblCoInfo", "tblCoInfo", "txtOHAllocationType")
                    Dim xOH As Decimal
                    Dim xOHRate As Double
                    Select Case xOHAllocationType
                        Case "PerSQM"
                            xOH = MiscCode.GetOHRatePerSQM

                            If DsOHDB1.lstMarginsperProduct.Rows(i).Item("txtProdSpec1") = "2070" Then
                                xOHRate = xOH * 2.07
                            End If
                            If DsOHDB1.lstMarginsperProduct.Rows(i).Item("txtProdSpec1") = "127" Then
                                xOHRate = xOH * 0.127
                            End If
                            If DsOHDB1.lstMarginsperProduct.Rows(i).Item("txtProdSpec1") = "89" Then
                                xOHRate = xOH * 0.089
                            End If

                        Case "ProdHours"
                            xOH = MiscCode.GetOHRatePerMinute

                            xOHRate = xOH

                            Dim xTime As Decimal = 0
                            Me.LstLabCostperProductTableAdapter1.FillByProductID(Me.DsOHDB1.lstLabCostperProduct, DsOHDB1.lstMarginsperProduct.Rows(i).Item(0))
                            For Each xRow As DataRow In Me.DsOHDB1.lstLabCostperProduct.Rows
                                Dim xTimeUnit As String = xRow.Item("txtValueDesc")

                                Select Case xTimeUnit
                                    Case "Minute"
                                        xTime = xTime + xRow.Item("sumOfdblValue")
                                    Case "Hour"
                                        xTime = xTime + (xRow.Item("sumOfdblValue") * 60)
                                    Case "Second"
                                        xTime = xTime + (xRow.Item("sumOfdblValue") / 60)
                                    Case Else

                                End Select

                                xCol = xCol + 1
                                dgv.Rows(i).Cells(xCol).Value = (DsOHDB1.lstMarginsperProduct.Rows(i).Item(4) * (xOHRate * xTime))
                                xOHTotalAmount = xOHTotalAmount + ((xOHRate * xTime) * DsOHDB1.lstMarginsperProduct.Rows(i).Item(4))

                            Next

                            '''''''''''''''''''''''
                        Case "LabourHours"

                            xOH = MiscCode.GetOHRate
                            xOHRate = xOH
                            Dim xTime As Decimal = 0
                            Dim xLabourHours As Decimal = 0
                            Dim xLabourCost As Decimal = 0
                            Me.LstLabCostperProductTableAdapter1.FillByProductID(Me.DsOHDB1.lstLabCostperProduct, DsOHDB1.lstMarginsperProduct.Rows(i).Item(0))
                            For Each xRow As DataRow In Me.DsOHDB1.lstLabCostperProduct.Rows
                                Dim xTimeUnit As String = xRow.Item("txtValueDesc")
                                xLabourCost = MiscCode.FillLabourByProduct(DsOHDB1.lstMarginsperProduct.Rows(i).Item(0), -1, 48, 0, xLabourHours)
                                Select Case xTimeUnit
                                    Case "Minute"
                                        xTime = xTime + xRow.Item("sumOfdblValue")
                                    Case "Hour"
                                        xTime = xTime + (xRow.Item("sumOfdblValue") * 60)
                                    Case "Second"
                                        xTime = xTime + (xRow.Item("sumOfdblValue") / 60)
                                    Case Else

                                End Select

                                xCol = xCol + 1
                                'dgv.Rows(i).Cells(xCol).Value = (xOHRate * xTime) '(DsOHDB1.lstMarginsperProduct.Rows(i).Item(4) * (xOHRate * xTime))
                                dgv.Rows(i).Cells(xCol).Value = (xOHRate * xLabourHours) * DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)
                                'xOHTotalAmount = xOHTotalAmount + ((xOHRate * xTime) * DsOHDB1.lstMarginsperProduct.Rows(i).Item(4))
                                xOHTotalAmount = xOHTotalAmount + ((xOHRate * xLabourHours) * DsOHDB1.lstMarginsperProduct.Rows(i).Item(4))
                            Next
                    End Select


                    'xCol = xCol + 1
                    'dgv.Rows(i).Cells(xCol).Value = (DsOHDB1.lstMarginsperProduct.Rows(i).Item(4) * xOHRate) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)
                    xCol = xCol + 1
                    'dgv.Rows(i).Cells(xCol).Value = Math.Round((dgv.Rows(i).Cells(xCol - 2).Value - dgv.Rows(i).Cells(xCol - 1).Value)
                    dgv.Rows(i).Cells(xCol).Value = Math.Round(dgv.Rows(i).Cells(xCol - 1).Value / (DsOHDB1.lstMarginsperProduct.Rows(i).Item(5) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)), 4)
                    ' xCol = xCol + 1
                    ' dgv.Rows(i).Cells(xCol).Value = Math.Round(dgv.Rows(i).Cells(xCol - 1).Value / (DsOHDB1.lstMarginsperProduct.Rows(i).Item(5) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)) * 100, 2)


                    xCol = 0

                    'xCol = xCol + 1
                    'dgv.Rows(i).Cells(xCol).Value = (dgv.Rows(i).Cells(xCol - 2).Value - dgv.Rows(i).Cells(xCol - 1).Value)
                    'xCol = xCol + 1
                    'dgv.Rows(i).Cells(xCol).Value = Math.Round(dgv.Rows(i).Cells(xCol - 1).Value / (DsOHDB1.lstMarginsperProduct.Rows(i).Item(5) / DsOHDB1.lstMarginsperProduct.Rows(i).Item(4)) * 100, 2)
                    'xCol = 0


                Next


            End If




            'Now adjust overhead to ensure full overhead amount is recovered.
            Dim xTotOHBudget As Decimal = Me.DsOHDB1.tblOH.Compute("Sum(dblOHAmount)", String.Empty)
            Dim xOHAdjFactor As Decimal = xTotOHBudget / xOHTotalAmount
            Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
            Dim xProdIndex As Decimal
            myConnection.Open()
            Dim myCommand = New SqlClient.SqlCommand("Select Min(dblProductivityIndex) as ProdIndex from tblCoInfo", myConnection)
            Dim dr3 = myCommand.ExecuteReader()
            If dr3.hasrows() = True Then
                While dr3.read()
                    xProdIndex = dr3.item("ProdIndex")
                End While
            End If
            If Math.Round(xOHAdjFactor, 2) <> xProdIndex Then
                Dim xReply As Integer
                xReply = MsgBox("The Productivity Index has changed from " & xProdIndex & " to " & Math.Round(xOHAdjFactor, 2) & ".  Do you want to update the factor for future use", MsgBoxStyle.YesNo, My.Settings.SysName)
                If xReply = 6 Then
                    UpdateProductivity(Math.Round(xOHAdjFactor, 2))
                End If
            End If


            For Each xrow As DataGridViewRow In dgv.Rows
                'xrow.Cells("Overhead Cost").Value = (xrow.Cells("Overhead Cost").Value * xOHAdjFactor) / xrow.Cells("Quantity").Value
                xrow.Cells("Overhead Cost").Value = (xrow.Cells("Overhead Cost").Value * 1) / xrow.Cells("Quantity").Value
                xrow.Cells("Net Profit").Value = xrow.Cells("Gross Profit").Value - xrow.Cells("Overhead Cost").Value
                xrow.Cells("Net Profit %").Value = Math.Round(xrow.Cells("Net Profit").Value / xrow.Cells("Selling Price").Value, 4)
                If xrow.Cells("Net Profit").Value < 0 Then
                    xrow.Cells("Net Profit %").Style.ForeColor = Color.DarkRed
                End If
            Next

        Catch ex As Exception
            MsgBox("Could not display" & ex.Message)
        End Try

        Me.dgv.Visible = True
    End Sub

    Private Function FillHeader() As ArrayList
        Dim xArr As New ArrayList
        xArr.Add("Product Code")
        xArr.Add("ProductID")
        xArr.Add("Description")
        xArr.Add("Quantity")
        xArr.Add("Gross Profit %")
        xArr.Add("Selling Price")
        xArr.Add("Material Cost")
        xArr.Add("Labour Cost")
        xArr.Add("Total Direct Cost")
        xArr.Add("Gross Profit")
        xArr.Add("Overhead Cost")
        xArr.Add("Net Profit")
        xArr.Add("Net Profit %")
        Return xArr
    End Function

    Private Sub dgv_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim xPos As Point = Control.MousePosition
        Dim xRow As DataGridViewRow = Me.dgv.CurrentRow

        Dim xComboID As Integer = xRow.Cells("ProductID").Value

        If xComboID > 0 And e.ColumnIndex = 7 Then
            Dim dia As Form = diaMarginPopup
            If Me.CheckBox1.Checked Then
                dia.Tag = xComboID & "|" & "Checked"
            Else
                dia.Tag = xComboID & "|" & "UnChecked"
            End If
            Try
                dia.Location = xPos
                dia.Show()
            Catch ex As Exception
            End Try

        End If

        If xComboID > 0 And e.ColumnIndex = 6 Then
            Dim dia As Form = diaPopUpMat
            If Me.CheckBox1.Checked Then
                dia.Tag = xComboID & "|" & "Checked"
            Else
                dia.Tag = xComboID & "|" & "UnChecked"
            End If
            Try
                dia.Location = xPos
                dia.Show()
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub CheckBox1_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckStateChanged
        Me.dgv.Visible = False
        frmOutputPerMonth_Load(Me, e)
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


        For iC = 0 To dgv.Columns.Count - 1

            wsheet.Cells(1, iC + 1).Value = dgv.Columns(iC).HeaderText

            wsheet.Cells(1, iC + 1).font.bold = True


        Next

        wsheet.Rows(2).select()


        For iX = 0 To dgv.Rows.Count - 1


            For iY = 0 To dgv.Columns.Count - 1

                If dgv(iY, iX).Value Is Nothing Then
                Else
                    wsheet.Cells(iX + 2, iY + 1).value = dgv(iY, iX).Value.ToString
                End If


            Next


        Next

        wapp.Visible = True

        wapp.UserControl = True
    End Sub

    Private Sub UpdateProductivity(ByVal xProdIndex As Decimal)
        Dim strSQL As String = "Update tblCoInfo Set dblProductivityIndex = " & xProdIndex & " where idtblCoInfo = " & MiscCode.GetCoNo
        Dim xCon As New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        Dim xComm As New SqlClient.SqlCommand(strSQL, xCon)
        xCon.Open()
        xComm.ExecuteNonQuery()
        xCon.Close()
    End Sub

    Private Sub CloseFormToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseFormToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class