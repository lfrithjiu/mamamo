Public Class Users
    Private Property userID As Integer = Nothing

    Public Sub setUserID(ByVal id As Integer)
        Me.userID = id

        ' Display the information
        displayInfo()
    End Sub
    Function GetAge(birthDate As DateTime) As Integer
        ' Get today's date
        Dim today As DateTime = DateTime.Now

        ' Calculate the difference in years, handling negative values (birth date in the future)
        Dim age As Integer = DateDiff(DateInterval.Year, birthDate, today)

        ' Check if birthday hasn't happened this year yet (current month and day before today's)
        If birthDate.Month > today.Month OrElse (birthDate.Month = today.Month AndAlso birthDate.Day > today.Day) Then
            ' Subtract 1 from age if birthday hasn't happened this year yet
            age -= 1
        End If

        ' Return the calculated age (non-negative)
        Return Math.Max(age, 0)  ' Ensure age is at least 0
    End Function

    Private Sub displayInfo()
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
	                    first_name,
	                    last_name,
	                    birthdate,
	                    contact_number,
	                    social_security_number,
	                    address,
	                    username,
	                    password,
	                    email,
	                    nationality
                    FROM users
                    WHERE id = " & userID

            command = New SqlClient.SqlCommand(query, con)
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()

            da = New SqlClient.SqlDataAdapter
            dt = New DataTable

            da.SelectCommand = command
            da.Fill(dt)

            tb_fname.Text = dt.Rows(0).Item(0)
            tb_lname.Text = dt.Rows(0).Item(1)
            tb_age.Text = GetAge(dt.Rows(0).Item(2))
            tb_contactnum.Text = dt.Rows(0).Item(3)
            tb_securitynum.Text = dt.Rows(0).Item(4)
            tb_address.Text = dt.Rows(0).Item(5)
            tb_username.Text = dt.Rows(0).Item(6)
            tb_nationality.Text = dt.Rows(0).Item(8)
            tb_email.Text = dt.Rows(0).Item(9)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tb_contactnum_KeyPress(sender As Object, e As KeyPressEventArgs)
        If tb_contactnum.Text.Trim.Length = 0 AndAlso Not e.KeyChar = "0" Then
            e.Handled = True
        ElseIf tb_contactnum.Text.Trim.Length >= 11 Then
            If (Asc(e.KeyChar) = 8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Else
            If ((Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) <= 57) Or
                (Asc(e.KeyChar) = 8)) Then

                ' MessageBox.Show("Valid")
            Else
                ' MessageBox.Show("Not Valid")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs)
        If tb_fname.Text.Trim = "" Or
            tb_lname.Text.Trim = "" Or
            tb_age.Text.Trim = "" Or
            tb_contactnum.Text.Trim = "" Or
            tb_securitynum.Text.Trim = "" Or
            tb_address.Text.Trim = "" Or
            tb_username.Text.Trim = "" Or
            tb_nationality.Text.Trim = "" Or
            tb_email.Text.Trim = "" Then
            MessageBox.Show("Please Fill all the required fields.")
        Else
            Dim con As SqlClient.SqlConnection
            Dim da As SqlClient.SqlDataAdapter
            Dim command As SqlClient.SqlCommand
            Dim dt As DataTable
            Dim query As String = ""

            Try
                con = New SqlClient.SqlConnection
                con.ConnectionString = connection.getConnectionString()
                con.Open()

                ' Update current user
                query = "UPDATE users SET 
	                    first_name = '" & tb_fname.Text.Trim & "',
	                    last_name = '" & tb_lname.Text.Trim & "',
	                    age = " & tb_age.Text.Trim & ",
	                    contact_number = '" & tb_contactnum.Text.Trim & "',
	                    social_security_number = '" & tb_securitynum.Text.Trim & "',
	                    address = '" & tb_address.Text.Trim & "',
	                    username = '" & tb_username.Text.Trim & "',
	                    email = '" & tb_email.Text.Trim & "',
	                    nationality = '" & tb_nationality.Text.Trim & "'
                    FROM users
                    WHERE id = 1"

                command = New SqlClient.SqlCommand(query, con)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()

                ' Updating the Grid View
                query = "SELECT 
	                    first_name,
	                    last_name,
	                    age,
	                    contact_number,
	                    social_security_number,
	                    address,
	                    username,
	                    password,
	                    email,
	                    nationality
                    FROM users
                    WHERE id = 1"

                command = New SqlClient.SqlCommand(query, con)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()

                da = New SqlClient.SqlDataAdapter
                dt = New DataTable

                da.SelectCommand = command
                da.Fill(dt)

                tb_fname.Text = dt.Rows(0).Item(0)
                tb_lname.Text = dt.Rows(0).Item(1)
                tb_age.Text = dt.Rows(0).Item(2)
                tb_contactnum.Text = dt.Rows(0).Item(3)
                tb_securitynum.Text = dt.Rows(0).Item(4)
                tb_address.Text = dt.Rows(0).Item(5)
                tb_username.Text = dt.Rows(0).Item(6)
                tb_nationality.Text = dt.Rows(0).Item(8)
                tb_email.Text = dt.Rows(0).Item(9)

                MessageBox.Show("Successfully Updated!")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MessageBox.Show(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btn_records_Click(sender As Object, e As EventArgs)
        seeUsers.loadUsers()
        seeUsers.ShowDialog()
    End Sub

    Private Sub btn_update_Click_1(sender As Object, e As EventArgs) Handles btn_update.Click
        If tb_fname.Text.Trim = "" Or
            tb_lname.Text.Trim = "" Or
            tb_age.Text.Trim = "" Or
            tb_contactnum.Text.Trim = "" Or
            tb_securitynum.Text.Trim = "" Or
            tb_address.Text.Trim = "" Or
            tb_username.Text.Trim = "" Or
            tb_nationality.Text.Trim = "" Or
            tb_email.Text.Trim = "" Then
            MessageBox.Show("Please Fill all the required fields.")
        Else
            Dim con As SqlClient.SqlConnection
            Dim da As SqlClient.SqlDataAdapter
            Dim command As SqlClient.SqlCommand
            Dim dt As DataTable
            Dim query As String = ""

            Try
                con = New SqlClient.SqlConnection
                con.ConnectionString = connection.getConnectionString()
                con.Open()

                ' Update current user
                query = "UPDATE users SET 
	                    first_name = '" & tb_fname.Text.Trim & "',
	                    last_name = '" & tb_lname.Text.Trim & "',
	                    age = " & tb_age.Text.Trim & ",
	                    contact_number = '" & tb_contactnum.Text.Trim & "',
	                    social_security_number = '" & tb_securitynum.Text.Trim & "',
	                    address = '" & tb_address.Text.Trim & "',
	                    username = '" & tb_username.Text.Trim & "',
	                    email = '" & tb_email.Text.Trim & "',
	                    nationality = '" & tb_nationality.Text.Trim & "'
                    FROM users
                    WHERE id = 1"

                command = New SqlClient.SqlCommand(query, con)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()

                ' Updating the Grid View
                query = "SELECT 
	                    first_name,
	                    last_name,
	                    age,
	                    contact_number,
	                    social_security_number,
	                    address,
	                    username,
	                    password,
	                    email,
	                    nationality
                    FROM users
                    WHERE id = 1"

                command = New SqlClient.SqlCommand(query, con)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()

                da = New SqlClient.SqlDataAdapter
                dt = New DataTable

                da.SelectCommand = command
                da.Fill(dt)

                tb_fname.Text = dt.Rows(0).Item(0)
                tb_lname.Text = dt.Rows(0).Item(1)
                tb_age.Text = dt.Rows(0).Item(2)
                tb_contactnum.Text = dt.Rows(0).Item(3)
                tb_securitynum.Text = dt.Rows(0).Item(4)
                tb_address.Text = dt.Rows(0).Item(5)
                tb_username.Text = dt.Rows(0).Item(6)
                tb_nationality.Text = dt.Rows(0).Item(8)
                tb_email.Text = dt.Rows(0).Item(9)

                MessageBox.Show("Successfully Updated!")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MessageBox.Show(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btn_records_Click_1(sender As Object, e As EventArgs) Handles btn_records.Click
        seeUsers.loadUsers()
        seeUsers.ShowDialog()
    End Sub
End Class