Public Class Bills

    Public Property orderID As Integer = Nothing
    Public Property selectedRowQuantity As Integer = Nothing
    Dim isSelected As Boolean = False

    Public Property transacID As Integer = Nothing
    Public Property transacTotal As Decimal = 0

    Private Sub Bills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con1 As SqlClient.SqlConnection
        Dim da3 As SqlClient.SqlDataAdapter
        Dim dt2 As DataTable
        Dim sql As String = "SELECT id FROM transactions WHERE transaction_status = 0"

        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = connection.getConnectionString()
            con1.Open()

            Dim command As SqlClient.SqlCommand = New SqlClient.SqlCommand(sql, con1)
            command.CommandType = CommandType.Text
            da3 = New SqlClient.SqlDataAdapter()
            da3.SelectCommand = command
            dt2 = New DataTable
            da3.Fill(dt2)

            If dt2.Rows.Count = 0 Then
                sql = "INSERT INTO transactions (transaction_date, transaction_total, transaction_status, transaction_money, transaction_change)
                        VALUES (GETDATE(), 0, 0, 0, 0)"
                command = New SqlClient.SqlCommand(sql, con1)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()

                sql = "SELECT id FROM transactions WHERE transaction_status = 0;"
                command = New SqlClient.SqlCommand(sql, con1)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()

                da3 = New SqlClient.SqlDataAdapter()
                da3.SelectCommand = command
                dt2 = New DataTable
                da3.Fill(dt2)
            End If

            transacID = dt2.Rows(0).Item(0)
            transacNumberTxtBox.Text = transacID

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
											order_items.transaction_id = " & transacID
            transactionList(getAllItems)
            orderID = Nothing
            selectedRowQuantity = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.StackTrace)

        End Try
    End Sub

    Public Sub transactionList(ByVal sql As String)
        Dim con1 As SqlClient.SqlConnection
        Dim da3 As SqlClient.SqlDataAdapter
        Dim dt2 As DataTable

        transacTotal = 0

        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = connection.getConnectionString()
            con1.Open()

            Dim command As SqlClient.SqlCommand = New SqlClient.SqlCommand(sql, con1)
            da3 = New SqlClient.SqlDataAdapter()
            da3.SelectCommand = command
            dt2 = New DataTable
            da3.Fill(dt2)
            transactionListGrid.DataSource = dt2

            ' Set Sizes
            transactionListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            For Each row As DataRow In dt2.Rows
                Dim price As Decimal = row("Price")
                Dim quan As Decimal = row("Quantity")

                transacTotal += (price * quan)
            Next row

            totalPrice.Text = transacTotal

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles searchProduct.KeyPress

        If (searchProduct.Text.Trim.Length = 8 AndAlso Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8) Then
            e.Handled = True
            Return
        End If

        If Asc(e.KeyChar) = 13 Then
            Dim productCode As String = searchProduct.Text.Trim()

            ' Select from database if the code value exist
            Dim con1 As SqlClient.SqlConnection
            Dim da3 As SqlClient.SqlDataAdapter
            Dim dt2 As DataTable
            Dim sql As String = "SELECT 
                                    stocks.id As 'ID',
	                                products.product_name AS 'Product',
	                                cars.car_name AS 'Car Name',
	                                cars.car_model AS 'Car Model',
	                                companies.company_name AS 'Company'
                                FROM stocks

                                INNER JOIN products ON stocks.product_id = products.id
                                INNER JOIN companies ON stocks.company_id = companies.id
                                INNER JOIN cars ON stocks.car_id = cars.id
                                WHERE products.product_code = '" & searchProduct.Text.Trim & "' AND 
                                products.product_status = 'Activated' AND stocks.quantity > 0"

            Try

                con1 = New SqlClient.SqlConnection
                con1.ConnectionString = connection.getConnectionString()
                con1.Open()

                Dim command As SqlClient.SqlCommand = New SqlClient.SqlCommand(sql, con1)
                command.CommandType = CommandType.Text
                da3 = New SqlClient.SqlDataAdapter()
                da3.SelectCommand = command
                dt2 = New DataTable
                da3.Fill(dt2)

                If dt2.Rows.Count >= 1 Then
                    addOrder.resultGrid.DataSource = dt2

                    ' Set Sizes
                    addOrder.resultGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    addOrder.ShowDialog()

                Else
                    MessageBox.Show("No Result")
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MessageBox.Show(ex.StackTrace)

            End Try
        ElseIf (Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) <= 57) Or
                (Asc(e.KeyChar) >= 65 AndAlso Asc(e.KeyChar) <= 90) Or
                (Asc(e.KeyChar) >= 97 AndAlso Asc(e.KeyChar) <= 122) Or
                (Asc(e.KeyChar) = 8) Then

            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub transactionListGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles transactionListGrid.CellClick
        Try
            orderID = Convert.ToInt32(transactionListGrid.Rows(e.RowIndex).Cells(0).Value)
            selectedRowQuantity = Convert.ToInt32(transactionListGrid.Rows(e.RowIndex).Cells(3).Value)
            isSelected = True
        Catch ex As Exception
            orderID = Nothing
            selectedRowQuantity = Nothing
            isSelected = False
        End Try
    End Sub

    Private Sub addQtyBtn_Click_1(sender As Object, e As EventArgs) Handles addQtyBtn.Click
        ' Add Quantity to current selected row
        If isSelected AndAlso Not orderID = Nothing Then
            ' selectedRowIndex has the row for getting the row index cell id of transaction order

            ' change the cell quantity by showing a inputBox
            Dim addQuantityDialog = New addQuantity(orderID, selectedRowQuantity)
            addQuantityDialog.ShowDialog()
        End If
    End Sub

    Private Sub newTransacBtn_Click_1(sender As Object, e As EventArgs) Handles newTransacBtn.Click
        ' Clear the datagridview
        Dim con As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim query As String = ""
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As DataTable

        con.ConnectionString = connection.getConnectionString()

        Try
            ' Getting back the stocks quantity
            con.Open()

            query = "SELECT * FROM order_items WHERE transaction_id = " & transacID
            command = New SqlClient.SqlCommand(query, con)
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()

            da = New SqlClient.SqlDataAdapter
            da.SelectCommand = command
            dt = New DataTable
            da.Fill(dt)

            For i = 0 To dt.Rows.Count - 1
                ' 4 , 7
                Dim stockQuantity As Integer = dt.Rows(i).Item(4)
                Dim stockIDTrav As Integer = dt.Rows(i).Item(7)

                ' Get Current Stock Quantity
                query = "SELECT quantity FROM stocks WHERE id = " & stockIDTrav
                command = New SqlClient.SqlCommand(query, con)
                command.ExecuteNonQuery()

                Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
                da1.SelectCommand = command
                Dim dt1 As DataTable = New DataTable
                da1.Fill(dt1)

                Dim quan As Integer = dt1.Rows(0).Item(0)
                Dim quantityResult As Integer = Math.Abs(quan + stockQuantity)

                ' Update The stock
                query = "UPDATE stocks SET quantity = " & quantityResult & " WHERE id = " & stockIDTrav
                command = New SqlClient.SqlCommand(query, con)
                command.ExecuteNonQuery()

            Next

            ' Clearing order items
            query = "DELETE FROM order_items WHERE transaction_id = " & transacID
            command = New SqlClient.SqlCommand(query, con)
            command.ExecuteNonQuery()

            ' Add new Transaction
            query = "UPDATE transactions SET transaction_status = 3 WHERE transaction_status = 0; 
                     INSERT INTO transactions (transaction_date, transaction_total, transaction_money, transaction_change, transaction_status)
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

            transacNumberTxtBox.Text = dt.Rows(0).Item(0)

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
											order_items.transaction_id = " & transacID
            transactionList(getAllItems)
            orderID = Nothing
            selectedRowQuantity = Nothing
            isSelected = False

            ' Update Inventory 
            Dim getAllStocks As String = "SELECT stocks.id AS 'Stock ID', products.id AS 'Product ID', products.product_name AS 'Product Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id;"
            Inventory.fillStocksDataGridView(getAllStocks)
            Inventory.cb_stockStatus.Text = "All"

            MessageBox.Show("New Transaction.")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub voidBtn_Click_1(sender As Object, e As EventArgs) Handles voidBtn.Click
        ' Remove the product of the current selected row

        If isSelected AndAlso Not orderID = Nothing Then
            ' selectedRowIndex has the row for getting the row index cell id of transaction order

            ' remove the row by showing a inputBox to input manager's or admin's password
            ' Dim password As String

            ' Check if password has matched password from database user admin or manager

            ' Removing Process
            Try
                Dim con As New SqlClient.SqlConnection
                Dim da As New SqlClient.SqlDataAdapter
                Dim command As New SqlClient.SqlCommand
                Dim dt As New DataTable
                Dim query As String = ""

                query = "SELECT item_stock_id, item_quantity FROM order_items WHERE id = " & orderID
                con.ConnectionString = connection.getConnectionString()
                con.Open()

                command = New SqlClient.SqlCommand(query, con)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()

                da.SelectCommand = command
                da.Fill(dt)

                Dim selectedStockID = dt.Rows(0).Item(0)
                Dim selectedQuantity = dt.Rows(0).Item(1)

                ' Get the quantity Stocks
                query = "SELECT quantity FROM stocks WHERE id = " & selectedStockID
                command = New SqlClient.SqlCommand(query, con)
                command.ExecuteNonQuery()

                da.SelectCommand = command
                dt = New DataTable
                da.Fill(dt)

                Dim stockQuantity As Integer = dt.Rows(0).Item(0)

                ' Updating the stocks quantity
                Dim quantityResult As Integer = Math.Abs(selectedQuantity + stockQuantity)
                query = "UPDATE stocks SET quantity = " & quantityResult & " WHERE id = " & selectedStockID
                command = New SqlClient.SqlCommand(query, con)
                command.ExecuteNonQuery()

                ' Delete / Void out the selected Item
                query = "DELETE FROM order_items WHERE id = " & orderID
                command = New SqlClient.SqlCommand(query, con)
                command.ExecuteNonQuery()

                MessageBox.Show("Successfully Voided Out item #" & orderID)

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
											order_items.transaction_id = " & transacID
                transactionList(getAllItems)
                orderID = Nothing
                selectedRowQuantity = Nothing
                isSelected = False

                ' Update Inventory 
                Dim getAllStocks As String = "SELECT stocks.id AS 'Stock ID', products.id AS 'Product ID', products.product_name AS 'Product Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id;"
                Inventory.fillStocksDataGridView(getAllStocks)
                Inventory.cb_stockStatus.Text = "All"

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MessageBox.Show(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub cancelTransacBtn_Click_1(sender As Object, e As EventArgs) Handles cancelTransacBtn.Click
        ' Clear the datagridview
        ' Clear the order list according to the transaction number
        ' remain in the current transaction number
        ' Clear the datagridview
        Dim con As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim query As String = ""
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As DataTable

        con.ConnectionString = connection.getConnectionString()

        Try
            ' Getting back the stocks quantity
            con.Open()

            query = "SELECT * FROM order_items WHERE transaction_id = " & transacID
            command = New SqlClient.SqlCommand(query, con)
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()

            da = New SqlClient.SqlDataAdapter
            da.SelectCommand = command
            dt = New DataTable
            da.Fill(dt)

            For i = 0 To dt.Rows.Count - 1
                ' 4 , 7
                Dim stockQuantity As Integer = dt.Rows(i).Item(4)
                Dim stockIDTrav As Integer = dt.Rows(i).Item(7)

                ' Get Current Stock Quantity
                query = "SELECT quantity FROM stocks WHERE id = " & stockIDTrav
                command = New SqlClient.SqlCommand(query, con)
                command.ExecuteNonQuery()

                Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
                da1.SelectCommand = command
                Dim dt1 As DataTable = New DataTable
                da1.Fill(dt1)

                Dim quan As Integer = dt1.Rows(0).Item(0)
                Dim quantityResult As Integer = Math.Abs(quan + stockQuantity)

                ' Update The stock
                query = "UPDATE stocks SET quantity = " & quantityResult & " WHERE id = " & stockIDTrav
                command = New SqlClient.SqlCommand(query, con)
                command.ExecuteNonQuery()

            Next

            ' Clearing order items
            query = "DELETE FROM order_items WHERE transaction_id = " & transacID
            command = New SqlClient.SqlCommand(query, con)
            command.ExecuteNonQuery()

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
											order_items.transaction_id = " & transacID
            transactionList(getAllItems)
            orderID = Nothing
            selectedRowQuantity = Nothing
            isSelected = False

            ' Update Inventory 
            Dim getAllStocks As String = "SELECT stocks.id AS 'Stock ID', products.id AS 'Product ID', products.product_name AS 'Product Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id;"
            Inventory.fillStocksDataGridView(getAllStocks)
            Inventory.cb_stockStatus.Text = "All"

            MessageBox.Show("Transaction Cancelled.")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub paymentBtn_Click(sender As Object, e As EventArgs) Handles paymentBtn.Click
        If transactionListGrid.Rows.Count <> 0 Then
            ' Show Payment Method
            Dim method = paymentMethod
            method.ShowDialog()
        End If
    End Sub
End Class