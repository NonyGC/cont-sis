Public Class Usuario
#Region "Variables"
    'Declaración de Variables
    Private _Codigo As Integer
    Private _Usuario As String
    Private _Password As String
    Private _Rol As Integer
    Private _Sesion As Integer
#End Region
#Region "Constructores"
    'Contructor
    Public Sub New(usuario As String, password As String)
        Me._Usuario = usuario
        Me._Password = password
    End Sub
    Public Sub New()

    End Sub
    Public Sub New(codigo As Integer, usuario As String, password As String, rol As Integer, sesion As Integer)
        Me._Codigo = codigo
        Me._Usuario = usuario
        Me._Password = password
        Me._Rol = rol
        Me._Sesion = sesion
    End Sub
#End Region
    'Metodos Get - Set
    Public Property Codigo As Integer
        Get
            Return _Codigo
        End Get
        Set(ByVal value As Integer)
            _Codigo = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property
    Public Property Password As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property
    Public Property Rol As Integer
        Get
            Return _Rol
        End Get
        Set(ByVal value As Integer)
            _Rol = value
        End Set
    End Property
    Public Function ResponseVeri() As String()
        Dim resDatos(1) As String

        If _Usuario.Trim().Length = 0 Then
            resDatos(0) = "fail"
        Else
            resDatos(0) = "ok"
        End If

        If _Password.Trim().Length = 0 Then
            resDatos(1) = "fail"
        Else
            resDatos(1) = "ok"
        End If
        Return resDatos
    End Function

    Public Sub Clear()
        _Codigo = 0
        _Usuario = ""
        _Password = ""
        _Rol = 0
    End Sub
    Public Function ArrayUsuario() As String()
        Dim array() As String = {_Usuario, _Password}
        Return array
    End Function
    Public Function ArrayUsuario(tipo As Integer) As String()
        Dim array(4) As String
        If tipo = 5 Then
            array(0) = _Codigo : array(1) = _Usuario : array(2) = _Password : array(3) = _Rol : array(4) = _Sesion
        Else
            Throw New Exception("Sin datos")
        End If
        Return Array
    End Function
    Public Function IsMaster() As Boolean
        If (_Usuario = "master") And (_Password = "vertigo") Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
