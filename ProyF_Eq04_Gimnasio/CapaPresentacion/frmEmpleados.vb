Imports CapaNegocio

' El formulario frmEmpleados se encarga de gestionar la visualización y manipulación de los empleados

Public Class frmEmpleados
    Dim capaNegocios As New CNEmpleado ' Se crea una instancia de la clase CNEmpleado para interactuar con los datos de los empleados

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargaEmpleados() ' Al cargar el formulario, se llama al método cargaEmpleados para mostrar la lista de empleados en el DataGridView
    End Sub

    ' Método para cargar la lista de empleados en el DataGridView
    Sub cargaEmpleados()
        dgvEmpleados.DataSource = capaNegocios.listaEmpleado.Tables("empleado")
    End Sub

    ' Evento del TextBox de filtro de búsqueda
    Private Sub txtbFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtbFiltro.TextChanged
        Dim vista As New DataView(capaNegocios.listaEmpleado.Tables("empleado")) ' Se crea una vista de los datos de los empleados
        vista.RowFilter = $"{cmbFiltro.SelectedItem.ToString} Like '{txtbFiltro.Text}%'" ' Se aplica un filtro a la vista según el criterio de búsqueda seleccionado en el ComboBox
        dgvEmpleados.DataSource = vista ' Se muestra la vista filtrada en el DataGridView
    End Sub

    ' Evento del botón "Actualizaciones"
    Private Sub btnActualizaciones_Click(sender As Object, e As EventArgs) Handles btnActualizaciones.Click
        frmActualizarEmpleados.Show() ' Se muestra el formulario frmActualizarEmpleados para realizar actualizaciones en los empleados
    End Sub

    ' Evento del botón "Refrescar"
    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Call cargaEmpleados() ' Se vuelve a cargar la lista de empleados en el DataGridView para refrescar los datos
        MessageBox.Show("Tabla refrescada")
    End Sub

    ' Evento del botón "Abrir Tablas"
    Private Sub btnAbrirTablas_Click(sender As Object, e As EventArgs) Handles btnAbrirTablas.Click
        frmVistaTablas.Show() ' Se muestra el formulario frmVistaTablas para visualizar las tablas de la base de datos
    End Sub

    ' Evento del menú "Registrar Cliente"
    Private Sub RegistrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarClienteToolStripMenuItem.Click
        frmNuevoCliente.Show() ' Se muestra el formulario frmNuevoCliente para registrar un nuevo cliente
        Me.Hide()
    End Sub

    ' Evento del menú "Lista de Clientes"
    Private Sub ListaDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeClientesToolStripMenuItem.Click
        frmClientes.Show() ' Se muestra el formulario frmClientes para visualizar la lista de clientes
        Me.Hide()
    End Sub

    ' Evento del menú "Registrar Invitados"
    Private Sub RegistrarInvitadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarInvitadosToolStripMenuItem.Click
        frmRegistrarInvitado.Show() ' Se muestra el formulario frmRegistrarInvitado para registrar un nuevo invitado
        Me.Hide()
    End Sub

    ' Evento del menú "Salir"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit() ' Se cierra la aplicación
    End Sub

    ' Evento del menú "Menu Presentación"
    Private Sub MenuPresentacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuPresentacionToolStripMenuItem.Click
        frmMenuPresentacion.Show() ' Se muestra el formulario frmMenuPresentacion para visualizar el menú de presentación
        Me.Hide()
    End Sub

End Class
