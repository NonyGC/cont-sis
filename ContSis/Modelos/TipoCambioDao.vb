Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class TipoCambioDao
    Inherits BaseDao
    Private conexionValue As MySqlConnection
    Public Function TCambio_all() As DataTable
        conexionValue = Me.conexion
        Dim sql As String = "select fecha,compra,venta from cambio;"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        Try
            DataAdapter.SelectCommand = consultaSQL
            DataAdapter.Fill(dataTable)
            conexionValue.Close()
            TCambio_all = dataTable
        Catch ex As Exception
            TCambio_all = Nothing
        End Try
    End Function
    Public Function TCambio_all_cbo() As DataTable
        conexionValue = Me.conexion
        Dim sql As String = "select Compra,Venta from cambio;"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        Try
            DataAdapter.SelectCommand = consultaSQL
            DataAdapter.Fill(dataTable)
            conexionValue.Close()
            TCambio_all_cbo = dataTable
        Catch ex As Exception
            TCambio_all_cbo = Nothing
        End Try
    End Function
    Public Function TCambio_data(ByVal enttp As TipoCambio) As DataTable
        conexionValue = Me.conexion
        Dim sql As String = "select fecha,compra,venta from cambio where fecha=@fecha;"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@fecha", enttp.fecha)
        End With
        Try
            DataAdapter.SelectCommand = consultaSQL
            DataAdapter.Fill(dataTable)
            conexionValue.Close()
            TCambio_data = dataTable
        Catch ex As Exception
            TCambio_data = Nothing
        End Try
    End Function
    Public Function TCambio_data_incompleta(ByVal enttp As TipoCambio) As DataTable
        conexionValue = Me.conexion
        Dim sql As String = "select fecha,compra,venta from cambio where cast(fecha as char) like @fecha;"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@fecha", enttp.fecha + "%")
        End With
        Try
            DataAdapter.SelectCommand = consultaSQL
            DataAdapter.Fill(dataTable)
            conexionValue.Close()
            TCambio_data_incompleta = dataTable
        Catch ex As Exception
            TCambio_data_incompleta = Nothing
        End Try
    End Function
    Public Function TCambio_Register(ByVal enttp As TipoCambio)
        conexionValue = Me.conexion
        Dim rowsaffected As Integer
        Dim sql As String = "insert into cambio(fecha,compra,venta) values(@fec,@comp,@vent);"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@fec", enttp.fecha)
            .Parameters.AddWithValue("@comp", enttp.compra)
            .Parameters.AddWithValue("@vent", enttp.venta)
        End With
        Try
            rowsaffected = consultaSQL.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conexionValue.Close()
        End Try
        Return rowsaffected
    End Function
    Public Function TCambio_Actualizar(ByVal enttp As TipoCambio)
        conexionValue = Me.conexion
        Dim rowsaffected As Integer
        Dim sql As String = "update cambio Set compra=@comp,venta=@vent where fecha=@fec;"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)
        Dim dataTable As New DataTable
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@comp", enttp.compra)
            .Parameters.AddWithValue("@vent", enttp.venta)
            .Parameters.AddWithValue("@fec", enttp.fecha)
        End With
        Try
            rowsaffected = consultaSQL.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conexionValue.Close()
        End Try
        Return rowsaffected
    End Function
    Public Function TCambio_Estado(fecha As String) As Integer
        Dim rowsaffected As Integer
        Dim men As String = ""
        Dim consultaSQL As MySqlCommand
        'Logica
        conexionValue = Me.conexion
        consultaSQL = New MySqlCommand
        With consultaSQL
            .Connection = conexionValue
            .CommandText = "select count(fecha) as Estado from cambio where fecha = @fecha;"
            .Parameters.AddWithValue("@fecha", fecha)
        End With
        Try
            rowsaffected = consultaSQL.ExecuteScalar()
        Catch ex As MySqlException
            men = ex.Message
            rowsaffected = 0
        Finally
            conexionValue.Close()
        End Try
        Return rowsaffected
    End Function

    Public Function CheckTipoCambio(f As String) As Integer
        Dim rsp As Integer = 0
        Try
            Dim cmd As MySqlCommand = Me.CommandProcedure("sp_get_check_tp_cmbio")
            cmd = Me.Parameters(cmd, New String() {f})
            rsp = CInt(cmd.ExecuteScalar)
            Return rsp
        Catch ex As Exception
            Me.CloseDB()
            Return rsp
        End Try
    End Function
End Class
