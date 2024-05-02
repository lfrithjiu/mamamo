Public Class addQuantity
    Dim orderID As Integer = Nothing
    Dim orderQuantity As Integer = Nothing
    Public Sub New(ByVal orderID As Integer, ByVal orderQuantity As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.orderID = orderID
        Me.orderQuantity = orderQuantity
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If qtyTextBox.Text.Trim <> "" AndAlso qtyTextBox.Text.Trim <> "0" AndAlso Not Convert.ToInt32(qtyTextBox.Text.Trim) < 0 Then
            ' Check if theres enough stocks first before adding the quantity
            Dim qtyAmount As Integer = Convert.ToInt32(qtyTextBox.Text.Trim())
            Dim con As SqlClient.SqlConnection
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim query As String = ""

            Try
                ' Get the Stock ID first
                query = "SELECT item_stock_id FROM order_items WHERE id = " & orderID
                con = New SqlClient.SqlConnection()
                con.ConnectionString = connection.getConnectionString()
                con.Open()

                Dim command As New SqlClient.SqlCommand(query, con)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()

                dt = New DataTable
                da = New SqlClient.SqlDataAdapter
                da.SelectCommand = command
                da.Fill(dt)

                Dim stockID As Integer = Convert.ToInt32(dt.Rows(0).Item(0))

                ' Get quantity of stock
                query = "SELECT stocks.quantity FROM stocks WHERE id = " & stockID
                command = New SqlClient.SqlCommand(query, con)
                command.ExecuteNonQuery()

                dt = New DataTable
                da.SelectCommand = command
                da.Fill(dt)

                Dim quantityStock As Integer = dt.Rows(0).Item(0)

                ' Check if the required Quantity is enough for the stock
                Dim condition As Boolean = (qtyAmount <= quantityStock)

                If (condition) Then
                    ' Update the Stocks and Order Item
                    Dim stockResult = quantityStock - qtyAmount

                    query = "UPDATE stocks SET quantity = " & stockResult & " WHERE id = " & stockID
                    command = New SqlClient.SqlCommand(query, con)
                    command.ExecuteNonQuery()

                    Dim newItemQuantity As Integer = Me.orderQuantity + qtyAmount
                    query = "UPDATE order_items SET item_quantity = " & newItemQuantity & " WHERE id = " & orderID
                    command = New SqlClient.SqlCommand(query, con)
                    command.ExecuteNonQuery()

                    ' Reload the Order List Table
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
                Else
                    ' Alert user that the stocks is insufficient
                    MessageBox.Show("Insufficient Stocks")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MessageBox.Show(ex.StackTrace)
            End Try
        Else
            MessageBox.Show("Must enter an appropriate value")
        End If
    End Sub

    Private Sub qtyTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qtyTextBox.KeyPress
        If ((Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) <= 57) Or
                (Asc(e.KeyChar) = 8)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub addQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        orderItem.Text = "Add Quantity to Item #" & Me.orderID
    End Sub
End Class