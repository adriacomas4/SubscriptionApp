Public Class Transaction

    Private _quantity As TransQuantity
    Private _price As TransPrice
    Private _empresa As TransBusiness
    Private _datetrans As TransDate

#Region "Propiedades"
    Public ReadOnly Property Quantity As TransQuantity
        Get
            Return _quantity
        End Get
    End Property

    Public ReadOnly Property Price As TransPrice
        Get
            Return _price
        End Get
    End Property

    Public ReadOnly Property Empresa As TransBusiness
        Get
            Return _empresa
        End Get
    End Property

    Public ReadOnly Property Datetrans As TransDate
        Get
            Return _datetrans
        End Get
    End Property
#End Region

    Sub New(quantity As TransQuantity, empresa As TransBusiness)
        _quantity = quantity
        _empresa = empresa
        setPrice()
        _datetrans = New TransDate(Date.Now)
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
