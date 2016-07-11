<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPlanCuentasAdicional
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txtpath = New System.Windows.Forms.TextBox()
        Me.rbHeaderNo = New System.Windows.Forms.RadioButton()
        Me.rbHeaderYes = New System.Windows.Forms.RadioButton()
        Me.btnprevista = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTImport = New System.Windows.Forms.DataGridView()
        Me.btnpath = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbguardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbcancelar = New System.Windows.Forms.ToolStripButton()
        Me.tsbsalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtini = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.cbohoja = New System.Windows.Forms.ComboBox()
        CType(Me.DTImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtpath
        '
        Me.txtpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpath.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpath.Location = New System.Drawing.Point(89, 60)
        Me.txtpath.Name = "txtpath"
        Me.txtpath.Size = New System.Drawing.Size(295, 25)
        Me.txtpath.TabIndex = 175
        '
        'rbHeaderNo
        '
        Me.rbHeaderNo.AutoSize = True
        Me.rbHeaderNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHeaderNo.Location = New System.Drawing.Point(67, 28)
        Me.rbHeaderNo.Name = "rbHeaderNo"
        Me.rbHeaderNo.Size = New System.Drawing.Size(44, 21)
        Me.rbHeaderNo.TabIndex = 173
        Me.rbHeaderNo.Text = "No"
        Me.rbHeaderNo.UseVisualStyleBackColor = True
        '
        'rbHeaderYes
        '
        Me.rbHeaderYes.AutoSize = True
        Me.rbHeaderYes.Checked = True
        Me.rbHeaderYes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHeaderYes.Location = New System.Drawing.Point(22, 28)
        Me.rbHeaderYes.Name = "rbHeaderYes"
        Me.rbHeaderYes.Size = New System.Drawing.Size(36, 21)
        Me.rbHeaderYes.TabIndex = 174
        Me.rbHeaderYes.TabStop = True
        Me.rbHeaderYes.Text = "Si"
        Me.rbHeaderYes.UseVisualStyleBackColor = True
        '
        'btnprevista
        '
        Me.btnprevista.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnprevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprevista.Location = New System.Drawing.Point(409, 88)
        Me.btnprevista.Name = "btnprevista"
        Me.btnprevista.Size = New System.Drawing.Size(75, 26)
        Me.btnprevista.TabIndex = 170
        Me.btnprevista.Text = "Verificar"
        Me.btnprevista.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 169
        Me.Label2.Text = "Hoja Excel"
        '
        'DTImport
        '
        Me.DTImport.AllowUserToAddRows = False
        Me.DTImport.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DTImport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DTImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTImport.Location = New System.Drawing.Point(12, 124)
        Me.DTImport.Name = "DTImport"
        Me.DTImport.RowHeadersVisible = False
        Me.DTImport.Size = New System.Drawing.Size(690, 202)
        Me.DTImport.TabIndex = 168
        '
        'btnpath
        '
        Me.btnpath.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpath.Location = New System.Drawing.Point(409, 57)
        Me.btnpath.Name = "btnpath"
        Me.btnpath.Size = New System.Drawing.Size(75, 26)
        Me.btnpath.TabIndex = 166
        Me.btnpath.Text = "Buscar"
        Me.btnpath.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Ubicación"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbguardar, Me.tsbcancelar, Me.tsbsalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(717, 53)
        Me.ToolStrip1.TabIndex = 213
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
        'tsbsalir
        '
        Me.tsbsalir.AutoSize = False
        Me.tsbsalir.Image = Global.Vista.My.Resources.Resources.log_logout_door_1563
        Me.tsbsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbsalir.Name = "tsbsalir"
        Me.tsbsalir.Size = New System.Drawing.Size(100, 47)
        Me.tsbsalir.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbHeaderYes)
        Me.GroupBox1.Controls.Add(Me.rbHeaderNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(490, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(122, 62)
        Me.GroupBox1.TabIndex = 214
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cabecera"
        '
        'txtini
        '
        Me.txtini.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtini.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtini, "Ingrese la celda donde inicia los datos")
        Me.txtini.Location = New System.Drawing.Point(245, 91)
        Me.txtini.Name = "txtini"
        Me.HelpProvider1.SetShowHelp(Me.txtini, True)
        Me.txtini.Size = New System.Drawing.Size(50, 25)
        Me.txtini.TabIndex = 216
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(201, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 215
        Me.Label3.Text = "Inicio"
        '
        'txtfin
        '
        Me.txtfin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtfin, "Ingrese la celda donde terminan los datos a importar")
        Me.txtfin.Location = New System.Drawing.Point(334, 91)
        Me.txtfin.Name = "txtfin"
        Me.HelpProvider1.SetShowHelp(Me.txtfin, True)
        Me.txtfin.Size = New System.Drawing.Size(50, 25)
        Me.txtfin.TabIndex = 218
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(304, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 17)
        Me.Label4.TabIndex = 217
        Me.Label4.Text = "Fin"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 339)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(717, 22)
        Me.StatusStrip1.TabIndex = 219
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'cbohoja
        '
        Me.cbohoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbohoja.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbohoja.FormattingEnabled = True
        Me.cbohoja.Location = New System.Drawing.Point(89, 93)
        Me.cbohoja.Name = "cbohoja"
        Me.cbohoja.Size = New System.Drawing.Size(106, 25)
        Me.cbohoja.TabIndex = 220
        '
        'FrmPlanCuentasAdicional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 361)
        Me.Controls.Add(Me.cbohoja)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtfin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtini)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtpath)
        Me.Controls.Add(Me.btnprevista)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTImport)
        Me.Controls.Add(Me.btnpath)
        Me.Controls.Add(Me.Label1)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPlanCuentasAdicional"
        Me.Text = "Importar Plan Contable"
        CType(Me.DTImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtpath As TextBox
    Friend WithEvents rbHeaderNo As RadioButton
    Friend WithEvents rbHeaderYes As RadioButton
    Friend WithEvents btnprevista As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DTImport As DataGridView
    Friend WithEvents btnpath As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbguardar As ToolStripButton
    Friend WithEvents tsbcancelar As ToolStripButton
    Friend WithEvents tsbsalir As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtini As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtfin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ProgressBar1 As ToolStripProgressBar
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents cbohoja As ComboBox
End Class
