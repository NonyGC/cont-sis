Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Imports System.Text
Public Class CuentaDAO
    'Inherits BaseDao
    Inherits DBEmpDao

    Private conexionValue As MySqlConnection
    '    Public Function Auxiliar_Autocompletado() As DataTable
    '        Return Consultas_SQL("sp_ruc_auxiliares")
    '    End Function
    '    Public Function Cuenta_Showall(ByVal tabla As String, ByVal largo As String) As DataTable
    '        Return Consultas_SQL("sp_Cuenta_Showall", tabla, largo)
    '    End Function
    '    Public Function Cuenta_Showall_destino(ByVal tabla As String, ByVal dest1 As String) As DataTable
    '        Return Consultas_SQL("sp_Cuenta_Showall_destino", tabla, dest1 + "%")
    '    End Function

    '    Public Function Cuenta_data(ByVal tabla As String, ByVal entcont As Cuenta) As DataTable
    '        Return Consultas_SQL("sp_cuenta_data", tabla, entcont.codigo)
    '    End Function
    '    Public Function Cuenta_Showall_Export(ByVal tabla As String) As DataTable
    '        Return Consultas_SQL("sp_Cuenta_Showall_Export", tabla)
    '    End Function
    '    Public Function Cuenta_Register(ByVal tabla As String, ByVal entcont As Cuenta)
    '        Return Mantenimiento_SQL("sp_Cuenta_Register", tabla, entcont.codigo, entcont.nombre, entcont.aliass)
    '    End Function
    '#Region "Amarres_Contables"
    '    Public Function Cuenta_Amarre_Show(ByVal tabla As String, ByVal entcont As Cuenta) As DataTable
    '        Return Consultas_SQL("sp_C_Amarre_Show", tabla, entcont.codigo)
    '    End Function
    '    Public Function Cuenta_Amarre_Register(ByVal tabla As String, ByVal cond As Integer, ByVal entcont As Cuenta) As Integer
    '        Return Mantenimiento_SQL("sp_C_Amarre_Register", tabla, entcont.codigo, entcont.c_debe, entcont.c_haber, cond)
    '    End Function
    '#End Region
    '    Public Function Cuenta_Actualizar(ByVal tabla As String, ByVal entcont As Cuenta) As Integer
    '        Return Mantenimiento_SQL("sp_Cuenta_Actualizar", tabla, entcont.nombre, entcont.aliass, entcont.codigo)
    '    End Function
    '    Public Function Cuenta_Borrar(ByVal tabla As String, ByVal entcont As Cuenta) As Integer
    '        Return Mantenimiento_SQL("sp_Cuenta_Borrar", tabla, entcont.codigo)
    '    End Function
    '    Public Function importXtomysql(ByVal tabla As String, ByVal cmd As String)
    '        conexionValue = Me.conexion
    '        Try
    '            Using insertPCCmmd As MySqlCommand = New MySqlCommand(cmd.ToString, conexionValue)
    '                insertPCCmmd.CommandType = CommandType.Text
    '                insertPCCmmd.ExecuteNonQuery()
    '            End Using
    '        Catch ex As Exception
    '            'MysqlTrans.Rollback()
    '        Finally
    '            conexionValue.Close()
    '        End Try
    '        Return Nothing
    '    End Function
    'Public Function Cuenta_Managment(ByVal cond As Integer, ByVal entcont As Cuenta) As Integer
    '    Return Mantenimiento_SQL("sp_Cuenta_Managment", entcont.codigo, cond)
    'End Function
    Public Function Cuenta_Managment(ByVal condicion As Integer, ByVal entCuenta As Cuenta)
        conexionValue = Me.conexion
        Dim rowsaffected As Integer
        Dim Hacer As Integer = condicion
        Dim sql As String = ""
        Dim register As String = "INSERT INTO plan_contable VALUES(@cod, @des, @ali);INSERT INTO pc_movimiento(codigo) VALUES(@cod);"
        Dim register_ As String = "INSERT INTO plan_contable VALUES(@cod,@des,@ali);INSERT INTO pc_movimiento_2(codigo,cuenta_padre) VALUES(@cod,@padre);"
        Dim updater As String = "UPDATE plan_contable SET nombre = @des, alias = @ali WHERE codigo = @cod;"
        Dim deleter As String = "DELETE FROM plan_contable WHERE codigo=@cod;"
        Select Case Hacer
            Case 0 'Insert en la tabla pc_movimientos
                sql = register
            Case 1 'Insert en la tabla pc_movimientos_2(6 digitos a más)
                sql = register_
            Case 2
                sql = updater
            Case 3
                sql = deleter
            Case Else
                MsgBox("Operación inválida")
        End Select
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@cod", entCuenta.codigo)
            .Parameters.AddWithValue("@des", entCuenta.nombre)
            .Parameters.AddWithValue("@ali", entCuenta.aliass)
            .Parameters.AddWithValue("@padre", entCuenta.Pcodigo)
        End With
        Try
            rowsaffected = consultaSQL.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conexionValue.Close()
        End Try
        Return rowsaffected
    End Function
    Public Function Cuenta_Mostrar(ByVal largo As String) As DataTable
        Dim dt As New DataTable
        dt = Consultar_Tabla_MySQL("SELECT codigo FROM plan_contable WHERE CHAR_LENGTH(codigo)=" & largo & ";")
        Return dt
    End Function
    Public Function Amarres_Mostrar(ByVal como As String) As DataTable
        Dim dt As New DataTable
        dt = Consultar_Tabla_MySQL("SELECT codigo FROM plan_contable WHERE codigo LIKE '" & como & "%' and CHAR_LENGTH(codigo)>5;")
        Return dt
    End Function

    Public Function Cuenta_data(ByVal condicion As Integer, ByVal entcont As Cuenta) As DataTable
        Dim dt As New DataTable
        Select Case condicion
            Case 0
                dt = Consultar_Tabla_MySQL("select pc.nombre,pc.alias,pcm.* from plan_contable as pc,pc_movimiento as pcm where pc.codigo=pcm.codigo and pc.codigo=" & entcont.codigo & ";")
            Case 1
                dt = Consultar_Tabla_MySQL("select pc.nombre,pc.alias,pcm.* from plan_contable as pc,pc_movimiento_2 as pcm where pc.codigo=pcm.codigo and pc.codigo=" & entcont.codigo & ";")
        End Select
        Return dt
    End Function
    Public Function Cuenta_Showall_Export() As DataTable
        Return Consultas_SQL("sp_Cuenta_Showall_Export")
    End Function
