Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class PermisoDao
    Inherits BaseDao
    Public Function Registrar(permiso As Permiso) As Boolean
        Try
            Dim respuesta As Integer
            Dim cmd As MySqlCommand = CommandProcedure("sp_jc_registrar_permiso")

            cmd = Parameters(cmd, New String() {permiso.Usuario, permiso.Empresa, permiso.ConvertIntToCompleto, permiso.Modulo})
            respuesta = cmd.ExecuteNonQuery()
            If respuesta <= 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            CloseDB()
        End Try

    End Function

    Public Function NewId() As Integer
        Try
            Dim cmd = CommandProcedure("sp_new_per")
            Return CInt(cmd.ExecuteScalar)
        Catch ex As Exception
            CloseDB()
            Return 0
        End Try
    End Function
    Public Function BuscarByUsuarioId(UsuarioId As Integer) As List(Of Permiso)
        Try
            Dim list As New List(Of Permiso)

            Dim cmd As MySqlCommand = CommandText("select * from permiso where usu_id=@id;")
            cmd.Parameters.AddWithValue("@id", UsuarioId)
            Using dr As MySqlDataReader = cmd.ExecuteReader
                While dr.Read
                    Dim permiso As New Permiso
                    permiso.Id = dr.GetInt32("per_id")
                    permiso.Usuario = dr.GetInt32("usu_id")
                    permiso.Modulo = dr.GetString("modulos")
                    permiso.Empresa = dr.GetString("emp_id")
                    list.Add(permiso)
                End While
                Return list
            End Using
        Catch ex As Exception
            Return Nothing
        Finally
            CloseDB()
        End Try

    End Function

    Public Function GetByUsuarioAndEmpresa(id As Integer, rUC As String) As Permiso
        Try
            Dim cmd As MySqlCommand = CommandText("select * from permiso WHERE usu_id=@id and emp_id=@ruc;")
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@ruc", rUC)
            Using dr As MySqlDataReader = cmd.ExecuteReader
                Dim permiso As New Permiso
                If dr.Read() Then
                    permiso.Id = dr.GetInt32("per_id")
                    permiso.Usuario = dr.GetInt32("usu_id")
                    permiso.Empresa = dr.GetString("emp_id")
                    permiso.Completo = dr.GetInt32("compt")
                    permiso.Modulo = dr.GetString("modulos")
                End If
                If permiso.Id = 0 Then
                    Return Nothing
                Else
                    Return permiso
                End If

            End Using
        Catch ex As Exception
            Return Nothing
        Finally
            CloseDB()
        End Try
    End Function
End Class
