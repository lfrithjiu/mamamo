<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateStocks
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
        Me.cancelStockBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.updateStockBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.yearTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.qtyTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2ComboBox2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2ComboBox3 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cancelStockBtn
        '
        Me.cancelStockBtn.Animated = True
        Me.cancelStockBtn.AutoRoundedCorners = True
        Me.cancelStockBtn.BorderRadius = 16
        Me.cancelStockBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelStockBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelStockBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelStockBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelStockBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelStockBtn.FillColor = System.Drawing.Color.Silver
        Me.cancelStockBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelStockBtn.ForeColor = System.Drawing.Color.Black
        Me.cancelStockBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_cancel_40
        Me.cancelStockBtn.Location = New System.Drawing.Point(315, 274)
        Me.cancelStockBtn.Name = "cancelStockBtn"
        Me.cancelStockBtn.Size = New System.Drawing.Size(168, 35)
        Me.cancelStockBtn.TabIndex = 26
        Me.cancelStockBtn.Text = "Cancel"
        '
        'updateStockBtn
        '
        Me.updateStockBtn.Animated = True
        Me.updateStockBtn.AutoRoundedCorners = True
        Me.updateStockBtn.BorderRadius = 16
        Me.updateStockBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateStockBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.updateStockBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.updateStockBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.updateStockBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.updateStockBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.updateStockBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateStockBtn.ForeColor = System.Drawing.Color.Black
        Me.updateStockBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_update_40__2_
        Me.updateStockBtn.Location = New System.Drawing.Point(315, 233)
        Me.updateStockBtn.Name = "updateStockBtn"
        Me.updateStockBtn.Size = New System.Drawing.Size(168, 35)
        Me.updateStockBtn.TabIndex = 25
        Me.updateStockBtn.Text = "Update"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(300, 146)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(92, 22)
        Me.Guna2HtmlLabel5.TabIndex = 24
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
        Me.yearTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearTxtBox.ForeColor = System.Drawing.Color.Black
        Me.yearTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yearTxtBox.Location = New System.Drawing.Point(300, 182)
        Me.yearTxtBox.Margin = New System.Windows.Forms.Padding(4)
        Me.yearTxtBox.Name = "yearTxtBox"
        Me.yearTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.yearTxtBox.PlaceholderText = ""
        Me.yearTxtBox.SelectedText = ""
        Me.yearTxtBox.Size = New System.Drawing.Size(201, 36)
        Me.yearTxtBox.TabIndex = 23
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(300, 62)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(66, 22)
        Me.Guna2HtmlLabel4.TabIndex = 22
        Me.Guna2HtmlLabel4.Text = "Quantity:"
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
        Me.qtyTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtyTxtBox.ForeColor = System.Drawing.Color.Black
        Me.qtyTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.qtyTxtBox.Location = New System.Drawing.Point(300, 103)
        Me.qtyTxtBox.Margin = New System.Windows.Forms.Padding(4)
        Me.qtyTxtBox.Name = "qtyTxtBox"
        Me.qtyTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.qtyTxtBox.PlaceholderText = ""
        Me.qtyTxtBox.SelectedText = ""
        Me.qtyTxtBox.Size = New System.Drawing.Size(201, 36)
        Me.qtyTxtBox.TabIndex = 21
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(36, 233)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(123, 22)
        Me.Guna2HtmlLabel3.TabIndex = 19
        Me.Guna2HtmlLabel3.Text = "Select Company:"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(36, 154)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(81, 22)
        Me.Guna2HtmlLabel2.TabIndex = 17
        Me.Guna2HtmlLabel2.Text = "Select Car:"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(36, 63)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(111, 22)
        Me.Guna2HtmlLabel1.TabIndex = 15
        Me.Guna2HtmlLabel1.Text = "Select Product:"
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
        Me.GunaElipsePanel1.TabIndex = 27
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(136, 26)
        Me.Guna2HtmlLabel6.TabIndex = 14
        Me.Guna2HtmlLabel6.Text = "Update Stocks"
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2ComboBox1.BorderRadius = 5
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(36, 103)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(204, 36)
        Me.Guna2ComboBox1.TabIndex = 0
        '
        'Guna2ComboBox2
        '
        Me.Guna2ComboBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox2.BorderColor = System.Drawing.Color.Black
        Me.Guna2ComboBox2.BorderRadius = 5
        Me.Guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox2.ItemHeight = 30
        Me.Guna2ComboBox2.Location = New System.Drawing.Point(36, 182)
        Me.Guna2ComboBox2.Name = "Guna2ComboBox2"
        Me.Guna2ComboBox2.Size = New System.Drawing.Size(204, 36)
        Me.Guna2ComboBox2.TabIndex = 28
        '
        'Guna2ComboBox3
        '
        Me.Guna2ComboBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox3.BorderColor = System.Drawing.Color.Black
        Me.Guna2ComboBox3.BorderRadius = 5
        Me.Guna2ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox3.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox3.ItemHeight = 30
        Me.Guna2ComboBox3.Location = New System.Drawing.Point(36, 260)
        Me.Guna2ComboBox3.Name = "Guna2ComboBox3"
        Me.Guna2ComboBox3.Size = New System.Drawing.Size(204, 36)
        Me.Guna2ComboBox3.TabIndex = 29
        '
        'updateStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 335)
        Me.Controls.Add(Me.Guna2ComboBox3)
        Me.Controls.Add(Me.Guna2ComboBox2)
        Me.Controls.Add(Me.Guna2ComboBox1)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.cancelStockBtn)
        Me.Controls.Add(Me.updateStockBtn)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.yearTxtBox)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.qtyTxtBox)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "updateStocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Stock"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancelStockBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents updateStockBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents yearTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents qtyTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2ComboBox3 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2ComboBox2 As Guna.UI2.WinForms.Guna2ComboBox
End Class
