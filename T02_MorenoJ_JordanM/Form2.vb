Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtResult.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Declaracion de variable
        Dim valor1, valor2, resultado As Double

        'Validación de los valores ingresados
        If Not Double.TryParse(txtValor1.Text, valor1) Then
            MessageBox.Show("Ingrese un número válido en el campo 'Valor 1'")
            Return
        End If

        If Not Double.TryParse(txtValor2.Text, valor2) Then
            MessageBox.Show("Ingrese un número válido en el campo 'Valor 2'")
            Return
        End If

        'Realización de la operación aritmética
        resultado = valor1 + valor2

        'Mostrar el resultado
        txtResult.Text = resultado.ToString()

    End Sub
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        'Boton para eliminar el contenido del txtBoton valor
        txtValor1.Text = String.Empty
        txtValor2.Text = String.Empty
        txtResult.Text = String.Empty
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        ' Oculta el formulario actual
        Me.Hide()

        ' Crea una instancia del formulario anterior y lo muestra
        Dim formularioAnterior As New Form1()
        formularioAnterior.Show()
    End Sub
End Class