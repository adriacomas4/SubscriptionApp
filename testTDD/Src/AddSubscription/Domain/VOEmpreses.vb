Imports Abp.Domain.Values

Public Class VOEmpreses
    Inherits ValueObject

    Private _name As String

    ReadOnly Property Name() As String
        Get
            Return _name
        End Get
    End Property

    Public Sub New(empresa As String)
        Me._name = empresa
    End Sub

    Protected Overrides Iterator Function GetAtomicValues() As IEnumerable(Of Object)
        Yield _name
    End Function
End Class
