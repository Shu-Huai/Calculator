Public Class mainForm
    Private firstNumber_ As Double
    Private secondNumber_ As Double
    Private needRefresh_ As Boolean
    Enum Operation
        Plus
        Minus
        Times
        Divide
    End Enum
    Private needOperation As Operation
    Private Sub PushZero(sender As Object, e As EventArgs) Handles zeroButton.Click
        If needRefresh_ Then
            numberEditor.Text = "0"
        Else
            If Not numberEditor.Text = "0" Then
                numberEditor.Text += "0"
            End If
        End If
    End Sub
    Private Sub PushOne(sender As Object, e As EventArgs) Handles oneButton.Click
        If needRefresh_ Then
            numberEditor.Text = "1"
            needRefresh_ = False
        Else
            numberEditor.Text += "1"
        End If
    End Sub
    Private Sub PushTwo(sender As Object, e As EventArgs) Handles twoButton.Click
        If needRefresh_ Then
            numberEditor.Text = "2"
            needRefresh_ = False
        Else
            numberEditor.Text += "2"
        End If
    End Sub
    Private Sub PushThree(sender As Object, e As EventArgs) Handles threeButton.Click
        If needRefresh_ Then
            numberEditor.Text = "3"
            needRefresh_ = False
        Else
            numberEditor.Text += "3"
        End If
    End Sub
    Private Sub PushFour(sender As Object, e As EventArgs) Handles fourButton.Click
        If needRefresh_ Then
            numberEditor.Text = "4"
            needRefresh_ = False
        Else
            numberEditor.Text += "4"
        End If
    End Sub
    Private Sub PushFive(sender As Object, e As EventArgs) Handles fiveButton.Click
        If needRefresh_ Then
            numberEditor.Text = "5"
            needRefresh_ = False
        Else
            numberEditor.Text += "5"
        End If
    End Sub
    Private Sub PushSix(sender As Object, e As EventArgs) Handles sixButton.Click
        If needRefresh_ Then
            numberEditor.Text = "6"
            needRefresh_ = False
        Else
            numberEditor.Text += "6"
        End If
    End Sub
    Private Sub PushSeven(sender As Object, e As EventArgs) Handles sevenButton.Click
        If needRefresh_ Then
            numberEditor.Text = "7"
            needRefresh_ = False
        Else
            numberEditor.Text += "7"
        End If
    End Sub
    Private Sub PushEight(sender As Object, e As EventArgs) Handles eightButton.Click
        If needRefresh_ Then
            numberEditor.Text = "8"
            needRefresh_ = False
        Else
            numberEditor.Text += "8"
        End If
    End Sub
    Private Sub PushNine(sender As Object, e As EventArgs) Handles nineButton.Click
        If needRefresh_ Then
            numberEditor.Text = "9"
            needRefresh_ = False
        Else
            numberEditor.Text += "9"
        End If
    End Sub
    Private Sub PushClear(sender As Object, e As EventArgs) Handles clearButton.Click
        numberEditor.Text = "0"
        needRefresh_ = True
    End Sub
    Private Sub PushPlus(sender As Object, e As EventArgs) Handles plusButton.Click
        If firstNumber_ = Double.MinValue Then
            firstNumber_ = numberEditor.Text
            needRefresh_ = True
        Else
            firstNumber_ += numberEditor.Text
            numberEditor.Text = firstNumber_
            needRefresh_ = True
        End If
        needOperation = Operation.Plus
    End Sub
    Private Sub PushMinus(sender As Object, e As EventArgs) Handles minusButton.Click
        If needRefresh_ Then
            If firstNumber_ = Double.MinValue Then
                firstNumber_ = numberEditor.Text
                needRefresh_ = True
                needOperation = Operation.Minus
            Else
                numberEditor.Text = "-"
                needRefresh_ = False
            End If

        Else
            If firstNumber_ = Double.MinValue Then
                firstNumber_ = numberEditor.Text
                needRefresh_ = True
            Else
                firstNumber_ -= numberEditor.Text
                numberEditor.Text = firstNumber_
                needRefresh_ = True
            End If
            needOperation = Operation.Minus
        End If

    End Sub
    Private Sub PushTimes(sender As Object, e As EventArgs) Handles timesButton.Click
        If firstNumber_ = Double.MinValue Then
            firstNumber_ = numberEditor.Text
            needRefresh_ = True
        Else
            firstNumber_ *= numberEditor.Text
            numberEditor.Text = firstNumber_
            needRefresh_ = True
        End If
        needOperation = Operation.Times
    End Sub
    Private Sub PushDevode(sender As Object, e As EventArgs) Handles devideButton.Click
        If firstNumber_ = Double.MinValue Then
            firstNumber_ = numberEditor.Text
            needRefresh_ = True
        Else
            firstNumber_ /= numberEditor.Text
            numberEditor.Text = firstNumber_
            needRefresh_ = True
        End If
        needOperation = Operation.Divide
    End Sub
    Private Sub PushResult(sender As Object, e As EventArgs) Handles equalButton.Click
        secondNumber_ = numberEditor.Text
        If firstNumber_ = Double.MinValue Then
            Return
        End If
        Select Case needOperation
            Case Operation.Plus
                numberEditor.Text = firstNumber_ + secondNumber_
            Case Operation.Minus
                numberEditor.Text = firstNumber_ - secondNumber_
            Case Operation.Times
                numberEditor.Text = firstNumber_ * secondNumber_
            Case Operation.Divide
                numberEditor.Text = firstNumber_ / secondNumber_
        End Select
        firstNumber_ = Double.MinValue
        secondNumber_ = Double.MinValue
        needRefresh_ = True
    End Sub
    Private Sub LoadMainForm(sender As Object, e As EventArgs) Handles MyBase.Load
        firstNumber_ = Double.MinValue
        secondNumber_ = Double.MinValue
        needRefresh_ = True
        numberEditor.Select(numberEditor.TextLength, 0)
    End Sub
    Private Sub PushDot(sender As Object, e As EventArgs) Handles dotButton.Click
        If needRefresh_ Then
            numberEditor.Text = "0."
            needRefresh_ = False
        ElseIf numberEditor.Text = "-" Then
            numberEditor.Text = "-0."
        Else
            numberEditor.Text += "."
        End If
    End Sub
End Class
