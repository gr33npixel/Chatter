Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.signedin = True Then
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub FlatClose1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Form2.Show()
    End Sub
End Class
