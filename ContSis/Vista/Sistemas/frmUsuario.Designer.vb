<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.ColId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStateString = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lbEmpresaActivosUsuario = New System.Windows.Forms.ListBox()
        Me.lbModuloUsuario = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEmpresaCantInactivas = New System.Windows.Forms.Label()
        Me.lbEmpresaInactivos = New System.Windows.Forms.ListBox()
        Me.lblNroModulo = New System.Windows.Forms.Label()
        Me.lblEmpresaCantActivas = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Mantenimiento = New System.Windows.Forms.GroupBox()
        Me.chkPassword = New System.Windows.Forms.CheckBox()
        Me.rtxtMsg = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbInactivo = New System.Windows.Forms.RadioButton()
        Me.rbActivo = New System.Windows.Forms.RadioButton()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmsUsuario = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiActualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.epUsuario = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ttUsuario = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlUsuario = New System.Windows.Forms.Panel()
        Me.pnlFront = New System.Windows.Forms.Panel()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbguardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbcancelar = New System.Windows.Forms.ToolStripButton()
        Me.tsbeliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbsalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Mantenimiento.SuspendLayout()
        Me.cmsUsuario.SuspendLayout()
        CType(Me.epUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUsuario.SuspendLayout()
        Me.pnlFront.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AllowUserToOrderColumns = True
        Me.dgvUsuarios.AllowUserToResizeColumns = False
        Me.dgvUsuarios.AllowUserToResizeRows = False
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColId, Me.ColPassword, Me.ColUsuario, Me.ColState, Me.ColStateString})
        Me.dgvUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvUsuarios.Location = New System.Drawing.Point(6, 19)
        Me.dgvUsuarios.MultiSelect = False
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(382, 177)
        Me.dgvUsuarios.TabIndex = 24
        '
        'ColId
        '
        Me.ColId.DataPropertyName = "usu_id"
        Me.ColId.HeaderText = "Id"
        Me.ColId.Name = "ColId"
        Me.ColId.ReadOnly = True
        Me.ColId.Visible = False
        '
        'ColPassword
        '
        Me.ColPassword.DataPropertyName = "usu_password"
        Me.ColPassword.HeaderText = "Password"
        Me.ColPassword.Name = "ColPassword"
        Me.ColPassword.Visible = False
        '
        'ColUsuario
        '
        Me.ColUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColUsuario.DataPropertyName = "usu_name"
        Me.ColUsuario.HeaderText = "Usuario"
        Me.ColUsuario.Name = "ColUsuario"
        Me.ColUsuario.ReadOnly = True
        Me.ColUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColUsuario.Width = 300
        '
        'ColState
        '
        Me.ColState.DataPropertyName = "usu_state"
        Me.ColState.HeaderText = "Estado"
        Me.ColState.Name = "ColState"
        Me.ColState.ReadOnly = True
        Me.ColState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColState.Visible = False
        '
        'ColStateString
        '
        Me.ColStateString.DataPropertyName = "usu_state_string"
        Me.ColStateString.HeaderText = "Estado"
        Me.ColStateString.Name = "ColStateString"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Permisos"
        '
        'txtRPassword
        '
        Me.txtRPassword.Location = New System.Drawing.Point(125, 133)
        Me.txtRPassword.MaxLength = 15
        Me.txtRPassword.Name = "txtRPassword"
        Me.txtRPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRPassword.Size = New System.Drawing.Size(179, 20)
        Me.txtRPassword.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Repetir Contraseña"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(125, 81)
        Me.txtPassword.MaxLength = 15
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(179, 20)
        Me.txtPassword.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.epUsuario.SetIconAlignment(Me.txtUsuario, System.Windows.Forms.ErrorIconAlignment.BottomRight)
        Me.txtUsuario.Location = New System.Drawing.Point(125, 55)
        Me.txtUsuario.MaxLength = 15
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(179, 20)
        Me.txtUsuario.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Usuario"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(24, 31)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(40, 13)
        Me.lblUsuario.TabIndex = 9
        Me.lblUsuario.Text = "Codigo"
        Me.lblUsuario.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Enabled = False
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(125, 190)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(179, 23)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "Activar "
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lbEmpresaActivosUsuario
        '
        Me.lbEmpresaActivosUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.lbEmpresaActivosUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbEmpresaActivosUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbEmpresaActivosUsuario.FormattingEnabled = True
        Me.lbEmpresaActivosUsuario.Location = New System.Drawing.Point(6, 217)
        Me.lbEmpresaActivosUsuario.Name = "lbEmpresaActivosUsuario"
        Me.lbEmpresaActivosUsuario.Size = New System.Drawing.Size(186, 106)
        Me.lbEmpresaActivosUsuario.TabIndex = 26
        Me.ttUsuario.SetToolTip(Me.lbEmpresaActivosUsuario, "Lista de Empresas activas")
        '
        'lbModuloUsuario
        '
        Me.lbModuloUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.lbModuloUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbModuloUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbModuloUsuario.FormattingEnabled = True
        Me.lbModuloUsuario.Location = New System.Drawing.Point(207, 217)
        Me.lbModuloUsuario.Name = "lbModuloUsuario"
        Me.lbModuloUsuario.Size = New System.Drawing.Size(181, 106)
        Me.lbModuloUsuario.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEmpresaCantInactivas)
        Me.GroupBox1.Controls.Add(Me.lbEmpresaInactivos)
        Me.GroupBox1.Controls.Add(Me.lblNroModulo)
        Me.GroupBox1.Controls.Add(Me.lblEmpresaCantActivas)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbEmpresaActivosUsuario)
        Me.GroupBox1.Controls.Add(Me.lbModuloUsuario)
        Me.GroupBox1.Controls.Add(Me.dgvUsuarios)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 430)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'lblEmpresaCantInactivas
        '
        Me.lblEmpresaCantInactivas.AutoSize = True
        Me.lblEmpresaCantInactivas.Location = New System.Drawing.Point(6, 417)
        Me.lblEmpresaCantInactivas.Name = "lblEmpresaCantInactivas"
        Me.lblEmpresaCantInactivas.Size = New System.Drawing.Size(66, 13)
        Me.lblEmpresaCantInactivas.TabIndex = 33
        Me.lblEmpresaCantInactivas.Text = "N° Empresa:"
        '
        'lbEmpresaInactivos
        '
        Me.lbEmpresaInactivos.BackColor = System.Drawing.SystemColors.Control
        Me.lbEmpresaInactivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbEmpresaInactivos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbEmpresaInactivos.FormattingEnabled = True
        Me.lbEmpresaInactivos.Location = New System.Drawing.Point(6, 342)
        Me.lbEmpresaInactivos.Name = "lbEmpresaInactivos"
        Me.lbEmpresaInactivos.Size = New System.Drawing.Size(186, 67)
        Me.lbEmpresaInactivos.TabIndex = 32
        Me.ttUsuario.SetToolTip(Me.lbEmpresaInactivos, "Lista de Empresas inactivos.")
        '
        'lblNroModulo
        '
        Me.lblNroModulo.AutoSize = True
        Me.lblNroModulo.Location = New System.Drawing.Point(207, 326)
        Me.lblNroModulo.Name = "lblNroModulo"
        Me.lblNroModulo.Size = New System.Drawing.Size(63, 13)
        Me.lblNroModulo.TabIndex = 31
        Me.lblNroModulo.Text = "N° Modulo: "
        '
        'lblEmpresaCantActivas
        '
        Me.lblEmpresaCantActivas.AutoSize = True
        Me.lblEmpresaCantActivas.Location = New System.Drawing.Point(3, 326)
        Me.lblEmpresaCantActivas.Name = "lblEmpresaCantActivas"
        Me.lblEmpresaCantActivas.Size = New System.Drawing.Size(66, 13)
        Me.lblEmpresaCantActivas.TabIndex = 30
        Me.lblEmpresaCantActivas.Text = "N° Empresa:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(207, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Modulos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Empresa"
        '
        'Mantenimiento
        '
        Me.Mantenimiento.BackColor = System.Drawing.SystemColors.Control
        Me.Mantenimiento.Controls.Add(Me.chkPassword)
        Me.Mantenimiento.Controls.Add(Me.rtxtMsg)
        Me.Mantenimiento.Controls.Add(Me.Label1)
        Me.Mantenimiento.Controls.Add(Me.rbInactivo)
        Me.Mantenimiento.Controls.Add(Me.rbActivo)
        Me.Mantenimiento.Controls.Add(Me.txtCodigo)
        Me.Mantenimiento.Controls.Add(Me.lblUsuario)
        Me.Mantenimiento.Controls.Add(Me.btnBack)
        Me.Mantenimiento.Controls.Add(Me.Label5)
        Me.Mantenimiento.Controls.Add(Me.Label2)
        Me.Mantenimiento.Controls.Add(Me.txtUsuario)
        Me.Mantenimiento.Controls.Add(Me.Label3)
        Me.Mantenimiento.Controls.Add(Me.txtPassword)
        Me.Mantenimiento.Controls.Add(Me.Label4)
        Me.Mantenimiento.Controls.Add(Me.txtRPassword)
        Me.Mantenimiento.Location = New System.Drawing.Point(403, 3)
        Me.Mantenimiento.Name = "Mantenimiento"
        Me.Mantenimiento.Size = New System.Drawing.Size(355, 430)
        Me.Mantenimiento.TabIndex = 29
        Me.Mantenimiento.TabStop = False
        Me.Mantenimiento.Text = "Mantenimiento"
        '
        'chkPassword
        '
        Me.chkPassword.AutoSize = True
        Me.chkPassword.Location = New System.Drawing.Point(125, 110)
        Me.chkPassword.Name = "chkPassword"
        Me.chkPassword.Size = New System.Drawing.Size(118, 17)
        Me.chkPassword.TabIndex = 74
        Me.chkPassword.Text = "Mostrar Contraseña"
        Me.chkPassword.UseVisualStyleBackColor = True
        '
        'rtxtMsg
        '
        Me.rtxtMsg.BackColor = System.Drawing.SystemColors.Control
        Me.rtxtMsg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtMsg.Enabled = False
        Me.rtxtMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtMsg.ForeColor = System.Drawing.Color.DarkRed
        Me.rtxtMsg.Location = New System.Drawing.Point(10, 228)
        Me.rtxtMsg.Name = "rtxtMsg"
        Me.rtxtMsg.ReadOnly = True
        Me.rtxtMsg.Size = New System.Drawing.Size(337, 81)
        Me.rtxtMsg.TabIndex = 30
        Me.rtxtMsg.Text = ""
        Me.rtxtMsg.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Estado"
        '
        'rbInactivo
        '
        Me.rbInactivo.AutoSize = True
        Me.rbInactivo.Enabled = False
        Me.rbInactivo.Location = New System.Drawing.Point(203, 159)
        Me.rbInactivo.Name = "rbInactivo"
        Me.rbInactivo.Size = New System.Drawing.Size(63, 17)
        Me.rbInactivo.TabIndex = 21
        Me.rbInactivo.Text = "Inactivo"
        Me.rbInactivo.UseVisualStyleBackColor = True
        '
        'rbActivo
        '
        Me.rbActivo.AutoSize = True
        Me.rbActivo.Checked = True
        Me.rbActivo.Enabled = False
        Me.rbActivo.Location = New System.Drawing.Point(125, 159)
        Me.rbActivo.Name = "rbActivo"
        Me.rbActivo.Size = New System.Drawing.Size(55, 17)
        Me.rbActivo.TabIndex = 20
        Me.rbActivo.TabStop = True
        Me.rbActivo.Text = "Activo"
        Me.rbActivo.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.Location = New System.Drawing.Point(125, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(179, 13)
        Me.txtCodigo.TabIndex = 26
        Me.txtCodigo.Text = "0"
        Me.txtCodigo.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "btneditar1.png")
        Me.ImageList1.Images.SetKeyName(1, "btneliminar.png")
        '
        'cmsUsuario
        '
        Me.cmsUsuario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiEliminar, Me.tsmiActualizar})
        Me.cmsUsuario.Name = "cmsUsuario"
        Me.cmsUsuario.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.cmsUsuario.Size = New System.Drawing.Size(127, 48)
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(126, 22)
        Me.tsmiEliminar.Text = "Eliminar"
        '
        'tsmiActualizar
        '
        Me.tsmiActualizar.Name = "tsmiActualizar"
        Me.tsmiActualizar.Size = New System.Drawing.Size(126, 22)
        Me.tsmiActualizar.Text = "Actualizar"
        '
        'epUsuario
        '
        Me.epUsuario.ContainerControl = Me
        '
        'ttUsuario
        '
        Me.ttUsuario.BackColor = System.Drawing.SystemColors.GrayText
        '
        'pnlUsuario
        '
        Me.pnlUsuario.Controls.Add(Me.pnlFront)
        Me.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlUsuario.Location = New System.Drawing.Point(0, 56)
        Me.pnlUsuario.Name = "pnlUsuario"
        Me.pnlUsuario.Size = New System.Drawing.Size(798, 453)
        Me.pnlUsuario.TabIndex = 30
        '
        'pnlFront
        '
        Me.pnlFront.Controls.Add(Me.GroupBox1)
        Me.pnlFront.Controls.Add(Me.Mantenimiento)
        Me.pnlFront.Location = New System.Drawing.Point(12, 8)
        Me.pnlFront.Name = "pnlFront"
        Me.pnlFront.Size = New System.Drawing.Size(774, 445)
        Me.pnlFront.TabIndex = 32
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbguardar, Me.tsbcancelar, Me.tsbeliminar, Me.tsbsalir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(798, 53)
        Me.ToolStrip1.TabIndex = 214
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbguardar
        '
        Me.tsbguardar.AutoSize = False
        Me.tsbguardar.Image = Global.Vista.My.Resources.Resources.guardar
        Me.tsbguardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbguardar.Name = "tsbguardar"
        Me.tsbguardar.Size = New System.Drawing.Size(100, 50)
        Me.tsbguardar.Text = "Guardar"
        '
        'tsbcancelar
        '
        Me.tsbcancelar.AutoSize = False
        Me.tsbcancelar.Image = Global.Vista.My.Resources.Resources.salir
        Me.tsbcancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbcancelar.Name = "tsbcancelar"
        Me.tsbcancelar.Size = New System.Drawing.Size(100, 47)
        Me.tsbcancelar.Text = "Cancelar"
        '
        'tsbeliminar
        '
        Me.tsbeliminar.AutoSize = False
        Me.tsbeliminar.Image = Global.Vista.My.Resources.Resources.eleminar_true
        Me.tsbeliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbeliminar.Name = "tsbeliminar"
        Me.tsbeliminar.Size = New System.Drawing.Size(100, 47)
        Me.tsbeliminar.Text = "Eliminar"
        '
        'tsbsalir
        '
        Me.tsbsalir.AutoSize = False
        Me.tsbsalir.Image = Global.Vista.My.Resources.Resources.log_logout_door_1563
        Me.tsbsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbsalir.Name = "tsbsalir"
        Me.tsbsalir.Size = New System.Drawing.Size(100, 47)
        Me.tsbsalir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(798, 509)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pnlUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Usuario"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Mantenimiento.ResumeLayout(False)
        Me.Mantenimiento.PerformLayout()
        Me.cmsUsuario.ResumeLayout(False)
        CType(Me.epUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUsuario.ResumeLayout(False)
        Me.pnlFront.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lbEmpresaActivosUsuario As ListBox
    Friend WithEvents lbModuloUsuario As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Mantenimiento As GroupBox
    Friend WithEvents cmsUsuario As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiActualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNroModulo As System.Windows.Forms.Label
    Friend WithEvents lblEmpresaCantActivas As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents epUsuario As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents rbInactivo As RadioButton
    Friend WithEvents rbActivo As RadioButton
    Friend WithEvents rtxtMsg As RichTextBox
    Friend WithEvents ttUsuario As ToolTip
    Friend WithEvents chkPassword As CheckBox
    Friend WithEvents pnlUsuario As Panel
    Friend WithEvents pnlFront As Panel
    Friend WithEvents lbEmpresaInactivos As ListBox
    Friend WithEvents lblEmpresaCantInactivas As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ColId As DataGridViewTextBoxColumn
    Friend WithEvents ColPassword As DataGridViewTextBoxColumn
    Friend WithEvents ColUsuario As DataGridViewTextBoxColumn
    Friend WithEvents ColState As DataGridViewTextBoxColumn
    Friend WithEvents ColStateString As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbguardar As ToolStripButton
    Friend WithEvents tsbcancelar As ToolStripButton
    Friend WithEvents tsbeliminar As ToolStripButton
    Friend WithEvents tsbsalir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
