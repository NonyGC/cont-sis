
Imports Controladores
Imports Capa_Entidad
Imports Vista.BaseForm
Imports System.Threading
Public Class frmUsuario
#Region "Atributos"
    Private rgls As New UsuarioBL
    Private usu As Usuario
    Private cnfg As Sistema
    Private back As New frmUsuarioBack
    Private ds As DataSet
    Private dtEmpresa As DataTable
    Private dtEmpresaSelect As DataTable
    Dim verificar As Integer
#End Region
#Region "Constructores"
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        With back
            .TopLevel = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .Dock = DockStyle.Fill
        End With
        pnlUsuario.Controls.Add(back)

        ds = rgls.Modulo
        dtEmpresa = ds.Tables("empresa")
        dtEmpresaSelect = ds.Tables("empresa_select")

        AddHandler back.btnFront.Click, AddressOf Front
        AddHandler back.btnAgregar.Click, AddressOf btnAgregarEmpresa
        AddHandler back.btnAgregarT.Click, AddressOf btnAgregarTodoEmpresa
        AddHandler back.btnQuitar.Click, AddressOf btnQuitarEmpresa
        AddHandler back.btnQuitarT.Click, AddressOf btnQuitarTodoEmpresa
        AddHandler back.btnAgregarMod.Click, AddressOf btnAgregarModulo
        AddHandler back.btnAgregarModT.Click, AddressOf btnAgregarTodoModulo
        AddHandler back.btnQuitarMod.Click, AddressOf btnQuitarModulo
        AddHandler back.btnQuitarModT.Click, AddressOf btnQuitarTodoModulo

        AddHandler back.tvModuloSelect.Enter, AddressOf tvModuloSelect_Enter
        AddHandler back.tvModulo.Enter, AddressOf tvModulo_Enter

        AddHandler back.cboEmpresas.SelectedIndexChanged, AddressOf cboEmpresas_SelectedIndexChanged


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
#End Region

#Region "Front"
#Region "Metodos"
#Region "Manejo Modulo"
    Public Sub CargarModulo()
        lbModulo.DataSource = rgls.getModulos
        lbModulo.DisplayMember = "name"
        lbModulo.ValueMember = "id"
    End Sub
    Public Sub CantModulo()

        lblNroModulo.Text = String.Concat("N° Modulo: ", lbModulo.Items.Count)
    End Sub
    Private Sub CargarModuloBack()
        Dim dt As DataTable = ds.Tables("modulo")
        For Each row As DataRow In dt.Rows
            Dim tn = New TreeNode(row.Item("name"))
            tn.Name = row.Item("id")
            back.tvModulo.Nodes.Add(tn)
            Dim childnode As New TreeNode()
            For Each childrow As DataRow In row.GetChildRows("Mod")
                childnode = tn.Nodes.Add(childrow("name"))
                childnode.Name = childrow("id")
            Next
        Next
    End Sub
    Private Sub CargarModuloBack(names As String())
        Dim dt As DataTable = ds.Tables("modulo")
        For Each row As DataRow In dt.Rows


            Dim tn = New TreeNode(row.Item("name"))
            tn.Name = row.Item("id")
            back.tvModulo.Nodes.Add(tn)
            Dim childnode As New TreeNode()
            For Each childrow As DataRow In row.GetChildRows("Mod")
                childnode = tn.Nodes.Add(childrow("name"))
                childnode.Name = childrow("id")
            Next

        Next
    End Sub
#End Region
#Region "Manejo Empresa"
    Public Sub CantEmpresa()
        lblNroEmpresa.Text = String.Concat("N° Empresa: ", lbEmpresa.Items.Count)
    End Sub
    Private Sub CargarEmpresa()
        lbEmpresa.DataSource = ds.Tables("empresa")
        lbEmpresa.DisplayMember = "name"
        lbEmpresa.ValueMember = "id"
    End Sub
    Private Sub CargarEmpresaBack()
        back.lbEmpresa.DataSource = dtEmpresa
        back.lbEmpresa.DisplayMember = "name"
        back.lbEmpresa.ValueMember = "id"
    End Sub
    Private Sub CargarStateEmpresa()
        back.lbStateEmpresa.DataSource = dtEmpresaSelect
        back.lbStateEmpresa.DisplayMember = "NameState"
        back.lbStateEmpresa.ValueMember = "id"
    End Sub
#End Region
#Region "Manejo Usuario"
    Public Sub CargarUsuario()
        dgvUsuarios.DataSource = Nothing
    End Sub

#End Region
#Region "Manejo Rol"
#End Region


