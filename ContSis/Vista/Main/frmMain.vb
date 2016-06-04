﻿Imports Controladores
Imports Controladores.ListasBL
Imports Controladores.MainBL
Imports System.Reflection
Imports Capa_Entidad
Imports Vista.BaseForm

Public Class frmMain
#Region "Variables"
    Private Shared _EmpresaMain As Empresa
    Private Shared DataRepore As New ReporteEN
    Private Shared _UsuarioMain As UsuarioMain
    Public Shared _EjercicioMain As String
    Public Shared _PeriodoMain As String
    Private _focoSize As Boolean = False
    Private Shared _action As listUsuario
    Private _oBL As New MainBL
    Private _state As listForm
    Shared _isMaster As Boolean = False
#End Region
#Region "Propiedades"
#Region "Shared"
    Public Shared Property EmpresaMain() As Empresa
        Get
            If IsNothing(_EmpresaMain) Then
                Return New Empresa
            End If
            Return _EmpresaMain
        End Get
        Set(value As Empresa)
            _EmpresaMain = value
        End Set
    End Property
    Public Shared Property UsuarioMain() As UsuarioMain
        Get
            If IsNothing(_UsuarioMain) Then
                Return New UsuarioMain
            End If
            Return _UsuarioMain
        End Get
        Set(value As UsuarioMain)
            _UsuarioMain = value
            _isMaster = _UsuarioMain.Rol.IsMaster
        End Set
    End Property
    Public Shared Property Action As listAccion
        Get
            Return _action
        End Get
        Set(value As listAccion)
            _action = value



        End Set
    End Property
    Public Property State As listForm
        Get
            Return _state
        End Get
        Set(value As listForm)
            _state = value

            Select Case _state
                Case listForm.Dependiente

                Case listForm.Independiente
                    Permiso()
                    Secuencia()
            End Select
        End Set
    End Property
    Public Shared Property EjercicioMain As String
        Get
            Return _EjercicioMain
        End Get
        Set(value As String)
            _EjercicioMain = value
        End Set
    End Property
    Public Shared Property PeriodoMain As String
        Get
            Return _PeriodoMain
        End Get
        Set(value As String)
            _PeriodoMain = value
        End Set
    End Property

#End Region


#End Region
#Region "Contructores"
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        CargarMenus()
        ClearMenu()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'Para permisos
        Permiso()
        Debug.WriteLine("New : ...")

    End Sub


#End Region
#Region "Evento"

    Private Sub frmMainv2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        If Not _isMaster Then
            Dim bl As New MainBL
            bl.UpdateUsuario(New Usuario(_UsuarioMain.Usuario.Codigo, "", "", 0, 0))
            notMain.Dispose()
        End If
    End Sub
    Private Sub frmMainv2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            CloseForm("frmLogeo")

            Me.MaximumSize = Me.Size
            Me.MinimumSize = Me.Size

            Me._focoSize = True

            With notMain
                .BalloonTipText = "Inicio de Main"
                .ShowBalloonTip(200000)
            End With

            'Para la secuencia de form.
            Secuencia()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region
#Region "Metodos"
#Region "Inicio"
    Private Sub CargarMenus()
        Dim mainbl As New MainBL
        Dim dt As DataTable = mainbl.getMenus
        If dt IsNot Nothing Then
            For Each dr As DataRow In dt.Rows
                Dim tsmi As New ToolStripMenuItem(dr("name").ToString)
                tsmi.Name = dr("name").ToString.Replace(" ", Nothing)
                tsmi.Tag = dr("id").ToString
                MnuMain.Items.Add(tsmi)
                opcion(tsmi, dr("id"), mainbl)
            Next
        End If
    End Sub
    Private Sub opcion(mnu As ToolStripMenuItem, id As Integer, bl As MainBL)
        Dim dt As DataTable = bl.getOpciones(id)
        For Each dr As DataRow In dt.Rows
            Dim tsmi As PToolStripMenuItem = New PToolStripMenuItem()
            tsmi.Name = dr("name").ToString
            tsmi.Text = dr("dscp").ToString
            tsmi.Image = Nothing
            AddHandler tsmi.Click, AddressOf Option_Click
            tsmi.Tag = dr("id")
            mnu.DropDownItems.Add(tsmi)
        Next
    End Sub
