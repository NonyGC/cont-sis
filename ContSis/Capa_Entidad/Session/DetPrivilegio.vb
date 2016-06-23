
Public Class DetPrivilegio
    'variables
    Private idValue As String
    Private privilegioValue As String
    Private contenedorValue As String
    Private nodeValue As String
    Private cantidadValue As Integer
    Private formularioValue As String
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
    Public Property Privilegio() As String
        Get
            Privilegio = privilegioValue
        End Get
        Set(value As String)
            privilegioValue = value
        End Set
    End Property
    Public Property Contenedor As String
        Get
            Contenedor = contenedorValue
        End Get
        Set(value As String)
            contenedorValue = value
        End Set
    End Property
    Public Property Node As String
        Get
            Node = nodeValue
        End Get
        Set(value As String)
            nodeValue = value
        End Set
    End Property
    Public Property Cantidad As Integer
        Get
            Cantidad = cantidadValue
        End Get
        Set(value As Integer)
            cantidadValue = value
        End Set
    End Property
    Public Property Formulario As String
        Get
            Formulario = formularioValue
        End Get
        Set(value As String)
            formularioValue = value
        End Set
    End Property
    'Metodos

End Class
