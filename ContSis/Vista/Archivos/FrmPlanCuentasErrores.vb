Public Class FrmPlanCuentasErrores
    Private Sub Frm_PlanCuentas_Errores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = FrmPlanCuentasAdicional.dterror
        DataGridView1.Columns(0).Width = 250
        DataGridView1.Columns(1).Width = 100
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class