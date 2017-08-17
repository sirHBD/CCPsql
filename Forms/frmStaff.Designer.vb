<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaff))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_LabActivities = New System.Windows.Forms.TabPage()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.IdtblActivityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtActNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtActDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numSortOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKidtblelementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TblActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsActivityDB1 = New CCP.dsActivityDB()
        Me.TabPage_LabOpsStaff = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdtblStaffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtEmpNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtEmpNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtEmpCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDepartment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtJobTitle = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblJobTitleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProdDB = New CCP.dsProdDB()
        Me.TxtRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dblCoBenefit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtRateDescriptorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DblHourperYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DblRatePerHourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage_LabStd = New System.Windows.Forms.TabPage()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.dgvProductLink = New System.Windows.Forms.DataGridView()
        Me.fk_tblDept = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblDeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FktblElementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblElementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Activity = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgv_txtLabourParameter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Staff_Member = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtblProdLinkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FktblProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FktblOperationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtLabourParameter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DblValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dblAdjValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtValueDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DblFreqDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dblLabourCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dblAdjCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_fk_tblActivity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TblProdLinkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_JobTitle = New System.Windows.Forms.DataGridView()
        Me.IdtblJobTitlesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtJobTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKtblDeptIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IsConstraintDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        Me.TblStaffTableAdapter1 = New CCP.dsProdDBTableAdapters.tblStaffTableAdapter()
        Me.TblCoInfoTableAdapter1 = New CCP.dsProdDBTableAdapters.tblCoInfoTableAdapter()
        Me.DsProdDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProductTableAdapter = New CCP.dsProdDBTableAdapters.tblProductTableAdapter()
        Me.TblProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProdLinkTableAdapter = New CCP.dsProdDBTableAdapters.tblProdLinkTableAdapter()
        Me.TblActivityTableAdapter2 = New CCP.dsActivityDBTableAdapters.tblActivityTableAdapter()
        Me.TblDeptTableAdapter1 = New CCP.dsActivityDBTableAdapters.tblDeptTableAdapter()
        Me.TblElementTableAdapter2 = New CCP.dsActivityDBTableAdapters.tblElementTableAdapter()
        Me.LstStaffGroupsTableAdapter1 = New CCP.dsProdDBTableAdapters.lstStaffGroupsTableAdapter()
        Me.TblJobTitleTableAdapter1 = New CCP.dsProdDBTableAdapters.tblJobTitleTableAdapter()
        Me.TblComponentTableAdapter1 = New CCP.dsProdDBTableAdapters.tblComponentTableAdapter()
        Me.TblMaterialTableAdapter1 = New CCP.dsProdDBTableAdapters.tblMaterialTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_LabActivities.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsActivityDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_LabOpsStaff.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobTitleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProdDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_LabStd.SuspendLayout()
        CType(Me.dgvProductLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblElementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.TblProdLinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_JobTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DsProdDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage_LabActivities)
        Me.TabControl1.Controls.Add(Me.TabPage_LabOpsStaff)
        Me.TabControl1.Controls.Add(Me.TabPage_LabStd)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(940, 390)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage_LabActivities
        '
        Me.TabPage_LabActivities.Controls.Add(Me.TreeView1)
        Me.TabPage_LabActivities.Controls.Add(Me.DataGridView3)
        Me.TabPage_LabActivities.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_LabActivities.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage_LabActivities.Name = "TabPage_LabActivities"
        Me.TabPage_LabActivities.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage_LabActivities.Size = New System.Drawing.Size(932, 364)
        Me.TabPage_LabActivities.TabIndex = 1
        Me.TabPage_LabActivities.Text = "Activities"
        Me.TabPage_LabActivities.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(14, 13)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(2)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(425, 341)
        Me.TreeView1.TabIndex = 2
        '
        'DataGridView3
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtblActivityDataGridViewTextBoxColumn, Me.TxtActNoDataGridViewTextBoxColumn, Me.TxtActDescDataGridViewTextBoxColumn, Me.numSortOrder, Me.FKidtblelementDataGridViewTextBoxColumn})
        Me.DataGridView3.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView3.DataSource = Me.TblActivityBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(442, 13)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(486, 340)
        Me.DataGridView3.TabIndex = 1
        '
        'IdtblActivityDataGridViewTextBoxColumn
        '
        Me.IdtblActivityDataGridViewTextBoxColumn.DataPropertyName = "id_tblActivity"
        Me.IdtblActivityDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdtblActivityDataGridViewTextBoxColumn.Name = "IdtblActivityDataGridViewTextBoxColumn"
        Me.IdtblActivityDataGridViewTextBoxColumn.Visible = False
        Me.IdtblActivityDataGridViewTextBoxColumn.Width = 50
        '
        'TxtActNoDataGridViewTextBoxColumn
        '
        Me.TxtActNoDataGridViewTextBoxColumn.DataPropertyName = "txtActNo"
        Me.TxtActNoDataGridViewTextBoxColumn.FillWeight = 75.0!
        Me.TxtActNoDataGridViewTextBoxColumn.HeaderText = "Activity No"
        Me.TxtActNoDataGridViewTextBoxColumn.Name = "TxtActNoDataGridViewTextBoxColumn"
        '
        'TxtActDescDataGridViewTextBoxColumn
        '
        Me.TxtActDescDataGridViewTextBoxColumn.DataPropertyName = "txtActDesc"
        Me.TxtActDescDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.TxtActDescDataGridViewTextBoxColumn.Name = "TxtActDescDataGridViewTextBoxColumn"
        Me.TxtActDescDataGridViewTextBoxColumn.Width = 250
        '
        'numSortOrder
        '
        Me.numSortOrder.DataPropertyName = "numSortOrder"
        Me.numSortOrder.HeaderText = "Sort Order"
        Me.numSortOrder.Name = "numSortOrder"
        '
        'FKidtblelementDataGridViewTextBoxColumn
        '
        Me.FKidtblelementDataGridViewTextBoxColumn.DataPropertyName = "FK_idtblelement"
        Me.FKidtblelementDataGridViewTextBoxColumn.HeaderText = "FK_idtblelement"
        Me.FKidtblelementDataGridViewTextBoxColumn.Name = "FKidtblelementDataGridViewTextBoxColumn"
        Me.FKidtblelementDataGridViewTextBoxColumn.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(191, 48)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(190, 22)
        Me.ToolStripMenuItem2.Text = "Edit selected record"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(190, 22)
        Me.ToolStripMenuItem1.Text = "Delete selected record"
        '
        'TblActivityBindingSource
        '
        Me.TblActivityBindingSource.DataMember = "tblActivity"
        Me.TblActivityBindingSource.DataSource = Me.DsActivityDB1
        Me.TblActivityBindingSource.Sort = "numSortORder"
        '
        'DsActivityDB1
        '
        Me.DsActivityDB1.DataSetName = "dsActivityDB"
        Me.DsActivityDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage_LabOpsStaff
        '
        Me.TabPage_LabOpsStaff.Controls.Add(Me.DataGridView1)
        Me.TabPage_LabOpsStaff.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_LabOpsStaff.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage_LabOpsStaff.Name = "TabPage_LabOpsStaff"
        Me.TabPage_LabOpsStaff.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage_LabOpsStaff.Size = New System.Drawing.Size(932, 364)
        Me.TabPage_LabOpsStaff.TabIndex = 0
        Me.TabPage_LabOpsStaff.Text = "Operational Staff"
        Me.TabPage_LabOpsStaff.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtblStaffDataGridViewTextBoxColumn, Me.TxtEmpNoDataGridViewTextBoxColumn, Me.TxtEmpNameDataGridViewTextBoxColumn, Me.txtEmpCategory, Me.txtDepartment, Me.txtJobTitle, Me.TxtRateDataGridViewTextBoxColumn, Me.dblCoBenefit, Me.TxtRateDescriptorDataGridViewTextBoxColumn, Me.DblHourperYearDataGridViewTextBoxColumn, Me.DblRatePerHourDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblStaffBindingSource
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(4, 3)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(880, 360)
        Me.DataGridView1.TabIndex = 1
        '
        'IdtblStaffDataGridViewTextBoxColumn
        '
        Me.IdtblStaffDataGridViewTextBoxColumn.DataPropertyName = "id_tblStaff"
        Me.IdtblStaffDataGridViewTextBoxColumn.HeaderText = "id_tblStaff"
        Me.IdtblStaffDataGridViewTextBoxColumn.Name = "IdtblStaffDataGridViewTextBoxColumn"
        Me.IdtblStaffDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdtblStaffDataGridViewTextBoxColumn.Visible = False
        '
        'TxtEmpNoDataGridViewTextBoxColumn
        '
        Me.TxtEmpNoDataGridViewTextBoxColumn.DataPropertyName = "txtEmpNo"
        Me.TxtEmpNoDataGridViewTextBoxColumn.HeaderText = "Emp No"
        Me.TxtEmpNoDataGridViewTextBoxColumn.Name = "TxtEmpNoDataGridViewTextBoxColumn"
        Me.TxtEmpNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtEmpNameDataGridViewTextBoxColumn
        '
        Me.TxtEmpNameDataGridViewTextBoxColumn.DataPropertyName = "txtEmpName"
        Me.TxtEmpNameDataGridViewTextBoxColumn.HeaderText = "Name / Surname"
        Me.TxtEmpNameDataGridViewTextBoxColumn.Name = "TxtEmpNameDataGridViewTextBoxColumn"
        Me.TxtEmpNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.TxtEmpNameDataGridViewTextBoxColumn.Width = 200
        '
        'txtEmpCategory
        '
        Me.txtEmpCategory.DataPropertyName = "txtEmpCategory"
        Me.txtEmpCategory.HeaderText = "Staff Grade"
        Me.txtEmpCategory.Name = "txtEmpCategory"
        Me.txtEmpCategory.ReadOnly = True
        Me.txtEmpCategory.Width = 125
        '
        'txtDepartment
        '
        Me.txtDepartment.DataPropertyName = "txtDepartment"
        Me.txtDepartment.HeaderText = "Department"
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.ReadOnly = True
        '
        'txtJobTitle
        '
        Me.txtJobTitle.DataPropertyName = "txtJobTitle"
        Me.txtJobTitle.DataSource = Me.TblJobTitleBindingSource
        Me.txtJobTitle.DisplayMember = "txtJobTitle"
        Me.txtJobTitle.HeaderText = "Job Title"
        Me.txtJobTitle.Name = "txtJobTitle"
        Me.txtJobTitle.ReadOnly = True
        Me.txtJobTitle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.txtJobTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TblJobTitleBindingSource
        '
        Me.TblJobTitleBindingSource.DataMember = "tblJobTitle"
        Me.TblJobTitleBindingSource.DataSource = Me.DsProdDB
        '
        'DsProdDB
        '
        Me.DsProdDB.DataSetName = "dsProdDB"
        Me.DsProdDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtRateDataGridViewTextBoxColumn
        '
        Me.TxtRateDataGridViewTextBoxColumn.DataPropertyName = "dblRate"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N3"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.TxtRateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.TxtRateDataGridViewTextBoxColumn.HeaderText = "Rate"
        Me.TxtRateDataGridViewTextBoxColumn.Name = "TxtRateDataGridViewTextBoxColumn"
        Me.TxtRateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'dblCoBenefit
        '
        Me.dblCoBenefit.DataPropertyName = "dblCoBenefit"
        Me.dblCoBenefit.HeaderText = "Company Benefit"
        Me.dblCoBenefit.Name = "dblCoBenefit"
        Me.dblCoBenefit.ReadOnly = True
        '
        'TxtRateDescriptorDataGridViewTextBoxColumn
        '
        Me.TxtRateDescriptorDataGridViewTextBoxColumn.DataPropertyName = "txtRateDescriptor"
        Me.TxtRateDescriptorDataGridViewTextBoxColumn.HeaderText = "Per What"
        Me.TxtRateDescriptorDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Month", "Week", "Day", "Hour"})
        Me.TxtRateDescriptorDataGridViewTextBoxColumn.Name = "TxtRateDescriptorDataGridViewTextBoxColumn"
        Me.TxtRateDescriptorDataGridViewTextBoxColumn.ReadOnly = True
        Me.TxtRateDescriptorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TxtRateDescriptorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DblHourperYearDataGridViewTextBoxColumn
        '
        Me.DblHourperYearDataGridViewTextBoxColumn.DataPropertyName = "dblHourperYear"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N3"
        Me.DblHourperYearDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.DblHourperYearDataGridViewTextBoxColumn.HeaderText = "dblHourperYear"
        Me.DblHourperYearDataGridViewTextBoxColumn.Name = "DblHourperYearDataGridViewTextBoxColumn"
        Me.DblHourperYearDataGridViewTextBoxColumn.ReadOnly = True
        Me.DblHourperYearDataGridViewTextBoxColumn.Visible = False
        '
        'DblRatePerHourDataGridViewTextBoxColumn
        '
        Me.DblRatePerHourDataGridViewTextBoxColumn.DataPropertyName = "dblRatePerHour"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DblRatePerHourDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.DblRatePerHourDataGridViewTextBoxColumn.HeaderText = "Calc Rate per Hour"
        Me.DblRatePerHourDataGridViewTextBoxColumn.Name = "DblRatePerHourDataGridViewTextBoxColumn"
        Me.DblRatePerHourDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblStaffBindingSource
        '
        Me.TblStaffBindingSource.DataMember = "tblStaff"
        Me.TblStaffBindingSource.DataSource = Me.DsProdDB
        '
        'TabPage_LabStd
        '
        Me.TabPage_LabStd.Controls.Add(Me.RadioButton2)
        Me.TabPage_LabStd.Controls.Add(Me.RadioButton1)
        Me.TabPage_LabStd.Controls.Add(Me.dgvProductLink)
        Me.TabPage_LabStd.Controls.Add(Me.ComboBox2)
        Me.TabPage_LabStd.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_LabStd.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage_LabStd.Name = "TabPage_LabStd"
        Me.TabPage_LabStd.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage_LabStd.Size = New System.Drawing.Size(932, 364)
        Me.TabPage_LabStd.TabIndex = 2
        Me.TabPage_LabStd.Text = "Labour Standard"
        Me.TabPage_LabStd.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(123, 17)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Component"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(8, 17)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Product"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'dgvProductLink
        '
        Me.dgvProductLink.AllowUserToAddRows = False
        Me.dgvProductLink.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProductLink.AutoGenerateColumns = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductLink.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvProductLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductLink.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fk_tblDept, Me.FktblElementDataGridViewTextBoxColumn, Me.Activity, Me.dgv_txtLabourParameter, Me.Staff_Member, Me.IdtblProdLinkDataGridViewTextBoxColumn, Me.FktblProductDataGridViewTextBoxColumn, Me.FktblOperationDataGridViewTextBoxColumn, Me.txtLabourParameter, Me.DblValueDataGridViewTextBoxColumn, Me.dblAdjValue, Me.TxtValueDescDataGridViewTextBoxColumn, Me.DblFreqDataGridViewTextBoxColumn, Me.dblLabourCost, Me.dblAdjCost, Me.dgv_fk_tblActivity})
        Me.dgvProductLink.ContextMenuStrip = Me.ContextMenuStrip2
        Me.dgvProductLink.DataSource = Me.TblProdLinkBindingSource
        Me.dgvProductLink.Location = New System.Drawing.Point(6, 85)
        Me.dgvProductLink.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvProductLink.Name = "dgvProductLink"
        Me.dgvProductLink.ReadOnly = True
        Me.dgvProductLink.RowTemplate.Height = 24
        Me.dgvProductLink.Size = New System.Drawing.Size(906, 268)
        Me.dgvProductLink.TabIndex = 5
        '
        'fk_tblDept
        '
        Me.fk_tblDept.DataPropertyName = "fk_tblDept"
        Me.fk_tblDept.DataSource = Me.TblDeptBindingSource
        Me.fk_tblDept.DisplayMember = "txtDepName"
        Me.fk_tblDept.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.fk_tblDept.HeaderText = "Department"
        Me.fk_tblDept.Name = "fk_tblDept"
        Me.fk_tblDept.ReadOnly = True
        Me.fk_tblDept.ValueMember = "idtblDept"
        '
        'TblDeptBindingSource
        '
        Me.TblDeptBindingSource.DataMember = "tblDept"
        Me.TblDeptBindingSource.DataSource = Me.DsActivityDB1
        '
        'FktblElementDataGridViewTextBoxColumn
        '
        Me.FktblElementDataGridViewTextBoxColumn.DataPropertyName = "fk_tblElement"
        Me.FktblElementDataGridViewTextBoxColumn.DataSource = Me.TblElementBindingSource
        Me.FktblElementDataGridViewTextBoxColumn.DisplayMember = "txtElementDesc"
        Me.FktblElementDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.FktblElementDataGridViewTextBoxColumn.HeaderText = "Operation"
        Me.FktblElementDataGridViewTextBoxColumn.Name = "FktblElementDataGridViewTextBoxColumn"
        Me.FktblElementDataGridViewTextBoxColumn.ReadOnly = True
        Me.FktblElementDataGridViewTextBoxColumn.ValueMember = "id_tblElement"
        Me.FktblElementDataGridViewTextBoxColumn.Width = 125
        '
        'TblElementBindingSource
        '
        Me.TblElementBindingSource.DataMember = "tblElement"
        Me.TblElementBindingSource.DataSource = Me.DsActivityDB1
        '
        'Activity
        '
        Me.Activity.DataPropertyName = "fk_tblActivity"
        Me.Activity.DataSource = Me.TblActivityBindingSource
        DataGridViewCellStyle8.NullValue = "N/A"
        Me.Activity.DefaultCellStyle = DataGridViewCellStyle8
        Me.Activity.DisplayMember = "txtActDesc"
        Me.Activity.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Activity.HeaderText = "Activity"
        Me.Activity.Name = "Activity"
        Me.Activity.ReadOnly = True
        Me.Activity.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Activity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Activity.ValueMember = "id_tblActivity"
        '
        'dgv_txtLabourParameter
        '
        Me.dgv_txtLabourParameter.DataPropertyName = "txtLabourParameter"
        Me.dgv_txtLabourParameter.HeaderText = "Staff Type"
        Me.dgv_txtLabourParameter.Name = "dgv_txtLabourParameter"
        Me.dgv_txtLabourParameter.ReadOnly = True
        Me.dgv_txtLabourParameter.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_txtLabourParameter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Staff_Member
        '
        Me.Staff_Member.HeaderText = "Staff Member"
        Me.Staff_Member.Name = "Staff_Member"
        Me.Staff_Member.ReadOnly = True
        '
        'IdtblProdLinkDataGridViewTextBoxColumn
        '
        Me.IdtblProdLinkDataGridViewTextBoxColumn.DataPropertyName = "id_tblProdLink"
        Me.IdtblProdLinkDataGridViewTextBoxColumn.HeaderText = "id_tblProdLink"
        Me.IdtblProdLinkDataGridViewTextBoxColumn.Name = "IdtblProdLinkDataGridViewTextBoxColumn"
        Me.IdtblProdLinkDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdtblProdLinkDataGridViewTextBoxColumn.Visible = False
        '
        'FktblProductDataGridViewTextBoxColumn
        '
        Me.FktblProductDataGridViewTextBoxColumn.DataPropertyName = "fk_tblProduct"
        Me.FktblProductDataGridViewTextBoxColumn.HeaderText = "fk_tblProduct"
        Me.FktblProductDataGridViewTextBoxColumn.Name = "FktblProductDataGridViewTextBoxColumn"
        Me.FktblProductDataGridViewTextBoxColumn.ReadOnly = True
        Me.FktblProductDataGridViewTextBoxColumn.Visible = False
        '
        'FktblOperationDataGridViewTextBoxColumn
        '
        Me.FktblOperationDataGridViewTextBoxColumn.DataPropertyName = "fk_tblOperation"
        Me.FktblOperationDataGridViewTextBoxColumn.HeaderText = "fk_tblOperation"
        Me.FktblOperationDataGridViewTextBoxColumn.Name = "FktblOperationDataGridViewTextBoxColumn"
        Me.FktblOperationDataGridViewTextBoxColumn.ReadOnly = True
        Me.FktblOperationDataGridViewTextBoxColumn.Visible = False
        '
        'txtLabourParameter
        '
        Me.txtLabourParameter.DataPropertyName = "txtLabourParameter"
        Me.txtLabourParameter.HeaderText = "txtLabourParameter"
        Me.txtLabourParameter.Name = "txtLabourParameter"
        Me.txtLabourParameter.ReadOnly = True
        Me.txtLabourParameter.Visible = False
        '
        'DblValueDataGridViewTextBoxColumn
        '
        Me.DblValueDataGridViewTextBoxColumn.DataPropertyName = "dblValue"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "n4"
        Me.DblValueDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.DblValueDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.DblValueDataGridViewTextBoxColumn.Name = "DblValueDataGridViewTextBoxColumn"
        Me.DblValueDataGridViewTextBoxColumn.ReadOnly = True
        Me.DblValueDataGridViewTextBoxColumn.Width = 75
        '
        'dblAdjValue
        '
        Me.dblAdjValue.DataPropertyName = "dblAdjValue"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N4"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.dblAdjValue.DefaultCellStyle = DataGridViewCellStyle10
        Me.dblAdjValue.HeaderText = "Adj Time"
        Me.dblAdjValue.Name = "dblAdjValue"
        Me.dblAdjValue.ReadOnly = True
        Me.dblAdjValue.Width = 75
        '
        'TxtValueDescDataGridViewTextBoxColumn
        '
        Me.TxtValueDescDataGridViewTextBoxColumn.DataPropertyName = "txtValueDesc"
        DataGridViewCellStyle11.Format = "n4"
        Me.TxtValueDescDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.TxtValueDescDataGridViewTextBoxColumn.HeaderText = "Time Unit"
        Me.TxtValueDescDataGridViewTextBoxColumn.Name = "TxtValueDescDataGridViewTextBoxColumn"
        Me.TxtValueDescDataGridViewTextBoxColumn.ReadOnly = True
        Me.TxtValueDescDataGridViewTextBoxColumn.Width = 75
        '
        'DblFreqDataGridViewTextBoxColumn
        '
        Me.DblFreqDataGridViewTextBoxColumn.DataPropertyName = "dblFreq"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.NullValue = "n4"
        Me.DblFreqDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.DblFreqDataGridViewTextBoxColumn.HeaderText = "Frequency"
        Me.DblFreqDataGridViewTextBoxColumn.Name = "DblFreqDataGridViewTextBoxColumn"
        Me.DblFreqDataGridViewTextBoxColumn.ReadOnly = True
        Me.DblFreqDataGridViewTextBoxColumn.Width = 75
        '
        'dblLabourCost
        '
        Me.dblLabourCost.DataPropertyName = "dblLabourCost"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "n2"
        Me.dblLabourCost.DefaultCellStyle = DataGridViewCellStyle13
        Me.dblLabourCost.HeaderText = "Labour Cost"
        Me.dblLabourCost.Name = "dblLabourCost"
        Me.dblLabourCost.ReadOnly = True
        Me.dblLabourCost.Width = 75
        '
        'dblAdjCost
        '
        Me.dblAdjCost.DataPropertyName = "dblAdjCost"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.dblAdjCost.DefaultCellStyle = DataGridViewCellStyle14
        Me.dblAdjCost.HeaderText = "Adj Cost"
        Me.dblAdjCost.Name = "dblAdjCost"
        Me.dblAdjCost.ReadOnly = True
        Me.dblAdjCost.Width = 75
        '
        'dgv_fk_tblActivity
        '
        Me.dgv_fk_tblActivity.DataPropertyName = "fk_tblActivity"
        Me.dgv_fk_tblActivity.HeaderText = "fk_tblActivity"
        Me.dgv_fk_tblActivity.Name = "dgv_fk_tblActivity"
        Me.dgv_fk_tblActivity.ReadOnly = True
        Me.dgv_fk_tblActivity.Visible = False
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(221, 70)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(220, 22)
        Me.ToolStripMenuItem3.Text = "Copy all to another product"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(220, 22)
        Me.ToolStripMenuItem4.Text = "Copy selected lines "
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(220, 22)
        Me.ToolStripMenuItem5.Text = "Delete selected lines"
        '
        'TblProdLinkBindingSource
        '
        Me.TblProdLinkBindingSource.DataMember = "tblProdLink"
        Me.TblProdLinkBindingSource.DataSource = Me.DsProdDB
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(6, 49)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(610, 21)
        Me.ComboBox2.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_JobTitle)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(932, 364)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Job/Task descriptions"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_JobTitle
        '
        Me.dgv_JobTitle.AllowUserToDeleteRows = False
        Me.dgv_JobTitle.AutoGenerateColumns = False
        Me.dgv_JobTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_JobTitle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtblJobTitlesDataGridViewTextBoxColumn, Me.TxtJobTitleDataGridViewTextBoxColumn, Me.FKtblDeptIDDataGridViewTextBoxColumn, Me.IsConstraintDataGridViewCheckBoxColumn})
        Me.dgv_JobTitle.DataSource = Me.TblJobTitleBindingSource
        Me.dgv_JobTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_JobTitle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_JobTitle.Location = New System.Drawing.Point(2, 2)
        Me.dgv_JobTitle.Name = "dgv_JobTitle"
        Me.dgv_JobTitle.Size = New System.Drawing.Size(928, 360)
        Me.dgv_JobTitle.TabIndex = 0
        '
        'IdtblJobTitlesDataGridViewTextBoxColumn
        '
        Me.IdtblJobTitlesDataGridViewTextBoxColumn.DataPropertyName = "id_tblJobTitles"
        Me.IdtblJobTitlesDataGridViewTextBoxColumn.HeaderText = "id_tblJobTitles"
        Me.IdtblJobTitlesDataGridViewTextBoxColumn.Name = "IdtblJobTitlesDataGridViewTextBoxColumn"
        Me.IdtblJobTitlesDataGridViewTextBoxColumn.Visible = False
        '
        'TxtJobTitleDataGridViewTextBoxColumn
        '
        Me.TxtJobTitleDataGridViewTextBoxColumn.DataPropertyName = "txtJobTitle"
        Me.TxtJobTitleDataGridViewTextBoxColumn.HeaderText = "Job title"
        Me.TxtJobTitleDataGridViewTextBoxColumn.Name = "TxtJobTitleDataGridViewTextBoxColumn"
        '
        'FKtblDeptIDDataGridViewTextBoxColumn
        '
        Me.FKtblDeptIDDataGridViewTextBoxColumn.DataPropertyName = "FK_tblDeptID"
        Me.FKtblDeptIDDataGridViewTextBoxColumn.DataSource = Me.TblDeptBindingSource
        Me.FKtblDeptIDDataGridViewTextBoxColumn.DisplayMember = "txtDepName"
        Me.FKtblDeptIDDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.FKtblDeptIDDataGridViewTextBoxColumn.Name = "FKtblDeptIDDataGridViewTextBoxColumn"
        Me.FKtblDeptIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FKtblDeptIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FKtblDeptIDDataGridViewTextBoxColumn.ValueMember = "idtblDept"
        '
        'IsConstraintDataGridViewCheckBoxColumn
        '
        Me.IsConstraintDataGridViewCheckBoxColumn.DataPropertyName = "IsConstraint"
        Me.IsConstraintDataGridViewCheckBoxColumn.HeaderText = "Constraint job title"
        Me.IsConstraintDataGridViewCheckBoxColumn.Name = "IsConstraintDataGridViewCheckBoxColumn"
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
        Me.ToolStrip1.Size = New System.Drawing.Size(951, 26)
        Me.ToolStrip1.TabIndex = 14
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
        'TblStaffTableAdapter1
        '
        Me.TblStaffTableAdapter1.ClearBeforeFill = True
        '
        'TblCoInfoTableAdapter1
        '
        Me.TblCoInfoTableAdapter1.ClearBeforeFill = True
        '
        'DsProdDBBindingSource
        '
        Me.DsProdDBBindingSource.DataSource = Me.DsProdDB
        Me.DsProdDBBindingSource.Position = 0
        '
        'TblProductTableAdapter
        '
        Me.TblProductTableAdapter.ClearBeforeFill = True
        '
        'TblProductBindingSource
        '
        Me.TblProductBindingSource.DataMember = "tblProduct"
        Me.TblProductBindingSource.DataSource = Me.DsProdDB
        '
        'TblProdLinkTableAdapter
        '
        Me.TblProdLinkTableAdapter.ClearBeforeFill = True
        '
        'TblActivityTableAdapter2
        '
        Me.TblActivityTableAdapter2.ClearBeforeFill = True
        '
        'TblDeptTableAdapter1
        '
        Me.TblDeptTableAdapter1.ClearBeforeFill = True
        '
        'TblElementTableAdapter2
        '
        Me.TblElementTableAdapter2.ClearBeforeFill = True
        '
        'LstStaffGroupsTableAdapter1
        '
        Me.LstStaffGroupsTableAdapter1.ClearBeforeFill = True
        '
        'TblJobTitleTableAdapter1
        '
        Me.TblJobTitleTableAdapter1.ClearBeforeFill = True
        '
        'TblComponentTableAdapter1
        '
        Me.TblComponentTableAdapter1.ClearBeforeFill = True
        '
        'TblMaterialTableAdapter1
        '
        Me.TblMaterialTableAdapter1.ClearBeforeFill = True
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 425)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Operational Staff"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_LabActivities.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsActivityDB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_LabOpsStaff.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobTitleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProdDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_LabStd.ResumeLayout(False)
        Me.TabPage_LabStd.PerformLayout()
        CType(Me.dgvProductLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblElementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.TblProdLinkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_JobTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DsProdDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TblStaffTableAdapter1 As CCP.dsProdDBTableAdapters.tblStaffTableAdapter
    Friend WithEvents TblStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsProdDB As CCP.dsProdDB
    Friend WithEvents TblCoInfoTableAdapter1 As CCP.dsProdDBTableAdapters.tblCoInfoTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_LabOpsStaff As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage_LabActivities As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_LabStd As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents TblElementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProductTableAdapter As CCP.dsProdDBTableAdapters.tblProductTableAdapter
    Friend WithEvents TblProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProdLinkTableAdapter As CCP.dsProdDBTableAdapters.tblProdLinkTableAdapter
    Friend WithEvents TblProdLinkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents dgvProductLink As System.Windows.Forms.DataGridView
    Friend WithEvents TblActivityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsProdDBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DsActivityDB1 As CCP.dsActivityDB
    Friend WithEvents TblActivityTableAdapter2 As CCP.dsActivityDBTableAdapters.tblActivityTableAdapter
    Friend WithEvents TblDeptTableAdapter1 As CCP.dsActivityDBTableAdapters.tblDeptTableAdapter
    Friend WithEvents TblElementTableAdapter2 As CCP.dsActivityDBTableAdapters.tblElementTableAdapter
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents TxtActValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtActDescriptorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TblDeptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LstStaffGroupsTableAdapter1 As CCP.dsProdDBTableAdapters.lstStaffGroupsTableAdapter
    Friend WithEvents IdtblActivityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtActNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtActDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numSortOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKidtblelementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fk_tblDept As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FktblElementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Activity As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgv_txtLabourParameter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Staff_Member As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdtblProdLinkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FktblProductDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FktblOperationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtLabourParameter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DblValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dblAdjValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtValueDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DblFreqDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dblLabourCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dblAdjCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_fk_tblActivity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblJobTitleTableAdapter1 As CCP.dsProdDBTableAdapters.tblJobTitleTableAdapter
    Friend WithEvents IdtblStaffDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtEmpNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtEmpNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtEmpCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtDepartment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtJobTitle As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TblJobTitleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TxtRateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dblCoBenefit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtRateDescriptorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DblHourperYearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DblRatePerHourDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_JobTitle As System.Windows.Forms.DataGridView
    Friend WithEvents IdtblJobTitlesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtJobTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKtblDeptIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents IsConstraintDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TblComponentTableAdapter1 As CCP.dsProdDBTableAdapters.tblComponentTableAdapter
    Friend WithEvents TblMaterialTableAdapter1 As CCP.dsProdDBTableAdapters.tblMaterialTableAdapter
End Class
