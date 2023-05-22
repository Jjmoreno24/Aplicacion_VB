
Public Class Form1
    Private Sub Form1_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtTexto.Text =" "
        txtTexto.BackColor = Color.White
        txtTexto.ForeColor = Color.Black
        'optFondoAzul.Checked = True
        'If optFondoVerde.Checked = True Then optFondoVerde.Checked = False
        'optFondoVerde.Checked = False
        'optFondoRojo.Checked = False
        'optFondoAzul.Checked = False
        'If chkMayuscula.CheckState = CheckState.Checked Then chkMayuscula.CheckState = CheckState.Unchecked
        'If chkNegrita.CheckState = CheckState.Checked Then chkNegrita.CheckState = CheckState.Unchecked
        txtTexto.Focus()
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtTexto.Text = " "
        txtTexto.BackColor = Color.White
        txtTexto.ForeColor = Color.Black

        If chkMayuscula.CheckState = CheckState.Checked Then chkMayuscula.CheckState = CheckState.Unchecked
        If chkNegrita.CheckState = CheckState.Checked Then chkNegrita.CheckState = CheckState.Unchecked
        txtTexto.Focus()
    End Sub


    Private Sub btnTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminar.Click
        Close()
    End Sub

    Private Sub optFondoVerde_CheckedChanged(sender As Object, e As EventArgs) Handles optFondoVerde.CheckedChanged
        txtTexto.BackColor = Color.Green
    End Sub

    Private Sub optFondoRojo_CheckedChanged(sender As Object, e As EventArgs) Handles optFondoRojo.CheckedChanged
        txtTexto.BackColor = Color.Red
    End Sub

    Private Sub optFondoAzul_CheckedChanged(sender As Object, e As EventArgs) Handles optFondoAzul.CheckedChanged
        txtTexto.BackColor = Color.Blue
    End Sub

    Private Sub optFuenteCyan_Click(sender As Object, e As EventArgs) Handles optFuenteCyan.Click
        txtTexto.ForeColor = Color.Cyan
    End Sub

    Private Sub optFuenteMagenta_Click(sender As Object, e As EventArgs) Handles optFuenteMagenta.Click
        txtTexto.ForeColor = Color.Magenta
    End Sub

    Private Sub optFuenteBlanco_Click(sender As Object, e As EventArgs) Handles optFuenteBlanco.Click
        txtTexto.ForeColor = Color.White
    End Sub

    Private Sub chkMayuscula_CheckedChanged(sender As Object, e As EventArgs) Handles chkMayuscula.CheckedChanged
        If chkMayuscula.Checked = True Then
            txtTexto.Text = UCase(txtTexto.Text)
        Else
            txtTexto.Text = LCase(txtTexto.Text)
        End If
    End Sub

    Private Sub chkNegrita_CheckedChanged(sender As Object, e As EventArgs) Handles chkNegrita.CheckedChanged
        If chkNegrita.Checked = True Then
            txtTexto.Font = New Font(txtTexto.Font, FontStyle.Bold)
        Else
            txtTexto.Font = New Font(txtTexto.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub nextFrmDatos_Click(sender As Object, e As EventArgs) Handles nextFrmDatos.Click
        Dim frmDatos As New frmDatos()
        Me.Hide()
        frmDatos.Show()
    End Sub
End Class
