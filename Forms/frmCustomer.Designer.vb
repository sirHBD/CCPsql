<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Cutomers = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdtblCustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCusCdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCusDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntCusPayDaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtProdCodesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtAddPosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtAddDelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtContactNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtPhone1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtPhone2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtFaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccounting1 = New CCP.dsAccounting()
        Me.TblStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DsActivityDB1 = New CCP.dsActivityDB()
        Me.TblDeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.LstStaffGroupsTableAdapter1 = New CCP.dsProdDBTableAdapters.lstStaffGroupsTableAdapter()
        Me.TblCustomerTableAdapter1 = New CCP.dsAccountingTableAdapters.tblCustomerTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Cutomers.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccounting1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.DsActivityDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage_Cutomers)
        Me.TabControl1.Location = New System.Drawing.Point(0, 26)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(940, 390)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage_Cutomers
        '
        Me.TabPage_Cutomers.Controls.Add(Me.DataGridView1)
        Me.TabPage_Cutomers.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Cutomers.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage_Cutomers.Name = "TabPage_Cutomers"
        Me.TabPage_Cutomers.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage_Cutomers.Size = New System.Drawing.Size(932, 364)
        Me.TabPage_Cutomers.TabIndex = 0
        Me.TabPage_Cutomers.Text = "Customers"
        Me.TabPage_Cutomers.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtblCustomerDataGridViewTextBoxColumn, Me.TxtCusCdeDataGridViewTextBoxColumn, Me.TxtCusDescDataGridViewTextBoxColumn, Me.IntCusPayDaysDataGridViewTextBoxColumn, Me.TxtProdCodesDataGridViewTextBoxColumn, Me.TxtAddPosDataGridViewTextBoxColumn, Me.TxtAddDelDataGridViewTextBoxColumn, Me.TxtContactNameDataGridViewTextBoxColumn, Me.TxtEmailDataGridViewTextBoxColumn, Me.TxtPhone1DataGridViewTextBoxColumn, Me.TxtPhone2DataGridViewTextBoxColumn, Me.TxtFaxDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblCustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(4, 3)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(880, 360)
        Me.DataGridView1.TabIndex = 1
        '
        'IdtblCustomerDataGridViewTextBoxColumn
        '
        Me.IdtblCustomerDataGridViewTextBoxColumn.DataPropertyName = "id_tblCustomer"
        Me.IdtblCustomerDataGridViewTextBoxColumn.HeaderText = "id_tblCustomer"
        Me.IdtblCustomerDataGridViewTextBoxColumn.Name = "IdtblCustomerDataGridViewTextBoxColumn"
        Me.IdtblCustomerDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdtblCustomerDataGridViewTextBoxColumn.Visible = False
        '
        'TxtCusCdeDataGridViewTextBoxColumn
        '
        Me.TxtCusCdeDataGridViewTextBoxColumn.DataPropertyName = "txtCusCde"
        Me.TxtCusCdeDataGridViewTextBoxColumn.HeaderText = "Code/Number"
        Me.TxtCusCdeDataGridViewTextBoxColumn.Name = "TxtCusCdeDataGridViewTextBoxColumn"
        Me.TxtCusCdeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtCusDescDataGridViewTextBoxColumn
        '
        Me.TxtCusDescDataGridViewTextBoxColumn.DataPropertyName = "txtCusDesc"
        Me.TxtCusDescDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.TxtCusDescDataGridViewTextBoxColumn.Name = "TxtCusDescDataGridViewTextBoxColumn"
        Me.TxtCusDescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IntCusPayDaysDataGridViewTextBoxColumn
        '
        Me.IntCusPayDaysDataGridViewTextBoxColumn.DataPropertyName = "IntCusPayDays"
        Me.IntCusPayDaysDataGridViewTextBoxColumn.HeaderText = "Pay Days"
        Me.IntCusPayDaysDataGridViewTextBoxColumn.Name = "IntCusPayDaysDataGridViewTextBoxColumn"
        Me.IntCusPayDaysDataGridViewTextBoxColumn.ReadOnly = True
        Me.IntCusPayDaysDataGridViewTextBoxColumn.Visible = False
        '
        'TxtProdCodesDataGridViewTextBoxColumn
        '
        Me.TxtProdCodesDataGridViewTextBoxColumn.DataPropertyName = "txtProdCodes"
        Me.TxtProdCodesDataGridViewTextBoxColumn.HeaderText = "Products"
        Me.TxtProdCodesDataGridViewTextBoxColumn.Name = "TxtProdCodesDataGridViewTextBoxColumn"
        Me.TxtProdCodesDataGridViewTextBoxColumn.ReadOnly = True
        Me.TxtProdCodesDataGridViewTextBoxColumn.Visible = False
        '
        'TxtAddPosDataGridViewTextBoxColumn
        '
        Me.TxtAddPosDataGridViewTextBoxColumn.DataPropertyName = "txtAddPos"
        Me.TxtAddPosDataGridViewTextBoxColumn.HeaderText = "Postal address"
        Me.TxtAddPosDataGridViewTextBoxColumn.Name = "TxtAddPosDataGridViewTextBoxColumn"
        Me.TxtAddPosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtAddDelDataGridViewTextBoxColumn
        '
        Me.TxtAddDelDataGridViewTextBoxColumn.DataPropertyName = "txtAddDel"
        Me.TxtAddDelDataGridViewTextBoxColumn.HeaderText = "Delivery address"
        Me.TxtAddDelDataGridViewTextBoxColumn.Name = "TxtAddDelDataGridViewTextBoxColumn"
        Me.TxtAddDelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtContactNameDataGridViewTextBoxColumn
        '
        Me.TxtContactNameDataGridViewTextBoxColumn.DataPropertyName = "txtContactName"
        Me.TxtContactNameDataGridViewTextBoxColumn.HeaderText = "Contact person"
        Me.TxtContactNameDataGridViewTextBoxColumn.Name = "TxtContactNameDataGridViewTextBoxColumn"
        Me.TxtContactNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtEmailDataGridViewTextBoxColumn
        '
        Me.TxtEmailDataGridViewTextBoxColumn.DataPropertyName = "txtEmail"
        Me.TxtEmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.TxtEmailDataGridViewTextBoxColumn.Name = "TxtEmailDataGridViewTextBoxColumn"
        Me.TxtEmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtPhone1DataGridViewTextBoxColumn
        '
        Me.TxtPhone1DataGridViewTextBoxColumn.DataPropertyName = "txtPhone1"
        Me.TxtPhone1DataGridViewTextBoxColumn.HeaderText = "Phone1"
        Me.TxtPhone1DataGridViewTextBoxColumn.Name = "TxtPhone1DataGridViewTextBoxColumn"
        Me.TxtPhone1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtPhone2DataGridViewTextBoxColumn
        '
        Me.TxtPhone2DataGridViewTextBoxColumn.DataPropertyName = "txtPhone2"
        Me.TxtPhone2DataGridViewTextBoxColumn.HeaderText = "Phone2"
        Me.TxtPhone2DataGridViewTextBoxColumn.Name = "TxtPhone2DataGridViewTextBoxColumn"
        Me.TxtPhone2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtFaxDataGridViewTextBoxColumn
        '
        Me.TxtFaxDataGridViewTextBoxColumn.DataPropertyName = "txtFax"
        Me.TxtFaxDataGridViewTextBoxColumn.HeaderText = "Fax"
        Me.TxtFaxDataGridViewTextBoxColumn.Name = "TxtFaxDataGridViewTextBoxColumn"
        Me.TxtFaxDataGridViewTextBoxColumn.ReadOnly = True
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
        'DsActivityDB1
        '
        Me.DsActivityDB1.DataSetName = "dsActivityDB"
        Me.DsActivityDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblDeptBindingSource
        '
        Me.TblDeptBindingSource.DataMember = "tblDept"
        Me.TblDeptBindingSource.DataSource = Me.DsActivityDB1
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
        'LstStaffGroupsTableAdapter1
        '
        Me.LstStaffGroupsTableAdapter1.ClearBeforeFill = True
        '
        'TblCustomerTableAdapter1
        '
        Me.TblCustomerTableAdapter1.ClearBeforeFill = True
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 425)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Operational Staff"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Cutomers.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccounting1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.DsActivityDB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TblStaffTableAdapter1 As CCP.dsProdDBTableAdapters.tblStaffTableAdapter
    Friend WithEvents TblStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Cutomers As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DsActivityDB1 As CCP.dsActivityDB
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
    Friend WithEvents DsAccounting1 As CCP.dsAccounting
    Friend WithEvents TblCustomerTableAdapter1 As CCP.dsAccountingTableAdapters.tblCustomerTableAdapter
    Friend WithEvents TblCustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdtblCustomerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtCusCdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtCusDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntCusPayDaysDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtProdCodesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtAddPosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtAddDelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtContactNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtEmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtPhone1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtPhone2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtFaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
