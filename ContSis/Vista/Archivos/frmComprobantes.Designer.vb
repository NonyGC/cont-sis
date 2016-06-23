<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprobantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComprobantes))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ErrorIcon = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.cbotipodoc = New System.Windows.Forms.ComboBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.dtpFechae = New System.Windows.Forms.DateTimePicker()
        Me.CboPeriodo = New System.Windows.Forms.ComboBox()
        Me.dtpFechav = New System.Windows.Forms.DateTimePicker()
        Me.cbomoneda = New System.Windows.Forms.ComboBox()
        Me.cboAdq = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.txtnumcompro = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cabecera = New System.Windows.Forms.GroupBox()
        Me.txtDserie = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtDnumero = New System.Windows.Forms.TextBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.gvComprobante = New System.Windows.Forms.DataGridView()
        Me.det = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gvcajabanco = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ErrorIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cabecera.SuspendLayout()
        CType(Me.gvComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gvcajabanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorIcon
        '
        Me.ErrorIcon.ContainerControl = Me
        Me.ErrorIcon.Icon = CType(resources.GetObject("ErrorIcon.Icon"), System.Drawing.Icon)
        '
        'Haber
        '
        Me.Haber.DataPropertyName = "haber"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Haber.DefaultCellStyle = DataGridViewCellStyle8
        Me.Haber.FillWeight = 48.3732!
        Me.Haber.HeaderText = "Haber"
        Me.Haber.Name = "Haber"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(93, 12)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 63
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'cbotipodoc
        '
        Me.cbotipodoc.DropDownWidth = 250
        Me.cbotipodoc.FormattingEnabled = True
        Me.cbotipodoc.Location = New System.Drawing.Point(407, 23)
        Me.cbotipodoc.Name = "cbotipodoc"
        Me.cbotipodoc.Size = New System.Drawing.Size(152, 21)
        Me.cbotipodoc.TabIndex = 2
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(174, 12)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 60
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Moneda"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(320, 27)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 13)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "Tipo Documento"
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(12, 12)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 61
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'dtpFechae
        '
        Me.dtpFechae.Checked = False
        Me.dtpFechae.CustomFormat = "  "
        Me.dtpFechae.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechae.Location = New System.Drawing.Point(735, 20)
        Me.dtpFechae.Name = "dtpFechae"
        Me.dtpFechae.ShowCheckBox = True
        Me.dtpFechae.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechae.TabIndex = 5
        Me.dtpFechae.Value = New Date(2016, 6, 12, 0, 0, 0, 0)
        '
        'CboPeriodo
        '
        Me.CboPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPeriodo.FormattingEnabled = True
        Me.CboPeriodo.Location = New System.Drawing.Point(745, 14)
        Me.CboPeriodo.Name = "CboPeriodo"
        Me.CboPeriodo.Size = New System.Drawing.Size(100, 23)
        Me.CboPeriodo.TabIndex = 58
        '
        'dtpFechav
        '
        Me.dtpFechav.Checked = False
        Me.dtpFechav.CustomFormat = "  "
        Me.dtpFechav.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechav.Location = New System.Drawing.Point(735, 42)
        Me.dtpFechav.Name = "dtpFechav"
        Me.dtpFechav.ShowCheckBox = True
        Me.dtpFechav.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechav.TabIndex = 6
        '
        'cbomoneda
        '
        Me.cbomoneda.FormattingEnabled = True
        Me.cbomoneda.Location = New System.Drawing.Point(101, 48)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(100, 21)
        Me.cbomoneda.TabIndex = 7
        '
        'cboAdq
        '
        Me.cboAdq.DropDownWidth = 340
        Me.cboAdq.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAdq.FormattingEnabled = True
        Me.cboAdq.Items.AddRange(New Object() {"GRAVADAS Y/O DE EXPORTACIÓN", "GRAVADAS Y/O DE EXPORTACIÓN Y A OPERACIONES NO GRAVADAS", "OPERACIONES NO GRAVADAS", "VALOR DE LAS ADQUISIONES NO GRAVADAS"})
        Me.cboAdq.Location = New System.Drawing.Point(101, 74)
        Me.cboAdq.Name = "cboAdq"
        Me.cboAdq.Size = New System.Drawing.Size(199, 20)
        Me.cboAdq.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 29)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Adq. Gravadas Dest. a Oper."
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.BackColor = System.Drawing.Color.White
        Me.lblRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocial.Location = New System.Drawing.Point(407, 99)
        Me.lblRazonSocial.MaximumSize = New System.Drawing.Size(349, 20)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(349, 18)
        Me.lblRazonSocial.TabIndex = 65
        Me.lblRazonSocial.Text = "Razón Social"
        '
        'txtnumcompro
        '
        Me.txtnumcompro.Location = New System.Drawing.Point(101, 23)
        Me.txtnumcompro.MaxLength = 4
        Me.txtnumcompro.Name = "txtnumcompro"
        Me.txtnumcompro.Size = New System.Drawing.Size(100, 20)
        Me.txtnumcompro.TabIndex = 54
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 27)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 13)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Nº  Comprobante"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(660, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Periodo"
        '
        'cabecera
        '
        Me.cabecera.Controls.Add(Me.dtpFechav)
        Me.cabecera.Controls.Add(Me.dtpFechae)
        Me.cabecera.Controls.Add(Me.cbomoneda)
        Me.cabecera.Controls.Add(Me.cboAdq)
        Me.cabecera.Controls.Add(Me.Label3)
        Me.cabecera.Controls.Add(Me.lblRazonSocial)
        Me.cabecera.Controls.Add(Me.txtnumcompro)
        Me.cabecera.Controls.Add(Me.Label20)
        Me.cabecera.Controls.Add(Me.Label4)
        Me.cabecera.Controls.Add(Me.Label25)
        Me.cabecera.Controls.Add(Me.cbotipodoc)
        Me.cabecera.Controls.Add(Me.txtDserie)
        Me.cabecera.Controls.Add(Me.Button3)
        Me.cabecera.Controls.Add(Me.Label28)
        Me.cabecera.Controls.Add(Me.txtDnumero)
        Me.cabecera.Controls.Add(Me.txtRuc)
        Me.cabecera.Controls.Add(Me.Label24)
        Me.cabecera.Controls.Add(Me.Label23)
        Me.cabecera.Controls.Add(Me.Label22)
        Me.cabecera.Location = New System.Drawing.Point(10, 41)
        Me.cabecera.Name = "cabecera"
        Me.cabecera.Size = New System.Drawing.Size(860, 137)
        Me.cabecera.TabIndex = 59
        Me.cabecera.TabStop = False
        Me.cabecera.Text = "Cabecera"
        '
        'txtDserie
        '
        Me.txtDserie.Location = New System.Drawing.Point(407, 48)
        Me.txtDserie.MaxLength = 3
        Me.txtDserie.Name = "txtDserie"
        Me.txtDserie.Size = New System.Drawing.Size(35, 20)
        Me.txtDserie.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(526, 73)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 23)
        Me.Button3.TabIndex = 64
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(320, 78)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(27, 13)
        Me.Label28.TabIndex = 63
        Me.Label28.Text = "Ruc"
        '
        'txtDnumero
        '
        Me.txtDnumero.Location = New System.Drawing.Point(461, 48)
        Me.txtDnumero.MaxLength = 7
        Me.txtDnumero.Name = "txtDnumero"
        Me.txtDnumero.Size = New System.Drawing.Size(100, 20)
        Me.txtDnumero.TabIndex = 4
        '
        'txtRuc
        '
        Me.txtRuc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRuc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRuc.Location = New System.Drawing.Point(407, 74)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(100, 20)
        Me.txtRuc.TabIndex = 8
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(320, 52)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 13)
        Me.Label24.TabIndex = 54
        Me.Label24.Text = "Nº Documento"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(650, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(76, 13)
        Me.Label23.TabIndex = 55
        Me.Label23.Text = "Fecha Emisión"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(650, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(77, 13)
        Me.Label22.TabIndex = 56
        Me.Label22.Text = "Fecha Vencimi"
        '
        'gvComprobante
        '
        Me.gvComprobante.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.gvComprobante.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.gvComprobante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvComprobante.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gvComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvComprobante.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.det, Me.Cuenta, Me.Nombre, Me.Glosa, Me.Debe, Me.Haber})
        Me.gvComprobante.Location = New System.Drawing.Point(3, 16)
        Me.gvComprobante.Name = "gvComprobante"
        Me.gvComprobante.RowHeadersVisible = False
        Me.gvComprobante.Size = New System.Drawing.Size(851, 179)
        Me.gvComprobante.TabIndex = 10
        '
        'det
        '
        Me.det.DataPropertyName = "nro_det"
        Me.det.FillWeight = 24.92823!
        Me.det.HeaderText = "det"
        Me.det.Name = "det"
        Me.det.Visible = False
        '
        'Cuenta
        '
        Me.Cuenta.DataPropertyName = "cuenta"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Cuenta.DefaultCellStyle = DataGridViewCellStyle6
        Me.Cuenta.FillWeight = 70.98851!
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "nombre"
        Me.Nombre.FillWeight = 99.42868!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Glosa
        '
        Me.Glosa.DataPropertyName = "glosa"
        Me.Glosa.FillWeight = 198.3302!
        Me.Glosa.HeaderText = "Glosa"
        Me.Glosa.Name = "Glosa"
        '
        'Debe
        '
        Me.Debe.DataPropertyName = "debe"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Debe.DefaultCellStyle = DataGridViewCellStyle7
        Me.Debe.FillWeight = 49.0373!
        Me.Debe.HeaderText = "Debe"
        Me.Debe.Name = "Debe"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gvComprobante)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(860, 203)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'btncerrar
        '
        Me.btncerrar.Location = New System.Drawing.Point(255, 12)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(75, 23)
        Me.btncerrar.TabIndex = 62
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gvcajabanco)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 388)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 116)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Caja Banco"
        '
        'gvcajabanco
        '
        Me.gvcajabanco.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.gvcajabanco.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvcajabanco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvcajabanco.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gvcajabanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvcajabanco.ColumnHeadersVisible = False
        Me.gvcajabanco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.gvcajabanco.Location = New System.Drawing.Point(3, 16)
        Me.gvcajabanco.Name = "gvcajabanco"
        Me.gvcajabanco.RowHeadersVisible = False
        Me.gvcajabanco.Size = New System.Drawing.Size(851, 92)
        Me.gvcajabanco.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nro_det"
        Me.DataGridViewTextBoxColumn1.FillWeight = 24.92823!
        Me.DataGridViewTextBoxColumn1.HeaderText = "det"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cuenta"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.FillWeight = 70.98851!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cuenta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn3.FillWeight = 99.42868!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "glosa"
        Me.DataGridViewTextBoxColumn4.FillWeight = 198.3302!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Glosa"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "debe"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn5.FillWeight = 49.0373!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Debe"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "haber"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn6.FillWeight = 48.3732!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Haber"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'frmComprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 379)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.CboPeriodo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cabecera)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btncerrar)
        Me.Name = "frmComprobantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmComprobantes"
        CType(Me.ErrorIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cabecera.ResumeLayout(False)
        Me.cabecera.PerformLayout()
        CType(Me.gvComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gvcajabanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorIcon As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents CboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cabecera As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechav As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechae As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents cboAdq As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents txtnumcompro As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbotipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtDserie As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtDnumero As System.Windows.Forms.TextBox
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gvComprobante As System.Windows.Forms.DataGridView
    Friend WithEvents det As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gvcajabanco As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
