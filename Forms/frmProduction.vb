Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmProduction
    Public Shared xCusID As Integer
    Dim xPOHeaderID As Integer
    Dim xJCID As Integer
    Dim xThisJCNo As Integer

    Private Sub frmProduction_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.dgv1.BackgroundColor = myGBColor
        Me.GroupBox1.BackColor = myGBColor
        Me.dgvMaterial.BackgroundColor = myGBColor
        Me.dgvLabour.BackgroundColor = myGBColor
        Me.GroupBox4.BackColor = Color.Black

        Me.TblPOHeaderTableAdapter1.Fill(Me.DsProduction1.tblPOHeader)
        Me.TblPODetailTableAdapter1.Fill(Me.DsProduction1.tblPODetail)

        jcCombo3.DataSource = Nothing
        Me.LstQuoteHeadersTableAdapter1.FillByOpenQuotes(Me.DsAccounting1.lstQuoteHeaders)
        jcCombo3.DataSource = New BindingSource(DsAccounting1.lstQuoteHeaders, Nothing)
        jcCombo3.DisplayMember = "ComboText"
        jcCombo3.ValueMember = "id_tblQuoteHeader"

    End Sub

    Private Sub frmProduction_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Try
            Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
            Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
            e.Graphics.FillRectangle(Grad, BaseRec)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmProduction_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Me.Invalidate()
    End Sub

    Private Sub jcCombo1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles jcCombo1.SelectedIndexChanged
        Me.Label2.Text = "Fill from quote"

        Me.LstQuoteHeadersTableAdapter1.FillByOpenQuotes(Me.DsAccounting1.lstQuoteHeaders)

        If Me.jcCombo1.SelectedItem = "Order" Then
            If Me.DsAccounting1.lstQuoteHeaders.Rows.Count > 0 Then
                jcCombo2.Visible = True
                Me.Label2.Visible = True
            Else
                jcCombo2.Visible = False
                Me.Label2.Visible = False
                MsgBox("All quotes has been placed on an order", , My.Settings.SysName)
                Return
            End If
        Else
            Me.Label2.Text = "Fill from P/Order"
            Me.Label2.Visible = True
            Me.jcCombo2.Visible = True
        End If

    End Sub

    Private Sub jcCombo3_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles jcCombo3.SelectionChangeCommitted
        Dim xDocType As String = Me.jcCombo1.SelectedItem
        Dim xFillType As String = Me.jcCombo2.SelectedItem
        Select Case xDocType

            Case "Order"
                If Me.jcCombo2.SelectedItem = "Yes" Then
                    Me.tb_QuoteID.Text = Me.jcCombo3.SelectedValue
                    CreateOrder()
                    Me.GroupBox2.Visible = True
                    Me.GroupBox4.Visible = True
                Else

                End If


            Case "Job card"
                Me.Button1.Text = "Save job card"
                Me.Button2.Text = "Print/Email job card"
                Me.Button3.Visible = False
                Me.Button4.Visible = False

                Me.cbJC_Product.Visible = False
                Me.Label9.Visible = False

                xPOHeaderID = Me.jcCombo3.SelectedValue

                Me.LstPOHeaderDetailsTableAdapter1.FillByPOid(Me.DsProduction1.lstPOHeaderDetails, xPOHeaderID)
                Dim xCount As Integer = Me.DsProduction1.lstPOHeaderDetails.Rows.Count
                Dim dv As New DataView(Me.DsProduction1.lstPOHeaderDetails)
                dv.RowFilter = "dblJCNo is Null"
                xCount = dv.Count
                If xCount <= 1 Then
                    Me.Label10.Visible = True
                    Me.Label11.Visible = True
                    Me.Label12.Visible = True
                    Me.Label9.Visible = True
                    Me.TblProductTableAdapter1.FillByCombo(Me.DsAccounting1.tblProduct)
                    Me.cbJC_Product.DataSource = DsAccounting1.tblProduct
                    Me.cbJC_Product.ValueMember = "idtblProduct"
                    Me.cbJC_Product.DisplayMember = "txtComboString"
                    Me.cbJC_Product.Visible = True
                    Me.TblCustomerTableAdapter1.Fill(Me.DsAccounting1.tblCustomer)
                    Me.cbJC_Customer2.DataSource = DsAccounting1.tblCustomer
                    Me.cbJC_Customer2.ValueMember = "id_tblCustomer"
                    Me.cbJC_Customer2.DisplayMember = "txtCusDesc"
                    Me.cbJC_Customer2.Visible = True
                    Me.tbJC_CusRef2.Visible = True
                    Me.tbJC_Qty.Visible = True
                    Me.GroupBox4.Location = New Point(12, 107)
                    Me.lbl_JCNumber.Location = New Point(625, 107)
                    Me.GroupBox4.Visible = True
                    Me.Label14.Visible = True
                    Me.Label15.Visible = True
                    Me.Label16.Visible = True
                    Me.JCDt_DateFrom.Visible = True
                    Me.JCDt_DateFrom.Value = dv(0).Item("dateFrom")
                    Me.JCdt_DateTo.Visible = True
                    Me.JCdt_DateTo.Value = dv(0).Item("dateTo")
                    Me.JCdt_ETD.Visible = True
                    Me.JCdt_ETD.Value = dv(0).Item("dateETD")
                    Me.cbJC_Product.SelectedValue = dv(0).Item("FK_tblProduct")
                    Me.cbJC_Customer2.SelectedValue = dv(0).Item("FK_idtblCustomer")
                    Me.tbJC_Qty.Text = dv(0).Item("decQty")
                    Me.tbJC_CusRef2.Text = dv(0).Item("txtCusRef")
                    CreateJC(dv(0).Item("FK_idtblCustomer"), dv(0).Item("FK_tblProduct"))
                Else
                    Dim strSQL As String = "SELECT tblProduct.idtblProduct, tblProduct.txtProdCde +'-'+tblProduct.txtProdDesc+'-'+tblProduct.txtProdSpec1 AS ComboInfo, lstPOHeaderDetails.txtPOMessage, lstPOHeaderDetails.dblJCno FROM tblProduct INNER JOIN lstPOHeaderDetails ON tblProduct.idtblProduct = lstPOHeaderDetails.FK_tblProduct WHERE (((lstPOHeaderDetails.id_tblPOHeader)=" & Me.jcCombo3.SelectedValue & ") AND ((lstPOHeaderDetails.dblJCno) Is Null));"
                    Dim xCon As New SqlConnection(My.Settings.ConnectionString1)
                    Dim xAdap As New SqlDataAdapter(strSQL, xCon)
                    Dim ds As New DataSet
                    xAdap.Fill(ds, "POProducts")
                    Me.cbJC_Product.DataSource = ds.Tables("POProducts")
                    Me.cbJC_Product.ValueMember = "idtblProduct"
                    Me.cbJC_Product.DisplayMember = "ComboInfo"
                    Me.cbJC_Product.SelectedIndex = -1
                    Me.cbJC_Product.Visible = True
                    Me.Label9.Visible = True

                End If


        End Select

        Me.jcCombo3.Enabled = False

    End Sub

    Private Sub jcCombo2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles jcCombo2.SelectedIndexChanged

        Me.tb_Pic.Text = String.Empty
        Dim xType As String = Me.jcCombo1.SelectedItem & Me.jcCombo2.SelectedItem

        Select Case xType
            Case "OrderYes"
                If Me.DsAccounting1.lstQuoteHeaders.Rows.Count > 0 Then
                    jcCombo3.Visible = True
                    Me.Label3.Visible = True
                Else
                    Me.Label1.Text = "No quotes are uninvoiced"
                    jcCombo3.Visible = False
                    Me.Label3.Visible = False
                    Return
                End If

            Case "OrderNo"
                Me.TblCustomerTableAdapter1.Fill(Me.DsAccounting1.tblCustomer)
                Me.jcCB_Customer.Enabled = True
                Me.tb_InvoiceID.Text = -1
                Me.tb_QuoteID.Text = -1
                Me.GroupBox2.Visible = True
                'Get the next Quote number
                Dim xThisPONo As Integer
                If Me.DsProduction1.Tables("tblPOHeader").Rows.Count = 0 Then
                    xThisPONo = 1
                Else
                    xThisPONo = Me.DsProduction1.Tables("tblPOHeader").Compute("Max(dblPONum)", "") + 1
                End If
                Me.lbl_PONumber.Text = xThisPONo
                Me.GroupBox3.Visible = True
                Me.GroupBox4.Location = New Point(12, 291)
                Me.GroupBox4.Visible = True

                'Get the quote details
                Me.TblPODetailBindingSource.Filter = "id_tblPODetail= -1"
                Me.dgv1.Visible = True
                Me.dgv1.Columns(0).Visible = False

            Case "Job cardYes"
                Me.TblPOHeaderTableAdapter1.FillByComboInfo(Me.DsProduction1.tblPOHeader)
                Me.LstPOHeaderDetailsTableAdapter1.FillByOpenPO(Me.DsProduction1.lstPOHeaderDetails)
                Me.jcCombo3.DataSource = Me.DsProduction1.lstPOHeaderDetails
                Me.jcCombo3.ValueMember = "id_tblPOHeader"
                Me.jcCombo3.DisplayMember = "ComboInfo"
                Me.jcCombo3.Visible = True
                Me.Label3.Text = "Select Production order"
                Me.Label3.Visible = True

            Case "Job cardNo"
                Me.Label10.Visible = True
                Me.Label11.Visible = True
                Me.Label12.Visible = True
                Me.Label9.Visible = True
                Me.TblProductTableAdapter1.FillByCombo(Me.DsAccounting1.tblProduct)
                Me.cbJC_Product.DataSource = DsAccounting1.tblProduct
                Me.cbJC_Product.ValueMember = "idtblProduct"
                Me.cbJC_Product.DisplayMember = "txtComboString"
                Me.cbJC_Product.Visible = True
                Me.TblCustomerTableAdapter1.Fill(Me.DsAccounting1.tblCustomer)
                Me.cbJC_Customer2.DataSource = DsAccounting1.tblCustomer
                Me.cbJC_Customer2.ValueMember = "id_tblCustomer"
                Me.cbJC_Customer2.DisplayMember = "txtCusDesc"
                Me.cbJC_Customer2.Visible = True
                Me.tbJC_CusRef2.Visible = True
                Me.tbJC_Qty.Visible = True
                Me.GroupBox4.Location = New Point(12, 107)
                Me.Button1.Text = "Save job card"
                Me.Button2.Text = "Print/Email job card"
                Me.Button3.Visible = False
                Me.lbl_JCNumber.Location = New Point(625, 107)
                Me.GroupBox4.Visible = True
                Me.Label14.Visible = True
                Me.Label15.Visible = True
                Me.Label16.Visible = True
                Me.JCDt_DateFrom.Visible = True
                Me.JCdt_DateTo.Visible = True
                Me.JCdt_ETD.Visible = True



        End Select


    End Sub

    Private Sub CreateOrder(Optional ByVal xMatStr As String = "")

        Me.LstQuoteHeadersTableAdapter1.Fill(Me.DsAccounting1.lstQuoteHeaders)
        Dim dvQuote As New DataView(DsAccounting1.lstQuoteHeaders)
        dvQuote.RowFilter = "id_tblQuoteHeader = " & Me.tb_QuoteID.Text
        xCusID = dvQuote(0)("FK_idtblCustomer")

        Me.TblCustomerTableAdapter1.Fill(Me.DsAccounting1.tblCustomer)
        Dim dvCus As New DataView(DsAccounting1.tblCustomer)
        dvCus.RowFilter = "id_tblCustomer = " & xCusID

        Me.jcCB_Customer.SelectedValue = xCusID

        'Get the next Quote number
        Dim xThisPONo As Integer
        If Me.DsProduction1.Tables("tblPOHeader").Rows.Count = 0 Then
            xThisPONo = 1
        Else
            xThisPONo = Me.DsProduction1.Tables("tblPOHeader").Compute("Max(dblPONum)", "") + 1
        End If
        Me.lbl_PONumber.Text = xThisPONo
        Me.GroupBox3.Visible = True

        'Get the quote details
        Me.TblQuoteDetailTableAdapter1.Fill(Me.DsAccounting1.tblQuoteDetail)
        Dim dvQuoteDet As New DataView(DsAccounting1.tblQuoteDetail)
        dvQuoteDet.RowFilter = "FK_tblQuoteHeader = " & Me.tb_QuoteID.Text
        Me.dgv1.DataSource = dvQuoteDet
        Me.TblPODetailBindingSource.AddNew()
        Me.dgv1.Visible = True
        Me.dgv1.Columns(0).Visible = False



    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If Me.Button1.Text = "Close" Then
            Me.Close()
            Exit Sub
        End If

        If Me.jcCombo1.SelectedItem = "Job card" Then

            SaveJC(Me.DsProduction1.lstMaterialLink, Me.DsProduction1.lstLabCostperProdandDept)
            ApplicationStartupForm.ss1.Text = Me.lbl_JCNumber.Text & " saved"
            'Me.dgv1.Visible = False
            'Me.dgvMaterial.Visible = False
            'Me.dgvLabour.Visible = False
            'Me.GroupBox4.Visible = False
            'Me.GroupBox3.Visible = False
            'Me.GroupBox2.Visible = False
            'Me.jcCombo1.SelectedValue = -1
            'Me.jcCombo3.SelectedValue = -1
            'Me.jcCombo2.SelectedValue = -1
            'Me.jcCombo3.Enabled = True

        Else

            Dim strIns As String
            Try
                Dim xCo As Integer = MiscCode.GetCoNo()
                strIns = "INSERT INTO tblPOHeader (fk_idtblCustomer, txtCompanyNo, dblPONum, txtCusDesc, txtAddPos, txtContactName, txtEmail, txtPhone1, txtPhone2, txtFax, txtPODate,txtPOOperator, txtPOStatus, txtPODocName, txtNotes, FK_tblQuoteHeader, txtCusRef, DateFrom, DateTo, DateETD) VALUES (" & xCusID & "," & xCo & ", " & Int32.Parse(Me.lbl_PONumber.Text) & ", '" & Me.TextBox8.Text & "', '" & Me.RichTextBox3.Text & "', '" & Me.TextBox10.Text & "', '" & Me.TextBox14.Text & "', '" & Me.TextBox9.Text & "', '" & Me.TextBox12.Text & "', '" & Me.TextBox13.Text & "', '" & Format(Now(), "yyy-MM-dd") & "', '" & My.User.Name & "', 'Created','" & Me.tb_Pic.Text.ToString() & "', ''" & ", " & Int32.Parse(Me.tb_QuoteID.Text) & ", '" & Me.tb_CusRef.Text.ToString() & "', '" & Format(Me.DateTimePicker1.Value, "yyyy-MM-dd") & "', '" & Format(Me.DateTimePicker2.Value, "yyyy-MM-dd") & "', '" & Format(Me.DateTimePicker3.Value, "yyyy-MM-dd") & "')" 'Int32.Parse(Me.tb_QuoteID.Text)"
                Dim xCon As New SqlConnection(My.Settings.ConnectionString1)
                Dim xCom As New SqlCommand(strIns, xCon)
                xCon.Open()
                xCom.ExecuteNonQuery()
                xCom.CommandText = "Select @@Identity"
                xPOHeaderID = xCom.ExecuteScalar




                'Save the notes if there are any.
                If Len(Me.RichTextBox3.Text) > 0 Then
                    strIns = "Insert into tblPOMessage (fk_tblPOHeader, txtPOMessage) Values (" & xPOHeaderID & ", '" & Me.RichTextBox3.Text.ToString() & "')"
                    xCom.CommandText = strIns
                    xCom.ExecuteNonQuery()
                End If

                xCon.Close()
            Catch ex As Exception
                MsgBox("Error posting the order", , My.Settings.SysName)
            End Try

            For Each xRow As DataGridViewRow In Me.dgv1.Rows
                If xRow.IsNewRow Then Exit For
                If Me.jcCombo2.SelectedItem = "Yes" Then TblPODetailBindingSource.AddNew()
                Me.TblPODetailBindingSource.Current.row.item("FK_tblPOHeader") = xPOHeaderID
                Me.TblPODetailBindingSource.Current.row.item("FK_tblProduct") = xRow.Cells("FktblProductDataGridViewTextBoxColumn").Value
                Me.TblPODetailBindingSource.Current.row.item("txtProdCde") = xRow.Cells("txtProdCdeDataGridViewTextBoxColumn").Value
                Me.TblPODetailBindingSource.Current.row.item("txtProdDesc") = xRow.Cells("txtProdDescDataGridViewTextBoxColumn").Value
                Me.TblPODetailBindingSource.Current.row.item("txtProdSpec1") = xRow.Cells("txtProdSpec1DataGridViewTextBoxColumn").Value
                Me.TblPODetailBindingSource.Current.row.item("txtProdSpec2") = xRow.Cells("txtProdSpec2DataGridViewTextBoxColumn").Value
                Me.TblPODetailBindingSource.Current.row.item("txtProdSpec3") = xRow.Cells("txtProdSpec3DataGridViewTextBoxColumn").Value
                Me.TblPODetailBindingSource.Current.row.item("decQty") = xRow.Cells("decQtyDataGridViewTextBoxColumn").Value
                Me.TblPODetailBindingSource.Current.row.item("txtUOM") = xRow.Cells("txtUOMDataGridViewTextBoxColumn").Value

            Next
            Me.TblPODetailBindingSource.EndEdit()
            Me.TblPODetailTableAdapter1.Update(Me.DsProduction1.tblPODetail)
            'Me.dgv1.Visible = False
            'Me.GroupBox4.Visible = False
            'Me.GroupBox3.Visible = False
            'Me.GroupBox2.Visible = False
            'Me.jcCombo1.SelectedValue = -1
            'Me.jcCombo3.SelectedValue = -1
            'Me.jcCombo2.SelectedValue = -1
            'Me.jcCombo3.Enabled = True
            ApplicationStartupForm.ss1.Text = "Production order " & Me.lbl_PONumber.Text & " saved"

        End If

        Me.LstQuoteHeadersTableAdapter1.FillByOpenQuotes(Me.DsAccounting1.lstQuoteHeaders)
        'Me.jcCombo2.Visible = False
        'Me.jcCombo3.Visible = False
        Me.Button1.Text = "Close"

    End Sub

    Private Sub dgv1_CellValidating(sender As Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgv1.CellValidating

        Dim xRow As DataGridViewRow = Me.dgv1.CurrentRow
        Dim xCell As Integer = Me.dgv1.CurrentCell.ColumnIndex
        Dim xRowState As String = Me.TblPODetailBindingSource.Current.Row.RowState

        If xCell = 1 And sender.CurrentRow.IsNewRow = False Then
            xRow.Cells("FktblProductDataGridViewTextBoxColumn").Value = MiscCode.GetProductID(xRow.Cells("txtProdCdeDataGridViewTextBoxColumn").EditedFormattedValue)
        End If

    End Sub

    Private Sub jcCB_Customer_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles jcCB_Customer.SelectedValueChanged

        If Me.jcCB_Customer.Focused = True Then
            xCusID = Me.jcCB_Customer.SelectedValue
        End If


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Dim xType As String = Me.jcCombo1.SelectedItem
        Select Case xType
            Case "Order"

                xId2Print = xPOHeaderID
                Dim frm As New frmRepViewer
                frm.Tag = "Production order"
                frm.Show()
            Case "Job card"
                xId2Print = xJCID
                Dim frm As New frmRepViewer
                frm.Tag = "JC"
                frm.Show()
        End Select
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        If Me.jcCombo1.SelectedItem = "Job card" And Me.jcCombo2.SelectedItem = "No" Then

            Me.TblJCTableAdapter1.Fill(Me.DsProduction1.tblJC)

            Dim xProdID As Integer = Me.cbJC_Product.SelectedValue
            xCusID = Me.cbJC_Customer2.SelectedValue

            Me.dgvMaterial.Location = New Point(12, 150)

            CreateJCMaterials(xProdID)

            Dim xPoint As Integer = Me.dgvMaterial.Height + 150 + 10
            Me.dgvLabour.Location = New Point(513, 150)
            CreateJCLabour(xProdID)

            'Get the next Quote number

            If Me.DsProduction1.Tables("tblJC").Rows.Count = 0 Then
                xThisJCNo = 1
            Else
                xThisJCNo = Me.DsProduction1.Tables("tblJC").Compute("Max(dblJCNO)", "") + 1
            End If
            Me.lbl_JCNumber.Text = Me.lbl_JCNumber.Text & xThisJCNo
            Me.lbl_JCNumber.Visible = True

        Else



        End If

    End Sub

    Public Sub CreateJCLabour(ByVal xProdID As Integer)
        Me.dgvLabour.DataSource = Nothing
        'Clear datagrid if colums exist
        Dim xCurCol As Integer = Me.dgvLabour.Columns.Count
        If xCurCol > 0 Then
            For xx As Integer = 0 To xCurCol - 1
                Me.dgvLabour.Columns.RemoveAt(0)
            Next
        End If

        Dim xLabourHours As Integer = 0

        Dim xHeaderList As ArrayList = FillHeader("LAB")
        'FillHeader()
        Dim xColNames As ArrayList = FillHeaderFields("LAB")
        Dim i As Integer
        Dim xTotUnits As Decimal
        xTotUnits = Me.tbJC_Qty.Text

        'Add Datagrid Colums

        For i = 0 To xHeaderList.Count - 1
            Me.dgvLabour.Columns.Add(xColNames(i), xHeaderList(i))
            dgvLabour.Columns(xColNames(i).ToString).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvLabour.Columns(xColNames(i).ToString).DefaultCellStyle.Format = "F4"
        Next
        'dgvLabour.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgvLabour.Columns(0).DefaultCellStyle.Format = "g"
        'dgvLabour.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader

        'If dgvLabour.Columns(0).Width < 100 Then
        '    MsgBox("it went below 100")
        'End If

        ' Me.LstLabourLinkTableAdapter1.FillByProductID(Me.DsProduction1.lstLabourLink, xProdID)
        Me.LstLabCostperProdandDeptTableAdapter1.FillByProduct(Me.DsProduction1.lstLabCostperProdandDept, xProdID)
        Dim xLabCount As Integer = Me.DsProduction1.lstLabCostperProdandDept.Count

        ''now Populate the rows
        Dim xCol As Integer
        Try
            Dim xLabCostUnit As Decimal
            Dim xLabCostOrder As Decimal

            For i = 0 To xLabCount - 1
                'Dim xVariable As String = String.Empty
                'If String.IsNullOrEmpty(MiscCode.MNS(Me.DsProduction1.lstLabourLink.Rows(i).Item("AppVariable"))) Then
                '    xVariable = "No"
                'Else
                '    xVariable = MiscCode.MNS(Me.DsProduction1.lstLabourLink.Rows(i).Item("AppVariable"))
                'End If
                Me.dgvLabour.Rows.Add()
                'Col 1
                dgvLabour.Rows(i).Cells(xCol).Value = Me.DsProduction1.lstLabCostperProdandDept.Rows(i).Item("txtDepName")
                xCol = xCol + 1
                Dim xValueDesc As String = Me.DsProduction1.lstLabCostperProdandDept.Rows(i).Item("txtValueDesc")
                Dim xValue As Decimal = Me.DsProduction1.lstLabCostperProdandDept.Rows(i).Item("SumOfdblAdjValue")
                'Col 3
                dgvLabour.Rows(i).Cells(xCol).Value = CalcMinutesReq(xValue, xValueDesc)
                xCol = xCol + 1
                dgvLabour.Rows(i).Cells(xCol).Value = (CalcMinutesReq(xValue, xValueDesc) * Me.tbJC_Qty.Text) / 60
                'Col 4
                'dgvLabour.Rows(i).Cells(xCol).Value = dgvLabour.Rows(i).Cells(xCol - 1).Value / Me.TextBox7.Text
                'xCol = xCol + 1

                'Dim xProdFactor As Decimal
                'If String.IsNullOrEmpty(MiscCode.MNS(Me.DsProduction1.lstLabourLink.Rows(i).Item("numEffPer"))) Then
                '    xProdFactor = 1
                'Else
                '    xProdFactor = Me.DsProduction1.lstLabourLink.Rows(i).Item("numEffPer")
                'End If
                'Col 5
                'dgvLabour.Rows(i).Cells(xCol).Value = xProdFactor
                'xCol = xCol + 2
                ''Col 7
                ''dgvLabour.Rows(i).Cells(xCol).Value = (dgvLabour.Rows(i).Cells("dgvOpsReq1").Value * Me.TextBox7.Text)
                'If IsDBNull(Me.DsProduction1.lstLabourLink.Rows(i).Item("dblAdjValue")) Then
                '    dgvLabour.Rows(i).Cells(xCol).Value = (dgvLabour.Rows(i).Cells("dgvOpsReq1").Value * Me.tbJC_Qty.Text) 'Me.TextBox7.Text)
                '    xCol = xCol + 1
                'Else
                '    dgvLabour.Rows(i).Cells(xCol).Value = Me.DsProduction1.lstLabourLink.Rows(i).Item("dblAdjValue")
                '    xCol = xCol + 1
                'End If


                'Col 8
                'dgvLabour.Rows(i).Cells(xCol).Value = (dgvLabour.Rows(i).Cells("dgvProjMinperOps").Value / Me.tbJC_Qty.Text) 'Me.TextBox7.Text)
                'xCol = xCol + 2


                'Col 10
                'dgvLabour.Rows(i).Cells(xCol).Value = dgvLabour.Rows(i).Cells("dgvAdjOpsReq").Value * Me.tbJC_Qty.Text 'Me.TextBox4.Text
                'xCol = xCol + 1
                ''Col 11
                ''dgvLabour.Rows(i).Cells(xCol).Value = Me.dsProduction1.lstLabourLink.Rows(i).Item("dbllabourCost")
                'Dim xCost As Decimal = Math.Round(CDec(Me.DsProduction1.lstLabourLink.Rows(i).Item("dblAdjCost")), 4)

                'dgvLabour.Rows(i).Cells(xCol).Value = xCost 'Math.Round(Me.dsProduction1.lstLabourLink.Rows(i).Item("dblAdjCost"), 4)
                'xCol = xCol + 1
                ''Col 12

                'dgvLabour.Rows(i).Cells(xCol).Value = dgvLabour.Rows(i).Cells("dgvLabCostperUnit").Value * Me.tbJC_Qty.Text 'Me.TextBox1.Text


                'xLabCostUnit = xLabCostUnit + dgvLabour.Rows(i).Cells("dgvLabCostperUnit").Value
                'xLabCostOrder = xLabCostOrder + dgvLabour.Rows(i).Cells("dgvLabCostOrder").Value
                xCol = 0
                ' xLabourHours = xLabourHours + Me.DsProduction1.lstLabourLink.Rows(i).Item("dblAdjValue")
            Next
        Catch ex As Exception
            MsgBox("No labour values loaded for this product", MsgBoxStyle.OkOnly, "CCP Messages")
        End Try

        dgvLabour.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvLabour.Columns(0).DefaultCellStyle.Format = "g"
        dgvLabour.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.dgvLabour.AllowUserToAddRows = False

        'Determine the hieght of the grid
        Dim xHeight As Integer = (Me.dgvLabour.ColumnHeadersHeight * 3)
        xHeight = xHeight + (Me.dgvLabour.Rows.Count * 22)

        Me.dgvLabour.Height = xHeight + 28
        MiscCode.ResizeGrid(dgvLabour)
        Me.dgvLabour.Visible = True
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

    Public Sub CreateJCMaterials(ByVal xProdID As String)
        Me.dgvMaterial.DataSource = Nothing
        Dim xMatCostUnit As Integer = 0
        Dim xMatCostOrder As Integer = 0

        Me.dgvMaterial.Columns.Clear()
        Me.dgvMaterial.Rows.Clear()

        Dim xHeaderList As ArrayList = FillHeader("MAT")
        'FillHeader()
        Dim xColNames As ArrayList = FillHeaderFields("MAT")
        Dim i As Integer
        Dim xTotUnits As Decimal
        xTotUnits = Me.tbJC_Qty.Text

        'Add Datagrid Colums
        'Dim xProdCount As Integer = Me.DsOHDB1.lstMarginsperProduct.Count
        For i = 0 To xHeaderList.Count - 1
            Me.dgvMaterial.Columns.Add(xColNames(i), xHeaderList(i))
            dgvMaterial.Columns(xColNames(i).ToString).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvMaterial.Columns(xColNames(i).ToString).DefaultCellStyle.Format = "n"
            dgvMaterial.Columns(xColNames(i).ToString).Width = 100
        Next



        'If Me.ComboBox2.Text = "All" Then
        Me.LstMaterialLinkTableAdapter1.FillByProdictID(Me.DsProduction1.lstMaterialLink, xProdID)
        'Else
        'Me.LstMaterialLinkTableAdapter1.FillByProductType(Me.DsProdDB1.lstMaterialLink, Me.ComboBox1.SelectedValue, Me.ComboBox2.SelectedValue) 'Me.CheckedListBox1.CheckedItems(0).ToString)
        'Me.LstMaterialLinkTableAdapter1.FillByProductType(Me.DsProdDB1.lstMaterialLink, Me.ComboBox1.SelectedValue, Me.ComboBox2.SelectedItem)
        'End If

        Dim xMatCount As Integer = Me.DsProduction1.lstMaterialLink.Count

        'Check if material standards were loaded
        If xMatCount = 1 Then
            If Me.DsProduction1.lstMaterialLink.Rows(0).Item("dblMatQty").ToString = "" Then
                MsgBox("No material standards were loaded")
                Exit Sub
            End If
        End If

        ''now Populate the rows
        Dim xCol As Integer
        For i = 0 To xMatCount - 1
            Me.dgvMaterial.Rows.Add()
            dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProduction1.lstMaterialLink.Rows(i).Item(12)
            'xCol = xCol + 2
            'dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProduction1.lstMaterialLink.Rows(i).Item("dblMatQty")
            xCol = xCol + 1
            dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProduction1.lstMaterialLink.Rows(i).Item("dblMatQty") * xTotUnits
            xCol = xCol + 1
            dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProduction1.lstMaterialLink.Rows(i).Item("txtMaterialUnit")
            'xCol = xCol + 2
            ''dgvMaterial.Rows(i).Cells(xCol).Value = Me.dsProduction1.lstMaterialLink.Rows(i).Item("dblMatCost") / Me.dsProduction1.lstMaterialLink.Rows(i).Item("dblMatQty")
            'dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProduction1.lstMaterialLink.Rows(i).Item("dblMatCost")
            'xCol = xCol + 1
            'dgvMaterial.Rows(i).Cells(xCol).Value = dgvMaterial.Rows(i).Cells("dgvstdUnitCost").Value
            'xCol = xCol + 1
            'dgvMaterial.Rows(i).Cells(xCol).Value = xTotUnits * dgvMaterial.Rows(i).Cells("dgvMatCostperUnit").Value
            'xCol = xCol + 1
            'dgvMaterial.Rows(i).Cells(xCol).Value = Me.DsProduction1.lstMaterialLink.Rows(i).Item("txtType")
            'xMatCostUnit = xMatCostUnit + dgvMaterial.Rows(i).Cells("dgvMatCostperUnit").Value
            'xMatCostOrder = xMatCostOrder + dgvMaterial.Rows(i).Cells("dgvMatCostOrder").Value
            xCol = 0
        Next

        'Set the description column
        'Dim xLen As Integer
        'Dim xMax As Integer
        'For Each xRow As DataGridViewRow In dgvMaterial.Rows
        '    xLen = Len(xRow.Cells(0).Value.ToString)
        '    If xLen > xMax Then xMax = xLen
        'Next

        dgvMaterial.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvMaterial.Columns(0).DefaultCellStyle.Format = "g"
        dgvMaterial.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader


        Me.dgvMaterial.AllowUserToAddRows = False
        MiscCode.ResizeGrid(dgvMaterial)

        'Determine the hieght of the grid
        Dim xHeight As Integer = (Me.dgvMaterial.ColumnHeadersHeight * 3)
        xHeight = xHeight + (Me.dgvMaterial.Rows.Count * 22)

        Me.dgvMaterial.Height = xHeight + 28



        Me.dgvMaterial.Visible = True
    End Sub

    Private Function FillHeader(ByVal xdgv As String)
        Dim xArr As New ArrayList
        If xdgv = "LAB" Then
            xArr.Add("Operation description")
            xArr.Add("Minutes per unit")
            xArr.Add("Planned total Hours required")
            xArr.Add("Operator")
            xArr.Add("Operator2")
            xArr.Add("Notes")
        End If
        If xdgv = "MAT" Then
            xArr.Add("Material description")
            'xArr.Add("Own materials required")
            'xArr.Add("Materials required at standard")
            'xArr.Add("Projected wasteage")
            'xArr.Add("Materials required adjusted for waste")
            'xArr.Add("Actual materials planned")
            xArr.Add("Planned order materials required")
            xArr.Add("Unit of measure")
            'xArr.Add("Own unit cost")
            'xArr.Add("Standard unit cost")
            'xArr.Add("Material cost per unit")
            'xArr.Add("Material cost for order")
            'xArr.Add("Type")
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
            xArr.Add("dgvMinsReq")
            xArr.Add("dgvHoursReq")
            xArr.Add("dgvOp1")
            xArr.Add("dgvOp2")
            xArr.Add("dgvNotes")
        End If
        If xdgv = "MAT" Then
            xArr.Add("dgvOps")
            'xArr.Add("dgvOveride")
            'xArr.Add("dgvStdReq")
            'xArr.Add("dgvWaste")
            'xArr.Add("dgvWasteAdj")
            'xArr.Add("dgvActPlanned")
            xArr.Add("dgvOrderPlanned")
            xArr.Add("dgvUOM")
            'xArr.Add("dgvOwnUnit")
            'xArr.Add("dgvstdUnitCost")
            'xArr.Add("dgvMatCostperUnit")
            'xArr.Add("dgvMatCostOrder")
            'xArr.Add("dgvType")
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

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        Dim fd As OpenFileDialog = New OpenFileDialog()

        If fd.ShowDialog() = DialogResult.OK Then
            Me.tb_Pic.Text = fd.FileName
        Else
            Me.tb_Pic.Text = "None"
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim dia As New diaNotes
        Dim xNotes As String = String.Empty
        dia.Tag = "PO"
        ' Show testDialog as a modal dialog and determine if DialogResult = OK.
        If dia.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            ' Read the contents of testDialog's TextBox.
            Me.RichTextBox3.Text = dia.RichTextBox1.Text
        Else

        End If
        dia.Dispose()
    End Sub

    Private Sub SaveJC(ByVal tblMat As DataTable, ByVal tblLab As DataTable)

        Dim xCo As Integer = MiscCode.GetCoNo()
        Try
            Dim strIns As String = "INSERT INTO tblJC (dblJCno,txtCusRef,FK_tblPOHeader,FK_tblProduct,dblQty,DateETD,txtPic, DateFrom, DateTo, FK_tblCustomer, dDateCreate) VALUES (" & xThisJCNo & ", '" & Me.tbJC_CusRef2.Text.ToString() & "', " & Int32.Parse(xPOHeaderID) & ", " & Me.cbJC_Product.SelectedValue & ", " & Decimal.Parse(Me.tbJC_Qty.Text.ToString()) & ", '" & Format(Me.JCdt_ETD.Value, "yyyy-MM-dd") & "', '', '" & Format(Me.JCDt_DateFrom.Value, "yyyy-MM-dd") & "', '" & Format(Me.JCdt_DateTo.Value, "yyyy-MM-dd") & "', " & Me.cbJC_Customer2.SelectedValue & ", '" & Format(Now(), "MM/dd/yyyy hh:mm:ss tt") & "')"

            Dim xCon As New SqlClient.SqlConnection(My.Settings.ConnectionString1)
            Dim xCom As New SqlClient.SqlCommand(strIns, xCon)
            xCon.Open()

            xCom.ExecuteNonQuery()
            xCom.CommandText = "Select @@Identity"
            xJCID = xCom.ExecuteScalar
        Catch ex As Exception
            MsgBox("The record could not be saved.  Ensure all the fields are completed", , My.Settings.SysName)
            Exit Sub
        End Try


        'Now save the materials
        For Each xRow As DataRow In tblMat.Rows
            Dim xQty As Double = Me.tbJC_Qty.Text
            xQty = xQty * xRow("dblMatQty")
            Me.TblJCMaterialTableAdapter1.Insert(xJCID, xRow("id_tblMatLink"), xRow("MatDesc"), xQty, xRow("txtMaterialUnit"))
        Next

        'Now save the labour requirements
        Dim xRowNo As Integer
        For Each yRow As DataRow In tblLab.Rows
            Dim xValueDesc As String = yRow("txtValueDesc")
            Dim xValue As Decimal = yRow("SumOfdblAdjValue")
            Dim xMins As Double = CalcMinutesReq(xValue, xValueDesc)
            Dim xHour As Double = (CalcMinutesReq(xValue, xValueDesc) * Me.tbJC_Qty.Text) / 60
            Dim xOp1, xOp2, xNotes As String
            If Me.dgvLabour.Rows(xRowNo).Cells("dgvOp1").Value Is Nothing Then xOp1 = "" Else xOp1 = Me.dgvLabour.Rows(xRowNo).Cells("dgvOp1").Value
            If Me.dgvLabour.Rows(xRowNo).Cells("dgvOp2").Value Is Nothing Then xOp2 = "" Else xOp2 = Me.dgvLabour.Rows(xRowNo).Cells("dgvOp2").Value
            If Me.dgvLabour.Rows(xRowNo).Cells("dgvNotes").Value Is Nothing Then xNotes = "" Else xNotes = Me.dgvLabour.Rows(xRowNo).Cells("dgvNotes").Value
            Me.TblJCLabourTableAdapter1.Insert(xJCID, yRow("txtDepName"), xMins, xHour, xOp1, xOp2, xNotes)
            xRowNo = xRowNo + 1
        Next

        'Clear the screen fields
        Dim xShowObj As New ArrayList
        xShowObj.Add("Label51")
        xShowObj.Add("jcCombo1")
        'HideControls(Me.GroupBox1, xShowObj)
        'Me.lbl_JCNumber.Visible = False

        Me.LstPOHeaderDetailsTableAdapter1.FillByOpenPO(Me.DsProduction1.lstPOHeaderDetails)

    End Sub

    Private Sub CreateJC(ByVal xCusId As Integer, ByVal xProdID As Integer)

        Me.lbl_JCNumber.Text = "Job card number - "
        Me.TblJCTableAdapter1.Fill(Me.DsProduction1.tblJC)

        'Dim xProdID As Integer = Me.cbJC_Product.SelectedValue
        'xCusId = Me.cbJC_Customer2.SelectedValue

        Me.dgvMaterial.Location = New Point(12, 170)

        CreateJCMaterials(xProdID)

        Dim xPoint As Integer = Me.dgvMaterial.Height + 150 + 10
        Me.dgvLabour.Location = New Point(513, 170)
        CreateJCLabour(xProdID)

        'Get the next Quote number

        If Me.DsProduction1.Tables("tblJC").Rows.Count = 0 Then
            xThisJCNo = 1
        Else
            xThisJCNo = Me.DsProduction1.Tables("tblJC").Compute("Max(dblJCNO)", "") + 1
        End If

        Me.lbl_JCNumber.Text = Me.lbl_JCNumber.Text & xThisJCNo
        Me.lbl_JCNumber.Visible = True
    End Sub

    Private Sub cbJC_Product_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cbJC_Product.SelectedValueChanged

        If Me.jcCombo1.SelectedItem = "Job card" And Me.jcCombo2.SelectedItem = "Yes" And Me.cbJC_Product.Focused = True Then
            Dim xProdId As Integer = Me.cbJC_Product.SelectedValue
            Me.LstPOHeaderDetailsTableAdapter1.FillByPOidANDProduct(Me.DsProduction1.lstPOHeaderDetails, Me.jcCombo3.SelectedValue, xProdId)
            Me.Label10.Visible = True
            Me.Label11.Visible = True
            Me.Label12.Visible = True
            Me.Label9.Visible = True
            'Me.TblProductTableAdapter1.FillByCombo(Me.DsAccounting1.tblProduct)
            'Me.cbJC_Product.DataSource = DsAccounting1.tblProduct
            'Me.cbJC_Product.ValueMember = "idtblProduct"
            'Me.cbJC_Product.DisplayMember = "txtComboString"
            Me.cbJC_Product.Visible = True
            Me.TblCustomerTableAdapter1.Fill(Me.DsAccounting1.tblCustomer)
            Me.cbJC_Customer2.DataSource = DsAccounting1.tblCustomer
            Me.cbJC_Customer2.ValueMember = "id_tblCustomer"
            Me.cbJC_Customer2.DisplayMember = "txtCusDesc"
            Me.cbJC_Customer2.Visible = True
            Me.tbJC_CusRef2.Visible = True
            Me.tbJC_Qty.Visible = True
            Me.GroupBox4.Location = New Point(12, 107)
            Me.lbl_JCNumber.Location = New Point(625, 120)
            Me.GroupBox4.Visible = True
            Me.Label14.Visible = True
            Me.Label15.Visible = True
            Me.Label16.Visible = True
            Me.JCDt_DateFrom.Visible = True
            Me.JCdt_DateTo.Visible = True
            Me.JCdt_ETD.Visible = True
            Me.cbJC_Customer2.SelectedValue = Me.DsProduction1.lstPOHeaderDetails.Rows(0).Item("FK_idtblCustomer")
            Me.tbJC_Qty.Text = Me.DsProduction1.lstPOHeaderDetails.Rows(0).Item("decQty")
            Me.tbJC_CusRef2.Text = Me.DsProduction1.lstPOHeaderDetails.Rows(0).Item("txtCusRef")
            CreateJC(Me.DsProduction1.lstPOHeaderDetails.Rows(0).Item("FK_idtblCustomer"), Me.DsProduction1.lstPOHeaderDetails.Rows(0).Item("FK_tblProduct"))
        End If

    End Sub

    Private Sub HideControls(ByVal xObj As Object, ByVal xShowObj As ArrayList)

        For Each xCon As Control In xObj.controls
            If xShowObj.Contains(xCon.Name) = False Then
                xCon.Visible = False
            End If
        Next
    End Sub
End Class