Imports Capa_Entidad
Imports Modelos
Public Class ActivacionEmpresasBL
    Inherits BaseBL
    Public ReadOnly count As Integer
    Public Function getEmpresas(id As String) As DataTable
        Dim empDao As New EmpresaDao
        Return empDao.GetEmpresasxRol(id)
    End Function
End Class
