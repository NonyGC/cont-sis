Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class ComprobanteDAO
    Inherits BaseDao
    Private conexionValue As MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim conn As New MySqlConnection
    Public Function Comprobante_mostrar_cuenta() As DataTable
        Return Consultar_Tabla_MySQL("select CONCAT(codigo,'  ',nombre) as Cuenta from pc16000 where codigo regexp '^33|^60|^62^63|^65|^4'")
    End Function
    Public Function Comprobante_mostrar_cuenta_n() As DataTable
        Return Consultar_Tabla_MySQL("select alias from pc16000 where LENGTH(codigo)=5")
    End Function
    Public Function Comprobante_filtrar_cuenta_n(ByVal entCom As Comprobante) As DataTable
        Return Consultar_Tabla_MySQL("select codigo,nombre from pc16000 WHERE codigo='" + entCom.cuenta + "'")
    End Function
    Public Function Comprobante_mostrar_moneda() As DataTable
        Return Consultar_Tabla_MySQL("SELECT codigo,descripcion FROM moneda")
    End Function
    Public Function Comprobante_mostrar_tipodoc() As DataTable
        Return Consultar_Tabla_MySQL("SELECT Numero,Descripcion FROM tipo_documento_pago")
    End Function
    Public Function Comprobante_mostrar_auxiliar() As DataTable
        Return Consultar_Tabla_MySQL("SELECT ruc,razon_social FROM auxiliar")
    End Function
    Public Function razon_social(ByVal entCom As Comprobante) As String
        conn = Me.conexion
        da = New MySqlDataAdapter("SELECT razon_social FROM auxiliar WHERE ruc = @ruc", conn)
        da.SelectCommand.CommandType = CommandType.Text
        da.SelectCommand.Parameters.AddWithValue("@ruc", entCom.ruc)
        Dim Razon As String = da.SelectCommand.ExecuteScalar
        Return Razon
    End Function
    Public Function comprobante_diario_autogenerado() As String
        conn = Me.conexion
        da = New MySqlDataAdapter("sp_comprobante_numero_diario", conn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim Razon As String = da.SelectCommand.ExecuteScalar
        Return Razon
    End Function
    Public Function comprobante_registocompra_autogenerado() As String
        conn = Me.conexion
        da = New MySqlDataAdapter("sp_comprobante_registroc_autogenerado", conn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim Razon As String = da.SelectCommand.ExecuteScalar
        Return Razon
    End Function
    'Public Function comprobante_cabecera_register(ByVal entCom As Comprobante)
    '    Return Mantenimiento_SQL("sp_comprobante_registrar_c", entCom.nrodiario, entCom.periodo, entCom.nrocompro, entCom.moneda, entCom.tipo_adq, entCom.tipo_doc, entCom.serie, entCom.nrodocu, entCom.fechae, entCom.fechav, entCom.ruc)
    'End Function
    Public Function comprobante_cabecera_register(ByVal entCom As Comprobante)
        conexionValue = Me.conexion
        Dim rowsaffected As Integer
        Dim sql As String = "sp_comprobante_registrar_c"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)

        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("n_d", entCom.nrodiario)
            .Parameters.AddWithValue("p", entCom.periodo)
            .Parameters.AddWithValue("n_r", entCom.nrocompro)
            .Parameters.AddWithValue("c_m", entCom.moneda)
            .Parameters.AddWithValue("t_adq", entCom.tipo_adq)
            .Parameters.AddWithValue("t_d", entCom.tipo_doc)
            .Parameters.AddWithValue("s_d", entCom.serie)
            .Parameters.AddWithValue("n_doc", entCom.nrodocu)
            .Parameters.AddWithValue("fee_d", entCom.fechae)
            .Parameters.AddWithValue("fev_d", entCom.fechav)
            .Parameters.AddWithValue("r_a", entCom.ruc)
            .Parameters.AddWithValue("est", entCom.estado)

        End With
        Try
            rowsaffected = consultaSQL.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conexionValue.Close()
        End Try
        Return rowsaffected
    End Function
    Public Function comprobante_cabecera_actualizar(ByVal entCom As Comprobante)
        conexionValue = Me.conexion
        Dim rowsaffected As Integer
        Dim sql As String = "sp_comprobante_actualizar_c"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)

        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("n_d", entCom.nrodiario)
            .Parameters.AddWithValue("p", entCom.periodo)
            .Parameters.AddWithValue("n_r", entCom.nrocompro)
            .Parameters.AddWithValue("c_m", entCom.moneda)
            .Parameters.AddWithValue("t_adq", entCom.tipo_adq)
            .Parameters.AddWithValue("t_d", entCom.tipo_doc)
            .Parameters.AddWithValue("s_d", entCom.serie)
            .Parameters.AddWithValue("n_doc", entCom.nrodocu)
            .Parameters.AddWithValue("fee_d", entCom.fechae)
            .Parameters.AddWithValue("fev_d", entCom.fechav)
            .Parameters.AddWithValue("r_a", entCom.ruc)
            .Parameters.AddWithValue("est", entCom.estado)

        End With
        Try
            rowsaffected = consultaSQL.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conexionValue.Close()
        End Try
        Return rowsaffected
    End Function
    Public Function comprobante_detalle_register(ByVal entCom As Comprobante)
        conexionValue = Me.conexion
        Dim rowsaffected As Integer
        Dim sql As String = "sp_comprobante_registrar_cdetalle"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)

        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("nrd", entCom.nrodetalle)
            .Parameters.AddWithValue("nrr", entCom.nrocompro)
            .Parameters.AddWithValue("cue", entCom.cuenta)
            .Parameters.AddWithValue("glo", entCom.glosa)
            .Parameters.AddWithValue("deb", entCom.debe)
            .Parameters.AddWithValue("hab", entCom.haber)
        End With
        Try
            rowsaffected = consultaSQL.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conexionValue.Close()
        End Try
        Return rowsaffected
    End Function
    Public Function comprobante_detalle_actualizar(ByVal entCom As Comprobante)
        conexionValue = Me.conexion
        Dim rowsaffected As Integer
        Dim sql As String = "sp_comprobante_actualizar_cdetalle"
        Dim consultaSQL As MySqlCommand = New MySqlCommand(sql, conexionValue)

        With consultaSQL
            .Connection = conexionValue
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("nrd", entCom.nrodetalle)
            .Parameters.AddWithValue("nrr", entCom.nrocompro)
            .Parameters.AddWithValue("cue", entCom.cuenta)
            .Parameters.AddWithValue("glo", entCom.glosa)
            .Parameters.AddWithValue("deb", entCom.debe)
            .Parameters.AddWithValue("hab", entCom.haber)
        End With
        Try
            rowsaffected = consultaSQL.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conexionValue.Close()
        End Try
        Return rowsaffected
    End Function

    'Public Function comprobante_detalle_register(ByVal entCom As Comprobante)
    '    Return Mantenimiento_SQL("sp_comprobante_registrar_cdetalle", entCom.nrodetalle, entCom.nrocompro, entCom.cuenta, entCom.glosa, entCom.debe, entCom.haber)
    'End Function
    Public Function comprobante_detalle_autogenerado(ByVal entCom As Comprobante) As String
        conn = Me.conexion
        da = New MySqlDataAdapter("SELECT LPAD(IFNULL(MAX(nro_det),0)+10,3,'0') detalle FROM d16000d where nro_reg=@nro_reg", conn)
        da.SelectCommand.CommandType = CommandType.Text
        da.SelectCommand.Parameters.AddWithValue("@nro_reg", entCom.nrocompro)
        Dim Razon As String = da.SelectCommand.ExecuteScalar
        Return Razon
    End Function
    Public Function Comprobante_cebecera_llenar(ByVal entCom As Comprobante) As DataTable
        Return Consultar_Tabla_MySQL("SELECT * FROM d16000 WHERE num_reg='" + entCom.nrocompro + "'")
    End Function
    Public Function Comprobante_detalle_llenar(ByVal entCom As Comprobante) As DataTable
        Return Consultar_Tabla_MySQL("SELECT nro_det,cuenta,p.nombre,glosa,debe,haber FROM d16000d d INNER JOIN pc16000 p on d.cuenta=p.codigo WHERE nro_reg='" + entCom.nrocompro + "'")
    End Function

End Class

