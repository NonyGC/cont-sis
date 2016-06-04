Imports Controladores
Imports Controladores.ListasBL
Imports Capa_Entidad
Imports Vista.BaseForm
Public Class frmSelectEmpresa
#Region "Variables"
    Dim bl As New ActivacionEmpresasBL
    Dim men As String
    Dim dataTabla As New DataTable
    Dim f As frmMain = My.Application.OpenForms.Item("frmMain")
    Dim c As Integer = 0
    Private _rol As Rol = frmMain.UsuarioMain.Rol
#End Region
#Region "Contructores"
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub
#End Region


    Private Sub dgvempresa_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpresa.CellDoubleClick
        ActivarMenu()
    End Sub

    Private Sub dgvempresa_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvEmpresa.DataBindingComplete
        Select Case _rol.TipoUsuario
            Case listUsuario.Normal
                For Each row As DataGridViewRow In dgvEmpresa.Rows
                    If TypeOf row.Cells("ColEstado").Value Is DBNull Then
                        row.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDark
                    End If
                Next
            Case listUsuario.Admin

            Case listUsuario.Master

        End Select


    End Sub

    Private Sub dgvempresa_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvEmpresa.KeyDown
        If e.KeyCode = Keys.Enter Then
            ActivarMenu()
        End If
    End Sub
    'Metodos
    Private Sub ActivarMenu()

        BtnOn.Enabled = False
        Dim mnu As MenuStrip = f.MnuMain
        frmMain.EmpresaMain = New Empresa(dgvEmpresa.Item("ColRuC", dgvEmpresa.CurrentRow.Index).Value().ToString,
                                                    dgvEmpresa.Item("ColRznScl", dgvEmpresa.CurrentRow.Index).Value().ToString,
                                                    dgvEmpresa.Item("ColAlias", dgvEmpresa.CurrentRow.Index).Value().ToString)
        Select Case _rol.TipoUsuario
            Case listUsuario.Normal
                'Variables
                Dim priv As New CabPrivilegio
                priv.Id = dgvEmpresa.Item("ColPrivilegio", dgvEmpresa.CurrentRow.Index).Value().ToString
                priv.Status = dgvEmpresa.Item("ColEstado", dgvEmpresa.CurrentRow.Index).Value().ToString
                Dim dt As DataTable = bl.getDetPrivilegios(priv.Id)
                Me.Hide()

                ''Logica 
                For Each rw As DataRow In dt.Rows
                    Dim iMnu As ToolStripMenuItem = mnu.Items.Item(rw("menu").ToString.Replace(" ", Nothing))
                    iMnu.Enabled = True
                    If rw("form").ToString.Contains("*") And rw("submenu") = 0 Then
                        PermisoAll(iMnu)
                    Else
                        PermisoSelect(iMnu, FormsArray(rw("form").ToString, CInt(rw("cantidad"))))
                    End If
                Next
            Case listUsuario.Admin, listUsuario.Master



        End Select


        Dim actM As ToolStripMenuItem = mnu.Items.Item("Sesión") : actM.DropDownItems.Item("frmSelectEmpresa").Enabled = True
        f.lblEmpresa.Text = frmMain.EmpresaMain.Impresion

        Dim frm As New frmEjercicio
        frm.MdiParent = Me.ParentForm
        frm.Show()
        CloseForm("frmSelectEmpresa")

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
            MsgBox(ex.Message)
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
        ActivarMenu()
    End Sub


    Private Sub dgvEmpresa_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpresa.CellMouseLeave
        dgvEmpresa.Cursor = Cursors.Default
    End Sub

    Private Sub dgvEmpresa_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpresa.CellMouseEnter
        Dim dg As DataGridViewRow = dgvEmpresa.CurrentRow
        dgvEmpresa.Cursor = Cursors.Hand
    End Sub

    Private Sub FrmActEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With dgvEmpresa
            .DataSource = bl.getEmpresas(frmMain.UsuarioMain.Rol.Id)
        End With
    End Sub

    Private Sub frmSelectEmpresa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim mnu As MenuStrip = f.MnuMain
        Dim actM As ToolStripMenuItem = mnu.Items.Item("Sesión") : actM.DropDownItems.Item("frmSelectEmpresa").Enabled = True
    End Sub
End Class
