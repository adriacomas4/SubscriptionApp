Imports System.Data.SqlClient

Public Class SelectQueryDB

    Private _conn As SqlConnection
    Sub New(conn As SqlConnection)
        _conn = conn
    End Sub

    Public Function executeSelectQuery(query As String) As DataTable
        Dim result As New DataTable
        _conn.Open()
        Using adapter As SqlDataAdapter = New SqlDataAdapter(query, _conn)
            adapter.Fill(result)
        End Using
        _conn.Close()
        Return result
    End Function
End Class
