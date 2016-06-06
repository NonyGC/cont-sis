Imports System.ComponentModel
Public Class WaterMark
    Inherits TextBox
    'Variables de WaterMark
    Dim Watertext As String
    Dim Watercolor As Color
    Dim WaterFont As Font
    Dim WaterBrush As SolidBrush
    Dim WaterContainer As Panel
    'Termina Variables de WaterMark
    Public Sub New()

        MyBase.New
        StartProcess()
    End Sub
    Private Sub StartProcess()
        Watertext = "Text"
        Watercolor = Color.Gray
        WaterFont = New Font(Me.Font, FontStyle.Italic)
        WaterBrush = New SolidBrush(Watercolor)

        CreateWaterMark()
        AddHandler TextChanged, AddressOf ChangeText
        AddHandler FontChanged, AddressOf ChangeFont
    End Sub
    Private Sub CreateWaterMark()
        WaterContainer = New Panel
        Me.Controls.Add(WaterContainer)
        AddHandler WaterContainer.Click, AddressOf Clicked
        AddHandler WaterContainer.Paint, AddressOf Painted
    End Sub
    Private Sub RemoveWaterMark()
        Me.Controls.Remove(WaterContainer)
    End Sub
    Private Sub ChangeText(sender As Object, e As EventArgs)
        If Me.TextLength <= 0 Then
            CreateWaterMark()
        ElseIf Me.TextLength > 0 Then
            RemoveWaterMark()
        End If
    End Sub
    Private Sub ChangeFont(sender As Object, e As EventArgs)
        WaterFont = New Font(Me.Font, FontStyle.Italic)
    End Sub
    Private Sub Clicked()
        Me.Focus()
    End Sub
    Private Sub Painted(sender As Object, e As PaintEventArgs)
        WaterContainer.Location = New Point(2, 0)
        WaterContainer.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        WaterContainer.Height = Me.Height
        WaterContainer.Width = Me.Width

        Dim Graphics As Graphics = e.Graphics
        Graphics.DrawString(Watertext, WaterFont, WaterBrush, New PointF(-2.0!, 1.0!))
    End Sub
    Protected Overrides Sub OnValidated(e As EventArgs)
        MyBase.OnValidated(e)
        WaterContainer.Invalidate()
    End Sub
    <Category("WaterMark Attributes"), Description("Sets WaterMark Text")> Public Property WaterMarkText As String
        Get
            Return Watertext
        End Get
        Set(value As String)
            Watertext = value
            Me.Invalidate()
        End Set
    End Property
    <Category("WaterMark Attributes"), Description("Sets WaterMark Color")> Public Property WaterMarkColor As Color
        Get
            Return Watercolor
        End Get
        Set(value As Color)
            Watercolor = value
            Me.Invalidate()
        End Set
    End Property

End Class
