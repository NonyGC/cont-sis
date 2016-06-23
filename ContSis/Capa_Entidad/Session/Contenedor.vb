Public Class Contenedor
    Private idValue As Integer
    Private nombreValue As String
    Private nivelValue As Integer
    Private relacionValue As Integer

    Public Property Id As Integer
        Get
            Id = idValue
        End Get
        Set(value As Integer)
            idValue = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Nombre = nombreValue
        End Get
        Set(value As String)
            nombreValue = value
        End Set
    End Property
    Public Property Nivel As Integer
        Get
            Nivel = nivelValue
        End Get
        Set(value As Integer)
            nivelValue = value
        End Set
    End Property
    Public Property Relacion As Integer
        Get
            Relacion = relacionValue
        End Get
        Set(value As Integer)
            relacionValue = value
        End Set
    End Property

End Class
