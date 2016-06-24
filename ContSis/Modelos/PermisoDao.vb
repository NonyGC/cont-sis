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


End Class
