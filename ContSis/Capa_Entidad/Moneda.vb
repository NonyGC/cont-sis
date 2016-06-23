Public Class Moneda
    Private _desc As String
    Private _tag As String

    Private Property desc As String
        Get
            Return _desc
        End Get
        Set(value As String)
            _desc = value
        End Set
    End Property
    Private Property tag As String
        Get
            Return _tag
        End Get
        Set(value As String)
            _tag = value
        End Set
    End Property
End Class
