Public Class Formulario
    Private _id As Integer
    Private _dscrip As String
    Private _idMenu As Integer
    Private _frm As String

#Region "Metodos"
#Region "Get - Set"
    Public Property Id() As String
        Get
            Id = _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Descripcion = _dscrip
        End Get
        Set(value As String)
            _dscrip = value
        End Set
    End Property
    Public Property Contenedor() As Integer
        Get
            Contenedor = _idMenu
        End Get
        Set(value As Integer)
            _idMenu = value
        End Set
    End Property
    Public Property Formulario() As String
        Get
            Formulario = _frm
        End Get
        Set(value As String)
            _frm = value
        End Set
    End Property
#End Region
#End Region

End Class
