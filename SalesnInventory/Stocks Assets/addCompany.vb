Public Class addCompany
    Private Sub cancelCompanyBtn_Click(sender As Object, e As EventArgs) Handles cancelCompanyBtn.Click
        Me.Close()
    End Sub

    Private Sub addCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub addCompanyBtn_Click(sender As Object, e As EventArgs) Handles addCompanyBtn.Click
        Dim companyName As String = companyNameTxtBox.Text.Trim()
        Dim companyLocation As String = companyLocationTxtBox.Text.Trim()

        If companyName = "" Or companyLocation = "" Then
            MessageBox.Show("Please fill up all the fields")
        Else
            Try
                Dim con As SqlClient.SqlConnection = New SqlClient.SqlConnection
                con.ConnectionString = connection.getConnectionString()
                con.Open()

                Dim sql As String = "INSERT INTO companies (company_name, company_location) VALUES ('" & companyName & "', '" & companyLocation & "')"
                Dim cmd As New SqlClient.SqlCommand(sql, con)
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()

                MessageBox.Show("Successfully Added!")
                addStocks.loadCompanyList()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class