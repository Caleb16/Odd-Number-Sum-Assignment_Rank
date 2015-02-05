Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intOddNum As Integer = Val(Me.txtOddNum.Text)
        Dim intFactor As Integer = 1
        Dim intFactorCounter As Integer = 0

        Dim intCounter As Integer
        For intCounter = 1 To intOddNum
            If intFactor Mod 2 = 1 Then
                intFactor = intFactor + intCounter
            ElseIf intFactor Mod 2 = 0 Then
                intFactor = intFactor + 1
                intFactorCounter += 1
            End If
        Next intCounter

        If intOddNum = 1 Then
            Me.lblResult.Text = "Follow the Rules. Pick Another Number Greater than 1."
        Else
            Me.lblResult.Text = "The Sum of all Odd Numbers Between 1 and " & intOddNum & " is " & (intFactor - intFactorCounter - 1)
            'The intFactorCounter is because my answers were coming out too high because of the intFactor = intFactor + 1. 
            'I had to do this because otherwise it would just get stuck on this part of the code and it wouldn't work continue to count up.

            '-1 is because after I added the intFactor counter, for some reason all of my answers kept coming out one too high.
            'I tested it with these changes with several random numbers and used my calculator to check the answers. They all came out correct.
            'I'm sure this isn't very professional (I hope you don't mind) but at least it works perfectly.
        End If
    End Sub
End Class
