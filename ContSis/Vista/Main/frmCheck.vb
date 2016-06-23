Imports System.Net.NetworkInformation
Imports Controladores.CheckBL
Public Class frmCheck
    Private mac As String
    Private sw As New Stopwatch
    Dim dmac As String = ""
    Dim c As Boolean = True
    Private Sub frmChecking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrChecking.Start()
        sw.Start()
        lblCheck.Text = CheckBD()
        'If "002586CEFCB7" <> getMacAddress() Then
        '    c = False
        '    tmrChecking.Stop()
        '    MsgBox("Computadora no Autorizada." & vbLf & "Contacte con el proveedor", MsgBoxStyle.OkOnly, "Informe")
        '    Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        'End If
    End Sub
    Private Function getMacAddress() As String
        Try
            Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
            Dim adapter As NetworkInterface
            Dim myMac As String = String.Empty

            For Each adapter In adapters
                Select Case adapter.NetworkInterfaceType
                    'Exclude Tunnels, Loopbacks and PPP
                    Case NetworkInterfaceType.Tunnel, NetworkInterfaceType.Loopback, NetworkInterfaceType.Ppp
                    Case Else
                        If Not adapter.GetPhysicalAddress.ToString = String.Empty And Not adapter.GetPhysicalAddress.ToString = "00000000000000E0" Then
                            myMac = adapter.GetPhysicalAddress.ToString
                            Exit For ' Got a mac so exit for
                        End If

                End Select
            Next adapter

            Return myMac
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function
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
