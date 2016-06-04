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
        Me.cabecera = New System.Windows.Forms.GroupBox()
        Me.cboAdq = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.txtnumcompro = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtnumdiario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbomoneda = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cbotipodoc = New System.Windows.Forms.ComboBox()
        Me.txtDserie = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtDnumero = New System.Windows.Forms.TextBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.MfechaDV = New System.Windows.Forms.MaskedTextBox()
        Me.MfechaDE = New System.Windows.Forms.MaskedTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Fperiodo = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gvComprobante = New System.Windows.Forms.DataGridView()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cabecera.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gvComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cabecera
        '
        Me.cabecera.Controls.Add(Me.cboAdq)
        Me.cabecera.Controls.Add(Me.Label3)
        Me.cabecera.Controls.Add(Me.lblRazonSocial)
        Me.cabecera.Controls.Add(Me.txtnumcompro)
        Me.cabecera.Controls.Add(Me.Label20)
        Me.cabecera.Controls.Add(Me.txtnumdiario)
        Me.cabecera.Controls.Add(Me.Label1)
        Me.cabecera.Controls.Add(Me.cbomoneda)
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
        Me.cabecera.Location = New System.Drawing.Point(4, 35)
        Me.cabecera.Name = "cabecera"
        Me.cabecera.Size = New System.Drawing.Size(786, 137)
        Me.cabecera.TabIndex = 25
        Me.cabecera.TabStop = False
        Me.cabecera.Text = "Cabecera"
        '
        'cboAdq
        '
        Me.cboAdq.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAdq.FormattingEnabled = True
        Me.cboAdq.Items.AddRange(New Object() {"GRAVADAS Y/O DE EXPORTACIÓN", "GRAVADAS Y/O DE EXPORTACIÓN Y A OPERACIONES NO GRAVADAS", "OPERACIONES NO GRAVADAS"})
        Me.cboAdq.Location = New System.Drawing.Point(100, 108)
        Me.cboAdq.Name = "cboAdq"
        Me.cboAdq.Size = New System.Drawing.Size(220, 20)
        Me.cboAdq.TabIndex = 67
        Me.cboAdq.Text = "Seleccione"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 29)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = " Adq. Gravadas Dest. a Oper."
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.BackColor = System.Drawing.Color.White
        Me.lblRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocial.Location = New System.Drawing.Point(382, 108)
        Me.lblRazonSocial.MaximumSize = New System.Drawing.Size(349, 15)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(349, 15)
        Me.lblRazonSocial.TabIndex = 65
        Me.lblRazonSocial.Text = "Nombre Auxiliar"
        '
        'txtnumcompro
        '
        Me.txtnumcompro.Location = New System.Drawing.Point(100, 51)
        Me.txtnumcompro.MaxLength = 4
        Me.txtnumcompro.Name = "txtnumcompro"
        Me.txtnumcompro.Size = New System.Drawing.Size(100, 20)
        Me.txtnumcompro.TabIndex = 54
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 54)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 13)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Nº  Comprobante"
        '
        'txtnumdiario
        '
        Me.txtnumdiario.Location = New System.Drawing.Point(100, 23)
        Me.txtnumdiario.MaxLength = 5
        Me.txtnumdiario.Name = "txtnumdiario"
        Me.txtnumdiario.Size = New System.Drawing.Size(100, 20)
        Me.txtnumdiario.TabIndex = 52
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
        'cbomoneda
        '
        Me.cbomoneda.FormattingEnabled = True
        Me.cbomoneda.Location = New System.Drawing.Point(100, 79)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(100, 21)
        Me.cbomoneda.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 81)
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
        'cbotipodoc
        '
        Me.cbotipodoc.FormattingEnabled = True
        Me.cbotipodoc.Location = New System.Drawing.Point(385, 23)
        Me.cbotipodoc.Name = "cbotipodoc"
        Me.cbotipodoc.Size = New System.Drawing.Size(141, 21)
        Me.cbotipodoc.TabIndex = 51
        '
        'txtDserie
        '
        Me.txtDserie.Location = New System.Drawing.Point(385, 50)
        Me.txtDserie.MaxLength = 3
        Me.txtDserie.Name = "txtDserie"
        Me.txtDserie.Size = New System.Drawing.Size(35, 20)
        Me.txtDserie.TabIndex = 52
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(491, 76)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 23)
        Me.Button3.TabIndex = 64
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(293, 81)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(27, 13)
        Me.Label28.TabIndex = 63
        Me.Label28.Text = "Ruc"
        '
        'txtDnumero
        '
        Me.txtDnumero.Location = New System.Drawing.Point(426, 50)
        Me.txtDnumero.MaxLength = 7
        Me.txtDnumero.Name = "txtDnumero"
        Me.txtDnumero.Size = New System.Drawing.Size(100, 20)
        Me.txtDnumero.TabIndex = 53
        '
        'txtRuc
        '
        Me.txtRuc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtRuc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRuc.Location = New System.Drawing.Point(385, 77)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(100, 20)
        Me.txtRuc.TabIndex = 62
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(293, 54)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 13)
        Me.Label24.TabIndex = 54
        Me.Label24.Text = "Nº Documento"
        '
        'MfechaDV
        '
        Me.MfechaDV.Location = New System.Drawing.Point(645, 50)
        Me.MfechaDV.Mask = "00/00/0000"
        Me.MfechaDV.Name = "MfechaDV"
        Me.MfechaDV.Size = New System.Drawing.Size(86, 20)
        Me.MfechaDV.TabIndex = 58
        Me.MfechaDV.ValidatingType = GetType(Date)
        '
        'MfechaDE
        '
        Me.MfechaDE.Location = New System.Drawing.Point(645, 23)
        Me.MfechaDE.Mask = "00/00/0000"
        Me.MfechaDE.Name = "MfechaDE"
        Me.MfechaDE.Size = New System.Drawing.Size(86, 20)
        Me.MfechaDE.TabIndex = 57
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
        Me.Label22.Location = New System.Drawing.Point(578, 54)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 13)
        Me.Label22.TabIndex = 56
        Me.Label22.Text = "Fecha V"
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(6, 6)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 29
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(87, 6)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 30
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(168, 6)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 29
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.Location = New System.Drawing.Point(249, 6)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(75, 23)
        Me.btncerrar.TabIndex = 30
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'Fperiodo
        '
        Me.Fperiodo.CustomFormat = "MM-yyyy"
        Me.Fperiodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fperiodo.Location = New System.Drawing.Point(701, 12)
        Me.Fperiodo.Name = "Fperiodo"
        Me.Fperiodo.Size = New System.Drawing.Size(89, 20)
        Me.Fperiodo.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(649, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Periodo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gvComprobante)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(786, 215)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'gvComprobante
        '
        Me.gvComprobante.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        Me.gvComprobante.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvComprobante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvComprobante.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gvComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvComprobante.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cuenta, Me.Nombre, Me.Glosa, Me.Debe, Me.Haber})
        Me.gvComprobante.Location = New System.Drawing.Point(3, 16)
        Me.gvComprobante.Name = "gvComprobante"
        Me.gvComprobante.RowHeadersVisible = False
        Me.gvComprobante.Size = New System.Drawing.Size(777, 179)
        Me.gvComprobante.TabIndex = 0
        '
        'Cuenta
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Cuenta.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cuenta.FillWeight = 47.51267!
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        '
        'Nombre
        '
        Me.Nombre.FillWeight = 66.5477!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Glosa
        '
        Me.Glosa.FillWeight = 132.7426!
        Me.Glosa.HeaderText = "Glosa"
        Me.Glosa.Name = "Glosa"
        '
        'Debe
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Debe.DefaultCellStyle = DataGridViewCellStyle3
        Me.Debe.FillWeight = 32.82071!
        Me.Debe.HeaderText = "Debe"
        Me.Debe.Name = "Debe"
        '
        'Haber
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Haber.DefaultCellStyle = DataGridViewCellStyle4
        Me.Haber.FillWeight = 32.37622!
        Me.Haber.HeaderText = "Haber"
        Me.Haber.Name = "Haber"
        '
        'Frm_Comprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 401)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Fperiodo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.cabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_Comprobantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Compra"
        Me.cabecera.ResumeLayout(False)
        Me.cabecera.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.gvComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cabecera As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbomoneda As ComboBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btncerrar As Button
    Friend WithEvents MfechaDV As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MfechaDE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtDnumero As System.Windows.Forms.TextBox
    Friend WithEvents txtDserie As System.Windows.Forms.TextBox
    Friend WithEvents cbotipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents Fperiodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtnumcompro As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtnumdiario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gvComprobante As System.Windows.Forms.DataGridView
    Friend WithEvents lblRazonSocial As Label
    Friend WithEvents cboAdq As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
