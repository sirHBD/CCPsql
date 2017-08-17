Imports System.Windows.Forms

Public Class diaLabourLink
    Const q = "'"

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.Validate()
        'Check to determine if there are errors
        Dim xErr As Boolean = False
        For Each ctrl As Control In Me.Controls
            If Len(Me.ErrorProvider1.GetError(ctrl)) > 0 Then
            xErr = True
            End If
        Next

     'Save if no errors exist
        If xErr = True Then
        Me.DsProdDB1.RejectChanges()
        MsgBox("Could not save due to errors", , My.Settings.SysName)
        My.Forms.ApplicationStartupForm.ss1.Text = "Could not save due to errors"
            Else

'New Record
            If xStaffToolstrip.Text = "New Record" Then Me.bsProdLink.AddNew()
            If Me.Tag = "Product" Then
                Me.bsProdLink.Current.row.item("fk_tblProduct") = xComboID
            Else
                Me.bsProdLink.Current.row.item("fk_tblMaterial") = xComboID
            End If
            Me.bsProdLink.Current.row.item("fk_tblDept") = Me.ComboBox1.SelectedValue
            If Me.ComboBox2.SelectedValue Is Nothing = False Then Me.bsProdLink.Current.row.item("fk_tblElement") = Me.ComboBox2.SelectedValue
            If Me.ComboBox3.SelectedValue IsNot Nothing Then Me.bsProdLink.Current.row.item("fk_tblActivity") = Me.ComboBox3.SelectedValue
            Me.bsProdLink.Current.row.item("dblValue") = Me.TextBox1.Text
            Me.bsProdLink.Current.row.item("dblFreq") = Me.TextBox2.Text

            If String.IsNullOrEmpty(Me.cBox_Operator.Text) = False Then
                Me.bsProdLink.Current.row.item("txtLabourParameter") = Me.cBox_Operator.SelectedValue
            Else
                Me.bsProdLink.Current.row.item("txtLabourParameter") = Me.cBox_StaffGroup.Text
            End If

            Me.bsProdLink.Current.row.item("txtValueDesc") = Me.ComboBox4.Text
            Me.bsProdLink.Current.row.item("dblLabourCost") = Me.TextBox3.Text
            Me.bsProdLink.Current.row.item("dblAdjValue") = Me.TextBox5.Text
            Me.bsProdLink.Current.row.item("dblAdjCost") = Me.TextBox4.Text
            Me.bsProdLink.Current.row.item("dblHour") = MiscCode.GetLabourHours(Me.ComboBox4.Text, Me.TextBox1.Text)
            Me.bsProdLink.Current.row.item("dblAdjHour") = MiscCode.GetLabourHours(Me.ComboBox4.Text, Me.TextBox5.Text)

            Me.bsProdLink.EndEdit()
            Me.TblProdLinkTableAdapter1.Update(Me.DsProdDB1.tblProdLink)



        End If


        If xStaffToolstrip.Text = "New Record" Then
            My.Forms.ApplicationStartupForm.ss1.Text = "Labour link for Product " & xComboID & " added"
        Else
            My.Forms.ApplicationStartupForm.ss1.Text = "Labour link for Product " & xComboID & " changed"
        End If


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cBox_Operator.SelectedItem = Nothing
        Me.cBox_StaffGroup.SelectedItem = Nothing
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub diaProdLink_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    My.Forms.ApplicationStartupForm.ss1.Text = String.Empty
    'TODO: This line of code loads data into the 'DsMatDB1.tblMaterial' table. You can move, or remove it, as needed.
    Me.TblDeptTableAdapter1.Fill(Me.DsActivityDB1.tblDept)
    Me.TblElementTableAdapter1.Fill(Me.DsActivityDB1.tblElement)
    Me.TblActivityTableAdapter1.Fill(Me.DsActivityDB1.tblActivity)
    Me.TblProdLinkTableAdapter1.Fill(Me.DsProdDB1.tblProdLink)
    Me.LstStaffGroupsTableAdapter1.Fill(Me.DsProdDB1.lstStaffGroups)
        Try
            Me.TblDeptBindingSource.Sort = "numSortSeq"
            Me.TblElementBindingSource.Sort = "numSortSeq"
            Me.TblActivityBindingSource.Sort = "numSortSeq"
        Catch ex As Exception
        End Try


        Me.cBox_Operator.DataSource = Nothing
        Me.TblStaffTableAdapter1.FillStaffCombo(Me.DsProdDB1.tblStaff)
        Dim DV_Staff As New DataView(Me.DsProdDB1.tblStaff.Copy)
        DV_Staff.Sort = "txtEmpName"
        Me.cBox_Operator.DataSource = DV_Staff 'Me.DsProdDB1.Tables("tblStaff").Copy
        Me.cBox_Operator.DisplayMember = "txtEmpName"
        Me.cBox_Operator.ValueMember = "id_tblStaff"
        Me.cBox_Operator.SelectedIndex = -1

        Me.TblStaffTableAdapter1.FillByStaffCategory(Me.DsProdDB1.tblStaff)
        If Me.DsProdDB1.tblStaff.Rows.Count > 0 Then
            For Each xRow As DataRow In Me.DsProdDB1.tblStaff.Rows
                Me.cBox_StaffGroup.Items.Add(xRow.Item("txtEmpCategory"))
            Next
        End If


        If xStaffToolstrip.ToString = "Edit Record" Then
            Try
                Me.ComboBox1.Enabled = False
                Me.bsProdLink.Filter = "id_tblProdLink = " & xLabourLinkID
                Dim xDeptID As Integer = Me.bsProdLink.Current.row.item("fk_tblDept")
                Me.ComboBox1.SelectedValue = xDeptID
                Me.ComboBox2.SelectedValue = Me.bsProdLink.Current.row.item("fk_tblElement") 'Me.DsActivityDB1.tblElement.FindByid_tblElement(Me.bsProdLink.Current.row.item("fk_tblElement"))
                Me.ComboBox3.SelectedValue = Me.bsProdLink.Current.row.item("fk_tblActivity") 'Me.DsActivityDB1.tblActivity.FindByid_tblActivity(Me.bsProdLink.Current.row.item("fk_tblActivity"))
                Me.GroupBox1.Enabled = False
                Me.GroupBox2.Enabled = False
                Me.ComboBox4.Text = Me.bsProdLink.Current.row.item("txtValueDesc")
                Me.TextBox1.Text = Me.bsProdLink.Current.row.item("dblValue")
                Me.TextBox2.Text = Me.bsProdLink.Current.row.item("dblFreq")
                Me.TextBox3.Text = Me.bsProdLink.Current.row.item("dblLabourCost")
                Me.TextBox6.Text = MiscCode.GetEffPer(Me.bsProdLink.Current.row.item("fk_tblDept"))
                Me.TextBox5.Text = MiscCode.MNS(Me.bsProdLink.Current.row.item("dblAdjValue"))
                Me.TextBox5.Text = MiscCode.MNS(Me.bsProdLink.Current.row.item("dblAdjCost"))

                If String.IsNullOrEmpty(Me.bsProdLink.Current.row.item("txtLabourParameter")) = False Then
                    Dim xLabPar As String = Me.bsProdLink.Current.row.item("txtLabourParameter")
                    Dim xGroup As Boolean = False
                    'Check to see if the labour parameter is a group
                    For Each xRow As DataRow In Me.DsProdDB1.lstStaffGroups
                        If xRow.Item("txtEmpCategory").ToString() = xLabPar Then
                            xGroup = True
                        End If
                    Next

                    'Now populate staff type combo boxes
                    If xGroup = True Then
                        Me.cBox_StaffGroup.Text = xLabPar
                    Else
                        Me.cBox_Operator.SelectedValue = xLabPar
                    End If
                End If

                'Me.bsProdLink.Current.row.item("txtLabourParameter") = Me.cBox_Operator.SelectedIndex
                'Else
                'Me.bsProdLink.Current.row.item("txtLabourParameter") = Me.cBox_StaffGroup.Text
                'End If
                Me.ComboBox4.Focus()

            Catch ex As Exception
                MsgBox("Could not populate all the required fields.  The form might not work.")

            End Try
        End If

        If xStaffToolstrip.text = "New Record" Then
            Me.ComboBox1.DataSource = Me.DsActivityDB1.tblDept
            Me.ComboBox1.ValueMember = "idtblDept"
            Me.ComboBox1.DisplayMember = "txtDepName"
            Me.ComboBox1.SelectedIndex = -1
            Me.ComboBox2.SelectedIndex = -1
            Me.ComboBox3.SelectedIndex = -1

        End If

        Me.GroupBox1.BackColor = MiscMod.myGBColor
        Me.GroupBox2.BackColor = MiscMod.myGBColor
        Me.GroupBox3.BackColor = MiscMod.myGBColor
    End Sub

    Private Sub diaProdLink_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub diaProdLink_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Invalidate()
    End Sub

    'Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted

    ''If xComboID > 0 Then
    ''Me.TextBox1.Text = Me.DsProdDB1.tblMaterial.FindByid_tblMaterial(xComboID).Item("txtMaterialUnit")
    ''Me.TextBox2.Focus()
    'End If

    'End Sub

    Private Sub cBox_Operator_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBox_Operator.Enter
        If cBox_StaffGroup.Enabled = False Then cBox_StaffGroup.Enabled = True

    End Sub

    Private Sub cBox_Operator_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBox_Operator.Leave
        If Len(sender.text) > 0 Then
        Me.cBox_StaffGroup.Text = Nothing
        Me.cBox_StaffGroup.Enabled = False
        End If
    End Sub

    Private Sub cBox_StaffGroup_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBox_StaffGroup.Leave
        If Len(sender.text) = 0 And Len(Me.cBox_Operator.Text) = 0 Then
        ErrorProvider1.SetError(sender, "Both Staff Group and Operator can not be blank")
            Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub TextBox2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Validated
    If Len(Me.ErrorProvider1.GetError(sender)) = 0 Then

    'Now apply the calculated rate based on the time speciier
            Dim xTimeSpec As String = Me.ComboBox4.Text
            Dim InEdit As Boolean = False
            If Me.Text.StartsWith("Edit") Then InEdit = True

  Select Case xTimeSpec
    Case "Year"
    'This calculation must be fixed
                    If InEdit = True Then Me.TextBox3.Text = CalcLabCost("Number") * (360 * 8) Else Me.TextBox3.Text = CalcLabCost("Name") * (360 * 8)
                    Me.TextBox6.Text = MiscCode.GetEffPer(Me.ComboBox1.SelectedValue)
                    If CDec(Me.TextBox6.Text) < 100 Then
                        Me.TextBox5.Text = Math.Round(CDec(((Me.TextBox1.Text) * 100) / Me.TextBox6.Text), 4)
                        Me.TextBox4.Text = Math.Round(CDec(((Me.TextBox3.Text) * 100) / Me.TextBox6.Text), 4)
                    Else
                        Me.TextBox5.Text = Math.Round(CDec(Me.TextBox1.Text), 4)
                        Me.TextBox4.Text = Math.Round(CDec(Me.TextBox3.Text), 4)
                    End If
    Case "Month"
    'This calculation must be fixed
                    If InEdit = True Then Me.TextBox3.Text = CalcLabCost("Number") * (22 * 8) Else Me.TextBox3.Text = CalcLabCost("Name") * (22 * 8)
                    Me.TextBox6.Text = MiscCode.GetEffPer(Me.ComboBox1.SelectedValue)
                    If CDec(Me.TextBox6.Text) < 100 Then
                        Me.TextBox5.Text = Math.Round(CDec(((Me.TextBox1.Text) * 100) / Me.TextBox6.Text), 4)
                        Me.TextBox4.Text = Math.Round(CDec(((Me.TextBox3.Text) * 100) / Me.TextBox6.Text), 4)
                    Else
                        Me.TextBox5.Text = Math.Round(CDec(Me.TextBox1.Text), 4)
                        Me.TextBox4.Text = Math.Round(CDec(Me.TextBox3.Text), 4)
                    End If
    Case "Week"
    'This calculation must be fixed
                    If InEdit = True Then Me.TextBox3.Text = CalcLabCost("Number") * (22 * 8) Else Me.TextBox3.Text = CalcLabCost("Name") * (22 * 8)
                    Me.TextBox6.Text = MiscCode.GetEffPer(Me.ComboBox1.SelectedValue)
                    If CDec(Me.TextBox6.Text) < 100 Then
                        Me.TextBox5.Text = Math.Round(CDec(((Me.TextBox1.Text) * 100) / Me.TextBox6.Text), 4)
                        Me.TextBox4.Text = Math.Round(CDec(((Me.TextBox3.Text) * 100) / Me.TextBox6.Text), 4)
                    Else
                        Me.TextBox5.Text = Math.Round(CDec(Me.TextBox1.Text), 4)
                        Me.TextBox4.Text = Math.Round(CDec(Me.TextBox3.Text), 4)
                    End If
    Case "Day"
    'This calculation must be fixed
                    If InEdit = True Then Me.TextBox3.Text = CalcLabCost("Number") * (8) Else Me.TextBox3.Text = CalcLabCost("Name") * (8)
                    Me.TextBox6.Text = MiscCode.GetEffPer(Me.ComboBox1.SelectedValue)
                    If CDec(Me.TextBox6.Text) < 100 Then
                        Me.TextBox5.Text = Math.Round(CDec(((Me.TextBox1.Text) * 100) / Me.TextBox6.Text), 4)
                        Me.TextBox4.Text = Math.Round(CDec(((Me.TextBox3.Text) * 100) / Me.TextBox6.Text), 4)
                    Else
                        Me.TextBox5.Text = Math.Round(CDec(Me.TextBox1.Text), 4)
                        Me.TextBox4.Text = Math.Round(CDec(Me.TextBox3.Text), 4)
                    End If
    Case "Hour"
                    If InEdit = True Then Me.TextBox3.Text = CalcLabCost("Number") * CDec(Me.TextBox1.Text) Else Me.TextBox3.Text = CalcLabCost("Name") * CDec(Me.TextBox1.Text)
                    Me.TextBox6.Text = MiscCode.GetEffPer(Me.ComboBox1.SelectedValue)
                    If CDec(Me.TextBox6.Text) < 100 Then
                        Me.TextBox5.Text = Math.Round(CDec(((Me.TextBox1.Text) * 100) / Me.TextBox6.Text), 4)
                        Me.TextBox4.Text = Math.Round(CDec(((Me.TextBox3.Text) * 100) / Me.TextBox6.Text), 4)
                    Else
                        Me.TextBox5.Text = Math.Round(CDec(Me.TextBox1.Text), 4)
                        Me.TextBox4.Text = Math.Round(CDec(Me.TextBox3.Text), 4)
                    End If
    Case "Minute"
                    If InEdit = True Then Me.TextBox3.Text = (CalcLabCost("Number") / 60) * CDec(Me.TextBox1.Text) Else Me.TextBox3.Text = (CalcLabCost("Name") / 60) * CDec(Me.TextBox1.Text)
                    Me.TextBox6.Text = MiscCode.GetEffPer(Me.ComboBox1.SelectedValue)
                    If CDec(Me.TextBox6.Text) < 100 Then
                        Me.TextBox5.Text = Math.Round(CDec(((Me.TextBox1.Text) * 100) / Me.TextBox6.Text), 4)
                        Me.TextBox4.Text = Math.Round(CDec(((Me.TextBox3.Text) * 100) / Me.TextBox6.Text), 4)
                    Else
                        Me.TextBox5.Text = Math.Round(CDec(Me.TextBox1.Text), 4)
                        Me.TextBox4.Text = Math.Round(CDec(Me.TextBox3.Text), 4)
                    End If

                Case "Second"
                    If InEdit = True Then Me.TextBox3.Text = CalcLabCost("Number") / (60 * 60) * CDec(Me.TextBox1.Text) Else Me.TextBox3.Text = CalcLabCost("Name") / (60 * 60) * CDec(Me.TextBox1.Text)
                    Me.TextBox6.Text = MiscCode.GetEffPer(Me.ComboBox1.SelectedValue)
                    If CDec(Me.TextBox6.Text) < 100 Then
                        Me.TextBox5.Text = Math.Round(CDec(((Me.TextBox1.Text) * 100) / Me.TextBox6.Text), 4)
                        Me.TextBox4.Text = Math.Round(CDec(((Me.TextBox3.Text) * 100) / Me.TextBox6.Text), 4)
                    Else
                        Me.TextBox5.Text = Math.Round(CDec(Me.TextBox1.Text), 4)
                        Me.TextBox4.Text = Math.Round(CDec(Me.TextBox3.Text), 4)
                    End If
                Case Else
                    Me.TextBox3.Text = 0
            End Select

    End If

    Me.TextBox3.Text = Math.Round(CDec(Me.TextBox3.Text), 3)

    End Sub

    Private Sub TextBox2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox2.Validating
    If IsNumeric(Me.TextBox2.Text) Then
    Me.ErrorProvider1.SetError(sender, "")
    Else
    Me.ErrorProvider1.SetError(sender, "Must enter a numerical value")
    End If
    End Sub

    Private Function CalcLabCost(ByVal xStaffIDtype As String)
        Dim xEmpRate As Decimal
        Dim xEmpNum As Integer
        Try
            If Len(Me.cBox_StaffGroup.Text) > 0 Then
                Me.TblStaffTableAdapter1.Fill(Me.DsProdDB1.tblStaff)
                xEmpRate = Me.DsProdDB1.tblStaff.Compute("Sum(dblRateperHour)", "txtEmpCategory = " & "'" & Me.cBox_StaffGroup.Text & "'")
                xEmpNum = Me.DsProdDB1.tblStaff.Compute("Count(id_tblStaff)", "txtEmpCategory = " & "'" & Me.cBox_StaffGroup.Text & "'")
                Return (xEmpRate / xEmpNum) * Me.TextBox2.Text
            Else
                Me.TblStaffTableAdapter1.Fill(Me.DsProdDB1.tblStaff)

                If xStaffIDtype = "Name" Then
                    xEmpRate = Me.DsProdDB1.tblStaff.Compute("Sum(dblRateperHour)", "txtEmpName = " & "'" & Me.cBox_Operator.Text & "'")
                Else
                    xEmpRate = Me.DsProdDB1.tblStaff.Compute("Sum(dblRateperHour)", "id_tblStaff = " & "'" & Me.cBox_Operator.SelectedValue & "'")
                End If

                xEmpNum = 1
                Return (xEmpRate / xEmpNum) * Me.TextBox2.Text
            End If
        Catch ex As Exception
            MsgBox("Could not calculate the labour cost due to errors.  See details - " & ex.Message)
            Return 0
        End Try

    End Function

    Private Sub ComboBox1_SelectionChangedCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted

    If ComboBox1.SelectedValue IsNot Nothing Then
            Me.TblElementBindingSource.Filter = "FK_tblDept = " & Me.ComboBox1.SelectedValue

    End If

    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectionChangeCommitted

    If ComboBox2.SelectedValue IsNot Nothing Then
            Me.TblActivityBindingSource.Filter = "FK_idtblelement = " & Me.ComboBox2.SelectedValue

    End If

    End Sub



End Class

