Public Class UsuarioMain
    Private _usuario As Usuario
    Private _rol As Rol

    Public Sub New(usuario As Usuario, rol As Rol)
        _usuario = usuario
        _rol = rol
    End Sub
    Public Sub New()

    End Sub
    Public Property Usuario As Usuario
        Get
            Return _usuario
        End Get
        Set(value As Usuario)
            _usuario = value
        End Set
    End Property
    Public Property Rol As Rol
        Get
            Return _rol
        End Get
        Set(value As Rol)
            _rol = value
        End Set
    End Property
    Public Function Impresion() As String
        Return _usuario.Usuario & vbLf & _rol.Descripcion

    End Function

End Class
