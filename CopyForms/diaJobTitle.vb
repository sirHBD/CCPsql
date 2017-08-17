Imports System.Math

Public Class diaJobTitle
    Public xDontClose As Boolean

    Private Sub diaJobTitle_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
       
    End Sub

    Private Sub dStaffAdd_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub dStaffAdd_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Invalidate()
    End Sub

    Private Sub diaJobTitle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Me.TblJobTitleTableAdapter1.Fill(Me.DsProdDB1.tblJobTitle)
        Me.TblDeptTableAdapter.Fill(Me.DsActivityDB1.tblDept)

        Me.Text = My.Settings.SysName & " - " & "Add/Edit an job title"

        If xStaffToolstrip.Name = "ToolStripButton1" Then
            If Len(tblJobTitleBS.Filter) > 0 Then
                Me.tblJobTitleBS.RemoveFilter()
            End If
            Me.tblJobTitleBS.AddNew()
        End If

        If xStaffToolstrip.Name = "ToolStripButton2" Then
            Me.tblJobTitleBS.Filter = "id_tblJobTitles = " & xLabourLinkID
        End If


    End Sub

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Validate()
        diaJobTitle_Validating(Me, Nothing)

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
            If Me.ComboBox2.Text = "True" Then
                Me.tblJobTitleBS.Current.row.item("IsConstraint") = True
            Else
                Me.tblJobTitleBS.Current.row.item("IsConstraint") = False
            End If

            Dim xDeptid As Integer = Me.ComboBox1.SelectedValue
            Me.tblJobTitleBS.Current.row.item("FK_tblDeptId") = xDeptid

            Me.tblJobTitleBS.EndEdit()
            Me.TblJobTitleTableAdapter1.Update(Me.DsProdDB1.tblJobTitle)

            If xStaffToolstrip.Name = "ToolStripButton1" Then
                My.Forms.ApplicationStartupForm.ss1.Text = "New Job title added"
            Else
                My.Forms.ApplicationStartupForm.ss1.Text = "Job title updated"
            End If

            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        xDontClose = False
        Me.Close()
    End Sub

    Private Sub diaJobTitle_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Validating

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
    
    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim xDeptid As Integer = sender.selectedvalue


        For Each xRow As DataRow In Me.DsProdDB1.tblJobTitle.Rows
            If xRow("IsConstraint") = True And xStaffToolstrip.Name = "ToolStripButton1" Then
                Me.ComboBox2.Enabled = False
            End If
        Next


    End Sub
End Class