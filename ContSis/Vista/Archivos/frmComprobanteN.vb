Imports Controladores
Imports Capa_Entidad
Imports Vista.Base
Public Class FrmComprobanteN
    Dim compBL As New ComprobanteBL
    Dim entCom As New Comprobante
    Dim numerocompro As String
    Dim datetimeFormat = Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat

    Dim monto As Decimal = 0
    Dim igv As Decimal = 0
    Dim isc As Decimal = 0
    Dim total As Decimal = 0
    Private Sub FrmComprobanteN_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim dat As New DataTable
        Dim datacol As New DataTable
        Dim colruc As New AutoCompleteStringCollection
        Dim colcuenta As New AutoCompleteStringCollection
        cbotipodoc.DataSource = compBL.comprobante_mostrar_tipodoc()
        cbotipodoc.DisplayMember = "Descripcion"
        cbotipodoc.ValueMember = "Numero"
        cbomoneda.DataSource = compBL.comprobante_mostrar_moneda()
        cbomoneda.DisplayMember = "Descripcion"
        cbomoneda.ValueMember = "Codigo"
        dat = compBL.comprobante_mostrar_auxiliar()
        For i As Integer = 0 To dat.Rows.Count - 1
            colruc.Add(dat.Rows(i)("ruc").ToString)
        Next
        txtRuc.AutoCompleteCustomSource = colruc
        cbotipodoc.SelectedIndex = 0
        cboAdq.SelectedIndex = 0
        CboPeriodo.DataSource = datetimeFormat.MonthNames()
        CboPeriodo.SelectedItem = datetimeFormat.GetMonthName(Date.Today.Month)

        numerocompro = Mid(compBL.comprobante_registro_autogenerado(), 3, 4)
        txtnumcompro.Text = numerocompro

        datacol = compBL.comprobante_Cuenta()
        For i As Integer = 0 To datacol.Rows.Count - 1
            colcuenta.Add(datacol.Rows(i)("Cuenta").ToString)
        Next
        txtCuentaMonto.AutoCompleteCustomSource = colcuenta
        txtCuentaIgv.AutoCompleteCustomSource = colcuenta
        txtCuentaIsc.AutoCompleteCustomSource = colcuenta
        txtCuentaTotal.AutoCompleteCustomSource = colcuenta
        dtpFechae.MaxDate = Date.Today
    End Sub
    Sub DetalleComprobante()
        Dim table As DataTable = New DataTable()
        Dim row As DataRow
        table.Columns.Add("Numero", Type.GetType("System.String"))
        table.Columns.Add("Cuenta", Type.GetType("System.String"))
        table.Columns.Add("Glosa", Type.GetType("System.String"))
        table.Columns.Add("Debe", Type.GetType("System.Decimal"))
        table.Columns.Add("Haber", Type.GetType("System.Decimal"))
        Dim det As Integer = 0
        If txtTotal.Text <> "" Then
            det = 10
            row = table.NewRow()
            row("Numero") = det.ToString("D3")
            row("Cuenta") = txtCuentaTotal.Text
            row("Glosa") = txtGlosa.Text
            row("Haber") = Convert.ToDecimal(txtTotal.Text)
            row("Debe") = "0.00"
            table.Rows.Add(row)
        End If
        If txtMonto.Text <> "" Then
            row = table.NewRow()
            det += 10
            row("Numero") = det.ToString("D3")
            row("Cuenta") = txtCuentaMonto.Text
            row("Glosa") = txtGlosa.Text
            row("Debe") = Convert.ToDecimal(txtMonto.Text)
            row("Haber") = "0.00"
            table.Rows.Add(row)
        End If
        If txtIgv.Text <> "" Then
            row = table.NewRow()
            det += 10
            row("Numero") = det.ToString("D3")
            row("Cuenta") = txtCuentaIgv.Text
            row("Glosa") = txtGlosa.Text
            row("Debe") = txtIgv.Text
            row("Haber") = "0.00"
            table.Rows.Add(row)
        End If
        If txtIsc.Text <> "" Then
            row = table.NewRow()
            det += 10
            row("Numero") = det.ToString("D3")
            row("Cuenta") = txtCuentaIsc.Text
            row("Glosa") = txtGlosa.Text
            row("Debe") = txtIsc.Text
            row("Haber") = "0.00"
            table.Rows.Add(row)
        End If
        Dim n As Integer = 0
        For Each r As DataRow In table.Rows
            With entCom
                .nrodetalle = r("Numero")
                .cuenta = r("Cuenta")
                .glosa = r("Glosa")
                .debe = Convert.ToDecimal(r("Debe"))
                .haber = Convert.ToDecimal(r("Haber"))
            End With
            compBL.comprobante_detalle_register(entCom)
        Next

    End Sub


    Private Sub txtnumcompro_Leave(sender As Object, e As EventArgs) Handles txtnumcompro.Leave
        Dim NCompro As Integer = Val(txtnumcompro.Text)
        txtnumcompro.Text = NCompro.ToString("D4")
        If NCompro > numerocompro Then
            MessageBox.Show("Solo Numeros Menores")
            txtnumcompro.Text = numerocompro
        End If
    End Sub

    Function Fg_SoloNumeros(ByVal Digito As String, ByVal Texto As String) As Boolean
        Dim Dt_Entero As Integer = CInt(Asc(Digito))
        If Dt_Entero = 8 Then
            Fg_SoloNumeros = False
        Else
            If InStr("1234567890.", Digito) = 0 Then
                Fg_SoloNumeros = True
            ElseIf IsNumeric(Texto) = True Then
                Fg_SoloNumeros = False
            ElseIf IsNumeric(Texto) = False Then
                Fg_SoloNumeros = True
            End If
        End If
        Return Fg_SoloNumeros
    End Function

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, txtMonto.Text & CChar(e.KeyChar))
    End Sub

    Private Sub txtIgv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIgv.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, txtIgv.Text & CChar(e.KeyChar))
    End Sub

    Private Sub txtIsc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIsc.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, txtIsc.Text & CChar(e.KeyChar))
    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, txtTotal.Text & CChar(e.KeyChar))
    End Sub

    Sub SumaTotal()
        total = monto + igv + isc
        txtTotal.Text = total.ToString("N")
    End Sub

    Private Sub txtMonto_Leave(sender As Object, e As EventArgs) Handles txtMonto.Leave
        If txtMonto.Text <> "" Then
            monto = Convert.ToDecimal(txtMonto.Text)
            txtMonto.Text = monto.ToString("N")
        End If
        SumaTotal()
    End Sub

    Private Sub txtIgv_Leave(sender As Object, e As EventArgs) Handles txtIgv.Leave
        If txtIgv.Text <> "" Then
            igv = Convert.ToDecimal(txtIgv.Text)
            txtIgv.Text = igv.ToString("N")
        End If
        SumaTotal()
    End Sub

    Private Sub txtIsc_Leave(sender As Object, e As EventArgs) Handles txtIsc.Leave
        If txtIsc.Text <> "" Then
            isc = Convert.ToDecimal(txtIsc.Text)
            txtIsc.Text = isc.ToString("N")
        End If
        SumaTotal()
    End Sub

    Private Sub txtTotal_Leave(sender As Object, e As EventArgs) Handles txtTotal.Leave
        If txtTotal.Text <> "" Then
            Dim total As Decimal = Convert.ToDecimal(txtTotal.Text)
            txtTotal.Text = total.ToString("N")
        End If
    End Sub

    Private Sub txtDserie_Leave(sender As Object, e As EventArgs) Handles txtDserie.Leave
        If txtDserie.Text <> "" Then
            txtDserie.Text = Convert.ToInt64(txtDserie.Text).ToString("D3")
        End If
    End Sub

    Private Sub txtDnumero_Leave(sender As Object, e As EventArgs) Handles txtDnumero.Leave
        If txtDnumero.Text <> "" Then
            txtDnumero.Text = Convert.ToInt64(txtDnumero.Text).ToString("D7")
        End If
    End Sub

    'Private Sub MfechaDE_TypeValidationCompleted(sender As Object, e As TypeValidationEventArgs) Handles MfechaDE.TypeValidationCompleted
    '    Dim UserDate As DateTime = CDate(e.ReturnValue)
    '    Dim mes As String = datetimeFormat.GetMonthName(UserDate.Month)
    '    Dim año As String = UserDate.Year

    '    If (Not e.IsValidInput) Then
    '        Me.ErrorIcon.SetError(sender, "Ingrese la Fecha Correctamente")
    '    Else

    '        If UserDate < DateTime.Now And mes = CboPeriodo.SelectedValue And año = Date.Today.Year Then
    '            Me.ErrorIcon.SetError(sender, "")
    '        Else
    '            Me.ErrorIcon.SetError(sender, "Ingrese la Fecha de Este Periodo y menor que hoy")
    '            e.Cancel = True
    '        End If

    '    End If

    'End Sub


    Private Sub txtDserie_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDserie.Validating
        ErrorProvider(sender, "Ingrese la Serie")
    End Sub

    Private Sub txtDnumero_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDnumero.Validating
        ErrorProvider(sender, "Ingrese el Numero")
    End Sub

    Private Sub txtRuc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtRuc.Validating
        ErrorProvider(sender, "Ingrese Ruc del Proveedor")
    End Sub

    Private Sub txtCuentaMonto_Leave(sender As Object, e As EventArgs) Handles txtCuentaMonto.Leave
        txtCuentaMonto.Text = Trim(Mid(txtCuentaMonto.Text, 1, InStr(txtCuentaMonto.Text, " ")))
    End Sub

    Private Sub txtCuentaIgv_Leave(sender As Object, e As EventArgs) Handles txtCuentaIgv.Leave
        txtCuentaIgv.Text = Trim(Mid(txtCuentaIgv.Text, 1, InStr(txtCuentaIgv.Text, " ")))
    End Sub

    Private Sub txtCuentaIsc_Leave(sender As Object, e As EventArgs) Handles txtCuentaIsc.Leave
        txtCuentaIsc.Text = Trim(Mid(txtCuentaIsc.Text, 1, InStr(txtCuentaIsc.Text, " ")))
    End Sub
    Sub cargarComprobante()
        numerocompro = Mid(compBL.comprobante_registro_autogenerado(), 3, 4)
        txtnumcompro.Text = numerocompro
    End Sub
    Sub limpiarComprobante()
        cbomoneda.SelectedIndex = 0
        cbotipodoc.SelectedIndex = 0
        cboAdq.SelectedIndex = 0
        lblRazonSocial.Text = "Razón Social"
        txtRuc.Clear()
        txtDserie.Clear()
        txtDnumero.Clear()
        CboPeriodo.SelectedItem = datetimeFormat.GetMonthName(Date.Today.Month)
        txtGlosa.Clear()
        txtMonto.Clear()
        txtCuentaMonto.Clear()
        txtIgv.Clear()
        txtCuentaIgv.Clear()
        txtIsc.Clear()
        txtCuentaIsc.Clear()
        txtTotal.Clear()
        txtCuentaTotal.Clear()
        dtpFechae.ResetText()
        dtpFechav.ResetText()
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If Me.ValidateChildren And dtpFechae.Checked And txtDserie.Text <> "" And txtDnumero.Text <> "" And txtRuc.Text <> "" And txtGlosa.Text <> "" And txtMonto.Text <> "" And txtCuentaMonto.Text <> "" And txtTotal.Text <> "" And txtCuentaTotal.Text <> "" Then
                With entCom
                    .nrodiario = compBL.comprobante_diario_autogenerado()
                    .periodo = CboPeriodo.Text
                    .nrocompro = compBL.comprobante_registro_autogenerado()
                    .moneda = cbomoneda.SelectedValue
                    .tipo_adq = cboAdq.SelectedIndex
                    .tipo_doc = cbotipodoc.SelectedValue
                    .serie = txtDserie.Text
                    .nrodocu = txtDnumero.Text
                    .fechae = Format(dtpFechae.Value.Date, "yyy/MM/dd")
                    .fechav = Format(dtpFechav.Value.Date, "yyy/MM/dd")
                    .estado = 1
                End With

                With entCom
                    .nrodiario = compBL.comprobante_diario_autogenerado()
                    .nrocompro = compBL.comprobante_registro_autogenerado()
                End With
                compBL.comprobante_cabecera_register(entCom)

                DetalleComprobante()

                MessageBox.Show("SE REGISTRO CORRECTAMENTE" + vbCr + "Nº Diario  [" + entCom.nrodiario + "]" + vbCr +
                             "Nº Comprobante  [" + entCom.nrocompro + "]")
                cargarComprobante()
                limpiarComprobante()
            Else
                MessageBox.Show("Ingrese los datos Remarcados ", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub txtCuentaTotal_Leave(sender As Object, e As EventArgs) Handles txtCuentaTotal.Leave
        txtCuentaTotal.Text = Trim(Mid(txtCuentaTotal.Text, 1, InStr(txtCuentaTotal.Text, " ")))
    End Sub

    Private Sub txtMonto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMonto.Validating
        ErrorProvider(sender, "Ingrese Monto")
    End Sub

    Private Sub txtCuentaMonto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCuentaMonto.Validating
        ErrorProvider(sender, "Ingrese Cuenta del Monto")
    End Sub

    Private Sub txtTotal_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTotal.Validating
        ErrorProvider(sender, "Ingrese Total")
    End Sub

    Private Sub txtCuentaTotal_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCuentaTotal.Validating
        ErrorProvider(sender, "Ingrese Cuenta del Total")
    End Sub

    Private Sub txtGlosa_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtGlosa.Validating
        ErrorProvider(sender, "Ingrese La Glosa")
    End Sub
    Sub ErrorProvider(sen As Object, mensaje As String)
        If DirectCast(sen, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sen, "")
        Else
            Me.ErrorIcon.SetError(sen, mensaje)
        End If
    End Sub

    Private Sub txtRuc_TextChanged(sender As Object, e As EventArgs) Handles txtRuc.TextChanged
        If txtRuc.Text <> "" Then
            entCom.ruc = txtRuc.Text
            lblRazonSocial.Text = compBL.comprobante_razon_social(entCom)
        End If
    End Sub


    Private Sub CboPeriodo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbotipodoc.KeyPress, CboPeriodo.KeyPress, cbomoneda.KeyPress, cboAdq.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtCuentaIsc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuentaTotal.KeyPress, txtCuentaMonto.KeyPress, txtCuentaIsc.KeyPress, txtCuentaIgv.KeyPress, MyBase.KeyPress
        Solo_numeros(e)
    End Sub

    Private Sub dtpFechae_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechae.ValueChanged
        If dtpFechae.Checked = True Then
            dtpFechae.Format = DateTimePickerFormat.Custom
            dtpFechae.CustomFormat = "dd/MM/yyyy"
        Else
            dtpFechae.Format = DateTimePickerFormat.Custom
            dtpFechae.CustomFormat = " "
        End If
    End Sub

    Private Sub dtpFechav_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechav.ValueChanged
        If dtpFechav.Checked = True Then
            dtpFechav.Format = DateTimePickerFormat.Custom
            dtpFechav.CustomFormat = "dd/MM/yyyy"
        Else
            dtpFechav.Format = DateTimePickerFormat.Custom
            dtpFechav.CustomFormat = " "
        End If
    End Sub

    Private Sub dtpFechae_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtpFechae.Validating
        If dtpFechae.Text <> String.Empty And dtpFechae.Checked Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingrese fecha")
        End If
    End Sub

    Private Sub txtRuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRuc.KeyPress, txtDserie.KeyPress, txtDnumero.KeyPress
        Solo_numeros(e)
    End Sub
End Class