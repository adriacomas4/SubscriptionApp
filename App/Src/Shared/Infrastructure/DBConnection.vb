Imports System.Data.SqlClient

Public Class DBConnection

    Private _connection As SqlConnection

    Public ReadOnly Property Connection As SqlConnection
        Get
            Return _connection
        End Get
    End Property

    Sub New()
        'Database in localhost with name "testCodely" and windows authentication.
        _connection = New SqlConnection("data source=localhost;initial catalog=testCodely;persist security info=True; Integrated Security=SSPI;")
    End Sub

End Class
