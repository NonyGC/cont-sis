Public Class CabPrivilegio
    'Variables
    Private idValue As String
    Private rolValue As Integer
    Private empresaValue As String
    Private _status As String
    'Contructor 



    'Propiedades
    Public Property Id() As String
        Get
            Id = idValue
        End Get
        Set(value As String)
            idValue = value
        End Set
    End Property
    Public Property Rol() As Integer
        Get
            Rol = rolValue
        End Get
        Set(value As Integer)
            rolValue = value
        End Set
    End Property
    Public Property Empresa() As String
        Get
            Empresa = empresaValue
        End Get
        Set(value As String)
            empresaValue = value
        End Set
    End Property
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

End Class
