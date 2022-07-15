Public Class TransDate
    Private _datetrans As Date

    Public ReadOnly Property Value As Date
        Get
            Return _datetrans
        End Get
    End Property

    Sub New(datetrans As Date)
        _datetrans = datetrans
    End Sub
End Class
