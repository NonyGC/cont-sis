Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports Controladores
Imports Capa_Entidad
Imports System.Text
Public Class FrmPlanCuentasAdicional
    Dim validar As New CuentaBL
    Dim tabla As String = "16002"
    Dim str As String
    Public dterror As New DataTable
    Dim EntCont As New Cuenta
    Dim DTExport As New DataTable
    Dim filePath_Import As String
    Dim extension As String
    Dim conStr As String
    Dim sheetName As String
    Dim Excel03ConString As String =
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES'"
    Dim Excel07ConString As String =
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES'"
    'Dim header As String = If(rbHeaderYes.Checked, "YES", "NO")
    Private Sub Abrir_path(sender As Object, e As EventArgs) Handles btnpath.Click
        Try
            With OpenFileDialog1
                .Filter = ("Excel files |*.xls;*.xlsx")
                .FilterIndex = 4
            End With
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                filePath_Import = OpenFileDialog1.FileName
                extension = Path.GetExtension(filePath_Import)
                txtpath.Text = OpenFileDialog1.FileName
                conStr = String.Empty
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnprevista.Click
        Try
            Select Case extension
                Case ".xls"
                    'Excel 97-03
                    conStr = String.Format(Excel03ConString, txtpath.Text)
                    Exit Select
                Case ".xlsx"
                    'Excel 07
                    conStr = String.Format(Excel07ConString, txtpath.Text)
                    Exit Select
            End Select
            Using con As New OleDbConnection(conStr)
                Using cmd As New OleDbCommand()
                    Using oda As New OleDbDataAdapter()
                        Dim dt As New DataTable()
                        sheetName = txthoja.Text + "$"
                        cmd.CommandText = (Convert.ToString("Select * From [") & sheetName) + "]"
                        cmd.Connection = con
                        con.Open()
                        oda.SelectCommand = cmd
                        oda.Fill(dt)
                        con.Close()
                        DTImport.DataSource = Nothing
                        DTImport.DataSource = dt
                        DTImport.Columns(0).Width = 80
                        DTImport.Columns(1).Width = 350
                        DTImport.Columns(2).Width = 260
                        DTImport.AllowUserToResizeColumns = False
                        'DTimport = dt
                    End Using
                End Using
            End Using
            Detectdupl()
            Detectexistenter()
            ' Detectexistpadre()

            If dterror.Rows.Count > 0 Then
                Dim result = MessageBox.Show("Se corrigieron los siguientes errores", "Errores encontrados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                If result = DialogResult.OK Then
                    FrmPlanCuentasErrores.Show()
                End If
            Else
                MessageBox.Show("No se encontro ningún problema", "Sin problemas")
            End If
            btnconfirmar.Enabled = True
            Dim pbcont As Integer
            For i = 0 To DTImport.Rows.Count - 1
                pbcont = pbcont + 1
            Next
            ProgressBar1.Maximum = pbcont
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub Frm_PlanCuentas_Adicional_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtpath.WaterMarkText = "Ingrese la dirección del archivo Excel"
        txthoja.WaterMarkText = "Hoja a importar"
        btnconfirmar.Enabled = False
        dterror.Columns.Add("Error", Type.GetType("System.String"))
        dterror.Columns.Add("Descripcion", Type.GetType("System.String"))
    End Sub

    Private Sub btnconfirmar_Click(sender As Object, e As EventArgs) Handles btnconfirmar.Click
        ProgressBar1.Value = 0
        Dim cont As Integer
        Dim PCsql As StringBuilder = New StringBuilder("insert into pc" & tabla & " (codigo,nombre,alias) values")
        Dim PCsql2 As StringBuilder = New StringBuilder("insert into pc" & tabla & "m (codigo) values")
        Dim PCsql3 As StringBuilder = New StringBuilder("insert into pc" & tabla & "m2 (codigo,cuenta_padre) values")
        Dim rows As New List(Of String)
        Dim rows2 As New List(Of String)
        Dim rows3 As New List(Of String)
        Dim c, n, a, cp As String
        Try
            For i = 0 To DTImport.Rows.Count - 1
                c = DTImport.Rows(i).Cells(0).Value.ToString
                'Ver si la cuenta es de 2 Digitos
                If c.Length < 3 Then
                    n = DTImport.Rows(i).Cells(1).Value.ToString.ToUpper()
                Else
                    n = DTImport.Rows(i).Cells(1).Value.ToString
                End If
                'si la cuenta es de 6 digitos
                If c.Length > 5 Then
                    cp = c.Substring(0, 5)
                Else
                    cp = c
                End If
                'Si el doc. tiene las cuents con un nombre de referencia
                If DTImport.Rows(i).Cells(2).Value.ToString.Length > 0 Then
                    a = DTImport.Rows(i).Cells(2).Value.ToString.Substring(0, 25)
                Else
                    Dim blanco = Space(25)
                    a = (n & blanco).Substring(0, n.Length)
                End If

                'Añadiendo a una lista los datos del DGV
                rows.Add(String.Format("('{0}','{1}','{2}')", Convert.ToString(c), Convert.ToString(n), Convert.ToString(a)))
                'si la cuenta es de 6 digitos a más se añadira la tabla designada
                If DTImport.Rows(i).Cells(0).Value.ToString.Length > 5 Then
                    rows3.Add(String.Format("('{0}','{1}')", Convert.ToString(c), Convert.ToString(cp)))
                Else
                    rows2.Add(String.Format("('{0}')", Convert.ToString(c)))
                End If
                cont = cont + 1
                ProgressBar1.Increment(1)
            Next
            'Construyendo los Strings
            PCsql.Append(String.Join(",", rows))
            PCsql.Append(";")
            PCsql2.Append(String.Join(",", rows2))
            PCsql2.Append(";")
            PCsql3.Append(String.Join(",", rows3))
            PCsql3.Append(";")
            Dim cmd As String
            If rows2.Count = 0 Then
                PCsql2 = New StringBuilder("")
            End If
            If rows3.Count = 0 Then
                PCsql3 = New StringBuilder("")
            End If
            'Formando sql Statement
            cmd = PCsql.ToString + PCsql2.ToString + PCsql3.ToString
            'Guardando Datos
            validar.ImportXtoMysqlLB(tabla, cmd.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Detectdupl()
        Dim msgdp As String = "Se encontro duplicado de esta cuenta"
        Dim i As Integer = 0
        Do While i < DTImport.Rows.Count - 1
            Dim filacompare = DTImport.Rows(i)
            For Each row As DataGridViewRow In DTImport.Rows
                If filacompare.Equals(row) Then Continue For
                Dim duplicadofila As Boolean = True
                If Not filacompare.Cells(0).Value.Equals(row.Cells(0).Value) Then
                    duplicadofila = False
                End If
                If (duplicadofila) Then
                    dterror.Rows.Add(msgdp, row.Cells(0).Value.ToString)
                    DTImport.Rows.RemoveAt(row.Index)
                End If
            Next
            i = i + 1
        Loop

    End Sub
    Sub Detectexistenter()
        Dim msgde As String = "Esta cuenta ya esta registrada en la base de datos"
        Dim i As Integer = 0
        Dim DTexiste As New DataTable
        DTexiste = validar.Cuenta_Export(tabla)
        Do While i < DTexiste.Rows.Count
            Dim filacompare = DTexiste.Rows(i)
            For Each row As DataGridViewRow In DTImport.Rows
                If filacompare.Equals(row) Then Continue For
                Dim duplicadofila As Boolean = True
                If Not filacompare(0).Equals(row.Cells(0).Value) Then
                    duplicadofila = False
                End If
                If (duplicadofila) Then
                    dterror.Rows.Add(msgde, row.Cells(0).Value.ToString)
                    DTImport.Rows.RemoveAt(row.Index)
                End If
            Next
            i = i + 1
        Loop
        'Dim a = dterror.Rows.Count
        'Dim result = MessageBox.Show("Se corrigieron los siguientes errores" & i & " " & a, "Errores encontrados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'If result = DialogResult.OK Then
        'FrmPlanCuentasErrores.Show()
        'End If
    End Sub
    Sub Detectexistpadre()
        Dim msgde As String = "Se creara la siguiente cuenta"
        Dim i As Integer = 0
        Dim DTexiste As New DataTable
        Dim noexiste As Boolean = True
        DTexiste = validar.Cuenta_Export(tabla)
        Do While i < DTexiste.Rows.Count
            Dim filacompare = DTexiste.Rows(i)
            For Each row As DataGridViewRow In DTImport.Rows
                Dim c As String = row.Cells(0).Value
                Dim c_length As Integer = row.Cells(0).Value.ToString.Length
                Dim padre As String = c.Substring(0, c_length - 1)
                Dim fijo As String = filacompare(0)
                'Aca empieza comprobacion
                If filacompare.Equals(padre) Then

                Else
                    dterror.Rows.Add(msgde, padre)
                    DTImport.Rows.RemoveAt(row.Index)
                End If

                If Not fijo.Equals(padre) Then
                    noexiste = False
                End If
            Next
            i = i + 1
        Loop
        'Dim a = dterror.Rows.Count
        'Dim result = MessageBox.Show("Se corrigieron los siguientes errores" & i & " " & a, "Errores encontrados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'If result = DialogResult.OK Then
        'FrmPlanCuentasErrores.Show()
        'End If
    End Sub
    Private Sub btnCnfExport_Click(sender As Object, e As EventArgs)
        'Change "C:\Users\Jimmy\Documents\Merchandise.accdb" to your database location
        Dim ODsave As New SaveFileDialog
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Jimmy\Desktop\test.accdb"
        'Change "C:\Users\Jimmy\Desktop\test.xlsx" to your excel file location
        Dim excelLocation As String
        Dim source1 As New BindingSource
        Dim APP As New Excel.Application
        Dim worksheet As Excel.Worksheet
        Dim workbook As Excel.Workbook
        Dim misValue As Object = System.Reflection.Missing.Value
        Try
            DTExport = validar.Cuenta_Export(tabla)
            ODsave.FileName = "Plan_contable"
            ODsave.Filter = ("Excel files |*.xls")
            ODsave.Title = "Guardar Plan Contable"
            ODsave.DefaultExt = "xls"
            ODsave.AddExtension = True
            ''Export Header Names Start
            If ODsave.ShowDialog = DialogResult.OK Then
                excelLocation = ODsave.FileName
                workbook = APP.Workbooks.Add(misValue)
                worksheet = CType(workbook.Sheets(1), Excel.Worksheet)

                Dim columnsCount As Integer = DTExport.Columns.Count
                For Each column In DTExport.Columns
                    worksheet.Cells(1, column.Ordinal + 1).Value = column.columnname
                Next
                For i As Integer = 0 To DTExport.Rows.Count - 1
                    Dim columnIndex As Integer = 0
                    Do Until columnIndex = columnsCount
                        'worksheet.Cells(i + 2, columnIndex + 1).Value = DTExport.Item(columnIndex, i).value.ToString
                        worksheet.Cells(i + 2, columnIndex + 1).Value = DTExport.Rows(i).Item(columnIndex).ToString
                        columnIndex += 1
                    Loop
                Next
                workbook.SaveAs(excelLocation, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                workbook.Close()
                APP.Quit()
                releaseObject(worksheet)
                releaseObject(workbook)
                releaseObject(APP)
                MessageBox.Show("Exportación Completada")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub
End Class