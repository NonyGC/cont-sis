Public Class Permiso
    Private _id As Integer
    Private _usuario As Integer
    Private _empresa As String
    Private _completo As Boolean
    Private _modulo As String

    Public Sub New(id As Integer, usuario As Integer, empresa As String, completo As Boolean, modulo As String)
        _id = id
        _usuario = usuario
        _empresa = empresa
        _completo = completo
        _modulo = modulo

    End Sub
    Public Sub New(usuario As Integer, empresa As String, completo As Boolean, modulo As String)
        _usuario = usuario
        _empresa = empresa
        _completo = completo
        _modulo = modulo

    End Sub
    Public Sub New(empresa As String, modulo As String)
        _empresa = empresa
        _modulo = modulo

    End Sub
    Public Sub New()

    End Sub
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property Usuario As Integer
        Get
            Return _usuario
        End Get
        Set(value As Integer)
            _usuario = value
        End Set
    End Property
    Public Property Empresa As String
        Get
            Return _empresa
        End Get
        Set(value As String)
            _empresa = value
        End Set
    End Property
    Public Property Completo As Boolean
        Get
            Return _completo
        End Get
        Set(value As Boolean)
            _completo = value
        End Set
    End Property

    Public Property Modulo As String
        Get
            Return _modulo
        End Get
        Set(value As String)
            _modulo = value
        End Set
    End Property
    Public Function ConvertIntToCompleto() As Integer
        If _completo Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Function Modulos(modulo As String) As String
        If modulo = String.Empty Then
            Return "[" & _modulo & "]"
        Else
            Return modulo & "[" & _modulo & "]"
        End If
    End Function
    Public Function Modulos() As String
        Return _modulo
    End Function
    Public Function QuitarModulo(modulo As String) As String
        Return modulo.Replace("[" & _modulo & "]", Nothing)
    End Function





End Class
