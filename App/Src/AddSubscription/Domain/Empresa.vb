Public Class Empresa

    Private _id As EmpresaId
    Private _name As EmpresaName
    Private _quantity As EmpresaQuantity

#Region "Properties"
    Public ReadOnly Property Id As EmpresaId
        Get
            Return _Id
        End Get
    End Property

    Public ReadOnly Property Name As EmpresaName
        Get
            Return _name
        End Get
    End Property
    Public ReadOnly Property Quantity As EmpresaQuantity
        Get
            Return _quantity
        End Get
    End Property

#End Region

    Sub New(id As EmpresaId, name As EmpresaName, quantity As EmpresaQuantity)
        _Id = id
        _name = name
        _quantity = quantity
    End Sub

End Class
