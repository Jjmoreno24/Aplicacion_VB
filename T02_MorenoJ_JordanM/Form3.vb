Public Class Form3
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUserIn.TextChanged


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtContraIn.TextChanged

    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        frmInfo.txtInfoOut.Text = frmInfo.txtInfoOut.Text & txtUserIn.Text
        frmInfo.txtInfoOut.Text = frmInfo.txtInfoOut.Text & "   " & txtContraIn.Text & vbNewLine

        frmInfo.txtInfUltima.Text = txtUserIn.Text + "    " & txtContraIn.Text
        txtUserIn.Text = ""
        txtUserIn.Text = ""
        txtUserIn.Focus()
    End Sub

    Private Sub cmdVisual_Click(sender As Object, e As EventArgs) Handles cmdVisual.Click
        Me.Hide()
        frmInfo.Show()
    End Sub

    Private Sub cmdTerminar_Click(sender As Object, e As EventArgs) Handles cmdTerminar.Click
        Close()
    End Sub
End Class