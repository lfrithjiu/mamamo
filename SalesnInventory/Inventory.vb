Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Inventory
    Dim con1 As SqlClient.SqlConnection
    Dim cmd2 As SqlClient.SqlCommand
    Dim da3 As SqlClient.SqlDataAdapter
    Dim dt2 As DataTable
    Dim sqladd As String

    Dim updateProd As updateProduct
    Public Property prodID As Integer = Nothing
    Public Property stockID As Integer = Nothing

    Public Property filterProduct As String
    Public Property filterStock As String

    Public Sub loadProductStatus()
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = connection.getConnectionString()
            con1.Open()

            Dim sql As String = "SELECT DISTINCT product_status As 'status' FROM products"
            Dim cmd2 As New SqlClient.SqlCommand(sql, con1)

            cmd2.CommandType = CommandType.Text
            Dim da3 As New SqlClient.SqlDataAdapter
            da3.SelectCommand = cmd2
            Dim dt2 As New DataTable
            If da3.Fill(dt2) Then
                cb_productStatus.DataSource = dt2
                cb_productStatus.Text = "Activated"
                cb_productStatus.DisplayMember = "status"
                cb_productStatus.ValueMember = "status"
            Else
                cb_productStatus.DataSource = Nothing
                cb_productStatus.Text = "No Status Found"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadProductStatus()
        filterProduct = "Activated"
        filterStock = "All"

        Dim getAllProducts As String = "SELECT id AS 'ID', product_code AS 'Product Code', product_name AS 'Name', product_description AS 'Description', product_price AS 'Price' FROM products WHERE product_status = 'Activated';"
        fillDataGridView(getAllProducts)
        checkStatusButtons()

        Dim getAllStocks As String = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id;"
        fillStocksDataGridView(getAllStocks)
        cb_stockStatus.Text = "All"

    End Sub

    Private Sub productSearch_KeyUp(sender As Object, e As KeyEventArgs)
        'MessageBox.Show(filterProduct)
        Dim search As String = "SELECT id AS 'ID', product_code AS 'Product Code', product_name AS 'Name', product_description AS 'Description', product_price AS 'Price' FROM products WHERE (product_name LIKE '" & productSearch.Text.Trim() & "%' OR product_code LIKE '" & productSearch.Text.Trim() & "%') AND product_status = '" & filterProduct & "'"
        fillDataGridView(search)
    End Sub

    Private Sub productSearch_KeyPress(sender As Object, e As KeyPressEventArgs)
        'MessageBox.Show(filterProduct)
        Dim search As String = "Select id As 'ID', product_code AS 'Product Code', product_name AS 'Name', product_description AS 'Description', product_price AS 'Price' FROM products WHERE (product_name LIKE '" & productSearch.Text.Trim() & "%' OR product_code LIKE '" & productSearch.Text.Trim() & "%') AND product_status = '" & filterProduct & "'"
        fillDataGridView(search)

    End Sub

    Public Sub fillDataGridView(ByVal sql As String)
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = connection.getConnectionString()
            con1.Open()

            Dim command As SqlClient.SqlCommand = New SqlClient.SqlCommand(sql, con1)
            da3 = New SqlClient.SqlDataAdapter()
            da3.SelectCommand = command
            dt2 = New DataTable
            da3.Fill(dt2)
            productsGridView.DataSource = dt2

            ' Set Sizes
            productsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            totalItems.Text = "Total of items: " & productsGridView.Rows.Count

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Public Sub fillStocksDataGridView(ByVal sql As String)
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
            stocksGridView.DataSource = dt2

            ' Set Sizes
            stocksGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            totalStockItems.Text = "Total of items: " & stocksGridView.Rows.Count

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub cb_productStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_productStatus.SelectedIndexChanged
        filterProduct = cb_productStatus.SelectedValue.ToString

        Dim getAllProducts As String = "SELECT id AS 'ID', product_code AS 'Category Code', product_name AS 'Name', product_description AS 'Description', product_price AS 'Price' FROM products WHERE product_status = '" & filterProduct & "';"
        fillDataGridView(getAllProducts)

        checkStatusButtons()
        prodID = Nothing
    End Sub

    Private Sub checkStatusButtons()
        If filterProduct = "Activated" Then
            ' Hide
            activateProductBtn.Enabled = False
            activateProductBtn.Visible = False
            deleteProductBtn.Enabled = False
            deleteProductBtn.Visible = False

            ' Show
            addProductBtn.Enabled = True
            addProductBtn.Visible = True
            updateProductBtn.Enabled = True
            updateProductBtn.Visible = True
            deactivateProductBtn.Enabled = True
            deactivateProductBtn.Visible = True

        Else

            ' Hide
            activateProductBtn.Enabled = True
            activateProductBtn.Visible = True
            deleteProductBtn.Enabled = True
            deleteProductBtn.Visible = True

            ' Show
            addProductBtn.Enabled = False
            addProductBtn.Visible = False
            updateProductBtn.Enabled = False
            updateProductBtn.Visible = False
            deactivateProductBtn.Enabled = False
            deactivateProductBtn.Visible = False

        End If
    End Sub

    Private Sub addProductBtn_Click(sender As Object, e As EventArgs) Handles addProductBtn.Click
        ' Ask for admin's password process
        '
        '
        '

        addProduct.ShowDialog()
    End Sub

    Private Sub productsGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles productsGridView.CellClick
        prodID = Convert.ToInt32(productsGridView.SelectedRows(0).Cells(0).Value)
    End Sub

    Private Sub updateProductBtn_Click(sender As Object, e As EventArgs) Handles updateProductBtn.Click
        If (prodID <> Nothing) Then
            ' Ask for admin's password process
            '
            '
            '

            updateProd = New updateProduct(prodID)
            updateProd.ShowDialog()
        End If
    End Sub

    Private Sub deactivateProductBtn_Click(sender As Object, e As EventArgs) Handles deactivateProductBtn.Click
        If (prodID <> Nothing) Then
            ' Ask for admin's password process
            '
            '
            ' 

            Dim query As String
            Dim con As SqlClient.SqlConnection
            Dim command As SqlClient.SqlCommand

            Try
                query = "UPDATE products SET product_status = 'DeActivated'
                    WHERE id = '" & prodID & "'"

                con = New SqlClient.SqlConnection
                con.ConnectionString = connection.getConnectionString()
                con.Open()

                command = New SqlClient.SqlCommand(query, con)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()

                MessageBox.Show("Successfully De-activated!")
                prodID = Nothing

                Dim getAllProducts As String = "SELECT id AS 'ID', product_code AS 'Category Code', product_name AS 'Name', product_description AS 'Description', product_price AS 'Price' FROM products WHERE product_status = '" & filterProduct & "';"
                fillDataGridView(getAllProducts)

                loadProductStatus()

            Catch ex As Exception
                MessageBox.Show(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub activateProductBtn_Click(sender As Object, e As EventArgs) Handles activateProductBtn.Click
        If (prodID <> Nothing) Then
            ' Ask for admin's password process
            '
            '
            '

            Dim query As String
            Dim con As SqlClient.SqlConnection
            Dim command As SqlClient.SqlCommand

            Try
                query = "UPDATE products SET product_status = 'Activated'
                    WHERE id = '" & prodID & "'"

                con = New SqlClient.SqlConnection
                con.ConnectionString = connection.getConnectionString()
                con.Open()

                command = New SqlClient.SqlCommand(query, con)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()

                MessageBox.Show("Successfully Activated!")
                prodID = Nothing

                Dim getAllProducts As String = "SELECT id AS 'ID', product_code AS 'Category Code', product_name AS 'Name', product_description AS 'Description', product_price AS 'Price' FROM products WHERE product_status = '" & filterProduct & "';"
                fillDataGridView(getAllProducts)
                loadProductStatus()

            Catch ex As Exception
                MessageBox.Show(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub deleteProductBtn_Click(sender As Object, e As EventArgs) Handles deleteProductBtn.Click
        ' Ask for admin's password process
        '
        '
        '

        Dim query As String
        Dim con As SqlClient.SqlConnection
        Dim command As SqlClient.SqlCommand

        Try
            query = "DELETE FROM products WHERE id = " & prodID & ""

            con = New SqlClient.SqlConnection
            con.ConnectionString = connection.getConnectionString()
            con.Open()

            command = New SqlClient.SqlCommand(query, con)
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()

            MessageBox.Show("Successfully Deleted!")

            Dim getAllProducts As String = "SELECT id AS 'ID', product_code AS 'Category Code', product_name AS 'Name', product_description AS 'Description', product_price AS 'Price' FROM products WHERE product_status = '" & filterProduct & "';"
            fillDataGridView(getAllProducts)

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim search As String = ""

        If filterStock = "All" Then
            search = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id WHERE products.product_name LIKE '" & stockSearch.Text.Trim() & "%' OR companies.company_name LIKE '" & stockSearch.Text.Trim() & "%' OR Companies.company_location LIKE '" & stockSearch.Text.Trim() & "%'"
        ElseIf filterStock = "Good" Then
            search = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id WHERE (products.product_name LIKE '" & stockSearch.Text.Trim() & "%' OR companies.company_name LIKE '" & stockSearch.Text.Trim() & "%' OR Companies.company_location LIKE '" & stockSearch.Text.Trim() & "%') AND stocks.quantity > 29"
        ElseIf filterStock = "Low" Then
            search = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id WHERE (products.product_name LIKE '" & stockSearch.Text.Trim() & "%' OR companies.company_name LIKE '" & stockSearch.Text.Trim() & "%' OR Companies.company_location LIKE '" & stockSearch.Text.Trim() & "%') AND stocks.quantity < 30 AND stocks.quantity > 0"
        ElseIf filterStock = "Out Of Stock" Then
            search = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id WHERE (products.product_name LIKE '" & stockSearch.Text.Trim() & "%' OR companies.company_name LIKE '" & stockSearch.Text.Trim() & "%' OR Companies.company_location LIKE '" & stockSearch.Text.Trim() & "%') AND stocks.quantity = 0"
        End If

        fillStocksDataGridView(search)
    End Sub

    Private Sub TextBox2_KeyUp(sender As Object, e As KeyEventArgs)
        Dim search As String = ""

        If filterStock = "All" Then
            search = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id WHERE products.product_name LIKE '" & stockSearch.Text.Trim() & "%' OR companies.company_name LIKE '" & stockSearch.Text.Trim() & "%' OR Companies.company_location LIKE '" & stockSearch.Text.Trim() & "%'"
        ElseIf filterStock = "Good" Then
            search = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id WHERE (products.product_name LIKE '" & stockSearch.Text.Trim() & "%' OR companies.company_name LIKE '" & stockSearch.Text.Trim() & "%' OR Companies.company_location LIKE '" & stockSearch.Text.Trim() & "%') AND stocks.quantity > 29"
        ElseIf filterStock = "Low" Then
            search = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id WHERE (products.product_name LIKE '" & stockSearch.Text.Trim() & "%' OR companies.company_name LIKE '" & stockSearch.Text.Trim() & "%' OR Companies.company_location LIKE '" & stockSearch.Text.Trim() & "%') AND stocks.quantity < 30 AND stocks.quantity > 0"
        ElseIf filterStock = "Out Of Stock" Then
            search = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id WHERE (products.product_name LIKE '" & stockSearch.Text.Trim() & "%' OR companies.company_name LIKE '" & stockSearch.Text.Trim() & "%' OR Companies.company_location LIKE '" & stockSearch.Text.Trim() & "%') AND stocks.quantity = 0"
        End If

        fillStocksDataGridView(search)
    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_stockStatus.SelectedIndexChanged
        filterStock = cb_stockStatus.SelectedItem.ToString

        If filterStock = "All" Then
            Dim getAllStocks As String = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id;"
            fillStocksDataGridView(getAllStocks)
        ElseIf filterStock = "Low" Then
            Dim getAllStocks As String = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id WHERE quantity < 30 AND quantity > 0;"
            fillStocksDataGridView(getAllStocks)
        ElseIf filterStock = "Good" Then
            Dim getAllStocks As String = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id WHERE quantity > 29;"
            fillStocksDataGridView(getAllStocks)
        ElseIf filterStock = "Out Of Stock" Then
            Dim getAllStocks As String = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id WHERE quantity = 0;"
            fillStocksDataGridView(getAllStocks)
        End If

        stockID = Nothing
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        addStocks.ShowDialog()
    End Sub

    Private Sub stocksGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles stocksGridView.CellClick
        stockID = Convert.ToInt32(stocksGridView.SelectedRows(0).Cells(0).Value)
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        ' Ask for admin's password process
        '
        '
        '

        Dim query As String
        Dim con As SqlClient.SqlConnection
        Dim command As SqlClient.SqlCommand

        Try
            query = "DELETE FROM stocks WHERE id = " & stockID & ""

            con = New SqlClient.SqlConnection
            con.ConnectionString = connection.getConnectionString()
            con.Open()

            command = New SqlClient.SqlCommand(query, con)
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()

            MessageBox.Show("Successfully Deleted!")

            If filterStock = "All" Then
                Dim getAllStocks As String = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id;"
                fillStocksDataGridView(getAllStocks)
            ElseIf filterStock = "Low" Then
                Dim getAllStocks As String = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id WHERE quantity < 30 AND quantity > 0;"
                fillStocksDataGridView(getAllStocks)
            ElseIf filterStock = "Good" Then
                Dim getAllStocks As String = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id WHERE quantity > 29;"
                fillStocksDataGridView(getAllStocks)
            ElseIf filterStock = "Out Of Stock" Then
                Dim getAllStocks As String = "SELECT stocks.id AS 'Stock ID', products.id AS 'Category ID', products.product_name AS 'Category Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id WHERE quantity = 0;"
                fillStocksDataGridView(getAllStocks)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub Guna2Button8_Click_1(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        If (stockID <> Nothing) Then
            ' Ask for admin's password process
            '
            '
            '

            Dim updateStock = New updateStocks(stockID)
            updateStock.ShowDialog()
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        ' productReportViewer.ShowDialog()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        ' stockReportViewer.ShowDialog()
    End Sub

    Private Sub stockSearch_TextChanged(sender As Object, e As EventArgs)

    End Sub


    'Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'DbInventoryDataSet.LogsTb' table. You can move, or remove it, as needed.
    'Me.LogsTbTableAdapter.Fill(Me.DbInventoryDataSet.LogsTb)
    'TODO: This line of code loads data into the 'DbInventoryDataSet.stocks' table. You can move, or remove it, as needed.
    'Me.StocksTableAdapter2.Fill(Me.DbInventoryDataSet.stocks)
    'loadcompany()
    'Cartype()
    'End Sub
End Class