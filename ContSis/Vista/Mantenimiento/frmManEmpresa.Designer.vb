<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmManEmpresa
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbodist = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboprovi = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbodepa = New System.Windows.Forms.ComboBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtalias = New System.Windows.Forms.TextBox()
        Me.txtrz = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pbimagen = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbguardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbcancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbsalir = New System.Windows.Forms.ToolStripButton()
        Me.cboruc = New System.Windows.Forms.ComboBox()
        Me.txtnivel = New System.Windows.Forms.TextBox()
        CType(Me.pbimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(55, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Distrito"
        '
        'cbodist
        '
        Me.cbodist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodist.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodist.FormattingEnabled = True
        Me.cbodist.Items.AddRange(New Object() {"6", "7", "8", "9", "10", "11", "12"})
        Me.cbodist.Location = New System.Drawing.Point(114, 273)
        Me.cbodist.Name = "cbodist"
        Me.cbodist.Size = New System.Drawing.Size(181, 25)
        Me.cbodist.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 17)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Provincia"
        '
        'cboprovi
        '
        Me.cboprovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboprovi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboprovi.FormattingEnabled = True
        Me.cboprovi.Items.AddRange(New Object() {"6", "7", "8", "9", "10", "11", "12"})
        Me.cboprovi.Location = New System.Drawing.Point(114, 242)
        Me.cboprovi.Name = "cboprovi"
        Me.cboprovi.Size = New System.Drawing.Size(181, 25)
        Me.cboprovi.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 17)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Departamento"
        '
        'cbodepa
        '
        Me.cbodepa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodepa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodepa.FormattingEnabled = True
        Me.cbodepa.Items.AddRange(New Object() {"6", "7", "8", "9", "10", "11", "12"})
        Me.cbodepa.Location = New System.Drawing.Point(114, 211)
        Me.cbodepa.Name = "cbodepa"
        Me.cbodepa.Size = New System.Drawing.Size(181, 25)
        Me.cbodepa.TabIndex = 50
        '
        'txtcodigo
        '
        Me.txtcodigo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(114, 87)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(57, 25)
        Me.txtcodigo.TabIndex = 49
        '
        'txtalias
        '
        Me.txtalias.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalias.Location = New System.Drawing.Point(114, 149)
        Me.txtalias.MaxLength = 50
        Me.txtalias.Name = "txtalias"
        Me.txtalias.Size = New System.Drawing.Size(181, 25)
        Me.txtalias.TabIndex = 48
        '
        'txtrz
        '
        Me.txtrz.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrz.Location = New System.Drawing.Point(114, 118)
        Me.txtrz.MaxLength = 100
        Me.txtrz.Name = "txtrz"
        Me.txtrz.Size = New System.Drawing.Size(181, 25)
        Me.txtrz.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Codigo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Nivel"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(360, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Subir imagen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pbimagen
        '
        Me.pbimagen.BackgroundImage = Global.Vista.My.Resources.Resources.No_Image_Available
        Me.pbimagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbimagen.InitialImage = Nothing
        Me.pbimagen.Location = New System.Drawing.Point(307, 67)
        Me.pbimagen.Name = "pbimagen"
        Me.pbimagen.Size = New System.Drawing.Size(200, 200)
        Me.pbimagen.TabIndex = 40
        Me.pbimagen.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Alias"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Razon Social"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "RUC"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbguardar, Me.tsbcancelar, Me.ToolStripSeparator1, Me.tsbsalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(521, 53)
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
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
        'cboruc
        '
        Me.cboruc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboruc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboruc.FormattingEnabled = True
        Me.cboruc.Location = New System.Drawing.Point(114, 56)
        Me.cboruc.Name = "cboruc"
        Me.cboruc.Size = New System.Drawing.Size(121, 25)
        Me.cboruc.TabIndex = 214
        '
        'txtnivel
        '
        Me.txtnivel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnivel.Location = New System.Drawing.Point(114, 180)
        Me.txtnivel.Name = "txtnivel"
        Me.txtnivel.Size = New System.Drawing.Size(57, 25)
        Me.txtnivel.TabIndex = 215
        '
        'FrmManEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(521, 323)
        Me.Controls.Add(Me.txtnivel)
        Me.Controls.Add(Me.cboruc)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbodist)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboprovi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbodepa)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.txtalias)
        Me.Controls.Add(Me.txtrz)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pbimagen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmManEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.pbimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents cbodist As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboprovi As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbodepa As ComboBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtalias As TextBox
    Friend WithEvents txtrz As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents pbimagen As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbguardar As ToolStripButton
    Friend WithEvents tsbcancelar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbsalir As ToolStripButton
    Friend WithEvents cboruc As ComboBox
    Friend WithEvents txtnivel As TextBox
End Class
