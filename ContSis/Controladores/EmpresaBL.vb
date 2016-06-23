Imports Modelos
Imports Capa_Entidad
Public Class EmpresaBL
    Inherits BaseBL
    'Variable
    Private empresaDao As New EmpresaDao

    'Metodos

    Dim Datos As New CuentaDAO
    Public Function Empresa_DatosLB(ByVal entemp As Empresa) As DataTable
        Return empresaDao.Empresa_data(entemp)
    End Function
    Public Function Empresa_RegisterLB(ByVal entemp As Empresa)
        Dim verificar As Integer
        verificar = empresaDao.Empresa_Register(entemp)
        Return verificar
    End Function
    Public Function Empresa_ActualizarLB(ByVal entemp As Empresa)
        Dim verificar As Integer
        verificar = empresaDao.Empresa_Actualizar(entemp)
        Return verificar
    End Function
    Public Function tablaEmpresas() As DataTable
        Dim tablas As DataTable
        Dim empresas As New EmpresaDao
        tablas = empresas.Empresa_all()
        tablaEmpresas = tablas
    End Function
End Class
