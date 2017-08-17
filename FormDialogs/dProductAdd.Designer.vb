<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dProductAdd
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
Me.GroupBox1 = New System.Windows.Forms.GroupBox()
Me.txtCoID = New System.Windows.Forms.TextBox()
Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProdDB1 = New CCP.dsProdDB()
        Me.txtSortItem = New System.Windows.Forms.TextBox()
        Me.txtSortCat = New System.Windows.Forms.TextBox()
        Me.txtSpec3 = New System.Windows.Forms.TextBox()
        Me.txtSpec2 = New System.Windows.Forms.TextBox()
        Me.txtSpec1 = New System.Windows.Forms.TextBox()
        Me.txtProdDesc = New System.Windows.Forms.TextBox()
        Me.txtProdCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TblProductTableAdapter1 = New CCP.dsProdDBTableAdapters.tblProductTableAdapter()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProdDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(420, 375)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 100
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 101
        Me.Cancel_Button.Text = "Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtCoID)
        Me.GroupBox1.Controls.Add(Me.txtSortItem)
        Me.GroupBox1.Controls.Add(Me.txtSortCat)
        Me.GroupBox1.Controls.Add(Me.txtSpec3)
        Me.GroupBox1.Controls.Add(Me.txtSpec2)
        Me.GroupBox1.Controls.Add(Me.txtSpec1)
        Me.GroupBox1.Controls.Add(Me.txtProdDesc)
        Me.GroupBox1.Controls.Add(Me.txtProdCode)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 297)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Detail"
        '
        'txtCoID
        '
        Me.txtCoID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "FK_idtblCoInfo", True))
        Me.txtCoID.Location = New System.Drawing.Point(151, 30)
        Me.txtCoID.Name = "txtCoID"
        Me.txtCoID.Size = New System.Drawing.Size(40, 22)
        Me.txtCoID.TabIndex = 0
        Me.txtCoID.TabStop = False
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblProduct"
        Me.BindingSource1.DataSource = Me.DsProdDB1
        '
        'DsProdDB1
        '
        Me.DsProdDB1.DataSetName = "dsProdDB"
        Me.DsProdDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtSortItem
        '
        Me.txtSortItem.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "txtCostSortItem", True))
        Me.txtSortItem.Location = New System.Drawing.Point(151, 240)
        Me.txtSortItem.Name = "txtSortItem"
        Me.txtSortItem.Size = New System.Drawing.Size(100, 22)
        Me.txtSortItem.TabIndex = 40
        '
        'txtSortCat
        '
        Me.txtSortCat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "txtCostSortCat", True))
        Me.txtSortCat.Location = New System.Drawing.Point(151, 210)
        Me.txtSortCat.Name = "txtSortCat"
        Me.txtSortCat.Size = New System.Drawing.Size(100, 22)
        Me.txtSortCat.TabIndex = 30
        '
        'txtSpec3
        '
        Me.txtSpec3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "txtProdSpec3", True))
        Me.txtSpec3.Location = New System.Drawing.Point(151, 180)
        Me.txtSpec3.Name = "txtSpec3"
        Me.txtSpec3.Size = New System.Drawing.Size(254, 22)
        Me.txtSpec3.TabIndex = 25
        '
        'txtSpec2
        '
        Me.txtSpec2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "txtProdSpec2", True))
        Me.txtSpec2.Location = New System.Drawing.Point(151, 150)
        Me.txtSpec2.Name = "txtSpec2"
        Me.txtSpec2.Size = New System.Drawing.Size(254, 22)
        Me.txtSpec2.TabIndex = 20
        '
        'txtSpec1
        '
        Me.txtSpec1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "txtProdSpec1", True))
        Me.txtSpec1.Location = New System.Drawing.Point(151, 120)
        Me.txtSpec1.Name = "txtSpec1"
        Me.txtSpec1.Size = New System.Drawing.Size(254, 22)
        Me.txtSpec1.TabIndex = 15
        '
        'txtProdDesc
        '
        Me.txtProdDesc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "txtProdDesc", True))
        Me.txtProdDesc.Location = New System.Drawing.Point(151, 90)
        Me.txtProdDesc.Name = "txtProdDesc"
        Me.txtProdDesc.Size = New System.Drawing.Size(254, 22)
        Me.txtProdDesc.TabIndex = 10
        '
        'txtProdCode
        '
        Me.txtProdCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "txtProdCde", True))
        Me.txtProdCode.Location = New System.Drawing.Point(151, 60)
        Me.txtProdCode.Name = "txtProdCode"
        Me.txtProdCode.Size = New System.Drawing.Size(100, 22)
        Me.txtProdCode.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Sorting Item"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Sorting Category"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Company"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Specification 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Specification 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Specification 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Product code"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TblProductTableAdapter1
        '
        Me.TblProductTableAdapter1.ClearBeforeFill = True
        '
        'dProductAdd
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(631, 426)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dProductAdd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "dProductAdd"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProdDB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCoID As System.Windows.Forms.TextBox
    Friend WithEvents txtSortItem As System.Windows.Forms.TextBox
    Friend WithEvents txtSortCat As System.Windows.Forms.TextBox
    Friend WithEvents txtSpec3 As System.Windows.Forms.TextBox
    Friend WithEvents txtSpec2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSpec1 As System.Windows.Forms.TextBox
    Friend WithEvents txtProdDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtProdCode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DsProdDB1 As CCP.dsProdDB
    Friend WithEvents TblProductTableAdapter1 As CCP.dsProdDBTableAdapters.tblProductTableAdapter
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
