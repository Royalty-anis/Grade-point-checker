Imports System.ComponentModel.Design
Imports System.Runtime.InteropServices
Imports System.Runtime.Intrinsics.X86

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("

                    WELCOME!  NOTICE!!!
        IF THE COURSES YOU INPUT IS LESS THAN THE AVAILABLE BOX
                  INPUT '0' INTO THE EMPTY BOXES 

")

    End Sub


    Private Sub Button1_Click(sender As Object, Z As EventArgs) Handles Button1.Click
        Dim ut1, ut2, ut3, ut4, ut5, ut6, ut7, ut8, ut9, ut10, ut11, gd1, gd2, gd3, gd4, gd5, gd6, gd7, gd8, gd9, gd10, gd11, total_grade_point As Integer
        Dim cal1, cal2, cal3, cal4, cal5, cal6, cal7, cal8, cal9, cal10, cal11, total_unit, overall_score As Integer




        ut1 = TextBox11.Text
        ut2 = TextBox10.Text
        ut3 = TextBox9.Text
        ut4 = TextBox8.Text
        ut5 = TextBox7.Text
        ut6 = TextBox6.Text
        ut7 = TextBox5.Text
        ut8 = TextBox18.Text
        ut9 = TextBox14.Text
        ut10 = TextBox21.Text
        ut11 = TextBox24.Text


        total_unit = (ut1 + ut2 + ut3 + ut4 + ut5 + ut6 + ut7 + ut8 + ut9 + ut10 + ut11)
        gd1 = TextBoxH.Text
        gd2 = TextBoxI.Text
        gd3 = TextBoxJ.Text
        gd4 = TextBoxK.Text
        gd5 = TextBoxL.Text
        gd6 = TextBoxM.Text
        gd7 = TextBoxN.Text
        gd8 = TextBoxO.Text
        gd9 = TextBoxP.Text
        gd10 = TextBoxQ.Text
        gd11 = TextBoxR.Text

        total_grade_point = (gd1 + gd2 + gd3 + gd4 + gd5 + gd6 + gd7 + gd8 + gd9 + gd10 + gd11)
        cal1 = ut1 * gd1
        cal2 = ut2 * gd2
        cal3 = ut3 * gd3
        cal4 = ut4 * gd4
        cal5 = ut5 * gd5
        cal6 = ut6 * gd6
        cal7 = ut7 * gd7
        cal8 = ut8 * gd8
        cal9 = ut9 * gd9
        cal10 = ut10 * gd10
        cal11 = ut11 * gd11

        overall_score = (cal1 + cal2 + cal3 + cal4 + cal5 + cal6 + cal7 + cal8 + cal9 + cal10 + cal11)

        '  "LC" represents the location for the calculated courses unit and grade point for each segment
        LC1.Text = cal1
        LC2.Text = cal2
        LC3.Text = cal3
        LC4.Text = cal4
        LC5.Text = cal5
        LC6.Text = cal6
        LC7.Text = cal7
        LC8.Text = cal8
        LC9.Text = cal9
        LC10.Text = cal10
        LC11.Text = cal11




        GP.Text = overall_score / total_unit


        dspbtn1.Text = Val(GP.Text)
        If Val(dspbtn1.Text) <= 1 Then
            dspbtn1.Text = "YOU NEED HELP" & "REACHOUT TO YOUR LEVEL ADVISOR"
        ElseIf Val(dspbtn1.Text) < 3.0 Then
            dspbtn1.Text = "YOU ARE NOT ON GOOD STANDING!"
        ElseIf Val(dspbtn1.Text) > 5 Then
            MsgBox("

                    INVALID

")
            dspbtn1.Text = "GP SHOULD BE BETWEEN 0 TO  5"
            GP.Text = " "
        ElseIf Val(dspbtn1.Text) >= 3 Then
            dspbtn1.Text = "YOU ARE ON GOOD STANDING"
        ElseIf Val(dspbtn1.Text) Then
        End If









    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub CLEAR_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("

                              NOTICE!!!

        IF THE COURSES YOU INPUT IS LESS THAN THE AVAILABLE BOX
                  INPUT '0' INTO THE EMPTY BOXES 



")
    End Sub

    Private Sub GP_Click(sender As Object, e As EventArgs) Handles GP.Click

    End Sub
End Class