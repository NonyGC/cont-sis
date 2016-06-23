Imports Modelos
Imports Capa_Entidad
Public Class VisoBL
    Inherits BaseBL
    Private formatos As New FormatoDao

    Public Sub CrearFormato_8_1(objEmpresa As Empresa, envio() As String, ByRef nroRegistro As Integer)
        Dim _desde As Date = Date.Parse(envio(1))
        Dim _hasta As Date = Date.Parse(envio(2))
        envio(1) = _desde.ToString("yyyy-MM-dd")
        envio(2) = _hasta.ToString("yyyy-MM-dd")
        formatos.CrearFormatoXMl_8_1(objEmpresa, envio, nroRegistro)
    End Sub

End Class
