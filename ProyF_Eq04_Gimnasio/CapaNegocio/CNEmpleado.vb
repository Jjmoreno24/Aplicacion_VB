Imports CapaDatos

' La clase CNEmpleado pertenece a la capa de negocios y se encarga de interactuar con los datos relacionados con los empleados

Public Class CNEmpleado

    ' Se crea una instancia de la clase DAOEmpleado para interactuar con los datos de los empleados
    Dim objEmpleado As New DAOEmpleado

    ' Función para obtener el listado de empleados
    Public Function listaEmpleado() As DataSet
        Return objEmpleado.listaEmpleados
    End Function

    ' Función para obtener el listado de posiciones
    Public Function listaPosicion() As DataSet
        Return objEmpleado.listarPosiciones
    End Function

    ' Función para obtener el listado de sucursales
    Public Function listaSucursal() As DataSet
        Return objEmpleado.listarSucursales
    End Function

    ' Método para actualizar el salario de un empleado
    Public Sub actualizarSalario(ByVal objC As CapaEntidad.CEEmpleado)
        objEmpleado.actualizarSalario(objC)
    End Sub

    ' Método para actualizar la sucursal de un empleado
    Public Sub actualizarSucursal(ByVal objC As CapaEntidad.CEEmpleado)
        objEmpleado.actualizarSucursal(objC)
    End Sub

End Class
