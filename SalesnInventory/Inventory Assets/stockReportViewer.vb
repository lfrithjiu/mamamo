Public Class stockReportViewer
    Private Sub productReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sales_and_inventory_dbDataSet1.stocks' table. You can move, or remove it, as needed.
        Me.StocksTableAdapter.Fill(Me.Sales_and_inventory_dbDataSet1.stocks)
        'TODO: This line of code loads data into the 'Sales_and_inventory_dbDataSet1.products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.Sales_and_inventory_dbDataSet1.products)
        Me.CenterToParent()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class