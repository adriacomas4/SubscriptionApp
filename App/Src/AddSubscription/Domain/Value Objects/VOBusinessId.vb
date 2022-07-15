Imports Abp.Domain.Values

Public Class VOBusinessId
    Inherits ValueObject
    Private _id As Integer

    Public ReadOnly Property Value
        Get
            Return _id
        End Get
    End Property

    Sub New(id As String)
        _id = id
    End Sub

    Protected Overrides Function GetAtomicValues() As IEnumerable(Of Object)
        Throw New NotImplementedException()
    End Function
End Class
