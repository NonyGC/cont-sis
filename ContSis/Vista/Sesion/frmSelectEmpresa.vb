Imports Controladores
Imports Controladores.ListasBL
Imports Capa_Entidad
Imports Vista.BaseForm
Public Class frmSelectEmpresa
#Region "Variables"
    Dim reglas As New ActivacionEmpresasBL
    Dim men As String
    Dim dtSelectEmpresa As DataTable
    Dim empresas As Empresa()
    Dim f As frmMain = My.Application.OpenForms.Item("frmMain")
    Dim c As Integer = 0
#End Region
#Region "Contructores"
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Try
            empresas = frmMain.Empresas
            dtSelectEmpresa = reglas.getEmpresas(frmMain.UsuarioMain.Id, frmMain.Empresas)
            dgvEmpresa.DataSource = dtSelectEmpresa
            dgvEmpresa.Columns("id").Visible = False
            dgvEmpresa.Columns("compt").Visible = False
            dgvEmpresa.Columns("modu").Visible = False
            dgvEmpresa.Columns("ColEstado").Visible = False

            For Each dgr As DataGridViewRow In dgvEmpresa.Rows

            Next
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

        BtnOn.Enabled = False

        Dim mnu As MenuStrip = f.MnuMain

        Select Case frmMain.UsuarioMain.Tipo
            Case "normal"
                'Variables
                Dim compt As Boolean = dgvEmpresa.Item("compt", dgvEmpresa.CurrentRow.Index).Value()
                Dim modulo As String = dgvEmpresa.Item("modu", dgvEmpresa.CurrentRow.Index).Value().ToString
                Dim estado As Boolean = dgvEmpresa.Item("ColEstado", dgvEmpresa.CurrentRow.Index).Value()
                If estado Then
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
                            End If
                        Next
                    End If

                    Dim actM As ToolStripMenuItem = mnu.Items.Item("Sesión") : actM.DropDownItems.Item("frmSelectEmpresa").Enabled = True
                    f.PnlEmpresa(frmMain.EmpresaMain.Impresion)
                    Dim frm As New Ejercicio
                    frm.MdiParent = Me.ParentForm
                    frm.Show()
                    CloseForm("frmSelectEmpresa")
                End If
            Case "admin"

                Dim empresa As New Empresa
                empresa.RUC = dgvEmpresa.Item("ColRuC", dgvEmpresa.CurrentRow.Index).Value().ToString
                empresa.Nombre = dgvEmpresa.Item("ColRznScl", dgvEmpresa.CurrentRow.Index).Value().ToString()
                empresa.Aliass = dgvEmpresa.Item("ColAlias", dgvEmpresa.CurrentRow.Index).Value().ToString
                empresa.Digito = dgvEmpresa.Item("ColDigito", dgvEmpresa.CurrentRow.Index).Value()
                empresa.Codigo = dgvEmpresa.Item("ColCod", dgvEmpresa.CurrentRow.Index).Value()
                frmMain.EmpresaMain = empresa

                Dim actM As ToolStripMenuItem = mnu.Items.Item("Sesión") : actM.DropDownItems.Item("frmSelectEmpresa").Enabled = True
                f.PnlEmpresa(frmMain.EmpresaMain.Impresion)
                Dim frm As New Ejercicio
                frm.MdiParent = Me.ParentForm
                frm.Show()
                CloseForm("frmSelectEmpresa")

                ''Logica 
                'For Each rw As DataRow In dt.Rows
                '    Dim iMnu As ToolStripMenuItem = mnu.Items.Item(rw("menu").ToString.Replace(" ", Nothing))
                '    iMnu.Enabled = True
                '    If rw("form").ToString.Contains("*") And rw("submenu") = 0 Then
                '        PermisoAll(iMnu)
                '    Else
                '        PermisoSelect(iMnu, FormsArray(rw("form").ToString, CInt(rw("cantidad"))))
                '    End If
                'Next
                '    Case listUsuario.Admin, listUsuario.Master

        End Select





    End Sub
    Private Sub PermisoSelect(iMnu As ToolStripMenuItem, forms() As String)
        For Each i As ToolStripMenuItem In iMnu.DropDownItems
            For j As Integer = 0 To forms.Length
                If i.Tag.ToString = forms(j).ToString Then
                    i.Enabled = True
                    i.BackColor = System.Drawing.SystemColors.Control
                Else
                    i.Enabled = False
                    i.BackColor = System.Drawing.SystemColors.ControlDark

                End If
            Next
        Next

    End Sub

    Private Sub recorrer_Menus(ByVal item As ToolStripItemCollection)
        'Variable
        Dim itemTemp As ToolStripMenuItem
        'Logica
        Try
            For Each otroItem As ToolStripItem In item
                EmpresaBL.Enabled_ToolStripItem(otroItem, True)
                If TypeOf otroItem Is ToolStripMenuItem Then
                    If otroItem.IsOnDropDown Then
                        itemTemp = otroItem
                        If itemTemp.DropDownItems.Count > 0 Then
                            recorrer_Menus(itemTemp.DropDownItems)
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub recorrer_Menus(ByVal item As ToolStripItemCollection, ByRef menact As String)
        'Variable
        Dim itemTemp As ToolStripMenuItem
        'Logica
        Try
            For Each otroItem As ToolStripItem In item
                If otroItem.Tag IsNot Nothing Then
                    If CInt(otroItem.Tag.ToString) = CInt(menact) Then
                        EmpresaBL.Enabled_ToolStripItem(otroItem, True)
                    Else
                        EmpresaBL.Enabled_ToolStripItem(otroItem, False)
                    End If
                End If
                If TypeOf otroItem Is ToolStripMenuItem Then
                    If otroItem.IsOnDropDown Then
                        itemTemp = otroItem
                        If itemTemp.DropDownItems.Count > 0 Then
                            recorrer_Menus(itemTemp.DropDownItems, "")
                        End If
                    End If
                End If

            Next

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub
    Private Function FormsArray(ByRef forms As String, count As Integer) As String()
        'Variables
        Dim star, fin As Integer
        Dim encon, cadena As String
        Dim res(count - 1) As String

        'Logica
        encon = "" : cadena = forms
        star = InStr(1, cadena, "[")
        fin = InStr(1, cadena, "]")

        For i As Integer = 0 To count - 1

            If star <> 0 And fin <> 0 Then
                encon = Mid(cadena, star + 1, fin - 2)
                forms = Mid(cadena, fin + 1, cadena.Length)
            End If
            If encon.Trim().Length > 0 Then
                res(i) = encon
            Else
                res(i) = ""
            End If
        Next
        Return res
    End Function
    Private Function recorrer_data_Contendedor(ByRef cadenaContenedor As String) As String
        'Variables
        Dim star, fin As Integer
        Dim encon, cadena As String
        'Logica
        encon = "" : cadena = cadenaContenedor
        star = InStr(1, cadena, "[")
        fin = InStr(1, cadena, "]")
        If star <> 0 And fin <> 0 Then
            encon = Mid(cadena, star + 1, fin - 2)
            cadenaContenedor = Mid(cadena, fin + 1, cadena.Length)
        End If
        If encon.Trim().Length > 0 Then
            Return encon
        Else
            Return ""
        End If

    End Function

    Private Sub PermisoAll(iMnu As ToolStripMenuItem)
        For Each opc As ToolStripMenuItem In iMnu.DropDownItems
            opc.Enabled = True
        Next
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnOn_Click(sender As Object, e As EventArgs) Handles BtnOn.Click
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

    End Sub

    Private Sub frmSelectEmpresa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim mnu As MenuStrip = f.MnuMain
        Dim actM As ToolStripMenuItem = mnu.Items.Item("Sesión") : actM.DropDownItems.Item("frmSelectEmpresa").Enabled = True
    End Sub

    Private Sub dgvEmpresa_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvEmpresa.DataError
        ' MsgBox(e.RowIndex)
    End Sub
End Class
