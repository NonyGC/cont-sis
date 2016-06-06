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
        Me.MfechaDV = New System.Windows.Forms.MaskedTextBox()
        Me.ErrorIcon = New System.Windows.Forms.ErrorProvider(Me.components)
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
        Me.MfechaDE = New System.Windows.Forms.MaskedTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbotipodoc = New System.Windows.Forms.ComboBox()
        Me.txtDserie = New System.Windows.Forms.TextBox()
        Me.txtDnumero = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label25 = New System.Windows.Forms.Label()
        CType(Me.ErrorIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnumcompro
        '
        Me.txtnumcompro.Enabled = False
        Me.txtnumcompro.Location = New System.Drawing.Point(109, 56)
        Me.txtnumcompro.MaxLength = 4
        Me.txtnumcompro.Name = "txtnumcompro"
        Me.txtnumcompro.Size = New System.Drawing.Size(64, 20)
        Me.txtnumcompro.TabIndex = 144
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(15, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 13)
        Me.Label20.TabIndex = 143
        Me.Label20.Text = "Nº  Comprobante"
        '
        'cbomoneda
        '
        Me.cbomoneda.FormattingEnabled = True
        Me.cbomoneda.Location = New System.Drawing.Point(109, 262)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(85, 21)
        Me.cbomoneda.TabIndex = 113
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 142
        Me.Label8.Text = "Moneda"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label7.Location = New System.Drawing.Point(484, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 141
        Me.Label7.Text = "Cuenta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboPeriodo
        '
        Me.CboPeriodo.FormattingEnabled = True
        Me.CboPeriodo.Location = New System.Drawing.Point(481, 11)
        Me.CboPeriodo.Name = "CboPeriodo"
        Me.CboPeriodo.Size = New System.Drawing.Size(89, 21)
        Me.CboPeriodo.TabIndex = 105
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(405, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 140
        Me.Label10.Text = "Periodo"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(362, 374)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(95, 20)
        Me.txtTotal.TabIndex = 121
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIsc
        '
        Me.txtIsc.Location = New System.Drawing.Point(362, 346)
        Me.txtIsc.Name = "txtIsc"
        Me.txtIsc.Size = New System.Drawing.Size(95, 20)
        Me.txtIsc.TabIndex = 119
        Me.txtIsc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIgv
        '
        Me.txtIgv.Location = New System.Drawing.Point(362, 320)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.Size = New System.Drawing.Size(95, 20)
        Me.txtIgv.TabIndex = 117
        Me.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(362, 294)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(95, 20)
        Me.txtMonto.TabIndex = 115
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(34, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Glosa"
        '
        'txtGlosa
        '
        Me.txtGlosa.Location = New System.Drawing.Point(109, 289)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(192, 20)
        Me.txtGlosa.TabIndex = 114
        '
        'btncerrar
        '
        Me.btncerrar.Location = New System.Drawing.Point(260, 9)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(75, 23)
        Me.btncerrar.TabIndex = 137
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(98, 9)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 138
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(179, 9)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 136
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(17, 9)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 123
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'MfechaDV
        '
        Me.MfechaDV.Location = New System.Drawing.Point(484, 112)
        Me.MfechaDV.Mask = "00/00/0000"
        Me.MfechaDV.Name = "MfechaDV"
        Me.MfechaDV.Size = New System.Drawing.Size(86, 20)
        Me.MfechaDV.TabIndex = 110
        Me.MfechaDV.ValidatingType = GetType(Date)
        '
        'ErrorIcon
        '
        Me.ErrorIcon.ContainerControl = Me
        Me.ErrorIcon.Icon = CType(resources.GetObject("ErrorIcon.Icon"), System.Drawing.Icon)
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(405, 116)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 13)
        Me.Label22.TabIndex = 135
        Me.Label22.Text = "Fecha Venc."
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.BackColor = System.Drawing.Color.White
        Me.lblRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocial.Location = New System.Drawing.Point(109, 197)
        Me.lblRazonSocial.MaximumSize = New System.Drawing.Size(349, 15)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(247, 15)
        Me.lblRazonSocial.TabIndex = 134
        Me.lblRazonSocial.Text = "Nombre Auxiliar"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(215, 171)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 23)
        Me.Button3.TabIndex = 133
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(15, 176)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(27, 13)
        Me.Label28.TabIndex = 132
        Me.Label28.Text = "Ruc"
        '
        'txtRuc
        '
        Me.txtRuc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtRuc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRuc.Location = New System.Drawing.Point(109, 172)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(85, 20)
        Me.txtRuc.TabIndex = 112
        '
        'cboAdq
        '
        Me.cboAdq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAdq.FormattingEnabled = True
        Me.cboAdq.Items.AddRange(New Object() {"GRAVADAS Y/O DE EXPORTACIÓN", "GRAVADAS Y/O DE EXPORTACIÓN Y A OPERACIONES NO GRAVADAS", "OPERACIONES NO GRAVADAS", "VALOR DE LAS ADQUISIONES NO GRAVADAS"})
        Me.cboAdq.Location = New System.Drawing.Point(109, 143)
        Me.cboAdq.Name = "cboAdq"
        Me.cboAdq.Size = New System.Drawing.Size(247, 21)
        Me.cboAdq.TabIndex = 111
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(15, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 29)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "Adq. Gravadas Dest. a Oper."
        '
        'txtCuentaTotal
        '
        Me.txtCuentaTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCuentaTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCuentaTotal.Location = New System.Drawing.Point(484, 374)
        Me.txtCuentaTotal.Name = "txtCuentaTotal"
        Me.txtCuentaTotal.Size = New System.Drawing.Size(86, 20)
        Me.txtCuentaTotal.TabIndex = 122
        '
        'txtCuentaIgv
        '
        Me.txtCuentaIgv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCuentaIgv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCuentaIgv.Location = New System.Drawing.Point(484, 320)
        Me.txtCuentaIgv.Name = "txtCuentaIgv"
        Me.txtCuentaIgv.Size = New System.Drawing.Size(86, 20)
        Me.txtCuentaIgv.TabIndex = 118
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(323, 380)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 130
        Me.Label5.Text = "Total"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(323, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "IGV"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(323, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "ISC"
        '
        'txtCuentaIsc
        '
        Me.txtCuentaIsc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCuentaIsc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCuentaIsc.Location = New System.Drawing.Point(484, 346)
        Me.txtCuentaIsc.Name = "txtCuentaIsc"
        Me.txtCuentaIsc.Size = New System.Drawing.Size(86, 20)
        Me.txtCuentaIsc.TabIndex = 120
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(323, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Monto"
        '
        'txtCuentaMonto
        '
        Me.txtCuentaMonto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCuentaMonto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCuentaMonto.Location = New System.Drawing.Point(484, 294)
        Me.txtCuentaMonto.Name = "txtCuentaMonto"
        Me.txtCuentaMonto.Size = New System.Drawing.Size(86, 20)
        Me.txtCuentaMonto.TabIndex = 116
        '
        'MfechaDE
        '
        Me.MfechaDE.Location = New System.Drawing.Point(484, 81)
        Me.MfechaDE.Mask = "00/00/0000"
        Me.MfechaDE.Name = "MfechaDE"
        Me.MfechaDE.Size = New System.Drawing.Size(86, 20)
        Me.MfechaDE.TabIndex = 109
        Me.MfechaDE.ValidatingType = GetType(Date)
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(405, 85)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 13)
        Me.Label23.TabIndex = 126
        Me.Label23.Text = "Fecha Emis."
        '
        'cbotipodoc
        '
        Me.cbotipodoc.FormattingEnabled = True
        Me.cbotipodoc.Location = New System.Drawing.Point(109, 81)
        Me.cbotipodoc.Name = "cbotipodoc"
        Me.cbotipodoc.Size = New System.Drawing.Size(247, 21)
        Me.cbotipodoc.TabIndex = 106
        '
        'txtDserie
        '
        Me.txtDserie.Location = New System.Drawing.Point(109, 112)
        Me.txtDserie.MaxLength = 3
        Me.txtDserie.Name = "txtDserie"
        Me.txtDserie.Size = New System.Drawing.Size(35, 20)
        Me.txtDserie.TabIndex = 107
        '
        'txtDnumero
        '
        Me.txtDnumero.Location = New System.Drawing.Point(160, 112)
        Me.txtDnumero.MaxLength = 7
        Me.txtDnumero.Name = "txtDnumero"
        Me.txtDnumero.Size = New System.Drawing.Size(100, 20)
        Me.txtDnumero.TabIndex = 108
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(15, 116)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 13)
        Me.Label24.TabIndex = 125
        Me.Label24.Text = "Nº Documento"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(15, 85)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 13)
        Me.Label25.TabIndex = 124
        Me.Label25.Text = "Tipo Documento"
        '
        'FrmComprobanteN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 402)
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
        Me.Controls.Add(Me.MfechaDV)
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
        Me.Controls.Add(Me.MfechaDE)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cbotipodoc)
        Me.Controls.Add(Me.txtDserie)
        Me.Controls.Add(Me.txtDnumero)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Name = "FrmComprobanteN"
        Me.Text = "FrmComprobanteN"
        CType(Me.ErrorIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents MfechaDV As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ErrorIcon As System.Windows.Forms.ErrorProvider
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
    Friend WithEvents MfechaDE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbotipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtDserie As System.Windows.Forms.TextBox
    Friend WithEvents txtDnumero As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
