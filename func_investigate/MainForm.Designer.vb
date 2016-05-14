<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GraphicsPanel = New System.Windows.Forms.Panel()
        Me.GraphicFunctionButton = New System.Windows.Forms.Button()
        Me.GraphicIntegralButton = New System.Windows.Forms.Button()
        Me.GraphicDiffButton = New System.Windows.Forms.Button()
        Me.StartValue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EndValue = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EndIntegralValue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StartIntegralValue = New System.Windows.Forms.TextBox()
        Me.CalculateIntegralButton = New System.Windows.Forms.Button()
        Me.StepValueLabel = New System.Windows.Forms.Label()
        Me.GraphicClearButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NextValue = New System.Windows.Forms.NumericUpDown()
        Me.CalculateFunctionButton = New System.Windows.Forms.Button()
        Me.FunctionMinValue = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FunctionMaxValue = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FunctionResultList = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.IntegralResultList = New System.Windows.Forms.ListBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabFunction = New System.Windows.Forms.TabPage()
        Me.StepValue = New System.Windows.Forms.NumericUpDown()
        Me.FunctionRootList = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ErrorValue = New System.Windows.Forms.NumericUpDown()
        Me.TabIntegral = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GraphicMaxMinButton = New System.Windows.Forms.Button()
        Me.ErrorValueTooltip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.NextValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabFunction.SuspendLayout()
        CType(Me.StepValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabIntegral.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GraphicsPanel
        '
        Me.GraphicsPanel.Location = New System.Drawing.Point(15, 11)
        Me.GraphicsPanel.Name = "GraphicsPanel"
        Me.GraphicsPanel.Size = New System.Drawing.Size(427, 416)
        Me.GraphicsPanel.TabIndex = 0
        '
        'GraphicFunctionButton
        '
        Me.GraphicFunctionButton.Enabled = False
        Me.GraphicFunctionButton.Location = New System.Drawing.Point(6, 16)
        Me.GraphicFunctionButton.Name = "GraphicFunctionButton"
        Me.GraphicFunctionButton.Size = New System.Drawing.Size(98, 45)
        Me.GraphicFunctionButton.TabIndex = 1
        Me.GraphicFunctionButton.Text = "Функции"
        Me.GraphicFunctionButton.UseVisualStyleBackColor = True
        '
        'GraphicIntegralButton
        '
        Me.GraphicIntegralButton.Enabled = False
        Me.GraphicIntegralButton.Location = New System.Drawing.Point(6, 68)
        Me.GraphicIntegralButton.Name = "GraphicIntegralButton"
        Me.GraphicIntegralButton.Size = New System.Drawing.Size(98, 46)
        Me.GraphicIntegralButton.TabIndex = 2
        Me.GraphicIntegralButton.Text = "Интеграла"
        Me.GraphicIntegralButton.UseVisualStyleBackColor = True
        '
        'GraphicDiffButton
        '
        Me.GraphicDiffButton.Enabled = False
        Me.GraphicDiffButton.Location = New System.Drawing.Point(6, 120)
        Me.GraphicDiffButton.Name = "GraphicDiffButton"
        Me.GraphicDiffButton.Size = New System.Drawing.Size(98, 43)
        Me.GraphicDiffButton.TabIndex = 3
        Me.GraphicDiffButton.Text = "Производной"
        Me.GraphicDiffButton.UseVisualStyleBackColor = True
        '
        'StartValue
        '
        Me.StartValue.Location = New System.Drawing.Point(72, 9)
        Me.StartValue.Name = "StartValue"
        Me.StartValue.ReadOnly = True
        Me.StartValue.Size = New System.Drawing.Size(91, 18)
        Me.StartValue.TabIndex = 4
        Me.StartValue.Text = "-5"
        Me.StartValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 11)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "A    ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 11)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "B    = "
        '
        'EndValue
        '
        Me.EndValue.Location = New System.Drawing.Point(72, 33)
        Me.EndValue.Name = "EndValue"
        Me.EndValue.ReadOnly = True
        Me.EndValue.Size = New System.Drawing.Size(91, 18)
        Me.EndValue.TabIndex = 6
        Me.EndValue.Text = "2"
        Me.EndValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 11)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "X2   ="
        '
        'EndIntegralValue
        '
        Me.EndIntegralValue.Location = New System.Drawing.Point(70, 39)
        Me.EndIntegralValue.Name = "EndIntegralValue"
        Me.EndIntegralValue.Size = New System.Drawing.Size(91, 18)
        Me.EndIntegralValue.TabIndex = 12
        Me.EndIntegralValue.Text = "0,9997"
        Me.EndIntegralValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 11)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "X1   ="
        '
        'StartIntegralValue
        '
        Me.StartIntegralValue.Location = New System.Drawing.Point(70, 15)
        Me.StartIntegralValue.Name = "StartIntegralValue"
        Me.StartIntegralValue.Size = New System.Drawing.Size(91, 18)
        Me.StartIntegralValue.TabIndex = 10
        Me.StartIntegralValue.Text = "-4,003"
        Me.StartIntegralValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CalculateIntegralButton
        '
        Me.CalculateIntegralButton.Location = New System.Drawing.Point(6, 341)
        Me.CalculateIntegralButton.Name = "CalculateIntegralButton"
        Me.CalculateIntegralButton.Size = New System.Drawing.Size(149, 43)
        Me.CalculateIntegralButton.TabIndex = 0
        Me.CalculateIntegralButton.Text = "Посчитать"
        Me.CalculateIntegralButton.UseVisualStyleBackColor = True
        '
        'StepValueLabel
        '
        Me.StepValueLabel.AutoSize = True
        Me.StepValueLabel.Location = New System.Drawing.Point(12, 61)
        Me.StepValueLabel.Name = "StepValueLabel"
        Me.StepValueLabel.Size = New System.Drawing.Size(54, 11)
        Me.StepValueLabel.TabIndex = 9
        Me.StepValueLabel.Text = "Step = "
        '
        'GraphicClearButton
        '
        Me.GraphicClearButton.Location = New System.Drawing.Point(6, 248)
        Me.GraphicClearButton.Name = "GraphicClearButton"
        Me.GraphicClearButton.Size = New System.Drawing.Size(98, 43)
        Me.GraphicClearButton.TabIndex = 11
        Me.GraphicClearButton.Text = "Очистить"
        Me.GraphicClearButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 11)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "N    = "
        '
        'NextValue
        '
        Me.NextValue.DecimalPlaces = 5
        Me.NextValue.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.NextValue.Location = New System.Drawing.Point(73, 82)
        Me.NextValue.Minimum = New Decimal(New Integer() {1, 0, 0, 327680})
        Me.NextValue.Name = "NextValue"
        Me.NextValue.Size = New System.Drawing.Size(90, 18)
        Me.NextValue.TabIndex = 14
        Me.NextValue.Value = New Decimal(New Integer() {1, 0, 0, 262144})
        '
        'CalculateFunctionButton
        '
        Me.CalculateFunctionButton.Location = New System.Drawing.Point(6, 341)
        Me.CalculateFunctionButton.Name = "CalculateFunctionButton"
        Me.CalculateFunctionButton.Size = New System.Drawing.Size(149, 43)
        Me.CalculateFunctionButton.TabIndex = 15
        Me.CalculateFunctionButton.Text = "Посчитать"
        Me.CalculateFunctionButton.UseVisualStyleBackColor = True
        '
        'FunctionMinValue
        '
        Me.FunctionMinValue.Location = New System.Drawing.Point(72, 106)
        Me.FunctionMinValue.Name = "FunctionMinValue"
        Me.FunctionMinValue.ReadOnly = True
        Me.FunctionMinValue.Size = New System.Drawing.Size(91, 18)
        Me.FunctionMinValue.TabIndex = 16
        Me.FunctionMinValue.Text = "NaN"
        Me.FunctionMinValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 11)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Min  = "
        '
        'FunctionMaxValue
        '
        Me.FunctionMaxValue.Location = New System.Drawing.Point(72, 130)
        Me.FunctionMaxValue.Name = "FunctionMaxValue"
        Me.FunctionMaxValue.ReadOnly = True
        Me.FunctionMaxValue.Size = New System.Drawing.Size(91, 18)
        Me.FunctionMaxValue.TabIndex = 18
        Me.FunctionMaxValue.Text = "NaN"
        Me.FunctionMaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 11)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Max  = "
        '
        'FunctionResultList
        '
        Me.FunctionResultList.FormattingEnabled = True
        Me.FunctionResultList.ItemHeight = 11
        Me.FunctionResultList.Location = New System.Drawing.Point(169, 30)
        Me.FunctionResultList.Name = "FunctionResultList"
        Me.FunctionResultList.Size = New System.Drawing.Size(169, 191)
        Me.FunctionResultList.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(220, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 11)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Результат"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(220, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 11)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Результат"
        '
        'IntegralResultList
        '
        Me.IntegralResultList.FormattingEnabled = True
        Me.IntegralResultList.ItemHeight = 11
        Me.IntegralResultList.Location = New System.Drawing.Point(169, 30)
        Me.IntegralResultList.Name = "IntegralResultList"
        Me.IntegralResultList.Size = New System.Drawing.Size(169, 191)
        Me.IntegralResultList.TabIndex = 22
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabFunction)
        Me.TabControl.Controls.Add(Me.TabIntegral)
        Me.TabControl.Location = New System.Drawing.Point(569, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(362, 415)
        Me.TabControl.TabIndex = 15
        '
        'TabFunction
        '
        Me.TabFunction.Controls.Add(Me.StepValue)
        Me.TabFunction.Controls.Add(Me.FunctionRootList)
        Me.TabFunction.Controls.Add(Me.Label11)
        Me.TabFunction.Controls.Add(Me.Label10)
        Me.TabFunction.Controls.Add(Me.ErrorValue)
        Me.TabFunction.Controls.Add(Me.Label8)
        Me.TabFunction.Controls.Add(Me.StartValue)
        Me.TabFunction.Controls.Add(Me.FunctionResultList)
        Me.TabFunction.Controls.Add(Me.StepValueLabel)
        Me.TabFunction.Controls.Add(Me.FunctionMaxValue)
        Me.TabFunction.Controls.Add(Me.Label7)
        Me.TabFunction.Controls.Add(Me.Label2)
        Me.TabFunction.Controls.Add(Me.FunctionMinValue)
        Me.TabFunction.Controls.Add(Me.EndValue)
        Me.TabFunction.Controls.Add(Me.Label6)
        Me.TabFunction.Controls.Add(Me.Label1)
        Me.TabFunction.Controls.Add(Me.CalculateFunctionButton)
        Me.TabFunction.Controls.Add(Me.Label5)
        Me.TabFunction.Controls.Add(Me.NextValue)
        Me.TabFunction.Location = New System.Drawing.Point(4, 21)
        Me.TabFunction.Name = "TabFunction"
        Me.TabFunction.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFunction.Size = New System.Drawing.Size(354, 390)
        Me.TabFunction.TabIndex = 0
        Me.TabFunction.Text = "Функция"
        Me.TabFunction.UseVisualStyleBackColor = True
        '
        'StepValue
        '
        Me.StepValue.DecimalPlaces = 5
        Me.StepValue.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.StepValue.Location = New System.Drawing.Point(73, 59)
        Me.StepValue.Minimum = New Decimal(New Integer() {1, 0, 0, 327680})
        Me.StepValue.Name = "StepValue"
        Me.StepValue.Size = New System.Drawing.Size(90, 18)
        Me.StepValue.TabIndex = 26
        Me.StepValue.Value = New Decimal(New Integer() {1, 0, 0, 262144})
        '
        'FunctionRootList
        '
        Me.FunctionRootList.FormattingEnabled = True
        Me.FunctionRootList.ItemHeight = 11
        Me.FunctionRootList.Location = New System.Drawing.Point(169, 242)
        Me.FunctionRootList.Name = "FunctionRootList"
        Me.FunctionRootList.Size = New System.Drawing.Size(169, 136)
        Me.FunctionRootList.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(220, 228)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 11)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Корни"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 11)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "e    = "
        '
        'ErrorValue
        '
        Me.ErrorValue.DecimalPlaces = 8
        Me.ErrorValue.Increment = New Decimal(New Integer() {1, 0, 0, 524288})
        Me.ErrorValue.Location = New System.Drawing.Point(73, 154)
        Me.ErrorValue.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ErrorValue.Minimum = New Decimal(New Integer() {1, 0, 0, 524288})
        Me.ErrorValue.Name = "ErrorValue"
        Me.ErrorValue.Size = New System.Drawing.Size(90, 18)
        Me.ErrorValue.TabIndex = 23
        Me.ErrorValueTooltip.SetToolTip(Me.ErrorValue, "Погрешность")
        Me.ErrorValue.Value = New Decimal(New Integer() {1, 0, 0, 524288})
        '
        'TabIntegral
        '
        Me.TabIntegral.Controls.Add(Me.Label9)
        Me.TabIntegral.Controls.Add(Me.IntegralResultList)
        Me.TabIntegral.Controls.Add(Me.CalculateIntegralButton)
        Me.TabIntegral.Controls.Add(Me.Label4)
        Me.TabIntegral.Controls.Add(Me.StartIntegralValue)
        Me.TabIntegral.Controls.Add(Me.EndIntegralValue)
        Me.TabIntegral.Controls.Add(Me.Label3)
        Me.TabIntegral.Location = New System.Drawing.Point(4, 21)
        Me.TabIntegral.Name = "TabIntegral"
        Me.TabIntegral.Padding = New System.Windows.Forms.Padding(3)
        Me.TabIntegral.Size = New System.Drawing.Size(354, 390)
        Me.TabIntegral.TabIndex = 1
        Me.TabIntegral.Text = "Интеграл"
        Me.TabIntegral.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GraphicMaxMinButton)
        Me.GroupBox1.Controls.Add(Me.GraphicFunctionButton)
        Me.GroupBox1.Controls.Add(Me.GraphicIntegralButton)
        Me.GroupBox1.Controls.Add(Me.GraphicClearButton)
        Me.GroupBox1.Controls.Add(Me.GraphicDiffButton)
        Me.GroupBox1.Location = New System.Drawing.Point(448, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(115, 297)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "График"
        '
        'GraphicMaxMinButton
        '
        Me.GraphicMaxMinButton.Enabled = False
        Me.GraphicMaxMinButton.Location = New System.Drawing.Point(6, 169)
        Me.GraphicMaxMinButton.Name = "GraphicMaxMinButton"
        Me.GraphicMaxMinButton.Size = New System.Drawing.Size(98, 43)
        Me.GraphicMaxMinButton.TabIndex = 12
        Me.GraphicMaxMinButton.Text = "Макс/Мин"
        Me.GraphicMaxMinButton.UseVisualStyleBackColor = True
        '
        'ErrorValueTooltip
        '
        Me.ErrorValueTooltip.ToolTipTitle = "Помощь"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 441)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.GraphicsPanel)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Лабораторная работа. Вариант №3"
        Me.TopMost = True
        CType(Me.NextValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabFunction.ResumeLayout(False)
        Me.TabFunction.PerformLayout()
        CType(Me.StepValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabIntegral.ResumeLayout(False)
        Me.TabIntegral.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GraphicsPanel As Panel
    Friend WithEvents GraphicFunctionButton As Button
    Friend WithEvents GraphicIntegralButton As Button
    Friend WithEvents GraphicDiffButton As Button
    Friend WithEvents StartValue As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EndValue As TextBox
    Friend WithEvents CalculateIntegralButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents StartIntegralValue As TextBox
    Friend WithEvents StepValueLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EndIntegralValue As TextBox
    Friend WithEvents GraphicClearButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents NextValue As NumericUpDown
    Friend WithEvents CalculateFunctionButton As Button
    Friend WithEvents FunctionMinValue As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FunctionMaxValue As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents FunctionResultList As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents IntegralResultList As ListBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabFunction As TabPage
    Friend WithEvents TabIntegral As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ErrorValue As NumericUpDown
    Friend WithEvents ErrorValueTooltip As ToolTip
    Friend WithEvents Label11 As Label
    Friend WithEvents FunctionRootList As ListBox
    Friend WithEvents GraphicMaxMinButton As Button
    Friend WithEvents StepValue As NumericUpDown
End Class
