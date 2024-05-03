<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addCompany
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
        Me.cancelCompanyBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.addCompanyBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.companyLocationTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.companyNameTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cancelCompanyBtn
        '
        Me.cancelCompanyBtn.Animated = True
        Me.cancelCompanyBtn.AutoRoundedCorners = True
        Me.cancelCompanyBtn.BorderRadius = 23
        Me.cancelCompanyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelCompanyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelCompanyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelCompanyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelCompanyBtn.FillColor = System.Drawing.Color.Silver
        Me.cancelCompanyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelCompanyBtn.ForeColor = System.Drawing.Color.Black
        Me.cancelCompanyBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_cancel_40
        Me.cancelCompanyBtn.Location = New System.Drawing.Point(40, 254)
        Me.cancelCompanyBtn.Name = "cancelCompanyBtn"
        Me.cancelCompanyBtn.Size = New System.Drawing.Size(164, 48)
        Me.cancelCompanyBtn.TabIndex = 22
        Me.cancelCompanyBtn.Text = "Cancel"
        '
        'addCompanyBtn
        '
        Me.addCompanyBtn.Animated = True
        Me.addCompanyBtn.AutoRoundedCorners = True
        Me.addCompanyBtn.BorderRadius = 23
        Me.addCompanyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addCompanyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addCompanyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addCompanyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addCompanyBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.addCompanyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addCompanyBtn.ForeColor = System.Drawing.Color.Black
        Me.addCompanyBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_add_40
        Me.addCompanyBtn.Location = New System.Drawing.Point(219, 254)
        Me.addCompanyBtn.Name = "addCompanyBtn"
        Me.addCompanyBtn.Size = New System.Drawing.Size(164, 48)
        Me.addCompanyBtn.TabIndex = 21
        Me.addCompanyBtn.Text = "Add"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(70, 155)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(139, 22)
        Me.Guna2HtmlLabel5.TabIndex = 20
        Me.Guna2HtmlLabel5.Text = "Company Location:"
        '
        'companyLocationTxtBox
        '
        Me.companyLocationTxtBox.Animated = True
        Me.companyLocationTxtBox.BorderColor = System.Drawing.Color.Black
        Me.companyLocationTxtBox.BorderRadius = 5
        Me.companyLocationTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.companyLocationTxtBox.DefaultText = ""
        Me.companyLocationTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.companyLocationTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.companyLocationTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.companyLocationTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.companyLocationTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.companyLocationTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyLocationTxtBox.ForeColor = System.Drawing.Color.Black
        Me.companyLocationTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.companyLocationTxtBox.Location = New System.Drawing.Point(70, 192)
        Me.companyLocationTxtBox.Margin = New System.Windows.Forms.Padding(4)
        Me.companyLocationTxtBox.Name = "companyLocationTxtBox"
        Me.companyLocationTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.companyLocationTxtBox.PlaceholderText = ""
        Me.companyLocationTxtBox.SelectedText = ""
        Me.companyLocationTxtBox.Size = New System.Drawing.Size(279, 34)
        Me.companyLocationTxtBox.TabIndex = 19
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(70, 68)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(120, 22)
        Me.Guna2HtmlLabel4.TabIndex = 18
        Me.Guna2HtmlLabel4.Text = "Company Name:"
        '
        'companyNameTxtBox
        '
        Me.companyNameTxtBox.Animated = True
        Me.companyNameTxtBox.BorderColor = System.Drawing.Color.Black
        Me.companyNameTxtBox.BorderRadius = 5
        Me.companyNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.companyNameTxtBox.DefaultText = ""
        Me.companyNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.companyNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.companyNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.companyNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.companyNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.companyNameTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyNameTxtBox.ForeColor = System.Drawing.Color.Black
        Me.companyNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.companyNameTxtBox.Location = New System.Drawing.Point(70, 105)
        Me.companyNameTxtBox.Margin = New System.Windows.Forms.Padding(4)
        Me.companyNameTxtBox.Name = "companyNameTxtBox"
        Me.companyNameTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.companyNameTxtBox.PlaceholderText = ""
        Me.companyNameTxtBox.SelectedText = ""
        Me.companyNameTxtBox.Size = New System.Drawing.Size(279, 34)
        Me.companyNameTxtBox.TabIndex = 17
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
        Me.GunaElipsePanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.GunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 1
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(419, 36)
        Me.GunaElipsePanel1.TabIndex = 23
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(135, 26)
        Me.Guna2HtmlLabel1.TabIndex = 14
        Me.Guna2HtmlLabel1.Text = "Add Company"
        '
        'addCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 324)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.cancelCompanyBtn)
        Me.Controls.Add(Me.addCompanyBtn)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.companyLocationTxtBox)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.companyNameTxtBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Company"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancelCompanyBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents addCompanyBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents companyLocationTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents companyNameTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
