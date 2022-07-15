Public Class VOPruchasePrice

    Private _price As Integer

    Public Property Value As Integer
        Get
            Return _price
        End Get
        Set(valorprecio As Integer)
            _price = valorprecio
        End Set
    End Property

    Sub New(price As Integer)
        _price = price
    End Sub
End Class
