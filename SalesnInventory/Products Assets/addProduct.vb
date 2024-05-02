Imports System.Data.SqlClient

Public Class addProduct
    Private Sub addProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim code As String = prodCode.Text.Trim()
        Dim name As String = prodName.Text.Trim()
        Dim desc As String = prodDesc.Text.Trim()
        Dim price As String = prodPrice.Text.Trim()

        If code = "" Or name = "" Or desc = "" Or price = "" Then
            MessageBox.Show("Please fill all the fields")
        ElseIf code.Length <> 8 Then
            MessageBox.Show("Product Code must be 8 Characters")
        ElseIf price = "0" Then
            MessageBox.Show("Price must be more than 0")
        Else
            Dim query As String
            Dim con As SqlClient.SqlConnection
            Dim command As SqlClient.SqlCommand
            Dim adapter As New SqlDataAdapter
            Dim ds As New DataSet

            Try
                query = "SELECT * FROM products WHERE product_code = '" & code & "'"

                con = New SqlClient.SqlConnection
                con.ConnectionString = connection.getConnectionString()
                con.Open()

                command = New SqlClient.SqlCommand(query, con)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()

                adapter.SelectCommand = command
                adapter.Fill(ds, "products")
                adapter.Dispose()
                command.Dispose()
                con.Dispose()

                If ds.Tables(0).Rows.Count >= 1 Then
                    MessageBox.Show("Product Code already exist. Enter a new one.")
                Else
                    Dim newPrice As Double = CDbl(price)
                    query = "INSERT INTO products (product_code, product_name, product_description, product_price, product_status)
                                    VALUES ('" & code & "', '" & name & "', '" & desc & "', " & newPrice & ", 'Activated')"

                    con = New SqlClient.SqlConnection
                    con.ConnectionString = connection.getConnectionString()
                    con.Open()

                    command = New SqlClient.SqlCommand(query, con)
                    command.CommandType = CommandType.Text
                    command.ExecuteNonQuery()

                    MessageBox.Show("Successfully Added!")

                    Dim getAllProducts As String = "SELECT id AS 'ID', product_code AS 'Product Code', product_name AS 'Name', product_description AS 'Description', product_price AS 'Price', product_status AS 'Status' FROM products WHERE product_status = '" & Inventory.filterProduct & "';"
                    Inventory.fillDataGridView(getAllProducts)
                    Inventory.prodID = Nothing

                    prodCode.Text = ""
                    prodName.Text = ""
                    prodPrice.Text = ""
                    prodDesc.Text = ""

                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub prodCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles prodCode.KeyPress
        If prodCode.Text.Trim.Length >= 8 Then
            If (Asc(e.KeyChar) = 8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Else
            If ((Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) <= 57) Or
                (Asc(e.KeyChar) >= 65 AndAlso Asc(e.KeyChar) <= 90) Or
                (Asc(e.KeyChar) >= 97 AndAlso Asc(e.KeyChar) <= 122) Or
                (Asc(e.KeyChar) = 8)) Then

                ' MessageBox.Show("Valid")
            Else
                ' MessageBox.Show("Not Valid")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub prodPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles prodPrice.KeyPress
        Dim price As String = prodPrice.Text.Trim

        If ((Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) <= 57) Or
            (Asc(e.KeyChar) = 8) Or
            (Asc(e.KeyChar) = 46)) Then

            If (Asc(e.KeyChar) = 46 AndAlso price.Contains(".")) Then
                e.Handled = True
            End If
        Else
            e.Handled = True
        End If
    End Sub

End Class