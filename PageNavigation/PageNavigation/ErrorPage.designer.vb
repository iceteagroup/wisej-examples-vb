<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ErrorPage
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
        Me.titleLabel = New Wisej.Web.Label()
        Me.continueButton = New Wisej.Web.Button()
        Me.details = New Wisej.Web.Label()
        Me.exitButton = New Wisej.Web.Button()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.titleLabel.BackColor = System.Drawing.Color.FromName("@invalid")
        Me.titleLabel.Font = New System.Drawing.Font("default", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.titleLabel.ForeColor = System.Drawing.Color.FromName("@buttonText")
        Me.titleLabel.Location = New System.Drawing.Point(138, 85)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(626, 40)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Application error"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'continueButton
        '
        Me.continueButton.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.continueButton.Location = New System.Drawing.Point(138, 395)
        Me.continueButton.Name = "continueButton"
        Me.continueButton.Size = New System.Drawing.Size(200, 40)
        Me.continueButton.TabIndex = 2
        Me.continueButton.Text = "Continue"
        '
        'details
        '
        Me.details.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.details.Font = New System.Drawing.Font("default", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.details.Location = New System.Drawing.Point(138, 200)
        Me.details.Name = "details"
        Me.details.Size = New System.Drawing.Size(626, 126)
        Me.details.TabIndex = 3
        Me.details.Text = "There was a serious application error. The cause of the error is unknown at this " &
    "time." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "We should display some details of the error here."
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.exitButton.Location = New System.Drawing.Point(588, 395)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(200, 40)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "Give up"
        '
        'ErrorPage
        '
        Me.AcceptButton = Me.continueButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.details)
        Me.Controls.Add(Me.continueButton)
        Me.Controls.Add(Me.titleLabel)
        Me.Name = "ErrorPage"
        Me.Size = New System.Drawing.Size(845, 586)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents titleLabel As Wisej.Web.Label
    Friend WithEvents continueButton As Wisej.Web.Button
    Friend WithEvents details As Wisej.Web.Label
    Friend WithEvents [exit] As Wisej.Web.Button
    Friend WithEvents exitButton As Wisej.Web.Button
End Class
