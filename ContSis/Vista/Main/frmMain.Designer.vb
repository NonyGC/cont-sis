<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MnuMain = New System.Windows.Forms.MenuStrip()
        Me.staMain = New System.Windows.Forms.StatusStrip()
        Me.tooUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tooEmpresa = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tooForm = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tooActionForm = New System.Windows.Forms.ToolStripStatusLabel()
        Me.notMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsNotifyIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblEjercicio = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.staMain.SuspendLayout()
        Me.cmsNotifyIcon.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MnuMain
        '
        Me.MnuMain.AutoSize = False
        Me.MnuMain.Location = New System.Drawing.Point(0, 0)
        Me.MnuMain.Name = "MnuMain"
        Me.MnuMain.Size = New System.Drawing.Size(568, 30)
        Me.MnuMain.TabIndex = 1
        '
        'staMain
        '
        Me.staMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tooUsuario, Me.tooEmpresa, Me.tooForm, Me.tooActionForm})
        Me.staMain.Location = New System.Drawing.Point(0, 347)
        Me.staMain.Name = "staMain"
        Me.staMain.Size = New System.Drawing.Size(568, 22)
        Me.staMain.SizingGrip = False
        Me.staMain.TabIndex = 3
        Me.staMain.Text = "StatusStrip1"
        '
        'tooUsuario
        '
        Me.tooUsuario.AutoSize = False
        Me.tooUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.tooUsuario.Name = "tooUsuario"
        Me.tooUsuario.Size = New System.Drawing.Size(100, 17)
        Me.tooUsuario.Text = "Usuario"
        '
        'tooEmpresa
        '
        Me.tooEmpresa.AutoSize = False
        Me.tooEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.tooEmpresa.Name = "tooEmpresa"
        Me.tooEmpresa.Size = New System.Drawing.Size(100, 17)
        Me.tooEmpresa.Text = "Empresa"
        '
        'tooForm
        '
        Me.tooForm.AutoSize = False
        Me.tooForm.BackColor = System.Drawing.SystemColors.Control
        Me.tooForm.Name = "tooForm"
        Me.tooForm.Size = New System.Drawing.Size(100, 17)
        Me.tooForm.Text = "Form"
        '
        'tooActionForm
        '
        Me.tooActionForm.AutoSize = False
        Me.tooActionForm.BackColor = System.Drawing.SystemColors.Control
        Me.tooActionForm.Name = "tooActionForm"
        Me.tooActionForm.Size = New System.Drawing.Size(253, 17)
        Me.tooActionForm.Spring = True
        Me.tooActionForm.Text = "Acción Form"
        '
        'notMain
        '
        Me.notMain.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.notMain.BalloonTipTitle = "ContMain"
        Me.notMain.ContextMenuStrip = Me.cmsNotifyIcon
        Me.notMain.Icon = CType(resources.GetObject("notMain.Icon"), System.Drawing.Icon)
        Me.notMain.Text = "ConSis"
        Me.notMain.Visible = True
        '
        'cmsNotifyIcon
        '
        Me.cmsNotifyIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.cmsNotifyIcon.Name = "cmsNotifyIcon"
        Me.cmsNotifyIcon.Size = New System.Drawing.Size(101, 48)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripMenuItem1.Text = "Abrir"
        '
        'pnlInfo
        '
        Me.pnlInfo.BackColor = System.Drawing.SystemColors.Control
        Me.pnlInfo.Controls.Add(Me.lblPeriodo)
        Me.pnlInfo.Controls.Add(Me.PictureBox1)
        Me.pnlInfo.Controls.Add(Me.lblEjercicio)
        Me.pnlInfo.Controls.Add(Me.lblUsuario)
        Me.pnlInfo.Controls.Add(Me.lblEmpresa)
        Me.pnlInfo.Enabled = False
        Me.pnlInfo.Location = New System.Drawing.Point(0, 33)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(44, 46)
        Me.pnlInfo.TabIndex = 5
        Me.pnlInfo.Visible = False
        '
        'lblPeriodo
        '
        Me.lblPeriodo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPeriodo.Location = New System.Drawing.Point(12, 192)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(142, 45)
        Me.lblPeriodo.TabIndex = 4
        Me.lblPeriodo.Text = "Periodo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(252, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 34)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblEjercicio
        '
        Me.lblEjercicio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEjercicio.Location = New System.Drawing.Point(13, 137)
        Me.lblEjercicio.Name = "lblEjercicio"
        Me.lblEjercicio.Size = New System.Drawing.Size(142, 55)
        Me.lblEjercicio.TabIndex = 2
        Me.lblEjercicio.Text = "Ejercicio"
        '
        'lblUsuario
        '
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUsuario.Location = New System.Drawing.Point(13, 79)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(142, 47)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuario"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.lblEmpresa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEmpresa.Location = New System.Drawing.Point(13, 19)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(233, 51)
        Me.lblEmpresa.TabIndex = 0
        Me.lblEmpresa.Text = "Empresa"
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Nothing
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(568, 369)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.staMain)
        Me.Controls.Add(Me.MnuMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MnuMain
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestión Contable"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.staMain.ResumeLayout(False)
        Me.staMain.PerformLayout()
        Me.cmsNotifyIcon.ResumeLayout(False)
        Me.pnlInfo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MnuMain As MenuStrip
    Friend WithEvents staMain As StatusStrip
    Friend WithEvents tooUsuario As ToolStripStatusLabel
    Friend WithEvents notMain As NotifyIcon
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblEjercicio As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblEmpresa As Label
    Friend WithEvents tooEmpresa As ToolStripStatusLabel
    Friend WithEvents tooForm As ToolStripStatusLabel
    Friend WithEvents lblPeriodo As Label
    Friend WithEvents tooActionForm As ToolStripStatusLabel
    Friend WithEvents cmsNotifyIcon As ContextMenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
