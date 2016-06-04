Imports Controladores
Imports Capa_Entidad
Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Public Class frmPlanCuentas
    Dim validar As New CuentaBL
    Dim Entvalidar As New Cuenta
    Dim EntCont As New Cuenta
    Dim datos As New DataTable
    Dim autorizado As Integer
    Dim DTimport As New DataTable
    Dim DTExport As New DataTable
    Dim largocbo As String
    Dim valuecuenta As String
    Dim tabla As String = "16000"
    Private Sub CLearTextboxes()
        Dim a As Decimal = 9999999999.99

        For Each C As Control In GroupBox4.Controls
            C.Text = a.ToString("C")
        Next

    End Sub
    Sub verificarTBs()
        If txtcuenta.Text.Trim().Length > 0 Then
            EntCont.codigo = txtcuenta.Text
        Else
            EntCont.codigo = Nothing
            MsgBox("Ingrese el numero de Cuenta")
        End If
        If txtnombre.Text.Trim().Length > 0 Then
            'mayuscula
            EntCont.nombre = txtnombre.Text.ToUpper()
        Else
            EntCont.nombre = Nothing
            MsgBox("Ingrese el nombre de la Cuenta")
        End If

        If txtalias.Text.Trim().Length > 0 Then
            EntCont.aliass = txtalias.Text
        Else
            Dim blanco As String = Space(25)
            EntCont.aliass = (EntCont.nombre & Space(25)).Substring(0, 25)
            'MsgBox(EntCont.aliass.Length)
        End If
    End Sub
    Sub limpiar()
        txtcuenta.Text = Nothing
        txtnombre.Text = Nothing
        txtalias.Text = Nothing
        CLearTextboxes()
    End Sub
    Sub registrar()
        If validar.Cuenta_RegisterLB(tabla, EntCont) > 0 Then
            MsgBox("Cuenta registrada ")
            limpiar()
        End If
    End Sub
    Sub actualizar()
        If validar.Cuenta_ActualizarLB(tabla, EntCont) > 0 Then
            MsgBox("Cuenta Actualizada ")
            limpiar()
        End If
    End Sub
    Sub autocompletado(ByVal largo As String)
        Dim i As Integer
        Try
            Dim col As New AutoCompleteStringCollection
            Dim datacol As New DataTable
            datacol = validar.Cuenta_Autocompletado(tabla, largo)
            For i = 0 To datacol.Rows.Count - 1
                col.Add(datacol.Rows(i)("codigo").ToString)
            Next
            txtcuenta.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtcuenta.AutoCompleteCustomSource = col
            txtcuenta.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub autocompletado_debe(ByVal dest As String)
        Try
            Dim datacol As New DataTable
            datacol = validar.Cuenta_Autocompletado_destino(tabla, dest)
            cbodebe.DataSource = datacol
            cbodebe.DisplayMember = "codigo"
            cbodebe.ValueMember = "codigo"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub autocompletado_haber(ByVal dest As String)
        Try
            Dim datacol As New DataTable
            datacol = validar.Cuenta_Autocompletado_destino(tabla, dest)
            cbohaber.DataSource = datacol
            cbohaber.DisplayMember = "codigo"
            cbohaber.ValueMember = "codigo"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub cbo_cambio(ByVal inx As Integer)
        Me.Text = "Plan contable de " + CStr(inx + 2) + " digitos"
        largocbo = inx + 2
        autocompletado(largocbo)
        GroupBox2.Visible = False
        txtcuenta.MaxLength = inx + 2
        limpiar()
    End Sub
    Private Sub txtcuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuenta.KeyDown

        If e.KeyCode = Keys.Enter Then
            If txtcuenta.Text.Trim().Length > 5 Then
                GroupBox2.Visible = True
            End If
            If txtcuenta.Text.Trim().Length > 0 Then
                With EntCont
                    .codigo = txtcuenta.Text.Split("  ").First()
                End With
                Try
                    datos = validar.Cuenta_DatosLB(tabla, EntCont)
                    If datos.Rows.Count > 0 Then
                        For Each row As DataRow In datos.Rows
                            txtcuenta.Text = row(2).ToString
                            txtnombre.Text = row(0).ToString
                            txtalias.Text = row(1).ToString
                            lbldebeini.Text = CDec(row(3)).ToString("C")
                            lblhaberini.Text = CDec(row(4)).ToString("C")
                            lbldebeene.Text = CDec(row(5)).ToString("C")
                            lblhaberene.Text = CDec(row(6)).ToString("C")
                            lbldebefeb.Text = CDec(row(7)).ToString("C")
                            lblhaberfeb.Text = CDec(row(8)).ToString("C")
                            lbldebemar.Text = CDec(row(9)).ToString("C")
                            lblhabermar.Text = CDec(row(10)).ToString("C")
                            lbldebeabr.Text = CDec(row(11)).ToString("C")
                            lblhaberabr.Text = CDec(row(12)).ToString("C")
                            lbldebemay.Text = CDec(row(13)).ToString("C")
                            lblhabermay.Text = CDec(row(14)).ToString("C")
                            lbldebejun.Text = CDec(row(15)).ToString("C")
                            lblhaberjun.Text = CDec(row(16)).ToString("C")
                            lbldebejul.Text = CDec(row(17)).ToString("C")
                            lblhaberjul.Text = CDec(row(18)).ToString("C")
                            lbldebeago.Text = CDec(row(19)).ToString("C")
                            lblhaberago.Text = CDec(row(20)).ToString("C")
                            lbldebesep.Text = CDec(row(21)).ToString("C")
                            lblhabersep.Text = CDec(row(22)).ToString("C")
                            lbldebeoct.Text = CDec(row(23)).ToString("C")
                            lblhaberoct.Text = CDec(row(24)).ToString("C")
                            lbldebenov.Text = CDec(row(25)).ToString("C")
                            lblhabernov.Text = CDec(row(26)).ToString("C")
                            lbldebedic.Text = CDec(row(27)).ToString("C")
                            lblhaberdic.Text = CDec(row(28)).ToString("C")
                            lbldebecier.Text = CDec(row(29)).ToString("C")
                            lblhabercier.Text = CDec(row(30)).ToString("C")
                            lbldebetotal.Text = row(3) + row(5) + row(7) + row(9) + row(11) + row(13) _
                                + row(15) + row(17) + row(19) + row(21) + row(23) + row(25) _
                                + row(27) + row(29)

                            lblhabertotal.Text = row(4) + row(6) + row(8) + row(10) + row(12) + row(14) _
                                + row(16) + row(18) + row(20) + row(22) + row(24) + row(26) _
                                + row(28) + row(30)
                        Next
                        If CInt(txtcuenta.Text.Substring(0, 2)) >= 61 And CInt(txtcuenta.Text.Substring(0, 2)) <= 69 Then
                            GroupBox2.Visible = True
                            autocompletado_debe(9)
                            autocompletado_haber(79)
                        ElseIf CInt(txtcuenta.Text.Substring(0, 2)) = 60
                            GroupBox2.Visible = True
                            autocompletado_debe(2)
                            autocompletado_haber(61)
                        Else
                            GroupBox2.Visible = False
                        End If

                    Else
                        MsgBox("Sin Datos")
                        limpiar()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        verificarTBs()
        Try
            Dim updata As DataTable = validar.Cuenta_DatosLB(tabla, EntCont)
            If updata.Rows.Count > 0 Then
                If txtnombre.Text.Trim().Length > 0 Then
                    actualizar()
                End If
            Else
                If txtcuenta.Text.Trim().Length > 2 Then
                    Dim codigo As String = txtcuenta.Text.Substring(0, txtcuenta.Text.Length - 1)
                    Entvalidar.codigo = codigo
                    datos = validar.Cuenta_DatosLB(tabla, Entvalidar)
                    If datos.Rows.Count > 0 Then
                        registrar()
                    Else
                        MsgBox("la cuenta " + codigo + " no existe")
                    End If
                Else
                    registrar()
                End If
            End If
            If CInt(txtcuenta.Text.Substring(0, 2)) >= 61 And CInt(txtcuenta.Text.Substring(0, 2)) <= 69 Then
                EntCont.codigo = txtcuenta.Text
                EntCont.c_debe = cbodebe.Text
                EntCont.c_haber = cbohaber.Text
                validar.Cuenta_Amarre_RegisterLB(tabla, EntCont)
            ElseIf CInt(txtcuenta.Text.Substring(0, 2)) = 60
                EntCont.codigo = txtcuenta.Text
                EntCont.c_debe = cbodebe.Text
                EntCont.c_haber = cbohaber.Text
                validar.Cuenta_Amarre_RegisterLB(tabla, EntCont)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtcuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcuenta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim resp As Integer
        Try
            With EntCont
                .codigo = txtcuenta.Text
                .debe = CDec(lbldebetotal.Text)
                .haber = CDec(lblhabertotal.Text)
            End With
            If EntCont.debe + EntCont.haber > 0 Then
                MsgBox("No se puede borrar")
                Exit Sub
            End If
            resp = MsgBox("¿Está seguro de Eliminar esta cuenta?", vbYesNo + vbQuestion,
                          "Eliminar Cuenta")
            If resp = vbYes Then
                Dim afecta As Integer = validar.Cuenta_BorrarLB(tabla, EntCont)
                If afecta > 0 Then
                    MsgBox("completado")
                    limpiar()
                End If
            End If
        Catch ex As Exception

        End Try


    End Sub
    Private Sub Frm_PlanCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCnfImp.Visible = False
        GroupBox2.Visible = False
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCnfImp.Click
        ProgressBar1.Value = 0
        Dim cont As Integer
        Try
            For i = 0 To DTimport.Rows.Count - 1
                EntCont.codigo = DTimport.Rows(i)(0).ToString
                EntCont.nombre = DTimport.Rows(i)(1).ToString.ToUpper()
                If DTimport.Rows(i)(2).ToString.Length > 0 Then
                    EntCont.aliass = DTimport.Rows(i)(2).ToString
                Else
                    Dim blanco As String = Space(25)
                    EntCont.aliass = (EntCont.nombre & Space(25)).Substring(0, 25)
                End If
                validar.Cuenta_RegisterLB(tabla, EntCont)
                cont = cont + 1
                ProgressBar1.Increment(1)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    Private Sub btnCnfExport_Click(sender As Object, e As EventArgs) Handles btnexport.Click
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
            btnCnfImp.Visible = False

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnimport.Click

        Dim Excel03ConString As String =
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES'"
        Dim Excel07ConString As String =
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES'"
        Dim filePath As String
        Dim extension As String
        'Dim header As String = If(rbHeaderYes.Checked, "YES", "NO")
        Dim conStr As String
        Dim sheetName As String
        Try
            With OpenFileDialog1
                .Filter = ("Excel files |*.xls;*.xlsx")
                .FilterIndex = 4
            End With
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                filePath = OpenFileDialog1.FileName
                extension = Path.GetExtension(filePath)
                conStr = String.Empty
                Select Case extension
                    Case ".xls"
                        'Excel 97-03
                        conStr = String.Format(Excel03ConString, filePath)
                        Exit Select
                    Case ".xlsx"
                        'Excel 07
                        conStr = String.Format(Excel07ConString, filePath)
                        Exit Select
                End Select

                'Using con As New OleDbConnection(conStr)
                '    Using cmd As New OleDbCommand()
                '        cmd.Connection = con
                '        con.Open()

                '        Dim dtExcelSchema As DataTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)

                '        sheetName = dtExcelSchema.Rows(0)("TABLE_NAME").ToString()
                '        con.Close()
                '    End Using
                'End Using
                'Read Data from the First Sheet.

                Using con As New OleDbConnection(conStr)
                    Using cmd As New OleDbCommand()
                        Using oda As New OleDbDataAdapter()
                            Dim dt As New DataTable()
                            sheetName = InputBox("Seleccione pagina a importar") + "$"
                            cmd.CommandText = (Convert.ToString("SELECT * From [") & sheetName) + "]"
                            cmd.Connection = con
                            con.Open()
                            oda.SelectCommand = cmd
                            oda.Fill(dt)
                            con.Close()
                            'DataGridView1.DataSource = Nothing
                            'DataGridView1.DataSource = dt
                            DTimport = dt
                        End Using
                    End Using
                End Using
                btnCnfImp.Visible = True

            End If
            Dim pbcont As Integer
            For i = 0 To DTimport.Rows.Count - 1
                pbcont = pbcont + 1
            Next
            ProgressBar1.Maximum = pbcont
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            cbo_cambio(0)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            cbo_cambio(1)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            cbo_cambio(2)
        ElseIf ComboBox1.SelectedIndex = 3 Then
            cbo_cambio(3)
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Me.Text = "Plan contable de (6 - 12) digitos"
            largocbo = "6"
            GroupBox2.Visible = True
            txtcuenta.MaxLength = 12
            limpiar()
        End If
    End Sub
    Private Sub cbodebe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodebe.SelectedIndexChanged
        If EntCont.codigo <> Nothing Then
            With EntCont
                .codigo = cbodebe.SelectedValue.ToString
            End With
            Try
                datos = validar.Cuenta_DatosLB(tabla, EntCont)
                For Each row As DataRow In datos.Rows
                    lblAmDebe.Text = row(1).ToString
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub cbohaber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbohaber.SelectedIndexChanged
        If EntCont.codigo <> Nothing Then
            With EntCont
                .codigo = cbohaber.SelectedValue.ToString
            End With
            Try
                datos = validar.Cuenta_DatosLB(tabla, EntCont)
                For Each row As DataRow In datos.Rows
                    lblAmHaber.Text = row(1).ToString
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

End Class