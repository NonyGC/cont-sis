Imports Modelos
Imports Capa_Entidad
Public Class LoginBL
    Inherits BaseBL
#Region "Variables"
    Private _respuesta As String
    Private _usuario As String
    Private _password As String


#End Region
#Region "Propiedades"
    Public ReadOnly Property Respuesta As String
        Get
            Return _respuesta
        End Get
    End Property
#End Region
#Region "Contructor"
    'Contructor
    Public Sub New()
    End Sub
#End Region
#Region "Metodos"
    Public Function ResponseLogeo(usuario As String, password As String) As Usuario
        _usuario = usuario
        _password = password
        Select Case usuario
            Case "admin"
                Return ResponseAdmin()
            Case "master"
                Return ResponseMaster()
            Case Else
                Return ResponseUsuario()
        End Select

    End Function

#Region "Response"
#Region "Master"
    Private Function ResponseMaster() As UsuarioMaster
        Dim usuDao As New UsuarioDao
        Dim usuario As New UsuarioMaster
        usuario.Usuario = _usuario
        usuario.Password = _password

        usuario = usuDao.ResponseUsuarioMaster(usuario)

        If usuDao.Respuesta.Equals("ok") Then
            _respuesta = "ok"
        Else
            _respuesta = "El usuario o password son incorrectos"
            usuario = Nothing
        End If
        Return usuario
    End Function
#End Region
    Private Function ResponseAdmin() As UsuarioAdmin
        Dim sisDao As New SistemaDao
        If sisDao.ActivoAdmin Then
            Dim usuDao As New UsuarioDao
            Dim usuario As New UsuarioAdmin
            usuario.Usuario = _usuario
            usuario.Password = _password

            usuario = usuDao.ResponseUsuarioAdmin(usuario)
            Select Case usuDao.Respuesta
                Case "fail"
                    _respuesta = "El usuario o password son incorrectos."
                    usuario = Nothing
                Case "no_activo"
                    _respuesta = "El usuario no cuenta con permiso."
                    usuario = Nothing
                Case "in_sesion"
                    _respuesta = "El usuario se encuentra en Sesion."
                    usuario = Nothing
                Case "ok"
                    _respuesta = "ok"
            End Select

            Return usuario
        Else
            _respuesta = "El usuario no cuenta con permiso."
            Return Nothing
        End If

    End Function
    Private Function ResponseUsuario() As UsuarioNormal
        Dim resp As String = ""
        Dim usuDao As New UsuarioDao
        Dim usuario As New UsuarioNormal

        usuario.Usuario = _usuario
        usuario.Password = _password

        usuario = usuDao.ResponseUsuario(usuario)

        Select Case usuDao.Respuesta
            Case "fail"
                _respuesta = "El usuario o password son incorrectos."
                usuario = Nothing
            Case "no_activo"
                _respuesta = "El usuario no cuenta con permiso."
                usuario = Nothing
            Case "in_sesion"
                _respuesta = "El usuario se encuentra en Sesion."
                usuario = Nothing
            Case "ok"
                _respuesta = "ok"
        End Select
        Return usuario
    End Function

#End Region

#End Region
End Class