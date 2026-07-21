Public Class Form1

    Private defaultbtnColor As Color
    Private activeInput As TextBox

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        defaultbtnColor = btnAddition.BackColor
        activeInput = input1
    End Sub

    Private Sub input1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles input1.Enter
        activeInput = input1
    End Sub

    Private Sub input2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles input2.Enter
        activeInput = input2
    End Sub

    Private Sub EnterDigit(ByVal digit As String)
        activeInput.Text &= digit
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        EnterDigit("1")
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        EnterDigit("2")
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        EnterDigit("3")
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        EnterDigit("4")
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        EnterDigit("5")
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        EnterDigit("6")
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        EnterDigit("7")
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        EnterDigit("8")
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        EnterDigit("9")
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        EnterDigit("0")
    End Sub

    Private Sub btnDot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDot.Click
        EnterDigit(".")
    End Sub

    Private Sub ColoredOperators(ByVal currentButton As Button)
        btnAddition.BackColor = defaultbtnColor
        btnSubtraction.BackColor = defaultbtnColor
        btnMultiplication.BackColor = defaultbtnColor
        btnDivision.BackColor = defaultbtnColor
        currentButton.BackColor = Color.MediumPurple
    End Sub

    Private Sub Calculate(ByVal op As String)
        Dim num1 As Double
        Dim num2 As Double

        If Not Double.TryParse(input1.Text, num1) OrElse Not Double.TryParse(input2.Text, num2) Then
            MessageBox.Show("Make sure both [Input 1] and [Input 2] have numbers!")
            Exit Sub
        End If

        Select Case op
            Case "+"
                output.Text = (num1 + num2).ToString()

            Case "-"
                output.Text = (num1 - num2).ToString()

            Case "*"
                output.Text = (num1 * num2).ToString()

            Case "/"
                If num2 = 0 Then
                    MessageBox.Show("Cannot divide by zero!")
                    Exit Sub
                End If

                output.Text = (num1 / num2).ToString()
        End Select

    End Sub
    Private Sub btnAddition_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddition.Click
        ColoredOperators(btnAddition)
        Calculate("+")
    End Sub

    Private Sub btnSubtraction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubtraction.Click
        ColoredOperators(btnSubtraction)
        Calculate("-")
    End Sub

    Private Sub btnMultiplication_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMultiplication.Click
        ColoredOperators(btnMultiplication)
        Calculate("*")
    End Sub

    Private Sub btnDivision_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDivision.Click
        ColoredOperators(btnDivision)
        Calculate("/")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        input1.Text = ""
        input2.Text = ""
        output.Text = ""
        btnAddition.BackColor = defaultbtnColor
        btnSubtraction.BackColor = defaultbtnColor
        btnMultiplication.BackColor = defaultbtnColor
        btnDivision.BackColor = defaultbtnColor
        activeInput = input1
    End Sub
End Class
