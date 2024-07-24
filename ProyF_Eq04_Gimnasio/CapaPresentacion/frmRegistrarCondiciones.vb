Imports CapaNegocio
Imports CapaEntidad

Public Class frmRegistrarCondiciones
    Dim capaNegocios As New CNCliente
    Private ced_cliente As String

    ' Constructor que recibe la cédula del cliente como parámetro
    Public Sub New(ByVal cedula As String)
        InitializeComponent()
        ced_cliente = cedula
    End Sub

    ' Evento que se ejecuta al cargar el formulario
    Private Sub frmRegistrarCondiciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarCondiciones() ' Carga las condiciones en el DataGridView
    End Sub

    ' Carga las condiciones en el DataGridView
    Sub cargarCondiciones()
        Dim capaNegocios As New CNCliente
        dgvCondiciones.DataSource = capaNegocios.listadoCondiciones.Tables("condicion")
    End Sub

    ' Obtiene la cédula del cliente
    Function getCedula() As String
        Return ced_cliente
    End Function

    ' Obtiene el código de la condición seleccionada en el DataGridView
    Function getCodigo() As String
        Dim cod_cond As String
        cod_cond = dgvCondiciones.SelectedRows(0).Cells(0).Value.ToString()
        Return cod_cond
    End Function

    ' Evento del botón "Agregar"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Se crea un objeto de la clase CECondicion y se asignan los valores necesarios
        Dim objeto As New CECondicion
        objeto.cedulaCliente = getCedula()
        objeto.codCondicion = getCodigo()
        capaNegocios.insertarCondicion(objeto) ' Se inserta la condición para el cliente en la capa de negocios
    End Sub

    ' Evento del botón "Listo"
    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        Me.Close() ' Se cierra el formulario actual (frmRegistrarCondiciones)
        frmClientes.Show() ' Se muestra el formulario frmClientes
    End Sub
End Class
