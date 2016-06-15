Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class PermisoDao
    Inherits BaseDao
    'Variables
    Private tabla As DataTable
    Private conexionValue As MySqlConnection
    Private consultaSQL As MySqlCommand
    Private DataAdapter As MySqlDataAdapter
    Private sql As String
    'Constructor
    'Propiedades 
    'Metodos
    Function crearTabla() As DataTable
        Me.tabla = New DataTable()
        CrearColumna("Privilegio", tabla)
        CrearColumna("Rol", tabla)
        CrearColumna("Empresa_id", tabla, "unique")
        CrearColumna("Empresa", tabla)
        crearTabla = tabla
    End Function
    Public Function Buscar_por_Rol_All(ByVal rol As Integer) As DataTable
        'Variables
        Me.tabla = New DataTable()
        Me.DataAdapter = New MySqlDataAdapter
        'Logica
        sql = "select priv_id , rol_id, emp_id,nombre " &
                "from cab_privilegios as c  " &
                "inner join empresas as e on c.emp_id = e.ruc " &
                "where rol_id = @rol order by priv_id;"
        conexionValue = Me.conexion
        consultaSQL = New MySqlCommand(sql, conexionValue)
        With consultaSQL
            .Parameters.AddWithValue("@rol", rol)
        End With

        Try
            DataAdapter.SelectCommand = consultaSQL
            DataAdapter.Fill(Me.tabla)
            Return Me.tabla
        Catch ex As Exception
            Return Nothing
        Finally
            conexionValue.Close()
        End Try
    End Function
    Public Function Registrar(ByVal cabPrivilegio As CabPrivilegio, ByRef men As String)
        'Variables
        Dim rowsaffected As Integer
        Dim sql As String
        'Logica
        sql = "insert into cab_privilegios(priv_id,rol_id,emp_id) " &
              "values (@id,@rol,@empresa);"
        Ejecucion(rowsaffected, sql, cabPrivilegio, men)
        Return rowsaffected
    End Function
    Public Function Delete_por_Rol(ByVal rol As String, ByRef men As String)
        'Variables
        Dim rowsaffected As Integer
        Dim sql As String
        'Logica
        sql = "delete from  cab_privilegios where rol_id=@rol;"
        Ejecucion(rowsaffected, sql, rol, men)
        Return rowsaffected
    End Function
    Private Sub Ejecucion(ByRef rowsaffected As Integer,
                               ByVal sql As String,
                               ByVal cabPrivilegio As CabPrivilegio,
                               ByRef men As String)
        'Variables 
        Dim consultaSQL As MySqlCommand
        'Logica
        conexionValue = Me.conexion
        consultaSQL = New MySqlCommand(sql, conexionValue)
        With consultaSQL
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@id", cabPrivilegio.Id)
            .Parameters.AddWithValue("@rol", cabPrivilegio.Rol)
            .Parameters.AddWithValue("@empresa", cabPrivilegio.Empresa)
        End With
        Try
            rowsaffected = consultaSQL.ExecuteNonQuery()
        Catch ex As MySqlException
            men = ex.Message
            rowsaffected = 0
        Finally
            conexionValue.Close()
        End Try
    End Sub
    Private Sub Ejecucion(ByRef rowsaffected As Integer,
                           ByVal sql As String,
                           ByVal rol As String,
                           ByRef men As String)
        'Variables 
        Dim consultaSQL As MySqlCommand
        'Logica
        conexionValue = Me.conexion
        consultaSQL = New MySqlCommand(sql, conexionValue)
        With consultaSQL
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@rol", rol)
        End With
        Try
            rowsaffected = consultaSQL.ExecuteNonQuery()
        Catch ex As MySqlException
            men = ex.Message
            rowsaffected = 0
        Finally
            conexionValue.Close()
        End Try
    End Sub
    Public Function NewId() As Integer
        Try
            Dim cmd = CommandProcedure("sp_new_per")
            Return CInt(cmd.ExecuteScalar)
        Catch ex As Exception
            CloseDB()
            Return 0
        End Try

    End Function
    Public Function CrearSchema() As DataTable
        Dim dt As New DataTable("Permiso")
        dt.Columns.Add("emp")
        dt.Columns.Add("usu")
        dt.Columns.Add("compt")
        dt.Columns.Add("mod")
        dt.PrimaryKey = New DataColumn() {dt.Columns("emp")}
        Return dt
    End Function

End Class
