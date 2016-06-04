Imports Modelos
Imports Capa_Entidad
Public Class UsuarioBL
    Dim Datos As New UsuarioDao
    Dim rolDao As New RolDao
    Public Function Usuario_RegisterLB(ByVal entusu As Usuario)
        Dim verificar As Integer
        verificar = Datos.Usuarios_Register(entusu)
        Return verificar
    End Function
    Public Function Usuario_ActualizarLB(ByVal entusu As Usuario)
        Dim verificar As Integer
        verificar = Datos.Usuarios_Actualizar(entusu)
        Return verificar
    End Function
    Public Function Roles_datos() As DataTable
        Return rolDao.Rol_all()
    End Function
    Public Function getModulos() As DataTable
        Dim maindao As New ContenedorDAO
        Dim dt As DataTable = maindao.GetContenedorAll(1)

        For Each dr As DataRow In dt.Rows
            dr("name") = "Mod. " & dr("name")
        Next
        Return dt
    End Function
    Public Function getRoles() As DataTable
        Dim dao As New RolDao
        Dim dt As DataTable = dao.GetRolAll(0)
        Dim dr As DataRow = dt.NewRow
        dr("id") = 0
        dr("name") = "Seleccione"
        dt.Rows.InsertAt(dr, 0)
        Return dt
    End Function

End Class
