<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheck
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
        Me.lblCheck = New System.Windows.Forms.Label()
        Me.tmrChecking = New System.Windows.Forms.Timer(Me.components)
        Me.lblProceso = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCheck
        '
        Me.lblCheck.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCheck.Location = New System.Drawing.Point(37, 239)
        Me.lblCheck.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCheck.Size = New System.Drawing.Size(380, 32)
        Me.lblCheck.TabIndex = 0
        Me.lblCheck.Text = "Comprobando ..."
        '
        'tmrChecking
        '
        Me.tmrChecking.Enabled = True
        '
        'lblProceso
        '
        Me.lblProceso.ForeColor = System.Drawing.SystemColors.Control
        Me.lblProceso.Location = New System.Drawing.Point(450, 239)
        Me.lblProceso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProceso.Name = "lblProceso"
        Me.lblProceso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblProceso.Size = New System.Drawing.Size(80, 32)
        Me.lblProceso.TabIndex = 1
        Me.lblProceso.Text = "%"
        '
        'frmCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.Vista.My.Resources.Resources.ALSee
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(530, 307)
        Me.Controls.Add(Me.lblProceso)
        Me.Controls.Add(Me.lblCheck)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCheck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChecking"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCheck As Label
    Friend WithEvents tmrChecking As Timer
    Friend WithEvents lblProceso As Label
End Class
