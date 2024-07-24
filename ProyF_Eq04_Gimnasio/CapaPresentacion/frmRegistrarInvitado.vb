Imports CapaEntidad
Imports CapaNegocio

Public Class frmRegistrarInvitado
    Dim capaNegocios As New CNInvitado

    ' Evento que se ejecuta al cargar el formulario
    Private Sub frmRegistrarInvitado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Obtiene la cédula del invitado
    Function getCedula() As String
        Return txtbCedula.Text
    End Function

    ' Obtiene la cédula del cliente
    Function getCedulaCliente() As String
        Return txtbCedulaCliente.Text
    End Function

    ' Obtiene la fecha de visita
    Function getFecha() As Date
        Return dtpFechaVisita.Value
    End Function

    ' Obtiene el nombre del invitado
    Function getNombre() As String
        Return txtbNombre.Text
    End Function

    ' Evento del botón "Registrar"
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ' Se crea un objeto de la clase CEInvitado
        Dim objeto As New CEInvitado

        ' Se obtiene la cantidad de visitas del cliente
        Dim cantidadVisitas As Integer = capaNegocios.obtenerCantidadVisitas(txtbCedulaCliente.Text)

        ' Verifica si el cliente ha alcanzado el máximo de invitaciones del mes (4)
        If cantidadVisitas < 4 Then
            MessageBox.Show("Visita del invitado registrada con exito")
            ' Asigna los valores al objeto CEInvitado
            objeto.cedulaCliente = getCedulaCliente()
            objeto.fechaInvitacion = getFecha()
            objeto.nombreInvitado = getNombre()
            objeto.cedulaInvitado = getCedula()

            ' Se inserta el invitado en la capa de negocios
            capaNegocios.insertarInvitado(objeto)

        Else
            MessageBox.Show("El cliente ha alcanzado el máximo de invitaciones del mes")
        End If

    End Sub

    ' Evento del menú "Lista de Empleados"
    Private Sub ListaDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeEmpleadosToolStripMenuItem.Click
        frmEmpleados.Show()
        Me.Hide()
    End Sub

    ' Evento del menú "Lista de Clientes"
    Private Sub ListaDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeClientesToolStripMenuItem.Click
        frmClientes.Show()
        Me.Hide()
    End Sub

    ' Evento del menú "Registrar Cliente"
    Private Sub RegistrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarClienteToolStripMenuItem.Click
        frmNuevoCliente.Show()
        Me.Hide()
    End Sub

    ' Evento del menú "Salir"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    ' Evento del menú "Menú Presentación"
    Private Sub MenuPresentacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuPresentacionToolStripMenuItem.Click
        frmMenuPresentacion.Show()
        Me.Hide()
    End Sub
End Class
