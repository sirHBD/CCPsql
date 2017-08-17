Imports System.Windows.Forms
Imports System.Math
Imports System.Data.SqlClient
Public Class frmAccountingMain
    Public Shared QQArray As New ArrayList
    Private Sub frmAccountingMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Me.Cursor = Cursors.WaitCursor
        'TODO: This line of code loads data into the 'DsAccounting.tblReceipts' table. You can move, or remove it, as needed.
        Me.TblReceiptsTableAdapter.Fill(Me.DsAccounting.tblReceipts)
        'TODO: This line of code loads data into the 'DsAccounting.lstQuoteHeaders' table. You can move, or remove it, as needed.
        Me.LstQuoteHeadersTableAdapter.Fill(Me.DsAccounting.lstQuoteHeaders)
        Me.Text = My.Settings.SysName & " - " & "Accounting"
        Me.TblCustomerTableAdapter1.Fill(Me.DsAccounting.tblCustomer)
        Me.TblCoInfoTableAdapter1.Fill(Me.DsAccounting.tblCoInfo)
        Me.TblQuoteHeaderTableAdapter1.Fill(Me.DsAccounting.tblQuoteHeader)
        Me.TblQuoteDetailTableAdapter1.Fill(Me.DsAccounting.tblQuoteDetail)
        Me.tb_OrderQty_Quote.Text = 1
        Me.TabControl1.TabPages(0).Hide()
        Me.Cursor = Cursors.Default


        If Me.Tag = "QQ" Then
            Me.TabControl1.SelectedTab = tPage_Quote
            Me.ComboBox5.SelectedIndex = 0
            Me.Label37.Visible = False
            Me.Label38.Visible = False
            Me.ComboBox6.Visible = False
            Me.ComboBox7.Visible = False
            Me.GroupBox2.Visible = True
            Me.GroupBox3.Visible = True
            Me.ComboBox5.Enabled = False
            Me.cb_Quote_Product.SelectedValue = QQArray(0)
            If xQQCusID >= 0 Then
                Me.cb_Quote_Customer.SelectedValue = xQQCusID
                Me.CheckBox1.Checked = True
            End If
            Me.tb_ProdID.Text = QQArray(0)
            Me.tb_ProfPer.Text = QQArray(1)
            Me.tb_OrderQty_Quote.Text = QQArray(2)
            CalculateQuoteValue(QQArray(0))
            'Get this quote number
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
        End If
    End Sub

    Private Sub tPage_Reports_Enter(sender As Object, e As System.EventArgs) Handles tPage_Reports.Enter
        Dim xTextLen As Integer = Me.ComboBox1.DropDownWidth
        Dim g As Graphics = Me.ComboBox1.CreateGraphics
        Dim f As Font = Me.ComboBox1.Font
        Dim xVertScrollLen As Integer = (Me.ComboBox1.Items.Count > Me.ComboBox1.MaxDropDownItems)

        Dim xNewLen
        For Each s As Object In Me.ComboBox1.Items
            xNewLen = g.MeasureString(s.row.combotext, Font).Width
            If xTextLen < xNewLen Then
                xTextLen = xNewLen
            End If

        Next
        Me.ComboBox1.DropDownWidth = xTextLen
    End Sub

    Private Sub tPage_Reports_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles tPage_Reports.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub tPage_Reports_Resize(sender As Object, e As System.EventArgs) Handles tPage_Customer.Resize
        Me.Invalidate()
    End Sub

    Private Sub tPage_Quote_Enter(sender As Object, e As System.EventArgs) Handles tPage_Quote.Enter
        Me.TblProductTableAdapter1.FillByCombo(Me.DsAccounting.tblProduct)
        Me.cb_Quote_Product.DataSource = Me.DsAccounting.tblProduct
        Me.cb_Quote_Product.ValueMember = "idtblProduct"
        Me.cb_Quote_Product.DisplayMember = "txtComboString"

        Me.cb_Quote_Product.SelectedIndex = -1
        Me.cb_Quote_Customer.SelectedIndex = -1


    End Sub

    Private Sub tPage_Quote_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles tPage_Quote.Paint
        Try
            Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
            Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
            e.Graphics.FillRectangle(Grad, BaseRec)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub tPage_Quote_Resize(sender As Object, e As System.EventArgs) Handles tPage_Quote.Resize
        Me.Invalidate()

    End Sub

    Private Sub tPage_Invoice_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs)
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub tPage_Invoice_Resize(sender As Object, e As System.EventArgs)
        Me.Invalidate()
    End Sub

    Private Sub tPage_Receipts_Enter(sender As Object, e As System.EventArgs) Handles tPage_Receipts.Enter
        Me.ComboBox2.SelectedIndex = -1
    End Sub

    Private Sub tPage_Receipts_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles tPage_Receipts.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub tPage_Receipts_Resize(sender As Object, e As System.EventArgs) Handles tPage_Receipts.Resize
        Me.Invalidate()
    End Sub

    Private Sub pb_Add_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pb_Add.MouseClick

        Me.TblCustomerBindingSource.AddNew()
        Me.GroupBox1.Text = "Add a new customer"
        Me.GroupBox1.Visible = True
        Me.DataGridView1.SendToBack()
    End Sub

    Private Sub pb_Add_MouseHover(sender As Object, e As System.EventArgs) Handles pb_Add.MouseHover

        Me.ToolTip1.SetToolTip(sender, sender.tag)

    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Me.TblCustomerBindingSource.EndEdit()
        Me.TblCustomerTableAdapter1.Update(Me.DsAccounting.tblCustomer)
        Me.TblCustomerBindingSource.Filter = ""
        Me.TblCustomerTableAdapter1.Fill(Me.DsAccounting.tblCustomer)
        Me.DataGridView1.Refresh()
        Me.GroupBox1.Visible = False
    End Sub

    Private Sub pb_Edit_Click(sender As Object, e As System.EventArgs) Handles pb_Edit.Click
        Dim xCus As Integer
        xCus = Me.DataGridView1.CurrentRow.Cells(0).Value
        Me.TblCustomerBindingSource.Filter = "id_tblCustomer = " & xCus
        Me.GroupBox1.Text = "Edit current customer"
        Me.GroupBox1.Visible = True
        Me.DataGridView1.SendToBack()


    End Sub

    Private Sub pb_Edit_MouseHover(sender As Object, e As System.EventArgs) Handles pb_Edit.MouseHover
        Me.ToolTip1.SetToolTip(sender, sender.tag)
    End Sub

    Private Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        Me.TblCustomerBindingSource.Filter = ""
        Me.TblCustomerTableAdapter1.Fill(Me.DsAccounting.tblCustomer)
        Me.DataGridView1.Refresh()
        Me.GroupBox1.Visible = False
    End Sub

    Private Sub TblCustomerBindingSource_CurrentItemChanged(sender As Object, e As System.EventArgs) Handles TblCustomerBindingSource.CurrentItemChanged
        ' If sender.items.count = 0 Then Exit Sub
        If CheckBox1.Checked = True Then
            Me.TextBox8.Text = TblCustomerBindingSource.Current.row.item("txtCusDesc")
            Me.RichTextBox3.Text = TblCustomerBindingSource.Current.row.item("txtAddPos")
            Me.TextBox9.Text = TblCustomerBindingSource.Current.row.item("txtPhone1")
            Me.TextBox10.Text = TblCustomerBindingSource.Current.row.item("txtEmail")
            Me.TextBox12.Text = TblCustomerBindingSource.Current.row.item("txtPhone2")
            Me.TextBox13.Text = TblCustomerBindingSource.Current.row.item("txtFax")
            Me.TextBox14.Text = TblCustomerBindingSource.Current.row.item("txtContactName")
        Else
            Me.TextBox8.Text = String.Empty
            Me.RichTextBox3.Text = String.Empty
            Me.TextBox9.Text = String.Empty
            Me.TextBox10.Text = String.Empty
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.cb_Quote_Customer.Enabled = True
            If Me.TblCustomerBindingSource.Current IsNot Nothing Then
                Me.TextBox8.Text = TblCustomerBindingSource.Current.row.item("txtCusDesc")
                Me.RichTextBox3.Text = TblCustomerBindingSource.Current.row.item("txtAddPos")
                Me.TextBox9.Text = TblCustomerBindingSource.Current.row.item("txtPhone1")
                Me.TextBox10.Text = TblCustomerBindingSource.Current.row.item("txtEmail")
                PrintingVariables.toEmail = TblCustomerBindingSource.Current.row.item("txtEmail")
                Me.TextBox15.Text = TblCustomerBindingSource.Current.row.item("id_tblCustomer")
            End If

        Else
            Me.cb_Quote_Customer.Enabled = False
            Me.TextBox8.Text = String.Empty
            Me.RichTextBox3.Text = String.Empty
            Me.TextBox9.Text = String.Empty
            Me.TextBox10.Text = String.Empty
            PrintingVariables.toEmail = String.Empty
            Me.TextBox15.Text = String.Empty
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

                xProdIndex = 1

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

            Me.Label23.Text = "(" & xBudgetPrice & ")"
            Me.Label23.Visible = True
            If String.IsNullOrEmpty(xNoValues) = True Then
                Me.tb_NPSellPrice.Text = Round(((CDec(xBudgetPrice) - (CDec(Me.tb_MatCost.Text) + CDec(Me.tb_LabCost.Text))) / (CDec(Me.tb_MatCost.Text) + CDec(Me.tb_LabCost.Text))) * 100, 2)
            End If
        End If



    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        If IsNumeric(Me.cb_Quote_Product.SelectedValue) Then

            Dim xProductID As Integer = Me.cb_Quote_Product.SelectedValue
            CalculateQuoteValue(xProductID)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        For Each xCtrl As Control In Me.GroupBox3.Controls
            Dim xType As String = xCtrl.GetType.ToString
            If xCtrl.GetType.ToString = "System.Windows.Forms.TextBox" And xCtrl.Tag = "Clear" Then
                xCtrl.Text = String.Empty
            End If
        Next
        Me.Label23.Text = String.Empty

    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim xDocType As String = Me.ComboBox5.SelectedItem

        Select Case xDocType

            Case "Quotation"
                'First decide if this is a new quote.  It it is then add a header record
                Dim xQuoteID As Integer
                Try
                    If Me.DataGridView2.Visible = False Then
                        Dim xCusNo As Integer
                        If Me.CheckBox1.Checked Then
                            xCusNo = Me.cb_Quote_Customer.SelectedValue
                        Else
                            xCusNo = -1
                        End If

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
                        dr.close()

                        Me.tb_QuoteNo.Text = CDec(xQuoteNo) + 1

                        Me.Button7.Enabled = True

                        Dim xCurDate As Date = Date.Today.ToShortDateString

                        Me.TblQuoteHeaderTableAdapter1.Insert(xCusNo, CInt(MiscCode.GetCoNo()), (CDec(xQuoteNo) + 1), Me.TextBox8.Text.ToString(), Me.RichTextBox3.Text.ToString(), Me.TextBox14.Text.ToString(), Me.TextBox10.Text.ToString(), Me.TextBox9.Text.ToString(), Me.TextBox12.Text.ToString(), Me.TextBox13.Text.ToString(), xCurDate, My.User.Name, "Added", "", "")

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



                    Else
                        xQuoteID = Me.tb_QuoteID.Text
                    End If
                Catch ex As IndexOutOfRangeException
                    MsgBox("Index out of Range No1")
                End Try
                'Now add the details
                Try

                    Dim xProdCde = Me.cb_Quote_Product.Text.ToString.Split(",")

                    Dim xBudgetPrice As String = MiscCode.GetValueonID(Me.tb_ProdID.Text, "fk_tblProductID", "tblProdBud", "decSalesPrice")
                    If xBudgetPrice Is Nothing Then xBudgetPrice = 0
                    If String.IsNullOrEmpty(Me.tb_SellingPrice.Text) Then Me.tb_SellingPrice.Text = xBudgetPrice
                    If String.IsNullOrEmpty(Me.tb_OrderQty_Quote.Text) Then Me.tb_OrderQty_Quote.Text = 1

                    Me.TblQuoteDetailTableAdapter1.Insert(xQuoteID, Me.cb_Quote_Product.SelectedValue, xProdCde(0), xProdCde(1), xProdCde(2), "", "", Me.tb_OrderQty_Quote.Text, Me.tb_SellingPrice.Text, Me.tb_SellingPrice.Text * Me.tb_OrderQty_Quote.Text, xBudgetPrice, 14, ((Me.tb_SellingPrice.Text * Me.tb_OrderQty_Quote.Text) * 14) / 100, (((Me.tb_SellingPrice.Text * Me.tb_OrderQty_Quote.Text) * 14) / 100) + (Me.tb_SellingPrice.Text * Me.tb_OrderQty_Quote.Text), "Each")




                    Me.TbllnvoiceDetailBindingSource.EndEdit()
                    Me.TbllnvoiceDetailTableAdapter1.Update(Me.DsAccounting.tbllnvoiceDetail)
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

            Case "Tax Invoice"

                CreateInvoice()


        End Select
    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click

        If Len(Me.TextBox8.Text.ToString()) = 0 Then
            MsgBox("Please select a customer before printing or saving the quotation or invoice")
            Exit Sub
        End If

        Dim xDocType As String = Me.ComboBox5.SelectedItem

        Select Case xDocType

            Case "Quotation"

                'Me.TblQuoteHeaderBindingSource.Current.Row.item("FK_idtblCustomer") = Me.TextBox15.Text
                Me.TblQuoteDetailBindingSource.EndEdit()
                Me.TblQuoteHeaderTableAdapter1.Update(Me.DsAccounting.tblQuoteHeader)
                Me.TblQuoteDetailTableAdapter1.Update(Me.DsAccounting.tblQuoteDetail)
                Me.DsAccounting.AcceptChanges()

            Case "Tax Invoice"

                'Me.TblInvoiceHeaderlBindingSource.Current.Row.item("FK_idtblCustomer") = Me.TextBox15.Text
                Me.TbllnvoiceDetailBindingSource.EndEdit()
                Me.TbllnvoiceDetailTableAdapter1.Update(Me.DsAccounting.tbllnvoiceDetail)
                Me.TblInvoiceHeaderTableAdapter1.Update(Me.DsAccounting.tblInvoiceHeader)
                Me.DsAccounting.AcceptChanges()



        End Select

    End Sub

    Private Sub Button7_Click(sender As Object, e As System.EventArgs) Handles Button7.Click

        If Len(Me.TextBox8.Text.ToString()) = 0 Then
            MsgBox("Please select a customer before printing or saving the quotation or invoice")
            Exit Sub
        End If


        Dim frm As New frmRepViewer
        'frm.MdiParent = Me

        Dim xDocType As String = Me.ComboBox5.SelectedItem

        Select Case xDocType

            Case "Quotation"
                frm.Tag = "Quote"
                If String.IsNullOrEmpty(Me.tb_QuoteNo.Text) Then
                    MsgBox("The quote has not been prepared and.or saved and can not be printed at this time", , My.Settings.SysName)
                    Return
                Else
                    PrintingVariables.xId2Print = Me.tb_QuoteNo.Text
                End If
                frm.Show()
                'FillActiveChildFormToClient()

            Case "Tax Invoice"
                frm.Tag = "Tax Invoice"
                If String.IsNullOrEmpty(Me.tb_InvoiceNo.Text) Then
                    MsgBox("The Invoice has not been prepared and.or saved and can not be printed at this time", , My.Settings.SysName)
                    Return
                Else
                    PrintingVariables.xId2Print = Me.tb_InvoiceNo.Text
                End If
                frm.Show()
                'FillActiveChildFormToClient()
        End Select

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

    Private Sub ComboBox1_GotFocus(sender As Object, e As System.EventArgs) Handles ComboBox1.GotFocus
        Me.LstQuoteHeadersTableAdapter.Fill(Me.DsAccounting.lstQuoteHeaders)
    End Sub

    Private Sub ComboBox2_GotFocus(sender As Object, e As System.EventArgs) Handles ComboBox2.GotFocus
        Me.LstQuoteHeadersTableAdapter.Fill(Me.DsAccounting.lstQuoteHeaders)
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Me.TextBox11.Text = Me.ComboBox1.SelectedValue

        Dim strSQL As String = "Select txtEmail from tblQuoteHeader where dblQuoteNum = " & Me.TextBox11.Text
        Dim strSQL1 As String = "Select txtEmail from tblInvoiceHeader where dblInvoiceNum = " & Me.TextBox11.Text
        Dim xCon As New SqlConnection(My.Settings.ConnectionString1)
        Dim xCom As New SqlCommand(strSQL, xCon)

        If Me.RadioButton1.Checked = True Then
            xCon.Open()
            PrintingVariables.toEmail = xCom.ExecuteScalar
            xCon.Close()
        End If

        If Me.RadioButton2.Checked = True Then
            xCom.CommandText = strSQL1
            xCon.Open()
            PrintingVariables.toEmail = xCom.ExecuteScalar
            xCon.Close()
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As System.EventArgs) Handles Button8.Click
        Dim xWrongSelection As Boolean = True

        If Me.RadioButton1.Checked And String.IsNullOrEmpty(Me.TextBox11.Text) = False Then
            Dim frm As New frmRepViewer
            frm.Tag = "Quote"
            PrintingVariables.xId2Print = Me.TextBox11.Text

            frm.Show()
            xWrongSelection = False
        Else

        End If

        If Me.RadioButton3.Checked And String.IsNullOrEmpty(Me.TextBox11.Text) = False And xWrongSelection = True Then
            Dim frm As New frmRepViewer
            frm.Tag = "ReceiptPerDocument"
            PrintingVariables.xId2Print = Me.TextBox11.Text
            frm.Show()
            xWrongSelection = False
        Else

        End If

        If Me.RadioButton2.Checked And String.IsNullOrEmpty(Me.TextBox11.Text) = False And xWrongSelection = True Then
            Dim frm As New frmRepViewer
            frm.Tag = "Tax Invoice"
            PrintingVariables.xId2Print = Me.TextBox11.Text
            frm.Show()
            xWrongSelection = False
        Else

        End If
        If xWrongSelection = True Then
            MsgBox("Please select required fields", , My.Settings.SysName)
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As System.EventArgs) Handles Button9.Click
        Dim FabricDialog As New diaFabric
        Dim xMatID As String
        ' Show testDialog as a modal dialog and determine if DialogResult = OK.
        If FabricDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            ' Read the contents of testDialog's TextBox.
            xMatID = FabricDialog.TextBox1.Text
        Else
            xMatID = -1
        End If
        FabricDialog.Dispose()

        Dim xDocType As String = Me.ComboBox5.SelectedItem

        Select Case xDocType

            Case "Quotation"
                'First decide if this is a new quote.  It it is then add a header record
                Dim xQuoteID As Integer

                If Me.DataGridView2.Visible = False Then
                    Dim xCusNo As Integer
                    If Me.CheckBox1.Checked Then
                        xCusNo = Me.cb_Quote_Customer.SelectedValue
                    Else
                        xCusNo = -1
                    End If

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


                Else
                    xQuoteID = Me.tb_QuoteID.Text
                End If

                Dim xMat = xMatID.Split("|")
                If String.IsNullOrEmpty(xMatID) = False Then
                    Try
                        Dim xPrice As Decimal = Round(CDec(xMat(8)), 4)
                        Me.TblQuoteDetailTableAdapter1.Insert(Me.tb_QuoteID.Text, CInt(xMat(0)), xMat(2), xMat(3), xMat(4), xMat(5), xMat(6), 1, xPrice, xPrice, xPrice, 14, (xPrice * 14) / 100, xPrice + (xPrice * 14) / 100, xMat(7))
                        Me.TblQuoteDetailBindingSource.EndEdit()
                        Me.TblQuoteDetailTableAdapter1.Update(Me.DsAccounting.tblQuoteDetail)
                    Catch ex As Exception
                        MsgBox("Error found during material update", MsgBoxStyle.Information, My.Settings.SysName)
                    End Try

                    Me.TblQuoteDetailTableAdapter1.Fill(Me.DsAccounting.tblQuoteDetail)
                    Me.TblQuoteDetailBindingSource.Filter = "fk_tblQuoteHeader = " & xQuoteID
                    Me.DataGridView2.Refresh()
                    Me.DataGridView2.Visible = True
                    MiscCode.ResizeGrid(Me.DataGridView2)
                End If
                Me.Button10.Visible = True
                Me.Button11.Enabled = False

            Case "Tax Invoice"
                CreateInvoice(xMatID)
        End Select



    End Sub

    Private Sub Button10_Click(sender As Object, e As System.EventArgs) Handles Button10.Click
        Dim xDocType As String = Me.ComboBox5.SelectedItem

        Select Case xDocType

            Case "Quotation"

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

            Case "Tax Invoice"
                Dim dia As New diaNotes
                Dim xNotes As String = String.Empty
                Dim xRef As String = String.Empty

                dia.Tag = "Tax Invoice"
                ' Show testDialog as a modal dialog and determine if DialogResult = OK.
                If dia.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                    ' Read the contents of testDialog's TextBox.
                    xNotes = dia.RichTextBox1.Text
                    xRef = dia.TextBox1.Text
                Else

                End If
                dia.Dispose()
                If String.IsNullOrEmpty(xNotes) = False Or String.IsNullOrEmpty(xRef) = False Then
                    Dim strSQL As String = "Update tblInvoiceHeader Set txtNotes = " & """" & xNotes & """" & ", txtCusRef = " & """" & xRef & """" & " where dblInvoiceNum = " & Me.tb_InvoiceNo.Text
                    Dim xCon = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
                    xCon.open()
                    Dim xComm As New SqlClient.SqlCommand(strSQL, xCon)
                    xComm.ExecuteNonQuery()
                    xCon.Close()
                End If
        End Select



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

    Private Sub Button12_Click(sender As Object, e As System.EventArgs) Handles Button12.Click
        'First Validate all entries
        If (Me.ComboBox2.SelectedValue >= 0 Or Me.ComboBox3.SelectedValue >= 0) And Len(Me.ComboBox4.SelectedItem) > 0 Then
            If IsNumeric(Me.TextBox22.Text) And IsDate(Me.TextBox21.Text) Then
                Dim xReply As Integer
                xReply = MsgBox("Are you sure you want to save this receipt", MsgBoxStyle.YesNo, My.Settings.SysName)
                If xReply = 6 Then
                    Dim xHeaderinfo As String = MiscCode.MNS(Me.ComboBox2.SelectedValue & "|" & Me.ComboBox2.Tag)
                    Dim xInvoiceNo As String = -1 'MiscCode.bdQuickFind(My.Settings.ConnectionString, "dblInvoiceNum", Me.ComboBox3.SelectedValue, "tblQuoteHeader", "", "")
                    Dim xQuoteInfo = xHeaderinfo.Split("|")
                    Dim xQuoteNo As Integer = CInt(xQuoteInfo(0))
                    Dim xQuoteID As Integer = CInt(xQuoteInfo(1))
                    Dim xCusNo As Integer = MiscCode.MNS(Me.DsAccounting.tblQuoteHeader.Rows.Find(xQuoteID).Item("FK_idtblCustomer"))
                    Me.TblReceiptsTableAdapter.Insert(xQuoteID, xInvoiceNo, xCusNo, Me.TextBox21.Text, Me.ComboBox4.Text, Me.TextBox22.Text, "Added", Now(), My.User.Name, "")

                    Dim xRecNo As Integer
                    Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
                    myConnection.Open()
                    Dim myCommand = New SqlClient.SqlCommand
                    myCommand = New SqlClient.SqlCommand("Select Max(id_tblReceipts) AS LastRecNo from tblReceipts", myConnection)
                    Dim dr = myCommand.ExecuteReader()
                    If dr.hasrows() = True Then
                        While dr.read()
                            If IsDBNull(dr.item("LastRecNo")) Then
                                xRecNo = 0
                            Else
                                xRecNo = dr.item("LastRecNo")
                            End If
                        End While
                    End If
                    Me.tb_ReceiptNo.Text = CDec(xRecNo)
                End If

            Else
                MsgBox("Please entered proper amount and/or date", , My.Settings.SysName)
            End If
        Else

            MsgBox("Please select quote or invoice", , My.Settings.SysName)
        End If

    End Sub

    Private Sub Button13_Click(sender As Object, e As System.EventArgs) Handles Button13.Click

        Dim frm As New frmRepViewer
        frm.Tag = "Receipt"
        If String.IsNullOrEmpty(Me.tb_ReceiptNo.Text) Then
            MsgBox("Accept and save the quote to enable printing", , My.Settings.SysName)
        Else
            PrintingVariables.xId2Print = Me.tb_ReceiptNo.Text
        End If

        frm.Show()

    End Sub

    Private Sub ComboBox5_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles ComboBox5.SelectionChangeCommitted

        Dim xDocType As String = sender.selectedItem
        Select Case xDocType

            Case "Tax Invoice"
                Me.Label37.Visible = True
                Me.Label38.Visible = True
                Me.ComboBox6.Visible = True
                Me.ComboBox7.Visible = False
                Me.TblInvoiceHeaderTableAdapter1.Fill(Me.DsAccounting.tblInvoiceHeader)
                Me.TbllnvoiceDetailTableAdapter1.Fill(Me.DsAccounting.tbllnvoiceDetail)
            Case "Quotation"
                Me.Label37.Visible = False
                Me.Label38.Visible = False
                Me.ComboBox6.Visible = False
                Me.ComboBox7.Visible = False
                Me.GroupBox2.Visible = True
                Me.GroupBox3.Visible = True
            Case "Job card"
                Me.Label37.Visible = True
                Me.Label38.Visible = True
                Me.ComboBox6.Visible = True
                Me.ComboBox7.Visible = False
                Me.TblInvoiceHeaderTableAdapter1.Fill(Me.DsAccounting.tblInvoiceHeader)
                Me.TbllnvoiceDetailTableAdapter1.Fill(Me.DsAccounting.tbllnvoiceDetail)

        End Select

        Me.ComboBox5.Enabled = False

    End Sub

    Private Sub ComboBox6_Click(sender As Object, e As System.EventArgs) Handles ComboBox6.SelectionChangeCommitted

        Dim xDocType As String = Me.ComboBox5.SelectedItem

        Select Case xDocType
            Case "Tax Invoice"
                If Me.ComboBox6.SelectedItem = "No" Then

                    Me.Label38.Visible = False
                    Me.ComboBox7.Visible = False
                    Me.GroupBox2.Visible = True
                    Me.GroupBox3.Visible = True
                    Me.Button6.Text = "Create/Save Invoice"
                    Me.Button7.Text = "Print Invoice"
                    Me.Button10.Text = "Add Invoice Notes"
                    Me.Button11.Text = "Edit previous invoice"
                    Me.Button3.Text = "Add to invoice"
                Else
                    ComboBox7.DataSource = Nothing
                    Me.LstQuoteHeadersTableAdapter.FillByUninvoiced(Me.DsAccounting.lstQuoteHeaders)
                    ComboBox7.DataSource = New BindingSource(DsAccounting.lstQuoteHeaders, Nothing)
                    ComboBox7.DisplayMember = "ComboText"
                    ComboBox7.ValueMember = "dblQuoteNum"
                    If Me.DsAccounting.lstQuoteHeaders.Rows.Count > 0 Then
                        ComboBox7.Visible = True
                    Else
                        Me.Label38.Text = "No quotes are uninvoiced"
                        Return
                    End If

                    Me.Button3.Text = "Add to invoice"
                    Me.Button6.Text = "Create/Save Invoice"
                    Me.Button7.Text = "Print Invoice"
                    Me.Button10.Text = "Add Invoice Notes"
                    Me.Button11.Text = "Edit previous invoice"
                End If


        End Select



    End Sub

    Private Sub ComboBox7_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles ComboBox7.SelectionChangeCommitted
        Dim xQuoteNo As String = Me.ComboBox7.SelectedValue

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
        Me.tb_QuoteNo.Text = xQuoteNo
        Me.tb_QuoteID.Text = MiscCode.MNS(Me.DsAccounting.tblQuoteHeader.Rows.Find(xQuoteID).Item("id_tblQuoteHeader"))

        CreateInvoice()

        Me.tb_QuoteNo.Text = xQuoteNo
        Me.tb_QuoteID.Text = xQuoteID
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = True

    End Sub

    Private Sub DataGridView3_CellValidating(sender As Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DataGridView3.CellValidating
        Dim xCell As DataGridViewCell = Me.DataGridView3.CurrentCell
        Dim xCoNo As String = MiscCode.GetCoNo

        If xCell.OwningColumn.HeaderText = "Quantity" Then
            Dim xRowIndex As Integer = xCell.RowIndex
            Dim xQty As Decimal = xCell.EditedFormattedValue
            Me.DataGridView3.Rows(xRowIndex).Cells("dgv3_Amt").Value = Round(xQty * Me.DataGridView3.Rows(xRowIndex).Cells("dgv3_SP").Value, 2)
            Me.DataGridView3.Rows(xRowIndex).Cells("dgv3_VatAmt").Value = Round(Me.DataGridView3.Rows(xRowIndex).Cells("dgv3_Amt").Value * (CDec(MiscCode.GetValueonID(xCoNo, "idtblCoInfo", "TblCoInfo", "dblVatRate") / 100)))
            Me.DataGridView3.Rows(xRowIndex).Cells("dgv3_TotAmt").Value = Me.DataGridView3.Rows(xRowIndex).Cells("dgv3_Amt").Value + Me.DataGridView3.Rows(xRowIndex).Cells("dgv3_VATAmt").Value
            xCell.Value = xQty
        End If
        If xCell.OwningColumn.HeaderText = "Selling Price" Then
            Dim xRowIndex As Integer = xCell.RowIndex
            Dim xSP As Decimal = Me.DataGridView3.Rows(xRowIndex).Cells("dgv3_SP").EditedFormattedValue
            xCell.Value = CDec(xCell.EditedFormattedValue)
            Dim xQty As Decimal = Me.DataGridView3.Rows(xRowIndex).Cells("dgv3_Qty").EditedFormattedValue
            Me.DataGridView3.Rows(xRowIndex).Cells("dgv3_Amt").Value = Round(xQty * Me.DataGridView3.Rows(xRowIndex).Cells("dgv3_SP").EditedFormattedValue, 2)
            Me.DataGridView3.Rows(xRowIndex).Cells("dgv3_VatAmt").Value = Round(Me.DataGridView3.Rows(xRowIndex).Cells("dgv3_Amt").Value * (CDec(MiscCode.GetValueonID(xCoNo, "idtblCoInfo", "TblCoInfo", "dblVatRate") / 100)))
            Me.DataGridView3.Rows(xRowIndex).Cells("dgv3_TotAmt").Value = Me.DataGridView3.Rows(xRowIndex).Cells("dgv3_Amt").Value + Me.DataGridView3.Rows(xRowIndex).Cells("dgv3_VATAmt").Value
            xCell.Value = xSP
        End If

    End Sub

    Private Sub DataGridView3_RowValidated(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.RowValidated
        Me.TbllnvoiceDetailBindingSource.EndEdit()
        Me.TbllnvoiceDetailTableAdapter1.Update(Me.DsAccounting.tbllnvoiceDetail)
        Me.TbllnvoiceDetailTableAdapter1.Fill(Me.DsAccounting.tbllnvoiceDetail)
        Me.DataGridView3.Refresh()
    End Sub

    Private Sub CreateInvoice(Optional ByVal xMatStr As String = "")
        'Determine if we are working with an alreade created invoice of not

        If Len(Me.tb_InvoiceID.Text) = 0 Then
            Dim xReply As Integer
            xReply = MsgBox("Are you sure you want to create a new invoice?", MsgBoxStyle.YesNo, My.Settings.SysName)
            If xReply = 7 Then
                Return
            Else
                'Create a new invoice

                Dim xCusNo As Integer
                If Me.CheckBox1.Checked Then
                    xCusNo = Me.cb_Quote_Customer.SelectedValue
                Else
                    xCusNo = -1
                End If

                Dim xInvoiceNo As String = "0"

                Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
                myConnection.Open()
                Dim myCommand = New SqlClient.SqlCommand
                myCommand = New SqlClient.SqlCommand("Select Max(dblInvoiceNum) AS LastInvoiceNo from tblInvoiceHeader", myConnection)
                Dim dr = myCommand.ExecuteReader()
                If dr.hasrows() = True Then
                    While dr.read()
                        If IsDBNull(dr.item("LastInvoiceNo")) Then
                            xInvoiceNo = 0
                        Else
                            xInvoiceNo = dr.item("LastInvoiceNo")
                        End If
                    End While
                End If
                dr.close()

                Me.tb_InvoiceNo.Text = CDec(xInvoiceNo) + 1
                Me.Button7.Enabled = True

                Dim xCurDate As Date = Date.Today.ToShortDateString
                If tb_QuoteID.Text = "" Then tb_QuoteID.Text = -1
                Me.TblInvoiceHeaderTableAdapter1.Insert(xCusNo, CInt(MiscCode.GetCoNo()), (CDec(xInvoiceNo) + 1), Me.TextBox8.Text, Me.RichTextBox3.Text, Me.TextBox14.Text, Me.TextBox10.Text, Me.TextBox9.Text, Me.TextBox12.Text, Me.TextBox13.Text, xCurDate, My.User.Name, "Added", "", "", Me.tb_QuoteID.Text)

                Dim xInvoiceID As Integer = 0
                myCommand = New SqlClient.SqlCommand("Select Max(id_tblInvoiceHeader) AS LastInvoiceID from tblInvoiceHeader", myConnection)
                Dim dr1 = myCommand.ExecuteReader()
                If dr1.hasrows() = True Then
                    While dr1.read()
                        If IsDBNull(dr1.item("LastInvoiceID")) Then
                            xInvoiceID = 0
                        Else
                            xInvoiceID = dr1.item("LastInvoiceID")
                        End If
                    End While
                End If
                Me.tb_InvoiceID.Text = xInvoiceID

                'Now add new invoice detail but first determine if we are adding from quote
                If Me.ComboBox6.Text = "No" Then
                    'Decide if we adding a direct product of a Not
                    If xMatStr = "" Then
                        Dim xProdCde = Me.cb_Quote_Product.Text.ToString.Split(",")
                        Dim xBudgetPrice As String = MiscCode.GetValueonID(Me.tb_ProdID.Text, "fk_tblProductID", "tblProdBud", "decSalesPrice")
                        If xBudgetPrice Is Nothing Then xBudgetPrice = 0
                        If Me.tb_SellingPrice.Text = "" Then Me.tb_SellingPrice.Text = xBudgetPrice
                        Me.TbllnvoiceDetailTableAdapter1.Insert(xInvoiceID, Me.cb_Quote_Product.SelectedValue, xProdCde(0), xProdCde(1), xProdCde(2), "", "", 1, xBudgetPrice, xBudgetPrice, Me.tb_SellingPrice.Text, 14, (xBudgetPrice * 14) / 100, xBudgetPrice + (xBudgetPrice * 14) / 100, "Each")
                        If xBudgetPrice = 0 Then
                            MsgBox("A line has been added with a zero selling price.  Please correct", MsgBoxStyle.Exclamation, My.Settings.SysName)
                        End If

                    Else
                        Dim xMat = xMatStr.Split("|")
                        Dim xPrice As Decimal = Round(CDec(xMat(8)), 4)
                        Me.DataGridView3.Visible = True
                        Me.TbllnvoiceDetailTableAdapter1.Insert(Me.tb_InvoiceID.Text, CInt(xMat(0)), xMat(2), xMat(3), xMat(4), xMat(5), xMat(6), 1, xPrice, xPrice, xPrice, 14, (xPrice * 14) / 100, xPrice + (xPrice * 14) / 100, xMat(7))
                        Me.TbllnvoiceDetailBindingSource.EndEdit()
                        Me.TbllnvoiceDetailTableAdapter1.Update(Me.DsAccounting.tbllnvoiceDetail)
                        Me.TbllnvoiceDetailTableAdapter1.Fill(Me.DsAccounting.tbllnvoiceDetail)
                        Me.TbllnvoiceDetailBindingSource.Filter = "fk_tblnvoiceHeader = " & xInvoiceID
                        Me.DataGridView3.Refresh()

                        MiscCode.ResizeGrid(Me.DataGridView2)
                    End If


                Else
                    'Adding from previously captured quote
                    Me.TblQuoteDetailBindingSource.Filter = "fk_tblQuoteHeader = " & CInt(Me.tb_QuoteID.Text)
                    Dim i As Integer
                    For i = 0 To Me.TblQuoteDetailBindingSource.Count - 1
                        Dim xRow As DataRowView = Me.TblQuoteDetailBindingSource.Item(i)
                        Me.TbllnvoiceDetailTableAdapter1.Insert(xInvoiceID, xRow.Item("fk_tblProduct"), xRow.Item("txtProdCde"), xRow.Item("txtProdDesc"), xRow.Item("txtProdSpec1"), xRow.Item("txtProdSpec2"), xRow.Item("txtProdSpec2"), xRow.Item("decQty"), xRow.Item("decSellingPrice"), xRow.Item("decSellingValue"), xRow.Item("decOriginalPrice"), xRow.Item("decVatPercentage"), xRow.Item("decVatAmount"), xRow.Item("decQuoteLineAmount"), xRow.Item("txtUOM"))
                    Next
                    UpdateQuoteStatus(Me.tb_QuoteID.Text, "Invoiced")
                End If

            End If

        Else
            If xMatStr = "" Then
                Dim xInvoiceID As Integer = Me.tb_InvoiceID.Text
                'Add details only if invoice has been generate
                Dim xProdCde = Me.cb_Quote_Product.Text.ToString.Split(",")
                Dim xBudgetPrice As String = MiscCode.GetValueonID(Me.tb_ProdID.Text, "fk_tblProductID", "tblProdBud", "decSalesPrice")
                Me.TbllnvoiceDetailTableAdapter1.Insert(xInvoiceID, Me.cb_Quote_Product.SelectedValue, xProdCde(0), xProdCde(1), xProdCde(2), "", "", 1, xBudgetPrice, xBudgetPrice, Me.tb_SellingPrice.Text, 14, (xBudgetPrice * 14) / 100, xBudgetPrice + (xBudgetPrice * 14) / 100, "Each")
                If xBudgetPrice = 0 Then
                    MsgBox("A line has been added with a zero selling price.  Please correct", MsgBoxStyle.Exclamation, My.Settings.SysName)
                End If

            Else
                Dim xMat = xMatStr.Split("|")
                Dim xPrice As Decimal = Round(CDec(xMat(8)), 4)
                Me.DataGridView3.Visible = True
                Me.TbllnvoiceDetailTableAdapter1.Insert(Me.tb_InvoiceID.Text, CInt(xMat(0)), xMat(2), xMat(3), xMat(4), xMat(5), xMat(6), 1, xPrice, xPrice, xPrice, 14, (xPrice * 14) / 100, xPrice + (xPrice * 14) / 100, xMat(7))
                Me.TbllnvoiceDetailBindingSource.EndEdit()
                Me.TbllnvoiceDetailTableAdapter1.Update(Me.DsAccounting.tbllnvoiceDetail)
                Me.TbllnvoiceDetailTableAdapter1.Fill(Me.DsAccounting.tbllnvoiceDetail)
                Me.TbllnvoiceDetailBindingSource.Filter = "fk_tblnvoiceHeader = " & Me.tb_InvoiceID.Text
                Me.DataGridView3.Refresh()

                MiscCode.ResizeGrid(Me.DataGridView2)

            End If


        End If

        'Now display Datagrid 3
        Me.DataGridView3.Visible = True
        Me.TbllnvoiceDetailTableAdapter1.Fill(Me.DsAccounting.tbllnvoiceDetail)
        Me.TbllnvoiceDetailBindingSource.Filter = "fk_tblnvoiceHeader = " & Me.tb_InvoiceID.Text
        Me.DataGridView3.Visible = True
        Me.DataGridView3.Refresh()
        Me.DataGridView3.Location = New Point(8, 222)

        MiscCode.ResizeGrid(Me.DataGridView3)
        Me.Button10.Visible = True
        Me.Button11.Enabled = False
    End Sub

    Private Sub UpdateQuoteStatus(ByVal xQuoteID As Integer, ByVal xStatus As String)

        Dim strSQL As String = "Update tblQuoteHeader Set txtQuoteStatus = '" & xStatus & "' where id_tblQuoteHeader = " & xQuoteID
        Dim xCon As New SqlConnection(My.Settings.ConnectionString1)
        Dim xComm As New SqlCommand(strSQL, xCon)
        xCon.Open()
        xComm.ExecuteNonQuery()
        xCon.Close()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If sender.checked = True Then
            Me.ComboBox1.DataSource = Nothing
            Me.LstInvoiceHeadersTableAdapter1.Fill(Me.DsAccounting.lstInvoiceHeaders)
            Me.ComboBox1.DataSource = New BindingSource(Me.DsAccounting.lstInvoiceHeaders, Nothing)
            Me.ComboBox1.DisplayMember = "comboText"
            Me.ComboBox1.ValueMember = "dblInvoiceNum"
        Else
            Me.ComboBox1.DataSource = Nothing
            Me.LstQuoteHeadersTableAdapter.Fill(Me.DsAccounting.lstQuoteHeaders)
            Me.ComboBox1.DataSource = New BindingSource(Me.DsAccounting.lstQuoteHeaders, Nothing)
            Me.ComboBox1.DisplayMember = "comboText"
            Me.ComboBox1.ValueMember = "dblQuoteNum"
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        MsgBox("Use the tabs below to navigate to the tab page required and then manage the records", , My.Settings.SysName)

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        MsgBox("Use the tabs below to navigate to the tab page required and then manage the records", , My.Settings.SysName)
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        My.Forms.ApplicationStartupForm.ss1.Text = "All records saved"
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        MsgBox("Use the tabs below to navigate to the tab page required and then select the print the records", , My.Settings.SysName)

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Me.Close()
    End Sub

    Private Sub TextBox21_Enter(sender As Object, e As System.EventArgs) Handles TextBox21.Enter

        If Me.ComboBox2.SelectedIndex = -1 Then
            MsgBox("A document must be selected")
        End If

    End Sub
End Class