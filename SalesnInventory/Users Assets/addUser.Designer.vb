<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addUser
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
        Me.tb_birthdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.tb_email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.cb_civilstat = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cb_gender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btn_register = New Guna.UI2.WinForms.Guna2Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tb_nationality = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_securitynum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_address = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_contactnum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_lname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_fname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_userType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'tb_birthdate
        '
        Me.tb_birthdate.Animated = True
        Me.tb_birthdate.BackColor = System.Drawing.Color.Transparent
        Me.tb_birthdate.BorderRadius = 10
        Me.tb_birthdate.Checked = True
        Me.tb_birthdate.FillColor = System.Drawing.Color.White
        Me.tb_birthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.tb_birthdate.Location = New System.Drawing.Point(34, 228)
        Me.tb_birthdate.MaxDate = New Date(2022, 12, 13, 0, 0, 0, 0)
        Me.tb_birthdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tb_birthdate.Name = "tb_birthdate"
        Me.tb_birthdate.Size = New System.Drawing.Size(246, 25)
        Me.tb_birthdate.TabIndex = 93
        Me.tb_birthdate.Value = New Date(2022, 12, 8, 8, 14, 24, 961)
        '
        'tb_email
        '
        Me.tb_email.Animated = True
        Me.tb_email.BackColor = System.Drawing.Color.Transparent
        Me.tb_email.BorderColor = System.Drawing.Color.Black
        Me.tb_email.BorderRadius = 10
        Me.tb_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_email.DefaultText = ""
        Me.tb_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_email.ForeColor = System.Drawing.Color.Black
        Me.tb_email.HoverState.BorderColor = System.Drawing.Color.Black
        Me.tb_email.HoverState.FillColor = System.Drawing.Color.Silver
        Me.tb_email.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tb_email.Location = New System.Drawing.Point(323, 292)
        Me.tb_email.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tb_email.Name = "tb_email"
        Me.tb_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_email.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.tb_email.PlaceholderText = "Ex: fr****@gmail.com"
        Me.tb_email.SelectedText = ""
        Me.tb_email.Size = New System.Drawing.Size(453, 36)
        Me.tb_email.TabIndex = 92
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(321, 263)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 20)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "E-mail:"
        '
        'btn_cancel
        '
        Me.btn_cancel.Animated = True
        Me.btn_cancel.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancel.BorderRadius = 20
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cancel.FillColor = System.Drawing.Color.Silver
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.HoverState.FillColor = System.Drawing.Color.White
        Me.btn_cancel.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btn_cancel.Image = Global.SalesnInventory.My.Resources.Resources.icons8_cancel_40
        Me.btn_cancel.Location = New System.Drawing.Point(456, 432)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(145, 40)
        Me.btn_cancel.TabIndex = 90
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseTransparentBackground = True
        '
        'cb_civilstat
        '
        Me.cb_civilstat.BackColor = System.Drawing.Color.Transparent
        Me.cb_civilstat.BorderColor = System.Drawing.Color.Black
        Me.cb_civilstat.BorderRadius = 10
        Me.cb_civilstat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_civilstat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_civilstat.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_civilstat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_civilstat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_civilstat.ForeColor = System.Drawing.Color.Black
        Me.cb_civilstat.ItemHeight = 30
        Me.cb_civilstat.Location = New System.Drawing.Point(34, 376)
        Me.cb_civilstat.Name = "cb_civilstat"
        Me.cb_civilstat.Size = New System.Drawing.Size(246, 36)
        Me.cb_civilstat.TabIndex = 89
        '
        'cb_gender
        '
        Me.cb_gender.BackColor = System.Drawing.Color.Transparent
        Me.cb_gender.BorderColor = System.Drawing.Color.Black
        Me.cb_gender.BorderRadius = 10
        Me.cb_gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_gender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_gender.ForeColor = System.Drawing.Color.Black
        Me.cb_gender.ItemHeight = 30
        Me.cb_gender.Location = New System.Drawing.Point(34, 292)
        Me.cb_gender.Name = "cb_gender"
        Me.cb_gender.Size = New System.Drawing.Size(246, 36)
        Me.cb_gender.TabIndex = 88
        '
        'btn_register
        '
        Me.btn_register.Animated = True
        Me.btn_register.BackColor = System.Drawing.Color.Transparent
        Me.btn_register.BorderRadius = 20
        Me.btn_register.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_register.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_register.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_register.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btn_register.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_register.ForeColor = System.Drawing.Color.Black
        Me.btn_register.HoverState.FillColor = System.Drawing.Color.White
        Me.btn_register.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btn_register.Image = Global.SalesnInventory.My.Resources.Resources.icons8_register_40
        Me.btn_register.Location = New System.Drawing.Point(631, 432)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(145, 40)
        Me.btn_register.TabIndex = 87
        Me.btn_register.Text = "Register"
        Me.btn_register.UseTransparentBackground = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(29, 344)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 20)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Civil Status:"
        '
        'tb_nationality
        '
        Me.tb_nationality.Animated = True
        Me.tb_nationality.BackColor = System.Drawing.Color.Transparent
        Me.tb_nationality.BorderColor = System.Drawing.Color.Black
        Me.tb_nationality.BorderRadius = 10
        Me.tb_nationality.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_nationality.DefaultText = ""
        Me.tb_nationality.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_nationality.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_nationality.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_nationality.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_nationality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_nationality.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nationality.ForeColor = System.Drawing.Color.Black
        Me.tb_nationality.HoverState.BorderColor = System.Drawing.Color.Black
        Me.tb_nationality.HoverState.FillColor = System.Drawing.Color.Silver
        Me.tb_nationality.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tb_nationality.Location = New System.Drawing.Point(326, 376)
        Me.tb_nationality.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tb_nationality.Name = "tb_nationality"
        Me.tb_nationality.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_nationality.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.tb_nationality.PlaceholderText = "Ex: Filipino"
        Me.tb_nationality.SelectedText = ""
        Me.tb_nationality.Size = New System.Drawing.Size(216, 36)
        Me.tb_nationality.TabIndex = 85
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(321, 344)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 20)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Nationality:"
        '
        'tb_username
        '
        Me.tb_username.Animated = True
        Me.tb_username.BackColor = System.Drawing.Color.Transparent
        Me.tb_username.BorderColor = System.Drawing.Color.Black
        Me.tb_username.BorderRadius = 10
        Me.tb_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_username.DefaultText = ""
        Me.tb_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_username.ForeColor = System.Drawing.Color.Black
        Me.tb_username.HoverState.BorderColor = System.Drawing.Color.Black
        Me.tb_username.HoverState.FillColor = System.Drawing.Color.Silver
        Me.tb_username.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tb_username.Location = New System.Drawing.Point(563, 103)
        Me.tb_username.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_username.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.tb_username.PlaceholderText = "Ex: Frankie"
        Me.tb_username.SelectedText = ""
        Me.tb_username.Size = New System.Drawing.Size(216, 25)
        Me.tb_username.TabIndex = 83
        '
        'tb_password
        '
        Me.tb_password.Animated = True
        Me.tb_password.BackColor = System.Drawing.Color.Transparent
        Me.tb_password.BorderColor = System.Drawing.Color.Black
        Me.tb_password.BorderRadius = 10
        Me.tb_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_password.DefaultText = ""
        Me.tb_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_password.ForeColor = System.Drawing.Color.Black
        Me.tb_password.HoverState.BorderColor = System.Drawing.Color.Black
        Me.tb_password.HoverState.FillColor = System.Drawing.Color.Silver
        Me.tb_password.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tb_password.Location = New System.Drawing.Point(563, 159)
        Me.tb_password.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_password.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.tb_password.PlaceholderText = "*********"
        Me.tb_password.SelectedText = ""
        Me.tb_password.Size = New System.Drawing.Size(216, 25)
        Me.tb_password.TabIndex = 82
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(558, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 20)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Password:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(558, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 20)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Username:"
        '
        'tb_securitynum
        '
        Me.tb_securitynum.Animated = True
        Me.tb_securitynum.BackColor = System.Drawing.Color.Transparent
        Me.tb_securitynum.BorderColor = System.Drawing.Color.Black
        Me.tb_securitynum.BorderRadius = 10
        Me.tb_securitynum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_securitynum.DefaultText = ""
        Me.tb_securitynum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_securitynum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_securitynum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_securitynum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_securitynum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_securitynum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_securitynum.ForeColor = System.Drawing.Color.Black
        Me.tb_securitynum.HoverState.BorderColor = System.Drawing.Color.Black
        Me.tb_securitynum.HoverState.FillColor = System.Drawing.Color.Silver
        Me.tb_securitynum.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tb_securitynum.Location = New System.Drawing.Point(326, 159)
        Me.tb_securitynum.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tb_securitynum.Name = "tb_securitynum"
        Me.tb_securitynum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_securitynum.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.tb_securitynum.PlaceholderText = "515-785-496-1"
        Me.tb_securitynum.SelectedText = ""
        Me.tb_securitynum.Size = New System.Drawing.Size(216, 25)
        Me.tb_securitynum.TabIndex = 79
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(321, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(177, 20)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Social Security Number:"
        '
        'tb_address
        '
        Me.tb_address.Animated = True
        Me.tb_address.BackColor = System.Drawing.Color.Transparent
        Me.tb_address.BorderColor = System.Drawing.Color.Black
        Me.tb_address.BorderRadius = 10
        Me.tb_address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_address.DefaultText = ""
        Me.tb_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_address.ForeColor = System.Drawing.Color.Black
        Me.tb_address.HoverState.BorderColor = System.Drawing.Color.Black
        Me.tb_address.HoverState.FillColor = System.Drawing.Color.Silver
        Me.tb_address.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tb_address.Location = New System.Drawing.Point(326, 228)
        Me.tb_address.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tb_address.Name = "tb_address"
        Me.tb_address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_address.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.tb_address.PlaceholderText = "Ex: San Bartolome Quezon City"
        Me.tb_address.SelectedText = ""
        Me.tb_address.Size = New System.Drawing.Size(453, 25)
        Me.tb_address.TabIndex = 77
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(321, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Address:"
        '
        'tb_contactnum
        '
        Me.tb_contactnum.Animated = True
        Me.tb_contactnum.BackColor = System.Drawing.Color.Transparent
        Me.tb_contactnum.BorderColor = System.Drawing.Color.Black
        Me.tb_contactnum.BorderRadius = 10
        Me.tb_contactnum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_contactnum.DefaultText = ""
        Me.tb_contactnum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_contactnum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_contactnum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_contactnum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_contactnum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_contactnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_contactnum.ForeColor = System.Drawing.Color.Black
        Me.tb_contactnum.HoverState.BorderColor = System.Drawing.Color.Black
        Me.tb_contactnum.HoverState.FillColor = System.Drawing.Color.Silver
        Me.tb_contactnum.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tb_contactnum.Location = New System.Drawing.Point(326, 103)
        Me.tb_contactnum.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tb_contactnum.Name = "tb_contactnum"
        Me.tb_contactnum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_contactnum.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.tb_contactnum.PlaceholderText = "09*********"
        Me.tb_contactnum.SelectedText = ""
        Me.tb_contactnum.Size = New System.Drawing.Size(216, 25)
        Me.tb_contactnum.TabIndex = 75
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(321, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 20)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Contact Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 33)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "REGISTER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(29, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Birthdate:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(126, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(29, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Gender:"
        '
        'tb_lname
        '
        Me.tb_lname.Animated = True
        Me.tb_lname.BackColor = System.Drawing.Color.Transparent
        Me.tb_lname.BorderColor = System.Drawing.Color.Black
        Me.tb_lname.BorderRadius = 10
        Me.tb_lname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_lname.DefaultText = ""
        Me.tb_lname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_lname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_lname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_lname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_lname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_lname.ForeColor = System.Drawing.Color.Black
        Me.tb_lname.HoverState.BorderColor = System.Drawing.Color.Black
        Me.tb_lname.HoverState.FillColor = System.Drawing.Color.Silver
        Me.tb_lname.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tb_lname.Location = New System.Drawing.Point(34, 159)
        Me.tb_lname.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tb_lname.Name = "tb_lname"
        Me.tb_lname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_lname.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.tb_lname.PlaceholderText = "Ex: Gamelo"
        Me.tb_lname.SelectedText = ""
        Me.tb_lname.Size = New System.Drawing.Size(246, 25)
        Me.tb_lname.TabIndex = 68
        '
        'tb_fname
        '
        Me.tb_fname.Animated = True
        Me.tb_fname.BackColor = System.Drawing.Color.Transparent
        Me.tb_fname.BorderColor = System.Drawing.Color.Black
        Me.tb_fname.BorderRadius = 10
        Me.tb_fname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_fname.DefaultText = ""
        Me.tb_fname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_fname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_fname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_fname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_fname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fname.ForeColor = System.Drawing.Color.Black
        Me.tb_fname.HoverState.BorderColor = System.Drawing.Color.Black
        Me.tb_fname.HoverState.FillColor = System.Drawing.Color.Silver
        Me.tb_fname.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tb_fname.Location = New System.Drawing.Point(34, 103)
        Me.tb_fname.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tb_fname.Name = "tb_fname"
        Me.tb_fname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_fname.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.tb_fname.PlaceholderText = "Ex: Frankie "
        Me.tb_fname.SelectedText = ""
        Me.tb_fname.Size = New System.Drawing.Size(246, 25)
        Me.tb_fname.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "First Name:"
        '
        'cb_userType
        '
        Me.cb_userType.BackColor = System.Drawing.Color.Transparent
        Me.cb_userType.BorderColor = System.Drawing.Color.Black
        Me.cb_userType.BorderRadius = 10
        Me.cb_userType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_userType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_userType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_userType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_userType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_userType.ForeColor = System.Drawing.Color.Black
        Me.cb_userType.ItemHeight = 30
        Me.cb_userType.Items.AddRange(New Object() {"Cashier", "Manager", "Admin"})
        Me.cb_userType.Location = New System.Drawing.Point(553, 376)
        Me.cb_userType.Name = "cb_userType"
        Me.cb_userType.Size = New System.Drawing.Size(149, 36)
        Me.cb_userType.TabIndex = 95
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(548, 344)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 20)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "User Type:"
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
        Me.Guna2Button1.Location = New System.Drawing.Point(865, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(30, 33)
        Me.Guna2Button1.TabIndex = 96
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Image = Global.SalesnInventory.My.Resources.Resources.icons8_close_40
        Me.Guna2Button2.Location = New System.Drawing.Point(765, 0)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(49, 39)
        Me.Guna2Button2.TabIndex = 98
        '
        'addUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SalesnInventory.My.Resources.Resources.gold
        Me.ClientSize = New System.Drawing.Size(816, 489)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.cb_userType)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tb_birthdate)
        Me.Controls.Add(Me.tb_email)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.cb_civilstat)
        Me.Controls.Add(Me.cb_gender)
        Me.Controls.Add(Me.btn_register)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tb_nationality)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tb_username)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tb_securitynum)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tb_address)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_contactnum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_lname)
        Me.Controls.Add(Me.tb_fname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_birthdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents tb_email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cb_civilstat As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cb_gender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btn_register As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label13 As Label
    Friend WithEvents tb_nationality As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tb_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tb_securitynum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tb_address As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_contactnum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_lname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_fname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_userType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
