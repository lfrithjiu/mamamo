Public Class addUser

    Dim AGE As String = ""
    Private Sub addUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        load_genders()
        load_civilStatus()
    End Sub
    Public Sub load_genders()
        Try
            Dim con As SqlClient.SqlConnection

            con = New SqlClient.SqlConnection
            con.ConnectionString = connection.getConnectionString()
            con.Open()

            Dim sql As String = "SELECT id, gender FROM genders"
            Dim cmd2 As New SqlClient.SqlCommand(sql, con)

            cmd2.CommandType = CommandType.Text
            Dim da3 As New SqlClient.SqlDataAdapter
            da3.SelectCommand = cmd2
            Dim dt2 As New DataTable
            If da3.Fill(dt2) Then
                cb_gender.DataSource = dt2
                cb_gender.Text = "Choose a Gender"
                cb_gender.DisplayMember = "gender"
                cb_gender.ValueMember = "id"
            Else
                cb_gender.DataSource = Nothing
                cb_gender.Text = "No Genders"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub load_civilStatus()
        Try
            Dim con As SqlClient.SqlConnection

            con = New SqlClient.SqlConnection
            con.ConnectionString = connection.getConnectionString()
            con.Open()

            Dim sql As String = "SELECT id, civil_status FROM civil_statuses"
            Dim cmd2 As New SqlClient.SqlCommand(sql, con)

            cmd2.CommandType = CommandType.Text
            Dim da3 As New SqlClient.SqlDataAdapter
            da3.SelectCommand = cmd2
            Dim dt2 As New DataTable
            If da3.Fill(dt2) Then
                cb_civilstat.DataSource = dt2
                cb_civilstat.Text = "Choose a status"
                cb_civilstat.DisplayMember = "civil_status"
                cb_civilstat.ValueMember = "id"
            Else
                cb_civilstat.DataSource = Nothing
                cb_civilstat.Text = "No Genders"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tb_contactnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_contactnum.KeyPress
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

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    ' Function to calculate age given a birth date
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

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        If tb_fname.Text.Trim = "" Or
            tb_lname.Text.Trim = "" Or
            tb_contactnum.Text.Trim = "" Or
            tb_securitynum.Text.Trim = "" Or
            tb_address.Text.Trim = "" Or
            tb_username.Text.Trim = "" Or
            tb_password.Text.Trim = "" Or
            tb_nationality.Text.Trim = "" Or
            tb_email.Text.Trim = "" Then
            MessageBox.Show("Please Fill all the required fields.")
        ElseIf cb_userType.SelectedItem = Nothing Or cb_userType.SelectedItem = "" Then
            MessageBox.Show("Please select a user type.")
        Else
            Dim con As SqlClient.SqlConnection
            Dim command As SqlClient.SqlCommand
            Dim query As String

            Try
                con = New SqlClient.SqlConnection
                con.ConnectionString = connection.getConnectionString()
                con.Open()

                Dim user As Integer = userGetter(cb_userType.SelectedItem)


                ' Check if contact number, social security number and email if its unique
                query = "SELECT * FROM users WHERE contact_number = '" & tb_contactnum.Text.Trim & "' OR
                     social_security_number = '" & tb_securitynum.Text.Trim & "' AND
                     email = '" & tb_email.Text.Trim & "'"

                command = New SqlClient.SqlCommand(query, con)
                command.ExecuteNonQuery()

                Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
                Dim dt As DataTable = New DataTable
                da.SelectCommand = command
                da.Fill(dt)

                If (dt.Rows.Count > 0) Then
                    MessageBox.Show("This information you entered may already 
                       exist in parts of email, social security number or contact number")
                Else
                    ' Get Age First
                    AGE = GetAge(tb_birthdate.Value)

                    query = "INSERT INTO users (first_name, last_name, address, 
                            nationality, birthdate, age, contact_number, 
                            social_security_number, email,
                            username, password, user_type, gender, civil_status)
                            VALUES(
	                            '" & tb_fname.Text.Trim & "', 
	                            '" & tb_lname.Text.Trim & "', 
	                            '" & tb_address.Text.Trim & "', 
	                            '" & tb_nationality.Text.Trim & "', 
	                            '" & tb_birthdate.Value.Date & "', 
	                             " & AGE & ",
	                            '" & tb_contactnum.Text.Trim & "', 
	                            '" & tb_securitynum.Text.Trim & "', 
	                            '" & tb_email.Text.Trim & "', 
	                            '" & tb_username.Text.Trim & "', 
	                            '" & tb_password.Text.Trim & "', 
	                            " & user & ", " & cb_gender.SelectedValue & ", 
                                " & cb_civilstat.SelectedValue & ");"

                    command = New SqlClient.SqlCommand(query, con)
                    command.CommandType = CommandType.Text
                    command.ExecuteNonQuery()

                    MessageBox.Show("Successfully added!")
                    seeUsers.loadUsers()
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MessageBox.Show(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Function userGetter(ByVal type As String) As Integer
        Dim userType As Integer = 0

        Select Case (type)
            Case "Admin"
                userType = 3
            Case "Manager"
                userType = 2
            Case "Cashier"
                userType = 1
        End Select

        Return userType
    End Function

    Private Sub tb_securitynum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_securitynum.KeyPress

        If tb_securitynum.Text.Trim.Length >= 10 Then
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
End Class