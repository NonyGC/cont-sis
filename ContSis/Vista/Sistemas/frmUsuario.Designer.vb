<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.ColId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cborol = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtrepass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.lbEmpresa = New System.Windows.Forms.ListBox()
        Me.lbModulo = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNroModulo = New System.Windows.Forms.Label()
        Me.lblNroEmpresa = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Mantenimiento = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.cmsUsuario = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiActualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Mantenimiento.SuspendLayout()
        Me.cmsUsuario.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColId, Me.ColUsuario, Me.ColRol})
        Me.dgvUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvUsuarios.Location = New System.Drawing.Point(21, 31)
        Me.dgvUsuarios.MultiSelect = False
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(368, 156)
        Me.dgvUsuarios.TabIndex = 24
        '
        'ColId
        '
        Me.ColId.HeaderText = "Id"
        Me.ColId.Name = "ColId"
        Me.ColId.ReadOnly = True
        Me.ColId.Visible = False
        '
        'ColUsuario
        '
        Me.ColUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColUsuario.HeaderText = "Usuario"
        Me.ColUsuario.Name = "ColUsuario"
        Me.ColUsuario.ReadOnly = True
        Me.ColUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColUsuario.Width = 183
        '
        'ColRol
        '
        Me.ColRol.HeaderText = "Rol"
        Me.ColRol.Name = "ColRol"
        Me.ColRol.ReadOnly = True
        Me.ColRol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'cborol
        '
        Me.cborol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cborol.FormattingEnabled = True
        Me.cborol.Location = New System.Drawing.Point(125, 135)
        Me.cborol.Name = "cborol"
        Me.cborol.Size = New System.Drawing.Size(121, 21)
        Me.cborol.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Rol"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(272, 328)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Salir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(191, 328)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(10, 328)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 23)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Nuevo Usuario"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(110, 328)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 21
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtrepass
        '
        Me.txtrepass.Location = New System.Drawing.Point(125, 107)
        Me.txtrepass.Name = "txtrepass"
        Me.txtrepass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtrepass.Size = New System.Drawing.Size(179, 20)
        Me.txtrepass.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Repetir Contraseña"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(125, 81)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(179, 20)
        Me.txtpass.TabIndex = 16
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
        'txtusu
        '
        Me.txtusu.Location = New System.Drawing.Point(125, 55)
        Me.txtusu.Name = "txtusu"
        Me.txtusu.Size = New System.Drawing.Size(179, 20)
        Me.txtusu.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre"
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
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(252, 133)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(52, 23)
        Me.Button6.TabIndex = 25
        Me.Button6.Text = "Nuevo"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'lbEmpresa
        '
        Me.lbEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.lbEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbEmpresa.FormattingEnabled = True
        Me.lbEmpresa.Location = New System.Drawing.Point(21, 217)
        Me.lbEmpresa.Name = "lbEmpresa"
        Me.lbEmpresa.Size = New System.Drawing.Size(180, 108)
        Me.lbEmpresa.TabIndex = 26
        '
        'lbModulo
        '
        Me.lbModulo.BackColor = System.Drawing.SystemColors.Control
        Me.lbModulo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbModulo.FormattingEnabled = True
        Me.lbModulo.Location = New System.Drawing.Point(208, 217)
        Me.lbModulo.Name = "lbModulo"
        Me.lbModulo.Size = New System.Drawing.Size(181, 108)
        Me.lbModulo.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNroModulo)
        Me.GroupBox1.Controls.Add(Me.lblNroEmpresa)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbEmpresa)
        Me.GroupBox1.Controls.Add(Me.lbModulo)
        Me.GroupBox1.Controls.Add(Me.dgvUsuarios)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 366)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'lblNroModulo
        '
        Me.lblNroModulo.AutoSize = True
        Me.lblNroModulo.Location = New System.Drawing.Point(205, 338)
        Me.lblNroModulo.Name = "lblNroModulo"
        Me.lblNroModulo.Size = New System.Drawing.Size(63, 13)
        Me.lblNroModulo.TabIndex = 31
        Me.lblNroModulo.Text = "N° Modulo: "
        '
        'lblNroEmpresa
        '
        Me.lblNroEmpresa.AutoSize = True
        Me.lblNroEmpresa.Location = New System.Drawing.Point(18, 338)
        Me.lblNroEmpresa.Name = "lblNroEmpresa"
        Me.lblNroEmpresa.Size = New System.Drawing.Size(66, 13)
        Me.lblNroEmpresa.TabIndex = 30
        Me.lblNroEmpresa.Text = "N° Empresa:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(205, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Modulos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Empresa"
        '
        'Mantenimiento
        '
        Me.Mantenimiento.Controls.Add(Me.txtCodigo)
        Me.Mantenimiento.Controls.Add(Me.Button5)
        Me.Mantenimiento.Controls.Add(Me.lblUsuario)
        Me.Mantenimiento.Controls.Add(Me.Button6)
        Me.Mantenimiento.Controls.Add(Me.cborol)
        Me.Mantenimiento.Controls.Add(Me.Label5)
        Me.Mantenimiento.Controls.Add(Me.Label2)
        Me.Mantenimiento.Controls.Add(Me.Button4)
        Me.Mantenimiento.Controls.Add(Me.txtusu)
        Me.Mantenimiento.Controls.Add(Me.Button3)
        Me.Mantenimiento.Controls.Add(Me.Label3)
        Me.Mantenimiento.Controls.Add(Me.txtpass)
        Me.Mantenimiento.Controls.Add(Me.btnGuardar)
        Me.Mantenimiento.Controls.Add(Me.Label4)
        Me.Mantenimiento.Controls.Add(Me.txtrepass)
        Me.Mantenimiento.Location = New System.Drawing.Point(424, 12)
        Me.Mantenimiento.Name = "Mantenimiento"
        Me.Mantenimiento.Size = New System.Drawing.Size(362, 366)
        Me.Mantenimiento.TabIndex = 29
        Me.Mantenimiento.TabStop = False
        Me.Mantenimiento.Text = "Mantenimiento"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.Location = New System.Drawing.Point(125, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(179, 13)
        Me.txtCodigo.TabIndex = 26
        Me.txtCodigo.Visible = False
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(798, 397)
        Me.Controls.Add(Me.Mantenimiento)
        Me.Controls.Add(Me.GroupBox1)
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
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents cborol As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtrepass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents lbEmpresa As ListBox
    Friend WithEvents lbModulo As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Mantenimiento As GroupBox
    Friend WithEvents cmsUsuario As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiActualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColRol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNroModulo As System.Windows.Forms.Label
    Friend WithEvents lblNroEmpresa As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
