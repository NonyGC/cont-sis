Imports Controladores
Imports Capa_Entidad
Imports Vista.Base
Imports Vista.BaseForm
Public Class FrmComprobanteN
    Dim compBL As New ComprobanteBL
    Dim entCom As New Comprobante
    Dim numerocompro As String
    Dim datetimeFormat = Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat

    Dim monto As Decimal = 0
    Dim igv As Decimal = 0
    Dim inafec As Decimal = 0
    Dim isc As Decimal = 0
    Dim total As Decimal

    Dim table As DataTable = New DataTable()
    Dim tablecb As DataTable = New DataTable()
    Dim row As DataRow
    Dim rowcb As DataRow

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

        ''numerocompro = Mid(compBL.comprobante_autogenerado_(), 3, 4)
        txtnumcompro.Text = numerocompro

        datacol = compBL.comprobante_Cuenta()
        For i As Integer = 0 To datacol.Rows.Count - 1
            colcuenta.Add(datacol.Rows(i)("Cuenta").ToString)
        Next
        txtCuentaMonto.AutoCompleteCustomSource = colcuenta
        txtCuentaIgv.AutoCompleteCustomSource = colcuenta
        txtCuentaIsc.AutoCompleteCustomSource = colcuenta
        txtCuentaTotal.AutoCompleteCustomSource = colcuenta
        txtCuentaInafecto.AutoCompleteCustomSource = colcuenta
        txtFormapago.AutoCompleteCustomSource = colcuenta
        'stripbuttons
        stripbuttons(ToolStrip1)
    End Sub
    Sub DetalleComprobantecb()
        'table = Nothing
        If tablecb.Columns.Count = 0 Then
            tablecb.Columns.Add("Numero", Type.GetType("System.String"))
            tablecb.Columns.Add("Cuenta", Type.GetType("System.String"))
            tablecb.Columns.Add("Glosa", Type.GetType("System.String"))
            tablecb.Columns.Add("Debe", Type.GetType("System.Decimal"))
            tablecb.Columns.Add("Haber", Type.GetType("System.Decimal"))
        End If

        Dim det As Integer = 0
        If txtTotal.Text <> "" Then
            det = 10
            rowcb = tablecb.NewRow()
            rowcb("Numero") = det.ToString("D3")
            rowcb("Cuenta") = txtCuentaTotal.Text
            rowcb("Glosa") = txtGlosa.Text
            rowcb("Debe") = Convert.ToDecimal(txtTotal.Text)
            rowcb("Haber") = "0.00"
            tablecb.Rows.Add(rowcb)
        End If
        If txtTotal.Text <> "" Then
            rowcb = tablecb.NewRow()
            det += 10
            rowcb("Numero") = det.ToString("D3")
            rowcb("Cuenta") = "101111"
            rowcb("Glosa") = txtGlosa.Text
            rowcb("Debe") = "0.00"
            rowcb("Haber") = Convert.ToDecimal(txtTotal.Text)
            tablecb.Rows.Add(rowcb)
        End If

        For Each r As DataRow In tablecb.Rows
            With entCom
                .nrodetalle = r("Numero")
                .cuenta = r("Cuenta")
                .glosa = r("Glosa")
                .debe = Convert.ToDecimal(r("Debe"))
                .haber = Convert.ToDecimal(r("Haber"))
            End With
            'compBL.comprobante_detalle_register_cb(entCom)
        Next
    End Sub


    Sub DetalleComprobante()
        If table.Columns.Count = 0 Then
            table.Columns.Add("Numero", Type.GetType("System.String"))
            table.Columns.Add("Cuenta", Type.GetType("System.String"))
            table.Columns.Add("Glosa", Type.GetType("System.String"))
            table.Columns.Add("Debe", Type.GetType("System.Decimal"))
            table.Columns.Add("Haber", Type.GetType("System.Decimal"))
        End If

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
        If txtInafecto.Text <> "" Then
            row = table.NewRow()
            det += 10
            row("Numero") = det.ToString("D3")
            row("Cuenta") = txtCuentaIgv.Text
            row("Glosa") = txtGlosa.Text
            row("Debe") = txtInafecto.Text
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
        For Each r As DataRow In table.Rows
            With entCom
                .nrodetalle = r("Numero")
                .cuenta = r("Cuenta")
                .glosa = r("Glosa")
                .debe = Convert.ToDecimal(r("Debe"))
                .haber = Convert.ToDecimal(r("Haber"))
            End With
            ''compBL.comprobante_detalle_register(entCom)
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
        total = 0
        total = monto + igv + isc + inafec
        txtTotal.Text = total.ToString("N")
    End Sub

    Private Sub txtMonto_Leave(sender As Object, e As EventArgs) Handles txtMonto.Leave
        If txtMonto.Text <> "" Then
            monto = Convert.ToDecimal(txtMonto.Text)
            txtMonto.Text = monto.ToString("N")
            txtIgv.Text = (monto * 0.18).ToString("N")
            igv = Convert.ToDecimal(txtIgv.Text)
            txtIgv.Text = igv.ToString("N")
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

    'Private Sub txtTotal_Leave(sender As Object, e As EventArgs) Handles txtTotal.Leave
    '    If txtTotal.Text <> "" Then
    '        Dim total As Decimal = Convert.ToDecimal(txtTotal.Text)
    '        txtTotal.Text = total.ToString("N")
    '    End If
    'End Sub

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

    Private Sub txtInafecto_Leave(sender As Object, e As EventArgs) Handles txtInafecto.Leave
        If txtInafecto.Text <> "" Then
            inafec = Convert.ToDecimal(txtInafecto.Text)
            txtInafecto.Text = inafec.ToString("N")
        End If
        SumaTotal()
    End Sub



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
        If Len(txtCuentaMonto.Text) > 6 Then
            txtCuentaMonto.Text = Trim(Mid(txtCuentaMonto.Text, 1, InStr(txtCuentaMonto.Text, " ")))
        End If

    End Sub

    Private Sub txtCuentaIgv_Leave(sender As Object, e As EventArgs) Handles txtCuentaIgv.Leave
        If Len(txtCuentaIgv.Text) > 6 Then
            txtCuentaIgv.Text = Trim(Mid(txtCuentaIgv.Text, 1, InStr(txtCuentaIgv.Text, " ")))
        End If
    End Sub

    Private Sub txtCuentaIsc_Leave(sender As Object, e As EventArgs) Handles txtCuentaIsc.Leave
        If Len(txtCuentaIsc.Text) > 6 Then
            txtCuentaIsc.Text = Trim(Mid(txtCuentaIsc.Text, 1, InStr(txtCuentaIsc.Text, " ")))
        End If
    End Sub


    Sub cargarComprobante()
        'numerocompro = Mid(compBL.comprobante_registro_autogenerado(), 3, 4)
        txtnumcompro.Text = numerocompro
        rbtEfectivo.Checked = True
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
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles tsbguardar.Click
        Try
            If Me.ValidateChildren And txtDserie.Text <> "" And txtDnumero.Text <> "" And txtRuc.Text <> "" And txtGlosa.Text <> "" And txtMonto.Text <> "" And txtCuentaMonto.Text <> "" And txtTotal.Text <> "" And txtCuentaTotal.Text <> "" Then
                'With entCom
                '    .nrodiario = compBL.comprobante_diario_autogenerado()
                '    .periodo = CboPeriodo.Text
                '    .nrocompro = compBL.comprobante_registro_autogenerado()
                '    .moneda = cbomoneda.SelectedValue
                '    .tipo_adq = cboAdq.SelectedIndex
                '    .tipo_doc = cbotipodoc.SelectedValue
                '    .serie = txtDserie.Text
                '    .nrodocu = txtDnumero.Text
                '    '.fechae = Format(dtpFechae.Value.Date, "yyy/MM/dd")
                '    '.fechav = Format(dtpFechav.Value.Date, "yyy/MM/dd")
                '    .estado = 1
                '    .nrocaba = compBL.comprobante_cajabanco_autogenerado()
                'End With
                'compBL.comprobante_cabecera_register(entCom)
                'DetalleComprobante()

                'With entCom
                '    .nrodiario = compBL.comprobante_diario_autogenerado()
                '    .nrocaba = compBL.comprobante_cajabanco_autogenerado()

                'End With
                'compBL.comprobante_cabecera_register_cb(entCom)
                'DetalleComprobantecb()


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
        If Len(txtCuentaTotal.Text) > 6 Then
            txtCuentaTotal.Text = Trim(Mid(txtCuentaTotal.Text, 1, InStr(txtCuentaTotal.Text, " ")))
        End If
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

    Private Sub txtCuentaIsc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuentaTotal.KeyPress, txtCuentaMonto.KeyPress, txtCuentaIsc.KeyPress, txtCuentaInafecto.KeyPress, txtCuentaIgv.KeyPress, MyBase.KeyPress
        Solo_numeros(e)
    End Sub


    Private Sub txtRuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRuc.KeyPress, txtDserie.KeyPress, txtDnumero.KeyPress
        Solo_numeros(e)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Private Sub txtInafecto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInafecto.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, txtInafecto.Text & CChar(e.KeyChar))
    End Sub



    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles tsbsalir.Click
        Me.Close()
    End Sub

    Private Sub txtCuentaInafecto_Leave(sender As Object, e As EventArgs) Handles txtCuentaInafecto.Leave
        If Len(txtCuentaInafecto.Text) > 6 Then
            txtCuentaInafecto.Text = Trim(Mid(txtCuentaInafecto.Text, 1, InStr(txtCuentaInafecto.Text, " ")))
        End If
    End Sub


    Private Sub txtdia_TextChanged(sender As Object, e As EventArgs) Handles txtdia.TextChanged
        If txtdia.TextLength = 2 Then
            txtmes.Focus()
        End If
    End Sub
    Private Sub txtmes_TextChanged(sender As Object, e As EventArgs) Handles txtmes.TextChanged
        If txtmes.TextLength = 2 Then
            txtaño.Focus()
        End If
    End Sub
    Private Sub txtdiav_TextChanged(sender As Object, e As EventArgs) Handles txtdiav.TextChanged
        If txtdiav.TextLength = 2 Then
            txtmesv.Focus()
        End If
    End Sub
    Private Sub txtmesv_TextChanged(sender As Object, e As EventArgs) Handles txtmesv.TextChanged
        If txtmesv.TextLength = 2 Then
            txtañov.Focus()
        End If
    End Sub
    Private Sub txtdia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdia.KeyPress, txtdiav.KeyPress
        Solo_numeros(e)
    End Sub
    Private Sub txtmes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmes.KeyPress
        Solo_numeros(e)
        If Asc(e.KeyChar) = 8 And txtmes.TextLength = 0 Then
            txtdia.Focus()
        End If
    End Sub
    Private Sub txtaño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtaño.KeyPress
        Solo_numeros(e)
        If Asc(e.KeyChar) = 8 And txtaño.TextLength = 0 Then
            txtmes.Focus()
        End If
    End Sub
    Private Sub txtmesv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmesv.KeyPress
        Solo_numeros(e)
        If Asc(e.KeyChar) = 8 And txtmesv.TextLength = 0 Then
            txtdiav.Focus()
        End If
    End Sub
    Private Sub txtañov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtañov.KeyPress
        Solo_numeros(e)
        If Asc(e.KeyChar) = 8 And txtañov.TextLength = 0 Then
            txtmesv.Focus()
        End If
    End Sub
    Private Sub txtmes_Leave(sender As Object, e As EventArgs) Handles txtmes.Leave, txtmesv.Leave, txtdia.Leave, txtdiav.Leave
        If DirectCast(sender, TextBox).Text <> "" Then
            DirectCast(sender, TextBox).Text = Completar_D2(sender)
        End If
    End Sub
    Function Completar_D2(sender As Object) As String
        Dim valor As String = Convert.ToInt64(DirectCast(sender, TextBox).Text).ToString("D2")
        Return valor
    End Function

    Private Sub txtdia_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdia.Validating
        If txtdia.Text <> String.Empty Then
            validar_fecha(sender, 31, e)
            Me.ErrorIcon.SetError(Me.txtaño, "")
        Else
            Me.ErrorIcon.SetError(Me.txtaño, "Completate la Fecha de Emision")
        End If
    End Sub
    Private Sub txtmes_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtmes.Validating
        If txtmes.Text <> String.Empty Then
            validar_fecha(sender, 12, e)
            Me.ErrorIcon.SetError(Me.txtaño, "")
        Else
            Me.ErrorIcon.SetError(Me.txtaño, "Completate la Fecha de Emision")
        End If
    End Sub
    Sub validar_fecha(sen As Object, max As Integer, e As System.ComponentModel.CancelEventArgs)
        If Val(DirectCast(sen, TextBox).Text) > max Then
            e.Cancel = True
        End If
    End Sub
    Private Sub txtaño_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtaño.Validating
        Try
            If Val(DirectCast(sender, TextBox).Text) > 2050 And Val(DirectCast(sender, TextBox).Text) < 2000 Then
                e.Cancel = True
            Else
                Dim fecha As Date = CDate(txtaño.Text + "/" + txtmes.Text + "/" + txtdia.Text)
                If fecha < Date.Now Then
                    If CboPeriodo.SelectedItem = datetimeFormat.GetMonthName(fecha.Month) Then
                        Me.ErrorIcon.SetError(Me.txtaño, "")
                    Else
                        Me.ErrorIcon.SetError(Me.txtaño, "La Fecha ingresada no esta dentro del Periodo")
                    End If

                Else
                    Me.ErrorIcon.SetError(Me.txtaño, "Ingrese Fecha de Hoy hacia Atras")
                End If
            End If
        Catch ex As Exception
            Me.ErrorIcon.SetError(Me.txtaño, "Fecha Ingresada no valida")
        End Try
    End Sub

    Private Sub txtaño_Leave(sender As Object, e As EventArgs) Handles txtaño.Leave, txtañov.Leave
        If DirectCast(sender, TextBox).Text <> "" And DirectCast(sender, TextBox).TextLength < 3 And DirectCast(sender, TextBox).TextLength > 0 Then
            Dim año As Integer = DirectCast(sender, TextBox).Text
            año = año + 2000
            DirectCast(sender, TextBox).Text = año
        End If
    End Sub

    Private Sub txtdiav_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdiav.Validating
        If chbfechav.Checked = True Then
            If txtdiav.Text <> String.Empty Then
                validar_fecha(sender, 31, e)
                Me.ErrorIcon.SetError(Me.txtañov, "")
            Else
                Me.ErrorIcon.SetError(Me.txtañov, "Completate la Fecha de Vencimiento")
            End If
        Else
            Me.ErrorIcon.SetError(Me.txtañov, "")
        End If
    End Sub

    Private Sub txtmesv_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtmesv.Validating
        If chbfechav.Checked = True Then
            If txtmesv.Text = "" Then
                validar_fecha(sender, 12, e)
                Me.ErrorIcon.SetError(Me.txtañov, "")
            Else
                Me.ErrorIcon.SetError(Me.txtañov, "Completate la Fecha de Vencimiento")
            End If
        Else
            Me.ErrorIcon.SetError(Me.txtañov, "")
        End If
    End Sub

    Private Sub txtañov_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtañov.Validating
        If chbfechav.Checked = True Then
            Try
                If Val(DirectCast(sender, TextBox).Text) > 2050 And Val(DirectCast(sender, TextBox).Text) < 2000 Then
                    e.Cancel = True
                End If
                Dim fecha As Date = CDate(txtañov.Text + "/" + txtmesv.Text + "/" + txtdiav.Text)
                Me.ErrorIcon.SetError(Me.txtañov, "")
            Catch ex As Exception
                Me.ErrorIcon.SetError(Me.txtañov, "Fecha Ingresada no valida")
            End Try
        Else
            Me.ErrorIcon.SetError(Me.txtañov, "")
        End If
    End Sub

    Private Sub chbfechav_CheckedChanged(sender As Object, e As EventArgs) Handles chbfechav.CheckedChanged
        If chbfechav.Checked Then
            txtdiav.Enabled = True
            txtmesv.Enabled = True
            txtañov.Enabled = True
        Else
            txtdiav.Enabled = False
            txtmesv.Enabled = False
            txtañov.Enabled = False
        End If
    End Sub

    Private Sub txtFormapago_Leave(sender As Object, e As EventArgs) Handles txtFormapago.Leave
        Dim cuenta As String = txtFormapago.Text
        Dim cuentan As Object = Trim(Mid(cuenta, 1, InStr(cuenta, " ")))
        Dim nombrec As Object = Trim(Mid(cuenta, InStr(cuenta, " "), cuenta.Length))
        If cuentan.Length >= 6 Then
            txtFormapago.Text = cuentan
            lblnomFP.Text = nombrec
        Else
            MessageBox.Show("Ingrese Cuenta de 6 a mas digitos")
        End If
    End Sub

End Class