#Region "Amarres_Contables"
    Public Function Cuenta_Amarre_Show(ByVal entcont As Cuenta) As DataTable
        Dim dt As New DataTable
        dt = Consultar_Tabla_MySQL("SELECT cuenta,c_debe,c_haber FROM amarre WHERE cuenta=" & entcont.codigo & ";")
        Return dt
    End Function
    Public Function Cuenta_Amarre_Managemenet(ByVal condicion As Integer, ByVal entcuenta As Cuenta) As Integer
        conexionValue = Me.conexion
        Dim rowsaffected As Integer
        Dim Hacer As Integer = condicion
        Dim sql As String = ""
        Dim register As String = "INSERT INTO amarre VALUES(@cod,@debe,@haber);"
        Dim updater As String = "UPDATE amarre SET c_debe=@debe,c_haber=@haber WHERE cuenta=@cod;"
        Select Case Hacer
            Case 0 'Insert en la tabla pc_movimientos
                sql = register
            Case 1 'Actualizar amarres de una cuenta
                sql = updater
            Case Else
                MsgBox("Operación inválida")
        End Select
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@cod", entcuenta.codigo)
            .Parameters.AddWithValue("@debe", entcuenta.c_debe)
            .Parameters.AddWithValue("@haber", entcuenta.c_haber)
        End With
        Try
            rowsaffected = consultaSQL.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conexionValue.Close()
        End Try
        Return rowsaffected
    End Function
#End Region
    Public Function importXtomysql(ByVal cmd As String)
        conexionValue = Me.conexion
        Try
            Using insertPCCmmd As MySqlCommand = New MySqlCommand(cmd.ToString, conexionValue)
                insertPCCmmd.CommandType = CommandType.Text
                insertPCCmmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            'MysqlTrans.Rollback()
        Finally
            conexionValue.Close()
        End Try
        Return Nothing
    End Function
End Class
