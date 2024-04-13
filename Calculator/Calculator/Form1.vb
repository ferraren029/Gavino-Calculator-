Public Class Form1
    Dim num1 As Double
    Dim num2 As Double
    Dim operation As String

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button5.Click, Button6.Click, Button7.Click, Button9.Click, btnDivide.Click, Button11.Click, btnMultiply.Click
        Dim button = CType(sender, Button)
        TextBox1.Text += button.Text
    End Sub

    Private Sub Operator_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click, btnMultiply.Click, btnDivide.Click
        Dim button As Button = CType(sender, Button)
        operation = button.Text
        num1 = CDbl(TextBox1.Text)
        TextBox1.Text = ""
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        num2 = CDbl(TextBox1.Text)
        Select Case operation
            Case "+"
                TextBox1.Text = (num1 + num2).ToString()
            Case "-"
                TextBox1.Text = (num1 - num2).ToString()
            Case "*"
                TextBox1.Text = (num1 * num2).ToString()
            Case "/"
                If num2 <> 0 Then
                    TextBox1.Text = (num1 / num2).ToString()
                Else
                    TextBox1.Text = "Error"
                End If
        End Select
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Clear()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs)

    End Sub
End Class