Public Class Cuenta
    Private _Codigo As String
    Private _nombre As String
    Private _alias As String
    Private _debe As Decimal
    Private _haber As Decimal
    Private _C_haber As String
    Private _C_debe As String
    Public Property c_debe As String
        Get
            Return _C_debe
        End Get
        Set(ByVal value As String)
            _C_debe = value
        End Set
    End Property
    Public Property c_haber As String
        Get
            Return _C_haber
        End Get
        Set(ByVal value As String)
            _C_haber = value
        End Set
    End Property
    Public Property codigo As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Public Property aliass As String
        Get
            Return _alias
        End Get
        Set(ByVal value As String)
            _alias = value
        End Set
    End Property
    Public Property debe As Decimal
        Get
            Return _debe
        End Get
        Set(ByVal value As Decimal)
            _debe = value
        End Set
    End Property

    Public Property haber As Decimal
        Get
            Return _haber
        End Get
        Set(ByVal value As Decimal)
            _haber = value
        End Set
    End Property

End Class
