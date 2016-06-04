Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class FormularioDAO
    Inherits BaseDao

    Private conexionValue As MySqlConnection

    Public Function Formularios_All() As DataTable
        conexionValue = Me.conexion
        Dim sql As String = "select * from formularios;"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        Try
            DataAdapter.SelectCommand = consultaSQL
            DataAdapter.Fill(dataTable)
            conexionValue.Close()
            Formularios_All = dataTable
        Catch ex As Exception
            Formularios_All = Nothing
        End Try

    End Function
    Public Function GetOpcionesxMenuId(id As Integer) As DataTable
        Dim cmd As MySqlCommand = New MySqlCommand("sp_get_opciones_x_menu_id", Me.conexion)

        cmd.CommandType = CommandType.StoredProcedure
        Try
            cmd = Me.Parameters(cmd, New String() {id})

            Return Me.GetDataTable(cmd)
        Catch ex As Exception
            Me.CloseDB()
            Return Nothing
        End Try
    End Function
    Public Function GetFormularioBDxDscp(dscp As String) As Formulario
        Dim cmd As New MySqlCommand("sp_get_opciones_x_menu_id", Me.conexion)
        Dim rd As MySqlDataReader
        Dim f As New Formulario
        cmd.CommandType = CommandType.StoredProcedure
        Try
            cmd = Me.Parameters(cmd, New String() {dscp})
            rd = cmd.ExecuteReader
            While rd.Read
                f.Id = rd.GetInt32("id")
                f.Id = rd.GetString("dscrip")
                f.Id = rd.GetInt32("mnuid")
                f.Id = rd.GetString("frm")
            End While
            Return Nothing
        Catch ex As Exception
            Me.CloseDB()
            Return Nothing
        End Try
    End Function

End Class
