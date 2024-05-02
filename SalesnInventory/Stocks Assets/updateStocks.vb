Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class updateStocks
    Dim con1 As SqlClient.SqlConnection
    Dim stockID As Integer

    Public Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        updateCB()

        ' Add any initialization after the InitializeComponent() call.
        stockID = id

        Dim query As String
        Dim con As SqlClient.SqlConnection
        Dim command As SqlClient.SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataTable
        Try
            query = "SELECT products.product_name, cars.car_name, companies.company_name, stocks.quantity, FORMAT(stocks.year_added, 'yyyy') AS 'year_added' FROM stocks 
                    INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars ON stocks.car_id = cars.id INNER JOIN companies ON stocks.company_id = companies.id WHERE stocks.id = " & stockID & ""

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

            Guna2ComboBox1.SelectedIndex = Guna2ComboBox1.FindStringExact(ds.Rows(0).Item(0))
            Guna2ComboBox2.SelectedIndex = Guna2ComboBox2.FindStringExact(ds.Rows(0).Item(1))
            Guna2ComboBox3.SelectedIndex = Guna2ComboBox3.FindStringExact(ds.Rows(0).Item(2))
            qtyTxtBox.Text = ds.Rows(0).Item(3)
            yearTxtBox.Text = ds.Rows(0).Item(4)
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub updateStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub updateCB()
        loadProductList()
        loadCompanyList()
        loadCarList()
    End Sub

    Public Sub loadProductList()
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = connection.getConnectionString()
            con1.Open()

            Dim sql As String = "SELECT DISTINCT id, product_name As 'prodName' FROM products"
            Dim cmd2 As New SqlClient.SqlCommand(sql, con1)

            cmd2.CommandType = CommandType.Text
            Dim da3 As New SqlClient.SqlDataAdapter
            da3.SelectCommand = cmd2
            Dim dt2 As New DataTable

            If da3.Fill(dt2) Then
                Guna2ComboBox1.DataSource = dt2
                Guna2ComboBox1.Text = "Choose a Product"
                Guna2ComboBox1.DisplayMember = "prodName"
                Guna2ComboBox1.ValueMember = "id"
            Else
                Guna2ComboBox1.DataSource = Nothing
                Guna2ComboBox1.Text = "No Product"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub loadCompanyList()
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = connection.getConnectionString()
            con1.Open()

            Dim sql As String = "SELECT DISTINCT id, company_name As 'compName' FROM companies"
            Dim cmd2 As New SqlClient.SqlCommand(sql, con1)

            cmd2.CommandType = CommandType.Text
            Dim da3 As New SqlClient.SqlDataAdapter
            da3.SelectCommand = cmd2
            Dim dtCompany As New DataTable

            If da3.Fill(dtCompany) Then
                Guna2ComboBox3.DataSource = dtCompany
                Guna2ComboBox3.Text = "Choose a Company"
                Guna2ComboBox3.DisplayMember = "compName"
                Guna2ComboBox3.ValueMember = "id"
            Else
                Guna2ComboBox3.DataSource = Nothing
                Guna2ComboBox3.Text = "No Company"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub loadCarList()
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = connection.getConnectionString()
            con1.Open()

            Dim sql As String = "SELECT DISTINCT id, car_name As 'carName' FROM cars"
            Dim cmd2 As New SqlClient.SqlCommand(sql, con1)

            cmd2.CommandType = CommandType.Text
            Dim da3 As New SqlClient.SqlDataAdapter
            da3.SelectCommand = cmd2
            Dim dt2 As New DataTable
            If da3.Fill(dt2) Then
                Guna2ComboBox2.DataSource = dt2
                Guna2ComboBox2.Text = "Choose a Company"
                Guna2ComboBox2.DisplayMember = "carName"
                Guna2ComboBox2.ValueMember = "id"
            Else
                Guna2ComboBox2.DataSource = Nothing
                Guna2ComboBox2.Text = "No Car"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub updateStockBtn_Click(sender As Object, e As EventArgs) Handles updateStockBtn.Click

        Dim prod As String = Guna2ComboBox1.SelectedValue
        Dim car As String = Guna2ComboBox2.SelectedValue
        Dim comp As String = Guna2ComboBox3.SelectedValue

        Dim quan As String = qtyTxtBox.Text.Trim()
        Dim year As String = yearTxtBox.Text.Trim()

        If quan = "" Or year = "" Then
            MessageBox.Show("Please fill all the fields")
        ElseIf year.Length <> 4 Then
            MessageBox.Show("Year must be a 4 digit decimals.")
        Else

            If prod = "" Or car = "" Or comp = "" Then
                MessageBox.Show("Please pick one of each drop down list")
            Else
                Dim query As String
                Dim con As SqlClient.SqlConnection
                Dim command As SqlClient.SqlCommand
                Dim adapter As New SqlDataAdapter
                Dim ds As New DataSet

                Try
                    query = "UPDATE stocks SET quantity = " & quan & ", year_added = '" & year & "', car_id = " & car & ", company_id = " & comp & " 
                            WHERE id = " & stockID & ""
                    con = New SqlClient.SqlConnection
                    con.ConnectionString = connection.getConnectionString()
                    con.Open()

                    command = New SqlClient.SqlCommand(query, con)
                    command.CommandType = CommandType.Text
                    command.ExecuteNonQuery()

                    MessageBox.Show("Successfully Updated!")

                    Dim getAllStocks As String = "SELECT stocks.id AS 'Stock ID', products.id AS 'Product ID', products.product_name AS 'Product Name', stocks.quantity As 'Quantity', FORMAT(stocks.year_added, 'yyyy') AS 'Year Added', carTB.car_name As 'Car Name', carTb.car_model AS 'Car Model', companies.company_name AS 'Company Name', companies.company_location AS 'Company Location' FROM stocks INNER JOIN products ON stocks.product_id = products.id INNER JOIN cars AS carTB ON stocks.car_id = carTB.id INNER JOIN companies ON stocks.company_id = companies.id;"
                    Inventory.fillStocksDataGridView(getAllStocks)
                    Inventory.cb_stockStatus.Text = "All"
                    Inventory.stockID = Nothing

                    qtyTxtBox.Text = ""
                    yearTxtBox.Text = ""

                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    MessageBox.Show(ex.StackTrace)
                End Try
            End If

        End If
    End Sub

    Private Sub qtyTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qtyTxtBox.KeyPress
        If ((Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) <= 57) Or
                (Asc(e.KeyChar) = 8)) Then

            ' MessageBox.Show("Valid")
        Else
            ' MessageBox.Show("Not Valid")
            e.Handled = True
        End If
    End Sub

    Private Sub cancelStockBtn_Click(sender As Object, e As EventArgs) Handles cancelStockBtn.Click
        Me.Close()
    End Sub
End Class