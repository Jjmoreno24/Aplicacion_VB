Imports CapaNegocio
Imports CapaEntidad

Public Class frmNuevoCliente

    Dim capaNegocios As New CNCliente

    ' Evento que se ejecuta al cargar el formulario
    Private Sub frmNuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarMembresia() ' Carga las opciones de membresía en el ComboBox
        Call cargarSucursal() ' Carga las opciones de sucursal en el ComboBox
        Call cargarSexo() ' Carga las opciones de sexo en el ComboBox
    End Sub

    ' Carga las opciones de sexo en el ComboBox
    Sub cargarSexo()
        cmbSexo.Items.Add("Femenino")
        cmbSexo.Items.Add("Masculino")
    End Sub

    ' Carga las opciones de membresía en el ComboBox
    Sub cargarMembresia()
        cmbMembresia.DataSource = capaNegocios.listaMembresia.Tables("Membresia")
        cmbMembresia.DisplayMember = "nomb_memb"
        cmbMembresia.ValueMember = "cod_memb"
    End Sub

    ' Carga las opciones de sucursal en el ComboBox
    Sub cargarSucursal()
        cmbSucursal.DataSource = capaNegocios.listaSucursal.Tables("Sucursal")
        cmbSucursal.DisplayMember = "Ubicacion"
        cmbSucursal.ValueMember = "Codigo"
    End Sub

    ' Obtiene la cédula ingresada por el usuario
    Function getCedula() As String
        Return txtbCedula.Text
    End Function

    ' Obtiene el nombre ingresado por el usuario
    Function getNombre() As String
        Return txtbNombre.Text
    End Function

    ' Obtiene el apellido ingresado por el usuario
    Function getApellido() As String
        Return txtbApellido.Text
    End Function

    ' Obtiene la fecha de adquisición ingresada por el usuario
    Function getFechaAqui() As Date
        Return dtpFechaAdqui.Value
    End Function

    ' Obtiene la fecha de nacimiento ingresada por el usuario
    Function getFechaNac() As Date
        Return dtpFechaNaci.Value
    End Function

    ' Obtiene el peso ingresado por el usuario
    Function getPeso() As Double
        Return CDbl(txtbPeso.Text)
    End Function

    ' Obtiene el sexo seleccionado por el usuario
    Function getSexo() As String
        Return cmbSexo.SelectedItem
    End Function

    ' Obtiene la sucursal seleccionada por el usuario
    Function getSucursal() As String
        Return cmbSucursal.SelectedValue
    End Function

    ' Obtiene la membresía seleccionada por el usuario
    Function getMembresia() As String
        Return cmbMembresia.SelectedValue
    End Function

    ' Evento del botón "Siguiente"
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        ' Se crea un objeto de la clase CECliente y se asignan los valores ingresados por el usuario
        Dim objeto As New CECliente
        objeto.cedulaCliente = getCedula()
        objeto.fechaAdquiCliente = getFechaAqui()
        objeto.nombreCliente = getNombre()
        objeto.apellidoCliente = getApellido()
        objeto.fechaNaciCliente = getFechaNac()
        objeto.pesoCliente = getPeso()
        objeto.sexoCliente = getSexo()
        objeto.codSucursCliente = getSucursal()
        objeto.codMembCliente = getMembresia()

        capaNegocios.nuevoCliente(objeto) ' Se llama al método para registrar un nuevo cliente en la capa de negocios

        ' Se muestra el formulario frmRegistrarCondiciones y se le pasa la cédula del cliente registrado
        Dim frmRegistrarCondiciones As New frmRegistrarCondiciones(txtbCedula.Text)
        frmRegistrarCondiciones.Show()
        Me.Close() ' Se cierra el formulario actual (frmNuevoCliente)
    End Sub

    ' Evento del menú "Salir"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit() ' Se cierra la aplicación
    End Sub

    ' Evento del menú "Lista de Empleados"
    Private Sub ListaDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeEmpleadosToolStripMenuItem.Click
        frmEmpleados.Show() ' Se muestra el formulario frmEmpleados para visualizar la lista de empleados
        Me.Hide() ' Se oculta el formulario actual (frmNuevoCliente)
    End Sub

    ' Evento del menú "Lista de Clientes"
    Private Sub ListaDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeClientesToolStripMenuItem.Click
        frmClientes.Show() ' Se muestra el formulario frmClientes para visualizar la lista de clientes
        Me.Hide() ' Se oculta el formulario actual (frmNuevoCliente)
    End Sub

    ' Evento del menú "Registrar Invitado"
    Private Sub RegistrarInvitadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarInvitadoToolStripMenuItem.Click
        frmRegistrarInvitado.Show() ' Se muestra el formulario frmRegistrarInvitado para registrar un nuevo invitado
        Me.Hide() ' Se oculta el formulario actual (frmNuevoCliente)
    End Sub

    ' Evento del menú "Menú de Presentación"
    Private Sub MenuPresentacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuPresentacionToolStripMenuItem.Click
        frmMenuPresentacion.Show() ' Se muestra el formulario frmMenuPresentacion para volver al menú de presentación
        Me.Hide() ' Se oculta el formulario actual (frmNuevoCliente)
    End Sub

End Class
