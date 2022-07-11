Imports System.Data.SqlClient

Public Class DBConnection

    Private _connection As SqlConnection
    Sub New(connectionString As String)
        _connection = New SqlConnection(connectionString)
    End Sub

    Public Function doQuery(query As String) As DataTable
        Dim result As New DataTable
        _connection.Open()
        Using adapter As SqlDataAdapter = New SqlDataAdapter(query, _connection)
            adapter.Fill(result)
        End Using

        Return result
    End Function
End Class
