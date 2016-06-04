Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReportePantalla
    Private registros As Integer
    Sub New(registros As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.registros = registros
        Me.tlRegistros.Text += " " & Me.registros
    End Sub
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class