Imports System.Security.Cryptography

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("

PRESS CHECK GP/CGPA IF YOU WANT TO CHECK YOUR GP/CGPA AND STATUS

PRESS CHECK STATUS IS YOU ONLY WANT TO CHECK STATUS


")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form2 As New Form2
        form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form3 As New Form3
        form3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form4 As New txtPictureFolder
        form4.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If isBackColorBlack Then
            ' Change background color to white for all forms
            Me.BackColor = Color.White
            Form2.BackColor = Color.White
            Form3.BackColor = Color.White
            Me.ForeColor = Color.Gray
            Button5.Text = "LIGHT MODE"
            isBackColorBlack = False
        Else
            ' Change background color to black for all forms
            Me.BackColor = Color.Black
            Form2.BackColor = Color.Black
            Form3.BackColor = Color.Black
            Me.ForeColor = Color.White
            Button5.Text = "DARK MODE"
            isBackColorBlack = True
        End If
    End Sub


End Class
