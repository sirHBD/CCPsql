<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOH))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdtblOHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtAccNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtAccName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DblOHAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtAllocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TxtDividerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtActivityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckForPerMonth = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TblOHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsOHDB = New CCP.dsOHDB()
        Me.TblOHTableAdapter = New CCP.dsOHDBTableAdapters.tblOHTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblOHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsOHDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtblOHDataGridViewTextBoxColumn, Me.TxtAccNoDataGridViewTextBoxColumn, Me.txtAccName, Me.DblOHAmountDataGridViewTextBoxColumn, Me.TxtAllocationDataGridViewTextBoxColumn, Me.TxtDividerDataGridViewTextBoxColumn, Me.TxtActivityDataGridViewTextBoxColumn, Me.CheckForPerMonth})
        Me.DataGridView1.DataSource = Me.TblOHBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(51, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1031, 374)
        Me.DataGridView1.TabIndex = 0
        '
        'IdtblOHDataGridViewTextBoxColumn
        '
        Me.IdtblOHDataGridViewTextBoxColumn.DataPropertyName = "id_tblOH"
        Me.IdtblOHDataGridViewTextBoxColumn.HeaderText = "id_tblOH"
        Me.IdtblOHDataGridViewTextBoxColumn.Name = "IdtblOHDataGridViewTextBoxColumn"
        Me.IdtblOHDataGridViewTextBoxColumn.Visible = False
        '
        'TxtAccNoDataGridViewTextBoxColumn
        '
        Me.TxtAccNoDataGridViewTextBoxColumn.DataPropertyName = "txtAccNo"
        Me.TxtAccNoDataGridViewTextBoxColumn.HeaderText = "Account Number"
        Me.TxtAccNoDataGridViewTextBoxColumn.Name = "TxtAccNoDataGridViewTextBoxColumn"
        '
        'txtAccName
        '
        Me.txtAccName.DataPropertyName = "txtAccName"
        Me.txtAccName.HeaderText = "Description"
        Me.txtAccName.Name = "txtAccName"
        '
        'DblOHAmountDataGridViewTextBoxColumn
        '
        Me.DblOHAmountDataGridViewTextBoxColumn.DataPropertyName = "dblOHAmount"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DblOHAmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DblOHAmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.DblOHAmountDataGridViewTextBoxColumn.Name = "DblOHAmountDataGridViewTextBoxColumn"
        '
        'TxtAllocationDataGridViewTextBoxColumn
        '
        Me.TxtAllocationDataGridViewTextBoxColumn.DataPropertyName = "txtAllocation"
        Me.TxtAllocationDataGridViewTextBoxColumn.HeaderText = "Allocation Basis"
        Me.TxtAllocationDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Sales Units", "Production Units", "Labour Hours"})
        Me.TxtAllocationDataGridViewTextBoxColumn.Name = "TxtAllocationDataGridViewTextBoxColumn"
        Me.TxtAllocationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TxtAllocationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TxtDividerDataGridViewTextBoxColumn
        '
        Me.TxtDividerDataGridViewTextBoxColumn.DataPropertyName = "txtDivider"
        Me.TxtDividerDataGridViewTextBoxColumn.HeaderText = "txtDivider"
        Me.TxtDividerDataGridViewTextBoxColumn.Name = "TxtDividerDataGridViewTextBoxColumn"
        Me.TxtDividerDataGridViewTextBoxColumn.Visible = False
        '
        'TxtActivityDataGridViewTextBoxColumn
        '
        Me.TxtActivityDataGridViewTextBoxColumn.DataPropertyName = "txtActivity"
        Me.TxtActivityDataGridViewTextBoxColumn.HeaderText = "txtActivity"
        Me.TxtActivityDataGridViewTextBoxColumn.Name = "TxtActivityDataGridViewTextBoxColumn"
        Me.TxtActivityDataGridViewTextBoxColumn.Visible = False
        '
        'CheckForPerMonth
        '
        Me.CheckForPerMonth.HeaderText = "Per Month"
        Me.CheckForPerMonth.Name = "CheckForPerMonth"
        Me.CheckForPerMonth.Width = 50
        '
        'TblOHBindingSource
        '
        Me.TblOHBindingSource.DataMember = "tblOH"
        Me.TblOHBindingSource.DataSource = Me.DsOHDB
        '
        'DsOHDB
        '
        Me.DsOHDB.DataSetName = "dsOHDB"
        Me.DsOHDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblOHTableAdapter
        '
        Me.TblOHTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRecordToolStripMenuItem, Me.EditRecordToolStripMenuItem, Me.SaveRecordToolStripMenuItem, Me.CancelToolStripMenuItem, Me.PrintRecordToolStripMenuItem, Me.CloseFormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1137, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewRecordToolStripMenuItem
        '
        Me.NewRecordToolStripMenuItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecordToolStripMenuItem.Name = "NewRecordToolStripMenuItem"
        Me.NewRecordToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.NewRecordToolStripMenuItem.Text = "New Record"
        '
        'EditRecordToolStripMenuItem
        '
        Me.EditRecordToolStripMenuItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditRecordToolStripMenuItem.Name = "EditRecordToolStripMenuItem"
        Me.EditRecordToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.EditRecordToolStripMenuItem.Text = "Edit Record"
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
        'frmOH
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1137, 466)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FACT - Overhead Input Screen"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblOHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsOHDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DsOHDB As CCP.dsOHDB
    Friend WithEvents TblOHBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblOHTableAdapter As CCP.dsOHDBTableAdapters.tblOHTableAdapter
    Friend WithEvents TxtAccNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdtblOHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtAccNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtAccName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DblOHAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtAllocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TxtDividerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtActivityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckForPerMonth As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NewRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
