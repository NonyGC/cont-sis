<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numUsuarios = New System.Windows.Forms.NumericUpDown()
        Me.numEmpresas = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.chkAdmin = New System.Windows.Forms.CheckBox()
        Me.pbConfiguracion = New System.Windows.Forms.ProgressBar()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.dgvEmpresa = New System.Windows.Forms.DataGridView()
        Me.ColRzn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bwConfiguracion = New System.ComponentModel.BackgroundWorker()
        Me.tmrConfiguracion = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbcrear = New System.Windows.Forms.ToolStripButton()
        Me.tsbsalir = New System.Windows.Forms.ToolStripButton()
        CType(Me.numUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° de Usuarios"
        '
        'numUsuarios
        '
        Me.numUsuarios.Location = New System.Drawing.Point(374, 38)
        Me.numUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.numUsuarios.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numUsuarios.Name = "numUsuarios"
        Me.numUsuarios.Size = New System.Drawing.Size(172, 24)
        Me.numUsuarios.TabIndex = 1
        Me.numUsuarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numUsuarios.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'numEmpresas
        '
        Me.numEmpresas.Location = New System.Drawing.Point(374, 74)
        Me.numEmpresas.Margin = New System.Windows.Forms.Padding(4)
        Me.numEmpresas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numEmpresas.Name = "numEmpresas"
        Me.numEmpresas.Size = New System.Drawing.Size(172, 24)
        Me.numEmpresas.TabIndex = 3
        Me.numEmpresas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numEmpresas.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "N° de Empresas"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(434, 153)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 32)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Activar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'chkAdmin
        '
        Me.chkAdmin.Location = New System.Drawing.Point(374, 114)
        Me.chkAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAdmin.Name = "chkAdmin"
        Me.chkAdmin.Size = New System.Drawing.Size(170, 33)
        Me.chkAdmin.TabIndex = 7
        Me.chkAdmin.Text = "Activar Admin"
        Me.chkAdmin.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chkAdmin.UseVisualStyleBackColor = True
        '
        'pbConfiguracion
        '
        Me.pbConfiguracion.Location = New System.Drawing.Point(13, 173)
        Me.pbConfiguracion.Name = "pbConfiguracion"
        Me.pbConfiguracion.Size = New System.Drawing.Size(413, 23)
        Me.pbConfiguracion.TabIndex = 9
        Me.pbConfiguracion.Visible = False
        '
        'lblCant
        '
        Me.lblCant.Location = New System.Drawing.Point(434, 173)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblCant.Size = New System.Drawing.Size(113, 23)
        Me.lblCant.TabIndex = 10
        Me.lblCant.Text = "Estado"
        Me.lblCant.Visible = False
        '
        'dgvEmpresa
        '
        Me.dgvEmpresa.AllowUserToAddRows = False
        Me.dgvEmpresa.AllowUserToDeleteRows = False
        Me.dgvEmpresa.AllowUserToResizeRows = False
        Me.dgvEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpresa.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpresa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColRzn, Me.ColEstado})
        Me.dgvEmpresa.Location = New System.Drawing.Point(6, 23)
        Me.dgvEmpresa.Name = "dgvEmpresa"
        Me.dgvEmpresa.RowHeadersVisible = False
        Me.dgvEmpresa.Size = New System.Drawing.Size(540, 135)
        Me.dgvEmpresa.TabIndex = 11
        '
        'ColRzn
        '
        Me.ColRzn.DataPropertyName = "rz"
        Me.ColRzn.FillWeight = 149.2386!
        Me.ColRzn.HeaderText = "Razón Social"
        Me.ColRzn.Name = "ColRzn"
        Me.ColRzn.ReadOnly = True
        '
        'ColEstado
        '
        Me.ColEstado.DataPropertyName = "estado"
        Me.ColEstado.FillWeight = 50.76142!
        Me.ColEstado.HeaderText = "Estado"
        Me.ColEstado.Name = "ColEstado"
        Me.ColEstado.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.numUsuarios)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.numEmpresas)
        Me.GroupBox1.Controls.Add(Me.chkAdmin)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 192)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Permiso"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvEmpresa)
        Me.GroupBox2.Controls.Add(Me.pbConfiguracion)
        Me.GroupBox2.Controls.Add(Me.lblCant)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(553, 244)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Empresa"
        '
        'bwConfiguracion
        '
        Me.bwConfiguracion.WorkerReportsProgress = True
        Me.bwConfiguracion.WorkerSupportsCancellation = True
        '
        'tmrConfiguracion
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbcrear, Me.tsbsalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(581, 53)
        Me.ToolStrip1.TabIndex = 213
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbcrear
        '
        Me.tsbcrear.AutoSize = False
        Me.tsbcrear.Image = Global.Vista.My.Resources.Resources.crear
        Me.tsbcrear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbcrear.Name = "tsbcrear"
        Me.tsbcrear.Size = New System.Drawing.Size(100, 50)
        Me.tsbcrear.Text = "Crear"
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
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(581, 470)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        CType(Me.numUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents numUsuarios As NumericUpDown
    Friend WithEvents numEmpresas As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents chkAdmin As CheckBox
    Friend WithEvents pbConfiguracion As ProgressBar
    Friend WithEvents lblCant As Label
    Friend WithEvents dgvEmpresa As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ColRzn As DataGridViewTextBoxColumn
    Friend WithEvents ColEstado As DataGridViewTextBoxColumn
    Friend WithEvents bwConfiguracion As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrConfiguracion As Timer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbcrear As ToolStripButton
    Friend WithEvents tsbsalir As ToolStripButton
End Class
