Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' deklarasi variabel
        Dim hours As Integer
        Dim payrate As Integer
        Dim basic As Integer
        Dim extra As Integer
        Dim grossPay As Integer

        ' read input from TextBoxes'
        hours = tbWorkedHours.Text
        payrate = tbPayrate.Text
        basic = tbBasicWage.Text
        extra = tbExtraWage.Text

        ' Calculate gross pay with overtime calculation if hours worked exceed 40

        If hours <= 40 Then
            grossPay = hours * payrate

        Else
            ' calculate overtime
            Dim regularHours As Integer = 40
            Dim overtimeHours As Integer = hours - regularHours
            Dim overtimePayrate As Double = payrate * 1.1 '10% increase for overtime 
            grossPay = (regularHours * payrate) + (overtimeHours * overtimePayrate)

        End If

        grossPay = grossPay - extra + basic

        ' display grossPay into label'
        lblGrossPay.Text = grossPay.ToString()


    End Sub

End Class
