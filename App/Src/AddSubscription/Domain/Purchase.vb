Public Class Purchase

    Private _quantity As VOPurchaseQuantity
    Private _price As VOPruchasePrice
    Private _empresa As VOPurchaseBusiness
    Private _datetrans As VOPurchaseDate

#Region "Propiedades"
    Public ReadOnly Property Quantity As VOPurchaseQuantity
        Get
            Return _quantity
        End Get
    End Property

    Public ReadOnly Property Price As VOPruchasePrice
        Get
            Return _price
        End Get
    End Property

    Public ReadOnly Property Empresa As VOPurchaseBusiness
        Get
            Return _empresa
        End Get
    End Property

    Public ReadOnly Property Datetrans As VOPurchaseDate
        Get
            Return _datetrans
        End Get
    End Property
#End Region

    Sub New(quantity As VOPurchaseQuantity, empresa As VOPurchaseBusiness)
        _quantity = quantity
        _empresa = empresa
        _datetrans = New VOPurchaseDate(Date.Now.ToString("yyyy/MM/dd"))
        _price = New VOPruchasePrice(0)
        setPrice()
    End Sub


    Private Sub setPrice()
        Try
            With _quantity
                If .Value <= 2 Then
                    _price.Value = .Value * 299
                ElseIf _quantity.Value <= 10 Then
                    _price.Value = .Value * 239
                ElseIf .Value <= 25 Then
                    _price.Value = .Value * 219
                ElseIf .Value <= 50 Then
                    _price.Value = .Value * 199
                ElseIf .Value > 50 Then
                    _price.Value = .Value * 149
                Else
                    Throw New QuantityIsZeroException("Quantitat de subscripcions menor de zero")
                End If
            End With
        Catch ex As QuantityIsZeroException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
