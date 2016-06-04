Imports Controladores
Imports Capa_Entidad
Imports System.IO
Public Class frmManEmpresa
    Dim validar As New EmpresaBL
    Dim Entvalidar As New Empresa
    Dim EntEmp As New Empresa
    Dim datos As New DataTable
    Dim autorizado As Integer
    Dim opFile As New OpenFileDialog
    Dim appPath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\Imagenes\"
    Dim imgname As String
    Dim FilePath As String
    Sub limpiar()
        txtruc.Clear()
        lblrsocial.Text = ""
        lblalias.Text = ""
        PictureBox1.Image = My.Resources.No_Image_Available
        btnguardar.Enabled = False
        txtruc.Enabled = True
    End Sub
    Sub mostrarimagen()
        Try
            If (File.Exists(appPath + txtruc.Text + ".jpg")) Then
                Dim temppath As String = appPath + txtruc.Text + ".jpg"
                Dim fs As FileStream
                fs = New FileStream(temppath, FileMode.Open, FileAccess.Read)
                PictureBox1.Image = Image.FromStream(fs)
                fs.Close()
            Else
                PictureBox1.Image = My.Resources.No_Image_Available
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub autocompletado()
        Try
            Dim col As New AutoCompleteStringCollection
            Dim datacol As New DataTable
            datacol = validar.tablaEmpresas
            For i As Integer = 0 To datacol.Rows.Count - 1
                col.Add(datacol.Rows(i)(0).ToString)
            Next
            txtruc.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtruc.AutoCompleteCustomSource = col
            txtruc.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtruc.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtruc.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtruc.Text.Trim().Length > 0 Then
                With EntEmp
                    .RUC = txtruc.Text
                End With
                Try
                    datos = validar.Empresa_DatosLB(EntEmp)
                    If datos.Rows.Count > 0 Then
                        For Each row As DataRow In datos.Rows
                            txtruc.Text = row(0).ToString
                            lblrsocial.Text = row(1).ToString
                            lblalias.Text = row(2).ToString
                        Next
                        mostrarimagen()
                        btnguardar.Enabled = False
                    Else
                        MsgBox("La Empresa no Existe")
                        limpiar()
                    End If
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If txtruc.Text.Trim().Length > 0 Then
            EntEmp.RUC = txtruc.Text
            Try
                datos = validar.Empresa_DatosLB(EntEmp)
                If datos.Rows.Count > 0 Then
                    If File.Exists(appPath + txtruc.Text + ".jpg") Then
                        File.Delete(appPath + txtruc.Text + ".jpg")
                        File.Copy(FilePath, appPath + imgname)
                    Else
                        File.Copy(FilePath, appPath + imgname)

                    End If
                    MsgBox("Logo actualizada")
                    txtruc.Enabled = True
                    btnguardar.Enabled = False
                    limpiar()
                Else
                    MsgBox("la Empresa no existe")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("Ingrese el RUC")
        End If
        'If txtrs.Text.Trim().Length > 0 Then
        '    EntEmp.Nombre = txtrs.Text
        'Else
        '    MsgBox("Ingrese Razon Social")
        'End If
        'If txtalias.Text.Trim().Length > 0 Then
        '    EntEmp.Aliass = txtalias.Text
        'Else
        '    MsgBox("Ingrese Alias")
        'End If

        'If validar.Empresa_RegisterLB(EntEmp) > 0 Then
        '    MsgBox("Empresa registrada")
        '    limpiar()
        'Else
        '    datos = validar.Empresa_DatosLB(EntEmp)
        '    If datos.Rows.Count > 0 Then
        '        If validar.Empresa_ActualizarLB(EntEmp) > 0 Then
        '            File.Copy(FilePath, appPath + imgname)
        '            MsgBox("Empresa actualizada ")
        '            limpiar()
        '        End If
        '    Else
        '        MsgBox("la Empresa no existe")
        '    End If
        'End If

    End Sub

    Private Sub frm_Man_Empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnguardar.Enabled = False
        autocompletado()
        PictureBox1.Image = My.Resources.No_Image_Available
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'OpenFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif| All Files|*.*"
        opFile.Title = "Seleccione el logo de la Empresa"
        opFile.Filter = "Image Files (*.jpeg,*.png,*.jpg)|*.jpeg;*.png;*.jpg| All Files|*.*"
        opFile.FileName = ""

        If (Directory.Exists(appPath) = False) Then
            Directory.CreateDirectory(appPath)
        End If
        If (opFile.ShowDialog = DialogResult.OK) Then
            Try
                If Image.FromFile(opFile.FileName).Size.Width > 550 Or Image.FromFile(opFile.FileName).Size.Height > 550 Then
                    MessageBox.Show("El logo no puede superar el tamaño de 550 x 550")
                Else
                    txtruc.Enabled = False
                    btnguardar.Enabled = True
                    imgname = txtruc.Text + ".jpg"
                    FilePath = opFile.FileName
                    PictureBox1.Image = New Bitmap(opFile.OpenFile)
                End If

            Catch ex As Exception
                MessageBox.Show("No se puede abrir la imagen" + ex.Message)
            End Try
        Else
            opFile.Dispose()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiar()
    End Sub
End Class