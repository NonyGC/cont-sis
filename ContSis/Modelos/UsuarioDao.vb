Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class UsuarioDao
    Inherits BaseDao

    Private conexionValue As MySqlConnection

    Public Function Usuarios_Showall() As DataTable
        conexionValue = Me.conexion
        Dim sql As String = "select usu_id,nombre,rol_id from usuarios;"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        Try
            DataAdapter.SelectCommand = consultaSQL
            DataAdapter.Fill(dataTable)
            conexionValue.Close()
            Usuarios_Showall = dataTable
        Catch ex As Exception
            Usuarios_Showall = Nothing
        End Try
    End Function
    Public Function Usuarios_Register(ByVal entusu As Usuario)
        conexionValue = Me.conexion
        Dim rowsaffected As Integer
        Dim sql As String = "insert into usuarios(nombre,clave,rol_id) values(@usu,@pass,@rol);"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@usu", entusu.Usuario)
            .Parameters.AddWithValue("@pass", entusu.Password)
            .Parameters.AddWithValue("@rol", entusu.Rol)
        End With
        Try
            rowsaffected = consultaSQL.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conexionValue.Close()
        End Try
        Return rowsaffected
    End Function
    Public Function Usuarios_Actualizar(ByVal entusu As Usuario)
        conexionValue = Me.conexion
        Dim rowsaffected As Integer
        Dim sql As String = "update usuarios set nombre=@usu,clave=@pass,rol_id=@rol where usu_id=@id;"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@usu", entusu.Usuario)
            .Parameters.AddWithValue("@pass", entusu.Password)
            .Parameters.AddWithValue("@rol", entusu.Rol)
            .Parameters.AddWithValue("@id", entusu.Codigo)

        End With
        Try
            rowsaffected = consultaSQL.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conexionValue.Close()
        End Try
        Return rowsaffected
    End Function

    Public Sub UpdateSession(envio() As String)

        'Declaracion 
        Dim prm As New MySqlParameter
        Dim c As Integer = 0


        Try
            Dim cmd As MySqlCommand = New MySqlCommand("sp_Update_Usuario", Me.conexion)
            cmd.CommandType = CommandType.StoredProcedure
            MySqlCommandBuilder.DeriveParameters(cmd)

            For Each prm In cmd.Parameters
                If prm.ParameterName <> "@RETURN_VALUE" Then
                    prm.Value = envio(c)
                    c = c + 1
                End If
            Next
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.conexion.Close()
        End Try

    End Sub
End Class
