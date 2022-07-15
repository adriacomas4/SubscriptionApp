Public Class Business

    Private _id As VOBusinessId
    Private _name As VOBusinessName
    Private _quantity As VOBusinessQuantity

#Region "Properties"
    Public ReadOnly Property Id As VOBusinessId
        Get
            Return _id
        End Get
    End Property

    Public ReadOnly Property Name As VOBusinessName
        Get
            Return _name
        End Get
    End Property
    Public ReadOnly Property Quantity As VOBusinessQuantity
        Get
            Return _quantity
        End Get
    End Property

#End Region

    Sub New(id As VOBusinessId, name As VOBusinessName, quantity As VOBusinessQuantity)
        _id = id
        _name = name
        _quantity = quantity
    End Sub

End Class
