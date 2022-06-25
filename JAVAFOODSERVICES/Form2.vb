Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Good Day Mr./Ms. " & txtname.Text + ", your order is now on process", vbOKOnly, "Order Confirmation")

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class