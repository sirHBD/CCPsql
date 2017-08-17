<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutputReq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOutputReq))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvMaterialReq = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cm_HideValue = New System.Windows.Forms.ToolStripMenuItem()
        Me.cm_HideUnits = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvLabRequirement = New System.Windows.Forms.DataGridView()
        Me.DsREQ1 = New CCP.dsREQ()
        Me.LstMatCostperMonthTableAdapter1 = New CCP.dsREQTableAdapters.lstMatCostperMonthTableAdapter()
        Me.LstLabCostperMonthTableAdapter1 = New CCP.dsREQTableAdapters.lstLabCostperMonthTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TblCoInfoTableAdapter1 = New CCP.dsOHDBTableAdapters.tblCoInfoTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvMaterialReq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvLabRequirement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsREQ1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 26)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(904, 413)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvMaterialReq)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(896, 387)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Material Cost and Unit Requirements"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvMaterialReq
        '
        Me.dgvMaterialReq.AllowUserToAddRows = False
        Me.dgvMaterialReq.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvMaterialReq.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMaterialReq.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMaterialReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterialReq.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvMaterialReq.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMaterialReq.Location = New System.Drawing.Point(4, 5)
        Me.dgvMaterialReq.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvMaterialReq.Name = "dgvMaterialReq"
        Me.dgvMaterialReq.RowTemplate.Height = 24
        Me.dgvMaterialReq.Size = New System.Drawing.Size(889, 377)
        Me.dgvMaterialReq.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cm_HideValue, Me.cm_HideUnits})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(172, 48)
        '
        'cm_HideValue
        '
        Me.cm_HideValue.Name = "cm_HideValue"
        Me.cm_HideValue.Size = New System.Drawing.Size(171, 22)
        Me.cm_HideValue.Text = "Hide / Show Value"
        '
        'cm_HideUnits
        '
        Me.cm_HideUnits.Name = "cm_HideUnits"
        Me.cm_HideUnits.Size = New System.Drawing.Size(171, 22)
        Me.cm_HideUnits.Text = "Hide / Show Units"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvLabRequirement)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(896, 387)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Labour Cost Requirement"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvLabRequirement
        '
        Me.dgvLabRequirement.AllowUserToAddRows = False
        Me.dgvLabRequirement.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvLabRequirement.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLabRequirement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLabRequirement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLabRequirement.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvLabRequirement.Location = New System.Drawing.Point(4, 5)
        Me.dgvLabRequirement.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvLabRequirement.Name = "dgvLabRequirement"
        Me.dgvLabRequirement.RowTemplate.Height = 24
        Me.dgvLabRequirement.Size = New System.Drawing.Size(889, 380)
        Me.dgvLabRequirement.TabIndex = 0
        '
        'DsREQ1
        '
        Me.DsREQ1.DataSetName = "dsREQ"
        Me.DsREQ1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LstMatCostperMonthTableAdapter1
        '
        Me.LstMatCostperMonthTableAdapter1.ClearBeforeFill = True
        '
        'LstLabCostperMonthTableAdapter1
        '
        Me.LstLabCostperMonthTableAdapter1.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRecordToolStripMenuItem, Me.EditRecordToolStripMenuItem, Me.SaveRecordToolStripMenuItem, Me.CancelToolStripMenuItem, Me.PrintRecordToolStripMenuItem, Me.CloseFormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(907, 24)
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
        'frmOutputReq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 438)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmOutputReq"
        Me.Text = "frmOutputReq"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvMaterialReq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvLabRequirement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsREQ1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvMaterialReq As System.Windows.Forms.DataGridView
    Friend WithEvents DsREQ1 As CCP.dsREQ
    Friend WithEvents LstMatCostperMonthTableAdapter1 As CCP.dsREQTableAdapters.lstMatCostperMonthTableAdapter
    Friend WithEvents dgvLabRequirement As System.Windows.Forms.DataGridView
    Friend WithEvents LstLabCostperMonthTableAdapter1 As CCP.dsREQTableAdapters.lstLabCostperMonthTableAdapter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cm_HideValue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cm_HideUnits As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NewRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TblCoInfoTableAdapter1 As CCP.dsOHDBTableAdapters.tblCoInfoTableAdapter
End Class
