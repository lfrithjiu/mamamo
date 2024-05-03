Public Class Login

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        'this is magic code that has an enormous positive effect on reducing flickering.
        'don't remove this.
        'found this nugget here: http://www.vbmigration.com/detknowledgebase.aspx?Id=692
        Get
            Dim params As CreateParams = MyBase.CreateParams
            params.ExStyle = params.ExStyle Or &H2000000
            Return params
        End Get
    End Property

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        With Admin
            .TopLevel = False
            Guna2Panel3.Controls.Add(Admin)
            .BringToFront()
            .Show()
        End With
        Manager.Close()
        Cashier.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        With Cashier
            .TopLevel = False
            Guna2Panel3.Controls.Add(Cashier)
            .BringToFront()
            .Show()
        End With
        Manager.Close()
        Admin.Close()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        With Manager
            .TopLevel = False
            Guna2Panel3.Controls.Add(Manager)
            .BringToFront()
            .Show()
        End With
        Cashier.Close()
        Admin.Close()
    End Sub
End Class