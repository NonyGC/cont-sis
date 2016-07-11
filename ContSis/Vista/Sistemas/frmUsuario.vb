
Imports Controladores
Imports Capa_Entidad
Imports Vista.BaseForm
Imports System.Threading
Public Class frmUsuario
#Region "Atributos"
    Private rgls As New UsuarioBL(frmMain.Empresas)
    Private usu As Usuario
    Private cnfg As Sistema
    Private back As New frmUsuarioBack
    Private dtEmpresa As DataTable
    Private dtUsuario As DataTable
    Private controlAgregarModulo As Boolean = False
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

        dtEmpresa = rgls.DataSetUsuario.Tables("empresa_activa")
        dtEmpresaSelect = rgls.DataSetUsuario.Tables("empresa_permiso_select")
        dtUsuario = rgls.UsuariosAll
#Region "Mapeando Eventos"
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

        AddHandler back.cboEmpresas.SelectedValueChanged, AddressOf cboEmpresas_SelectedValueChanged
        AddHandler back.lbEmpresaSelect.DoubleClick, AddressOf lbEmpresaSelect_DoubleClick
#End Region

    End Sub
    Private Sub Frm_RegUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarModuloBackAll()
        CargarEmpresaSelect()
        CargarUsuario()
        CargarCboEmpresa()
        CargarDataSourceOfListBox()
        stripbuttons(ToolStrip1)
    End Sub
    Private Sub frmUsuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        back.Close()
    End Sub

#End Region
#Region "Front"
#Region "Metodos"
#Region "Manejo Modulo"
    Private Sub CargarDataSourceOfListBox()
        AgregarDataSource(lbModuloUsuario, rgls.DataSetUsuario.Tables("modulo_usuario"), "name", "id")
        AgregarDataSource(lbEmpresaActivosUsuario, rgls.DataSetUsuario.Tables("empresa_usuario"), "rz_elegido", "id")
        AgregarDataSource(lbEmpresaInactivos, rgls.DataSetUsuario.Tables("empresa_inactiva"), "rz_elegido", "id")
        AgregarDataSource(back.lbStateEmpresa, dtEmpresaSelect, "NameState", "id")
        AgregarDataSource(back.lbEmpresa, dtEmpresa, "rz_elegido", "id")
        AgregarDataSource(back.lbStateEmpresaFront, dtEmpresaSelect, "NameState", "id")


        lblEmpresaCantInactivas.Text = String.Concat("N° Empresa: ", lbEmpresaInactivos.Items.Count)
        lblEmpresaCantActivas.Text = String.Concat("N° Empresa: ", lbEmpresaActivosUsuario.Items.Count)
        lblNroModulo.Text = String.Concat("N° Modulo: ", lbModuloUsuario.Items.Count)

    End Sub
    Private Sub AgregarDataSource(listControl As ListControl, dataSource As Object, ParamArray ByVal displayAndValue() As String)
        listControl.DataSource = dataSource
        listControl.DisplayMember = displayAndValue(0)
        listControl.ValueMember = displayAndValue(1)
    End Sub
    Private Sub CargarModuloBackAll()
        CargarTreeViewAll(back.tvModulo)
    End Sub
    Private Sub CargarModuloSelectAll()
        CargarTreeViewAll(back.tvModuloSelect)
    End Sub

    Private Sub CargarTreeViewAll(treeView As TreeView)
        Dim dt As DataTable = rgls.DataSetUsuario.Tables("modulo")
        For Each row As DataRow In dt.Rows
            Dim tn = New TreeNode(row.Item("name"))
            tn.Name = row.Item("id")
            treeView.Nodes.Add(tn)
            Dim childnode As New TreeNode()
            For Each childrow As DataRow In row.GetChildRows("Mod")
                childnode = tn.Nodes.Add(childrow("name"))
                childnode.Name = childrow("id")
            Next
        Next
    End Sub
    Private Sub CargarModuloSelectBackByName(name As String)
        If name IsNot Nothing Then
            Dim dr As DataRow = rgls.DataSetUsuario.Tables("modulo").Rows.Find(name)
            Dim tn As New TreeNode(dr.Item("Name"))
            tn.Name = dr.Item("Id")
            back.tvModuloSelect.Nodes.Add(tn)
            Dim childnode As New TreeNode()
            For Each childrow As DataRow In dr.GetChildRows("Mod")
                childnode = tn.Nodes.Add(childrow("Name"))
                childnode.Name = childrow("Id")
            Next
        End If

    End Sub
    Private Sub CargarModuloBackByListString(list As String)
        Dim dt As DataTable = rgls.DataSetUsuario.Tables("modulo")
        For Each row As DataRow In dt.Rows
            If Not list.Contains(row.Item("id")) Then
                Dim tn = New TreeNode(row.Item("name"))
                tn.Name = row.Item("id")
                back.tvModulo.Nodes.Add(tn)
                Dim childnode As New TreeNode()
                For Each childrow As DataRow In row.GetChildRows("Mod")
                    childnode = tn.Nodes.Add(childrow("name"))
                    childnode.Name = childrow("id")
                Next
            End If
        Next

    End Sub



    Private Sub LimpiarModuloBackAll()
        back.tvModulo.Nodes.Clear()
    End Sub
    Private Sub LimpiarModuloSelectBackAll()
        back.tvModuloSelect.Nodes.Clear()
    End Sub

