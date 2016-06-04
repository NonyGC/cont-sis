Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class LoginDao
    Inherits BaseDao
    Private conexionValue As MySqlConnection
    Public Function logeo_D(ByVal EntLog As Usuario) As Integer
        'Variables 
        Dim sql As String = ""
        Dim verificar As Integer
        Dim commando As MySqlCommand
        'Logica
        conexionValue = Me.conexion
        sql = "Select count(usu_id) from usuarios where nombre=@usu and clave=@pass;"
        commando = New MySqlCommand(sql, conexionValue)
        With commando
            .Parameters.AddWithValue("@usu", EntLog.Usuario)
            .Parameters.AddWithValue("@pass", EntLog.Password)
        End With
        Try
            verificar = Convert.ToInt32(commando.ExecuteScalar)
        Catch ex As Exception
            verificar = 0
        Finally
            conexionValue.Close()
        End Try
        Return verificar
    End Function

    Public Function ResponseLogeo(envio() As String) As String()

        'Declaracion 
        Dim prm As New MySqlParameter
        Dim c As Integer = 0
        Dim dr As MySqlDataReader
        Dim arrayResp(0) As String


        Dim cmd As MySqlCommand = New MySqlCommand("sp_Response_Logeo", Me.conexion)
        cmd.CommandType = CommandType.StoredProcedure
        MySqlCommandBuilder.DeriveParameters(cmd)


        For Each prm In cmd.Parameters
            If prm.ParameterName <> "@RETURN_VALUE" Then
                prm.Value = envio(c)
                c = c + 1
            End If
        Next

        Try

            dr = cmd.ExecuteReader
            If dr.Read Then
                If dr.FieldCount = 1 Then
                    arrayResp(0) = dr.GetString(0)

                Else
                    ReDim arrayResp(4)

                    arrayResp(0) = dr.GetInt32(0)
                    arrayResp(1) = dr.GetInt32(1)
                    arrayResp(2) = dr.GetInt32(2)
                    arrayResp(3) = dr.GetString(3)
                    arrayResp(4) = dr.GetString(4)
                End If
            End If
            Return arrayResp
        Catch ex As Exception
            arrayResp(0) = "Fail"
            Return arrayResp
            MsgBox(ex.Message)
        Finally
            Me.conexion.Close()
        End Try
    End Function

End Class
