Public Class Empresa
    Private _RUC As String = ""
    Private _Nombre As String = ""
    Private _Alias As String = ""
    Private _imagen As Byte()
    Private _imagen_string As String
    Private _codigo As String
    Private _digito As Integer
    Private _ubigeo As String
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
    Public Property imagen_string As String
        Get
            Return _imagen_string
        End Get
        Set(ByVal value As String)
            _imagen_string = value
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
    Public Property ubigeo As String
        Get
            Return _ubigeo
        End Get
        Set(value As String)
            _ubigeo = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Function Impresion() As String
        If IsNothing(_Alias) Or _Alias.Length = 0 Then
            Return _Nombre & vbLf & _RUC
        Else
            Return _Alias & vbLf & _RUC
        End If

    End Function
    Public Function Array() As String()
        Return New String() {_RUC, _Nombre, _Alias}
    End Function

#End Region

End Class
