<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportePantalla
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
        Me.components = New System.ComponentModel.Container()
        Me.crvFormato8_1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tlRegistros = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'crvFormato8_1
        '
        Me.crvFormato8_1.ActiveViewIndex = -1
        Me.crvFormato8_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvFormato8_1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.crvFormato8_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvFormato8_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvFormato8_1.EnableDrillDown = False
        Me.crvFormato8_1.Location = New System.Drawing.Point(0, 0)
        Me.crvFormato8_1.Name = "crvFormato8_1"
        Me.crvFormato8_1.ShowCloseButton = False
        Me.crvFormato8_1.ShowGroupTreeButton = False
        Me.crvFormato8_1.ShowLogo = False
        Me.crvFormato8_1.ShowParameterPanelButton = False
        Me.crvFormato8_1.ShowTextSearchButton = False
        Me.crvFormato8_1.Size = New System.Drawing.Size(809, 400)
        Me.crvFormato8_1.TabIndex = 0
        Me.crvFormato8_1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlRegistros, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(120, 48)
        Me.ContextMenuStrip1.Text = "Información"
        '
        'tlRegistros
        '
        Me.tlRegistros.Name = "tlRegistros"
        Me.tlRegistros.Size = New System.Drawing.Size(119, 22)
        Me.tlRegistros.Text = "Registros"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(119, 22)
        Me.ToolStripMenuItem2.Text = "R. por Pagina"
        '
        'frmReportePantalla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 400)
        Me.Controls.Add(Me.crvFormato8_1)
        Me.Name = "frmReportePantalla"
        Me.Text = "Reporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvFormato8_1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tlRegistros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
End Class
