<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduct))
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage_ProdDet = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctx_Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctx_Paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctx_Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.bs_tblProduct = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProdDB1 = New CCP.dsProdDB()
        Me.TabPage_ProdBud = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cBox_Deletecurrent = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tb_Co = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnFillEasyOptions = New System.Windows.Forms.Button()
        Me.tb_SpreadVolume = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tb_FixedPrice = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cb_ChangeMonth = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbox_FillMonths = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TblprodbudDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdtblProdBudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKtblProductidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtPeriodDescriptorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DecVolumeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DecSalesPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DecGrossIncomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs_tblProdBud = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage_ProdActVal = New System.Windows.Forms.TabPage()
        Me.TabPage_ProdActVol = New System.Windows.Forms.TabPage()
        Me.bsProduct = New System.Windows.Forms.BindingSource(Me.components)
        Me.frmERR = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblProdLinkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProductTableAdapter2 = New CCP.dsProdDBTableAdapters.tblProductTableAdapter()
        Me.TblProdBudTableAdapter1 = New CCP.dsProdDBTableAdapters.tblProdBudTableAdapter()
        Me.TblProdLinkTableAdapter = New CCP.dsProdDBTableAdapters.tblProdLinkTableAdapter()
        Me.TblElementTableAdapter1 = New CCP.dsProdDBTableAdapters.tblElementTableAdapter()
        Me.TblActivityTableAdapter1 = New CCP.dsProdDBTableAdapters.tblActivityTableAdapter()
        Me.TblOperationTableAdapter1 = New CCP.dsProdDBTableAdapters.tblOperationTableAdapter()
        Me.TblStaffTableAdapter1 = New CCP.dsProdDBTableAdapters.tblStaffTableAdapter()
        Me.TblProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCoInfoTableAdapter1 = New CCP.dsProdDBTableAdapters.tblCoInfoTableAdapter()
        Me.dgv1_idtblProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtProdCdeDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.TxtProdDescDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.txtProdSpec1DataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.txtProdSpec2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtProdSpec3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCostSortCatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCostSortItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKidtblCoInfoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_Pic = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabControl2.SuspendLayout()
        Me.TabPage_ProdDet.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.bs_tblProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProdDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_ProdBud.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TblprodbudDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_tblProdBud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmERR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.TblProdLinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage_ProdDet)
        Me.TabControl2.Controls.Add(Me.TabPage_ProdBud)
        Me.TabControl2.Controls.Add(Me.TabPage_ProdActVal)
        Me.TabControl2.Controls.Add(Me.TabPage_ProdActVol)
        Me.TabControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(0, 29)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1284, 710)
        Me.TabControl2.TabIndex = 15
        '
        'TabPage_ProdDet
        '
        Me.TabPage_ProdDet.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_ProdDet.Controls.Add(Me.DataGridView1)
        Me.TabPage_ProdDet.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ProdDet.Name = "TabPage_ProdDet"
        Me.TabPage_ProdDet.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ProdDet.Size = New System.Drawing.Size(1276, 684)
        Me.TabPage_ProdDet.TabIndex = 0
        Me.TabPage_ProdDet.Text = "Product Detail"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv1_idtblProduct, Me.TxtProdCdeDataGridViewTextBoxColumn, Me.TxtProdDescDataGridViewTextBoxColumn, Me.txtProdSpec1DataGridViewTextBoxColumn, Me.txtProdSpec2DataGridViewTextBoxColumn, Me.txtProdSpec3, Me.TxtCostSortCatDataGridViewTextBoxColumn, Me.TxtCostSortItemDataGridViewTextBoxColumn, Me.FKidtblCoInfoDataGridViewTextBoxColumn, Me.dgv_Pic})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.DataSource = Me.bs_tblProduct
        Me.DataGridView1.Location = New System.Drawing.Point(3, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1270, 646)
        Me.DataGridView1.TabIndex = 14
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctx_Copy, Me.ctx_Paste, Me.ctx_Delete})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(131, 70)
        '
        'ctx_Copy
        '
        Me.ctx_Copy.Name = "ctx_Copy"
        Me.ctx_Copy.Size = New System.Drawing.Size(130, 22)
        Me.ctx_Copy.Text = "Copy Row"
        '
        'ctx_Paste
        '
        Me.ctx_Paste.Name = "ctx_Paste"
        Me.ctx_Paste.Size = New System.Drawing.Size(130, 22)
        Me.ctx_Paste.Text = "Paste Row"
        '
        'ctx_Delete
        '
        Me.ctx_Delete.Name = "ctx_Delete"
        Me.ctx_Delete.Size = New System.Drawing.Size(130, 22)
        Me.ctx_Delete.Text = "Delete row"
        '
        'bs_tblProduct
        '
        Me.bs_tblProduct.DataMember = "tblProduct"
        Me.bs_tblProduct.DataSource = Me.DsProdDB1
        '
        'DsProdDB1
        '
        Me.DsProdDB1.DataSetName = "dsProdDB"
        Me.DsProdDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage_ProdBud
        '
        Me.TabPage_ProdBud.Controls.Add(Me.Label2)
        Me.TabPage_ProdBud.Controls.Add(Me.GroupBox2)
        Me.TabPage_ProdBud.Controls.Add(Me.TblprodbudDataGridView)
        Me.TabPage_ProdBud.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage_ProdBud.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ProdBud.Name = "TabPage_ProdBud"
        Me.TabPage_ProdBud.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ProdBud.Size = New System.Drawing.Size(1276, 684)
        Me.TabPage_ProdBud.TabIndex = 1
        Me.TabPage_ProdBud.Text = "Product Budget"
        Me.TabPage_ProdBud.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox2.Controls.Add(Me.cBox_Deletecurrent)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.tb_Co)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.btnFillEasyOptions)
        Me.GroupBox2.Controls.Add(Me.tb_SpreadVolume)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.tb_FixedPrice)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cb_ChangeMonth)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cbox_FillMonths)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(486, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(771, 281)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Easy Fill Options"
        '
        'cBox_Deletecurrent
        '
        Me.cBox_Deletecurrent.AutoSize = True
        Me.cBox_Deletecurrent.Location = New System.Drawing.Point(542, 48)
        Me.cBox_Deletecurrent.Name = "cBox_Deletecurrent"
        Me.cBox_Deletecurrent.Size = New System.Drawing.Size(15, 14)
        Me.cBox_Deletecurrent.TabIndex = 12
        Me.cBox_Deletecurrent.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(367, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 13)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Delete current budget"
        '
        'tb_Co
        '
        Me.tb_Co.Enabled = False
        Me.tb_Co.Location = New System.Drawing.Point(307, 15)
        Me.tb_Co.Name = "tb_Co"
        Me.tb_Co.Size = New System.Drawing.Size(35, 19)
        Me.tb_Co.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(50, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Company"
        '
        'btnFillEasyOptions
        '
        Me.btnFillEasyOptions.Location = New System.Drawing.Point(307, 229)
        Me.btnFillEasyOptions.Name = "btnFillEasyOptions"
        Me.btnFillEasyOptions.Size = New System.Drawing.Size(100, 28)
        Me.btnFillEasyOptions.TabIndex = 8
        Me.btnFillEasyOptions.Text = "Fill"
        Me.btnFillEasyOptions.UseVisualStyleBackColor = True
        '
        'tb_SpreadVolume
        '
        Me.tb_SpreadVolume.Location = New System.Drawing.Point(307, 167)
        Me.tb_SpreadVolume.Name = "tb_SpreadVolume"
        Me.tb_SpreadVolume.Size = New System.Drawing.Size(100, 19)
        Me.tb_SpreadVolume.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(50, 170)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Spread volume over periods"
        '
        'tb_FixedPrice
        '
        Me.tb_FixedPrice.Location = New System.Drawing.Point(307, 124)
        Me.tb_FixedPrice.Name = "tb_FixedPrice"
        Me.tb_FixedPrice.Size = New System.Drawing.Size(100, 19)
        Me.tb_FixedPrice.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(50, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(162, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Fixed Sales Price over all periods"
        '
        'cb_ChangeMonth
        '
        Me.cb_ChangeMonth.FormattingEnabled = True
        Me.cb_ChangeMonth.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.cb_ChangeMonth.Location = New System.Drawing.Point(307, 78)
        Me.cb_ChangeMonth.Name = "cb_ChangeMonth"
        Me.cb_ChangeMonth.Size = New System.Drawing.Size(121, 21)
        Me.cb_ChangeMonth.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(50, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Change start month"
        '
        'cbox_FillMonths
        '
        Me.cbox_FillMonths.AutoSize = True
        Me.cbox_FillMonths.Location = New System.Drawing.Point(307, 47)
        Me.cbox_FillMonths.Name = "cbox_FillMonths"
        Me.cbox_FillMonths.Size = New System.Drawing.Size(15, 14)
        Me.cbox_FillMonths.TabIndex = 1
        Me.cbox_FillMonths.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(50, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(155, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Fill Months per Normal YearEnd"
        '
        'TblprodbudDataGridView
        '
        Me.TblprodbudDataGridView.AllowUserToAddRows = False
        Me.TblprodbudDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblprodbudDataGridView.AutoGenerateColumns = False
        Me.TblprodbudDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblprodbudDataGridView.BackgroundColor = System.Drawing.Color.LightGreen
        Me.TblprodbudDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtblProdBudDataGridViewTextBoxColumn, Me.FKtblProductidDataGridViewTextBoxColumn, Me.TxtPeriodDescriptorDataGridViewTextBoxColumn, Me.DecVolumeDataGridViewTextBoxColumn, Me.DecSalesPriceDataGridViewTextBoxColumn, Me.DecGrossIncomeDataGridViewTextBoxColumn})
        Me.TblprodbudDataGridView.DataSource = Me.bs_tblProdBud
        Me.TblprodbudDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TblprodbudDataGridView.Location = New System.Drawing.Point(0, 43)
        Me.TblprodbudDataGridView.Name = "TblprodbudDataGridView"
        Me.TblprodbudDataGridView.RowTemplate.Height = 24
        Me.TblprodbudDataGridView.Size = New System.Drawing.Size(445, 627)
        Me.TblprodbudDataGridView.TabIndex = 1
        '
        'IdtblProdBudDataGridViewTextBoxColumn
        '
        Me.IdtblProdBudDataGridViewTextBoxColumn.DataPropertyName = "idtblProdBud"
        Me.IdtblProdBudDataGridViewTextBoxColumn.HeaderText = "idtblProdBud"
        Me.IdtblProdBudDataGridViewTextBoxColumn.Name = "IdtblProdBudDataGridViewTextBoxColumn"
        Me.IdtblProdBudDataGridViewTextBoxColumn.Visible = False
        '
        'FKtblProductidDataGridViewTextBoxColumn
        '
        Me.FKtblProductidDataGridViewTextBoxColumn.DataPropertyName = "FK_tblProductid"
        Me.FKtblProductidDataGridViewTextBoxColumn.HeaderText = "FK_tblProductid"
        Me.FKtblProductidDataGridViewTextBoxColumn.Name = "FKtblProductidDataGridViewTextBoxColumn"
        Me.FKtblProductidDataGridViewTextBoxColumn.Visible = False
        '
        'TxtPeriodDescriptorDataGridViewTextBoxColumn
        '
        Me.TxtPeriodDescriptorDataGridViewTextBoxColumn.DataPropertyName = "txtPeriodDescriptor"
        Me.TxtPeriodDescriptorDataGridViewTextBoxColumn.HeaderText = "Period"
        Me.TxtPeriodDescriptorDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.TxtPeriodDescriptorDataGridViewTextBoxColumn.Name = "TxtPeriodDescriptorDataGridViewTextBoxColumn"
        Me.TxtPeriodDescriptorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TxtPeriodDescriptorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DecVolumeDataGridViewTextBoxColumn
        '
        Me.DecVolumeDataGridViewTextBoxColumn.DataPropertyName = "decVolume"
        Me.DecVolumeDataGridViewTextBoxColumn.HeaderText = "Volume"
        Me.DecVolumeDataGridViewTextBoxColumn.Name = "DecVolumeDataGridViewTextBoxColumn"
        '
        'DecSalesPriceDataGridViewTextBoxColumn
        '
        Me.DecSalesPriceDataGridViewTextBoxColumn.DataPropertyName = "decSalesPrice"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DecSalesPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DecSalesPriceDataGridViewTextBoxColumn.HeaderText = "Sales Price"
        Me.DecSalesPriceDataGridViewTextBoxColumn.Name = "DecSalesPriceDataGridViewTextBoxColumn"
        '
        'DecGrossIncomeDataGridViewTextBoxColumn
        '
        Me.DecGrossIncomeDataGridViewTextBoxColumn.DataPropertyName = "decGrossIncome"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DecGrossIncomeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DecGrossIncomeDataGridViewTextBoxColumn.HeaderText = "Gross Income"
        Me.DecGrossIncomeDataGridViewTextBoxColumn.Name = "DecGrossIncomeDataGridViewTextBoxColumn"
        '
        'bs_tblProdBud
        '
        Me.bs_tblProdBud.DataMember = "tblProdBud"
        Me.bs_tblProdBud.DataSource = Me.DsProdDB1
        '
        'TabPage_ProdActVal
        '
        Me.TabPage_ProdActVal.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ProdActVal.Name = "TabPage_ProdActVal"
        Me.TabPage_ProdActVal.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ProdActVal.Size = New System.Drawing.Size(1276, 684)
        Me.TabPage_ProdActVal.TabIndex = 2
        Me.TabPage_ProdActVal.Text = "Product Actual Value"
        Me.TabPage_ProdActVal.UseVisualStyleBackColor = True
        '
        'TabPage_ProdActVol
        '
        Me.TabPage_ProdActVol.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ProdActVol.Name = "TabPage_ProdActVol"
        Me.TabPage_ProdActVol.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ProdActVol.Size = New System.Drawing.Size(1276, 684)
        Me.TabPage_ProdActVol.TabIndex = 3
        Me.TabPage_ProdActVol.Text = "Product Actual Volume"
        Me.TabPage_ProdActVol.UseVisualStyleBackColor = True
        '
        'bsProduct
        '
        Me.bsProduct.DataSource = Me.bs_tblProduct
        '
        'frmERR
        '
        Me.frmERR.ContainerControl = Me
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.ToolStripButton2, Me.ToolStripSeparator4, Me.ToolStripButton3, Me.ToolStripSeparator5, Me.ToolStripButton4, Me.ToolStripSeparator6, Me.ToolStripButton5, Me.ToolStripSeparator7, Me.ToolStripButton6, Me.ToolStripSeparator8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1268, 26)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(82, 23)
        Me.ToolStripButton1.Text = "New Record"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 26)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(80, 23)
        Me.ToolStripButton2.Text = "Edit Record"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 26)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(85, 23)
        Me.ToolStripButton3.Text = "Save Record"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 26)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(52, 23)
        Me.ToolStripButton4.Text = "Cancel"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 26)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(84, 23)
        Me.ToolStripButton5.Text = "Print Record"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 26)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(79, 26)
        Me.ToolStripButton6.Text = "Close Form"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 26)
        '
        'TblProdLinkBindingSource
        '
        Me.TblProdLinkBindingSource.DataMember = "tblProdLink"
        Me.TblProdLinkBindingSource.DataSource = Me.DsProdDB1
        '
        'TblProductTableAdapter2
        '
        Me.TblProductTableAdapter2.ClearBeforeFill = True
        '
        'TblProdBudTableAdapter1
        '
        Me.TblProdBudTableAdapter1.ClearBeforeFill = True
        '
        'TblProdLinkTableAdapter
        '
        Me.TblProdLinkTableAdapter.ClearBeforeFill = True
        '
        'TblElementTableAdapter1
        '
        Me.TblElementTableAdapter1.ClearBeforeFill = True
        '
        'TblActivityTableAdapter1
        '
        Me.TblActivityTableAdapter1.ClearBeforeFill = True
        '
        'TblOperationTableAdapter1
        '
        Me.TblOperationTableAdapter1.ClearBeforeFill = True
        '
        'TblStaffTableAdapter1
        '
        Me.TblStaffTableAdapter1.ClearBeforeFill = True
        '
        'TblProductBindingSource
        '
        Me.TblProductBindingSource.DataMember = "tblProduct"
        Me.TblProductBindingSource.DataSource = Me.DsProdDB1
        '
        'TblCoInfoTableAdapter1
        '
        Me.TblCoInfoTableAdapter1.ClearBeforeFill = True
        '
        'dgv1_idtblProduct
        '
        Me.dgv1_idtblProduct.DataPropertyName = "idtblProduct"
        Me.dgv1_idtblProduct.HeaderText = "idtblProduct"
        Me.dgv1_idtblProduct.Name = "dgv1_idtblProduct"
        Me.dgv1_idtblProduct.ReadOnly = True
        Me.dgv1_idtblProduct.Visible = False
        '
        'TxtProdCdeDataGridViewTextBoxColumn
        '
        Me.TxtProdCdeDataGridViewTextBoxColumn.DataPropertyName = "txtProdCde"
        Me.TxtProdCdeDataGridViewTextBoxColumn.HeaderText = "Product Code"
        Me.TxtProdCdeDataGridViewTextBoxColumn.Name = "TxtProdCdeDataGridViewTextBoxColumn"
        Me.TxtProdCdeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TxtProdCdeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TxtProdCdeDataGridViewTextBoxColumn.Width = 153
        '
        'TxtProdDescDataGridViewTextBoxColumn
        '
        Me.TxtProdDescDataGridViewTextBoxColumn.DataPropertyName = "txtProdDesc"
        Me.TxtProdDescDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.TxtProdDescDataGridViewTextBoxColumn.Name = "TxtProdDescDataGridViewTextBoxColumn"
        Me.TxtProdDescDataGridViewTextBoxColumn.ReadOnly = True
        Me.TxtProdDescDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TxtProdDescDataGridViewTextBoxColumn.Width = 154
        '
        'txtProdSpec1DataGridViewTextBoxColumn
        '
        Me.txtProdSpec1DataGridViewTextBoxColumn.DataPropertyName = "txtProdSpec1"
        Me.txtProdSpec1DataGridViewTextBoxColumn.HeaderText = "Product Spec 1"
        Me.txtProdSpec1DataGridViewTextBoxColumn.Name = "txtProdSpec1DataGridViewTextBoxColumn"
        Me.txtProdSpec1DataGridViewTextBoxColumn.ReadOnly = True
        Me.txtProdSpec1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.txtProdSpec1DataGridViewTextBoxColumn.Width = 153
        '
        'txtProdSpec2DataGridViewTextBoxColumn
        '
        Me.txtProdSpec2DataGridViewTextBoxColumn.DataPropertyName = "txtProdSpec2"
        Me.txtProdSpec2DataGridViewTextBoxColumn.HeaderText = "Product Spec 2"
        Me.txtProdSpec2DataGridViewTextBoxColumn.Name = "txtProdSpec2DataGridViewTextBoxColumn"
        Me.txtProdSpec2DataGridViewTextBoxColumn.ReadOnly = True
        Me.txtProdSpec2DataGridViewTextBoxColumn.Width = 154
        '
        'txtProdSpec3
        '
        Me.txtProdSpec3.DataPropertyName = "txtProdSpec3"
        Me.txtProdSpec3.HeaderText = "Product Spec 3"
        Me.txtProdSpec3.Name = "txtProdSpec3"
        Me.txtProdSpec3.ReadOnly = True
        Me.txtProdSpec3.Width = 153
        '
        'TxtCostSortCatDataGridViewTextBoxColumn
        '
        Me.TxtCostSortCatDataGridViewTextBoxColumn.DataPropertyName = "txtCostSortCat"
        Me.TxtCostSortCatDataGridViewTextBoxColumn.HeaderText = "Sort Category"
        Me.TxtCostSortCatDataGridViewTextBoxColumn.Name = "TxtCostSortCatDataGridViewTextBoxColumn"
        Me.TxtCostSortCatDataGridViewTextBoxColumn.ReadOnly = True
        Me.TxtCostSortCatDataGridViewTextBoxColumn.Width = 153
        '
        'TxtCostSortItemDataGridViewTextBoxColumn
        '
        Me.TxtCostSortItemDataGridViewTextBoxColumn.DataPropertyName = "txtCostSortItem"
        Me.TxtCostSortItemDataGridViewTextBoxColumn.HeaderText = "Sort Item"
        Me.TxtCostSortItemDataGridViewTextBoxColumn.Name = "TxtCostSortItemDataGridViewTextBoxColumn"
        Me.TxtCostSortItemDataGridViewTextBoxColumn.ReadOnly = True
        Me.TxtCostSortItemDataGridViewTextBoxColumn.Width = 154
        '
        'FKidtblCoInfoDataGridViewTextBoxColumn
        '
        Me.FKidtblCoInfoDataGridViewTextBoxColumn.DataPropertyName = "FK_idtblCoInfo"
        Me.FKidtblCoInfoDataGridViewTextBoxColumn.HeaderText = "Company"
        Me.FKidtblCoInfoDataGridViewTextBoxColumn.Name = "FKidtblCoInfoDataGridViewTextBoxColumn"
        Me.FKidtblCoInfoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FKidtblCoInfoDataGridViewTextBoxColumn.Visible = False
        Me.FKidtblCoInfoDataGridViewTextBoxColumn.Width = 153
        '
        'dgv_Pic
        '
        Me.dgv_Pic.HeaderText = "Picture"
        Me.dgv_Pic.Name = "dgv_Pic"
        Me.dgv_Pic.ReadOnly = True
        '
        'frmProduct
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1268, 767)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FACT - Product Information"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage_ProdDet.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.bs_tblProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProdDB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_ProdBud.ResumeLayout(False)
        Me.TabPage_ProdBud.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TblprodbudDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_tblProdBud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmERR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.TblProdLinkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bs_tblProduct As System.Windows.Forms.BindingSource
    Friend WithEvents DsProdDB1 As CCP.dsProdDB
    Friend WithEvents TblProductTableAdapter2 As CCP.dsProdDBTableAdapters.tblProductTableAdapter
    Friend WithEvents TblProdBudTableAdapter1 As CCP.dsProdDBTableAdapters.tblProdBudTableAdapter
    Friend WithEvents bs_tblProdBud As System.Windows.Forms.BindingSource
    Friend WithEvents TblProdLinkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProdLinkTableAdapter As CCP.dsProdDBTableAdapters.tblProdLinkTableAdapter
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_ProdDet As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage_ProdBud As System.Windows.Forms.TabPage
    Friend WithEvents TblprodbudDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TblElementTableAdapter1 As CCP.dsProdDBTableAdapters.tblElementTableAdapter
    Friend WithEvents TblActivityTableAdapter1 As CCP.dsProdDBTableAdapters.tblActivityTableAdapter
    Friend WithEvents TblOperationTableAdapter1 As CCP.dsProdDBTableAdapters.tblOperationTableAdapter
    Friend WithEvents TblStaffTableAdapter1 As CCP.dsProdDBTableAdapters.tblStaffTableAdapter
    Friend WithEvents TblProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabPage_ProdActVal As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_ProdActVol As System.Windows.Forms.TabPage
    Friend WithEvents frmERR As System.Windows.Forms.ErrorProvider
    Friend WithEvents bsProduct As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFillEasyOptions As System.Windows.Forms.Button
    Friend WithEvents tb_SpreadVolume As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tb_FixedPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cb_ChangeMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbox_FillMonths As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tb_Co As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TblCoInfoTableAdapter1 As CCP.dsProdDBTableAdapters.tblCoInfoTableAdapter
    Friend WithEvents cBox_Deletecurrent As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ctx_Copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctx_Paste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctx_Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IdtblProdBudDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKtblProductidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtPeriodDescriptorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DecVolumeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DecSalesPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DecGrossIncomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv1_idtblProduct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtProdCdeDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents TxtProdDescDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents txtProdSpec1DataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents txtProdSpec2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtProdSpec3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtCostSortCatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtCostSortItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKidtblCoInfoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_Pic As System.Windows.Forms.DataGridViewImageColumn
End Class
