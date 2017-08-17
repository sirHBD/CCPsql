<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterial
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterial))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabPage_MatActual = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_MatDet = New System.Windows.Forms.TabPage()
        Me.dgvMaterial = New System.Windows.Forms.DataGridView()
        Me.IdtblMaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtMaterialNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtMaterialDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtMatspec1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtMatSpec2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtMatSpec3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TxtMaterialUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DblMaterialPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblMaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMatDB = New CCP.dsMatDB()
        Me.TabPage_Component = New System.Windows.Forms.TabPage()
        Me.lblMaterialID = New System.Windows.Forms.Label()
        Me.lblFormStatus = New System.Windows.Forms.Label()
        Me.dgvComponent = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewComboBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage_MatStan = New System.Windows.Forms.TabPage()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdtblMatLinkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FktblProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FktblMaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.fk_tblMaterial = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgv_dblWasteFactor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DblMatQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DblMatCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tblMatLinkBindingsource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage_MatAct = New System.Windows.Forms.TabPage()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TblMaterialTableAdapter = New CCP.dsMatDBTableAdapters.tblMaterialTableAdapter()
        Me.dgvErr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TblMatLinkTableAdapter = New CCP.dsMatDBTableAdapters.tblMatLinkTableAdapter()
        Me.TblProductTableAdapter1 = New CCP.dsMatDBTableAdapters.tblProductTableAdapter()
        Me.TblProductTableAdapter2 = New CCP.dsProdDBTableAdapters.tblProductTableAdapter()
        Me.DsProdDB1 = New CCP.dsProdDB()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
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
        Me.TblComponentTableAdapter1 = New CCP.dsMatDBTableAdapters.tblComponentTableAdapter()
        Me.dgv3_id_tblMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv3_Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv3_UOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv3_Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv3_CostperUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv3_Cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tblMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_MatDet.SuspendLayout()
        CType(Me.dgvMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMatDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Component.SuspendLayout()
        CType(Me.dgvComponent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage_MatStan.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.tblMatLinkBindingsource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.dgvErr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProdDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage_MatActual
        '
        Me.TabPage_MatActual.BackColor = System.Drawing.Color.Goldenrod
        Me.TabPage_MatActual.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_MatActual.Name = "TabPage_MatActual"
        Me.TabPage_MatActual.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_MatActual.Size = New System.Drawing.Size(1275, 938)
        Me.TabPage_MatActual.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage_MatDet)
        Me.TabControl1.Controls.Add(Me.TabPage_Component)
        Me.TabControl1.Controls.Add(Me.TabPage_MatStan)
        Me.TabControl1.Controls.Add(Me.TabPage_MatAct)
        Me.TabControl1.Location = New System.Drawing.Point(0, 26)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(879, 504)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_MatDet
        '
        Me.TabPage_MatDet.Controls.Add(Me.dgvMaterial)
        Me.TabPage_MatDet.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_MatDet.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage_MatDet.Name = "TabPage_MatDet"
        Me.TabPage_MatDet.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage_MatDet.Size = New System.Drawing.Size(871, 478)
        Me.TabPage_MatDet.TabIndex = 0
        Me.TabPage_MatDet.Text = "Material Detail"
        '
        'dgvMaterial
        '
        Me.dgvMaterial.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvMaterial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMaterial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMaterial.AutoGenerateColumns = False
        Me.dgvMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMaterial.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtblMaterialDataGridViewTextBoxColumn, Me.TxtMaterialNoDataGridViewTextBoxColumn, Me.TxtMaterialDescDataGridViewTextBoxColumn, Me.txtMatspec1, Me.txtMatSpec2, Me.txtMatSpec3, Me.txtType, Me.TxtMaterialUnitDataGridViewTextBoxColumn, Me.DblMaterialPriceDataGridViewTextBoxColumn})
        Me.dgvMaterial.DataSource = Me.TblMaterialBindingSource
        Me.dgvMaterial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMaterial.Location = New System.Drawing.Point(2, 4)
        Me.dgvMaterial.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvMaterial.Name = "dgvMaterial"
        Me.dgvMaterial.RowTemplate.Height = 24
        Me.dgvMaterial.Size = New System.Drawing.Size(869, 470)
        Me.dgvMaterial.TabIndex = 0
        '
        'IdtblMaterialDataGridViewTextBoxColumn
        '
        Me.IdtblMaterialDataGridViewTextBoxColumn.DataPropertyName = "id_tblMaterial"
        Me.IdtblMaterialDataGridViewTextBoxColumn.HeaderText = "id_tblMaterial"
        Me.IdtblMaterialDataGridViewTextBoxColumn.Name = "IdtblMaterialDataGridViewTextBoxColumn"
        Me.IdtblMaterialDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdtblMaterialDataGridViewTextBoxColumn.Visible = False
        '
        'TxtMaterialNoDataGridViewTextBoxColumn
        '
        Me.TxtMaterialNoDataGridViewTextBoxColumn.DataPropertyName = "txtMaterialNo"
        Me.TxtMaterialNoDataGridViewTextBoxColumn.HeaderText = "Material Code/Number"
        Me.TxtMaterialNoDataGridViewTextBoxColumn.Name = "TxtMaterialNoDataGridViewTextBoxColumn"
        '
        'TxtMaterialDescDataGridViewTextBoxColumn
        '
        Me.TxtMaterialDescDataGridViewTextBoxColumn.DataPropertyName = "txtMaterialDesc"
        Me.TxtMaterialDescDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.TxtMaterialDescDataGridViewTextBoxColumn.Name = "TxtMaterialDescDataGridViewTextBoxColumn"
        '
        'txtMatspec1
        '
        Me.txtMatspec1.DataPropertyName = "txtMatspec1"
        Me.txtMatspec1.HeaderText = "Material Specification 1"
        Me.txtMatspec1.Name = "txtMatspec1"
        '
        'txtMatSpec2
        '
        Me.txtMatSpec2.DataPropertyName = "txtMatSpec2"
        Me.txtMatSpec2.HeaderText = "Material Specification 2"
        Me.txtMatSpec2.Name = "txtMatSpec2"
        '
        'txtMatSpec3
        '
        Me.txtMatSpec3.DataPropertyName = "txtMatSpec3"
        Me.txtMatSpec3.HeaderText = "Material Specification 3"
        Me.txtMatSpec3.Name = "txtMatSpec3"
        '
        'txtType
        '
        Me.txtType.DataPropertyName = "txtType"
        Me.txtType.HeaderText = "Component/Material"
        Me.txtType.Items.AddRange(New Object() {"Component", "Material", "Direct"})
        Me.txtType.Name = "txtType"
        Me.txtType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.txtType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TxtMaterialUnitDataGridViewTextBoxColumn
        '
        Me.TxtMaterialUnitDataGridViewTextBoxColumn.DataPropertyName = "txtMaterialUnit"
        Me.TxtMaterialUnitDataGridViewTextBoxColumn.HeaderText = "Unit of Measure"
        Me.TxtMaterialUnitDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Each", "Kilogram", "Gram", "Liter", "Meter", "Cub m", "Sqr m"})
        Me.TxtMaterialUnitDataGridViewTextBoxColumn.Name = "TxtMaterialUnitDataGridViewTextBoxColumn"
        Me.TxtMaterialUnitDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TxtMaterialUnitDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DblMaterialPriceDataGridViewTextBoxColumn
        '
        Me.DblMaterialPriceDataGridViewTextBoxColumn.DataPropertyName = "dblMaterialPrice"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DblMaterialPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DblMaterialPriceDataGridViewTextBoxColumn.HeaderText = "Cost Price per Unit"
        Me.DblMaterialPriceDataGridViewTextBoxColumn.Name = "DblMaterialPriceDataGridViewTextBoxColumn"
        '
        'TblMaterialBindingSource
        '
        Me.TblMaterialBindingSource.DataMember = "tblMaterial"
        Me.TblMaterialBindingSource.DataSource = Me.DsMatDB
        '
        'DsMatDB
        '
        Me.DsMatDB.DataSetName = "dsMatDB"
        Me.DsMatDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage_Component
        '
        Me.TabPage_Component.Controls.Add(Me.lblMaterialID)
        Me.TabPage_Component.Controls.Add(Me.lblFormStatus)
        Me.TabPage_Component.Controls.Add(Me.dgvComponent)
        Me.TabPage_Component.Controls.Add(Me.GroupBox2)
        Me.TabPage_Component.Controls.Add(Me.GroupBox1)
        Me.TabPage_Component.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Component.Name = "TabPage_Component"
        Me.TabPage_Component.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Component.Size = New System.Drawing.Size(871, 478)
        Me.TabPage_Component.TabIndex = 3
        Me.TabPage_Component.Text = "Component Detail"
        Me.TabPage_Component.UseVisualStyleBackColor = True
        '
        'lblMaterialID
        '
        Me.lblMaterialID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMaterialID.AutoSize = True
        Me.lblMaterialID.Location = New System.Drawing.Point(832, 454)
        Me.lblMaterialID.Name = "lblMaterialID"
        Me.lblMaterialID.Size = New System.Drawing.Size(33, 13)
        Me.lblMaterialID.TabIndex = 4
        Me.lblMaterialID.Text = "Insert"
        '
        'lblFormStatus
        '
        Me.lblFormStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFormStatus.AutoSize = True
        Me.lblFormStatus.Location = New System.Drawing.Point(9, 454)
        Me.lblFormStatus.Name = "lblFormStatus"
        Me.lblFormStatus.Size = New System.Drawing.Size(33, 13)
        Me.lblFormStatus.TabIndex = 3
        Me.lblFormStatus.Text = "Insert"
        '
        'dgvComponent
        '
        Me.dgvComponent.AllowUserToAddRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvComponent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvComponent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvComponent.AutoGenerateColumns = False
        Me.dgvComponent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvComponent.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvComponent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComponent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewComboBoxColumn2, Me.DataGridViewComboBoxColumn3, Me.DataGridViewTextBoxColumn7})
        Me.dgvComponent.DataSource = Me.TblMaterialBindingSource
        Me.dgvComponent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvComponent.Location = New System.Drawing.Point(-2, 5)
        Me.dgvComponent.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvComponent.Name = "dgvComponent"
        Me.dgvComponent.RowTemplate.Height = 24
        Me.dgvComponent.Size = New System.Drawing.Size(871, 68)
        Me.dgvComponent.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_tblMaterial"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_tblMaterial"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "txtMaterialNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Material Code/Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "txtMaterialDesc"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "txtMatspec1"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Material Specification 1"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "txtMatSpec2"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Material Specification 2"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "txtMatSpec3"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Material Specification 3"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.DataPropertyName = "txtType"
        Me.DataGridViewComboBoxColumn2.HeaderText = "Component/Material"
        Me.DataGridViewComboBoxColumn2.Items.AddRange(New Object() {"Component", "Material", "Direct"})
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        Me.DataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewComboBoxColumn3
        '
        Me.DataGridViewComboBoxColumn3.DataPropertyName = "txtMaterialUnit"
        Me.DataGridViewComboBoxColumn3.HeaderText = "Unit of Measure"
        Me.DataGridViewComboBoxColumn3.Items.AddRange(New Object() {"Each", "Kilogram", "Gram", "Liter", "Meter", "Cub m", "Sqr m"})
        Me.DataGridViewComboBoxColumn3.Name = "DataGridViewComboBoxColumn3"
        Me.DataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "dblMaterialPrice"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N3"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cost Price per Unit"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.DataGridView3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(859, 292)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recipe"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(268, 119)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Add another"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(214, 28)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(87, 20)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = "1"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Batch size in the above unit of measure"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv3_id_tblMaterial, Me.dgv3_Description, Me.dgv3_UOM, Me.dgv3_Qty, Me.dgv3_CostperUnit, Me.dgv3_Cost, Me.id_tblMaterial})
        Me.DataGridView3.Location = New System.Drawing.Point(349, 60)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(504, 225)
        Me.DataGridView3.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Select all"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.TblMaterialBindingSource
        Me.ListBox1.DisplayMember = "Comboboxvalue"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 60)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(255, 225)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "id_tblMaterial"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(858, 75)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add component and product variables"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Each", "Kilogram", "Gram", "Liter", "Meter", "Cub m", "Sqr m"})
        Me.ComboBox1.Location = New System.Drawing.Point(743, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(740, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Unit of measure"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(561, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Specification 3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(384, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Specification 2"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(564, 42)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(174, 20)
        Me.TextBox4.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(384, 42)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(174, 20)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(204, 42)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(174, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Specification 1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Description"
        '
        'TabPage_MatStan
        '
        Me.TabPage_MatStan.Controls.Add(Me.ComboBox2)
        Me.TabPage_MatStan.Controls.Add(Me.DataGridView2)
        Me.TabPage_MatStan.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_MatStan.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage_MatStan.Name = "TabPage_MatStan"
        Me.TabPage_MatStan.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage_MatStan.Size = New System.Drawing.Size(871, 478)
        Me.TabPage_MatStan.TabIndex = 1
        Me.TabPage_MatStan.Text = "Material Standard"
        Me.TabPage_MatStan.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(6, 21)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(409, 21)
        Me.ComboBox2.TabIndex = 5
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtblMatLinkDataGridViewTextBoxColumn, Me.FktblProductDataGridViewTextBoxColumn, Me.FktblMaterialDataGridViewTextBoxColumn, Me.DataGridViewComboBoxColumn1, Me.Column1, Me.fk_tblMaterial, Me.dgv_dblWasteFactor, Me.DblMatQtyDataGridViewTextBoxColumn, Me.DblMatCostDataGridViewTextBoxColumn})
        Me.DataGridView2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView2.DataSource = Me.tblMatLinkBindingsource
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView2.Location = New System.Drawing.Point(6, 83)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(860, 353)
        Me.DataGridView2.TabIndex = 2
        '
        'IdtblMatLinkDataGridViewTextBoxColumn
        '
        Me.IdtblMatLinkDataGridViewTextBoxColumn.DataPropertyName = "id_tblMatLink"
        Me.IdtblMatLinkDataGridViewTextBoxColumn.HeaderText = "id_tblMatLink"
        Me.IdtblMatLinkDataGridViewTextBoxColumn.Name = "IdtblMatLinkDataGridViewTextBoxColumn"
        Me.IdtblMatLinkDataGridViewTextBoxColumn.Visible = False
        Me.IdtblMatLinkDataGridViewTextBoxColumn.Width = 50
        '
        'FktblProductDataGridViewTextBoxColumn
        '
        Me.FktblProductDataGridViewTextBoxColumn.DataPropertyName = "fk_tblProduct"
        Me.FktblProductDataGridViewTextBoxColumn.HeaderText = "fk_tblProduct"
        Me.FktblProductDataGridViewTextBoxColumn.Name = "FktblProductDataGridViewTextBoxColumn"
        Me.FktblProductDataGridViewTextBoxColumn.Visible = False
        '
        'FktblMaterialDataGridViewTextBoxColumn
        '
        Me.FktblMaterialDataGridViewTextBoxColumn.DataPropertyName = "fk_tblMaterial"
        Me.FktblMaterialDataGridViewTextBoxColumn.DataSource = Me.TblMaterialBindingSource
        Me.FktblMaterialDataGridViewTextBoxColumn.DisplayMember = "txtMaterialDesc"
        Me.FktblMaterialDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.FktblMaterialDataGridViewTextBoxColumn.HeaderText = "Material"
        Me.FktblMaterialDataGridViewTextBoxColumn.Name = "FktblMaterialDataGridViewTextBoxColumn"
        Me.FktblMaterialDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FktblMaterialDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FktblMaterialDataGridViewTextBoxColumn.ValueMember = "id_tblMaterial"
        Me.FktblMaterialDataGridViewTextBoxColumn.Width = 200
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "fk_tblMaterial"
        Me.DataGridViewComboBoxColumn1.DataSource = Me.TblMaterialBindingSource
        Me.DataGridViewComboBoxColumn1.DisplayMember = "txtMatspec1"
        Me.DataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewComboBoxColumn1.HeaderText = "Specification 1"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn1.ValueMember = "id_tblMaterial"
        Me.DataGridViewComboBoxColumn1.Width = 200
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "fk_tblMaterial"
        Me.Column1.DataSource = Me.TblMaterialBindingSource
        Me.Column1.DisplayMember = "txtMatSpec2"
        Me.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Column1.HeaderText = "Specification 2"
        Me.Column1.Name = "Column1"
        Me.Column1.ValueMember = "id_tblMaterial"
        Me.Column1.Width = 200
        '
        'fk_tblMaterial
        '
        Me.fk_tblMaterial.DataPropertyName = "fk_tblMaterial"
        Me.fk_tblMaterial.DataSource = Me.TblMaterialBindingSource
        Me.fk_tblMaterial.DisplayMember = "txtMatSpec3"
        Me.fk_tblMaterial.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.fk_tblMaterial.HeaderText = "Specification 3"
        Me.fk_tblMaterial.Name = "fk_tblMaterial"
        Me.fk_tblMaterial.ValueMember = "id_tblMaterial"
        Me.fk_tblMaterial.Width = 200
        '
        'dgv_dblWasteFactor
        '
        Me.dgv_dblWasteFactor.DataPropertyName = "dblWasteFactor"
        Me.dgv_dblWasteFactor.HeaderText = "Waste Percentage"
        Me.dgv_dblWasteFactor.Name = "dgv_dblWasteFactor"
        '
        'DblMatQtyDataGridViewTextBoxColumn
        '
        Me.DblMatQtyDataGridViewTextBoxColumn.DataPropertyName = "dblMatQty"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DblMatQtyDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.DblMatQtyDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.DblMatQtyDataGridViewTextBoxColumn.Name = "DblMatQtyDataGridViewTextBoxColumn"
        Me.DblMatQtyDataGridViewTextBoxColumn.Width = 75
        '
        'DblMatCostDataGridViewTextBoxColumn
        '
        Me.DblMatCostDataGridViewTextBoxColumn.DataPropertyName = "dblMatCost"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = "0"
        Me.DblMatCostDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.DblMatCostDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.DblMatCostDataGridViewTextBoxColumn.Name = "DblMatCostDataGridViewTextBoxColumn"
        Me.DblMatCostDataGridViewTextBoxColumn.Width = 75
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(283, 70)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(282, 22)
        Me.ToolStripMenuItem1.Text = "Copy All to another product"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(282, 22)
        Me.ToolStripMenuItem2.Text = "Copy Selected Lines to another product"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(282, 22)
        Me.ToolStripMenuItem3.Text = "Delete"
        '
        'tblMatLinkBindingsource
        '
        Me.tblMatLinkBindingsource.DataMember = "tblMatLink"
        Me.tblMatLinkBindingsource.DataSource = Me.DsMatDB
        '
        'TabPage_MatAct
        '
        Me.TabPage_MatAct.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_MatAct.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage_MatAct.Name = "TabPage_MatAct"
        Me.TabPage_MatAct.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage_MatAct.Size = New System.Drawing.Size(871, 478)
        Me.TabPage_MatAct.TabIndex = 2
        Me.TabPage_MatAct.Text = "Material Actual"
        Me.TabPage_MatAct.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(148, 26)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(147, 22)
        Me.ToolStripMenuItem4.Text = "Delete Record"
        '
        'TblMaterialTableAdapter
        '
        Me.TblMaterialTableAdapter.ClearBeforeFill = True
        '
        'dgvErr
        '
        Me.dgvErr.ContainerControl = Me
        '
        'TblMatLinkTableAdapter
        '
        Me.TblMatLinkTableAdapter.ClearBeforeFill = True
        '
        'TblProductTableAdapter1
        '
        Me.TblProductTableAdapter1.ClearBeforeFill = True
        '
        'TblProductTableAdapter2
        '
        Me.TblProductTableAdapter2.ClearBeforeFill = True
        '
        'DsProdDB1
        '
        Me.DsProdDB1.DataSetName = "dsProdDB"
        Me.DsProdDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.ToolStripButton2, Me.ToolStripSeparator4, Me.ToolStripButton3, Me.ToolStripSeparator5, Me.ToolStripButton4, Me.ToolStripSeparator6, Me.ToolStripButton5, Me.ToolStripSeparator7, Me.ToolStripButton6, Me.ToolStripSeparator8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(881, 26)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.AutoSize = False
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
        Me.ToolStripSeparator3.AutoSize = False
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
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(79, 23)
        Me.ToolStripButton6.Text = "Close Form"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 26)
        '
        'TblComponentTableAdapter1
        '
        Me.TblComponentTableAdapter1.ClearBeforeFill = True
        '
        'dgv3_id_tblMaterial
        '
        Me.dgv3_id_tblMaterial.HeaderText = "id"
        Me.dgv3_id_tblMaterial.Name = "dgv3_id_tblMaterial"
        Me.dgv3_id_tblMaterial.Visible = False
        '
        'dgv3_Description
        '
        Me.dgv3_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgv3_Description.HeaderText = "Description"
        Me.dgv3_Description.Name = "dgv3_Description"
        Me.dgv3_Description.ReadOnly = True
        Me.dgv3_Description.Width = 85
        '
        'dgv3_UOM
        '
        Me.dgv3_UOM.HeaderText = "Unit of Measure"
        Me.dgv3_UOM.Name = "dgv3_UOM"
        Me.dgv3_UOM.ReadOnly = True
        '
        'dgv3_Qty
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.Format = "N4"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.dgv3_Qty.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv3_Qty.HeaderText = "Quantity"
        Me.dgv3_Qty.Name = "dgv3_Qty"
        '
        'dgv3_CostperUnit
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N4"
        DataGridViewCellStyle6.NullValue = "0"
        Me.dgv3_CostperUnit.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv3_CostperUnit.HeaderText = "Cost per Unit"
        Me.dgv3_CostperUnit.Name = "dgv3_CostperUnit"
        Me.dgv3_CostperUnit.ReadOnly = True
        '
        'dgv3_Cost
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N4"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.dgv3_Cost.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgv3_Cost.HeaderText = "Cost"
        Me.dgv3_Cost.Name = "dgv3_Cost"
        Me.dgv3_Cost.ReadOnly = True
        '
        'id_tblMaterial
        '
        Me.id_tblMaterial.HeaderText = "id_tblMaterial"
        Me.id_tblMaterial.Name = "id_tblMaterial"
        Me.id_tblMaterial.Visible = False
        '
        'frmMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 529)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMaterial"
        Me.Text = "frmMaterial"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_MatDet.ResumeLayout(False)
        CType(Me.dgvMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMatDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Component.ResumeLayout(False)
        Me.TabPage_Component.PerformLayout()
        CType(Me.dgvComponent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage_MatStan.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.tblMatLinkBindingsource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.dgvErr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProdDB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabPage_MatActual As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_MatDet As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_MatStan As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_MatAct As System.Windows.Forms.TabPage
    Friend WithEvents dgvMaterial As System.Windows.Forms.DataGridView
    Friend WithEvents DsMatDB As CCP.dsMatDB
    Friend WithEvents TblMaterialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMaterialTableAdapter As CCP.dsMatDBTableAdapters.tblMaterialTableAdapter
    Friend WithEvents dgvErr As System.Windows.Forms.ErrorProvider
    Friend WithEvents TblMatLinkTableAdapter As CCP.dsMatDBTableAdapters.tblMatLinkTableAdapter
    Friend WithEvents tblMatLinkBindingsource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TblProductTableAdapter1 As CCP.dsMatDBTableAdapters.tblProductTableAdapter
    Friend WithEvents TblProductTableAdapter2 As CCP.dsProdDBTableAdapters.tblProductTableAdapter
    Friend WithEvents DsProdDB1 As CCP.dsProdDB
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdtblMatLinkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FktblProductDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FktblMaterialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents fk_tblMaterial As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgv_dblWasteFactor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DblMatQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DblMatCostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage_Component As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvComponent As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IdtblMaterialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtMaterialNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtMaterialDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtMatspec1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtMatSpec2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtMatSpec3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TxtMaterialUnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DblMaterialPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblComponentTableAdapter1 As CCP.dsMatDBTableAdapters.tblComponentTableAdapter
    Friend WithEvents lblFormStatus As System.Windows.Forms.Label
    Friend WithEvents lblMaterialID As System.Windows.Forms.Label
    Friend WithEvents dgv3_id_tblMaterial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv3_Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv3_UOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv3_Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv3_CostperUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv3_Cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tblMaterial As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
