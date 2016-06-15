Imports MySql.Data.MySqlClient
Public Class ContenedorDAO
    Inherits BaseDao
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
