Public Class Form1

    Private flag = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & "0"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If flag = False Then
            TextBox1.Text = ""
            TextBox1.Text = TextBox1.Text & "1"
            flag = True
        ElseIf flag = True Then
            TextBox1.Text = TextBox1.Text & "1"
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If flag = False Then
            TextBox1.Text = ""
            TextBox1.Text = TextBox1.Text & "2"
            flag = True
        ElseIf flag = True Then
            TextBox1.Text = TextBox1.Text & "2"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If flag = False Then
            TextBox1.Text = ""
            TextBox1.Text = TextBox1.Text & "3"
            flag = True
        ElseIf flag = True Then
            TextBox1.Text = TextBox1.Text & "3"
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If flag = False Then
            TextBox1.Text = ""
            TextBox1.Text = TextBox1.Text & "4"
            flag = True
        ElseIf flag = True Then
            TextBox1.Text = TextBox1.Text & "4"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If flag = False Then
            TextBox1.Text = ""
            TextBox1.Text = TextBox1.Text & "5"
            flag = True
        ElseIf flag = True Then
            TextBox1.Text = TextBox1.Text & "5"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If flag = False Then
            TextBox1.Text = ""
            TextBox1.Text = TextBox1.Text & "6"
            flag = True
        ElseIf flag = True Then
            TextBox1.Text = TextBox1.Text & "6"
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If flag = False Then
            TextBox1.Text = ""
            TextBox1.Text = TextBox1.Text & "7"
            flag = True
        ElseIf flag = True Then
            TextBox1.Text = TextBox1.Text & "7"
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If flag = False Then
            TextBox1.Text = ""
            TextBox1.Text = TextBox1.Text & "8"
            flag = True
        ElseIf flag = True Then
            TextBox1.Text = TextBox1.Text & "8"
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If flag = False Then
            TextBox1.Text = ""
            TextBox1.Text = TextBox1.Text & "9"
            flag = True
        ElseIf flag = True Then
            TextBox1.Text = TextBox1.Text & "9"
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox1.Text = "0"
        flag = False
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)

        If TextBox1.Text.Length = 0 Then
            TextBox1.Text = "0"
            flag = False
        End If
    End Sub
End Class
