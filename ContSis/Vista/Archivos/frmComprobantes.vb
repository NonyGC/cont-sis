Imports Controladores
Imports Capa_Entidad
Imports Vista.Base
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
        bloquear_filas()
        dat = compBL.comprobante_mostrar_auxiliar()
        For i As Integer = 0 To dat.Rows.Count - 1
            coll.Add(dat.Rows(i)("ruc").ToString)
        Next
        txtRuc.AutoCompleteCustomSource = coll


        cboAdq.SelectedIndex = 0
        CboPeriodo.DataSource = datetimeFormat.MonthNames()
        CboPeriodo.SelectedItem = datetimeFormat.GetMonthName(Date.Today.Month)
        dtpFechae.MaxDate = Date.Today
    End Sub

    Sub cargarComprobante()
        numerodiario = Mid(compBL.comprobante_diario_autogenerado(), 3, 5)
        numerocompro = Mid(compBL.comprobante_registro_autogenerado(), 3, 4)
        entCom.nrodiario = numerodiario
        txtnumcompro.Text = numerocompro
        llenarCeldasDGV()
    End Sub
    Sub llenarCeldasDGV()
        If gvComprobante.Rows.Count < 3 Then
            For I As Integer = 0 To 5
                gvComprobante.Rows.Add()
            Next
        End If
        For i As Integer = 0 To 2
            gvcajabanco.Rows.Add()
        Next
    End Sub
    Sub bloquear_filas()
        For I As Integer = 1 To gvComprobante.Rows.Count - 1
            gvComprobante.Rows(I).ReadOnly = True
            gvComprobante.Rows(I).DefaultCellStyle.BackColor = Color.WhiteSmoke
        Next
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
        dtpFechae.ResetText()
        dtpFechav.ResetText()
    End Sub

    Private Sub gvComprobante_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles gvComprobante.EditingControlShowing
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
                        col.Add(datacol.Rows(i)("alias").ToString)
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
        Dim cuentaalias As String = gvComprobante.CurrentRow.Cells(2).Value
        Dim cuentan As String
        Dim nombrec As String
        If gvComprobante.CurrentCell.ColumnIndex = 1 Then
            Try
                cuentan = Trim(Mid(cuenta, 1, InStr(cuenta, " ")))
                nombrec = Trim(Mid(cuenta, InStr(cuenta, " "), cuenta.Length))
                If cuentan.Length >= 6 Then
                    gvComprobante.CurrentRow.Cells(1).Value = cuentan
                    gvComprobante.CurrentRow.Cells(2).Value = nombrec
                Else
                    MessageBox.Show("Ingrese Cuenta de 6 a mas digitos")
                End If
                If gvComprobante.CurrentRow.Index = 0 Then
                    gvComprobante.CurrentRow.Cells(4).Value = "0.00"
                    gvComprobante.CurrentRow.Cells(5).Value = "0.00"
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf gvComprobante.CurrentCell.ColumnIndex = 2 Then

            cuentan = Trim(Mid(cuentaalias, InStrRev(cuentaalias, " ") + 1, 6))
            nombrec = Trim(Mid(cuentaalias, 1, InStrRev(cuentaalias, " ")))

            gvComprobante.CurrentRow.Cells(1).Value = cuentan
            gvComprobante.CurrentRow.Cells(2).Value = nombrec
            If gvComprobante.CurrentRow.Index = 0 Then
                gvComprobante.CurrentRow.Cells(4).Value = "0.00"
                gvComprobante.CurrentRow.Cells(5).Value = "0.00"
            End If
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
                    If debe - haber < 0 Then
                        gvComprobante.Item(4, gvComprobante.CurrentRow.Index + 1).Value = Convert.ToDecimal(((debe - haber) * -1).ToString("N"))
                        gvComprobante.Item(5, gvComprobante.CurrentRow.Index + 1).Value = "0.00"
                        gvComprobante.Item(3, gvComprobante.CurrentRow.Index + 1).Value = entCom.glosa
                        ActivarFila(gvComprobante.CurrentRow.Index + 1)
                    ElseIf debe <> haber Then
                        gvComprobante.Item(5, gvComprobante.CurrentRow.Index + 1).Value = Convert.ToDecimal((debe - haber).ToString("N"))
                        gvComprobante.Item(4, gvComprobante.CurrentRow.Index + 1).Value = "0.00"
                        gvComprobante.Item(3, gvComprobante.CurrentRow.Index + 1).Value = entCom.glosa
                        ActivarFila(gvComprobante.CurrentRow.Index + 1)
                    End If
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
                    If haber - debe < 0 Then
                        gvComprobante.Item(5, gvComprobante.CurrentRow.Index + 1).Value = Convert.ToDecimal(((haber - debe) * -1).ToString("N"))
                        gvComprobante.Item(4, gvComprobante.CurrentRow.Index + 1).Value = "0.00"
                        gvComprobante.Item(3, gvComprobante.CurrentRow.Index + 1).Value = entCom.glosa
                        ActivarFila(gvComprobante.CurrentRow.Index + 1)
                    ElseIf debe <> haber Then
                        gvComprobante.Item(4, gvComprobante.CurrentRow.Index + 1).Value = Convert.ToDecimal((haber - debe).ToString("N"))
                        gvComprobante.Item(5, gvComprobante.CurrentRow.Index + 1).Value = "0.00"
                        gvComprobante.Item(3, gvComprobante.CurrentRow.Index + 1).Value = entCom.glosa
                        ActivarFila(gvComprobante.CurrentRow.Index + 1)
                    End If

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        gvComprobante.Rows(e.RowIndex).ErrorText = String.Empty
    End Sub
    Sub ActivarFila(I As Integer)
        gvComprobante.Rows(I).ReadOnly = False
        gvComprobante.Rows(I).DefaultCellStyle.BackColor = Color.White
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If Me.ValidateChildren And txtnumcompro.Text <> String.Empty And txtDserie.Text <> String.Empty And txtDnumero.Text <> String.Empty And txtRuc.Text <> String.Empty And dtpFechae.Checked Then

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
                    If dtpFechav.Checked = False Then
                        .fechav = ""
                    ElseIf dtpFechav.Checked = True Then
                        .fechav = Format(dtpFechav.Value.Date, "yyy/MM/dd")
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
                bloquear_filas()
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
                        entCom.nrodiario = datacol.Rows(0)("num_dia")
                        txtDnumero.Text = datacol.Rows(0)("num_doc")
                        txtDserie.Text = datacol.Rows(0)("ser_doc")
                        txtRuc.Text = datacol.Rows(0)("ruc_aux")
                        CboPeriodo.SelectedItem = datacol.Rows(0)("periodo")
                        cbomoneda.SelectedValue = datacol.Rows(0)("cod_mon")
                        cbotipodoc.SelectedValue = datacol.Rows(0)("tip_doc")
                        cboAdq.SelectedIndex = datacol.Rows(0)("tipo_adq")
                        dtpFechae.ResetText()
                        dtpFechav.ResetText()
                        dtpFechae.Value = datacol.Rows(0)("fee_doc")
                        If datacol.Rows(0)("fev_doc") <> "12:00:00 am" Then
                            dtpFechav.Value = datacol.Rows(0)("fev_doc")
                        End If

                        entCom.ruc = txtRuc.Text
                        lblRazonSocial.Text = compBL.comprobante_razon_social(entCom)
                        entCom.glosa = ""
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

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiarComprobante()
        gvtb.Clear()
        For i As Integer = 0 To 5
            gvtb.Rows.Add()
        Next
        gvComprobante.DataSource = gvtb
        cargarComprobante()
        bloquear_filas()
        btnguardar.Text = "Guardar"
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiarComprobante()
        gvComprobante.DataSource = Nothing
        gvComprobante.Rows.Clear()
        llenarCeldasDGV()
        bloquear_filas()
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

    Private Sub txtRuc_TextChanged(sender As Object, e As EventArgs) Handles txtRuc.TextChanged
        entCom.ruc = txtRuc.Text
        lblRazonSocial.Text = compBL.comprobante_razon_social(entCom)
    End Sub

    Private Sub cbomoneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbotipodoc.KeyPress, cbomoneda.KeyPress, cboAdq.KeyPress, CboPeriodo.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtRuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRuc.KeyPress, txtDserie.KeyPress, txtDnumero.KeyPress
        Solo_numeros(e)
    End Sub

    Private Sub gvComprobante_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles gvComprobante.CellValidating
        Dim header As String = gvComprobante.Columns(e.ColumnIndex).HeaderText
        'Dim row As DataGridViewRow = gvComprobante.CurrentRow
        'Dim cell As DataGridViewCell = gvComprobante.CurrentCell
        'Dim glosa As Object = cell(e)
        'If ((Convert.ToString(glosa) = String.Empty)) Then
        '    gvComprobante.Rows(e.RowIndex).ErrorText = "Ingresar Glosa"
        '    e.Cancel = True
        'End If


        'If String.IsNullOrEmpty(e.FormattedValue.ToString) Then
        '    gvComprobante.Rows(e.RowIndex).ErrorText = "hola"
        '    e.Cancel = True
        'End If

    End Sub
End Class