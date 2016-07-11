<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPlanCuentas
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbohaber = New System.Windows.Forms.ComboBox()
        Me.cbodebe = New System.Windows.Forms.ComboBox()
        Me.lblAmHaber = New System.Windows.Forms.Label()
        Me.lblAmDebe = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtalias = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcuenta = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ErrorV = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbguardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbcancelar = New System.Windows.Forms.ToolStripButton()
        Me.tsbeliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbsalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbexportar = New System.Windows.Forms.ToolStripButton()
        Me.tsbimportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1 Nivel", "2 Nivel", "3 Nivel", "4 Nivel", "5 Nivel"})
        Me.ComboBox1.Location = New System.Drawing.Point(460, 61)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(83, 25)
        Me.ComboBox1.TabIndex = 151
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbohaber)
        Me.GroupBox2.Controls.Add(Me.cbodebe)
        Me.GroupBox2.Controls.Add(Me.lblAmHaber)
        Me.GroupBox2.Controls.Add(Me.lblAmDebe)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(365, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(503, 83)
        Me.GroupBox2.TabIndex = 149
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Amarres"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "C. Haber"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "C. Debe"
        '
        'cbohaber
        '
        Me.cbohaber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbohaber.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbohaber.FormattingEnabled = True
        Me.cbohaber.Location = New System.Drawing.Point(95, 49)
        Me.cbohaber.Name = "cbohaber"
        Me.cbohaber.Size = New System.Drawing.Size(83, 25)
        Me.cbohaber.TabIndex = 17
        '
        'cbodebe
        '
        Me.cbodebe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodebe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodebe.FormattingEnabled = True
        Me.cbodebe.Location = New System.Drawing.Point(95, 19)
        Me.cbodebe.Name = "cbodebe"
        Me.cbodebe.Size = New System.Drawing.Size(83, 25)
        Me.cbodebe.TabIndex = 17
        '
        'lblAmHaber
        '
        Me.lblAmHaber.AutoSize = True
        Me.lblAmHaber.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmHaber.Location = New System.Drawing.Point(187, 52)
        Me.lblAmHaber.Name = "lblAmHaber"
        Me.lblAmHaber.Size = New System.Drawing.Size(0, 17)
        Me.lblAmHaber.TabIndex = 16
        '
        'lblAmDebe
        '
        Me.lblAmDebe.AutoSize = True
        Me.lblAmDebe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmDebe.Location = New System.Drawing.Point(187, 22)
        Me.lblAmDebe.Name = "lblAmDebe"
        Me.lblAmDebe.Size = New System.Drawing.Size(0, 17)
        Me.lblAmDebe.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(368, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 147
        Me.Label7.Text = "Digitos"
        '
        'txtalias
        '
        Me.txtalias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtalias.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtalias.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalias.Location = New System.Drawing.Point(460, 154)
        Me.txtalias.MaxLength = 25
        Me.txtalias.Name = "txtalias"
        Me.txtalias.Size = New System.Drawing.Size(248, 25)
        Me.txtalias.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(367, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Desc. Corta"
        '
        'txtnombre
        '
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(460, 123)
        Me.txtnombre.MaxLength = 150
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(408, 25)
        Me.txtnombre.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(368, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cuenta"
        '
        'txtcuenta
        '
        Me.txtcuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcuenta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcuenta.Location = New System.Drawing.Point(460, 92)
        Me.txtcuenta.MaxLength = 6
        Me.txtcuenta.Name = "txtcuenta"
        Me.txtcuenta.Size = New System.Drawing.Size(83, 25)
        Me.txtcuenta.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(2, 54)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(360, 295)
        Me.ListView1.TabIndex = 211
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ErrorV
        '
        Me.ErrorV.ContainerControl = Me
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbguardar, Me.tsbcancelar, Me.tsbeliminar, Me.ToolStripSeparator1, Me.tsbexportar, Me.tsbimportar, Me.ToolStripSeparator2, Me.tsbsalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(893, 53)
        Me.ToolStrip1.TabIndex = 212
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
        'tsbexportar
        '
        Me.tsbexportar.AutoSize = False
        Me.tsbexportar.Image = Global.Vista.My.Resources.Resources.export_icon
        Me.tsbexportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbexportar.Name = "tsbexportar"
        Me.tsbexportar.Size = New System.Drawing.Size(100, 47)
        Me.tsbexportar.Text = "Exportar"
        '
        'tsbimportar
        '
        Me.tsbimportar.AutoSize = False
        Me.tsbimportar.Image = Global.Vista.My.Resources.Resources.import_icon
        Me.tsbimportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbimportar.Name = "tsbimportar"
        Me.tsbimportar.Size = New System.Drawing.Size(73, 50)
        Me.tsbimportar.Text = "Importar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 53)
        '
        'FrmPlanCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(893, 352)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtalias)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcuenta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPlanCuentas"
        Me.Text = "Administrar Plan Contable"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbohaber As ComboBox
    Friend WithEvents cbodebe As ComboBox
    Friend WithEvents lblAmHaber As Label
    Friend WithEvents lblAmDebe As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtalias As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcuenta As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ErrorV As ErrorProvider
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbguardar As ToolStripButton
    Friend WithEvents tsbcancelar As ToolStripButton
    Friend WithEvents tsbeliminar As ToolStripButton
    Friend WithEvents tsbsalir As ToolStripButton
    Friend WithEvents tsbexportar As ToolStripButton
    Friend WithEvents tsbimportar As ToolStripButton
    Private WithEvents ComboBox1 As ComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
