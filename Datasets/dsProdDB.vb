

Partial Public Class dsProdDB



    Partial Class tblActivityDataTable

        Private Sub tblActivityDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.txtActNoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class tblCustomerDataTable

        Private Sub tblCustomerDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.txtProdCodesColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class lstStaffGroupsDataTable

        Private Sub lstStaffGroupsDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.txtEmpCategoryColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class lstLabourLinkDataTable

    End Class


End Class

Namespace dsProdDBTableAdapters

    Partial Class lstMaterialLinkTableAdapter

    End Class

    Partial Public Class tblCustomerTableAdapter
    End Class
End Namespace
