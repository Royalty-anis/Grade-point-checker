Imports System.Runtime.InteropServices

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim broCgpa As NFloat
        broCgpa = Val(TextBox1.Text)
        If NFloat.TryParse(TextBox1.Text, broCgpa) Then
            If broCgpa <= 1 Then
                dspbtn.Text = "advice to withdraw" & vbNewLine & "go learn mechanic"
            ElseIf broCgpa < 2.0 Then
                dspbtn.Text = "You need help!!!"

            ElseIf broCgpa > 5 Then
                dspbtn.Text = "invalid Input" & vbNewLine & "Number should be between 0 to 5"

            ElseIf broCgpa >= 3.0 Then
                dspbtn.Text = "you are on good standing!"
            End If
        Else
            dspbtn.Text = "Invalid"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dspbtn.Text = ""
        TextBox1.Text = ""
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class