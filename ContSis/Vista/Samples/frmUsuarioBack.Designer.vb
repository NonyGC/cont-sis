<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuarioBack
    Inherits System.Windows.Forms.Form

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
        Me.tvModulo = New System.Windows.Forms.TreeView()
        Me.tabRoles = New System.Windows.Forms.TabControl()
        Me.tabpageEmpresas = New System.Windows.Forms.TabPage()
        Me.btnFront = New System.Windows.Forms.Button()
        Me.btnQuitarT = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregarT = New System.Windows.Forms.Button()
        Me.lbEmpresaSelect = New System.Windows.Forms.ListBox()
        Me.lbEmpresa = New System.Windows.Forms.ListBox()
        Me.tabPageFormulario = New System.Windows.Forms.TabPage()
        Me.lbStateEmpresa = New System.Windows.Forms.ListBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnQuitarModT = New System.Windows.Forms.Button()
        Me.btnAgregarMod = New System.Windows.Forms.Button()
        Me.btnQuitarMod = New System.Windows.Forms.Button()
        Me.btnAgregarModT = New System.Windows.Forms.Button()
        Me.tvModuloSelect = New System.Windows.Forms.TreeView()
        Me.cboEmpresas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.toolTip_Form = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabRoles.SuspendLayout()
        Me.tabpageEmpresas.SuspendLayout()
        Me.tabPageFormulario.SuspendLayout()
        Me.SuspendLayout()
        '
        'tvModulo
        '
        Me.tvModulo.BackColor = System.Drawing.SystemColors.Control
        Me.tvModulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvModulo.Location = New System.Drawing.Point(6, 33)
        Me.tvModulo.Name = "tvModulo"
        Me.tvModulo.Size = New System.Drawing.Size(264, 366)
        Me.tvModulo.TabIndex = 5
        '
        'tabRoles
        '
        Me.tabRoles.Controls.Add(Me.tabpageEmpresas)
        Me.tabRoles.Controls.Add(Me.tabPageFormulario)
        Me.tabRoles.Location = New System.Drawing.Point(12, 12)
        Me.tabRoles.Name = "tabRoles"
        Me.tabRoles.SelectedIndex = 0
        Me.tabRoles.Size = New System.Drawing.Size(774, 440)
        Me.tabRoles.TabIndex = 19
        '
        'tabpageEmpresas
        '
        Me.tabpageEmpresas.BackColor = System.Drawing.SystemColors.Control
        Me.tabpageEmpresas.Controls.Add(Me.btnFront)
        Me.tabpageEmpresas.Controls.Add(Me.btnQuitarT)
        Me.tabpageEmpresas.Controls.Add(Me.btnAgregar)
        Me.tabpageEmpresas.Controls.Add(Me.btnQuitar)
        Me.tabpageEmpresas.Controls.Add(Me.btnAgregarT)
        Me.tabpageEmpresas.Controls.Add(Me.lbEmpresaSelect)
        Me.tabpageEmpresas.Controls.Add(Me.lbEmpresa)
        Me.tabpageEmpresas.Location = New System.Drawing.Point(4, 22)
        Me.tabpageEmpresas.Name = "tabpageEmpresas"
        Me.tabpageEmpresas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageEmpresas.Size = New System.Drawing.Size(766, 414)
        Me.tabpageEmpresas.TabIndex = 0
        Me.tabpageEmpresas.Text = "Empresa"
        '
        'btnFront
        '
        Me.btnFront.Location = New System.Drawing.Point(462, 367)
        Me.btnFront.Name = "btnFront"
        Me.btnFront.Size = New System.Drawing.Size(264, 34)
        Me.btnFront.TabIndex = 17
        Me.btnFront.Text = "Regresar"
        Me.btnFront.UseVisualStyleBackColor = True
        '
        'btnQuitarT
        '
        Me.btnQuitarT.Location = New System.Drawing.Point(323, 199)
        Me.btnQuitarT.Name = "btnQuitarT"
        Me.btnQuitarT.Size = New System.Drawing.Size(118, 23)
        Me.btnQuitarT.TabIndex = 16
        Me.btnQuitarT.Text = "<< Quitar Todo"
        Me.btnQuitarT.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(323, 141)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 23)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "Agregar >>"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(323, 170)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(118, 23)
        Me.btnQuitar.TabIndex = 14
        Me.btnQuitar.Text = "<< Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAgregarT
        '
        Me.btnAgregarT.Location = New System.Drawing.Point(323, 112)
        Me.btnAgregarT.Name = "btnAgregarT"
        Me.btnAgregarT.Size = New System.Drawing.Size(118, 23)
        Me.btnAgregarT.TabIndex = 13
        Me.btnAgregarT.Text = "Agregar Todo >>"
        Me.btnAgregarT.UseVisualStyleBackColor = True
        '
        'lbEmpresaSelect
        '
        Me.lbEmpresaSelect.BackColor = System.Drawing.SystemColors.Control
        Me.lbEmpresaSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbEmpresaSelect.FormattingEnabled = True
        Me.lbEmpresaSelect.Location = New System.Drawing.Point(496, 34)
        Me.lbEmpresaSelect.Name = "lbEmpresaSelect"
        Me.lbEmpresaSelect.Size = New System.Drawing.Size(264, 327)
        Me.lbEmpresaSelect.TabIndex = 3
        '
        'lbEmpresa
        '
        Me.lbEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.lbEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbEmpresa.FormattingEnabled = True
        Me.lbEmpresa.Location = New System.Drawing.Point(6, 35)
        Me.lbEmpresa.Name = "lbEmpresa"
        Me.lbEmpresa.Size = New System.Drawing.Size(264, 366)
        Me.lbEmpresa.TabIndex = 0
        '
        'tabPageFormulario
        '
        Me.tabPageFormulario.BackColor = System.Drawing.SystemColors.Control
        Me.tabPageFormulario.Controls.Add(Me.lbStateEmpresa)
        Me.tabPageFormulario.Controls.Add(Me.lblMsg)
        Me.tabPageFormulario.Controls.Add(Me.btnQuitarModT)
        Me.tabPageFormulario.Controls.Add(Me.btnAgregarMod)
        Me.tabPageFormulario.Controls.Add(Me.btnQuitarMod)
        Me.tabPageFormulario.Controls.Add(Me.btnAgregarModT)
        Me.tabPageFormulario.Controls.Add(Me.tvModuloSelect)
        Me.tabPageFormulario.Controls.Add(Me.cboEmpresas)
        Me.tabPageFormulario.Controls.Add(Me.Label3)
        Me.tabPageFormulario.Controls.Add(Me.tvModulo)
        Me.tabPageFormulario.Location = New System.Drawing.Point(4, 22)
        Me.tabPageFormulario.Name = "tabPageFormulario"
        Me.tabPageFormulario.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageFormulario.Size = New System.Drawing.Size(766, 414)
        Me.tabPageFormulario.TabIndex = 1
        Me.tabPageFormulario.Text = "Modulo"
        '
        'lbStateEmpresa
        '
        Me.lbStateEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.lbStateEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbStateEmpresa.Enabled = False
        Me.lbStateEmpresa.FormattingEnabled = True
        Me.lbStateEmpresa.Location = New System.Drawing.Point(276, 245)
        Me.lbStateEmpresa.Name = "lbStateEmpresa"
        Me.lbStateEmpresa.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lbStateEmpresa.Size = New System.Drawing.Size(214, 156)
        Me.lbStateEmpresa.TabIndex = 14
        '
        'lblMsg
        '
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.DarkRed
        Me.lblMsg.Location = New System.Drawing.Point(190, 7)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(486, 23)
        Me.lblMsg.TabIndex = 13
        Me.lblMsg.Text = "Debe agregar minimo una empresa"
        Me.lblMsg.Visible = False
        '
        'btnQuitarModT
        '
        Me.btnQuitarModT.Location = New System.Drawing.Point(323, 199)
        Me.btnQuitarModT.Name = "btnQuitarModT"
        Me.btnQuitarModT.Size = New System.Drawing.Size(118, 23)
        Me.btnQuitarModT.TabIndex = 12
        Me.btnQuitarModT.Text = "<< Quitar Todo"
        Me.btnQuitarModT.UseVisualStyleBackColor = True
        '
        'btnAgregarMod
        '
        Me.btnAgregarMod.Location = New System.Drawing.Point(323, 141)
        Me.btnAgregarMod.Name = "btnAgregarMod"
        Me.btnAgregarMod.Size = New System.Drawing.Size(118, 23)
        Me.btnAgregarMod.TabIndex = 11
        Me.btnAgregarMod.Text = "Agregar >>"
        Me.btnAgregarMod.UseVisualStyleBackColor = True
        '
        'btnQuitarMod
        '
        Me.btnQuitarMod.Location = New System.Drawing.Point(323, 170)
        Me.btnQuitarMod.Name = "btnQuitarMod"
        Me.btnQuitarMod.Size = New System.Drawing.Size(118, 23)
        Me.btnQuitarMod.TabIndex = 10
        Me.btnQuitarMod.Text = "<< Quitar"
        Me.btnQuitarMod.UseVisualStyleBackColor = True
        '
        'btnAgregarModT
        '
        Me.btnAgregarModT.Location = New System.Drawing.Point(323, 112)
        Me.btnAgregarModT.Name = "btnAgregarModT"
        Me.btnAgregarModT.Size = New System.Drawing.Size(118, 23)
        Me.btnAgregarModT.TabIndex = 9
        Me.btnAgregarModT.Text = "Agregar Todo >>"
        Me.btnAgregarModT.UseVisualStyleBackColor = True
        '
        'tvModuloSelect
        '
        Me.tvModuloSelect.BackColor = System.Drawing.SystemColors.Control
        Me.tvModuloSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvModuloSelect.Location = New System.Drawing.Point(496, 67)
        Me.tvModuloSelect.Name = "tvModuloSelect"
        Me.tvModuloSelect.Size = New System.Drawing.Size(264, 332)
        Me.tvModuloSelect.TabIndex = 8
        '
        'cboEmpresas
        '
        Me.cboEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresas.FormattingEnabled = True
        Me.cboEmpresas.Location = New System.Drawing.Point(496, 35)
        Me.cboEmpresas.Name = "cboEmpresas"
        Me.cboEmpresas.Size = New System.Drawing.Size(264, 21)
        Me.cboEmpresas.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(347, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Empresa"
        '
        'frmUsuarioBack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 464)
        Me.Controls.Add(Me.tabRoles)
        Me.Name = "frmUsuarioBack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRolesHijo"
        Me.tabRoles.ResumeLayout(False)
        Me.tabpageEmpresas.ResumeLayout(False)
        Me.tabPageFormulario.ResumeLayout(False)
        Me.tabPageFormulario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tvModulo As System.Windows.Forms.TreeView
    Friend WithEvents tabRoles As System.Windows.Forms.TabControl
    Friend WithEvents tabpageEmpresas As System.Windows.Forms.TabPage
    Friend WithEvents tabPageFormulario As System.Windows.Forms.TabPage
    Friend WithEvents toolTip_Form As System.Windows.Forms.ToolTip
    Friend WithEvents cboEmpresas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbEmpresaSelect As System.Windows.Forms.ListBox
    Friend WithEvents btnQuitarMod As System.Windows.Forms.Button
    Friend WithEvents btnAgregarModT As System.Windows.Forms.Button
    Friend WithEvents tvModuloSelect As System.Windows.Forms.TreeView
    Friend WithEvents btnFront As Button
    Friend WithEvents btnQuitarT As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnAgregarT As Button
    Friend WithEvents btnQuitarModT As Button
    Friend WithEvents btnAgregarMod As Button
    Friend WithEvents lbEmpresa As ListBox
    Friend WithEvents lblMsg As Label
    Friend WithEvents lbStateEmpresa As ListBox
End Class
