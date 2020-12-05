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
            components = New ComponentModel.Container()
            label1 = New Label()
            animation = New Animation(components)
            textBoxUserName = New TextBox()
            textBoxPassword = New TextBox()
            buttonLogin = New Button()
            helpTip = New HelpTip(components)
            errorProvider = New ErrorProvider(components)
            panel = New Panel()
            CType(errorProvider, ComponentModel.ISupportInitialize).BeginInit()
            panel.SuspendLayout()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            animation.GetAnimation(label1).Event = "appear"
            animation.GetAnimation(label1).Name = "bounce"
            label1.Font = New Drawing.Font("default", 24.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
            label1.ImageAlign = Drawing.ContentAlignment.TopCenter
            label1.ImageSource = "Images/Wisej-Logo-64x64.png"
            label1.Location = New Drawing.Point(47, 9)
            label1.Margin = New Padding(9)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(887, 450)
            label1.TabIndex = 0
            label1.Text = "ACME Hardware"
            label1.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' textBoxUserName
            ' 
            textBoxUserName.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            textBoxUserName.AutoComplete = AutoComplete.Off
            textBoxUserName.AutoSize = False
            helpTip.SetHelpTip(textBoxUserName, "User your name or email address.")
            errorProvider.SetIconAlignment(textBoxUserName, ErrorIconAlignment.MiddleLeft)
            textBoxUserName.Location = New Drawing.Point(82, 477)
            textBoxUserName.Margin = New Padding(9)
            textBoxUserName.Name = "textBoxUserName"
            textBoxUserName.Size = New Drawing.Size(817, 108)
            textBoxUserName.TabIndex = 1
            textBoxUserName.Watermark = "User Name"
            ' 
            ' textBoxPassword
            ' 
            textBoxPassword.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            textBoxPassword.AutoComplete = AutoComplete.Off
            textBoxPassword.AutoSize = False
            helpTip.SetHelpTip(textBoxPassword, "Enter ""demo""")
            errorProvider.SetIconAlignment(textBoxPassword, ErrorIconAlignment.MiddleLeft)
            textBoxPassword.Location = New Drawing.Point(82, 650)
            textBoxPassword.Margin = New Padding(9)
            textBoxPassword.Name = "textBoxPassword"
            textBoxPassword.PasswordChar = "*"c
            textBoxPassword.Size = New Drawing.Size(817, 108)
            textBoxPassword.TabIndex = 2
            textBoxPassword.Watermark = "Password"
            ' 
            ' buttonLogin
            ' 
            buttonLogin.Anchor = AnchorStyles.Bottom
            buttonLogin.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/locked-padlock.svg"
            buttonLogin.Location = New Drawing.Point(299, 857)
            buttonLogin.Margin = New Padding(9)
            buttonLogin.Name = "buttonLogin"
            buttonLogin.Size = New Drawing.Size(408, 140)
            buttonLogin.TabIndex = 3
            buttonLogin.Text = "&LOGIN"
            AddHandler buttonLogin.Click, New EventHandler(AddressOf buttonLogin_Click)
            ' 
            ' errorProvider
            ' 
            errorProvider.BlinkAnimation = ErrorAnimationType.Bounce
            errorProvider.ContainerControl = Me
            errorProvider.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/round-error-symbol.svg"
            ' 
            ' panel
            ' 
            panel.Anchor = AnchorStyles.None
            panel.BackColor = Drawing.Color.Transparent
            panel.Controls.Add(buttonLogin)
            panel.Controls.Add(textBoxPassword)
            panel.Controls.Add(textBoxUserName)
            panel.Controls.Add(label1)
            panel.Location = New Drawing.Point(340, 378)
            panel.Margin = New Padding(9)
            panel.MaximumSize = New Drawing.Size(980, 1035)
            panel.MinimumSize = New Drawing.Size(747, 720)
            panel.Name = "panel"
            panel.Size = New Drawing.Size(980, 1035)
            panel.TabIndex = 4
            ' 
            ' LoginPage
            ' 
            Accelerators = New Keys() {Keys.Return}
            AutoScaleDimensions = New Drawing.SizeF(21.0F, 45.0F)
            AutoScaleMode = AutoScaleMode.Font
            BackgroundImageLayout = ImageLayout.BestFit
            BackgroundImageSource = "Images/Background.jpg"
            Controls.Add(panel)
            Font = New Drawing.Font("default", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
            Margin = New Padding(4)
            Name = "LoginPage"
            Size = New Drawing.Size(1398, 1213)
            Text = "ACME Hardware - Login"
            AddHandler Load, New EventHandler(AddressOf LoginPage_Load)
            AddHandler ResponsiveProfileChanged, New ResponsiveProfileChangedEventHandler(AddressOf LoginPage_ResponsiveProfileChanged)
            AddHandler Accelerator, New AcceleratorEventHandler(AddressOf LoginPage_Accelerator)
            CType(errorProvider, ComponentModel.ISupportInitialize).EndInit()
            panel.ResumeLayout(False)
            ResumeLayout(False)
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