#End Region

#Region "Manejo Usuario"
    Public Sub CargarUsuario()
        dgvUsuarios.DataSource = dtUsuario
        If dtUsuario.Rows.Count < 10 Then
            For i = 1 To 10 - dtUsuario.Rows.Count
                dtUsuario.Rows.Add()
            Next
        End If
    End Sub

#End Region

#End Region

    Public Sub limpiar()
        txtUsuario.Text = ""
        txtPassword.Text = ""
        txtRPassword.Text = ""
        rbActivo.Checked = True
    End Sub

    Private Sub dgvUsuarios_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUsuarios.CellMouseDoubleClick
        Dim cap = dgvUsuarios.CurrentRow.Cells(0).Value
        Dim id As Integer = If(cap IsNot DBNull.Value, cap, 0)
        If id > 0 Then
            rgls.UpdateDataTableDtEmpresaAndDtModulo(id)
        End If
    End Sub

    Private Sub Front()
        pnlFront.Visible = True
        back.Hide()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlFront.Visible = False
        back.Show()
    End Sub

    Private Sub dgvUsuarios_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUsuarios.CellMouseClick
        If dgvUsuarios.CurrentRow.Cells("ColUsuario").Value Is DBNull.Value Then
            cmsUsuario.Items("tsmiEliminar").Enabled = False
            cmsUsuario.Items("tsmiActualizar").Enabled = False
            dgvUsuarios.Columns.Item(e.ColumnIndex).ContextMenuStrip = cmsUsuario

        Else
            cmsUsuario.Items("tsmiEliminar").Enabled = True
            cmsUsuario.Items("tsmiActualizar").Enabled = True
            dgvUsuarios.Columns.Item(e.ColumnIndex).ContextMenuStrip = cmsUsuario
        End If
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged, txtPassword.TextChanged, txtRPassword.TextChanged
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
            btnBack.Enabled = True
        Else
            btnBack.Enabled = False
        End If

    End Sub

    Private Sub frmUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Control Then
            If e.KeyCode = Keys.N Then
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
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles tsbguardar.Click
        Dim nroUsuario As Integer = frmMain.NroUsuario
        If nroUsuario = (dgvUsuarios.Rows.Count + 1) Then
            MsgBox(String.Format("Solo puede usar {0} usuario.", If(nroUsuario = 1, nroUsuario, nroUsuario - 1)), MsgBoxStyle.OkOnly, "Registro de Usuarios")
            Exit Sub
        End If
        tsbguardar.Enabled = False
        ' btnGuardar.BackgroundImage = Global.Vista.My.Resources.Resources.guardar_false

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
        Dim respuestaRegistrar As Boolean
        If txtCodigo.Text = String.Empty Then
            respuestaRegistrar = rgls.Registrar(usu, txtRPassword.Text)
        Else
            respuestaRegistrar = rgls.ActualizarUsuario(usu, txtRPassword.Text)
        End If
        If respuestaRegistrar Then
            MsgBox("Registro completo")
            RegresarComoNuevaOperacion()
        Else
            rtxtMsg.Text = rgls.Log
            rtxtMsg.Visible = True
            tsbguardar.Enabled = True
            'btnGuardar.BackgroundImage = Global.Vista.My.Resources.Resources.guardar_true
        End If
    End Sub
    Private Sub RegresarComoNuevaOperacion()
        txtCodigo.Text = String.Empty
        txtUsuario.Text = String.Empty
        txtPassword.Text = String.Empty
        txtRPassword.Text = String.Empty
        rbActivo.Checked = True
        rbActivo.Enabled = False
        rbInactivo.Enabled = False
        dtEmpresaSelect.Rows.Clear()
        dtUsuario = rgls.UsuariosAll
        CargarUsuario()
        rgls.UpdateDataDtEmpresa()
        CargarModuloBackAll()
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
        Dim dv As DataRowView = back.lbEmpresaSelect.SelectedItem
        If dv Is Nothing Then Exit Sub
        Dim dr As DataRow = dtEmpresa.NewRow
        dr("id") = dv.Row("Id")
        dr("rz_elegido") = dv.Row("Name")

        dtEmpresa.Rows.Add(dr)
        dtEmpresaSelect.Rows.Remove(dv.Row)

        EnabledEmpresa()

    End Sub
    Private Sub btnQuitarTodoEmpresa(sender As Object, e As EventArgs)
        For Each dr As DataRow In dtEmpresaSelect.Rows
            Dim nr As DataRow = dtEmpresa.NewRow
            nr("id") = dr("Id")
            nr("rz_elegido") = dr("Name")
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
        dr("name") = dv.Row("rz_elegido")
        dr("state") = False
        dr("compt") = False
        dtEmpresaSelect.Rows.Add(dr)
        dtEmpresa.Rows.Remove(dv.Row)
        EnabledEmpresa()
    End Sub
    Private Sub btnAgregarTodoEmpresa(sender As Object, e As EventArgs)

        For Each dr As DataRow In dtEmpresa.Rows
            Dim ndr As DataRow = dtEmpresaSelect.NewRow
            ndr("id") = dr("id")
            ndr("name") = dr("rz_elegido")
            ndr("state") = False
            ndr("compt") = False
            ndr("NameState") = ndr("name") & ": Falta"
            dtEmpresaSelect.Rows.Add(ndr)
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
                QuitarPermiso(back.lbEmpresaSelect.SelectedValue, New Permiso(1, tn.Parent.Name))
            Else
                back.tvModuloSelect.Nodes.Remove(tn)
                back.tvModulo.Nodes.Add(tn)
                QuitarPermiso(back.lbEmpresaSelect.SelectedValue, New Permiso(1, tn.Name))

            End If
            EnabledModuloQuitar()
        End If
    End Sub
    Private Sub btnQuitarTodoModulo(sender As Object, e As EventArgs)
        For Each tn As TreeNode In back.tvModuloSelect.Nodes
            If tn IsNot Nothing Then
                back.tvModulo.Nodes.Add(tn.Clone)
            End If
        Next
        QuitarPermisoTodo(back.lbEmpresaSelect.SelectedValue)
        back.tvModuloSelect.Nodes.Clear()
        EnabledModuloQuitar()
    End Sub
