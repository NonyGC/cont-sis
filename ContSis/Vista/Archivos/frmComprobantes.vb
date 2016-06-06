Imports Controladores
Imports Capa_Entidad
Public Class frmComprobantes
    Dim compBL As New ComprobanteBL
    Dim entCom As New Comprobante
    Dim datacol As New DataTable

    Dim numerodiario As String
    Dim numerocompro As String
    Dim datetimeFormat = Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat
    Dim gvtb As New DataTable
    Private Sub frmComprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dat As New DataTable
        Dim coll As New AutoCompleteStringCollection

        cbotipodoc.DataSource = compBL.comprobante_mostrar_tipodoc()
        cbotipodoc.DisplayMember = "Descripcion"
        cbotipodoc.ValueMember = "Numero"
        cbomoneda.DataSource = compBL.comprobante_mostrar_moneda()
        cbomoneda.DisplayMember = "Descripcion"
        cbomoneda.ValueMember = "Codigo"
        cargarComprobante()

        dat = compBL.comprobante_mostrar_auxiliar()
        For i As Integer = 0 To dat.Rows.Count - 1
            coll.Add(dat.Rows(i)("ruc").ToString)
        Next
        txtRuc.AutoCompleteCustomSource = coll

        llenarCeldasDGV()

        cboAdq.SelectedIndex = 0
        CboPeriodo.DataSource = datetimeFormat.MonthNames()
        CboPeriodo.SelectedItem = datetimeFormat.GetMonthName(Date.Today.Month)
    End Sub

    Sub cargarComprobante()
        numerodiario = Mid(compBL.comprobante_diario_autogenerado(), 3, 5)
        numerocompro = Mid(compBL.comprobante_registro_autogenerado(), 3, 4)
        txtnumdiario.Text = numerodiario
        entCom.nrodiario = txtnumdiario.Text
        txtnumcompro.Text = numerocompro
    End Sub
    Sub llenarCeldasDGV()
        If gvComprobante.Rows.Count < 3 Then
            For I As Integer = 0 To 5
                gvComprobante.Rows.Add()
            Next
        End If
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
    End Sub

    Private Sub gvComprobante_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles gvComprobante.EditingControlShowing
        'Dim fila As Integer = gvComprobante.Rows.Count() - 1
        'For i As Integer = 0 To gvComprobante.Columns.Count() - 1
        '    gvComprobante.Item(i, fila).ReadOnly = True
        '    gvComprobante.Rows(fila).DefaultCellStyle.BackColor = Color.Beige
        'Next
        '05
        Dim col As New AutoCompleteStringCollection
        Dim autoText As TextBox = TryCast(e.Control, TextBox)

        If gvComprobante.CurrentCell.ColumnIndex = 1 Then
            If autoText IsNot Nothing Then
                Try
                    datacol = compBL.comprobante_Cuenta()
                    For i As Integer = 0 To datacol.Rows.Count - 1
                        col.Add(datacol.Rows(i)("Cuenta").ToString)
                    Next
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    autoText.AutoCompleteCustomSource = col
                    autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        ElseIf gvComprobante.CurrentCell.ColumnIndex = 2 Then
            If autoText IsNot Nothing Then
                Try
                    datacol = compBL.comprobante_Cuenta_n()
                    For i As Integer = 0 To datacol.Rows.Count - 1
                        col.Add(datacol.Rows(i)("nombre").ToString)
                    Next
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    autoText.AutoCompleteCustomSource = col
                    autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            autoText.AutoCompleteCustomSource = Nothing
        End If
    End Sub

    Private Sub gvComprobante_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles gvComprobante.CellEndEdit
        Dim cuenta As String = gvComprobante.CurrentRow.Cells(1).Value
        If gvComprobante.CurrentCell.ColumnIndex = 1 Then
            Try
                If cuenta.Length > 6 Then
                    cuenta = Trim(Mid(cuenta, 1, InStr(cuenta, " ")))
                End If
                gvComprobante.CurrentRow.Cells(1).Value = cuenta
                entCom.cuenta = cuenta

                datacol = compBL.comprobante_cuenta_filtrar_nombre(entCom)
                If datacol.Rows.Count > 0 Then
                    For Each row As DataRow In datacol.Rows
                        gvComprobante.CurrentRow.Cells(2).Value = row(1).ToString
                    Next
                End If
                entCom.cuenta = ""
                gvComprobante.CurrentRow.Cells(3).Value = entCom.glosa
                ''
                Dim debe As Decimal = gvComprobante.CurrentRow.Cells(4).Value
                Dim haber As Decimal = gvComprobante.CurrentRow.Cells(5).Value
                gvComprobante.CurrentRow.Cells(4).Value = debe.ToString("N")
                gvComprobante.CurrentRow.Cells(5).Value = haber.ToString("N")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        If gvComprobante.CurrentCell.ColumnIndex = 3 Then
            entCom.glosa = gvComprobante.CurrentRow.Cells(3).Value
        End If


        Try
            If gvComprobante.CurrentCell.ColumnIndex = 4 Or gvComprobante.CurrentCell.ColumnIndex = 5 Then

                Dim debe As Decimal = 0
                Dim haber As Decimal = 0
                debe = gvComprobante.CurrentRow.Cells(4).Value
                haber = gvComprobante.CurrentRow.Cells(5).Value
                Dim n As Integer = -1
                gvComprobante.CurrentRow.Cells(4).Value = Convert.ToDecimal((debe).ToString("N"))
                gvComprobante.CurrentRow.Cells(5).Value = Convert.ToDecimal((haber).ToString("N"))


                If gvComprobante.CurrentCell.ColumnIndex = 4 Then
                    debe = 0
                    haber = 0
                    gvComprobante.CurrentRow.Cells(5).Value = "0.00"
                    For Each row As DataGridViewRow In gvComprobante.Rows
                        n += 1
                        If row.Cells(1).Value Is Nothing Then Exit For
                        If n > gvComprobante.CurrentRow.Index Then Exit For
                        debe += row.Cells(4).Value
                        haber += row.Cells(5).Value
                    Next

                    gvComprobante.Item(5, gvComprobante.CurrentRow.Index + 1).Value = Convert.ToDecimal((debe - haber).ToString("N"))

                ElseIf gvComprobante.CurrentCell.ColumnIndex = 5 Then
                    debe = 0
                    haber = 0
                    gvComprobante.CurrentRow.Cells(4).Value = "0.00"
                    For Each row As DataGridViewRow In gvComprobante.Rows
                        n += 1
                        If row.Cells(1).Value Is Nothing Then Exit For
                        If n > gvComprobante.CurrentRow.Index Then Exit For
                        debe += row.Cells(4).Value
                        haber += row.Cells(5).Value
                    Next
                    gvComprobante.Item(4, gvComprobante.CurrentRow.Index + 1).Value = Convert.ToDecimal((haber - debe).ToString("N"))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If Me.ValidateChildren And txtnumdiario.Text <> String.Empty And txtnumcompro.Text <> String.Empty And txtDserie.Text <> String.Empty And txtDnumero.Text <> String.Empty And txtRuc.Text <> String.Empty And MfechaDE.ValidateText IsNot Nothing Then

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
                If btnguardar.Text = "Guardar" Then
                    With entCom
                        .nrodiario = compBL.comprobante_diario_autogenerado()
                        .nrocompro = compBL.comprobante_registro_autogenerado()
                    End With
                    compBL.comprobante_cabecera_register(entCom)
                    For Each row As DataGridViewRow In gvComprobante.Rows
                        If row.Cells(1).Value Is Nothing Then Exit For
                        With entCom
                            .nrodetalle = compBL.comprobante_detalle_autogenerado(entCom)
                            .cuenta = row.Cells(1).Value
                            .glosa = row.Cells(3).Value
                            .debe = row.Cells(4).Value
                            .haber = row.Cells(5).Value
                        End With
                        compBL.comprobante_detalle_register(entCom)
                    Next
                    limpiarComprobante()
                    gvtb.Clear()
                    For i As Integer = 0 To 5
                        gvtb.Rows.Add()
                    Next
                    gvComprobante.DataSource = gvtb
                    MessageBox.Show("SE REGISTRO CORRECTAMENTE" + vbCr + "Nº Diario  [" + entCom.nrodiario + "]" + vbCr +
                                 "Nº Comprobante  [" + entCom.nrocompro + "]")

                ElseIf btnguardar.Text = "Actualizar" Then
                    With entCom
                        .nrodiario = "05" + txtnumdiario.Text
                        .nrocompro = "08" + txtnumcompro.Text
                    End With
                    compBL.comprobante_cabecera_actualizar(entCom)

                    For Each row As DataGridViewRow In gvComprobante.Rows
                        If row.Cells(1).Value.ToString = "" Then Exit For
                        With entCom
                            .nrodetalle = row.Cells(0).Value
                            .cuenta = row.Cells(1).Value
                            .glosa = row.Cells(3).Value
                            .debe = row.Cells(4).Value
                            .haber = row.Cells(5).Value
                        End With
                        compBL.comprobante_detalle_actualizar(entCom)
                    Next
                    btnguardar.Text = "Guardar"
                    limpiarComprobante()
                    gvtb.Clear()
                    For i As Integer = 0 To 5
                        gvtb.Rows.Add()
                    Next
                    gvComprobante.DataSource = gvtb


                    MessageBox.Show("SE ACTUALIZO CORRECTAMENTE" + vbCr + vbCr + "Nº Diario  [" + entCom.nrodiario + "]" + vbCr +
                                 "Nº Comprobante  [" + entCom.nrocompro + "]")

                End If
                cargarComprobante()
            Else
                MessageBox.Show("Ingrese los datos Remarcados ", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtnumcompro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumcompro.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If Asc(e.KeyChar) = 13 Then
                Try
                    btnguardar.Text = "Actualizar"
                    btnlimpiar.Enabled = False
                    Dim Ncompro As Integer = Val(txtnumcompro.Text)
                    txtnumcompro.Text = Ncompro.ToString("D4")

                    If Ncompro <> numerocompro And Ncompro < numerocompro Then
                        entCom.nrocompro = "08" + txtnumcompro.Text
                        compBL.Comprobante_cebecera_llenar(entCom)
                        compBL.Comprobante_detalle_llenar(entCom)

                        gvtb = compBL.Comprobante_detalle_llenar(entCom)
                        gvComprobante.DataSource = gvtb
                        For i As Integer = 0 To 5 - gvtb.Rows.Count
                            gvtb.Rows.Add()
                        Next

                        datacol = compBL.Comprobante_cebecera_llenar(entCom)
                        txtnumdiario.Text = Mid(datacol.Rows(0)("num_dia"), 3, 5)
                        txtDnumero.Text = datacol.Rows(0)("num_doc")
                        txtDserie.Text = datacol.Rows(0)("ser_doc")
                        txtRuc.Text = datacol.Rows(0)("ruc_aux")
                        CboPeriodo.SelectedItem = datacol.Rows(0)("periodo")
                        cbomoneda.SelectedValue = datacol.Rows(0)("cod_mon")
                        cbotipodoc.SelectedValue = datacol.Rows(0)("tip_doc")
                        cboAdq.SelectedIndex = datacol.Rows(0)("tipo_adq")
                        MfechaDE.Text = datacol.Rows(0)("fee_doc")
                        If datacol.Rows(0)("fev_doc") = "12:00:00 am" Then
                            MfechaDV.Text = ""
                        Else
                            MfechaDV.Text = datacol.Rows(0)("fev_doc")
                        End If
                        entCom.ruc = txtRuc.Text
                        lblRazonSocial.Text = compBL.comprobante_razon_social(entCom)
                    Else
                        MessageBox.Show("Solo Numeros Menores")
                        txtnumcompro.Text = numerocompro
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        Else
            e.Handled = True
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

    Private Sub cbomoneda_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cboAdq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboAdq.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbotipodoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbotipodoc.KeyPress
        e.Handled = True
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
        entCom.ruc = txtRuc.Text
        lblRazonSocial.Text = compBL.comprobante_razon_social(entCom)
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiarComprobante()
        gvtb.Clear()
        For i As Integer = 0 To 5
            gvtb.Rows.Add()
        Next
        gvComprobante.DataSource = gvtb
        cargarComprobante()
        btnguardar.Text = "Guardar"
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiarComprobante()
        gvComprobante.DataSource = Nothing
        gvComprobante.Rows.Clear()
        llenarCeldasDGV()
    End Sub

    Private Sub CboPeriodo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboPeriodo.KeyPress
        e.Handled = True
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
            Me.ErrorIcon.SetError(sender, "Ingrese el Ruc del Proveedor")
        End If
    End Sub
    Private Sub txtnumcompro_Leave(sender As Object, e As EventArgs) Handles txtnumcompro.Leave
        Dim NCompro As Integer = Val(txtnumcompro.Text)
        txtnumcompro.Text = NCompro.ToString("D4")
        If NCompro > numerocompro Or NCompro = 0 Then
            MessageBox.Show("Numero no Valido")
            txtnumcompro.Text = numerocompro
        End If
    End Sub
End Class