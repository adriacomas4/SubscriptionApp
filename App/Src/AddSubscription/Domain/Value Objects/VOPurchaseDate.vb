Public Class VOPurchaseDate
    Private _datetrans As String

    Public ReadOnly Property Value As String
        Get
            Return _datetrans
        End Get
    End Property

    Sub New(datetrans As String)
        _datetrans = datetrans
    End Sub
End Class
