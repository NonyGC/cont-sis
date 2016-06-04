Imports MySql.Data.MySqlClient
Public Class ContenedorDAO
    Inherits BaseDao

    Private conexionValue As MySqlConnection

    Public Function Contenedor_all() As DataTable
        conexionValue = Me.conexion
        Dim sql As String = "select * from contenedores order by nombre;"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        Try
            DataAdapter.SelectCommand = consultaSQL
            DataAdapter.Fill(dataTable)
            conexionValue.Close()
            Contenedor_all = dataTable
        Catch ex As Exception
            Contenedor_all = Nothing
        End Try
    End Function
    Public Function GetContenedorAll(tipo As Integer) As DataTable
        Try
            Dim cmd As MySqlCommand = Me.CommandProcedure("sp_get_menus")
            cmd = Me.Parameters(cmd, New String() {tipo})
            Return Me.GetDataTable(cmd)
        Catch ex As Exception
            Me.CloseDB()
            Return Nothing
        End Try
    End Function
End Class
