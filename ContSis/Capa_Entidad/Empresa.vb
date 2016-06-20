Public Class Empresa
    Private _RUC As String = ""
    Private _Nombre As String = ""
    Private _Alias As String = ""
    Private _imagen As Byte()
    Private _codigo As String
    Private _digito As Integer
#Region "Contructores"
    Public Sub New(ruc As String, rznScl As String, rznSclShort As String)
        _RUC = ruc
        _Nombre = rznScl
        _Alias = rznSclShort
    End Sub
    Public Sub New()

    End Sub

#End Region
#Region "Metodos Get - Set"
    Public Property RUC As String
        Get
            Return _RUC
        End Get
        Set(ByVal value As String)
            _RUC = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Aliass As String
        Get
            Return _Alias
        End Get
        Set(ByVal value As String)
            _Alias = value
        End Set
    End Property
    Public Property imagen As Byte()
        Get
            Return _imagen
        End Get
        Set(ByVal value As Byte())
            _imagen = value
        End Set
    End Property
    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property
    Public Property Digito As String
        Get
            Return _digito
        End Get
        Set(value As String)
            _digito = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Function Impresion() As String
        Return _Nombre & vbLf & _RUC
    End Function
    Public Function Array() As String()
        Return New String() {_RUC, _Nombre, _Alias}
    End Function

#End Region

End Class
