Public Class frmDatos
    Private Sub btnAgregar_Click_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar_Click.Click
        lboNombre.Items.Add(txtNombre.Text)
        lboEdad.Items.Add(txtEdad.Text)
        lboTel.Items.Add(txtTelefono.Text)
        lboEstado.Items.Add(IIf(CheckBox1.Checked, "Casado", "Soltero"))
        txtContador.Text = lboNombre.Items.Count

        'Agg fila al ListBox de Filas ingresada
        Dim filaIngresada As String = txtNombre.Text & " - " & txtEdad.Text & " - " & txtTelefono.Text & " - " & IIf(CheckBox1.Checked, "Casado", "Soltero")
        lboFilas.Items.Add(filaIngresada)

        txtTelefono.Text = ""
        txtEdad.Text = ""
        txtNombre.Text = ""
        txtNombre.Focus()
    End Sub

    Private Sub btnEliminar_Click_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Click.Click
        Dim l As Integer = lboNombre.SelectedIndex
        lboNombre.Items.RemoveAt(l)
        lboEdad.Items.RemoveAt(l)
        lboTel.Items.RemoveAt(l)
        lboEstado.Items.RemoveAt(l)
        'Eliminar fila del Lisbox de Filas ingresadas
        'lboFilas.Items.RemoveAt(l)
        txtContador.Text = lboNombre.Items.Count

        'Eliminar fila del Lisbox de Filas ingresadas
        'If lboFilas.Items.Count > 1 Then
        'lboFilas.Items.RemoveAt(l)
        'End If
    End Sub

    Private Sub btnLimpiar_Click_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar_Click.Click
        lboNombre.Items.Clear()
        lboEdad.Items.Clear()
        lboTel.Items.Clear()
        lboEstado.Items.Clear()
        'limpiar listBox de filas ingresadas
        lboFilas.Items.Clear()
        txtContador.Text = lboNombre.Items.Count
        txtNombre.Focus()
    End Sub

    Private Sub btnSalir_Click_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir_Click.Click
        End
    End Sub
End Class