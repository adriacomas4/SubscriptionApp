Public Class TransPrice

    Private _price As Integer

    Public Property Value As Integer
        Get
            Return _price
        End Get
        Set(value As Integer)
            _price = value
        End Set
    End Property

    Sub New(price As Integer)
        _price = price
    End Sub
End Class
