Public Class BaseForm
    Shared Sub CloseForm(nameForm As String)
        Try
            Dim f As Form = Application.OpenForms.Item(nameForm)
            If f IsNot Nothing Then
                f.Close()
            End If
        Catch ex As Exception
            Debug.WriteLine("Error Cerrar Form: " & nameForm & " - " & ex.ToString)
        End Try
    End Sub
    Shared Function CadenaToArray(value As String) As String()
        Dim continua As Boolean = True
        Dim buscaDesde As Integer = 0
        Dim array(0) As String
        Dim contador As Integer = 0

        While continua
            Dim indiceInicial As Integer = value.IndexOf("[", buscaDesde)
            Dim indiceFinal As Integer
            Dim val As String

            If indiceInicial < 0 Then
                continua = False

            Else
                indiceFinal = value.IndexOf("]", indiceInicial)
                val = value.Substring(indiceInicial + 1, indiceFinal - (indiceInicial + 1))

                Try
                    array(contador) = val
                Catch ex As Exception
                    ReDim Preserve array(array.Length)
                    array(contador) = val
                End Try
                contador += 1
                buscaDesde = indiceFinal
            End If
        End While
        Return array
    End Function
    Shared Function CantidadOfCadenaArray(value As String) As Integer
        Dim continua As Boolean = True
        Dim buscaDesde As Integer = 0
        Dim array(0) As String
        Dim contador As Integer = 0

        While continua
            Dim indiceInicial As Integer = value.IndexOf("[", buscaDesde)
            Dim indiceFinal As Integer
            Dim val As String

            If indiceInicial < 0 Then
                continua = False

            Else
                indiceFinal = value.IndexOf("]", indiceInicial)
                val = value.Substring(indiceInicial + 1, indiceFinal - (indiceInicial + 1))
                contador += 1
                buscaDesde = indiceFinal
            End If
        End While
        Return contador
    End Function
    Shared Sub stripbuttons(ByVal ts As ToolStrip)
        For Each c As ToolStripItem In ts.Items
            If TypeOf c Is ToolStripButton Then
                Dim b As New Bitmap(50, 50)
                Dim g As Graphics = Graphics.FromImage(DirectCast(b, Image))
                c.AutoSize = False
                c.Width = 100
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(c.Image, 0, 0, 50, 50)
                g.Dispose()
                Dim myResizedImg As Image = DirectCast(b, Image)
                c.Image = myResizedImg
            End If
        Next
        ts.ImageScalingSize = New Size(50, 50)
    End Sub
End Class
