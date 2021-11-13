Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Page1
    Inherits Wisej.Web.Page
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As ComponentModel.IContainer

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

#Region "Wisej Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.controlStateLabel = New Wisej.Web.Label()
        Me.controlState = New Wisej.Web.ComboBox()
        Me.statePanel = New Wisej.Web.Panel()
        Me.domainUpDown = New Wisej.Web.DomainUpDown()
        Me.numericUpDown = New Wisej.Web.NumericUpDown()
        Me.listBox = New Wisej.Web.ListBox()
        Me.dateTimePicker = New Wisej.Web.DateTimePicker()
        Me.comboBox = New Wisej.Web.ComboBox()
        Me.textBox = New Wisej.Web.TextBox()
        Me.statePanel.SuspendLayout()
        CType(Me.numericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'controlStateLabel
        '
        Me.controlStateLabel.AutoSize = True
        Me.controlStateLabel.Location = New System.Drawing.Point(36, 41)
        Me.controlStateLabel.Name = "controlStateLabel"
        Me.controlStateLabel.Size = New System.Drawing.Size(120, 15)
        Me.controlStateLabel.TabIndex = 0
        Me.controlStateLabel.Text = "Select Control State"
        '
        'controlState
        '
        Me.controlState.Items.AddRange(New Object() {"Enabled", "Disabled", "ReadOnly"})
        Me.controlState.Location = New System.Drawing.Point(189, 38)
        Me.controlState.Name = "controlState"
        Me.controlState.Size = New System.Drawing.Size(120, 22)
        Me.controlState.TabIndex = 1
        Me.controlState.Text = "ReadOnly"
        '
        'statePanel
        '
        Me.statePanel.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.statePanel.Controls.Add(Me.domainUpDown)
        Me.statePanel.Controls.Add(Me.numericUpDown)
        Me.statePanel.Controls.Add(Me.listBox)
        Me.statePanel.Controls.Add(Me.dateTimePicker)
        Me.statePanel.Controls.Add(Me.comboBox)
        Me.statePanel.Controls.Add(Me.textBox)
        Me.statePanel.Location = New System.Drawing.Point(36, 104)
        Me.statePanel.Name = "statePanel"
        Me.statePanel.ShowCloseButton = False
        Me.statePanel.ShowHeader = True
        Me.statePanel.Size = New System.Drawing.Size(576, 450)
        Me.statePanel.TabIndex = 2
        Me.statePanel.TabStop = True
        Me.statePanel.Text = "Enable"
        '
        'domainUpDown
        '
        Me.domainUpDown.AutoSize = False
        Me.domainUpDown.Items.AddRange(New Object() {"George Washington (1789-1797)", "John Adams (1797-1801)", "Thomas Jefferson (1801-1809)", "James Madison (1809-1817)", "James Monroe (1817-1825)", "John Quincy Adams (1825-1829*)", "Andrew Jackson (1829-1837)", ""})
        Me.domainUpDown.Location = New System.Drawing.Point(18, 201)
        Me.domainUpDown.Name = "domainUpDown"
        Me.domainUpDown.SelectedIndex = 0
        Me.domainUpDown.Size = New System.Drawing.Size(304, 22)
        Me.domainUpDown.TabIndex = 7
        Me.domainUpDown.Text = "George Washington (1789-1797)"
        '
        'numericUpDown
        '
        Me.numericUpDown.AutoSize = False
        Me.numericUpDown.Increment = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numericUpDown.Location = New System.Drawing.Point(352, 201)
        Me.numericUpDown.Maximum = New Decimal(New Integer() {1829, 0, 0, 0})
        Me.numericUpDown.Minimum = New Decimal(New Integer() {1789, 0, 0, 0})
        Me.numericUpDown.Name = "numericUpDown"
        Me.numericUpDown.Size = New System.Drawing.Size(200, 22)
        Me.numericUpDown.TabIndex = 6
        Me.numericUpDown.Value = New Decimal(New Integer() {1789, 0, 0, 0})
        '
        'listBox
        '
        Me.listBox.Items.AddRange(New Object() {"George Washington (1789-1797)", "John Adams (1797-1801)", "Thomas Jefferson (1801-1809)", "James Madison (1809-1817)", "James Monroe (1817-1825)", "John Quincy Adams (1825-1829*)", "Andrew Jackson (1829-1837)"})
        Me.listBox.Location = New System.Drawing.Point(18, 244)
        Me.listBox.Name = "listBox"
        Me.listBox.Size = New System.Drawing.Size(534, 156)
        Me.listBox.TabIndex = 5
        '
        'dateTimePicker
        '
        Me.dateTimePicker.Checked = False
        Me.dateTimePicker.Location = New System.Drawing.Point(352, 159)
        Me.dateTimePicker.Name = "dateTimePicker"
        Me.dateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.dateTimePicker.TabIndex = 4
        Me.dateTimePicker.Value = New Date(2018, 7, 14, 12, 18, 5, 367)
        '
        'comboBox
        '
        Me.comboBox.AutoSize = False
        Me.comboBox.Items.AddRange(New Object() {"George Washington (1789-1797)", "John Adams (1797-1801)", "Thomas Jefferson (1801-1809)", "James Madison (1809-1817)", "James Monroe (1817-1825)", "John Quincy Adams (1825-1829*)", "Andrew Jackson (1829-1837)"})
        Me.comboBox.Location = New System.Drawing.Point(18, 159)
        Me.comboBox.Name = "comboBox"
        Me.comboBox.Size = New System.Drawing.Size(304, 22)
        Me.comboBox.TabIndex = 3
        Me.comboBox.Text = "George Washington (1789-1797)"
        '
        'textBox
        '
        Me.textBox.Location = New System.Drawing.Point(18, 23)
        Me.textBox.Multiline = True
        Me.textBox.Name = "textBox"
        Me.textBox.Size = New System.Drawing.Size(534, 118)
        Me.textBox.TabIndex = 0
        Me.textBox.Text = "George Washington (1789-1797)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "John Adams (1797-1801)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Thomas Jefferson (1801-180" &
    "9)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "James Madison (1809-1817)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "James Monroe (1817-1825)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "John Quincy Adams (1825" &
    "-1829*)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Andrew Jackson (1829-1837)"
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.statePanel)
        Me.Controls.Add(Me.controlState)
        Me.Controls.Add(Me.controlStateLabel)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(1075, 806)
        Me.Text = "Page1"
        Me.statePanel.ResumeLayout(False)
        Me.statePanel.PerformLayout()
        CType(Me.numericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents controlStateLabel As Wisej.Web.Label
    Friend WithEvents controlState As Wisej.Web.ComboBox
    Friend WithEvents statePanel As Wisej.Web.Panel
    Friend WithEvents domainUpDown As Wisej.Web.DomainUpDown
    Friend WithEvents numericUpDown As Wisej.Web.NumericUpDown
    Friend WithEvents listBox As Wisej.Web.ListBox
    Friend WithEvents dateTimePicker As Wisej.Web.DateTimePicker
    Friend WithEvents comboBox As Wisej.Web.ComboBox
    Friend WithEvents textBox As Wisej.Web.TextBox
End Class
