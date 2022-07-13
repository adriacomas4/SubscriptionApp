Imports System.Data.SqlClient

Public Class DBConnection

    Private _connection As SqlConnection
    Sub New()
        _connection = New SqlConnection("data source=localhost;initial catalog=testCodely;persist security info=True; Integrated Security=SSPI;")
    End Sub

    Public Function DoSelectQuery(query As String) As DataTable
        Dim result As New DataTable
        _connection.Open()
        Using adapter As SqlDataAdapter = New SqlDataAdapter(query, _connection)
            adapter.Fill(result)
        End Using
        _connection.Close()
        Return result
    End Function

    Public Function DoInsertUpdateQuery(query As String) As Integer
        Dim result As Integer
        _connection.Open()
        Using cmd As SqlCommand = New SqlCommand(query, _connection)
            result = cmd.ExecuteNonQuery
        End Using
        _connection.Close()
        Return result
    End Function
End Class
