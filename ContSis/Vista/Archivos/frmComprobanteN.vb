Imports Controladores
Imports Capa_Entidad
Public Class FrmComprobanteN
    Dim compBL As New ComprobanteBL
    Dim entCom As New Comprobante
    Dim numerocompro As String
    Dim datetimeFormat = Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat

    Dim monto As Decimal = 0
    Dim igv As Decimal = 0
    Dim isc As Decimal = 0
    Dim total As Decimal = 0
    Private Sub FrmComprobanteN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub
    Sub DetalleComprobante()
        Dim table As DataTable = New DataTable()
        Dim row As DataRow
        table.Columns.Add("Numero", Type.GetType("System.String"))
        table.Columns.Add("Cuenta", Type.GetType("System.String"))
        table.Columns.Add("Glosa", Type.GetType("System.String"))
        table.Columns.Add("Debe", Type.GetType("System.Decimal"))
        table.Columns.Add("Haber", Type.GetType("System.Decimal"))
        If txtTotal.Text <> "" Then
            row = table.NewRow()
            row("Numero") = "010"
            row("Cuenta") = txtCuentaTotal.Text
            row("Glosa") = txtGlosa.Text
            row("Haber") = Convert.ToDecimal(txtTotal.Text)
            row("Debe") = "0.00"
            table.Rows.Add(row)
        End If
        If txtMonto.Text <> "" Then
            row = table.NewRow()
            row("Numero") = "020"
            row("Cuenta") = txtCuentaMonto.Text
            row("Glosa") = txtGlosa.Text
            row("Debe") = Convert.ToDecimal(txtMonto.Text)
            row("Haber") = "0.00"
            table.Rows.Add(row)
        End If
        If txtIgv.Text <> "" Then
            row = table.NewRow()
            row("Numero") = "030"
            row("Cuenta") = txtCuentaIgv.Text
            row("Glosa") = txtGlosa.Text
            row("Debe") = txtIgv.Text
            row("Haber") = "0.00"
            table.Rows.Add(row)
        End If
        If txtIsc.Text <> "" Then
            row = table.NewRow()
            row("Numero") = "040"
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

    Private Sub txtRuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRuc.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRuc_Leave(sender As Object, e As EventArgs) Handles txtRuc.Leave
        If txtRuc.Text <> "" Then
            entCom.ruc = txtRuc.Text
            lblRazonSocial.Text = compBL.comprobante_razon_social(entCom)
        End If
    End Sub

    Private Sub txtnumcompro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumcompro.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnumcompro_Leave(sender As Object, e As EventArgs) Handles txtnumcompro.Leave
        Dim NCompro As Integer = Val(txtnumcompro.Text)
        txtnumcompro.Text = NCompro.ToString("D4")
        If NCompro > numerocompro Then
            MessageBox.Show("Solo Numeros Menores")
            txtnumcompro.Text = numerocompro
        End If
    End Sub

    Private Sub txtDserie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDserie.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDnumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDnumero.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cbotipodoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbotipodoc.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboAdq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboAdq.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbomoneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbomoneda.KeyPress
        e.Handled = True
    End Sub

    Private Sub CboPeriodo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboPeriodo.KeyPress
        e.Handled = True
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

    Private Sub MfechaDE_TypeValidationCompleted(sender As Object, e As TypeValidationEventArgs) Handles MfechaDE.TypeValidationCompleted
        If (Not e.IsValidInput) Then
            Me.ErrorIcon.SetError(sender, "Ingrese la Fecha Correctamente")
        Else
            Dim UserDate As DateTime = CDate(e.ReturnValue)
            If (UserDate > DateTime.Now) Then
                Me.ErrorIcon.SetError(sender, "Ingrese la Fecha Menor que hoy")
                e.Cancel = True
            End If
            Me.ErrorIcon.SetError(sender, "")
        End If
    End Sub

    Private Sub MfechaDV_TypeValidationCompleted(sender As Object, e As TypeValidationEventArgs) Handles MfechaDV.TypeValidationCompleted
        If (Not e.IsValidInput) Then
        Else
            Dim UserDate As DateTime = CDate(e.ReturnValue)
            If (UserDate > DateTime.Now) Then
                Me.ErrorIcon.SetError(sender, "Ingrese la Fecha Menor que hoy")
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtDserie_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDserie.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingrese la Serie")
        End If
    End Sub

    Private Sub txtDnumero_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDnumero.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingrese el Numero")
        End If
    End Sub

    Private Sub txtRuc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtRuc.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingrese Ruc del Proveedor")
        End If
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
        MfechaDE.Clear()
        MfechaDV.Clear()
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
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If Me.ValidateChildren And MfechaDE.ValidateText IsNot Nothing And txtDserie.Text <> "" And txtDnumero.Text <> "" And txtRuc.Text <> "" And txtGlosa.Text <> "" And txtMonto.Text <> "" And txtCuentaMonto.Text <> "" And txtTotal.Text <> "" And txtCuentaTotal.Text <> "" Then
                Dim fechaDE As Date
                Dim fechaDV As Date
                fechaDE = CDate(MfechaDE.ValidateText)
                fechaDV = CDate(MfechaDV.ValidateText)
                With entCom
                    .nrodiario = compBL.comprobante_diario_autogenerado()
                    .periodo = CboPeriodo.Text
                    .nrocompro = compBL.comprobante_registro_autogenerado()
                    .moneda = cbomoneda.SelectedValue
                    .tipo_adq = cboAdq.SelectedIndex
                    .tipo_doc = cbotipodoc.SelectedValue
                    .serie = txtDserie.Text
                    .nrodocu = txtDnumero.Text
                    .fechae = Format(fechaDE, "yyyy/MM/dd")
                    If MfechaDV.ValidateText IsNot Nothing Then
                        .fechav = Format(fechaDV, "yyyy/MM/dd")
                    Else
                        .fechav = ""
                    End If
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
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingrese Monto")
        End If
    End Sub

    Private Sub txtCuentaMonto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCuentaMonto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingrese Cuenta del Monto")
        End If
    End Sub

    Private Sub txtTotal_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTotal.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingrese Total")
        End If
    End Sub

    Private Sub txtCuentaTotal_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCuentaTotal.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingrese Cuenta del Total")
        End If
    End Sub

    Private Sub txtGlosa_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtGlosa.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingrese La Glosa")
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click

    End Sub
End Class