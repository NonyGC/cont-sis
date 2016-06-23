Imports Modelos
Public Class CheckBL

    Public Shared Function CheckBD() As String
        Dim base As New BaseDao

        If base.CheckConexion Then
            Return "Conexión OK"
        Else
            Return "Conexión Error "
        End If
    End Function

End Class
