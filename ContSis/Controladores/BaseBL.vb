Imports System.Windows.Forms

Public Class BaseBL
    Public Shared Sub Enabled_ToolStripItem(ByVal toolStripItem As ToolStripItem, ByVal status As Boolean)
        If status = True Then
            With toolStripItem
                .Enabled = True
                .BackColor = System.Drawing.SystemColors.Menu
            End With
        Else
            With toolStripItem
                .Enabled = False
                .BackColor = System.Drawing.SystemColors.ControlDark
            End With
        End If
    End Sub
    Public Shared Sub Enabled_ToolStripMenuItem(ByVal toolStripMenuItem As ToolStripMenuItem, ByVal status As Boolean)
        If status = True Then
            With toolStripMenuItem
                .Enabled = True
                .BackColor = System.Drawing.SystemColors.Menu
            End With
        Else
            With toolStripMenuItem
                .Enabled = False
                .BackColor = System.Drawing.SystemColors.ControlDark
            End With
        End If
    End Sub
    Public Shared Function CheckForm(formName As String) As Boolean
        Try
            Dim f As Form = Application.OpenForms.Item(formName)
            If IsNothing(f) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
            Debug.WriteLine("Error CheckForm: " & ex.ToString)
        End Try


    End Function
End Class