#End Region
#Region "Agregar"
    Private Sub btnAgregarModulo(sender As Object, e As EventArgs)
        If back.cboEmpresas.SelectedValue IsNot Nothing Then
            AgregarModulo()
            UpdateEmpresaOk()
        End If
    End Sub
    Private Sub AgregarModulo()
        Dim tn As TreeNode = back.tvModulo.SelectedNode
        If Not IsNothing(tn) Then
            If tn.Nodes.Count = 0 Then
                back.tvModulo.Nodes.Remove(tn.Parent)
                back.tvModuloSelect.Nodes.Add(tn.Parent)

                AgregarPermiso(New Permiso(1, 1, back.cboEmpresas.SelectedValue, False, tn.Parent.Name))
            Else
                back.tvModulo.Nodes.Remove(tn)
                back.tvModuloSelect.Nodes.Add(tn)

                AgregarPermiso(New Permiso(1, 1, back.cboEmpresas.SelectedValue, False, tn.Name))

            End If
            EnabledModuloAgregar()
        End If
    End Sub
    Private Sub UpdateEmpresaOk()
        Dim empresaRuc As String = back.cboEmpresas.SelectedValue
        Dim drEmpresa As DataRow = dtEmpresaSelect.Rows.Find(empresaRuc)
        If drEmpresa IsNot Nothing Then

            drEmpresa("state") = True
            Dim cantidadModulos As Integer = CantidadOfCadenaArray(drEmpresa("mod").ToString)
            If cantidadModulos = rgls.DataSetUsuario.Tables("modulo").Rows.Count Then
                drEmpresa("compt") = True
                drEmpresa("mod") = String.Empty
            End If
        End If




    End Sub

    Private Sub btnAgregarTodoModulo(sender As Object, e As EventArgs)
        If back.cboEmpresas.SelectedValue Is Nothing Then Exit Sub
        controlAgregarModulo = True
        For Each tn As TreeNode In back.tvModulo.Nodes
            If tn IsNot Nothing Then
                back.tvModuloSelect.Nodes.Add(tn.Clone)
            End If
        Next

        AgregarPermisoTodo(New Permiso(1, 1, back.cboEmpresas.SelectedValue, True, String.Empty))
        back.tvModulo.Nodes.Clear()
        EnabledModuloAgregar()
        controlAgregarModulo = False
    End Sub
