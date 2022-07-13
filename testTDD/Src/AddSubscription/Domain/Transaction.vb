Public Class Transaction

    Public Property _quantity As Integer
    Public Property _price As Integer
    Public Property _empresa As Integer

    Sub New(quantity As Integer, price As Integer, empresa As Integer)
        _quantity = quantity
        _price = price
        _empresa = empresa
    End Sub
End Class
