Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class Presentacion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Oculta el formulario actual
        Me.Hide()
        ' Crea una instancia del segundo formulario y lo muestra
        Dim formulario As New Form1()
        formulario.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Oculta el formulario actual
        Me.Hide()
        ' Crea una instancia del segundo formulario y lo muestra
        Dim formulario2 As New frmDatos()
        formulario2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Cierra la aplicacion 
        Me.Close()
    End Sub

End Class