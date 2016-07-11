Imports Capa_Entidad
Imports Controladores

Public Class frnCronogramaPagos
    Dim regla As New VencimientoPagoBL
    Private Sub frnCronogramaPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim periodos() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octube", "Noviembre", "Diciembre"}
        Dim nroRuc() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "BC"}
        For i = 0 To 11
            dgvCronograma.Rows.Add(periodos(i))
            cboPeriodo.Items.Add(periodos(i))
        Next
        cboPeriodo.SelectedIndex = Date.Now.Month - 1
        For Each nro As String In nroRuc
            cboUltimoDigito.Items.Add(nro)
        Next
        cboUltimoDigito.SelectedIndex = 0

        Dim listVencimientoPago As List(Of VencimientoPagos) = regla.ListVencimientoPago
        If listVencimientoPago Is Nothing Then Exit Sub
        For Each vp As VencimientoPagos In listVencimientoPago
            AgregarCell(vp.Ruc, vp.Periodo, vp.Fecha)
        Next

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles tsbCerrar.Click
        Close()
    End Sub

    Private Sub dgvCronograma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDay.KeyPress, txtMonth.KeyPress, txtYear.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dgvCronograma_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvCronograma.EditingControlShowing
        Dim autoText As TextBox = TryCast(e.Control, TextBox)
        autoText.MaxLength = 2
        AddHandler autoText.KeyPress, AddressOf dgvCronograma_KeyPress

    End Sub


    Private Sub dgvCronograma_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCronograma.CellEndEdit
        If e.ColumnIndex <> 0 Then
            Dim cell As DataGridViewCell = dgvCronograma.Item(e.ColumnIndex, e.RowIndex)
            If cell.Value IsNot Nothing Then
                Try
                    Dim dt As Date
                    If cell.Value.ToString.Length >= 3 Then

                    Else
                        If e.RowIndex = 11 Then
                            dt = New DateTime(Now.Year, 1, cell.Value)
                        Else
                            dt = New DateTime(Now.Year, e.RowIndex + 2, cell.Value)
                        End If
                    End If
                    cell.Value = dt.ToString("MMM dd")
                Catch ex As Exception
                    cell.Value = ""
                End Try
            Else
                cell.Value = ""
            End If
        End If
    End Sub


    Private Sub cboPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPeriodo.SelectedIndexChanged
        Dim cbo As ComboBox = DirectCast(sender, ComboBox)
        Try

            Dim dt As Date
            If cbo.SelectedIndex = 11 Then
                dt = New DateTime(Now.Year + 1, 1, Now.Day)
            Else
                dt = New DateTime(Now.Year, cbo.SelectedIndex + 2, Now.Day)
            End If
            txtYear.Text = dt.Year
            txtMonth.Text = dt.ToString("MM")
            txtDay.Text = If(txtDay.Text = String.Empty, dt.ToString("dd"), txtDay.Text)
            tsbRegistrar.Image = My.Resources.guardar_true
            tsbRegistrar.Enabled = True
        Catch ex As Exception
            tsbRegistrar.Image = My.Resources.guardar_false
            tsbRegistrar.Enabled = False
        End Try
    End Sub

    Private Sub Registrar(sender As Object, e As EventArgs) Handles tsbRegistrar.Click
        If cboUltimoDigito.Text = "" Then
            MsgBox("Seleccione el ultimo digito de un Ruc ", MsgBoxStyle.OkOnly, "Cronograma Pagos")
            Exit Sub
        End If

        Dim vencimientoPago As New VencimientoPagos
        vencimientoPago.Ruc = cboUltimoDigito.SelectedIndex
        vencimientoPago.Periodo = cboPeriodo.SelectedIndex
        Try
            vencimientoPago.Fecha = New DateTime(txtYear.Text, txtMonth.Text, txtDay.Text)
        Catch ex As Exception
            MsgBox("Ingrese la fecha de pago", MsgBoxStyle.OkOnly, "Cronograma Pagos")
            Exit Sub
        End Try

        If cboPeriodo.SelectedIndex <> If(vencimientoPago.Fecha.Month = 1, 12, vencimientoPago.Fecha.Month - 2) Then
            If cboPeriodo.SelectedIndex = 11 Then
                epCronograma.SetError(txtMonth, "El mes solo puede ser enero.")
            Else
                epCronograma.SetError(txtMonth, "El mes que ingreso no es correcto, " & vbLf & " debe ser un mes despues de periodo escogido.")
            End If

            Exit Sub
        End If



        Dim respuesta As Boolean = regla.Registrar(vencimientoPago)
        If respuesta Then
            MsgBox("Registro Completo", MsgBoxStyle.OkOnly, "Cronograma Pagos")
            tsbCancelar_Click(Nothing, Nothing)
            AgregarCell(vencimientoPago.Ruc, vencimientoPago.Periodo, vencimientoPago.Fecha)
        Else
            MsgBox("Ocurrio un problema", MsgBoxStyle.OkOnly, "Cronograma Pagos")
        End If

    End Sub



    Private Sub frnCronogramaPagos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Control And e.KeyCode = Keys.R Then

            Dim dt As Date = New DateTime(Now.Year, If(cboPeriodo.SelectedIndex = 11, 1, cboPeriodo.SelectedIndex + 2), CInt(txtDay.Text))
            AgregarCell(cboUltimoDigito.SelectedIndex, cboPeriodo.SelectedIndex, dt)

        End If
    End Sub
    Public Sub AgregarCell(ruc As Integer, periodo As Integer, fecha As Date)

        Dim dgvc As DataGridViewCell = dgvCronograma.Item(ruc + 1, periodo)
        dgvc.Value = fecha



    End Sub
    Dim controlEvento As Boolean = True
    Private Sub txtDay_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDay.KeyDown, txtMonth.KeyDown, txtYear.KeyDown
        'If controlEvento = True Then
        '    Exit Sub
        'End If

        If e.KeyCode = Keys.Enter Then
            Dim txt As TextBox = DirectCast(sender, TextBox)
            Select Case txt.Name
                Case "txtDay"
                    PressDay(txt)

                Case "txtMonth"
                    PressMonth()

                Case "txtYear"
                    PressYear()
            End Select
            controlEvento = False
        End If


    End Sub

    Private Sub txtYear_Leave(sender As Object, e As EventArgs) Handles txtDay.Leave, txtMonth.Leave, txtYear.Leave
        If controlEvento = False Then
            Exit Sub
        End If
        Dim txt As TextBox = DirectCast(sender, TextBox)
        Select Case txt.Name
            Case "txtDay"
                PressDay(txt)

            Case "txtMonth"
                PressMonth()

            Case "txtYear"
                PressYear()
        End Select
        If txtDay.Text <> String.Empty And txtMonth.Text <> String.Empty And txtYear.Text <> String.Empty Then
            tsbRegistrar.Image = My.Resources.guardar_true
            tsbRegistrar.Enabled = True

        Else
            tsbRegistrar.Image = My.Resources.guardar_false
            tsbRegistrar.Enabled = False
        End If
        controlEvento = True
    End Sub

    Private Sub PressYear()
        Try
            If IsDate(New DateTime(txtYear.Text, txtMonth.Text, txtDay.Text)) Then Exit Sub
        Catch ex As Exception

            txtYear.Text = If(cboPeriodo.SelectedIndex = 11, Now.Year + 1, Now.Year)
            txtMonth.Text = If(cboPeriodo.SelectedIndex = 11, 1, cboPeriodo.SelectedIndex + 2)
            txtDay.Text = If(txtDay.Text = String.Empty, Now.Day, txtDay.Text)
        End Try

    End Sub
    Private Sub PressMonth()
        Dim dt As Date
        Try
            dt = New DateTime(If(cboPeriodo.SelectedIndex = 11, Now.Year + 1, Now.Year),
                              If(cboPeriodo.SelectedIndex = 11, 1, cboPeriodo.SelectedIndex + 2), txtDay.Text)
        Catch ex As Exception
            dt = New DateTime(If(cboPeriodo.SelectedIndex = 11, Now.Year + 1, Now.Year),
                              If(cboPeriodo.SelectedIndex = 11, 1, cboPeriodo.SelectedIndex + 2), 1)
        Finally
            txtDay.Text = dt.ToString("dd")
            txtMonth.Text = dt.ToString("MM")
            txtYear.Text = dt.Year
        End Try
        txtYear.Focus()
    End Sub
    Private Sub PressDay(txt As TextBox)
        Dim dt As Date
        If txt.Text = String.Empty Then
            dt = New DateTime(If(cboPeriodo.SelectedIndex = 11, Now.Year + 1, Now.Year),
                              If(cboPeriodo.SelectedIndex = 11, 1, cboPeriodo.SelectedIndex + 2), Now.Day)
            txtDay.Text = dt.ToString("dd")
            txtMonth.Text = dt.ToString("MM")
            txtYear.Text = dt.Year
        Else

            Try
                dt = New DateTime(If(cboPeriodo.SelectedIndex = 11, Now.Year + 1, Now.Year),
                                  If(cboPeriodo.SelectedIndex = 11, 1, cboPeriodo.SelectedIndex + 2), txt.Text)
            Catch ex As Exception
                dt = New DateTime(If(cboPeriodo.SelectedIndex = 11, Now.Year + 1, Now.Year),
                                  If(cboPeriodo.SelectedIndex = 11, 1, cboPeriodo.SelectedIndex + 2), 1)
            Finally
                txtDay.Text = dt.ToString("dd")
                txtMonth.Text = dt.ToString("MM")
                txtYear.Text = dt.Year
            End Try
        End If
        txtMonth.Focus()
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        txtDay.Text = ""
        txtMonth.Text = ""
        txtYear.Text = ""
        cboPeriodo.SelectedItem = Date.Now.Month - 1
        cboUltimoDigito.SelectedItem = 0
        tsbRegistrar.Image = My.Resources.guardar_false
        tsbRegistrar.Enabled = False
    End Sub

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        Dim vencimientoPago As New VencimientoPagos
        vencimientoPago.Ruc = cboUltimoDigito.SelectedIndex
        vencimientoPago.Periodo = cboPeriodo.SelectedIndex
        Dim respuesta As Boolean = regla.Eliminar(vencimientoPago)
        If respuesta Then
            MsgBox("Registro Eliminado", MsgBoxStyle.OkOnly, "Cronograma Pagos")
            Dim dgvc As DataGridViewCell = dgvCronograma.Item(vencimientoPago.Ruc + 1, vencimientoPago.Periodo)
            dgvc.Value = ""
            tsbCancelar_Click(Nothing, Nothing)
        Else
            MsgBox("Ocurrio un problema", MsgBoxStyle.OkOnly, "Cronograma Pagos")
        End If
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        Dim cell As DataGridViewCell = dgvCronograma.CurrentCell
        If cell Is Nothing Then Exit Sub
        If cell.Value Is Nothing Then Exit Sub

        Dim d As Date = cell.Value
        cboUltimoDigito.SelectedIndex = cell.ColumnIndex - 1
        cboPeriodo.SelectedIndex = cell.RowIndex
        txtDay.Text = d.ToString("dd")
        txtMonth.Text = d.ToString("MM")
        txtYear.Text = If(d.Month = 1, Now.Year + 1, Now.Year)
        tsbRegistrar.Image = My.Resources.guardar_true
        tsbRegistrar.Enabled = True

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim cell As DataGridViewCell = dgvCronograma.CurrentCell
        If cell Is Nothing Then Exit Sub
        If cell.Value Is Nothing Then Exit Sub

        Dim vencimientoPago As New VencimientoPagos
        vencimientoPago.Ruc = cell.ColumnIndex - 1
        vencimientoPago.Periodo = cell.RowIndex


        Dim respuesta As Boolean = regla.Eliminar(vencimientoPago)
        If respuesta Then
            MsgBox("Registro Eliminado", MsgBoxStyle.OkOnly, "Cronograma Pagos")
            Dim dgvc As DataGridViewCell = dgvCronograma.Item(vencimientoPago.Ruc + 1, vencimientoPago.Periodo)
            dgvc.Value = ""
            tsbCancelar_Click(Nothing, Nothing)
        Else
            MsgBox("Ocurrio un problema", MsgBoxStyle.OkOnly, "Cronograma Pagos")
        End If

    End Sub

    Private Sub txtDay_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDay.Validating

    End Sub

    Private Sub txtMonth_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMonth.Validating

    End Sub

    Private Sub txtYear_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtYear.Validating


    End Sub


    Public Sub IsValid()

    End Sub

    Private Sub txtMonth_TextChanged(sender As Object, e As EventArgs) Handles txtMonth.Enter, txtDay.Enter, txtYear.Enter
        epCronograma.SetError(sender, "")
    End Sub
End Class