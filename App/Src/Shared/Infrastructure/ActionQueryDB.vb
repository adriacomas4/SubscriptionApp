Imports System.Data.SqlClient

Public Class ActionQueryDB

    Private _conn As SqlConnection
    Sub New(conn As SqlConnection)
        _conn = conn
    End Sub

    Public Function executeActionQuery(query As String) As Integer
        Dim result As Integer
        _conn.Open()
        Using cmd As SqlCommand = New SqlCommand(query, _conn)
            result = cmd.ExecuteNonQuery
        End Using
        _conn.Close()
        Return result
    End Function
End Class
