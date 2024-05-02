Public Class addCar
    Private Sub cancelCarBtn_Click(sender As Object, e As EventArgs) Handles cancelCarBtn.Click
        Me.Close()
    End Sub

    Private Sub addCarBtn_Click(sender As Object, e As EventArgs) Handles addCarBtn.Click
        Dim carName As String = carNameTxtBox.Text.Trim()
        Dim carModel As String = carModelTxtBox.Text.Trim()

        If carName = "" Or carModel = "" Then
            MessageBox.Show("Please fill up all the fields")
        Else
            Try
                Dim con As SqlClient.SqlConnection = New SqlClient.SqlConnection
                con.ConnectionString = connection.getConnectionString()
                con.Open()

                Dim sql As String = "INSERT INTO cars (car_name, car_model) VALUES ('" & carName & "', '" & carModel & "')"
                Dim cmd As New SqlClient.SqlCommand(sql, con)
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()

                MessageBox.Show("Successfully Added!")
                addStocks.loadCarList()
                Me.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub addCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub
End Class