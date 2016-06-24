Imports Modelos
Imports Capa_Entidad
Public Class UsuarioBL
    Dim Datos As New UsuarioDao
    'Dim rolDao As New RolDao
    Dim _log As String
    Private _newUsuario As Integer
    Private _newPermiso As Integer
    Private _nroModulo As Integer
    Public dtDataPermiso As DataTable
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
        Dim respuesta As Boolean = False
        If usuario.Password <> rPassword Then
            _log += "La contraseña no coinciden " & usuario.Password & " con " & rPassword & vbLf

            respuesta = False
        Else
            Dim daousuario As New UsuarioDao
            Dim respuestaRegistro As Boolean = daousuario.Registrar(usuario)
            If respuestaRegistro Then
                respuesta = True
                For Each dr As DataRow In dtDataPermiso.Rows
                    Dim permiso As New Permiso
                    permiso.Usuario = dr("usu")
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
    Public Function Usuario_ActualizarLB(ByVal entusu As Usuario)
        Dim verificar As Integer
        verificar = Datos.Usuarios_Actualizar(entusu)
        Return verificar
    End Function
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
        '--------------------------
        Dim ds As New DataSet
        '--------------------------------
        Dim dtMod As DataTable = daoMod.GetContenedorAll(1)
        Dim dtModDet As DataTable = daoModDet.getModuloDetAll()
        Dim dtEmpresaPermiso As DataTable = CreaDataTableEmpresaPermisoSelect()

        dtMod.TableName = "modulo"
        dtMod.PrimaryKey = New DataColumn() {dtMod.Columns("id")}
        dtModDet.TableName = "modulo_det"
        dtModDet.PrimaryKey = New DataColumn() {dtModDet.Columns("id")}
        _nroModulo = dtMod.Rows.Count

        ds.Tables.Add(dtMod)
        ds.Tables.Add(dtModDet)
        ds.Tables.Add(dtEmpresaPermiso)
        ds.Tables.Add(getEmpresas)

        ds.Relations.Add("mod", ds.Tables("modulo").Columns("id"),
                              ds.Tables("modulo_Det").Columns("modcab"))
        Return ds
    End Function
    Private Function CreaDataTableEmpresaPermisoSelect() As DataTable
        Dim dt As New DataTable("empresa_permiso_select")
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

#End Region

End Class