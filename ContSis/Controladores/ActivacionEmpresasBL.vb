Imports Capa_Entidad
Imports Modelos
Public Class ActivacionEmpresasBL
    Inherits BaseBL
    Public ReadOnly count As Integer
    Public Function getEmpresas(id As String, empresas As Empresa()) As DataTable
        Dim empDao As New EmpresaDao
        Dim dt As New DataTable("empresa_permiso")
        dt.Columns.Add("ruc")
        dt.Columns.Add("rzn_scl")
        dt.Columns.Add("rzn_scl_ls")
        dt.Columns.Add("cod")
        dt.Columns.Add("dig")
        dt.Columns.Add("id")
        dt.Columns.Add("compt")
        dt.Columns.Add("modu")
        dt.Columns.Add("estado")
        Dim ep As New EmpresaPermiso
        For Each empresa As Empresa In empresas
            ep = empDao.GetEmpresasxRol(id, empresa.RUC)
            If ep IsNot Nothing Then
                Dim dr As DataRow = dt.NewRow
                dr("ruc") = ep.empresa.RUC
                dr("rzn_scl") = ep.empresa.Nombre
                dr("rzn_scl_ls") = ep.empresa.Aliass
                dr("cod") = ep.empresa.Codigo
                dr("dig") = ep.empresa.Digito
                dr("id") = ep.permiso.Id
                dr("compt") = ep.permiso.Completo
                dr("modu") = ep.permiso.Modulo
                dr("estado") = True
                dt.Rows.Add(dr)
            Else
                Dim dr As DataRow = dt.NewRow
                dr("ruc") = empresa.RUC
                dr("rzn_scl") = empresa.Nombre
                dr("rzn_scl_ls") = empresa.Aliass
                dr("estado") = False
                dt.Rows.Add(dr)
            End If
        Next
        Return dt
    End Function
End Class
