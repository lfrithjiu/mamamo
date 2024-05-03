<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addCar
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
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.carModelTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.carNameTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cancelCarBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.addCarBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(61, 161)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(79, 22)
        Me.Guna2HtmlLabel5.TabIndex = 14
        Me.Guna2HtmlLabel5.Text = "Car Model:"
        '
        'carModelTxtBox
        '
        Me.carModelTxtBox.Animated = True
        Me.carModelTxtBox.BorderColor = System.Drawing.Color.Black
        Me.carModelTxtBox.BorderRadius = 17
        Me.carModelTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.carModelTxtBox.DefaultText = ""
        Me.carModelTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.carModelTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.carModelTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.carModelTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.carModelTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.carModelTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carModelTxtBox.ForeColor = System.Drawing.Color.Black
        Me.carModelTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.carModelTxtBox.Location = New System.Drawing.Point(61, 193)
        Me.carModelTxtBox.Margin = New System.Windows.Forms.Padding(4)
        Me.carModelTxtBox.Name = "carModelTxtBox"
        Me.carModelTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.carModelTxtBox.PlaceholderText = ""
        Me.carModelTxtBox.SelectedText = ""
        Me.carModelTxtBox.Size = New System.Drawing.Size(279, 34)
        Me.carModelTxtBox.TabIndex = 13
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(62, 68)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(78, 22)
        Me.Guna2HtmlLabel4.TabIndex = 12
        Me.Guna2HtmlLabel4.Text = "Car Name:"
        '
        'carNameTxtBox
        '
        Me.carNameTxtBox.Animated = True
        Me.carNameTxtBox.BorderColor = System.Drawing.Color.Black
        Me.carNameTxtBox.BorderRadius = 17
        Me.carNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.carNameTxtBox.DefaultText = ""
        Me.carNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.carNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.carNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.carNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.carNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.carNameTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carNameTxtBox.ForeColor = System.Drawing.Color.Black
        Me.carNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.carNameTxtBox.Location = New System.Drawing.Point(62, 105)
        Me.carNameTxtBox.Margin = New System.Windows.Forms.Padding(4)
        Me.carNameTxtBox.Name = "carNameTxtBox"
        Me.carNameTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.carNameTxtBox.PlaceholderText = ""
        Me.carNameTxtBox.SelectedText = ""
        Me.carNameTxtBox.Size = New System.Drawing.Size(279, 34)
        Me.carNameTxtBox.TabIndex = 11
        '
        'cancelCarBtn
        '
        Me.cancelCarBtn.Animated = True
        Me.cancelCarBtn.AutoRoundedCorners = True
        Me.cancelCarBtn.BorderRadius = 23
        Me.cancelCarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelCarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelCarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelCarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelCarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelCarBtn.FillColor = System.Drawing.Color.Silver
        Me.cancelCarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelCarBtn.ForeColor = System.Drawing.Color.Black
        Me.cancelCarBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_cancel_40
        Me.cancelCarBtn.Location = New System.Drawing.Point(35, 247)
        Me.cancelCarBtn.Name = "cancelCarBtn"
        Me.cancelCarBtn.Size = New System.Drawing.Size(164, 48)
        Me.cancelCarBtn.TabIndex = 16
        Me.cancelCarBtn.Text = "Cancel"
        '
        'addCarBtn
        '
        Me.addCarBtn.Animated = True
        Me.addCarBtn.AutoRoundedCorners = True
        Me.addCarBtn.BorderRadius = 23
        Me.addCarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addCarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addCarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addCarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addCarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addCarBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.addCarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addCarBtn.ForeColor = System.Drawing.Color.Black
        Me.addCarBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_add_40
        Me.addCarBtn.Location = New System.Drawing.Point(217, 247)
        Me.addCarBtn.Name = "addCarBtn"
        Me.addCarBtn.Size = New System.Drawing.Size(164, 48)
        Me.addCarBtn.TabIndex = 15
        Me.addCarBtn.Text = "Add"
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
        Me.GunaElipsePanel1.TabIndex = 21
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(79, 26)
        Me.Guna2HtmlLabel1.TabIndex = 14
        Me.Guna2HtmlLabel1.Text = "Add Car"
        '
        'addCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 324)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.cancelCarBtn)
        Me.Controls.Add(Me.addCarBtn)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.carModelTxtBox)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.carNameTxtBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addCar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Car"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents carModelTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents carNameTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cancelCarBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents addCarBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
