Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DataGridViewAutoFilter

Public Class frmProduct
Public xTrfID As Integer
Dim tmpDS As DataSet
Dim xResetFilter As String
Dim xHasChanges As Boolean
Dim xBusyCopy As Boolean = False

    Private Sub frmProduct_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
    My.Forms.ApplicationStartupForm.ss1.Text = ""
    End Sub

    Private Sub frmProduct_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.Text = My.Settings.SysName & " - " & "Product"
    Me.TblProductTableAdapter2.Fill(Me.DsProdDB1.tblProduct)
    Me.TblProdBudTableAdapter1.Fill(Me.DsProdDB1.tblProdBud)

    Me.GroupBox2.BackColor = myGBColor
    Me.DataGridView1.BackgroundColor = myGBColor
        Me.TblprodbudDataGridView.BackgroundColor = myGBColor

        If Me.DsProdDB1.Tables("tblProduct").Rows.Count = 0 Then Exit Sub

    Me.bs_tblProduct.Sort = "txtProdCde"
    Me.bs_tblProdBud.Filter = "FK_tblProductID = " & Me.DataGridView1.CurrentRow.Cells("dgv1_idtblProduct").Value

    If MiscCode.GetCoNo() IsNot Nothing Then
        Me.tb_Co.Text = MiscCode.GetCoNo()
        Me.tb_Co.Enabled = False
        Else
        MsgBox("A company must be created before other actions are permitted", , My.Settings.SysName & " - Add a product")
        Me.Close()
        End If

    End Sub

    Private Sub Product_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, myTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)

    End Sub

    Private Sub Product_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Invalidate()

    End Sub

    Private Sub TabPage_ProdDet_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TabPage_ProdDet.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, myTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub TabPage_ProdBud_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage_ProdBud.Leave

    Me.TblprodbudDataGridView.EditMode = 4
    Me.TblprodbudDataGridView.AllowUserToAddRows = False
    My.Forms.ApplicationStartupForm.ss1.Text = ""

    End Sub

    Private Sub TabPage_ProdBud_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TabPage_ProdBud.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, myTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub TabPage_ProdActVal_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TabPage_ProdActVal.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, myTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub TabPage_ProdActVol_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TabPage_ProdActVol.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, myTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub TabPage_ProdActDet_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage_ProdDet.Resize
        Me.Invalidate()
    End Sub

    Private Sub TabPage_ProdActBud_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage_ProdBud.Resize
        Me.Invalidate()
    End Sub

    Private Sub TabPage_ProdActVal_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage_ProdActVal.Resize
        Me.Invalidate()
    End Sub

    Private Sub TabPage_ProdActVol_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage_ProdActVol.Resize
        Me.Invalidate()
    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    MsgBox("A data error occured - " & e.Context.ToString, , My.Settings.SysName)

    If e.Context = DataGridViewDataErrorContexts.Commit Then
    MsgBox("Commit error")
    e.ThrowException = False
    End If

    If e.Context = DataGridViewDataErrorContexts.CurrentCellChange Then
    MsgBox("Cell Change")
    End If

    If e.Context = DataGridViewDataErrorContexts.Display Then
    MsgBox("Display error", , My.Settings.SysName)
    e.ThrowException = False
    End If


    If (TypeOf (e.Exception) Is ConstraintException) Then
    Dim view As DataGridView = CType(sender, DataGridView)
    view.Rows(e.RowIndex).ErrorText = "DataError"
    e.ThrowException = False
    End If

    End Sub

    Private Sub DataGridView1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Resize

        Me.dgv1_idtblProduct.Visible = False
        Me.DataGridView1.Invalidate()
        MiscCode.ResizeGrid(Me.DataGridView1)

    End Sub

    Private Sub DataGridView1_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating

    If sender.CurrentRow Is Nothing Then Return
    If sender.rows(e.RowIndex).isNewRow Then Return
    If sender.IsCurrentCellDirty = False Then Return

    Dim xColName As String = DataGridView1.Columns(e.ColumnIndex).HeaderText

    'Abort validation if not needed
    If Not (xColName.Equals("Description") Or xColName.Equals("Product Spec 1") Or xColName.Equals("Product Code") Or xColName.Equals("Company")) Then Return

    'Validate Mandatory Input for Product Code and description
    If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
    DataGridView1.Rows(e.RowIndex).ErrorText = xColName & " is a mandatory field"
    e.Cancel = True
    End If



    End Sub

    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged

    If sender.CurrentRow Is Nothing Then Return

    Dim xColName As String = DataGridView1.Columns(e.ColumnIndex).HeaderText
    'Do duplicate check on product code if filled in
    If xColName.Equals("Product Code") Then
    Dim xProdcode As String = sender.CurrentCell.EditedFormattedValue
            Dim xCheckDup As String = MiscCode.bdQuickFind(My.Settings.ConnectionString1, "txtProdCde", xProdcode, "tblProduct", "", "")
            If Len(xCheckDup) > 0 Then
                DataGridView1.Rows(e.RowIndex).ErrorText = xColName & " can not contain duplicates"
            Else
                DataGridView1.Rows(e.RowIndex).ErrorText = ""
            End If
        End If
    End Sub

    Private Sub DataGridView1_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView1.RowValidating

        If sender.CurrentRow Is Nothing Then Exit Sub
        If DataGridView1.Rows(e.RowIndex).ErrorText <> "" Then Return
        If sender.iscurrentrowdirty = False Then Return


        Try
            If sender.rows(e.RowIndex).isNewRow = True Then
                'First check that duplicate product code was not entered
                Dim xProdcode As String = sender.Currentrow.cell("TxtProdCdeDataGridViewTextBoxColumn").value
                Dim xCheckDup As String = MiscCode.bdQuickFind(My.Settings.ConnectionString1, "txtProdCde", xProdcode, "tblProduct", "", "")
                If Len(xCheckDup) > 0 Then
                    DataGridView1.Rows(e.RowIndex).ErrorText = "Product code can not contain duplicates"
                    Return
                End If

                'Now check that the other mandatory fields

                For Each xCol As DataGridViewColumn In sender.columns
                    Dim xColName As String = xCol.HeaderText
                    Dim xCell As DataGridViewCell = Me.DataGridView1.CurrentRow.Cells(xCol.Index)

                    If (xColName.Equals("Description") Or xColName.Equals("Product Spec 1") Or xColName.Equals("Product Code") Or xColName.Equals("Company")) Then

                        'Validate Mandatory Input for Product Code and description
                        If (String.IsNullOrEmpty(xCell.FormattedValue.ToString())) Then
                            DataGridView1.Rows(e.RowIndex).ErrorText = xColName & " is a mandatory field"
                            e.Cancel = True
                        End If


                    Else

                    End If
                Next
            End If

        Catch ex As Exception

            MsgBox("Validating Error")

        End Try

    End Sub

    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated

        If xBusyCopy = True Then Return

        If sender.focused = False Then
            Return
        Else
            Try
                Dim xRowState As DataRowState = Me.bs_tblProduct.Current.row.rowstate
                Dim xProdCode As String = Me.bs_tblProduct.Current.row.item("txtProdCde")
                'if row is error don't save
                If sender.CurrentRow.Errortext = "" And sender.iscurrentrowdirty = True Then
                    'Save Record and display message
                    Me.Validate()
                    Me.bs_tblProduct.EndEdit()
                    Me.TblProductTableAdapter2.Update(Me.DsProdDB1.tblProduct)
                    Me.DsProdDB1.AcceptChanges()


                    If xRowState = DataViewRowState.Added Then
                        My.Forms.ApplicationStartupForm.ss1.Text = "New Row added for product " & xProdCode
                        Me.TblProductTableAdapter2.Fill(Me.DsProdDB1.tblProduct)

                    ElseIf xRowState = DataViewRowState.ModifiedCurrent Then
                        My.Forms.ApplicationStartupForm.ss1.Text = "Product " & xProdCode & " was updated"
                    End If
                Else
                    'Don't save the record
                    If sender.IsCurrentRowDirty = True Then
                        My.Forms.ApplicationStartupForm.ss1.Text = "Product " & xProdCode & " has errors and was not updated"
                        Me.DsProdDB1.tblProduct.RejectChanges()
                    End If
                End If
            Catch ex As Exception
                MsgBox("Error when saving and refreshing the Datagrid" & ex.Message)

            End Try

        End If

    End Sub

    Private Sub DataGridView1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyUp

        If e.KeyData = 46 Then
            Dim xresult As String

            xresult = MiscCode.DisplayError("006", "YesCancel")
            If xresult = 1 Then

                Me.bs_tblProduct.EndEdit()
                Me.TblProductTableAdapter2.Update(Me.DsProdDB1.tblProduct)

            Else
                Me.DsProdDB1.RejectChanges()
                Me.DataGridView1.Refresh()
            End If
        End If
    End Sub

    Private Sub bs_tblProduct_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs_tblProduct.CurrentChanged

        If sender.current Is Nothing Then Exit Sub
        Dim xProdID As Integer

        Try
            xProdID = Me.bs_tblProduct.Current.row.item("idtblProduct")
            Dim xCoId As Integer
            If IsDBNull(Me.bs_tblProduct.Current.row.item("FK_idtblCoInfo")) Then
                xCoId = 0
            Else
                xCoId = Me.bs_tblProduct.Current.row.item("FK_idtblCoInfo")
            End If
            'Me.TblProdBudTableAdapter1.Fill(Me.DsProdDB1.tblProdBud)
            'Me.bs_tblProdBud.Filter = "FK_tblProductID = " & xProdID
            'Me.TblProdLinkBindingSource.Filter = "FK_tblProduct = " & xProdID
            Me.tb_Co.Text = xCoId
            'My.Forms.ApplicationStartupForm.ss1.Text = ""

        Catch ex As Exception
            MsgBox("OOOps - " & ex.Message)
        End Try

    End Sub

    Private Sub TblprodbudDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblprodbudDataGridView.CellEndEdit

        Dim xCurCell As DataGridViewCell = Me.TblprodbudDataGridView.CurrentCell

        If IsDBNull(Me.TblprodbudDataGridView.CurrentRow.Cells("DecVolumeDataGridViewTextBoxColumn").Value) Or IsDBNull(Me.TblprodbudDataGridView.CurrentRow.Cells("DecSalesPriceDataGridViewTextBoxColumn").Value) Then
            Exit Sub
        Else
            Dim xSP As Decimal = Me.TblprodbudDataGridView.CurrentRow.Cells("DecSalesPriceDataGridViewTextBoxColumn").Value
            Dim xVol As Decimal = Me.TblprodbudDataGridView.CurrentRow.Cells("DecVolumeDataGridViewTextBoxColumn").Value
            Me.TblprodbudDataGridView.CurrentRow.Cells("DecGrossIncomeDataGridViewTextBoxColumn").Value = xVol * xSP
        End If

    End Sub

    Private Sub TblprodbudDataGridView_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles TblprodbudDataGridView.DefaultValuesNeeded
        e.Row.Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub TblprodbudDataGridView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TblprodbudDataGridView.Resize
        Me.DataGridView1.Invalidate()
        MiscCode.ResizeGrid(Me.TblprodbudDataGridView)
    End Sub

    Private Sub TblprodbudDataGridView_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblprodbudDataGridView.RowEnter

        Me.TblprodbudDataGridView.Columns("IdtblProdBudDataGridViewTextBoxColumn").Visible = False

        If sender.CurrentRow Is Nothing And Me.TblprodbudDataGridView.NewRowIndex <> 0 Then Exit Sub

        If sender.editmode = 4 Then
            Beep()
            My.Forms.ApplicationStartupForm.ss1.Text = "The Datagrid is not in edit mode"
            My.Forms.ApplicationStartupForm.ss1.BackColor = Color.DarkSalmon
            Return
        End If

        Dim xRow As Integer = Me.DataGridView1.CurrentRow.Index
        Dim xIDValue As Integer = Me.DataGridView1.Rows(xRow).Cells(0).Value
        Dim xBudRow As Integer


        xBudRow = Me.TblprodbudDataGridView.NewRowIndex

        If xBudRow > -1 Then
            'Me.TblprodbudDataGridView.Rows(xBudRow).Cells(1).Value = xIDValue

        Else
            'Me.TblprodbudDataGridView.Rows(xBudRow).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(0).Value

        End If

    End Sub

    Private Sub DataGridView3_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim xChanges As Object = Me.DsProdDB1.tblProdLink.GetChanges()
        If xChanges IsNot Nothing Then
            Me.Validate()
            Me.TblProdLinkBindingSource.EndEdit()
            Me.TblProdLinkTableAdapter.Update(Me.DsProdDB1.tblProdLink)
        End If
    End Sub

    Private Sub TabPage_ProdBud_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage_ProdBud.Enter
        Try
            If Len(Me.Tag) = 0 Then
                Me.Label2.Text = Me.bs_tblProduct.Current.row.item("txtProdCde") & " - " & Me.bs_tblProduct.Current.row.item("txtProdDesc")
                Me.bs_tblProdBud.Filter = "FK_tblProductID = " & Me.bs_tblProduct.Current.row.item("idtblProduct")
            Else
                Me.bs_tblProduct.Filter = "idtblProduct=" & Me.Tag
                Me.Label2.Text = Me.bs_tblProduct.Current.row.item("txtProdCde") & " - " & Me.bs_tblProduct.Current.row.item("txtProdDesc")
                Me.bs_tblProdBud.Filter = "FK_tblProductID = " & Me.bs_tblProduct.Current.row.item("idtblProduct")
            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnFillEasyOptions_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFillEasyOptions.Click

        If cBox_Deletecurrent.Checked = True Then
            Me.TblProdBudTableAdapter1.DeleteBudgetPerProduct(Me.bs_tblProduct.Current.item("idtblProduct"))
        ElseIf Me.TblprodbudDataGridView.Rows.Count > 1 Then
            Dim xMsgResult As Integer
            xMsgResult = MiscCode.DisplayError("007")
            If xMsgResult = 1 Then
                Me.TblProdBudTableAdapter1.DeleteBudgetPerProduct(Me.bs_tblProduct.Current.item("idtblProduct"))
            Else
                Exit Sub
            End If
        End If


        Me.bs_tblProdBud.EndEdit()
        Me.TblProdBudTableAdapter1.Update(Me.DsProdDB1.tblProdBud)
        Me.TblProdBudTableAdapter1.Fill(Me.DsProdDB1.tblProdBud)
        Me.TblprodbudDataGridView.Refresh()


        'Now apply filling options
        Dim xYEDate As Date
        xYEDate = Me.TblCoInfoTableAdapter1.GetFinYearEnd(Me.tb_Co.Text)
        ' = Me.DsProdDB1.tblCoInfo.Rows(0).Item("dteFinYearEnd")
        Dim xStartMonth As Date = DateAdd(DateInterval.Month, 1, xYEDate)
        Dim i As Integer

        If cbox_FillMonths.Checked = True And String.IsNullOrEmpty(Me.tb_FixedPrice.Text) And String.IsNullOrEmpty(Me.tb_SpreadVolume.Text) Then

            For i = 0 To 11

                Dim xRow As DataRow = Me.DsProdDB1.Tables("tblProdBud").NewRow
                xRow.Item("FK_tblProductid") = Me.bs_tblProduct.Current.item("idtblproduct")
                Dim xMonthstring As String = xStartMonth.ToString("MMM")
                xRow.Item("txtPeriodDescriptor") = xMonthstring
                Me.DsProdDB1.tblProdBud.Rows.Add(xRow)
                xStartMonth = DateAdd(DateInterval.Month, 1, xStartMonth)



            Next
            Me.bs_tblProdBud.EndEdit()
            Me.TblProdBudTableAdapter1.Update(Me.DsProdDB1.tblProdBud)
            Me.TblProdBudTableAdapter1.Fill(Me.DsProdDB1.tblProdBud)
            Me.DataGridView1.Refresh()
            'Me.TblprodbudDataGridView.Invalidate()
        End If

        If Me.cb_ChangeMonth.SelectedIndex <> -1 And String.IsNullOrEmpty(Me.tb_FixedPrice.Text) And String.IsNullOrEmpty(Me.tb_SpreadVolume.Text) Then
            xStartMonth = CDate("01-" & Me.cb_ChangeMonth.Text & Now.Year.ToString)

            For i = 0 To 11

                Dim xRow As DataRow = Me.DsProdDB1.Tables("tblProdBud").NewRow
                xRow.Item("FK_tblProductid") = Me.bs_tblProduct.Current.item("idtblproduct")
                Dim xMonthstring As String = xStartMonth.ToString("MMM")
                xRow.Item("txtPeriodDescriptor") = xMonthstring
                Me.DsProdDB1.tblProdBud.Rows.Add(xRow)
                xStartMonth = DateAdd(DateInterval.Month, 1, xStartMonth)
            Next
            Me.bs_tblProdBud.EndEdit()
            Me.TblProdBudTableAdapter1.Update(Me.DsProdDB1.tblProdBud)
            Me.TblProdBudTableAdapter1.Fill(Me.DsProdDB1.tblProdBud)
            Me.DataGridView1.Refresh()

        End If


        If cbox_FillMonths.Checked = True And String.IsNullOrEmpty(Me.tb_FixedPrice.Text) = False And String.IsNullOrEmpty(Me.tb_SpreadVolume.Text) Then

            For i = 0 To 11

                Dim xRow As DataRow = Me.DsProdDB1.Tables("tblProdBud").NewRow
                xRow.Item("FK_tblProductid") = Me.bs_tblProduct.Current.item("idtblproduct")
                Dim xMonthstring As String = xStartMonth.ToString("MMM")
                xRow.Item("txtPeriodDescriptor") = xMonthstring
                xRow.Item("decSalesPrice") = tb_FixedPrice.Text
                Me.DsProdDB1.tblProdBud.Rows.Add(xRow)
                xStartMonth = DateAdd(DateInterval.Month, 1, xStartMonth)
            Next
            Me.bs_tblProdBud.EndEdit()
            Me.TblProdBudTableAdapter1.Update(Me.DsProdDB1.tblProdBud)
            Me.TblProdBudTableAdapter1.Fill(Me.DsProdDB1.tblProdBud)
            Me.DataGridView1.Refresh()
        End If

        If cbox_FillMonths.Checked = True And String.IsNullOrEmpty(Me.tb_FixedPrice.Text) = False And String.IsNullOrEmpty(Me.tb_SpreadVolume.Text) = False Then

            For i = 0 To 11

                Dim xRow As DataRow = Me.DsProdDB1.Tables("tblProdBud").NewRow
                xRow.Item("FK_tblProductid") = Me.bs_tblProduct.Current.item("idtblproduct")
                Dim xMonthstring As String = xStartMonth.ToString("MMM")
                xRow.Item("txtPeriodDescriptor") = xMonthstring
                xRow.Item("decSalesPrice") = tb_FixedPrice.Text
                xRow.Item("decVolume") = tb_SpreadVolume.Text / 12
                xRow.Item("txtPeriodDescriptor") = xMonthstring
                xRow.Item("decGrossIncome") = (tb_SpreadVolume.Text / 12) * Me.tb_FixedPrice.Text
                Me.DsProdDB1.tblProdBud.Rows.Add(xRow)
                xStartMonth = DateAdd(DateInterval.Month, 1, xStartMonth)
            Next
            Me.bs_tblProdBud.EndEdit()
            Me.TblProdBudTableAdapter1.Update(Me.DsProdDB1.tblProdBud)
            Me.TblProdBudTableAdapter1.Fill(Me.DsProdDB1.tblProdBud)
            Me.DataGridView1.Refresh()
        End If


        If Me.cb_ChangeMonth.SelectedIndex <> -1 And String.IsNullOrEmpty(Me.tb_FixedPrice.Text) = False And String.IsNullOrEmpty(Me.tb_SpreadVolume.Text) = False Then
            xStartMonth = CDate("01-" & Me.cb_ChangeMonth.Text & Now.Year.ToString)
            For i = 0 To 11

                Dim xRow As DataRow = Me.DsProdDB1.Tables("tblProdBud").NewRow
                xRow.Item("FK_tblProductid") = Me.bs_tblProduct.Current.item("idtblproduct")
                Dim xMonthstring As String = xStartMonth.ToString("MMM")
                xRow.Item("txtPeriodDescriptor") = xMonthstring
                xRow.Item("decSalesPrice") = tb_FixedPrice.Text
                xRow.Item("decVolume") = tb_SpreadVolume.Text / 12
                xRow.Item("txtPeriodDescriptor") = xMonthstring
                xRow.Item("decGrossIncome") = (tb_SpreadVolume.Text / 12) * Me.tb_FixedPrice.Text
                Me.DsProdDB1.tblProdBud.Rows.Add(xRow)
                xStartMonth = DateAdd(DateInterval.Month, 1, xStartMonth)
            Next
            Me.bs_tblProdBud.EndEdit()
            Me.TblProdBudTableAdapter1.Update(Me.DsProdDB1.tblProdBud)
            Me.TblProdBudTableAdapter1.Fill(Me.DsProdDB1.tblProdBud)
            Me.DataGridView1.Refresh()
        End If
    End Sub

    Private Sub ctx_Copy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctx_Copy.Click

        If Me.DataGridView1.GetCellCount(DataGridViewElementStates.Selected) > 0 Then

            Try

                ' Add the selection to the clipboard.
                Clipboard.SetDataObject( _
                    Me.DataGridView1.GetClipboardContent())
                xBusyCopy = True
                Me.bs_tblProduct.AddNew()
            Catch ex As System.Runtime.InteropServices.ExternalException
                My.Forms.ApplicationStartupForm.ss1.Text = _
                    "The Clipboard could not be accessed. Please try again."
            End Try

        End If

    End Sub

    Private Sub ctx_Paste_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctx_Paste.Click
        Try
            PasteData(Me.DataGridView1)
            Dim xRowIndex As Integer = Me.DataGridView1.CurrentRow.Index
            Dim xProductCde As String = Me.DataGridView1.CurrentRow.Cells("TxtProdCdeDataGridViewTextBoxColumn").Value
            If Me.DataGridView1.CurrentRow.ErrorText = "" Then
                Me.Validate()
                Me.bs_tblProduct.EndEdit()
                Me.TblProductTableAdapter2.Update(Me.DsProdDB1.tblProduct)
                My.Forms.ApplicationStartupForm.ss1.Text = "New Row added for product " & Me.DataGridView1.CurrentRow.Cells("TxtProdCdeDataGridViewTextBoxColumn").Value
                Me.TblProductTableAdapter2.Fill(Me.DsProdDB1.tblProduct)
                Me.bs_tblProduct.Position = Me.bs_tblProduct.Find("txtProdCde", xProductCde)
            End If
        Catch ex As Exception
            MsgBox("Paste was not successful.  See attached error message - " & ex.Message, , My.Settings.SysName)
        End Try
    End Sub

    Public Sub PasteData(ByRef dgv As DataGridView)

        'Before pasting make sure the grid is not filtered on Product Code
        Dim xFilter As String
        If dgv.DataSource.filter Is Nothing Then
            xFilter = String.Empty
        Else
            xFilter = dgv.DataSource.filter
        End If
        If xFilter.StartsWith("[txtProdCde") Then
            MsgBox("Unable to paste when filtered on Product Code", , My.Settings.SysName)
            Return
        End If

        Me.DataGridView1.Enabled = True
        Me.DataGridView1.ReadOnly = False

        If Me.bs_tblProduct.Current.isnew = False Then
            xBusyCopy = True
            Me.bs_tblProduct.AddNew()
        End If

        Dim tArr() As String
        Dim arT() As String
        Dim i, ii As Integer
        Dim c, cc, r As Integer

        tArr = Clipboard.GetText().Trim().Split(Environment.NewLine)  '!!! Added Trim() ...because when pasting from vb App


        r = dgv.CurrentCellAddress.Y()     'this is easier
        c = dgv.CurrentCellAddress.X()
        If (tArr.Length > (dgv.Rows.Count - r)) Then dgv.Rows.Add(tArr.Length - (dgv.Rows.Count - r)) 'check length of the clipboard and the datagridview

        For i = 0 To tArr.Length - 1
            If tArr(i) <> "" Then
                arT = tArr(i).Split(vbTab)
                cc = c
                For ii = 0 To arT.Length - 1
                    If cc > dgv.ColumnCount - 1 Then Exit For
                    If r > dgv.Rows.Count - 1 Then Exit Sub
                    With dgv.Item(cc, r)
                        .Value = arT(ii).TrimStart
                    End With
                    cc = cc + 1
                Next
                r = r + 1
            End If
        Next
        'Me.bs_tblProduct.Filter = String.Empty
        'dgv.CurrentRow.ErrorText = "Duplicate values created by paste - Please correct"
        Me.DataGridView1.CurrentCell = Me.DataGridView1.CurrentRow.Cells("TxtProdCdeDataGridViewTextBoxColumn")
        Me.DataGridView1.CurrentCell.Value = NextProductNo(Me.DataGridView1.CurrentCell.Value)
        xBusyCopy = False
        Me.DataGridView1.BeginEdit(True)
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged

        If DataGridView1.CurrentCell Is Nothing Then Exit Sub

        'All you need to do is to set the CurrentCell after you do your refresh:
        Try
            Dim ptCurrentCell As Point = Me.DataGridView1.CurrentCellAddress
            'Refresh()

            ' now reset the current cell
            Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(ptCurrentCell.Y).Cells(ptCurrentCell.X)
        Catch
            MsgBox("Error Found")
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        If Me.TabPage_ProdDet.Visible = True Then
            Dim dia As Form = dProductAdd
            dia.ShowDialog()
            If dia.DialogResult = Windows.Forms.DialogResult.OK Then
                Me.TblProductTableAdapter2.Fill(Me.DsProdDB1.tblProduct)
            End If
            dia.Close()
        End If

        If Me.TabPage_ProdBud.Visible = True Then
            Dim xRows As Integer = Me.TblprodbudDataGridView.Rows.Count
            Me.TblprodbudDataGridView.AllowUserToAddRows = True
            Me.TblprodbudDataGridView.EditMode = 1
            'Me.bs_tblProdBud.AddNew()
            Me.TblprodbudDataGridView.Rows(Me.TblprodbudDataGridView.Rows.Count - 1).Selected = True
        End If

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        If Me.TabPage_ProdDet.Visible = True Then
            Me.DataGridView1.Enabled = True
            Me.DataGridView1.ReadOnly = False
            Dim dia As Form = dProductAdd
            dia.Tag = Me.bs_tblProduct.Current.row.item("idtblProduct")
            dia.ShowDialog()
            If dia.DialogResult = Windows.Forms.DialogResult.OK Then
                Me.TblProductTableAdapter2.Fill(Me.DsProdDB1.tblProduct)
            End If
            dia.Close()
        End If


        If Me.TabPage_ProdBud.Visible = True Then
            Me.TblprodbudDataGridView.EditMode = 1
            My.Forms.ApplicationStartupForm.ss1.Text = "..."
            My.Forms.ApplicationStartupForm.ss1.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click

        If Me.TabPage_ProdDet.Visible = True Then
            Me.DsProdDB1.RejectChanges()
            Me.DataGridView1.Refresh()
        End If

        If Me.TabPage_ProdBud.Visible = True Then
            Me.DsProdDB1.RejectChanges()
            Me.TblprodbudDataGridView.Refresh()
        End If

    End Sub

    Private Sub ctx_Delete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctx_Delete.Click

        Dim xProdID As Integer = Me.bs_tblProduct.Current.Row.item("idTblProduct")

        Dim strSql As String = "Delete from tblProduct where idtblProduct = " & xProdID
        Dim strSql1 As String = "Delete from tblProdBud where FK_tblProductID = " & xProdID
        Dim MyCon As New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        Dim MyCom As New SqlClient.SqlCommand(strSql, MyCon)
        Try
            MyCon.Open()
            MyCom.ExecuteNonQuery()
            Dim MyCom1 As New SqlClient.SqlCommand(strSql1, MyCon)
            MyCom1.ExecuteNonQuery()
            MyCon.Close()
            Me.TblProductTableAdapter2.Fill(Me.DsProdDB1.tblProduct)
            My.Forms.ApplicationStartupForm.ss1.Text = "Product - " & xProdID & " - was deleted"
        Catch ex As Exception
            MsgBox("Could not execute the deletion")
        End Try



    End Sub

    Private Sub TblprodbudDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblprodbudDataGridView.RowValidated

        'If IsDBNull(Me.TblprodbudDataGridView.CurrentRow.Cells("DecVolumeDataGridViewTextBoxColumn").Value) Or IsDBNull(Me.TblprodbudDataGridView.CurrentRow.Cells("DecSalesPriceDataGridViewTextBoxColumn").Value) Then
        '    Exit Sub
        '        Else
        '        Dim xSP As Decimal = Me.TblprodbudDataGridView.CurrentRow.Cells("DecSalesPriceDataGridViewTextBoxColumn").Value
        '        Dim xVol As Decimal = Me.TblprodbudDataGridView.CurrentRow.Cells("DecVolumeDataGridViewTextBoxColumn").Value
        '        Me.TblprodbudDataGridView.CurrentRow.Cells("DecGrossIncomeDataGridViewTextBoxColumn").Value = xVol * xSP
        '        End If

        'Update database
        If Me.TblprodbudDataGridView.CurrentRow.ErrorText = "" Then

            Dim xIsDispayed As Boolean = sender.currentrow.Displayed

            If Me.DsProdDB1.HasChanges And xIsDispayed = True Then
                Me.bs_tblProdBud.EndEdit()
                Me.TblProdBudTableAdapter1.Update(Me.DsProdDB1.tblProdBud)
                My.Forms.ApplicationStartupForm.ss1.Text = "Product - " & Me.Label2.Text & " - was updated"
            End If
        End If
    End Sub

    Private Sub TblprodbudDataGridView_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles TblprodbudDataGridView.RowValidating

        If sender Is Nothing Then Return
        If sender.CurrentRow Is Nothing Then Return
        Try
            For Each xCol As DataGridViewColumn In sender.columns
                Dim xColName As String = xCol.HeaderText
                Dim xCell As DataGridViewCell = sender.CurrentRow.Cells(xCol.Index)


                'Validate Mandatory Input for Product Code and description
                If (String.IsNullOrEmpty(xCell.FormattedValue.ToString())) And (e.RowIndex <> sender.NewRowIndex) Then
                    TblprodbudDataGridView.Rows(e.RowIndex).ErrorText = xColName & " is a mandatory field"
                    e.Cancel = True
                Else
                    TblprodbudDataGridView.Rows(e.RowIndex).ErrorText = ""
                End If
            Next

            'Validate to ensure we don't exceed periods
            If Me.bs_tblProdBud.Count > 12 Then
                'If Me.TblprodbudDataGridView.Rows.Count > 11 Then
                TblprodbudDataGridView.Rows(e.RowIndex).ErrorText = "Number of rows exceed the number of allowed periods"
                e.Cancel = True
            Else
                TblprodbudDataGridView.Rows(e.RowIndex).ErrorText = ""
            End If

        Catch ex As Exception
            MsgBox("Could not validate")
        End Try


    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl2.SelectedIndexChanged
        My.Forms.ApplicationStartupForm.ss1.Text = String.Empty
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim frm As New frmRepViewer
        'frm.MdiParent = Me
        frm.Tag = "ProductList"
        frm.Show()
        'FillActiveChildFormToClient()
    End Sub

    Private Sub cbox_FillMonths_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbox_FillMonths.Validating
        If Me.cbox_FillMonths.CheckState = CheckState.Checked Then
            Me.cb_ChangeMonth.SelectedIndex = -1
            Me.cb_ChangeMonth.Text = ""
        End If
    End Sub

    Private Sub cb_ChangeMonth_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cb_ChangeMonth.Validating
        Me.cbox_FillMonths.CheckState = CheckState.Unchecked
    End Sub

    Private Function NextProductNo(ByVal xProductNo As String)
        'Determine the structure of the Product Code
        Dim xStructure As String = String.Empty
        Dim xNumStart As Integer

        If IsNumeric(xProductNo) Then
            xStructure = "Num"
        Else
            Dim b As Boolean
            Dim i As Integer

            Dim xStringLen As Integer = Len(xProductNo) - 1
            For i = 0 To xStringLen
                If b = False Then
                    b = Int32.TryParse(xProductNo.Substring(i, 1), 0)
                    If b = True Then xNumStart = i
                End If
            Next

            If b = True Then
                If xNumStart = 0 Then
                    xStructure = "AlphaNum0"
                Else
                    xStructure = "AlphaNum9"
                End If
            Else
                xStructure = "Alpha"
            End If
        End If

        'Now determine the best case scenario for the next porduct number
        Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        'establishing connection. you need to provide password for sql server
        myConnection.Open()
        'opening the connection

        Dim myCommand = New SqlClient.SqlCommand

        'Dim dr = myCommand.ExecuteReader()



        Select Case xStructure
            Case "Num"
                myCommand = New SqlClient.SqlCommand("Select Max(txtProdCde) as MaxNo from tblProduct WHERE (IsNumeric(txtProdCde) = True)", myConnection)
                Dim dr = myCommand.executeReader()
                If dr.HasRows() = True Then
                    dr.Read()
                    Return dr.Item(0) + 1
                Else
                    Return 0
                End If
            Case "AlphaNum0"
                Dim xTextStart As Integer

                Dim xBuildstringAlpha As String
                Dim xStringLen As Integer = Len(xProductNo) - 1
                Dim b As Boolean

                Dim y As Integer
                For y = 0 To xStringLen
                    b = Int32.TryParse(xProductNo.Substring(y, 1), 0)
                    If b = False Then
                        xTextStart = y
                        Exit For
                    End If

                Next
                Dim xAlpha As String = xProductNo.Substring(xTextStart)
                Dim xMax As Integer

                'Determine next numerical number
                myCommand = New SqlClient.SqlCommand("Select txtProdCde as MaxNo from tblProduct where txtProdCde Like " & "'%" & xAlpha & "'", myConnection)
                Dim myAdaptor As New OleDb.OleDbDataAdapter(myCommand)
                Dim ds As New DataSet
                myAdaptor.Fill(ds, "MyTable")
                If ds.Tables(0).Rows.Count > 0 Then
                    Dim xlen As Integer
                    For Each xRow As DataRow In ds.Tables(0).Rows
                        xlen = Len(xRow.Item(0))
                        xBuildstringAlpha = xRow.Item(0)

                        For y = 0 To xlen
                            b = Int32.TryParse(xBuildstringAlpha.Substring(y, 1), 0)
                            If b = False Then
                                xTextStart = y
                                Exit For
                            End If
                        Next

                        xBuildstringAlpha = xBuildstringAlpha.Substring(0, xTextStart)
                        If CInt(xBuildstringAlpha) > xMax Then
                            xMax = CInt(xBuildstringAlpha)
                        End If
                    Next
                End If

                'Now build return string
                'myCommand = New SqlClient.SqlCommand("Select Max(txtProdCde) as MaxNo from tblProduct having txtProdCde Like " & "'%" & xAlpha & "'", myConnection)
                'Dim dr = myCommand.executeReader()
                'If dr.HasRows() = True Then
                'dr.Read()
                'xBuildstringAlpha = dr.Item(0)
                'xBuildStringNum = CInt(xBuildstringAlpha.Substring(0, xTextStart)) + 1
                Return (xMax + 1).ToString + xAlpha
                'Else
                'Return 0
                'End If



            Case "AlphaNum9"

                Dim xBuildstringAlpha As String = String.Empty
                'Dim y As Integer
                '    For y = 0 To xStringLen
                '    b = Int32.TryParse(xProductNo.Substring(y, 1), 0)
                '        If b = False Then xTextStart = y
                '    Next

                'Determine next numerical number
                Dim xAlpha As String = xProductNo.Substring(0, xNumStart)
                myCommand = New SqlClient.SqlCommand("Select txtProdCde as MaxNo from tblProduct where txtProdCde Like " & "'" & xAlpha & "%'", myConnection)
                Dim myAdaptor As New OleDb.OleDbDataAdapter(myCommand)
                Dim ds As New DataSet
                myAdaptor.Fill(ds, "MyTable")
                If ds.Tables(0).Rows.Count > 0 Then
                    Dim xlen, xMax As Integer
                    For Each xRow As DataRow In ds.Tables(0).Rows
                        xlen = Len(xRow.Item(0))
                        xBuildstringAlpha = xRow.Item(0)
                        xBuildstringAlpha = xBuildstringAlpha.Substring(xNumStart, xlen - xNumStart)
                        If CInt(xBuildstringAlpha) > xMax Then
                            xMax = CInt(xBuildstringAlpha)
                        End If
                    Next

                    'Build string to return
                    Return xAlpha + (xMax + 1).ToString
                Else
                    Return 0
                End If

            Case "Alpha"
            Case Else
                Return 0
        End Select



        myConnection.close()

        Return 0
    End Function

    End Class

