Public Class CECondicion
    ' Atributo privado para almacenar la cédula del cliente relacionada con la condición
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

    ' Atributo privado para almacenar el código de la condición
    Private _codCondicion As String

    ' Propiedad para acceder al código de la condición
    Public Property codCondicion As String
        Get
            Return _codCondicion
        End Get
        Set(value As String)
            _codCondicion = value
        End Set
    End Property
End Class
