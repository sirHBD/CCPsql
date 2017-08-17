Imports System.Math

Public Class diaStaffAdd
Public xDontClose As Boolean

    Private Sub diaStaffAdd_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub diaStaffAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    My.Forms.ApplicationStartupForm.ss1.Text = String.Empty
    'TODO: This line of code loads data into the 'DsActivityDB.tblDept' table. You can move, or remove it, as needed.
        Me.TblCoInfoTableAdapter1.Fill(Me.DsProdDB1.tblCoInfo)
        Me.TblDeptTableAdapter.Fill(Me.DsActivityDB.tblDept)
        Me.TblStaffTableAdapter1.Fill(Me.DsProdDB1.tblStaff)
        Me.TblJobTitleTableAdapter1.Fill(Me.DsProdDB1.tblJobTitle)



    Me.Text = My.Settings.SysName & " - " & "Add/Edit an employee"

        If xStaffToolstrip.Name = "ToolStripButton1" Then
            If Len(TblStaffBindingSource.Filter) > 0 Then
            Me.TblStaffBindingSource.RemoveFilter()
            End If

        Me.TblStaffBindingSource.AddNew()
        End If

        MiscCode.ComboBoxFiller(Me.cb_RemCat, "txtEmpCategory", "txtEmpCategory", "txtEmpCategory", "tblStaff", , , True)

    If xStaffToolstrip.Name = "ToolStripButton2" Then
            Me.TblStaffBindingSource.Filter = "id_tblStaff = " & xLabourLinkID
            Me.ComboBox3.Text = Me.TblStaffBindingSource.Current.row("CCType").ToString
            If Me.ComboBox3.Text = "" Then Me.ComboBox3.SelectedIndex = -1
            Me.ComboBox4.Text = Me.TblStaffBindingSource.Current.row("CCUOM").ToString
            If Me.ComboBox4.Text = "" Then Me.ComboBox4.SelectedIndex = -1
            Me.ComboBox2.Text = Me.TblStaffBindingSource.Current.row("txtRateDescriptor")
            Me.cb_RemCat.Text = Me.TblStaffBindingSource.Current.row("txtEmpCategory").ToString()
            Me.ComboBox5.Text = Me.TblStaffBindingSource.Current.row("txtJobTitle")
    End If


    End Sub

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Validate()
        diaStaffAdd_Validating(Me, Nothing)

    'Check to determine if there are errors
        Dim xErr As Boolean = False
        For Each ctrl As Control In Me.GroupBox1.Controls
            If Len(Me.ErrorProvider1.GetError(ctrl)) > 0 Then
            xErr = True
            End If
        Next
        If xErr = False Then
            For Each ctrl As Control In Me.GroupBox2.Controls
                If Len(Me.ErrorProvider1.GetError(ctrl)) > 0 Then
                xErr = True
                End If
            Next
        End If

        If xErr = True Then
        My.Forms.ApplicationStartupForm.ss1.Text = "Record can not be added / updated before errors are not corrected"
        xDontClose = True
        Return

            Else
            'Before saving check for duplicates and issue warning
                If xStaffToolstrip.Name = "ToolStripButton1" Then
                Dim xHasRec As String
                xHasRec = MiscCode.bdQuickFind(My.Settings.ConnectionString1, "txtEmpNo", Me.TextBox1.Text, "tblStaff", "", "")
                    If String.IsNullOrEmpty(xHasRec) = False Then
                    Dim xRes As MsgBoxResult = MsgBox("Another staff member with this code was found.  Are you sure?", MsgBoxStyle.OkCancel, My.Settings.SysName)
                        If xRes = MsgBoxResult.Cancel Then
                        Return
                        End If
                    End If
                End If
            Try
                Me.TextBox7.Text = GetRatePerHour(Me.TextBox5.Text, Me.ComboBox2.Text) + GetCoCon(Me.TextBox5.Text, Me.TextBox6.Text, Me.ComboBox2.Text, Me.ComboBox4.Text, Me.ComboBox3.Text)
                Me.TblStaffBindingSource.Current.row.item("txtRateDescriptor") = Me.ComboBox2.Text
                Me.TblStaffBindingSource.Current.row.item("CCType") = Me.ComboBox3.Text
                Me.TblStaffBindingSource.Current.row.item("CCUOM") = Me.ComboBox4.Text
                Me.TblStaffBindingSource.EndEdit()
                Me.TblStaffTableAdapter1.Update(Me.DsProdDB1.tblStaff)
            Catch
                MsgBox("Records not saved due to errors")
            End Try

                If xStaffToolstrip.Name = "ToolStripButton1" Then
                My.Forms.ApplicationStartupForm.ss1.Text = "New Staff member added"
                Else
                My.Forms.ApplicationStartupForm.ss1.Text = "Staff member updated"
                End If

            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        xDontClose = False
        Me.Close()
    End Sub

    Private Sub diaStaffAdd_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Validating

    For Each ctrl As Control In Me.GroupBox1.Controls
    If TypeOf (ctrl) Is TextBox Then

        If MiscCode.IsMandatoryOK(ctrl.Text) = True Then
        Me.ErrorProvider1.SetError(ctrl, "")
        Else
        Me.ErrorProvider1.SetError(ctrl, "Mandatory Field - Can not contain nothing")
        End If
    End If
    Next

    For Each ctrl As Control In Me.GroupBox2.Controls
    If TypeOf (ctrl) Is TextBox Then

        If MiscCode.IsMandatoryOK(ctrl.Text) = True Then
        Me.ErrorProvider1.SetError(ctrl, "")
        Else
        Me.ErrorProvider1.SetError(ctrl, "Mandatory Field - Can not contain nothing")
        End If
    End If

    Next
    End Sub

    Private Sub TextBox5_Validating(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.Validating
        If IsNumeric(Me.TextBox5.Text) = True Then
            Me.TextBox7.Text = GetRatePerHour(Me.TextBox5.Text, Me.ComboBox2.Text)
            Me.ErrorProvider1.SetError(sender, "")
        ElseIf sender.focused = True Then
            Me.ErrorProvider1.SetError(sender, "Value must be numeric")
        End If
    End Sub

    Private Function GetRatePerHour(ByVal xRate As Decimal, ByVal xType As String)

        Dim xNorHour As Decimal
        Dim xFriHour As Decimal

        Try
            xNorHour = Me.DsProdDB1.tblCoInfo.Rows(0).Item("dblNormalLabHours")
        Catch ex As Exception
            xNorHour = 8
        End Try
        Try
            xFriHour = Me.DsProdDB1.tblCoInfo.Rows(0).Item("dblFridayLabHours")
        Catch ex As Exception
            xFriHour = 6
        End Try



        Select Case xType
            Case "Hour"
                Return Round(xRate, 3)
            Case "Week"
                Return Round(xRate / ((xNorHour * 4) + xFriHour), 3)
            Case "Day"
                Dim div As Decimal = ((xNorHour * 4) + xFriHour) / 5
                Return Round(xRate / div, 3)
            Case "Month"
                Dim div As Decimal = (((xNorHour * 4) + xFriHour) * 4.345238095)
                Return Round(xRate / div, 3)
            Case Else
                Return 0

        End Select


    End Function

    Private Sub ComboBox2_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedValueChanged
        If String.IsNullOrEmpty(Me.TextBox5.Text) = False Then
            Me.TextBox7.Text = GetRatePerHour(Me.TextBox7.Text, Me.ComboBox2.Text)
        End If
    End Sub

    Private Sub cb_RemCat_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_RemCat.SelectionChangeCommitted
    Try
    Me.TblStaffBindingSource.Current.row("txtEmpCategory") = Me.cb_RemCat.SelectedItem.ToString
    Me.cb_RemCat.Refresh()
    Catch ex As Exception
    End Try

    End Sub

    Private Sub cb_RemCat_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_RemCat.Validating

    Try
        If Len(Me.cb_RemCat.Text) > 0 Then
            If Me.cb_RemCat.Items.Contains(Me.cb_RemCat.Text) Then
            Else

                Dim xRes As MsgBoxResult = MsgBox("You are creating a new employee category.  Are you sure?", MsgBoxStyle.OkCancel, My.Settings.SysName)
                If xRes = MsgBoxResult.Cancel Then
                Return
                End If

            Me.cb_RemCat.Items.Add(Me.cb_RemCat.Text)
            Me.cb_RemCat.SelectedItem = Me.cb_RemCat.Text
            cb_RemCat_SelectionChangeCommitted(sender, Nothing)
            End If
        End If

    Catch ex As Exception
    End Try
    End Sub

    Private Sub TextBox6_ContextMenuStripChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.ContextMenuStripChanged
        If Me.ComboBox3.Text = "Fixed" Or String.IsNullOrEmpty(Me.ComboBox3.Text) Then
        Me.TextBox6.Text = 0
        End If
    End Sub

    Private Sub TextBox6_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox6.Validating
        Try
            Me.TextBox7.Text = GetRatePerHour(Me.TextBox5.Text, Me.ComboBox2.Text) + GetCoCon(Me.TextBox5.Text, Me.TextBox6.Text, Me.ComboBox2.Text, Me.ComboBox4.Text, Me.ComboBox3.Text)
        Catch ex As Exception
        End Try


    End Sub

    Private Function GetCoCon(ByVal xWageRate As Decimal, ByVal xCoConRate As Decimal, ByVal xWagePeriod As String, ByVal xCoConPeriod As String, ByVal xCoConType As String)

        Dim xNorHour As Decimal = Me.DsProdDB1.tblCoInfo.Rows(0).Item("dblNormalLabHours")
        Dim xFriHour As Decimal = Me.DsProdDB1.tblCoInfo.Rows(0).Item("dblFridayLabHours")

        Try

            Select Case xCoConPeriod
                Case "Hour"
                    If Me.ComboBox3.Text = "Percentage" Then
                        Return Round(GetRatePerHour(Me.TextBox5.Text, Me.ComboBox2.Text), 3) * (xCoConRate / 100)
                    Else
                        Return Round(xCoConRate, 3)
                    End If

                Case "Week"
                    If Me.ComboBox3.Text = "Percentage" Then
                        Return Round(Round(GetRatePerHour(Me.TextBox5.Text, Me.ComboBox2.Text) / ((xNorHour * 4) + xFriHour), 3) * (Me.TextBox5.Text / 100))
                    Else
                        Return Round(xCoConRate / ((xNorHour * 4) + xFriHour), 3)
                    End If

                Case "Day"
                    Dim div As Decimal = ((xNorHour * 4) + xFriHour) / 5
                    Return Round(GetRatePerHour(Me.TextBox5.Text, Me.ComboBox2.Text) / div, 3)
                Case "Month"
                    Dim div As Decimal = (((xNorHour * 4) + xFriHour) * 4.345238095)
                    If Me.ComboBox3.Text = "Percentage" Then
                        Return Round((GetRatePerHour(Me.TextBox5.Text, Me.ComboBox2.Text)) * (Me.TextBox6.Text / 100), 3)
                    Else
                        Return Round(((xCoConRate) / div), 3)
                    End If
                Case Else
                    Return 0

            End Select

        Catch ex As Exception
            MsgBox("CCP encountered an error as foolows " & vbCrLf & ex.Message, , My.Settings.SysName)
            Return 0
        End Try


    End Function

    Private Sub ComboBox3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboBox3.Validating
        Try
            Me.TextBox7.Text = GetRatePerHour(Me.TextBox5.Text, Me.ComboBox2.Text) + GetCoCon(Me.TextBox5.Text, Me.TextBox6.Text, Me.ComboBox2.Text, Me.ComboBox4.Text, Me.ComboBox3.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox4_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboBox4.Validating
        Try
            Me.TextBox7.Text = GetRatePerHour(Me.TextBox5.Text, Me.ComboBox2.Text) + GetCoCon(Me.TextBox5.Text, Me.TextBox6.Text, Me.ComboBox2.Text, Me.ComboBox4.Text, Me.ComboBox3.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        Dim xIsConstraint As Boolean
        Dim xTitle As String
        Dim xTitleID As Integer

        If Not sender.SelectedValue Is Nothing Then
            xTitleID = sender.SelectedValue.Row.item("id_tblJobTitles")
            xIsConstraint = sender.SelectedValue.Row.item("IsConstraint")
            xTitle = sender.SelectedValue.Row.item("txtJobTitle").ToString()
            Me.TextBox3.Text = xTitle
            Me.TblStaffBindingSource.Current.row.item("ConstraintYes") = xIsConstraint
            Me.TblStaffBindingSource.Current.row.item("txtJobTitle") = xTitle
            Me.TblStaffBindingSource.Current.row.item("FK_tblJobTitleID") = xTitleID
        End If


    End Sub
End Class