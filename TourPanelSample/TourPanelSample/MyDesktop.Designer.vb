Imports System

Partial Class MyDesktop
    ''' <summary> 
    ''' Required designer variable.
    ''' </summary>
    Private components As ComponentModel.IContainer = Nothing

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

#Region "Component Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.toolBar1 = New Wisej.Web.ToolBar()
        Me.toolBarButton1 = New Wisej.Web.ToolBarButton()
        Me.toolBarButton2 = New Wisej.Web.ToolBarButton()
        Me.SuspendLayout()
        '
        'toolBar1
        '
        Me.toolBar1.Buttons.AddRange(New Wisej.Web.ToolBarButton() {Me.toolBarButton1, Me.toolBarButton2})
        Me.toolBar1.Location = New System.Drawing.Point(0, 0)
        Me.toolBar1.Name = "toolBar1"
        Me.toolBar1.Size = New System.Drawing.Size(931, 66)
        Me.toolBar1.TabIndex = 0
        Me.toolBar1.TabStop = False
        '
        'toolBarButton1
        '
        Me.toolBarButton1.ImageSource = "icon-help"
        Me.toolBarButton1.Name = "toolBarButton1"
        Me.toolBarButton1.Text = "Start tour"
        '
        'toolBarButton2
        '
        Me.toolBarButton2.AllowHtml = True
        Me.toolBarButton2.ImageSource = "icon-play"
        Me.toolBarButton2.Name = "toolBarButton2"
        Me.toolBarButton2.Text = "Start Tour <br/>with AutoPlay"
        '
        'MyDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.toolBar1)
        Me.Name = "MyDesktop"
        Me.Size = New System.Drawing.Size(931, 827)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents toolBar1 As Wisej.Web.ToolBar
    Private WithEvents toolBarButton1 As Wisej.Web.ToolBarButton
    Private WithEvents toolBarButton2 As Wisej.Web.ToolBarButton
End Class
