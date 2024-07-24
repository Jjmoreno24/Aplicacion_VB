Public Class CEEmpleado
    ' Atributo privado para almacenar la cédula del empleado
    Private _cedulaEmpleado As String

    ' Propiedad para acceder a la cédula del empleado
    Public Property cedulaEmpleado As String
        Get
            Return _cedulaEmpleado
        End Get
        Set(value As String)
            _cedulaEmpleado = value
        End Set
    End Property

    ' Atributo privado para almacenar el código de la sucursal a la que pertenece el empleado
    Private _codSucursal As String

    ' Propiedad para acceder al código de la sucursal
    Public Property codSucursal As String
        Get
            Return _codSucursal
        End Get
        Set(value As String)
            _codSucursal = value
        End Set
    End Property

    ' Atributo privado para almacenar el salario del empleado
    Private _Salario As Double

    ' Propiedad para acceder al salario del empleado
    Public Property Salario As Double
        Get
            Return _Salario
        End Get
        Set(value As Double)
            _Salario = value
        End Set
    End Property
End Class
