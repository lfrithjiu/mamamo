Imports System.Data.SqlClient
Imports TheArtOfDevHtmlRenderer

Public Class updateProduct
    Dim prodID As Integer

    Public Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        prodID = id

        Dim query As String
        Dim con As SqlClient.SqlConnection
        Dim command As SqlClient.SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataTable
        Try
            query = "SELECT product_code, product_name, product_price, product_description FROM products WHERE id = " & prodID & ""

            con = New SqlClient.SqlConnection
            con.ConnectionString = connection.getConnectionString()
            con.Open()

            command = New SqlClient.SqlCommand(query, con)
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()

            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            con.Dispose()

            prodCode.Text = ds.Rows(0).Item(0)
            prodName.Text = ds.Rows(0).Item(1)
            prodPrice.Text = ds.Rows(0).Item(2)
            prodDesc.Text = ds.Rows(0).Item(3)
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub updateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim query As String
        Dim con As SqlClient.SqlConnection
        Dim command As SqlClient.SqlCommand

        Dim name = prodName.Text.Trim()
        Dim price = Convert.ToDouble(prodPrice.Text.Trim())
        Dim desc = prodDesc.Text.Trim()
        Dim code = prodCode.Text.Trim()

        Try
            query = "UPDATE products SET product_name = '" & name & "', product_price = " & price & ", product_description = '" & desc & "'
                    WHERE product_code = '" & code & "'"

            con = New SqlClient.SqlConnection
            con.ConnectionString = connection.getConnectionString()
            con.Open()

            command = New SqlClient.SqlCommand(query, con)
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()

            MessageBox.Show("Successfully Updated!")

            Dim getAllProducts As String = "SELECT id AS 'ID', product_code AS 'Product Code', product_name AS 'Name', product_description AS 'Description', product_price AS 'Price', product_status AS 'Status' FROM products WHERE product_status = '" & Inventory.filterProduct & "';"
            Inventory.fillDataGridView(getAllProducts)
            Inventory.prodID = Nothing

            prodCode.Text = ""
            prodName.Text = ""
            prodPrice.Text = ""
            prodDesc.Text = ""

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
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