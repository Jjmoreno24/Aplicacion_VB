Public Class frmMenuPresentacion

    ' Evento del menú "Lista de Clientes"
    Private Sub ListaDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeClientesToolStripMenuItem.Click
        frmClientes.Show() ' Se muestra el formulario frmClientes para visualizar la lista de clientes
        Me.Hide() ' Se oculta el formulario actual (frmMenuPresentacion)
    End Sub

    ' Evento del menú "Lista de Empleados"
    Private Sub ListaDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeEmpleadosToolStripMenuItem.Click
        frmEmpleados.Show() ' Se muestra el formulario frmEmpleados para visualizar la lista de empleados
        Me.Hide() ' Se oculta el formulario actual (frmMenuPresentacion)
    End Sub

    ' Evento del menú "Registrar Invitados"
    Private Sub RegistrarInvitadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarInvitadosToolStripMenuItem.Click
        frmRegistrarInvitado.Show() ' Se muestra el formulario frmRegistrarInvitado para registrar un nuevo invitado
        Me.Hide() ' Se oculta el formulario actual (frmMenuPresentacion)
    End Sub

    ' Evento del menú "Salir"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit() ' Se cierra la aplicación
    End Sub

    ' Evento del botón "Guía"
    Private Sub btnGuia_Click(sender As Object, e As EventArgs) Handles btnGuia.Click
        frmGuia.Show() ' Se muestra el formulario frmGuia para visualizar la guía
    End Sub

    ' Evento del botón "Curso"
    Private Sub btnCurso_Click(sender As Object, e As EventArgs) Handles btnCurso.Click
        frmCurso.Show() ' Se muestra el formulario frmCurso para visualizar el curso
    End Sub

    ' Evento del botón "Aplicación"
    Private Sub btnAplicacion_Click(sender As Object, e As EventArgs) Handles btnAplicacion.Click
        frmAplicacion.Show() ' Se muestra el formulario frmAplicacion para visualizar la aplicación
    End Sub

    ' Evento del menú "Registrar Cliente"
    Private Sub RegistrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarClienteToolStripMenuItem.Click
        frmNuevoCliente.Show() 'Se muestra el formulario frmNuevoCliente para registrar un nuevo cliente del gimnasio
        Me.Hide() 'Se oculta el formulario actual
    End Sub

End Class
