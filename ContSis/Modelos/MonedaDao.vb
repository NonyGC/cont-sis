Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class MonedaDao
    Inherits BaseDao
    Private conexionValue As MySqlConnection
    Public Function Moneda_all() As DataTable
        conexionValue = Me.conexion
        Dim sql As String = "select descripcion,tag from moneda;"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        Try
            DataAdapter.SelectCommand = consultaSQL
            DataAdapter.Fill(dataTable)
            conexionValue.Close()
            Moneda_all = dataTable
        Catch ex As Exception
            Moneda_all = Nothing
        End Try
    End Function
End Class
