Imports Modelos
Imports Capa_Entidad
Public Class UsuarioBL
    Dim Datos As New UsuarioDao
    'Dim rolDao As New RolDao
    Dim _log As String

    Private Empresas() As Empresa

    Private dataSet As DataSet

    Private dtEmpresaUsuario As DataTable
    Private dtEmpesasActivas As DataTable
    Private dtEmpresaActivaStatic As DataTable
    Private dtEmpresaInactivas As DataTable
    Private dtEmpresaSelect As DataTable


    Private dtModuloUsuario As DataTable
    Private dtModulo As DataTable

    Private listPermiso As New List(Of Permiso)
#Region "Constructor"

    Public Sub New(empresa() As Empresa)

        Me.Empresas = empresa
        dataSet = New DataSet("business_logic_usuario")
#Region "Contrucción de DataTable Empresa"
        dtEmpresaInactivas = New DataTable()
        dtEmpresaActivaStatic = New DataTable()
        BuilDatosdDataTableEmpresas()

        dtEmpresaUsuario = dtEmpresaActivaStatic.Copy
        dtEmpesasActivas = dtEmpresaActivaStatic.Copy
#End Region
        dtEmpresaSelect = CreaDataTableEmpresaPermisoSelect()


        Dim maindao As New ContenedorDAO
        Dim daoModDet As New FormularioDAO
        Dim dtModDet As DataTable = daoModDet.getModuloDetAll()
        dtModulo = maindao.GetContenedorAll(1)

        For Each dr As DataRow In dtModulo.Rows
            dr("name") = "Mod. " & dr("name")
        Next
        dtModuloUsuario = dtModulo.Copy

        dtModulo.PrimaryKey = New DataColumn() {dtModulo.Columns("id")}
        dtModDet.PrimaryKey = New DataColumn() {dtModDet.Columns("id")}

        dtModuloUsuario.TableName = "modulo_usuario"
        dtModulo.TableName = "modulo"
        dtModDet.TableName = "modulo_detalle"
        dtEmpresaSelect.TableName = "empresa_permiso_select"
        dtEmpesasActivas.TableName = "empresa_activa"
        dtEmpresaInactivas.TableName = "empresa_inactiva"
        dtEmpresaUsuario.TableName = "empresa_usuario"


        dataSet.Tables.Add(dtModuloUsuario)
        dataSet.Tables.Add(dtModulo)
        dataSet.Tables.Add(dtModDet)

        dataSet.Tables.Add(dtEmpresaSelect)
        dataSet.Tables.Add(dtEmpresaInactivas)
        dataSet.Tables.Add(dtEmpesasActivas)
        dataSet.Tables.Add(dtEmpresaUsuario)

        dataSet.Relations.Add("mod", dtModulo.Columns("id"),
                              dtModDet.Columns("modcab"))


    End Sub
#End Region
#Region "Propiedades"
    Public ReadOnly Property Log As String
        Get
            Dim msg As String = _log
            _log = ""
            Return msg
        End Get
    End Property
    Public ReadOnly Property DataSetUsuario As DataSet
        Get
            Return dataSet
        End Get
    End Property

#End Region
#Region "Metodos"
    Public Function Registrar(ByVal usuario As Usuario, rPassword As String) As Boolean
        If dtEmpresaSelect.Rows.Count = 0 Then
            Return False
            Exit Function
        End If


        Dim respuesta As Boolean = False
        If usuario.Password <> rPassword Then
            _log += "La contraseña no coinciden " & usuario.Password & " con " & rPassword & vbLf

            respuesta = False
        Else

            Dim daousuario As New UsuarioDao
            Dim respuestaRegistro As Boolean = daousuario.Registrar(usuario)

            If respuestaRegistro Then
                respuesta = True
                Dim usuarioId As Integer = daousuario.IdbyName(usuario.Usuario)
                For Each dr As DataRow In dtEmpresaSelect.Rows
                    Dim permiso As New Permiso
                    permiso.Usuario = usuarioId
                    permiso.Empresa = dr("Id")
                    permiso.Completo = dr("compt")
                    permiso.Modulo = dr("mod")
                    Dim daoPermiso As New PermisoDao
                    daoPermiso.Registrar(permiso)
                Next

            Else
                respuesta = False
            End If
        End If
        Return respuesta
    End Function
#Region "Usuario"
    Public Function Usuario_ActualizarLB(ByVal entusu As Usuario)
        Dim verificar As Integer
        verificar = Datos.Usuarios_Actualizar(entusu)
        Return verificar
    End Function
    Public Function UsuariosAll() As DataTable
        Dim daoUsuario As New UsuarioDao
        Dim dtusuario As DataTable = daoUsuario.UsuariosAll
        dtusuario.Columns.Add("usu_state_string", Type.GetType("System.String"))
        For Each row As DataRow In dtusuario.Rows
            If row("usu_state") Then
                row("usu_state_string") = "Activo"
            Else
                row("usu_state_string") = "Inactivo"
            End If
        Next

        Return dtusuario
    End Function
