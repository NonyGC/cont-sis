
Imports Controladores
Imports Capa_Entidad
Imports Vista.BaseForm
Imports System.IO
Public Class FrmManEmpresa
    Dim validar As New EmpresaBL
    Dim Entvalidar As New Empresa
    Dim EntEmp As New Empresa
    Dim datos As New DataTable
    Dim autorizado As Integer
    Dim opFile As New OpenFileDialog
    'Dim appPath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\Imagenes\"
    Dim imgname As String
    Dim FilePath As String
    Dim ubigeo As String
    Sub limpiar()
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then c.Text = "" : c.Enabled = False
            If TypeOf c Is ComboBox Then c.Text = "" : c.Enabled = False
        Next
        cboruc.Enabled = True
        pbimagen.Image = Nothing
    End Sub
    Private Sub aviable()
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then c.Enabled = True
        Next
        txtnivel.Enabled = False
        txtcodigo.Enabled = False
        cboruc.Enabled = False
        cbodepa.Enabled = True
    End Sub
    Private Sub cbo_empresa()
        Dim dt As New DataTable
        dt = validar.tablaEmpresas
        cboruc.DataSource = dt : cboruc.DisplayMember = "ruc" : cboruc.ValueMember = "ruc"
    End Sub
    Private Sub Fill_ComboBoc(cb As ComboBox, op As Integer, entemp As Empresa)
        Dim dt As DataTable = validar.ubigeoLB(op, entemp)
        cb.DataSource = dt : cb.DisplayMember = "descripcion" : cb.ValueMember = "codigo"
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub seleccione_empresa(sender As Object, e As EventArgs) Handles cboruc.SelectionChangeCommitted
        Try
            EntEmp.RUC = cboruc.SelectedValue
            datos = validar.Empresa_DatosLB(EntEmp)
            If datos.Rows.Count <> 0 Then
                For Each row In datos.Rows
                    If Not String.IsNullOrEmpty(row(3).ToString) Then
                        Dim pic As Byte() = Convert.FromBase64String(row(3))
                        Dim lstr As New System.IO.MemoryStream(pic)
                        pbimagen.Image = Image.FromStream(lstr) : pbimagen.SizeMode = PictureBoxSizeMode.StretchImage
                        'lstr.Close()
                    End If
                    txtrz.Text = row(1).ToString
                    txtalias.Text = row(2).ToString
                    txtcodigo.Text = row(4).ToString
                    txtnivel.Text = row(5)
                    cbodepa.Text = row(6).ToString
                    cboprovi.Text = row(7).ToString
                    cbodist.Text = row(8).ToString
                    ubigeo = row(9).ToString
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        aviable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles tsbguardar.Click
        With EntEmp
            .RUC = cboruc.SelectedValue : .Nombre = txtrz.Text : .Aliass = txtalias.Text
            If cbodist.SelectedValue <> Nothing Then .ubigeo = cbodist.SelectedValue Else .ubigeo = ubigeo
        End With
        If pbimagen.Image IsNot Nothing Then
            Dim mstream As New System.IO.MemoryStream()
            pbimagen.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.ToArray()
            Dim base64 As String = Convert.ToBase64String(arrImage)
            EntEmp.imagen_string = base64
        Else
            MsgBox("Ingrese un logo")
            Exit Sub
        End If
        datos = validar.Empresa_DatosLB(EntEmp)
        If datos.Rows.Count > 0 Then
            validar.Empresa_ActualizarLB(EntEmp)
            MsgBox("Empresa actualizada ")
            limpiar()
        End If
    End Sub
    Private Sub validando(sender As Object, e As EventArgs) Handles txtrz.TextChanged, txtcodigo.TextChanged, txtalias.TextChanged, cbodepa.SelectedValueChanged, cboprovi.SelectedValueChanged, cbodist.SelectedValueChanged, Button1.Click
        If String.IsNullOrEmpty(txtrz.Text) Or String.IsNullOrEmpty(txtalias.Text) Or String.IsNullOrEmpty(cbodepa.Text) Or
                String.IsNullOrEmpty(cboprovi.Text) Or String.IsNullOrEmpty(cbodist.Text) Then
            tsbguardar.Enabled = False
        Else
            tsbguardar.Enabled = True
        End If
    End Sub
    Private Sub depa(sender As Object, e As EventArgs) Handles cbodepa.SelectionChangeCommitted
        EntEmp.ubigeo = cbodepa.SelectedValue
        Fill_ComboBoc(cboprovi, 1, EntEmp)
        cboprovi.Enabled = True : cboprovi.Text = ""
    End Sub
    Private Sub provincia(sender As Object, e As EventArgs) Handles cboprovi.SelectionChangeCommitted
        EntEmp.ubigeo = cboprovi.SelectedValue
        Fill_ComboBoc(cbodist, 2, EntEmp)
        cbodist.Enabled = True : cbodist.Text = ""
    End Sub

    Private Sub frm_Man_Empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill_ComboBoc(cbodepa, 0, EntEmp)
        cbo_empresa()
        stripbuttons(ToolStrip1)
        limpiar()
        tsbguardar.Enabled = False
        pbimagen.Image = Nothing
        pbimagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'OpenFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif| All Files|*.*"
        opFile.Title = "Seleccione el logo de la Empresa"
        opFile.Filter = "Image Files (*.jpeg,*.png,*.jpg)|*.jpeg;*.png;*.jpg| All Files|*.*"
        opFile.FileName = ""
        If (opFile.ShowDialog = DialogResult.OK) Then
            Try
                If Image.FromFile(opFile.FileName).Size.Width > 1000 Or Image.FromFile(opFile.FileName).Size.Height > 1000 Then
                    MessageBox.Show("El logo no puede superar el tamaño de 550 x 550")
                Else
                    imgname = cboruc.Text + ".jpg"
                    FilePath = opFile.FileName
                    pbimagen.Image = New Bitmap(opFile.OpenFile)
                End If
            Catch ex As Exception
                MessageBox.Show("No se puede abrir la imagen" + ex.Message)
            End Try
        Else
            opFile.Dispose()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles tsbcancelar.Click
        limpiar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles tsbsalir.Click
        Me.Close()
    End Sub
End Class