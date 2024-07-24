Public Class CECliente
    ' Atributo privado para almacenar la cédula del cliente
    Private _cedulaCliente As String

    ' Propiedad para acceder a la cédula del cliente
    Public Property cedulaCliente As String
        Get
            Return _cedulaCliente
        End Get
        Set(value As String)
            _cedulaCliente = value
        End Set
    End Property

    ' Atributo privado para almacenar la fecha de adquisición del cliente
    Private _fechaAdquiCliente As Date

    ' Propiedad para acceder a la fecha de adquisición del cliente
    Public Property fechaAdquiCliente As Date
        Get
            Return _fechaAdquiCliente
        End Get
        Set(value As Date)
            _fechaAdquiCliente = value
        End Set
    End Property

    ' Atributo privado para almacenar el nombre del cliente
    Private _nombreCliente As String

    ' Propiedad para acceder al nombre del cliente
    Public Property nombreCliente As String
        Get
            Return _nombreCliente
        End Get
        Set(value As String)
            _nombreCliente = value
        End Set
    End Property

    ' Atributo privado para almacenar el apellido del cliente
    Private _apellidoCliente As String

    ' Propiedad para acceder al apellido del cliente
    Public Property apellidoCliente As String
        Get
            Return _apellidoCliente
        End Get
        Set(value As String)
            _apellidoCliente = value
        End Set
    End Property

    ' Atributo privado para almacenar la fecha de nacimiento del cliente
    Private _fechaNaciCliente As Date

    ' Propiedad para acceder a la fecha de nacimiento del cliente
    Public Property fechaNaciCliente As Date
        Get
            Return _fechaNaciCliente
        End Get
        Set(value As Date)
            _fechaNaciCliente = value
        End Set
    End Property

    ' Atributo privado para almacenar el peso del cliente
    Private _pesoCliente As Double

    ' Propiedad para acceder al peso del cliente
    Public Property pesoCliente As Double
        Get
            Return _pesoCliente
        End Get
        Set(value As Double)
            _pesoCliente = value
        End Set
    End Property

    ' Atributo privado para almacenar el sexo del cliente
    Private _sexoCliente As String

    ' Propiedad para acceder al sexo del cliente
    Public Property sexoCliente As String
        Get
            Return _sexoCliente
        End Get
        Set(value As String)
            _sexoCliente = value
        End Set
    End Property

    ' Atributo privado para almacenar el código de sucursal del cliente
    Private _codSucursCliente As String

    ' Propiedad para acceder al código de sucursal del cliente
    Public Property codSucursCliente As String
        Get
            Return _codSucursCliente
        End Get
        Set(value As String)
            _codSucursCliente = value
        End Set
    End Property

    ' Atributo privado para almacenar el código de membresía del cliente
    Private _codMembCliente As String

    ' Propiedad para acceder al código de membresía del cliente
    Public Property codMembCliente As String
        Get
            Return _codMembCliente
        End Get
        Set(value As String)
            _codMembCliente = value
        End Set
    End Property

End Class

