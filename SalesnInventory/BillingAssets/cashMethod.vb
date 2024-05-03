Public Class cashMethod
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If (moneyTextBox.Text.Trim >= Bills.transacTotal) Then

            'MessageBox.Show("Total " & Bills.transacTotal & " Money: " & moneyTextBox.Text.Trim, "Test")

            'Return
            Dim con As New SqlClient.SqlConnection
            Dim command As SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim query As String = ""
            Dim change As Decimal = Convert.ToDouble(moneyTextBox.Text.Trim) - Convert.ToDouble(Bills.transacTotal)
            Dim now As DateTime = DateTime.Now()
            Dim formattedTime As String = now.ToString("MM/dd/yyyy hh:mm:ss tt")


            Try
                con.ConnectionString = connection.getConnectionString()
                con.Open()

                query = "UPDATE transactions 
                         SET 
                            transaction_total = " & Bills.transacTotal & ", 
                            transaction_money = " & moneyTextBox.Text.Trim & ", 
                            transaction_change = " & change & ", 
                            transaction_status = 1,
                            transaction_date = " & formattedTime & "
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

                MessageBox.Show("Transaction Complete!" & vbNewLine & "Change: " & change)


            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MessageBox.Show(ex.StackTrace)
            End Try
        Else
            MessageBox.Show("Not enough money")
        End If

    End Sub

    Private Sub cashMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub moneyTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles moneyTextBox.KeyPress
        Dim price As String = moneyTextBox.Text.Trim

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