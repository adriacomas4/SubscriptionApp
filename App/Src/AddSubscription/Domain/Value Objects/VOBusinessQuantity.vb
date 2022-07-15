Public Class VOBusinessQuantity

    Private _quantity As Object

    Public Property Value
        Get
            Return _quantity
        End Get
        Set
            _quantity = Value
        End Set
    End Property

    Sub New(quantity As String)
        _quantity = quantity
    End Sub
End Class
