<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStocks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.qtyTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.yearTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cancelStockBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.addStockBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.addCarBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.addCompanyBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cb_product = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cb_car = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cb_company = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(34, 62)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(111, 22)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Select Product:"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(34, 149)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(81, 22)
        Me.Guna2HtmlLabel2.TabIndex = 3
        Me.Guna2HtmlLabel2.Text = "Select Car:"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(34, 231)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(123, 22)
        Me.Guna2HtmlLabel3.TabIndex = 5
        Me.Guna2HtmlLabel3.Text = "Select Company:"
        '
        'qtyTxtBox
        '
        Me.qtyTxtBox.Animated = True
        Me.qtyTxtBox.BorderColor = System.Drawing.Color.Black
        Me.qtyTxtBox.BorderRadius = 5
        Me.qtyTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.qtyTxtBox.DefaultText = ""
        Me.qtyTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.qtyTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.qtyTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.qtyTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.qtyTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.qtyTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtyTxtBox.ForeColor = System.Drawing.Color.Black
        Me.qtyTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.qtyTxtBox.Location = New System.Drawing.Point(298, 98)
        Me.qtyTxtBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.qtyTxtBox.Name = "qtyTxtBox"
        Me.qtyTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.qtyTxtBox.PlaceholderText = ""
        Me.qtyTxtBox.SelectedText = ""
        Me.qtyTxtBox.Size = New System.Drawing.Size(201, 36)
        Me.qtyTxtBox.TabIndex = 7
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(298, 61)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(66, 22)
        Me.Guna2HtmlLabel4.TabIndex = 8
        Me.Guna2HtmlLabel4.Text = "Quantity:"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(298, 149)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(92, 22)
        Me.Guna2HtmlLabel5.TabIndex = 10
        Me.Guna2HtmlLabel5.Text = "Year Added:"
        '
        'yearTxtBox
        '
        Me.yearTxtBox.Animated = True
        Me.yearTxtBox.BorderColor = System.Drawing.Color.Black
        Me.yearTxtBox.BorderRadius = 5
        Me.yearTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.yearTxtBox.DefaultText = ""
        Me.yearTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.yearTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.yearTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yearTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yearTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yearTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearTxtBox.ForeColor = System.Drawing.Color.Black
        Me.yearTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yearTxtBox.Location = New System.Drawing.Point(298, 181)
        Me.yearTxtBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.yearTxtBox.Name = "yearTxtBox"
        Me.yearTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.yearTxtBox.PlaceholderText = ""
        Me.yearTxtBox.SelectedText = ""
        Me.yearTxtBox.Size = New System.Drawing.Size(201, 36)
        Me.yearTxtBox.TabIndex = 9
        '
        'cancelStockBtn
        '
        Me.cancelStockBtn.Animated = True
        Me.cancelStockBtn.AutoRoundedCorners = True
        Me.cancelStockBtn.BorderRadius = 17
        Me.cancelStockBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelStockBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelStockBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelStockBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelStockBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelStockBtn.FillColor = System.Drawing.Color.Silver
        Me.cancelStockBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelStockBtn.ForeColor = System.Drawing.Color.Black
        Me.cancelStockBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_cancel_40
        Me.cancelStockBtn.Location = New System.Drawing.Point(313, 272)
        Me.cancelStockBtn.Name = "cancelStockBtn"
        Me.cancelStockBtn.Size = New System.Drawing.Size(168, 37)
        Me.cancelStockBtn.TabIndex = 12
        Me.cancelStockBtn.Text = "Cancel"
        '
        'addStockBtn
        '
        Me.addStockBtn.Animated = True
        Me.addStockBtn.AutoRoundedCorners = True
        Me.addStockBtn.BackColor = System.Drawing.Color.Transparent
        Me.addStockBtn.BorderRadius = 16
        Me.addStockBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addStockBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addStockBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addStockBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addStockBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addStockBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.addStockBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addStockBtn.ForeColor = System.Drawing.Color.Black
        Me.addStockBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_add_40
        Me.addStockBtn.Location = New System.Drawing.Point(313, 231)
        Me.addStockBtn.Name = "addStockBtn"
        Me.addStockBtn.Size = New System.Drawing.Size(168, 35)
        Me.addStockBtn.TabIndex = 11
        Me.addStockBtn.Text = "Add"
        Me.addStockBtn.UseTransparentBackground = True
        '
        'addCarBtn
        '
        Me.addCarBtn.Animated = True
        Me.addCarBtn.BackColor = System.Drawing.SystemColors.Control
        Me.addCarBtn.BorderRadius = 5
        Me.addCarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addCarBtn.DefaultAutoSize = True
        Me.addCarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addCarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addCarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addCarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addCarBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.addCarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addCarBtn.ForeColor = System.Drawing.Color.Black
        Me.addCarBtn.Location = New System.Drawing.Point(197, 185)
        Me.addCarBtn.Name = "addCarBtn"
        Me.addCarBtn.Size = New System.Drawing.Size(40, 28)
        Me.addCarBtn.TabIndex = 13
        Me.addCarBtn.Text = "+"
        '
        'addCompanyBtn
        '
        Me.addCompanyBtn.Animated = True
        Me.addCompanyBtn.BackColor = System.Drawing.SystemColors.Control
        Me.addCompanyBtn.BorderRadius = 5
        Me.addCompanyBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addCompanyBtn.DefaultAutoSize = True
        Me.addCompanyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addCompanyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addCompanyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addCompanyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addCompanyBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.addCompanyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addCompanyBtn.ForeColor = System.Drawing.Color.Black
        Me.addCompanyBtn.Location = New System.Drawing.Point(197, 267)
        Me.addCompanyBtn.Name = "addCompanyBtn"
        Me.addCompanyBtn.Size = New System.Drawing.Size(40, 28)
        Me.addCompanyBtn.TabIndex = 14
        Me.addCompanyBtn.Text = "+"
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
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.MidnightBlue
        Me.GunaElipsePanel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.GunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 1
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(536, 36)
        Me.GunaElipsePanel1.TabIndex = 24
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(108, 26)
        Me.Guna2HtmlLabel6.TabIndex = 14
        Me.Guna2HtmlLabel6.Text = "Add Stocks"
        '
        'cb_product
        '
        Me.cb_product.BackColor = System.Drawing.Color.Transparent
        Me.cb_product.BorderColor = System.Drawing.Color.Black
        Me.cb_product.BorderRadius = 5
        Me.cb_product.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_product.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_product.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_product.ForeColor = System.Drawing.Color.Black
        Me.cb_product.ItemHeight = 30
        Me.cb_product.Location = New System.Drawing.Point(34, 98)
        Me.cb_product.Name = "cb_product"
        Me.cb_product.Size = New System.Drawing.Size(204, 36)
        Me.cb_product.TabIndex = 25
        '
        'cb_car
        '
        Me.cb_car.BackColor = System.Drawing.Color.Transparent
        Me.cb_car.BorderColor = System.Drawing.Color.Black
        Me.cb_car.BorderRadius = 5
        Me.cb_car.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_car.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_car.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_car.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_car.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_car.ForeColor = System.Drawing.Color.Black
        Me.cb_car.ItemHeight = 30
        Me.cb_car.Location = New System.Drawing.Point(34, 181)
        Me.cb_car.Name = "cb_car"
        Me.cb_car.Size = New System.Drawing.Size(157, 36)
        Me.cb_car.TabIndex = 26
        '
        'cb_company
        '
        Me.cb_company.BackColor = System.Drawing.Color.Transparent
        Me.cb_company.BorderColor = System.Drawing.Color.Black
        Me.cb_company.BorderRadius = 5
        Me.cb_company.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_company.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_company.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_company.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_company.ForeColor = System.Drawing.Color.Black
        Me.cb_company.ItemHeight = 30
        Me.cb_company.Location = New System.Drawing.Point(34, 263)
        Me.cb_company.Name = "cb_company"
        Me.cb_company.Size = New System.Drawing.Size(157, 36)
        Me.cb_company.TabIndex = 27
        '
        'addStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 335)
        Me.Controls.Add(Me.cb_company)
        Me.Controls.Add(Me.cb_car)
        Me.Controls.Add(Me.cb_product)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.addCompanyBtn)
        Me.Controls.Add(Me.addCarBtn)
        Me.Controls.Add(Me.cancelStockBtn)
        Me.Controls.Add(Me.addStockBtn)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.yearTxtBox)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.qtyTxtBox)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addStocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Stock"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents qtyTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents yearTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cancelStockBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents addStockBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents addCarBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents addCompanyBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents cb_company As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cb_car As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cb_product As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
