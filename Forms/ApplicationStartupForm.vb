Imports System.Drawing
Imports System.IO


Public Class ApplicationStartupForm

    Private Sub ApplicationStartupForm_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        If QQ_Variables.xNewID > -1 Then
            Dim xResponse As MsgBoxResult
            xResponse = MsgBox("A current product exist that has not been saved.  The product is " & QQ_Variables.xProdCode & " " & QQ_Variables.xProdDesc & ".  This product must first be saved or deleted.  Do you want to save the product?", MsgBoxStyle.YesNoCancel, My.Settings.SysName)
            If xResponse = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            If xResponse = MsgBoxResult.No Then
                MiscCode.DeleteTmpProduct(QQ_Variables.xNewID)
                QQ_Variables.xNewID = -1
                QQ_Variables.xProdCopyID = 0
                QQ_Variables.xProdCode = String.Empty
                QQ_Variables.xProdDesc = String.Empty
                QQ_Variables.xSpec1 = String.Empty
                QQ_Variables.xSpec2 = String.Empty
                QQ_Variables.xSpec3 = String.Empty
            End If
            If xResponse = MsgBoxResult.Yes Then
                QQ_Variables.xNewID = -1
                QQ_Variables.xProdCopyID = 0
                QQ_Variables.xProdCode = String.Empty
                QQ_Variables.xProdDesc = String.Empty
                QQ_Variables.xSpec1 = String.Empty
                QQ_Variables.xSpec2 = String.Empty
                QQ_Variables.xSpec3 = String.Empty
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = My.Settings.SysName & "SQL version"
        Dim spl As New ApplicationSplashScreen
        spl.MdiParent = Me
        spl.Show()
        Me.ToolStripSeparator1.BackColor = MySeperatorColor
        Me.ToolStripSeparator2.BackColor = MySeperatorColor
        Me.ToolStripSeparator3.BackColor = MySeperatorColor
        Me.ToolStripSeparator4.BackColor = MySeperatorColor
        Me.ToolStripSeparator5.BackColor = MySeperatorColor
        Me.ToolStripSeparator6.BackColor = MySeperatorColor
        Me.ToolStripSeparator7.BackColor = MySeperatorColor
        Me.ToolStripSeparator8.BackColor = MySeperatorColor

        If My.Settings.SqlScript.ToString().StartsWith("SqlScript") Then
            MsgBox("Please run the sql script before continuing with Cost Coach Pro")
        End If

        If My.Settings.SqlScript.ToString().StartsWith("Busy") Then
            MsgBox("Another user is busy updating the database with a script.  Please allow this process to finish before continuing")
            Application.Exit()
        End If
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Invalidate()

    End Sub

    Private Sub FillActiveChildFormToClient()
        Dim child As Form = Me.ActiveMdiChild
        Dim mdiClientArea As Rectangle = Rectangle.Empty
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is MdiClient Then
                mdiClientArea = c.ClientRectangle
            End If
        Next
        child.Bounds = mdiClientArea
    End Sub

    Private Sub tsAdmin_CoInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsAdmin_CoInfo.Click
        Dim frm As New frmCoParms
        frm.MdiParent = Me
        'Me.ActivateMdiChild(frm)

        frm.Show()
        FillActiveChildFormToClient()
    End Sub

    Private Sub tsAdmin_Clear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsAdmin_Clear.Click
        Dim xMsgResult As String = MsgBox("Are you sure you want to clear all data - It can not be restored", MsgBoxStyle.YesNo, My.Settings.SysName)

        If xMsgResult = 7 Then
            Exit Sub

        Else

            'Dim con As New SqlClient.SqlConnection(My.Settings.ConnectionString)
            ''Dim cat As New ADOX.Catalog
            'Dim constr As String = My.Settings.ConnectionString.ToString
            ''con.Open(constr)
            'con.Open()

            ''cat.ActiveConnection = con
            ''Dim tbl As ADOX.Table
            'For Each tbl In cat.Tables
            '    If tbl.Type = "TABLE" Then con.Execute("Delete from [" & tbl.Name & "]")
            'Next
            'tbl = Nothing
            'cat = Nothing
            'con.Close() : con = Nothing

        End If
    End Sub

    Private Sub tsData_OHBudget_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsData_OHBudget.Click
        Dim frm As New frmOH
        frm.MdiParent = Me
        Try
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub tsData_OpsStaff_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim frm As New frmStaff
        frm.MdiParent = Me
        Try
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub tsData_Activities_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim frm As New frmLabourAdd
        frm.MdiParent = Me
        Try
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub tsRep_IncomeStmt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsRep_IncomeStmt.Click
        Dim frm As New frmOutputPerMonth
        frm.MdiParent = Me
        Try
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub tsData_Product_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsData_Product.Click
        Dim frm As New frmProduct
        frm.MdiParent = Me
        Try
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub tsData_Materials_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsData_Materials.Click
        Dim frm As New frmMaterial
        frm.MdiParent = Me
        Try
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub tsData_Labour_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsData_Labour.Click
        Dim frm As New frmStaff
        frm.MdiParent = Me
        Try
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub tsAnal_ProdMargins_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsAnal_ProdMargins.Click
        Dim frm As New frmOutput_ProdMar
        frm.MdiParent = Me
        Try
            frm.Show()
            'MsgBox("Under construction", , "Cost Coach Pro Messages")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub ts_Tutorial_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ts_Tutorial.Click

        System.Diagnostics.Process.Start(My.Application.Deployment.DataDirectory & "\tutorial.txt")

    End Sub

    Private Sub tsQuote_QQ_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim frm As New frmQuick
        frm.MdiParent = Me
        Try
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub tsAnal_ReqMat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsAnal_ReqMat.Click
        Dim frm As New frmOutputReq
        frm.MdiParent = Me
        Try
            frm.Tag = ""
            frm.Show()
            'MsgBox("Under construction", , "Cost Coach Pro Messages")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub tsAnal_ReqLab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsAnal_ReqLab.Click
        Dim frm As New frmOutputReq
        frm.MdiParent = Me
        Try
            frm.Tag = "Labour"
            frm.Show()
            'MsgBox("Under construction", , "Cost Coach Pro Messages")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub tsRep_CashFlowStmt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsRep_CashFlowStmt.Click
        Dim frm As New frmOutputCF
        frm.MdiParent = Me
        Try
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub ts_About_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ts_About.Click
        Dim frm As New MyAbout
        'frm.MdiParent = Me
        Try
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' FillActiveChildFormToClient()
    End Sub

    Private Sub tsAnal_LabEff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsAnal_LabEff.Click
        Dim frm As New frmOutputReq_Adj
        frm.MdiParent = Me
        Try
            frm.Tag = "Labour"
            frm.Show()
            'MsgBox("Under construction", , "Cost Coach Pro Messages")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub tsData_Customer_Click(sender As System.Object, e As System.EventArgs) Handles tsData_Customer.Click
        Dim frm As New frmCustomer
        frm.MdiParent = Me
        Try

            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub ts_Quote_Click(sender As System.Object, e As System.EventArgs) Handles ts_Quote.Click
        Dim frm As New frmQuick
        frm.MdiParent = Me
        Try
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub ImpProduct_Click1(sender As Object, e As System.EventArgs) Handles ImpProduct.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        If fd.ShowDialog() = DialogResult.OK Then
            Dim xFile As String = fd.FileName
            MiscCode.ImportProduct(xFile)
        End If
    End Sub

    Private Sub ImpMaterial_Click(sender As Object, e As System.EventArgs) Handles ImpMaterial.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        If fd.ShowDialog() = DialogResult.OK Then
            Dim xFile As String = fd.FileName
            MiscCode.ImportMaterial(xFile)
        End If

    End Sub

    Private Sub ImpStaff_Click(sender As Object, e As System.EventArgs) Handles ImpStaff.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        If fd.ShowDialog() = DialogResult.OK Then
            Dim xFile As String = fd.FileName
            MiscCode.ImportStaff(xFile)
        End If
    End Sub

    Private Sub tsRep_ProdPic_Click(sender As Object, e As System.EventArgs) Handles tsRep_ProdPic.Click
        Dim frm As New frmViewProduct
        frm.Show()

    End Sub

    Private Sub ts_Production_Click(sender As Object, e As System.EventArgs) Handles ts_Production.Click
        Dim frm As New frmProduction
        frm.MdiParent = Me
        Try
            frm.jcCombo1.SelectedItem = "Order"
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub ReprintDocumentsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReprintDocumentsToolStripMenuItem.Click
        Dim frm As New frmRePrint
        frm.Show()
    End Sub

    Private Sub ts_Accounting_Click(sender As Object, e As System.EventArgs) Handles ts_Accounting.Click
        Dim frm As New frmAccountingMain
        frm.MdiParent = Me
        Try
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub RunSQLScriptToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RunSQLScriptToolStripMenuItem.Click
        Dim xSQL As String = My.Settings.SqlScript

        Try

            My.Settings.SqlScript = "Busy"
            Dim cmd As New SqlClient.SqlCommand
            'cmd.Transaction = Application.Transaction
            Dim xCon As New SqlClient.SqlConnection(My.Settings.ConnectionString1)
            cmd.Connection = xCon

            cmd.CommandType = CommandType.Text

            xCon.Open()

            Dim dbScriptFile As String
            Dim appPath As String = Path.GetDirectoryName(Application.ExecutablePath)
            Dim frm As New Windows.Forms.OpenFileDialog
            frm.Filter = "(*.sql)|*.sql"
            frm.RestoreDirectory = True
            frm.InitialDirectory = appPath
            ' frm.ShowDialog()
            If frm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                dbScriptFile = frm.FileName
                Dim objReader As New System.IO.StreamReader(dbScriptFile)
                Dim scriptArr As String()
                Dim i As Integer
                cmd.CommandText = objReader.ReadToEnd.Replace("GO", ";")
                scriptArr = cmd.CommandText.Split(";")
                Try
                    For i = 0 To scriptArr.Length - 1

                        If Len(scriptArr.GetValue(i)) > 1 Then
                            cmd.CommandText = scriptArr.GetValue(i)
                            cmd.ExecuteNonQuery()
                        End If

                    Next
                Finally
                End Try
            Else
                Exit Sub
            End If
            xCon.Close()
            cmd.Dispose()
            MessageBox.Show("The script " & dbScriptFile & " was successfull")
            My.Settings.SqlScript = String.Empty
        Catch ex As Exception
            My.Settings.SqlScript = xSQL
            MessageBox.Show("An error was encountered.  Advise the administrator " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ts_Monitor_Click(sender As Object, e As System.EventArgs) Handles ts_Monitor.Click
        Dim frm As New frmJCMonitor
        frm.MdiParent = Me
        Try
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub

    Private Sub ts_Receipt_Click(sender As System.Object, e As System.EventArgs) Handles ts_Receipt.Click
        Dim frm As New frmAccountingMain
        frm.TabControl1.SelectedIndex = 1
        frm.ComboBox4.SelectedItem = "Deposit"
        frm.ComboBox2.SelectedIndex = -1
        frm.ComboBox4.Enabled = False
        frm.Show()
    End Sub

    Private Sub ts_Settlement_Click(sender As System.Object, e As System.EventArgs) Handles ts_Settlement.Click
        Dim frm As New frmAccountingMain
        frm.TabControl1.SelectedIndex = 1
        frm.ComboBox4.SelectedItem = "Settlement"
        frm.ComboBox4.Enabled = False
        frm.Show()
    End Sub

    Private Sub ts_Invoice_Click(sender As System.Object, e As System.EventArgs) Handles ts_Invoice.Click
        Dim frm As New frmAccountingMain
        frm.TabControl1.SelectedIndex = 2
        frm.ComboBox5.SelectedItem = "Tax Invoice"
        frm.ComboBox5.Enabled = False
        frm.Label37.Visible = True
        frm.ComboBox6.Visible = True

        frm.Show()
    End Sub

    Private Sub ts_JobCard_Click(sender As System.Object, e As System.EventArgs) Handles ts_JobCard.Click
        Dim frm As New frmProduction
        frm.MdiParent = Me
        Try
            frm.jcCombo1.SelectedItem = "Job card"
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FillActiveChildFormToClient()
    End Sub
End Class


