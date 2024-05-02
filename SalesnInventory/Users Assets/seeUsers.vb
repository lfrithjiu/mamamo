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
                        user_type AS 'Type',
                        first_name AS 'First Name',
	                    last_name AS 'Last Name',
	                    age AS 'Age',
	                    contact_number AS 'Contact',
	                    social_security_number AS 'SSN',
	                    address AS 'Address',
	                    username AS 'Username',
	                    password AS 'Password',
	                    email AS 'E-mail',
	                    nationality AS 'Nationality' 
                FROM users"
            command = New SqlClient.SqlCommand(query, con)
            command.CommandType = CommandType.Text

            da = New SqlClient.SqlDataAdapter
            dt = New DataTable

            da.SelectCommand = command
            da.Fill(dt)

            ' Get All
            userGridView.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub seeUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub
End Class