Imports Modelos
Imports Capa_Entidad
Public Class MainBL
    Inherits BaseBL

    Public Sub UpdateUsuario(usuario As Usuario)
        Try
            Dim envio(4) As String
            envio = usuario.ArrayUsuario(5)
            ReDim Preserve envio(5)
            envio(5) = 4
            Dim objUsuarioDato As New UsuarioDao
            objUsuarioDato.UpdateSession(envio)
        Catch ex As Exception
            Debug.WriteLine("Error UpdateUsuario: " & usuario.Usuario & " - " & ex.ToString)
        End Try

    End Sub
    Public Function getMenus() As DataTable
        Dim maindao As New ContenedorDAO
        Return maindao.GetContenedorAll(0)
    End Function
    Public Function getOpciones(id As Integer) As DataTable
        Dim maindao As New FormularioDAO
        Return maindao.GetOpcionesxMenuId(id)
    End Function
    Public Function getOpcion(id As String) As Formulario
        Dim maindao As New FormularioDAO
        Return maindao.GetFormularioBDxDscp(id)
    End Function
    Public Function CheckTipoCambio(f As DateTime) As Boolean
        Dim rsp As Boolean = False
        Dim oTC As New TipoCambioDao
        Dim i As Integer
        Try
            i = oTC.CheckTipoCambio(f.ToString("yyyy-MM-dd"))
            If i = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Debug.WriteLine("ChekTipoCambio: " & ex.ToString)
            Return False
        End Try
        Return rsp
    End Function
End Class
