Public Class Mam

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles touchButton.Click
        If Me.BackColor = Color.White Then
            Me.BackColor = Color.Firebrick
        Else
            Me.BackColor = Color.White
        End If
    End Sub
End Class
