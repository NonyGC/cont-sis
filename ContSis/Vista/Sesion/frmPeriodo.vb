Imports Vista.frmMain
Public Class frmPeriodo
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        validar()
    End Sub
    Sub validar()
        Dim s As String = ListBox1.SelectedItem
        _PeriodoMain = ListBox1.SelectedItem
        Dim f As frmMain = Application.OpenForms.Item("frmMain")
        f.PnlPeriodo(_PeriodoMain)
        f.pnlInfo.Visible = True
        Me.Dispose()

    End Sub

    Private Sub frmPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Focus()
        ListBox1.SelectedIndex = Now.Month
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        validar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class