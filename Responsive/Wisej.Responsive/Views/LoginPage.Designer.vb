Imports Wisej.Web

Namespace Views

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class LoginPage
        Inherits Page
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer


        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub


#Region "Wisej Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.label1 = New Wisej.Web.Label()
            Me.animation = New Wisej.Web.Animation(Me.components)
            Me.textBoxUserName = New Wisej.Web.TextBox()
            Me.textBoxPassword = New Wisej.Web.TextBox()
            Me.buttonLogin = New Wisej.Web.Button()
            Me.helpTip = New Wisej.Web.HelpTip(Me.components)
            Me.errorProvider = New Wisej.Web.ErrorProvider(Me.components)
            Me.panel = New Wisej.Web.Panel()
            CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel.SuspendLayout()
            Me.SuspendLayout()
            '
            'label1
            '
            Me.label1.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
            Me.animation.GetAnimation(Me.label1).Event = "appear"
            Me.animation.GetAnimation(Me.label1).Name = "bounce"
            Me.label1.Font = New System.Drawing.Font("default", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.label1.ImageSource = "Images/Wisej-Logo-64x64.png"
            Me.label1.Location = New System.Drawing.Point(20, 4)
            Me.label1.Margin = New Wisej.Web.Padding(2)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(380, 200)
            Me.label1.TabIndex = 0
            Me.label1.Text = "ACME Hardware"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'textBoxUserName
            '
            Me.textBoxUserName.Anchor = CType(((Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
            Me.textBoxUserName.AutoComplete = Wisej.Web.AutoComplete.Off
            Me.textBoxUserName.AutoSize = False
            Me.helpTip.SetHelpTip(Me.textBoxUserName, "User your name or email address.")
            Me.errorProvider.SetIconAlignment(Me.textBoxUserName, Wisej.Web.ErrorIconAlignment.MiddleLeft)
            Me.textBoxUserName.Location = New System.Drawing.Point(35, 212)
            Me.textBoxUserName.Margin = New Wisej.Web.Padding(2)
            Me.textBoxUserName.Name = "textBoxUserName"
            Me.textBoxUserName.Size = New System.Drawing.Size(350, 48)
            Me.textBoxUserName.TabIndex = 1
            Me.textBoxUserName.Watermark = "User Name"
            '
            'textBoxPassword
            '
            Me.textBoxPassword.Anchor = CType(((Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
            Me.textBoxPassword.AutoComplete = Wisej.Web.AutoComplete.Off
            Me.textBoxPassword.AutoSize = False
            Me.helpTip.SetHelpTip(Me.textBoxPassword, "Enter ""demo""")
            Me.errorProvider.SetIconAlignment(Me.textBoxPassword, Wisej.Web.ErrorIconAlignment.MiddleLeft)
            Me.textBoxPassword.InputType.Type = Wisej.Web.TextBoxType.Password
            Me.textBoxPassword.Location = New System.Drawing.Point(35, 289)
            Me.textBoxPassword.Margin = New Wisej.Web.Padding(2)
            Me.textBoxPassword.Name = "textBoxPassword"
            Me.textBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.textBoxPassword.Size = New System.Drawing.Size(350, 41)
            Me.textBoxPassword.TabIndex = 2
            Me.textBoxPassword.Watermark = "Password"
            '
            'buttonLogin
            '
            Me.buttonLogin.Anchor = Wisej.Web.AnchorStyles.Bottom
            Me.buttonLogin.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/locked-padlock.svg"
            Me.buttonLogin.Location = New System.Drawing.Point(128, 381)
            Me.buttonLogin.Margin = New Wisej.Web.Padding(2)
            Me.buttonLogin.Name = "buttonLogin"
            Me.buttonLogin.Size = New System.Drawing.Size(110, 28)
            Me.buttonLogin.TabIndex = 3
            Me.buttonLogin.Text = "&LOGIN"
            '
            'errorProvider
            '
            Me.errorProvider.BlinkAnimation = Wisej.Web.ErrorAnimationType.Bounce
            Me.errorProvider.ContainerControl = Me
            Me.errorProvider.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/round-error-symbol.svg"
            '
            'panel
            '
            Me.panel.Anchor = Wisej.Web.AnchorStyles.None
            Me.panel.BackColor = System.Drawing.Color.Transparent
            Me.panel.Controls.Add(Me.buttonLogin)
            Me.panel.Controls.Add(Me.textBoxPassword)
            Me.panel.Controls.Add(Me.textBoxUserName)
            Me.panel.Controls.Add(Me.label1)
            Me.panel.Location = New System.Drawing.Point(266, 140)
            Me.panel.Margin = New Wisej.Web.Padding(4)
            Me.panel.MaximumSize = New System.Drawing.Size(420, 460)
            Me.panel.MinimumSize = New System.Drawing.Size(320, 320)
            Me.panel.Name = "panel"
            Me.panel.Size = New System.Drawing.Size(420, 460)
            Me.panel.TabIndex = 4
            Me.panel.TabStop = True
            '
            'LoginPage
            '
            Me.Accelerators = New Wisej.Web.Keys() {Wisej.Web.Keys.Enter}
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
            Me.BackgroundImageLayout = Wisej.Web.ImageLayout.BestFit
            Me.BackgroundImageSource = "Images/Background.jpg"
            Me.Controls.Add(Me.panel)
            Me.Font = New System.Drawing.Font("default", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.Margin = New Wisej.Web.Padding(4)
            Me.Name = "LoginPage"
            Me.Size = New System.Drawing.Size(1033, 741)
            Me.Text = "ACME Hardware - Login"
            CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub


#End Region

        Friend WithEvents label1 As Label
        Friend WithEvents animation As Animation
        Friend WithEvents textBoxUserName As TextBox
        Friend WithEvents textBoxPassword As TextBox
        Friend WithEvents buttonLogin As Button
        Friend WithEvents helpTip As HelpTip
        Friend WithEvents errorProvider As ErrorProvider
        Friend WithEvents panel As Panel
    End Class
End Namespace
