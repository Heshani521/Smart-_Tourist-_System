Imports System.Security.Cryptography


Public Class login_form

        Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click


        If txtusername.Text = "" Or txtpw.Text = "" Then
                MessageBox.Show("Please enter both Username and Password!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


        If txtusername.Text = "admin" And txtpw.Text = "123" Then
                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Dim dash As New DashboardForm()
            dash.Show()

            Me.Hide()
            Else

            MessageBox.Show("Error: Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtusername.Clear()
                txtpw.Clear()
            txtusername.Focus()
        End If





        End Sub

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click

        txtusername.Clear()
        txtpw.Clear()


        txtusername.Focus()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click

        Application.Exit()
    End Sub

    Private Sub chkshow_CheckedChanged(sender As Object, e As EventArgs) Handles chkshow.CheckedChanged

        If chkshow.Checked Then
            txtpw.PasswordChar = ""
        Else
            txtpw.PasswordChar = "*"
        End If
    End Sub

End Class
