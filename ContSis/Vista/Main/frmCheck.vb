Imports Controladores.CheckBL
Public Class frmCheck
    Private mac As String
    Private sw As New Stopwatch
    Private Sub frmChecking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrChecking.Start()
        sw.Start()
        lblCheck.Text = CheckBD()
    End Sub

    Private Sub tmrChecking_Tick(sender As Object, e As EventArgs) Handles tmrChecking.Tick

        lblProceso.Text = (sw.ElapsedMilliseconds / 1000) & " %"
        Dim c As String = (sw.ElapsedMilliseconds \ 1000)
        Select Case c
            Case "1"
                Me.Opacity = 0.75
            Case "2"
                sw.Stop()
                tmrChecking.Stop()

                Dim frmLogeo As New frmLogeo()
                Me.Hide()
                frmLogeo.Show()
        End Select
    End Sub

End Class