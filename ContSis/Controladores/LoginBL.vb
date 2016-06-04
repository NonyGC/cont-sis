Imports Modelos
Imports Capa_Entidad
Public Class LoginBL
    Inherits BaseBL
#Region "Variables"
    'Variables
    Private Datos As New LoginDao
    Private usuarioLogin As Usuario
    Private rolDao As New RolDao
    Private tmpSesionLogin As Integer
    Private tmpUsuIdLogin As Integer
    Private tmpRolIdLogin As Integer
    Private rolLogin As New Rol
    Private _control As Boolean = False

    Enum StatusSesion
        Fail = 0
        InSession = 1
        Ok = 2
    End Enum

#End Region
#Region "Contructor"
    'Contructor
    Public Sub New()

    End Sub
    Public Sub New(usuario As Usuario)
        Me.usuarioLogin = usuario
        _control = Me.usuarioLogin.IsMaster()
    End Sub
#End Region
#Region "Propiedades"
    Public ReadOnly Property Control As Boolean
        Get
            Return _control
        End Get
    End Property

#End Region
#Region "Metodos"
    'Metodos
#Region "New"
    Public Function ResponseLogeo() As String
        Dim rpt As String = ""
        If _control Then
            rpt = "Ok"
            rolLogin.Id = 0
            rolLogin.Descripcion = "master"
            rolLogin.Tipo = "master"
        Else
            Dim resp As String() = Datos.ResponseLogeo(usuarioLogin.ArrayUsuario)

            If resp.Count = 1 Then
                rpt = resp(0)
            Else
                tmpUsuIdLogin = resp(0)
                tmpSesionLogin = resp(1)
                tmpRolIdLogin = resp(2)
                rolLogin.Id = resp(2)
                rolLogin.Descripcion = resp(3)
                rolLogin.Tipo = resp(4)
                rpt = "Ok"
            End If
        End If

        Return rpt
    End Function
    Public Function GetUsuario() As Usuario
        If _control Then
            Return New Usuario(0, "master", "*******", "0", "1")
        Else
            Dim arrayUsuario As String()
            arrayUsuario = usuarioLogin.ArrayUsuario
            Return New Usuario(tmpUsuIdLogin, arrayUsuario(0), arrayUsuario(1), tmpSesionLogin, tmpRolIdLogin)
        End If

    End Function
    Public Function GetRol() As Rol
        Return rolLogin
    End Function

#End Region

#End Region
End Class