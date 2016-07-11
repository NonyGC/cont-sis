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
    Private _fecha_dua_dsi As String
    Private _ruc As String
    Private _estado As String
    Private _man As String

    Private _nrodetalle As String
    Private _cuenta As String
    Private _glosa As String
    Private _debe As Object
    Private _haber As Object

    Private _baseimpo1 As Decimal
    Private _igv1 As Decimal
    Private _baseimpo2 As Decimal
    Private _igv2 As Decimal
    Private _baseimpo3 As Decimal
    Private _igv3 As Decimal
    Private _baseimpo4 As Decimal

    Private _importe_total As Decimal

    Private _isc As Decimal
    Private _razonsocial As String
    Private _tipo_cambio As Decimal


    Private _nrocaba As String

    Public Property baseimpo1 As Decimal
        Get
            Return _baseimpo1
        End Get
        Set(ByVal value As Decimal)
            _baseimpo1 = value
        End Set
    End Property
    Public Property igv1 As Decimal
        Get
            Return _igv1
        End Get
        Set(ByVal value As Decimal)
            _igv1 = value
        End Set
    End Property
    Public Property baseimpo2 As Decimal
        Get
            Return _baseimpo2
        End Get
        Set(ByVal value As Decimal)
            _baseimpo2 = value
        End Set
    End Property
    Public Property igv2 As Decimal
        Get
            Return _igv2
        End Get
        Set(ByVal value As Decimal)
            _igv2 = value
        End Set
    End Property
    Public Property baseimpo3 As Decimal
        Get
            Return _baseimpo3
        End Get
        Set(ByVal value As Decimal)
            _baseimpo3 = value
        End Set
    End Property
    Public Property igv3 As Decimal
        Get
            Return _igv3
        End Get
        Set(ByVal value As Decimal)
            _igv3 = value
        End Set
    End Property
    Public Property baseimpo4 As Decimal
        Get
            Return _baseimpo4
        End Get
        Set(ByVal value As Decimal)
            _baseimpo4 = value
        End Set
    End Property
    Public Property importe_total As Decimal
        Get
            Return _importe_total
        End Get
        Set(ByVal value As Decimal)
            _importe_total = value
        End Set
    End Property

    Public Property isc As Decimal
        Get
            Return _isc
        End Get
        Set(ByVal value As Decimal)
            _isc = value
        End Set
    End Property
    Public Property razonsocial As String
        Get
            Return _razonsocial
        End Get
        Set(ByVal value As String)
            _razonsocial = value
        End Set
    End Property
    Public Property tipo_cambio As Decimal
        Get
            Return _tipo_cambio
        End Get
        Set(ByVal value As Decimal)
            _tipo_cambio = value
        End Set
    End Property
    Public Property nrocaba As String
        Get
            Return _nrocaba
        End Get
        Set(value As String)
            _nrocaba = value
        End Set
    End Property
    Public Property estado As Integer
        Get
            Return _estado
        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property
    Public Property man As String
        Get
            Return _man
        End Get
        Set(ByVal value As String)
            _man = value
        End Set
    End Property
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
    Public Property fecha_dua_dsi As String
        Get
            Return _fecha_dua_dsi
        End Get
        Set(ByVal value As String)
            _fecha_dua_dsi = value
        End Set
    End Property
    Public Property debe As Object
        Get
            Return _debe
        End Get
        Set(ByVal value As Object)
            _debe = value
        End Set
    End Property

    Public Property haber As Object
        Get
            Return _haber
        End Get
        Set(ByVal value As Object)
            _haber = value
        End Set
    End Property

End Class

