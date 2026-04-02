Imports MySql.Data.MySqlClient
Public Class Reports_Form
    Dim connString As String = "server=localhost;user=root;password=;database=galle_tourism;"

    Private Sub LoadReports()
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()


            Dim query1 As String = "SELECT COUNT(*) FROM attractions"
            Dim cmd1 As New MySqlCommand(query1, conn)
            lbltotalat.Text = cmd1.ExecuteScalar().ToString()


            Dim query2 As String = "SELECT COUNT(*) FROM service_providers WHERE type = 'Hotel' OR type = 'Accommodation'"
            Dim cmd2 As New MySqlCommand(query2, conn)
            lbltotalhotels.Text = cmd2.ExecuteScalar().ToString()


            Dim query3 As String = "SELECT COUNT(*) FROM service_providers WHERE type = 'Transport' OR type = 'Vehicle'"
            Dim cmd3 As New MySqlCommand(query3, conn)
            lbltotaltr.Text = cmd3.ExecuteScalar().ToString()

        Catch ex As Exception
            MessageBox.Show("Error loading reports: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Reports_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReports()
    End Sub

    Private Sub btndash_Click(sender As Object, e As EventArgs) Handles btndash.Click
        dashboardform.Show()
        Me.Close()
    End Sub

End Class