#End Region


    Private Sub BuilDatosdDataTableEmpresas()
        Dim maindao As New EmpresaDao
        MakeDataTableEmpresa(dtEmpresaActivaStatic)
        MakeDataTableEmpresa(dtEmpresaInactivas)

        For Each empresa As Empresa In Empresas
            Dim newEmpresa As Empresa = maindao.GetById(empresa.RUC)

            If newEmpresa IsNot Nothing Then
                AddNewDataRowEmpresa(dtEmpresaActivaStatic, empresa)
            Else
                AddNewDataRowEmpresa(dtEmpresaInactivas, empresa)
            End If
        Next
        MostrarRazonSocialDataTable(dtEmpresaActivaStatic)
        MostrarRazonSocialDataTable(dtEmpresaInactivas)

        dtEmpresaUsuario = dtEmpresaActivaStatic.Copy()
        dtEmpresaUsuario.TableName = "empresa_usuario"
    End Sub
    Private Sub AddNewDataRowEmpresa(ByRef dt As DataTable, empresa As Empresa)
        Dim dr As DataRow = dt.NewRow
        dr("id") = empresa.RUC
        dr("name") = empresa.Nombre
        dr("rz_com") = empresa.Aliass
        dt.Rows.Add(dr)
    End Sub
    Private Sub MostrarRazonSocialDataTable(ByRef dt As DataTable)
        For Each dr As DataRow In dt.Rows
            If (dr("rz_com").ToString.Length = 0) Or (IsNothing(dr("rz_com"))) Then

                Dim DiferencialengthEmpresaName As Integer = 30 - dr("name").ToString.Length

                If DiferencialengthEmpresaName <= 0 Then
                    dr("rz_elegido") = "Emp. " & dr("name").ToString.Substring(0, 29)
                Else
                    dr("rz_elegido") = "Emp. " & dr("name").ToString
                End If
            Else
                dr("rz_elegido") = "Emp. " & dr("rz_com")
            End If
        Next
    End Sub
    Private Sub MakeDataTableEmpresa(ByRef dt As DataTable)
        dt.Columns.Add("id", Type.GetType("System.String"))
        dt.Columns.Add("name", Type.GetType("System.String"))
        dt.Columns.Add("rz_com", Type.GetType("System.String"))
        dt.Columns.Add("rz_elegido", Type.GetType("System.String"))
    End Sub
