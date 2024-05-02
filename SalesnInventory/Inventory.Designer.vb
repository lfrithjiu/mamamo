<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.totalItems = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.productsGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.deleteProductBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.deactivateProductBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.updateProductBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.activateProductBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.productSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cb_productStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addProductBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button7 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button8 = New Guna.UI2.WinForms.Guna2Button()
        Me.totalStockItems = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.stocksGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.stockSearch = New Guna.UI.WinForms.GunaTextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cb_stockStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.productsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.stocksGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(5, 53)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(8, 15)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(792, 431)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.totalItems)
        Me.TabPage1.Controls.Add(Me.Guna2Button4)
        Me.TabPage1.Controls.Add(Me.productsGridView)
        Me.TabPage1.Controls.Add(Me.deleteProductBtn)
        Me.TabPage1.Controls.Add(Me.deactivateProductBtn)
        Me.TabPage1.Controls.Add(Me.updateProductBtn)
        Me.TabPage1.Controls.Add(Me.activateProductBtn)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.addProductBtn)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 53)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(784, 374)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Category"
        '
        'totalItems
        '
        Me.totalItems.BackColor = System.Drawing.Color.Transparent
        Me.totalItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalItems.Location = New System.Drawing.Point(10, 286)
        Me.totalItems.Name = "totalItems"
        Me.totalItems.Size = New System.Drawing.Size(96, 17)
        Me.totalItems.TabIndex = 6
        Me.totalItems.Text = "Total of items: 10"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.AutoRoundedCorners = True
        Me.Guna2Button4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.BorderRadius = 15
        Me.Guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button4.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button4.Image = Global.SalesnInventory.My.Resources.Resources.icons8_print_40
        Me.Guna2Button4.Location = New System.Drawing.Point(652, 325)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(106, 33)
        Me.Guna2Button4.TabIndex = 10
        Me.Guna2Button4.Text = "Print"
        '
        'productsGridView
        '
        Me.productsGridView.AllowUserToAddRows = False
        Me.productsGridView.AllowUserToDeleteRows = False
        Me.productsGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.productsGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.productsGridView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.productsGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.productsGridView.ColumnHeadersHeight = 55
        Me.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.productsGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.productsGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productsGridView.Location = New System.Drawing.Point(3, 87)
        Me.productsGridView.Name = "productsGridView"
        Me.productsGridView.ReadOnly = True
        Me.productsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.productsGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.productsGridView.RowHeadersVisible = False
        Me.productsGridView.RowTemplate.Height = 25
        Me.productsGridView.Size = New System.Drawing.Size(774, 199)
        Me.productsGridView.TabIndex = 5
        Me.productsGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.productsGridView.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productsGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.productsGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productsGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.productsGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.productsGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productsGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productsGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.productsGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productsGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.productsGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.productsGridView.ThemeStyle.HeaderStyle.Height = 55
        Me.productsGridView.ThemeStyle.ReadOnly = True
        Me.productsGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.productsGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.productsGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productsGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.productsGridView.ThemeStyle.RowsStyle.Height = 25
        Me.productsGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productsGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'deleteProductBtn
        '
        Me.deleteProductBtn.Animated = True
        Me.deleteProductBtn.AutoRoundedCorners = True
        Me.deleteProductBtn.BackColor = System.Drawing.Color.Transparent
        Me.deleteProductBtn.BorderRadius = 15
        Me.deleteProductBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteProductBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.deleteProductBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.deleteProductBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.deleteProductBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.deleteProductBtn.Enabled = False
        Me.deleteProductBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.deleteProductBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteProductBtn.ForeColor = System.Drawing.Color.Black
        Me.deleteProductBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_delete_40
        Me.deleteProductBtn.Location = New System.Drawing.Point(276, 325)
        Me.deleteProductBtn.Name = "deleteProductBtn"
        Me.deleteProductBtn.Size = New System.Drawing.Size(106, 33)
        Me.deleteProductBtn.TabIndex = 13
        Me.deleteProductBtn.Text = "Delete"
        Me.deleteProductBtn.Visible = False
        '
        'deactivateProductBtn
        '
        Me.deactivateProductBtn.Animated = True
        Me.deactivateProductBtn.AutoRoundedCorners = True
        Me.deactivateProductBtn.BackColor = System.Drawing.Color.Transparent
        Me.deactivateProductBtn.BorderRadius = 15
        Me.deactivateProductBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deactivateProductBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.deactivateProductBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.deactivateProductBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.deactivateProductBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.deactivateProductBtn.Enabled = False
        Me.deactivateProductBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.deactivateProductBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deactivateProductBtn.ForeColor = System.Drawing.Color.Black
        Me.deactivateProductBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_repeat_off_40
        Me.deactivateProductBtn.Location = New System.Drawing.Point(530, 325)
        Me.deactivateProductBtn.Name = "deactivateProductBtn"
        Me.deactivateProductBtn.Size = New System.Drawing.Size(106, 33)
        Me.deactivateProductBtn.TabIndex = 9
        Me.deactivateProductBtn.Text = "De-Activate"
        '
        'updateProductBtn
        '
        Me.updateProductBtn.Animated = True
        Me.updateProductBtn.AutoRoundedCorners = True
        Me.updateProductBtn.BackColor = System.Drawing.Color.Transparent
        Me.updateProductBtn.BorderRadius = 15
        Me.updateProductBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateProductBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.updateProductBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.updateProductBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.updateProductBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.updateProductBtn.Enabled = False
        Me.updateProductBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.updateProductBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateProductBtn.ForeColor = System.Drawing.Color.Black
        Me.updateProductBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_update_40__1_
        Me.updateProductBtn.Location = New System.Drawing.Point(147, 325)
        Me.updateProductBtn.Name = "updateProductBtn"
        Me.updateProductBtn.Size = New System.Drawing.Size(106, 33)
        Me.updateProductBtn.TabIndex = 7
        Me.updateProductBtn.Text = "Update"
        '
        'activateProductBtn
        '
        Me.activateProductBtn.Animated = True
        Me.activateProductBtn.AutoRoundedCorners = True
        Me.activateProductBtn.BackColor = System.Drawing.Color.Transparent
        Me.activateProductBtn.BorderRadius = 15
        Me.activateProductBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.activateProductBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.activateProductBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.activateProductBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.activateProductBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.activateProductBtn.Enabled = False
        Me.activateProductBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.activateProductBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activateProductBtn.ForeColor = System.Drawing.Color.Black
        Me.activateProductBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_activate_40
        Me.activateProductBtn.Location = New System.Drawing.Point(396, 325)
        Me.activateProductBtn.Name = "activateProductBtn"
        Me.activateProductBtn.Size = New System.Drawing.Size(106, 33)
        Me.activateProductBtn.TabIndex = 12
        Me.activateProductBtn.Text = "Activate"
        Me.activateProductBtn.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.Controls.Add(Me.productSearch)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel1.Controls.Add(Me.cb_productStatus)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 78)
        Me.Panel1.TabIndex = 1
        '
        'productSearch
        '
        Me.productSearch.BorderColor = System.Drawing.Color.Black
        Me.productSearch.BorderRadius = 6
        Me.productSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.productSearch.DefaultText = ""
        Me.productSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.productSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.productSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.productSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.productSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productSearch.ForeColor = System.Drawing.Color.Black
        Me.productSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productSearch.Location = New System.Drawing.Point(102, 37)
        Me.productSearch.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.productSearch.Name = "productSearch"
        Me.productSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.productSearch.PlaceholderForeColor = System.Drawing.Color.Black
        Me.productSearch.PlaceholderText = ""
        Me.productSearch.SelectedText = ""
        Me.productSearch.Size = New System.Drawing.Size(277, 36)
        Me.productSearch.TabIndex = 7
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(478, 46)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(40, 17)
        Me.Guna2HtmlLabel2.TabIndex = 6
        Me.Guna2HtmlLabel2.Text = "Status:"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(49, 46)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(45, 17)
        Me.Guna2HtmlLabel1.TabIndex = 5
        Me.Guna2HtmlLabel1.Text = "Search:"
        '
        'cb_productStatus
        '
        Me.cb_productStatus.BackColor = System.Drawing.Color.Transparent
        Me.cb_productStatus.BorderColor = System.Drawing.Color.Black
        Me.cb_productStatus.BorderRadius = 6
        Me.cb_productStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_productStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_productStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_productStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_productStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cb_productStatus.ForeColor = System.Drawing.Color.Black
        Me.cb_productStatus.ItemHeight = 30
        Me.cb_productStatus.Location = New System.Drawing.Point(527, 37)
        Me.cb_productStatus.Name = "cb_productStatus"
        Me.cb_productStatus.Size = New System.Drawing.Size(211, 36)
        Me.cb_productStatus.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(774, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'addProductBtn
        '
        Me.addProductBtn.Animated = True
        Me.addProductBtn.AutoRoundedCorners = True
        Me.addProductBtn.BackColor = System.Drawing.Color.Transparent
        Me.addProductBtn.BorderRadius = 15
        Me.addProductBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addProductBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addProductBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addProductBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addProductBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addProductBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.addProductBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addProductBtn.ForeColor = System.Drawing.Color.Black
        Me.addProductBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_add_40
        Me.addProductBtn.Location = New System.Drawing.Point(26, 325)
        Me.addProductBtn.Name = "addProductBtn"
        Me.addProductBtn.Size = New System.Drawing.Size(106, 33)
        Me.addProductBtn.TabIndex = 8
        Me.addProductBtn.Text = "Add"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Guna2Button5)
        Me.TabPage2.Controls.Add(Me.Guna2Button6)
        Me.TabPage2.Controls.Add(Me.Guna2Button7)
        Me.TabPage2.Controls.Add(Me.Guna2Button8)
        Me.TabPage2.Controls.Add(Me.totalStockItems)
        Me.TabPage2.Controls.Add(Me.stocksGridView)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 53)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(784, 374)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Product"
        '
        'Guna2Button5
        '
        Me.Guna2Button5.Animated = True
        Me.Guna2Button5.AutoRoundedCorners = True
        Me.Guna2Button5.BorderRadius = 15
        Me.Guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button5.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button5.Image = Global.SalesnInventory.My.Resources.Resources.icons8_print_40
        Me.Guna2Button5.Location = New System.Drawing.Point(522, 317)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(106, 33)
        Me.Guna2Button5.TabIndex = 15
        Me.Guna2Button5.Text = "Print"
        '
        'Guna2Button6
        '
        Me.Guna2Button6.Animated = True
        Me.Guna2Button6.AutoRoundedCorners = True
        Me.Guna2Button6.BorderRadius = 15
        Me.Guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button6.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button6.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button6.Image = Global.SalesnInventory.My.Resources.Resources.icons8_delete_40
        Me.Guna2Button6.Location = New System.Drawing.Point(387, 317)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(106, 33)
        Me.Guna2Button6.TabIndex = 14
        Me.Guna2Button6.Text = "Delete"
        '
        'Guna2Button7
        '
        Me.Guna2Button7.Animated = True
        Me.Guna2Button7.AutoRoundedCorners = True
        Me.Guna2Button7.BorderRadius = 15
        Me.Guna2Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button7.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button7.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button7.Image = Global.SalesnInventory.My.Resources.Resources.icons8_add_40
        Me.Guna2Button7.Location = New System.Drawing.Point(130, 317)
        Me.Guna2Button7.Name = "Guna2Button7"
        Me.Guna2Button7.Size = New System.Drawing.Size(106, 33)
        Me.Guna2Button7.TabIndex = 13
        Me.Guna2Button7.Text = "Add"
        '
        'Guna2Button8
        '
        Me.Guna2Button8.Animated = True
        Me.Guna2Button8.AutoRoundedCorners = True
        Me.Guna2Button8.BorderRadius = 15
        Me.Guna2Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button8.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button8.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button8.Image = Global.SalesnInventory.My.Resources.Resources.icons8_update_40__1_
        Me.Guna2Button8.Location = New System.Drawing.Point(255, 317)
        Me.Guna2Button8.Name = "Guna2Button8"
        Me.Guna2Button8.Size = New System.Drawing.Size(106, 33)
        Me.Guna2Button8.TabIndex = 12
        Me.Guna2Button8.Text = "Update"
        '
        'totalStockItems
        '
        Me.totalStockItems.BackColor = System.Drawing.Color.Transparent
        Me.totalStockItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalStockItems.Location = New System.Drawing.Point(13, 294)
        Me.totalStockItems.Name = "totalStockItems"
        Me.totalStockItems.Size = New System.Drawing.Size(84, 15)
        Me.totalStockItems.TabIndex = 11
        Me.totalStockItems.Text = "Total of items: 10"
        '
        'stocksGridView
        '
        Me.stocksGridView.AllowUserToAddRows = False
        Me.stocksGridView.AllowUserToDeleteRows = False
        Me.stocksGridView.AllowUserToOrderColumns = True
        Me.stocksGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.stocksGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.stocksGridView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.stocksGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.stocksGridView.ColumnHeadersHeight = 55
        Me.stocksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.stocksGridView.DefaultCellStyle = DataGridViewCellStyle7
        Me.stocksGridView.GridColor = System.Drawing.Color.White
        Me.stocksGridView.Location = New System.Drawing.Point(6, 87)
        Me.stocksGridView.Name = "stocksGridView"
        Me.stocksGridView.ReadOnly = True
        Me.stocksGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.stocksGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.stocksGridView.RowHeadersVisible = False
        Me.stocksGridView.RowTemplate.Height = 25
        Me.stocksGridView.Size = New System.Drawing.Size(772, 199)
        Me.stocksGridView.TabIndex = 6
        Me.stocksGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.stocksGridView.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stocksGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.stocksGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stocksGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.stocksGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.stocksGridView.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.stocksGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stocksGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.stocksGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stocksGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.stocksGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.stocksGridView.ThemeStyle.HeaderStyle.Height = 55
        Me.stocksGridView.ThemeStyle.ReadOnly = True
        Me.stocksGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.stocksGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.stocksGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stocksGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.stocksGridView.ThemeStyle.RowsStyle.Height = 25
        Me.stocksGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stocksGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.stockSearch)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel3.Controls.Add(Me.cb_stockStatus)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(778, 78)
        Me.Panel3.TabIndex = 2
        '
        'stockSearch
        '
        Me.stockSearch.BackColor = System.Drawing.Color.Transparent
        Me.stockSearch.BaseColor = System.Drawing.Color.White
        Me.stockSearch.BorderColor = System.Drawing.Color.Black
        Me.stockSearch.BorderSize = 1
        Me.stockSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.stockSearch.FocusedBaseColor = System.Drawing.Color.White
        Me.stockSearch.FocusedBorderColor = System.Drawing.Color.Silver
        Me.stockSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.stockSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockSearch.Location = New System.Drawing.Point(89, 34)
        Me.stockSearch.Name = "stockSearch"
        Me.stockSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.stockSearch.Radius = 6
        Me.stockSearch.SelectedText = ""
        Me.stockSearch.Size = New System.Drawing.Size(277, 36)
        Me.stockSearch.TabIndex = 7
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(444, 40)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(40, 17)
        Me.Guna2HtmlLabel5.TabIndex = 6
        Me.Guna2HtmlLabel5.Text = "Status:"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(36, 40)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(45, 17)
        Me.Guna2HtmlLabel4.TabIndex = 5
        Me.Guna2HtmlLabel4.Text = "Search:"
        '
        'cb_stockStatus
        '
        Me.cb_stockStatus.BackColor = System.Drawing.Color.Transparent
        Me.cb_stockStatus.BorderColor = System.Drawing.Color.Black
        Me.cb_stockStatus.BorderRadius = 6
        Me.cb_stockStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_stockStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_stockStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_stockStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_stockStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_stockStatus.ForeColor = System.Drawing.Color.Black
        Me.cb_stockStatus.ItemHeight = 30
        Me.cb_stockStatus.Items.AddRange(New Object() {"All", "Good", "Low", "Out Of Stock"})
        Me.cb_stockStatus.Location = New System.Drawing.Point(509, 34)
        Me.cb_stockStatus.Name = "cb_stockStatus"
        Me.cb_stockStatus.Size = New System.Drawing.Size(211, 36)
        Me.cb_stockStatus.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(776, 37)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Product Information"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 10
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(12, 10)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(108, 31)
        Me.Guna2HtmlLabel3.TabIndex = 14
        Me.Guna2HtmlLabel3.Text = "Inventory"
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 499)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inventory"
        Me.Padding = New System.Windows.Forms.Padding(200, 50, 0, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = resources.GetString("$this.Text")
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.productsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.stocksGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_productStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents deactivateProductBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents addProductBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents updateProductBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents totalItems As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents productsGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cb_stockStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents stocksGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button7 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button8 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents totalStockItems As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents deleteProductBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents activateProductBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents stockSearch As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents productSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
