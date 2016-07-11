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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ErrorIcon = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.cbotipodoc = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTipodocumento = New System.Windows.Forms.Label()
        Me.CboPeriodo = New System.Windows.Forms.ComboBox()
        Me.cbomoneda = New System.Windows.Forms.ComboBox()
        Me.cboAdq = New System.Windows.Forms.ComboBox()
        Me.lbladquisiciones = New System.Windows.Forms.Label()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.txtnumdiario = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cabecera = New System.Windows.Forms.GroupBox()
        Me.pnlDocumento = New System.Windows.Forms.Panel()
        Me.lblNumerodoc = New System.Windows.Forms.Label()
        Me.txtDnumero = New System.Windows.Forms.TextBox()
        Me.txtDserie = New System.Windows.Forms.TextBox()
        Me.pnlFechavenci = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdiav = New System.Windows.Forms.TextBox()
        Me.txtmesv = New System.Windows.Forms.TextBox()
        Me.txtañov = New System.Windows.Forms.TextBox()
        Me.grpRuc = New System.Windows.Forms.GroupBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.lblRuc = New System.Windows.Forms.Label()
        Me.btnRuc = New System.Windows.Forms.Button()
        Me.txtdia = New System.Windows.Forms.TextBox()
        Me.CboTipolibro = New System.Windows.Forms.ComboBox()
        Me.lblFechaemision = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmes = New System.Windows.Forms.TextBox()
        Me.txtaño = New System.Windows.Forms.TextBox()
        Me.gvComprobante = New System.Windows.Forms.DataGridView()
        Me.det = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbguardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbcancelar = New System.Windows.Forms.ToolStripButton()
        Me.tsbeliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbsalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbexportar = New System.Windows.Forms.ToolStripButton()
        Me.tsbimportar = New System.Windows.Forms.ToolStripButton()
        CType(Me.ErrorIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cabecera.SuspendLayout()
        Me.pnlDocumento.SuspendLayout()
        Me.pnlFechavenci.SuspendLayout()
        Me.grpRuc.SuspendLayout()
        CType(Me.gvComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorIcon
        '
        Me.ErrorIcon.ContainerControl = Me
        Me.ErrorIcon.Icon = CType(resources.GetObject("ErrorIcon.Icon"), System.Drawing.Icon)
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Location = New System.Drawing.Point(20, 83)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(90, 23)
        Me.btnlimpiar.TabIndex = 63
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'cbotipodoc
        '
        Me.cbotipodoc.DropDownWidth = 250
        Me.cbotipodoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotipodoc.FormattingEnabled = True
        Me.cbotipodoc.Location = New System.Drawing.Point(117, 7)
        Me.cbotipodoc.Name = "cbotipodoc"
        Me.cbotipodoc.Size = New System.Drawing.Size(154, 24)
        Me.cbotipodoc.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Moneda"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTipodocumento
        '
        Me.lblTipodocumento.AutoSize = True
        Me.lblTipodocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipodocumento.Location = New System.Drawing.Point(3, 11)
        Me.lblTipodocumento.Name = "lblTipodocumento"
        Me.lblTipodocumento.Size = New System.Drawing.Size(108, 16)
        Me.lblTipodocumento.TabIndex = 50
        Me.lblTipodocumento.Text = "Tipo Documento"
        Me.lblTipodocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboPeriodo
        '
        Me.CboPeriodo.DropDownWidth = 80
        Me.CboPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPeriodo.FormattingEnabled = True
        Me.CboPeriodo.Items.AddRange(New Object() {"enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"})
        Me.CboPeriodo.Location = New System.Drawing.Point(764, 79)
        Me.CboPeriodo.Name = "CboPeriodo"
        Me.CboPeriodo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CboPeriodo.Size = New System.Drawing.Size(100, 24)
        Me.CboPeriodo.TabIndex = 58
        '
        'cbomoneda
        '
        Me.cbomoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbomoneda.FormattingEnabled = True
        Me.cbomoneda.Location = New System.Drawing.Point(107, 83)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(83, 24)
        Me.cbomoneda.TabIndex = 7
        '
        'cboAdq
        '
        Me.cboAdq.DropDownWidth = 350
        Me.cboAdq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAdq.FormattingEnabled = True
        Me.cboAdq.Location = New System.Drawing.Point(107, 116)
        Me.cboAdq.Name = "cboAdq"
        Me.cboAdq.Size = New System.Drawing.Size(218, 24)
        Me.cboAdq.TabIndex = 9
        '
        'lbladquisiciones
        '
        Me.lbladquisiciones.AutoSize = True
        Me.lbladquisiciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladquisiciones.Location = New System.Drawing.Point(10, 119)
        Me.lbladquisiciones.Name = "lbladquisiciones"
        Me.lbladquisiciones.Size = New System.Drawing.Size(93, 16)
        Me.lbladquisiciones.TabIndex = 66
        Me.lbladquisiciones.Text = "Adquisiciones"
        Me.lbladquisiciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.BackColor = System.Drawing.Color.White
        Me.lblRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocial.Location = New System.Drawing.Point(42, 45)
        Me.lblRazonSocial.MaximumSize = New System.Drawing.Size(349, 20)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(349, 18)
        Me.lblRazonSocial.TabIndex = 65
        Me.lblRazonSocial.Text = "Razón Social"
        '
        'txtnumdiario
        '
        Me.txtnumdiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumdiario.Location = New System.Drawing.Point(107, 52)
        Me.txtnumdiario.MaxLength = 4
        Me.txtnumdiario.Name = "txtnumdiario"
        Me.txtnumdiario.Size = New System.Drawing.Size(83, 22)
        Me.txtnumdiario.TabIndex = 54
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(38, 55)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 16)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Nº  Diario"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(695, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Periodo"
        '
        'cabecera
        '
        Me.cabecera.Controls.Add(Me.pnlDocumento)
        Me.cabecera.Controls.Add(Me.pnlFechavenci)
        Me.cabecera.Controls.Add(Me.grpRuc)
        Me.cabecera.Controls.Add(Me.txtdia)
        Me.cabecera.Controls.Add(Me.CboTipolibro)
        Me.cabecera.Controls.Add(Me.lblFechaemision)
        Me.cabecera.Controls.Add(Me.Label1)
        Me.cabecera.Controls.Add(Me.cbomoneda)
        Me.cabecera.Controls.Add(Me.cboAdq)
        Me.cabecera.Controls.Add(Me.txtmes)
        Me.cabecera.Controls.Add(Me.lbladquisiciones)
        Me.cabecera.Controls.Add(Me.txtnumdiario)
        Me.cabecera.Controls.Add(Me.Label20)
        Me.cabecera.Controls.Add(Me.txtaño)
        Me.cabecera.Controls.Add(Me.Label4)
        Me.cabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cabecera.Location = New System.Drawing.Point(7, 109)
        Me.cabecera.Name = "cabecera"
        Me.cabecera.Size = New System.Drawing.Size(860, 165)
        Me.cabecera.TabIndex = 59
        Me.cabecera.TabStop = False
        Me.cabecera.Text = "Cabecera"
        '
        'pnlDocumento
        '
        Me.pnlDocumento.Controls.Add(Me.cbotipodoc)
        Me.pnlDocumento.Controls.Add(Me.lblNumerodoc)
        Me.pnlDocumento.Controls.Add(Me.txtDnumero)
        Me.pnlDocumento.Controls.Add(Me.txtDserie)
        Me.pnlDocumento.Controls.Add(Me.lblTipodocumento)
        Me.pnlDocumento.Location = New System.Drawing.Point(291, 14)
        Me.pnlDocumento.Name = "pnlDocumento"
        Me.pnlDocumento.Size = New System.Drawing.Size(295, 74)
        Me.pnlDocumento.TabIndex = 69
        '
        'lblNumerodoc
        '
        Me.lblNumerodoc.AutoSize = True
        Me.lblNumerodoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumerodoc.Location = New System.Drawing.Point(16, 43)
        Me.lblNumerodoc.Name = "lblNumerodoc"
        Me.lblNumerodoc.Size = New System.Drawing.Size(95, 16)
        Me.lblNumerodoc.TabIndex = 54
        Me.lblNumerodoc.Text = "Nº Documento"
        Me.lblNumerodoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDnumero
        '
        Me.txtDnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDnumero.Location = New System.Drawing.Point(171, 40)
        Me.txtDnumero.MaxLength = 7
        Me.txtDnumero.Name = "txtDnumero"
        Me.txtDnumero.Size = New System.Drawing.Size(100, 22)
        Me.txtDnumero.TabIndex = 4
        '
        'txtDserie
        '
        Me.txtDserie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDserie.Location = New System.Drawing.Point(117, 40)
        Me.txtDserie.MaxLength = 3
        Me.txtDserie.Name = "txtDserie"
        Me.txtDserie.Size = New System.Drawing.Size(35, 22)
        Me.txtDserie.TabIndex = 3
        '
        'pnlFechavenci
        '
        Me.pnlFechavenci.Controls.Add(Me.Label2)
        Me.pnlFechavenci.Controls.Add(Me.txtdiav)
        Me.pnlFechavenci.Controls.Add(Me.txtmesv)
        Me.pnlFechavenci.Controls.Add(Me.txtañov)
        Me.pnlFechavenci.Location = New System.Drawing.Point(614, 45)
        Me.pnlFechavenci.Name = "pnlFechavenci"
        Me.pnlFechavenci.Size = New System.Drawing.Size(210, 36)
        Me.pnlFechavenci.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Fecha Vencimi"
        '
        'txtdiav
        '
        Me.txtdiav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdiav.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiav.Location = New System.Drawing.Point(180, 4)
        Me.txtdiav.MaxLength = 2
        Me.txtdiav.Name = "txtdiav"
        Me.txtdiav.Size = New System.Drawing.Size(23, 22)
        Me.txtdiav.TabIndex = 69
        Me.txtdiav.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmesv
        '
        Me.txtmesv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmesv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmesv.Location = New System.Drawing.Point(158, 4)
        Me.txtmesv.MaxLength = 2
        Me.txtmesv.Name = "txtmesv"
        Me.txtmesv.Size = New System.Drawing.Size(23, 22)
        Me.txtmesv.TabIndex = 70
        Me.txtmesv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtañov
        '
        Me.txtañov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtañov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtañov.Location = New System.Drawing.Point(122, 4)
        Me.txtañov.MaxLength = 4
        Me.txtañov.Name = "txtañov"
        Me.txtañov.Size = New System.Drawing.Size(37, 22)
        Me.txtañov.TabIndex = 71
        Me.txtañov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpRuc
        '
        Me.grpRuc.Controls.Add(Me.txtRuc)
        Me.grpRuc.Controls.Add(Me.lblRuc)
        Me.grpRuc.Controls.Add(Me.btnRuc)
        Me.grpRuc.Controls.Add(Me.lblRazonSocial)
        Me.grpRuc.Location = New System.Drawing.Point(366, 96)
        Me.grpRuc.Name = "grpRuc"
        Me.grpRuc.Size = New System.Drawing.Size(448, 69)
        Me.grpRuc.TabIndex = 66
        Me.grpRuc.TabStop = False
        '
        'txtRuc
        '
        Me.txtRuc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRuc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(42, 20)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(100, 22)
        Me.txtRuc.TabIndex = 8
        '
        'lblRuc
        '
        Me.lblRuc.AutoSize = True
        Me.lblRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRuc.Location = New System.Drawing.Point(4, 23)
        Me.lblRuc.Name = "lblRuc"
        Me.lblRuc.Size = New System.Drawing.Size(32, 16)
        Me.lblRuc.TabIndex = 63
        Me.lblRuc.Text = "Ruc"
        Me.lblRuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRuc
        '
        Me.btnRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRuc.Location = New System.Drawing.Point(162, 20)
        Me.btnRuc.Name = "btnRuc"
        Me.btnRuc.Size = New System.Drawing.Size(35, 23)
        Me.btnRuc.TabIndex = 64
        Me.btnRuc.Text = "..."
        Me.btnRuc.UseVisualStyleBackColor = True
        '
        'txtdia
        '
        Me.txtdia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdia.Location = New System.Drawing.Point(794, 19)
        Me.txtdia.MaxLength = 2
        Me.txtdia.Name = "txtdia"
        Me.txtdia.Size = New System.Drawing.Size(23, 22)
        Me.txtdia.TabIndex = 202
        Me.txtdia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CboTipolibro
        '
        Me.CboTipolibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipolibro.FormattingEnabled = True
        Me.CboTipolibro.Location = New System.Drawing.Point(107, 19)
        Me.CboTipolibro.Name = "CboTipolibro"
        Me.CboTipolibro.Size = New System.Drawing.Size(146, 24)
        Me.CboTipolibro.TabIndex = 100
        '
        'lblFechaemision
        '
        Me.lblFechaemision.AutoSize = True
        Me.lblFechaemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaemision.Location = New System.Drawing.Point(623, 22)
        Me.lblFechaemision.Name = "lblFechaemision"
        Me.lblFechaemision.Size = New System.Drawing.Size(97, 16)
        Me.lblFechaemision.TabIndex = 55
        Me.lblFechaemision.Text = "Fecha Emisión"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Tipo de Libro"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtmes
        '
        Me.txtmes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmes.Location = New System.Drawing.Point(772, 19)
        Me.txtmes.MaxLength = 2
        Me.txtmes.Name = "txtmes"
        Me.txtmes.Size = New System.Drawing.Size(23, 22)
        Me.txtmes.TabIndex = 201
        Me.txtmes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtaño
        '
        Me.txtaño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaño.Location = New System.Drawing.Point(736, 19)
        Me.txtaño.MaxLength = 4
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(37, 22)
        Me.txtaño.TabIndex = 200
        Me.txtaño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gvComprobante
        '
        Me.gvComprobante.AllowUserToResizeColumns = False
        Me.gvComprobante.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.gvComprobante.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvComprobante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvComprobante.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gvComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvComprobante.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.det, Me.Cuenta, Me.Nombre, Me.Glosa, Me.Debe, Me.Haber})
        Me.gvComprobante.Location = New System.Drawing.Point(3, 16)
        Me.gvComprobante.Name = "gvComprobante"
        Me.gvComprobante.RowHeadersVisible = False
        Me.gvComprobante.Size = New System.Drawing.Size(851, 245)
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
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Cuenta.DefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Debe.DefaultCellStyle = DataGridViewCellStyle3
        Me.Debe.FillWeight = 49.0373!
        Me.Debe.HeaderText = "Debe"
        Me.Debe.Name = "Debe"
        '
        'Haber
        '
        Me.Haber.DataPropertyName = "haber"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Haber.DefaultCellStyle = DataGridViewCellStyle4
        Me.Haber.FillWeight = 48.3732!
        Me.Haber.HeaderText = "Haber"
        Me.Haber.Name = "Haber"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gvComprobante)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(860, 264)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(-3, 53)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(878, 23)
        Me.lblTitulo.TabIndex = 66
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbguardar, Me.tsbcancelar, Me.tsbeliminar, Me.tsbsalir, Me.ToolStripSeparator1, Me.tsbexportar, Me.tsbimportar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(873, 53)
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
        'frmComprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 547)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.CboPeriodo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cabecera)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmComprobantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ErrorIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cabecera.ResumeLayout(False)
        Me.cabecera.PerformLayout()
        Me.pnlDocumento.ResumeLayout(False)
        Me.pnlDocumento.PerformLayout()
        Me.pnlFechavenci.ResumeLayout(False)
        Me.pnlFechavenci.PerformLayout()
        Me.grpRuc.ResumeLayout(False)
        Me.grpRuc.PerformLayout()
        CType(Me.gvComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorIcon As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents CboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cabecera As System.Windows.Forms.GroupBox
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents cboAdq As System.Windows.Forms.ComboBox
    Friend WithEvents lbladquisiciones As System.Windows.Forms.Label
    Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents txtnumdiario As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTipodocumento As System.Windows.Forms.Label
    Friend WithEvents cbotipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtDserie As System.Windows.Forms.TextBox
    Friend WithEvents btnRuc As System.Windows.Forms.Button
    Friend WithEvents lblRuc As System.Windows.Forms.Label
    Friend WithEvents txtDnumero As System.Windows.Forms.TextBox
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents lblNumerodoc As System.Windows.Forms.Label
    Friend WithEvents lblFechaemision As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gvComprobante As System.Windows.Forms.DataGridView
    Friend WithEvents CboTipolibro As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdia As System.Windows.Forms.TextBox
    Friend WithEvents txtaño As System.Windows.Forms.TextBox
    Friend WithEvents txtmes As System.Windows.Forms.TextBox
    Friend WithEvents txtañov As System.Windows.Forms.TextBox
    Friend WithEvents txtmesv As System.Windows.Forms.TextBox
    Friend WithEvents txtdiav As System.Windows.Forms.TextBox
    Friend WithEvents grpRuc As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlFechavenci As System.Windows.Forms.Panel
    Friend WithEvents pnlDocumento As System.Windows.Forms.Panel
    Friend WithEvents det As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbguardar As ToolStripButton
    Friend WithEvents tsbcancelar As ToolStripButton
    Friend WithEvents tsbeliminar As ToolStripButton
    Friend WithEvents tsbsalir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbexportar As ToolStripButton
    Friend WithEvents tsbimportar As ToolStripButton
End Class
