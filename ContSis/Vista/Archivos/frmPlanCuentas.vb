Imports Controladores
Imports Capa_Entidad
Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Office.Interop

Public Class FrmPlanCuentas
    Dim totaldebe As Decimal
    Dim totalhaber As Decimal
    Dim validar As New CuentaBL
    Dim Entvalidar As New Cuenta
    Dim EntCont As New Cuenta
    Dim datos As New DataTable
    Dim autorizado As Integer
    Dim DTimport As New DataTable
    Dim DTExport As New DataTable
    Dim Amarretables As New DataTable
    Dim largocbo As String
    Dim valuecuenta As String
    Dim tabla As String = "16000"
    Dim listdet As String() = {"Inicio", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", "Cierre", "Total"}
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
#Region "ListView_Control"
    Sub listview_sin_nada()
        ListView1.Clear()
        ListView1.View = View.Details
        ListView1.Columns.Add("Meses")
        ListView1.Columns.Add("Debe")
        ListView1.Columns.Add("Haber")
        ListView1.Columns(0).Width = 115
        ListView1.Columns(1).Width = 190
        ListView1.Columns(2).Width = 190
        ListView1.Columns(1).TextAlign = HorizontalAlignment.Right
        ListView1.Columns(2).TextAlign = HorizontalAlignment.Right
        ListView1.GridLines = True
        For i = 0 To listdet.Length - 1
            ListView1.Items.Add(listdet(i))
        Next
    End Sub
    Sub listview_ceros()
        For i = 0 To listdet.Length - 1
            ListView1.Items(i).SubItems.Add(CDec("0,00"))
            ListView1.Items(i).SubItems.Add(CDec("0,00"))
        Next
    End Sub
#End Region
    Sub Amarres_registro()
        EntCont.codigo = txtcuenta.Text
        EntCont.c_debe = cbodebe.Text
        EntCont.c_haber = cbohaber.Text
        Amarretables = validar.Cuenta_Amarre_ShowLB(tabla, EntCont)
        If Amarretables.Rows.Count > 0 Then
            validar.Cuenta_Amarre_RegisterLB(tabla, 1, EntCont)
        Else
            validar.Cuenta_Amarre_RegisterLB(tabla, 0, EntCont)
        End If
    End Sub
    Sub limpiar()
        txtcuenta.Text = Nothing
        txtnombre.Text = Nothing
        txtalias.Text = Nothing
        cbodebe.Enabled = False
        cbohaber.Enabled = False
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        listview_sin_nada()
        listview_ceros()
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
#Region "AutoComplete"
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
    Sub llenando_autos()
        If CInt(txtcuenta.Text.Substring(0, 2)) >= 61 And CInt(txtcuenta.Text.Substring(0, 2)) <= 69 Then
            cbodebe.Enabled = True
            cbohaber.Enabled = True
            autocompletado_debe(9)
            autocompletado_haber(79)
        ElseIf CInt(txtcuenta.Text.Substring(0, 2)) = 60
            cbodebe.Enabled = True
            cbohaber.Enabled = True
            autocompletado_debe(2)
            autocompletado_haber(61)
        End If
    End Sub

#End Region


    Sub cbo_cambio(ByVal inx As Integer)
        Me.Text = "Plan contable de " + CStr(inx + 2) + " digitos"
        largocbo = inx + 2
        autocompletado(largocbo)
        txtcuenta.MaxLength = inx + 2
        limpiar()
    End Sub
    Private Sub txtcuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuenta.KeyDown

        If e.KeyCode = Keys.Enter Then
            If txtcuenta.Text.Trim().Length > 0 Then
                With EntCont
                    .codigo = txtcuenta.Text.Split("  ").First()
                End With
                Try
                    datos = validar.Cuenta_DatosLB(tabla, EntCont)
                    If datos.Rows.Count > 0 Then
                        listview_sin_nada()
                        For Each row As DataRow In datos.Rows
                            Dim xdebe As Integer() = {3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29}
                            Dim xhaber As Integer() = {4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30}
                            For i = 0 To 13
                                ListView1.Items(i).SubItems.Add(CDec(row(xdebe(i))).ToString)
                                ListView1.Items(i).SubItems.Add(CDec(row(xhaber(i))).ToString)
                            Next
                            totaldebe = row(3) + row(5) + row(7) + row(9) + row(11) + row(13) _
                                + row(15) + row(17) + row(19) + row(21) + row(23) + row(25) _
                                + row(27) + row(29)
                            totalhaber = row(4) + row(6) + row(8) + row(10) + row(12) + row(14) _
                                + row(16) + row(18) + row(20) + row(22) + row(24) + row(26) _
                                + row(28) + row(30)
                            ListView1.Items(14).SubItems.Add(totaldebe.ToString)
                            ListView1.Items(14).SubItems.Add(totalhaber.ToString)


                            txtcuenta.Text = row(2).ToString
                            txtnombre.Text = row(0).ToString
                            txtalias.Text = row(1).ToString
                        Next
                        If txtcuenta.TextLength > 5 Then
                            Amarretables = validar.Cuenta_Amarre_ShowLB(tabla, EntCont)
                            If Amarretables.Rows.Count > 0 Then
                                llenando_autos()
                                For Each row As DataRow In Amarretables.Rows
                                    cbodebe.Text = row(1)
                                    cbohaber.Text = row(2)
                                Next

                            Else
                                llenando_autos()
                            End If
                        End If

                    Else
                        MsgBox("Sin Datos")
                        limpiar()
                        listview_ceros()
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
                Amarres_registro()
            ElseIf CInt(txtcuenta.Text.Substring(0, 2)) = 60
                Amarres_registro()
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
                .debe = CDec(totaldebe)
                .haber = CDec(totalhaber)
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
        limpiar()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Autocompleta segun el nivel deseado
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
            largocbo = 6
            autocompletado(largocbo)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_PlanCuentas_Adicional.Show()
    End Sub

    Private Sub ListView1_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles ListView1.ColumnWidthChanging
        e.Cancel = True
    End Sub

    Private Sub ListView1_ColumnWidthChanged(sender As Object, e As ColumnWidthChangedEventArgs) Handles ListView1.ColumnWidthChanged
        Static FireMe As Boolean = True
        If FireMe = True Then
            FireMe = False
            ListView1.Columns(e.ColumnIndex).Width = 172
            FireMe = True
        End If
    End Sub
End Class