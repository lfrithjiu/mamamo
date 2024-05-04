﻿Public Class Form1
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

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Users.Hide()
        Inventory.Hide()
        Bills.Hide()

        With Dashboard
            .TopLevel = False
            Panel5.Controls.Add(Dashboard)
            .BringToFront()
            .Dock = DockStyle.Left
            .Show()
        End With
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Users.Hide()
        Inventory.Hide()
        Dashboard.Hide()

        With Bills
            .TopLevel = False
            Panel5.Controls.Add(Bills)
            .BringToFront()
            .Dock = DockStyle.Left
            .Show()
        End With
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Users.Hide()
        Bills.Hide()
        Dashboard.Hide()

        With Inventory
            .TopLevel = False
            Panel5.Controls.Add(Inventory)
            .BringToFront()
            .Dock = DockStyle.Left
            .Show()
        End With
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Bills.Hide()
        Inventory.Hide()
        Dashboard.Hide()

        With Users
            .TopLevel = False
            Panel5.Controls.Add(Users)
            .BringToFront()
            .Dock = DockStyle.Left
            .Show()
        End With
    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = connection.getConnectionString()

        SaveFileDialog1.FileName = "sales_and_inventory.bak"
        If SaveFileDialog1.ShowDialog = ShowDialog.OK Then
            Dim lFolder As String = SaveFileDialog1.FileName
            Dim stmnt As String = "BACKUP DATABASE sales_and_inventory TO Disk='" & lFolder & "'"
            Dim command As New SqlClient.SqlCommand(stmnt, con)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Successfully made Back-up")
        Else
            MessageBox.Show("Error")
        End If

    End Sub


    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        Me.Button7.Visible = False
        Me.Close()
    End Sub
End Class
