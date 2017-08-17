<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class diaPopUpMat
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TblMaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMatDB = New CCP.dsMatDB()
        Me.TblMaterialTableAdapter1 = New CCP.dsMatDBTableAdapters.tblMaterialTableAdapter()
        Me.TblMatLinkTableAdapter1 = New CCP.dsMatDBTableAdapters.tblMatLinkTableAdapter()
        Me.TblMatLinkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblMaterialBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdtblMatLinkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FktblProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FktblMaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DblMatQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DblMatCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TblMaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMatDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMatLinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMaterialBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(287, 274)
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
        'DsMatDB
        '
        Me.DsMatDB.DataSetName = "dsMatDB"
        Me.DsMatDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblMaterialTableAdapter1
        '
        Me.TblMaterialTableAdapter1.ClearBeforeFill = True
        '
        'TblMatLinkTableAdapter1
        '
        Me.TblMatLinkTableAdapter1.ClearBeforeFill = True
        '
        'TblMatLinkBindingSource
        '
        Me.TblMatLinkBindingSource.DataMember = "tblMatLink"
        Me.TblMatLinkBindingSource.DataSource = Me.DsMatDB
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtblMatLinkDataGridViewTextBoxColumn, Me.FktblProductDataGridViewTextBoxColumn, Me.FktblMaterialDataGridViewTextBoxColumn, Me.DblMatQtyDataGridViewTextBoxColumn, Me.DblMatCostDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblMatLinkBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(420, 227)
        Me.DataGridView1.TabIndex = 1
        '
        'TblMaterialBindingSource1
        '
        Me.TblMaterialBindingSource1.DataMember = "tblMaterial"
        Me.TblMaterialBindingSource1.DataSource = Me.DsMatDB
        '
        'IdtblMatLinkDataGridViewTextBoxColumn
        '
        Me.IdtblMatLinkDataGridViewTextBoxColumn.DataPropertyName = "id_tblMatLink"
        Me.IdtblMatLinkDataGridViewTextBoxColumn.HeaderText = "id_tblMatLink"
        Me.IdtblMatLinkDataGridViewTextBoxColumn.Name = "IdtblMatLinkDataGridViewTextBoxColumn"
        Me.IdtblMatLinkDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdtblMatLinkDataGridViewTextBoxColumn.Visible = False
        '
        'FktblProductDataGridViewTextBoxColumn
        '
        Me.FktblProductDataGridViewTextBoxColumn.DataPropertyName = "fk_tblProduct"
        Me.FktblProductDataGridViewTextBoxColumn.HeaderText = "fk_tblProduct"
        Me.FktblProductDataGridViewTextBoxColumn.Name = "FktblProductDataGridViewTextBoxColumn"
        Me.FktblProductDataGridViewTextBoxColumn.ReadOnly = True
        Me.FktblProductDataGridViewTextBoxColumn.Visible = False
        '
        'FktblMaterialDataGridViewTextBoxColumn
        '
        Me.FktblMaterialDataGridViewTextBoxColumn.DataPropertyName = "fk_tblMaterial"
        Me.FktblMaterialDataGridViewTextBoxColumn.DataSource = Me.TblMaterialBindingSource1
        Me.FktblMaterialDataGridViewTextBoxColumn.DisplayMember = "txtMaterialDesc"
        Me.FktblMaterialDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.FktblMaterialDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.FktblMaterialDataGridViewTextBoxColumn.Name = "FktblMaterialDataGridViewTextBoxColumn"
        Me.FktblMaterialDataGridViewTextBoxColumn.ReadOnly = True
        Me.FktblMaterialDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FktblMaterialDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FktblMaterialDataGridViewTextBoxColumn.ValueMember = "id_tblMaterial"
        '
        'DblMatQtyDataGridViewTextBoxColumn
        '
        Me.DblMatQtyDataGridViewTextBoxColumn.DataPropertyName = "dblMatQty"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DblMatQtyDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DblMatQtyDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.DblMatQtyDataGridViewTextBoxColumn.Name = "DblMatQtyDataGridViewTextBoxColumn"
        Me.DblMatQtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DblMatCostDataGridViewTextBoxColumn
        '
        Me.DblMatCostDataGridViewTextBoxColumn.DataPropertyName = "dblMatCost"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DblMatCostDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DblMatCostDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.DblMatCostDataGridViewTextBoxColumn.Name = "DblMatCostDataGridViewTextBoxColumn"
        Me.DblMatCostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'diaPopUpMat
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(445, 315)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "diaPopUpMat"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "diaPopUpMat"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.TblMaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMatDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMatLinkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMaterialBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents DsMatDB As CCP.dsMatDB
    Friend WithEvents TblMaterialTableAdapter1 As CCP.dsMatDBTableAdapters.tblMaterialTableAdapter
    Friend WithEvents TblMaterialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMatLinkTableAdapter1 As CCP.dsMatDBTableAdapters.tblMatLinkTableAdapter
    Friend WithEvents TblMatLinkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TblMaterialBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IdtblMatLinkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FktblProductDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FktblMaterialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DblMatQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DblMatCostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
