Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class EmpresaDao
    Inherits BaseDao

    Private conexionValue As MySqlConnection

    Public Function Empresa_all() As DataTable
        conexionValue = Me.conexion
        Dim sql As String = "select ruc,nombre,alias  from empresas;"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        Try
            DataAdapter.SelectCommand = consultaSQL
            DataAdapter.Fill(dataTable)
            conexionValue.Close()
            Empresa_all = dataTable
        Catch ex As Exception
            Empresa_all = Nothing
        End Try
    End Function
    Public Function GetEmpresasxRol(id As String) As DataTable
        Dim cmd As New MySqlCommand("sp_get_empresas_status_rol", Me.conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Try
            cmd = Me.Parameters(cmd, New String() {id})
            dt = Me.GetDataTable(cmd)
            Return dt
        Catch ex As Exception
            Me.CloseDB()
            Return Nothing
        End Try
    End Function
    Public Function Empresa_data(ByVal entemp As Empresa) As DataTable
        conexionValue = Me.conexion
        Dim sql As String = "select ruc,nombre,alias,imagen from empresas where ruc=@ruc;"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@ruc", entemp.RUC)
        End With
        Try
            DataAdapter.SelectCommand = consultaSQL
            DataAdapter.Fill(dataTable)
            conexionValue.Close()
            Empresa_data = dataTable
        Catch ex As Exception
            Empresa_data = Nothing
        End Try
    End Function
    Public Function Empresa_Register(ByVal entemp As Empresa)
        conexionValue = Me.conexion
        Dim rowsaffected As Integer
        Dim sql As String = "insert into empresas(ruc,nombre,alias,imagen) values(@ruc,@nom,@alias,@imagen);"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@ruc", entemp.RUC)
            .Parameters.AddWithValue("@nom", entemp.Nombre)
            .Parameters.AddWithValue("@alias", entemp.Aliass)
            .Parameters.AddWithValue("@imagen", entemp.imagen)
        End With
        Try
            rowsaffected = consultaSQL.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conexionValue.Close()
        End Try
        Return rowsaffected
    End Function
    Public Function Empresa_Actualizar(ByVal entemp As Empresa)
        conexionValue = Me.conexion
        Dim rowsaffected As Integer
        Dim sql As String = "update empresas set nombre=@nom,alias=@alias,imagen=@imagen where ruc=@ruc;"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@nom", entemp.Nombre)
            .Parameters.AddWithValue("@alias", entemp.Aliass)
            .Parameters.AddWithValue("@ruc", entemp.RUC)
            .Parameters.AddWithValue("@imagen", entemp.imagen)
        End With
        Try
            rowsaffected = consultaSQL.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conexionValue.Close()
        End Try
        Return rowsaffected
    End Function
    Shared Function CrearSchema() As DataTable
        'Declaracion
        'Variables DataColumn
        Dim dcRuc As New DataColumn("RUC")
        Dim dcRazonSocial As New DataColumn("RazonSocial")
        Dim dcAlias As New DataColumn("Alias")
        Dim dcImagen As New DataColumn("Image")
        'Variable DataTable
        Dim dtEmpresa As New DataTable("Empresa")
        '---------------

        'Logica
        dtEmpresa.Columns.Add(dcRuc)
        dtEmpresa.Columns.Add(dcRazonSocial)
        dtEmpresa.Columns.Add(dcAlias)
        dtEmpresa.Columns.Add(dcImagen)
        Return dtEmpresa

    End Function
End Class
