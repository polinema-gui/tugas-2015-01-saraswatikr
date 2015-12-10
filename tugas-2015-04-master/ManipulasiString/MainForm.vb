Public Class MainForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kata1 As Integer = 0
        Dim kata2 As Integer = 0
        Dim array1() As Char = TextBox1.Text.ToArray()
        Dim array2() As Char = TextBox2.Text.ToArray()
        Dim output As String = ""
        For y As Integer = 0 To TextBox1.Text.Length - 1
            For z As Integer = 0 To TextBox2.Text.Length - 1
                If (array1(y).ToString.ToUpper.Equals(array2(z).ToString.ToUpper)) Then
                    kata1 = 1
                End If
                If (array2(y).ToString.ToUpper.Equals(array1(z).ToString.ToUpper)) Then
                    kata2 = 1
                End If
            Next
            If (kata1 > 0 And kata2 > 0) Then
                output = "Anagram"
            Else
                output = "Bukan Anagram"
                Exit For
            End If
            'kata1 = 0
            'kata2 = 0
        Next
        Label11.Text = output
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As Integer = 0
        Dim alphabet() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Dim array As String = TextBox3.Text.ToArray()
        Dim output As String = ""
        For y As Integer = 0 To alphabet.Length - 1
            For z As Integer = 0 To array.Length - 1
                If (alphabet(y).ToString.ToUpper.Equals(array(z).ToString.ToUpper)) Then
                    result += 1
                End If
            Next
            If (result > 0) Then
                output &= alphabet(y) & ":" & result & vbTab
            End If
            result = 0
        Next
        TextBox4.Text = output
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As Integer = 0
        Dim alphabet() As String = {"a", "i", "u", "e", "o"}
        Dim array As String = TextBox5.Text.ToArray()
        Dim output As String = ""
        For y As Integer = 0 To alphabet.Length - 1
            For z As Integer = 0 To array.Length - 1
                If (alphabet(y).ToString.ToUpper.Equals(array(z).ToString.ToUpper)) Then
                    result += 1
                End If
            Next
            If (result > 0) Then
                output &= alphabet(y) & ":" & result & vbTab
            End If
            result = 0
        Next
        TextBox6.Text = output
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As Integer = 0
        Dim alphabet() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Dim array As String = TextBox8.Text.ToArray()
        Dim output As String = ""
        Dim cek As Boolean = True
        For y As Integer = 0 To array.Length - 1
            If (array(y).ToString.Equals(" ")) Then
                output &= " "
            End If
            For z As Integer = 0 To alphabet.Length - 1
                If (array(y).ToString.Equals(" ")) Then
                    output &= ""
                ElseIf (alphabet(z).ToString.ToUpper.Equals(array(y).ToString.ToUpper)) Then
                    If (z - TextBox7.Text < 0) Then
                        output &= alphabet(z - TextBox7.Text + alphabet.Length)
                    Else
                        output &= alphabet(z - TextBox7.Text)
                    End If
                End If
            Next
        Next
        TextBox9.Text = output
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim result As Integer = 0
        Dim alphabet() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Dim array As String = TextBox8.Text.ToArray()
        Dim output As String = ""
        For y As Integer = 0 To array.Length - 1
            If (array(y).ToString.ToUpper.Equals(" ")) Then
                output &= " "
            End If
            For z As Integer = 0 To alphabet.Length - 1
                If (alphabet(z).Equals(array(y))) Then
                    If (z + TextBox7.Text > alphabet.Length - 1) Then
                        output &= alphabet(z + TextBox7.Text - alphabet.Length)
                    Else
                        output &= alphabet(z + TextBox7.Text)
                    End If
                End If
            Next
        Next
        TextBox9.Text = output
    End Sub
End Class