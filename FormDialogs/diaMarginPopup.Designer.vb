<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class diaMarginPopup
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblDeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsActivityDB1 = New CCP.dsActivityDB()
        Me.TblProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProdDB = New CCP.dsProdDB()
        Me.TblProdLinkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblElementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsActivityDB1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProdLinkTableAdapter = New CCP.dsProdDBTableAdapters.tblProdLinkTableAdapter()
        Me.DsProdDB1 = New CCP.dsProdDB()
        Me.TblProdLinkTableAdapter1 = New CCP.dsProdDBTableAdapters.tblProdLinkTableAdapter()
        Me.TblDeptTableAdapter = New CCP.dsActivityDBTableAdapters.tblDeptTableAdapter()
        Me.TblElementTableAdapter = New CCP.dsActivityDBTableAdapters.tblElementTableAdapter()
        Me.TblProductTableAdapter = New CCP.dsProdDBTableAdapters.tblProductTableAdapter()
        Me.TblActivityTableAdapter = New CCP.dsActivityDBTableAdapters.tblActivityTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FktblDeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FktblProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DblLabourCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsActivityDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProdDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProdLinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblElementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsActivityDB1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProdDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(141, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FktblDeptDataGridViewTextBoxColumn, Me.FktblProductDataGridViewTextBoxColumn, Me.DblLabourCostDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblProdLinkBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-5, 35)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(295, 233)
        Me.DataGridView1.TabIndex = 1
        '
        'TblDeptBindingSource
        '
        Me.TblDeptBindingSource.DataMember = "tblDept"
        Me.TblDeptBindingSource.DataSource = Me.DsActivityDB1
        '
        'DsActivityDB1
        '
        Me.DsActivityDB1.DataSetName = "dsActivityDB"
        Me.DsActivityDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProductBindingSource
        '
        Me.TblProductBindingSource.DataMember = "tblProduct"
        Me.TblProductBindingSource.DataSource = Me.DsProdDB
        '
        'DsProdDB
        '
        Me.DsProdDB.DataSetName = "dsProdDB"
        Me.DsProdDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProdLinkBindingSource
        '
        Me.TblProdLinkBindingSource.DataMember = "tblProdLink"
        Me.TblProdLinkBindingSource.DataSource = Me.DsProdDB
        '
        'TblElementBindingSource
        '
        Me.TblElementBindingSource.DataMember = "tblElement"
        Me.TblElementBindingSource.DataSource = Me.DsActivityDB1
        '
        'TblActivityBindingSource
        '
        Me.TblActivityBindingSource.DataMember = "tblActivity"
        Me.TblActivityBindingSource.DataSource = Me.DsActivityDB1BindingSource
        '
        'DsActivityDB1BindingSource
        '
        Me.DsActivityDB1BindingSource.DataSource = Me.DsActivityDB1
        Me.DsActivityDB1BindingSource.Position = 0
        '
        'TblProdLinkTableAdapter
        '
        Me.TblProdLinkTableAdapter.ClearBeforeFill = True
        '
        'DsProdDB1
        '
        Me.DsProdDB1.DataSetName = "dsProdDB"
        Me.DsProdDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProdLinkTableAdapter1
        '
        Me.TblProdLinkTableAdapter1.ClearBeforeFill = True
        '
        'TblDeptTableAdapter
        '
        Me.TblDeptTableAdapter.ClearBeforeFill = True
        '
        'TblElementTableAdapter
        '
        Me.TblElementTableAdapter.ClearBeforeFill = True
        '
        'TblProductTableAdapter
        '
        Me.TblProductTableAdapter.ClearBeforeFill = True
        '
        'TblActivityTableAdapter
        '
        Me.TblActivityTableAdapter.ClearBeforeFill = True
        '
        'FktblDeptDataGridViewTextBoxColumn
        '
        Me.FktblDeptDataGridViewTextBoxColumn.DataPropertyName = "fk_tblDept"
        Me.FktblDeptDataGridViewTextBoxColumn.DataSource = Me.TblDeptBindingSource
        Me.FktblDeptDataGridViewTextBoxColumn.DisplayMember = "txtDepName"
        Me.FktblDeptDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.FktblDeptDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.FktblDeptDataGridViewTextBoxColumn.Name = "FktblDeptDataGridViewTextBoxColumn"
        Me.FktblDeptDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FktblDeptDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FktblDeptDataGridViewTextBoxColumn.ValueMember = "idtblDept"
        Me.FktblDeptDataGridViewTextBoxColumn.Width = 150
        '
        'FktblProductDataGridViewTextBoxColumn
        '
        Me.FktblProductDataGridViewTextBoxColumn.DataPropertyName = "fk_tblProduct"
        Me.FktblProductDataGridViewTextBoxColumn.DataSource = Me.TblProductBindingSource
        Me.FktblProductDataGridViewTextBoxColumn.DisplayMember = "txtProdCde"
        Me.FktblProductDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.FktblProductDataGridViewTextBoxColumn.HeaderText = "Product"
        Me.FktblProductDataGridViewTextBoxColumn.Name = "FktblProductDataGridViewTextBoxColumn"
        Me.FktblProductDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FktblProductDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FktblProductDataGridViewTextBoxColumn.ValueMember = "idtblProduct"
        Me.FktblProductDataGridViewTextBoxColumn.Visible = False
        Me.FktblProductDataGridViewTextBoxColumn.Width = 150
        '
        'DblLabourCostDataGridViewTextBoxColumn
        '
        Me.DblLabourCostDataGridViewTextBoxColumn.DataPropertyName = "dblLabourCost"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N4"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DblLabourCostDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DblLabourCostDataGridViewTextBoxColumn.HeaderText = "Labour Cost"
        Me.DblLabourCostDataGridViewTextBoxColumn.Name = "DblLabourCostDataGridViewTextBoxColumn"
        '
        'diaMarginPopup
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(299, 315)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "diaMarginPopup"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Dialog1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsActivityDB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProdDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProdLinkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblElementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsActivityDB1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProdDB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents DsProdDB As CCP.dsProdDB
    Friend WithEvents TblProdLinkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProdLinkTableAdapter As CCP.dsProdDBTableAdapters.tblProdLinkTableAdapter
    Friend WithEvents DsProdDB1 As CCP.dsProdDB
    Friend WithEvents TblProdLinkTableAdapter1 As CCP.dsProdDBTableAdapters.tblProdLinkTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DsActivityDB1 As CCP.dsActivityDB
    Friend WithEvents TblDeptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblDeptTableAdapter As CCP.dsActivityDBTableAdapters.tblDeptTableAdapter
    Friend WithEvents TblElementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblElementTableAdapter As CCP.dsActivityDBTableAdapters.tblElementTableAdapter
    Friend WithEvents TblProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProductTableAdapter As CCP.dsProdDBTableAdapters.tblProductTableAdapter
    Friend WithEvents DsActivityDB1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblActivityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblActivityTableAdapter As CCP.dsActivityDBTableAdapters.tblActivityTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents FktblDeptDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FktblProductDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DblLabourCostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
