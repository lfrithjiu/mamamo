Public Class Admin
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        'this is magic code that has an enormous positive effect on reducing flickering.
        'don't remove this.
        'found this nugget here: http://www.vbmigration.com/detknowledgebase.aspx?Id=692
        Get
            Dim params As CreateParams = MyBase.CreateParams
            params.ExStyle = params.ExStyle Or &H2000000
            Return params
        End Get
    End Property
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        If adminUsernameBox.Text.Trim = "" Or adminPasswordBox.Text.Trim = "" Then
            MessageBox.Show("Please fill all the fields.")
        Else
            Dim con As SqlClient.SqlConnection
            Dim da As SqlClient.SqlDataAdapter
            Dim command As SqlClient.SqlCommand
            Dim dt As DataTable
            Dim query As String = ""

            Try
                Dim user As String = adminUsernameBox.Text.Trim
                Dim pass As String = adminPasswordBox.Text.Trim

                con = New SqlClient.SqlConnection
                con.ConnectionString = connection.getConnectionString()
                con.Open()

                query = "SELECT id, * FROM users WHERE user_type = 3 AND username = '" & user & "' AND password = '" & pass & "'"

                command = New SqlClient.SqlCommand(query, con)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()

                da = New SqlClient.SqlDataAdapter
                da.SelectCommand = command

                dt = New DataTable
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    Users.setUserID(dt.Rows(0).Item(0))

                    Form1.Button1.Enabled = True
                    Form1.Button2.Enabled = True
                    Form1.Button3.Enabled = True
                    Form1.Button5.Enabled = True
                    Form1.Button7.Enabled = True
                    Form1.Button7.Visible = True
                    Form1.ShowDialog()
                    Me.Close()

                    Dashboard.Close()
                    Users.Close()
                    Bills.Close()
                    Inventory.Close()

                    Form1.Label3.Text = "WELCOME ADMIN"
                Else
                    MessageBox.Show("Wrong Credentials")
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MessageBox.Show(ex.StackTrace)
            End Try
        End If

    End Sub

End Class