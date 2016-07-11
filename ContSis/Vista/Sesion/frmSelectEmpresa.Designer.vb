<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSelectEmpresa
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvEmpresa = New System.Windows.Forms.DataGridView()
        Me.ColRuc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRznScl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAlias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColImagen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColCod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDigito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmpresa
        '
        Me.dgvEmpresa.AllowUserToAddRows = False
        Me.dgvEmpresa.AllowUserToDeleteRows = False
        Me.dgvEmpresa.AllowUserToResizeColumns = False
        Me.dgvEmpresa.AllowUserToResizeRows = False
        Me.dgvEmpresa.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvEmpresa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvEmpresa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpresa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmpresa.ColumnHeadersHeight = 28
        Me.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEmpresa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColRuc, Me.ColRznScl, Me.ColAlias, Me.ColImagen, Me.ColCod, Me.ColDigito, Me.ColEstado})
        Me.dgvEmpresa.GridColor = System.Drawing.SystemColors.Control
        Me.dgvEmpresa.Location = New System.Drawing.Point(18, 78)
        Me.dgvEmpresa.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvEmpresa.MultiSelect = False
        Me.dgvEmpresa.Name = "dgvEmpresa"
        Me.dgvEmpresa.ReadOnly = True
        Me.dgvEmpresa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvEmpresa.RowHeadersVisible = False
        Me.dgvEmpresa.RowHeadersWidth = 50
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.NullValue = "0"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvEmpresa.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpresa.Size = New System.Drawing.Size(636, 415)
        Me.dgvEmpresa.TabIndex = 0
        '
        'ColRuc
        '
        Me.ColRuc.DataPropertyName = "ruc"
        Me.ColRuc.FillWeight = 3.601002!
        Me.ColRuc.HeaderText = "Ruc"
        Me.ColRuc.Name = "ColRuc"
        Me.ColRuc.ReadOnly = True
        Me.ColRuc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColRuc.Width = 120
        '
        'ColRznScl
        '
        Me.ColRznScl.DataPropertyName = "rzn_scl"
        Me.ColRznScl.FillWeight = 20.98395!
        Me.ColRznScl.HeaderText = "Razon Social"
        Me.ColRznScl.Name = "ColRznScl"
        Me.ColRznScl.ReadOnly = True
        Me.ColRznScl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColRznScl.Width = 280
        '
        'ColAlias
        '
        Me.ColAlias.DataPropertyName = "rzn_scl_ls"
        Me.ColAlias.FillWeight = 369.543!
        Me.ColAlias.HeaderText = "R.S Comercial"
        Me.ColAlias.Name = "ColAlias"
        Me.ColAlias.ReadOnly = True
        Me.ColAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColAlias.Width = 180
        '
        'ColImagen
        '
        Me.ColImagen.FillWeight = 5.871868!
        Me.ColImagen.HeaderText = "Logo"
        Me.ColImagen.Name = "ColImagen"
        Me.ColImagen.ReadOnly = True
        Me.ColImagen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColImagen.Width = 54
        '
        'ColCod
        '
        Me.ColCod.DataPropertyName = "cod"
        Me.ColCod.HeaderText = "Codigo"
        Me.ColCod.Name = "ColCod"
        Me.ColCod.ReadOnly = True
        Me.ColCod.Visible = False
        Me.ColCod.Width = 5
        '
        'ColDigito
        '
        Me.ColDigito.DataPropertyName = "dig"
        Me.ColDigito.HeaderText = "Digito"
        Me.ColDigito.Name = "ColDigito"
        Me.ColDigito.ReadOnly = True
        Me.ColDigito.Visible = False
        Me.ColDigito.Width = 5
        '
        'ColEstado
        '
        Me.ColEstado.DataPropertyName = "estado"
        Me.ColEstado.HeaderText = "Estado"
        Me.ColEstado.Name = "ColEstado"
        Me.ColEstado.ReadOnly = True
        Me.ColEstado.Visible = False
        Me.ColEstado.Width = 5
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Logo"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = Global.Vista.My.Resources.Resources.log_logout_door_1563
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Location = New System.Drawing.Point(68, 17)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(39, 39)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmSelectEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 510)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.dgvEmpresa)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(688, 549)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(688, 549)
        Me.Name = "frmSelectEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar Empresa"
        CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvEmpresa As DataGridView
    Friend WithEvents btnCerrar As Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents ColRuc As DataGridViewTextBoxColumn
    Friend WithEvents ColRznScl As DataGridViewTextBoxColumn
    Friend WithEvents ColAlias As DataGridViewTextBoxColumn
    Friend WithEvents ColImagen As DataGridViewImageColumn
    Friend WithEvents ColCod As DataGridViewTextBoxColumn
    Friend WithEvents ColDigito As DataGridViewTextBoxColumn
    Friend WithEvents ColEstado As DataGridViewTextBoxColumn
End Class
