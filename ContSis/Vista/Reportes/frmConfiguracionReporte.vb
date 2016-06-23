Imports System.Drawing.Printing

Public Class frmConfiguracionReporte
    Private PrinterSettings As New PrinterSettings
    Private Sub btnDestinoPDF_Click(sender As Object, e As EventArgs) Handles btnDestinoPDF.Click
        Dim fbDiag As New FolderBrowserDialog
        fbDiag.Description = "Establezca el destino para la exportación del archivo PDF"
        If (fbDiag.ShowDialog(Me) = DialogResult.OK) Then
            txtDestinoPDF.Text = fbDiag.SelectedPath
        End If

    End Sub
    Private Sub btnDestinoExcel_Click(sender As Object, e As EventArgs) Handles btnDestinoExcel.Click
        Dim FBdiag As New FolderBrowserDialog
        FBdiag.Description = "Establezca el destino para la exportación del archivo Excel (97-2003)"
        If (FBdiag.ShowDialog(Me) = DialogResult.OK) Then
            txtDestinoExcel.Text = FBdiag.SelectedPath
        End If
    End Sub
    Private Sub PopulateInstalledPrintersCombo()
        ' Add list of installed printers found to the combo box.
        ' The pkInstalledPrinters string will be used to provide the display string.
        Dim i As Integer
        Dim pkInstalledPrinters As String

        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
            pkInstalledPrinters = PrinterSettings.InstalledPrinters.Item(i)
            cboImpresora.Items.Add(pkInstalledPrinters)
        Next
        cboImpresora.SelectedIndex = 0
    End Sub

    Private Sub frmConfiguracionReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateInstalledPrintersCombo()
    End Sub

    Private Sub rbBD_CheckedChanged(sender As Object, e As EventArgs) Handles rbBD.CheckedChanged
        If rbBD.Checked Then
            VisibleExcel(False)
        End If
    End Sub

    Private Sub rdEXCEL_CheckedChanged(sender As Object, e As EventArgs) Handles rdEXCEL.CheckedChanged
        If rdEXCEL.Checked Then
            VisibleExcel(True)
        End If
    End Sub
    Private Sub VisibleExcel(b As Boolean)
        lblNamExcel.Visible = b
        txtNamExcel.Visible = b
    End Sub

End Class
