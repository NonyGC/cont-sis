Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Imports System.Text
Public Class SistemaDao
    Inherits BaseDao

    Public Function ActivoAdmin() As Boolean
        Try

            Dim rsp As Integer
            Dim cmd As MySqlCommand = CommandProcedure("sp_act_adm")
            rsp = CInt(cmd.ExecuteScalar)

            If rsp > 0 Then
                Return True
            End If
            Return rsp
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Mantenimiento(sistema As Sistema) As Boolean
        Try
            Dim cmd As MySqlCommand = CommandProcedure("sp_configuracion")
            cmd = Parameters(cmd, sistema.Array)
            Dim c As Integer = cmd.ExecuteNonQuery()
            If c > 0 Then
                Return True
            Else
                Return False
            End If
            Return True
        Catch ex As Exception
            Return False
        Finally
            CloseDB()
        End Try
    End Function
    Public Function GetSistema() As Sistema
        Try
            Dim sistema As New Sistema
            Dim cmd As MySqlCommand = CommandProcedure("sp_get_sistema")
            Using dr As MySqlDataReader = cmd.ExecuteReader
                If dr.Read() Then
                    sistema.NroUsuario = dr.GetInt32("usu")
                    sistema.NroEmpresa = dr.GetInt32("emp")
                    sistema.ActivoAdmin = dr.GetInt32("adm")
                Else
                    sistema = Nothing
                End If
            End Using
            Return sistema
        Catch ex As Exception
            Return Nothing
        Finally
            CloseDB()
        End Try
    End Function
    Public Function BuildShema(cod As String) As Boolean
        Try
            Dim cmd As MySqlCommand = CommandProcedure("sp_CreaTablasxEmp")
            cmd = Parameters(cmd, New String() {cod})
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            CloseDB()
        End Try

    End Function
    Public Function DBCreate(cod As String)
        Try
            Dim sql As New StringBuilder("Create Database If Not exists ")
            Dim cmd As MySqlCommand
            Dim DataBase As String
            DataBase = String.Format("BD{0}", Convert.ToString(cod))
            sql.Append(DataBase)
            sql.Append(";")
            cmd = New MySqlCommand(sql.ToString, conexion)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            Dim tb As New StringBuilder("use ")
            tb.Append(DataBase)
            tb.Append(";")
            'Tablas
            tb.Append("CREATE TABLE IF Not EXISTS `plan_contable` like bdsist.plan_contable;")
            tb.Append("CREATE TABLE IF Not EXISTS `pc_movimiento` like bdsist.pc_movimiento;")
            tb.Append("CREATE TABLE IF Not EXISTS `pc_movimiento_2` like bdsist.pc_movimiento_2;")
            tb.Append("CREATE TABLE IF Not EXISTS `amarre` like bdsist.amarre;")
            tb.Append("CREATE TABLE IF Not EXISTS `diario` like bdsist.diario;")
            tb.Append("CREATE TABLE IF Not EXISTS `diario_detalle` like bdsist.diario_detalle;")
            tb.Append("CREATE TABLE IF Not EXISTS `registro_compra` like bdsist.reg_compra;")
            tb.Append("CREATE TABLE IF Not EXISTS `registro_venta` like bdsist.reg_venta;")
            'F_keys
            tb.Append("ALTER TABLE `pc_movimiento` ADD CONSTRAINT `FK_pcontable` FOREIGN KEY (`codigo`) REFERENCES `plan_contable` (`codigo`);")
            tb.Append("ALTER TABLE `pc_movimiento_2` ")
            tb.Append("ADD CONSTRAINT `FK_c_padre` FOREIGN KEY (`cuenta_padre`) REFERENCES `pc_movimiento` (`codigo`),")
            tb.Append("ADD Constraint `FK_pcontable_2` FOREIGN KEY (`codigo`) REFERENCES `plan_contable` (`codigo`);")
            tb.Append("ALTER TABLE `amarre` ")
            tb.Append("ADD CONSTRAINT `FK_am_pcm` FOREIGN KEY (`cuenta`) REFERENCES `pc_movimiento` (`codigo`),")
            tb.Append("ADD CONSTRAINT `FK_am_pcm_2` FOREIGN KEY (`c_debe`) REFERENCES `pc_movimiento` (`codigo`),")
            tb.Append("ADD CONSTRAINT `FK_am_pcm_3` FOREIGN KEY (`c_haber`) REFERENCES `pc_movimiento` (`codigo`);")
            tb.Append("ALTER TABLE `diario` ")
            tb.Append("ADD CONSTRAINT `fk_a__d` FOREIGN KEY (`ruc_aux`) REFERENCES `bdsist`.`auxiliar` (`ruc`),")
            tb.Append("ADD CONSTRAINT `fk_m__d` FOREIGN KEY (`cod_mon`) REFERENCES `bdsist`.`moneda` (`codigo`),")
            tb.Append("ADD CONSTRAINT `fk_t__d` FOREIGN KEY (`tip_doc`) REFERENCES `bdsist`.`tipo_documento_pago` (`Numero`);")
            tb.Append("ALTER TABLE `diario_detalle` ")
            tb.Append("ADD CONSTRAINT `fk__det_d` FOREIGN KEY (`nro_reg`) REFERENCES `diario` (`num_reg`),")
            tb.Append("ADD CONSTRAINT `fk__det_pc` FOREIGN KEY (`cuenta`) REFERENCES `plan_contable` (`codigo`);")
            'Inset plan
            tb.Append("INSERT INTO plan_contable SELECT * from bdsist.pc_master;")
            tb.Append("INSERT INTO pc_movimiento SELECT * from bdsist.pc_movimiento;")
            cmd = New MySqlCommand(tb.ToString, conexion)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            CloseDB()
        End Try
    End Function
End Class
