Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class UsuarioDao
    Inherits BaseDao

    Private conexionValue As MySqlConnection
    Private _respuesta As String
    Private log As String
    Public ReadOnly Property Respuesta As String
        Get
            Return _respuesta
        End Get
    End Property

    Public Function UsuariosAll() As DataTable
        conexionValue = Me.conexion
        Dim sql As String = "select usu_id,usu_name,usu_password,usu_state from usuario where usu_tipo='normal';"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        Try
            DataAdapter.SelectCommand = consultaSQL
            DataAdapter.Fill(dataTable)
            Return dataTable
        Catch ex As Exception
            Return Nothing
        Finally
            CloseDB()
        End Try
    End Function
    Public Function Registrar(ByVal usuario As Usuario) As Boolean
        Try
            Dim respuesta As Integer
            Dim cmd As MySqlCommand = CommandProcedure("sp_jc_registrar_usuario")
            cmd = Parameters(cmd, New String() {usuario.Usuario, usuario.Password, usuario.State, usuario.Tipo})
            respuesta = cmd.ExecuteNonQuery()
            If respuesta <= 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As MySqlException
            Return False
            log = ex.Message
        Catch ex As Exception
            Return False
        Finally
            CloseDB()
        End Try

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
        End With
        Try
            rowsaffected = consultaSQL.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conexionValue.Close()
        End Try
        Return rowsaffected
    End Function

    Public Sub UpdateSession(usuario As Usuario)
        Try
            Dim cmd As MySqlCommand = CommandProcedure("sp_Update_Usuario")
            cmd = Parameters(cmd, New String() {usuario.Id})
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.conexion.Close()
        End Try
    End Sub
    Public Function NewUsuario() As Integer
        Try
            Dim cmd As MySqlCommand = CommandProcedure("sp_new_usu")
            Return CInt(cmd.ExecuteScalar)

        Catch ex As Exception
            Return 0
            Debug.WriteLine("Error: NewUsuario " & ex.ToString)
        End Try
    End Function
    Public Function ResponseUsuario(usu As UsuarioNormal) As UsuarioNormal
        Try
            Dim c As Integer = 0
            Dim dr As MySqlDataReader
            Dim usuario As Usuario

            Dim cmd As MySqlCommand = CommandProcedure("sp_response_usuario")
            cmd = Parameters(cmd, usu.ArrayUsuario)
            dr = cmd.ExecuteReader
            usuario = New UsuarioNormal
            If dr.Read Then
                If dr.FieldCount = 1 Then
                    _respuesta = dr.GetString(0)
                Else

                    usuario.Id = dr.GetInt32("id")
                    usuario.Usuario = usu.Usuario
                    usuario.Password = usu.Password
                    usuario.Sesion = dr.GetInt32("sesion")
                    usuario.State = dr.GetInt32("state")
                    _respuesta = "ok"
                End If
            End If
            Return usuario
        Catch ex As Exception
            _respuesta = "fail"
            Return Nothing
        Finally
            Me.conexion.Close()
        End Try
    End Function
    Public Function ResponseUsuarioAdmin(admin As UsuarioAdmin) As UsuarioAdmin
        Try
            Dim dr As MySqlDataReader
            Dim usu As Usuario
            usu = New UsuarioAdmin
            Dim cmd As MySqlCommand = CommandProcedure("sp_response_admin")
            cmd = Parameters(cmd, admin.ArrayUsuario)
            dr = cmd.ExecuteReader
            If dr.Read Then
                If dr.FieldCount = 1 Then
                    _respuesta = dr.GetString(0)
                Else
                    usu.Id = dr.GetInt32("id")
                    usu.Usuario = admin.Usuario
                    usu.Password = admin.Password
                    usu.Sesion = dr.GetInt32("sesion")
                    usu.State = dr.GetInt32("state")
                    _respuesta = "ok"
                End If
            End If
            Return usu
        Catch ex As Exception
            Return Nothing
        Finally
            CloseDB()
        End Try

    End Function
    Public Function IdbyName(Name As String) As Integer
        Try
            Dim respuesta As Integer
            Dim cmd As MySqlCommand = CommandText("select * from  usuario where usu_name=@name;")
            cmd.Parameters.AddWithValue("@name", Name)
            respuesta = cmd.ExecuteScalar
            Return respuesta
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ResponseUsuarioMaster(master As UsuarioMaster) As UsuarioMaster
        If master.Password = "vertigo" Then
            _respuesta = "ok"
            Dim usu As New UsuarioMaster

            usu.Id = 0
            usu.Usuario = master.Usuario
            usu.Sesion = 1
            usu.State = 1

            Return usu
        Else
            _respuesta = "fail"
            Return Nothing

        End If
    End Function
    Public Function RegistroAdmin(usuario As Usuario) As Boolean
        Try
            Dim cmd As MySqlCommand = CommandProcedure("sp_registro_usuario_admin")
            cmd = Parameters(cmd, usuario.Array)
            Dim registro As Integer = cmd.ExecuteNonQuery
            If registro > 0 Then
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
    Public Function GetAdmin() As UsuarioAdmin
        Try
            Dim usuario As New UsuarioAdmin
            Dim cmd As MySqlCommand = CommandProcedure("sp_get_usuario_admin")
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            If dr.Read Then
                usuario.Id = dr.GetInt32("id")
                usuario.Usuario = dr.GetString("usu")
                usuario.Password=dr.GetString("pass")
            Else
                usuario = Nothing
            End If
            Return usuario

        Catch ex As Exception
            Return Nothing
        Finally
            CloseDB()
        End Try
    End Function

    Public Function Eliminar(usuarioID As Integer) As Boolean
        Try
            Dim cmd As MySqlCommand = CommandText("delete from usuario where usu_id=@id;")
            cmd.Parameters.AddWithValue("@id", usuarioID)
            Dim respuesta As Integer = cmd.ExecuteNonQuery
            If respuesta > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
