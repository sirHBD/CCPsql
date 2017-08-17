Public Class frmRePrint

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim xDocType As String = Me.ComboBox1.SelectedItem

        Select Case xDocType
            Case "Production order"

                Me.TblPOHeaderTableAdapter1.FillByComboInfo(Me.DsProduction1.tblPOHeader)
                Me.ComboBox2.DataSource = Me.DsProduction1.tblPOHeader
                Me.ComboBox2.DisplayMember = "ComboInfo"
                Me.ComboBox2.ValueMember = "id_tblPOHeader"

            Case "Job card"
                Me.TblJCTableAdapter1.Fill(Me.DsProduction1.tblJC)
                Me.ComboBox2.DataSource = Me.DsProduction1.tblJC
                Me.ComboBox2.DisplayMember = "dblJCNo"
                Me.ComboBox2.ValueMember = "id_tblJC"

            Case "Invoice"
                Me.ComboBox2.DataSource = Nothing
                Me.LstInvoiceHeadersTableAdapter1.Fill(Me.DsAccounting1.lstInvoiceHeaders)
                Me.ComboBox2.DataSource = New BindingSource(Me.DsAccounting1.lstInvoiceHeaders, Nothing)
                Me.ComboBox2.DisplayMember = "comboText"
                Me.ComboBox2.ValueMember = "dblInvoiceNum"
            Case "Quote", "Receipts"
                Me.ComboBox2.DataSource = Nothing
                Me.LstQuoteHeadersTableAdapter1.Fill(Me.DsAccounting1.lstQuoteHeaders)
                Me.ComboBox2.DataSource = New BindingSource(Me.DsAccounting1.lstQuoteHeaders, Nothing)
                Me.ComboBox2.DisplayMember = "comboText"
                Me.ComboBox2.ValueMember = "dblQuoteNum"

        End Select



    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim frm As New frmRepViewer
        xId2Print = Me.ComboBox2.SelectedValue
        Dim xType As String = Me.ComboBox1.Text.ToString()
        Select Case xType
            Case "Job card"
                frm.Tag = "JC"
            Case "Production order"
                frm.Tag = "Production order"
            Case "Quote"
                frm.Tag = "Quote"
            Case "Invoice"
                frm.Tag = "Tax Invoice"
            Case "Receipts"
                frm.Tag = "Receipt"
            Case Else
                frm.Tag = String.Empty
        End Select

        Me.Close()
        frm.Show()

    End Sub

    Private Sub ComboBox2_DropDown(sender As Object, e As System.EventArgs) Handles ComboBox2.DropDown
        ' MiscCode.AdjustWidthComboBox_DropDown(sender, e)
    End Sub
End Class