#End Region
#Region "Eventos Form"
    Private Sub Frm_RegUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarModulo()
        CantModulo()
        CargarModuloBack()
        CargarEmpresaBack()
        CargarEmpresaSelect()
        CargarEmpresa()
        CantEmpresa()
        EnabledEmpresa()
        CargarCboEmpresa()
        CargarStateEmpresa()
        lblUsuario.Text = rgls.NewUsuario
        For i = 0 To 6
            dgvUsuarios.Rows.Add()
        Next
    End Sub
#End Region

    Public Sub limpiar()
        txtUsuario.Text = ""
        txtPassword.Text = ""
        txtRPassword.Text = ""
        rbActivo.Checked = True



    End Sub

    Private Sub dgvUsuarios_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUsuarios.CellMouseDoubleClick
        txtUsuario.Text = dgvUsuarios.CurrentRow.Cells(1).Value

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs)
        Nuevo()
    End Sub
    Private Sub Nuevo()
        limpiar()
        txtUsuario.Enabled = True
        txtPassword.Enabled = True
        txtRPassword.Enabled = True
    End Sub

    Private Sub Front()
        pnlFront.Visible = True
        back.Hide()
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlFront.Visible = False
        back.Show()


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



    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        ActivarEnabled()
    End Sub
    Private Sub ActivarEnabled()
        Dim txt() As TextBox = {txtUsuario, txtPassword, txtRPassword}
        Dim c As Integer
        If rtxtMsg.Visible Then
            rtxtMsg.Visible = False
        End If
        For i = 0 To txt.Length - 1
            If txt(i).Text.Trim.Length >= 5 Then
                c += 1
            End If
        Next
        If c = txt.Length Then
            'If cborol.SelectedIndex <> 0 Then
            btnBack.Enabled = True
            'End If
        Else
            btnBack.Enabled = False
        End If

    End Sub
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        ActivarEnabled()
    End Sub

    Private Sub txtRPassword_TextChanged(sender As Object, e As EventArgs) Handles txtRPassword.TextChanged
        ActivarEnabled()
    End Sub


    Private Sub frmUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Control Then
            If e.KeyCode = Keys.N Then
                Nuevo()
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkPassword.CheckedChanged
        If chkPassword.Checked Then
            txtPassword.PasswordChar = String.Empty
            txtRPassword.PasswordChar = String.Empty
        Else
            txtPassword.PasswordChar = "*"c
            txtRPassword.PasswordChar = "*"c
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Mantenimiento_Enter(sender As Object, e As EventArgs) Handles Mantenimiento.Enter

    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        btnGuardar.Enabled = False
        Dim usu As Usuario

        usu = New UsuarioNormal

        With usu
            .Id = txtCodigo.Text
            .Usuario = txtUsuario.Text
            .Password = txtPassword.Text
        End With

        If rbActivo.Checked Then
            usu.State = 1
        Else
            usu.State = 0
        End If

        If rgls.Registrar(usu, txtRPassword.Text) Then
            MsgBox("Registro completo")

        Else
            rtxtMsg.Text = rgls.Log
            rtxtMsg.Visible = True

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmUsuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        back.Close()
    End Sub

