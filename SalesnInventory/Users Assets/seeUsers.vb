Public Class seeUsers
    Private Sub cancelStockBtn_Click(sender As Object, e As EventArgs) Handles cancelStockBtn.Click
        Me.Close()
    End Sub

    Private Sub addStockBtn_Click(sender As Object, e As EventArgs) Handles addStockBtn.Click
        addUser.ShowDialog()
    End Sub

    Public Sub loadUsers()
        Dim con As SqlClient.SqlConnection
        Dim da As SqlClient.SqlDataAdapter
        Dim command As SqlClient.SqlCommand
        Dim dt As DataTable
        Dim query As String = ""

        Try
            con = New SqlClient.SqlConnection
            con.ConnectionString = connection.getConnectionString()
            con.Open()

            query = "SELECT 
                        first_name AS 'First Name',
	                    last_name AS 'Last Name',
	                    contact_number AS 'Contact',
	                    social_security_number AS 'SSN',
	                    address AS 'Address',
	                    username AS 'Username',
	                    password AS 'Password',
	                    email AS 'E-mail',
	                    nationality AS 'Nationality',
                        id AS 'ID'
                FROM users"
            command = New SqlClient.SqlCommand(query, con)
            command.CommandType = CommandType.Text

            da = New SqlClient.SqlDataAdapter
            dt = New DataTable

            da.SelectCommand = command
            da.Fill(dt)

            ' Get All
            userGridView.DataSource = dt
            userGridView.Columns(dt.Columns.Count - 1).Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub seeUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub userGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles userGridView.CellValueChanged
        If e.RowIndex >= 0 Then  ' Check for valid row index
            ' Access the edited row data
            Dim editedRow As DataGridViewRow = userGridView.Rows(e.RowIndex)

            ' Access values from specific columns (adjust column names)
            Dim first_name As String = editedRow.Cells("First Name").Value.ToString()
            Dim last_name As String = editedRow.Cells("Last Name").Value.ToString()
            Dim contact_number As String = editedRow.Cells("Contact").Value.ToString()
            Dim social_security_number As String = editedRow.Cells("SSN").Value.ToString()
            Dim address As String = editedRow.Cells("Address").Value.ToString()
            Dim username As String = editedRow.Cells("Username").Value.ToString()
            Dim password As String = editedRow.Cells("Password").Value.ToString()
            Dim email As String = editedRow.Cells("E-mail").Value.ToString()
            Dim nationality As String = editedRow.Cells("Nationality").Value.ToString()
            Dim id As Integer = editedRow.Cells("ID").Value

            ' Update 
            Dim query As String
            Dim con As SqlClient.SqlConnection
            Dim command As SqlClient.SqlCommand

            Try
                con = New SqlClient.SqlConnection
                con.ConnectionString = connection.getConnectionString()
                con.Open()

                query = "UPDATE users SET 
                            first_name = '" & first_name & "', 
                            last_name = '" & last_name & "', 
                            contact_number = '" & contact_number & "',
                            social_security_number = '" & social_security_number & "',
                            address = '" & address & "',
                            username = '" & username & "',
                            password = '" & password & "',
                            email = '" & email & "',
                            nationality = '" & nationality & "'
                    WHERE id = " & id & ";"

                con = New SqlClient.SqlConnection
                con.ConnectionString = connection.getConnectionString()
                con.Open()

                command = New SqlClient.SqlCommand(query, con)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()

                MessageBox.Show("Successfully Updated!")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MessageBox.Show(ex.StackTrace)
            End Try

            ' ... Do something with the entire row data or specific values
        End If
    End Sub
End Class