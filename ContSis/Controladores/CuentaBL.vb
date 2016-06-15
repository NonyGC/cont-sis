Imports Modelos
Imports Capa_Entidad
Public Class CuentaBL
    Dim Datos As New CuentaDAO
    Public Function Auxiliar_Autocompletado() As DataTable
        Return Datos.Auxiliar_Autocompletado()
    End Function
    Public Function Cuenta_Autocompletado_f() As DataTable
        Return Datos.Cuenta_Autocompletado_f()
    End Function
    Public Function Cuenta_Autocompletado(ByVal tabla As String, ByVal largo As String) As DataTable
        Return Datos.Cuenta_Showall(tabla, largo)
    End Function
    Public Function Cuenta_Autocompletado_destino(ByVal tabla As String, ByVal dest As String) As DataTable
        Return Datos.Cuenta_Showall_destino(tabla, dest)
    End Function
    Public Function Cuenta_Export(ByVal tabla As String) As DataTable
        Return Datos.Cuenta_Showall_Export(tabla)
    End Function
    Public Function Cuenta_DatosLB(ByVal tabla As String, ByVal entcont As Cuenta) As DataTable
        Return Datos.Cuenta_data(tabla, entcont)
    End Function
    Public Function Cuenta_RegisterLB(ByVal tabla As String, ByVal entcont As Cuenta) As Integer

        Dim verificar As Integer
        verificar = Datos.Cuenta_Register(tabla, entcont)
        Return verificar
    End Function
    Public Function Cuenta_Amarre_RegisterLB(ByVal tabla As String, ByVal cond As Integer, ByVal entcont As Cuenta) As Integer
        Dim verificar As Integer
        verificar = Datos.Cuenta_Amarre_Register(tabla, cond, entcont)
        Return verificar
    End Function
    Public Function Cuenta_ActualizarLB(ByVal tabla As String, ByVal entcont As Cuenta) As Integer
        Dim verificar As Integer
        verificar = Datos.Cuenta_Actualizar(tabla, entcont)
        Return verificar
    End Function
    Public Function Cuenta_BorrarLB(ByVal tabla As String, ByVal entcont As Cuenta)
        Dim verificar As Integer
        verificar = Datos.Cuenta_Borrar(tabla, entcont)
        Return verificar
    End Function

    Public Function Tcomprobante_DatosLB() As DataSet
        Dim tablas As DataSet
        tablas = Datos.TComprobante_Showall()
        Tcomprobante_DatosLB = tablas
    End Function
    Public Function Cuenta_Amarre_ShowLB(ByVal tabla As String, ByVal entcont As Cuenta) As DataTable
        Return Datos.Cuenta_Amarre_Show(tabla, entcont)
    End Function
End Class
