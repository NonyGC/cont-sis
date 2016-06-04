<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportes
    Inherits System.Windows.Forms.Form
    'Inherits EngineBaseForm
    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExaminarHasta = New System.Windows.Forms.Button()
        Me.btnExaminarDesde = New System.Windows.Forms.Button()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbPdf = New System.Windows.Forms.RadioButton()
        Me.rbExcel = New System.Windows.Forms.RadioButton()
        Me.rbImpresion = New System.Windows.Forms.RadioButton()
        Me.rbPantalla = New System.Windows.Forms.RadioButton()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pbReporte = New System.Windows.Forms.ProgressBar()
        Me.rdFecha = New System.Windows.Forms.RadioButton()
        Me.rdGeneral = New System.Windows.Forms.RadioButton()
        Me.rdComprobante = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkAgrupado = New System.Windows.Forms.CheckBox()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.bwReport = New System.ComponentModel.BackgroundWorker()
        Me.tmrReporte = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lblNroReg = New System.Windows.Forms.Label()
        Me.lblNroPag = New System.Windows.Forms.Label()
        Me.btnConfiguracion = New System.Windows.Forms.Button()
        Me.opnReporte = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExaminarHasta)
        Me.GroupBox2.Controls.Add(Me.btnExaminarDesde)
        Me.GroupBox2.Controls.Add(Me.txtHasta)
        Me.GroupBox2.Controls.Add(Me.txtDesde)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(245, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rango de Fechas"
        '
        'btnExaminarHasta
        '
        Me.btnExaminarHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!)
        Me.btnExaminarHasta.Location = New System.Drawing.Point(168, 53)
        Me.btnExaminarHasta.Name = "btnExaminarHasta"
        Me.btnExaminarHasta.Size = New System.Drawing.Size(58, 23)
        Me.btnExaminarHasta.TabIndex = 5
        Me.btnExaminarHasta.Text = "Examinar"
        Me.btnExaminarHasta.UseVisualStyleBackColor = True
        '
        'btnExaminarDesde
        '
        Me.btnExaminarDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminarDesde.Location = New System.Drawing.Point(168, 23)
        Me.btnExaminarDesde.Name = "btnExaminarDesde"
        Me.btnExaminarDesde.Size = New System.Drawing.Size(58, 23)
        Me.btnExaminarDesde.TabIndex = 4
        Me.btnExaminarDesde.Text = "Examinar"
        Me.btnExaminarDesde.UseVisualStyleBackColor = True
        '
        'txtHasta
        '
        Me.txtHasta.Location = New System.Drawing.Point(62, 56)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtHasta.TabIndex = 3
        '
        'txtDesde
        '
        Me.txtDesde.Location = New System.Drawing.Point(62, 25)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtDesde.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde: "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbPdf)
        Me.GroupBox5.Controls.Add(Me.rbExcel)
        Me.GroupBox5.Controls.Add(Me.rbImpresion)
        Me.GroupBox5.Controls.Add(Me.rbPantalla)
        Me.GroupBox5.Location = New System.Drawing.Point(245, 118)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(232, 126)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Salida"
        '
        'rbPdf
        '
        Me.rbPdf.AutoSize = True
        Me.rbPdf.Location = New System.Drawing.Point(21, 91)
        Me.rbPdf.Name = "rbPdf"
        Me.rbPdf.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rbPdf.Size = New System.Drawing.Size(46, 17)
        Me.rbPdf.TabIndex = 3
        Me.rbPdf.Text = "PDF"
        Me.rbPdf.UseVisualStyleBackColor = True
        '
        'rbExcel
        '
        Me.rbExcel.AutoSize = True
        Me.rbExcel.Location = New System.Drawing.Point(21, 68)
        Me.rbExcel.Name = "rbExcel"
        Me.rbExcel.Size = New System.Drawing.Size(51, 17)
        Me.rbExcel.TabIndex = 2
        Me.rbExcel.Text = "Excel"
        Me.rbExcel.UseVisualStyleBackColor = True
        '
        'rbImpresion
        '
        Me.rbImpresion.AutoSize = True
        Me.rbImpresion.Location = New System.Drawing.Point(21, 44)
        Me.rbImpresion.Name = "rbImpresion"
        Me.rbImpresion.Size = New System.Drawing.Size(70, 17)
        Me.rbImpresion.TabIndex = 1
        Me.rbImpresion.Text = "Impresión"
        Me.rbImpresion.UseVisualStyleBackColor = True
        '
        'rbPantalla
        '
        Me.rbPantalla.AutoSize = True
        Me.rbPantalla.Checked = True
        Me.rbPantalla.Location = New System.Drawing.Point(21, 20)
        Me.rbPantalla.Name = "rbPantalla"
        Me.rbPantalla.Size = New System.Drawing.Size(63, 17)
        Me.rbPantalla.TabIndex = 0
        Me.rbPantalla.TabStop = True
        Me.rbPantalla.Text = "Pantalla"
        Me.rbPantalla.UseVisualStyleBackColor = True
        '
        'btnReporte
        '
        Me.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReporte.Location = New System.Drawing.Point(310, 249)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(110, 23)
        Me.btnReporte.TabIndex = 5
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(426, 248)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(50, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pbReporte
        '
        Me.pbReporte.Location = New System.Drawing.Point(7, 281)
        Me.pbReporte.Name = "pbReporte"
        Me.pbReporte.Size = New System.Drawing.Size(470, 10)
        Me.pbReporte.Step = 1
        Me.pbReporte.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbReporte.TabIndex = 7
        Me.pbReporte.Visible = False
        '
        'rdFecha
        '
        Me.rdFecha.AutoSize = True
        Me.rdFecha.Checked = True
        Me.rdFecha.Location = New System.Drawing.Point(7, 20)
        Me.rdFecha.Name = "rdFecha"
        Me.rdFecha.Size = New System.Drawing.Size(55, 17)
        Me.rdFecha.TabIndex = 0
        Me.rdFecha.TabStop = True
        Me.rdFecha.Text = "Fecha"
        Me.rdFecha.UseVisualStyleBackColor = True
        '
        'rdGeneral
        '
        Me.rdGeneral.AutoSize = True
        Me.rdGeneral.Location = New System.Drawing.Point(7, 43)
        Me.rdGeneral.Name = "rdGeneral"
        Me.rdGeneral.Size = New System.Drawing.Size(211, 17)
        Me.rdGeneral.TabIndex = 1
        Me.rdGeneral.Text = "Tipo Doc+ Serie + Documento + Fecha"
        Me.rdGeneral.UseVisualStyleBackColor = True
        '
        'rdComprobante
        '
        Me.rdComprobante.AutoSize = True
        Me.rdComprobante.Location = New System.Drawing.Point(7, 66)
        Me.rdComprobante.Name = "rdComprobante"
        Me.rdComprobante.Size = New System.Drawing.Size(93, 17)
        Me.rdComprobante.TabIndex = 2
        Me.rdComprobante.Text = "Comprobantes"
        Me.rdComprobante.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdComprobante)
        Me.GroupBox3.Controls.Add(Me.rdGeneral)
        Me.GroupBox3.Controls.Add(Me.rdFecha)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 93)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(218, 85)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ordenado Por"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAgrupado)
        Me.GroupBox1.Controls.Add(Me.cboPeriodo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 76)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Periodo"
        '
        'chkAgrupado
        '
        Me.chkAgrupado.AutoSize = True
        Me.chkAgrupado.Location = New System.Drawing.Point(7, 51)
        Me.chkAgrupado.Name = "chkAgrupado"
        Me.chkAgrupado.Size = New System.Drawing.Size(72, 17)
        Me.chkAgrupado.TabIndex = 1
        Me.chkAgrupado.Text = "Agrupado"
        Me.chkAgrupado.UseVisualStyleBackColor = True
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Items.AddRange(New Object() {"Apertura", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", "Cierre"})
        Me.cboPeriodo.Location = New System.Drawing.Point(7, 23)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(205, 21)
        Me.cboPeriodo.TabIndex = 0
        '
        'bwReport
        '
        Me.bwReport.WorkerReportsProgress = True
        Me.bwReport.WorkerSupportsCancellation = True
        '
        'tmrReporte
        '
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblNroReg)
        Me.GroupBox7.Controls.Add(Me.lblNroPag)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 182)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(218, 62)
        Me.GroupBox7.TabIndex = 9
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Información"
        '
        'lblNroReg
        '
        Me.lblNroReg.Location = New System.Drawing.Point(7, 35)
        Me.lblNroReg.Name = "lblNroReg"
        Me.lblNroReg.Size = New System.Drawing.Size(205, 13)
        Me.lblNroReg.TabIndex = 1
        Me.lblNroReg.Text = "Número de Registros:"
        '
        'lblNroPag
        '
        Me.lblNroPag.Location = New System.Drawing.Point(7, 18)
        Me.lblNroPag.Name = "lblNroPag"
        Me.lblNroPag.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNroPag.Size = New System.Drawing.Size(205, 13)
        Me.lblNroPag.TabIndex = 0
        Me.lblNroPag.Text = "Número de Paginas:"
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.BackColor = System.Drawing.SystemColors.Control
        Me.btnConfiguracion.BackgroundImage = Global.Vista.My.Resources.Resources.configuration_13194
        Me.btnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfiguracion.Location = New System.Drawing.Point(249, 250)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(55, 23)
        Me.btnConfiguracion.TabIndex = 10
        Me.btnConfiguracion.UseVisualStyleBackColor = False
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(488, 303)
        Me.Controls.Add(Me.btnConfiguracion)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.pbReporte)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnSalir)
        Me.MaximizeBox = False
        Me.Name = "frmReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExaminarHasta As System.Windows.Forms.Button
    Friend WithEvents btnExaminarDesde As System.Windows.Forms.Button
    Friend WithEvents txtHasta As System.Windows.Forms.TextBox
    Friend WithEvents txtDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPdf As System.Windows.Forms.RadioButton
    Friend WithEvents rbExcel As System.Windows.Forms.RadioButton
    Friend WithEvents rbImpresion As System.Windows.Forms.RadioButton
    Friend WithEvents rbPantalla As System.Windows.Forms.RadioButton
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents pbReporte As System.Windows.Forms.ProgressBar
    Friend WithEvents rdFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rdGeneral As System.Windows.Forms.RadioButton
    Friend WithEvents rdComprobante As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAgrupado As System.Windows.Forms.CheckBox
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents bwReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrReporte As System.Windows.Forms.Timer

    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNroReg As System.Windows.Forms.Label
    Friend WithEvents lblNroPag As System.Windows.Forms.Label
    Friend WithEvents btnConfiguracion As Button
    Friend WithEvents opnReporte As OpenFileDialog
End Class
