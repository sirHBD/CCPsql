<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJCMonitor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LstJCMonitorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction = New CCP.dsProduction()
        Me.LstJCMonitorTableAdapter1 = New CCP.dsProductionTableAdapters.lstJCMonitorTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DblQuoteNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCompanyNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCusDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtQuoteDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DblPONumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtPODateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateFromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateToDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateETDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtReceiptTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DblJCnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JCDateFromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JCDateToDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JCDateETDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DblInvoiceNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtInvoiceDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceAmtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SettlementDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SettlementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SettlementAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LstJCMonitorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"All", "Current", "Quote only"})
        Me.ComboBox2.Location = New System.Drawing.Point(195, 6)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Show"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Asc", "Desc"})
        Me.ComboBox1.Location = New System.Drawing.Point(54, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DblQuoteNumDataGridViewTextBoxColumn, Me.TxtCompanyNoDataGridViewTextBoxColumn, Me.TxtCusDescDataGridViewTextBoxColumn, Me.TxtQuoteDateDataGridViewTextBoxColumn, Me.DblPONumDataGridViewTextBoxColumn, Me.TxtPODateDataGridViewTextBoxColumn, Me.DateFromDataGridViewTextBoxColumn, Me.DateToDataGridViewTextBoxColumn, Me.DateETDDataGridViewTextBoxColumn, Me.ReceiptDateDataGridViewTextBoxColumn, Me.TxtReceiptTypeDataGridViewTextBoxColumn, Me.ReceiptAmountDataGridViewTextBoxColumn, Me.DblJCnoDataGridViewTextBoxColumn, Me.DateCreatedDataGridViewTextBoxColumn, Me.JCDateFromDataGridViewTextBoxColumn, Me.JCDateToDataGridViewTextBoxColumn, Me.JCDateETDDataGridViewTextBoxColumn, Me.DblInvoiceNumDataGridViewTextBoxColumn, Me.TxtInvoiceDateDataGridViewTextBoxColumn, Me.InvoiceAmtDataGridViewTextBoxColumn, Me.SettlementDateDataGridViewTextBoxColumn, Me.SettlementDataGridViewTextBoxColumn, Me.SettlementAmountDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LstJCMonitorBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(10, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(866, 396)
        Me.DataGridView1.TabIndex = 0
        '
        'LstJCMonitorBindingSource
        '
        Me.LstJCMonitorBindingSource.DataMember = "lstJCMonitor"
        Me.LstJCMonitorBindingSource.DataSource = Me.DsProduction
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LstJCMonitorTableAdapter1
        '
        Me.LstJCMonitorTableAdapter1.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sort"
        '
        'DblQuoteNumDataGridViewTextBoxColumn
        '
        Me.DblQuoteNumDataGridViewTextBoxColumn.DataPropertyName = "dblQuoteNum"
        Me.DblQuoteNumDataGridViewTextBoxColumn.HeaderText = "Quote No"
        Me.DblQuoteNumDataGridViewTextBoxColumn.Name = "DblQuoteNumDataGridViewTextBoxColumn"
        Me.DblQuoteNumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtCompanyNoDataGridViewTextBoxColumn
        '
        Me.TxtCompanyNoDataGridViewTextBoxColumn.DataPropertyName = "txtCompanyNo"
        Me.TxtCompanyNoDataGridViewTextBoxColumn.HeaderText = "txtCompanyNo"
        Me.TxtCompanyNoDataGridViewTextBoxColumn.Name = "TxtCompanyNoDataGridViewTextBoxColumn"
        Me.TxtCompanyNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TxtCompanyNoDataGridViewTextBoxColumn.Visible = False
        '
        'TxtCusDescDataGridViewTextBoxColumn
        '
        Me.TxtCusDescDataGridViewTextBoxColumn.DataPropertyName = "txtCusDesc"
        Me.TxtCusDescDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.TxtCusDescDataGridViewTextBoxColumn.Name = "TxtCusDescDataGridViewTextBoxColumn"
        Me.TxtCusDescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtQuoteDateDataGridViewTextBoxColumn
        '
        Me.TxtQuoteDateDataGridViewTextBoxColumn.DataPropertyName = "txtQuoteDate"
        Me.TxtQuoteDateDataGridViewTextBoxColumn.HeaderText = "Quote Date"
        Me.TxtQuoteDateDataGridViewTextBoxColumn.Name = "TxtQuoteDateDataGridViewTextBoxColumn"
        Me.TxtQuoteDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DblPONumDataGridViewTextBoxColumn
        '
        Me.DblPONumDataGridViewTextBoxColumn.DataPropertyName = "dblPONum"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DblPONumDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DblPONumDataGridViewTextBoxColumn.HeaderText = "Order No"
        Me.DblPONumDataGridViewTextBoxColumn.Name = "DblPONumDataGridViewTextBoxColumn"
        Me.DblPONumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtPODateDataGridViewTextBoxColumn
        '
        Me.TxtPODateDataGridViewTextBoxColumn.DataPropertyName = "txtPODate"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtPODateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TxtPODateDataGridViewTextBoxColumn.HeaderText = "Order Date"
        Me.TxtPODateDataGridViewTextBoxColumn.Name = "TxtPODateDataGridViewTextBoxColumn"
        Me.TxtPODateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateFromDataGridViewTextBoxColumn
        '
        Me.DateFromDataGridViewTextBoxColumn.DataPropertyName = "DateFrom"
        Me.DateFromDataGridViewTextBoxColumn.HeaderText = "DateFrom"
        Me.DateFromDataGridViewTextBoxColumn.Name = "DateFromDataGridViewTextBoxColumn"
        Me.DateFromDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateFromDataGridViewTextBoxColumn.Visible = False
        '
        'DateToDataGridViewTextBoxColumn
        '
        Me.DateToDataGridViewTextBoxColumn.DataPropertyName = "DateTo"
        Me.DateToDataGridViewTextBoxColumn.HeaderText = "DateTo"
        Me.DateToDataGridViewTextBoxColumn.Name = "DateToDataGridViewTextBoxColumn"
        Me.DateToDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateToDataGridViewTextBoxColumn.Visible = False
        '
        'DateETDDataGridViewTextBoxColumn
        '
        Me.DateETDDataGridViewTextBoxColumn.DataPropertyName = "DateETD"
        Me.DateETDDataGridViewTextBoxColumn.HeaderText = "DateETD"
        Me.DateETDDataGridViewTextBoxColumn.Name = "DateETDDataGridViewTextBoxColumn"
        Me.DateETDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateETDDataGridViewTextBoxColumn.Visible = False
        '
        'ReceiptDateDataGridViewTextBoxColumn
        '
        Me.ReceiptDateDataGridViewTextBoxColumn.DataPropertyName = "ReceiptDate"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
        Me.ReceiptDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ReceiptDateDataGridViewTextBoxColumn.HeaderText = "Receipt Date"
        Me.ReceiptDateDataGridViewTextBoxColumn.Name = "ReceiptDateDataGridViewTextBoxColumn"
        Me.ReceiptDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtReceiptTypeDataGridViewTextBoxColumn
        '
        Me.TxtReceiptTypeDataGridViewTextBoxColumn.DataPropertyName = "txtReceiptType"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        Me.TxtReceiptTypeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.TxtReceiptTypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TxtReceiptTypeDataGridViewTextBoxColumn.Name = "TxtReceiptTypeDataGridViewTextBoxColumn"
        Me.TxtReceiptTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReceiptAmountDataGridViewTextBoxColumn
        '
        Me.ReceiptAmountDataGridViewTextBoxColumn.DataPropertyName = "ReceiptAmount"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ReceiptAmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.ReceiptAmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.ReceiptAmountDataGridViewTextBoxColumn.Name = "ReceiptAmountDataGridViewTextBoxColumn"
        Me.ReceiptAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DblJCnoDataGridViewTextBoxColumn
        '
        Me.DblJCnoDataGridViewTextBoxColumn.DataPropertyName = "dblJCno"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DblJCnoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.DblJCnoDataGridViewTextBoxColumn.HeaderText = "Job Card"
        Me.DblJCnoDataGridViewTextBoxColumn.Name = "DblJCnoDataGridViewTextBoxColumn"
        Me.DblJCnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateCreatedDataGridViewTextBoxColumn
        '
        Me.DateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateCreatedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.DateCreatedDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateCreatedDataGridViewTextBoxColumn.Name = "DateCreatedDataGridViewTextBoxColumn"
        Me.DateCreatedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JCDateFromDataGridViewTextBoxColumn
        '
        Me.JCDateFromDataGridViewTextBoxColumn.DataPropertyName = "JC_DateFrom"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.JCDateFromDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.JCDateFromDataGridViewTextBoxColumn.HeaderText = "DateFrom"
        Me.JCDateFromDataGridViewTextBoxColumn.Name = "JCDateFromDataGridViewTextBoxColumn"
        Me.JCDateFromDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JCDateToDataGridViewTextBoxColumn
        '
        Me.JCDateToDataGridViewTextBoxColumn.DataPropertyName = "JC_DateTo"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.JCDateToDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.JCDateToDataGridViewTextBoxColumn.HeaderText = "DateTo"
        Me.JCDateToDataGridViewTextBoxColumn.Name = "JCDateToDataGridViewTextBoxColumn"
        Me.JCDateToDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JCDateETDDataGridViewTextBoxColumn
        '
        Me.JCDateETDDataGridViewTextBoxColumn.DataPropertyName = "JC_DateETD"
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.JCDateETDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.JCDateETDDataGridViewTextBoxColumn.HeaderText = "ETD"
        Me.JCDateETDDataGridViewTextBoxColumn.Name = "JCDateETDDataGridViewTextBoxColumn"
        Me.JCDateETDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DblInvoiceNumDataGridViewTextBoxColumn
        '
        Me.DblInvoiceNumDataGridViewTextBoxColumn.DataPropertyName = "dblInvoiceNum"
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DblInvoiceNumDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.DblInvoiceNumDataGridViewTextBoxColumn.HeaderText = "Invoice No"
        Me.DblInvoiceNumDataGridViewTextBoxColumn.Name = "DblInvoiceNumDataGridViewTextBoxColumn"
        Me.DblInvoiceNumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtInvoiceDateDataGridViewTextBoxColumn
        '
        Me.TxtInvoiceDateDataGridViewTextBoxColumn.DataPropertyName = "txtInvoiceDate"
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtInvoiceDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.TxtInvoiceDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.TxtInvoiceDateDataGridViewTextBoxColumn.Name = "TxtInvoiceDateDataGridViewTextBoxColumn"
        Me.TxtInvoiceDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvoiceAmtDataGridViewTextBoxColumn
        '
        Me.InvoiceAmtDataGridViewTextBoxColumn.DataPropertyName = "InvoiceAmt"
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.InvoiceAmtDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.InvoiceAmtDataGridViewTextBoxColumn.HeaderText = "Invoice Amt"
        Me.InvoiceAmtDataGridViewTextBoxColumn.Name = "InvoiceAmtDataGridViewTextBoxColumn"
        Me.InvoiceAmtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SettlementDateDataGridViewTextBoxColumn
        '
        Me.SettlementDateDataGridViewTextBoxColumn.DataPropertyName = "SettlementDate"
        Me.SettlementDateDataGridViewTextBoxColumn.HeaderText = "Sett Date"
        Me.SettlementDateDataGridViewTextBoxColumn.Name = "SettlementDateDataGridViewTextBoxColumn"
        Me.SettlementDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SettlementDataGridViewTextBoxColumn
        '
        Me.SettlementDataGridViewTextBoxColumn.DataPropertyName = "Settlement"
        Me.SettlementDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.SettlementDataGridViewTextBoxColumn.Name = "SettlementDataGridViewTextBoxColumn"
        Me.SettlementDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SettlementAmountDataGridViewTextBoxColumn
        '
        Me.SettlementAmountDataGridViewTextBoxColumn.DataPropertyName = "SettlementAmount"
        DataGridViewCellStyle14.Format = "C2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.SettlementAmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.SettlementAmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.SettlementAmountDataGridViewTextBoxColumn.Name = "SettlementAmountDataGridViewTextBoxColumn"
        Me.SettlementAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmJCMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frmJCMonitor"
        Me.Text = "frmJCMonitor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LstJCMonitorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LstJCMonitorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsProduction As CCP.dsProduction
    Friend WithEvents LstJCMonitorTableAdapter1 As CCP.dsProductionTableAdapters.lstJCMonitorTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DblQuoteNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtCompanyNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtCusDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtQuoteDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DblPONumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtPODateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateFromDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateToDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateETDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiptDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtReceiptTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiptAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DblJCnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateCreatedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JCDateFromDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JCDateToDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JCDateETDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DblInvoiceNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtInvoiceDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceAmtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SettlementDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SettlementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SettlementAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
