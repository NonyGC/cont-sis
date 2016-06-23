Public Class TipoCambio
    Private _fecha As String
    Private _compra As Decimal
    Private _venta As Decimal
    Public Property fecha As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property
    Public Property compra As Decimal
        Get
            Return _compra
        End Get
        Set(ByVal value As Decimal)
            _compra = value
        End Set
    End Property
    Public Property venta As Decimal
        Get
            Return _venta
        End Get
        Set(ByVal value As Decimal)
            _venta = value
        End Set
    End Property
End Class