#End Region
#Region "Back"
#Region "EmpresaSelect"
    Private Sub EnabledEmpresa()
        If back.lbEmpresa.Items.Count = 0 Then
            back.btnAgregar.Enabled = False
            back.btnAgregarT.Enabled = False
        Else
            back.btnAgregar.Enabled = True
            back.btnAgregarT.Enabled = True
        End If

        If back.lbEmpresaSelect.Items.Count = 0 Then
            back.btnQuitar.Enabled = False
            back.btnQuitarT.Enabled = False
        Else
            back.btnQuitar.Enabled = True
            back.btnQuitarT.Enabled = True
        End If
    End Sub
    Private Sub btnQuitarEmpresa(sender As Object, e As EventArgs)
        Dim dr As DataRow = dtEmpresa.NewRow
        Dim dv As DataRowView
        dv = back.lbEmpresaSelect.SelectedItem
        dr("id") = dv.Row("id")
        dr("name") = dv.Row("name")

        dtEmpresa.Rows.Add(dr)
        dtEmpresaSelect.Rows.Remove(dv.Row)
        EnabledEmpresa()
    End Sub
    Private Sub btnQuitarTodoEmpresa(sender As Object, e As EventArgs)
        For Each dr As DataRow In dtEmpresaSelect.Rows
            Dim nr As DataRow = dtEmpresa.NewRow
            nr("id") = dr("id")
            nr("name") = dr("name")
            dtEmpresa.Rows.Add(nr)
        Next
        dtEmpresaSelect.Rows.Clear()
        EnabledEmpresa()
    End Sub
    Private Sub btnAgregarEmpresa(sender As Object, e As EventArgs)

        Dim dr As DataRow = dtEmpresaSelect.NewRow
        Dim dv As DataRowView
        dv = back.lbEmpresa.SelectedItem
        dr("id") = dv.Row("id")
        dr("name") = dv.Row("name")
        dr("state") = False
        dr("NameState") = dr("name") & ": Falta"
        dtEmpresaSelect.Rows.Add(dr)
        dtEmpresa.Rows.Remove(dv.Row)
        EnabledEmpresa()
    End Sub
    Private Sub btnAgregarTodoEmpresa(sender As Object, e As EventArgs)

        For Each dr As DataRow In dtEmpresa.Rows
            Dim nr As DataRow = dtEmpresaSelect.NewRow
            nr("id") = dr("id")
            nr("name") = dr("name")
            dr("state") = False
            dr("NameState") = dr("name") & ": Falta"
            dtEmpresaSelect.Rows.Add(nr)
        Next

        dtEmpresa.Rows.Clear()
        EnabledEmpresa()
    End Sub
    Private Sub CargarEmpresaSelect()
        back.lbEmpresaSelect.DataSource = dtEmpresaSelect
        back.lbEmpresaSelect.DisplayMember = "name"
        back.lbEmpresaSelect.ValueMember = "id"
    End Sub
    Private Sub CargarCboEmpresa()
        back.cboEmpresas.DataSource = dtEmpresaSelect
        back.cboEmpresas.DisplayMember = "name"
        back.cboEmpresas.ValueMember = "id"
    End Sub
#End Region
#Region "ModuloSelect"
#Region "Enabled"
    Private Sub EnabledModuloAgregar()
        If back.tvModulo.Nodes.Count = 0 Then
            back.btnAgregarMod.Enabled = False
            back.btnAgregarModT.Enabled = False
        Else
            back.btnAgregarMod.Enabled = True
            back.btnAgregarModT.Enabled = True
        End If
    End Sub
    Private Sub EnabledModuloQuitar()
        If back.tvModuloSelect.Nodes.Count = 0 Then
            back.btnQuitarMod.Enabled = False
            back.btnQuitarModT.Enabled = False
        Else
            back.btnQuitarMod.Enabled = True
            back.btnQuitarModT.Enabled = True
        End If
    End Sub
#End Region
#Region "Quitar"
    Private Sub btnQuitarModulo(sender As Object, e As EventArgs)
        Dim tn As TreeNode = back.tvModuloSelect.SelectedNode
        If Not IsNothing(tn) Then
            If tn.Nodes.Count = 0 Then
                back.tvModuloSelect.Nodes.Remove(tn.Parent)
                back.tvModulo.Nodes.Add(tn.Parent)
                QuitarPermiso(New Permiso(rgls.NewPermiso, tn.Parent.Name))
            Else
                back.tvModuloSelect.Nodes.Remove(tn)
                back.tvModulo.Nodes.Add(tn)
                QuitarPermiso(New Permiso(rgls.NewPermiso, tn.Name))

            End If
            EnabledModuloQuitar()
        End If
    End Sub
    Private Sub btnQuitarTodoModulo(sender As Object, e As EventArgs)
        For Each tn As TreeNode In back.tvModuloSelect.Nodes
            Dim tnt As TreeNode = tn.Clone

            If Not IsNothing(tnt) Then
                back.tvModulo.Nodes.Add(tnt)
            End If
        Next
        QuitarPermisoTodo(New Permiso(rgls.NewPermiso, ""))
        back.tvModuloSelect.Nodes.Clear()
        EnabledModuloQuitar()
    End Sub
#End Region
#Region "Agregar"
    Private Sub btnAgregarModulo(sender As Object, e As EventArgs)
        Dim tn As TreeNode = back.tvModulo.SelectedNode
        If Not IsNothing(tn) Then
            If tn.Nodes.Count = 0 Then
                back.tvModulo.Nodes.Remove(tn.Parent)
                back.tvModuloSelect.Nodes.Add(tn.Parent)
                AgregarPermiso(New Permiso(rgls.NewPermiso, rgls.NewUsuario, back.cboEmpresas.SelectedValue, False, tn.Parent.Name))
            Else
                back.tvModulo.Nodes.Remove(tn)
                back.tvModuloSelect.Nodes.Add(tn)
                AgregarPermiso(New Permiso(rgls.NewPermiso, rgls.NewUsuario, back.cboEmpresas.SelectedValue, False, tn.Name))

            End If
            EnabledModuloAgregar()
        End If
    End Sub

    Private Sub btnAgregarTodoModulo(sender As Object, e As EventArgs)
        For Each tn As TreeNode In back.tvModulo.Nodes
            Dim tnt As TreeNode = tn.Clone
            If Not IsNothing(tnt) Then
                back.tvModuloSelect.Nodes.Add(tnt)
            End If
        Next
        back.tvModulo.Nodes.Clear()
        AgregarPermisoTodo(New Permiso(rgls.NewPermiso, rgls.NewPermiso, back.cboEmpresas.SelectedValue, True, ""))
        EnabledModuloAgregar()
    End Sub
