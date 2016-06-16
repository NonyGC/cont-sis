Public Class Sistema
    Private _nroUsuario As Integer
    Private _nroEmpresa As Integer
    Private _existeDatos As Boolean
    Private _activoAdmin As Integer

    Public Sub New()

    End Sub
    Public Sub New(nroUsuario As Integer, nroEmpresa As Integer)
        _nroUsuario = nroUsuario
        _nroEmpresa = _nroEmpresa
    End Sub

    Public Property NroUsuario As Integer
        Get
            Return _nroUsuario
        End Get
        Set(value As Integer)
            _nroUsuario = value
        End Set
    End Property

    Public Property NroEmpresa As Integer
        Get
            Return _nroEmpresa
        End Get
        Set(value As Integer)
            _nroEmpresa = value
        End Set
    End Property
    Public Property ActivoAdmin As Integer
        Get
            Return _activoAdmin
        End Get
        Set(value As Integer)
            _activoAdmin = value
        End Set
    End Property
    Public Property ExisteDatos As Boolean
        Get
            Return _existeDatos
        End Get
        Set(value As Boolean)
            _existeDatos = value
        End Set
    End Property
    Public Function VerificarDatos() As Boolean
        If ExisteDatos Then
            If _nroEmpresa = 0 And _nroUsuario = 0 Then
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If

    End Function
    Public Function Array() As String()

        Return New String() {_nroUsuario, _nroEmpresa, _activoAdmin}
    End Function

End Class
