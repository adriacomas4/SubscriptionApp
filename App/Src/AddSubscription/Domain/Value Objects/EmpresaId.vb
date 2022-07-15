Public Class EmpresaId

    Private _id As Integer

    Public ReadOnly Property Value
        Get
            Return _id
        End Get
    End Property

    Sub New(id As String)
        _id = id
    End Sub

End Class
