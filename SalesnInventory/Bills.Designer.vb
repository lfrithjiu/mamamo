<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bills
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
        Me.searchProduct = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.transactionListGrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.totalPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.transacNumberTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.paymentBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.voidBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.addQtyBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.cancelTransacBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.newTransacBtn = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.transactionListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'searchProduct
        '
        Me.searchProduct.Animated = True
        Me.searchProduct.AutoRoundedCorners = True
        Me.searchProduct.BackColor = System.Drawing.Color.Transparent
        Me.searchProduct.BorderColor = System.Drawing.Color.Black
        Me.searchProduct.BorderRadius = 16
        Me.searchProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.searchProduct.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchProduct.DefaultText = ""
        Me.searchProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchProduct.ForeColor = System.Drawing.Color.Black
        Me.searchProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchProduct.Location = New System.Drawing.Point(498, 69)
        Me.searchProduct.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.searchProduct.Name = "searchProduct"
        Me.searchProduct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchProduct.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.searchProduct.PlaceholderText = "Ex: 6ai42**"
        Me.searchProduct.SelectedText = ""
        Me.searchProduct.Size = New System.Drawing.Size(289, 35)
        Me.searchProduct.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.searchProduct, "Write a product code")
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(324, 76)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(150, 20)
        Me.Guna2HtmlLabel1.TabIndex = 6
        Me.Guna2HtmlLabel1.Text = "Search Product Code:"
        '
        'transactionListGrid
        '
        Me.transactionListGrid.AllowUserToAddRows = False
        Me.transactionListGrid.AllowUserToDeleteRows = False
        Me.transactionListGrid.AllowUserToResizeColumns = False
        Me.transactionListGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.transactionListGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.transactionListGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(5, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(5, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.transactionListGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.transactionListGrid.ColumnHeadersHeight = 44
        Me.transactionListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.transactionListGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.transactionListGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transactionListGrid.Location = New System.Drawing.Point(324, 110)
        Me.transactionListGrid.Name = "transactionListGrid"
        Me.transactionListGrid.ReadOnly = True
        Me.transactionListGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.transactionListGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.transactionListGrid.RowHeadersVisible = False
        Me.transactionListGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.transactionListGrid.Size = New System.Drawing.Size(464, 366)
        Me.transactionListGrid.TabIndex = 4
        Me.transactionListGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.transactionListGrid.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactionListGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.transactionListGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transactionListGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.transactionListGrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.transactionListGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transactionListGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.transactionListGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.transactionListGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactionListGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.transactionListGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.transactionListGrid.ThemeStyle.HeaderStyle.Height = 44
        Me.transactionListGrid.ThemeStyle.ReadOnly = True
        Me.transactionListGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.transactionListGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.transactionListGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactionListGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.transactionListGrid.ThemeStyle.RowsStyle.Height = 22
        Me.transactionListGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transactionListGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = Global.SalesnInventory.My.Resources.Resources.icons8_close_38
        Me.Guna2Button1.Location = New System.Drawing.Point(1205, 3)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(30, 33)
        Me.Guna2Button1.TabIndex = 98
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(12, 12)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(74, 44)
        Me.Guna2HtmlLabel4.TabIndex = 100
        Me.Guna2HtmlLabel4.Text = "Bills"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.paymentBtn)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.voidBtn)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.addQtyBtn)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.cancelTransacBtn)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.newTransacBtn)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.SandyBrown
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Gold
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.SandyBrown
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(12, 80)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(291, 396)
        Me.Guna2CustomGradientPanel1.TabIndex = 102
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.SaddleBrown
        Me.Guna2Panel2.BorderThickness = 2
        Me.Guna2Panel2.Controls.Add(Me.totalPrice)
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel2.Controls.Add(Me.transacNumberTxtBox)
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel2.Location = New System.Drawing.Point(11, 17)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(268, 169)
        Me.Guna2Panel2.TabIndex = 6
        '
        'totalPrice
        '
        Me.totalPrice.Animated = True
        Me.totalPrice.AutoRoundedCorners = True
        Me.totalPrice.BorderColor = System.Drawing.Color.Black
        Me.totalPrice.BorderRadius = 16
        Me.totalPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.totalPrice.DefaultText = "0"
        Me.totalPrice.DisabledState.BorderColor = System.Drawing.Color.White
        Me.totalPrice.DisabledState.FillColor = System.Drawing.Color.White
        Me.totalPrice.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.totalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalPrice.Enabled = False
        Me.totalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPrice.ForeColor = System.Drawing.Color.Black
        Me.totalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalPrice.Location = New System.Drawing.Point(21, 112)
        Me.totalPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.totalPrice.PlaceholderText = ""
        Me.totalPrice.SelectedText = ""
        Me.totalPrice.Size = New System.Drawing.Size(230, 34)
        Me.totalPrice.TabIndex = 4
        Me.totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(21, 85)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(93, 22)
        Me.Guna2HtmlLabel3.TabIndex = 6
        Me.Guna2HtmlLabel3.Text = "Total Price:"
        '
        'transacNumberTxtBox
        '
        Me.transacNumberTxtBox.Animated = True
        Me.transacNumberTxtBox.AutoRoundedCorners = True
        Me.transacNumberTxtBox.BorderColor = System.Drawing.Color.Black
        Me.transacNumberTxtBox.BorderRadius = 15
        Me.transacNumberTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transacNumberTxtBox.DefaultText = "1"
        Me.transacNumberTxtBox.DisabledState.BorderColor = System.Drawing.Color.White
        Me.transacNumberTxtBox.DisabledState.FillColor = System.Drawing.Color.White
        Me.transacNumberTxtBox.DisabledState.ForeColor = System.Drawing.Color.Gray
        Me.transacNumberTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.transacNumberTxtBox.Enabled = False
        Me.transacNumberTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transacNumberTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transacNumberTxtBox.ForeColor = System.Drawing.Color.Black
        Me.transacNumberTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transacNumberTxtBox.Location = New System.Drawing.Point(21, 43)
        Me.transacNumberTxtBox.Margin = New System.Windows.Forms.Padding(6)
        Me.transacNumberTxtBox.Name = "transacNumberTxtBox"
        Me.transacNumberTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.transacNumberTxtBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.transacNumberTxtBox.PlaceholderText = ""
        Me.transacNumberTxtBox.SelectedText = ""
        Me.transacNumberTxtBox.Size = New System.Drawing.Size(230, 33)
        Me.transacNumberTxtBox.TabIndex = 5
        Me.transacNumberTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(19, 13)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(169, 22)
        Me.Guna2HtmlLabel2.TabIndex = 4
        Me.Guna2HtmlLabel2.Text = "Transaction Number:"
        '
        'paymentBtn
        '
        Me.paymentBtn.Animated = True
        Me.paymentBtn.AutoRoundedCorners = True
        Me.paymentBtn.BackColor = System.Drawing.Color.Transparent
        Me.paymentBtn.BorderRadius = 19
        Me.paymentBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paymentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.paymentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.paymentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.paymentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.paymentBtn.FillColor = System.Drawing.Color.DodgerBlue
        Me.paymentBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentBtn.ForeColor = System.Drawing.Color.Black
        Me.paymentBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_payment_40
        Me.paymentBtn.IndicateFocus = True
        Me.paymentBtn.Location = New System.Drawing.Point(11, 202)
        Me.paymentBtn.Name = "paymentBtn"
        Me.paymentBtn.Size = New System.Drawing.Size(268, 41)
        Me.paymentBtn.TabIndex = 11
        Me.paymentBtn.Text = "  Payment"
        Me.paymentBtn.UseTransparentBackground = True
        '
        'voidBtn
        '
        Me.voidBtn.Animated = True
        Me.voidBtn.BackColor = System.Drawing.Color.Transparent
        Me.voidBtn.BorderRadius = 20
        Me.voidBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.voidBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.voidBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.voidBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.voidBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.voidBtn.FillColor = System.Drawing.Color.LightGray
        Me.voidBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voidBtn.ForeColor = System.Drawing.Color.Black
        Me.voidBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_void_40__1_
        Me.voidBtn.Location = New System.Drawing.Point(11, 335)
        Me.voidBtn.Name = "voidBtn"
        Me.voidBtn.Size = New System.Drawing.Size(103, 40)
        Me.voidBtn.TabIndex = 10
        Me.voidBtn.Text = "Void"
        '
        'addQtyBtn
        '
        Me.addQtyBtn.Animated = True
        Me.addQtyBtn.BackColor = System.Drawing.Color.Transparent
        Me.addQtyBtn.BorderRadius = 20
        Me.addQtyBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addQtyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addQtyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addQtyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addQtyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addQtyBtn.FillColor = System.Drawing.Color.LightGray
        Me.addQtyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addQtyBtn.ForeColor = System.Drawing.Color.Black
        Me.addQtyBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_add_40__2_
        Me.addQtyBtn.IndicateFocus = True
        Me.addQtyBtn.Location = New System.Drawing.Point(11, 265)
        Me.addQtyBtn.Name = "addQtyBtn"
        Me.addQtyBtn.Size = New System.Drawing.Size(105, 40)
        Me.addQtyBtn.TabIndex = 9
        Me.addQtyBtn.Text = "Add QTY"
        Me.addQtyBtn.UseTransparentBackground = True
        '
        'cancelTransacBtn
        '
        Me.cancelTransacBtn.Animated = True
        Me.cancelTransacBtn.BackColor = System.Drawing.Color.Transparent
        Me.cancelTransacBtn.BorderRadius = 21
        Me.cancelTransacBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelTransacBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelTransacBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelTransacBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelTransacBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelTransacBtn.FillColor = System.Drawing.Color.LightGray
        Me.cancelTransacBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelTransacBtn.ForeColor = System.Drawing.Color.Black
        Me.cancelTransacBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_cancel_40__2_
        Me.cancelTransacBtn.Location = New System.Drawing.Point(130, 335)
        Me.cancelTransacBtn.Name = "cancelTransacBtn"
        Me.cancelTransacBtn.Size = New System.Drawing.Size(149, 40)
        Me.cancelTransacBtn.TabIndex = 8
        Me.cancelTransacBtn.Text = "Cancel Transaction"
        '
        'newTransacBtn
        '
        Me.newTransacBtn.Animated = True
        Me.newTransacBtn.BackColor = System.Drawing.Color.Transparent
        Me.newTransacBtn.BorderRadius = 21
        Me.newTransacBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.newTransacBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.newTransacBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.newTransacBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.newTransacBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.newTransacBtn.FillColor = System.Drawing.Color.LightGray
        Me.newTransacBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newTransacBtn.ForeColor = System.Drawing.Color.Black
        Me.newTransacBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_add_money_40
        Me.newTransacBtn.Location = New System.Drawing.Point(130, 265)
        Me.newTransacBtn.Name = "newTransacBtn"
        Me.newTransacBtn.Size = New System.Drawing.Size(149, 40)
        Me.newTransacBtn.TabIndex = 7
        Me.newTransacBtn.Text = "New Transaction"
        '
        'Bills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 499)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.searchProduct)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.transactionListGrid)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(200, 50)
        Me.Name = "Bills"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bills"
        CType(Me.transactionListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchProduct As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents transactionListGrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents totalPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents transacNumberTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents paymentBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents voidBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents addQtyBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cancelTransacBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents newTransacBtn As Guna.UI2.WinForms.Guna2Button
End Class
