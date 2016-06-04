Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Imports System.Data.OleDb

Public Class FormatoDao
    Inherits BaseDao
#Region "Variables"
    Private dsFormato8_1 As New DataSet("BDFormato8_1")
    Private dt As New DataTable("Formato8_1")
    Public nroRegistros As Integer
    Private _empresa As Empresa
#End Region
#Region "Constructor"
    Public Sub New()

    End Sub
    Public Property Empresa() As Empresa
        Get
            Return _empresa
        End Get
        Set(value As Empresa)
            _empresa = value
            dsFormato8_1.Tables.Add(EmpresaDao.CrearSchema.Copy)
            Dim dr As DataRow = dsFormato8_1.Tables("Empresa").NewRow
            dr("Ruc") = _empresa.RUC
            dr("RazonSocial") = _empresa.Nombre
            dr("Alias") = _empresa.Aliass
            dsFormato8_1.Tables("Empresa").Rows.Add(dr)
        End Set
    End Property


#End Region
#Region "Formato81"
    Public Sub CrearFormatoXMl_8_1(conStr As String, sheetName As String)
        Using con As New OleDbConnection(conStr)
            con.Open()
            Using cmd As New OleDbCommand((Convert.ToString("SELECT * From [") & sheetName + "$") + "]", con)
                Dim dt As DataTable = CrearSchema()
                dt.TableName = "Formato8_1"
                Dim odr As OleDbDataReader
                odr = cmd.ExecuteReader
                While odr.Read
                    Dim r As DataRow = dt.NewRow
                    For i = 0 To dt.Columns.Count - 1
                        r.Item(i) = odr.Item(i)
                    Next
                    dt.Rows.Add(r)
                End While
                dsFormato8_1.Tables.Add(dt.Copy)
                nroRegistros = dsFormato8_1.Tables("Formato8_1").Rows.Count
                dsFormato8_1.WriteXml("C:\SoftTemp\formato8_1.xml", XmlWriteMode.WriteSchema)
                con.Close()
            End Using
        End Using


    End Sub
    Public Sub CrearFormatoXMl_8_1(envio() As String)
        'Declaracion 
        Dim cmd As MySqlCommand = Me.CommandProcedure("sp_FiltroFormato81")
        cmd = Me.Parameters(cmd, envio)
        Dim da As New MySqlDataAdapter
        Try
            da.SelectCommand = cmd
            da.Fill(dt)
            dsFormato8_1.Tables.Add(dt.Copy)
            If System.IO.Directory.Exists("C:\SoftTemp") = False Then
                System.IO.Directory.CreateDirectory("C:\SoftTemp")
            End If
            nroRegistros = dsFormato8_1.Tables("Formato8_1").Rows.Count
            dsFormato8_1.WriteXml("C:\SoftTemp\formato8_1.xml", XmlWriteMode.WriteSchema)

        Catch ex As Exception
            nroRegistros = 0
            MsgBox(ex.Message)
        Finally
            Me.CloseDB()
        End Try
    End Sub
#End Region

    Public Sub CrearFormatoXMl141DB(envio() As String)
        'Declaracion 
        Dim cmd As MySqlCommand = Me.CommandProcedure("sp_FiltroFormato141")
        cmd = Me.Parameters(cmd, envio)
        Try

            Dim ndt As DataTable = Me.GetDataTable(cmd)
            ndt.TableName = "Formato141"
            CrearDirectory("C:\SoftTemp")
            nroRegistros = ndt.Rows.Count
            ndt.WriteXml("C:\SoftTemp\formato141.xml", XmlWriteMode.WriteSchema)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.CloseDB()
        End Try
    End Sub
    Public Sub CrearDirectory(NameDirectory As String)
        If System.IO.Directory.Exists(NameDirectory) = False Then
            System.IO.Directory.CreateDirectory(NameDirectory)
        End If
    End Sub
    Private Function CrearSchema() As DataTable
        Dim cmd As New MySqlCommand("formato_8_1", Me.conexion)
        cmd.CommandType = CommandType.TableDirect
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        Return da.FillSchema(dt, SchemaType.Mapped)
    End Function
End Class