#End Region
#Region "AgregarPermisoData"
    Private Sub AgregarPermiso(permiso As Permiso)
        Dim dr As DataRow
        dr = dtEmpresaSelect.Rows.Find(permiso.Empresa)
        dr("usu") = permiso.Usuario
        dr("compt") = permiso.Completo
        dr("mod") = permiso.Modulos(dr("mod").ToString)
        dr("state") = If(back.tvModuloSelect.Nodes.Count = 0, False, True)
    End Sub
    Private Sub AgregarPermisoTodo(permiso As Permiso)
        Dim dr As DataRow
        dr = dtEmpresaSelect.Rows.Find(permiso.Empresa)
        dr("state") = True
        dr("usu") = permiso.Usuario
        dr("compt") = permiso.Completo
        dr("mod") = permiso.Modulos
    End Sub
#End Region

#Region "QuitarPermisoData"
    Private Sub QuitarPermiso(empresaRuc As String, permiso As Permiso)
        Dim dr As DataRow = dtEmpresaSelect.Rows.Find(empresaRuc)

        If Not IsNothing(dr) Then
            dr("mod") = permiso.QuitarModulo(dr("mod").ToString)
            dr("compt") = False
            dr("state") = If(back.tvModuloSelect.Nodes.Count = 0, False, True)
        End If
        Dim cantidad As Integer = CantidadOfCadenaArray(dr("mod").ToString)
        If cantidad = 0 Then
            UpdateEmpresaFalse()
        End If
    End Sub
    Private Sub QuitarPermisoTodo(empresaRuc As String)
        Dim dr As DataRow
        dr = dtEmpresaSelect.Rows.Find(empresaRuc)
        dr("state") = False
        dr("mod") = String.Empty
        dr("compt") = False
        UpdateEmpresaFalse()
    End Sub
    Private Sub UpdateEmpresaFalse()
        Dim empresaRuc As String = back.cboEmpresas.SelectedValue
        Dim drEmpresa As DataRow = dtEmpresaSelect.Rows.Find(empresaRuc)
        If drEmpresa IsNot Nothing Then
            drEmpresa("state") = False
            drEmpresa("NameState") = drEmpresa("Name") + " - Falta"
        End If
    End Sub
    Private Sub btnGuardarEnabled()
        Dim c As Integer = 0
        For Each dr As DataRow In dtEmpresaSelect.Rows

            If dr("state") = True Then
                c += 1
            End If
        Next
        If c = dtEmpresaSelect.Rows.Count Then
            tsbguardar.Enabled = True
        Else
            tsbguardar.Enabled = False
        End If
    End Sub
    Private Sub btnEliminarEnabled()

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
    Private Sub lbEmpresaSelect_DoubleClick(sender As Object, e As EventArgs)

        back.tabRoles.SelectedIndex = 1
        back.cboEmpresas.SelectedIndex = back.lbEmpresaSelect.SelectedIndex
        If controlAgregarModulo = False Then CargarPermisosByEmpresa(back.lbEmpresaSelect.SelectedValue)

    End Sub
