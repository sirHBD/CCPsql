Imports System.IO
Imports System.Configuration

Public Class frmChangeDB
    Public blnTextBoxChange As Boolean = False

    Private Sub Label1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.Click
        'OpenFileDialog1.Filter = "Database Files |*.*db"
        'OpenFileDialog1.ShowDialog()

        Dim DBtype As String = Me.ComboBox1.SelectedItem

        Select Case DBtype
            Case "Access"

                Dim fd As OpenFileDialog = New OpenFileDialog()
                fd.Filter = "Database Files |*.*db"

                If fd.ShowDialog() = DialogResult.OK Then
                    Dim xFile As String = fd.FileName
                    Dim xConnString As String = Me.Tag
                    Dim xConnArr = Me.Tag.ToString.Split("=")
                    Dim xSplitstr = xConnArr(2).Split(";")
                    Dim xHasPwd As Boolean = False
                    If xConnArr.length > 3 Then
                        xHasPwd = True
                    Else
                        xHasPwd = False
                    End If
                    If xHasPwd = True Then
                        xConnString = xConnArr(0) & "=" & xConnArr(1) & "=" & xFile & ";" & xSplitstr(1) & "=" & xConnArr(3) & "=" & xConnArr(4)
                    Else
                        xConnString = xConnArr(0) & "=" & xConnArr(1) & "=" & xFile & ";" '& xSplitstr(1)
                    End If
                    Me.TextBox1.Text = xConnString
                End If

            Case "SQL server"
                Dim xOldString As String = Me.TextBox1.Text
                Dim xOld = xOldString.Split(";")

                Try
                    Dim xNewServer As String = Me.ComboBox2.SelectedItem
                    If xNewServer.ToUpper.Contains("\") = False Then
                        xNewServer = xNewServer & "\SQLEXPRESS"
                    End If
                    Dim xNewDB As String = Me.ComboBox3.SelectedItem
                    If String.IsNullOrEmpty(xNewServer) Or String.IsNullOrEmpty(xNewDB) Then
                        MsgBox("We can not replace blanks.  Ensure all fields have values")
                        Return
                    End If

                    Try
                        Dim fOut As StreamWriter = New StreamWriter("Output.config")
                        Using sr As StreamReader = New StreamReader("CCPconnections.config")
                            Dim line, NewLine As String
                            line = sr.ReadLine()
                            Do

                                NewLine = line.Replace(xOld(0), "Data Source=" & xNewServer)
                                NewLine = NewLine.Replace(xOld(1), "Initial Catalog=" & xNewDB)

                                fOut.WriteLine(NewLine)
                                line = sr.ReadLine()

                            Loop Until line Is Nothing
                            sr.Close()
                            fOut.Close()
                        End Using
                        My.Computer.FileSystem.DeleteFile("CCPconnections.config")
                        My.Computer.FileSystem.RenameFile("Output.config", "CCPconnections.config")
                        'My.Computer.FileSystem.DeleteFile("Output.config")
                    Catch Ex As Exception
                        ' Let the user know what went wrong.
                        Console.WriteLine("The file could not be read:")
                        Console.WriteLine(Ex.Message)
                    End Try

                    MsgBox("The connection strings were updated.  The system must close and be restarted for the change to take effect")
                    Me.Close()

                Catch ex As Exception
                    MsgBox("Then connection strings could not be changed.  See error below:" & vbCrLf & ex.ToString())
                End Try


        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        If blnTextBoxChange = True Then

            My.Settings.LocalSetting = Me.TextBox1.Text

        End If

        'Change the Server / Local setting
        If Me.CheckBox1.Checked = True Then
            My.Settings.MyLocalConn = True
        End If

        If Me.CheckBox2.Checked = True Then
            My.Settings.MyLocalConn = False
        End If

        'Save and close
        My.Settings.SaveFolder = Me.TextBox2.Text
        My.Settings.Save()
        Label1_Click(Me, e)

        ApplicationStartupForm.Close()

    End Sub

    Private Sub frmChangeDB_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = My.Settings.SysName & " - " & Me.Text
        Me.TextBox1.Text = Me.Tag
        Me.ComboBox1.SelectedItem = My.Settings.DBsetting

        If My.Settings.MyLocalConn = False Then
            Me.CheckBox1.Checked = False
            Me.CheckBox2.Checked = True
        Else
            Me.CheckBox1.Checked = True
            Me.CheckBox2.Checked = False
        End If

        Me.TextBox2.Text = My.Settings.SaveFolder

        'Reset the textbox change flag after initial filling
        blnTextBoxChange = False
    End Sub

    Private Sub CheckBox1_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckStateChanged
        If Me.CheckBox1.Checked = True Then
            Me.CheckBox2.Checked = False
        Else
            Me.CheckBox2.Checked = True
        End If
    End Sub

    Private Sub CheckBox2_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckStateChanged
        If Me.CheckBox2.Checked = True Then
            Me.CheckBox1.Checked = False
        Else
            Me.CheckBox1.Checked = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        blnTextBoxChange = True
        'Me.Tag = Me.TextBox1.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox2.Text = FolderBrowserDialog1.SelectedPath & "\"
        End If
    End Sub

    Private Sub ComboBox2_DropDown(sender As Object, e As System.EventArgs) Handles ComboBox2.DropDown
        Dim oTable As Data.DataTable
        Dim lstServers As List(Of String)
        Try
            If sender.Items.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                oTable = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources

                For Each oRow As DataRow In oTable.Rows
                    If oRow("InstanceName").ToString = "" Then
                        sender.Items.Add(oRow("ServerName"))
                    Else
                        sender.Items.Add(oRow("ServerName").ToString & "\" & oRow("InstanceName").ToString)
                    End If
                Next oRow
            End If
        Catch ex As Exception
            'ErrHandler("frmLogin", "cmbServer_DropDown", ex.Source, ex.Message, ex.InnerException)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            If oTable IsNot Nothing Then
                oTable.Dispose()
            End If
        End Try
    End Sub


    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        For Each xConnection As Object In ConfigurationManager.ConnectionStrings
            MsgBox(xConnection.Name & " " & xConnection.ToString())
        Next
    End Sub
End Class