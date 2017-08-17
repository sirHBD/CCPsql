Public Class frmJCMonitor
    Public IsOpening As Boolean = True
    Private Sub frmJCMonitor_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.LstJCMonitorTableAdapter1.Fill(Me.DsProduction.lstJCMonitor)
        Me.ComboBox1.SelectedIndex = 0
        Me.ComboBox2.SelectedIndex = 0


        IsOpening = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.ComboBox1.SelectedItem = "Desc" Then
            Me.LstJCMonitorBindingSource.Sort = "dblQuoteNum Desc"
        Else
            Me.LstJCMonitorBindingSource.Sort = "dblQuoteNum ASC"
        End If
        If IsOpening = False Then
            Me.DataGridView1.DataSource = ""
            Me.DataGridView1.DataSource = LstJCMonitorBindingSource
        End If


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim xShowType As String = Me.ComboBox2.SelectedItem
        Select Case xShowType
            Case "All"
                Me.LstJCMonitorBindingSource.Filter = ""
            Case "Quote only"
                Me.LstJCMonitorBindingSource.Filter = "dblPONum is null and ReceiptDate is null and dblInvoiceNum is null"
        End Select
        If IsOpening = False Then
            Me.DataGridView1.DataSource = ""
            Me.DataGridView1.DataSource = LstJCMonitorBindingSource
        End If

    End Sub
End Class