Public Class CEInvitado
    ' Atributo privado para almacenar la cédula del invitado
    Private _cedulaInvitado As String

    ' Propiedad para acceder a la cédula del invitado
    Public Property cedulaInvitado As String
        Get
            Return _cedulaInvitado
        End Get
        Set(value As String)
            _cedulaInvitado = value
        End Set
    End Property

    ' Atributo privado para almacenar el nombre del invitado
    Private _nombreInvitado As String

    ' Propiedad para acceder al nombre del invitado
    Public Property nombreInvitado As String
        Get
            Return _nombreInvitado
        End Get
        Set(value As String)
            _nombreInvitado = value
        End Set
    End Property

    ' Atributo privado para almacenar la cédula del cliente al que pertenece el invitado
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

    ' Atributo privado para almacenar la fecha de la invitación
    Private _fechaInvitacion As Date

    ' Propiedad para acceder a la fecha de la invitación
    Public Property fechaInvitacion As Date
        Get
            Return _fechaInvitacion
        End Get
        Set(value As Date)
            _fechaInvitacion = value
        End Set
    End Property
End Class
