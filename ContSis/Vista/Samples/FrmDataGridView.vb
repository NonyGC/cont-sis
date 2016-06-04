Imports Controladores
Public Class FrmDataGridView
    'Variables 
    Private rolBl As New RolBL
    'Metodos
    Public Sub Load_DataGridView()
        With dgvContenedor
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AllowUserToAddRows = False
            .DataSource = rolBl.tablaRoles().Copy()
            .Columns("Codigo").ReadOnly = True
            .Columns("Descripcion").ReadOnly = True
        End With
        For Each Row As DataGridViewRow In dgvContenedor.Rows
            Row.DefaultCellStyle.BackColor = Color.GreenYellow

        Next
    End Sub
    Public Sub BuscarDataGridView(ByVal id As String)
        Dim foco As Boolean
        If id.Length = 0 Then
            For Each row As DataGridViewRow In dgvContenedor.Rows
                row.Selected = False
            Next
            dgvContenedor.Rows(dgvContenedor.RowCount - 1).Selected = True
        Else
            For Each row As DataGridViewRow In dgvContenedor.Rows
                If CInt(row.Cells(0).Value) = Integer.Parse(id) Then
                    row.Selected = True
                    Exit For
                Else
                    row.Selected = False
                    foco = False
                End If
            Next

            If foco = False Then
                For Each row As DataGridViewRow In dgvContenedor.Rows
                    row.Selected = False
                Next
                dgvContenedor.Rows(dgvContenedor.RowCount - 1).Selected = True
            End If
        End If

    End Sub


End Class