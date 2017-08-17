Imports System.Windows.Forms

Public Class diaMarginPopup

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub diaMarginPopup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    My.Forms.ApplicationStartupForm.ss1.Text = String.Empty

    'TODO: This line of code loads data into the 'DsActivityDB1.tblActivity' table. You can move, or remove it, as needed.
    Me.TblActivityTableAdapter.Fill(Me.DsActivityDB1.tblActivity)
    'TODO: This line of code loads data into the 'DsProdDB.tblProduct' table. You can move, or remove it, as needed.
    Me.TblProductTableAdapter.Fill(Me.DsProdDB.tblProduct)
    'TODO: This line of code loads data into the 'DsActivityDB1.tblElement' table. You can move, or remove it, as needed.
    Me.TblElementTableAdapter.Fill(Me.DsActivityDB1.tblElement)
    'TODO: This line of code loads data into the 'DsActivityDB1.tblDept' table. You can move, or remove it, as needed.
    Me.TblDeptTableAdapter.Fill(Me.DsActivityDB1.tblDept)
        'TODO: This line of code loads data into the 'DsProdDB.tblProdLink' table. You can move, or remove it, as needed.
        Me.TblProdLinkTableAdapter.FillByDept(Me.DsProdDB.tblProdLink)

        Dim xArr = Me.Tag.ToString.Split("|")
        Dim xProdID As Integer = CInt(xArr(0))
        Dim xCheck As String = xArr(1)
        If xCheck = "UnChecked" Then

            'Me.DataGridView1.Columns("DblValueDataGridViewTextBoxColumn").DataPropertyName = "dblAdjValue"
            'Me.DataGridView1.Columns("DblValueDataGridViewTextBoxColumn").DefaultCellStyle.Format = String.Format("N4")
            Me.DataGridView1.Columns("DblLabourCostDataGridViewTextBoxColumn").DataPropertyName = "AdjCost"
            Me.DataGridView1.Columns("DblLabourCostDataGridViewTextBoxColumn").DefaultCellStyle.Format = "#####.000"
        Else
            Me.DataGridView1.Columns("DblLabourCostDataGridViewTextBoxColumn").DataPropertyName = "LabCost"
            Me.DataGridView1.Columns("DblLabourCostDataGridViewTextBoxColumn").DefaultCellStyle.Format = "#####.000"
        End If
        Me.TblProdLinkBindingSource.Filter = "FK_tblProduct = " & xProdID

    Me.Text = My.Settings.SysName & " - " & "Display Labour Details"
    Me.DataGridView1.BackgroundColor = MiscMod.myGBColor
    MiscCode.ResizeGrid(Me.DataGridView1)
    End Sub

    Private Sub diaMarginPopup_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    Dim BaseRec As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim Grad As New Drawing2D.LinearGradientBrush(BaseRec, MyTopColor, myBotColor, 120)
        e.Graphics.FillRectangle(Grad, BaseRec)
    End Sub

    Private Sub diaMarginPopup_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Invalidate()
    End Sub

End Class
