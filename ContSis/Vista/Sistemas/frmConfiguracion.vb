Imports Capa_Entidad
Imports Controladores
Public Class frmConfiguracion
    Private reglas As New SistemaBL
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim sistema As New Sistema
        With sistema
            .NroUsuario = CInt(numUsuarios.Value)
            .NroEmpresa = CInt(numUsuarios.Value)
            If chkAdmin.Checked Then
                .ActivoAdmin = 1
            Else
                .ActivoAdmin = 0
            End If
        End With
        Dim registro As Boolean = reglas.Registrar(sistema)
        If registro Then
            MsgBox("Completado", MsgBoxStyle.OkOnly, "Configuración")
        Else
            MsgBox("Ocurrio un Error", MsgBoxStyle.OkOnly, "Configuración")
        End If
    End Sub

    Private Sub frmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sistema As Sistema
        sistema = reglas.GetSistema
        numEmpresas.Value = sistema.NroUsuario
        numUsuarios.Value = sistema.NroEmpresa
        If sistema.ActivoAdmin > 0 Then
            chkAdmin.Checked = True
        Else
            chkAdmin.Checked = False
        End If
    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click

    End Sub
End Class