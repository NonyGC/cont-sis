Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class EmpresaDao
    Inherits BaseDao

    Private conexionValue As MySqlConnection

    Public Function Empresa_all() As DataTable
        conexionValue = Me.conexion
        Dim sql As String = "select ruc,nombre,alias,imagen,cod,digito  from empresas;"
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
    'Public Function Empresas() As DataTable
    '    Try
    '        Dim cmd As MySqlCommand = Me.CommandProcedure("sp_get_empresas")
    '        Dim dt As DataTable = Me.GetDataTable(cmd)
    '        Return dt
    '    Catch ex As Exception
    '        Return Nothing
    '        Me.CloseDB()
    '    End Try
    'End Function
    Public Function GetEmpresasxRol(id As Integer, ruc As String) As EmpresaPermiso
        Dim cmd As MySqlCommand = CommandProcedure("sp_get_empresa_select")

        Dim ep As New EmpresaPermiso
        Try
            cmd = Me.Parameters(cmd, New String() {id, ruc})

            Using dr As MySqlDataReader = cmd.ExecuteReader
                If dr.Read Then
                    Dim empresa As New Empresa
                    Dim permiso As New Permiso

                    empresa.RUC = dr.GetString("ruc")
                    empresa.Nombre = dr.GetString("rzn_scl")
                    empresa.Aliass = dr.GetString("rzn_scl_ls")
                    empresa.Codigo = dr.GetString("cod")
                    empresa.Digito = dr.GetInt32("digito")

                    permiso.Id = dr.GetInt32("per_id")
                    Dim respCompt As Integer = dr.GetInt32("compt")
                    If respCompt = 0 Then
                        permiso.Completo = False
                    Else
                        permiso.Completo = True
                    End If
                    permiso.Modulo = dr.GetString("modulos")

                    ep.empresa = empresa
                    ep.permiso = permiso

                Else
                    ep = Nothing
                End If


            End Using
            Return ep
        Catch ex As Exception
            Me.CloseDB()
            Return Nothing
        End Try
    End Function

    Public Function GetAll() As List(Of Empresa)
        Try
            Dim cmd As MySqlCommand = CommandText("select * from empresas;")
            Dim listEmpresa As New List(Of Empresa)
            Using dr As MySqlDataReader = cmd.ExecuteReader
                While dr.Read
                    Dim empresa As New Empresa
                    empresa.RUC = dr.GetString("ruc")
                    empresa.Nombre = dr.GetString("nombre")
                    empresa.Aliass = dr.GetString("Alias")
                    empresa.Codigo = dr.GetString("cod")
                    empresa.Digito = dr.GetString("digito")
                    listEmpresa.Add(empresa)
                End While
                Return listEmpresa
            End Using
        Catch ex As Exception
            Return Nothing
        Finally
            CloseDB()
        End Try

    End Function

    Public Function Empresa_data(ByVal entemp As Empresa) As DataTable
        conexionValue = Me.conexion
        Dim sql As String = "select ruc,nombre,alias,imagen,cod,digito,d.descripcion,p.descripcion,u.descripcion,u.codigo
                             from empresas,departamento d,provincia p,ubigeo u 
                             where u.cod_provincia=p.codigo and p.cod_departamento=d.codigo and u.codigo=ubigeo and ruc=@ruc;"
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
    Public Function Registrar(empresa As Empresa) As Boolean
        Try
            Dim i As Integer
            Dim cmd As MySqlCommand = CommandProcedure("sp_registrar_empresa")
            cmd = Parameters(cmd, empresa.Array)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        Finally
            CloseDB()
        End Try

    End Function
    Public Function Empresa_Actualizar(ByVal entemp As Empresa)
        conexionValue = Me.conexion
        Dim rowsaffected As Integer
        Dim sql As String = "update empresas set nombre=@nom,alias=@alias,imagen=@imagen,ubigeo=@ubi where ruc=@ruc;"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@nom", entemp.Nombre)
            .Parameters.AddWithValue("@alias", entemp.Aliass)
            .Parameters.AddWithValue("@ruc", entemp.RUC)
            .Parameters.AddWithValue("@imagen", entemp.imagen_string)
            .Parameters.AddWithValue("@ubi", entemp.ubigeo)
        End With
        Try
            rowsaffected = consultaSQL.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conexionValue.Close()
        End Try
        Return rowsaffected
    End Function
    Public Function GetById(ruc As String) As Empresa
        Try
            Dim empresa As Empresa
            Dim cmd As MySqlCommand = CommandProcedure("sp_get_by_id_empresa")
            cmd = Parameters(cmd, New String() {ruc})
            Using dr As MySqlDataReader = cmd.ExecuteReader
                If dr.Read Then
                    empresa = New Empresa
                    empresa.RUC = dr.GetString("ruc")
                    empresa.Nombre = dr.GetString("rz")
                    empresa.Aliass = dr.GetString("rz_com")
                    empresa.Codigo = dr.GetString("cod")
                    empresa.Digito = dr.GetInt32("dig")
                Else
                    empresa = Nothing
                End If
            End Using
            Return empresa
        Catch ex As Exception
            Return Nothing
        Finally
            CloseDB()
        End Try

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
    Public Function ubigeo(op As Integer, ByVal entemp As Empresa) As DataTable
        conexionValue = Me.conexion
        Dim sql As String = ""
        Select Case op
            Case 0  'departamento
                sql = "select codigo,descripcion from departamento;"
            Case 1  'provincia
                sql = "select distinct p.codigo,p.descripcion from provincia p,departamento d where d.codigo=p.cod_departamento and d.codigo=@cod;"
            Case 2  'ditrito
                sql = "select distinct u.codigo,u.descripcion from ubigeo u,provincia p where p.codigo=u.cod_provincia and p.codigo=@cod;"
        End Select
        Dim consultaSQL As New MySqlCommand(sql, conexionValue)
        Dim dt As New DataTable
        Dim DataAdapter As New MySqlDataAdapter
        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@cod", entemp.ubigeo)
        End With
        DataAdapter.SelectCommand = consultaSQL
        DataAdapter.Fill(dt)
        CloseDB()
        Return dt
    End Function
End Class
Public Class EmpresaPermiso
    Public empresa As Empresa
    Public permiso As Permiso
End Class