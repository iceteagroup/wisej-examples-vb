Imports Wisej.Web

Namespace Views

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class HomePage
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
            optionsPanel1 = New Panels.OptionsPanel()
            workspacePanel = New Panels.WorkspacePanel()
            SuspendLayout()
            ' 
            ' optionsPanel1
            ' 
            optionsPanel1.BackColor = Drawing.Color.FromArgb(59, 63, 191, 179)
            optionsPanel1.Dock = Web.DockStyle.Left
            optionsPanel1.Font = New Drawing.Font("default", 14.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
            optionsPanel1.Location = New Drawing.Point(0, 0)
            optionsPanel1.Name = "optionsPanel1"
            optionsPanel1.Size = New Drawing.Size(250, 874)
            optionsPanel1.TabIndex = 0
            AddHandler optionsPanel1.OptionClick, New Panels.OptionsPanel.OptionClickedEventHandler(AddressOf optionsPanel1_OptionClick)
            ' 
            ' workspacePanel
            ' 
            workspacePanel.BackgroundImageLayout = Web.ImageLayout.BestFit
            workspacePanel.BackgroundImageSource = "Images/Background.jpg"
            workspacePanel.Dock = Web.DockStyle.Fill
            workspacePanel.Location = New Drawing.Point(250, 0)
            workspacePanel.Name = "workspacePanel"
            workspacePanel.Size = New Drawing.Size(1182, 874)
            workspacePanel.TabIndex = 1
            ' 
            ' HomePage
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
            AutoScaleMode = Web.AutoScaleMode.Font
            Controls.Add(workspacePanel)
            Controls.Add(optionsPanel1)
            Name = "HomePage"
            Size = New Drawing.Size(1432, 874)
            ResumeLayout(False)
        End Sub


#End Region

        Friend WithEvents optionsPanel1 As Panels.OptionsPanel
        Friend WithEvents workspacePanel As Panels.WorkspacePanel
    End Class
End Namespace