#End Region


#Region "AgregarPermisoData"
    Private Sub AgregarPermiso(permiso As Permiso)
        Dim dr As DataRow
        dr = ds.Tables("permiso").Rows.Find(permiso.Empresa)
        If IsNothing(dr) Then
            dr = ds.Tables("permiso").NewRow
            dr("emp") = permiso.Empresa
            dr("usu") = permiso.Usuario
            dr("compt") = permiso.Completo
            dr("mod") = permiso.Modulos(dr("mod").ToString)
            ds.Tables("permiso").Rows.Add(dr)
        Else
            dr("mod") = permiso.Modulos(dr("mod").ToString)
        End If
    End Sub
    Private Sub AgregarPermisoTodo(permiso As Permiso)
        Dim dr As DataRow
        dr = ds.Tables("permiso").Rows.Find(permiso.Empresa)
        If IsNothing(dr) Then
            dr = ds.Tables("permiso").NewRow
            dr("emp") = permiso.Empresa
            dr("usu") = permiso.Usuario
            dr("compt") = permiso.Completo
            dr("mod") = permiso.Modulos()
            ds.Tables("permiso").Rows.Add(dr)
        Else
            dr("compt") = permiso.Completo
            dr("mod") = permiso.Modulos()
        End If
    End Sub
#End Region

#Region "QuitarPermisoData"
    Private Sub QuitarPermiso(permiso As Permiso)
        Dim dr As DataRow
        dr = ds.Tables("permiso").Rows.Find(permiso.Empresa)
        dr("mod") = permiso.QuitarModulo(dr("mod").ToString)
    End Sub
    Private Sub QuitarPermisoTodo(permiso As Permiso)
        Dim dr As DataRow
        dr = ds.Tables("permiso").Rows.Find(permiso.Empresa)
        ds.Tables("permiso").Rows.Remove(dr)
    End Sub
#End Region


    Private Sub tvModulo_Enter(sender As Object, e As EventArgs)
        If back.tvModulo.Nodes.Count > 0 Then

            back.btnAgregarMod.Enabled = True
            back.btnAgregarModT.Enabled = True
        End If
        back.btnQuitarMod.Enabled = False
        If back.tvModuloSelect.Nodes.Count = 0 Then
            back.btnQuitarModT.Enabled = False
        End If
    End Sub
    Private Sub tvModuloSelect_Enter(sender As Object, e As EventArgs)
        If back.tvModuloSelect.Nodes.Count > 0 Then
            back.btnQuitarMod.Enabled = True
            back.btnQuitarModT.Enabled = True
        End If


        back.btnAgregarMod.Enabled = False
        If back.tvModulo.Nodes.Count = 0 Then
            back.btnAgregarModT.Enabled = False
        End If

    End Sub
#End Region
#Region "CboEmpresa"
    Private Sub cboEmpresas_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Not IsNothing(back.cboEmpresas.SelectedValue) Then
            Dim dr As DataRow = ds.Tables("permiso").Rows.Find(back.cboEmpresas.SelectedValue.ToString)
            If Not IsNothing(dr) Then
                Dim modulos() As String = ModulosArray(dr("mod"))
            End If

        End If
    End Sub
    Private Function ModulosArray(value As String) As String()
        Dim continua As Boolean = True
        Dim c As Integer = 0
        Dim array(0) As String

        While continua
            Dim startcadena As Integer = value.IndexOf("[", c)
            Dim endcadena As Integer
            Dim val As String

            If startcadena < 0 Then
                continua = False

            Else
                endcadena = value.IndexOf("]", startcadena)
                val = value.Substring(startcadena + 1, endcadena - (startcadena + 1))
                array(c) = val

                If c = array.Length - 1 Then
                    ReDim Preserve array(c + 1)
                End If

                c = c + 1
            End If
        End While
        Return array
    End Function
#End Region
#End Region



End Class