<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracionReporte
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.nmrCopias = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboImpresora = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnDestinoExcel = New System.Windows.Forms.Button()
        Me.btnDestinoPDF = New System.Windows.Forms.Button()
        Me.txtDestinoExcel = New System.Windows.Forms.TextBox()
        Me.txtDestinoPDF = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNamExcel = New System.Windows.Forms.Label()
        Me.txtNamExcel = New System.Windows.Forms.TextBox()
        Me.rdEXCEL = New System.Windows.Forms.RadioButton()
        Me.rbBD = New System.Windows.Forms.RadioButton()
        Me.GroupBox6.SuspendLayout()
        CType(Me.nmrCopias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.nmrCopias)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.cboImpresora)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Location = New System.Drawing.Point(7, 184)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(464, 84)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Impresión"
        '
        'nmrCopias
        '
        Me.nmrCopias.Location = New System.Drawing.Point(119, 47)
        Me.nmrCopias.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nmrCopias.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrCopias.Name = "nmrCopias"
        Me.nmrCopias.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nmrCopias.Size = New System.Drawing.Size(49, 20)
        Me.nmrCopias.TabIndex = 3
        Me.nmrCopias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nmrCopias.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Numero de Copias"
        '
        'cboImpresora
        '
        Me.cboImpresora.FormattingEnabled = True
        Me.cboImpresora.Location = New System.Drawing.Point(119, 22)
        Me.cboImpresora.Name = "cboImpresora"
        Me.cboImpresora.Size = New System.Drawing.Size(298, 21)
        Me.cboImpresora.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nombre"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnDestinoExcel)
        Me.GroupBox4.Controls.Add(Me.btnDestinoPDF)
        Me.GroupBox4.Controls.Add(Me.txtDestinoExcel)
        Me.GroupBox4.Controls.Add(Me.txtDestinoPDF)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 98)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(464, 80)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Destino"
        '
        'btnDestinoExcel
        '
        Me.btnDestinoExcel.Location = New System.Drawing.Point(384, 45)
        Me.btnDestinoExcel.Name = "btnDestinoExcel"
        Me.btnDestinoExcel.Size = New System.Drawing.Size(45, 23)
        Me.btnDestinoExcel.TabIndex = 5
        Me.btnDestinoExcel.Text = "..."
        Me.btnDestinoExcel.UseVisualStyleBackColor = True
        '
        'btnDestinoPDF
        '
        Me.btnDestinoPDF.Location = New System.Drawing.Point(384, 18)
        Me.btnDestinoPDF.Name = "btnDestinoPDF"
        Me.btnDestinoPDF.Size = New System.Drawing.Size(45, 23)
        Me.btnDestinoPDF.TabIndex = 4
        Me.btnDestinoPDF.Text = "..."
        Me.btnDestinoPDF.UseVisualStyleBackColor = True
        '
        'txtDestinoExcel
        '
        Me.txtDestinoExcel.BackColor = System.Drawing.SystemColors.Control
        Me.txtDestinoExcel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDestinoExcel.Enabled = False
        Me.txtDestinoExcel.Location = New System.Drawing.Point(43, 50)
        Me.txtDestinoExcel.Name = "txtDestinoExcel"
        Me.txtDestinoExcel.Size = New System.Drawing.Size(335, 13)
        Me.txtDestinoExcel.TabIndex = 3
        Me.txtDestinoExcel.Text = "D:/ExportSoft/Excel"
        '
        'txtDestinoPDF
        '
        Me.txtDestinoPDF.BackColor = System.Drawing.SystemColors.Control
        Me.txtDestinoPDF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDestinoPDF.Enabled = False
        Me.txtDestinoPDF.Location = New System.Drawing.Point(43, 24)
        Me.txtDestinoPDF.Name = "txtDestinoPDF"
        Me.txtDestinoPDF.Size = New System.Drawing.Size(335, 13)
        Me.txtDestinoPDF.TabIndex = 2
        Me.txtDestinoPDF.Text = "D:/ExportSoft/PDF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Excel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "PDF"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNamExcel)
        Me.GroupBox1.Controls.Add(Me.txtNamExcel)
        Me.GroupBox1.Controls.Add(Me.rdEXCEL)
        Me.GroupBox1.Controls.Add(Me.rbBD)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 80)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Origen"
        '
        'lblNamExcel
        '
        Me.lblNamExcel.AutoSize = True
        Me.lblNamExcel.Location = New System.Drawing.Point(76, 44)
        Me.lblNamExcel.Name = "lblNamExcel"
        Me.lblNamExcel.Size = New System.Drawing.Size(130, 13)
        Me.lblNamExcel.TabIndex = 5
        Me.lblNamExcel.Text = "Nombre del Hoja de Excel"
        Me.lblNamExcel.Visible = False
        '
        'txtNamExcel
        '
        Me.txtNamExcel.Location = New System.Drawing.Point(212, 41)
        Me.txtNamExcel.Name = "txtNamExcel"
        Me.txtNamExcel.Size = New System.Drawing.Size(242, 20)
        Me.txtNamExcel.TabIndex = 4
        Me.txtNamExcel.Text = "Formato81"
        Me.txtNamExcel.Visible = False
        '
        'rdEXCEL
        '
        Me.rdEXCEL.AutoSize = True
        Me.rdEXCEL.Location = New System.Drawing.Point(10, 41)
        Me.rdEXCEL.Name = "rdEXCEL"
        Me.rdEXCEL.Size = New System.Drawing.Size(59, 17)
        Me.rdEXCEL.TabIndex = 3
        Me.rdEXCEL.Text = "EXCEL"
        Me.rdEXCEL.UseVisualStyleBackColor = True
        '
        'rbBD
        '
        Me.rbBD.AutoSize = True
        Me.rbBD.Checked = True
        Me.rbBD.Location = New System.Drawing.Point(11, 19)
        Me.rbBD.Name = "rbBD"
        Me.rbBD.Size = New System.Drawing.Size(40, 17)
        Me.rbBD.TabIndex = 2
        Me.rbBD.TabStop = True
        Me.rbBD.Text = "BD"
        Me.rbBD.UseVisualStyleBackColor = True
        '
        'frmConfiguracionReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 276)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.MaximumSize = New System.Drawing.Size(500, 315)
        Me.MinimumSize = New System.Drawing.Size(500, 315)
        Me.Name = "frmConfiguracionReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración Avanzada"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.nmrCopias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents nmrCopias As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents cboImpresora As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnDestinoExcel As Button
    Friend WithEvents btnDestinoPDF As Button
    Friend WithEvents txtDestinoExcel As TextBox
    Friend WithEvents txtDestinoPDF As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdEXCEL As RadioButton
    Friend WithEvents rbBD As RadioButton
    Friend WithEvents lblNamExcel As Label
    Friend WithEvents txtNamExcel As TextBox
End Class
