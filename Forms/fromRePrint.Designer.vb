﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRePrint
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TblPOHeaderTableAdapter1 = New CCP.dsProductionTableAdapters.tblPOHeaderTableAdapter()
        Me.DsProduction1 = New CCP.dsProduction()
        Me.TblJCTableAdapter1 = New CCP.dsProductionTableAdapters.tblJCTableAdapter()
        Me.LstInvoiceHeadersTableAdapter1 = New CCP.dsAccountingTableAdapters.lstInvoiceHeadersTableAdapter()
        Me.DsAccounting1 = New CCP.dsAccounting()
        Me.LstQuoteHeadersTableAdapter1 = New CCP.dsAccountingTableAdapters.lstQuoteHeadersTableAdapter()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccounting1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Quote", "Receipts", "Production order", "Job card", "Invoice"})
        Me.ComboBox1.Location = New System.Drawing.Point(211, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select document type to reprint"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(211, 90)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select document"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Re print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(211, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TblPOHeaderTableAdapter1
        '
        Me.TblPOHeaderTableAdapter1.ClearBeforeFill = True
        '
        'DsProduction1
        '
        Me.DsProduction1.DataSetName = "dsProduction"
        Me.DsProduction1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblJCTableAdapter1
        '
        Me.TblJCTableAdapter1.ClearBeforeFill = True
        '
        'LstInvoiceHeadersTableAdapter1
        '
        Me.LstInvoiceHeadersTableAdapter1.ClearBeforeFill = True
        '
        'DsAccounting1
        '
        Me.DsAccounting1.DataSetName = "dsAccounting"
        Me.DsAccounting1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LstQuoteHeadersTableAdapter1
        '
        Me.LstQuoteHeadersTableAdapter1.ClearBeforeFill = True
        '
        'frmRePrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 261)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frmRePrint"
        Me.Text = "Reprint documents"
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccounting1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TblPOHeaderTableAdapter1 As CCP.dsProductionTableAdapters.tblPOHeaderTableAdapter
    Friend WithEvents DsProduction1 As CCP.dsProduction
    Friend WithEvents TblJCTableAdapter1 As CCP.dsProductionTableAdapters.tblJCTableAdapter
    Friend WithEvents LstInvoiceHeadersTableAdapter1 As CCP.dsAccountingTableAdapters.lstInvoiceHeadersTableAdapter
    Friend WithEvents DsAccounting1 As CCP.dsAccounting
    Friend WithEvents LstQuoteHeadersTableAdapter1 As CCP.dsAccountingTableAdapters.lstQuoteHeadersTableAdapter
End Class
