Imports System.IO

Public Class txtPictureFolder
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' Assign image to a ListViewItem



    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile("C:\Users\USER\source\repos\Csc 215 project 6\Resources\Badmus ibrahim.png")
        PictureBox2.Image = Image.FromFile("C:\Users\USER\source\repos\Csc 215 project 6\Resources\whensu sesheyon faith.png")
        PictureBox3.Image = Image.FromFile("C:\Users\USER\source\repos\Csc 215 project 6\Resources\ayomiposi adeniyi.jpeg")
        PictureBox4.Image = Image.FromFile("C:\Users\USER\source\repos\Csc 215 project 6\Resources\Boluwatife halimat abolarinwa.jpeg")
        PictureBox5.Image = Image.FromFile("C:\Users\USER\source\repos\Csc 215 project 6\Resources\Dosa ezekiel shediye.jpeg")
        PictureBox6.Image = Image.FromFile("C:\Users\USER\source\repos\Csc 215 project 6\Resources\e.png")
        PictureBox7.Image = Image.FromFile("C:\Users\USER\source\repos\Csc 215 project 6\Resources\iilola eniolabi gboluwaga.jpeg")
        PictureBox8.Image = Image.FromFile("C:\Users\USER\source\repos\Csc 215 project 6\Resources\s.jpeg")
        'PictureBox9.Image = Image.FromFile("C:\Users\USER\source\repos\Csc 215 project 6\Resources\Boluwatife halimat abolarinwa.jpeg")
        PictureBox10.Image = Image.FromFile("C:\Users\USER\source\repos\Csc 215 project 6\Resources\samod balogun.jpeg")

        PictureBox10.Image = Image.FromFile("C:\Users\USER\source\repos\Csc 215 project 6\Resources\w.jpeg")



    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class