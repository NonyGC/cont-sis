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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComprobantes))
        Me.Haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbomoneda = New System.Windows.Forms.ComboBox()
        Me.cboAdq = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.txtnumcompro = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtnumdiario = New System.Windows.Forms.TextBox()
        Me.Glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.det = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbotipodoc = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gvComprobante = New System.Windows.Forms.DataGridView()
        Me.txtDserie = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtDnumero = New System.Windows.Forms.TextBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ErrorIcon = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MfechaDV = New System.Windows.Forms.MaskedTextBox()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.MfechaDE = New System.Windows.Forms.MaskedTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CboPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cabecera = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gvComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'Haber
        '
        Me.Haber.DataPropertyName = "haber"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Haber.DefaultCellStyle = DataGridViewCellStyle1
        Me.Haber.FillWeight = 48.3732!
        Me.Haber.HeaderText = "Haber"
        Me.Haber.Name = "Haber"
        '
        'cbomoneda
        '
        Me.cbomoneda.FormattingEnabled = True
        Me.cbomoneda.Location = New System.Drawing.Point(101, 77)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(100, 21)
        Me.cbomoneda.TabIndex = 7
        '
        'cboAdq
        '
        Me.cboAdq.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAdq.FormattingEnabled = True
        Me.cboAdq.Items.AddRange(New Object() {"GRAVADAS Y/O DE EXPORTACIÓN", "GRAVADAS Y/O DE EXPORTACIÓN Y A OPERACIONES NO GRAVADAS", "OPERACIONES NO GRAVADAS", "VALOR DE LAS ADQUISIONES NO GRAVADAS"})
        Me.cboAdq.Location = New System.Drawing.Point(101, 106)
        Me.cboAdq.Name = "cboAdq"
        Me.cboAdq.Size = New System.Drawing.Size(227, 20)
        Me.cboAdq.TabIndex = 9
        Me.cboAdq.Text = "Seleccione"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 29)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Adq. Gravadas Dest. a Oper."
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.BackColor = System.Drawing.Color.White
        Me.lblRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocial.Location = New System.Drawing.Point(382, 111)
        Me.lblRazonSocial.MaximumSize = New System.Drawing.Size(349, 15)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(349, 15)
        Me.lblRazonSocial.TabIndex = 65
        Me.lblRazonSocial.Text = "Razón Social"
        '
        'txtnumcompro
        '
        Me.txtnumcompro.Location = New System.Drawing.Point(101, 51)
        Me.txtnumcompro.MaxLength = 4
        Me.txtnumcompro.Name = "txtnumcompro"
        Me.txtnumcompro.Size = New System.Drawing.Size(100, 20)
        Me.txtnumcompro.TabIndex = 54
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 55)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 13)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Nº  Comprobante"
        '
        'txtnumdiario
        '
        Me.txtnumdiario.Enabled = False
        Me.txtnumdiario.Location = New System.Drawing.Point(101, 23)
        Me.txtnumdiario.MaxLength = 5
        Me.txtnumdiario.Name = "txtnumdiario"
        Me.txtnumdiario.Size = New System.Drawing.Size(100, 20)
        Me.txtnumdiario.TabIndex = 52
        '
        'Glosa
        '
        Me.Glosa.DataPropertyName = "glosa"
        Me.Glosa.FillWeight = 198.3302!
        Me.Glosa.HeaderText = "Glosa"
        Me.Glosa.Name = "Glosa"
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "nombre"
        Me.Nombre.FillWeight = 99.42868!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Cuenta
        '
        Me.Cuenta.DataPropertyName = "cuenta"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Cuenta.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cuenta.FillWeight = 70.98851!
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        '
        'det
        '
        Me.det.DataPropertyName = "nro_det"
        Me.det.FillWeight = 24.92823!
        Me.det.HeaderText = "det"
        Me.det.Name = "det"
        Me.det.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Nº Diario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Moneda"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(293, 27)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 13)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "Tipo Documento"
        '
        'Debe
        '
        Me.Debe.DataPropertyName = "debe"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Debe.DefaultCellStyle = DataGridViewCellStyle3
        Me.Debe.FillWeight = 49.0373!
        Me.Debe.HeaderText = "Debe"
        Me.Debe.Name = "Debe"
        '
        'cbotipodoc
        '
        Me.cbotipodoc.FormattingEnabled = True
        Me.cbotipodoc.Location = New System.Drawing.Point(382, 23)
        Me.cbotipodoc.Name = "cbotipodoc"
        Me.cbotipodoc.Size = New System.Drawing.Size(152, 21)
        Me.cbotipodoc.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gvComprobante)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(786, 215)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'gvComprobante
        '
        Me.gvComprobante.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.gvComprobante.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gvComprobante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvComprobante.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gvComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvComprobante.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.det, Me.Cuenta, Me.Nombre, Me.Glosa, Me.Debe, Me.Haber})
        Me.gvComprobante.Location = New System.Drawing.Point(3, 16)
        Me.gvComprobante.Name = "gvComprobante"
        Me.gvComprobante.RowHeadersVisible = False
        Me.gvComprobante.Size = New System.Drawing.Size(777, 179)
        Me.gvComprobante.TabIndex = 10
        '
        'txtDserie
        '
        Me.txtDserie.Location = New System.Drawing.Point(382, 51)
        Me.txtDserie.MaxLength = 3
        Me.txtDserie.Name = "txtDserie"
        Me.txtDserie.Size = New System.Drawing.Size(35, 20)
        Me.txtDserie.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(499, 77)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 23)
        Me.Button3.TabIndex = 64
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(293, 83)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(27, 13)
        Me.Label28.TabIndex = 63
        Me.Label28.Text = "Ruc"
        '
        'txtDnumero
        '
        Me.txtDnumero.Location = New System.Drawing.Point(434, 51)
        Me.txtDnumero.MaxLength = 7
        Me.txtDnumero.Name = "txtDnumero"
        Me.txtDnumero.Size = New System.Drawing.Size(100, 20)
        Me.txtDnumero.TabIndex = 4
        '
        'txtRuc
        '
        Me.txtRuc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtRuc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRuc.Location = New System.Drawing.Point(382, 79)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(100, 20)
        Me.txtRuc.TabIndex = 8
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(293, 55)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 13)
        Me.Label24.TabIndex = 54
        Me.Label24.Text = "Nº Documento"
        '
        'ErrorIcon
        '
        Me.ErrorIcon.ContainerControl = Me
        Me.ErrorIcon.Icon = CType(resources.GetObject("ErrorIcon.Icon"), System.Drawing.Icon)
        '
        'MfechaDV
        '
        Me.MfechaDV.Location = New System.Drawing.Point(645, 51)
        Me.MfechaDV.Mask = "00/00/0000"
        Me.MfechaDV.Name = "MfechaDV"
        Me.MfechaDV.Size = New System.Drawing.Size(86, 20)
        Me.MfechaDV.TabIndex = 6
        Me.MfechaDV.ValidatingType = GetType(Date)
        '
        'btncerrar
        '
        Me.btncerrar.Location = New System.Drawing.Point(247, 10)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(75, 23)
        Me.btncerrar.TabIndex = 54
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(85, 10)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 55
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(166, 10)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 52
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(4, 10)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 53
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'MfechaDE
        '
        Me.MfechaDE.Location = New System.Drawing.Point(645, 23)
        Me.MfechaDE.Mask = "00/00/0000"
        Me.MfechaDE.Name = "MfechaDE"
        Me.MfechaDE.Size = New System.Drawing.Size(86, 20)
        Me.MfechaDE.TabIndex = 5
        Me.MfechaDE.ValidatingType = GetType(Date)
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(578, 27)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 13)
        Me.Label23.TabIndex = 55
        Me.Label23.Text = "Fecha E"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(578, 55)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 13)
        Me.Label22.TabIndex = 56
        Me.Label22.Text = "Fecha V"
        '
        'CboPeriodo
        '
        Me.CboPeriodo.FormattingEnabled = True
        Me.CboPeriodo.Location = New System.Drawing.Point(699, 11)
        Me.CboPeriodo.Name = "CboPeriodo"
        Me.CboPeriodo.Size = New System.Drawing.Size(89, 21)
        Me.CboPeriodo.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(650, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Periodo"
        '
        'cabecera
        '
        Me.cabecera.Controls.Add(Me.cbomoneda)
        Me.cabecera.Controls.Add(Me.cboAdq)
        Me.cabecera.Controls.Add(Me.Label3)
        Me.cabecera.Controls.Add(Me.lblRazonSocial)
        Me.cabecera.Controls.Add(Me.txtnumcompro)
        Me.cabecera.Controls.Add(Me.Label20)
        Me.cabecera.Controls.Add(Me.txtnumdiario)
        Me.cabecera.Controls.Add(Me.Label1)
        Me.cabecera.Controls.Add(Me.Label4)
        Me.cabecera.Controls.Add(Me.Label25)
        Me.cabecera.Controls.Add(Me.cbotipodoc)
        Me.cabecera.Controls.Add(Me.txtDserie)
        Me.cabecera.Controls.Add(Me.Button3)
        Me.cabecera.Controls.Add(Me.Label28)
        Me.cabecera.Controls.Add(Me.txtDnumero)
        Me.cabecera.Controls.Add(Me.txtRuc)
        Me.cabecera.Controls.Add(Me.Label24)
        Me.cabecera.Controls.Add(Me.MfechaDV)
        Me.cabecera.Controls.Add(Me.MfechaDE)
        Me.cabecera.Controls.Add(Me.Label23)
        Me.cabecera.Controls.Add(Me.Label22)
        Me.cabecera.Location = New System.Drawing.Point(2, 39)
        Me.cabecera.Name = "cabecera"
        Me.cabecera.Size = New System.Drawing.Size(786, 137)
        Me.cabecera.TabIndex = 51
        Me.cabecera.TabStop = False
        Me.cabecera.Text = "Cabecera"
        '
        'frmComprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 409)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.CboPeriodo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cabecera)
        Me.Name = "frmComprobantes"
        Me.Text = "frmComprobantes"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.gvComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cabecera.ResumeLayout(False)
        Me.cabecera.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents cboAdq As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents txtnumcompro As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtnumdiario As System.Windows.Forms.TextBox
    Friend WithEvents Glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents det As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbotipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gvComprobante As System.Windows.Forms.DataGridView
    Friend WithEvents txtDserie As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtDnumero As System.Windows.Forms.TextBox
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents ErrorIcon As System.Windows.Forms.ErrorProvider
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents CboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cabecera As System.Windows.Forms.GroupBox
    Friend WithEvents MfechaDV As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MfechaDE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
