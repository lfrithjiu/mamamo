Public Class lendMethod
    Dim price As Double = 0
    Private Sub lendMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        lendDays.Text = "Select"

        price = Convert.ToDouble(Bills.totalPrice.Text.Trim())
        totalPrice.Text = price
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Add to lendings table
        Dim companyName As String = compName.Text.Trim()
        Dim companyLocation As String = compLocation.Text.Trim()
        Dim shopName As String = shopNameBox.Text.Trim()
        Dim days As Integer = Convert.ToInt32(lendDays.SelectedItem())
        Dim currentDate As DateTime = DateTime.Now

        If companyName = "" Or companyLocation = "" Or shopName = "" Then
            MessageBox.Show("Please fill up all the fields")
        ElseIf Not days = 30 And Not days = 60 And Not days = 90 Then
            MessageBox.Show("Days selection must only be 30, 60 or 90")
        Else
            Dim con As New SqlClient.SqlConnection
            Dim command As SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim query As String = ""

            Try
                query = "INSERT INTO lendings (
                            company_name, 
                            company_location,
                            shop_name,
                            duration_day,
                            start_date,
                            last_date,
                            transaction_id
                         )
                         VALUES (
                            '" & companyName & "',
                            '" & companyLocation & "',
                            '" & shopName & "',
                            '" & days & "',
                            '" & currentDate & "',
                            '" & DateAdd("d", days, currentDate) & "',
                            '" & Bills.transacID & "'
                         )"

                con.ConnectionString = connection.getConnectionString()
                con.Open()

                command = New SqlClient.SqlCommand(query, con)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()

                ' Update Transaction
                query = "UPDATE transactions 
                         SET 
                            transaction_total = " & Bills.transacTotal & ", 
                            transaction_money = 0, 
                            transaction_change = 0, 
                            transaction_status = 2
                        WHERE 
                            transaction_status = 0;"
                command = New SqlClient.SqlCommand(query, con)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()


                ' Add new Transaction
                query = "INSERT INTO transactions (transaction_date, transaction_total, transaction_money, transaction_change, transaction_status)
                     VALUES (GETDATE(), 0, 0, 0, 0)"
                command = New SqlClient.SqlCommand(query, con)
                command.ExecuteNonQuery()

                ' Update Transaction Number
                query = "SELECT id FROM transactions WHERE transaction_status = 0"
                command = New SqlClient.SqlCommand(query, con)
                command.ExecuteNonQuery()

                da = New SqlClient.SqlDataAdapter
                dt = New DataTable
                da.SelectCommand = command
                da.Fill(dt)

                Bills.transacNumberTxtBox.Text = dt.Rows(0).Item(0)
                Bills.transacID = dt.Rows(0).Item(0)

                ' Refresh the TransactionList
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
                Bills.selectedRowQuantity = Nothing

                ' Update Inventory 
                Dim getAllStocks As String = "SELECT stocks.id AS 'Stock ID', products.id AS 'Product ID', products.product_name AS 'Product Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id;"
                Inventory.fillStocksDataGridView(getAllStocks)
                Inventory.cb_stockStatus.Text = "All"

                Me.Close()

                MessageBox.Show("Lending Transaction Complete!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MessageBox.Show(ex.StackTrace)
            End Try
        End If
    End Sub
End Class