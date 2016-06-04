Public Class BaseForm
    Shared Sub CloseForm(nameForm As String)
        Try
            Application.OpenForms.Item(nameForm).Close()
        Catch ex As Exception
            Debug.WriteLine("Error Cerrar Form: " & nameForm & " - " & ex.ToString)
        End Try
    End Sub
End Class
