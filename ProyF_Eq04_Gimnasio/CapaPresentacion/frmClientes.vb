Imports CapaNegocio

' El formulario frmClientes se encarga de gestionar la visualización y manipulación de los clientes

Public Class frmClientes
    Dim capaNegocios As New CNCliente ' Se crea una instancia de la clase CNCliente para interactuar con los datos de los clientes

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarClientes() ' Al cargar el formulario, se llama al método cargarClientes para mostrar la lista de clientes en el DataGridView
    End Sub

    ' Método para cargar la lista de clientes en el DataGridView
    Sub cargarClientes()
        dgvClientes.DataSource = capaNegocios.listadoClientes.Tables("Cliente")
    End Sub

    ' Evento del menú "Registrar Cliente"
    Private Sub RegistrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarClienteToolStripMenuItem.Click
        frmNuevoCliente.Show() ' Se muestra el formulario frmNuevoCliente para registrar un nuevo cliente
        Me.Hide()
    End Sub

    ' Evento del botón "Actualizar"
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        capaNegocios.EliminarDatosAntiguos() ' Se llama al método EliminarDatosAntiguos de la clase CNCliente para eliminar los datos antiguos de los clientes
        capaNegocios.EliminarCondiciones() ' Se llama al método EliminarCondiciones de la clase CNCliente para eliminar las condiciones de los clientes que ya no existen
        Call cargarClientes() ' Se vuelve a cargar la lista de clientes en el DataGridView después de la actualización
        MessageBox.Show("Actualización realizada")
    End Sub

    ' Evento del TextBox de filtro de búsqueda
    Private Sub txtbFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtbFiltro.TextChanged
        Dim vista As New DataView(capaNegocios.listadoClientes.Tables("Cliente")) ' Se crea una vista de los datos de los clientes
        vista.RowFilter = $"{cmbFiltro.SelectedItem.ToString} Like '{txtbFiltro.Text}%'" ' Se aplica un filtro a la vista según el criterio de búsqueda seleccionado en el ComboBox
        dgvClientes.DataSource = vista ' Se muestra la vista filtrada en el DataGridView
    End Sub

    ' Evento del menú "Lista de Empleados"
    Private Sub ListaDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeEmpleadosToolStripMenuItem.Click
        Me.Hide()
        frmEmpleados.Show() ' Se muestra el formulario frmEmpleados para visualizar la lista de empleados
    End Sub

    ' Evento del menú "Registrar Invitado"
    Private Sub RegistrarInvitadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarInvitadoToolStripMenuItem.Click
        frmRegistrarInvitado.Show() ' Se muestra el formulario frmRegistrarInvitado para registrar un nuevo invitado
        Me.Hide()
    End Sub

    ' Evento del botón "Abrir Tablas"
    Private Sub btnAbrirTablas_Click(sender As Object, e As EventArgs) Handles btnAbrirTablas.Click
        frmVistaTablas.Show() ' Se muestra el formulario frmVistaTablas para visualizar las tablas de la base de datos
    End Sub

    ' Evento del menú "Salir"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit() ' Se cierra la aplicación
    End Sub

    ' Evento del botón "Refrescar"
    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Call cargarClientes() ' Se vuelve a cargar la lista de clientes en el DataGridView para refrescar los datos
        MessageBox.Show("Tabla refrescada")
    End Sub

    ' Evento del menú "Menu Presentación"
    Private Sub MenuPresentacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuPresentacionToolStripMenuItem.Click
        frmMenuPresentacion.Show() ' Se muestra el formulario frmMenuPresentacion para visualizar el menú de presentación
        Me.Hide()
    End Sub
End Class

