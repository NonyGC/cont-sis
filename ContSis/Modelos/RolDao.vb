Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class RolDao
    Inherits BaseDao
    Private conexionValue As MySqlConnection
    'Metodos
    Public Function Rol_all() As DataTable
        'Variable
        Dim sql As String
        Dim consultaSQL As MySqlCommand
        Dim dataTable As New DataTable
        Dim DataAdapter As New MySqlDataAdapter
        'Logica
        conexionValue = Me.conexion
        sql = "select rol_id as Codigo, descrip as Descripcion from roles order by rol_id;"
        consultaSQL = New MySqlCommand(sql, conexionValue)
        Try
            DataAdapter.SelectCommand = consultaSQL
            DataAdapter.Fill(dataTable)
            Rol_all = dataTable
        Catch ex As Exception
            Rol_all = Nothing
        Finally
            conexionValue.Close()
        End Try
    End Function
    Public Function Registrar(ByVal rol As Rol, ByRef men As String)
        'Variables
        Dim rowsaffected As Integer
        Dim sql As String
        'Logica
        sql = "insert into roles(rol_id,descrip) values (@id,@descrip);"
        Ejecucion(rowsaffected, sql, rol, men)
        Return rowsaffected
    End Function
    Public Function Update(ByVal rol As Rol, ByRef men As String)
        'Variables
        Dim rowsaffected As Integer
        Dim sql As String
        'Logica
        sql = "update roles set descrip=@descrip where rol_id=@id LIMIT 1;"
        Ejecucion(rowsaffected, sql, rol, men)
        Return rowsaffected
    End Function
    Public Function Buscar(ByVal rol As String, ByRef men As String)
        'Variables
        Dim rowsaffected As Integer
        Dim sql As String
        'Logica
        sql = "select count(rol_id) from roles where rol_id = @rol;"
        EjecucionScalar(rowsaffected, sql, "@rol", rol, men)
        Return rowsaffected
    End Function
    Public Function Buscar_por_Usuario(ByVal usuario As String, ByRef men As String) As String
        'Variables
        Dim respuesta As String = ""
        Dim sql As String
        'Logica
        sql = "select u.rol_id from " &
            " usuarios as u inner join roles r on u.rol_id = r.rol_id " &
            " where u.nombre=@usuario;"
        EjecucionScalar(respuesta, sql, "@usuario", usuario, men)
        If respuesta.Trim().Length = 0 Then
            Return respuesta = ""
        Else
            Return respuesta
        End If
    End Function
    Private Sub Ejecucion(ByRef rowsaffected As Integer, _
                               ByVal sql As String, ByVal rol As Rol, _
                               ByRef men As String)
        'Variables 
        Dim consultaSQL As MySqlCommand
        'Logica
        conexionValue = Me.conexion
        consultaSQL = New MySqlCommand(sql, conexionValue)
        With consultaSQL
            .Parameters.AddWithValue("@id", rol.Id)
            .Parameters.AddWithValue("@descrip", rol.Descripcion)
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
    Private Sub EjecucionScalar(ByRef rowsaffected As Integer, _
                           ByVal sql As String, _
                           ByVal parametro As String, _
                           ByVal reemmplazo As String, _
                           ByRef men As String)
        'Variables 
        Dim consultaSQL As MySqlCommand
        'Logica
        conexionValue = Me.conexion
        consultaSQL = New MySqlCommand
        With consultaSQL
            .Connection = conexionValue
            .CommandText = sql
            .Parameters.AddWithValue(parametro, reemmplazo)
        End With
        Try
            rowsaffected = consultaSQL.ExecuteScalar()
        Catch ex As MySqlException
            men = ex.Message
            rowsaffected = 0
        Finally
            conexionValue.Close()
        End Try
    End Sub
    Private Sub EjecucionScalar(ByRef respueta As String, _
                       ByVal sql As String, _
                       ByVal parametro As String, _
                       ByVal reemmplazo As String, _
                       ByRef men As String)
        'Variables 
        Dim consultaSQL As MySqlCommand
        'Logica
        conexionValue = Me.conexion
        consultaSQL = New MySqlCommand
        With consultaSQL
            .Connection = conexionValue
            .CommandText = sql
            .Parameters.AddWithValue(parametro, reemmplazo)
        End With
        Try
            respueta = consultaSQL.ExecuteScalar()
        Catch ex As MySqlException
            men = ex.Message
            respueta = ""
        Finally
            conexionValue.Close()
        End Try
    End Sub

    Public Function GetRolAll(tipo As Integer) As DataTable
        Try
            Dim cmd As MySqlCommand = Me.CommandProcedure("sp_get_roles")
            cmd = Me.Parameters(cmd, New String() {tipo})
            Return Me.GetDataTable(cmd)
        Catch ex As Exception
            Me.CloseDB()
            Return Nothing
        End Try
    End Function

End Class
