Imports Capa_Entidad
Imports Modelos
Public Class ActivacionEmpresasBL
    Inherits BaseBL
    Public ReadOnly count As Integer
    Public Function getEmpresas(id As String) As DataTable
        Dim empDao As New EmpresaDao
        Return empDao.GetEmpresasxRol(id)
    End Function
    'Public Function getDetPrivilegios(id As String) As DataTable
    '    Dim dtDao As New Det_PrivilegioDao
    '    Return dtDao.GetDetPrivilegios(id)
    'End Function
End Class
