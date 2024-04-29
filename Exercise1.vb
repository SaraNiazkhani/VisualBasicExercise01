Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Exercise1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Num1 As Double = CDbl(firstNum.Text)
        Dim Num2 As Double = CDbl(SecondNum.Text)
        Dim sum As Long = Num1 + Num2
        OutPutlbl.Text = sum.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Num1 As Double = CDbl(firstNum.Text)
        Dim Num2 As Double = CDbl(SecondNum.Text)
        Dim Minus As Long = Num1 - Num2
        OutPutlbl.Text = Minus.ToString()
    End Sub
     Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
End
    End Sub
End Class
