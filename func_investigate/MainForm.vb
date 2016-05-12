Public Class MainForm

    Dim funcResult As List(Of KeyValuePair(Of Double, Double)) = New List(Of KeyValuePair(Of Double, Double))
    Dim funcMax As KeyValuePair(Of Double, Double)
    Dim funcMin As KeyValuePair(Of Double, Double)
    Dim funcRoots As List(Of Double) = New List(Of Double)
    Const GraphicYOffset = 20
    Const MaxYBorder = 10000000


    Private Sub GraphicClearButton_Click(sender As Object, e As EventArgs) Handles GraphicClearButton.Click
        ClearGraphics()
    End Sub

    Private Sub ClearGraphics()
        Dim g As Graphics = GraphicsPanel.CreateGraphics()
        Dim width = GraphicsPanel.Width
        Dim height = GraphicsPanel.Height
        Dim blackPen As Pen = New Pen(Color.Black)

        g.Clear(SystemColors.Control)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim StartCalculateValue As Double = Convert.ToDouble(StartValue.Text)
        Dim EndCalculateValue As Double = Convert.ToDouble(EndValue.Text)
        g.DrawLine(blackPen, 0, Convert.ToInt32(height / 2), width, Convert.ToInt32(height / 2))
        Dim k As Single = (-StartCalculateValue + 1) / (EndCalculateValue - StartCalculateValue + 2)
        g.DrawLine(blackPen, Convert.ToInt32(width * k), 0, Convert.ToInt32(width * k), height)
        For i As Double = StartCalculateValue - 1 To EndCalculateValue + 1
            g.DrawString(Convert.ToString(i), GraphicsPanel.Font, Brushes.Black, NormalizeCoordX(i, width), Convert.ToInt32(height / 2))
        Next
        g.DrawRectangle(blackPen, 0, 0, width - 1, height - 1)
    End Sub

    Private Sub GraphicFunctionButton_Click(sender As Object, e As EventArgs) Handles GraphicFunctionButton.Click
        DrawChart(funcResult, Color.DarkRed)
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ClearGraphics()
        NextValue.Value = 1.0
        StepValue.Value = 0.001
    End Sub

    Private Function CalculateY(x As Double, N As Double) As Double
        Return 5 + ((-5 + 2 * x + 1 * x ^ 2 + 4 * N * x ^ 3) + N * x ^ 4) / (1 - N * x) ^ (4 / 5)
    End Function

    Private Sub CalculateFunction()
        Dim StartCalculateValue As Double = Convert.ToDouble(StartValue.Text)
        Dim EndCalculateValue As Double = Convert.ToDouble(EndValue.Text)
        Dim StepCalculateValue As Double = Convert.ToDouble(StepValue.Value)
        Dim N As Double = Convert.ToDouble(NextValue.Value)

        funcResult.Clear()
        Dim fyMax = -1000000000000000
        Dim fxMax = 0
        Dim fyMin = 1000000000000000
        Dim fxMin = 0
        For x As Double = StartCalculateValue To EndCalculateValue Step StepCalculateValue
            Dim y As Double = CalculateY(x, N)
            If (Double.IsNaN(y) Or y < -7 Or y > 7) Then
                Continue For
            End If
            funcResult.Add(New KeyValuePair(Of Double, Double)(x, y))

            If y > fyMax Then
                fyMax = y
                fxMax = x
            End If

            If y < fyMin Then
                fyMin = y
                fxMin = x
            End If
        Next
        funcMax = New KeyValuePair(Of Double, Double)(fxMax, fyMax)
        funcMin = New KeyValuePair(Of Double, Double)(fxMin, fyMin)
        CalculateRoots()
    End Sub

    Private Sub DrawChart(result As List(Of KeyValuePair(Of Double, Double)), color As Color)
        Dim g As Graphics = GraphicsPanel.CreateGraphics()
        Dim width = GraphicsPanel.Width
        Dim height = GraphicsPanel.Height
        Dim coloredPen As Pen = New Pen(color)

        coloredPen.Width = 2
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim xprev As Integer = -1
        Dim yprev As Integer = -1
        Dim xs, ys As Integer

        For Each pair As KeyValuePair(Of Double, Double) In result
            Dim y As Double = pair.Value
            Dim x As Double = pair.Key

            xs = NormalizeCoordX(x, width)
            ys = NormalizeCoordY(y, height)

            If (ys > width) Then
                ys = width
            ElseIf (ys < 0) Then
                ys = 0
            End If

            If xprev >= 0 Then
                g.DrawLine(coloredPen, xprev, yprev, xs, ys)
            End If
            xprev = xs
            yprev = ys
        Next
    End Sub

    Private Sub CalculateFunctionButton_Click(sender As Object, e As EventArgs) Handles CalculateFunctionButton.Click
        CalculateFunction()
        FunctionMinValue.Text = Convert.ToString(funcMin.Value)
        FunctionMaxValue.Text = Convert.ToString(funcMax.Value)
        FunctionResultList.Items.Clear()
        For Each pair As KeyValuePair(Of Double, Double) In funcResult
            Dim y As Double = pair.Value
            Dim x As Double = pair.Key
            Dim text As String = String.Format("x: {0:G5}, y: {1:G5}", x, y)
            FunctionResultList.Items.Add(text)
        Next
        FunctionRootList.Items.Clear()
        For Each root As Double In funcRoots
            FunctionRootList.Items.Add(String.Format("{0:G5}", root))
        Next
        GraphicFunctionButton.Enabled = True
        GraphicMaxMinButton.Enabled = True
    End Sub

    Private Sub CalculateRoots()
        Dim Epsi As Double = Convert.ToDouble(ErrorValue.Value)
        Dim StartCalculateValue As Double = Convert.ToDouble(StartValue.Text)
        Dim EndCalculateValue As Double = Convert.ToDouble(EndValue.Text)
        Dim N As Double = Convert.ToDouble(NextValue.Value)

        funcRoots.Clear()
        CalculateRoots(StartCalculateValue, EndCalculateValue, N, Epsi, funcRoots)
    End Sub

    Private Sub CalculateRoots(StartValue As Double, EndValue As Double, N As Double, Epsi As Double, roots As List(Of Double))
        Dim x As Double = (StartValue + EndValue) / 2
        Dim fx As Double = CalculateY(x, N)
        Dim val As Double = CalculateY(StartValue, N) * fx

        If (Math.Abs(fx) < Epsi Or EndValue - StartValue < Epsi) Then
            Return
        ElseIf (fx + Epsi = 0 Or fx - Epsi = 0 Or fx = 0) Then
            roots.Add(x)
        ElseIf (val > 0) Then
            CalculateRoots(x, EndValue, N, Epsi, roots)
        ElseIf (val < 0) Then
            CalculateRoots(StartValue, x, N, Epsi, roots)
        End If
    End Sub

    Private Sub GraphicMaxMinButton_Click(sender As Object, e As EventArgs) Handles GraphicMaxMinButton.Click
        Dim g As Graphics = GraphicsPanel.CreateGraphics()
        Dim coloredPen As Pen = New Pen(Color.DarkGreen)
        Dim width = GraphicsPanel.Width
        Dim height = GraphicsPanel.Height

        coloredPen.Width = 1
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.DrawEllipse(coloredPen, NormalizeCoordX(funcMin.Key, width), NormalizeCoordY(funcMin.Value, height), 2, 2)
        g.DrawEllipse(coloredPen, NormalizeCoordX(funcMax.Key, width), NormalizeCoordY(funcMax.Value, height), 2, 2)
    End Sub

    Private Function NormalizeCoordX(x As Double, width As Integer) As Integer
        Return Convert.ToInt64((x + 6) * (width / 9.0))
    End Function

    Private Function NormalizeCoordY(y As Double, height As Integer) As Integer
        If (y > MaxYBorder) Then
            y = MaxYBorder
        End If
        y = -y
        Return Convert.ToInt64((height / 11.0) * (y + 6)) - GraphicYOffset
    End Function
End Class
