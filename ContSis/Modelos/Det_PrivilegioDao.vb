Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class Det_PrivilegioDao
    Inherits BaseDao
    'Variables
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
        CrearColumna("Id", tabla, "unique")
        CrearColumna("Privilegio", tabla)
        CrearColumna("Contenedor", tabla)
        CrearColumna("Node", tabla)
        CrearColumna("Cantidad", tabla)
        CrearColumna("Formularios", tabla)
        crearTabla = tabla
    End Function

    Public Function Buscar_por_Privilegio_All(ByVal privilegio As String) As DataTable
        'Variables
        Me.tabla = New DataTable()
        Me.DataAdapter = New MySqlDataAdapter
        'Logica
        sql = "select * from Det_Privilegios where priv_id = @privilegio order by priv_id;"
        conexionValue = Me.conexion
        consultaSQL = New MySqlCommand(sql, conexionValue)
        With consultaSQL
            .Parameters.AddWithValue("@privilegio", privilegio)
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
    Public Function Buscar_por_Privilegio_Contenedor_All(ByVal privilegio As String) As DataTable
        'Variables
        Me.tabla = New DataTable()
        Me.DataAdapter = New MySqlDataAdapter
        'Logica
        sql = "select priv_id,dp.cont_id,cant_form,form,nivel,cont_rel,nombre " &
                "from Det_Privilegios as dp " &
                "inner join contenedores as c on dp.cont_id= c.cont_id " &
                "where priv_id = @privilegio order by nivel ;"
        conexionValue = Me.conexion
        consultaSQL = New MySqlCommand(sql, conexionValue)
        With consultaSQL
            .Parameters.AddWithValue("@privilegio", privilegio)
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
    Public Function Registrar(ByVal detPrivilegio As DetPrivilegio, ByRef men As String)
        'Variables
        Dim rowsaffected As Integer
        Dim sql As String
        'Logica
        sql = "insert into Det_Privilegios(priv_id,cont_id,cant_form,form) " &
              "values (@privilegio,@contenedor,@cantidad,@formularios);"
        Ejecucion(rowsaffected, sql, detPrivilegio, men)
        Return rowsaffected
    End Function
    Public Function Delete_por_Privilegio(ByVal privilegio As String, ByRef men As String)
        'Variables
        Dim rowsaffected As Integer
        Dim sql As String
        'Logica
        sql = "delete from  Det_Privilegios where priv_id=@privilegio;"
        Ejecucion_Delete(rowsaffected, sql, privilegio, men)
        Return rowsaffected
    End Function
    Private Sub Ejecucion(ByRef rowsaffected As Integer, _
                               ByVal sql As String, ByVal detPrivilegio As DetPrivilegio, _
                               ByRef men As String)
        'Variables 
        Dim consultaSQL As MySqlCommand
        'Logica
        conexionValue = Me.conexion
        consultaSQL = New MySqlCommand(sql, conexionValue)
        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@privilegio", detPrivilegio.Privilegio)
            .Parameters.AddWithValue("@contenedor", detPrivilegio.Contenedor)
            .Parameters.AddWithValue("@cantidad", detPrivilegio.Cantidad)
            .Parameters.AddWithValue("@formularios", detPrivilegio.Formulario)
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
    Private Sub Ejecucion_Delete(ByRef rowsaffected As Integer,
                           ByVal sql As String, ByVal privilegio As String,
                           ByRef men As String)
        'Variables 
        Dim consultaSQL As MySqlCommand
        'Logica
        conexionValue = Me.conexion
        consultaSQL = New MySqlCommand(sql, conexionValue)
        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@privilegio", privilegio)
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
    Public Function GetDetPrivilegios(id As String) As DataTable
        Try
            Dim da As New MySqlDataAdapter
            Dim cmd As MySqlCommand = Me.CommandProcedure("sp_get_privs_id")
            Dim dt As New DataTable
            cmd = Parameters(cmd, New String() {id})
            da.SelectCommand = cmd
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Return Nothing
        Finally
            CloseDB()
        End Try


    End Function

End Class
