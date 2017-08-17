Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles
Imports System.Math



Public Class frmQuick
Dim xNormalLab As Integer
Dim xFridayLab As Integer
Dim xLabCostOrder As Decimal
Dim xLabCostUnit As Decimal
Dim xMatCostOrder As Decimal
    Dim xMatCostUnit As Decimal
    Public xLabourHours As Decimal
    Dim xQuoteIDSaved As Integer


    Private Sub frmQuick_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        If QQ_Variables.xNewID > -1 Then
            Dim xResponse As MsgBoxResult
            xResponse = MsgBox("A current product exist that has not been saved.  The product is " & QQ_Variables.xProdCode & " " & QQ_Variables.xProdDesc & ".  This product must first be saved or deleted.  Do you want to save the product?", MsgBoxStyle.YesNoCancel, My.Settings.SysName)
            If xResponse = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            If xResponse = MsgBoxResult.No Then
                MiscCode.DeleteTmpProduct(QQ_Variables.xNewID)
                QQ_Variables.xNewID = -1
                QQ_Variables.xProdCopyID = 0
                QQ_Variables.xProdCode = String.Empty
                QQ_Variables.xProdDesc = String.Empty
                QQ_Variables.xSpec1 = String.Empty
                QQ_Variables.xSpec2 = String.Empty
                QQ_Variables.xSpec3 = String.Empty
            End If
            If xResponse = MsgBoxResult.Yes Then
                QQ_Variables.xNewID = -1
                QQ_Variables.xProdCopyID = 0
                QQ_Variables.xProdCode = String.Empty
                QQ_Variables.xProdDesc = String.Empty
                QQ_Variables.xSpec1 = String.Empty
                QQ_Variables.xSpec2 = String.Empty
                QQ_Variables.xSpec3 = String.Empty
            End If
        End If
    End Sub

    Private Sub frmQuick_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.Text = My.Settings.SysName & " - " & "Quoting"
    Me.dgvLabour.BackgroundColor = myGBColor
    Me.dgvMaterial.BackgroundColor = myGBColor
        Me.GroupBox2.BackColor = myGBColor
        Me.dgvCapacity.BackgroundColor = myGBColor

        Me.TblCustomerTableAdapter1.Fill(Me.DsProdDB1.tblCustomer)

        Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        myConnection.Open()
        Dim myCommand = New SqlClient.SqlCommand
        myCommand = New SqlClient.SqlCommand("Select * from tblCoInfo", myConnection)
        Dim dr = myCommand.ExecuteReader()
        If dr.hasrows() = True Then
            While dr.read()
                xNormalLab = dr.item("dblNormalLabHours")
                Me.TextBox2.Text = xNormalLab
                xFridayLab = dr.item("dblFridayLabHours")
                Me.TextBox3.Text = xFridayLab
            End While
        End If
        dr.close()
        myConnection.Close()

        Fill_cb_NotType()
        Me.ComboBox1.SelectedIndex = 0
        Me.ComboBox2.SelectedIndex = 0



    End Sub

    Private Sub Fill_cb_NotType()
        Me.TblProductTableAdapter1.FillByComboInfo(Me.DsProdDB1.tblProduct)

        With ComboBox1
            .DataSource = Me.DsProdDB1.tblProduct
            .DisplayMember = "ComboInfo"
            .ValueMember = "idtblProduct"
        End With

    End Sub

    Private Sub frmQuick_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)

    End Sub

    Private Sub frmQuick_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Invalidate()

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Cursor = Cursors.WaitCursor
        'For Each ctrl As Control In Me.GroupBox1.Controls
        '    If ctrl.GetType().ToString = "System.Windows.Forms.TextBox" Then
        '        ctrl.Text = Nothing
        '    End If
        'Next

        For Each ctrl As Control In Me.GroupBox2.Controls
            If ctrl.GetType().ToString = "System.Windows.Forms.TextBox" Then
                ctrl.Text = Nothing
            End If
        Next

        Dim xRowcount As Integer = Me.dgvLabour.Rows.Count
        If xRowcount > 0 Then
            Me.dgvLabour.Rows.Clear()
            Me.dgvLabour.Columns.Clear()
        End If
        xRowcount = Me.dgvMaterial.Rows.Count
        If xRowcount > 0 Then
            Me.dgvMaterial.Rows.Clear()
            Me.dgvMaterial.Columns.Clear()
        End If

        'Me.GroupBox1.Visible = True
        Me.GroupBox2.Visible = True

        'Calculate Hours available
        If Me.TextBox3.Text = "" Then Me.TextBox3.Text = 0

        Me.TextBox4.Text = (Me.TextBox2.Text * xNormalLab) + (Me.TextBox3.Text * xFridayLab)
        'Calulate Units per Hour req
        Me.TextBox5.Text = Me.TextBox1.Text / Me.TextBox4.Text
        'Find max labour requirement
        Me.TextBox7.Text = CDec(60 / CDec(Me.TextBox5.Text))
        'Calculater Labour Requirements
        xLabCostOrder = 0
        xLabCostUnit = 0


        FillLabour()
        Me.ComboBox2.Tag = "Selected"
        FillMat()
        Dim x As Integer = Me.dgvLabour.Columns(0).Width

        xLabCostUnit = MiscCode.FillLabourByProduct(Me.ComboBox1.SelectedValue, Me.TextBox1.Text, -1, xLabCostUnit, xLabourHours)
        'Find out if the product has components in its materials
        Me.LstMaterialLinkTableAdapter1.FillByProductID(Me.DsProdDB1.lstMaterialLink, Me.ComboBox1.SelectedValue)
        Dim xHasComponents As Integer
        Dim dvMAT As New DataView(Me.DsProdDB1.lstMaterialLink, "txtType = 'Component'", "idtblProduct", DataViewRowState.CurrentRows)
        If dvMAT.Count > 0 Then
            xHasComponents = dvMAT.Count
            xLabCostUnit = xLabCostUnit + MiscCode.FillLabourByComponent(Me.ComboBox1.SelectedValue, dvMAT(0)(11), Me.TextBox1.Text, xLabCostUnit, xLabourHours)
        End If
        xLabCostUnit = Round(xLabCostUnit, 2)

        Dim xOrderQty As Decimal
        If Me.TextBox1.Text.ToString.Contains(".") = False Then
            xOrderQty = Math.Round(CDec(Me.TextBox1.Text), 2)
        Else
            xOrderQty = CDec(Me.TextBox1.Text)
        End If
        Dim xGrossPer As Decimal
        If Me.tbDesGrossPer.Text.ToString.Contains(".") = False Then
            xGrossPer = Math.Round(CDec(Me.tbDesGrossPer.Text), 2)
        Else
            xGrossPer = CDec(Me.TextBox1.Text)
        End If


        Me.tb_LabperORder.Text = Math.Round(xLabCostUnit * xOrderQty, 2)
        Me.tb_LabperUnit.Text = Math.Round(xLabCostUnit, 2)
        Me.tb_MatPerOrder.Text = Math.Round(xMatCostOrder, 2)
        Me.tb_MatPerUnit.Text = Math.Round(xMatCostUnit, 2)

        'Get overhead amount
        Dim xOH As Decimal = MiscCode.GetOHRate
        Dim xProdIndex As Decimal = MiscCode.CalculateProdIndex
        xProdIndex = 1

        Me.Newtb_OHPerUnit.Text = Math.Round(((xOH * xLabourHours) * xProdIndex), 2)
        Me.tb_OHPerOrder.Text = Math.Round(CDec(Me.Newtb_OHPerUnit.Text), 2) * xOrderQty

        Me.tb_SP_PerUnit.Text = Math.Round(MiscCode.GetGrossMargingPerUnit((xMatCostUnit + xLabCostUnit), (xGrossPer)), 2)
        Me.tb_SPPerOrder.Text = Math.Round(CDec(Me.tb_SP_PerUnit.Text), 2) * xOrderQty
        Me.tb_GrossPerUnit.Text = Math.Round(CDec(Me.tb_SP_PerUnit.Text), 2) - Math.Round(CDec(Me.tb_LabperUnit.Text), 2) - Math.Round(CDec(Me.tb_MatPerUnit.Text), 2)
        Me.tb_GrossPerOrder.Text = Math.Round(CDec(Me.tb_GrossPerUnit.Text), 2) * xOrderQty
        Me.tb_NetperUnit.Text = Math.Round(CDec(Me.tb_GrossPerUnit.Text), 2) - Math.Round(CDec(Me.Newtb_OHPerUnit.Text), 2)
        Me.tb_NetperORder.Text = Math.Round(CDec(Me.tb_NetperUnit.Text), 2) * xOrderQty

        CalculateCapacity()
        Me.Chart1.Visible = True
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub FillLabour()
        Me.dgvLabour.DataSource = Nothing
        'Clear datagrid if colums exist
        Dim xCurCol As Integer = Me.dgvLabour.Columns.Count
        If xCurCol > 0 Then
            For xx As Integer = 0 To xCurCol - 1
                Me.dgvLabour.Columns.Remove(0)
            Next
        End If

        xLabourHours = 0

        Dim xHeaderList As ArrayList = FillHeader("LAB")
        'FillHeader()
        Dim xColNames As ArrayList = FillHeaderFields("LAB")
        Dim i As Integer
        Dim xTotUnits As Decimal
        xTotUnits = Me.TextBox1.Text

        'Add Datagrid Colums

        For i = 0 To xHeaderList.Count - 1
            Me.dgvLabour.Columns.Add(xColNames(i), xHeaderList(i))
            dgvLabour.Columns(xColNames(i).ToString).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvLabour.Columns(xColNames(i).ToString).DefaultCellStyle.Format = "F4"
        Next

        Me.LstLabourLinkTableAdapter1.FillByProductID(Me.DsProdDB1.lstLabourLink, Me.ComboBox1.SelectedValue)
        Dim xLabCount As Integer = Me.DsProdDB1.lstLabourLink.Count

        'Find out if the product has components in its materials
        Me.LstMaterialLinkTableAdapter1.FillByProductID(Me.DsProdDB1.lstMaterialLink, Me.ComboBox1.SelectedValue)
        Dim xHasComponents As Integer
        Dim dvMAT As New DataView(Me.DsProdDB1.lstMaterialLink, "txtType = 'Component'", "idtblProduct", DataViewRowState.CurrentRows)
        If dvMAT.Count > 0 Then
            xHasComponents = dvMAT.Count
            Me.LstComponentLabourTableAdapter1.FillByMaterialID(Me.DsProdDB1.lstComponentLabour, dvMAT(0)(11))
        End If

        ''now Populate the component labour rows
        Dim xCol As Integer
        If xHasComponents > 0 Then
            Try
                For i = 0 To Me.DsProdDB1.lstComponentLabour.Rows.Count - 1
                    Dim xVariable As String = String.Empty
                    If String.IsNullOrEmpty(MiscCode.MNS(Me.DsProdDB1.lstComponentLabour.Rows(i).Item("AppVariable"))) Then
                        xVariable = "No"
                    Else
                        xVariable = MiscCode.MNS(Me.DsProdDB1.lstComponentLabour.Rows(i).Item("AppVariable"))
                    End If
                    Me.dgvLabour.Rows.Add()
                    'Col 1
                    dgvLabour.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstComponentLabour.Rows(i).Item("Description")
                    xCol = xCol + 2
                    Dim xValueDesc As String = Me.DsProdDB1.lstComponentLabour.Rows(i).Item("txtValueDesc")
                    Dim xValue As Decimal = Me.DsProdDB1.lstComponentLabour.Rows(i).Item("dblValue")
                    'Col 3
                    dgvLabour.Rows(i).Cells(xCol).Value = CalcMinutesReq(xValue, xValueDesc)
                    xCol = xCol + 1
                    'Col 4
                    'dgvLabour.Rows(i).Cells(xCol).Value = dgvLabour.Rows(i).Cells(xCol - 1).Value / Me.TextBox7.Text
                    'xCol = xCol + 1

                    Dim xProdFactor As Decimal
                    If String.IsNullOrEmpty(MiscCode.MNS(Me.DsProdDB1.lstComponentLabour.Rows(i).Item("numEffPer"))) Then
                        xProdFactor = 1
                    Else
                        xProdFactor = Me.DsProdDB1.lstComponentLabour.Rows(i).Item("numEffPer")
                    End If
                    'Col 5
                    dgvLabour.Rows(i).Cells(xCol).Value = xProdFactor
                    xCol = xCol + 2
                    'Col 7
                    'dgvLabour.Rows(i).Cells(xCol).Value = (dgvLabour.Rows(i).Cells("dgvOpsReq1").Value * Me.TextBox7.Text)
                    If IsDBNull(Me.DsProdDB1.lstComponentLabour.Rows(i).Item("dblAdjValue")) Then
                        dgvLabour.Rows(i).Cells(xCol).Value = (dgvLabour.Rows(i).Cells("dgvOpsReq1").Value * Me.TextBox7.Text)
                        xCol = xCol + 1
                    Else
                        dgvLabour.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstComponentLabour.Rows(i).Item("dblAdjValue") / (MiscCode.GetComponentBatch(dvMAT(0)(11), -1) / MiscCode.GetComponentQtyReq(dvMAT(0)(11), -1))
                        xCol = xCol + 1
                    End If


                    'Col 8
                    dgvLabour.Rows(i).Cells(xCol).Value = (dgvLabour.Rows(i).Cells("dgvProjMinperOps").Value / Me.TextBox7.Text)
                    xCol = xCol + 2


                    'Col 10
                    dgvLabour.Rows(i).Cells(xCol).Value = dgvLabour.Rows(i).Cells("dgvAdjOpsReq").Value * Me.TextBox4.Text
                    xCol = xCol + 1
                    'Col 11
                    'dgvLabour.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstLabourLink.Rows(i).Item("dbllabourCost")
                    Dim xCost As Decimal = Round(CDec(Me.DsProdDB1.lstComponentLabour.Rows(i).Item("dblAdjCost") / (MiscCode.GetComponentBatch(Me.DsProdDB1.lstComponentLabour.Rows(i).Item("id_tblMaterial"), Me.ComboBox1.SelectedValue) / MiscCode.GetComponentQtyReq(Me.DsProdDB1.lstComponentLabour.Rows(i).Item("id_tblMaterial"), Me.ComboBox1.SelectedValue))), 4)

                    dgvLabour.Rows(i).Cells(xCol).Value = xCost 'Math.Round(Me.DsProdDB1.lstLabourLink.Rows(i).Item("dblAdjCost"), 4)
                    xCol = xCol + 1
                    'Col 12

                    dgvLabour.Rows(i).Cells(xCol).Value = dgvLabour.Rows(i).Cells("dgvLabCostperUnit").Value * Me.TextBox1.Text


                    xLabCostUnit = xLabCostUnit + dgvLabour.Rows(i).Cells("dgvLabCostperUnit").Value
                    xLabCostOrder = xLabCostOrder + dgvLabour.Rows(i).Cells("dgvLabCostOrder").Value
                    xCol = 0
                    xLabourHours = xLabourHours + Me.DsProdDB1.lstComponentLabour.Rows(i).Item("dblAdjValue")
                Next
            Catch ex As Exception
                MsgBox("No labour values loaded for this product", MsgBoxStyle.OkOnly, "CCP Messages")
            End Try
        End If

        ''now Populate the product labour rows
        xCol = 0
        Dim xRowCount As Integer
        If xHasComponents > 0 Then
            xRowCount = i
        End If

        Try
            For i = 0 To xLabCount - 1
                Dim xVariable As String = String.Empty
                If String.IsNullOrEmpty(MiscCode.MNS(Me.DsProdDB1.lstLabourLink.Rows(i).Item("AppVariable"))) Then
                    xVariable = "No"
                Else
                    xVariable = MiscCode.MNS(Me.DsProdDB1.lstLabourLink.Rows(i).Item("AppVariable"))
                End If
                Me.dgvLabour.Rows.Add()
                'Col 1
                dgvLabour.Rows(i + xRowCount).Cells(xCol).Value = Me.DsProdDB1.lstLabourLink.Rows(i).Item("Description")
                xCol = xCol + 2
                Dim xValueDesc As String = Me.DsProdDB1.lstLabourLink.Rows(i).Item("txtValueDesc")
                Dim xValue As Decimal = Me.DsProdDB1.lstLabourLink.Rows(i).Item("dblValue")
                'Col 3
                dgvLabour.Rows(i + xRowCount).Cells(xCol).Value = CalcMinutesReq(xValue, xValueDesc)
                xCol = xCol + 1
                'Col 4
                'dgvLabour.Rows(i).Cells(xCol).Value = dgvLabour.Rows(i).Cells(xCol - 1).Value / Me.TextBox7.Text
                'xCol = xCol + 1

                Dim xProdFactor As Decimal
                If String.IsNullOrEmpty(MiscCode.MNS(Me.DsProdDB1.lstLabourLink.Rows(i).Item("numEffPer"))) Then
                    xProdFactor = 1
                Else
                    xProdFactor = Me.DsProdDB1.lstLabourLink.Rows(i).Item("numEffPer")
                End If
                'Col 5
                dgvLabour.Rows(i).Cells(xCol).Value = xProdFactor
                xCol = xCol + 2
                'Col 7
                'dgvLabour.Rows(i).Cells(xCol).Value = (dgvLabour.Rows(i).Cells("dgvOpsReq1").Value * Me.TextBox7.Text)
                If IsDBNull(Me.DsProdDB1.lstLabourLink.Rows(i).Item("dblAdjValue")) Then
                    dgvLabour.Rows(i + xRowCount).Cells(xCol).Value = (dgvLabour.Rows(i + xRowCount).Cells("dgvOpsReq1").Value * Me.TextBox7.Text)
                    xCol = xCol + 1
                Else
                    dgvLabour.Rows(i + xRowCount).Cells(xCol).Value = Me.DsProdDB1.lstLabourLink.Rows(i).Item("dblAdjValue")
                    xCol = xCol + 1
                End If


                'Col 8
                dgvLabour.Rows(i + xRowCount).Cells(xCol).Value = (dgvLabour.Rows(i + xRowCount).Cells("dgvProjMinperOps").Value / Me.TextBox7.Text)
                xCol = xCol + 2


                'Col 10
                dgvLabour.Rows(i + xRowCount).Cells(xCol).Value = dgvLabour.Rows(i + xRowCount).Cells("dgvAdjOpsReq").Value * Me.TextBox4.Text
                xCol = xCol + 1
                'Col 11
                'dgvLabour.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstLabourLink.Rows(i).Item("dbllabourCost")
                Dim xCost As Decimal = Round(CDec(Me.DsProdDB1.lstLabourLink.Rows(i).Item("dblAdjCost")), 4)

                dgvLabour.Rows(i + xRowCount).Cells(xCol).Value = xCost 'Math.Round(Me.DsProdDB1.lstLabourLink.Rows(i).Item("dblAdjCost"), 4)
                xCol = xCol + 1
                'Col 12

                dgvLabour.Rows(i + xRowCount).Cells(xCol).Value = dgvLabour.Rows(i + xRowCount).Cells("dgvLabCostperUnit").Value * Me.TextBox1.Text


                xLabCostUnit = xLabCostUnit + dgvLabour.Rows(i + xRowCount).Cells("dgvLabCostperUnit").Value
                xLabCostOrder = xLabCostOrder + dgvLabour.Rows(i + xRowCount).Cells("dgvLabCostOrder").Value
                xCol = 0
                xLabourHours = xLabourHours + Me.DsProdDB1.lstLabourLink.Rows(i).Item("dblAdjValue")
            Next
        Catch ex As Exception
            MsgBox("No labour values loaded for this product", MsgBoxStyle.OkOnly, "CCP Messages")
        End Try

        dgvLabour.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvLabour.Columns(0).DefaultCellStyle.Format = "g"
        dgvLabour.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader

        MiscCode.ResizeGrid(dgvLabour)


        'xLabCostUnit = MiscCode.FillLabourByProduct(Me.ComboBox1.SelectedValue, Me.TextBox1.Text, xLabourCost, xLabourHours)

    End Sub

    Private Function FillHeader(ByVal xdgv As String)
        Dim xArr As New ArrayList
        If xdgv = "LAB" Then
            xArr.Add("Operation description")
            xArr.Add("Overide value")
            xArr.Add("Standard minutes per operation")
            'xArr.Add("dgvOpsReq1")
            xArr.Add("Calculated labour effiency")
            xArr.Add("Overide labour effiency")
            xArr.Add("Projected required minutes per operator")
            xArr.Add("Operators required adjusted for labour eff.")
            'xArr.Add("dgvAdjOpsReq")
            xArr.Add("Actual operators planned")
            xArr.Add("Planned total hours required")
            xArr.Add("Labour cost per unit")
            xArr.Add("Labour cost for total order")
        End If
        If xdgv = "MAT" Then
            xArr.Add("Operation description")
            xArr.Add("Own materials required")
            xArr.Add("Materials required at standard")
            xArr.Add("Projected wasteage")
            xArr.Add("Materials required adjusted for waste")
            xArr.Add("Actual materials planned")
            xArr.Add("Planned order materials required")
            xArr.Add("Unit of measure")
            xArr.Add("Own unit cost")
            xArr.Add("Standard unit cost")
            xArr.Add("Material cost per unit")
            xArr.Add("Material cost for order")
            xArr.Add("Type")
        End If

        If xdgv = "CAP" Then
            xArr.Add("Department")
            xArr.Add("Production capacity")
            xArr.Add("Planned production")
            xArr.Add("Production load with this order")
            xArr.Add("Available capacity")

        End If
        Return xArr
    End Function

    Private Function FillHeaderFields(ByVal xdgv As String) As ArrayList
        Dim xArr As New ArrayList
        If xdgv = "LAB" Then
            xArr.Add("dgvOps")
            xArr.Add("dgvOveride")
            xArr.Add("dgvOpsReq")
            'xArr.Add("dgvOpsReq1")
            xArr.Add("dgvLabEffCalc")
            xArr.Add("dgvLabEffOverid")
            xArr.Add("dgvProjMinperOps")
            xArr.Add("dgvAdjOpsReq")
            xArr.Add("dgvOpsPlanned")
            xArr.Add("dgvHoursReq")
            xArr.Add("dgvLabCostperUnit")
            xArr.Add("dgvLabCostOrder")
        End If
        If xdgv = "MAT" Then
            xArr.Add("dgvOps")
            xArr.Add("dgvOveride")
            xArr.Add("dgvStdReq")
            xArr.Add("dgvWaste")
            xArr.Add("dgvWasteAdj")
            xArr.Add("dgvActPlanned")
            xArr.Add("dgvOrderPlanned")
            xArr.Add("dgvUOM")
            xArr.Add("dgvOwnUnit")
            xArr.Add("dgvstdUnitCost")
            xArr.Add("dgvMatCostperUnit")
            xArr.Add("dgvMatCostOrder")
            xArr.Add("dgvType")
        End If

        If xdgv = "CAP" Then
            xArr.Add("txtDepName")
            xArr.Add("Hours")
            xArr.Add("Budgetedproduction")
            xArr.Add("CurrentOrderTime")
            xArr.Add("SpareCapacity")

        End If
        Return xArr
    End Function

    Private Sub FillMat()
        Me.dgvMaterial.DataSource = Nothing
        xMatCostUnit = 0
        xMatCostOrder = 0

        Me.dgvMaterial.Columns.Clear()
        Me.dgvMaterial.Rows.Clear()

        Dim xHeaderList As ArrayList = FillHeader("MAT")
        'FillHeader()
        Dim xColNames As ArrayList = FillHeaderFields("MAT")
        Dim i As Integer
        Dim xTotUnits As Decimal
        xTotUnits = Me.TextBox1.Text

        'Add Datagrid Colums
        'Dim xProdCount As Integer = Me.DsOHDB1.lstMarginsperProduct.Count
        For i = 0 To xHeaderList.Count - 1
            Me.dgvMaterial.Columns.Add(xColNames(i), xHeaderList(i))
            dgvMaterial.Columns(xColNames(i).ToString).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvMaterial.Columns(xColNames(i).ToString).DefaultCellStyle.Format = "n"
            dgvMaterial.Columns(xColNames(i).ToString).Width = 100
        Next



        If Me.ComboBox2.Text = "All" Then
            Me.LstMaterialLinkTableAdapter1.FillByProductID(Me.DsProdDB1.lstMaterialLink, Me.ComboBox1.SelectedValue)
            Me.LstComponentLinkTableAdapter1.FillByProductID(Me.DsProdDB1.lstComponentLink, Me.ComboBox1.SelectedValue)
        Else
            'Me.LstMaterialLinkTableAdapter1.FillByProductType(Me.DsProdDB1.lstMaterialLink, Me.ComboBox1.SelectedValue, Me.ComboBox2.SelectedValue) 'Me.CheckedListBox1.CheckedItems(0).ToString)
            Me.LstMaterialLinkTableAdapter1.FillByProductType(Me.DsProdDB1.lstMaterialLink, Me.ComboBox1.SelectedValue, Me.ComboBox2.SelectedItem)
        End If

        Dim xMatCount As Integer = Me.DsProdDB1.lstMaterialLink.Count

        'Check if material standards were loaded
        If xMatCount = 1 Then
            If Me.DsProdDB1.lstMaterialLink.Rows(0).Item("dblMatQty").ToString = "" Then
                MsgBox("No material standards were loaded")
                Exit Sub
            End If
        End If

        Dim xMatID As Integer
        Dim xComponentID As Integer
        Dim xIsComponent As Boolean = False
        Dim dvComp As New DataView(Me.DsProdDB1.lstComponentLink)
        dvComp.Sort = "id_tblMaterial"
        Dim xHasMaterial As Boolean
        Dim xx As Integer


        ''now Populate the rows
        Dim xCol As Integer
        For i = 0 To xMatCount - 1
            xMatID = Me.DsProdDB1.lstMaterialLink.Rows(i).Item("id_tblMaterial")
            xComponentID = dvComp.Find(xMatID)
            If xComponentID >= 0 Then
                'Calculate how much of the component material is required
                dvComp.RowFilter = "id_tblMaterial = " & xMatID
                Dim xBatchSize As Decimal = Decimal.Parse(dvComp(0).Item("dblBatchSize").ToString())
                Dim xTotReq As Decimal = GetComponentReq(dvComp(0).Item("fk_ComponentLinkID"), dvComp(0).Item("fk_tblProduct"))
                xTotReq = (xTotReq * xTotUnits) / xBatchSize
                Dim xCompQty As Decimal = Decimal.Parse(dvComp(0).Item("dblMatQty").ToString()) * xTotReq
                Dim xCompCost As Decimal = Decimal.Parse(dvComp(0).Item("dblMatCost").ToString()) * xTotReq

                'Now fill the next row of the datagrid
                Me.dgvMaterial.Rows.Add()
                dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstMaterialLink.Rows(i).Item(13)
                xCol = xCol + 2
                dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstMaterialLink.Rows(i).Item("dblMatQty")
                xCol = xCol + 4
                dgvMaterial.Rows(i).Cells(xCol).Value = (Me.DsProdDB1.lstMaterialLink.Rows(i).Item("dblMatQty") * xTotUnits) + xCompQty
                xCol = xCol + 1
                dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstMaterialLink.Rows(i).Item("txtMaterialUnit")
                xCol = xCol + 2
                'dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstMaterialLink.Rows(i).Item("dblMatCost") / Me.DsProdDB1.lstMaterialLink.Rows(i).Item("dblMatQty")
                dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstMaterialLink.Rows(i).Item("dblMatCost")
                xCol = xCol + 1
                dgvMaterial.Rows(i).Cells(xCol).Value = dgvMaterial.Rows(i).Cells("dgvstdUnitCost").Value
                xCol = xCol + 1
                dgvMaterial.Rows(i).Cells(xCol).Value = (xTotUnits * dgvMaterial.Rows(i).Cells("dgvMatCostperUnit").Value) + xCompCost
                xCol = xCol + 1
                dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstMaterialLink.Rows(i).Item("txtType")
                xMatCostUnit = xMatCostUnit + dgvMaterial.Rows(i).Cells("dgvMatCostperUnit").Value + (xCompCost / xTotUnits)
                xMatCostOrder = xMatCostOrder + dgvMaterial.Rows(i).Cells("dgvMatCostOrder").Value
                xCol = 0
                dvComp.RowFilter = ""
            End If

            If Me.DsProdDB1.lstMaterialLink.Rows(i).Item("txtType").ToString() = "Component" Then
                xIsComponent = True
            Else
                xIsComponent = False
            End If
            If xIsComponent = False And xComponentID < 0 Then
                Me.dgvMaterial.Rows.Add()
                dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstMaterialLink.Rows(i).Item(13)
                xCol = xCol + 2
                dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstMaterialLink.Rows(i).Item("dblMatQty")
                xCol = xCol + 4
                dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstMaterialLink.Rows(i).Item("dblMatQty") * xTotUnits
                xCol = xCol + 1
                dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstMaterialLink.Rows(i).Item("txtMaterialUnit")
                xCol = xCol + 2
                'dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstMaterialLink.Rows(i).Item("dblMatCost") / Me.DsProdDB1.lstMaterialLink.Rows(i).Item("dblMatQty")
                dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstMaterialLink.Rows(i).Item("dblMatCost")
                xCol = xCol + 1
                dgvMaterial.Rows(i).Cells(xCol).Value = dgvMaterial.Rows(i).Cells("dgvstdUnitCost").Value
                xCol = xCol + 1
                dgvMaterial.Rows(i).Cells(xCol).Value = xTotUnits * dgvMaterial.Rows(i).Cells("dgvMatCostperUnit").Value
                xCol = xCol + 1
                dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstMaterialLink.Rows(i).Item("txtType")
                xMatCostUnit = xMatCostUnit + dgvMaterial.Rows(i).Cells("dgvMatCostperUnit").Value
                xMatCostOrder = xMatCostOrder + dgvMaterial.Rows(i).Cells("dgvMatCostOrder").Value
                xCol = 0
            ElseIf xComponentID = -1 Then
                Me.dgvMaterial.Rows.Add()
                dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstMaterialLink.Rows(i).Item(13)
                xCol = xCol + 2
                dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstMaterialLink.Rows(i).Item("dblMatQty")
                xCol = 0
            End If

        Next

        Dim xRowNo As Integer = i
        'Now add rows to the datagrid that is materials used in the component but not in the Product
        Dim dv_MatLink As New DataView(DsProdDB1.lstMaterialLink)
        dv_MatLink.Sort = "id_tblMaterial"

        For i = 0 To Me.DsProdDB1.lstComponentLink.Rows.Count - 1
            xMatID = Me.DsProdDB1.lstComponentLink.Rows(i).Item("id_tblMaterial")
            xComponentID = dv_MatLink.Find(xMatID)
            If xComponentID = -1 Then
                'Calculate how much of the component material is required
                dvComp.RowFilter = "id_tblMaterial = " & xMatID
                Dim xBatchSize As Decimal = Decimal.Parse(dvComp(0).Item("dblBatchSize").ToString())
                Dim xTotReq As Decimal = GetComponentReq(dvComp(0).Item("fk_ComponentLinkID"), dvComp(0).Item("fk_tblProduct"))
                xTotReq = (xTotReq * xTotUnits) / xBatchSize
                Dim xCompQty As Decimal = Decimal.Parse(dvComp(0).Item("dblMatQty").ToString()) * xTotReq
                Dim xCompCost As Decimal = Decimal.Parse(dvComp(0).Item("dblMatCost").ToString()) * xTotReq

                'Now fill the next row of the datagrid
                Me.dgvMaterial.Rows.Add()
                dgvMaterial.Rows(i + xRowNo).Cells(xCol).Value = dvComp(0).Item("txtMaterialDesc").ToString()
                xCol = xCol + 2
                dgvMaterial.Rows(i + xRowNo).Cells(xCol).Value = dvComp(0).Item("dblMatQty").ToString()
                xCol = xCol + 4
                dgvMaterial.Rows(i + xRowNo).Cells(xCol).Value = xCompQty
                xCol = xCol + 1
                dgvMaterial.Rows(i + xRowNo).Cells(xCol).Value = dvComp(0).Item("txtMaterialUnit").ToString()
                xCol = xCol + 2
                'dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProdDB1.lstMaterialLink.Rows(i).Item("dblMatCost") / Me.DsProdDB1.lstMaterialLink.Rows(i).Item("dblMatQty")
                dgvMaterial.Rows(i + xRowNo).Cells(xCol).Value = dvComp(0).Item("dblMatCost").ToString()
                xCol = xCol + 1
                dgvMaterial.Rows(i + xRowNo).Cells(xCol).Value = dgvMaterial.Rows(i + xRowNo).Cells("dgvstdUnitCost").Value
                xCol = xCol + 1
                dgvMaterial.Rows(i + xRowNo).Cells(xCol).Value = xCompCost
                xCol = xCol + 1
                dgvMaterial.Rows(i + xRowNo).Cells(xCol).Value = dvComp(0).Item("txtType").ToString()
                Dim xText As Decimal = (dgvMaterial.Rows(i + xRowNo).Cells("dgvstdUnitCost").Value / xBatchSize) * GetComponentQtyReq(dvComp(0).Item("id_tblComponent"))
                xMatCostUnit = xMatCostUnit + (dgvMaterial.Rows(i + xRowNo).Cells("dgvstdUnitCost").Value / xBatchSize) * GetComponentQtyReq(dvComp(0).Item("id_tblComponent"))
                xMatCostOrder = xMatCostOrder + xCompCost
                xCol = 0
                dvComp.RowFilter = ""
            Else
                xCol = 0
                xRowNo = xRowNo - 1
            End If
        Next


        'Set the description column
        Dim xLen As Integer
        Dim xMax As Integer
        For Each xRow As DataGridViewRow In dgvMaterial.Rows
            xLen = Len(xRow.Cells(0).Value.ToString())
            If xLen > xMax Then xMax = xLen
        Next

        dgvMaterial.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvMaterial.Columns(0).DefaultCellStyle.Format = "g"
        dgvMaterial.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader

        MiscCode.ResizeGrid(dgvMaterial)

    End Sub

    Private Function CalcMinutesReq(ByVal xValue As Decimal, ByVal xValueDesc As String)

        Select Case xValueDesc
            Case "Minute"
                Return xValue
            Case "Hour"
                Return xValue * 60
            Case "Seconds"
                Return xValue / 60
            Case Else
                Return xValue

        End Select

    End Function

    Private Sub ComboBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.TextChanged

        If Me.ComboBox2.Tag = "Selected" Then
            FillMat()
        End If

    End Sub

    Private Sub CloseFormToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseFormToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim frm As New frmAccountingMain
        frmAccountingMain.QQArray.Clear()
        frmAccountingMain.QQArray.Add(Me.ComboBox1.SelectedValue)
        frmAccountingMain.QQArray.Add(Me.tbDesGrossPer.Text)
        frmAccountingMain.QQArray.Add(Me.TextBox1.Text)
        If Me.ComboBox3.SelectedValue Is Nothing Then
            MsgBox("No customer has been selected.  Please select a customer when the quote screen is shown")
        Else
            xQQCusID = Me.ComboBox3.SelectedValue
        End If
        frm.Tag = "QQ"
        Me.Close()
        frm.Show()

    End Sub

    Private Sub TabPage_QuickQuote_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles TabPage_QuickQuote.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub TabPage_QuickQuote_Resize(sender As Object, e As System.EventArgs) Handles TabPage_QuickQuote.Resize
        Me.Invalidate()
    End Sub

    Private Sub TabPage_Lab_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles TabPage_Lab.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub TabPage_Lab_Resize(sender As Object, e As System.EventArgs) Handles TabPage_Lab.Resize
        Me.Invalidate()
    End Sub

    Private Sub TabPage_Mat_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles TabPage_Mat.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub TabPage_Mat_Resize(sender As Object, e As System.EventArgs) Handles TabPage_Mat.Resize
        Me.Invalidate()
    End Sub

    Private Sub TabPage_Quoting_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles TabPage_Quoting.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub TabPage_Quoting_Paint(sender As Object, e As System.EventArgs) Handles TabPage_Quoting.Resize, TabPage_Quoting.Paint
        Me.Invalidate()
    End Sub

    Private Sub CalculateCapacity()

        Dim strSQL As String = "Select * from lstConstraintStaff"
        Dim xCon As New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        Dim xAdap As New SqlClient.SqlDataAdapter(strSQL, xCon)
        Dim ds As New DataSet
        xAdap.Fill(ds, "Staff")
        ds.Tables("Staff").Columns.Add("Hours")

        Dim xTotalAvailable As Decimal

        For Each xRow As DataRow In ds.Tables("Staff").Rows
            xRow("Hours") = ((xRow("NoOfStaff") * (((xNormalLab * 4) * 4) + (xFridayLab * 4))) * ((xRow("numEffPer") / 100)))
            xTotalAvailable = xTotalAvailable + ((xRow("NoOfStaff") * (((xNormalLab * 4) * 4) + (xFridayLab * 4))) * ((xRow("numEffPer") / 100)))
        Next

        'Now determine the production time for the budgeted products 
        Dim xMonth As String = MonthName(Month(Now())).Substring(0, 3)
        strSQL = "Select FK_tblDept, txtValueDesc, Sum((dblAdjValue*dblFreq) * decVolume) as TheTime from lstLabCostPerMonth where txtPeriodDescriptor = '" & xMonth & "' Group by FK_tblDept, txtValueDesc"
        xAdap.SelectCommand.CommandText = strSQL
        xAdap.Fill(ds, "LabCost")
        ds.Tables("LabCost").Columns.Add("Convert2Hour", GetType(Decimal))

        Dim xValueDesc As String

        For Each yRow As DataRow In ds.Tables("LabCost").Rows
            xValueDesc = yRow("txtValueDesc")
            Select Case xValueDesc
                Case "Minute"
                    yRow("Convert2Hour") = yRow("TheTime") / 60
                Case "Hour"
                    yRow("Convert2Hour") = yRow("TheTime")
                Case "Day"
                    yRow("Convert2Hour") = yRow("TheTime") / xNormalLab
                Case "Week"
                    yRow("Convert2Hour") = yRow("TheTime") / ((xNormalLab * 4) + xFridayLab)
                Case "Month"
                    yRow("Convert2Hour") = yRow("TheTime") / (((xNormalLab * 4) + xFridayLab) * 4)
            End Select
        Next

        'Combine the two tables
        ds.Tables("Staff").Columns.Add("BudgetProduction")
        Dim xDept As Integer
        Dim xFilter As String
        Dim tmp As DataTable
        tmp = ds.Tables("LabCost")

        For Each xRow As DataRow In ds.Tables("STaff").Rows
            xDept = xRow("idTblDept")
            xFilter = "FK_tblDept = " & xDept
            xRow("BudgetProduction") = tmp.Compute("Sum(Convert2Hour)", xFilter)
        Next

        'Now add current order to table
        ds.Tables("Staff").Columns.Add("CurrentOrder", GetType(Decimal))
        ds.Tables("Staff").Columns.Add("SpareCapacity", GetType(Decimal))

        strSQL = "Select txtValueDesc, fk_tblDept, TotalTime from lstLabCostperProdandDept where fk_tblProduct = " & Me.ComboBox1.SelectedValue
        xAdap.SelectCommand.CommandText = strSQL
        xAdap.Fill(ds, "Current")
        ds.Tables("Current").Columns.Add("CurrentOrderTime", GetType(Decimal))

        For Each yRow As DataRow In ds.Tables("Current").Rows
            xValueDesc = yRow("txtValueDesc")
            Select Case xValueDesc
                Case "Minute"
                    yRow("CurrentOrderTime") = (yRow("TotalTime") * Me.TextBox1.Text) / 60
                Case "Hour"
                    yRow("CurrentOrderTime") = yRow("TotalTime") * Me.TextBox1.Text
                Case "Day"
                    yRow("CurrentOrderTime") = (yRow("TotalTime") * Me.TextBox1.Text) / xNormalLab
                Case "Week"
                    yRow("CurrentOrderTime") = (yRow("TotalTime") * Me.TextBox1.Text) / ((xNormalLab * 4) + xFridayLab)
                Case "Month"
                    yRow("CurrentOrderTime") = (yRow("TotalTime") * Me.TextBox1.Text) / (((xNormalLab * 4) + xFridayLab) * 4)
            End Select
        Next

        tmp = ds.Tables("Current")


        For Each xRow As DataRow In ds.Tables("STaff").Rows
            xDept = xRow("idTblDept")
            xFilter = "FK_tblDept = " & xDept
            xRow("CurrentOrder") = tmp.Compute("Sum(CurrentOrderTime)", xFilter)
            xRow("SpareCapacity") = xRow("Hours") - MND(xRow("Budgetproduction").ToString()) - MND(xRow("CurrentOrder").ToString())
        Next

        FillCapacity(ds)

        ds.Dispose()

        Dim xNewlLabel As String = Me.Label21.Text.Replace("XXX", xMonth)
        Me.Label21.Text = xNewlLabel

        Me.Label21.Visible = True
        Me.dgvCapacity.Visible = True

    End Sub

    Private Function MND(ByVal xInVal As String)
        If String.IsNullOrEmpty(xInVal) Then
            Return 0
        Else
            Return Decimal.Parse(xInVal)
        End If
    End Function

    Private Sub FillCapacity(ByVal ds As DataSet)

        Me.dgvCapacity.DataSource = Nothing
        'Clear datagrid if colums exist
        Dim xCurCol As Integer = Me.dgvCapacity.Columns.Count
        If xCurCol > 0 Then
            Me.dgvCapacity.Rows.Clear()
            Me.dgvCapacity.Columns.Clear()
        End If

        xLabourHours = 0

        Dim xHeaderList As ArrayList = FillHeader("CAP")
        'FillHeader()
        Dim xColNames As ArrayList = FillHeaderFields("CAP")
        Dim i As Integer
        Dim xTotUnits As Decimal
        xTotUnits = Me.TextBox1.Text

        'Add Datagrid Colums

        For i = 0 To xHeaderList.Count - 1
            Me.dgvCapacity.Columns.Add(xColNames(i), xHeaderList(i))
            dgvCapacity.Columns(xColNames(i).ToString).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvCapacity.Columns(xColNames(i).ToString).DefaultCellStyle.Format = "F2"
        Next


        Dim xLabCount As Integer = ds.Tables("Staff").Rows.Count

        ''now Populate the rows
        Dim xCol As Integer
        Try
            For i = 0 To xLabCount - 1

                Me.dgvCapacity.Rows.Add()
                dgvCapacity.Rows(i).Cells(xCol).Value = ds.Tables("Staff").Rows(i).Item("txtDepName")
                xCol = xCol + 1
                dgvCapacity.Rows(i).Cells(xCol).Value = Math.Round(MND(ds.Tables("Staff").Rows(i).Item("Hours").ToString()), 2)
                xCol = xCol + 1
                dgvCapacity.Rows(i).Cells(xCol).Value = Math.Round(MND(ds.Tables("Staff").Rows(i).Item("BudgetProduction").ToString()), 2)
                xCol = xCol + 1
                dgvCapacity.Rows(i).Cells(xCol).Value = Math.Round(MND(ds.Tables("Staff").Rows(i).Item("CurrentOrder").ToString()), 2)
                xCol = xCol + 1
                dgvCapacity.Rows(i).Cells(xCol).Value = Math.Round(MND(ds.Tables("Staff").Rows(i).Item("SpareCapacity").ToString()), 2)
                xCol = 0
            Next
        Catch ex As Exception
            MsgBox("Problem encounter whilst filling the capacity grid", MsgBoxStyle.OkOnly, "CCP Messages")
        End Try

        dgvCapacity.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCapacity.Columns(0).DefaultCellStyle.Format = "g"
        dgvCapacity.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader

        MiscCode.ResizeGrid(dgvCapacity, False)
        dgvCapacity.RowHeadersVisible = False

        'Now create the graph

        Me.Chart1.Series.Clear()
        Me.Chart1.DataSource = ds

        Dim xSeries As String
        xCol = 7

        Dim xColArr As New ArrayList
        xColArr.Add(Color.Blue)
        xColArr.Add(Color.Orange)
        xColArr.Add(Color.Green)
        xColArr.Add(Color.Red)


        For i = 0 To 2 'ds.Tables("Staff").Rows.Count - 1
            xSeries = "Series" & i + 1
            Me.Chart1.Series.Add(xSeries)

            Me.Chart1.Series(xSeries).XValueMember = ds.Tables("Staff").Columns(0).ToString
            Me.Chart1.Series(xSeries).ChartType = DataVisualization.Charting.SeriesChartType.StackedBar
            Me.Chart1.Series(xSeries).YValueMembers = ds.Tables("Staff").Columns(xCol).ToString
            Me.Chart1.Series(xSeries).Color = xColArr(i)

            'If i = 2 And ds.Tables("Staff").Rows(i + 1).Item(xCol) < 0 Then
            '    Me.Chart1.Series(xSeries).Color = xColArr(i + 1)
            'End If

            Me.Chart1.Series(xSeries).Name = Me.dgvCapacity.Columns(i + 2).HeaderText
            xCol = xCol + 1




        Next

        Me.Chart1.DataBind()


    End Sub

    Private Sub ts_CreateTemp_Click(sender As System.Object, e As System.EventArgs) Handles ts_CreateTemp.Click

        'First check if a current temporary product is in the system
        If QQ_Variables.xNewID > 0 Then
            Dim xResponse As MsgBoxResult
            xResponse = MsgBox("A current product exist that has not been saved.  The product is " & QQ_Variables.xProdCode & " " & QQ_Variables.xProdDesc & ".  This product must first be saved or deleted.  Do you want to save the product?", MsgBoxStyle.YesNoCancel, My.Settings.SysName)
            If xResponse = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            If xResponse = MsgBoxResult.No Then
                MiscCode.DeleteTmpProduct(QQ_Variables.xNewID)
                QQ_Variables.xNewID = 0
                QQ_Variables.xProdCopyID = 0
                QQ_Variables.xProdCode = String.Empty
                QQ_Variables.xProdDesc = String.Empty
                QQ_Variables.xSpec1 = String.Empty
                QQ_Variables.xSpec2 = String.Empty
                QQ_Variables.xSpec3 = String.Empty
            End If
            If xResponse = MsgBoxResult.Yes Then
                QQ_Variables.xNewID = 0
                QQ_Variables.xProdCopyID = 0
                QQ_Variables.xProdCode = String.Empty
                QQ_Variables.xProdDesc = String.Empty
                QQ_Variables.xSpec1 = String.Empty
                QQ_Variables.xSpec2 = String.Empty
                QQ_Variables.xSpec3 = String.Empty
            End If

        End If

        Dim dia As Form = diaTmpProduct
        dia.ShowDialog()

        If dia.DialogResult = Windows.Forms.DialogResult.OK Then

            Me.TblProductTableAdapter1.FillByProductID(Me.DsProdDB1.tblProduct, QQ_Variables.xProdCopyID)
            Me.TblProdLinkTableAdapter1.FillByProduct(Me.DsProdDB1.tblProdLink, QQ_Variables.xProdCopyID)
            Me.TblMatLinkTableAdapter1.FillByProductID(Me.DsProdDB1.tblMatLink, QQ_Variables.xProdCopyID)

            Dim xError As String = String.Empty
            If Me.DsProdDB1.Tables("tblProdLink").Rows.Count = 0 Then
                xError = "no labour specification"
            End If

            If Me.DsProdDB1.Tables("tblMatLink").Rows.Count = 0 Then
                If xError = String.Empty Then
                    xError = "no material specification"
                Else
                    xError = xError & " and no material specification"
                End If
            End If

            If Len(xError) > 0 Then
                MsgBox("This product can not be used to base another product on because " & xError)
                Exit Sub
            End If



            Dim strIns As String = "Insert into tblProduct (txtProdCde,txtProdDesc,txtCostSortCat,txtCostSortItem,FK_idtblCoInfo,txtProdSpec1,txtProdSpec2,txtProdSpec3) Values('" & QQ_Variables.xProdCode & "', '" & QQ_Variables.xProdDesc & "', '" & Me.DsProdDB1.tblProduct.Rows(0).Item("txtCostSortCat").ToString() & "', '999', " & MiscCode.GetCoNo & ", '" & QQ_Variables.xSpec1 & "', '" & QQ_Variables.xSpec2 & "', '" & QQ_Variables.xSpec3 & "')"
            Dim xCon As New SqlConnection(My.Settings.ConnectionString1)
            Dim xCom As New SqlCommand(strIns, xCon)
            xCon.Open()
            xCom.ExecuteNonQuery()
            xCom.CommandText = "Select @@Identity"
            QQ_Variables.xNewID = xCom.ExecuteScalar
            xCon.Close()

            'Create the labour standards the new product

            Dim xCols As New ArrayList
            For Each xCol As DataColumn In Me.DsProdDB1.tblProdLink.Columns
                xCols.Add(xCol.ColumnName)
            Next

            Dim xRow As DataRow
            Dim xRowNo As Integer

            For xRowNo = 0 To Me.DsProdDB1.tblProdLink.Rows.Count - 1
                xRow = Me.DsProdDB1.tblProdLink.Rows(xRowNo)
                bs_ProdLink.AddNew()
                Dim i As Integer

                For i = 1 To xCols.Count - 1
                    If xCols(i) = "fk_tblProduct" Then
                        Me.bs_ProdLink.Current.Row.item(xCols(i)) = QQ_Variables.xNewID
                    Else
                        Me.bs_ProdLink.Current.Row.item(xCols(i)) = xRow.Item(xCols(i))
                    End If
                Next
            Next

            bs_ProdLink.EndEdit()
            Me.TblProdLinkTableAdapter1.Update(Me.DsProdDB1.tblProdLink)


            'Create the Material standards the new product

            xCols.Clear()
            For Each xCol As DataColumn In Me.DsProdDB1.tblMatLink.Columns
                xCols.Add(xCol.ColumnName)
            Next

            xRow = Nothing
            xRowNo = 0

            For xRowNo = 0 To Me.DsProdDB1.tblMatLink.Rows.Count - 1
                xRow = Me.DsProdDB1.tblMatLink.Rows(xRowNo)
                bs_MatLink.AddNew()
                Dim i As Integer

                For i = 1 To xCols.Count - 1
                    If xCols(i) = "fk_tblProduct" Then
                        Me.bs_MatLink.Current.Row.item(xCols(i)) = QQ_Variables.xNewID
                    Else
                        Me.bs_MatLink.Current.Row.item(xCols(i)) = xRow.Item(xCols(i))
                    End If
                Next
            Next

            bs_MatLink.EndEdit()
            Me.TblMatLinkTableAdapter1.Update(Me.DsProdDB1.tblMatLink)

            MsgBox("New product " & QQ_Variables.xProdCode & " " & QQ_Variables.xProdDesc & " was created", , My.Settings.SysName)
            Fill_cb_NotType()



        End If


    End Sub

    Private Sub ts_EditProduct_Click(sender As System.Object, e As System.EventArgs) Handles ts_EditProduct.Click
        If QQ_Variables.xNewID >= 0 Then
            Dim dia As New dProductAdd
            dia.Tag = QQ_Variables.xNewID
            dia.ShowDialog()
        Else
            MsgBox("You have to create a product before it can be edited", , My.Settings.SysName)
        End If
    End Sub

    Private Sub ts_EditLabour_Click(sender As System.Object, e As System.EventArgs) Handles ts_EditLabour.Click
        If QQ_Variables.xNewID >= 0 Then
            Dim dia As New frmStaff
            dia.Tag = QQ_Variables.xNewID
            dia.TabControl1.SelectTab(2)
            dia.StartPosition = FormStartPosition.CenterScreen
            xComboID = QQ_Variables.xNewID
            dia.ShowDialog()
        Else
            MsgBox("You have to create a product before it can be edited", , My.Settings.SysName)
        End If
    End Sub

    Private Sub ts_EditMaterial_Click(sender As System.Object, e As System.EventArgs) Handles ts_EditMaterial.Click
        If QQ_Variables.xNewID >= 0 Then
            Dim dia As New frmMaterial
            dia.Tag = QQ_Variables.xNewID
            dia.TabControl1.SelectTab(1)
            dia.StartPosition = FormStartPosition.CenterScreen
            xComboID = QQ_Variables.xNewID
            dia.ShowDialog()
        Else
            MsgBox("You have to create a product before it can be edited", , My.Settings.SysName)
        End If
    End Sub

    Private Sub ts_EditBudget_Click(sender As System.Object, e As System.EventArgs) Handles ts_EditBudget.Click
        If QQ_Variables.xNewID >= 0 Then
            Dim dia As New frmProduct
            dia.Tag = QQ_Variables.xNewID
            dia.TabControl2.SelectTab(1)
            dia.StartPosition = FormStartPosition.CenterScreen
            xComboID = QQ_Variables.xNewID
            dia.ShowDialog()
        Else
            MsgBox("You have to create a product before it can be edited", , My.Settings.SysName)
        End If
    End Sub

    Private Sub TabPage_Quoting_Enter(sender As Object, e As System.EventArgs) Handles TabPage_Quoting.Enter
        Dim xQuoteID As Integer

        Me.GroupBox4.Visible = True
        Me.GroupBox5.Visible = True
        Me.DataGridView2.BackgroundColor = myGBColor

        Me.TblCoInfoTableAdapter1.Fill(Me.DsAccounting.tblCoInfo)
        Me.TblCustomerTableAdapter1.Fill(Me.DsProdDB1.tblCustomer)
        Me.TblProductBindingSource1.ResetBindings(True)
        Me.cb_Quote_Customer.SelectedValue = -1

        Me.TblProductTableAdapter1.FillByComboInfo(Me.DsProdDB1.tblProduct)
        Me.TblProductBindingSource1.ResetBindings(True)
        Me.cb_Quote_Product.DataSource = Me.TblProductBindingSource1
        Me.cb_Quote_Product.DisplayMember = "ComboInfo"
        Me.cb_Quote_Product.ValueMember = "idtblProduct"


        'If Me.DataGridView2.Visible = False Then
        Dim xCusNo As Integer
        Dim xQuoteNo As String = "0"

        Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        myConnection.Open()
        Dim myCommand = New SqlClient.SqlCommand
        myCommand = New SqlClient.SqlCommand("Select Max(dblQuoteNum) AS LastQuoteNo from tblQuoteHeader", myConnection)
        Dim dr = myCommand.ExecuteReader()
        If dr.hasrows() = True Then
            While dr.read()
                If IsDBNull(dr.item("LastQuoteNo")) Then
                    xQuoteNo = 0
                Else
                    xQuoteNo = dr.item("LastQuoteNo")
                End If
            End While
        End If
        Me.tb_QuoteNo.Text = CDec(xQuoteNo) + 1

        Dim xCurDate As Date = Date.Today.ToShortDateString

        Me.tb_QuoteID.Text = xQuoteID

        If Me.DataGridView2.RowCount > 0 Then
            Dim xRows As Integer = Me.DataGridView2.RowCount
            Dim i As Integer
            For i = 0 To xRows - 1
                DirectCast(Me.DataGridView2.Rows(i).DataBoundItem, DataRowView).Delete()
            Next
            Me.cb_Quote_Customer.SelectedValue = -1
            Me.cb_Quote_Product.SelectedValue = -1

            For Each xctrl As Control In Me.GroupBox4.Controls
                Dim xType As String = xctrl.GetType.ToString
                If xType = "System.Windows.Forms.TextBox" Or xType = "System.Windows.Forms.RichTextBox" Then
                    xctrl.Text = String.Empty
                End If
            Next

            For Each xctrl As Control In Me.GroupBox5.Controls
                Dim xType As String = xctrl.GetType.ToString
                If xType = "System.Windows.Forms.TextBox" Then
                    xctrl.Text = String.Empty
                End If
            Next

            Me.DataGridView2.Visible = False
        End If


    End Sub

    Private Sub DataGridView2_CellValidating(sender As Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DataGridView2.CellValidating
        Dim xCell As DataGridViewCell = Me.DataGridView2.CurrentCell
        Dim xCoNo As String = MiscCode.GetCoNo

        If xCell.OwningColumn.HeaderText = "Quantity" Then
            Dim xRowIndex As Integer = xCell.RowIndex
            Dim xQty As Decimal = xCell.EditedFormattedValue
            Me.DataGridView2.Rows(xRowIndex).Cells("dgv2_Amt").Value = Round(xQty * Me.DataGridView2.Rows(xRowIndex).Cells("dgv2_SP").EditedFormattedValue, 2)
            Me.DataGridView2.Rows(xRowIndex).Cells("dgv2_VatAmt").Value = Round(Me.DataGridView2.Rows(xRowIndex).Cells("dgv2_Amt").Value * (CDec(MiscCode.GetValueonID(xCoNo, "idtblCoInfo", "TblCoInfo", "dblVatRate") / 100)))
            Me.DataGridView2.Rows(xRowIndex).Cells("dgv2_TotAmt").Value = Me.DataGridView2.Rows(xRowIndex).Cells("dgv2_Amt").Value + Me.DataGridView2.Rows(xRowIndex).Cells("dgv2_VATAmt").Value
            xCell.Value = xQty
        End If
        If xCell.OwningColumn.HeaderText = "Selling Price" Then
            Dim xRowIndex As Integer = xCell.RowIndex
            Dim xSP As Decimal = Me.DataGridView2.Rows(xRowIndex).Cells("dgv2_SP").EditedFormattedValue
            Dim xQty As Decimal = Me.DataGridView2.Rows(xRowIndex).Cells("dgv2_Qty").EditedFormattedValue
            Me.DataGridView2.Rows(xRowIndex).Cells("dgv2_Amt").Value = Round(xQty * Me.DataGridView2.Rows(xRowIndex).Cells("dgv2_SP").EditedFormattedValue, 2)
            Me.DataGridView2.Rows(xRowIndex).Cells("dgv2_VatAmt").Value = Round(Me.DataGridView2.Rows(xRowIndex).Cells("dgv2_Amt").Value * (CDec(MiscCode.GetValueonID(xCoNo, "idtblCoInfo", "TblCoInfo", "dblVatRate") / 100)))
            Me.DataGridView2.Rows(xRowIndex).Cells("dgv2_TotAmt").Value = Me.DataGridView2.Rows(xRowIndex).Cells("dgv2_Amt").Value + Me.DataGridView2.Rows(xRowIndex).Cells("dgv2_VATAmt").Value
            xCell.Value = xSP
        End If

    End Sub

    Private Sub DataGridView2_RowValidated(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.RowValidated
        Me.TblQuoteDetailBindingSource.EndEdit()
        Me.TblQuoteDetailTableAdapter1.Update(Me.DsAccounting.tblQuoteDetail)
        Me.TblQuoteDetailTableAdapter1.Fill(Me.DsAccounting.tblQuoteDetail)
        Me.DataGridView2.Refresh()
    End Sub

    Private Sub CalculateQuoteValue(ByVal xProductID As Integer)

        Dim xNoValues As String = String.Empty
        Me.tb_ProdID.Text = xProductID
        Me.LstMatCostperProductTableAdapter1.FillByProduct(Me.DsAccounting.lstMatCostperProduct, xProductID)
        Me.LstLabCostperProductTableAdapter1.FillByProduct(Me.DsAccounting.lstLabCostperProduct, xProductID)

        If Me.DsAccounting.lstMatCostperProduct.Count = 0 Or Me.DsAccounting.lstLabCostperProduct.Rows.Count = 0 Then
            xNoValues = "No Costing"
        Else

            If String.IsNullOrEmpty(Me.tb_GrossProfitPer.Text) Then
                Me.tb_ProfPer.Text = Me.DsAccounting.tblCoInfo.Rows(0).Item("dblProfitPercentage")
            End If

            Dim xMatCost As Decimal
            For Each xRow As DataRow In Me.DsAccounting.lstMatCostperProduct.Rows
                xMatCost = xMatCost + xRow.Item(1)
            Next

            Me.tb_MatCost.Text = Round(xMatCost, 2)

            Dim xLabourHours As Decimal
            Try
                Me.tb_LabCost.Text = MiscCode.FillLabourByProduct(Me.tb_ProdID.Text, -1, 0, 0, xLabourHours)
            Catch ex As Exception
                MsgBox("Problems encountered during the labour cost and hours calculation")
            End Try

            Try
                Dim xOHRate As Decimal = MiscCode.GetOHRate
                Dim xProdIndex As Decimal = MiscCode.CalculateProdIndex
                Me.tb_OH.Text = Round((xLabourHours * xOHRate) * xProdIndex, 2)
            Catch ex As Exception
                MsgBox("Problems encountered during the overhead calculation")
            End Try

            Me.tb_SellingPrice.Text = MiscCode.GetGrossMargingPerUnit((CDec(Me.tb_LabCost.Text) + CDec(Me.tb_MatCost.Text)), Me.tb_ProfPer.Text)
            Me.tb_GP.Text = CDec(Me.tb_SellingPrice.Text) - CDec(Me.tb_MatCost.Text) - CDec(Me.tb_LabCost.Text)
            Me.tb_NP.Text = CDec(Me.tb_GP.Text) - CDec(Me.tb_OH.Text)
            If Me.tb_NP.Text < 0 Then
                Me.tb_NP.Text = Round(CDec(Me.tb_NP.Text), 2)
                Me.tb_NP.BackColor = Color.Red
            Else
                Me.tb_NP.Text = Round(CDec(Me.tb_NP.Text), 2)
                Me.tb_NP.BackColor = Color.White
            End If
            Me.tb_GrossProfitPer.Text = (CDec(Me.tb_GP.Text) / CDec(Me.tb_SellingPrice.Text)) * 100

        End If

        Dim xBudgetPrice As String = MiscCode.GetValueonID(xProductID, "fk_tblProductID", "tblProdBud", "decSalesPrice")

        If String.IsNullOrEmpty(xBudgetPrice) Then
            xNoValues = xNoValues + "NoPrice"
        Else

            Me.Label33.Text = "(" & xBudgetPrice & ")"
            Me.Label33.Visible = True
            If String.IsNullOrEmpty(xNoValues) = True Then
                Me.tb_NPSellPrice.Text = Round(((CDec(xBudgetPrice) - (CDec(Me.tb_MatCost.Text) + CDec(Me.tb_LabCost.Text))) / (CDec(Me.tb_MatCost.Text) + CDec(Me.tb_LabCost.Text))) * 100, 2)
            End If
        End If



    End Sub

    Private Sub TblCustomerBindingSource1_CurrentChanged(sender As Object, e As System.EventArgs) Handles TblCustomerBindingSource1.CurrentChanged

        If Not Me.TblCustomerBindingSource1.Current Is Nothing And Me.cb_Quote_Customer.Focused = True Then

            Me.TextBox8.Text = TblCustomerBindingSource1.Current.row.item("txtCusDesc")
            Me.RichTextBox3.Text = TblCustomerBindingSource1.Current.row.item("txtAddPos")
            Me.TextBox9.Text = TblCustomerBindingSource1.Current.row.item("txtPhone1")
            Me.TextBox10.Text = TblCustomerBindingSource1.Current.row.item("txtEmail")
            Me.TextBox12.Text = TblCustomerBindingSource1.Current.row.item("txtPhone2")
            Me.TextBox13.Text = TblCustomerBindingSource1.Current.row.item("txtFax")
            Me.TextBox14.Text = TblCustomerBindingSource1.Current.row.item("txtContactName")
        End If


    End Sub

    Private Sub cb_Quote_Product_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Quote_Product.SelectedIndexChanged
        If sender.items.count = 0 Then Exit Sub
        If IsNumeric(Me.cb_Quote_Product.SelectedValue) Then

            Dim xProductID As Integer = Me.cb_Quote_Product.SelectedValue
            Button4_Click(sender, Nothing)
            CalculateQuoteValue(xProductID)
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click

        'First decide if this is a new quote.  It it is then add a header record
        Dim xQuoteID As Integer
        Try
            If Me.DataGridView2.Visible = False Then
                Dim xCusNo As Integer = Me.cb_Quote_Customer.SelectedValue
                Dim xQuoteNo As String = "0"

                Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
                myConnection.Open()
                Dim myCommand = New SqlClient.SqlCommand
                myCommand = New SqlClient.SqlCommand("Select Max(dblQuoteNum) AS LastQuoteNo from tblQuoteHeader", myConnection)
                Dim dr = myCommand.ExecuteReader()
                If dr.hasrows() = True Then
                    While dr.read()
                        If IsDBNull(dr.item("LastQuoteNo")) Then
                            xQuoteNo = 0
                        Else
                            xQuoteNo = dr.item("LastQuoteNo")
                        End If
                    End While
                End If
                Me.tb_QuoteNo.Text = CDec(xQuoteNo) + 1

                Me.Button7.Enabled = True

                Dim xCurDate As Date = Date.Today.ToShortDateString

                Me.TblQuoteHeaderTableAdapter1.Insert(xCusNo, CInt(MiscCode.GetCoNo()), (CDec(xQuoteNo) + 1), Me.TextBox8.Text, Me.RichTextBox3.Text, Me.TextBox14.Text, Me.TextBox10.Text, Me.TextBox9.Text, Me.TextBox12.Text, Me.TextBox13.Text, xCurDate, My.User.Name, "Added", "", "")

                myCommand = New SqlClient.SqlCommand("Select Max(id_tblQuoteHeader) AS LastQuoteID from tblQuoteHeader", myConnection)
                Dim dr1 = myCommand.ExecuteReader()
                If dr1.hasrows() = True Then
                    While dr1.read()
                        If IsDBNull(dr1.item("LastQuoteID")) Then
                            xQuoteID = 0
                        Else
                            xQuoteID = dr1.item("LastQuoteID")
                        End If
                    End While
                End If
                Me.tb_QuoteID.Text = xQuoteID
                xQuoteIDSaved = xQuoteID


            Else
                xQuoteID = Me.tb_QuoteID.Text
            End If
        Catch ex As IndexOutOfRangeException
            MsgBox("Index out of Range No1")
        End Try
        'Now add the details
        Try

            ' Dim xProdCde = Me.cb_Quote_Product.Text.ToString.Split(",")

            Dim xProdCde As New ArrayList
            xProdCde.Add(Me.TblProductBindingSource1.Current.row.item("txtProdCde"))
            xProdCde.Add(Me.TblProductBindingSource1.Current.row.item("txtProdDesc"))
            xProdCde.Add(Me.TblProductBindingSource1.Current.row.item("txtProdSpec1"))
            xProdCde.Add(Me.TblProductBindingSource1.Current.row.item("txtProdSpec2"))
            xProdCde.Add(Me.TblProductBindingSource1.Current.row.item("txtProdSpec3"))


            Dim xBudgetPrice As String = MiscCode.GetValueonID(Me.tb_ProdID.Text, "fk_tblProductID", "tblProdBud", "decSalesPrice")
            If xBudgetPrice Is Nothing Then xBudgetPrice = 0
            If String.IsNullOrEmpty(Me.tb_SellingPrice.Text) Then Me.tb_SellingPrice.Text = xBudgetPrice

            If String.IsNullOrEmpty(Me.tb_OrderQty_Quote.Text) Then Me.tb_OrderQty_Quote.Text = 1
            Me.TblQuoteDetailTableAdapter1.Insert(xQuoteID, Me.cb_Quote_Product.SelectedValue, xProdCde(0), xProdCde(1), xProdCde(2), "", "", Me.tb_OrderQty_Quote.Text, Me.tb_SellingPrice.Text, Me.tb_SellingPrice.Text * Me.tb_OrderQty_Quote.Text, xBudgetPrice, 14, ((Me.tb_SellingPrice.Text * Me.tb_OrderQty_Quote.Text) * 14) / 100, (((Me.tb_SellingPrice.Text * Me.tb_OrderQty_Quote.Text) * 14) / 100) + (Me.tb_SellingPrice.Text * Me.tb_OrderQty_Quote.Text), "Each")

            Me.TblQuoteDetailTableAdapter1.Fill(Me.DsAccounting.tblQuoteDetail)
            Me.DataGridView2.Visible = True
            Me.TblQuoteDetailBindingSource.Filter = "fk_tblQuoteHeader = " & xQuoteID

            Me.DataGridView2.Refresh()
            MiscCode.ResizeGrid(Me.DataGridView2)
            'Me.DataGridView2.CurrentCell = Me.DataGridView2.Item(9, 0)

            Me.DataGridView2.FirstDisplayedScrollingRowIndex = 0

            Me.Button10.Visible = True
            Me.Button11.Enabled = False

            If xBudgetPrice = 0 Then
                MsgBox("A line has been added with a zero selling price.  Please correct", MsgBoxStyle.Exclamation, My.Settings.SysName)
            End If

        Catch ex As IndexOutOfRangeException
            MsgBox("Index out of Range No2")
        End Try


    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        For Each xCtrl As Control In Me.GroupBox3.Controls
            Dim xType As String = xCtrl.GetType.ToString
            If xCtrl.GetType.ToString = "System.Windows.Forms.TextBox" And xCtrl.Tag = "Clear" Then
                xCtrl.Text = String.Empty
            End If
        Next
        Me.Label33.Text = String.Empty

    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        If IsNumeric(Me.cb_Quote_Product.SelectedValue) Then

            Dim xProductID As Integer = Me.cb_Quote_Product.SelectedValue
            CalculateQuoteValue(xProductID)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click

        If Len(Me.TextBox8.Text.ToString()) = 0 Then
            MsgBox("Please select a customer before printing or saving the quotation or invoice")
            Exit Sub
        End If


        'Me.TblQuoteHeaderBindingSource.Current.Row.item("FK_idtblCustomer") = Me.TextBox15.Text
        Me.TblQuoteDetailBindingSource.EndEdit()
        Me.TblQuoteHeaderTableAdapter1.Update(Me.DsAccounting.tblQuoteHeader)
        Me.TblQuoteDetailTableAdapter1.Update(Me.DsAccounting.tblQuoteDetail)
        Me.DsAccounting.AcceptChanges()
        xQuoteIDSaved = 0


    End Sub

    Private Sub Button7_Click(sender As Object, e As System.EventArgs) Handles Button7.Click

        If Len(Me.TextBox8.Text.ToString()) = 0 Then
            MsgBox("Please select a customer before printing or saving the quotation or invoice")
            Exit Sub
        End If


        Dim frm As New frmRepViewer

        frm.Tag = "Quote"
        If String.IsNullOrEmpty(Me.tb_QuoteNo.Text) Then
            MsgBox("The quote has not been prepared and.or saved and can not be printed at this time", , My.Settings.SysName)
            Return
        Else
            PrintingVariables.xId2Print = Me.tb_QuoteNo.Text
        End If
        frm.Show()
        'FillActiveChildFormToClient()



    End Sub

    Private Sub Button10_Click(sender As Object, e As System.EventArgs) Handles Button10.Click

        Dim dia As New diaNotes
        Dim xNotes As String = String.Empty
        dia.Tag = "Quote"
        ' Show testDialog as a modal dialog and determine if DialogResult = OK.
        If dia.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            ' Read the contents of testDialog's TextBox.
            xNotes = dia.RichTextBox1.Text
        Else

        End If
        dia.Dispose()
        If String.IsNullOrEmpty(xNotes) = False Then
            Dim strSQL As String = "Update tblQuoteHeader Set txtNotes = " & """" & xNotes & """" & " where dblQuoteNum = " & Me.tb_QuoteNo.Text
            Dim xCon = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
            xCon.open()
            Dim xComm As New SqlClient.SqlCommand(strSQL, xCon)
            xComm.ExecuteNonQuery()
            xCon.Close()
        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As System.EventArgs) Handles Button11.Click
        Dim dia As New diaNotes
        dia.Tag = "Edit"
        Dim xQuoteNo As String = String.Empty
        ' Show testDialog as a modal dialog and determine if DialogResult = OK.
        If dia.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            ' Read the contents of testDialog's TextBox.
            xQuoteNo = dia.ComboBox1.SelectedValue
        Else

        End If

        If String.IsNullOrEmpty(xQuoteNo) = False Then

            Me.TblQuoteHeaderTableAdapter1.Fill(Me.DsAccounting.tblQuoteHeader)
            Me.TblQuoteDetailTableAdapter1.Fill(Me.DsAccounting.tblQuoteDetail)

            Dim xFilter As String = "dblQuoteNum = " & xQuoteNo
            Dim xQuoteID As Integer = Me.DsAccounting.tblQuoteHeader.Compute("Min(id_tblQuoteHeader)", xFilter)
            Dim xCusNo As Integer = Me.DsAccounting.tblQuoteHeader.Compute("Min(FK_idtblCustomer)", xFilter)
            If xCusNo >= 0 Then
                Me.cb_Quote_Customer.SelectedValue = xCusNo
            End If

            Me.TextBox8.Text = MiscCode.MNS(Me.DsAccounting.tblQuoteHeader.Rows.Find(xQuoteID).Item("txtCusDesc"))
            Me.TextBox9.Text = MiscCode.MNS(Me.DsAccounting.tblQuoteHeader.Rows.Find(xQuoteID).Item("txtPhone1"))
            Me.RichTextBox3.Text = MiscCode.MNS(Me.DsAccounting.tblQuoteHeader.Rows.Find(xQuoteID).Item("txtAddPos"))
            Me.TextBox10.Text = MiscCode.MNS(Me.DsAccounting.tblQuoteHeader.Rows.Find(xQuoteID).Item("txtEmail"))
            Me.TextBox12.Text = MiscCode.MNS(Me.DsAccounting.tblQuoteHeader.Rows.Find(xQuoteID).Item("txtPhone2"))
            Me.TextBox13.Text = MiscCode.MNS(Me.DsAccounting.tblQuoteHeader.Rows.Find(xQuoteID).Item("txtFax"))
            Me.TextBox14.Text = MiscCode.MNS(Me.DsAccounting.tblQuoteHeader.Rows.Find(xQuoteID).Item("txtContactName"))

            Me.TblQuoteDetailBindingSource.Filter = "fk_tblQuoteHeader = " & xQuoteID
            Me.DataGridView2.Refresh()
            Me.DataGridView2.Visible = True
            MiscCode.ResizeGrid(Me.DataGridView2)
            Me.Button10.Visible = True
            Me.Button11.Enabled = False
            Me.Button10.Enabled = True

            Me.tb_QuoteNo.Text = xQuoteNo
            Me.tb_QuoteID.Text = xQuoteID



        End If
    End Sub

    Private Sub TabPage_Quoting_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TabPage_Quoting.Validating
        If xQuoteIDSaved > 0 Then
            Dim xMsBoxResult As MsgBoxResult
            xMsBoxResult = MsgBox("The quote has not been saved.  Do you want to dicard the quote?", MsgBoxStyle.YesNoCancel, My.Settings.SysName)
            If xMsBoxResult = MsgBoxResult.Yes Then
                Dim strHead As String = "Delete from tblQuoteHeader where id_tblQuoteHeader = " & xQuoteIDSaved
                Dim strDetail As String = "Delete from tblQuoteDetail where FK_tblQuoteHeader = " & xQuoteIDSaved
                Dim xCon As New SqlConnection(My.Settings.ConnectionString1)
                Dim xComm As New SqlCommand(strHead, xCon)
                xCon.Open()
                xComm.ExecuteNonQuery()
                xComm.CommandText = strDetail
                xComm.ExecuteNonQuery()
                xCon.Close()
                xQuoteIDSaved = 0
                ApplicationStartupForm.ss1.Text = "The quote has been deleted"

            End If
            If xMsBoxResult = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If
            If xMsBoxResult = MsgBoxResult.No Then
                ApplicationStartupForm.ss1.Text = "The quote has been SAVED"
                xQuoteIDSaved = 0
            End If
        End If
    End Sub

    Private Sub cb_Quote_Customer_GotFocus(sender As Object, e As System.EventArgs) Handles cb_Quote_Customer.GotFocus
        Me.TblCustomerBindingSource1.ResetBindings(True)
    End Sub

    Private Function GetComponentReq(ByVal xComponentID As Integer, ByVal xProductID As Integer)
        Dim xQty As Decimal
        Try
            xQty = Me.TblMatLinkTableAdapter1.GetComponentQty(xProductID, xComponentID)
        Catch ex As Exception
            xQty = 1
            MsgBox("Could not determine the component volume/quantity", My.Settings.SysName)
        End Try
        Return xQty

    End Function

    Private Function GetComponentQtyReq(ByVal xComponentID As Integer)
        Dim xQty As Decimal
        Try
            xQty = Me.LstComponentLinkTableAdapter1.GetCompReq(xComponentID)
        Catch ex As Exception
            xQty = 1
            MsgBox("Could not determine the component volume/quantity", My.Settings.SysName)
        End Try
        Return xQty

    End Function


End Class



Public Module QQ_Variables
    Public xProdCopyID As Integer
    Public xNewID As Integer = -1
    Public xProdCode As String
    Public xProdDesc As String
    Public xSpec1 As String
    Public xSpec2 As String
    Public xSpec3 As String
    Public xQQCusID As Integer = -1

End Module