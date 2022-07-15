Public Class VOBusinessName
    Private _name As Object

    Private ReadOnly Property Value
        Get
            Return _name
        End Get
    End Property

    Sub New(name As String)
        _name = name
    End Sub

End Class
