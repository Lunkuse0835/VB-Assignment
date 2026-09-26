Public Class Form1
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter username and password.")

        ElseIf username = "admin" And password = "1234" Then
            MessageBox.Show("Login successful!")

        Else
            MessageBox.Show("Invalid username or password.")
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()

    End Sub
End Class
