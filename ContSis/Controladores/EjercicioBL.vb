Imports Modelos
Imports Capa_Entidad
Public Class EjercicioBL
    Dim ejerciciodao As New EjercicioDao
    Public Function ExistsTablaByBL(tabla As String, ByRef men As String) As Boolean
        Dim verificar As Integer
        verificar = ejerciciodao.ExistsTablaBy(tabla, men)
        Return verificar
    End Function

End Class
