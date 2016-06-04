<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataGridView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvContenedor = New System.Windows.Forms.DataGridView()
        Me.ColId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvContenedor
        '
        Me.dgvContenedor.AllowUserToAddRows = False
        Me.dgvContenedor.AllowUserToDeleteRows = False
        Me.dgvContenedor.AllowUserToResizeColumns = False
        Me.dgvContenedor.AllowUserToResizeRows = False
        Me.dgvContenedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvContenedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvContenedor.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvContenedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContenedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColId, Me.CodRol})
        Me.dgvContenedor.Location = New System.Drawing.Point(13, 13)
        Me.dgvContenedor.MultiSelect = False
        Me.dgvContenedor.Name = "dgvContenedor"
        Me.dgvContenedor.ReadOnly = True
        Me.dgvContenedor.RowHeadersVisible = False
        Me.dgvContenedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContenedor.Size = New System.Drawing.Size(337, 443)
        Me.dgvContenedor.TabIndex = 0
        '
        'ColId
        '
        Me.ColId.FillWeight = 50.76142!
        Me.ColId.HeaderText = "Id"
        Me.ColId.Name = "ColId"
        Me.ColId.ReadOnly = True
        Me.ColId.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CodRol
        '
        Me.CodRol.FillWeight = 149.2386!
        Me.CodRol.HeaderText = "Rol"
        Me.CodRol.Name = "CodRol"
        Me.CodRol.ReadOnly = True
        Me.CodRol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(389, 422)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmDataGridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 513)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.dgvContenedor)
        Me.Name = "FrmDataGridView"
        Me.Text = "FrmDataGridView"
        CType(Me.dgvContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvContenedor As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents ColId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodRol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
