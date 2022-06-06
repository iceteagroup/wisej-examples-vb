Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits Wisej.Web.Form
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
        Me.toolBar1 = New Wisej.Web.ToolBar()
        Me.addMdiChild = New Wisej.Web.ToolBarButton()
        Me.closeMdiChild = New Wisej.Web.ToolBarButton()
        Me.activateFirstMdiChild = New Wisej.Web.ToolBarButton()
        Me.separator1 = New Wisej.Web.ToolBarButton()
        Me.showModeless = New Wisej.Web.ToolBarButton()
        Me.separator2 = New Wisej.Web.ToolBarButton()
        Me.showHideThumbnails = New Wisej.Web.ToolBarButton()
        Me.SuspendLayout()
        '
        'toolBar1
        '
        Me.toolBar1.AutoSize = False
        Me.toolBar1.Buttons.AddRange(New Wisej.Web.ToolBarButton() {Me.addMdiChild, Me.closeMdiChild, Me.activateFirstMdiChild, Me.separator1, Me.showModeless, Me.separator2, Me.showHideThumbnails})
        Me.toolBar1.Location = New System.Drawing.Point(0, 0)
        Me.toolBar1.Name = "toolBar1"
        Me.toolBar1.Size = New System.Drawing.Size(676, 51)
        Me.toolBar1.TabIndex = 1
        Me.toolBar1.TabStop = False
        '
        'addMdiChild
        '
        Me.addMdiChild.ImageSource = "window-maximize"
        Me.addMdiChild.Name = "addMdiChild"
        Me.addMdiChild.Text = "Create MDI"
        '
        'closeMdiChild
        '
        Me.closeMdiChild.ImageSource = "window-minimize"
        Me.closeMdiChild.Name = "closeMdiChild"
        Me.closeMdiChild.Text = "Close MDI"
        '
        'activateFirstMdiChild
        '
        Me.activateFirstMdiChild.ImageSource = "window-icon"
        Me.activateFirstMdiChild.Name = "activateFirstMdiChild"
        Me.activateFirstMdiChild.Text = "Activate First MDI"
        '
        'separator1
        '
        Me.separator1.Name = "separator1"
        Me.separator1.Style = Wisej.Web.ToolBarButtonStyle.Separator
        '
        'showModeless
        '
        Me.showModeless.ImageSource = "icon-file"
        Me.showModeless.Name = "showModeless"
        Me.showModeless.Text = "Show Modeless"
        '
        'separator2
        '
        Me.separator2.Name = "separator2"
        Me.separator2.Style = Wisej.Web.ToolBarButtonStyle.Separator
        '
        'showHideThumbnails
        '
        Me.showHideThumbnails.ImageSource = "icon-preview"
        Me.showHideThumbnails.Name = "showHideThumbnails"
        Me.showHideThumbnails.Text = "Hide Thumbnails Buttom"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 472)
        Me.CloseBox = False
        Me.ControlBox = False
        Me.Controls.Add(Me.toolBar1)
        Me.FormBorderStyle = Wisej.Web.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "MainWindow"
        Me.Text = "Window1"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents toolBar1 As Wisej.Web.ToolBar
    Friend WithEvents addMdiChildField As Wisej.Web.ToolBarButton
    Friend WithEvents closeMdiChild As Wisej.Web.ToolBarButton
    Friend WithEvents activateFirstMdiChild As Wisej.Web.ToolBarButton
    Friend WithEvents showModelessField As Wisej.Web.ToolBarButton
    Friend WithEvents separator1 As Wisej.Web.ToolBarButton
    Friend WithEvents separator2 As Wisej.Web.ToolBarButton
    Friend WithEvents showHideThumbnails As Wisej.Web.ToolBarButton
    Friend WithEvents addMdiChild As Wisej.Web.ToolBarButton
    Friend WithEvents showModeless As Wisej.Web.ToolBarButton
End Class
