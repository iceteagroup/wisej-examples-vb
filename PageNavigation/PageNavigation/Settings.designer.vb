<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Me.label1 = New Wisej.Web.Label()
        Me.textBox1 = New Wisej.Web.TextBox()
        Me.textBox2 = New Wisej.Web.TextBox()
        Me.label2 = New Wisej.Web.Label()
        Me.textBox3 = New Wisej.Web.TextBox()
        Me.label3 = New Wisej.Web.Label()
        Me.textBox4 = New Wisej.Web.TextBox()
        Me.label4 = New Wisej.Web.Label()
        Me.titleLabel = New Wisej.Web.Label()
        Me.save = New Wisej.Web.Button()
        Me.close = New Wisej.Web.Button()
        Me.errorButton = New Wisej.Web.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(50, 100)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(65, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "First name"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(200, 98)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(300, 22)
        Me.textBox1.TabIndex = 1
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(200, 163)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(300, 22)
        Me.textBox2.TabIndex = 3
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(50, 165)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(65, 15)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Last name"
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(200, 228)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(300, 22)
        Me.textBox3.TabIndex = 5
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(50, 230)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(37, 15)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Email"
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(200, 293)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(300, 22)
        Me.textBox4.TabIndex = 7
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(50, 295)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(65, 15)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Telephone"
        '
        'titleLabel
        '
        Me.titleLabel.BackColor = System.Drawing.Color.FromName("@buttonFace")
        Me.titleLabel.Dock = Wisej.Web.DockStyle.Top
        Me.titleLabel.Font = New System.Drawing.Font("default", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.titleLabel.ForeColor = System.Drawing.Color.FromName("@buttonText")
        Me.titleLabel.Location = New System.Drawing.Point(0, 0)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(845, 40)
        Me.titleLabel.TabIndex = 8
        Me.titleLabel.Text = "User settings"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(50, 390)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(200, 40)
        Me.save.TabIndex = 9
        Me.save.Text = "Save"
        '
        'close
        '
        Me.close.Location = New System.Drawing.Point(300, 390)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(200, 40)
        Me.close.TabIndex = 10
        Me.close.Text = "Close"
        '
        'errorButton
        '
        Me.errorButton.Location = New System.Drawing.Point(300, 466)
        Me.errorButton.Name = "errorButton"
        Me.errorButton.Size = New System.Drawing.Size(200, 40)
        Me.errorButton.TabIndex = 11
        Me.errorButton.Text = "Unknown Issue"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.errorButton)
        Me.Controls.Add(Me.close)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Settings"
        Me.Size = New System.Drawing.Size(845, 586)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents textBox1 As Wisej.Web.TextBox
    Friend WithEvents textBox2 As Wisej.Web.TextBox
    Friend WithEvents label2 As Wisej.Web.Label
    Friend WithEvents textBox3 As Wisej.Web.TextBox
    Friend WithEvents label3 As Wisej.Web.Label
    Friend WithEvents textBox4 As Wisej.Web.TextBox
    Friend WithEvents label4 As Wisej.Web.Label
    Friend WithEvents titleLabel As Wisej.Web.Label
    Friend WithEvents save As Wisej.Web.Button
    Friend WithEvents close As Wisej.Web.Button
    Friend WithEvents errorButton As Wisej.Web.Button
End Class
