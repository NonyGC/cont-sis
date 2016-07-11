Public Class frnCronogramaPagos
    Private Sub frnCronogramaPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim periodos() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octube", "Noviembre", "Diciembre"}
        Dim nroRuc() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "BC"}
        For i = 0 To 11
            dgvCronograma.Rows.Add(periodos(i))
            cboPeriodo.Items.Add(periodos(i))
        Next
        cboPeriodo.SelectedIndex = DateTime.Now.Month - 1
        For Each nro As String In nroRuc
            cboUltimoDigito.Items.Add(nro)
        Next
        cboUltimoDigito.SelectedIndex = 0
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
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

    Private Sub dgvCronograma_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvCronograma.CellBeginEdit
        'Dim cell As DataGridViewCell = dgvCronograma.Item(e.ColumnIndex, e.RowIndex)
        'If cell.Value IsNot Nothing Then
        '    cell.Value = ""
        'End If
    End Sub

    Private Sub cboPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPeriodo.SelectedIndexChanged
        Dim cbo As ComboBox = DirectCast(sender, ComboBox)
        Try

            Dim dt As Date
            If cbo.SelectedIndex = 11 Then
                dt = New DateTime(Now.Year, 1, Now.Day)
            Else
                dt = New DateTime(Now.Year, cbo.SelectedIndex + 2, Now.Day)
            End If
            txtYear.Text = dt.Year
            txtMonth.Text = dt.ToString("MM")
            txtDay.Text = dt.ToString("dd")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

    End Sub



    Private Sub frnCronogramaPagos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.R Then

            Dim dt As Date = New DateTime(Now.Year, If(cboPeriodo.SelectedIndex = 11, 1, cboPeriodo.SelectedIndex + 2), CInt(txtDay.Text))

            Dim dgvc As DataGridViewCell = dgvCronograma.Item(cboUltimoDigito.SelectedIndex + 1, cboPeriodo.SelectedIndex)
            dgvc.Value = dt.ToString("MMM dd")
        End If
    End Sub

    Private Sub txtDay_TextChanged(sender As Object, e As EventArgs) Handles txtDay.TextChanged, txtMonth.TextChanged, txtYear.TextChanged


    End Sub
    Dim controlEvento As Boolean = True
    Private Sub txtDay_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDay.KeyDown, txtMonth.KeyDown, txtYear.KeyDown
        If controlEvento = True Then
            controlEvento = False
            Exit Sub
        End If

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
        End If


    End Sub

    Private Sub txtYear_Leave(sender As Object, e As EventArgs) Handles txtDay.Leave, txtMonth.Leave, txtYear.Leave
        If controlEvento = False Then
            controlEvento = True
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
    End Sub

    Private Sub PressYear()
        txtYear.Text = Now.Year
        txtMonto.Focus()
    End Sub
    Private Sub PressMonth()
        Dim dt As Date
        Try
            dt = New DateTime(Now.Year, If(cboPeriodo.SelectedIndex = 11, 1, cboPeriodo.SelectedIndex + 2), CInt(txtDay.Text))
        Catch ex As Exception
            dt = New DateTime(Now.Year, If(cboPeriodo.SelectedIndex = 11, 1, cboPeriodo.SelectedIndex + 2), 1)
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
            dt = New DateTime(Now.Year, If(cboPeriodo.SelectedIndex = 11, 1, cboPeriodo.SelectedIndex + 2), Now.Day)
            txtDay.Text = dt.ToString("dd")
            txtMonth.Text = dt.ToString("MM")
            txtYear.Text = dt.Year
        Else

            Try
                dt = New DateTime(Now.Year, If(cboPeriodo.SelectedIndex = 11, 1, cboPeriodo.SelectedIndex + 2), CInt(txt.Text))
            Catch ex As Exception
                dt = New DateTime(Now.Year, If(cboPeriodo.SelectedIndex = 11, 1, cboPeriodo.SelectedIndex + 2), 1)
            Finally
                txtDay.Text = dt.ToString("dd")
                txtMonth.Text = dt.ToString("MM")
                txtYear.Text = dt.Year
            End Try
        End If
        txtMonth.Focus()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class