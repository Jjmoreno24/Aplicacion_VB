Imports CapaNegocio
Imports CapaEntidad

' El formulario frmActualizarEmpleados se encarga de actualizar los datos de los empleados

Public Class frmActualizarEmpleados
    Dim capaNegocios As New CNEmpleado ' Se crea una instancia de la clase CNEmpleado para interactuar con los datos de los empleados

    Private Sub frmActualizarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarSucursal() ' Al cargar el formulario, se llama al método cargarSucursal para cargar la lista de sucursales en el ComboBox
    End Sub

    ' Método para cargar la lista de sucursales en el ComboBox
    Sub cargarSucursal()
        cmbSucursal.DataSource = capaNegocios.listaSucursal.Tables("Sucursal")
        cmbSucursal.DisplayMember = "Ubicacion"
        cmbSucursal.ValueMember = "Codigo"
    End Sub

    ' Función para obtener la cédula del empleado ingresada en el campo de texto
    Function getCedula() As String
        Return txtbCedula.Text
    End Function

    ' Función para obtener el salario ingresado en el campo de texto
    Function getSalario() As Double
        Return Val(txtbSalario.Text)
    End Function

    ' Función para obtener el código de la sucursal seleccionada en el ComboBox
    Function getSucursal() As String
        Return cmbSucursal.SelectedValue
    End Function

    ' Evento del botón "Actualizar Sucursal"
    Private Sub btnSucursal_Click(sender As Object, e As EventArgs) Handles btnSucursal.Click
        Dim objeto As New CEEmpleado ' Se crea una instancia de la clase CEEmpleado para almacenar los datos del empleado
        objeto.codSucursal = getSucursal()
        objeto.cedulaEmpleado = getCedula()
        capaNegocios.actualizarSucursal(objeto) ' Se llama al método actualizarSucursal de la clase CNEmpleado para actualizar la sucursal del empleado
        MessageBox.Show("Actualización realizada")
    End Sub

    ' Evento del botón "Actualizar Salario"
    Private Sub btnSalario_Click(sender As Object, e As EventArgs) Handles btnSalario.Click
        Dim objeto As New CEEmpleado ' Se crea una instancia de la clase CEEmpleado para almacenar los datos del empleado
        objeto.cedulaEmpleado = getCedula()
        objeto.Salario = getSalario()
        capaNegocios.actualizarSalario(objeto) ' Se llama al método actualizarSalario de la clase CNEmpleado para actualizar el salario del empleado
        MessageBox.Show("Actualización realizada")
    End Sub
End Class
