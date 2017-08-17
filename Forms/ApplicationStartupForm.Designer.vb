<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApplicationStartupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApplicationStartupForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_Admin = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsAdmin_CoInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAdmin_Clear = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunSQLScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_DataInput = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsData_Customer = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsData_Product = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsData_Supplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsData_Materials = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsData_Labour = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsData_Overheads = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsData_OHBudget = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsData_OHActuals = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemplateImportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_Imports = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpMaterial = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpStaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_Quote = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_ProdAcc = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ts_Monitor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_Receipt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_Production = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_JobCard = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_Invoice = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_Settlement = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReprintDocumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_Accounting = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_DataAnalysis = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsAnal_Product = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAnal_ProdMargins = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAnal_Labour = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAnal_Material = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAnal_Req = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAnal_ReqMat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAnal_ReqLab = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAnal_LabEff = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_Reports = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsRep_IncomeStmt = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsRep_CashFlowStmt = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsRep_Sales = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsRep_ProdPic = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_Tutorial = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_About = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ss1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ss2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator8, Me.ts_Admin, Me.ToolStripSeparator2, Me.ts_DataInput, Me.ToolStripSeparator3, Me.ts_Quote, Me.ToolStripSeparator4, Me.ts_ProdAcc, Me.ToolStripSeparator5, Me.ts_Accounting, Me.ToolStripSeparator10, Me.ts_DataAnalysis, Me.ToolStripSeparator6, Me.ts_Reports, Me.ToolStripSeparator7, Me.ts_Tutorial, Me.ToolStripSeparator1, Me.ts_About, Me.ToolStripSeparator9})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1112, 45)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "Administration"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 45)
        '
        'ts_Admin
        '
        Me.ts_Admin.BackColor = System.Drawing.Color.White
        Me.ts_Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ts_Admin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts_Admin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAdmin_CoInfo, Me.tsAdmin_Clear, Me.RunSQLScriptToolStripMenuItem})
        Me.ts_Admin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_Admin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ts_Admin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Admin.Margin = New System.Windows.Forms.Padding(2)
        Me.ts_Admin.Name = "ts_Admin"
        Me.ts_Admin.Size = New System.Drawing.Size(133, 41)
        Me.ts_Admin.Text = "Administration"
        '
        'tsAdmin_CoInfo
        '
        Me.tsAdmin_CoInfo.Name = "tsAdmin_CoInfo"
        Me.tsAdmin_CoInfo.Size = New System.Drawing.Size(194, 24)
        Me.tsAdmin_CoInfo.Text = "Company Info"
        '
        'tsAdmin_Clear
        '
        Me.tsAdmin_Clear.Name = "tsAdmin_Clear"
        Me.tsAdmin_Clear.Size = New System.Drawing.Size(194, 24)
        Me.tsAdmin_Clear.Text = "Clear Database"
        '
        'RunSQLScriptToolStripMenuItem
        '
        Me.RunSQLScriptToolStripMenuItem.Name = "RunSQLScriptToolStripMenuItem"
        Me.RunSQLScriptToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.RunSQLScriptToolStripMenuItem.Text = "Run SQL script"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 45)
        '
        'ts_DataInput
        '
        Me.ts_DataInput.BackColor = System.Drawing.Color.White
        Me.ts_DataInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ts_DataInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts_DataInput.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsData_Customer, Me.tsData_Product, Me.tsData_Supplier, Me.tsData_Materials, Me.tsData_Labour, Me.tsData_Overheads, Me.TemplateImportsToolStripMenuItem})
        Me.ts_DataInput.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_DataInput.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ts_DataInput.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_DataInput.Name = "ts_DataInput"
        Me.ts_DataInput.Size = New System.Drawing.Size(100, 42)
        Me.ts_DataInput.Text = "Data Input"
        '
        'tsData_Customer
        '
        Me.tsData_Customer.Name = "tsData_Customer"
        Me.tsData_Customer.Size = New System.Drawing.Size(273, 24)
        Me.tsData_Customer.Text = "Customer"
        '
        'tsData_Product
        '
        Me.tsData_Product.Name = "tsData_Product"
        Me.tsData_Product.Size = New System.Drawing.Size(273, 24)
        Me.tsData_Product.Text = "Product"
        '
        'tsData_Supplier
        '
        Me.tsData_Supplier.Enabled = False
        Me.tsData_Supplier.Name = "tsData_Supplier"
        Me.tsData_Supplier.Size = New System.Drawing.Size(273, 24)
        Me.tsData_Supplier.Text = "Supplier"
        '
        'tsData_Materials
        '
        Me.tsData_Materials.Name = "tsData_Materials"
        Me.tsData_Materials.Size = New System.Drawing.Size(273, 24)
        Me.tsData_Materials.Text = "Materials"
        '
        'tsData_Labour
        '
        Me.tsData_Labour.Name = "tsData_Labour"
        Me.tsData_Labour.Size = New System.Drawing.Size(273, 24)
        Me.tsData_Labour.Text = "Labour"
        '
        'tsData_Overheads
        '
        Me.tsData_Overheads.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsData_OHBudget, Me.tsData_OHActuals})
        Me.tsData_Overheads.Name = "tsData_Overheads"
        Me.tsData_Overheads.Size = New System.Drawing.Size(273, 24)
        Me.tsData_Overheads.Text = "Overheads"
        '
        'tsData_OHBudget
        '
        Me.tsData_OHBudget.Name = "tsData_OHBudget"
        Me.tsData_OHBudget.Size = New System.Drawing.Size(135, 24)
        Me.tsData_OHBudget.Text = "Budget"
        '
        'tsData_OHActuals
        '
        Me.tsData_OHActuals.Enabled = False
        Me.tsData_OHActuals.Name = "tsData_OHActuals"
        Me.tsData_OHActuals.Size = New System.Drawing.Size(135, 24)
        Me.tsData_OHActuals.Text = "Actuals"
        '
        'TemplateImportsToolStripMenuItem
        '
        Me.TemplateImportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_Imports})
        Me.TemplateImportsToolStripMenuItem.Name = "TemplateImportsToolStripMenuItem"
        Me.TemplateImportsToolStripMenuItem.Size = New System.Drawing.Size(273, 24)
        Me.TemplateImportsToolStripMenuItem.Text = "Template Imports/Exports"
        '
        'ts_Imports
        '
        Me.ts_Imports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImpProduct, Me.ImpMaterial, Me.ImpStaff})
        Me.ts_Imports.Name = "ts_Imports"
        Me.ts_Imports.Size = New System.Drawing.Size(136, 24)
        Me.ts_Imports.Text = "Imports"
        '
        'ImpProduct
        '
        Me.ImpProduct.Name = "ImpProduct"
        Me.ImpProduct.Size = New System.Drawing.Size(148, 24)
        Me.ImpProduct.Text = "Products"
        '
        'ImpMaterial
        '
        Me.ImpMaterial.Name = "ImpMaterial"
        Me.ImpMaterial.Size = New System.Drawing.Size(148, 24)
        Me.ImpMaterial.Text = "Material"
        '
        'ImpStaff
        '
        Me.ImpStaff.Name = "ImpStaff"
        Me.ImpStaff.Size = New System.Drawing.Size(148, 24)
        Me.ImpStaff.Text = "Staff"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 45)
        '
        'ts_Quote
        '
        Me.ts_Quote.BackColor = System.Drawing.Color.White
        Me.ts_Quote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts_Quote.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_Quote.Image = CType(resources.GetObject("ts_Quote.Image"), System.Drawing.Image)
        Me.ts_Quote.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Quote.Name = "ts_Quote"
        Me.ts_Quote.Size = New System.Drawing.Size(74, 42)
        Me.ts_Quote.Text = "Quoting"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 45)
        '
        'ts_ProdAcc
        '
        Me.ts_ProdAcc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts_ProdAcc.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_Monitor, Me.ts_Receipt, Me.ts_Production, Me.ts_JobCard, Me.ts_Invoice, Me.ts_Settlement, Me.ReprintDocumentsToolStripMenuItem})
        Me.ts_ProdAcc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_ProdAcc.Image = CType(resources.GetObject("ts_ProdAcc.Image"), System.Drawing.Image)
        Me.ts_ProdAcc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_ProdAcc.Name = "ts_ProdAcc"
        Me.ts_ProdAcc.Size = New System.Drawing.Size(112, 42)
        Me.ts_ProdAcc.Text = "Job Control"
        '
        'ts_Monitor
        '
        Me.ts_Monitor.Name = "ts_Monitor"
        Me.ts_Monitor.Size = New System.Drawing.Size(226, 24)
        Me.ts_Monitor.Text = "Job monitor"
        '
        'ts_Receipt
        '
        Me.ts_Receipt.Name = "ts_Receipt"
        Me.ts_Receipt.Size = New System.Drawing.Size(226, 24)
        Me.ts_Receipt.Text = "Deposit"
        '
        'ts_Production
        '
        Me.ts_Production.Name = "ts_Production"
        Me.ts_Production.Size = New System.Drawing.Size(226, 24)
        Me.ts_Production.Text = "Production order"
        '
        'ts_JobCard
        '
        Me.ts_JobCard.Name = "ts_JobCard"
        Me.ts_JobCard.Size = New System.Drawing.Size(226, 24)
        Me.ts_JobCard.Text = "Job Card"
        '
        'ts_Invoice
        '
        Me.ts_Invoice.Name = "ts_Invoice"
        Me.ts_Invoice.Size = New System.Drawing.Size(226, 24)
        Me.ts_Invoice.Text = "Invoice"
        '
        'ts_Settlement
        '
        Me.ts_Settlement.Name = "ts_Settlement"
        Me.ts_Settlement.Size = New System.Drawing.Size(226, 24)
        Me.ts_Settlement.Text = "Settlement"
        '
        'ReprintDocumentsToolStripMenuItem
        '
        Me.ReprintDocumentsToolStripMenuItem.Name = "ReprintDocumentsToolStripMenuItem"
        Me.ReprintDocumentsToolStripMenuItem.Size = New System.Drawing.Size(226, 24)
        Me.ReprintDocumentsToolStripMenuItem.Text = "Reprint Documents"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 45)
        '
        'ts_Accounting
        '
        Me.ts_Accounting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts_Accounting.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_Accounting.Image = CType(resources.GetObject("ts_Accounting.Image"), System.Drawing.Image)
        Me.ts_Accounting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Accounting.Name = "ts_Accounting"
        Me.ts_Accounting.Size = New System.Drawing.Size(101, 42)
        Me.ts_Accounting.Text = "Accounting"
        Me.ts_Accounting.Visible = False
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 45)
        Me.ToolStripSeparator10.Visible = False
        '
        'ts_DataAnalysis
        '
        Me.ts_DataAnalysis.BackColor = System.Drawing.Color.White
        Me.ts_DataAnalysis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ts_DataAnalysis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts_DataAnalysis.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAnal_Product, Me.tsAnal_Req})
        Me.ts_DataAnalysis.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_DataAnalysis.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ts_DataAnalysis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_DataAnalysis.Name = "ts_DataAnalysis"
        Me.ts_DataAnalysis.Size = New System.Drawing.Size(125, 42)
        Me.ts_DataAnalysis.Text = "Data Analysis"
        '
        'tsAnal_Product
        '
        Me.tsAnal_Product.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAnal_ProdMargins, Me.tsAnal_Labour, Me.tsAnal_Material})
        Me.tsAnal_Product.Name = "tsAnal_Product"
        Me.tsAnal_Product.Size = New System.Drawing.Size(185, 24)
        Me.tsAnal_Product.Text = "Product Cost"
        '
        'tsAnal_ProdMargins
        '
        Me.tsAnal_ProdMargins.Name = "tsAnal_ProdMargins"
        Me.tsAnal_ProdMargins.Size = New System.Drawing.Size(177, 24)
        Me.tsAnal_ProdMargins.Text = "Margins"
        '
        'tsAnal_Labour
        '
        Me.tsAnal_Labour.Enabled = False
        Me.tsAnal_Labour.Name = "tsAnal_Labour"
        Me.tsAnal_Labour.Size = New System.Drawing.Size(177, 24)
        Me.tsAnal_Labour.Text = "Labour Cost"
        '
        'tsAnal_Material
        '
        Me.tsAnal_Material.Enabled = False
        Me.tsAnal_Material.Name = "tsAnal_Material"
        Me.tsAnal_Material.Size = New System.Drawing.Size(177, 24)
        Me.tsAnal_Material.Text = "Material Cost"
        '
        'tsAnal_Req
        '
        Me.tsAnal_Req.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAnal_ReqMat, Me.tsAnal_ReqLab, Me.tsAnal_LabEff})
        Me.tsAnal_Req.Name = "tsAnal_Req"
        Me.tsAnal_Req.Size = New System.Drawing.Size(185, 24)
        Me.tsAnal_Req.Text = "Requirements"
        '
        'tsAnal_ReqMat
        '
        Me.tsAnal_ReqMat.Name = "tsAnal_ReqMat"
        Me.tsAnal_ReqMat.Size = New System.Drawing.Size(212, 24)
        Me.tsAnal_ReqMat.Text = "Materials"
        '
        'tsAnal_ReqLab
        '
        Me.tsAnal_ReqLab.Name = "tsAnal_ReqLab"
        Me.tsAnal_ReqLab.Size = New System.Drawing.Size(212, 24)
        Me.tsAnal_ReqLab.Text = "Labour"
        '
        'tsAnal_LabEff
        '
        Me.tsAnal_LabEff.Name = "tsAnal_LabEff"
        Me.tsAnal_LabEff.Size = New System.Drawing.Size(212, 24)
        Me.tsAnal_LabEff.Text = "Labour Efficiency"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 45)
        '
        'ts_Reports
        '
        Me.ts_Reports.BackColor = System.Drawing.Color.White
        Me.ts_Reports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts_Reports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsRep_IncomeStmt, Me.tsRep_CashFlowStmt, Me.tsRep_Sales, Me.tsRep_ProdPic})
        Me.ts_Reports.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_Reports.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ts_Reports.Image = CType(resources.GetObject("ts_Reports.Image"), System.Drawing.Image)
        Me.ts_Reports.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Reports.Name = "ts_Reports"
        Me.ts_Reports.Size = New System.Drawing.Size(83, 42)
        Me.ts_Reports.Text = "Reports"
        '
        'tsRep_IncomeStmt
        '
        Me.tsRep_IncomeStmt.Name = "tsRep_IncomeStmt"
        Me.tsRep_IncomeStmt.Size = New System.Drawing.Size(240, 24)
        Me.tsRep_IncomeStmt.Text = "Income Statement"
        '
        'tsRep_CashFlowStmt
        '
        Me.tsRep_CashFlowStmt.Name = "tsRep_CashFlowStmt"
        Me.tsRep_CashFlowStmt.Size = New System.Drawing.Size(240, 24)
        Me.tsRep_CashFlowStmt.Text = "Cash Flow Statement"
        '
        'tsRep_Sales
        '
        Me.tsRep_Sales.Enabled = False
        Me.tsRep_Sales.Name = "tsRep_Sales"
        Me.tsRep_Sales.Size = New System.Drawing.Size(240, 24)
        Me.tsRep_Sales.Text = "Sales per Month"
        '
        'tsRep_ProdPic
        '
        Me.tsRep_ProdPic.Name = "tsRep_ProdPic"
        Me.tsRep_ProdPic.Size = New System.Drawing.Size(240, 24)
        Me.tsRep_ProdPic.Text = "View product picture"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 45)
        '
        'ts_Tutorial
        '
        Me.ts_Tutorial.BackColor = System.Drawing.Color.White
        Me.ts_Tutorial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts_Tutorial.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_Tutorial.Image = CType(resources.GetObject("ts_Tutorial.Image"), System.Drawing.Image)
        Me.ts_Tutorial.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Tutorial.Name = "ts_Tutorial"
        Me.ts_Tutorial.Size = New System.Drawing.Size(70, 42)
        Me.ts_Tutorial.Text = "Tutorial"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 45)
        '
        'ts_About
        '
        Me.ts_About.BackColor = System.Drawing.Color.White
        Me.ts_About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts_About.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_About.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ts_About.Image = CType(resources.GetObject("ts_About.Image"), System.Drawing.Image)
        Me.ts_About.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_About.Name = "ts_About"
        Me.ts_About.Size = New System.Drawing.Size(59, 42)
        Me.ts_About.Text = "About"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 45)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ss1, Me.ss2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 686)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1112, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ss1
        '
        Me.ss1.Name = "ss1"
        Me.ss1.Size = New System.Drawing.Size(16, 17)
        Me.ss1.Text = "..."
        '
        'ss2
        '
        Me.ss2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ss2.Name = "ss2"
        Me.ss2.Size = New System.Drawing.Size(16, 17)
        Me.ss2.Text = "..."
        Me.ss2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ApplicationStartupForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1112, 708)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "ApplicationStartupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ts_DataInput As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsData_Customer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsData_Product As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsData_Supplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_DataAnalysis As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ts_Tutorial As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_About As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_Admin As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsAdmin_CoInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAdmin_Clear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_Reports As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsRep_IncomeStmt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsRep_CashFlowStmt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsRep_Sales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAnal_Product As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAnal_ProdMargins As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAnal_Labour As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAnal_Material As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAnal_Req As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAnal_ReqMat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAnal_ReqLab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAnal_LabEff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsData_Labour As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsData_Overheads As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsData_OHBudget As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsData_OHActuals As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsData_Materials As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ss1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ss2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TemplateImportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_Imports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ImpProduct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImpMaterial As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImpStaff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsRep_ProdPic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_ProdAcc As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ts_Production As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReprintDocumentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_Accounting As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_Quote As System.Windows.Forms.ToolStripButton
    Friend WithEvents RunSQLScriptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_Monitor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_Receipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_JobCard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_Invoice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_Settlement As System.Windows.Forms.ToolStripMenuItem

End Class
