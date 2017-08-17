<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduction
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.JCdt_ETD = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.JCdt_DateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.JCDt_DateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbJC_CusRef2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbJC_Customer2 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbJC_Qty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbJC_Product = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.jcCombo3 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.jcCombo2 = New System.Windows.Forms.ComboBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.jcCombo1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tb_QuoteID = New System.Windows.Forms.TextBox()
        Me.tb_InvoiceID = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TblCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccounting1 = New CCP.dsAccounting()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.jcCB_Customer = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgvLabour = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_PONumber = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tb_Pic = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_CusRef = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.dgvMaterial = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_JCNumber = New System.Windows.Forms.Label()
        Me.LstQuoteHeadersTableAdapter1 = New CCP.dsAccountingTableAdapters.lstQuoteHeadersTableAdapter()
        Me.TblCustomerTableAdapter1 = New CCP.dsAccountingTableAdapters.tblCustomerTableAdapter()
        Me.LstQuoteHeadersTableAdapter2 = New CCP.dsAccountingTableAdapters.lstQuoteHeadersTableAdapter()
        Me.TblQuoteDetailTableAdapter1 = New CCP.dsAccountingTableAdapters.tblQuoteDetailTableAdapter()
        Me.TblProductTableAdapter1 = New CCP.dsAccountingTableAdapters.tblProductTableAdapter()
        Me.FktblProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtProdCdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtProdDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtProdSpec1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtProdSpec2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtProdSpec3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DecQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtUOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblPODetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction1 = New CCP.dsProduction()
        Me.TblPODetailTableAdapter1 = New CCP.dsProductionTableAdapters.tblPODetailTableAdapter()
        Me.TblPOHeaderTableAdapter1 = New CCP.dsProductionTableAdapters.tblPOHeaderTableAdapter()
        Me.TblJCTableAdapter1 = New CCP.dsProductionTableAdapters.tblJCTableAdapter()
        Me.LstMaterialLinkTableAdapter1 = New CCP.dsProductionTableAdapters.lstMaterialLinkTableAdapter()
        Me.TblJCMaterialTableAdapter1 = New CCP.dsProductionTableAdapters.tblJCMaterialTableAdapter()
        Me.LstLabourLinkTableAdapter1 = New CCP.dsProductionTableAdapters.lstLabourLinkTableAdapter()
        Me.LstLabCostperProdandDeptTableAdapter1 = New CCP.dsProductionTableAdapters.lstLabCostperProdandDeptTableAdapter()
        Me.TblJCLabourTableAdapter1 = New CCP.dsProductionTableAdapters.tblJCLabourTableAdapter()
        Me.LstPOHeaderDetailsTableAdapter1 = New CCP.dsProductionTableAdapters.lstPOHeaderDetailsTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccounting1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvLabour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPODetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.JCdt_ETD)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.JCdt_DateTo)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.JCDt_DateFrom)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.tbJC_CusRef2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cbJC_Customer2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tbJC_Qty)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbJC_Product)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.jcCombo3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.jcCombo2)
        Me.GroupBox1.Controls.Add(Me.Label51)
        Me.GroupBox1.Controls.Add(Me.jcCombo1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(865, 97)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select document type and additional information"
        '
        'JCdt_ETD
        '
        Me.JCdt_ETD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.JCdt_ETD.Location = New System.Drawing.Point(501, 73)
        Me.JCdt_ETD.Name = "JCdt_ETD"
        Me.JCdt_ETD.Size = New System.Drawing.Size(132, 20)
        Me.JCdt_ETD.TabIndex = 41
        Me.JCdt_ETD.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(426, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Delivery date"
        Me.Label16.Visible = False
        '
        'JCdt_DateTo
        '
        Me.JCdt_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.JCdt_DateTo.Location = New System.Drawing.Point(257, 73)
        Me.JCdt_DateTo.Name = "JCdt_DateTo"
        Me.JCdt_DateTo.Size = New System.Drawing.Size(132, 20)
        Me.JCdt_DateTo.TabIndex = 39
        Me.JCdt_DateTo.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(231, 79)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "to"
        Me.Label15.Visible = False
        '
        'JCDt_DateFrom
        '
        Me.JCDt_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.JCDt_DateFrom.Location = New System.Drawing.Point(93, 73)
        Me.JCDt_DateFrom.Name = "JCDt_DateFrom"
        Me.JCDt_DateFrom.Size = New System.Drawing.Size(132, 20)
        Me.JCDt_DateFrom.TabIndex = 37
        Me.JCDt_DateFrom.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 13)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Production from"
        Me.Label14.Visible = False
        '
        'tbJC_CusRef2
        '
        Me.tbJC_CusRef2.Location = New System.Drawing.Point(672, 46)
        Me.tbJC_CusRef2.Name = "tbJC_CusRef2"
        Me.tbJC_CusRef2.Size = New System.Drawing.Size(100, 20)
        Me.tbJC_CusRef2.TabIndex = 35
        Me.tbJC_CusRef2.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(595, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Customer Ref"
        Me.Label12.Visible = False
        '
        'cbJC_Customer2
        '
        Me.cbJC_Customer2.DisplayMember = "ComboText"
        Me.cbJC_Customer2.FormattingEnabled = True
        Me.cbJC_Customer2.Location = New System.Drawing.Point(429, 47)
        Me.cbJC_Customer2.Name = "cbJC_Customer2"
        Me.cbJC_Customer2.Size = New System.Drawing.Size(156, 21)
        Me.cbJC_Customer2.TabIndex = 33
        Me.cbJC_Customer2.ValueMember = "dblQuoteNum"
        Me.cbJC_Customer2.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(372, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Customer"
        Me.Label11.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(209, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Quantity"
        Me.Label10.Visible = False
        '
        'tbJC_Qty
        '
        Me.tbJC_Qty.Location = New System.Drawing.Point(261, 46)
        Me.tbJC_Qty.Name = "tbJC_Qty"
        Me.tbJC_Qty.Size = New System.Drawing.Size(100, 20)
        Me.tbJC_Qty.TabIndex = 30
        Me.tbJC_Qty.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Product"
        Me.Label9.Visible = False
        '
        'cbJC_Product
        '
        Me.cbJC_Product.DisplayMember = "ComboText"
        Me.cbJC_Product.FormattingEnabled = True
        Me.cbJC_Product.Location = New System.Drawing.Point(53, 46)
        Me.cbJC_Product.Name = "cbJC_Product"
        Me.cbJC_Product.Size = New System.Drawing.Size(150, 21)
        Me.cbJC_Product.TabIndex = 28
        Me.cbJC_Product.ValueMember = "dblQuoteNum"
        Me.cbJC_Product.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(463, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "..."
        Me.Label1.Visible = False
        '
        'jcCombo3
        '
        Me.jcCombo3.DisplayMember = "ComboText"
        Me.jcCombo3.FormattingEnabled = True
        Me.jcCombo3.Location = New System.Drawing.Point(447, 19)
        Me.jcCombo3.Name = "jcCombo3"
        Me.jcCombo3.Size = New System.Drawing.Size(359, 21)
        Me.jcCombo3.TabIndex = 3
        Me.jcCombo3.ValueMember = "dblQuoteNum"
        Me.jcCombo3.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Select Quote"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Fill from Quote"
        Me.Label2.Visible = False
        '
        'jcCombo2
        '
        Me.jcCombo2.FormattingEnabled = True
        Me.jcCombo2.Items.AddRange(New Object() {"Yes", "No"})
        Me.jcCombo2.Location = New System.Drawing.Point(287, 19)
        Me.jcCombo2.Name = "jcCombo2"
        Me.jcCombo2.Size = New System.Drawing.Size(59, 21)
        Me.jcCombo2.TabIndex = 1
        Me.jcCombo2.Visible = False
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(6, 22)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(56, 13)
        Me.Label51.TabIndex = 8
        Me.Label51.Text = "Document"
        '
        'jcCombo1
        '
        Me.jcCombo1.FormattingEnabled = True
        Me.jcCombo1.Items.AddRange(New Object() {"Order", "Job card"})
        Me.jcCombo1.Location = New System.Drawing.Point(68, 19)
        Me.jcCombo1.Name = "jcCombo1"
        Me.jcCombo1.Size = New System.Drawing.Size(121, 21)
        Me.jcCombo1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tb_QuoteID)
        Me.GroupBox2.Controls.Add(Me.tb_InvoiceID)
        Me.GroupBox2.Controls.Add(Me.TextBox16)
        Me.GroupBox2.Controls.Add(Me.TextBox14)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.TextBox13)
        Me.GroupBox2.Controls.Add(Me.Label41)
        Me.GroupBox2.Controls.Add(Me.TextBox12)
        Me.GroupBox2.Controls.Add(Me.Label42)
        Me.GroupBox2.Controls.Add(Me.Label45)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Label46)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.Label47)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.Label48)
        Me.GroupBox2.Controls.Add(Me.RichTextBox3)
        Me.GroupBox2.Controls.Add(Me.Label49)
        Me.GroupBox2.Controls.Add(Me.Label50)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.jcCB_Customer)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(573, 178)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer details"
        Me.GroupBox2.Visible = False
        '
        'tb_QuoteID
        '
        Me.tb_QuoteID.Location = New System.Drawing.Point(6, 109)
        Me.tb_QuoteID.Name = "tb_QuoteID"
        Me.tb_QuoteID.Size = New System.Drawing.Size(70, 20)
        Me.tb_QuoteID.TabIndex = 34
        Me.tb_QuoteID.TabStop = False
        Me.tb_QuoteID.Visible = False
        '
        'tb_InvoiceID
        '
        Me.tb_InvoiceID.Location = New System.Drawing.Point(6, 91)
        Me.tb_InvoiceID.Name = "tb_InvoiceID"
        Me.tb_InvoiceID.Size = New System.Drawing.Size(70, 20)
        Me.tb_InvoiceID.TabIndex = 0
        Me.tb_InvoiceID.TabStop = False
        Me.tb_InvoiceID.Visible = False
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(395, 18)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(75, 20)
        Me.TextBox16.TabIndex = 33
        Me.TextBox16.TabStop = False
        Me.TextBox16.Visible = False
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomerBindingSource, "txtContactName", True))
        Me.TextBox14.Location = New System.Drawing.Point(83, 155)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(161, 20)
        Me.TextBox14.TabIndex = 17
        '
        'TblCustomerBindingSource
        '
        Me.TblCustomerBindingSource.DataMember = "tblCustomer"
        Me.TblCustomerBindingSource.DataSource = Me.DsAccounting1
        '
        'DsAccounting1
        '
        Me.DsAccounting1.DataSetName = "dsAccounting"
        Me.DsAccounting1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(8, 158)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(73, 13)
        Me.Label40.TabIndex = 16
        Me.Label40.Text = "Contact name"
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomerBindingSource, "txtFax", True))
        Me.TextBox13.Location = New System.Drawing.Point(384, 129)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(75, 20)
        Me.TextBox13.TabIndex = 16
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(354, 132)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(24, 13)
        Me.Label41.TabIndex = 14
        Me.Label41.Text = "Fax"
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomerBindingSource, "txtPhone2", True))
        Me.TextBox12.Location = New System.Drawing.Point(278, 129)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(70, 20)
        Me.TextBox12.TabIndex = 15
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(250, 132)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(22, 13)
        Me.Label42.TabIndex = 12
        Me.Label42.Text = "Cel"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(145, 132)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(22, 13)
        Me.Label45.TabIndex = 11
        Me.Label45.Text = "Tel"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(107, 21)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(244, 161)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(72, 13)
        Me.Label46.TabIndex = 9
        Me.Label46.Text = "Email address"
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomerBindingSource, "txtEmail", True))
        Me.TextBox10.Location = New System.Drawing.Point(322, 158)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(245, 20)
        Me.TextBox10.TabIndex = 18
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(8, 132)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(89, 13)
        Me.Label47.TabIndex = 7
        Me.Label47.Text = "Contact Numbers"
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomerBindingSource, "txtPhone1", True))
        Me.TextBox9.Location = New System.Drawing.Point(174, 129)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(70, 20)
        Me.TextBox9.TabIndex = 14
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(8, 75)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(45, 13)
        Me.Label48.TabIndex = 5
        Me.Label48.Text = "Address"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomerBindingSource, "txtAddPos", True))
        Me.RichTextBox3.Location = New System.Drawing.Point(148, 72)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(241, 51)
        Me.RichTextBox3.TabIndex = 13
        Me.RichTextBox3.Text = ""
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(6, 49)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(82, 13)
        Me.Label49.TabIndex = 3
        Me.Label49.Text = "Customer Name"
        Me.Label49.Visible = False
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(6, 22)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(84, 13)
        Me.Label50.TabIndex = 2
        Me.Label50.Text = "Select Customer"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomerBindingSource, "txtCusDesc", True))
        Me.TextBox8.Location = New System.Drawing.Point(148, 46)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(241, 20)
        Me.TextBox8.TabIndex = 12
        '
        'jcCB_Customer
        '
        Me.jcCB_Customer.DataSource = Me.TblCustomerBindingSource
        Me.jcCB_Customer.DisplayMember = "txtCusDesc"
        Me.jcCB_Customer.Enabled = False
        Me.jcCB_Customer.FormattingEnabled = True
        Me.jcCB_Customer.Location = New System.Drawing.Point(148, 19)
        Me.jcCB_Customer.Name = "jcCB_Customer"
        Me.jcCB_Customer.Size = New System.Drawing.Size(241, 21)
        Me.jcCB_Customer.TabIndex = 11
        Me.jcCB_Customer.ValueMember = "id_tblCustomer"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 291)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(573, 40)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(436, 10)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(126, 23)
        Me.Button5.TabIndex = 55
        Me.Button5.Text = "Add message"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(4, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Create production order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(143, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 23)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "Print/Email production order"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(299, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Create job cards"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgvLabour
        '
        Me.dgvLabour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLabour.Location = New System.Drawing.Point(513, 356)
        Me.dgvLabour.Name = "dgvLabour"
        Me.dgvLabour.Size = New System.Drawing.Size(459, 183)
        Me.dgvLabour.TabIndex = 52
        Me.dgvLabour.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Order number: "
        '
        'lbl_PONumber
        '
        Me.lbl_PONumber.AutoSize = True
        Me.lbl_PONumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PONumber.Location = New System.Drawing.Point(136, 17)
        Me.lbl_PONumber.Name = "lbl_PONumber"
        Me.lbl_PONumber.Size = New System.Drawing.Size(24, 20)
        Me.lbl_PONumber.TabIndex = 8
        Me.lbl_PONumber.Text = "..."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RichTextBox1)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.tb_Pic)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.tb_CusRef)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lbl_PONumber)
        Me.GroupBox3.Location = New System.Drawing.Point(591, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(387, 178)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Production Order details"
        Me.GroupBox3.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(242, 22)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.RichTextBox1.TabIndex = 37
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(106, 146)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(28, 23)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'tb_Pic
        '
        Me.tb_Pic.Location = New System.Drawing.Point(140, 149)
        Me.tb_Pic.Name = "tb_Pic"
        Me.tb_Pic.Size = New System.Drawing.Size(241, 20)
        Me.tb_Pic.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Picture"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(140, 125)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(132, 20)
        Me.DateTimePicker3.TabIndex = 33
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(140, 101)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(132, 20)
        Me.DateTimePicker2.TabIndex = 32
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(140, 75)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(132, 20)
        Me.DateTimePicker1.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Expected delivery "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Production to"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Production from"
        '
        'tb_CusRef
        '
        Me.tb_CusRef.Location = New System.Drawing.Point(140, 50)
        Me.tb_CusRef.Name = "tb_CusRef"
        Me.tb_CusRef.Size = New System.Drawing.Size(132, 20)
        Me.tb_CusRef.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Customer order number: "
        '
        'dgv1
        '
        Me.dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.AutoGenerateColumns = False
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FktblProductDataGridViewTextBoxColumn, Me.TxtProdCdeDataGridViewTextBoxColumn, Me.TxtProdDescDataGridViewTextBoxColumn, Me.TxtProdSpec1DataGridViewTextBoxColumn, Me.TxtProdSpec2DataGridViewTextBoxColumn, Me.TxtProdSpec3DataGridViewTextBoxColumn, Me.DecQtyDataGridViewTextBoxColumn, Me.TxtUOMDataGridViewTextBoxColumn})
        Me.dgv1.DataSource = Me.TblPODetailBindingSource
        Me.dgv1.Location = New System.Drawing.Point(12, 335)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(966, 290)
        Me.dgv1.TabIndex = 50
        Me.dgv1.Visible = False
        '
        'dgvMaterial
        '
        Me.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterial.Location = New System.Drawing.Point(2, 356)
        Me.dgvMaterial.Name = "dgvMaterial"
        Me.dgvMaterial.Size = New System.Drawing.Size(505, 183)
        Me.dgvMaterial.TabIndex = 51
        Me.dgvMaterial.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbl_JCNumber
        '
        Me.lbl_JCNumber.BackColor = System.Drawing.Color.Black
        Me.lbl_JCNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_JCNumber.ForeColor = System.Drawing.Color.White
        Me.lbl_JCNumber.Location = New System.Drawing.Point(625, 301)
        Me.lbl_JCNumber.Name = "lbl_JCNumber"
        Me.lbl_JCNumber.Size = New System.Drawing.Size(252, 28)
        Me.lbl_JCNumber.TabIndex = 53
        Me.lbl_JCNumber.Text = "Job card number - "
        Me.lbl_JCNumber.Visible = False
        '
        'LstQuoteHeadersTableAdapter1
        '
        Me.LstQuoteHeadersTableAdapter1.ClearBeforeFill = True
        '
        'TblCustomerTableAdapter1
        '
        Me.TblCustomerTableAdapter1.ClearBeforeFill = True
        '
        'LstQuoteHeadersTableAdapter2
        '
        Me.LstQuoteHeadersTableAdapter2.ClearBeforeFill = True
        '
        'TblQuoteDetailTableAdapter1
        '
        Me.TblQuoteDetailTableAdapter1.ClearBeforeFill = True
        '
        'TblProductTableAdapter1
        '
        Me.TblProductTableAdapter1.ClearBeforeFill = True
        '
        'FktblProductDataGridViewTextBoxColumn
        '
        Me.FktblProductDataGridViewTextBoxColumn.DataPropertyName = "fk_tblProduct"
        Me.FktblProductDataGridViewTextBoxColumn.HeaderText = "fk_tblProduct"
        Me.FktblProductDataGridViewTextBoxColumn.Name = "FktblProductDataGridViewTextBoxColumn"
        Me.FktblProductDataGridViewTextBoxColumn.Visible = False
        '
        'TxtProdCdeDataGridViewTextBoxColumn
        '
        Me.TxtProdCdeDataGridViewTextBoxColumn.DataPropertyName = "txtProdCde"
        Me.TxtProdCdeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.TxtProdCdeDataGridViewTextBoxColumn.Name = "TxtProdCdeDataGridViewTextBoxColumn"
        '
        'TxtProdDescDataGridViewTextBoxColumn
        '
        Me.TxtProdDescDataGridViewTextBoxColumn.DataPropertyName = "txtProdDesc"
        Me.TxtProdDescDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.TxtProdDescDataGridViewTextBoxColumn.Name = "TxtProdDescDataGridViewTextBoxColumn"
        '
        'TxtProdSpec1DataGridViewTextBoxColumn
        '
        Me.TxtProdSpec1DataGridViewTextBoxColumn.DataPropertyName = "txtProdSpec1"
        Me.TxtProdSpec1DataGridViewTextBoxColumn.HeaderText = "Spec 1"
        Me.TxtProdSpec1DataGridViewTextBoxColumn.Name = "TxtProdSpec1DataGridViewTextBoxColumn"
        '
        'TxtProdSpec2DataGridViewTextBoxColumn
        '
        Me.TxtProdSpec2DataGridViewTextBoxColumn.DataPropertyName = "txtProdSpec2"
        Me.TxtProdSpec2DataGridViewTextBoxColumn.HeaderText = "Spec 2"
        Me.TxtProdSpec2DataGridViewTextBoxColumn.Name = "TxtProdSpec2DataGridViewTextBoxColumn"
        '
        'TxtProdSpec3DataGridViewTextBoxColumn
        '
        Me.TxtProdSpec3DataGridViewTextBoxColumn.DataPropertyName = "txtProdSpec3"
        Me.TxtProdSpec3DataGridViewTextBoxColumn.HeaderText = "Spec 3"
        Me.TxtProdSpec3DataGridViewTextBoxColumn.Name = "TxtProdSpec3DataGridViewTextBoxColumn"
        '
        'DecQtyDataGridViewTextBoxColumn
        '
        Me.DecQtyDataGridViewTextBoxColumn.DataPropertyName = "decQty"
        Me.DecQtyDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.DecQtyDataGridViewTextBoxColumn.Name = "DecQtyDataGridViewTextBoxColumn"
        '
        'TxtUOMDataGridViewTextBoxColumn
        '
        Me.TxtUOMDataGridViewTextBoxColumn.DataPropertyName = "txtUOM"
        Me.TxtUOMDataGridViewTextBoxColumn.HeaderText = "Unit of Measurement"
        Me.TxtUOMDataGridViewTextBoxColumn.Name = "TxtUOMDataGridViewTextBoxColumn"
        '
        'TblPODetailBindingSource
        '
        Me.TblPODetailBindingSource.DataMember = "tblPODetail"
        Me.TblPODetailBindingSource.DataSource = Me.DsProduction1
        '
        'DsProduction1
        '
        Me.DsProduction1.DataSetName = "dsProduction"
        Me.DsProduction1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPODetailTableAdapter1
        '
        Me.TblPODetailTableAdapter1.ClearBeforeFill = True
        '
        'TblPOHeaderTableAdapter1
        '
        Me.TblPOHeaderTableAdapter1.ClearBeforeFill = True
        '
        'TblJCTableAdapter1
        '
        Me.TblJCTableAdapter1.ClearBeforeFill = True
        '
        'LstMaterialLinkTableAdapter1
        '
        Me.LstMaterialLinkTableAdapter1.ClearBeforeFill = True
        '
        'TblJCMaterialTableAdapter1
        '
        Me.TblJCMaterialTableAdapter1.ClearBeforeFill = True
        '
        'LstLabourLinkTableAdapter1
        '
        Me.LstLabourLinkTableAdapter1.ClearBeforeFill = True
        '
        'LstLabCostperProdandDeptTableAdapter1
        '
        Me.LstLabCostperProdandDeptTableAdapter1.ClearBeforeFill = True
        '
        'TblJCLabourTableAdapter1
        '
        Me.TblJCLabourTableAdapter1.ClearBeforeFill = True
        '
        'LstPOHeaderDetailsTableAdapter1
        '
        Me.LstPOHeaderDetailsTableAdapter1.ClearBeforeFill = True
        '
        'frmProduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 668)
        Me.Controls.Add(Me.lbl_JCNumber)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.dgvLabour)
        Me.Controls.Add(Me.dgvMaterial)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmProduction"
        Me.Text = "frmProduction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccounting1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvLabour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPODetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents jcCombo3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents jcCombo2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents jcCombo1 As System.Windows.Forms.ComboBox
    Friend WithEvents LstQuoteHeadersTableAdapter1 As CCP.dsAccountingTableAdapters.lstQuoteHeadersTableAdapter
    Friend WithEvents DsAccounting1 As CCP.dsAccounting
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents jcCB_Customer As System.Windows.Forms.ComboBox
    Friend WithEvents tb_InvoiceID As System.Windows.Forms.TextBox
    Friend WithEvents TblCustomerTableAdapter1 As CCP.dsAccountingTableAdapters.tblCustomerTableAdapter
    Friend WithEvents DsProduction1 As CCP.dsProduction
    Friend WithEvents TblPODetailTableAdapter1 As CCP.dsProductionTableAdapters.tblPODetailTableAdapter
    Friend WithEvents TblPOHeaderTableAdapter1 As CCP.dsProductionTableAdapters.tblPOHeaderTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_PONumber As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_QuoteID As System.Windows.Forms.TextBox
    Friend WithEvents tb_CusRef As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LstQuoteHeadersTableAdapter2 As CCP.dsAccountingTableAdapters.lstQuoteHeadersTableAdapter
    Friend WithEvents TblCustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents TblPODetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FktblProductDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtProdCdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtProdDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtProdSpec1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtProdSpec2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtProdSpec3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DecQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtUOMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdtblPODetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FktblPOHeaderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblQuoteDetailTableAdapter1 As CCP.dsAccountingTableAdapters.tblQuoteDetailTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbJC_CusRef2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbJC_Customer2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbJC_Qty As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbJC_Product As System.Windows.Forms.ComboBox
    Friend WithEvents TblJCTableAdapter1 As CCP.dsProductionTableAdapters.tblJCTableAdapter
    Friend WithEvents TblProductTableAdapter1 As CCP.dsAccountingTableAdapters.tblProductTableAdapter
    Friend WithEvents dgvMaterial As System.Windows.Forms.DataGridView
    Friend WithEvents LstMaterialLinkTableAdapter1 As CCP.dsProductionTableAdapters.lstMaterialLinkTableAdapter
    Friend WithEvents dgvLabour As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents tb_Pic As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_JCNumber As System.Windows.Forms.Label
    Friend WithEvents JCdt_ETD As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents JCdt_DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents JCDt_DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TblJCMaterialTableAdapter1 As CCP.dsProductionTableAdapters.tblJCMaterialTableAdapter
    Friend WithEvents LstLabourLinkTableAdapter1 As CCP.dsProductionTableAdapters.lstLabourLinkTableAdapter
    Friend WithEvents LstLabCostperProdandDeptTableAdapter1 As CCP.dsProductionTableAdapters.lstLabCostperProdandDeptTableAdapter
    Friend WithEvents TblJCLabourTableAdapter1 As CCP.dsProductionTableAdapters.tblJCLabourTableAdapter
    Friend WithEvents LstPOHeaderDetailsTableAdapter1 As CCP.dsProductionTableAdapters.lstPOHeaderDetailsTableAdapter
End Class
