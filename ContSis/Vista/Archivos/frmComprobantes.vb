Imports Controladores
Imports Capa_Entidad
Public Class frmComprobantes
    Dim compBL As New ComprobanteBL
    Dim entCom As New Comprobante
    Dim datacol As New DataTable

    Dim numerodiario As String
    Dim numerocompro As String
    Private Sub Frm_Comprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim dat As New DataTable
        'Dim coll As New AutoCompleteStringCollection
        ''gvComprobante.Rows.Add()
        ''Dim fila As Integer = gvComprobante.Rows.Count() - 1
        ''For i As Integer = 0 To gvComprobante.Columns.Count() - 1
        ''    gvComprobante.Item(i, fila).ReadOnly = True
        ''    gvComprobante.Rows(fila).DefaultCellStyle.BackColor = Color.Beige
        ''Next
        'cbomoneda.DataSource = compBL.comprobante_mostrar_moneda()
        'cbomoneda.DisplayMember = "Descripcion"
        'cbomoneda.ValueMember = "Codigo"
        'cbotipodoc.DataSource = compBL.comprobante_mostrar_tipodoc()
        'cbotipodoc.DisplayMember = "Descripcion"
        'cbotipodoc.ValueMember = "Numero"
        'dat = compBL.comprobante_mostrar_auxiliar()
        'For i As Integer = 0 To dat.Rows.Count - 1
        '    coll.Add(dat.Rows(i)("ruc").ToString)
        'Next
        'numerodiario = Mid(compBL.comprobante_diario_autogenerado(), 3, 5)
        'numerocompro = Mid(compBL.comprobante_registro_autogenerado(), 3, 4)
        'txtRuc.AutoCompleteCustomSource = coll
        'txtnumdiario.Text = numerodiario
        'entCom.nrodiario = txtnumdiario.Text
        'txtnumcompro.Text = numerocompro
        'For I As Integer = 0 To 99
        '    gvComprobante.Rows.Add()
        'Next

    End Sub

    Private Sub gvComprobante_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles gvComprobante.EditingControlShowing

        Dim col As New AutoCompleteStringCollection
        Dim autoText As TextBox = TryCast(e.Control, TextBox)

        If gvComprobante.CurrentCell.ColumnIndex = 0 Then
            If autoText IsNot Nothing Then
                Try
                    datacol = compBL.comprobante_Cuenta()
                    For i As Integer = 0 To datacol.Rows.Count - 1
                        col.Add(datacol.Rows(i)("codigo").ToString)
                    Next
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    autoText.AutoCompleteCustomSource = col
                    autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        ElseIf gvComprobante.CurrentCell.ColumnIndex = 1 Then
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

        Dim cuenta As String = gvComprobante.CurrentRow.Cells(0).Value
        If gvComprobante.CurrentCell.ColumnIndex = 0 Then
            Try
                If cuenta.Length > 6 Then
                    cuenta = Trim(Mid(cuenta, 1, InStr(cuenta, " ")))
                End If
                gvComprobante.CurrentRow.Cells(0).Value = cuenta
                entCom.cuenta = cuenta

                datacol = compBL.comprobante_cuenta_filtrar_nombre(entCom)
                If datacol.Rows.Count > 0 Then
                    For Each row As DataRow In datacol.Rows
                        gvComprobante.CurrentRow.Cells(1).Value = row(1).ToString
                    Next
                End If
                entCom.cuenta = ""
                gvComprobante.CurrentRow.Cells(2).Value = entCom.glosa
                '
                Dim debe As Double = gvComprobante.CurrentRow.Cells(3).Value
                Dim haber As Double = gvComprobante.CurrentRow.Cells(4).Value
                gvComprobante.CurrentRow.Cells(3).Value = debe.ToString("N")
                gvComprobante.CurrentRow.Cells(4).Value = haber.ToString("N")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

        If gvComprobante.CurrentCell.ColumnIndex = 2 Then
            entCom.glosa = gvComprobante.CurrentRow.Cells(2).Value
        End If

        If gvComprobante.CurrentCell.ColumnIndex = 3 Or gvComprobante.CurrentCell.ColumnIndex = 4 Then
            Dim debe As Double = gvComprobante.CurrentRow.Cells(3).Value
            Dim haber As Double = gvComprobante.CurrentRow.Cells(4).Value
            Dim n As Integer = 0
            gvComprobante.CurrentRow.Cells(3).Value = debe.ToString("N")
            gvComprobante.CurrentRow.Cells(4).Value = haber.ToString("N")

            For Each row As DataGridViewRow In gvComprobante.Rows
                If row.Cells(0).Value Is Nothing Then Exit For
                n += 1
            Next
            If gvComprobante.CurrentCell.ColumnIndex = 3 Then
                debe = 0
                haber = 0
                gvComprobante.CurrentRow.Cells(4).Value = "0.00"
                For Each row As DataGridViewRow In gvComprobante.Rows
                    If row.Cells(0).Value Is Nothing Then Exit For
                    debe += row.Cells(3).Value
                    haber += row.Cells(4).Value
                Next
                gvComprobante.Item(4, n).Value = (debe - haber).ToString("N")

            ElseIf gvComprobante.CurrentCell.ColumnIndex = 4 Then
                debe = 0
                haber = 0
                gvComprobante.CurrentRow.Cells(3).Value = "0.00"
                For Each row As DataGridViewRow In gvComprobante.Rows
                    If row.Cells(0).Value Is Nothing Then Exit For
                    debe += row.Cells(3).Value
                    haber += row.Cells(4).Value
                Next
                gvComprobante.Item(3, n).Value = (haber - debe).ToString("N")
            End If
        End If
    End Sub

    Private Sub txtRuc_Leave(sender As Object, e As EventArgs) Handles txtRuc.Leave
        entCom.ruc = txtRuc.Text
        lblRazonSocial.Text = compBL.comprobante_razon_social(entCom)
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim fechaDE As DateTime = Convert.ToDateTime(MfechaDE.Text)
        Dim fechaDV As DateTime = Convert.ToDateTime(MfechaDV.Text)
        With entCom
            .nrodiario = compBL.comprobante_diario_autogenerado()
            .periodo = Fperiodo.Text
            .nrocompro = compBL.comprobante_registro_autogenerado()
            .moneda = cbomoneda.SelectedValue
            .tipo_adq = cboAdq.SelectedIndex + 1
            .tipo_doc = cbotipodoc.SelectedValue
            .serie = txtDserie.Text
            .nrodocu = txtDnumero.Text
            .fechae = Format(fechaDE, "yyyy/MM/dd")
            .fechav = Format(fechaDV, "yyyy/MM/dd")
        End With
        compBL.comprobante_cabecera_register(entCom)
        For Each row As DataGridViewRow In gvComprobante.Rows
            If row.Cells(0).Value Is Nothing Then Exit For
            With entCom
                .nrodetalle = compBL.comprobante_detalle_autogenerado(entCom)
                .cuenta = row.Cells(0).Value
                .glosa = row.Cells(2).Value
                .debe = row.Cells(3).Value
                .haber = row.Cells(4).Value
            End With
            compBL.comprobante_detalle_register(entCom)
        Next
    End Sub

    Private Sub txtnumdiario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumdiario.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
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

    Private Sub txtRuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRuc.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cbomoneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbomoneda.KeyPress
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
            ToolTip1.ToolTipTitle = "Fecha invalida"
            ToolTip1.Show("fecha válida en el formato dd/mm/aaaa", MfechaDE, 0, -20, 5000)
        Else
            Dim UserDate As DateTime = CDate(e.ReturnValue)
            If (UserDate > DateTime.Now) Then
                ToolTip1.ToolTipTitle = "Fecha invalida"
                ToolTip1.Show("La fecha en este campo debe ser menor que la fecha de hoy.", MfechaDE, 0, -20, 2000)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub MfechaDV_TypeValidationCompleted(sender As Object, e As TypeValidationEventArgs) Handles MfechaDV.TypeValidationCompleted
        If (Not e.IsValidInput) Then
            ToolTip1.ToolTipTitle = "Fecha invalida"
            ToolTip1.Show("fecha válida en el formato dd/mm/aaaa", MfechaDV, 0, -20, 5000)
        Else
            Dim UserDate As DateTime = CDate(e.ReturnValue)
            If (UserDate > DateTime.Now) Then
                ToolTip1.ToolTipTitle = "Fecha invalida"
                ToolTip1.Show("La fecha en este campo debe ser menor que la fecha de hoy.", MfechaDV, 0, -20, 2000)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtnumdiario_Leave(sender As Object, e As EventArgs) Handles txtnumdiario.Leave
        Dim Ndiario As Integer = Val(txtnumdiario.Text)
        txtnumdiario.Text = Ndiario.ToString("D5")
        If Ndiario > numerodiario Then
            MessageBox.Show("Solo Numeros Menores")
            txtnumdiario.Text = numerodiario
        End If
    End Sub

    Private Sub txtnumcompro_Leave(sender As Object, e As EventArgs) Handles txtnumcompro.Leave
        Dim Ncompro As Integer = Val(txtnumcompro.Text)
        txtnumcompro.Text = Ncompro.ToString("D4")
        If Ncompro > numerocompro Then
            MessageBox.Show("Solo Numeros Menores")
            txtnumcompro.Text = numerocompro
        End If
        Dim tbl As New DataTable
        entCom.nrocompro = "08" + txtnumcompro.Text
        compBL.Comprobante_cebecera_llenar(entCom)
        compBL.Comprobante_detalle_llenar(entCom)
        gvComprobante.DataSource = compBL.Comprobante_detalle_llenar(entCom)
        'gvComprobante.Bounds()
        'gvComprobante.DataBindings

        datacol = compBL.Comprobante_cebecera_llenar(entCom)
        txtDnumero.Text = datacol.Rows(0)("num_doc")
        txtDserie.Text = datacol.Rows(0)("ser_doc")
        txtRuc.Text = datacol.Rows(0)("ruc_aux")
        Fperiodo.Text = datacol.Rows(0)("periodo")
        cbomoneda.SelectedValue = datacol.Rows(0)("cod_mon")
        cbotipodoc.SelectedValue = datacol.Rows(0)("tip_doc")
        cboAdq.SelectedIndex = datacol.Rows(0)("tipo_adq")
        MfechaDE.Text = datacol.Rows(0)("fee_doc").ToString
        MfechaDV.Text = datacol.Rows(0)("fev_doc").ToString

        entCom.ruc = txtRuc.Text
        lblRazonSocial.Text = compBL.comprobante_razon_social(entCom)

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click

    End Sub
End Class