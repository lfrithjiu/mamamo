Public Class addOrder
    Public Property stockID As Integer = Nothing
    Dim isSelected As Boolean = False

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim con As SqlClient.SqlConnection
        Dim command As SqlClient.SqlCommand
        Dim adapter As SqlClient.SqlDataAdapter
        Dim query As String
        Dim dt As DataTable

        If stockID = Nothing Or isSelected = False Then
            Return
        End If

        Try
            query = "SELECT 
	                    products.product_code As 'Product Code',	
	                    products.product_name AS 'Product Name', 
	                    products.product_price As 'Price', 
	                    stocks.quantity As 'Quantity', 
	                    carTB.id As 'Car ID', 
	                    companies.id AS 'Company ID',
	                    stocks.id AS 'Stock ID'
                    FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id WHERE stocks.id = " & Me.stockID & ""

            con = New SqlClient.SqlConnection
            con.ConnectionString = connection.getConnectionString()
            con.Open()

            command = New SqlClient.SqlCommand(query, con)
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()

            adapter = New SqlClient.SqlDataAdapter
            adapter.SelectCommand = command
            dt = New DataTable
            adapter.Fill(dt)

            Dim prodCode As String = dt.Rows(0).Item(0)
            Dim product As String = dt.Rows(0).Item(1)
            Dim price As Decimal = dt.Rows(0).Item(2)
            Dim quan As Integer = 1
            Dim carID As Integer = dt.Rows(0).Item(4)
            Dim companyID As Integer = dt.Rows(0).Item(5)
            Dim stockID As Integer = dt.Rows(0).Item(6)
            Dim transacID As Integer = Bills.transacID
            Dim stockQuantity As Integer = dt.Rows(0).Item(3)

            ' Check if the selected item already exist in the order item list
            query = "SELECT item_stock_id FROM order_items WHERE item_stock_id = " & stockID & " AND transaction_id = " & Bills.transacID
            command = New SqlClient.SqlCommand(query, con)
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()

            dt = New DataTable
            Dim dataAdap As New SqlClient.SqlDataAdapter()
            dataAdap.SelectCommand = command
            dataAdap.Fill(dt)

            If (dt.Rows.Count > 0) Then
                MessageBox.Show("Item is already selected, You may add quantity into it")
                Return
            End If

            query = "INSERT INTO order_items (item_prodCode, item_product, item_price, item_quantity, 
            item_car_id, item_company_id, item_stock_id, transaction_id)
            VALUES ('" & prodCode & "','" & product & "'," & price & ", " & quan & "," & carID & "," & companyID & "
            ," & stockID & "," & transacID & ")"


            command = New SqlClient.SqlCommand(query, con)
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()

            Dim getAllItems As String = "SELECT 
	                                        order_items.id As '#', 
	                                        item_product As 'Product',
	                                        item_price As 'Price',
	                                        item_quantity As 'Quantity',
	                                        cars.car_name As 'Car',
	                                        companies.company_name As 'Company'
                                        FROM order_items
                                        INNER JOIN 
	                                        cars ON
	                                        order_items.item_car_id = cars.id
                                        INNER JOIN 
	                                        companies ON
	                                        order_items.item_company_id = companies.id
                                        WHERE 
                                            order_items.transaction_id = " & Bills.transacID
            Bills.transactionList(getAllItems)
            Bills.orderID = Nothing

            ' Update Stocks by decreasing its quantity on stocks
            Dim newStock As Integer = stockQuantity - 1
            query = "UPDATE stocks SET quantity = " & newStock & " WHERE id = " & stockID
            command = New SqlClient.SqlCommand(query, con)
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()

            ' Update Inventory 
            Dim getAllStocks As String = "SELECT stocks.id AS 'Stock ID', products.id AS 'Product ID', products.product_name AS 'Product Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id;"
            Inventory.fillStocksDataGridView(getAllStocks)
            Inventory.cb_stockStatus.Text = "All"

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub addOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub resultGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles resultGrid.CellClick
        stockID = resultGrid.Rows(e.RowIndex).Cells(0).Value
        isSelected = True
    End Sub
End Class