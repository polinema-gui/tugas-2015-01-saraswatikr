Public Class Form2

    Dim hasil As String = String.Empty


    Private Sub proses_Click(sender As Object, e As EventArgs) Handles proses.Click
        Try
            Select Case ComboBox1.Text
                Case "Pyramid"
                    pyramid(Convert.ToInt32(TextBox1.Text))
                Case "Hollow Pyramid"
                    hollowpyramid(Convert.ToInt32(TextBox1.Text))
                Case "Inverted Pyramid"
                    invertedpyramid(Convert.ToInt32(TextBox1.Text))
                Case "Hollow Inverted Pyramid"
                    hollowinvertedpyramid(Convert.ToInt32(TextBox1.Text))
                Case Else
                    TextBox2.Text = "Pola Belum Dipilih"
            End Select
        Catch ex As Exception
            TextBox2.Text = "Inputan Bukan Angka"
        End Try
    End Sub


    Private Sub pyramid(batas As Integer)
        Dim batasKolom1 As Integer = batas
        Dim batasKolom2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom < batasKolom1 Or kolom > batasKolom2) Then
                    Me.hasil &= " "
                Else
                    Me.hasil &= "*"
                End If
            Next
            batasKolom1 -= 1
            batasKolom2 += 1
            Me.hasil &= vbCrLf
        Next
        TextBox2.Text = hasil
        hasil = ""
    End Sub


    Private Sub hollowpyramid(batas As Integer)
        Dim batasKolom1 As Integer = batas
        Dim batasKolom2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris < batas) Then
                    If (kolom = batasKolom1 Or kolom = batasKolom2) Then
                        Me.hasil &= "*  "
                    Else
                        Me.hasil &= "  "
                    End If
                Else
                    Me.hasil &= "* "
                End If
            Next
            batasKolom1 -= 1
            batasKolom2 += 1
            Me.hasil &= vbCrLf
        Next
        TextBox2.Text = hasil
        hasil = ""
    End Sub


    Private Sub invertedpyramid(batas As Integer)
        Dim batasKolom1 As Integer = 0
        Dim batasKolom2 As Integer = batas * 2
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom > batasKolom1 And kolom < batasKolom2) Then
                    Me.hasil &= "*"
                Else
                    Me.hasil &= " "
                End If
            Next
            Me.hasil &= vbCrLf
            batasKolom1 += 1
            batasKolom2 -= 1
        Next
        TextBox2.Text = hasil
        Me.hasil = ""
    End Sub


    Private Sub hollowinvertedpyramid(batas As Integer)
        Dim batasKolom1 As Integer = 1
        Dim batasKolom2 As Integer = batas * 2 - 1
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris = 1) Then
                    Me.hasil &= "* "
                Else
                    If (kolom = batasKolom1 Or kolom = batasKolom2) Then
                        Me.hasil &= "*  "
                    Else
                        Me.hasil &= "  "
                    End If
                End If
            Next
            batasKolom1 += 1
            batasKolom2 -= 1
            Me.hasil &= vbCrLf
        Next
        TextBox2.Text = hasil
        Me.hasil = ""
    End Sub

End Class