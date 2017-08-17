Imports System.Windows.Forms

Public Class diaTmpProduct
    Dim IsSelected As Boolean = False
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If IsSelected = True Then
            QQ_Variables.xProdCopyID = Me.ComboBox1.SelectedValue
            QQ_Variables.xProdCode = Me.TextBox1.Text
            QQ_Variables.xProdDesc = Me.TextBox2.Text
            QQ_Variables.xSpec1 = Me.TextBox3.Text
            QQ_Variables.xSpec2 = Me.TextBox4.Text
            QQ_Variables.xSpec3 = Me.TextBox5.Text
            Me.ComboBox1.SelectedIndex = -1
            Me.GroupBox2.Visible = False
            IsSelected = False
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("No product was selected")
        End If



    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ComboBox1.SelectedIndex = -1
        Me.GroupBox2.Visible = False

        Me.Close()
    End Sub

    Private Sub diaTmpProduct_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        My.Forms.ApplicationStartupForm.ss1.Text = ""
        Me.GroupBox1.BackColor = myGBColor
        Me.TblProductTableAdapter1.Fill(Me.DsProdDB1.tblProduct)
        Me.Text = "Add temporary product"

        Me.ComboBox1.DataSource = Me.DsProdDB1.tblProduct
        Me.ComboBox1.ValueMember = "idtblProduct"
        Me.ComboBox1.DisplayMember = "txtProdDesc"
        'Me.ComboBox1.SelectedIndex = -1


    End Sub

    Private Sub diaTmpProduct_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub diaTmpProduct_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Invalidate()

    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Dim dv As New DataView(Me.DsProdDB1.tblProduct)
        Me.GroupBox2.Visible = True
        IsSelected = True

        '
        'Check for the product code
        Dim xNewProductCode As String = ""
        dv.RowFilter = "txtProdCde Like '" & "TEMP*'"
        If dv.Count = 0 Then
            xNewProductCode = "TEMP-1"
        Else
            dv.Sort = "idtblProduct Desc"
            Dim xCodeArr = dv(0)("txtProdCde").ToString().Split("-")
            xNewProductCode = "TEMP-" & xCodeArr(1) + 1
        End If

        'Fill the fields
        Dim xNewID As Integer
        If Me.ComboBox1.SelectedText <> "" Then xNewID = Me.ComboBox1.SelectedValue
        dv.RowFilter = "idtblProduct = " & xNewID

        Me.TextBox1.Text = xNewProductCode
        Me.TextBox2.Text = dv(0)("txtProdDesc") & " - Copy"
        Me.TextBox3.Text = dv(0)("txtProdSpec1").ToString()
        Me.TextBox4.Text = dv(0)("txtProdSpec2").ToString()
        Me.TextBox5.Text = dv(0)("txtProdSpec3").ToString()
    End Sub
End Class
