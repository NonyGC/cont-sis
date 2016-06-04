Public Class Comprobante
    Private _nrodiario As String
    Private _periodo As String
    Private _nrocompro As String
    Private _moneda As String
    Private _tipo_adq As String
    Private _tipo_doc As String
    Private _serie As String
    Private _nrodocu As String
    Private _fechae As String
    Private _fechav As String
    Private _ruc As String

    Private _nrodetalle As String
    Private _cuenta As String
    Private _glosa As String
    Private _debe As Double
    Private _haber As Double

    
    Public Property nrocompro As String
        Get
            Return _nrocompro
        End Get
        Set(ByVal value As String)
            _nrocompro = value
        End Set
    End Property

    Public Property tipo_adq As String
        Get
            Return _tipo_adq
        End Get
        Set(ByVal value As String)
            _tipo_adq = value
        End Set
    End Property
    Public Property nrodiario As String
        Get
            Return _nrodiario
        End Get
        Set(ByVal value As String)
            _nrodiario = value
        End Set
    End Property

    Public Property periodo As String
        Get
            Return _periodo
        End Get
        Set(ByVal value As String)
            _periodo = value
        End Set
    End Property
    Public Property glosa As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property

    Public Property moneda As String
        Get
            Return _moneda
        End Get
        Set(ByVal value As String)
            _moneda = value
        End Set
    End Property

    Public Property nrodetalle As String
        Get
            Return _nrodetalle
        End Get
        Set(ByVal value As String)
            _nrodetalle = value
        End Set
    End Property
    Public Property ruc As String
        Get
            Return _ruc
        End Get
        Set(ByVal value As String)
            _ruc = value
        End Set
    End Property
    Public Property cuenta As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
        End Set
    End Property
    Public Property tipo_doc As String
        Get
            Return _tipo_doc
        End Get
        Set(ByVal value As String)
            _tipo_doc = value
        End Set
    End Property
    Public Property serie As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
        End Set
    End Property
    Public Property nrodocu As String
        Get
            Return _nrodocu
        End Get
        Set(ByVal value As String)
            _nrodocu = value
        End Set
    End Property
    Public Property fechae As String
        Get
            Return _fechae
        End Get
        Set(ByVal value As String)
            _fechae = value
        End Set
    End Property
    Public Property fechav As String
        Get
            Return _fechav
        End Get
        Set(ByVal value As String)
            _fechav = value
        End Set
    End Property
    Public Property debe As Double
        Get
            Return _debe
        End Get
        Set(ByVal value As Double)
            _debe = value
        End Set
    End Property

    Public Property haber As Double
        Get
            Return _haber
        End Get
        Set(ByVal value As Double)
            _haber = value
        End Set
    End Property

End Class
