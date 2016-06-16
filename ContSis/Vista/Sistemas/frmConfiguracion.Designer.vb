<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numUsuarios = New System.Windows.Forms.NumericUpDown()
        Me.numEmpresas = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.chkAdmin = New System.Windows.Forms.CheckBox()
        CType(Me.numUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° de Usuarios"
        '
        'numUsuarios
        '
        Me.numUsuarios.Location = New System.Drawing.Point(142, 13)
        Me.numUsuarios.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numUsuarios.Name = "numUsuarios"
        Me.numUsuarios.Size = New System.Drawing.Size(59, 20)
        Me.numUsuarios.TabIndex = 1
        Me.numUsuarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numUsuarios.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'numEmpresas
        '
        Me.numEmpresas.Location = New System.Drawing.Point(142, 39)
        Me.numEmpresas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numEmpresas.Name = "numEmpresas"
        Me.numEmpresas.Size = New System.Drawing.Size(59, 20)
        Me.numEmpresas.TabIndex = 3
        Me.numEmpresas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numEmpresas.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "N° de Empresas"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(103, 149)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(184, 149)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'chkAdmin
        '
        Me.chkAdmin.Location = New System.Drawing.Point(38, 68)
        Me.chkAdmin.Name = "chkAdmin"
        Me.chkAdmin.Size = New System.Drawing.Size(163, 24)
        Me.chkAdmin.TabIndex = 7
        Me.chkAdmin.Text = "Activar Admin"
        Me.chkAdmin.UseVisualStyleBackColor = True
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(273, 184)
        Me.Controls.Add(Me.chkAdmin)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.numEmpresas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numUsuarios)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        CType(Me.numUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents numUsuarios As NumericUpDown
    Friend WithEvents numEmpresas As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents chkAdmin As CheckBox
End Class
