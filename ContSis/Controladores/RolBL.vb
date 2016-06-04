Imports Modelos
Imports Capa_Entidad
Imports System.Windows.Forms
Public Class RolBL
    'Variables
    Private formularioDao As New FormularioDAO
    Private contenedorDao As New ContenedorDAO
    Private empresaDao As New EmpresaDao
    Private cabPrivilegioDao As New Cab_PrivilegioDao
    Private detPrivilegioDao As New Det_PrivilegioDao
    Private rolDao As New RolDao
    'Contructor
    'Propiedades 
    'Metodos
    Public Function tablaRoles() As DataTable
        Dim tablas As DataTable
        Dim roles As New RolDao
        Dim renglon As DataRow
        tablas = roles.Rol_all().Copy()
        If tablas.Rows.Count = 0 Then
            renglon = tablas.NewRow
            renglon("Codigo") = "1"
            renglon("Descripcion") = "Disponible"
            tablas.Rows.Add(renglon)
        Else
            Dim codNew As Integer = tablas.Rows(tablas.Rows.Count - 1)(0)
            renglon = tablas.NewRow
            renglon("Codigo") = codNew + 1
            renglon("Descripcion") = "Disponible"
            tablas.Rows.Add(renglon)
        End If

        tablaRoles = tablas
    End Function
    Public Function BaseForm_Roles() As DataSet
        'Variables 
        Dim baseSet As New DataSet()
        Dim contTable As New DataTable()
        Dim formTable As New DataTable()
        Dim empTable As New DataTable()
        Dim cabPrivTable As New DataTable()
        Dim detPrivTable As New DataTable()
        'Logica
        contTable = contenedorDao.Contenedor_all().Copy() : contTable.TableName = "tableCont"
        formTable = formularioDao.Formularios_All().Copy() : formTable.TableName = "tableForm"
        empTable = empresaDao.Empresa_all.Copy() : empTable.TableName = "tableEmp"
        cabPrivTable = cabPrivilegioDao.crearTabla.Copy() : cabPrivTable.TableName = "tableCabPrivilegio"
        detPrivTable = detPrivilegioDao.crearTabla().Copy() : detPrivTable.TableName = "tableDetPrivilegio"

        baseSet.Tables.Add(contTable)
        baseSet.Tables.Add(formTable)
        baseSet.Tables.Add(empTable)
        baseSet.Tables.Add(cabPrivTable)
        baseSet.Tables.Add(detPrivTable)

        baseSet.Relations.Add("ContID", baseSet.Tables("tableCont").Columns("cont_id"), _
                              baseSet.Tables("tableForm").Columns("cont_id"))
        BaseForm_Roles = baseSet
    End Function
    Public Function validacion_Codigo(ByVal codigo As String, ByRef men As String) As Boolean
        If codigo.Length <= 0 Then
            men = "Ingrese un codigo"
            Return False
        ElseIf IsNumeric(codigo) = False Then
            men = "Este codigo contiene texto : " & codigo
            Return False
        Else
            Return True
        End If
    End Function
    Public Function validacion_Nombre(ByVal nombre As String, ByRef men As String) As Boolean
        'Variables
        Dim resp As Boolean
        'Logica
        nombre = nombre.Trim()
        If nombre.Length <= 0 Then
            men = "Ingrese un nombre"
            resp = False
        ElseIf nombre.Length < 5 Then
            men = "Este nombre necesita 5 caracteres minimo : " & nombre
            resp = False
        Else
            'Variables
            Dim countNumeric, countSimbolo, countPuntuacion, countWhriteSpace As Integer
            'Logica
            countNumeric = 0
            countSimbolo = 0
            countPuntuacion = 0
            countWhriteSpace = 0
            For i As Integer = 1 To nombre.Length
                If IsNumeric(Mid(nombre, i, 1)) Then
                    countNumeric = countNumeric + 1
                ElseIf Char.IsSymbol(Mid(nombre, i, 1)) Then
                    countSimbolo = countSimbolo + 1
                ElseIf Char.IsPunctuation(Mid(nombre, i, 1)) Then
                    countPuntuacion = countPuntuacion + 1
                ElseIf Char.IsWhiteSpace(Mid(nombre, i, 1)) Then
                    countWhriteSpace = countWhriteSpace + 1
                End If
            Next
            If countPuntuacion + countSimbolo + countNumeric + countWhriteSpace > 0 Then
                men = "Esta nombre contiene caracteres erroneos : " & nombre
                resp = False
            Else
                resp = True
            End If
        End If
        Return resp
    End Function
    Public Function validacion_Data_Empresa(ByVal dataEmpresa As DataTable, ByRef men As String) As Boolean

        If dataEmpresa.Rows.Count <= 0 Then
            men = "Selecione las empresas que manejara el usuario"
            Return False
        Else
            Return True
        End If

    End Function
    Public Function validacion_Data_Formulario(ByVal dataEmpresa As DataTable, ByVal dataPrivilegio As DataTable, _
                                               ByRef men As String) As Boolean
        'Variables 
        Dim baseSet As New DataSet()
        Dim cabPrivTable As New DataTable() : Dim detPrivTable As New DataTable()
        Dim resp As Boolean
        'Declarando 
        cabPrivTable = dataEmpresa.Copy() : cabPrivTable.TableName = "tableCabPrivilegio"
        detPrivTable = dataPrivilegio.Copy() : detPrivTable.TableName = "tableDetPrivilegio"
        baseSet.Tables.Add(cabPrivTable) : baseSet.Tables.Add(detPrivTable)
        baseSet.Relations.Add("PrivilegioID", baseSet.Tables("tableCabPrivilegio").Columns("Privilegio"), _
                      baseSet.Tables("tableDetPrivilegio").Columns("Privilegio"))
        'Logica
        If detPrivTable.Rows.Count <= 0 Then : men = vbTab & " --Selecione--" & vbLf &
                                                        " Minimo (1) privilegio por Empresa"
            resp = False
        Else
            men = "--Las Empresas selecionadas deben tener minimo (1) privilegio -- " & vbLf
            For Each row As DataRow In cabPrivTable.Rows
                Dim count As Integer = 0
                For Each childrow As DataRow In row.GetChildRows("PrivilegioID")
                    count = count + 1
                Next
                If count = 0 Then
                    men = men & vbTab & "La " & row("Empresa").ToString & " tiene: " & count & " privilegios asignados" & vbLf
                    resp = False
                Else
                    men = ""
                    resp = True
                End If
            Next
        End If
        Return resp
    End Function
    Public Function validacion_Registrar_Update_Rol(ByVal rol As Rol, _
                                                     ByRef men As String) As Boolean
        'Variables 
        Dim rowsAffected As Integer
        Dim resp As Boolean
        'Logica 
        rowsAffected = rolDao.Update(rol, men)
        If rowsAffected = 1 Then
            resp = True
        Else
            If InStr(men, "un_descrip_rol") <> 0 Then
                men = "Ya existe (1) rol con el mismo nombre"
                resp = False
            Else
                rowsAffected = rolDao.Registrar(rol, men)
                If rowsAffected = 1 Then
                    resp = True
                Else
                    If InStr(men, "un_descrip_rol") <> 0 Then
                        men = "Ya existe (1) rol con el mismo nombre -->"
                        resp = False
                    Else
                        men = men
                        resp = False
                    End If
                End If
            End If
        End If
        Return resp
    End Function
    Public Sub validacion_Registrar_Delete_Privilegio(ByVal PrivilegioTable As DataTable, _
                                                        ByVal detPrivilegioTable As DataTable, _
                                                        ByRef men As String)
        'Variables 
        Dim rowsAffected As Integer
        Dim baseSet As New DataSet()
        Dim cabPrivTable As New DataTable() : Dim detPrivTable As New DataTable()
        'Declarando 
        cabPrivTable = PrivilegioTable.Copy() : cabPrivTable.TableName = "tableCabPrivilegio"
        detPrivTable = detPrivilegioTable.Copy() : detPrivTable.TableName = "tableDetPrivilegio"
        baseSet.Tables.Add(cabPrivTable) : baseSet.Tables.Add(detPrivTable)
        baseSet.Relations.Add("PrivilegioID", baseSet.Tables("tableCabPrivilegio").Columns("Privilegio"), _
                      baseSet.Tables("tableDetPrivilegio").Columns("Privilegio"))
        'Logica 
        For Each row As DataRow In cabPrivTable.Rows
            'Variables 
            Dim cabprivilegio As New CabPrivilegio()
            'Logica
                With cabprivilegio
                .Id = row("Privilegio").ToString
                .Rol = Integer.Parse(row("Rol").ToString())
                .Empresa = row("Empresa_Id").ToString
                End With

            rowsAffected = detPrivilegioDao.Delete_por_Privilegio(cabprivilegio.Id, men)
            men = men.Trim() & vbLf
            rowsAffected = cabPrivilegioDao.Delete_por_Rol(cabprivilegio.Rol, men)
            men = men.Trim() & vbLf
            rowsAffected = cabPrivilegioDao.Registrar(cabprivilegio, men)
            men = men.Trim() & vbLf
            For Each childrow As DataRow In row.GetChildRows("PrivilegioID")
                'Variables 
                Dim detprivilegio As New DetPrivilegio()
                With detprivilegio
                    .Privilegio = childrow("Privilegio").ToString
                    .Contenedor = childrow("Contenedor").ToString
                    .Cantidad = Integer.Parse(childrow("Cantidad").ToString)
                    .Formulario = childrow("Formularios").ToString
                End With
                rowsAffected = detPrivilegioDao.Registrar(detprivilegio, men)
                men = men.Trim() & vbLf
            Next
        Next
    End Sub
    Public Function validacion_cabPrivilegio_Encontrador(ByVal rol As Integer, ByRef dataTable As DataTable) As Boolean
        'Variables
        Dim rowAffected As Integer
        Dim men As String = ""
        'Logica 
        rowAffected = rolDao.Buscar(rol, men)
        If rowAffected <= 0 Then
            dataTable = Nothing
            Return False
        Else
            dataTable = cabPrivilegioDao.Buscar_por_Rol_All(rol)
            Return True
        End If
    End Function
    Public Function LLenar_detPrivilegio(ByVal privilegio As String) As DataTable
        Return detPrivilegioDao.Buscar_por_Privilegio_All(privilegio)
    End Function
End Class
