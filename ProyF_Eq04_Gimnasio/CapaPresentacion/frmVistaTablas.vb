Imports CapaNegocio

Public Class frmVistaTablas

    ' Evento que se ejecuta al cargar el formulario
    Private Sub frmVistaTablas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarCondicionClientes()
        Call cargarPosiciones()
        Call cargarSucursales()
    End Sub

    ' Se crean instancias de las capas de negocios CNCliente y CNEmpleado
    Dim capaNegociosCliente As New CNCliente
    Dim capaNegociosEmpleado As New CNEmpleado

    ' Carga los datos de las condiciones de los clientes en el DataGridView
    Sub cargarCondicionClientes()
        dgvCondiciones.DataSource = capaNegociosCliente.listaCondicionCliente.Tables("Condicion_cliente")
    End Sub

    ' Carga los datos de las sucursales en el DataGridView
    Sub cargarSucursales()
        dgvSucursales.DataSource = capaNegociosEmpleado.listaSucursal.Tables("Sucursal")
    End Sub

    ' Carga los datos de las posiciones en el DataGridView
    Sub cargarPosiciones()
        dgvPosicion.DataSource = capaNegociosEmpleado.listaPosicion.Tables("Posicion")
    End Sub

    ' Evento del botón "Actualizar"
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Call cargarCondicionClientes()
    End Sub
End Class
