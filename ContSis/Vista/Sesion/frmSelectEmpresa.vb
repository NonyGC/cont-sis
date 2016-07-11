Imports Controladores
Imports Controladores.ListasBL
Imports Capa_Entidad
Imports Vista.BaseForm
Public Class frmSelectEmpresa
#Region "Variables"
    Dim reglas As New ActivacionEmpresasBL(frmMain.UsuarioMain, frmMain.Empresas)
    Dim men As String
    Dim dtSelectEmpresa As DataTable
    Dim empresas As Empresa()
    Dim f As frmMain = My.Application.OpenForms.Item("frmMain")
    Dim c As Integer = 0
    Dim usuario As Usuario
#End Region
#Region "Contructores"
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Try
            empresas = frmMain.Empresas
            usuario = frmMain.UsuarioMain
            dtSelectEmpresa = reglas.getEmpresas()
            dgvEmpresa.DataSource = dtSelectEmpresa
            dgvEmpresa.Columns("id").Visible = False
            dgvEmpresa.Columns("compt").Visible = False
            dgvEmpresa.Columns("modu").Visible = False

        Catch ex As Exception

        End Try


    End Sub
#End Region


    Private Sub dgvempresa_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpresa.CellDoubleClick
        Try
            If dgvEmpresa.RowCount >= 0 Then
                ActivarMenu()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub dgvempresa_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvEmpresa.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgvEmpresa.RowCount >= 0 Then
                ActivarMenu()
            End If

        End If
    End Sub
    'Metodos
    Private Sub ActivarMenu()

        Dim mnu As MenuStrip = f.MnuMain

        Dim modulo As String = dgvEmpresa.Item("modu", dgvEmpresa.CurrentRow.Index).Value().ToString
        Dim estado As Integer = dgvEmpresa.Item("ColEstado", dgvEmpresa.CurrentRow.Index).Value()
        Select Case estado
            Case 0
                If usuario.Tipo = "normal" Then
                    Dim compt As Boolean = dgvEmpresa.Item("compt", dgvEmpresa.CurrentRow.Index).Value()
                    If compt Then

                        For Each tool As ToolStripMenuItem In mnu.Items
                            tool.Enabled = True
                            For Each chilTool As ToolStripMenuItem In tool.DropDownItems
                                chilTool.Enabled = True
                            Next
                        Next

                    Else
                        For Each tool As ToolStripMenuItem In mnu.Items
                            If modulo.Contains(tool.Tag) Then
                                tool.Enabled = True
                                For Each chilTool As ToolStripMenuItem In tool.DropDownItems
                                    chilTool.Enabled = True
                                Next
                            Else
                                tool.Enabled = False
                                For Each chilTool As ToolStripMenuItem In tool.DropDownItems
                                    chilTool.Enabled = False
                                Next
                            End If
                        Next
                    End If
                    f.MenuVisible("Sistemas", False)
                    f.MenuEnabled("Sistemas", False)
                    f.OptionOrFormVisible("Sesión", "frmUsuariosConectados", False)
                    f.PnlEmpresa(frmMain.EmpresaMain.Impresion)

                Else
                    f.ActionAdmin()
                End If
                f.MenuEnabled("Sesión", True)
                f.OptionOrFormEnabled("Sesión", "opc_2", True)
                f.OptionOrFormEnabled("Sesión", "frmSelectEmpresa", True)
                Dim empresa As New Empresa
                empresa.RUC = dgvEmpresa.Item("ColRuC", dgvEmpresa.CurrentRow.Index).Value().ToString
                empresa.Nombre = dgvEmpresa.Item("ColRznScl", dgvEmpresa.CurrentRow.Index).Value().ToString()
                empresa.Aliass = dgvEmpresa.Item("ColAlias", dgvEmpresa.CurrentRow.Index).Value().ToString
                empresa.Digito = dgvEmpresa.Item("ColDigito", dgvEmpresa.CurrentRow.Index).Value()
                empresa.Codigo = dgvEmpresa.Item("ColCod", dgvEmpresa.CurrentRow.Index).Value()
                frmMain.EmpresaMain = empresa
                f.PnlEmpresa(frmMain.EmpresaMain.Impresion)

                Dim vp As VencimientoPagos = reglas.VencimientoPago(frmMain.EmpresaMain.RUC.ToString.Substring(10), Now.Month - 1)
                If vp IsNot Nothing Then
                    If Now.Day = vp.Fecha.Day - 2 Then
                        MsgBox("En 2 dias sera vencimiento del Pago.", MsgBoxStyle.OkOnly, "Cronograma Pagos")
                    ElseIf Now.Day = vp.Fecha.Day - 1 Then
                        MsgBox("En 1 dia sera vencimiento del Pago.", MsgBoxStyle.OkOnly, "Cronograma Pagos")
                    ElseIf Now.Day = vp.Fecha.Day Then
                        MsgBox("Hoy dia termina el vencimiento de Pago.", MsgBoxStyle.OkOnly, "Cronograma Pagos")
                    End If
                End If


                Dim frm As New Ejercicio
                frm.MdiParent = Me.ParentForm
                frm.Show()

            Case 1
                MsgBox("No tiene permisos para usar esta Empresa.", MsgBoxStyle.OkOnly, "Selección de Empresa")
            Case 2
                MsgBox("La empresa no tiene información para continuar.", MsgBoxStyle.OkOnly, "Selección de Empresa")
        End Select

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnOn_Click(sender As Object, e As EventArgs)
        If dgvEmpresa.RowCount >= 0 Then
            ActivarMenu()
        End If

    End Sub


    Private Sub dgvEmpresa_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpresa.CellMouseLeave
        dgvEmpresa.Cursor = Cursors.Default
    End Sub

    Private Sub dgvEmpresa_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpresa.CellMouseEnter
        Dim dg As DataGridViewRow = dgvEmpresa.CurrentRow
        dgvEmpresa.Cursor = Cursors.Hand
    End Sub

    Private Sub FrmActEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CloseForm("frmEjercicio")
        If usuario.Tipo = "normal" Then
            For Each dgr As DataGridViewRow In dgvEmpresa.Rows
                If dgr.Cells("ColEstado").Value = 0 Then
                    dgr.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control
                    dgr.DefaultCellStyle.SelectionBackColor = Color.SkyBlue
                Else
                    dgr.DefaultCellStyle.BackColor = Color.DarkGray
                    dgr.DefaultCellStyle.SelectionBackColor = Color.SkyBlue
                End If
            Next
        End If
    End Sub

    Private Sub frmSelectEmpresa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim mnu As MenuStrip = f.MnuMain
        Dim actM As ToolStripMenuItem = mnu.Items.Item("Sesión") : actM.DropDownItems.Item("frmSelectEmpresa").Enabled = True
    End Sub

    Private Sub dgvEmpresa_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvEmpresa.DataError

    End Sub
End Class
