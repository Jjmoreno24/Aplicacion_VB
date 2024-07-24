Imports CapaDatos
Imports CapaEntidad

' La clase CNInvitado pertenece a la capa de negocios y se encarga de interactuar con los datos relacionados con los invitados
Public Class CNInvitado
    ' Se crea una instancia de la clase DAOInvitado para interactuar con los datos de los invitados
    Dim objInvitado As New DAOInvitado

    ' Función para obtener la cantidad de visitas de un cliente
    Public Function obtenerCantidadVisitas(ByVal ced_cliente As String) As Integer
        Return objInvitado.obtenerCantidadVisitas(ced_cliente)
    End Function

    ' Método para insertar un invitado
    Public Sub insertarInvitado(ByVal objC As CapaEntidad.CEInvitado)
        objInvitado.insertarInvitado(objC)
    End Sub

End Class

