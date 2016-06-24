Imports MySql.Data.MySqlClient

Public Class BaseDao
    'Variables
    Private server As String = "localhost"
    Private user As String = "user"
    Private password As String = "S0p0rt3user"
    Private port As String = "3307"
    Private database As String = "bdsist"
    Private conexionValue As MySqlConnection
    'Contructor
    'Propiedades 
    'Metodos
    Protected Function conexion() As MySqlConnection

        conexionValue = New MySqlConnection()
        If conexionValue.State = ConnectionState.Open Then
            conexionValue.Close()
        End If
        conexionValue.ConnectionString =
            "server=" & Me.server & ";" &
            "user id=" & Me.user & ";" &
            "password=" & Me.password & ";" &
            "port=" & Me.port & ";" &
            "database=" & Me.database & ";Convert Zero Datetime=True"

        conexionValue.Open()
        conexion = conexionValue
    End Function
    Public Function CheckConexion() As Boolean

        conexion()

        If conexionValue.State = ConnectionState.Open Then
            Return True
        Else
            Return False
        End If

    End Function
    Protected Sub CrearColumna(ByVal nombre As String, ByVal tabla As DataTable)
        Dim column As New DataColumn
        column.ColumnName = nombre
        tabla.Columns.Add(column)
    End Sub
    Protected Sub CrearColumna(ByVal nombre As String, ByVal tabla As DataTable, ByVal unique As String)
        Dim column As New DataColumn
        Dim key(1) As DataColumn
        column.ColumnName = nombre
        column.Unique = True
        tabla.Columns.Add(column)
        key(0) = column
        tabla.PrimaryKey = key
    End Sub
    Public Function GetDataTable(cmd As MySqlCommand) As DataTable
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(dt)
        CloseDB()
        Return dt
    End Function
    Public Sub CloseDB()
        If conexionValue.State = ConnectionState.Open Then
            conexionValue.Close()
        End If
    End Sub
    Public Function Parameters(cmd As MySqlCommand, env() As String) As MySqlCommand
        Dim procedure As String = cmd.CommandText
        Try
            MySqlCommandBuilder.DeriveParameters(cmd)
            Dim c As Integer = 0

            For Each prm As MySqlParameter In cmd.Parameters
                If prm.ParameterName <> "@RETURN_VALUE" Then
                    prm.Value = env(c)
                    c += 1
                End If
            Next
            Return cmd
        Catch ex As Exception
            Return Nothing
            Debug.WriteLine(procedure & "- " & ex.ToString)
        End Try

    End Function
    Public Function CommandProcedure(name As String) As MySqlCommand
        Dim cmd As New MySqlCommand(name, Me.conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Return cmd
    End Function


    Function Consultas_SQL(ByVal SQL As String, ByVal ParamArray argu() As Object) As DataTable
        conexionValue = Me.conexion
        Dim cmd As New MySqlCommand(SQL, conexionValue)
        Dim prm As New MySqlParameter 'representa cualquier parametro
        cmd.CommandType = CommandType.StoredProcedure
        'prepara  al comando  para  que  reciba  parametros
        MySqlCommandBuilder.DeriveParameters(cmd) 'prepara  comandos para que  reciba n parametros
        Dim c As Integer = 0 'contador de parametros
        'asigna   cada   valor  del procedimiento a  su respectivo parameter
        For Each prm In cmd.Parameters 'para cada  parameter que  esta contenido en los parametros
            If prm.ParameterName <> "@RETURN_VALUE" Then 'si prm.ParameterName  es diferente al parame.por  defecto  "@return_value"
                prm.Value = argu(c)
                c = c + 1
            End If
        Next
        Dim da As New MySqlDataAdapter(cmd) 'creo un dataadapter
        Dim dt As New DataTable
        da.Fill(dt) 'guarda en el   datatable lo q   sta   e  el dataadapter
        Return dt 'retorna la tabla  correspondiente
        conexionValue.Close()
    End Function
    Function Mantenimiento_SQL(ByVal SQL As String, ByVal ParamArray argu() As Object) As Integer
        conexionValue = Me.conexion
        Dim cmd As New MySqlCommand(SQL, conexionValue)
        Dim prm As New MySqlParameter 'representa cualkier parametro
        cmd.CommandType = CommandType.StoredProcedure
        MySqlCommandBuilder.DeriveParameters(cmd)
        Dim c As Integer = 0 'contador de parametros
        For Each prm In cmd.Parameters
            If prm.ParameterName <> "@RETURN_VALUE" Then
                prm.Value = argu(c)
                c = c + 1
            End If
        Next
        Dim res As Integer
        Try
            res = cmd.ExecuteNonQuery 'ejecuta  el procedure
        Catch ex As Exception

        Finally
            conexionValue.Close()
        End Try
        Return res  'retorna la tabla  correspondiente

    End Function
    Public Function Consultar_Tabla_MySQL(ByVal Consulta As String) As DataTable
        Dim tbl = New DataTable
        Try
            conexionValue = Me.conexion
            Dim da = New MySqlDataAdapter(Consulta, conexionValue)
            da.Fill(tbl)
            conexion.Close()

        Catch exSql As MySqlException
            MsgBox(exSql.Message.ToString)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return tbl
    End Function


















End Class
