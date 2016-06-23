Imports Modelos
Imports Capa_Entidad
Public Class MonedaBL
    Dim Money As New MonedaDao
    Public Function Money_AllLB()
        Return Money.Moneda_all
    End Function
End Class
