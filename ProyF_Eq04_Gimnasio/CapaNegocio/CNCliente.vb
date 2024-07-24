Imports CapaDatos
Imports CapaEntidad

' La clase CNCliente pertenece a la capa de negocios y se encarga de interactuar con los datos relacionados con los clientes

Public Class CNCliente

    ' Se crea una instancia de la clase DAOCliente para interactuar con los datos de los clientes
    Dim objCliente As New DAOCliente

    ' Método para eliminar los datos antiguos de los clientes
    Public Sub EliminarDatosAntiguos()
        objCliente.actualizarClientes()
    End Sub

    ' Método para eliminar las condiciones de los clientes que ya no existen en la tabla de clientes
    Public Sub EliminarCondiciones()
        objCliente.actualizarCondiciones()
    End Sub

    ' Función para obtener las condiciones de los clientes
    Public Function listaCondicionCliente() As DataSet
        Return objCliente.listaCondicionesClientes
    End Function

    ' Función para obtener el listado de clientes
    Public Function listadoClientes() As DataSet
        Return objCliente.listadoClientes
    End Function

    ' Función para obtener el listado de membresías
    Public Function listaMembresia() As DataSet
        Return objCliente.listaMembresia
    End Function

    ' Función para obtener el listado de sucursales
    Public Function listaSucursal() As DataSet
        Return objCliente.listaSucursal
    End Function

    ' Función para obtener el listado de condiciones
    Public Function listadoCondiciones() As DataSet
        Return objCliente.listadoCondiciones
    End Function

    ' Método para registrar un nuevo cliente
    Public Sub nuevoCliente(ByVal objC As CapaEntidad.CECliente)
        objCliente.nuevoCliente(objC)
    End Sub

    ' Método para insertar una condición para un cliente
    Public Sub insertarCondicion(ByVal objC As CapaEntidad.CECondicion)
        objCliente.insertarCondicion(objC)
    End Sub

End Class
