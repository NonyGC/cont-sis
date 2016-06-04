Imports Controladores
Imports Vista.frmMain
Public Class frmEjercicio
    Dim ejeLB As New EjercicioBL
#Region "Metodos"
    Shared Function PermitirNumero(ByVal c As Char) As Boolean
        Dim bln As Boolean
        If Char.IsNumber(c) Then
            bln = False
        ElseIf c = Convert.ToChar(Keys.Back) Then
            bln = False
        ElseIf c = Convert.ToChar(Keys.Enter) Then
            bln = False
        Else
            bln = True
        End If

        Return bln
    End Function
    Shared Function Year(ByVal cad As String, start As Integer, startend As Integer) As Integer
        Dim i, s, e, yyyy As Integer
        s = start
        e = startend
        i = cad.Trim.Length

        Select Case i
            Case 0
                s = e
            Case 1 To 3
                Dim f As Integer = s + CInt(cad)
                If f <= e And f >= s Then
                    yyyy = f
                Else
                    yyyy = 0
                End If
            Case Else
                If CInt(cad) <= e And CInt(cad) >= s Then
                    yyyy = CInt(cad)
                Else
                    yyyy = 0
                End If
        End Select
        Return yyyy
    End Function
    Shared Function ValidarYear(ByVal int As Integer, ByVal start As Integer, ByVal startend As Integer) As Boolean
        If int >= start And int <= startend Then
            Return True
        Else
            Return False
        End If
    End Function
    Shared Function CIntP(ByVal cadena As String) As Integer
        Dim resp As Integer = 0

        If String.IsNullOrEmpty(cadena) Or String.IsNullOrWhiteSpace(cadena) Then
            resp = 0
        ElseIf IsNumeric(cadena) Then
            resp = CInt(cadena)
        Else
            resp = 0
        End If
        Return resp
    End Function
    Shared Function ValidarString(cad As String) As Boolean
        Dim resp As Boolean
        If String.IsNullOrEmpty(cad) Or String.IsNullOrWhiteSpace(cad) Then
            resp = False
        Else
            resp = True
        End If
        Return resp
    End Function
    Shared Function ValidarInt(cad As String)
        Dim resp As Boolean
        If ValidarString(cad) = False Then
            resp = False
        ElseIf IsNumeric(cad) Then
            resp = True
        Else
            resp = False
        End If
        Return resp
    End Function
#End Region
    Private Sub Frm_Ejercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = "Fecha: " & Now.Date
        Label2.Text = "Hora: " & Now.Hour & ":" & Now.Minute
        TextBox1.Text = Now.Year
        TextBox1.MaxLength = 4
        'With frmMainv2.tssl_ejercicio
        '    .Text = " INGRESE EL AÑO A TRABAJAR"
        '    .Size = New System.Drawing.Size(200, 17)
        '    .BorderSides = ToolStripStatusLabelBorderSides.Right
        'End With
        TextBox1.Select()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If PermitirNumero(e.KeyChar) = True Then
            'BeepP()
        End If
        e.Handled = PermitirNumero(e.KeyChar)
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Validar()
        End If
    End Sub
    Sub Validar()
        If ValidarYear(CIntP(TextBox1.Text), 2000, Now.Year) Then

            Me.Hide()
            _EjercicioMain = TextBox1.Text

            Dim f As frmMain = Application.OpenForms.Item("frmMain")
            f.lblEjercicio.Text += ": " & _EjercicioMain

            Dim frm As New frmPeriodo
            frm.MdiParent = Me.ParentForm
            frm.Show()
            Me.Dispose()
        End If


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Validar()
    End Sub
End Class