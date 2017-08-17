<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class diaFabric
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblMaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccounting = New CCP.dsAccounting()
        Me.TblProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProductTableAdapter = New CCP.dsAccountingTableAdapters.tblProductTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TblMaterialTableAdapter1 = New CCP.dsProdDBTableAdapters.tblMaterialTableAdapter()
        Me.TblMaterialTableAdapter2 = New CCP.dsAccountingTableAdapters.tblMaterialTableAdapter()
        Me.IdtblMaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TxtMaterialNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtMaterialDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtMatspec1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtMatSpec2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtMatSpec3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtMaterialUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DblMaterialPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccounting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(687, 274)
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
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtblMaterialDataGridViewTextBoxColumn, Me.TxtTypeDataGridViewTextBoxColumn, Me.TxtMaterialNoDataGridViewTextBoxColumn, Me.TxtMaterialDescDataGridViewTextBoxColumn, Me.TxtMatspec1DataGridViewTextBoxColumn, Me.TxtMatSpec2DataGridViewTextBoxColumn, Me.TxtMatSpec3DataGridViewTextBoxColumn, Me.TxtMaterialUnitDataGridViewTextBoxColumn, Me.DblMaterialPriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblMaterialBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(846, 270)
        Me.DataGridView1.TabIndex = 1
        '
        'TblMaterialBindingSource
        '
        Me.TblMaterialBindingSource.DataMember = "tblMaterial"
        Me.TblMaterialBindingSource.DataSource = Me.DsAccounting
        '
        'DsAccounting
        '
        Me.DsAccounting.DataSetName = "dsAccounting"
        Me.DsAccounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProductBindingSource
        '
        Me.TblProductBindingSource.DataMember = "tblProduct"
        Me.TblProductBindingSource.DataSource = Me.DsAccounting
        '
        'TblProductTableAdapter
        '
        Me.TblProductTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-1, 279)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TblMaterialTableAdapter1
        '
        Me.TblMaterialTableAdapter1.ClearBeforeFill = True
        '
        'TblMaterialTableAdapter2
        '
        Me.TblMaterialTableAdapter2.ClearBeforeFill = True
        '
        'IdtblMaterialDataGridViewTextBoxColumn
        '
        Me.IdtblMaterialDataGridViewTextBoxColumn.DataPropertyName = "id_tblMaterial"
        Me.IdtblMaterialDataGridViewTextBoxColumn.HeaderText = "id_tblMaterial"
        Me.IdtblMaterialDataGridViewTextBoxColumn.Name = "IdtblMaterialDataGridViewTextBoxColumn"
        Me.IdtblMaterialDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdtblMaterialDataGridViewTextBoxColumn.Visible = False
        '
        'TxtTypeDataGridViewTextBoxColumn
        '
        Me.TxtTypeDataGridViewTextBoxColumn.DataPropertyName = "txtType"
        Me.TxtTypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TxtTypeDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Direct"})
        Me.TxtTypeDataGridViewTextBoxColumn.Name = "TxtTypeDataGridViewTextBoxColumn"
        Me.TxtTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TxtTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TxtTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TxtMaterialNoDataGridViewTextBoxColumn
        '
        Me.TxtMaterialNoDataGridViewTextBoxColumn.DataPropertyName = "txtMaterialNo"
        Me.TxtMaterialNoDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.TxtMaterialNoDataGridViewTextBoxColumn.Name = "TxtMaterialNoDataGridViewTextBoxColumn"
        Me.TxtMaterialNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtMaterialDescDataGridViewTextBoxColumn
        '
        Me.TxtMaterialDescDataGridViewTextBoxColumn.DataPropertyName = "txtMaterialDesc"
        Me.TxtMaterialDescDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.TxtMaterialDescDataGridViewTextBoxColumn.Name = "TxtMaterialDescDataGridViewTextBoxColumn"
        Me.TxtMaterialDescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtMatspec1DataGridViewTextBoxColumn
        '
        Me.TxtMatspec1DataGridViewTextBoxColumn.DataPropertyName = "txtMatspec1"
        Me.TxtMatspec1DataGridViewTextBoxColumn.HeaderText = "Spec1"
        Me.TxtMatspec1DataGridViewTextBoxColumn.Name = "TxtMatspec1DataGridViewTextBoxColumn"
        Me.TxtMatspec1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtMatSpec2DataGridViewTextBoxColumn
        '
        Me.TxtMatSpec2DataGridViewTextBoxColumn.DataPropertyName = "txtMatSpec2"
        Me.TxtMatSpec2DataGridViewTextBoxColumn.HeaderText = "Spec2"
        Me.TxtMatSpec2DataGridViewTextBoxColumn.Name = "TxtMatSpec2DataGridViewTextBoxColumn"
        Me.TxtMatSpec2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtMatSpec3DataGridViewTextBoxColumn
        '
        Me.TxtMatSpec3DataGridViewTextBoxColumn.DataPropertyName = "txtMatSpec3"
        Me.TxtMatSpec3DataGridViewTextBoxColumn.HeaderText = "Spec3"
        Me.TxtMatSpec3DataGridViewTextBoxColumn.Name = "TxtMatSpec3DataGridViewTextBoxColumn"
        Me.TxtMatSpec3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TxtMaterialUnitDataGridViewTextBoxColumn
        '
        Me.TxtMaterialUnitDataGridViewTextBoxColumn.DataPropertyName = "txtMaterialUnit"
        Me.TxtMaterialUnitDataGridViewTextBoxColumn.HeaderText = "Unit of Measure"
        Me.TxtMaterialUnitDataGridViewTextBoxColumn.Name = "TxtMaterialUnitDataGridViewTextBoxColumn"
        Me.TxtMaterialUnitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DblMaterialPriceDataGridViewTextBoxColumn
        '
        Me.DblMaterialPriceDataGridViewTextBoxColumn.DataPropertyName = "dblMaterialPrice"
        Me.DblMaterialPriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.DblMaterialPriceDataGridViewTextBoxColumn.Name = "DblMaterialPriceDataGridViewTextBoxColumn"
        Me.DblMaterialPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'diaFabric
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(845, 315)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "diaFabric"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "diaFabric"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccounting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DsAccounting As CCP.dsAccounting
    Friend WithEvents TblProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProductTableAdapter As CCP.dsAccountingTableAdapters.tblProductTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TblMaterialTableAdapter1 As CCP.dsProdDBTableAdapters.tblMaterialTableAdapter
    Friend WithEvents TblMaterialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMaterialTableAdapter2 As CCP.dsAccountingTableAdapters.tblMaterialTableAdapter
    Friend WithEvents IdtblMaterialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TxtMaterialNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtMaterialDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtMatspec1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtMatSpec2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtMatSpec3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtMaterialUnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DblMaterialPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
