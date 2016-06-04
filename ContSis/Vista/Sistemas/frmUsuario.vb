
Imports Controladores
Imports Capa_Entidad
Public Class frmUsuario
#Region "Atributos"
    Dim reglas As New UsuarioBL
    Dim entidad As New Usuario
    Dim entidad2 As New Usuario
    Dim verificar As Integer
#End Region
#Region "Metodos"
#Region "Manejo Modulo"
    Public Sub CargarModulo()
        lbModulo.DataSource = reglas.getModulos
        lbModulo.DisplayMember = "name"
        lbModulo.ValueMember = "id"
    End Sub
    Public Sub CantModulo()

        lblNroModulo.Text = String.Concat("N° Modulo: ", lbModulo.Items.Count)
    End Sub
#End Region
#Region "Manejo Empresa"
    Public Sub CantEmpresa()
        lblNroEmpresa.Text = String.Concat("N° Empresa: ", lbEmpresa.Items.Count)
    End Sub
#End Region
#Region "Manejo Usuario"
    Public Sub CargarUsuario()
        dgvUsuarios.DataSource = Nothing
    End Sub
#End Region
#Region "Manejo Rol"
    Public Sub CargarRol()
        cborol.DataSource = reglas.getRoles
        cborol.DisplayMember = "name"
        cborol.ValueMember = "id"
    End Sub

#End Region



#End Region





    Public Sub limpiar()
        txtusu.Text = ""
        txtpass.Text = ""
        txtrepass.Text = ""
        cborol.Text = ""
    End Sub
    Private Sub Frm_RegUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarModulo()
        CargarRol()
        CantModulo()
        CantEmpresa()

        For i = 0 To 5
            dgvUsuarios.Rows.Add()
        Next
    End Sub
    Private Sub dgvUsuarios_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUsuarios.CellMouseDoubleClick
        txtusu.Text = dgvUsuarios.CurrentRow.Cells(1).Value
        cborol.Text = dgvUsuarios.CurrentRow.Cells(2).Value

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        limpiar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        With entidad
            .Usuario = txtusu.Text
            .Password = txtpass.Text
            .Rol = CInt(cborol.SelectedValue.ToString)
        End With
        If txtpass.Text = txtrepass.Text Then
            verificar = reglas.Usuario_RegisterLB(entidad)
        Else
            MsgBox("Las contraseñas deben coinsidir")
        End If

        With entidad2
            .Usuario = txtusu.Text
            .Password = txtpass.Text
            .Rol = CInt(cborol.SelectedValue.ToString)

        End With
        If txtpass.Text = txtrepass.Text Then
            verificar = reglas.Usuario_ActualizarLB(entidad2)
        Else
            MsgBox("Las contraseñas deben coinsidir")
        End If

        Try
            If verificar = 0 Then
                MsgBox("Registrado insatisfacotorio")
            Else
                MsgBox("Usuario Resgistrado")
                limpiar()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim f As New frmRol
        f.ShowDialog()
    End Sub

    Private Sub dgvUsuarios_RowEnter(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgvUsuarios_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUsuarios.CellMouseClick
        If IsNothing(dgvUsuarios.CurrentRow.Cells("ColUsuario").Value) Then
            cmsUsuario.Items("tsmiEliminar").Enabled = False
            cmsUsuario.Items("tsmiActualizar").Enabled = False
            dgvUsuarios.Columns.Item(e.ColumnIndex).ContextMenuStrip = cmsUsuario

        Else
            dgvUsuarios.Columns.Item(e.ColumnIndex).ContextMenuStrip = cmsUsuario
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Dim c As Integer
    Private Sub lbModulo_DataSourceChanged(sender As Object, e As EventArgs) Handles lbModulo.DataSourceChanged
        c += 1
        Debug.WriteLine("LblModulo-Event: DataSourceChanged : " & c)
    End Sub
End Class