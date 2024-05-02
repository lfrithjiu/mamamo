Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports TheArtOfDevHtmlRenderer

Public Class addStocks

    Dim con1 As SqlClient.SqlConnection

    Private Sub addStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()

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
                cb_product.DataSource = dt2
                cb_product.Text = "Choose a Product"
                cb_product.DisplayMember = "prodName"
                cb_product.ValueMember = "id"
            Else
                cb_product.DataSource = Nothing
                cb_product.Text = "No Product"
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
            Dim dt2 As New DataTable
            If da3.Fill(dt2) Then
                cb_company.DataSource = dt2
                cb_company.Text = "Choose a Company"
                cb_company.DisplayMember = "compName"
                cb_company.ValueMember = "id"
            Else
                cb_company.DataSource = Nothing
                cb_company.Text = "No Company"
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
                cb_car.DataSource = dt2
                cb_car.Text = "Choose a Company"
                cb_car.DisplayMember = "carName"
                cb_car.ValueMember = "id"
            Else
                cb_car.DataSource = Nothing
                cb_car.Text = "No Car"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub addStockBtn_Click(sender As Object, e As EventArgs) Handles addStockBtn.Click

        Dim prod As String = cb_product.SelectedValue
        Dim car As String = cb_car.SelectedValue
        Dim comp As String = cb_company.SelectedValue

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
                    query = "SELECT * FROM stocks WHERE company_id = " & comp & " AND car_id = " & car & " AND product_id = " & prod & ""
                    con = New SqlClient.SqlConnection
                    con.ConnectionString = connection.getConnectionString()
                    con.Open()

                    command = New SqlClient.SqlCommand(query, con)
                    command.CommandType = CommandType.Text
                    command.ExecuteNonQuery()

                    adapter.SelectCommand = command
                    adapter.Fill(ds, "stocks")

                    If ds.Tables(0).Rows.Count >= 1 Then
                        ' Update the current existing row by adding the quantity
                        MessageBox.Show("The record you want to add already exist, You may able to update it.")
                        Return
                    End If

                    query = "INSERT INTO stocks (quantity, year_added, product_id, car_id, company_id)
                            VALUES (" & quan & ",'" & year & "'," & prod & ", " & car & "," & comp & ")"
                    con = New SqlClient.SqlConnection
                    con.ConnectionString = connection.getConnectionString()
                    con.Open()

                    command = New SqlClient.SqlCommand(query, con)
                    command.CommandType = CommandType.Text
                    command.ExecuteNonQuery()

                    MessageBox.Show("Successfully Added!")

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

    Private Sub addCarBtn_Click(sender As Object, e As EventArgs) Handles addCarBtn.Click
        addCar.ShowDialog()
    End Sub

    Private Sub addCompany_Click(sender As Object, e As EventArgs) Handles addCompanyBtn.Click
        addCompany.ShowDialog()
    End Sub

    Private Sub cancelStockBtn_Click(sender As Object, e As EventArgs) Handles cancelStockBtn.Click
        Me.Close()
    End Sub

    Private Sub yearTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles yearTxtBox.KeyPress
        If yearTxtBox.Text.Trim.Length = 0 AndAlso e.KeyChar = "0" Then
            e.Handled = True
        ElseIf yearTxtBox.Text.Trim.Length >= 4 Then
            If (Asc(e.KeyChar) = 8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Else
            If ((Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) <= 57) Or
                (Asc(e.KeyChar) = 8)) Then

                ' MessageBox.Show("Valid")
            Else
                ' MessageBox.Show("Not Valid")
                e.Handled = True
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
End Class