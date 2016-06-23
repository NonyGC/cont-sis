Imports Modelos
Imports Capa_Entidad
Public Class UsuarioBL
    Dim Datos As New UsuarioDao
    'Dim rolDao As New RolDao
    Dim _log As String
    Private _newUsuario As Integer
    Private _newPermiso As Integer
    Private _nroModulo As Integer
#Region "Constructor"
    Public Sub New()
        _newUsuario = Datos.NewUsuario

        Dim dao As New PermisoDao
        _newPermiso = dao.NewId

    End Sub
#End Region
#Region "Propiedades"
    Public ReadOnly Property NewUsuario As Integer
        Get
            Return _newUsuario
        End Get
    End Property
    Public ReadOnly Property NewPermiso As Integer
        Get
            Return _newPermiso
        End Get
    End Property
    Public ReadOnly Property Log As String
        Get
            Dim msg As String = _log
            _log = ""
            Return msg
        End Get
    End Property
    Public ReadOnly Property NroModulo As Integer
        Get
            Return _nroModulo
        End Get
    End Property

#End Region
    Public Function Registrar(ByVal usuario As Usuario, rPassword As String) As Boolean

        If usuario.Password <> rPassword Then
            _log += "La contraseña no coinciden " & usuario.Password & " con " & rPassword & vbLf

        End If
        Return False

    End Function
    Public Function Usuario_ActualizarLB(ByVal entusu As Usuario)
        Dim verificar As Integer
        verificar = Datos.Usuarios_Actualizar(entusu)
        Return verificar
    End Function
    'Public Function Roles_datos() As DataTable
    '    'Return rolDao.Rol_all()
    'End Function
    Public Function getModulos() As DataTable
        Dim maindao As New ContenedorDAO
        Dim dt As DataTable = maindao.GetContenedorAll(1)

        For Each dr As DataRow In dt.Rows
            dr("name") = "Mod. " & dr("name")
        Next
        Return dt
    End Function
    Private Function getEmpresas() As DataTable
        Dim maindao As New EmpresaDao
        Dim dt As DataTable = maindao.Empresas
        dt.TableName = "empresa"
        dt.Columns.Add("rz_elegido")
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
        Return dt
    End Function

#Region "Modulo"
    Public Function Modulo() As DataSet
        'Variables 
        Dim daoMod As New ContenedorDAO
        Dim daoModDet As New FormularioDAO
        Dim daoPer As New PermisoDao
        '--------------------------
        Dim ds As New DataSet
        '--------------------------------
        Dim dtMod As DataTable = daoMod.GetContenedorAll(1)
        Dim dtModDet As DataTable = daoModDet.getModuloDetAll()
        Dim dtPermi As DataTable = daoPer.CreaSchemaDataTable
        Dim dtEmpresa As DataTable = CreaDataTableEmpresaSelect()

        dtMod.TableName = "modulo"
        dtMod.PrimaryKey = New DataColumn() {dtMod.Columns("id")}
        dtModDet.TableName = "modulo_det"
        dtModDet.PrimaryKey = New DataColumn() {dtModDet.Columns("id")}
        _nroModulo = dtMod.Rows.Count

        ds.Tables.Add(dtMod)
        ds.Tables.Add(dtModDet)
        ds.Tables.Add(dtEmpresa)
        ds.Tables.Add(getEmpresas)
        ds.Tables.Add(dtPermi)

        ds.Relations.Add("mod", ds.Tables("modulo").Columns("id"),
                              ds.Tables("modulo_Det").Columns("modcab"))
        Return ds
    End Function
    Private Function CreaDataTableEmpresaSelect() As DataTable
        Dim dt As New DataTable("empresa_select")
        dt.Columns.Add("Id")
        dt.Columns.Add("Name")
        dt.Columns.Add("Alias")
        dt.Columns.Add("rz_elegido")
        dt.Columns.Add("State")
        dt.Columns.Add("NameState")
        Return dt
    End Function
#End Region

End Class