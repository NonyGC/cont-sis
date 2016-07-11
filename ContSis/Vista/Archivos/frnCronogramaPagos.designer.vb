<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnCronogramaPagos
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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvCronograma = New System.Windows.Forms.DataGridView()
        Me.ColPeriodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRuc0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRuc1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRuc2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRuc3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.cboUltimoDigito = New System.Windows.Forms.ComboBox()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvCronograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCronograma
        '
        Me.dgvCronograma.AllowUserToAddRows = False
        Me.dgvCronograma.AllowUserToDeleteRows = False
        Me.dgvCronograma.AllowUserToOrderColumns = True
        Me.dgvCronograma.AllowUserToResizeColumns = False
        Me.dgvCronograma.AllowUserToResizeRows = False
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCronograma.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvCronograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCronograma.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColPeriodo, Me.ColRuc0, Me.ColRuc1, Me.ColRuc2, Me.ColRuc3, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgvCronograma.Location = New System.Drawing.Point(18, 144)
        Me.dgvCronograma.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCronograma.Name = "dgvCronograma"
        Me.dgvCronograma.RowHeadersVisible = False
        Me.dgvCronograma.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvCronograma.RowTemplate.Height = 30
        Me.dgvCronograma.Size = New System.Drawing.Size(1118, 403)
        Me.dgvCronograma.TabIndex = 0
        '
        'ColPeriodo
        '
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control
        Me.ColPeriodo.DefaultCellStyle = DataGridViewCellStyle20
        Me.ColPeriodo.Frozen = True
        Me.ColPeriodo.HeaderText = "Periodo Tributario"
        Me.ColPeriodo.Name = "ColPeriodo"
        Me.ColPeriodo.ReadOnly = True
        Me.ColPeriodo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColRuc0
        '
        Me.ColRuc0.Frozen = True
        Me.ColRuc0.HeaderText = "0"
        Me.ColRuc0.Name = "ColRuc0"
        Me.ColRuc0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColRuc0.Width = 90
        '
        'ColRuc1
        '
        Me.ColRuc1.HeaderText = "1"
        Me.ColRuc1.Name = "ColRuc1"
        Me.ColRuc1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColRuc1.Width = 90
        '
        'ColRuc2
        '
        Me.ColRuc2.HeaderText = "2"
        Me.ColRuc2.Name = "ColRuc2"
        Me.ColRuc2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColRuc2.Width = 90
        '
        'ColRuc3
        '
        Me.ColRuc3.HeaderText = "3"
        Me.ColRuc3.Name = "ColRuc3"
        Me.ColRuc3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColRuc3.Width = 90
        '
        'Column1
        '
        Me.Column1.HeaderText = "4"
        Me.Column1.Name = "Column1"
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Width = 90
        '
        'Column2
        '
        Me.Column2.HeaderText = "5"
        Me.Column2.Name = "Column2"
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 90
        '
        'Column3
        '
        Me.Column3.HeaderText = "6"
        Me.Column3.Name = "Column3"
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column3.Width = 90
        '
        'Column4
        '
        Me.Column4.HeaderText = "7"
        Me.Column4.Name = "Column4"
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Width = 90
        '
        'Column5
        '
        Me.Column5.HeaderText = "8"
        Me.Column5.Name = "Column5"
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column5.Width = 90
        '
        'Column6
        '
        Me.Column6.HeaderText = "9"
        Me.Column6.Name = "Column6"
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column6.Width = 90
        '
        'Column7
        '
        Me.Column7.HeaderText = "Buenos Contribuyentes"
        Me.Column7.Name = "Column7"
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column7.Width = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Periodo de Presentación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(533, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha de Presentación"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Último digito de RUC"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1149, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Vista.My.Resources.Resources.guardar_false
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Guardar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Vista.My.Resources.Resources.salir
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Cancelar"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.Vista.My.Resources.Resources.eliminar_false
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Eliminar"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.Vista.My.Resources.Resources.log_logout_door_1563
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Salir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(654, 73)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "U.I.T"
        '
        'txtMonto
        '
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.Location = New System.Drawing.Point(700, 69)
        Me.txtMonto.MaxLength = 7
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(71, 24)
        Me.txtMonto.TabIndex = 6
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(339, 28)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(112, 26)
        Me.cboPeriodo.TabIndex = 7
        '
        'cboUltimoDigito
        '
        Me.cboUltimoDigito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUltimoDigito.DropDownWidth = 64
        Me.cboUltimoDigito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboUltimoDigito.FormattingEnabled = True
        Me.cboUltimoDigito.Location = New System.Drawing.Point(339, 64)
        Me.cboUltimoDigito.Name = "cboUltimoDigito"
        Me.cboUltimoDigito.Size = New System.Drawing.Size(58, 26)
        Me.cboUltimoDigito.TabIndex = 8
        '
        'txtDay
        '
        Me.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDay.Location = New System.Drawing.Point(700, 29)
        Me.txtDay.MaxLength = 2
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(31, 24)
        Me.txtDay.TabIndex = 9
        Me.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMonth
        '
        Me.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonth.Location = New System.Drawing.Point(757, 29)
        Me.txtMonth.MaxLength = 2
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(31, 24)
        Me.txtMonth.TabIndex = 10
        Me.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtYear
        '
        Me.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYear.Location = New System.Drawing.Point(815, 29)
        Me.txtYear.MaxLength = 2
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(44, 24)
        Me.txtYear.TabIndex = 11
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(738, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "/"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(796, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "/"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(355, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(453, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "FECHA DE VENCIMIENTO SEGÚN EL ÚLTIMO DÍGITO DEL RUC"
        '
        'frnCronogramaPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1149, 560)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.cboUltimoDigito)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCronograma)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frnCronogramaPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CRONOGRAMA DE OBLIGACIONES MENSUALES"
        CType(Me.dgvCronograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCronograma As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents cboPeriodo As ComboBox
    Friend WithEvents cboUltimoDigito As ComboBox
    Friend WithEvents txtDay As TextBox
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ColPeriodo As DataGridViewTextBoxColumn
    Friend WithEvents ColRuc0 As DataGridViewTextBoxColumn
    Friend WithEvents ColRuc1 As DataGridViewTextBoxColumn
    Friend WithEvents ColRuc2 As DataGridViewTextBoxColumn
    Friend WithEvents ColRuc3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
