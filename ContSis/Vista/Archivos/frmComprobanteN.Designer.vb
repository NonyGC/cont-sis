<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComprobanteN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComprobanteN))
        Me.dtpFechae = New System.Windows.Forms.DateTimePicker()
        Me.ErrorIcon = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dtpFechav = New System.Windows.Forms.DateTimePicker()
        Me.txtnumcompro = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbomoneda = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIsc = New System.Windows.Forms.TextBox()
        Me.txtIgv = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.cboAdq = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCuentaTotal = New System.Windows.Forms.TextBox()
        Me.txtCuentaIgv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCuentaIsc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCuentaMonto = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbotipodoc = New System.Windows.Forms.ComboBox()
        Me.txtDserie = New System.Windows.Forms.TextBox()
        Me.txtDnumero = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.ErrorIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpFechae
        '
        Me.dtpFechae.Checked = False
        Me.dtpFechae.CustomFormat = "  "
        Me.dtpFechae.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechae.Location = New System.Drawing.Point(540, 80)
        Me.dtpFechae.Name = "dtpFechae"
        Me.dtpFechae.ShowCheckBox = True
        Me.dtpFechae.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechae.TabIndex = 189
        Me.dtpFechae.Value = New Date(2016, 6, 12, 0, 0, 0, 0)
        '
        'ErrorIcon
        '
        Me.ErrorIcon.ContainerControl = Me
        Me.ErrorIcon.Icon = CType(resources.GetObject("ErrorIcon.Icon"), System.Drawing.Icon)
        '
        'dtpFechav
        '
        Me.dtpFechav.Checked = False
        Me.dtpFechav.CustomFormat = "  "
        Me.dtpFechav.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechav.Location = New System.Drawing.Point(540, 110)
        Me.dtpFechav.Name = "dtpFechav"
        Me.dtpFechav.ShowCheckBox = True
        Me.dtpFechav.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechav.TabIndex = 190
        '
        'txtnumcompro
        '
        Me.txtnumcompro.Enabled = False
        Me.txtnumcompro.Location = New System.Drawing.Point(110, 61)
        Me.txtnumcompro.MaxLength = 4
        Me.txtnumcompro.Name = "txtnumcompro"
        Me.txtnumcompro.Size = New System.Drawing.Size(64, 20)
        Me.txtnumcompro.TabIndex = 224
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 13)
        Me.Label20.TabIndex = 223
        Me.Label20.Text = "Nº  Comprobante"
        '
        'cbomoneda
        '
        Me.cbomoneda.FormattingEnabled = True
        Me.cbomoneda.Location = New System.Drawing.Point(110, 248)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(85, 21)
        Me.cbomoneda.TabIndex = 194
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 222
        Me.Label8.Text = "Moneda"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label7.Location = New System.Drawing.Point(466, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 221
        Me.Label7.Text = "Cuenta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboPeriodo
        '
        Me.CboPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPeriodo.FormattingEnabled = True
        Me.CboPeriodo.Location = New System.Drawing.Point(540, 14)
        Me.CboPeriodo.Name = "CboPeriodo"
        Me.CboPeriodo.Size = New System.Drawing.Size(100, 23)
        Me.CboPeriodo.TabIndex = 185
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(466, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 220
        Me.Label10.Text = "Periodo"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(318, 498)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(85, 20)
        Me.txtTotal.TabIndex = 203
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIsc
        '
        Me.txtIsc.Location = New System.Drawing.Point(320, 459)
        Me.txtIsc.Name = "txtIsc"
        Me.txtIsc.Size = New System.Drawing.Size(85, 20)
        Me.txtIsc.TabIndex = 201
        Me.txtIsc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIgv
        '
        Me.txtIgv.Location = New System.Drawing.Point(318, 390)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.Size = New System.Drawing.Size(85, 20)
        Me.txtIgv.TabIndex = 199
        Me.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(318, 355)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(85, 20)
        Me.txtMonto.TabIndex = 197
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(35, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 219
        Me.Label2.Text = "Glosa"
        '
        'txtGlosa
        '
        Me.txtGlosa.Location = New System.Drawing.Point(110, 275)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(226, 20)
        Me.txtGlosa.TabIndex = 195
        '
        'btncerrar
        '
        Me.btncerrar.Location = New System.Drawing.Point(261, 14)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(75, 23)
        Me.btncerrar.TabIndex = 207
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(99, 14)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 205
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(180, 14)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 206
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(18, 14)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 204
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(466, 116)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 13)
        Me.Label22.TabIndex = 218
        Me.Label22.Text = "Fecha Venc."
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.BackColor = System.Drawing.Color.White
        Me.lblRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocial.Location = New System.Drawing.Point(110, 202)
        Me.lblRazonSocial.MaximumSize = New System.Drawing.Size(349, 15)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(226, 15)
        Me.lblRazonSocial.TabIndex = 217
        Me.lblRazonSocial.Text = "Razón Social"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(216, 176)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 23)
        Me.Button3.TabIndex = 193
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(16, 181)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(27, 13)
        Me.Label28.TabIndex = 216
        Me.Label28.Text = "Ruc"
        '
        'txtRuc
        '
        Me.txtRuc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtRuc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRuc.Location = New System.Drawing.Point(110, 177)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(85, 20)
        Me.txtRuc.TabIndex = 192
        '
        'cboAdq
        '
        Me.cboAdq.DropDownWidth = 340
        Me.cboAdq.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAdq.FormattingEnabled = True
        Me.cboAdq.Items.AddRange(New Object() {"GRAVADAS Y/O DE EXPORTACIÓN", "GRAVADAS Y/O DE EXPORTACIÓN Y A OPERACIONES NO GRAVADAS", "OPERACIONES NO GRAVADAS", "VALOR DE LAS ADQUISIONES NO GRAVADAS"})
        Me.cboAdq.Location = New System.Drawing.Point(110, 148)
        Me.cboAdq.Name = "cboAdq"
        Me.cboAdq.Size = New System.Drawing.Size(226, 20)
        Me.cboAdq.TabIndex = 191
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 29)
        Me.Label6.TabIndex = 215
        Me.Label6.Text = "Adq. Gravadas Dest. a Oper."
        '
        'txtCuentaTotal
        '
        Me.txtCuentaTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCuentaTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCuentaTotal.Location = New System.Drawing.Point(446, 498)
        Me.txtCuentaTotal.Name = "txtCuentaTotal"
        Me.txtCuentaTotal.Size = New System.Drawing.Size(121, 20)
        Me.txtCuentaTotal.TabIndex = 202
        '
        'txtCuentaIgv
        '
        Me.txtCuentaIgv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCuentaIgv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCuentaIgv.Location = New System.Drawing.Point(446, 390)
        Me.txtCuentaIgv.Name = "txtCuentaIgv"
        Me.txtCuentaIgv.Size = New System.Drawing.Size(121, 20)
        Me.txtCuentaIgv.TabIndex = 198
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(254, 501)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 214
        Me.Label5.Text = "Total"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(254, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 213
        Me.Label4.Text = "IGV"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(254, 466)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 212
        Me.Label3.Text = "ISC"
        '
        'txtCuentaIsc
        '
        Me.txtCuentaIsc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCuentaIsc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCuentaIsc.Location = New System.Drawing.Point(448, 459)
        Me.txtCuentaIsc.Name = "txtCuentaIsc"
        Me.txtCuentaIsc.Size = New System.Drawing.Size(121, 20)
        Me.txtCuentaIsc.TabIndex = 200
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(254, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 211
        Me.Label1.Text = "Monto"
        '
        'txtCuentaMonto
        '
        Me.txtCuentaMonto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCuentaMonto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCuentaMonto.Location = New System.Drawing.Point(446, 355)
        Me.txtCuentaMonto.Name = "txtCuentaMonto"
        Me.txtCuentaMonto.Size = New System.Drawing.Size(121, 20)
        Me.txtCuentaMonto.TabIndex = 196
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(466, 87)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 13)
        Me.Label23.TabIndex = 210
        Me.Label23.Text = "Fecha Emis."
        '
        'cbotipodoc
        '
        Me.cbotipodoc.DropDownWidth = 300
        Me.cbotipodoc.FormattingEnabled = True
        Me.cbotipodoc.Location = New System.Drawing.Point(110, 86)
        Me.cbotipodoc.Name = "cbotipodoc"
        Me.cbotipodoc.Size = New System.Drawing.Size(226, 21)
        Me.cbotipodoc.TabIndex = 186
        '
        'txtDserie
        '
        Me.txtDserie.Location = New System.Drawing.Point(110, 117)
        Me.txtDserie.MaxLength = 3
        Me.txtDserie.Name = "txtDserie"
        Me.txtDserie.Size = New System.Drawing.Size(35, 20)
        Me.txtDserie.TabIndex = 187
        '
        'txtDnumero
        '
        Me.txtDnumero.Location = New System.Drawing.Point(161, 117)
        Me.txtDnumero.MaxLength = 7
        Me.txtDnumero.Name = "txtDnumero"
        Me.txtDnumero.Size = New System.Drawing.Size(100, 20)
        Me.txtDnumero.TabIndex = 188
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(16, 121)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 13)
        Me.Label24.TabIndex = 209
        Me.Label24.Text = "Nº Documento"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(16, 90)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 13)
        Me.Label25.TabIndex = 208
        Me.Label25.Text = "Tipo Documento"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(318, 425)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(85, 20)
        Me.TextBox1.TabIndex = 226
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox2.Location = New System.Drawing.Point(446, 425)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 20)
        Me.TextBox2.TabIndex = 225
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(240, 432)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 227
        Me.Label9.Text = "Inafecto"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(11, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton1.TabIndex = 228
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Efectivo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(102, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton2.TabIndex = 229
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Banco"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(261, 548)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 49)
        Me.GroupBox1.TabIndex = 230
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "forma depago"
        '
        'FrmComprobanteN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 609)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.dtpFechae)
        Me.Controls.Add(Me.dtpFechav)
        Me.Controls.Add(Me.txtnumcompro)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cbomoneda)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CboPeriodo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtIsc)
        Me.Controls.Add(Me.txtIgv)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGlosa)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lblRazonSocial)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtRuc)
        Me.Controls.Add(Me.cboAdq)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCuentaTotal)
        Me.Controls.Add(Me.txtCuentaIgv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCuentaIsc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCuentaMonto)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cbotipodoc)
        Me.Controls.Add(Me.txtDserie)
        Me.Controls.Add(Me.txtDnumero)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Name = "FrmComprobanteN"
        Me.Text = "Comprobante"
        CType(Me.ErrorIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFechae As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrorIcon As System.Windows.Forms.ErrorProvider
    Friend WithEvents dtpFechav As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtnumcompro As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIsc As System.Windows.Forms.TextBox
    Friend WithEvents txtIgv As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGlosa As System.Windows.Forms.TextBox
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents cboAdq As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaIgv As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaIsc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbotipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtDserie As System.Windows.Forms.TextBox
    Friend WithEvents txtDnumero As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
