Imports System.Data.SqlClient
Imports System.Math



Public Class MiscCode
    Const q = "'"

    Shared Sub ResizeGrid(ByVal xGrid As DataGridView, Optional ByVal RowHeaderVisible As Boolean = True)
        Dim xFactor As Integer

        Try
            'Get total column predefined size.
            Dim xTotSize As Integer
            For Each col As DataGridViewColumn In xGrid.Columns
                If col.Visible = True Then
                    xTotSize = xTotSize + col.Width
                End If
            Next

            'Determine if we have a vertical scroll bar
            'If xGrid.verticalScrollBar.Size.Width > 0 Then
            xFactor = SystemInformation.VerticalScrollBarWidth
            xFactor = xFactor + 2
            'End If

            'Now rezize the columns
            Dim xWidth As Integer
            If RowHeaderVisible = True Then
                xWidth = (xGrid.Width - (xGrid.RowHeadersWidth + 1)) - xFactor
            Else
                xWidth = (xGrid.Width - xFactor)
            End If

            For Each col As DataGridViewColumn In xGrid.Columns
                If col.Visible = True Then
                    col.Width = col.Width * (xWidth / xTotSize)
                End If
            Next
        Catch ex As Exception
            MsgBox("Could not resize the datagrid.  See message below and contact system administrator " & vbCrLf & ex.Message, , My.Settings.SysName)
        End Try

    End Sub

    Shared Sub AdjustWidthComboBox_DropDown(sender As Object, e As System.EventArgs)
        Dim senderComboBox As ComboBox = DirectCast(sender, ComboBox)
        Dim width As Integer = senderComboBox.DropDownWidth
        Dim g As Graphics = senderComboBox.CreateGraphics()
        Dim font As Font = senderComboBox.Font
        Dim vertScrollBarWidth As Integer = If((senderComboBox.Items.Count > senderComboBox.MaxDropDownItems), SystemInformation.VerticalScrollBarWidth, 0)

        Dim newWidth As Integer
        Dim xTest As String = DirectCast(sender, ComboBox).Items.Item(0).name
        For Each s As String In DirectCast(sender, ComboBox).Items
            newWidth = CInt(g.MeasureString(s, font).Width) + vertScrollBarWidth
            If width < newWidth Then
                width = newWidth
            End If
        Next
        senderComboBox.DropDownWidth = width
    End Sub

    Shared Function IsMandatoryOK(ByVal xString As String) As Boolean

        If Len(xString) > 0 Then
            IsMandatoryOK = True
        Else
            IsMandatoryOK = False
        End If

    End Function

    Shared Function IsNumericOK(ByVal xString As String) As Boolean

    If Len(xString) > 0 And IsNumeric(xString) Then
    IsNumericOK = True
    Else
    IsNumericOK = False
    End If

    End Function

    Public Shared Function MNS(ByVal s As Object) As String
        ' Return String if object is not null, else return empty.string
        If IsDBNull(s) Then
            Return String.Empty
        Else
            Return CType(s, String)
        End If
    End Function

    Public Shared Function bdQuickFind(ByVal xConStr As String, _
ByVal xField As String, ByVal xValue As String, ByVal xTable As String, _
ByVal xField1 As String, ByVal xValue1 As String, _
Optional ByVal yField As String = Nothing, _
Optional ByVal yField1 As String = Nothing) As String

    Dim xReturnValue As String = Nothing
    Dim xTextValue As String = Nothing
    bdQuickFind = Nothing

    'Dim myConnection = New SqlClient.SqlConnection(xConStr)
        Dim myConnection = New SqlClient.SqlConnection(xConStr)
        'establishing connection. you need to provide password for sql server
        Try
            myConnection.Open()
            'opening the connection
            'Dim myCommand = New SqlClient.SqlCommand
            Dim myCommand = New SqlClient.SqlCommand
            If Len(xField) > 1 And xField1 = Nothing And yField = Nothing And yField1 = Nothing Then
                'myCommand = New SqlClient.SqlCommand("Select " & xField & " from " & _
                'xTable & " Where " & xField & " = " & q & xValue & q, _
                'myConnection)
                myCommand = New SqlClient.SqlCommand("Select " & xField & " from " & _
                xTable & " Where " & xField & " = " & q & xValue & q, _
                myConnection)
                xReturnValue = 1
            End If

            If Len(xField) > 1 And xField1 = Nothing And Len(yField) > 0 And yField1 = Nothing Then
                myCommand = New SqlClient.SqlCommand("Select " & xField & ", " & yField & " from " & _
                xTable & " Where " & xField & " = " & q & xValue & q, _
                myConnection)
                xReturnValue = 2
            End If

            If Len(xField) > 1 And Len(xField1) > 1 And yField1 = Nothing And yField = Nothing Then
                myCommand = New SqlClient.SqlCommand("Select " & xField & ", " & xField1 & " from " & _
                xTable & " Where(" & xField & " = " & q & xValue & q & " And " & xField1 & " = " & q & xValue1 & q & ")", _
                myConnection)
                xReturnValue = 3
            End If

            If Len(xField) > 1 And Len(xField1) > 1 And yField1 = Nothing And Len(yField) > 0 Then
                myCommand = New SqlClient.SqlCommand("Select " & xField & ", " & xField1 & ", " & yField & " from " & _
                xTable & " Where(" & xField & " = " & q & xValue & q & " And " & xField1 & " = " & q & xValue1 & q & ")", _
                myConnection)
                xReturnValue = 4
            End If

            If Len(xField) > 1 And Len(xField1) > 1 And Len(yField1) > 0 And Len(yField) > 0 Then
                myCommand = New SqlClient.SqlCommand("Select " & xField & ", " & xField1 & ", " & yField & ", " & yField1 & " from " & _
                xTable & " Where(" & xField & " = " & q & xValue & q & " And " & xField1 & " = " & q & xValue1 & q & ")", _
                myConnection)
                xReturnValue = 5
            End If

            If Len(xField) > 1 And xField1 = Nothing And yField <> Nothing And yField1 <> Nothing Then
                myCommand = New SqlClient.SqlCommand("Select " & xField & ", " & yField & ", " & yField1 & " from " & _
                xTable & " Where " & xField & " = " & q & xValue & q, _
                myConnection)
                xReturnValue = 6
            End If


            'executing the command and assigning it to connection 
            Dim dr = myCommand.ExecuteReader()

            If dr.hasrows() = True Then
                While dr.read()


                    Select Case xReturnValue
                        Case 1
                            xTextValue = dr.item(xField)
                        Case 2
                            xTextValue = dr.item(xField) & "|" & dr.item(yField)
                        Case 3
                            xTextValue = dr.item(xField) & "|" & dr.item(xField1)
                        Case 4
                            xTextValue = dr.item(xField) & "|" & dr.item(xField1) & "|" & dr.item(yField)
                        Case 5
                            xTextValue = dr.item(xField) & "|" & dr.item(xField1) & "|" & dr.item(yField) & "|" & dr.item(yField1)
                        Case 6
                            xTextValue = dr.item(xField) & "|" & "|" & dr.item(yField) & "|" & dr.item(yField1)
                    End Select

                    Return xTextValue
                End While
            Else
                Return String.Empty
            End If
            dr.Close()
            myConnection.Close()
        Catch e As Exception
            MsgBox("Problem finding - " & xField & " - " & e.ToString)
        Finally
            myConnection.Close()
        End Try

    End Function

    Shared Function DisplayError(ByVal xErrCde As String, Optional ByVal xType As String = Nothing) As Integer
        'Dim myConnection = New SqlClient.SqlConnection(xConStr)
        Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        'establishing connection. you need to provide password for sql server
        Try
            myConnection.Open()
            'opening the connection
            'Dim myCommand = New SqlClient.SqlCommand
            Dim myCommand = New SqlClient.SqlCommand
            myCommand = New SqlClient.SqlCommand("Select * FROM tblErrCode where txtErrCode = " & q & xErrCde & q, myConnection)
            Dim dr = myCommand.ExecuteReader()

            If dr.hasrows() = True Then
                While dr.read()
                    Dim xMsgText As String = dr.item("txtErrMsg")

                    Dim xMsgType As String
                    If xType = Nothing Then
                        xMsgType = dr.item("txtMsgBoxType")
                    Else
                        xMsgType = xType
                    End If

                    Dim xMsg As MsgBoxStyle
                    Select Case xMsgType
                        Case "OKOnly"
                            xMsg = MsgBoxStyle.OkOnly
                        Case "OKCancel"
                            xMsg = MsgBoxStyle.OkCancel
                        Case "YesNo"
                            xMsg = MsgBoxStyle.YesNo
                        Case "YesNOCancel"
                            xMsg = MsgBoxStyle.YesNoCancel
                        Case "YesCancel"
                            xMsg = MsgBoxStyle.OkCancel
                        Case Else
                            xMsg = Nothing
                    End Select
                    Dim xMsgHeader As String = My.Settings.SysName & " - " & "Messages"
                    Dim xMsgBoxResult As Integer
                    xMsgBoxResult = MsgBox(xMsgText, xMsg, xMsgHeader)

                    If xMsgBoxResult > 0 Then
                        Return xMsgBoxResult
                    Else
                        Return 0
                    End If

                End While
            End If
        Catch ex As Exception
            MsgBox("Error system Error")
            Return 0
        End Try

    End Function

    Shared Function GetValueonID(ByVal xID As Integer, ByVal xIDField As String, ByVal xTable As String, ByVal xReturnField As String) As String
        Try
            Dim xReturnValue As String = Nothing
            Dim xTextValue As String = Nothing

            Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
            'establishing connection. you need to provide password for sql server
            myConnection.Open()
            'opening the connection

            Dim myCommand = New SqlClient.SqlCommand
            myCommand = New SqlClient.SqlCommand("Select " & xReturnField & " from " & xTable & " where " & xIDField & " = " & xID, myConnection)
            Dim dr = myCommand.ExecuteReader()

            If dr.HasRows() = True Then
                dr.Read()
                Return dr.Item(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Shared Sub UpdateMaterialLinks(ByVal xNewCost As Decimal, ByVal xMatID As Integer)

        Dim Mystr As String = "Update tblMatLink Set dblMatCost = dblMatQty * " & xNewCost & " Where fk_tblMaterial = " & xMatID
        Dim Con As New SqlConnection(My.Settings.ConnectionString1)
        Con.Open()
        'Dim OLEDBAdapter As New OleDbDataAdapter(OLEDBstr, OLEDBCon)
        'Dim OLEDBCommBuilder As SqlDataAdapterBuilder = New SqlDataAdapterBuilder(OLEDBAdapter)
        Dim myCommand As New SqlCommand(Mystr, Con)
        myCommand.ExecuteNonQuery()


        Con.Close()
        My.Forms.ApplicationStartupForm.ss1.Text = "Product " & xMatID & " modified"

    End Sub

    Shared Sub UpdateComponentLinks(ByVal xNewCost As Decimal, ByVal xMatID As Integer)

        Dim Con As New SqlConnection(My.Settings.ConnectionString1)
        Con.Open()
        Dim strSQL As String = "Select dblCompQty from tblComponent where fk_MaterialLinkID = " & xMatID
        Dim xComm As New SqlClient.SqlCommand(strSQL, Con)
        Dim xCompQty As Decimal

        xCompQty = xComm.ExecuteScalar


        Dim Mystr As String = "Update tblComponent Set dblMaterialPrice = Round(" & xNewCost & ",4) ,dblCompCost = Round(" & xNewCost * xCompQty & ",4) Where fk_MaterialLinkID = " & xMatID
        
        'Dim OLEDBAdapter As New OleDbDataAdapter(OLEDBstr, OLEDBCon)
        'Dim OLEDBCommBuilder As SqlDataAdapterBuilder = New SqlDataAdapterBuilder(OLEDBAdapter)
        Dim myCommand As New SqlCommand(Mystr, Con)
        myCommand.ExecuteNonQuery()

        'Now calculate the components new cost and update the material table
        strSQL = "Select * from tblComponent where fk_MaterialLinkID = " & xMatID & " order by fk_ComponentLinkID"
        Dim xAdap As New SqlClient.SqlDataAdapter(strSQL, Con)
        Dim ds As New DataSet
        xAdap.Fill(ds, "Comp")

        If ds.Tables("Comp").Rows.Count = 0 Then
            Con.Close()
            Exit Sub
        End If

        Dim xCompCost As Decimal
        Dim xCompID As Integer

        For Each xRow As DataRow In ds.Tables("Comp").Rows
            xCompID = xRow.Item("FK_ComponentLinkID")
            xCompCost = CalcCompCost(xCompID)
            Mystr = "Update tblMaterial Set dblMaterialPrice = " & xCompCost & " Where id_tblMaterial = " & xCompID
            myCommand.CommandText = Mystr
            myCommand.ExecuteNonQuery()
        Next

        Con.Close()
        My.Forms.ApplicationStartupForm.ss1.Text = "Product " & xMatID & " modified"

    End Sub

    Shared Sub ComboBoxFiller(ByVal sender As Object, ByVal xDisplayField As String, ByVal xCatName As String, ByVal xCat As String, ByVal xTable As String, Optional ByVal xWhere As Boolean = True, Optional ByVal xNumCondition As Boolean = False, Optional ByVal xDistinct As Boolean = False)

        sender.Items.Clear()
        Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        Dim myCommand = New SqlClient.SqlCommand
        If xWhere = True Then
            myCommand = New SqlClient.SqlCommand("Select * FROM " & xTable & " Where " & xCatName & " = " & q & xCat & q, myConnection)
            If Len(xDisplayField) = 0 Then
                xDisplayField = "txtValueDesc"
            End If
        Else
            myCommand = New SqlClient.SqlCommand("Select * FROM " & xTable, myConnection)
            xDisplayField = xCatName
        End If

        If xNumCondition = True Then
            myCommand = New SqlClient.SqlCommand("Select * FROM " & xTable & " Where " & xCatName & " = " & xCat, myConnection)
        End If

        If xDistinct = True Then
            myCommand = New SqlClient.SqlCommand("Select Distinct " & xDisplayField & " FROM " & xTable, myConnection)
        End If


        Dim myAdaptor As New SqlClient.SqlDataAdapter(myCommand)
        Dim ds As New DataSet
        myAdaptor.Fill(ds, "ComboDS")

        For Each xRow As DataRow In ds.Tables("ComboDS").Rows
            sender.Items.Add(xRow.Item(xDisplayField))
        Next
    End Sub

    Shared Function GetCoNo()
        Try
            Dim xReturnValue As String = Nothing
            Dim xTextValue As String = Nothing

            Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
            'establishing connection. you need to provide password for sql server
            myConnection.Open()
            'opening the connection

            Dim myCommand = New SqlClient.SqlCommand
            myCommand = New SqlClient.SqlCommand("Select idtblCoInfo from tblCoInfo", myConnection)
            Dim dr = myCommand.ExecuteReader()

            If dr.HasRows() = True Then
                dr.Read()
                Return dr.Item(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Shared Function GetProductID(ByVal xProdCde As String)
        Try
            Dim xReturnValue As String = Nothing
            Dim xTextValue As String = Nothing

            Dim myConnection = New SqlConnection(My.Settings.ConnectionString1)
            'establishing connection. you need to provide password for sql server
            myConnection.Open()
            'opening the connection

            Dim myCommand = New SqlClient.SqlCommand
            myCommand = New SqlClient.SqlCommand("Select idtblProduct from tblProduct where txtProdCde = '" & xProdCde & "'", myConnection)
            Dim dr = myCommand.ExecuteReader()

            If dr.HasRows() = True Then
                dr.Read()
                Return dr.Item(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Shared Function GetOHRate()
        Dim xOH As Decimal
        Dim xVol As Decimal

        Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        myConnection.Open()
        Dim myCommand = New SqlClient.SqlCommand
        myCommand = New SqlClient.SqlCommand("Select Sum(dblOHAmount) AS TotOH from tblOH", myConnection)
        Dim dr = myCommand.ExecuteReader()
        If dr.hasrows() = True Then
            While dr.read()
                xOH = dr.item("TotOH")
            End While
        End If
        dr.close()
        'Dim strSql As String = ""
        'myCommand = New SqlClient.SqlCommand("Select * from lstBudgetperCategory", myConnection)
        'Dim myAdaptor As New OleDb.OleDbDataAdapter(myCommand)
        'Dim ds As New DataSet
        'myAdaptor.Fill(ds, "MyTable")

        'Dim x2070, x89, x127 As Decimal
        'Dim i As Integer

        'For i = 0 To ds.Tables("MyTable").Rows.Count - 1
        '    If ds.Tables("MyTable").Rows(i).Item("txtCostSortCat") = "2070" Then
        '        xVol = xVol + ds.Tables("MyTable").Rows(i).Item("sumOfDecVolume")
        '    End If
        '    If ds.Tables("MyTable").Rows(i).Item("txtCostSortCat") = "127" Then
        '        xVol = xVol + ds.Tables("MyTable").Rows(i).Item("sumOfDecVolume") / 16
        '    End If
        '    If ds.Tables("MyTable").Rows(i).Item("txtCostSortCat") = "89" Then
        '        xVol = xVol + ds.Tables("MyTable").Rows(i).Item("sumOfDecVolume") / 24
        '    End If
        'Next
        Dim xFriday As Decimal
        Dim xNormal As Decimal
        Dim xEmployees As Decimal

        myCommand = New SqlClient.SqlCommand("Select *  from tblCoInfo", myConnection)
        Dim dr1 = myCommand.ExecuteReader()
        If dr1.hasrows() = True Then
            While dr1.read()
                xFriday = dr1.item("dblFridayLabHours")
                xNormal = dr1.item("dblNormalLabHours")
            End While
        End If
        dr1.close()

        'Each Year consist of 50 weeks - each personnel members spens this time in the factory per year
        xVol = ((xFriday + (4 * xNormal)) * 52) '* 60


        'Now get the number of production employees
        myCommand = New SqlClient.SqlCommand("Select Count(id_tblStaff) AS TotEmp from tblStaff", myConnection)
        Dim dr2 = myCommand.ExecuteReader()
        If dr2.hasrows() = True Then
            While dr2.read()
                xEmployees = dr2.item("TotEmp")
            End While
        End If

        myConnection.close()

        Return (xOH / (xVol * xEmployees)) '* xProdIndex
    End Function

    Public Shared Function GetEffPer(ByVal xDeptID As Integer)
        Dim xEffPer As Double

        Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        myConnection.Open()
        Dim myCommand = New SqlClient.SqlCommand
        myCommand = New SqlClient.SqlCommand("Select numEffPer from tblDept where idtblDept = " & xDeptID, myConnection)
        Dim dr = myCommand.ExecuteReader()
        If dr.hasrows() = True Then
            While dr.read()
                If IsDBNull(dr.item(0)) Then
                    xEffPer = 100
                Else
                    xEffPer = dr.item(0)
                End If
            End While
        End If

        If xEffPer = 0 Then
            xEffPer = 100
        End If

        Return xEffPer

        dr.close()
        myConnection.Close()
    End Function

    Shared Function GetOHRatePerSQM()
        Dim xOH As Decimal
        Dim xVol As Decimal

        Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        myConnection.Open()
        Dim myCommand = New SqlClient.SqlCommand
        myCommand = New SqlClient.SqlCommand("Select Sum(dblOHAmount) AS TotOH from tblOH", myConnection)
        Dim dr = myCommand.ExecuteReader()
        If dr.hasrows() = True Then
            While dr.read()
                xOH = dr.item("TotOH")
            End While
        End If
        dr.close()
        myConnection.close()



        Dim strSql As String = ""
        myCommand = New SqlClient.SqlCommand("Select * from lstBudgetperCategory", myConnection)
        Dim myAdaptor As New OleDb.OleDbDataAdapter(myCommand)
        Dim ds As New DataSet
        myAdaptor.Fill(ds, "MyTable")

        Dim i As Integer

        For i = 0 To ds.Tables("MyTable").Rows.Count - 1
            If ds.Tables("MyTable").Rows(i).Item("txtProdSpec1") = "2070" Then
                xVol = xVol + ds.Tables("MyTable").Rows(i).Item("sumOfDecVolume") * 2.07
            End If
            If ds.Tables("MyTable").Rows(i).Item("txtProdSpec1") = "127" Then
                xVol = xVol + (ds.Tables("MyTable").Rows(i).Item("sumOfDecVolume") * 0.127)

            End If
            If ds.Tables("MyTable").Rows(i).Item("txtProdSpec1") = "89" Then
                xVol = xVol + ds.Tables("MyTable").Rows(i).Item("sumOfDecVolume") * 0.089
            End If
        Next

        'xVol = 1657453
        If xVol > 0 Then
            Return xOH / xVol
        Else
            Return 0
        End If

        myAdaptor = Nothing
        myConnection.Close()
    End Function

    Shared Function GetOHRatePerMinute()
        Dim xOH As Decimal
        Dim xVol As Decimal
        Dim xFriday As Decimal
        Dim xNormal As Decimal
        Dim xEmployees As Decimal

        Dim myConnection = New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        myConnection.Open()
        Dim myCommand = New SqlClient.SqlCommand
        myCommand = New SqlClient.SqlCommand("Select Sum(dblOHAmount) AS TotOH from tblOH", myConnection)
        Dim dr = myCommand.ExecuteReader()
        If dr.hasrows() = True Then
            While dr.read()
                xOH = dr.item("TotOH")
            End While
        End If


        myCommand = New SqlClient.SqlCommand("Select *  from tblCoInfo", myConnection)
        Dim dr1 = myCommand.ExecuteReader()
        If dr1.hasrows() = True Then
            While dr1.read()
                xFriday = dr1.item("dblFridayLabHours")
                xNormal = dr1.item("dblNormalLabHours")
            End While
        End If

        'Each Year consist of 50 weeks - each personnel members spens this time in the factory per year
        xVol = ((xFriday + (4 * xNormal)) * 50) * 60

        'Now get the number of production employees
        myCommand = New SqlClient.SqlCommand("Select Count(id_tblStaff) AS TotEmp from tblStaff", myConnection)
        Dim dr2 = myCommand.ExecuteReader()
        If dr2.hasrows() = True Then
            While dr2.read()
                xEmployees = dr2.item("TotEmp")
            End While
        End If




        myConnection.close()

        Return (xOH / (xVol * xEmployees)) '* xProdIndex

    End Function

    Shared Function GetGrossMargingPerUnit(ByVal XDirectCost As Decimal, ByVal xPercent As Decimal)

        Dim xGrossPerUnit As Decimal
        Dim xPercentageFactor As Double = (1 - ((xPercent) / 100))

        If xPercentageFactor < 1 And xPercentageFactor > 0 Then
            xGrossPerUnit = Math.Round((XDirectCost / xPercentageFactor), 2)
        ElseIf xPercentageFactor = 0 Then
            xGrossPerUnit = Math.Round((XDirectCost * xPercent), 2)
        ElseIf xPercentageFactor > 1 Then
            xGrossPerUnit = Math.Round(XDirectCost / xPercentageFactor, 2)
        End If

        Return xGrossPerUnit
    End Function

    Shared Function FillLabourByProduct(ByVal xProductID As Integer, ByVal xMaterialID As Integer, ByVal xOrderQty As Decimal, ByVal xLabourCost As Decimal, ByRef xLabourHours As Decimal)

        xLabourHours = 0
        xLabourCost = 0

        Dim i As Integer
        Dim xTotUnits As Decimal
        xTotUnits = xOrderQty

        Dim LstLabourLinkTableAdapter1 As dsProdDBTableAdapters.lstLabourLinkTableAdapter
        LstLabourLinkTableAdapter1 = New dsProdDBTableAdapters.lstLabourLinkTableAdapter()
        Dim DsProdDB1 As dsProdDB
        DsProdDB1 = New dsProdDB

        LstLabourLinkTableAdapter1.FillByProductID(DsProdDB1.lstLabourLink, xProductID)
        Dim xLabCount As Integer = DsProdDB1.lstLabourLink.Count

        ''now Populate the rows

        Try
            For i = 0 To xLabCount - 1

                Dim xTimeType As String = DsProdDB1.lstLabourLink.Rows(i).Item("txtValueDesc")

                Select Case xTimeType
                    Case "Hour"
                        xLabourHours = xLabourHours + DsProdDB1.lstLabourLink.Rows(i).Item("dblAdjValue")
                    Case "Minute"
                        xLabourHours = xLabourHours + (DsProdDB1.lstLabourLink.Rows(i).Item("dblAdjValue") / 60)
                    Case "Day"
                        xLabourHours = xLabourHours + DsProdDB1.lstLabourLink.Rows(i).Item("dblAdjValue") * 7
                    Case Else
                        xLabourHours = xLabourHours + DsProdDB1.lstLabourLink.Rows(i).Item("dblAdjValue")
                End Select

                xLabourCost = xLabourCost + DsProdDB1.Tables("lstLabourLink").Rows(i).Item("dblAdjCost")

            Next
        Catch ex As Exception
            MsgBox("No labour values loaded for this product", MsgBoxStyle.OkOnly, "CCP Messages")
        End Try

        Return xLabourCost

    End Function

    Shared Function FillLabourByComponent(ByVal xProductID As Integer, ByVal xMaterialID As Integer, ByVal xOrderQty As Decimal, ByVal xLabourCost As Decimal, ByRef xLabourHours As Decimal)

        xLabourHours = 0
        xLabourCost = 0

        Dim i As Integer
        Dim xTotUnits As Decimal
        xTotUnits = xOrderQty

        Dim LstComponentLinkTableAdapter1 As dsProdDBTableAdapters.lstComponentLabourTableAdapter
        LstComponentLinkTableAdapter1 = New dsProdDBTableAdapters.lstComponentLabourTableAdapter
        Dim DsProdDB1 As dsProdDB
        DsProdDB1 = New dsProdDB

        LstComponentLinkTableAdapter1.FillByMaterialID(DsProdDB1.lstComponentLabour, xMaterialID)
        Dim xLabCount As Integer = DsProdDB1.lstComponentLabour.Count

        ''now Populate the rows

        Try
            For i = 0 To xLabCount - 1

                Dim xTimeType As String = DsProdDB1.lstComponentLabour.Rows(i).Item("txtValueDesc")

                Select Case xTimeType
                    Case "Hour"
                        xLabourHours = xLabourHours + DsProdDB1.lstComponentLabour.Rows(i).Item("dblAdjValue") / (GetComponentBatch(xMaterialID, xProductID) / GetComponentQtyReq(xMaterialID, xProductID))
                    Case "Minute"
                        xLabourHours = xLabourHours + (DsProdDB1.lstComponentLabour.Rows(i).Item("dblAdjValue") / 60) / (GetComponentBatch(xMaterialID, xProductID) / GetComponentQtyReq(xMaterialID, xProductID))
                    Case "Day"
                        xLabourHours = xLabourHours + DsProdDB1.lstComponentLabour.Rows(i).Item("dblAdjValue") * 7 / (GetComponentBatch(xMaterialID, xProductID) / GetComponentQtyReq(xMaterialID, xProductID))
                    Case Else
                        xLabourHours = xLabourHours + DsProdDB1.lstComponentLabour.Rows(i).Item("dblAdjValue") / (GetComponentBatch(xMaterialID, xProductID) / GetComponentQtyReq(xMaterialID, xProductID))
                End Select

                xLabourCost = xLabourCost + (DsProdDB1.Tables("lstComponentLabour").Rows(i).Item("dblAdjCost") / (GetComponentBatch(xMaterialID, xProductID) / GetComponentQtyReq(xMaterialID, xProductID)))

            Next
        Catch ex As Exception
            MsgBox("No labour values loaded for this product", MsgBoxStyle.OkOnly, "CCP Messages")
        End Try

        Return xLabourCost

    End Function

    Shared Function CalculateProdIndex()
        Dim xOH = MiscCode.GetOHRate
        Dim xOHTotalAmount As Decimal

        Dim xTime As Decimal = 0
        Dim xLabourHours As Decimal = 0
        Dim xLabourCost As Decimal = 0

        'Me.LstLabCostperProductTableAdapter1.FillByProductID(Me.DsOHDB1.lstLabCostperProduct, DsOHDB1.lstMarginsperProduct.Rows(i).Item(0))
        Dim strSQL As String = "Select * from lstLabCostperProduct"
        Dim xCon As New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        Dim xAdap As New SqlDataAdapter(strSQL, xCon)
        Dim ds As New DataSet
        xAdap.Fill(ds, "lstLabCostperProduct")

        strSQL = "Select * from lstMarginsperProduct"
        xAdap.SelectCommand.CommandText = strSQL
        xAdap.Fill(ds, "lstMarginsperProduct")
        Dim dv As New DataView(ds.Tables("lstMarginsperProduct"))



        strSQL = "Select Sum(dblOHAmount) as TotOH from tblOH"
        xAdap.SelectCommand.CommandText = strSQL
        xAdap.Fill(ds, "OH")
        Dim xTotOHBudget As Decimal = ds.Tables("OH").Rows(0).Item(0)
        Dim xHaveComponent As Boolean = False

        For Each xRow As DataRow In ds.Tables("lstLabCostperProduct").Rows
            Dim xTimeUnit As String = xRow.Item("txtValueDesc")
            If String.IsNullOrEmpty(xRow(0).ToString()) = False Then
                xHaveComponent = False
                dv.RowFilter = "idtblProduct = " & xRow(0)
                xLabourCost = xLabourCost + MiscCode.FillLabourByProduct(xRow(0), -1, 48, 0, xLabourHours)
            Else
                xHaveComponent = True
                dv.RowFilter = "idtblProduct = " & xRow(1)
                xLabourCost = xLabourCost + MiscCode.FillLabourByComponent(-1, xRow(1), 48, 0, xLabourHours)
            End If

            Select Case xTimeUnit
                Case "Minute"
                    xTime = xTime + xRow.Item("sumOfdblValue")
                Case "Hour"
                    xTime = xTime + (xRow.Item("sumOfdblValue") * 60)
                Case "Second"
                    xTime = xTime + (xRow.Item("sumOfdblValue") / 60)
                Case Else

            End Select
            Try
                If String.IsNullOrEmpty(xRow(0).ToString()) = False Then
                    If dv(0).Item("TotVol").ToString <> "" Then
                        xOHTotalAmount = xOHTotalAmount + ((xOH * xLabourHours) * dv(0).Item("TotVol"))
                    End If
                ElseIf xHaveComponent = True Then
                    xOHTotalAmount = xOHTotalAmount + ((xOH * xLabourHours) * GetComponentQtyReq(xRow(1), -1))
                End If


            Catch ex As Exception
                MsgBox("Product number" & xRow(0) & " with missing details were found during productivity calculation", MsgBoxStyle.Information, My.Settings.SysName)
            End Try
        Next
        'Return xOHTotalAmount
        Dim xOHAdjFactor As Decimal = xTotOHBudget / xOHTotalAmount
        Return xOHAdjFactor

    End Function

    Shared Sub ImportProduct(ByVal xFile As String)
        Dim ExcelCon As New System.Data.OleDb.OleDbConnection
        Dim ExcelAdp As System.Data.OleDb.OleDbDataAdapter
        Dim ExcelComm As System.Data.OleDb.OleDbCommand
        Try
            ExcelCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
                "Data Source= " & xFile & _
                ";Extended Properties=""Excel 12.0;HDR=Yes"""
            ExcelCon.Open()

            Dim StrSql As String = "Select txtProdCde,txtProdDesc,txtCostSortCat,txtCostSortItem,FK_idtblCoInfo,txtProdSpec1,txtProdSpec2,txtProdSpec3 From [tblProduct$]"
            ExcelComm = New System.Data.OleDb.OleDbCommand(StrSql, ExcelCon)
            ExcelAdp = New System.Data.OleDb.OleDbDataAdapter(StrSql, ExcelCon.ConnectionString)
            Dim ds As New DataSet
            ExcelAdp.Fill(ds, "Imp")

            'Now open the products table
            StrSql = "Select * from tblProduct"
            Dim xCon As New SqlConnection(My.Settings.ConnectionString1)
            Dim xAdap As New SqlDataAdapter(StrSql, xCon)
            xAdap.Fill(ds, "Data")


            Dim dv As New DataView(ds.Tables("Data"))

            'Loop throug the excel import and add new records
            Dim strIns As String = "Insert into tblProduct (txtProdCde,txtProdDesc,txtCostSortCat,txtCostSortItem,FK_idtblCoInfo,txtProdSpec1,txtProdSpec2,txtProdSpec3) Values("
            Dim xAddCount As Integer
            Dim xComm As New SqlCommand(strIns, xCon)

            For Each xRow As DataRow In ds.Tables("Imp").Rows
                dv.RowFilter = "txtProdCde = '" & xRow("txtProdCde") & "'"
                If dv.Count = 0 Then
                    xAddCount = xAddCount + 1
                    'ds.Tables("data").Rows.Add(xRow)
                    ds.Tables("data").ImportRow(xRow)
                    strIns = strIns & "'" & xRow(0) & "', '" & xRow(1) & "', '" & xRow(2) & "', '" & xRow(3) & "', '" & xRow(4) & "', '" & xRow(5) & "', '" & xRow(6) & "', '" & xRow(7) & "')"
                    xComm.CommandText = strIns
                    xCon.Open()
                    xComm.ExecuteNonQuery()
                    xCon.Close()
                End If
                strIns = "Insert into tblProduct (txtProdCde,txtProdDesc,txtCostSortCat,txtCostSortItem,FK_idtblCoInfo,txtProdSpec1,txtProdSpec2,txtProdSpec3) Values("
            Next

            MsgBox(xAddCount & " records added", MsgBoxStyle.Information, My.Settings.SysName)
            xCon.Close()
            ds.Dispose()

        Catch ex As Exception
            MsgBox("Error encountered during upload process" & vbCrLf & ex.Message.ToString(), , My.Settings.SysName)
        End Try


        ExcelCon.Close()


    End Sub

    Shared Sub ImportMaterial(ByVal xFile As String)
        Dim ExcelCon As New System.Data.OleDb.OleDbConnection
        Dim ExcelAdp As System.Data.OleDb.OleDbDataAdapter
        Dim ExcelComm As System.Data.OleDb.OleDbCommand
        Try
            ExcelCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
                "Data Source= " & xFile & _
                ";Extended Properties=""Excel 12.0;HDR=Yes"""
            ExcelCon.Open()

            Dim StrSql As String = "Select distinct txtMaterialNo,txtMaterialDesc,txtMaterialUnit,dblMaterialPrice,txtMatspec1,txtMatSpec2,txtMatSpec3,txtType From [tblMaterial$]"
            ExcelComm = New System.Data.OleDb.OleDbCommand(StrSql, ExcelCon)
            ExcelAdp = New System.Data.OleDb.OleDbDataAdapter(StrSql, ExcelCon.ConnectionString)
            Dim ds As New DataSet
            ExcelAdp.Fill(ds, "Imp")

            'Now open the products table
            StrSql = "Select * from tblMaterial"
            Dim xCon As New SqlConnection(My.Settings.ConnectionString1)
            Dim xAdap As New SqlDataAdapter(StrSql, xCon)
            xAdap.Fill(ds, "Data")


            Dim dv As New DataView(ds.Tables("Data"))

            'Loop throug the excel import and add new records
            Dim strIns As String = "Insert into tblMaterial (txtMaterialNo,txtMaterialDesc,txtMaterialUnit,dblMaterialPrice,txtMatspec1,txtMatSpec2,txtMatSpec3,txtType) Values("
            Dim xAddCount As Integer
            Dim xComm As New SqlCommand(strIns, xCon)

            For Each xRow As DataRow In ds.Tables("Imp").Rows
                dv.RowFilter = "txtMaterialNo = '" & xRow("txtMaterialNo") & "'"
                If dv.Count = 0 Then
                    xAddCount = xAddCount + 1
                    'ds.Tables("data").Rows.Add(xRow)
                    'ds.Tables("data").ImportRow(xRow)
                    strIns = strIns & "'" & xRow(0) & "', '" & xRow(1) & "', '" & xRow(2) & "', '" & xRow(3) & "', '" & xRow(4) & "', '" & xRow(5) & "', '" & xRow(6) & "', '" & xRow(7) & "')"
                    xComm.CommandText = strIns
                    xCon.Open()
                    xComm.ExecuteNonQuery()
                    xCon.Close()
                    strIns = "Insert into tblMaterial (txtMaterialNo,txtMaterialDesc,txtMaterialUnit,dblMaterialPrice,txtMatspec1,txtMatSpec2,txtMatSpec3,txtType) Values("
                End If

            Next

            MsgBox(xAddCount & " records added", MsgBoxStyle.Information, My.Settings.SysName)
            xCon.Close()
            ds.Dispose()

        Catch ex As Exception
            MsgBox("Error encountered during upload process" & vbCrLf & ex.Message.ToString(), , My.Settings.SysName)
        End Try


        ExcelCon.Close()


    End Sub

    Shared Sub ImportStaff(ByVal xFile As String)
        Dim ExcelCon As New System.Data.OleDb.OleDbConnection
        Dim ExcelAdp As System.Data.OleDb.OleDbDataAdapter
        Dim ExcelComm As System.Data.OleDb.OleDbCommand
        Try
            ExcelCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
                "Data Source= " & xFile & _
                ";Extended Properties=""Excel 12.0;HDR=Yes"""
            ExcelCon.Open()

            Dim StrSql As String = "Select txtEmpNo,txtEmpName,	txtEmpCategory,txtDepartment,txtJobTitle,dblRate,dblCoBenefit,txtRateDescriptor,dblRatePerHour,ConstraintYes From [tblStaff$]"
            ExcelComm = New System.Data.OleDb.OleDbCommand(StrSql, ExcelCon)
            ExcelAdp = New System.Data.OleDb.OleDbDataAdapter(StrSql, ExcelCon.ConnectionString)
            Dim ds As New DataSet
            ExcelAdp.Fill(ds, "Imp")

            'Now open the products table
            StrSql = "Select * from tblStaff"
            Dim xCon As New SqlConnection(My.Settings.ConnectionString1)
            Dim xAdap As New SqlDataAdapter(StrSql, xCon)
            xAdap.Fill(ds, "Data")


            Dim dv As New DataView(ds.Tables("Data"))

            'Loop throug the excel import and add new records
            Dim strIns As String = "Insert into tblStaff (txtEmpNo,txtEmpName,txtEmpCategory,txtDepartment,txtJobTitle,dblRate,dblCoBenefit,txtRateDescriptor,dblRatePerHour, ConstraintYes) Values("
            Dim xAddCount As Integer
            Dim xComm As New SqlCommand(strIns, xCon)

            For Each xRow As DataRow In ds.Tables("Imp").Rows
                dv.RowFilter = "txtEmpNo = '" & xRow("txtEmpNo") & "'"
                If dv.Count = 0 Then
                    xAddCount = xAddCount + 1
                    'ds.Tables("data").Rows.Add(xRow)
                    'ds.Tables("data").ImportRow(xRow)
                    strIns = strIns & "'" & xRow(0) & "', '" & xRow(1) & "', '" & xRow(2) & "', '" & xRow(3) & "', '" & xRow(4) & "', '" & xRow(5) & "', '" & xRow(6) & "', '" & xRow(7) & "', '" & xRow(8) & "', " & xRow(9) & ")"
                    xComm.CommandText = strIns
                    xCon.Open()
                    xComm.ExecuteNonQuery()
                    xCon.Close()
                    strIns = "Insert into tblStaff (txtEmpNo,txtEmpName,txtEmpCategory,txtDepartment,txtJobTitle,dblRate,dblCoBenefit,txtRateDescriptor,dblRatePerHour, ConstraintYes) Values("
                End If

            Next

            MsgBox(xAddCount & " records added", MsgBoxStyle.Information, My.Settings.SysName)
            xCon.Close()
            ds.Dispose()

        Catch ex As Exception
            MsgBox("Error encountered during upload process" & vbCrLf & ex.Message.ToString(), , My.Settings.SysName)
        End Try


        ExcelCon.Close()


    End Sub

    Shared Function GetLabourHours(ByVal xTimeDescription As String, ByVal xTime As Decimal)

        Dim xLabourHours As Decimal

        Select Case xTimeDescription
            Case "Minute"
                xLabourHours = xTime / 60
            Case "Hour"
                xLabourHours = xTime
            Case "Second"
                xLabourHours = (xTime / 60) / 60
            Case "Day"
                Dim xNormal As Decimal
                Dim xFriday As Decimal
                GetStandardCoWorkHours(xNormal, xFriday)
                xLabourHours = xTime * (((xNormal * 4) + xFriday) / 5)
            Case "Week"
                Dim xNormal As Decimal
                Dim xFriday As Decimal
                GetStandardCoWorkHours(xNormal, xFriday)
                xLabourHours = xTime * ((xNormal * 4) + xFriday)
            Case "Month"
                Dim xNormal As Decimal
                Dim xFriday As Decimal
                GetStandardCoWorkHours(xNormal, xFriday)
                xLabourHours = xTime * ((xNormal * 4) + xFriday) * 4
            Case Else
                MsgBox("Unknown Time Descriptor = " & xTimeDescription)
                xLabourHours = xTime
        End Select

        Return xLabourHours

    End Function

    Shared Sub GetStandardCoWorkHours(ByRef xNormal As Decimal, ByRef xFriday As Decimal)

        Dim myConnection As New SqlConnection(My.Settings.ConnectionString1)
        Dim myCommand As New SqlClient.SqlCommand("Select *  from tblCoInfo", myConnection)
        Dim dr1 = myCommand.ExecuteReader()
        If dr1.hasrows() = True Then
            While dr1.read()
                xFriday = dr1.item("dblFridayLabHours")
                xNormal = dr1.item("dblNormalLabHours")
            End While
        End If

    End Sub

    Shared Sub DeleteTmpProduct(ByVal xID As Integer)

        Dim strSQL As String = "Delete from tblMatLink where FK_tblProduct = " & xID
        Dim xCon As New SqlConnection(My.Settings.ConnectionString1)
        Dim xCom As New SqlCommand(strSQL, xCon)
        xCon.Open()
        xCom.ExecuteNonQuery()
        strSQL = "Delete from tblProdLink where FK_tblProduct = " & xID
        xCom.CommandText = strSQL
        xCom.ExecuteNonQuery()
        strSQL = "Delete from tblProduct where idtblProduct = " & xID
        xCom.CommandText = strSQL
        xCom.ExecuteNonQuery()
        xCon.Close()

    End Sub

    Shared Function CalcCompCost(ByVal xCompID As Integer)
        Dim strSQL As String = "Select * from tblComponent where fk_ComponentLinkID = " & xCompID
        Dim xCon As New SqlClient.SqlConnection(My.Settings.ConnectionString1)
        Dim xAdap As New SqlDataAdapter(strSQL, xCon)
        Dim ds As New DataSet
        xAdap.Fill(ds, "CompCost")

        Dim xCompCost As Decimal
        For Each xRow As DataRow In ds.Tables("CompCost").Rows
            xCompCost = xCompCost + Decimal.Parse(xRow.Item("dblCompCost") / xRow.Item("dblBatchSize"))
        Next
        Return xCompCost

    End Function


    Shared Function GetComponentBatch(ByVal xComponentID As Integer, ByVal xProductID As Integer)
        Dim xQty As Decimal
        Try
            Dim LstComponentLinkTableAdapter1 As dsProdDBTableAdapters.lstComponentLinkTableAdapter
            LstComponentLinkTableAdapter1 = New dsProdDBTableAdapters.lstComponentLinkTableAdapter
            Dim DsProdDB1 As dsProdDB
            DsProdDB1 = New dsProdDB

            xQty = LstComponentLinkTableAdapter1.GetBatchSize(xComponentID)
        Catch ex As Exception
            xQty = 1
            MsgBox("Could not determine the component volume/quantity", My.Settings.SysName)
        End Try
        Return xQty

    End Function

    Shared Function GetComponentQtyReq(ByVal xComponentID As Integer, ByVal xProductID As Integer)
        Dim xQty As Decimal
        Try
            Dim LstMatLinkTableAdapter1 As dsProdDBTableAdapters.tblMatLinkTableAdapter
            LstMatLinkTableAdapter1 = New dsProdDBTableAdapters.tblMatLinkTableAdapter
            Dim DsProdDB1 As dsProdDB
            DsProdDB1 = New dsProdDB
            If xProductID > -1 Then
                xQty = LstMatLinkTableAdapter1.GetComponentQty(xProductID, xComponentID)
            Else
                xQty = LstMatLinkTableAdapter1.GetComponentQty1(xComponentID)
            End If


        Catch ex As Exception
            xQty = 1
            MsgBox("Could not determine the component volume/quantity", My.Settings.SysName)
        End Try
        Return xQty

    End Function
End Class
