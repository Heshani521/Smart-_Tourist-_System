Imports MySql.Data.MySqlClient
Public Class Manage__Attration_form

    Dim connString As String = "server=localhost;user=root;password=;database=galle_tourism;"


    Private Sub LoadAttractions()
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            Dim query As String = "SELECT id AS 'ID', name AS 'Attraction Name', location AS 'Location', fee AS 'Entrance Fee' FROM attractions"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)


            dgvattraction.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        dashboardform.Show()
        Me.Close()
    End Sub

    Private Sub Manage__Attration_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadAttractions()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtname.Text = "" Or txtlocation.Text = "" Or txtfee.Text = "" Then
            MessageBox.Show("Please fill all the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()

            Dim query As String = "INSERT INTO attractions (name, location, fee) VALUES (@name, @location, @fee)"
            Dim cmd As New MySqlCommand(query, conn)


            cmd.Parameters.AddWithValue("@name", txtname.Text)
            cmd.Parameters.AddWithValue("@location", txtlocation.Text)
            cmd.Parameters.AddWithValue("@fee", txtfee.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Attraction added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txtname.Clear()
            txtlocation.Clear()
            txtfee.Clear()


            LoadAttractions()

        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub dgvattraction_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvattraction.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvattraction.Rows(e.RowIndex)


            txtname.Text = row.Cells("Attraction Name").Value.ToString()
            txtlocation.Text = row.Cells("Location").Value.ToString()
            txtfee.Text = row.Cells("Entrance Fee").Value.ToString()
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click



        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            Dim query As String = "UPDATE attractions SET name=@name, location=@location, fee=@fee WHERE id=@id"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@name", txtname.Text)
            cmd.Parameters.AddWithValue("@location", txtlocation.Text)
            cmd.Parameters.AddWithValue("@fee", txtfee.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)



            txtname.Clear()
            txtlocation.Clear()
            txtfee.Clear()
            LoadAttractions()
        Catch ex As Exception
            MessageBox.Show("Error updating: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btndlt_Click(sender As Object, e As EventArgs) Handles btndlt.Click



        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Dim conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "DELETE FROM attractions WHERE id=@id"
                Dim cmd As New MySqlCommand(query, conn)


                cmd.ExecuteNonQuery()
                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                txtname.Clear()
                txtlocation.Clear()
                txtfee.Clear()
                LoadAttractions()
            Catch ex As Exception
                MessageBox.Show("Error deleting: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End If

    End Sub

End Class