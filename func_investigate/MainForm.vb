Imports System.Drawing.Imaging
Imports System.Threading

Public Class MainForm

    ReadOnly _funcResult As List(Of KeyValuePair(Of Double, Double)) = New List(Of KeyValuePair(Of Double, Double))
    ReadOnly _funcDiffResult As List(Of KeyValuePair(Of Double, Double)) = New List(Of KeyValuePair(Of Double, Double))
    ReadOnly _funcIntegralResult As List(Of KeyValuePair(Of Double, Double)) = New List(Of KeyValuePair(Of Double, Double))
    Dim _funcMax As KeyValuePair(Of Double, Double)
    Dim _funcMin As KeyValuePair(Of Double, Double)
    ReadOnly _funcRoots As List(Of KeyValuePair(Of Double, Double)) = New List(Of KeyValuePair(Of Double, Double))
    Const GraphicYOffset = 20
    Const MaxYBorder = 10000000

    Dim _graphic As Bitmap


    Private Sub GraphicClearButton_Click(sender As Object, e As EventArgs) Handles GraphicClearButton.Click
        ClearGraphics()
        GraphicsPanel.Invalidate()
    End Sub

    Private Sub ClearGraphics()
        Dim g As Graphics = Graphics.FromImage(_graphic)
        Dim blackPen = New Pen(Color.Black, 1)

        g.Clear(SystemColors.Control)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim startCalculateValue As Double = Convert.ToDouble(StartValue.Text)
        Dim endCalculateValue As Double = Convert.ToDouble(EndValue.Text)
        g.DrawLine(blackPen, 0, Convert.ToInt32(GraphicsPanel.Height / 2), GraphicsPanel.Width, Convert.ToInt32(GraphicsPanel.Height / 2))
        Dim k As Single = (-startCalculateValue + 1) / (endCalculateValue - startCalculateValue + 2)
        g.DrawLine(blackPen, Convert.ToInt32(GraphicsPanel.Width * k), 0, Convert.ToInt32(GraphicsPanel.Width * k), GraphicsPanel.Height)
        For i As Double = startCalculateValue - 1 To endCalculateValue + 1
            g.DrawString(Convert.ToString(i), GraphicsPanel.Font, Brushes.Black, NormalizeCoordX(i, GraphicsPanel.Width), Convert.ToInt32(GraphicsPanel.Height / 2))
        Next
        g.DrawRectangle(blackPen, 0, 0, GraphicsPanel.Width - blackPen.Width, GraphicsPanel.Height - blackPen.Width)
    End Sub

    Private Sub GraphicFunctionButton_Click(sender As Object, e As EventArgs) Handles GraphicFunctionButton.Click
        DrawChart(_funcResult, Color.DarkRed)
        GraphicsPanel.Invalidate()
    End Sub

    Private Sub GraphicDiffButton_Click(sender As Object, e As EventArgs) Handles GraphicDiffButton.Click
        DrawChart(_funcDiffResult, Color.DarkOrchid)
        GraphicsPanel.Invalidate()
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ClearGraphics()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _graphic = New Bitmap(GraphicsPanel.Width, GraphicsPanel.Height, PixelFormat.Format32bppArgb)
        ClearGraphics()
    End Sub

    Private Shared Function CalculateY(x As Double, n As Double) As Double
        Return 5 + ((-5 + 2 * x + 1 * x ^ 2 + 4 * n * x ^ 3) + n * x ^ 4) / (1 - n * x) ^ (4 / 5)
    End Function

    Private Sub CalculateFunction()
        Dim startCalculateValue As Double = Convert.ToDouble(StartValue.Text)
        Dim endCalculateValue As Double = Convert.ToDouble(EndValue.Text)
        Dim stepCalculateValue As Double = Convert.ToDouble(StepValue.Value)
        Dim n As Double = Convert.ToDouble(NextValue.Value)

        _funcResult.Clear()
        Dim fyMax = -1000000000000000
        Dim fxMax = 0
        Dim fyMin = 1000000000000000
        Dim fxMin = 0
        For x As Double = startCalculateValue To endCalculateValue Step stepCalculateValue
            Dim y As Double = CalculateY(x, n)
            If (Double.IsNaN(y) Or y < -7 Or y > 7) Then
                Continue For
            End If
            _funcResult.Add(New KeyValuePair(Of Double, Double)(x, y))

            If y > fyMax Then
                fyMax = y
                fxMax = x
            End If

            If y < fyMin Then
                fyMin = y
                fxMin = x
            End If
        Next
        _funcMax = New KeyValuePair(Of Double, Double)(fxMax, fyMax)
        _funcMin = New KeyValuePair(Of Double, Double)(fxMin, fyMin)
        CalculateRoots()
        ClaculateDiff()
    End Sub

    Private Sub ClaculateDiff()
        Const delta = 0.0001
        Dim startCalculateValue As Double = Convert.ToDouble(StartValue.Text)
        Dim endCalculateValue As Double = Convert.ToDouble(EndValue.Text)
        Dim n As Double = Convert.ToDouble(NextValue.Value)

        _funcDiffResult.Clear()
        For x As Double = startCalculateValue To endCalculateValue Step delta
            Dim yDelta = CalculateY(x + delta, n)
            Dim yx = CalculateY(x, n)
            Dim result As Double = (yDelta - yx) / delta
            _funcDiffResult.Add(New KeyValuePair(Of Double, Double)(x, result))
        Next
    End Sub

    Private Sub DrawChart(result As List(Of KeyValuePair(Of Double, Double)), color As Color)
        Dim g As Graphics = Graphics.FromImage(_graphic)
        Dim coloredPen = New Pen(color)

        coloredPen.Width = 2
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim xprev As Integer = -1
        Dim yprev As Integer = -1
        Dim xs, ys As Integer

        For Each pair As KeyValuePair(Of Double, Double) In result
            Dim y As Double = pair.Value
            Dim x As Double = pair.Key

            xs = NormalizeCoordX(x, GraphicsPanel.Width)
            ys = NormalizeCoordY(y, GraphicsPanel.Height)

            If (ys > GraphicsPanel.Width) Then
                ys = GraphicsPanel.Width
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
        PrepareStartFunctionCall(Me)
        CalculateFunction()
        PrepareEndFunctionCall(Me)
    End Sub

    Private Sub CalculateRoots()
        Dim epsi As Double = Convert.ToDouble(ErrorValue.Value)
        Dim stepCalculateValue As Double = Convert.ToDouble(StepValue.Value)
        Dim n As Double = Convert.ToDouble(NextValue.Value)

        _funcRoots.Clear()

        For Each pair As KeyValuePair(Of Double, Double) In _funcResult
            Dim x As Double = pair.Key
            Dim y As Double = pair.Value
            Dim yy As Double = CalculateY(x + stepCalculateValue, n)

            If Math.Abs(y) < epsi Then
                _funcRoots.Add(New KeyValuePair(Of Double, Double)(x, y))
            ElseIf y * yy < 0 Then
                Dim root As Double = CalculateRoot(x, x + stepCalculateValue, n, epsi)
                _funcRoots.Add(New KeyValuePair(Of Double, Double)(x, root))
            End If
        Next
    End Sub

    Private Shared Function CalculateRoot(xLeft As Double, xRight As Double, n As Double, epsilon As Double) As Double
        Dim aa As Double = xLeft
        Dim bb As Double = xRight
        Dim xx As Double
        Dim fa As Double
        Dim fx As Double
        Do
            xx = (aa + bb) / 2
            fx = CalculateY(xx, n)
            fa = CalculateY(aa, n)
            If fa * fx > 0 Then
                aa = xx
            Else
                bb = xx
            End If
        Loop Until Math.Abs(fx) < epsilon Or bb - aa < epsilon
        Return xx
    End Function

    Private Sub GraphicMaxMinButton_Click(sender As Object, e As EventArgs) Handles GraphicMaxMinButton.Click
        DrawPoint(_funcMin.Key, _funcMin.Value, Color.DarkGreen)
        DrawPoint(_funcMax.Key, _funcMax.Value, Color.DarkGreen)
    End Sub

    Private Sub DrawPoint(x As Double, y As Double, color As Color)
        Dim g As Graphics = GraphicsPanel.CreateGraphics()
        Dim coloredPen = New Pen(color)

        coloredPen.Width = 2
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.DrawEllipse(coloredPen, NormalizeCoordX(x, GraphicsPanel.Width), NormalizeCoordY(y, GraphicsPanel.Height), 2, 2)
    End Sub

    Private Shared Function NormalizeCoordX(x As Double, width As Integer) As Integer
        Return Convert.ToInt64((x + 6) * (width / 9.0))
    End Function

    Private Shared Function NormalizeCoordY(y As Double, height As Integer) As Integer
        If (y > MaxYBorder Or Double.IsNaN(y)) Then
            y = MaxYBorder
        End If
        y = -y
        Return Convert.ToInt64((height / 11.0) * (y + 6)) - GraphicYOffset
    End Function

    Private Sub FunctionRootList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FunctionRootList.SelectedIndexChanged, FunctionResultList.SelectedIndexChanged, IntegralResultList.SelectedIndexChanged
        Dim list As ListBox = sender
        Dim point As PointView = list.SelectedItem

        DrawPoint(point.X, point.Y, Color.DarkBlue)
    End Sub

    Private Class PointView
        Public ReadOnly X As Double
        Public ReadOnly Y As Double

        Public Sub New(x As Double, y As Double)
            Me.X = x
            Me.Y = y
        End Sub

        Public Overrides Function ToString() As String
            Return String.Format("X: {0:G5}, Y: {1:G5}", X, Y)
        End Function
    End Class

    Private Sub CalculateIntegralButton_Click(sender As Object, e As EventArgs) Handles CalculateIntegralButton.Click
        CalculateIntegral()
        IntegralResultList.Items.Clear()
        For Each pair As KeyValuePair(Of Double, Double) In _funcIntegralResult
            Dim y As Double = pair.Value
            Dim x As Double = pair.Key
            IntegralResultList.Items.Add(New PointView(x, y))
        Next
        GraphicIntegralButton.Enabled = True
    End Sub

    Private Sub CalculateIntegral()
        Dim startValue As Double = Convert.ToDouble(StartIntegralValue.Text)
        Dim endValue As Double = Convert.ToDouble(EndIntegralValue.Text)

        _funcIntegralResult.Clear()

        'TODO: Расчет интеграла
    End Sub

    Private Sub GraphicIntegralButton_Click(sender As Object, e As EventArgs) Handles GraphicIntegralButton.Click
        DrawChart(_funcIntegralResult, Color.Coral)
        GraphicsPanel.Invalidate()
    End Sub

    Private Sub GraphicsPanel_Paint(sender As Object, e As PaintEventArgs) Handles GraphicsPanel.Paint
        Dim g As Graphics = GraphicsPanel.CreateGraphics()
        g.DrawImage(_graphic, 0, 0, GraphicsPanel.Width, GraphicsPanel.Height)
    End Sub

    Private Shared Sub PrepareStartFunctionCall(form As MainForm)
        If form.FunctionResultList.InvokeRequired Then
            form.Invoke(Sub()
                            PrepareStartFunctionCall(form)
                        End Sub)
        Else
            form.GraphicFunctionButton.Enabled = False
            form.GraphicDiffButton.Enabled = False
            form.GraphicMaxMinButton.Enabled = False
            form.FunctionResultList.Items.Clear()
            form.FunctionRootList.Items.Clear()
        End If
    End Sub
    Private Shared Sub PrepareEndFunctionCall(form As MainForm)
        If form.FunctionResultList.InvokeRequired Then
            form.Invoke(Sub()
                            PrepareEndFunctionCall(form)
                        End Sub)
        Else
            form.FunctionMinValue.Text = Convert.ToString(form._funcMin.Value)
            form.FunctionMaxValue.Text = Convert.ToString(form._funcMax.Value)

            For Each pair As KeyValuePair(Of Double, Double) In form._funcResult
                Dim y As Double = pair.Value
                Dim x As Double = pair.Key
                form.FunctionResultList.Items.Add(New PointView(x, y))
            Next

            For Each pair As KeyValuePair(Of Double, Double) In form._funcRoots
                Dim y As Double = pair.Value
                Dim x As Double = pair.Key
                form.FunctionRootList.Items.Add(New PointView(x, y))
            Next
            form.GraphicFunctionButton.Enabled = True
            form.GraphicDiffButton.Enabled = True
            form.GraphicMaxMinButton.Enabled = True
        End If
    End Sub

End Class
