
Imports MySql.Data.MySqlClient
Public Class dashboardform
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        login_form.txtusername.Clear()
        login_form.txtpw.Clear()


        login_form.Show()
        Me.Close()
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            login_form.Show()


            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim manage As New Manage__Attration_form()
        manage.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Service Providers Form is under development!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Reports_Form.Show()
        Me.Hide()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click





        If txtsearch.Text = "" Then
            MessageBox.Show("Please enter a keyword to search!", "Input Needed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim connString As String = "server=localhost;user=root;password=;database=galle_tourism;"
        Dim conn As New MySqlConnection(connString)

        Try

            conn.Open()


            Dim query As String = "SELECT name AS 'Site Name', location AS 'Location', fee AS 'Entrance Fee' FROM attractions WHERE name LIKE @search OR location LIKE @search"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@search", "%" & txtsearch.Text & "%")


            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            dgvresults.DataSource = dt


            If dt.Rows.Count = 0 Then
                MessageBox.Show("No results found for '" & txtsearch.Text & "'.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            conn.Close()
        End Try

    End Sub

End Class