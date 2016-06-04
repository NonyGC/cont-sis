Imports Capa_Entidad
Imports Controladores
Public Class frmRol
#Region "Atributos"
    Dim rol As New Rol
    Dim contenedor As New RolBL
    Dim front As New FrontRol
    Dim back As New BackRol
    Dim roles As String
#End Region
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        With front
            .TopLevel = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .Dock = DockStyle.Fill
        End With
        With back
            .TopLevel = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .Dock = DockStyle.Fill
        End With
        pnlPadre.Controls.Add(front)
        pnlPadre.Controls.Add(back)
        AddHandler front.btnRoles.Click, AddressOf MostrarBack
        AddHandler back.BtnCancelar.Click, AddressOf MostrarFront


        ' Add any initialization after the InitializeComponent() call.

    End Sub
    'Variables
    Private Sub MostrarFront(sender As Object, e As EventArgs)
        back.Hide()
        front.Show()
    End Sub
    Private Sub MostrarBack(sender As Object, e As EventArgs)
        front.Hide()
        back.Show()
    End Sub
    'Contructores
    'Propiedades 
    'Eventos
    '----Evento Form : Padre
    Private Sub Frm_Roles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'With hijoDrigView
        '    .TopLevel = False
        '    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
        '    .Dock = DockStyle.Fill
        'End With

        front.Show()
        'pnlPadre.Controls.Add(hijoDrigView)

        'AddHandler hijoFormRoles.btnRoles.Click, AddressOf Me.Evento_btnDataGridView
        'AddHandler hijoFormRoles.btnCerrar.Click, AddressOf Me.Evento_btnCerrar_Click
        'AddHandler hijoDrigView.BtnCancelar.Click, AddressOf Me.Evento_btnCancelar_Data
        'AddHandler hijoDrigView.dgvContenedor.CellDoubleClick, AddressOf Me.Evento_dgvContenedor_CellDoubleClick
        'AddHandler hijoDrigView.dgvContenedor.KeyDown, AddressOf Me.Evento_dgvContenedor_KeyDown

        'MostrarFormHijo()

    End Sub
    Private Sub Frm_Roles_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'If e.CloseReason = CloseReason.UserClosing Then
        '    If Me.front.txtCodigo.Text <> "" Then
        '        MsgBox("No se puede salir en este momento (2)")
        '        e.Cancel = True
        '    End If
        'End If

    End Sub
    '----Evento Button : Hijo
    'Private Sub Evento_btnDataGridView(ByVal sender As System.Object, ByVal e As EventArgs)
    '    With hijoDrigView
    '        .Load_DataGridView()
    '        .BuscarDataGridView(front.txtCodigo.Text)
    '    End With
    '    MostrarDataGridViewHijo()
    'End Sub
    'Private Sub Evento_btnCancelar_Data(ByVal sender As System.Object, ByVal e As EventArgs)
    '    With front
    '    End With
    '    MostrarFormHijo()
    'End Sub
    Private Sub Evento_btnCerrar_Click(sender As Object, e As EventArgs)
        If Me.front.txtCodigo.Text <> "" Then
            MsgBox("No se puede salir en este momento (1)")
        Else
            Me.Dispose()
        End If
    End Sub
    ''---Evento DataGridView : Hijo 
    'Private Sub Evento_dgvContenedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
    '    capturarRol()
    '    MostrarFormHijo(rol)
    'End Sub
    'Private Sub Evento_dgvContenedor_KeyDown(sender As Object, e As KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        capturarRol()
    '        MostrarFormHijo(rol)
    '    End If
    'End Sub

    'Metodos
    'Private Sub capturarRol()
    '    With rol
    '        .Id = hijoDrigView.dgvContenedor.Item(0, hijoDrigView.dgvContenedor.CurrentRow.Index).Value
    '        .Descripcion = hijoDrigView.dgvContenedor.Item(1, hijoDrigView.dgvContenedor.CurrentRow.Index).Value
    '    End With
    'End Sub
    'Private Sub MostrarFormHijo()
    '    If hijoDrigView IsNot Nothing Then
    '        hijoDrigView.Hide()
    '    End If
    '    front.Show()
    'End Sub
    Private Sub MostrarFormHijo(ByVal rol As Rol)
        'Variables 
        Dim DataTable As New DataTable
        '
        With front
            .txtCodigo.Text = rol.Id
            .txtNombre.Text = rol.Descripcion
            .txtCodigo.Enabled = False
        End With
        If contenedor.validacion_cabPrivilegio_Encontrador(rol.Id, DataTable) = False Then
        Else
            If DataTable IsNot Nothing Then
                If DataTable.Rows.Count > 0 Then
                    With front
                    End With
                End If
            End If
        End If
        'MostrarFormHijo()
    End Sub
    'Private Sub MostrarDataGridViewHijo()
    '    If front IsNot Nothing Then
    '        front.Hide()
    '    End If
    '    hijoDrigView.Show()
    'End Sub

