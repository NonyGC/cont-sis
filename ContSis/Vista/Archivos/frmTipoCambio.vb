Imports Controladores
Imports Capa_Entidad
Public Class frmTipoCambio
    Dim entTC As New TipoCambio
    Dim fecha As String
    Dim datos As DataTable
    Dim validar As New TipoCambioBL
    Dim año As String = Date.Now.Year
    Dim mes As String = Date.Now.Month
    Dim dia As String = Date.Now.Day
#Region "op"
    Sub GV()
        DataGridView1.DataSource = validar.TCambio_AllLB
    End Sub
    Sub deshabilitar()
        txtcompra.Enabled = False
        txtventa.Enabled = False
        btnguardar.Enabled = False
    End Sub
    Sub habilitar()
        txtcompra.Enabled = True
        txtventa.Enabled = True
        btnguardar.Enabled = True
    End Sub
    Sub limpiar()
        txtaño.Text = año
        If mes < 10 Then
            txtmes.Text = "0" + mes
        Else txtmes.Text = mes
        End If
        If dia < 10 Then
            txtdia.Text = "0" + dia
        Else txtdia.Text = dia
        End If
        txtcompra.Clear()
        txtventa.Clear()
        GV()
    End Sub
    Sub GV_keydown()
        datos = validar.TCambio_Datos_IncompletosLB(entTC)
        If datos.Rows.Count > 0 Then
            DataGridView1.DataSource = validar.TCambio_Datos_IncompletosLB(entTC)
        Else
            DataGridView1.DataSource = Nothing
            MsgBox("el cambio no Existe")
        End If
        txtcompra.Clear()
        txtventa.Clear()
    End Sub
#End Region

    Private Sub Frm_TipoCambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim state As Integer = validar.TCambio_Verificar(Now)
        If state <> 0 Then
            Dim msg, title As String
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult
            msg = "El tipo de cambio ya fue ingresado." & vbLf &
                "Desea verificar."
            title = "Info Tipo de Cambio "
            style = MsgBoxStyle.YesNo
            response = MsgBox(msg, style, title)

            If response = MsgBoxResult.No Then
                Me.Hide()
                'Me.Dispose()
            End If
        End If

        limpiar()
        deshabilitar()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        habilitar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        deshabilitar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If txtaño.Text.Length = 0 Then
            MessageBox.Show("El año no puede estar vacío", "Ingrese el año", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Convert.ToInt16(txtaño.Text) > Date.Now.Year Or Convert.ToInt16(txtaño.Text) < (año - 10) Then
            MessageBox.Show("El año ingresado no está permitido", "Año no válido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtmes.Text.Length = 0 Then
            MessageBox.Show("El mes no puede estar vacío", "Ingrese el mes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Convert.ToInt16(txtmes.Text) > 12 Then
            MessageBox.Show("Ingrese el mes correctamente", "Mes incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Convert.ToInt16(txtmes.Text) > Date.Now.Month Then
            MessageBox.Show("El mes ingresado no está permitido", "Mes no válido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtdia.Text.Length = 0 Then
            MessageBox.Show("El día no puede estar vacío", "Ingrese el día", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Convert.ToInt16(txtdia.Text) > Date.Now.Day Then
            MessageBox.Show("El día ingresado no está permitido", "Día no válido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtcompra.Text.Length = 0 Then
            MessageBox.Show("Ingrese el precio de compra", "Precio no válido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtventa.Text.Length = 0 Then
            MessageBox.Show("Ingrese el precio de venta", "Precio no válido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        fecha = txtaño.Text + "-" + txtmes.Text + "-" + txtdia.Text
        With entTC
            .fecha = fecha
            .compra = txtcompra.Text
            .venta = txtventa.Text
        End With
        Try
            datos = validar.TCambio_DatosLB(entTC)
            If datos.Rows.Count > 0 Then
                validar.TCambio_ActualizarLB(entTC)
                MessageBox.Show("Tipo de Cambio Actualizada")
                limpiar()
            Else
                validar.TCambio_RegisterLB(entTC)
                MessageBox.Show("Tipo de Cambio Registrado")
                limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtfecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtaño.KeyPress, txtmes.KeyPress, txtdia.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtaño_KeyDown(sender As Object, e As KeyEventArgs) Handles txtaño.KeyDown, txtmes.KeyDown, txtdia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtaño.Text.Trim().Length > 0 And txtmes.Text.Trim().Length > 0 And txtdia.Text.Trim().Length > 0 Then
                entTC.fecha = txtaño.Text + "-" + txtmes.Text + "-" + txtdia.Text
                DataGridView1.DataSource = validar.TCambio_DatosLB(entTC)
                datos = validar.TCambio_Datos_IncompletosLB(entTC)
                If datos.Rows.Count > 0 Then
                    For Each row As DataRow In datos.Rows
                        txtcompra.Text = row(1).ToString
                        txtventa.Text = row(2).ToString
                    Next
                Else
                    txtcompra.Clear()
                    txtventa.Clear()
                    DataGridView1.DataSource = Nothing
                    MsgBox("el cambio no Existe")
                End If
            ElseIf txtaño.Text.Trim().Length > 0 And txtmes.Text.Trim().Length > 0 Then
                entTC.fecha = txtaño.Text + "-" + txtmes.Text
                GV_keydown()
            ElseIf txtaño.Text.Trim().Length > 0 And txtdia.Text.Trim().Length > 0 Then
                DataGridView1.DataSource = Nothing
                MsgBox("Ingrese el mes")
                txtcompra.Clear()
                txtventa.Clear()
            Else
                entTC.fecha = txtaño.Text
                GV_keydown()
            End If

        End If
    End Sub

    Private Sub frmTipoCambio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim f As New frmSelectEmpresa
        f.MdiParent = Me.ParentForm
        f.Tag = Nothing
        f.Show()
    End Sub
End Class