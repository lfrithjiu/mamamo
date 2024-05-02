<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paymentMethod
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
        Me.cashBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.lendBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cashBtn
        '
        Me.cashBtn.Animated = True
        Me.cashBtn.AutoRoundedCorners = True
        Me.cashBtn.BackColor = System.Drawing.Color.Transparent
        Me.cashBtn.BorderRadius = 20
        Me.cashBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cashBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cashBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cashBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cashBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.cashBtn.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cashBtn.ForeColor = System.Drawing.Color.Black
        Me.cashBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_cash_40__1_
        Me.cashBtn.IndicateFocus = True
        Me.cashBtn.Location = New System.Drawing.Point(222, 91)
        Me.cashBtn.Name = "cashBtn"
        Me.cashBtn.Size = New System.Drawing.Size(187, 42)
        Me.cashBtn.TabIndex = 10
        Me.cashBtn.Text = "Cash"
        Me.cashBtn.UseTransparentBackground = True
        '
        'lendBtn
        '
        Me.lendBtn.Animated = True
        Me.lendBtn.AutoRoundedCorners = True
        Me.lendBtn.BackColor = System.Drawing.Color.Transparent
        Me.lendBtn.BorderRadius = 20
        Me.lendBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.lendBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.lendBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lendBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lendBtn.FillColor = System.Drawing.Color.MidnightBlue
        Me.lendBtn.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lendBtn.ForeColor = System.Drawing.Color.White
        Me.lendBtn.Image = Global.SalesnInventory.My.Resources.Resources.icons8_lend_50
        Me.lendBtn.IndicateFocus = True
        Me.lendBtn.Location = New System.Drawing.Point(12, 91)
        Me.lendBtn.Name = "lendBtn"
        Me.lendBtn.Size = New System.Drawing.Size(187, 42)
        Me.lendBtn.TabIndex = 9
        Me.lendBtn.Text = "Lend"
        Me.lendBtn.UseTransparentBackground = True
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(12, 49)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(178, 36)
        Me.Guna2HtmlLabel2.TabIndex = 8
        Me.Guna2HtmlLabel2.Text = "Select a Method:"
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
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(421, 36)
        Me.GunaElipsePanel1.TabIndex = 13
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(96, 36)
        Me.Guna2HtmlLabel1.TabIndex = 14
        Me.Guna2HtmlLabel1.Text = "Payment"
        '
        'paymentMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 145)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.cashBtn)
        Me.Controls.Add(Me.lendBtn)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "paymentMethod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Method"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cashBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lendBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
