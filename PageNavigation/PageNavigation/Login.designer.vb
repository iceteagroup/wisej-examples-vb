
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.usernameLabel = New Wisej.Web.Label()
        Me.username = New Wisej.Web.TextBox()
        Me.passwordLabel = New Wisej.Web.Label()
        Me.password = New Wisej.Web.TextBox()
        Me.loginButton = New Wisej.Web.Button()
        Me.credentialsError = New Wisej.Web.Label()
        Me.label1 = New Wisej.Web.Label()
        Me.SuspendLayout()
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Font = New System.Drawing.Font("default", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.usernameLabel.Location = New System.Drawing.Point(150, 105)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(96, 23)
        Me.usernameLabel.TabIndex = 0
        Me.usernameLabel.Text = "Username"
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("default", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.username.Location = New System.Drawing.Point(349, 105)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(150, 25)
        Me.username.TabIndex = 1
        Me.username.Watermark = "username"
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Font = New System.Drawing.Font("default", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.passwordLabel.Location = New System.Drawing.Point(150, 167)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(92, 23)
        Me.passwordLabel.TabIndex = 2
        Me.passwordLabel.Text = "Password"
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("default", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.password.InputType.Type = Wisej.Web.TextBoxType.Password
        Me.password.Location = New System.Drawing.Point(349, 167)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(150, 25)
        Me.password.TabIndex = 3
        Me.password.Watermark = "password"
        '
        'loginButton
        '
        Me.loginButton.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.loginButton.Location = New System.Drawing.Point(150, 280)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(200, 40)
        Me.loginButton.TabIndex = 4
        Me.loginButton.Text = "Login"
        '
        'credentialsError
        '
        Me.credentialsError.AutoSize = True
        Me.credentialsError.ForeColor = System.Drawing.Color.FromName("@invalid")
        Me.credentialsError.Location = New System.Drawing.Point(150, 214)
        Me.credentialsError.Name = "credentialsError"
        Me.credentialsError.Size = New System.Drawing.Size(178, 15)
        Me.credentialsError.TabIndex = 5
        Me.credentialsError.Text = "Wrong username or password"
        Me.credentialsError.Visible = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(150, 47)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(237, 15)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Username and password must be equal."
        '
        'Login
        '
        Me.AcceptButton = Me.loginButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.credentialsError)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.passwordLabel)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.usernameLabel)
        Me.Name = "Login"
        Me.Size = New System.Drawing.Size(845, 586)
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents usernameLabel As Wisej.Web.Label
    Friend WithEvents passwordLabel As Wisej.Web.Label
    Friend WithEvents password As Wisej.Web.TextBox
    Friend WithEvents loginButton As Wisej.Web.Button
    Friend WithEvents username As Wisej.Web.TextBox
    Friend WithEvents credentialsError As Wisej.Web.Label
    Friend WithEvents label1 As Wisej.Web.Label
End Class
