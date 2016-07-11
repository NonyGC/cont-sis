
Public Class VencimientoPagos

    Private _periodo As Integer
    Private _ruc As Integer
    Private _fecha As Date

    Public Property Periodo As Integer
        Get
            Return _periodo
        End Get
        Set(value As Integer)
            _periodo = value
        End Set
    End Property
    Public Property Ruc As Integer
        Get
            Return _ruc
        End Get
        Set(value As Integer)
            _ruc = value
        End Set
    End Property
    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

End Class
