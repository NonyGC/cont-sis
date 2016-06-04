Public Class Rol
    'Varibles
    Private idValue As Integer
    Private descripcionValue As String
    Private _tipo As String
    'Propiedades
    Public Property Id() As Integer
        Get
            Id = idValue
        End Get
        Set(value As Integer)
            idValue = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Descripcion = descripcionValue
        End Get
        Set(value As String)
            descripcionValue = value
        End Set
    End Property
    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Public Function TipoUsuario() As Integer
        Dim rsp As Integer
        Select Case _tipo
            Case "normal"
                rsp = 3
            Case "admin"
                rsp = 2
            Case "master"
                rsp = 1
        End Select
        Return rsp
    End Function
    Public Function IsMaster() As Boolean

        If _tipo = "master" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
