Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class SistemaDao
    Inherits BaseDao

    Public Function ActivoAdmin() As Boolean
        Try

            Dim rsp As Integer
            Dim cmd As MySqlCommand = CommandProcedure("sp_act_adm")
            rsp = CInt(cmd.ExecuteScalar)

            If rsp > 0 Then
                Return True
            End If
            Return rsp
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Mantenimiento(sistema As Sistema) As Boolean
        Try
            Dim cmd As MySqlCommand = CommandProcedure("sp_configuracion")
            cmd = Parameters(cmd, sistema.Array)
            Dim c As Integer = cmd.ExecuteNonQuery()
            If c > 0 Then
                Return True
            Else
                Return False
            End If
            Return True
        Catch ex As Exception
            Return False
        Finally
            CloseDB()
        End Try
    End Function
    Public Function GetSistema() As Sistema
        Try
            Dim sistema As New Sistema
            Dim cmd As MySqlCommand = CommandProcedure("sp_get_sistema")
            Using dr As MySqlDataReader = cmd.ExecuteReader
                If dr.Read() Then
                    sistema.NroUsuario = dr.GetInt32("usu")
                    sistema.NroEmpresa = dr.GetInt32("emp")
                    sistema.ActivoAdmin = dr.GetInt32("adm")
                Else
                    sistema = Nothing
                End If
            End Using
            Return sistema
        Catch ex As Exception
            Return Nothing
        Finally
            CloseDB()
        End Try
    End Function
    Public Function BuildShema(cod As String) As Boolean
        Try
            Dim cmd As MySqlCommand = CommandProcedure("sp_CreaTablasxEmp")
            cmd = Parameters(cmd, New String() {cod})
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            CloseDB()
        End Try

    End Function

End Class