#End Region
#Region "Ejecución Form or Option"
    Private Sub Option_Click(sender As Object, e As EventArgs)
        '
        'Variables

        Dim cons As Boolean = False
        Dim op As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
        Dim fo As New FormOption(op.Name)


        If fo.CheckOption Then
            Listenning(fo.Action)
        Else
            If CheckForm(fo.FullName) Then : Exit Sub : End If
            cons = OpenForm(fo.Name, fo)
            If cons = False Then
                MessageBox.Show(String.Join("" & vbLf, "En Contrucción: " & op.Text), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub
    Private Sub Listenning(l As Integer)
        Select Case l
            Case listAccion.EndSession
                For Each ChildForm As Form In Me.MdiChildren
                    ChildForm.Close()
                Next

                ClearMenu()
                MenuEnabled("Sesión", True)
                OptionOrFormEnabled("Sesión", "frmLogeo", True)

                pnlInfo.Visible = False
                lblEjercicio.Text = ""
                lblEmpresa.Text = ""
                lblPeriodo.Text = ""
                lblUsuario.Text = ""

                _UsuarioMain = Nothing
                _EmpresaMain = Nothing
                _EjercicioMain = Nothing
                _PeriodoMain = Nothing
                _state = listForm.Dependiente


                OpenForm("frmLogeo", Nothing)
                SSUsuario(Nothing)
                SSEmpresa(Nothing)

        End Select
    End Sub
    Private Function OpenForm(formName As String, tag As Object) As Boolean
        Dim frmAssembly As Assembly = Assembly.LoadFile(Application.ExecutablePath)
        Dim mainbl As New MainBL
        Dim cons As Boolean = False
        For Each type As Type In frmAssembly.GetTypes

            If IsNothing(type.BaseType) = False Then

                If type.BaseType.ToString.Contains("Form") Then
                    If type.Name = formName Then
                        Dim frmShow As Form = DirectCast(frmAssembly.CreateInstance(type.ToString, True), Form)
                        If IsNothing(frmShow) = False Then
                            frmShow.Tag = tag
                            frmShow.MdiParent = Me
                            frmShow.Show()
                            cons = True
                            Exit For
                        End If
                    End If
                End If
            End If
        Next
        Return cons

    End Function
#End Region
#Region "Manejo de Form or Option"
    Private Sub OptionOrFormEnabled(parent As String, Name As String, status As Boolean)

        Dim t As ToolStripMenuItem = FindOptionOrForm(parent, Name)
        If Not IsNothing(t) Then
            t.Enabled = status
        End If
    End Sub
    Private Sub OptionOrFormVisible(parent As String, Name As String, status As Boolean)
        Dim t As ToolStripMenuItem = FindOptionOrForm(parent, Name)
        If Not IsNothing(t) Then
            t.Visible = status
        End If

    End Sub
    Private Function FindOptionOrForm(parent As String, name As String) As ToolStripItem
        Try
            Dim t As ToolStripMenuItem = MnuMain.Items.Item(parent)
            Return t.DropDownItems.Item(name)
        Catch ex As Exception
            Debug.WriteLine("Error FindOptionOrForm: " & name & " - " & ex.ToString)
            Return Nothing
        End Try
    End Function

#End Region
#Region "Manejo de Menus"
    Private Sub MenuEnabled(Name As String, status As Boolean)

        Dim t As ToolStripMenuItem = FindMenu(Name)
        If Not IsNothing(t) Then
            t.Enabled = status
        End If
    End Sub
    Private Sub MenuVisible(Name As String, status As Boolean)
        Dim t As ToolStripMenuItem = FindMenu(Name)
        If Not IsNothing(t) Then
            t.Visible = status
        End If

    End Sub
    Private Function FindMenu(parent As String) As ToolStripItem
        Try
            Dim t As ToolStripMenuItem = MnuMain.Items.Item(parent)
            Return t
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Private Sub ClearMenu()
        For Each tool As ToolStripMenuItem In MnuMain.Items
            tool.Enabled = False
            For Each chilTool As ToolStripMenuItem In tool.DropDownItems
                chilTool.Enabled = False
            Next
        Next
    End Sub
#End Region
#Region "Accion Permisos Usuario"
    Private Sub Permiso()
        Select Case _action
            Case listUsuario.Normal
                ActionNormal()
            Case listUsuario.Admin
                ActionAdmin()
            Case listUsuario.Master
                ActionMaster()
        End Select
    End Sub

    Private Sub ActionAdmin()
        ActionAdminAndMaster()


        ActionAdminAndNormal()

        ActionAll()



    End Sub
    Private Sub ActionNormal()



        MenuVisible("Sistema", False)
        OptionOrFormVisible("Sistema", "frmRol", False)
        OptionOrFormVisible("Sistema", "frmUsuario", False)
        OptionOrFormVisible("Sistema", "frmUsuariosConectados", False)
        ActionAdminAndNormal()
        ActionAll()
    End Sub
    Private Sub ActionMaster()

        ActionAdminAndMaster()
        ActionAll()

    End Sub
    Private Sub ActionAll()
        MenuEnabled("Sesión", True)
        OptionOrFormEnabled("Sesión", "frmLogeo", False)
    End Sub
    Private Sub ActionAdminAndNormal()
        OptionOrFormVisible("Mantenimiento", "frmManEmpresa", False)
        OptionOrFormEnabled("Sesión", "frmSelectEmpresa", False)
    End Sub
    Private Sub ActionAdminAndMaster()
        For Each tool As ToolStripMenuItem In MnuMain.Items
            MenuEnabled(tool.Name, True)
            MenuVisible(tool.Name, True)
            For Each t As ToolStripMenuItem In tool.DropDownItems
                OptionOrFormEnabled(tool.Name, t.Name, True)
                OptionOrFormVisible(tool.Name, t.Name, True)
            Next
        Next
    End Sub
#End Region
#Region "Acción Secuencia Usuario"

    Private Sub Secuencia()
        Select Case _action
            Case listUsuario.Normal
                ActionSecNormal()
            Case listUsuario.Admin
                ActionSecAdmin()
            Case listUsuario.Master
                ActionSecMaster()
        End Select
    End Sub
    Private Sub ActionSecAdmin()

        OpenForm("frmUsuariosConectados", Nothing)
        ActionSecAdminAndNormal()
        ActionSecAll()

    End Sub
    Private Sub ActionSecNormal()


        ActionSecAdminAndNormal()
        ActionSecAll()

        Dim rsp As Boolean = _oBL.CheckTipoCambio(Now)
        If rsp Then
            OpenForm("frmTipoCambio", Nothing)
        Else
            OpenForm("frmSelectEmpresa", Nothing)
        End If
    End Sub
    Private Sub ActionSecMaster()

        lblUsuario.Text = _UsuarioMain.Impresion
        _EmpresaMain = New Empresa("00000000000", "Sin Asignar", "Sin Asignar")

        SSEmpresa(Nothing)
        SSForm(Nothing)
        PnlUsuario(_UsuarioMain.Impresion)
        PnlEmpresa(_EmpresaMain.Impresion)
        PnlEjercicio("Sin Asignar")
        PnlPeriodo("Sin Asignar")
        pnlInfo.Visible = True

        ActionSecAll()
    End Sub
    Private Sub ActionSecAll()
        SSUsuario(UsuarioMain.Usuario.Usuario)
        SSForm()
        SSActionForm()
    End Sub
    Private Sub ActionSecAdminAndNormal()

    End Sub
#End Region
#Region "Manejo de StatusStrip"
    Public Sub SSUsuario(Usuario As String)
        If IsNothing(Usuario) Then
            tooUsuario.Text = ""
        Else
            tooUsuario.Text = String.Concat("Usuario: ", Usuario).ToUpper
        End If
    End Sub
    Public Sub SSEmpresa(Empresa As String)
        If IsNothing(Empresa) Then
            tooEmpresa.Text = ""
        Else
            tooEmpresa.Text = String.Concat("Empresa: ", Empresa).ToUpper
        End If


    End Sub
    Public Sub SSForm()
        tooForm.Text = ""
    End Sub
    Public Sub SSForm(Form As String)
        If IsNothing(Form) Then
            tooForm.Text = ""
        Else
            tooForm.Text = String.Concat(Form).ToUpper
        End If

    End Sub
    Public Sub SSActionForm(actionForm As String)

        If IsNothing(actionForm) Then
            tooActionForm.Text = ""
        Else
            tooActionForm.Text = String.Concat(actionForm).ToUpper
        End If

    End Sub
    Public Sub SSActionForm()
        tooActionForm.Text = "Navegue por las modulos".ToUpper
    End Sub



#End Region
#Region "Manejo de Panel"
    Private Sub PnlUsuario(Impresion As String)
        lblUsuario.Text = Impresion
    End Sub
    Private Sub PnlEmpresa(Impresion As String)
        lblEmpresa.Text = Impresion
    End Sub
    Private Sub PnlEjercicio(Impresion As String)
        lblEjercicio.Text = String.Concat("Ejercicio: ", Impresion).ToUpper
    End Sub
    Private Sub PnlPeriodo(Impresion As String)
        lblPeriodo.Text = String.Concat("Periodo: ", Impresion).ToUpper
    End Sub
#End Region

#End Region

End Class

Public Class PToolStripMenuItem
    Inherits System.Windows.Forms.ToolStripMenuItem
#Region "Metodos"
    Public Overrides Function ToString() As String
        Return Me.Name
    End Function
#End Region


End Class

