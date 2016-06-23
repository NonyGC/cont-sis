Imports Modelos
Imports Capa_Entidad
Public Class TipoCambioBL
    Dim tipocambiodao As New TipoCambioDao
    Public Function TCambio_AllLB()
        Return tipocambiodao.TCambio_all
    End Function
    Public Function TCambio_All_cboLB()
        Return tipocambiodao.TCambio_all_cbo
    End Function
    Public Function TCambio_DatosLB(ByVal entTC As TipoCambio) As DataTable
        Return tipocambiodao.TCambio_data(entTC)
    End Function
    Public Function TCambio_Datos_IncompletosLB(ByVal entTC As TipoCambio) As DataTable
        Return tipocambiodao.TCambio_data_incompleta(entTC)
    End Function
    Public Function TCambio_RegisterLB(ByVal entTC As TipoCambio)
        Dim verificar As Integer
        verificar = tipocambiodao.TCambio_Register(entTC)
        Return verificar
    End Function
    Public Function TCambio_ActualizarLB(ByVal entTC As TipoCambio)
        Dim verificar As Integer
        verificar = tipocambiodao.TCambio_Actualizar(entTC)
        Return verificar
    End Function

    Public Function TCambio_Verificar(f As Date) As Integer
        Dim state As Integer
        state = tipocambiodao.TCambio_Estado(f.ToString("yyyy-MM-dd"))
        Return state
    End Function
End Class
