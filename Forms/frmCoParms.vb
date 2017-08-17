Imports System.Data
Imports System.Data.Odbc
Imports System.Drawing.Drawing2D


Public Class frmCoParms

    Private Sub frmCoParms_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        
        Try
            Me.TblCoInfoTableAdapter2.Fill(Me.DsProdDB1.tblCoInfo)
        Catch ex As Exception
            MessageBox.Show("Error in opening the database - " & vbCrLf & ex.Message)
            Exit Sub
        End Try

        If Me.DsProdDB1.Tables("tblCoInfo").Rows.Count = 0 Then

            Me.TblcoinfoBindingSource.AddNew()
            Me.TextBox20.Enabled = True

        Else

            'Now make all the text boxes uneditable
            For Each ctrl As Control In Me.Controls
                If TypeOf (ctrl) Is TextBox Then
                    CType(ctrl, TextBox).ReadOnly = True
                End If
                If TypeOf (ctrl) Is GroupBox Then
                    CType(ctrl, GroupBox).Enabled = False
                End If
            Next
        End If

    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Dim myTopColor As Color = Color.FromArgb(195, 224, 129)
        Dim myBotColor As Color = Color.FromArgb(182, 209, 114)
        Dim myGBColor As Color = Color.FromArgb(213, 235, 159)

        'Me.BackColor = Color.FromArgb(195, 224, 129)


        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New LinearGradientBrush(BaseRec, myTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)

        Me.GroupBox1.BackColor = myGBColor
        Me.GroupBox2.BackColor = myGBColor
        Me.GroupBox3.BackColor = myGBColor
        Me.GroupBox4.BackColor = myGBColor
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Invalidate()

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

        Me.Validate()
        Me.TblcoinfoBindingSource.EndEdit()
        Try
        Me.TblCoInfoTableAdapter2.Update(Me.DsProdDB1.tblCoInfo)
            My.Forms.ApplicationStartupForm.ss1.Text = "Record Saved"

            'Now make all the text boxes uneditable
            For Each ctrl As Control In Me.Controls
                If TypeOf (ctrl) Is TextBox Then
                    CType(ctrl, TextBox).ReadOnly = True
                End If
                If TypeOf (ctrl) Is GroupBox Then
                    CType(ctrl, GroupBox).Enabled = False
                End If
            Next

        Catch ex As DBConcurrencyException
        MsgBox("The company number can not be changed", , My.Settings.SysName & " - Company Information")
        Me.Close()
        End Try
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click

        Me.DsProdDB1.RejectChanges()
        Me.TblCoInfoTableAdapter2.Fill(Me.DsProdDB1.tblCoInfo)
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click

        Me.Close()

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
    For Each ctrl As Control In Me.Controls
            If TypeOf (ctrl) Is TextBox Then
            CType(ctrl, TextBox).ReadOnly = False
            End If
            If TypeOf (ctrl) Is GroupBox Then
            CType(ctrl, GroupBox).Enabled = True
            End If
        Next
    End Sub

    Private Sub Toolstripbutton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
    If Me.TextBox17.Text > 0 Then
    MsgBox("The system is configured as a single company system.  If you require more than one company please contact the vendor", , My.Settings.SysName & " - Company Information")
    Else
            For Each ctrl As Control In Me.Controls
                If TypeOf (ctrl) Is TextBox Then
                CType(ctrl, TextBox).ReadOnly = False
                End If
                If TypeOf (ctrl) Is GroupBox Then
                CType(ctrl, GroupBox).Enabled = True
                End If
            Next
            Me.TblcoinfoBindingSource.AddNew()
    End If
    End Sub

    Private Sub TextBox17_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox17.Validating
    Dim xOK As Boolean = MiscCode.IsNumericOK(sender.text)
        If xOK = False Then
        Me.ErrorProvider1.SetError(sender, "Company Number should be numeric")
        e.Cancel = True
            Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub DateTimePicker1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateTimePicker1.Validating
    If IsDate(sender.value) = False Then
    Me.ErrorProvider1.SetError(sender, "You must select a valid date")
    e.Cancel = True
        Else
        Me.ErrorProvider1.SetError(sender, "")
    End If
    End Sub

    Private Sub Textbox6_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox6.Validating
        If MiscCode.IsMandatoryOK(sender.text) = False Or MiscCode.IsNumericOK(sender.text) = False Then
        Me.ErrorProvider1.SetError(sender, "Mandatory Numeric input required")
        e.Cancel = True
            Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub Textbox7_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox7.Validating
        If MiscCode.IsMandatoryOK(sender.text) = False Or MiscCode.IsNumericOK(sender.text) = False Then
        Me.ErrorProvider1.SetError(sender, "Mandatory Numeric input required")
        e.Cancel = True
            Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub Textbox8_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox8.Validating
        If MiscCode.IsMandatoryOK(sender.text) = False Or MiscCode.IsNumericOK(sender.text) = False Then
        Me.ErrorProvider1.SetError(sender, "Mandatory Numeric input required")
        e.Cancel = True
            Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim frm As New frmRepViewer
        frm.Tag = "CoInfo"
        frm.Show()
        End Sub
End Class