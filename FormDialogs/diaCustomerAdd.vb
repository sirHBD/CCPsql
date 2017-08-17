Imports System.Math

Public Class diaCustomerAdd
    Public xDontClose As Boolean
    Shared xCustomerId As Integer


    Private Sub diaCustomerAdd_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If xDontClose = True Then
            e.Cancel = True
            xDontClose = False
        End If
    End Sub

    Private Sub dStaffAdd_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub dStaffAdd_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Invalidate()

    End Sub

    Private Sub diaCustomerAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Forms.ApplicationStartupForm.ss1.Text = String.Empty
        'TODO: This line of code loads data into the 'DsActivityDB.tblDept' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter1.Fill(Me.DsAccounting1.tblCustomer)
        
        Me.Text = My.Settings.SysName & " - " & "Add/Edit an customer"

        If xStaffToolstrip.Name = "ToolStripButton1" Then
            If Len(TblCustomerBindingSource.Filter) > 0 Then
                Me.TblCustomerBindingSource.RemoveFilter()

            End If
            Me.TblCustomerBindingSource.AddNew()
        End If

        If xStaffToolstrip.Name = "ToolStripButton2" Then
            Me.TblCustomerBindingSource.Filter = "id_tblCustomer = " & Me.Tag
            
        End If


    End Sub

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Validate()
        diaCustomerAdd_Validating(Me, Nothing)

        'Check to determine if there are errors
        Dim xErr As Boolean = False
        For Each ctrl As Control In Me.GroupBox1.Controls
            If Len(Me.ErrorProvider1.GetError(ctrl)) > 0 Then
                xErr = True
            End If
        Next

        If xErr = True Then
            My.Forms.ApplicationStartupForm.ss1.Text = "Record can not be added / updated before errors are not corrected"
            xDontClose = True
            Return

        Else
            'Before saving check for duplicates and issue warning
            If xStaffToolstrip.Name = "ToolStripButton1" Then
                Dim xHasRec As String
                xHasRec = MiscCode.bdQuickFind(My.Settings.ConnectionString1, "txtCusCde", Me.TextBox1.Text, "tblCustomer", "", "")
                If String.IsNullOrEmpty(xHasRec) = False Then
                    Dim xRes As MsgBoxResult = MsgBox("Another staff member with this code was found.  Are you sure?", MsgBoxStyle.OkCancel, My.Settings.SysName)
                    If xRes = MsgBoxResult.Cancel Then
                        Return
                    End If
                End If
            End If
            Try
                Me.TblCustomerBindingSource.EndEdit()
                Me.TblCustomerTableAdapter1.Update(Me.DsAccounting1.tblCustomer)
            Catch
                MsgBox("Records not saved due to errors")
            End Try

            If xStaffToolstrip.Name = "ToolStripButton1" Then
                My.Forms.ApplicationStartupForm.ss1.Text = "New customer added"
            Else
                My.Forms.ApplicationStartupForm.ss1.Text = "Customer updated"
            End If

            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        xDontClose = False
        Me.Close()
    End Sub

    Private Sub diaCustomerAdd_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Validating

        For Each ctrl As Control In Me.GroupBox1.Controls
            If TypeOf (ctrl) Is TextBox Then

                If MiscCode.IsMandatoryOK(ctrl.Text) = True Then
                    Me.ErrorProvider1.SetError(ctrl, "")
                Else
                    Me.ErrorProvider1.SetError(ctrl, "Mandatory Field - Can not contain nothing")
                End If
            End If
        Next

    End Sub

    
   

    

    

    

    

    
End Class