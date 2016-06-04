Imports Vista.frmRol
Imports Controladores
Imports Capa_Entidad

Public Class Form_RolesHijo
    '
    'Variables
    '
    Private contenedor As New RolBL
    Private tablaCabPrivilegio As DataTable
    Private tablaDetPrivilegio As DataTable
    Private dataSet As New DataSet
    Private foco As Boolean
    '
    'Contructor
    'Propiedades
    '
    'Eventos
    '
    '----Evento Form
    Private Sub FormRolesHijo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StatusButton(False)
        dataSet = contenedor.BaseForm_Roles
        tablaCabPrivilegio = dataSet.Tables("tableCabPrivilegio")
        tablaDetPrivilegio = dataSet.Tables("tableDetPrivilegio")
        foco = False
    End Sub
    '----Evento Button
    Private Sub btnRoles_Click(sender As Object, e As EventArgs) Handles btnRoles.Click
        'StatusButton()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Variables 
        Dim men, num As String
        'Logica
        men = "" : num = ""
        If contenedor.validacion_Codigo(txtCodigo.Text, men) = False Then
            MsgBox(men)
        ElseIf contenedor.validacion_Nombre(txtNombre.Text, men) = False Then
            MsgBox(men)
        ElseIf contenedor.validacion_Data_Empresa(Me.tablaCabPrivilegio.Copy, men) = False Then
            MsgBox(men)
        ElseIf contenedor.validacion_Data_Formulario(Me.tablaCabPrivilegio.Copy, Me.tablaDetPrivilegio.Copy, men) = False Then
            MsgBox(men)
        Else
            'Variables
            Dim rol As New Rol()
            Dim rowAfected As Boolean
            'Logica
            With rol
                .Id = txtCodigo.Text
                .Descripcion = txtNombre.Text
            End With
            rowAfected = contenedor.validacion_Registrar_Update_Rol(rol, men)
            If rowAfected = False Then
                MsgBox("Error:(1) " & vbLf &
                       men,
                       MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            Else
                contenedor.validacion_Registrar_Delete_Privilegio(tablaCabPrivilegio, tablaDetPrivilegio, men.Trim())
                If men.Trim().Length = 0 Then
                    MsgBox("Registro Existoso")
                    Limpiar_Registro_Rol()
                Else
                    MsgBox("Error:(2) " & vbLf & men,
                    MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                End If

            End If

        End If
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'Variables 
        Dim men As String
        'Logica
        men = ""
        If contenedor.validacion_Codigo(txtCodigo.Text, men) = False Then
            MsgBox(men)
        End If

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Limpiar_Registro_Rol()
        Me.StatusButton(False)
    End Sub

    '---Evento TreeView
    Private Sub treeView_Empresa_AfterCheck(sender As Object, e As TreeViewEventArgs)
        'Variables
        Dim newfila As DataRow
        'Logica
        newfila = Me.tablaCabPrivilegio.NewRow
        If e.Action <> TreeViewAction.Unknown Then
            If e.Node.Checked Then
                Try
                    newfila("Privilegio") = txtCodigo.Text & e.Node.Tag.ToString
                    newfila("Rol") = Integer.Parse(txtCodigo.Text)
                    newfila("Empresa_id") = e.Node.Tag.ToString
                    newfila("Empresa") = e.Node.Text
                    tablaCabPrivilegio.Rows.Add(newfila)
                Catch

                End Try

            Else
                Dim rowColeccion As DataRowCollection = tablaCabPrivilegio.Rows
                Dim cadbusqueda As String = e.Node.Tag.ToString
                If rowColeccion.Contains(cadbusqueda) Then
                    Dim row As DataRow = rowColeccion.Find(cadbusqueda)
                    rowColeccion.Remove(row)
                    Dim expresion As String
                    Dim rows() As DataRow
                    Dim i As Integer
                    Dim rowColeccionDetalle As DataRowCollection = tablaDetPrivilegio.Rows
                    expresion = "Privilegio =" & "'" & txtCodigo.Text & e.Node.Tag.ToString & "'"
                    rows = tablaDetPrivilegio.Select(expresion)
                    For i = 0 To rows.GetUpperBound(0)
                        rowColeccionDetalle.Remove(rows(i))
                    Next
                End If

            End If

        End If

    End Sub
    Private Sub tv_Formularios_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tv_Formularios.AfterCheck
        'Variables
        Dim cadena As String = ""
        Dim node As String = ""
        Dim cant As Integer = 0
        Dim Padre As String = ""
        Dim rowEdit As DataRow
        'Logica
        RemoveHandler tv_Formularios.AfterCheck, AddressOf tv_Formularios_AfterCheck
        Me.CheckAllChildNodes(e.Node, cadena, node, cant, Padre)
        If e.Action <> TreeViewAction.Unknown Then
            'Variable
            Dim tree As TreeNode = e.Node.Parent

            If e.Node.Checked Then
                Try
                    If tree Is Nothing Then
                        'Variable
                        Dim rowColeccion As DataRowCollection = tablaDetPrivilegio.Rows
                        Dim cadbusqueda As String = cboEmpresas.SelectedValue.ToString & Padre
                        Dim detPrivilegio As New DetPrivilegio()
                        'Logica
                        If rowColeccion.Contains(cadbusqueda) Then
                            Dim row As DataRow = rowColeccion.Find(cadbusqueda)
                            rowColeccion.Remove(row)
                        End If
                        If Padre.Length > 0 Then
                            With detPrivilegio
                                .Id = cboEmpresas.SelectedValue.ToString & Padre
                                .Contenedor = Padre
                                .Cantidad = cant
                            End With
                        Else
                            With detPrivilegio
                                .Id = cboEmpresas.SelectedValue.ToString & e.Node.Name
                                .Contenedor = e.Node.Tag.ToString
                                .Cantidad = 1
                            End With
                        End If
                        With detPrivilegio
                            .Privilegio = cboEmpresas.SelectedValue.ToString
                            .Node = node & "[*]"
                            .Formulario = cadena & "[*]"
                        End With

                        If Me.New_Fila_Tabla_detPrivilegio(DetPrivilegio, DetPrivilegio.Id) = False Then
                            e.Node.Checked = False
                        End If
                    Else
                        rowEdit = tablaDetPrivilegio.Rows.Find(cboEmpresas.SelectedValue.ToString & e.Node.Parent.Tag.ToString)
                        If rowEdit Is Nothing Then
                            Dim detPrivilegio As New DetPrivilegio
                            With detPrivilegio
                                .Id = cboEmpresas.SelectedValue.ToString & e.Node.Parent.Tag.ToString
                                .Privilegio = cboEmpresas.SelectedValue.ToString
                                .Contenedor = e.Node.Parent.Tag.ToString
                                .Node = "[" & e.Node.Name & "]"
                                .Cantidad = 1
                                .Formulario = "[" & e.Node.Tag.ToString & "]"
                            End With
                            If Me.New_Fila_Tabla_detPrivilegio(detPrivilegio, detPrivilegio.Id) = False Then
                                e.Node.Checked = False
                            End If

                        Else
                            rowEdit("Cantidad") = Integer.Parse(rowEdit("Cantidad").ToString) + 1
                            rowEdit("Node") = rowEdit("Node").ToString & "[" & e.Node.Name & "]"
                            rowEdit("Formularios") = rowEdit("Formularios").ToString & "[" & e.Node.Tag.ToString & "]"
                            If Integer.Parse(rowEdit("Cantidad").ToString) = e.Node.Parent.Nodes.Count Then
                                rowEdit("Node") = rowEdit("Node").ToString & "[*]"
                                rowEdit("Formularios") = rowEdit("Formularios").ToString & "[*]"
                                e.Node.Parent.Checked = True
                            End If

                        End If
                    End If
                Catch
                End Try
            Else
                Try
                    If tree Is Nothing Then
                        Me.Eliminar_Fila_Tabla_detPrivilegio(cboEmpresas.SelectedValue.ToString & e.Node.Tag.ToString)
                    Else
                        'Variables
                        Dim cadenas As String
                        Dim nodes As String
                        'Logica
                        rowEdit = tablaDetPrivilegio.Rows.Find(cboEmpresas.SelectedValue.ToString & e.Node.Parent.Tag.ToString)
                        rowEdit("Cantidad") = Integer.Parse(rowEdit("Cantidad").ToString) - 1
                        cadenas = rowEdit("Formularios").ToString
                        nodes = rowEdit("Node").ToString
                        cadenas = cadenas.Replace("[" & e.Node.Tag.ToString & "]", Nothing).Replace("[*]", Nothing)
                        nodes = nodes.Replace("[" & e.Node.Name.ToString & "]", Nothing).Replace("[*]", Nothing)
                        rowEdit("Formularios") = cadenas
                        rowEdit("Node") = nodes
                        If Integer.Parse(rowEdit("Cantidad").ToString) = 0 Then
                            Me.Eliminar_Fila_Tabla_detPrivilegio(cboEmpresas.SelectedValue.ToString & e.Node.Tag.ToString)
                        End If
                        e.Node.Parent.Checked = False
                    End If
                Catch
                End Try

            End If
        End If
        AddHandler tv_Formularios.AfterCheck, AddressOf tv_Formularios_AfterCheck
    End Sub

    '---Evento TabControl
    Private Sub tabRoles_Selected(sender As Object, e As TabControlEventArgs) Handles tabRoles.Selected
        If e.TabPageIndex = 1 Then
            Dim tabla As DataTable = tablaCabPrivilegio
            cboEmpresas.DataSource = tabla
            cboEmpresas.DisplayMember = "Empresa"
            cboEmpresas.ValueMember = "Privilegio"
            tv_Formularios.Nodes.Clear()
        Else
            tv_Formularios.Nodes.Clear()
        End If
    End Sub
    Private Sub tabRoles_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tabRoles.Selecting
        'tv_Formularios.Nodes.Clear()
        'If e.TabPageIndex = 1 Then
        '    If treeView_Empresa.Nodes.Count = 0 Then
        '        e.Cancel = True
        '        MsgBox("Busca un Nuevo Rol")
        '    Else
        '        If tablaCabPrivilegio.Rows.Count = 0 Then
        '            e.Cancel = True
        '            MsgBox("Seleccione minimo (1) empresa ")
        '        Else
        '            e.Cancel = False
        '        End If
        '    End If
        'End If

    End Sub
    '---Evento ComboBox
    Private Sub cboEmpresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpresas.SelectedIndexChanged
        If cboEmpresas.Items.Count > 0 Then : foco = True
        Else : foco = False
        End If
        If foco Then
            If cboEmpresas.SelectedIndex <> -1 Then
                Check_TreeView_Formulario()
            End If
        End If
    End Sub
    '---Evento TextBox
    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        e.Handled = Validacion_Numero_TextBox(e.KeyChar)
    End Sub
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        e.Handled = Validacion_Cadena_TextBox(e.KeyChar)
    End Sub
    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        txtNombre.Text = txtNombre.Text.Trim
        If txtNombre.Text.Length > 0 Then
            txtNombre.Text = UCase(Mid(txtNombre.Text, 1, 1)) & Mid(txtNombre.Text, 2, txtNombre.Text.Length)
        End If
    End Sub
    '
    'Metodos
    '
    '---Metodo  Button
    Public Sub StatusButton(ByVal control As Boolean)
        If control = True Then
            btnGuardar.BackgroundImage = Vista.My.Resources.Resources.guardar_true
            btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
            btnCancelar.BackgroundImage = Vista.My.Resources.Resources.cancelar_true
            btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            BtnEliminar.BackgroundImage = Vista.My.Resources.Resources.opcion_true
            BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True
            BtnEliminar.Enabled = True
        Else
            btnGuardar.BackgroundImage = Vista.My.Resources.Resources.guardar_false
            btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            btnCancelar.BackgroundImage = Vista.My.Resources.Resources.cancelar_false
            btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            BtnEliminar.BackgroundImage = Vista.My.Resources.Resources.opcion_false
            BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            btnGuardar.Enabled = False
            btnCancelar.Enabled = False
            BtnEliminar.Enabled = False
        End If

    End Sub
    '---Metodo  TreeView
    Public Sub CargarTreeView_Formulario()
        Me.tv_Formularios.Nodes.Clear()
        Me.tv_Formularios.CheckBoxes = True
        Dim row As DataRow
        Dim table As DataTable = dataSet.Tables("tableCont")
        For Each row In table.Rows
            Dim node As TreeNode
            node = New TreeNode(row.Item("nombre"))
            node.Tag = row.Item("cont_id")
            node.Name = row.Item("cont_id")
            Me.tv_Formularios.Nodes.Add(node)

            Dim childrow As DataRow
            Dim childnode As TreeNode
            childnode = New TreeNode()
            For Each childrow In row.GetChildRows("ContID")
                childnode = node.Nodes.Add(childrow("descrip"))
                childnode.Tag = childrow("for_id")
                childnode.Name = childrow("for_id")
            Next
        Next

    End Sub
    Public Sub CargarTreeView_Empresa()
        'Me.treeView_Empresa.Nodes.Clear()
        'Me.treeView_Empresa.CheckBoxes = True
        'Dim row As DataRow
        'Dim table As DataTable = dataSet.Tables("tableEmp")
        'For Each row In table.Rows
        '    Dim node As TreeNode
        '    node = New TreeNode(row.Item("nombre"))
        '    node.Tag = row.Item("ruc")
        '    Me.treeView_Empresa.Nodes.Add(node)
        'Next

    End Sub
    Private Sub CheckAllChildNodes(ByVal nodePadre As TreeNode, ByRef cadena As String, ByRef node As String, ByRef cant As Integer, ByRef Padre As String)
        If nodePadre.Nodes.Count > 0 Then
            Padre = nodePadre.Tag.ToString
        End If
        For Each childNode As TreeNode In nodePadre.Nodes
            cant = cant + 1
            childNode.Checked = nodePadre.Checked
            node = cadena & "[" & childNode.Name.ToString & "]"
            cadena = cadena & "[" & childNode.Tag.ToString & "]"
            CheckAllChildNodes(childNode, cadena, node, cant, Padre)
        Next
    End Sub
    Public Sub Check_TreeView_Formulario()
        'Variables
        Dim expresion As String
        Dim rows() As DataRow
        Dim i As Integer
        'Logica
        Me.CargarTreeView_Formulario()
        Dim rowColeccionDetalle As DataRowCollection = tablaDetPrivilegio.Rows
        expresion = "Privilegio = '" & cboEmpresas.SelectedValue.ToString & "'"
        rows = tablaDetPrivilegio.Select(expresion)
        If rows.Length > 0 Then
            For i = 0 To rows.GetUpperBound(0)
                Dim nodes() As TreeNode
                nodes = tv_Formularios.Nodes.Find(rows(i)(2).ToString, False)
                For Each node As TreeNode In nodes
                    If node.Name = rows(i)(2) Then
                        If InStr(rows(i)(5).ToString, "*") <> 0 Then : node.Checked = True
                        Else
                            Dim start As Integer = 0
                            For Each childNode As TreeNode In node.Nodes
                                If InStr(rows(i)(5).ToString, childNode.Tag.ToString) <> 0 Then : childNode.Checked = True
                                End If
                            Next
                            node.Expand()
                        End If
                    End If
                Next
            Next
        End If
    End Sub
    '---Metodo DataTable
    Private Function New_Fila_Tabla_detPrivilegio(ByVal detPrivilegio As DetPrivilegio, ByVal cadbusqueda As String) As Boolean
        'Variable
        Dim newfila As DataRow
        'Logica
        newfila = Me.tablaDetPrivilegio.NewRow
        newfila("Id") = detPrivilegio.Id
        newfila("Privilegio") = detPrivilegio.Privilegio
        newfila("Contenedor") = detPrivilegio.Contenedor
        newfila("Node") = detPrivilegio.Node
        newfila("Cantidad") = detPrivilegio.Cantidad
        newfila("Formularios") = detPrivilegio.Formulario
        tablaDetPrivilegio.Rows.Add(newfila)
        Dim rowColeccion As DataRowCollection = tablaDetPrivilegio.Rows
        If rowColeccion.Contains(cadbusqueda) Then
            Dim row As DataRow = rowColeccion.Find(cadbusqueda)
            If row Is Nothing Then
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If

    End Function
    Private Sub Eliminar_Fila_Tabla_detPrivilegio(ByVal cadbusqueda As String)
        Dim rowColeccion As DataRowCollection = tablaDetPrivilegio.Rows
        If rowColeccion.Contains(cadbusqueda) Then
            Dim row As DataRow = rowColeccion.Find(cadbusqueda)
            rowColeccion.Remove(row)
        End If
    End Sub
    Public Function Validacion_Numero_TextBox(ByVal caracter As Char) As Boolean
        Dim res As Boolean
        If Char.IsNumber(caracter) Then
            res = False
        ElseIf caracter = Convert.ToChar(8) Then
            res = False
        ElseIf Char.IsWhiteSpace(caracter) Then
            res = True
        Else
            res = True
        End If
        Return res
    End Function
    Public Function Validacion_Cadena_TextBox(ByVal caracter As Char) As Boolean
        Dim res As Boolean
        If Char.IsNumber(caracter) Then
            res = True
        ElseIf caracter = Convert.ToChar(8) Then
            res = False
        ElseIf Char.IsWhiteSpace(caracter) Then
            res = True
        ElseIf Char.IsSymbol(caracter) Then
            res = True
        ElseIf Char.IsPunctuation(caracter) Then
            res = True
        Else
            res = False
        End If
        Return res
    End Function
    Public Sub Llenar_tablaCabPrivilegio(ByVal dataTableTemp As DataTable)

        'Logicas
        tablaCabPrivilegio.Rows.Clear()
        tablaDetPrivilegio.Rows.Clear()
        For Each row As DataRow In dataTableTemp.Rows
            'Variable
            Dim newfila As DataRow
            'Logica
            newfila = Me.tablaCabPrivilegio.NewRow
            newfila("Privilegio") = row("priv_id").ToString
            newfila("Rol") = Integer.Parse(row("rol_id").ToString)
            newfila("Empresa_id") = row("emp_id").ToString
            newfila("Empresa") = row("nombre")
            tablaCabPrivilegio.Rows.Add(newfila)
            'For Each node As TreeNode In treeView_Empresa.Nodes
            '    If node.Tag = row("emp_id").ToString Then
            '        node.Checked = True
            '    End If
            'Next
            'Llenar_tablaDetPrivilegio(row("priv_id").ToString)

        Next
    End Sub
    Public Sub Llenar_tablaDetPrivilegio(ByVal privilegio As String)
        'Variables
        Dim dataTable_detPrivilegio As DataTable
        'Logica
        dataTable_detPrivilegio = contenedor.LLenar_detPrivilegio(privilegio).Copy()
        For Each row As DataRow In dataTable_detPrivilegio.Rows
            'Variable
            Dim newfila As DataRow
            'Logica
            newfila = Me.tablaDetPrivilegio.NewRow
            newfila("Id") = row("cont_id").ToString & row("priv_id").ToString
            newfila("Privilegio") = row("priv_id").ToString
            newfila("Contenedor") = row("cont_id").ToString
            newfila("Node") = row("form").ToString
            newfila("Cantidad") = row("cant_form").ToString
            newfila("Formularios") = row("form").ToString
            tablaDetPrivilegio.Rows.Add(newfila)
        Next
    End Sub

    '---Metodo Limpiar Data
    Public Sub Limpiar_Registro_Rol()
        Me.tablaCabPrivilegio.Rows.Clear()
        Me.tablaDetPrivilegio.Rows.Clear()
        Me.tv_Formularios.Nodes.Clear()
        'Me.treeView_Empresa.Nodes.Clear()
        Me.txtNombre.Text = ""
        Me.txtCodigo.Text = ""
        Me.txtCodigo.Enabled = True
        Me.txtCodigo.Focus()
        Me.tabRoles.SelectedIndex = 0
        Me.cboEmpresas.DataSource = Nothing
    End Sub





End Class