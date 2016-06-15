Imports MySql.Data.MySqlClient
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

End Class
