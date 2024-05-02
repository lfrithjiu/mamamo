Imports System.Runtime.InteropServices

Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAllData()
    End Sub

    Private Sub loadAllData()
        fillMostBought()
        fillAudit()
        fillLendList()
    End Sub

    Private Sub fillLendList()
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = connection.getConnectionString()
        con.Open()

        Dim query As String
        Dim da As SqlClient.SqlDataAdapter
        Dim command As SqlClient.SqlCommand
        Dim dt As DataTable

        Try
            query = "SELECT 
	                    lendings.company_name As 'Company Name',
	                    lendings.shop_name As 'Shop',
	                    lendings.company_location As 'Location',
	                    FORMAT(lendings.start_date, 'MMM dd, yyyy') As 'Started On',
	                    FORMAT(lendings.last_date, 'MMM dd, yyyy') As 'Ends on',
	                    transactions.transaction_total As 'Total Cost'
                    FROM 
	                    lendings
                    INNER JOIN
	                    transactions
                    ON
	                    lendings.transaction_id = transactions.id;"

            command = New SqlClient.SqlCommand(query, con)
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()

            da = New SqlClient.SqlDataAdapter
            da.SelectCommand = command

            dt = New DataTable
            da.Fill(dt)

            lendGridView.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub fillAudit()
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = connection.getConnectionString()
        con.Open()

        Dim query As String
        Dim da As SqlClient.SqlDataAdapter
        Dim command As SqlClient.SqlCommand
        Dim dt As DataTable

        Dim daily, monthly, annually As String

        Try
            ' Daily
            query = "SELECT
	                    SUM(transactions.transaction_total) As 'Daily'
                    FROM 
	                    transactions
                    WHERE 
	                    FORMAT(transactions.transaction_date, 'dd') = FORMAT(GETDATE(), 'dd')"

            command = New SqlClient.SqlCommand(query, con)
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()

            da = New SqlClient.SqlDataAdapter
            da.SelectCommand = command
            dt = New DataTable
            da.Fill(dt)

            If (dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0).Item(0))) Then
                daily = dt.Rows(0).Item(0)
            Else
                daily = "0"
            End If


            ' Monthly
            query = "SELECT
	                SUM(transactions.transaction_total) As 'Monthly'
                FROM 
	                transactions
                WHERE 
	                FORMAT(transactions.transaction_date, 'MM') = FORMAT(GETDATE(), 'MM')"

            command = New SqlClient.SqlCommand(query, con)
            command.ExecuteNonQuery()

            da = New SqlClient.SqlDataAdapter
            da.SelectCommand = command
            dt = New DataTable
            da.Fill(dt)

            If (dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0).Item(0))) Then
                monthly = dt.Rows(0).Item(0)
            Else
                monthly = "0"
            End If

            ' Annually
            query = "SELECT
	                SUM(transactions.transaction_total) As 'Annually'
                FROM 
	                transactions
                WHERE 
	                FORMAT(transactions.transaction_date, 'yyyy') = FORMAT(GETDATE(), 'yyyy')"

            command = New SqlClient.SqlCommand(query, con)
            command.ExecuteNonQuery()

            da = New SqlClient.SqlDataAdapter
            da.SelectCommand = command
            dt = New DataTable
            da.Fill(dt)

            If (dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0).Item(0))) Then
                annually = dt.Rows(0).Item(0)
            Else
                annually = "0"
            End If

            dailyReport.Text = daily
            monthlyReport.Text = monthly
            annuallyReport.Text = annually

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.stacktrace)
        End Try

    End Sub

    Private Sub fillMostBought()
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = connection.getConnectionString()
        con.Open()

        Dim query As String = "SELECT TOP 12
	                                order_items.item_product As 'Product Name',
	                                SUM(order_items.item_quantity) As 'Bought'
                                FROM
	                                order_items
                                INNER JOIN
	                                transactions
                                ON
	                                order_items.transaction_id = transactions.id
                                WHERE 
	                                transactions.transaction_status = 1
                                GROUP BY
	                                order_items.item_product
                                ORDER BY 
	                                Bought ASC"

        Dim command As SqlClient.SqlCommand
        command = New SqlClient.SqlCommand(query, con)
        command.CommandType = CommandType.Text
        command.ExecuteNonQuery()

        Dim da As New SqlClient.SqlDataAdapter
        da.SelectCommand = command

        Dim ds As New DataSet
        da.Fill(ds)

        Chart1.DataSource = ds
        Chart1.Series("Items").XValueMember = "Product Name"
        Chart1.Series("Items").YValueMembers = "Bought"

        If Chart1.Titles.Count = 0 Then
            Chart1.Titles.Add("Most Bought Items")
        End If

        con.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        loadAllData()
    End Sub


End Class