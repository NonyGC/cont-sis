<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPlanCuentasAdicional
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
        Me.tabcuentas = New System.Windows.Forms.TabControl()
        Me.tcuentaimport = New System.Windows.Forms.TabPage()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txthoja = New Vista.WaterMark()
        Me.txtpath = New Vista.WaterMark()
        Me.btnconfirmar = New System.Windows.Forms.Button()
        Me.btnprevista = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTImport = New System.Windows.Forms.DataGridView()
        Me.btnpath = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tcuentaexport = New System.Windows.Forms.TabPage()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tabcuentas.SuspendLayout()
        Me.tcuentaimport.SuspendLayout()
        CType(Me.DTImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabcuentas
        '
        Me.tabcuentas.Controls.Add(Me.tcuentaimport)
        Me.tabcuentas.Controls.Add(Me.tcuentaexport)
        Me.tabcuentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcuentas.Location = New System.Drawing.Point(0, 0)
        Me.tabcuentas.Name = "tabcuentas"
        Me.tabcuentas.SelectedIndex = 0
        Me.tabcuentas.Size = New System.Drawing.Size(717, 404)
        Me.tabcuentas.TabIndex = 152
        '
        'tcuentaimport
        '
        Me.tcuentaimport.BackColor = System.Drawing.SystemColors.Control
        Me.tcuentaimport.Controls.Add(Me.ProgressBar1)
        Me.tcuentaimport.Controls.Add(Me.txthoja)
        Me.tcuentaimport.Controls.Add(Me.txtpath)
        Me.tcuentaimport.Controls.Add(Me.btnconfirmar)
        Me.tcuentaimport.Controls.Add(Me.btnprevista)
        Me.tcuentaimport.Controls.Add(Me.Label2)
        Me.tcuentaimport.Controls.Add(Me.DTImport)
        Me.tcuentaimport.Controls.Add(Me.btnpath)
        Me.tcuentaimport.Controls.Add(Me.Label1)
        Me.tcuentaimport.Location = New System.Drawing.Point(4, 22)
        Me.tcuentaimport.Name = "tcuentaimport"
        Me.tcuentaimport.Padding = New System.Windows.Forms.Padding(3)
        Me.tcuentaimport.Size = New System.Drawing.Size(709, 378)
        Me.tcuentaimport.TabIndex = 0
        Me.tcuentaimport.Text = "Importar"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(11, 325)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(690, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 162
        '
        'txthoja
        '
        Me.txthoja.Location = New System.Drawing.Point(104, 41)
        Me.txthoja.Name = "txthoja"
        Me.txthoja.Size = New System.Drawing.Size(168, 20)
        Me.txthoja.TabIndex = 161
        Me.txthoja.WaterMarkColor = System.Drawing.Color.Gray
        Me.txthoja.WaterMarkText = "Text"
        '
        'txtpath
        '
        Me.txtpath.Location = New System.Drawing.Point(104, 15)
        Me.txtpath.Name = "txtpath"
        Me.txtpath.Size = New System.Drawing.Size(295, 20)
        Me.txtpath.TabIndex = 160
        Me.txtpath.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtpath.WaterMarkText = "Text"
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Location = New System.Drawing.Point(310, 251)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(75, 40)
        Me.btnconfirmar.TabIndex = 159
        Me.btnconfirmar.Text = "Confirmar Importación"
        Me.btnconfirmar.UseVisualStyleBackColor = True
        '
        'btnprevista
        '
        Me.btnprevista.Location = New System.Drawing.Point(278, 66)
        Me.btnprevista.Name = "btnprevista"
        Me.btnprevista.Size = New System.Drawing.Size(143, 23)
        Me.btnprevista.TabIndex = 158
        Me.btnprevista.Text = "Previsualizar y verificar"
        Me.btnprevista.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Hoja Excel"
        '
        'DTImport
        '
        Me.DTImport.AllowUserToAddRows = False
        Me.DTImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTImport.Location = New System.Drawing.Point(11, 95)
        Me.DTImport.Name = "DTImport"
        Me.DTImport.RowHeadersVisible = False
        Me.DTImport.Size = New System.Drawing.Size(680, 150)
        Me.DTImport.TabIndex = 155
        '
        'btnpath
        '
        Me.btnpath.Location = New System.Drawing.Point(405, 13)
        Me.btnpath.Name = "btnpath"
        Me.btnpath.Size = New System.Drawing.Size(75, 23)
        Me.btnpath.TabIndex = 54
        Me.btnpath.Text = "Buscar"
        Me.btnpath.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Archivo Excel"
        '
        'tcuentaexport
        '
        Me.tcuentaexport.BackColor = System.Drawing.SystemColors.Control
        Me.tcuentaexport.Location = New System.Drawing.Point(4, 22)
        Me.tcuentaexport.Name = "tcuentaexport"
        Me.tcuentaexport.Padding = New System.Windows.Forms.Padding(3)
        Me.tcuentaexport.Size = New System.Drawing.Size(709, 378)
        Me.tcuentaexport.TabIndex = 1
        Me.tcuentaexport.Text = "Exportar"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Frm_PlanCuentas_Adicional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 404)
        Me.Controls.Add(Me.tabcuentas)
        Me.Name = "Frm_PlanCuentas_Adicional"
        Me.Text = "Frm_PlanCuentas_Adicional"
        Me.tabcuentas.ResumeLayout(False)
        Me.tcuentaimport.ResumeLayout(False)
        Me.tcuentaimport.PerformLayout()
        CType(Me.DTImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabcuentas As TabControl
    Friend WithEvents tcuentaimport As TabPage
    Friend WithEvents btnpath As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tcuentaexport As TabPage
    Friend WithEvents DTImport As DataGridView
    Friend WithEvents btnprevista As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnconfirmar As Button
    Friend WithEvents txtpath As WaterMark
    Friend WithEvents txthoja As WaterMark
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
