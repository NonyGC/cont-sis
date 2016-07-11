Imports Controladores
Imports Capa_Entidad
Imports Vista.Base
Imports Vista.BaseForm
Imports Transitions
Public Class frmComprobantes
    Dim compBL As New ComprobanteBL
    Dim entCom As New Comprobante
    Dim datacol As New DataTable

    Dim numerodiario As String
    Dim numerocompro As String
    Dim datetimeFormat = Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat
    Dim gvtb As New DataTable
    Dim _t As Transition = New Transitions.Transition(New TransitionType_EaseInEaseOut(500))
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
        CboPeriodo.SelectedItem = datetimeFormat.GetMonthName(Date.Today.Month)
        For Each column As DataGridViewColumn In gvComprobante.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim tabla As New DataTable
        tabla.Columns.Add("Numero", Type.GetType("System.Object"))
        tabla.Columns.Add("Descripcion", Type.GetType("System.Object"))
        tabla.Rows.Add("05", "Libro Diario")
        tabla.Rows.Add("08", "Registo de Compras")
        tabla.Rows.Add("14", "Registro de Ventas")
        tabla.Rows.Add("01", "Libro Caja y Bancos")
        CboTipolibro.DisplayMember = "Descripcion"
        CboTipolibro.ValueMember = "Numero"
        CboTipolibro.DataSource = tabla
        'toolstrip
        stripbuttons(ToolStrip1)
    End Sub

    Sub cargarComprobante()
        numerodiario = Mid(compBL.comprobante_diario_autogenerado(), 3, 5)
        txtnumdiario.Text = numerodiario
        llenarCeldasDGV()
    End Sub
    Sub llenarCeldasDGV()
        If gvComprobante.Rows.Count < 3 Then
            For I As Integer = 0 To 8
                gvComprobante.Rows.Add()
            Next
        End If
    End Sub

    Sub limpiarComprobante()
        cbomoneda.SelectedIndex = 0
        cbotipodoc.SelectedIndex = 0
        lblRazonSocial.Text = "Razón Social"
        txtRuc.Clear()
        txtDserie.Clear()
        txtDnumero.Clear()
        'CboPeriodo.SelectedItem = datetimeFormat.GetMonthName(Date.Today.Month)
        txtdiav.Clear()
        txtmesv.Clear()
        txtañov.Clear()
    End Sub
    Private WithEvents txtDecimal As New DataGridViewTextBoxEditingControl
    Private WithEvents txtglosa As New DataGridViewTextBoxEditingControl
    Private WithEvents txtnumerocuenta As New DataGridViewTextBoxEditingControl
    Private WithEvents txtnombrecuenta As New DataGridViewTextBoxEditingControl
    Private Sub gvComprobante_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles gvComprobante.EditingControlShowing
        Dim ColumnIndex As Integer = gvComprobante.CurrentCell.ColumnIndex
        Dim col As New AutoCompleteStringCollection

        If ColumnIndex = 1 Then
            RemoveHandler txtnombrecuenta.KeyPress, AddressOf txtnombrecuenta_KeyPress
            RemoveHandler txtglosa.KeyPress, AddressOf txtglosa_KeyPress
            RemoveHandler txtDecimal.KeyPress, AddressOf txtNumeric_KeyPress
            txtnumerocuenta = CType(gvComprobante.EditingControl, DataGridViewTextBoxEditingControl)
            If txtnumerocuenta IsNot Nothing Then
                Try
                    datacol = compBL.comprobante_Cuenta()
                    For i As Integer = 0 To datacol.Rows.Count - 1
                        col.Add(datacol.Rows(i)("Cuenta").ToString)
                    Next
                    txtnumerocuenta.AutoCompleteSource = AutoCompleteSource.CustomSource
                    txtnumerocuenta.AutoCompleteCustomSource = col
                    txtnumerocuenta.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf ColumnIndex = 2 Then
            RemoveHandler txtnumerocuenta.KeyPress, AddressOf txtnumerocuenta_KeyPress
            RemoveHandler txtglosa.KeyPress, AddressOf txtglosa_KeyPress
            RemoveHandler txtDecimal.KeyPress, AddressOf txtNumeric_KeyPress
            txtnombrecuenta = CType(gvComprobante.EditingControl, DataGridViewTextBoxEditingControl)
            If txtnombrecuenta IsNot Nothing Then
                Try
                    datacol = compBL.comprobante_Cuenta_n()
                    For i As Integer = 0 To datacol.Rows.Count - 1
                        col.Add(datacol.Rows(i)("alias").ToString)
                    Next
                    txtnombrecuenta.AutoCompleteSource = AutoCompleteSource.CustomSource
                    txtnombrecuenta.AutoCompleteCustomSource = col
                    txtnombrecuenta.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf ColumnIndex = 4 Or ColumnIndex = 5 Then
            RemoveHandler txtnumerocuenta.KeyPress, AddressOf txtnumerocuenta_KeyPress
            RemoveHandler txtnombrecuenta.KeyPress, AddressOf txtnombrecuenta_KeyPress
            RemoveHandler txtglosa.KeyPress, AddressOf txtglosa_KeyPress
            txtDecimal = CType(gvComprobante.EditingControl, DataGridViewTextBoxEditingControl)
            txtnumerocuenta.AutoCompleteCustomSource = Nothing
            txtnombrecuenta.AutoCompleteCustomSource = Nothing
        ElseIf ColumnIndex = 3 Then
            RemoveHandler txtnumerocuenta.KeyPress, AddressOf txtnumerocuenta_KeyPress
            RemoveHandler txtnombrecuenta.KeyPress, AddressOf txtnombrecuenta_KeyPress
            RemoveHandler txtDecimal.KeyPress, AddressOf txtNumeric_KeyPress
            txtglosa = CType(gvComprobante.EditingControl, DataGridViewTextBoxEditingControl)
            txtnumerocuenta.AutoCompleteCustomSource = Nothing
            txtnombrecuenta.AutoCompleteCustomSource = Nothing
        End If
    End Sub
    Private Sub txtnumerocuenta_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtnumerocuenta.KeyPress
        Dim fila As Integer = gvComprobante.CurrentRow.Index
        If fila = 0 Then
            Solo_numeros(e)
        Else
            If gvComprobante.Item(1, fila - 1).Value IsNot Nothing Then

                'If gvComprobante.Item(4, fila - 1).Value.ToString <> gvComprobante.Item(5, fila - 1).Value.ToString Then
                '    Solo_numeros(e)
                'Else
                '    e.Handled = True
                '    MessageBox.Show("Completar Datos de La fila Anterior ", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'End If
            Else
                e.Handled = True
                MessageBox.Show("Ingrese la fila anterior ", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub txtnombrecuenta_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtnombrecuenta.KeyPress
        Dim fila As Integer = gvComprobante.CurrentRow.Index
        If fila = 0 Then
            Solo_Letras(e)
        Else
            If gvComprobante.Item(1, fila - 1).Value <> Nothing Then
                If gvComprobante.Item(4, fila - 1).Value IsNot Nothing Or gvComprobante.Item(5, fila - 1).Value IsNot Nothing Then
                    Solo_Letras(e)
                Else
                    e.Handled = True
                    MessageBox.Show("Completar Datos de La fila Anterior ", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                e.Handled = True
                MessageBox.Show("Ingrese Primero la Cuenta ", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub txtglosa_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtglosa.KeyPress
        If gvComprobante.CurrentRow.Cells(1).Value Is Nothing Then
            MessageBox.Show("Ingrese Primero la Cuenta ", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub txtNumeric_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtDecimal.KeyPress
        If gvComprobante.CurrentRow.Cells(1).Value = Nothing Then
            MessageBox.Show("Ingrese Primero la Cuenta ", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        Else
            e.Handled = Fg_SoloNumeros(e.KeyChar, txtDecimal.Text & CChar(e.KeyChar))
        End If
    End Sub
    Sub celdaDecimal(col1 As Integer, col2 As Integer)
        Dim Val As Decimal
        Dim columna As Object = gvComprobante.CurrentRow.Cells(col1).Value
        If columna IsNot DBNull.Value And columna IsNot Nothing Then
            If columna.ToString <> "" Then
                Val = Convert.ToDecimal(columna)
                gvComprobante.CurrentRow.Cells(col1).Value = Val.ToString("N")
                gvComprobante.CurrentRow.Cells(col2).Value = DBNull.Value
            End If
        End If
    End Sub
    Sub debehaber()
        Dim deb As Decimal = 0
        Dim hab As Decimal = 0
        Dim resul As Decimal
        Dim fila As Integer = 0
        For Each row As DataGridViewRow In gvComprobante.Rows
            If row.Cells(1).Value Is Nothing Or row.Cells(1).Value Is DBNull.Value Then Exit For
            If row.Cells(4).Value Is DBNull.Value Then
                deb += 0
            Else
                deb += row.Cells(4).Value
            End If
            If row.Cells(5).Value Is DBNull.Value Then
                hab += 0
            Else
                hab += row.Cells(5).Value
            End If
            fila += 1
        Next
        gvComprobante.Item(4, fila).Value = DBNull.Value
        gvComprobante.Item(5, fila).Value = DBNull.Value
        If deb > hab Then
            resul = deb - hab
            'If gvComprobante.Item(4, fila - 1).Value IsNot DBNull.Value Then
            gvComprobante.Item(5, fila).Value = resul.ToString("N")
            gvComprobante.Item(3, fila).Value = gvComprobante.CurrentRow.Cells(3).Value
            'Else
            '    gvComprobante.Item(5, fila - 1).Value = resul.ToString("N")
            '    gvComprobante.Item(3, fila - 1).Value = gvComprobante.CurrentRow.Cells(3).Value
            'End If
            tsbguardar.Enabled = False
        ElseIf hab > deb Then
            resul = hab - deb
            'If gvComprobante.Item(5, fila - 1).Value IsNot DBNull.Value Then
            gvComprobante.Item(4, fila).Value = resul.ToString("N")
            gvComprobante.Item(3, fila).Value = gvComprobante.CurrentRow.Cells(3).Value
            'Else
            '    gvComprobante.Item(4, fila - 1).Value = resul.ToString("N")
            '    gvComprobante.Item(3, fila - 1).Value = gvComprobante.CurrentRow.Cells(3).Value
            'End If
            tsbguardar.Enabled = False
        ElseIf hab = deb Then
            tsbguardar.Enabled = True
        End If
    End Sub
    Sub LimpiarEntidad()
        With entCom
            .periodo = Nothing
            .moneda = Nothing
            .tipo_adq = Nothing
            .tipo_doc = Nothing
            .ruc = Nothing
            .serie = Nothing
            .nrodiario = Nothing
            .nrodocu = Nothing
            .fechae = Nothing
            .fechav = Nothing
        End With
    End Sub

    Private Sub gvComprobante_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles gvComprobante.CellEndEdit
        'Try
        If gvComprobante.CurrentRow.Cells(1).Value IsNot Nothing Then
            Dim cuenta As Object = gvComprobante.CurrentRow.Cells(1).Value
            Dim cuentaalias As Object = gvComprobante.CurrentRow.Cells(2).Value
            Dim cuentan As String
            Dim nombrec As String
            Dim Columna As Integer = gvComprobante.CurrentCell.ColumnIndex

            If Columna = 1 Then
                If cuenta <> String.Empty And cuenta.Length > 6 Then
                    cuentan = Trim(Mid(cuenta, 1, InStr(cuenta, " ")))
                    nombrec = Trim(Mid(cuenta, InStr(cuenta, " "), cuenta.Length))
                    If cuentan.Length >= 6 Then
                        gvComprobante.CurrentRow.Cells(1).Value = cuentan
                        gvComprobante.CurrentRow.Cells(2).Value = nombrec
                        gvComprobante.CurrentRow.Cells(0).Value = ((gvComprobante.CurrentRow.Index + 1) * 10).ToString("D3")
                    Else
                        MessageBox.Show("Ingrese Cuenta de 6 a mas digitos")
                    End If
                Else
                    gvComprobante.CurrentRow.Cells(1).Value = DBNull.Value
                    gvComprobante.CurrentRow.Cells(2).Value = DBNull.Value
                End If
            ElseIf Columna = 2 Then
                If cuenta <> String.Empty Then
                    cuentan = Trim(Mid(cuentaalias, InStrRev(cuentaalias, " ") + 1, 6))
                    nombrec = Trim(Mid(cuentaalias, 1, InStrRev(cuentaalias, " ")))
                    gvComprobante.CurrentRow.Cells(1).Value = cuentan
                    gvComprobante.CurrentRow.Cells(2).Value = nombrec
                    gvComprobante.CurrentRow.Cells(0).Value = ((gvComprobante.CurrentRow.Index + 1) * 10).ToString("D3")
                Else
                    gvComprobante.CurrentRow.Cells(1).Value = DBNull.Value
                    gvComprobante.CurrentRow.Cells(2).Value = DBNull.Value
                End If
            End If
            If gvComprobante.CurrentRow.Index <> 0 Then
                If Columna = 1 Or Columna = 2 Then
                    debehaber()
                End If
            End If
            If gvComprobante.CurrentCell.ColumnIndex = 4 Or gvComprobante.CurrentCell.ColumnIndex = 5 Then
                Dim col4 As Object = gvComprobante.CurrentRow.Cells(4).Value
                Dim col5 As Object = gvComprobante.CurrentRow.Cells(5).Value
                If Columna = 4 And col4 IsNot DBNull.Value And col4 IsNot Nothing Then
                    If col4.ToString <> String.Empty Then
                        celdaDecimal(4, 5)
                        debehaber()
                    Else
                        gvComprobante.CurrentRow.Cells(4).Value = DBNull.Value
                    End If
                End If
                If Columna = 5 And col5 IsNot DBNull.Value And col5 IsNot Nothing Then
                    celdaDecimal(5, 4)
                    debehaber()
                Else
                End If
            End If
        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
    Sub detalle_CRU(button As String)
        For Each row As DataGridViewRow In gvComprobante.Rows
            If row.Cells(1).Value Is Nothing Or row.Cells(1).Value Is DBNull.Value Then Exit For
            With entCom
                .nrodetalle = row.Cells(0).Value
                .cuenta = row.Cells(1).Value
                .glosa = row.Cells(3).Value
                .debe = row.Cells(4).Value
                .haber = row.Cells(5).Value
            End With

            If Mid(row.Cells(1).Value, 1, 3) = "421" And CboTipolibro.SelectedValue = "08" Then entCom.importe_total = row.Cells(5).Value
            If Mid(row.Cells(1).Value, 1, 4) = "4011" And CboTipolibro.SelectedValue = "08" Then
                If cboAdq.SelectedIndex = 0 Then
                    entCom.igv1 = row.Cells(4).Value
                    entCom.baseimpo1 = entCom.importe_total - entCom.igv1
                ElseIf cboAdq.SelectedIndex = 1 Then
                    entCom.igv2 = row.Cells(4).Value
                    entCom.baseimpo2 = entCom.importe_total - entCom.igv2
                ElseIf cboAdq.SelectedIndex = 2 Then
                    entCom.igv3 = row.Cells(4).Value
                    entCom.baseimpo3 = entCom.importe_total - entCom.igv3
                End If
            End If
            compBL.comprobante_detalle_CRU(entCom)
        Next

        compBL.registro_compra_CRU(entCom)
        gvtb.Clear()
        For i As Integer = 0 To 8
            gvtb.Rows.Add()
        Next
        gvComprobante.DataSource = gvtb
        limpiarComprobante()
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles tsbguardar.Click
        'Try
        If CboTipolibro.SelectedValue = "08" Or CboTipolibro.SelectedValue = "14" Then
            With entCom
                .periodo = CboPeriodo.Text
                .moneda = cbomoneda.SelectedValue
                .tipo_adq = cboAdq.SelectedIndex
                .tipo_doc = cbotipodoc.SelectedValue
                .ruc = txtRuc.Text
                .razonsocial = lblRazonSocial.Text
                .serie = txtDserie.Text
                .nrodocu = txtDnumero.Text
                .fechae = Format(CDate(txtaño.Text + "/" + txtmes.Text + "/" + txtdia.Text), "yyy/MM/dd")
                Dim fechav As String = txtañov.Text + "/" + txtmesv.Text + "/" + txtdiav.Text
                If fechav.Length = 10 Then
                    .fechav = Format(CDate(txtañov.Text + "/" + txtmesv.Text + "/" + txtdiav.Text), "yyy/MM/dd")
                Else
                    .fechav = ""
                End If
                .estado = 1
            End With
            If tsbguardar.Text = "Guardar" Then
                With entCom
                    .nrodiario = compBL.comprobante_diario_autogenerado()
                    .nrocompro = compBL.comprobante_autogenerado_registro(CboTipolibro.SelectedValue)
                End With
                Dim affected As Integer = compBL.comprobante_cabecera_CRU(entCom)
                If affected = 1 Then
                    detalle_CRU("Guardar")
                    MessageBox.Show("SE REGISTRO CORRECTAMENTE" + vbCr + "Nº Diario  [" + entCom.nrodiario + "]" + vbCr +
                                 "Nº Comprobante  [" + entCom.nrocompro + "]")
                Else
                    MessageBox.Show("NO SE REGISTRO EL COMPROBANTE")
                End If
            ElseIf tsbguardar.Text = "Actualizar" Then
                With entCom
                    .nrodiario = "05" & txtnumdiario.Text
                End With
                Dim affected As Integer = compBL.comprobante_cabecera_CRU(entCom)
                MessageBox.Show(affected)
                If affected = 2 Then
                    detalle_CRU("Actualizar")
                    MessageBox.Show("SE ACTUALIZO CORRECTAMENTE" + vbCr + vbCr + "Nº Diario  [" + entCom.nrodiario + "]" + vbCr +
                                 "Nº Comprobante  [" + entCom.nrocompro + "]")
                Else
                    MessageBox.Show("NO SE ACTUALIZO EL COMPROBANTE")
                End If
            End If
            cargarComprobante()
        End If
        If CboTipolibro.SelectedValue = "05" Or CboTipolibro.SelectedValue = "01" Then
            LimpiarEntidad()
            With entCom
                .periodo = CboPeriodo.Text
                .moneda = cbomoneda.SelectedValue
                .fechae = Format(CDate(txtaño.Text + "/" + txtmes.Text + "/" + txtdia.Text), "yyy/MM/dd")
                .estado = 1
                .nrocompro = ""
            End With
            If tsbguardar.Text = "Guardar" Then
                With entCom
                    .nrodiario = compBL.comprobante_diario_autogenerado()
                    If CboTipolibro.SelectedValue = "01" Then
                        .nrocompro = compBL.comprobante_autogenerado_registro(CboTipolibro.SelectedValue)
                    Else
                        .nrocompro = Nothing
                    End If
                End With
                Dim affected As Integer = compBL.comprobante_cabecera_CRU(entCom)
                If affected = 1 Then
                    detalle_CRU("Guardar")
                    MessageBox.Show("SE REGISTRO CORRECTAMENTE" + vbCr + "Nº Diario  [" + entCom.nrodiario + "]" + vbCr +
                                 "Nº Comprobante  [" + entCom.nrocompro + "]")
                Else
                    MessageBox.Show("NO SE REGISTRO EL COMPROBANTE")
                End If
            ElseIf tsbguardar.Text = "Actualizar" Then

                With entCom
                    .nrodiario = "05" & txtnumdiario.Text
                End With
                Dim affected As Integer = compBL.comprobante_cabecera_CRU(entCom)
                If affected = 2 Then
                    detalle_CRU("Actualizar")
                    MessageBox.Show("SE ACTUALIZO CORRECTAMENTE" + vbCr + vbCr + "Nº Diario  [" + entCom.nrodiario + "]" + vbCr +
                                 "Nº Comprobante  [" + entCom.nrocompro + "]")
                Else
                    MessageBox.Show("NO SE ACTUALIZO EL COMPROBANTE")
                End If
            End If
            cargarComprobante()
        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
    Private Sub txtnumdiario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumdiario.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If Asc(e.KeyChar) = 13 Then
                'Try
                tsbguardar.Text = "Actualizar"
                btnlimpiar.Enabled = False
                tsbcancelar.Enabled = True
                Dim Ndiario As Integer = Val(txtnumdiario.Text)
                txtnumdiario.Text = Ndiario.ToString("D5")

                If Ndiario <> numerodiario And Ndiario < numerodiario Then
                    entCom.nrodiario = "05" + txtnumdiario.Text
                    gvtb = compBL.Comprobante_detalle_llenar(entCom)
                    gvComprobante.DataSource = gvtb
                    For i As Integer = 0 To 8 - gvtb.Rows.Count
                        gvtb.Rows.Add()
                    Next

                    datacol = compBL.Comprobante_cebecera_llenar(entCom)
                    Dim num_reg As String = datacol.Rows(0)("num_reg").ToString
                    num_reg = Mid(num_reg, 1, 2)
                    If num_reg = "" Then
                        num_reg = "05"
                    End If
                    CboTipolibro.SelectedValue = num_reg
                    CboTipolibro.Enabled = False
                    If num_reg = "08" Or num_reg = "14" Then
                        txtDnumero.Text = datacol.Rows(0)("num_doc")
                        txtDserie.Text = datacol.Rows(0)("ser_doc")
                        txtRuc.Text = datacol.Rows(0)("ruc_aux")
                        cbotipodoc.SelectedValue = datacol.Rows(0)("tip_doc")
                        cboAdq.SelectedIndex = datacol.Rows(0)("tipo_adq")
                        Dim fechav As Object = datacol.Rows(0)("fev_doc")
                        If datacol.Rows(0)("fev_doc") <> "12:00:00 am." And fechav IsNot DBNull.Value Then
                            txtdiav.Text = Mid(fechav, 1, 2)
                            txtmesv.Text = Mid(fechav, 4, 2)
                            txtañov.Text = Mid(fechav, 7, 4)
                        End If
                        entCom.ruc = txtRuc.Text
                        lblRazonSocial.Text = compBL.comprobante_razon_social(entCom)
                    End If
                    entCom.nrodiario = datacol.Rows(0)("num_dia").ToString
                    entCom.nrocompro = datacol.Rows(0)("num_reg").ToString
                    CboPeriodo.SelectedItem = datacol.Rows(0)("periodo")
                    cbomoneda.SelectedValue = datacol.Rows(0)("cod_mon")
                    Dim fecha As String = datacol.Rows(0)("fee_doc")
                    txtdia.Text = Mid(fecha, 1, 2)
                    txtmes.Text = Mid(fecha, 4, 2)
                    txtaño.Text = Mid(fecha, 7, 4)

                Else
                    MessageBox.Show("Solo Numeros Menores")
                    txtnumdiario.Text = numerodiario
                End If
                'Catch ex As Exception
                '    MessageBox.Show(ex.Message)
                'End Try

            End If
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub tsbcancelar_Click(sender As Object, e As EventArgs) Handles tsbcancelar.Click
        limpiarComprobante()
        gvComprobante.Refresh()
        gvtb.Clear()
        CboTipolibro.Enabled = True
        For i As Integer = 0 To 8
            gvtb.Rows.Add()
        Next
        gvComprobante.DataSource = gvtb
        cargarComprobante()
        tsbguardar.Text = "Guardar"
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiarComprobante()
        gvComprobante.DataSource = Nothing
        gvComprobante.Rows.Clear()
        llenarCeldasDGV()
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
    Private Sub txtnumcompro_Leave(sender As Object, e As EventArgs) Handles txtnumdiario.Leave
        Dim Ndiario As Integer = Val(txtnumdiario.Text)
        txtnumdiario.Text = Ndiario.ToString("D5")
        If Ndiario > numerodiario Or Ndiario = 0 Then
            MessageBox.Show("Numero no Valido")
            txtnumdiario.Text = numerodiario
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
        Dim txt As TextBox = DirectCast(sender, TextBox)
        If txt IsNot Nothing Then
            If txt.Name <> "" Then
                Solo_numeros(e)
            End If
        End If
    End Sub
    Private Sub gvComprobante_Click(sender As Object, e As EventArgs) Handles gvComprobante.Click
        If CboTipolibro.SelectedValue = "08" Or CboTipolibro.SelectedValue = "14" Then
            If txtaño.Text <> "" And txtnumdiario.Text <> "" And txtDserie.Text <> "" And txtDnumero.Text <> "" And txtRuc.Text <> "" And txtdia.Text <> "" And txtmes.Text <> "" Then
            Else
                MessageBox.Show("INGRESE TODO LOS DATOS", "comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        If CboTipolibro.SelectedValue = "01" Or CboTipolibro.SelectedValue = "05" Then
            If txtnumdiario.Text <> "" And txtdia.Text <> "" And txtmes.Text <> "" And txtaño.Text <> "" Then
            Else
                MessageBox.Show("INGRESE TODO LOS DATOS", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles tsbsalir.Click
        Me.Close()
    End Sub

    Private Sub txtdia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdia.KeyPress, txtdiav.KeyPress, txtmes.KeyPress, txtaño.KeyPress, txtmesv.KeyPress, txtañov.KeyPress
        Solo_numeros(e)
    End Sub
    Private Sub txtmes_Leave(sender As Object, e As EventArgs) Handles txtmes.Leave, txtmesv.Leave, txtdia.Leave, txtdiav.Leave
        If DirectCast(sender, TextBox).Text <> "" Then
            DirectCast(sender, TextBox).Text = Completar_D(sender, "D2")
        End If
    End Sub
    Function Completar_D(sender As Object, D As String) As String
        Dim valor As String = Convert.ToInt64(DirectCast(sender, TextBox).Text).ToString(D)
        Return valor
    End Function

    Private Sub txtdia_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdia.Validating
        If DirectCast(sender, TextBox).Text <> String.Empty Then
            If Today.Month = txtmes.Text Then
                If Today.Day >= txtdia.Text Then
                    validar_fecha(sender, 31, e, "DIA NO VALIDO")
                Else
                    MessageBox.Show("NO SE PERMITE INGRESAR DIA A FUTURO")
                    e.Cancel = True
                End If
            Else
                validar_fecha(sender, 31, e, "DIA NO VALIDO")
            End If
        Else
            MessageBox.Show("INGRESE EL DIA")
            e.Cancel = True
        End If
        If IsDate(txtaño.Text + "/" + txtmes.Text + "/" + txtdia.Text) = False Then
            MessageBox.Show("DIA NO VALIDO EN ESTE MES")
            e.Cancel = True
        End If

    End Sub
    Private Sub txtmes_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtmes.Validating
        If DirectCast(sender, TextBox).Text <> String.Empty Then
            If CboPeriodo.Text = datetimeFormat.GetMonthName(txtmes.Text) Then
                validar_fecha(sender, 12, e, "MES NO VALIDO")
            Else
                MessageBox.Show("EL MES INGRESADO NO ESTA DENTRO DEL PERIODO")
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub
    Sub validar_fecha(sen As Object, max As Integer, e As System.ComponentModel.CancelEventArgs, mensaje As String)
        If Val(DirectCast(sen, TextBox).Text) > max Or Val(DirectCast(sen, TextBox).Text) = 0 Then
            e.Cancel = True
            MessageBox.Show(mensaje)
        End If
    End Sub
    Private Sub txtaño_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtaño.Validating
        If Val(DirectCast(sender, TextBox).Text) > Today.Year Or Val(DirectCast(sender, TextBox).Text) < Today.Year - 5 Then
            e.Cancel = True
            MessageBox.Show("AÑO NO PERMITIDO")
        End If
    End Sub

    Private Sub txtaño_Leave(sender As Object, e As EventArgs) Handles txtaño.Leave, txtañov.Leave
        If DirectCast(sender, TextBox).Text <> "" And DirectCast(sender, TextBox).TextLength < 3 And DirectCast(sender, TextBox).TextLength > 0 Then
            Dim año As Integer = DirectCast(sender, TextBox).Text
            año = año + 2000
            DirectCast(sender, TextBox).Text = año
        End If
    End Sub

    Sub moControles(estado As Boolean)
        lbladquisiciones.Visible = estado
        pnlDocumento.Visible = estado
        cboAdq.Visible = estado
        grpRuc.Visible = estado
        pnlFechavenci.Visible = estado
    End Sub
    Private Sub CboTipolibro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTipolibro.SelectedIndexChanged
        CboPeriodo.Enabled = True
        If CboTipolibro.SelectedValue = "05" Or CboTipolibro.SelectedValue = "01" Then
            moControles(False)
        End If
        If CboTipolibro.SelectedValue = "08" Then

            moControles(True)
            cboAdq.Items.Clear()
            grpRuc.Text = "Proveedor"
            cboAdq.Items.Add("GRAVADAS Y/O DE EXPORTACIÓN")
            cboAdq.Items.Add("GRAVADAS Y/O DE EXPORTACIÓN Y A OPERACIONES NO GRAVADAS")
            cboAdq.Items.Add("OPERACIONES NO GRAVADAS")
            cboAdq.Items.Add("VALOR DE LAS ADQUISIONES NO GRAVADAS")
            cboAdq.SelectedIndex = 0
        End If
        If CboTipolibro.SelectedValue = "14" Then
            CboPeriodo.Enabled = False
            moControles(True)
            cboAdq.Items.Clear()
            grpRuc.Text = "Cliente"
            cboAdq.Items.Add("VALOR FACTURADO DE LA EXPORTACIÓN")
            cboAdq.Items.Add("BASE IMPONIBLE DE LA OPERACIÓN")
            cboAdq.Items.Add("VENTA EXONERADA")
            cboAdq.Items.Add("VENTA INAFECTA")
            cboAdq.SelectedIndex = 0
        End If
        lblTitulo.Text = CboTipolibro.Text
        limpiarComprobante()
    End Sub
    Private Sub CboPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPeriodo.SelectedIndexChanged
        If CboPeriodo.Text <> datetimeFormat.GetMonthName(Date.Today.Month) Then
            txtdia.Text = "01"
            txtmes.Text = (CboPeriodo.SelectedIndex + 1).ToString("D2")
            txtaño.Text = Today.Year
        Else
            txtdia.Text = Today.Day.ToString("D2")
            txtmes.Text = Today.Month.ToString("D2")
            txtaño.Text = Today.Year
        End If
    End Sub

    Private Sub txtdiav_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdiav.Validating
        If DirectCast(sender, TextBox).Text <> String.Empty Then
            validar_fecha(sender, 31, e, "DIA NO VALIDO")
            If IsDate(txtañov.Text + "/" + txtmesv.Text + "/" + txtdiav.Text) = False Then
                MessageBox.Show("DIA NO VALIDO EN ESTE MES")
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtmesv_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtmesv.Validating
        If DirectCast(sender, TextBox).Text <> String.Empty Then
            validar_fecha(sender, 12, e, "MES NO VALIDO")
        End If
    End Sub
    Private Sub gvComprobante_SelectionChanged(sender As Object, e As EventArgs) Handles gvComprobante.SelectionChanged
        'MessageBox.Show("FOCO")
    End Sub
End Class