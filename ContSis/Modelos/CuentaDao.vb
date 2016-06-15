Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class CuentaDAO
    Inherits BaseDao

    Private conexionValue As MySqlConnection
    Public Function Auxiliar_Autocompletado() As DataTable
        Return Consultas_SQL("sp_ruc_auxiliares")
    End Function
    Public Function Cuenta_Autocompletado_f() As DataTable
        Return Consultas_SQL("sp_Cuenta_Showall_f")
    End Function
    Public Function Cuenta_Showall(ByVal tabla As String, ByVal largo As String) As DataTable
        Return Consultas_SQL("sp_Cuenta_Showall", tabla, largo)
    End Function
    Public Function Cuenta_Showall_destino(ByVal tabla As String, ByVal dest1 As String) As DataTable
        Return Consultas_SQL("sp_Cuenta_Showall_destino", tabla, dest1 + "%")
    End Function

    Public Function Cuenta_data(ByVal tabla As String, ByVal entcont As Cuenta) As DataTable
        Return Consultas_SQL("sp_cuenta_data", tabla, entcont.codigo)
    End Function
    Public Function Cuenta_Showall_Export(ByVal tabla As String) As DataTable
        Return Consultas_SQL("sp_Cuenta_Showall_Export", tabla)
    End Function
    Public Function Cuenta_Register(ByVal tabla As String, ByVal entcont As Cuenta)
        Return Mantenimiento_SQL("sp_Cuenta_Register", tabla, entcont.codigo, entcont.nombre, entcont.aliass)
    End Function
#Region "Amarres_Contables"
    Public Function Cuenta_Amarre_Show(ByVal tabla As String, ByVal entcont As Cuenta) As DataTable
        Return Consultas_SQL("sp_C_Amarre_Show", tabla, entcont.codigo)
    End Function
    Public Function Cuenta_Amarre_Register(ByVal tabla As String, ByVal cond As Integer, ByVal entcont As Cuenta) As Integer
        Return Mantenimiento_SQL("sp_C_Amarre_Register", tabla, entcont.codigo, entcont.c_debe, entcont.c_haber, cond)
    End Function
#End Region
    Public Function Cuenta_Actualizar(ByVal tabla As String, ByVal entcont As Cuenta) As Integer
        Return Mantenimiento_SQL("sp_Cuenta_Actualizar", tabla, entcont.nombre, entcont.aliass, entcont.codigo)
    End Function
    Public Function Cuenta_Borrar(ByVal tabla As String, ByVal entcont As Cuenta) As Integer
        Return Mantenimiento_SQL("sp_Cuenta_Borrar", tabla, entcont.codigo)
    End Function
    Public Function TComprobante_Showall() As DataSet
        conexionValue = Me.conexion
        Dim sql As String = "select descripcion from tipo_Comprobante;"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataset As New DataSet
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        Try
            DataAdapter.SelectCommand = consultaSQL
            DataAdapter.Fill(dataset)
            conexionValue.Close()
            TComprobante_Showall = dataset
        Catch ex As Exception
            TComprobante_Showall = Nothing
        End Try
    End Function
End Class
