Imports Capa_Entidad
Imports Modelos
Public Class VencimientoPagoBL
    Public Function Registrar(vencimientoPago As VencimientoPagos) As Boolean
        Dim modelo As New VencimientoPagoDao(vencimientoPago)
        Dim respuestaVencimientoPago As New VencimientoPagos
        Dim respuestaCrud As Boolean
        respuestaVencimientoPago = modelo.GetByPeridoAndRuc()
        If respuestaVencimientoPago Is Nothing Then
            respuestaCrud = modelo.Crear()
        Else
            respuestaCrud = modelo.Actualizar()
        End If
        Return respuestaCrud
    End Function
    Public Function Eliminar(vencimientoPago As VencimientoPagos) As Boolean
        Dim modelo As New VencimientoPagoDao(vencimientoPago)
        Dim respuestaCrud As Boolean
        respuestaCrud = modelo.Elminar()
        Return respuestaCrud
    End Function
    Public Function ListVencimientoPago() As List(Of VencimientoPagos)
        Dim modelo As New VencimientoPagoDao()
        Return modelo.GetAll
    End Function
End Class
