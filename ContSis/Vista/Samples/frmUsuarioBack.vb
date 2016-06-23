
Imports Controladores
Imports Capa_Entidad

Public Class frmUsuarioBack
    Private Sub tabRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabRoles.SelectedIndexChanged
        If tabRoles.SelectedIndex = 1 Then
            Dim c() As Control = {tvModuloSelect, tvModulo, cboEmpresas}
            Dim btn() As Control = {btnAgregarModT, btnAgregarMod, btnQuitarMod, btnQuitarModT}


            For i = 0 To btn.Length - 1
                btn(i).Enabled = False
            Next

            If lbEmpresaSelect.Items.Count <= 0 Then
                For i = 0 To c.Length - 1
                    c(i).Enabled = False
                    c(i).Cursor = Cursors.No

                Next
                lblMsg.Visible = True

            Else
                For i = 0 To c.Length - 1
                    c(i).Enabled = True
                    c(i).Cursor = Cursors.Hand
                Next
                lblMsg.Visible = False
            End If
        End If
    End Sub


End Class