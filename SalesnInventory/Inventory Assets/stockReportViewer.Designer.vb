<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stockReportViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sales_and_inventory_dbDataSet1 = New SalesnInventory.sales_and_inventory_dbDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ProductsTableAdapter = New SalesnInventory.sales_and_inventory_dbDataSet1TableAdapters.productsTableAdapter()
        Me.stocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StocksBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StocksTableAdapter = New SalesnInventory.sales_and_inventory_dbDataSet1TableAdapters.stocksTableAdapter()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sales_and_inventory_dbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "products"
        Me.ProductsBindingSource.DataSource = Me.Sales_and_inventory_dbDataSet1
        '
        'Sales_and_inventory_dbDataSet1
        '
        Me.Sales_and_inventory_dbDataSet1.DataSetName = "sales_and_inventory_dbDataSet1"
        Me.Sales_and_inventory_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "productSet"
        ReportDataSource1.Value = Me.ProductsBindingSource
        ReportDataSource2.Name = "stockSet"
        ReportDataSource2.Value = Me.StocksBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SalesnInventory.stockReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 13)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(905, 582)
        Me.ReportViewer1.TabIndex = 0
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'stocksBindingSource
        '
        Me.stocksBindingSource.DataMember = "stocks"
        Me.stocksBindingSource.DataSource = Me.Sales_and_inventory_dbDataSet1
        '
        'StocksBindingSource1
        '
        Me.StocksBindingSource1.DataMember = "stocks"
        Me.StocksBindingSource1.DataSource = Me.Sales_and_inventory_dbDataSet1
        '
        'StocksTableAdapter
        '
        Me.StocksTableAdapter.ClearBeforeFill = True
        '
        'stockReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 607)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "stockReportViewer"
        Me.Text = "Product Report"
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sales_and_inventory_dbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sales_and_inventory_dbDataSet1 As sales_and_inventory_dbDataSet1
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As sales_and_inventory_dbDataSet1TableAdapters.productsTableAdapter
    Friend WithEvents stocksBindingSource As BindingSource
    Friend WithEvents StocksBindingSource1 As BindingSource
    Friend WithEvents StocksTableAdapter As sales_and_inventory_dbDataSet1TableAdapters.stocksTableAdapter
End Class