#Region "Modulo"

    Private Function CreaDataTableEmpresaPermisoSelect() As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("Id", Type.GetType("System.String"))
        dt.Columns.Add("Name", Type.GetType("System.String"))
        dt.Columns.Add("State", Type.GetType("System.Boolean"))
        dt.Columns.Add("NameState", Type.GetType("System.String"))
        dt.Columns.Add("usu", Type.GetType("System.Int32"))
        dt.Columns.Add("compt", Type.GetType("System.Boolean"))
        dt.Columns.Add("mod", Type.GetType("System.String"))
        dt.PrimaryKey = New DataColumn() {dt.Columns("Id")}
        Return dt
    End Function
    Public Sub UpdateDataTableDtEmpresaAndDtModulo(UsuarioID As Integer)
        Dim permisoDao As New PermisoDao
        listPermiso = permisoDao.BuscarByUsuarioId(UsuarioID)

        dtEmpresaUsuario.Rows.Clear()

        For Each permiso As Permiso In listPermiso
            Dim dr As DataRow = dtEmpresaUsuario.NewRow
            Dim drSearch As DataRow = SearchEmpresa(permiso.Empresa)
            dr("id") = drSearch("id")
            dr("name") = drSearch("name")
            dr("rz_com") = drSearch("rz_com")
            dr("rz_elegido") = drSearch("rz_elegido")
            dtEmpresaUsuario.Rows.Add(dr)
        Next
        Dim permisoFirst As Permiso = listPermiso.First
        RecorrerListUpdateDtModulo(permisoFirst)
    End Sub
    Private Sub RecorrerListUpdateDtModulo(permiso As Permiso)
        Dim list As List(Of String) = CadenaToArray(permiso.Modulo)
        dtModuloUsuario.Rows.Clear()
        For Each l As String In list
            Dim drModuloSearch As DataRow = SearchModulo(l)
            dtModuloUsuario.Rows.Add(drModuloSearch)
        Next
    End Sub
    Private Function SearchEmpresa(ruc As String) As DataRow
        Dim q = From t In dtEmpresaActivaStatic.AsEnumerable
                Where t.Field(Of String)("id") = ruc
                Select t
        Dim dr As DataRow = dtEmpresaUsuario.NewRow
        For Each empresa In q
            dr("id") = empresa.Field(Of String)("id")
            dr("name") = empresa.Field(Of String)("name")
            dr("rz_com") = empresa.Field(Of String)("rz_com")
            dr("rz_elegido") = empresa.Field(Of String)("rz_elegido")
        Next
        Return dr
    End Function
    Private Function SearchModulo(ModuloId As UInteger) As DataRow
        Dim q = From t In dtModulo.AsEnumerable()
                Where t.Field(Of UInteger)("id") = ModuloId
                Select t

        Dim dr As DataRow = dtModuloUsuario.NewRow
        For Each moduloNew In q
            dr("id") = moduloNew.Field(Of UInteger)("id")
            dr("name") = moduloNew.Field(Of String)("name")
        Next
        Return dr
    End Function

    Private Function CadenaToArray(value As String) As List(Of String)
        Dim continua As Boolean = True
        Dim buscaDesde As Integer = 0
        Dim list As List(Of String) = New List(Of String)

        While continua
            Dim indiceInicial As Integer = value.IndexOf("[", buscaDesde)
            Dim indiceFinal As Integer
            Dim val As String

            If indiceInicial < 0 Then
                continua = False

            Else
                indiceFinal = value.IndexOf("]", indiceInicial)
                val = value.Substring(indiceInicial + 1, indiceFinal - (indiceInicial + 1))
                list.Add(val)
                buscaDesde = indiceFinal
            End If
        End While
        Return list
    End Function

    Public Function ActualizarUsuario(usu As Usuario, text As String) As Boolean
        EliminarUsuario(usu.Id)
        Return Registrar(usu, text)
    End Function

    Public Sub UpdateDtModulo(Ruc As String)
        If listPermiso.Count = 0 Then Exit Sub
        Try
            Dim permiso As Permiso = listPermiso.Where(Function(x) x.Empresa = Ruc).Single()
            If permiso IsNot Nothing Then RecorrerListUpdateDtModulo(permiso)
        Catch ex As InvalidOperationException

        End Try

    End Sub

    Public Sub UpdateDataDtEmpresa()
        dtEmpesasActivas.Rows.Clear()
        For Each row As DataRow In dtEmpresaActivaStatic.Rows
            dtEmpesasActivas.ImportRow(row)
        Next
    End Sub
    Public Function DisponibleUsuarioName(Name As String) As Boolean
        If Name = "admin" Then
            Return False
        Else
            Dim usuarioDao As New UsuarioDao
            Dim usuarioName As EnumerableRowCollection = usuarioDao.UsuariosAll.AsEnumerable.Where(Function(x) x.Field(Of String)("usu_name") = Name)
            Dim c As Integer = 0
            For Each r In usuarioName
                c += 1
            Next
            Return If(c > 0, False, True)
        End If
    End Function

    Public Function EliminarUsuario(UsuarioID As Integer) As Boolean
        Dim usuarioDao As New UsuarioDao
        Dim respuesta As Boolean = usuarioDao.Eliminar(UsuarioID)
        If respuesta Then
            Return respuesta
        Else
            Return respuesta
        End If
    End Function

    Public Sub UpdateDataTableEmpresaAndModuloUsuario()

        dtEmpresaUsuario.Rows.Clear()
        For Each row As DataRow In dtEmpresaActivaStatic.Rows
            dtEmpresaUsuario.ImportRow(row)
        Next
        listPermiso = Nothing
        dtModuloUsuario.Rows.Clear()
        For Each row As DataRow In dtModulo.Rows
            dtModuloUsuario.ImportRow(row)
        Next

    End Sub

    Public Sub UpdateDataTableEmpresaPermisoSelect(UsuarioId As Integer)
        Dim permisoDao As New PermisoDao
        Dim listPermiso As List(Of Permiso) = permisoDao.BuscarByUsuarioId(UsuarioId)
        dtEmpresaSelect.Rows.Clear()
        listPermiso.ForEach(AddressOf AgregarDataRow)
    End Sub
    Private Sub AgregarDataRow(permiso As Permiso)
        Dim dr As DataRow = dtEmpresaSelect.NewRow()
        dr.Item("Id") = permiso.Id
        Dim drSearchEmpresa As DataRow = dtEmpresaActivaStatic.AsEnumerable.Single(Function(x) x.Field(Of String)("id") = permiso.Empresa)
        dr("Name") = drSearchEmpresa("rz_elegido")
        dr("State") = True
        dr("NameState") = dr("Name") & " Ok"
        dr("usu") = permiso.Usuario
        dr("compt") = permiso.Completo
        dr("mod") = permiso.Modulo
        Dim drSearEmpresaRemove As DataRow = dtEmpesasActivas.AsEnumerable.Single(Function(x) x.Field(Of String)("id") = permiso.Empresa)
        If drSearchEmpresa IsNot Nothing Then dtEmpesasActivas.Rows.Remove(drSearEmpresaRemove)
        dtEmpresaSelect.Rows.Add(dr)
    End Sub
#End Region
#End Region




End Class