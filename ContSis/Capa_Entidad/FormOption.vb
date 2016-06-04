Public Class FormOption
#Region "Atributos"
    Private _name As String
    Private _fullName As String
    Private _action As Integer
#End Region
#Region "Contructor"
    Public Sub New(nameSource As String)
        If nameSource.Contains("_") Then
            Dim b As Integer = nameSource.IndexOf("_")
            _fullName = nameSource
            _name = nameSource.Substring(0, b)
            _action = CInt(nameSource.Substring(b + 1))
        Else
            _fullName = nameSource
            _name = nameSource
            _action = 0
        End If

    End Sub
#End Region

#Region "Metodos"
#Region "Get- Set"
    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property
    Public ReadOnly Property FullName As String
        Get
            Return _fullName
        End Get
    End Property
    Public ReadOnly Property Action As Integer
        Get
            Return _action
        End Get
    End Property

#End Region
#Region "Acción"
    Public Function CheckForm() As Boolean
        Try
            If _fullName.Contains("frm") Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
            Return False
        End Try
    End Function
    Public Function CheckOption() As Boolean
        Try
            If _fullName.Contains("opc") Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Debug.Write(ex.ToString)
            Return False
        End Try

    End Function
#End Region
#End Region

End Class
