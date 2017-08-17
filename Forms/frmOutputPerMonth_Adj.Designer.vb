<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutputPerMonth_Adj
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOutputPerMonth_Adj))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtPeriodDescriptorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DecVolumeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DecSalesPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DecGrossIncomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumOfdblMatCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumOfdblLabourCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstTotalsperMonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsOHDB = New CCP.dsOHDB()
        Me.LstTotalsperMonthTableAdapter = New CCP.dsOHDBTableAdapters.lstTotalsperMonthTableAdapter()
        Me.TblOHTableAdapter1 = New CCP.dsOHDBTableAdapters.tblOHTableAdapter()
        Me.LstLabCostperMonthTableAdapter1 = New CCP.dsOHDBTableAdapters.lstLabCostperMonthTableAdapter()
        Me.LstMatCostperMonthTableAdapter1 = New CCP.dsOHDBTableAdapters.lstMatCostperMonthTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TblCoInfoTableAdapter1 = New CCP.dsOHDBTableAdapters.tblCoInfoTableAdapter()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LstTotalsperMonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsOHDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column14, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.TxtPeriodDescriptorDataGridViewTextBoxColumn, Me.DecVolumeDataGridViewTextBoxColumn, Me.DecSalesPriceDataGridViewTextBoxColumn, Me.DecGrossIncomeDataGridViewTextBoxColumn, Me.SumOfdblMatCostDataGridViewTextBoxColumn, Me.SumOfdblLabourCostDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.LstTotalsperMonthBindingSource
        Me.dgv.Location = New System.Drawing.Point(25, 27)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(1026, 336)
        Me.dgv.TabIndex = 0
        '
        'Column14
        '
        Me.Column14.HeaderText = "Description"
        Me.Column14.Name = "Column14"
        '
        'Column1
        '
        Me.Column1.HeaderText = "January"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "February"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "March"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "April"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "May"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "June"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "July"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "August"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "September"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "October"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "November"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "December"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.HeaderText = "Total"
        Me.Column13.Name = "Column13"
        '
        'TxtPeriodDescriptorDataGridViewTextBoxColumn
        '
        Me.TxtPeriodDescriptorDataGridViewTextBoxColumn.DataPropertyName = "txtPeriodDescriptor"
        Me.TxtPeriodDescriptorDataGridViewTextBoxColumn.HeaderText = "txtPeriodDescriptor"
        Me.TxtPeriodDescriptorDataGridViewTextBoxColumn.Name = "TxtPeriodDescriptorDataGridViewTextBoxColumn"
        '
        'DecVolumeDataGridViewTextBoxColumn
        '
        Me.DecVolumeDataGridViewTextBoxColumn.DataPropertyName = "decVolume"
        Me.DecVolumeDataGridViewTextBoxColumn.HeaderText = "decVolume"
        Me.DecVolumeDataGridViewTextBoxColumn.Name = "DecVolumeDataGridViewTextBoxColumn"
        '
        'DecSalesPriceDataGridViewTextBoxColumn
        '
        Me.DecSalesPriceDataGridViewTextBoxColumn.DataPropertyName = "decSalesPrice"
        Me.DecSalesPriceDataGridViewTextBoxColumn.HeaderText = "decSalesPrice"
        Me.DecSalesPriceDataGridViewTextBoxColumn.Name = "DecSalesPriceDataGridViewTextBoxColumn"
        '
        'DecGrossIncomeDataGridViewTextBoxColumn
        '
        Me.DecGrossIncomeDataGridViewTextBoxColumn.DataPropertyName = "decGrossIncome"
        Me.DecGrossIncomeDataGridViewTextBoxColumn.HeaderText = "decGrossIncome"
        Me.DecGrossIncomeDataGridViewTextBoxColumn.Name = "DecGrossIncomeDataGridViewTextBoxColumn"
        '
        'SumOfdblMatCostDataGridViewTextBoxColumn
        '
        Me.SumOfdblMatCostDataGridViewTextBoxColumn.DataPropertyName = "SumOfdblMatCost"
        Me.SumOfdblMatCostDataGridViewTextBoxColumn.HeaderText = "SumOfdblMatCost"
        Me.SumOfdblMatCostDataGridViewTextBoxColumn.Name = "SumOfdblMatCostDataGridViewTextBoxColumn"
        '
        'SumOfdblLabourCostDataGridViewTextBoxColumn
        '
        Me.SumOfdblLabourCostDataGridViewTextBoxColumn.DataPropertyName = "SumOfdblLabourCost"
        Me.SumOfdblLabourCostDataGridViewTextBoxColumn.HeaderText = "SumOfdblLabourCost"
        Me.SumOfdblLabourCostDataGridViewTextBoxColumn.Name = "SumOfdblLabourCostDataGridViewTextBoxColumn"
        '
        'LstTotalsperMonthBindingSource
        '
        Me.LstTotalsperMonthBindingSource.DataMember = "lstTotalsperMonth"
        Me.LstTotalsperMonthBindingSource.DataSource = Me.DsOHDB
        '
        'DsOHDB
        '
        Me.DsOHDB.DataSetName = "dsOHDB"
        Me.DsOHDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LstTotalsperMonthTableAdapter
        '
        Me.LstTotalsperMonthTableAdapter.ClearBeforeFill = True
        '
        'TblOHTableAdapter1
        '
        Me.TblOHTableAdapter1.ClearBeforeFill = True
        '
        'LstLabCostperMonthTableAdapter1
        '
        Me.LstLabCostperMonthTableAdapter1.ClearBeforeFill = True
        '
        'LstMatCostperMonthTableAdapter1
        '
        Me.LstMatCostperMonthTableAdapter1.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRecordToolStripMenuItem, Me.EditRecordToolStripMenuItem, Me.SaveRecordToolStripMenuItem, Me.CancelToolStripMenuItem, Me.PrintRecordToolStripMenuItem, Me.CloseFormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1072, 24)
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
        'TblCoInfoTableAdapter1
        '
        Me.TblCoInfoTableAdapter1.ClearBeforeFill = True
        '
        'frmOutputPerMonth_Adj
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1072, 398)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOutputPerMonth_Adj"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cost Coach Pro - Income Statement"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LstTotalsperMonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsOHDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents DsOHDB As CCP.dsOHDB
    Friend WithEvents LstTotalsperMonthBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LstTotalsperMonthTableAdapter As CCP.dsOHDBTableAdapters.lstTotalsperMonthTableAdapter
    Friend WithEvents TblOHTableAdapter1 As CCP.dsOHDBTableAdapters.tblOHTableAdapter
    Friend WithEvents LstLabCostperMonthTableAdapter1 As CCP.dsOHDBTableAdapters.lstLabCostperMonthTableAdapter
    Friend WithEvents LstMatCostperMonthTableAdapter1 As CCP.dsOHDBTableAdapters.lstMatCostperMonthTableAdapter
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtPeriodDescriptorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DecVolumeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DecSalesPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DecGrossIncomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SumOfdblMatCostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SumOfdblLabourCostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NewRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TblCoInfoTableAdapter1 As CCP.dsOHDBTableAdapters.tblCoInfoTableAdapter
End Class
