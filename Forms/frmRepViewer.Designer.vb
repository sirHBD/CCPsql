<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepViewer
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepViewer))
        Me.tblProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyProdDBDataSet = New CCP.MyProdDBDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ts1_Exp_Word = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts1_Exp_Excel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts1_Exp_PDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts1_Print = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts1_Email = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts1_Close = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.LstPOHeaderDetailsTableAdapter1 = New CCP.dsProductionTableAdapters.lstPOHeaderDetailsTableAdapter()
        Me.rptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProductTableAdapter1 = New CCP.MyProdDBDataSetTableAdapters.tblProductTableAdapter()
        Me.TblCoInfoTableAdapter = New CCP.MyProdDBDataSetTableAdapters.tblCoInfoTableAdapter()
        Me.LstQuoteHeaderDetailsTableAdapter1 = New CCP.MyProdDBDataSetTableAdapters.lstQuoteHeaderDetailsTableAdapter()
        Me.LstReceiptsTableAdapter1 = New CCP.MyProdDBDataSetTableAdapters.lstReceiptsTableAdapter()
        Me.LstInvoiceHeaderDetailsTableAdapter1 = New CCP.MyProdDBDataSetTableAdapters.lstInvoiceHeaderDetailsTableAdapter()
        Me.LstPOHeaderDetailsTableAdapter2 = New CCP.MyProdDBDataSetTableAdapters.lstPOHeaderDetailsTableAdapter()
        Me.LstJCDetailsTableAdapter1 = New CCP.MyProdDBDataSetTableAdapters.lstJCDetailsTableAdapter()
        Me.TblJCMaterialTableAdapter1 = New CCP.MyProdDBDataSetTableAdapters.tblJCMaterialTableAdapter()
        Me.TblJCLabourTableAdapter1 = New CCP.MyProdDBDataSetTableAdapters.tblJCLabourTableAdapter()
        CType(Me.tblProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyProdDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.rptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblProductBindingSource
        '
        Me.tblProductBindingSource.DataMember = "tblProduct"
        Me.tblProductBindingSource.DataSource = Me.MyProdDBDataSet
        '
        'MyProdDBDataSet
        '
        Me.MyProdDBDataSet.DataSetName = "MyProdDBDataSet"
        Me.MyProdDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.AutoScroll = True
        Me.ReportViewer1.AutoSize = True
        ReportDataSource1.Name = "dsProd"
        ReportDataSource1.Value = Me.tblProductBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "da_CostProj.rptProductList.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 26)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowToolBar = False
        Me.ReportViewer1.Size = New System.Drawing.Size(762, 518)
        Me.ReportViewer1.TabIndex = 0
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator1, Me.ToolStripDropDownButton1, Me.ToolStripSeparator3, Me.ts1_Print, Me.ToolStripSeparator4, Me.ts1_Email, Me.ToolStripSeparator5, Me.ts1_Close, Me.ToolStripSeparator8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(762, 26)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.AutoSize = False
        Me.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts1_Exp_Word, Me.ts1_Exp_Excel, Me.ts1_Exp_PDF})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(59, 23)
        Me.ToolStripDropDownButton1.Text = "Export"
        '
        'ts1_Exp_Word
        '
        Me.ts1_Exp_Word.Name = "ts1_Exp_Word"
        Me.ts1_Exp_Word.Size = New System.Drawing.Size(109, 22)
        Me.ts1_Exp_Word.Text = "Word"
        '
        'ts1_Exp_Excel
        '
        Me.ts1_Exp_Excel.Name = "ts1_Exp_Excel"
        Me.ts1_Exp_Excel.Size = New System.Drawing.Size(109, 22)
        Me.ts1_Exp_Excel.Text = "Excel"
        '
        'ts1_Exp_PDF
        '
        Me.ts1_Exp_PDF.Name = "ts1_Exp_PDF"
        Me.ts1_Exp_PDF.Size = New System.Drawing.Size(109, 22)
        Me.ts1_Exp_PDF.Text = "PDF"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 26)
        '
        'ts1_Print
        '
        Me.ts1_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts1_Print.Image = CType(resources.GetObject("ts1_Print.Image"), System.Drawing.Image)
        Me.ts1_Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts1_Print.Name = "ts1_Print"
        Me.ts1_Print.Size = New System.Drawing.Size(39, 23)
        Me.ts1_Print.Text = "Print"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 26)
        '
        'ts1_Email
        '
        Me.ts1_Email.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts1_Email.Image = CType(resources.GetObject("ts1_Email.Image"), System.Drawing.Image)
        Me.ts1_Email.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts1_Email.Name = "ts1_Email"
        Me.ts1_Email.Size = New System.Drawing.Size(45, 23)
        Me.ts1_Email.Text = "Email"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 26)
        '
        'ts1_Close
        '
        Me.ts1_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts1_Close.Image = CType(resources.GetObject("ts1_Close.Image"), System.Drawing.Image)
        Me.ts1_Close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts1_Close.Name = "ts1_Close"
        Me.ts1_Close.Size = New System.Drawing.Size(79, 23)
        Me.ts1_Close.Text = "Close Form"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 26)
        '
        'LstPOHeaderDetailsTableAdapter1
        '
        Me.LstPOHeaderDetailsTableAdapter1.ClearBeforeFill = True
        '
        'rptBindingSource
        '
        Me.rptBindingSource.DataMember = "tblCoInfo"
        Me.rptBindingSource.DataSource = Me.MyProdDBDataSet
        '
        'TblProductTableAdapter1
        '
        Me.TblProductTableAdapter1.ClearBeforeFill = True
        '
        'TblCoInfoTableAdapter
        '
        Me.TblCoInfoTableAdapter.ClearBeforeFill = True
        '
        'LstQuoteHeaderDetailsTableAdapter1
        '
        Me.LstQuoteHeaderDetailsTableAdapter1.ClearBeforeFill = True
        '
        'LstReceiptsTableAdapter1
        '
        Me.LstReceiptsTableAdapter1.ClearBeforeFill = True
        '
        'LstInvoiceHeaderDetailsTableAdapter1
        '
        Me.LstInvoiceHeaderDetailsTableAdapter1.ClearBeforeFill = True
        '
        'LstPOHeaderDetailsTableAdapter2
        '
        Me.LstPOHeaderDetailsTableAdapter2.ClearBeforeFill = True
        '
        'LstJCDetailsTableAdapter1
        '
        Me.LstJCDetailsTableAdapter1.ClearBeforeFill = True
        '
        'TblJCMaterialTableAdapter1
        '
        Me.TblJCMaterialTableAdapter1.ClearBeforeFill = True
        '
        'TblJCLabourTableAdapter1
        '
        Me.TblJCLabourTableAdapter1.ClearBeforeFill = True
        '
        'frmRepViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 545)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmRepViewer"
        Me.Text = "frmRepViewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tblProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyProdDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.rptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MyProdDBDataSet As CCP.MyProdDBDataSet
    Friend WithEvents TblProductTableAdapter1 As CCP.MyProdDBDataSetTableAdapters.tblProductTableAdapter
    Friend WithEvents rptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCoInfoTableAdapter As CCP.MyProdDBDataSetTableAdapters.tblCoInfoTableAdapter
    Friend WithEvents LstQuoteHeaderDetailsTableAdapter1 As CCP.MyProdDBDataSetTableAdapters.lstQuoteHeaderDetailsTableAdapter
    Friend WithEvents LstReceiptsTableAdapter1 As CCP.MyProdDBDataSetTableAdapters.lstReceiptsTableAdapter
    Friend WithEvents LstInvoiceHeaderDetailsTableAdapter1 As CCP.MyProdDBDataSetTableAdapters.lstInvoiceHeaderDetailsTableAdapter
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ts1_Exp_Word As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts1_Exp_Excel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts1_Exp_PDF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts1_Print As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts1_Email As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts1_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LstPOHeaderDetailsTableAdapter1 As CCP.dsProductionTableAdapters.lstPOHeaderDetailsTableAdapter
    Friend WithEvents LstPOHeaderDetailsTableAdapter2 As CCP.MyProdDBDataSetTableAdapters.lstPOHeaderDetailsTableAdapter
    Friend WithEvents LstJCDetailsTableAdapter1 As CCP.MyProdDBDataSetTableAdapters.lstJCDetailsTableAdapter
    Friend WithEvents TblJCMaterialTableAdapter1 As CCP.MyProdDBDataSetTableAdapters.tblJCMaterialTableAdapter
    Friend WithEvents TblJCLabourTableAdapter1 As CCP.MyProdDBDataSetTableAdapters.tblJCLabourTableAdapter
    'Friend WithEvents TblCoInfoTableAdapter1 As da_CostProj.MyProdDBDataSet1TableAdapters.tblCoInfoTableAdapter
End Class
