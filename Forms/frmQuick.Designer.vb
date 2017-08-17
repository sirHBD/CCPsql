<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuick
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuick))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_QuickQuote = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dgvCapacity = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbDesGrossPer = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TblCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProdDB1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProdDB1 = New CCP.dsProdDB()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Newtb_OHPerUnit = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tb_NetperORder = New System.Windows.Forms.TextBox()
        Me.tb_NetperUnit = New System.Windows.Forms.TextBox()
        Me.tb_OHPerOrder = New System.Windows.Forms.TextBox()
        Me.tb_GrossPerOrder = New System.Windows.Forms.TextBox()
        Me.tb_GrossPerUnit = New System.Windows.Forms.TextBox()
        Me.tb_MatPerOrder = New System.Windows.Forms.TextBox()
        Me.tb_MatPerUnit = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_LabperUnit = New System.Windows.Forms.TextBox()
        Me.tb_LabperORder = New System.Windows.Forms.TextBox()
        Me.tb_SP_PerUnit = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tb_SPPerOrder = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPage_Quoting = New System.Windows.Forms.TabPage()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.FktblProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtProdCdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtProdDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtProdSpec1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtProdSpec2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtProdSpec3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtUOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv2_Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv2_SP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv2_Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DecOriginalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv2_VatPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv2_VatAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv2_TotAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblQuoteDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccounting = New CCP.dsAccounting()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.tb_ProfPer = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.tb_OrderQty_Quote = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.tb_InvoiceID = New System.Windows.Forms.TextBox()
        Me.tb_InvoiceNo = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.tb_QuoteNo = New System.Windows.Forms.TextBox()
        Me.tb_QuoteID = New System.Windows.Forms.TextBox()
        Me.tb_ProdID = New System.Windows.Forms.TextBox()
        Me.tb_NPSellPrice = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.tb_GrossProfitPer = New System.Windows.Forms.TextBox()
        Me.tb_NP = New System.Windows.Forms.TextBox()
        Me.tb_OH = New System.Windows.Forms.TextBox()
        Me.tb_GP = New System.Windows.Forms.TextBox()
        Me.tb_MatCost = New System.Windows.Forms.TextBox()
        Me.tb_LabCost = New System.Windows.Forms.TextBox()
        Me.tb_SellingPrice = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.cb_Quote_Product = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.cb_Quote_Customer = New System.Windows.Forms.ComboBox()
        Me.TblCustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage_Lab = New System.Windows.Forms.TabPage()
        Me.dgvLabour = New System.Windows.Forms.DataGridView()
        Me.TabPage_Mat = New System.Windows.Forms.TabPage()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dgvMaterial = New System.Windows.Forms.DataGridView()
        Me.TblProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_CreateTemp = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_EditProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_EditBudget = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_EditLabour = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_EditMaterial = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TblProductTableAdapter1 = New CCP.dsProdDBTableAdapters.tblProductTableAdapter()
        Me.LstLabourLinkTableAdapter1 = New CCP.dsProdDBTableAdapters.lstLabourLinkTableAdapter()
        Me.LstMaterialLinkTableAdapter1 = New CCP.dsProdDBTableAdapters.lstMaterialLinkTableAdapter()
        Me.TblProdLinkTableAdapter1 = New CCP.dsProdDBTableAdapters.tblProdLinkTableAdapter()
        Me.bs_ProdLink = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMatLinkTableAdapter1 = New CCP.dsProdDBTableAdapters.tblMatLinkTableAdapter()
        Me.bs_MatLink = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCustomerTableAdapter1 = New CCP.dsProdDBTableAdapters.tblCustomerTableAdapter()
        Me.TblQuoteHeaderTableAdapter1 = New CCP.dsAccountingTableAdapters.tblQuoteHeaderTableAdapter()
        Me.TblQuoteDetailTableAdapter1 = New CCP.dsAccountingTableAdapters.tblQuoteDetailTableAdapter()
        Me.DsAccountingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LstLabCostperProductTableAdapter1 = New CCP.dsAccountingTableAdapters.lstLabCostperProductTableAdapter()
        Me.LstMatCostperProductTableAdapter1 = New CCP.dsAccountingTableAdapters.lstMatCostperProductTableAdapter()
        Me.TblCoInfoTableAdapter1 = New CCP.dsAccountingTableAdapters.tblCoInfoTableAdapter()
        Me.TblProductBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LstComponentLinkTableAdapter1 = New CCP.dsProdDBTableAdapters.lstComponentLinkTableAdapter()
        Me.LstComponentLabourTableAdapter1 = New CCP.dsProdDBTableAdapters.lstComponentLabourTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_QuickQuote.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProdDB1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProdDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage_Quoting.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQuoteDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccounting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TblCustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Lab.SuspendLayout()
        CType(Me.dgvLabour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Mat.SuspendLayout()
        CType(Me.dgvMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.bs_ProdLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_MatLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccountingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage_QuickQuote)
        Me.TabControl1.Controls.Add(Me.TabPage_Quoting)
        Me.TabControl1.Controls.Add(Me.TabPage_Lab)
        Me.TabControl1.Controls.Add(Me.TabPage_Mat)
        Me.TabControl1.Location = New System.Drawing.Point(3, 31)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1306, 747)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_QuickQuote
        '
        Me.TabPage_QuickQuote.Controls.Add(Me.Chart1)
        Me.TabPage_QuickQuote.Controls.Add(Me.Label21)
        Me.TabPage_QuickQuote.Controls.Add(Me.dgvCapacity)
        Me.TabPage_QuickQuote.Controls.Add(Me.GroupBox3)
        Me.TabPage_QuickQuote.Controls.Add(Me.SplitContainer1)
        Me.TabPage_QuickQuote.Controls.Add(Me.GroupBox2)
        Me.TabPage_QuickQuote.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_QuickQuote.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage_QuickQuote.Name = "TabPage_QuickQuote"
        Me.TabPage_QuickQuote.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage_QuickQuote.Size = New System.Drawing.Size(1298, 721)
        Me.TabPage_QuickQuote.TabIndex = 1
        Me.TabPage_QuickQuote.Text = "Quick Quote"
        Me.TabPage_QuickQuote.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend1.Name = "Legend"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(977, 136)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(272, 240)
        Me.Chart1.TabIndex = 9
        Me.Chart1.Text = "Chart1"
        Me.Chart1.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(589, 115)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(245, 13)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Production capacity for XXX in hours for the month"
        Me.Label21.Visible = False
        '
        'dgvCapacity
        '
        Me.dgvCapacity.AllowUserToAddRows = False
        Me.dgvCapacity.AllowUserToDeleteRows = False
        Me.dgvCapacity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCapacity.Location = New System.Drawing.Point(592, 136)
        Me.dgvCapacity.Name = "dgvCapacity"
        Me.dgvCapacity.ReadOnly = True
        Me.dgvCapacity.Size = New System.Drawing.Size(335, 240)
        Me.dgvCapacity.TabIndex = 7
        Me.dgvCapacity.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbDesGrossPer)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.ComboBox3)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1231, 56)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Order specification"
        '
        'tbDesGrossPer
        '
        Me.tbDesGrossPer.Location = New System.Drawing.Point(856, 31)
        Me.tbDesGrossPer.Margin = New System.Windows.Forms.Padding(2)
        Me.tbDesGrossPer.Name = "tbDesGrossPer"
        Me.tbDesGrossPer.Size = New System.Drawing.Size(62, 20)
        Me.tbDesGrossPer.TabIndex = 11
        Me.tbDesGrossPer.Text = "50"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(853, 16)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 13)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Desired Gross Profit"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1038, 29)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 22)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.TblCustomerBindingSource
        Me.ComboBox3.DisplayMember = "txtCusDesc"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(440, 30)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox3.TabIndex = 4
        Me.ComboBox3.ValueMember = "id_tblCustomer"
        '
        'TblCustomerBindingSource
        '
        Me.TblCustomerBindingSource.DataMember = "tblCustomer"
        Me.TblCustomerBindingSource.DataSource = Me.DsProdDB1BindingSource
        '
        'DsProdDB1BindingSource
        '
        Me.DsProdDB1BindingSource.DataSource = Me.DsProdDB1
        Me.DsProdDB1BindingSource.Position = 0
        '
        'DsProdDB1
        '
        Me.DsProdDB1.DataSetName = "dsProdDB"
        Me.DsProdDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(437, 16)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 13)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Order Date"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(732, 30)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(42, 20)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.Text = "1"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(24, 31)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(151, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(729, 16)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Friday Production Hours"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(603, 30)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(42, 20)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Product Code"
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "idtblProduct"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(187, 30)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "idtblProduct"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(600, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Normal Production Hours"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(346, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Order Volume"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(349, 31)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(76, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(18, 577)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(100, 100)
        Me.SplitContainer1.SplitterDistance = 29
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 0
        Me.SplitContainer1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Section"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(152, 34)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(256, 115)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        Me.GroupBox1.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 87)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Off-Line Standard Minutes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 66)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Units/Hour possible at Constraint"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(182, 84)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(62, 20)
        Me.TextBox7.TabIndex = 8
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(182, 63)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(62, 20)
        Me.TextBox6.TabIndex = 7
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(182, 41)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(62, 20)
        Me.TextBox5.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 43)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Units per Hour Req"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(182, 17)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(62, 20)
        Me.TextBox4.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Order Hours Available"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Newtb_OHPerUnit)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.tb_NetperORder)
        Me.GroupBox2.Controls.Add(Me.tb_NetperUnit)
        Me.GroupBox2.Controls.Add(Me.tb_OHPerOrder)
        Me.GroupBox2.Controls.Add(Me.tb_GrossPerOrder)
        Me.GroupBox2.Controls.Add(Me.tb_GrossPerUnit)
        Me.GroupBox2.Controls.Add(Me.tb_MatPerOrder)
        Me.GroupBox2.Controls.Add(Me.tb_MatPerUnit)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.tb_LabperUnit)
        Me.GroupBox2.Controls.Add(Me.tb_LabperORder)
        Me.GroupBox2.Controls.Add(Me.tb_SP_PerUnit)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.tb_SPPerOrder)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 136)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(524, 240)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Calculation Result"
        Me.GroupBox2.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(149, 214)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(220, 22)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Create Quote with these figures"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Newtb_OHPerUnit
        '
        Me.Newtb_OHPerUnit.Location = New System.Drawing.Point(276, 146)
        Me.Newtb_OHPerUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.Newtb_OHPerUnit.Name = "Newtb_OHPerUnit"
        Me.Newtb_OHPerUnit.Size = New System.Drawing.Size(62, 20)
        Me.Newtb_OHPerUnit.TabIndex = 23
        Me.Newtb_OHPerUnit.Text = "2.36"
        Me.Newtb_OHPerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 171)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Net Profit"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 149)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 13)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Overhead Contribution"
        '
        'tb_NetperORder
        '
        Me.tb_NetperORder.Location = New System.Drawing.Point(358, 169)
        Me.tb_NetperORder.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_NetperORder.Name = "tb_NetperORder"
        Me.tb_NetperORder.Size = New System.Drawing.Size(62, 20)
        Me.tb_NetperORder.TabIndex = 20
        Me.tb_NetperORder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_NetperUnit
        '
        Me.tb_NetperUnit.Location = New System.Drawing.Point(276, 169)
        Me.tb_NetperUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_NetperUnit.Name = "tb_NetperUnit"
        Me.tb_NetperUnit.Size = New System.Drawing.Size(62, 20)
        Me.tb_NetperUnit.TabIndex = 19
        Me.tb_NetperUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_OHPerOrder
        '
        Me.tb_OHPerOrder.Location = New System.Drawing.Point(358, 146)
        Me.tb_OHPerOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_OHPerOrder.Name = "tb_OHPerOrder"
        Me.tb_OHPerOrder.Size = New System.Drawing.Size(62, 20)
        Me.tb_OHPerOrder.TabIndex = 18
        Me.tb_OHPerOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_GrossPerOrder
        '
        Me.tb_GrossPerOrder.Location = New System.Drawing.Point(358, 116)
        Me.tb_GrossPerOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_GrossPerOrder.Name = "tb_GrossPerOrder"
        Me.tb_GrossPerOrder.Size = New System.Drawing.Size(62, 20)
        Me.tb_GrossPerOrder.TabIndex = 16
        Me.tb_GrossPerOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_GrossPerUnit
        '
        Me.tb_GrossPerUnit.Location = New System.Drawing.Point(276, 116)
        Me.tb_GrossPerUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_GrossPerUnit.Name = "tb_GrossPerUnit"
        Me.tb_GrossPerUnit.Size = New System.Drawing.Size(62, 20)
        Me.tb_GrossPerUnit.TabIndex = 15
        Me.tb_GrossPerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_MatPerOrder
        '
        Me.tb_MatPerOrder.Location = New System.Drawing.Point(358, 87)
        Me.tb_MatPerOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_MatPerOrder.Name = "tb_MatPerOrder"
        Me.tb_MatPerOrder.Size = New System.Drawing.Size(62, 20)
        Me.tb_MatPerOrder.TabIndex = 14
        Me.tb_MatPerOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_MatPerUnit
        '
        Me.tb_MatPerUnit.Location = New System.Drawing.Point(276, 87)
        Me.tb_MatPerUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_MatPerUnit.Name = "tb_MatPerUnit"
        Me.tb_MatPerUnit.Size = New System.Drawing.Size(62, 20)
        Me.tb_MatPerUnit.TabIndex = 13
        Me.tb_MatPerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(386, 15)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 13)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Order"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(274, 15)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Per Item/Unit"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 116)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Gross Profit"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 89)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Direct Material Cost"
        '
        'tb_LabperUnit
        '
        Me.tb_LabperUnit.Location = New System.Drawing.Point(276, 63)
        Me.tb_LabperUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_LabperUnit.Name = "tb_LabperUnit"
        Me.tb_LabperUnit.Size = New System.Drawing.Size(62, 20)
        Me.tb_LabperUnit.TabIndex = 8
        Me.tb_LabperUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_LabperORder
        '
        Me.tb_LabperORder.Location = New System.Drawing.Point(358, 63)
        Me.tb_LabperORder.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_LabperORder.Name = "tb_LabperORder"
        Me.tb_LabperORder.Size = New System.Drawing.Size(62, 20)
        Me.tb_LabperORder.TabIndex = 7
        Me.tb_LabperORder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_SP_PerUnit
        '
        Me.tb_SP_PerUnit.Location = New System.Drawing.Point(276, 39)
        Me.tb_SP_PerUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_SP_PerUnit.Name = "tb_SP_PerUnit"
        Me.tb_SP_PerUnit.Size = New System.Drawing.Size(62, 20)
        Me.tb_SP_PerUnit.TabIndex = 6
        Me.tb_SP_PerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 66)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(205, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Direct Labour (Cost Adjusted for efficienty)"
        '
        'tb_SPPerOrder
        '
        Me.tb_SPPerOrder.Location = New System.Drawing.Point(358, 39)
        Me.tb_SPPerOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_SPPerOrder.Name = "tb_SPPerOrder"
        Me.tb_SPPerOrder.Size = New System.Drawing.Size(62, 20)
        Me.tb_SPPerOrder.TabIndex = 4
        Me.tb_SPPerOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 41)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Product Selling Price"
        '
        'TabPage_Quoting
        '
        Me.TabPage_Quoting.Controls.Add(Me.Button11)
        Me.TabPage_Quoting.Controls.Add(Me.Button10)
        Me.TabPage_Quoting.Controls.Add(Me.Button7)
        Me.TabPage_Quoting.Controls.Add(Me.Button6)
        Me.TabPage_Quoting.Controls.Add(Me.DataGridView2)
        Me.TabPage_Quoting.Controls.Add(Me.GroupBox5)
        Me.TabPage_Quoting.Controls.Add(Me.GroupBox4)
        Me.TabPage_Quoting.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Quoting.Name = "TabPage_Quoting"
        Me.TabPage_Quoting.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Quoting.Size = New System.Drawing.Size(1298, 721)
        Me.TabPage_Quoting.TabIndex = 4
        Me.TabPage_Quoting.Text = "Quoting"
        Me.TabPage_Quoting.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button11.Location = New System.Drawing.Point(636, 653)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(200, 23)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "Edit previous quote"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.Location = New System.Drawing.Point(430, 653)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(200, 23)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "Add Quote Notes"
        Me.Button10.UseVisualStyleBackColor = True
        Me.Button10.Visible = False
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.Location = New System.Drawing.Point(845, 653)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(198, 23)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Print/Mail Quote"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(1049, 653)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(200, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Save Quote"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FktblProductDataGridViewTextBoxColumn, Me.TxtProdCdeDataGridViewTextBoxColumn, Me.TxtProdDescDataGridViewTextBoxColumn, Me.TxtProdSpec1DataGridViewTextBoxColumn, Me.TxtProdSpec2DataGridViewTextBoxColumn, Me.TxtProdSpec3DataGridViewTextBoxColumn, Me.txtUOM, Me.dgv2_Qty, Me.dgv2_SP, Me.dgv2_Amt, Me.DecOriginalPriceDataGridViewTextBoxColumn, Me.dgv2_VatPer, Me.dgv2_VatAmt, Me.dgv2_TotAmt})
        Me.DataGridView2.DataSource = Me.TblQuoteDetailBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(6, 267)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1243, 300)
        Me.DataGridView2.TabIndex = 3
        Me.DataGridView2.Visible = False
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
        'txtUOM
        '
        Me.txtUOM.DataPropertyName = "txtUOM"
        Me.txtUOM.HeaderText = "Unit"
        Me.txtUOM.Name = "txtUOM"
        '
        'dgv2_Qty
        '
        Me.dgv2_Qty.DataPropertyName = "decQty"
        Me.dgv2_Qty.HeaderText = "Quantity"
        Me.dgv2_Qty.Name = "dgv2_Qty"
        '
        'dgv2_SP
        '
        Me.dgv2_SP.DataPropertyName = "decSellingPrice"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.dgv2_SP.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv2_SP.HeaderText = "Selling Price"
        Me.dgv2_SP.Name = "dgv2_SP"
        '
        'dgv2_Amt
        '
        Me.dgv2_Amt.DataPropertyName = "decSellingValue"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.dgv2_Amt.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv2_Amt.HeaderText = "Gross Value"
        Me.dgv2_Amt.Name = "dgv2_Amt"
        '
        'DecOriginalPriceDataGridViewTextBoxColumn
        '
        Me.DecOriginalPriceDataGridViewTextBoxColumn.DataPropertyName = "decOriginalPrice"
        Me.DecOriginalPriceDataGridViewTextBoxColumn.HeaderText = "decOriginalPrice"
        Me.DecOriginalPriceDataGridViewTextBoxColumn.Name = "DecOriginalPriceDataGridViewTextBoxColumn"
        Me.DecOriginalPriceDataGridViewTextBoxColumn.Visible = False
        '
        'dgv2_VatPer
        '
        Me.dgv2_VatPer.DataPropertyName = "decVatPercentage"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.dgv2_VatPer.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv2_VatPer.HeaderText = "Vat %"
        Me.dgv2_VatPer.Name = "dgv2_VatPer"
        '
        'dgv2_VatAmt
        '
        Me.dgv2_VatAmt.DataPropertyName = "decVatAmount"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.dgv2_VatAmt.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv2_VatAmt.HeaderText = "VAT Amount"
        Me.dgv2_VatAmt.Name = "dgv2_VatAmt"
        '
        'dgv2_TotAmt
        '
        Me.dgv2_TotAmt.DataPropertyName = "decQuoteLineAmount"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.dgv2_TotAmt.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv2_TotAmt.HeaderText = "Quote Amount"
        Me.dgv2_TotAmt.Name = "dgv2_TotAmt"
        '
        'TblQuoteDetailBindingSource
        '
        Me.TblQuoteDetailBindingSource.DataMember = "tblQuoteDetail"
        Me.TblQuoteDetailBindingSource.DataSource = Me.DsAccounting
        '
        'DsAccounting
        '
        Me.DsAccounting.DataSetName = "dsAccounting"
        Me.DsAccounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.tb_ProfPer)
        Me.GroupBox5.Controls.Add(Me.Label39)
        Me.GroupBox5.Controls.Add(Me.tb_OrderQty_Quote)
        Me.GroupBox5.Controls.Add(Me.Label35)
        Me.GroupBox5.Controls.Add(Me.tb_InvoiceID)
        Me.GroupBox5.Controls.Add(Me.tb_InvoiceNo)
        Me.GroupBox5.Controls.Add(Me.Button9)
        Me.GroupBox5.Controls.Add(Me.tb_QuoteNo)
        Me.GroupBox5.Controls.Add(Me.tb_QuoteID)
        Me.GroupBox5.Controls.Add(Me.tb_ProdID)
        Me.GroupBox5.Controls.Add(Me.tb_NPSellPrice)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.Label33)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Me.tb_GrossProfitPer)
        Me.GroupBox5.Controls.Add(Me.tb_NP)
        Me.GroupBox5.Controls.Add(Me.tb_OH)
        Me.GroupBox5.Controls.Add(Me.tb_GP)
        Me.GroupBox5.Controls.Add(Me.tb_MatCost)
        Me.GroupBox5.Controls.Add(Me.tb_LabCost)
        Me.GroupBox5.Controls.Add(Me.tb_SellingPrice)
        Me.GroupBox5.Controls.Add(Me.Label34)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.Label37)
        Me.GroupBox5.Controls.Add(Me.Label38)
        Me.GroupBox5.Controls.Add(Me.Label40)
        Me.GroupBox5.Controls.Add(Me.Label41)
        Me.GroupBox5.Controls.Add(Me.Label42)
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.Label43)
        Me.GroupBox5.Controls.Add(Me.cb_Quote_Product)
        Me.GroupBox5.Location = New System.Drawing.Point(518, 24)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(451, 215)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Product details"
        Me.GroupBox5.Visible = False
        '
        'tb_ProfPer
        '
        Me.tb_ProfPer.Location = New System.Drawing.Point(369, 46)
        Me.tb_ProfPer.Name = "tb_ProfPer"
        Me.tb_ProfPer.Size = New System.Drawing.Size(66, 20)
        Me.tb_ProfPer.TabIndex = 33
        Me.tb_ProfPer.Tag = "Clear"
        Me.tb_ProfPer.Text = "50"
        Me.tb_ProfPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(242, 49)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(108, 13)
        Me.Label39.TabIndex = 32
        Me.Label39.Text = "Desired gross profit %"
        '
        'tb_OrderQty_Quote
        '
        Me.tb_OrderQty_Quote.Location = New System.Drawing.Point(143, 46)
        Me.tb_OrderQty_Quote.Name = "tb_OrderQty_Quote"
        Me.tb_OrderQty_Quote.Size = New System.Drawing.Size(66, 20)
        Me.tb_OrderQty_Quote.TabIndex = 31
        Me.tb_OrderQty_Quote.Tag = "Clear"
        Me.tb_OrderQty_Quote.Text = "1"
        Me.tb_OrderQty_Quote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(16, 49)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(75, 13)
        Me.Label35.TabIndex = 30
        Me.Label35.Text = "Order Quantity"
        '
        'tb_InvoiceID
        '
        Me.tb_InvoiceID.Location = New System.Drawing.Point(183, 132)
        Me.tb_InvoiceID.Name = "tb_InvoiceID"
        Me.tb_InvoiceID.Size = New System.Drawing.Size(66, 20)
        Me.tb_InvoiceID.TabIndex = 29
        Me.tb_InvoiceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tb_InvoiceID.Visible = False
        '
        'tb_InvoiceNo
        '
        Me.tb_InvoiceNo.Location = New System.Drawing.Point(19, 65)
        Me.tb_InvoiceNo.Name = "tb_InvoiceNo"
        Me.tb_InvoiceNo.Size = New System.Drawing.Size(66, 20)
        Me.tb_InvoiceNo.TabIndex = 28
        Me.tb_InvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tb_InvoiceNo.Visible = False
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(128, 186)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(99, 23)
        Me.Button9.TabIndex = 27
        Me.Button9.Text = "Add fabric"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'tb_QuoteNo
        '
        Me.tb_QuoteNo.Location = New System.Drawing.Point(28, 142)
        Me.tb_QuoteNo.Name = "tb_QuoteNo"
        Me.tb_QuoteNo.Size = New System.Drawing.Size(66, 20)
        Me.tb_QuoteNo.TabIndex = 26
        Me.tb_QuoteNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tb_QuoteNo.Visible = False
        '
        'tb_QuoteID
        '
        Me.tb_QuoteID.Location = New System.Drawing.Point(91, 65)
        Me.tb_QuoteID.Name = "tb_QuoteID"
        Me.tb_QuoteID.Size = New System.Drawing.Size(66, 20)
        Me.tb_QuoteID.TabIndex = 25
        Me.tb_QuoteID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tb_QuoteID.Visible = False
        '
        'tb_ProdID
        '
        Me.tb_ProdID.Location = New System.Drawing.Point(163, 67)
        Me.tb_ProdID.Name = "tb_ProdID"
        Me.tb_ProdID.Size = New System.Drawing.Size(66, 20)
        Me.tb_ProdID.TabIndex = 24
        Me.tb_ProdID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tb_ProdID.Visible = False
        '
        'tb_NPSellPrice
        '
        Me.tb_NPSellPrice.Location = New System.Drawing.Point(369, 155)
        Me.tb_NPSellPrice.Name = "tb_NPSellPrice"
        Me.tb_NPSellPrice.Size = New System.Drawing.Size(66, 20)
        Me.tb_NPSellPrice.TabIndex = 23
        Me.tb_NPSellPrice.Tag = "Clear"
        Me.tb_NPSellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(242, 158)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(89, 13)
        Me.Label32.TabIndex = 22
        Me.Label32.Text = "Profit % on selling"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(180, 90)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(47, 13)
        Me.Label33.TabIndex = 21
        Me.Label33.Text = "Budget"
        Me.Label33.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(231, 186)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 23)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Re-Calculate"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'tb_GrossProfitPer
        '
        Me.tb_GrossProfitPer.Location = New System.Drawing.Point(369, 133)
        Me.tb_GrossProfitPer.Name = "tb_GrossProfitPer"
        Me.tb_GrossProfitPer.Size = New System.Drawing.Size(66, 20)
        Me.tb_GrossProfitPer.TabIndex = 19
        Me.tb_GrossProfitPer.Tag = "Clear"
        Me.tb_GrossProfitPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_NP
        '
        Me.tb_NP.Location = New System.Drawing.Point(369, 112)
        Me.tb_NP.Name = "tb_NP"
        Me.tb_NP.Size = New System.Drawing.Size(66, 20)
        Me.tb_NP.TabIndex = 18
        Me.tb_NP.Tag = "Clear"
        Me.tb_NP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_OH
        '
        Me.tb_OH.Location = New System.Drawing.Point(369, 90)
        Me.tb_OH.Name = "tb_OH"
        Me.tb_OH.Size = New System.Drawing.Size(66, 20)
        Me.tb_OH.TabIndex = 17
        Me.tb_OH.Tag = "Clear"
        Me.tb_OH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_GP
        '
        Me.tb_GP.Location = New System.Drawing.Point(108, 155)
        Me.tb_GP.Name = "tb_GP"
        Me.tb_GP.Size = New System.Drawing.Size(66, 20)
        Me.tb_GP.TabIndex = 16
        Me.tb_GP.Tag = "Clear"
        Me.tb_GP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_MatCost
        '
        Me.tb_MatCost.Location = New System.Drawing.Point(108, 133)
        Me.tb_MatCost.Name = "tb_MatCost"
        Me.tb_MatCost.Size = New System.Drawing.Size(66, 20)
        Me.tb_MatCost.TabIndex = 15
        Me.tb_MatCost.Tag = "Clear"
        Me.tb_MatCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_LabCost
        '
        Me.tb_LabCost.Location = New System.Drawing.Point(108, 110)
        Me.tb_LabCost.Name = "tb_LabCost"
        Me.tb_LabCost.Size = New System.Drawing.Size(66, 20)
        Me.tb_LabCost.TabIndex = 14
        Me.tb_LabCost.Tag = "Clear"
        Me.tb_LabCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_SellingPrice
        '
        Me.tb_SellingPrice.Location = New System.Drawing.Point(108, 87)
        Me.tb_SellingPrice.Name = "tb_SellingPrice"
        Me.tb_SellingPrice.Size = New System.Drawing.Size(66, 20)
        Me.tb_SellingPrice.TabIndex = 13
        Me.tb_SellingPrice.Tag = "Clear"
        Me.tb_SellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(242, 136)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(95, 13)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "Calculated Profit %"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(242, 115)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(53, 13)
        Me.Label36.TabIndex = 11
        Me.Label36.Text = "Nett profit"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(242, 93)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(112, 13)
        Me.Label37.TabIndex = 10
        Me.Label37.Text = "Overhead contribution"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(16, 158)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(60, 13)
        Me.Label38.TabIndex = 9
        Me.Label38.Text = "Gross profit"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(16, 135)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(67, 13)
        Me.Label40.TabIndex = 8
        Me.Label40.Text = "Material cost"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(16, 110)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(63, 13)
        Me.Label41.TabIndex = 7
        Me.Label41.Text = "Labour cost"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(19, 90)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(64, 13)
        Me.Label42.TabIndex = 6
        Me.Label42.Text = "Selling price"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(28, 186)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(336, 186)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Add to quote"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(16, 22)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(121, 13)
        Me.Label43.TabIndex = 3
        Me.Label43.Text = "Select Product to Quote"
        '
        'cb_Quote_Product
        '
        Me.cb_Quote_Product.FormattingEnabled = True
        Me.cb_Quote_Product.Location = New System.Drawing.Point(143, 19)
        Me.cb_Quote_Product.Name = "cb_Quote_Product"
        Me.cb_Quote_Product.Size = New System.Drawing.Size(302, 21)
        Me.cb_Quote_Product.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox15)
        Me.GroupBox4.Controls.Add(Me.TextBox14)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.TextBox13)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.TextBox12)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.TextBox10)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.TextBox9)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.RichTextBox3)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.TextBox8)
        Me.GroupBox4.Controls.Add(Me.cb_Quote_Customer)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 24)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(489, 186)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Customer details"
        Me.GroupBox4.Visible = False
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(395, 18)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(75, 20)
        Me.TextBox15.TabIndex = 33
        Me.TextBox15.TabStop = False
        Me.TextBox15.Visible = False
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(83, 155)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(161, 20)
        Me.TextBox14.TabIndex = 30
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(8, 158)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(73, 13)
        Me.Label30.TabIndex = 16
        Me.Label30.Text = "Contact name"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(384, 129)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(75, 20)
        Me.TextBox13.TabIndex = 26
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(354, 132)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(24, 13)
        Me.Label29.TabIndex = 14
        Me.Label29.Text = "Fax"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(278, 129)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(70, 20)
        Me.TextBox12.TabIndex = 25
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(250, 132)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(22, 13)
        Me.Label28.TabIndex = 12
        Me.Label28.Text = "Cel"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(145, 132)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(22, 13)
        Me.Label27.TabIndex = 11
        Me.Label27.Text = "Tel"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(244, 161)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 13)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "Email address"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(322, 158)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(161, 20)
        Me.TextBox10.TabIndex = 32
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 132)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(89, 13)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Contact Numbers"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(174, 129)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(70, 20)
        Me.TextBox9.TabIndex = 22
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 75)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 13)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "Address"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Location = New System.Drawing.Point(148, 72)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(241, 51)
        Me.RichTextBox3.TabIndex = 20
        Me.RichTextBox3.Text = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 49)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(82, 13)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "Customer Name"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 22)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(84, 13)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Select Customer"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(148, 46)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(241, 20)
        Me.TextBox8.TabIndex = 10
        '
        'cb_Quote_Customer
        '
        Me.cb_Quote_Customer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomerBindingSource, "txtCusDesc", True))
        Me.cb_Quote_Customer.DataSource = Me.TblCustomerBindingSource1
        Me.cb_Quote_Customer.DisplayMember = "txtCusDesc"
        Me.cb_Quote_Customer.FormattingEnabled = True
        Me.cb_Quote_Customer.Location = New System.Drawing.Point(148, 19)
        Me.cb_Quote_Customer.Name = "cb_Quote_Customer"
        Me.cb_Quote_Customer.Size = New System.Drawing.Size(241, 21)
        Me.cb_Quote_Customer.TabIndex = 0
        Me.cb_Quote_Customer.ValueMember = "id_tblCustomer"
        '
        'TblCustomerBindingSource1
        '
        Me.TblCustomerBindingSource1.DataMember = "tblCustomer"
        Me.TblCustomerBindingSource1.DataSource = Me.DsProdDB1
        '
        'TabPage_Lab
        '
        Me.TabPage_Lab.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_Lab.Controls.Add(Me.dgvLabour)
        Me.TabPage_Lab.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Lab.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage_Lab.Name = "TabPage_Lab"
        Me.TabPage_Lab.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage_Lab.Size = New System.Drawing.Size(1298, 721)
        Me.TabPage_Lab.TabIndex = 2
        Me.TabPage_Lab.Text = "Labour Requirements"
        '
        'dgvLabour
        '
        Me.dgvLabour.AllowUserToAddRows = False
        Me.dgvLabour.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvLabour.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvLabour.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLabour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLabour.Location = New System.Drawing.Point(3, 5)
        Me.dgvLabour.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvLabour.Name = "dgvLabour"
        Me.dgvLabour.RowTemplate.Height = 24
        Me.dgvLabour.Size = New System.Drawing.Size(1238, 379)
        Me.dgvLabour.TabIndex = 0
        '
        'TabPage_Mat
        '
        Me.TabPage_Mat.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_Mat.Controls.Add(Me.ComboBox2)
        Me.TabPage_Mat.Controls.Add(Me.Label20)
        Me.TabPage_Mat.Controls.Add(Me.dgvMaterial)
        Me.TabPage_Mat.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Mat.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage_Mat.Name = "TabPage_Mat"
        Me.TabPage_Mat.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage_Mat.Size = New System.Drawing.Size(1298, 721)
        Me.TabPage_Mat.TabIndex = 3
        Me.TabPage_Mat.Text = "Material Requirements"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"All", "Component", "Material"})
        Me.ComboBox2.Location = New System.Drawing.Point(128, 16)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox2.TabIndex = 2
        Me.ComboBox2.Tag = "NotSelected"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(117, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Select details to display"
        '
        'dgvMaterial
        '
        Me.dgvMaterial.AllowUserToAddRows = False
        Me.dgvMaterial.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvMaterial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvMaterial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMaterial.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterial.Location = New System.Drawing.Point(4, 44)
        Me.dgvMaterial.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvMaterial.Name = "dgvMaterial"
        Me.dgvMaterial.ReadOnly = True
        Me.dgvMaterial.RowTemplate.Height = 24
        Me.dgvMaterial.Size = New System.Drawing.Size(1246, 307)
        Me.dgvMaterial.TabIndex = 0
        '
        'TblProductBindingSource
        '
        Me.TblProductBindingSource.DataMember = "tblProduct"
        Me.TblProductBindingSource.DataSource = Me.DsProdDB1BindingSource
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRecordToolStripMenuItem, Me.EditRecordToolStripMenuItem, Me.SaveRecordToolStripMenuItem, Me.CancelToolStripMenuItem, Me.PrintRecordToolStripMenuItem, Me.CloseFormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1268, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewRecordToolStripMenuItem
        '
        Me.NewRecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_CreateTemp})
        Me.NewRecordToolStripMenuItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecordToolStripMenuItem.Name = "NewRecordToolStripMenuItem"
        Me.NewRecordToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.NewRecordToolStripMenuItem.Text = "New Record"
        '
        'ts_CreateTemp
        '
        Me.ts_CreateTemp.Name = "ts_CreateTemp"
        Me.ts_CreateTemp.Size = New System.Drawing.Size(231, 22)
        Me.ts_CreateTemp.Text = "Create new (temporary) product"
        '
        'EditRecordToolStripMenuItem
        '
        Me.EditRecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_EditProduct, Me.ts_EditBudget, Me.ts_EditLabour, Me.ts_EditMaterial})
        Me.EditRecordToolStripMenuItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditRecordToolStripMenuItem.Name = "EditRecordToolStripMenuItem"
        Me.EditRecordToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.EditRecordToolStripMenuItem.Text = "Edit Record"
        '
        'ts_EditProduct
        '
        Me.ts_EditProduct.Name = "ts_EditProduct"
        Me.ts_EditProduct.Size = New System.Drawing.Size(164, 22)
        Me.ts_EditProduct.Text = "Product"
        '
        'ts_EditBudget
        '
        Me.ts_EditBudget.Name = "ts_EditBudget"
        Me.ts_EditBudget.Size = New System.Drawing.Size(164, 22)
        Me.ts_EditBudget.Text = "Product Budget"
        '
        'ts_EditLabour
        '
        Me.ts_EditLabour.Name = "ts_EditLabour"
        Me.ts_EditLabour.Size = New System.Drawing.Size(164, 22)
        Me.ts_EditLabour.Text = "Labour Standards"
        '
        'ts_EditMaterial
        '
        Me.ts_EditMaterial.Name = "ts_EditMaterial"
        Me.ts_EditMaterial.Size = New System.Drawing.Size(164, 22)
        Me.ts_EditMaterial.Text = "Material Standards"
        '
        'SaveRecordToolStripMenuItem
        '
        Me.SaveRecordToolStripMenuItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveRecordToolStripMenuItem.Name = "SaveRecordToolStripMenuItem"
        Me.SaveRecordToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.SaveRecordToolStripMenuItem.Text = "Save Record"
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'PrintRecordToolStripMenuItem
        '
        Me.PrintRecordToolStripMenuItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintRecordToolStripMenuItem.Name = "PrintRecordToolStripMenuItem"
        Me.PrintRecordToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.PrintRecordToolStripMenuItem.Text = "Print Record"
        '
        'CloseFormToolStripMenuItem
        '
        Me.CloseFormToolStripMenuItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseFormToolStripMenuItem.Name = "CloseFormToolStripMenuItem"
        Me.CloseFormToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.CloseFormToolStripMenuItem.Text = "Close Form"
        '
        'TblProductTableAdapter1
        '
        Me.TblProductTableAdapter1.ClearBeforeFill = True
        '
        'LstLabourLinkTableAdapter1
        '
        Me.LstLabourLinkTableAdapter1.ClearBeforeFill = True
        '
        'LstMaterialLinkTableAdapter1
        '
        Me.LstMaterialLinkTableAdapter1.ClearBeforeFill = True
        '
        'TblProdLinkTableAdapter1
        '
        Me.TblProdLinkTableAdapter1.ClearBeforeFill = True
        '
        'bs_ProdLink
        '
        Me.bs_ProdLink.DataMember = "tblProdLink"
        Me.bs_ProdLink.DataSource = Me.DsProdDB1
        '
        'TblMatLinkTableAdapter1
        '
        Me.TblMatLinkTableAdapter1.ClearBeforeFill = True
        '
        'bs_MatLink
        '
        Me.bs_MatLink.DataMember = "tblMatLink"
        Me.bs_MatLink.DataSource = Me.DsProdDB1
        '
        'TblCustomerTableAdapter1
        '
        Me.TblCustomerTableAdapter1.ClearBeforeFill = True
        '
        'TblQuoteHeaderTableAdapter1
        '
        Me.TblQuoteHeaderTableAdapter1.ClearBeforeFill = True
        '
        'TblQuoteDetailTableAdapter1
        '
        Me.TblQuoteDetailTableAdapter1.ClearBeforeFill = True
        '
        'LstLabCostperProductTableAdapter1
        '
        Me.LstLabCostperProductTableAdapter1.ClearBeforeFill = True
        '
        'LstMatCostperProductTableAdapter1
        '
        Me.LstMatCostperProductTableAdapter1.ClearBeforeFill = True
        '
        'TblCoInfoTableAdapter1
        '
        Me.TblCoInfoTableAdapter1.ClearBeforeFill = True
        '
        'TblProductBindingSource1
        '
        Me.TblProductBindingSource1.DataMember = "tblProduct"
        Me.TblProductBindingSource1.DataSource = Me.DsProdDB1
        '
        'LstComponentLinkTableAdapter1
        '
        Me.LstComponentLinkTableAdapter1.ClearBeforeFill = True
        '
        'LstComponentLabourTableAdapter1
        '
        Me.LstComponentLabourTableAdapter1.ClearBeforeFill = True
        '
        'frmQuick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 741)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmQuick"
        Me.Text = "frmQuick"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_QuickQuote.ResumeLayout(False)
        Me.TabPage_QuickQuote.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProdDB1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProdDB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage_Quoting.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQuoteDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccounting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.TblCustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Lab.ResumeLayout(False)
        CType(Me.dgvLabour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Mat.ResumeLayout(False)
        Me.TabPage_Mat.PerformLayout()
        CType(Me.dgvMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.bs_ProdLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_MatLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccountingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_QuickQuote As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TblProductTableAdapter1 As CCP.dsProdDBTableAdapters.tblProductTableAdapter
    Friend WithEvents DsProdDB1 As CCP.dsProdDB
    Friend WithEvents TabPage_Lab As System.Windows.Forms.TabPage
    Friend WithEvents dgvLabour As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage_Mat As System.Windows.Forms.TabPage
    Friend WithEvents LstLabourLinkTableAdapter1 As CCP.dsProdDBTableAdapters.lstLabourLinkTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tb_LabperUnit As System.Windows.Forms.TextBox
    Friend WithEvents tb_LabperORder As System.Windows.Forms.TextBox
    Friend WithEvents tb_SP_PerUnit As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tb_SPPerOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dgvMaterial As System.Windows.Forms.DataGridView
    Friend WithEvents LstMaterialLinkTableAdapter1 As CCP.dsProdDBTableAdapters.lstMaterialLinkTableAdapter
    Friend WithEvents tb_MatPerOrder As System.Windows.Forms.TextBox
    Friend WithEvents tb_MatPerUnit As System.Windows.Forms.TextBox
    Friend WithEvents tb_GrossPerOrder As System.Windows.Forms.TextBox
    Friend WithEvents tb_GrossPerUnit As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tbDesGrossPer As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tb_NetperORder As System.Windows.Forms.TextBox
    Friend WithEvents tb_NetperUnit As System.Windows.Forms.TextBox
    Friend WithEvents tb_OHPerOrder As System.Windows.Forms.TextBox
    Friend WithEvents Newtb_OHPerUnit As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NewRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TblProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsProdDB1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgvCapacity As System.Windows.Forms.DataGridView
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ts_CreateTemp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TblProdLinkTableAdapter1 As CCP.dsProdDBTableAdapters.tblProdLinkTableAdapter
    Friend WithEvents bs_ProdLink As System.Windows.Forms.BindingSource
    Friend WithEvents TblMatLinkTableAdapter1 As CCP.dsProdDBTableAdapters.tblMatLinkTableAdapter
    Friend WithEvents bs_MatLink As System.Windows.Forms.BindingSource
    Friend WithEvents ts_EditProduct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_EditLabour As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_EditMaterial As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_EditBudget As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TblCustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCustomerTableAdapter1 As CCP.dsProdDBTableAdapters.tblCustomerTableAdapter
    Friend WithEvents TabPage_Quoting As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents cb_Quote_Customer As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_ProfPer As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents tb_OrderQty_Quote As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents tb_InvoiceID As System.Windows.Forms.TextBox
    Friend WithEvents tb_InvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents tb_QuoteNo As System.Windows.Forms.TextBox
    Friend WithEvents tb_QuoteID As System.Windows.Forms.TextBox
    Friend WithEvents tb_ProdID As System.Windows.Forms.TextBox
    Friend WithEvents tb_NPSellPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents tb_GrossProfitPer As System.Windows.Forms.TextBox
    Friend WithEvents tb_NP As System.Windows.Forms.TextBox
    Friend WithEvents tb_OH As System.Windows.Forms.TextBox
    Friend WithEvents tb_GP As System.Windows.Forms.TextBox
    Friend WithEvents tb_MatCost As System.Windows.Forms.TextBox
    Friend WithEvents tb_LabCost As System.Windows.Forms.TextBox
    Friend WithEvents tb_SellingPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents cb_Quote_Product As System.Windows.Forms.ComboBox
    Friend WithEvents TblQuoteHeaderTableAdapter1 As CCP.dsAccountingTableAdapters.tblQuoteHeaderTableAdapter
    Friend WithEvents TblQuoteDetailTableAdapter1 As CCP.dsAccountingTableAdapters.tblQuoteDetailTableAdapter
    Friend WithEvents TblQuoteDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsAccountingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsAccounting As CCP.dsAccounting
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents FktblProductDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtProdCdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtProdDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtProdSpec1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtProdSpec2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtProdSpec3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtUOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv2_Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv2_SP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv2_Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DecOriginalPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv2_VatPer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv2_VatAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv2_TotAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstLabCostperProductTableAdapter1 As CCP.dsAccountingTableAdapters.lstLabCostperProductTableAdapter
    Friend WithEvents LstMatCostperProductTableAdapter1 As CCP.dsAccountingTableAdapters.lstMatCostperProductTableAdapter
    Friend WithEvents TblCustomerBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblCoInfoTableAdapter1 As CCP.dsAccountingTableAdapters.tblCoInfoTableAdapter
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TblProductBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents LstComponentLinkTableAdapter1 As CCP.dsProdDBTableAdapters.lstComponentLinkTableAdapter
    Friend WithEvents LstComponentLabourTableAdapter1 As CCP.dsProdDBTableAdapters.lstComponentLabourTableAdapter
End Class
