Public MustInherit Class Usuario
    Implements ITipoUsuario
#Region "Variables"
    'Declaración de Variables
    Protected _id As Integer
    Protected _usuario As String
    Protected _password As String
    Protected _sesion As Integer
    Protected _state As Integer
    Protected _fSesion As Date
    Protected _fCierre As Date
#End Region
#Region "Constructores"
    'Contructor
    Public Sub New(usuario As String, password As String)
        Me._usuario = usuario
        Me._password = password
    End Sub
    Public Sub New()

    End Sub
#End Region
#Region "Metodos Get - Set"
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property
    Public Property Password As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property
    Public Property State As Integer
        Get
            Return _state
        End Get
        Set(value As Integer)
            _state = value
        End Set
    End Property
    Public Property Sesion As Integer
        Get
            Return _sesion
        End Get
        Set(value As Integer)
            _sesion = value
        End Set
    End Property

    Public MustOverride ReadOnly Property Tipo As String


#End Region
    Public MustOverride Function Impresion() As String

    Public Function ArrayUsuario() As String()
        Dim array() As String = {_usuario, _password}
        Return array
    End Function
    Public Function ArrayUsuario(tipo As Integer) As String()
        Dim array(4) As String
        If tipo = 5 Then
            array(0) = _id : array(1) = _usuario : array(2) = _password : array(4) = _sesion
        Else
            Throw New Exception("Sin datos")
        End If
        Return array
    End Function

End Class

Public Interface ITipoUsuario


End Interface
Public Class UsuarioNormal
    Inherits Usuario
    Public Sub New(usuario As String, password As String)
        MyBase.New(usuario, password)
    End Sub
    Public Sub New()

    End Sub

    Public Overrides ReadOnly Property Tipo As String
        Get
            Return "normal"
        End Get
    End Property

    Public Overrides Function Impresion() As String
        Return Me._usuario & vbLf & Tipo
    End Function
End Class

Public Class UsuarioAdmin
    Inherits Usuario
    Public Sub New(usuario As String, password As String)
        MyBase.New(usuario, password)
    End Sub
    Public Sub New()

    End Sub
    Public Overrides ReadOnly Property Tipo As String
        Get
            Return "admin"
        End Get
    End Property
    Public Overrides Function Impresion() As String
        Return Usuario & vbLf & Tipo
    End Function
End Class

Public Class UsuarioMaster
    Inherits Usuario
    Public Sub New(usuario As String, password As String)
        MyBase.New(usuario, password)
    End Sub
    Public Sub New()

    End Sub
    Public Overrides ReadOnly Property Tipo As String
        Get
            Return "master"
        End Get
    End Property
    Public Overrides Function Impresion() As String
        Return Usuario & vbLf & Tipo
    End Function
End Class

