Imports System.Windows.Forms

Public Class diaDeptEleAct
Dim xNewDept As Boolean = False
Dim xNewOps As Boolean = False
    Dim xNewAct As Boolean = False
    Dim xOldEffPer As Decimal


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

    'Check what was added
    If Me.RadioButton1.Checked = True Then
            Me.TblDeptBindingSource.EndEdit()
            Me.TblDeptTableAdapter1.Update(Me.DsActivityDB1.tblDept)
            Me.RadioButton1.Checked = False
            Me.GroupBox1.Enabled = False
        End If

        If Me.RadioButton2.Checked = True Then
        Me.TblElementBindingSource.Current.Row.item("FK_tblDept") = Me.ComboBox1.SelectedValue
            If IsDBNull(TblElementBindingSource.Current.Row.item("txtElementNo")) Or IsDBNull(TblElementBindingSource.Current.Row.item("txtElementNo")) Then
                TblElementBindingSource.CancelEdit()
            End If
            Me.TblElementBindingSource.EndEdit()
            Me.TblElementTableAdapter1.Update(Me.DsActivityDB1.tblElement)
            'End If
            Me.RadioButton2.Checked = False
            Me.GroupBox2.Enabled = False
        End If

        If Me.RadioButton3.Checked Or IsNumeric(Me.Tag) = True Then
            Me.TblActivityBindingSource.Current.Row.item("FK_idtblElement") = Me.ComboBox2.SelectedValue
            Me.TblActivityBindingSource.EndEdit()
            Me.TblActivityTableAdapter1.Update(Me.DsActivityDB1.tblActivity)
            Me.RadioButton3.Checked = False
            Me.GroupBox3.Enabled = False
        End If


        If Me.Text.StartsWith("Edit") Then

            Me.TblDeptBindingSource.EndEdit()
            Me.TblDeptTableAdapter1.Update(Me.DsActivityDB1.tblDept)
            Dim xNewEffPer As Decimal
            Try
                xNewEffPer = MiscCode.MNS(TblDeptBindingSource.Current.row.item("numEffPer"))
            Catch ex As Exception
            End Try

            If xOldEffPer <> xNewEffPer Then
                MsgBox("Updating labour standards")
                UpdateProductWithEff(TblDeptBindingSource.Current.row.item("idtblDept"), xNewEffPer)
            End If
            Me.TblElementBindingSource.EndEdit()
            Me.TblElementTableAdapter1.Update(Me.DsActivityDB1.tblElement)
            Me.TblActivityBindingSource.EndEdit()
            Me.TblActivityTableAdapter1.Update(Me.DsActivityDB1.tblActivity)
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.GroupBox1.Enabled = False
        Me.GroupBox2.Enabled = False
        Me.GroupBox3.Enabled = False

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.GroupBox1.Enabled = False
        Me.GroupBox2.Enabled = False
        Me.GroupBox3.Enabled = False
        

        Me.Close()
    End Sub

    Private Sub diaDeptEleAct_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    My.Forms.ApplicationStartupForm.ss1.Text = String.Empty

    'TODO: This line of code loads data into the 'DsActivityDB.tblDept' table. You can move, or remove it, as needed.

        Me.TblDeptTableAdapter1.Fill(Me.DsActivityDB1.tblDept)
        Me.TblElementTableAdapter1.Fill(Me.DsActivityDB1.tblElement)
        Me.TblActivityTableAdapter1.Fill(Me.DsActivityDB1.tblActivity)

        If Len(Me.Tag) = 0 And xStaffToolstrip.Text = "Edit Record" Then
            MsgBox("Incorrect selection", MessageBoxButtons.OK, "CCP Messages")
            Exit Sub
        End If
        Dim xType As String = String.Empty
        If Len(Me.Tag) > 0 Then
            xType = Me.Tag.ToString.Substring(0, 1)
        End If

        If xStaffToolstrip.text = "New Record" And String.IsNullOrEmpty(Me.Tag) = True Then
            Me.RadioButton1.Visible = True
            If Me.RadioButton1.Checked = True Then
                RadioButton1_Click(sender, e)
            Else
                Me.RadioButton1.Checked = CheckState.Checked
            End If
            Me.RadioButton1.Checked = CheckState.Checked
            Me.RadioButton2.Visible = True
            Me.RadioButton3.Visible = True

        End If

        If xStaffToolstrip.text = "New Record" And xType = "S" Then
            Dim xDeptID As Integer = Me.Tag.ToString.Substring(1, Len(Me.Tag) - 1)
            Me.TblDeptBindingSource.Filter = "idtbldept = " & xDeptID
            Me.RadioButton2.Visible = True
            If Me.RadioButton2.Checked = True Then
                RadioButton2_CheckedChanged(sender, e)
            Else
                Me.RadioButton2.Checked = CheckState.Checked
            End If
            Me.DsActivityDB1.tblActivity.Clear()
            Me.TblElementBindingSource.AddNew()
            Me.GroupBox2.Enabled = True
            Me.ComboBox2.Visible = False
            Me.TextBox3.Visible = True
            Dim xNewLoc As Point = Me.ComboBox2.Location
            Me.TextBox3.Location = xNewLoc
            Me.RadioButton1.Visible = False
            Me.RadioButton2.Visible = False
            Me.RadioButton3.Visible = False
            Me.GroupBox1.Enabled = False
            Try
                xOldEffPer = MiscCode.MNS(TblDeptBindingSource.Current.row.item("numEffPer"))
            Catch ex As Exception
            End Try

        End If


        If xStaffToolstrip.Text = "Edit Record" And xType = "S" Then
            Me.Text = xStaffToolstrip.text
            Dim xDeptID As Integer = Me.Tag.ToString.Substring(1, Len(Me.Tag) - 1)
            Me.TblDeptBindingSource.Filter = "idtbldept = " & xDeptID
            Me.DsActivityDB1.tblActivity.Clear()
            Me.DsActivityDB1.tblElement.Clear()
            Me.GroupBox1.Enabled = True
            Me.ComboBox1.Visible = False
            Me.TextBox2.Visible = True
            Dim xNewLoc As Point = Me.ComboBox1.Location
            Me.TextBox2.Location = xNewLoc
            Me.RadioButton1.Visible = False
            Me.RadioButton2.Visible = False
            Me.RadioButton3.Visible = False
            Try
                xOldEffPer = MiscCode.MNS(TblDeptBindingSource.Current.row.item("numEffPer"))
            Catch ex As Exception
            End Try

        End If


        If xStaffToolstrip.Text = "Edit Record" And xType = "T" Then
            Me.Text = xStaffToolstrip.text
            Dim xEleID As Integer = Me.Tag.ToString.Substring(1, Len(Me.Tag) - 1)
            Me.TblElementBindingSource.Filter = "id_tblElement = " & xEleID
            Dim xDeptID As Integer = Me.TblElementBindingSource.Current.row.item("fk_tblDept")
            Me.TblDeptBindingSource.Filter = "idtbldept = " & xDeptID
            Me.DsActivityDB1.tblActivity.Clear()
            Me.GroupBox2.Enabled = True
            Me.ComboBox2.Visible = False
            Me.TextBox3.Visible = True
            Dim xNewLoc As Point = Me.ComboBox2.Location
            Me.TextBox3.Location = xNewLoc
            Me.RadioButton1.Visible = False
            Me.RadioButton2.Visible = False
            Me.RadioButton3.Visible = False
            Try
                xOldEffPer = MiscCode.MNS(TblDeptBindingSource.Current.row.item("numEffPer"))
            Catch ex As Exception
            End Try
        End If


        If xStaffToolstrip.Text = "Edit Record" And IsNumeric(Me.Tag) Then
            Me.Text = xStaffToolstrip.text
            Me.TblActivityBindingSource.Filter = "id_tblActivity = " & Me.Tag
            Dim xOp As Integer = Me.TblActivityBindingSource.Current.row.item("FK_idtblelement")
            Me.TblElementBindingSource.Filter = "id_tblelement = " & xOp
            Dim xDept As Integer = Me.TblElementBindingSource.Current.row.item("fk_tblDept")
            Me.TblDeptBindingSource.Filter = "idtbldept = " & xDept
            Me.GroupBox3.Enabled = True
            Me.GroupBox2.Enabled = True
            Me.ComboBox3.Visible = False
            Me.ComboBox2.Visible = False
            Me.TextBox3.Visible = True
            Me.TextBox5.Visible = True
            Dim xNewLoc As Point = Me.ComboBox3.Location
            Me.TextBox5.Location = xNewLoc
            Dim yNewLoc As Point = Me.ComboBox2.Location
            Me.TextBox2.Location = yNewLoc
            Me.RadioButton1.Visible = False
            Me.RadioButton2.Visible = False
            Me.RadioButton3.Visible = False
            Try
                xOldEffPer = MiscCode.MNS(TblDeptBindingSource.Current.row.item("numEffPer"))
            Catch ex As Exception
            End Try
        End If


    End Sub

    Private Sub diaDeptEleAct_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub diaDeptEleAct_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Invalidate()
    End Sub

    Private Sub ComboBox1_Validating(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Validating
    Dim xNewValue As String = Me.ComboBox1.Text

    'Exit if Not yet selected or changed
    If String.IsNullOrEmpty(xNewValue) Then Return

    If xNewDept = True Then
    Me.TblDeptBindingSource.AddNew()
    Me.ComboBox1.Visible = False
    Me.TextBox2.Visible = True
    Dim xNewLoc As Point = Me.ComboBox1.Location
    Me.TextBox2.Location = xNewLoc
         Else
        Me.TextBox1.Visible = True
    End If

    If (xNewOps = True) And Me.ComboBox1.SelectedValue IsNot Nothing Then
    Me.TblElementBindingSource.AddNew()
    Me.GroupBox2.Enabled = True
    Me.ComboBox2.Visible = False
    Me.TextBox3.Visible = True
    Dim xNewLoc As Point = Me.ComboBox2.Location
    Me.TextBox3.Location = xNewLoc
    End If

    If (xNewAct = True) And Me.ComboBox1.SelectedValue IsNot Nothing Then
    Me.GroupBox2.Enabled = True
    Me.ComboBox2.Visible = True
    Me.TextBox3.Visible = False
    End If

    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        If Me.RadioButton1.Checked Then
        Dim txCnt As Integer = Me.DsActivityDB1.tblDept.Rows.Count

        Me.TblDeptBindingSource.AddNew()


        txCnt = Me.DsActivityDB1.tblDept.Rows.Count

            Me.GroupBox1.Enabled = True
            Me.ComboBox1.Visible = False
            Me.TextBox2.Visible = True
            Dim xNewLoc As Point = Me.ComboBox1.Location
            Me.TextBox2.Location = xNewLoc
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If Me.RadioButton2.Checked Then
        'Set up Dept Group Box to select the dept
            Me.GroupBox1.Enabled = True
            Me.ComboBox1.Visible = True
            Me.TextBox2.Visible = False
            xNewOps = True
            Else
            xNewOps = False
            Me.GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

        If Me.RadioButton3.Checked = True Then
        'Set up Dept Group Box to select the dept
            Me.GroupBox1.Enabled = True
            Me.ComboBox1.Visible = True
            Me.TextBox2.Visible = False

            xNewAct = True
            Else
            xNewAct = False
            Me.GroupBox3.Enabled = False
        End If
    End Sub

    Private Sub ComboBox2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBox2.Validating
    Dim xNewValue As String = Me.ComboBox2.Text


    'Exit if Not yet selected or changed
    If String.IsNullOrEmpty(xNewValue) Then Return

    If xNewAct = True Then
    Me.TblActivityBindingSource.AddNew()
    Me.GroupBox3.Enabled = True
    Me.ComboBox3.Visible = False
    Me.TextBox5.Visible = True
    Dim xNewLoc As Point = Me.ComboBox3.Location
    Me.TextBox5.Location = xNewLoc
    End If


    End Sub

    Public Sub UpdateProductWithEff(ByVal xDeptID As Integer, ByVal xEffPer As Decimal)

        Dim xTime As Decimal
        Dim xCost As Decimal

        Dim strSelect As String = "Select * from tblProdLink where FK_tblDept = " & xDeptID
        Dim ds As New DataSet
        Dim MyCon As New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        Dim MyComm As New SqlClient.SqlCommand(strSelect, MyCon)
        Dim MyAdap As New SqlClient.SqlDataAdapter(MyComm)
        MyCon.Open()
        MyAdap.Fill(ds, "DeptRecs")
        Dim xCount As Integer = ds.Tables(0).Rows.Count

        If xCount < 1 Then
            Exit Sub
        End If

        Dim i As Integer
        Dim drCurrent As DataRow
        Dim objCommandBuilder As New SqlClient.SqlCommandBuilder(MyAdap)

        drCurrent = ds.Tables(0).Rows(i)
        drCurrent.BeginEdit()

        For i = 0 To xCount - 1
            drCurrent = ds.Tables(0).Rows(i)
            Try
                xCost = ds.Tables(0).Rows(i).Item("dblLabourCost")
                xTime = ds.Tables(0).Rows(i).Item("dblValue")
            Catch ex As Exception
            End Try

            If xEffPer < 100 Then
                drCurrent.Item("dblAdjValue") = (xTime / (xEffPer / 100))
                drCurrent.Item("dblAdjCost") = (xCost / (xEffPer / 100))
            Else
                drCurrent.Item("dblAdjValue") = xTime
                drCurrent.Item("dblAdjCost") = xCost
            End If
            drCurrent.EndEdit()
            MyAdap.Update(ds, "DeptRecs")
        Next

        ds.Clear()
        MyCon.Close()


    End Sub
End Class
