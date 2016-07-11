Imports Capa_Entidad
Imports Vista.BaseForm
Imports Controladores
Imports Controladores.ListasBL
Imports Controladores.LoginBL
Public Class frmLogeo
#Region "Atributos"
    Private _estado As listForm
    Private _f As frmMain

#End Region
#Region "Propiedades"

#End Region
#Region "Contructor"
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

#End Region
#Region "Metodos"
    Private Sub accionLogeo()

        Try
            Dim objLoginBL = New LoginBL
            frmMain.UsuarioMain = objLoginBL.ResponseLogeo(txtusu.Text, txtpass.Text)

            If objLoginBL.Respuesta = "ok" Then
                Dim frm As frmMain
                Select Case _estado
                    Case listForm.Dependiente
                        Me.Hide()
                        CargarActionUsuario()
                        frm = Application.OpenForms.Item("frmMain")
                        If frmMain.UsuarioMain.Tipo = "admin" Then
                            frm.ActionAdmin()
                        End If
                        frm.State = listForm.Independiente

                    Case listForm.Independiente
                        CargarActionUsuario()
                        frm = New frmMain
                        frm.lblUsuario.Text = frmMain.UsuarioMain.Impresion
                        Me.Hide()
                        frm.Show()

                End Select
            Else
                MsgBox(objLoginBL.Respuesta, MsgBoxStyle.OkOnly, "Logeo")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub ControlAcceso()
        If txtusu.Text.Trim.Length = 0 Then
            btnlogin.Enabled = False
        Else
            If txtpass.Text.Trim.Length = 0 Then
                btnlogin.Enabled = False
            Else
                btnlogin.Enabled = True
            End If
        End If
    End Sub
    Private Sub CargarActionUsuario()
        Select Case frmMain.UsuarioMain.Tipo
            Case "normal"
                frmMain.Action = listUsuario.Normal
            Case "admin"
                frmMain.Action = listUsuario.Admin
            Case "master"
                frmMain.Action = listUsuario.Master
        End Select
    End Sub
#End Region
#Region "Eventos"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If btnlogin.Enabled Then
            Me.accionLogeo()
        End If
    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
    Private Sub txtusu_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusu.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnlogin.Enabled Then
                Me.accionLogeo()
            End If
        End If
    End Sub
    Private Sub txtpass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnlogin.Enabled Then
                Me.accionLogeo()
            End If

        End If
    End Sub
    Private Sub txtusu_TextChanged(sender As Object, e As EventArgs) Handles txtusu.TextChanged
        ControlAcceso()
    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged
        ControlAcceso()
    End Sub
    Private Sub Frm_Logeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IsNothing(Me.MdiParent) Then
            _estado = listForm.Independiente
            CloseForm("frmCheck")
        Else
            _estado = listForm.Dependiente
            _f = DirectCast(Me.MdiParent, frmMain)
            _f.SSForm("Logear")
            _f.SSActionForm("Enter O Click para Ingresar")
        End If
    End Sub

    Private Sub frmLogeo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If _estado = listForm.Dependiente Then
            _f.SSForm()
            _f.SSActionForm()
        End If

    End Sub

#End Region


End Class