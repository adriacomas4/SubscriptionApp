Public Class Empresa

    Private _id As Integer
    Private _name As String
    Private _quantity As Integer

    ReadOnly Property Name() As String
        Get
            Return _name
        End Get
    End Property

    ReadOnly Property Id() As String
        Get
            Return _id
        End Get
    End Property

    Public Property Quantity() As Integer
        Get
            Return _quantity
        End Get
        Set(ByVal value As Integer)
            _quantity = value
        End Set
    End Property


    Sub New(id As Integer, name As String, quantity As Integer)
        _id = id
        _name = name
        _quantity = quantity
    End Sub

End Class
