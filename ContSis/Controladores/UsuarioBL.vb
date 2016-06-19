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
        For Each dr As DataRow In dt.Rows
            dr("name") = "Emp. " & dr("name")
        Next
        Return dt
    End Function

    'Public Function getRoles() As DataTable
    '    Dim dao As New RolDao
    '    Dim dt As DataTable = dao.GetRolAll(0)
    '    Dim dr As DataRow = dt.NewRow
    '    dr("id") = 0
    '    dr("name") = "Seleccione"
    '    dt.Rows.InsertAt(dr, 0)
    '    Return dt
    'End Function

#Region "Modulo"
    Public Function Modulo() As DataSet
        'Variables 
        Dim daoMod As New ContenedorDAO
        Dim daoModDet As New FormularioDAO
        Dim daoPer As New PermisoDao
        '--------------------------
        Dim ds As New DataSet
        '--------------------------------
        Dim dtMod As DataTable
        Dim dtModDet As DataTable
        Dim dtPermi As DataTable


        Dim dtEmpresa As New DataTable("empresa_select")
        dtEmpresa.Columns.Add("Id")
        dtEmpresa.Columns.Add("Name")
        dtEmpresa.Columns.Add("State")
        dtEmpresa.Columns.Add("NameState")

        'Logica
        dtMod = daoMod.GetContenedorAll(1) : dtMod.TableName = "modulo"
        _nroModulo = dtMod.Rows.Count
        dtModDet = daoModDet.getModuloDetAll() : dtModDet.TableName = "modulo_det"
        dtMod.PrimaryKey = New DataColumn() {dtMod.Columns("id")}
        dtModDet.PrimaryKey = New DataColumn() {dtModDet.Columns("id")}
        dtPermi = daoPer.CrearSchema

        ds.Tables.Add(dtMod)
        ds.Tables.Add(dtModDet)
        ds.Tables.Add(dtEmpresa)
        ds.Tables.Add(getEmpresas)
        ds.Tables.Add(dtPermi)

        ds.Relations.Add("mod", ds.Tables("modulo").Columns("id"),
                              ds.Tables("modulo_Det").Columns("modcab"))
        Return ds
    End Function
#End Region

End Class