End Class


Public Class FrontRol
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public Sub New()
        InitializeComponent()
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tv_Formularios = New System.Windows.Forms.TreeView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRoles = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tabRoles = New System.Windows.Forms.TabControl()
        Me.tabpageEmpresas = New System.Windows.Forms.TabPage()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.tabPageFormulario = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.cboEmpresas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.toolTip_Form = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.tabRoles.SuspendLayout()
        Me.tabpageEmpresas.SuspendLayout()
        Me.tabPageFormulario.SuspendLayout()
        Me.SuspendLayout()
        '
        'tv_Formularios
        '
        Me.tv_Formularios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tv_Formularios.Location = New System.Drawing.Point(6, 34)
        Me.tv_Formularios.Name = "tv_Formularios"
        Me.tv_Formularios.Size = New System.Drawing.Size(157, 249)
        Me.tv_Formularios.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnRoles)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.txtCodigo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(439, 79)
        Me.Panel2.TabIndex = 17
        '
        'btnRoles
        '
        Me.btnRoles.Location = New System.Drawing.Point(193, 16)
        Me.btnRoles.Name = "btnRoles"
        Me.btnRoles.Size = New System.Drawing.Size(24, 23)
        Me.btnRoles.TabIndex = 4
        Me.btnRoles.Text = "..."
        Me.toolTip_Form.SetToolTip(Me.btnRoles, "Buscar")
        Me.btnRoles.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(87, 42)
        Me.txtNombre.MaxLength = 25
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(87, 16)
        Me.txtCodigo.MaxLength = 11
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = Global.Vista.My.Resources.Resources.cerrar_true
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.Location = New System.Drawing.Point(92, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(24, 26)
        Me.btnCerrar.TabIndex = 16
        Me.toolTip_Form.SetToolTip(Me.btnCerrar, "Cerrar")
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.Vista.My.Resources.Resources.cancelar_false
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancelar.Location = New System.Drawing.Point(62, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(24, 26)
        Me.btnCancelar.TabIndex = 15
        Me.toolTip_Form.SetToolTip(Me.btnCancelar, "Cancelar")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackgroundImage = Global.Vista.My.Resources.Resources.cancelar_false
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEliminar.Location = New System.Drawing.Point(40, 12)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(24, 26)
        Me.BtnEliminar.TabIndex = 14
        Me.toolTip_Form.SetToolTip(Me.BtnEliminar, "Eliminar")
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.BackgroundImage = Global.Vista.My.Resources.Resources.guardar_false
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnGuardar.Location = New System.Drawing.Point(12, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(24, 26)
        Me.btnGuardar.TabIndex = 13
        Me.toolTip_Form.SetToolTip(Me.btnGuardar, "Guardar")
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'tabRoles
        '
        Me.tabRoles.Controls.Add(Me.tabpageEmpresas)
        Me.tabRoles.Controls.Add(Me.tabPageFormulario)
        Me.tabRoles.Location = New System.Drawing.Point(12, 141)
        Me.tabRoles.Name = "tabRoles"
        Me.tabRoles.SelectedIndex = 0
        Me.tabRoles.Size = New System.Drawing.Size(439, 323)
        Me.tabRoles.TabIndex = 19
        '
        'tabpageEmpresas
        '
        Me.tabpageEmpresas.BackColor = System.Drawing.SystemColors.Control
        Me.tabpageEmpresas.Controls.Add(Me.ListBox2)
        Me.tabpageEmpresas.Controls.Add(Me.Button2)
        Me.tabpageEmpresas.Controls.Add(Me.Button1)
        Me.tabpageEmpresas.Controls.Add(Me.ListBox1)
        Me.tabpageEmpresas.Location = New System.Drawing.Point(4, 22)
        Me.tabpageEmpresas.Name = "tabpageEmpresas"
        Me.tabpageEmpresas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageEmpresas.Size = New System.Drawing.Size(431, 297)
        Me.tabpageEmpresas.TabIndex = 0
        Me.tabpageEmpresas.Text = "Empresa"
        '
        'ListBox2
        '
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(259, 34)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(157, 249)
        Me.ListBox2.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(169, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "<< Quitar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(169, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Agregar >>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 34)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(157, 249)
        Me.ListBox1.TabIndex = 0
        '
        'tabPageFormulario
        '
        Me.tabPageFormulario.BackColor = System.Drawing.SystemColors.Control
        Me.tabPageFormulario.Controls.Add(Me.Button4)
        Me.tabPageFormulario.Controls.Add(Me.Button3)
        Me.tabPageFormulario.Controls.Add(Me.TreeView1)
        Me.tabPageFormulario.Controls.Add(Me.cboEmpresas)
        Me.tabPageFormulario.Controls.Add(Me.Label3)
        Me.tabPageFormulario.Controls.Add(Me.tv_Formularios)
        Me.tabPageFormulario.Location = New System.Drawing.Point(4, 22)
        Me.tabPageFormulario.Name = "tabPageFormulario"
        Me.tabPageFormulario.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageFormulario.Size = New System.Drawing.Size(431, 297)
        Me.tabPageFormulario.TabIndex = 1
        Me.tabPageFormulario.Text = "Formularios"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(169, 160)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "<< Quitar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(169, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Agregar >>"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.Location = New System.Drawing.Point(259, 34)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(157, 249)
        Me.TreeView1.TabIndex = 8
        '
        'cboEmpresas
        '
        Me.cboEmpresas.FormattingEnabled = True
        Me.cboEmpresas.Location = New System.Drawing.Point(161, 8)
        Me.cboEmpresas.Name = "cboEmpresas"
        Me.cboEmpresas.Size = New System.Drawing.Size(255, 21)
        Me.cboEmpresas.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Empresa"
        '
        'Form_RolesHijo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 513)
        Me.Controls.Add(Me.tabRoles)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "Form_RolesHijo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRolesHijo"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tabRoles.ResumeLayout(False)
        Me.tabpageEmpresas.ResumeLayout(False)
        Me.tabPageFormulario.ResumeLayout(False)
        Me.tabPageFormulario.PerformLayout()
        Me.ResumeLayout(False)
        Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink

    End Sub

    Friend WithEvents tv_Formularios As System.Windows.Forms.TreeView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnRoles As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents tabRoles As System.Windows.Forms.TabControl
    Friend WithEvents tabpageEmpresas As System.Windows.Forms.TabPage
    Friend WithEvents tabPageFormulario As System.Windows.Forms.TabPage
    Friend WithEvents toolTip_Form As System.Windows.Forms.ToolTip
    Friend WithEvents cboEmpresas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
End Class


Public Class BackRol
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    Public Sub New()
        InitializeComponent()
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.dgvContenedor = New System.Windows.Forms.DataGridView()
        Me.ColId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvContenedor
        '
        Me.dgvContenedor.AllowUserToAddRows = False
        Me.dgvContenedor.AllowUserToDeleteRows = False
        Me.dgvContenedor.AllowUserToResizeColumns = False
        Me.dgvContenedor.AllowUserToResizeRows = False
        Me.dgvContenedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvContenedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvContenedor.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvContenedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContenedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColId, Me.CodRol})
        Me.dgvContenedor.Location = New System.Drawing.Point(13, 13)
        Me.dgvContenedor.MultiSelect = False
        Me.dgvContenedor.Name = "dgvContenedor"
        Me.dgvContenedor.ReadOnly = True
        Me.dgvContenedor.RowHeadersVisible = False
        Me.dgvContenedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContenedor.Size = New System.Drawing.Size(337, 443)
        Me.dgvContenedor.TabIndex = 0
        '
        'ColId
        '
        Me.ColId.FillWeight = 50.76142!
        Me.ColId.HeaderText = "Id"
        Me.ColId.Name = "ColId"
        Me.ColId.ReadOnly = True
        Me.ColId.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CodRol
        '
        Me.CodRol.FillWeight = 149.2386!
        Me.CodRol.HeaderText = "Rol"
        Me.CodRol.Name = "CodRol"
        Me.CodRol.ReadOnly = True
        Me.CodRol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(389, 422)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmDataGridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

        Me.ClientSize = New System.Drawing.Size(499, 513)
        Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.dgvContenedor)
        Me.Name = "FrmDataGridView"
        Me.Text = "FrmDataGridView"
        CType(Me.dgvContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvContenedor As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents ColId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodRol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class