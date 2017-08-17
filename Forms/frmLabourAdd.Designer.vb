<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLabourAdd
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
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLabourAdd))
Me.Panel1 = New System.Windows.Forms.Panel()
Me.Panel2 = New System.Windows.Forms.Panel()
Me.PictureBox3 = New System.Windows.Forms.PictureBox()
Me.PictureBox2 = New System.Windows.Forms.PictureBox()
Me.PictureBox1 = New System.Windows.Forms.PictureBox()
Me.Button1 = New System.Windows.Forms.Button()
Me.TextBox3 = New System.Windows.Forms.TextBox()
Me.TextBox2 = New System.Windows.Forms.TextBox()
Me.ComboBox1 = New System.Windows.Forms.ComboBox()
Me.TextBox1 = New System.Windows.Forms.TextBox()
Me.Label9 = New System.Windows.Forms.Label()
Me.cBox_StaffGroup = New System.Windows.Forms.ComboBox()
Me.cBox_Operator = New System.Windows.Forms.ComboBox()
Me.cBox_Operation = New System.Windows.Forms.ComboBox()
Me.cBox_Activity = New System.Windows.Forms.ComboBox()
Me.cBox_Element = New System.Windows.Forms.ComboBox()
Me.Label8 = New System.Windows.Forms.Label()
Me.Label7 = New System.Windows.Forms.Label()
Me.Label6 = New System.Windows.Forms.Label()
Me.Label5 = New System.Windows.Forms.Label()
Me.Label4 = New System.Windows.Forms.Label()
Me.Label3 = New System.Windows.Forms.Label()
Me.Label2 = New System.Windows.Forms.Label()
Me.Label1 = New System.Windows.Forms.Label()
Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
Me.AddNewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
Me.dgvProductLink = New System.Windows.Forms.DataGridView()
Me.ComboBox2 = New System.Windows.Forms.ComboBox()
Me.TblOperationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProdDB = New CCP.dsProdDB()
        Me.TblActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblElementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProdLinkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProductTableAdapter = New CCP.dsProdDBTableAdapters.tblProductTableAdapter()
        Me.TblProdLinkTableAdapter = New CCP.dsProdDBTableAdapters.tblProdLinkTableAdapter()
        Me.TblElementTableAdapter1 = New CCP.dsProdDBTableAdapters.tblElementTableAdapter()
        Me.TblActivityTableAdapter1 = New CCP.dsProdDBTableAdapters.tblActivityTableAdapter()
        Me.TblStaffTableAdapter1 = New CCP.dsProdDBTableAdapters.tblStaffTableAdapter()
        Me.TblOperationTableAdapter = New CCP.dsProdDBTableAdapters.tblOperationTableAdapter()
        Me.FktblElementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FktblActivityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Operation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_txtLabourParameter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Staff_Member = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtblProdLinkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FktblProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FktblOperationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DblValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtValueDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DblFreqDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dblLabourCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblOperationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProdDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblElementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProdLinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(766, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 544)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.Beige
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.cBox_StaffGroup)
        Me.Panel2.Controls.Add(Me.cBox_Operator)
        Me.Panel2.Controls.Add(Me.cBox_Operation)
        Me.Panel2.Controls.Add(Me.cBox_Activity)
        Me.Panel2.Controls.Add(Me.cBox_Element)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(325, 515)
        Me.Panel2.TabIndex = 3
        Me.Panel2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(92, 119)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(92, 87)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(92, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 467)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(259, 33)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(204, 311)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(204, 283)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 16
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"Year", "Month", "Week", "Day", "Hour", "Minute", "Second"})
        Me.ComboBox1.Location = New System.Drawing.Point(204, 222)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 24)
        Me.ComboBox1.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(204, 254)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Staff Group"
        '
        'cBox_StaffGroup
        '
        Me.cBox_StaffGroup.FormattingEnabled = True
        Me.cBox_StaffGroup.Location = New System.Drawing.Point(141, 179)
        Me.cBox_StaffGroup.Name = "cBox_StaffGroup"
        Me.cBox_StaffGroup.Size = New System.Drawing.Size(163, 24)
        Me.cBox_StaffGroup.TabIndex = 12
        '
        'cBox_Operator
        '
        Me.cBox_Operator.FormattingEnabled = True
        Me.cBox_Operator.Location = New System.Drawing.Point(141, 149)
        Me.cBox_Operator.Name = "cBox_Operator"
        Me.cBox_Operator.Size = New System.Drawing.Size(163, 24)
        Me.cBox_Operator.TabIndex = 11
        '
        'cBox_Operation
        '
        Me.cBox_Operation.DataSource = Me.TblOperationBindingSource
        Me.cBox_Operation.DisplayMember = "txtOpDesc"
        Me.cBox_Operation.FormattingEnabled = True
        Me.cBox_Operation.Location = New System.Drawing.Point(141, 119)
        Me.cBox_Operation.Name = "cBox_Operation"
        Me.cBox_Operation.Size = New System.Drawing.Size(163, 24)
        Me.cBox_Operation.TabIndex = 10
        Me.cBox_Operation.ValueMember = "id_tblOperation"
        '
        'cBox_Activity
        '
        Me.cBox_Activity.DataSource = Me.TblActivityBindingSource
        Me.cBox_Activity.DisplayMember = "txtActDesc"
        Me.cBox_Activity.FormattingEnabled = True
        Me.cBox_Activity.Location = New System.Drawing.Point(141, 87)
        Me.cBox_Activity.Name = "cBox_Activity"
        Me.cBox_Activity.Size = New System.Drawing.Size(163, 24)
        Me.cBox_Activity.TabIndex = 9
        Me.cBox_Activity.ValueMember = "id_tblActivity"
        '
        'cBox_Element
        '
        Me.cBox_Element.DataSource = Me.TblElementBindingSource
        Me.cBox_Element.DisplayMember = "txtElementDesc"
        Me.cBox_Element.FormattingEnabled = True
        Me.cBox_Element.Location = New System.Drawing.Point(141, 53)
        Me.cBox_Element.Name = "cBox_Element"
        Me.cBox_Element.Size = New System.Drawing.Size(163, 24)
        Me.cBox_Element.TabIndex = 0
        Me.cBox_Element.ValueMember = "id_tblElement"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 314)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Labour Cost"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Frequency"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Value"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Value Descriptor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Staff Select"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Operation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Activity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Element"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewRecordToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(325, 26)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddNewRecordToolStripMenuItem
        '
        Me.AddNewRecordToolStripMenuItem.Name = "AddNewRecordToolStripMenuItem"
        Me.AddNewRecordToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AddNewRecordToolStripMenuItem.Text = "Add new Record"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dgvProductLink
        '
        Me.dgvProductLink.AllowUserToAddRows = False
        Me.dgvProductLink.AutoGenerateColumns = False
        Me.dgvProductLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductLink.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FktblElementDataGridViewTextBoxColumn, Me.FktblActivityDataGridViewTextBoxColumn, Me.Operation, Me.dgv_txtLabourParameter, Me.Staff_Member, Me.IdtblProdLinkDataGridViewTextBoxColumn, Me.FktblProductDataGridViewTextBoxColumn, Me.FktblOperationDataGridViewTextBoxColumn, Me.DblValueDataGridViewTextBoxColumn, Me.TxtValueDescDataGridViewTextBoxColumn, Me.DblFreqDataGridViewTextBoxColumn, Me.dblLabourCost})
        Me.dgvProductLink.DataSource = Me.TblProdLinkBindingSource
        Me.dgvProductLink.Location = New System.Drawing.Point(20, 44)
        Me.dgvProductLink.Name = "dgvProductLink"
        Me.dgvProductLink.RowTemplate.Height = 24
        Me.dgvProductLink.Size = New System.Drawing.Size(712, 509)
        Me.dgvProductLink.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(20, 14)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(712, 24)
        Me.ComboBox2.TabIndex = 3
        '
        'TblOperationBindingSource
        '
        Me.TblOperationBindingSource.DataMember = "tblOperation"
        Me.TblOperationBindingSource.DataSource = Me.DsProdDB
        '
        'DsProdDB
        '
        Me.DsProdDB.DataSetName = "dsProdDB"
        Me.DsProdDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblActivityBindingSource
        '
        Me.TblActivityBindingSource.DataMember = "tblActivity"
        Me.TblActivityBindingSource.DataSource = Me.DsProdDB
        '
        'TblElementBindingSource
        '
        Me.TblElementBindingSource.DataMember = "tblElement"
        Me.TblElementBindingSource.DataSource = Me.DsProdDB
        '
        'TblProdLinkBindingSource
        '
        Me.TblProdLinkBindingSource.DataMember = "tblProdLink"
        Me.TblProdLinkBindingSource.DataSource = Me.DsProdDB
        '
        'TblProductBindingSource
        '
        Me.TblProductBindingSource.DataMember = "tblProduct"
        Me.TblProductBindingSource.DataSource = Me.DsProdDB
        '
        'TblProductTableAdapter
        '
        Me.TblProductTableAdapter.ClearBeforeFill = True
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
        'TblStaffTableAdapter1
        '
        Me.TblStaffTableAdapter1.ClearBeforeFill = True
        '
        'TblOperationTableAdapter
        '
        Me.TblOperationTableAdapter.ClearBeforeFill = True
        '
        'FktblElementDataGridViewTextBoxColumn
        '
        Me.FktblElementDataGridViewTextBoxColumn.DataPropertyName = "fk_tblElement"
        Me.FktblElementDataGridViewTextBoxColumn.DataSource = Me.TblElementBindingSource
        Me.FktblElementDataGridViewTextBoxColumn.DisplayMember = "txtElementDesc"
        Me.FktblElementDataGridViewTextBoxColumn.HeaderText = "Element"
        Me.FktblElementDataGridViewTextBoxColumn.Name = "FktblElementDataGridViewTextBoxColumn"
        Me.FktblElementDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FktblElementDataGridViewTextBoxColumn.ValueMember = "id_tblElement"
        Me.FktblElementDataGridViewTextBoxColumn.Width = 84
        '
        'FktblActivityDataGridViewTextBoxColumn
        '
        Me.FktblActivityDataGridViewTextBoxColumn.DataPropertyName = "fk_tblActivity"
        Me.FktblActivityDataGridViewTextBoxColumn.DataSource = Me.TblActivityBindingSource
        Me.FktblActivityDataGridViewTextBoxColumn.DisplayMember = "txtActDesc"
        Me.FktblActivityDataGridViewTextBoxColumn.HeaderText = "Activity"
        Me.FktblActivityDataGridViewTextBoxColumn.Name = "FktblActivityDataGridViewTextBoxColumn"
        Me.FktblActivityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FktblActivityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FktblActivityDataGridViewTextBoxColumn.ValueMember = "id_tblActivity"
        Me.FktblActivityDataGridViewTextBoxColumn.Width = 125
        '
        'Operation
        '
        Me.Operation.HeaderText = "Operation"
        Me.Operation.Name = "Operation"
        Me.Operation.Visible = False
        '
        'dgv_txtLabourParameter
        '
        Me.dgv_txtLabourParameter.DataPropertyName = "txtLabourParameter"
        Me.dgv_txtLabourParameter.HeaderText = "Staff Type"
        Me.dgv_txtLabourParameter.Name = "dgv_txtLabourParameter"
        Me.dgv_txtLabourParameter.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_txtLabourParameter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Staff_Member
        '
        Me.Staff_Member.HeaderText = "Staff Member"
        Me.Staff_Member.Name = "Staff_Member"
        '
        'IdtblProdLinkDataGridViewTextBoxColumn
        '
        Me.IdtblProdLinkDataGridViewTextBoxColumn.DataPropertyName = "id_tblProdLink"
        Me.IdtblProdLinkDataGridViewTextBoxColumn.HeaderText = "id_tblProdLink"
        Me.IdtblProdLinkDataGridViewTextBoxColumn.Name = "IdtblProdLinkDataGridViewTextBoxColumn"
        Me.IdtblProdLinkDataGridViewTextBoxColumn.Visible = False
        '
        'FktblProductDataGridViewTextBoxColumn
        '
        Me.FktblProductDataGridViewTextBoxColumn.DataPropertyName = "fk_tblProduct"
        Me.FktblProductDataGridViewTextBoxColumn.HeaderText = "fk_tblProduct"
        Me.FktblProductDataGridViewTextBoxColumn.Name = "FktblProductDataGridViewTextBoxColumn"
        Me.FktblProductDataGridViewTextBoxColumn.Visible = False
        '
        'FktblOperationDataGridViewTextBoxColumn
        '
        Me.FktblOperationDataGridViewTextBoxColumn.DataPropertyName = "fk_tblOperation"
        Me.FktblOperationDataGridViewTextBoxColumn.HeaderText = "fk_tblOperation"
        Me.FktblOperationDataGridViewTextBoxColumn.Name = "FktblOperationDataGridViewTextBoxColumn"
        Me.FktblOperationDataGridViewTextBoxColumn.Visible = False
        '
        'DblValueDataGridViewTextBoxColumn
        '
        Me.DblValueDataGridViewTextBoxColumn.DataPropertyName = "dblValue"
        Me.DblValueDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.DblValueDataGridViewTextBoxColumn.Name = "DblValueDataGridViewTextBoxColumn"
        '
        'TxtValueDescDataGridViewTextBoxColumn
        '
        Me.TxtValueDescDataGridViewTextBoxColumn.DataPropertyName = "txtValueDesc"
        Me.TxtValueDescDataGridViewTextBoxColumn.HeaderText = "Time Unit"
        Me.TxtValueDescDataGridViewTextBoxColumn.Name = "TxtValueDescDataGridViewTextBoxColumn"
        '
        'DblFreqDataGridViewTextBoxColumn
        '
        Me.DblFreqDataGridViewTextBoxColumn.DataPropertyName = "dblFreq"
        Me.DblFreqDataGridViewTextBoxColumn.HeaderText = "Number of Times"
        Me.DblFreqDataGridViewTextBoxColumn.Name = "DblFreqDataGridViewTextBoxColumn"
        '
        'dblLabourCost
        '
        Me.dblLabourCost.DataPropertyName = "dblLabourCost"
        Me.dblLabourCost.HeaderText = "Labour Cost"
        Me.dblLabourCost.Name = "dblLabourCost"
        '
        'frmLabourAdd
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1115, 578)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvProductLink)
        Me.HelpButton = True
        Me.Name = "frmLabourAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FACT - Labour Parameter Management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblOperationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProdDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblElementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProdLinkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsProdDB As CCP.dsProdDB
    Friend WithEvents TblProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProductTableAdapter As CCP.dsProdDBTableAdapters.tblProductTableAdapter
    Friend WithEvents TblProdLinkTableAdapter As CCP.dsProdDBTableAdapters.tblProdLinkTableAdapter
    Friend WithEvents TblElementTableAdapter1 As CCP.dsProdDBTableAdapters.tblElementTableAdapter
    Friend WithEvents TblActivityTableAdapter1 As CCP.dsProdDBTableAdapters.tblActivityTableAdapter
    Friend WithEvents TxtLabourParameterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DblLabourCostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cBox_Operator As System.Windows.Forms.ComboBox
    Friend WithEvents cBox_Operation As System.Windows.Forms.ComboBox
    Friend WithEvents cBox_Activity As System.Windows.Forms.ComboBox
    Friend WithEvents cBox_Element As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddNewRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TblStaffTableAdapter1 As CCP.dsProdDBTableAdapters.tblStaffTableAdapter
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cBox_StaffGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TblActivityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblElementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblOperationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblOperationTableAdapter As CCP.dsProdDBTableAdapters.tblOperationTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents TblProdSpec1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblProdSpec2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvProductLink As System.Windows.Forms.DataGridView
    Friend WithEvents TblProdLinkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents FktblElementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FktblActivityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Operation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_txtLabourParameter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Staff_Member As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdtblProdLinkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FktblProductDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FktblOperationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DblValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtValueDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DblFreqDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dblLabourCost As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
