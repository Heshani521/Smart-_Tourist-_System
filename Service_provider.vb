Imports MySql.Data.MySqlClient
Public Class Service_provider

    Dim connString As String = "server=localhost;user=root;password=;database=galle_tourism;"
    Dim conn As MySqlConnection


    Private Sub loadprovider()
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            Dim query As String = "SELECT id AS 'ID', type AS 'Type', name AS 'Provider Name', contact AS 'Contact No', description AS 'Description' FROM service_providers"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' ඔයාගේ Form එකේ තියෙන Grid එකේ නම මෙතනට දෙන්න
            dgvprovider.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadProviders()
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            Dim query As String = "SELECT id AS 'ID', type AS 'Type', name AS 'Provider Name', contact AS 'Contact No', description AS 'Description' FROM service_providers"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            dgvprovider.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Service_provider_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadProviders()
    End Sub


    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click


        If cmbtype.SelectedIndex = -1 Or txtname.Text = "" Or txtcn.Text = "" Then
            MessageBox.Show("Please fill all the required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try

            Dim conn As New MySqlConnection("server=localhost;user=root;password=;database=galle_tourism;")
            conn.Open()


            Dim query As String = "INSERT INTO service_providers (type, name, contact, description) VALUES (@type, @name, @contact, @description)"
            Dim cmd As New MySqlCommand(query, conn)


            cmd.Parameters.AddWithValue("@type", cmbtype.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@name", txtname.Text)
            cmd.Parameters.AddWithValue("@contact", txtcn.Text)
            cmd.Parameters.AddWithValue("@description", txtdes.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Service Provider added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cmbtype.SelectedIndex = -1
            txtname.Clear()
            txtcn.Clear()
            txtdes.Clear()

            LoadProviders()


            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgvprovider_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprovider.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvprovider.Rows(e.RowIndex)


            txtid.Text = row.Cells("ID").Value.ToString()
            cmbtype.SelectedItem = row.Cells("Type").Value.ToString()
            txtname.Text = row.Cells("Provider Name").Value.ToString()
            txtcn.Text = row.Cells("Contact No").Value.ToString()
            txtdes.Text = row.Cells("Description").Value.ToString()
        End If
    End Sub

    Private Sub btnup_Click(sender As Object, e As EventArgs) Handles btnup.Click
        If txtid.Text = "" Then
            MessageBox.Show("Please select a record to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            Dim query As String = "UPDATE service_providers SET type=@type, name=@name, contact=@contact, description=@description WHERE id=@id"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@type", cmbtype.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@name", txtname.Text)
            cmd.Parameters.AddWithValue("@contact", txtcn.Text)
            cmd.Parameters.AddWithValue("@description", txtdes.Text)
            cmd.Parameters.AddWithValue("@id", txtid.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txtid.Clear()
            cmbtype.SelectedIndex = -1
            txtname.Clear()
            txtcn.Clear()
            txtdes.Clear()
            LoadProviders()
        Catch ex As Exception
            MessageBox.Show("Error updating: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btndlt_Click(sender As Object, e As EventArgs) Handles btndlt.Click

        If txtid.Text = "" Then
            MessageBox.Show("Please select a record to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this provider?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Dim conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "DELETE FROM service_providers WHERE id=@id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", txtid.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                txtid.Clear()
                cmbtype.SelectedIndex = -1
                txtname.Clear()
                txtcn.Clear()
                txtdes.Clear()
                LoadProviders()
            Catch ex As Exception
                MessageBox.Show("Error deleting: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End If
    End Sub
End Class