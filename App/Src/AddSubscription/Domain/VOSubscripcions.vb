Imports Abp.Domain.Values

Public Class VOSubscripcions
    Inherits ValueObject

    Private _quantity As Integer
    Private _price As Integer

    ReadOnly Property Price() As String
        Get
            Return _price
        End Get
    End Property

    ReadOnly Property Quantity() As String
        Get
            Return _quantity
        End Get
    End Property

    Sub New(quantity As Integer)
        _quantity = quantity
        _price = 0
        setPrice()
    End Sub

    Protected Overrides Iterator Function GetAtomicValues() As IEnumerable(Of Object)
        Yield _quantity
        Yield _price
    End Function

    Private Function setPrice() As Object
        Try
            If _quantity <= 2 Then
                _price = _quantity * 299
            ElseIf _quantity <= 10 Then
                _price = _quantity * 239
            ElseIf _quantity <= 25 Then
                _price = _quantity * 219
            ElseIf _quantity <= 50 Then
                _price = _quantity * 199
            ElseIf _quantity > 50 Then
                _price = _quantity * 149
            Else
                Throw New QuantityIsZeroException("Quantitat de subscripcions menor de zero")
            End If
        Catch ex As QuantityIsZeroException
            MessageBox.Show(ex.Message)
        End Try
    End Function

End Class