#Region "CboEmpresa"
    Private Sub cboEmpresas_SelectedValueChanged(sender As Object, e As EventArgs)
        If controlAgregarModulo = False Then CargarPermisosByEmpresa(back.cboEmpresas.SelectedValue)
    End Sub
    Private Sub CargarPermisosByEmpresa(EmpresaRuc As String)
        If Not IsNothing(EmpresaRuc) Then
            Dim dr As DataRow = dtEmpresaSelect.Rows.Find(EmpresaRuc)
            If dr Is Nothing Or dr("mod").ToString.Length = 0 Then
                LimpiarModuloBackAll()
                CargarModuloBackAll()
                LimpiarModuloSelectBackAll()
            Else
                LimpiarModuloSelectBackAll()
                If CBool(dr.Item("compt")) = True Then

                    LimpiarModuloBackAll()
                    CargarModuloSelectAll()
                Else
                    Dim modulos() As String = CadenaToArray(dr("mod").ToString)
                    For i = 0 To modulos.Length - 1
                        CargarModuloSelectBackByName(modulos(i))
                    Next
                    LimpiarModuloBackAll()
                    CargarModuloBackByListString(dr("mod").ToString)
                End If
            End If
        End If
    End Sub


    Dim countTruePermiso As Integer = 0
    Friend WithEvents dtEmpresaSelect As DataTable
    Private Sub DataEmpresaSelect_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs) Handles dtEmpresaSelect.ColumnChanged
        Dim dt As DataColumn = e.Column
        If (dt Is Nothing) Or (dt.ColumnName <> "State") Then Exit Sub
        Dim dr As DataRow = e.Row
        If dr("state") = True Then
            dr("NameState") = dr("name") & ": Ok"
            countTruePermiso += 1
        Else
            dr("NameState") = dr("name") & ": Falta"
            countTruePermiso -= 1
        End If
        Dim cantidadState = dtEmpresaSelect.AsEnumerable.Count(Function(x) x.Field(Of Boolean)("state") = True)
        If dr("state") And (cantidadState = dtEmpresa.Rows.Count) Then
            ' btnGuardar.BackgroundImage = Global.Vista.My.Resources.Resources.guardar_true
            tsbguardar.Enabled = True
        Else
            ' btnGuardar.BackgroundImage = Global.Vista.My.Resources.Resources.guardar_false
            tsbguardar.Enabled = False
        End If

    End Sub

    Private Sub DataDeleted(sender As Object, e As DataRowChangeEventArgs) Handles dtEmpresaSelect.RowDeleted
        Dim rowsCantidad As Integer = dtEmpresaSelect.Rows.Count
        If rowsCantidad = 0 Then
            'btnGuardar.BackgroundImage = Global.Vista.My.Resources.Resources.guardar_false
            tsbguardar.Enabled = False
        End If
    End Sub

    Private Sub lbEmpresaActivos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbEmpresaActivosUsuario.SelectedIndexChanged
        Dim lb As ListBox = DirectCast(sender, ListBox)
        If lb.SelectedValue Is Nothing Then
            Exit Sub
        End If
        rgls.UpdateDtModulo(lb.SelectedValue.ToString)
    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUsuario.Validating
        If txtUsuario.Text.Trim.Count = 0 Then Exit Sub
        Dim permitido As Boolean = rgls.DisponibleUsuarioName(txtUsuario.Text)
        If permitido Then
            Me.epUsuario.SetError(sender, "")
        Else
            epUsuario.SetError(sender, "Es un nombre de usuario  esta reservado.")
            txtUsuario.Text = String.Empty
            txtUsuario.Focus()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles tsbsalir.Click
        Me.Close()
    End Sub

    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs) Handles tsmiEliminar.Click
        Dim dgvr As DataGridViewRow = dgvUsuarios.CurrentRow
        EliminarUsuario(dgvr.Cells("ColId").Value)

    End Sub
    Private Sub EliminarUsuario(UsuarioId As Integer)
        Dim respuesta As Boolean = rgls.EliminarUsuario(UsuarioId)
        If respuesta Then
            dtUsuario = rgls.UsuariosAll
            CargarUsuario()
            rgls.UpdateDataTableEmpresaAndModuloUsuario()
            MsgBox("Terminado")
        Else
            MsgBox("Ocurrio un Error")
        End If
    End Sub

    Private Sub tsmiActualizar_Click(sender As Object, e As EventArgs) Handles tsmiActualizar.Click
        Dim dgvr As DataGridViewRow = dgvUsuarios.CurrentRow
        txtCodigo.Text = dgvr.Cells("ColId").Value
        txtUsuario.Text = dgvr.Cells("ColUsuario").Value
        txtPassword.Text = dgvr.Cells("ColPassword").Value
        txtRPassword.Text = dgvr.Cells("ColPassword").Value

        rbActivo.Enabled = True
        rbInactivo.Enabled = True
        If dgvr.Cells("ColState").Value Then
            rbActivo.Checked = True
        Else
            rbInactivo.Checked = True
        End If
        rgls.UpdateDataTableEmpresaPermisoSelect(txtCodigo.Text)
        ' btnGuardar.BackgroundImage = Global.Vista.My.Resources.Resources.guardar_true
        tsbguardar.Enabled = True
        'btnEliminar.BackgroundImage = Global.Vista.My.Resources.Resources.eleminar_true
        tsbeliminar.Enabled = True
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles tsbcancelar.Click
        RegresarComoNuevaOperacion()
        ' btnGuardar.BackgroundImage = Global.Vista.My.Resources.Resources.guardar_false
        tsbguardar.Enabled = False
        '  btnEliminar.BackgroundImage = Global.Vista.My.Resources.Resources.eleminar_false
        tsbeliminar.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles tsbeliminar.Click
        EliminarUsuario(txtCodigo.Text)
        RegresarComoNuevaOperacion()
        'btnGuardar.BackgroundImage = Global.Vista.My.Resources.Resources.guardar_false
        tsbguardar.Enabled = False
        ' btnEliminar.BackgroundImage = Global.Vista.My.Resources.Resources.eleminar_false
        tsbeliminar.Enabled = False
    End Sub

    Private Sub tsbguardar_EnabledChanged(sender As Object, e As EventArgs) Handles tsbguardar.EnabledChanged
        tsbguardar.Enabled = True
    End Sub






#End Region
#End Region
End Class

