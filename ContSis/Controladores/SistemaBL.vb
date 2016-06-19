Imports Capa_Entidad
Imports Modelos
Public Class SistemaBL
    Public Function Registrar(sistema As Sistema) As Boolean
        Dim sisDao As New SistemaDao
        Return sisDao.Mantenimiento(sistema)
    End Function
    Public Function GetSistema() As Sistema
        Dim sisDao As New SistemaDao
        Return sisDao.GetSistema
    End Function
End Class
