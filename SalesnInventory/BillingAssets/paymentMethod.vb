Public Class paymentMethod
    Private Sub paymentMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub cashBtn_Click(sender As Object, e As EventArgs) Handles cashBtn.Click
        Me.Close()
        cashMethod.ShowDialog()
    End Sub

    Private Sub lendBtn_Click(sender As Object, e As EventArgs) Handles lendBtn.Click
        Me.Close()
        lendMethod.ShowDialog()
    End Sub
End Class