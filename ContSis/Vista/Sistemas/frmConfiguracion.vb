Imports Capa_Entidad
Imports Controladores
Imports Vista.BaseForm
Public Class frmConfiguracion
    Private reglas As New SistemaBL
    Private dtEmpresa As DataTable
    Private empresas As Empresa()
    Private proceso As Boolean = False
    Private totalproceso As Integer

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        dtEmpresa = New DataTable("empresa")
        dtEmpresa.Columns.Add("ruc")
        dtEmpresa.Columns.Add("rz")
        dtEmpresa.Columns.Add("rz_com")
        dtEmpresa.Columns.Add("estado", Type.GetType("System.String"))
        empresas = frmMain.Empresas
        dgvEmpresa.DataSource = dtEmpresa
        dgvEmpresa.Columns("rz_com").Visible = False
        dgvEmpresa.Columns("ruc").Visible = False
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles tsbsalir.Click
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
        CargarSistema()
        CargarEmpresa()
        CompletarDataGridViewEmpresa()
        stripbuttons(ToolStrip1)
    End Sub
    Private Sub CargarEmpresa()
        For i = 0 To empresas.Length - 1
            Dim dr As DataRow = dtEmpresa.NewRow
            dr("ruc") = empresas(i).RUC
            dr("rz") = empresas(i).Nombre
            dr("rz_com") = empresas(i).Aliass

            If reglas.ExistsEmpresa(empresas(i).RUC) Then
                dr("estado") = "Activo"
            Else
                dr("estado") = "Inactivo"
            End If
            dtEmpresa.Rows.Add(dr)
        Next
    End Sub
    Private Sub CompletarDataGridViewEmpresa()
        Dim rows As Integer
        Dim rowstotal As Integer = dgvEmpresa.Rows.Count
        rows = 5 - rowstotal
        If rows <> 0 Then
            For i = 1 To rows
                dtEmpresa.Rows.Add()
            Next
        End If
    End Sub

    Private Sub CargarSistema()
        Dim sistema As Sistema
        sistema = reglas.GetSistema
        'numEmpresas.Value = sistema.NroEmpresa
        numEmpresas.Value = empresas.Length
        numEmpresas.Enabled = False

        numUsuarios.Value = frmMain.NroUsuario
        numUsuarios.Enabled = False


        If sistema.ActivoAdmin > 0 Then
            chkAdmin.Checked = True
        Else
            chkAdmin.Checked = False
        End If

    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles tsbcrear.Click

        Dim envioForm As New EnvioConfiguracion
        envioForm.empresas = New DataView(dtEmpresa, "Estado='Inactivo'", "rz", DataViewRowState.CurrentRows)
        If envioForm.empresas.Count <= 0 Then
            MsgBox("Empresas operativas")
        Else
            tsbcrear.Enabled = False
            proceso = True
            pbConfiguracion.Visible = True
            totalproceso = CType(dtEmpresa.Compute("Count(ruc)", "Estado = 'Inactivo'"), Integer)
            lblCant.Text = String.Concat("1/", totalproceso)
            lblCant.Visible = True
            tmrConfiguracion.Start()
            bwConfiguracion.RunWorkerAsync(envioForm)
        End If

    End Sub

    Private Sub bwConfiguracion_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwConfiguracion.DoWork
        Dim env As EnvioConfiguracion = CType(e.Argument, EnvioConfiguracion)
        Dim c As Integer = 0
        For Each dr As DataRowView In env.empresas
            Dim reglas As New SistemaBL
            Dim empresa As New Empresa

            empresa.RUC = dr("ruc")
            empresa.Nombre = dr("rz")
            empresa.Aliass = dr("rz_com")
            reglas.RegistrarEmpresa(empresa)
            empresa = reglas.GeEmpresa(empresa.RUC)
            reglas.BuildShema(empresa.Codigo)
            c = c + 1
            bwConfiguracion.ReportProgress(c, empresa)
        Next
    End Sub

    Private Sub bwConfiguracion_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwConfiguracion.ProgressChanged
        pbConfiguracion.Value = 0
        tmrConfiguracion.Stop()
        tmrConfiguracion.Start()
        Dim empresa As Empresa = CType(e.UserState, Empresa)
        Dim resultados = From row In dtEmpresa.AsEnumerable
                         Where row.Field(Of String)("ruc") = empresa.RUC
                         Select row
        For Each dr As DataRow In resultados
            dr("Estado") = "Activo"
        Next

        lblCant.Text = String.Concat(e.ProgressPercentage + 1, "/", totalproceso)
    End Sub


    Private Sub bwConfiguracion_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwConfiguracion.RunWorkerCompleted

        tmrConfiguracion.Stop()
        lblCant.Visible = False
        pbConfiguracion.Visible = False
        tsbcrear.Enabled = True
        proceso = False
    End Sub

    Private Sub tmrConfiguracion_Tick(sender As Object, e As EventArgs) Handles tmrConfiguracion.Tick
        pbConfiguracion.PerformStep()
    End Sub

    Private Sub frmConfiguracion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If proceso Then
            e.Cancel = True
            MsgBox("El proceso no se completo", MsgBoxStyle.OkOnly, "Configuración")
        End If
    End Sub
End Class

Public Class EnvioConfiguracion
    Public empresas As DataView
End Class

