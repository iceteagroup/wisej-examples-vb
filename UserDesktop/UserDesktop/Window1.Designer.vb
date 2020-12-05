<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window1
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


#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        toolBar1 = New Wisej.Web.ToolBar()
        btnOpen = New Wisej.Web.ToolBarButton()
        btnSave = New Wisej.Web.ToolBarButton()
        btnNew = New Wisej.Web.ToolBarButton()
        textBox1 = New Wisej.Web.TextBox()
        SuspendLayout()
        ' 
        ' toolBar1
        ' 
        toolBar1.AutoSize = False
        toolBar1.Buttons.AddRange(New Wisej.Web.ToolBarButton() {btnOpen, btnSave, btnNew})
        toolBar1.Location = New Drawing.Point(0, 0)
        toolBar1.Name = "toolBar1"
        toolBar1.Size = New Drawing.Size(613, 48)
        toolBar1.TabIndex = 0
        toolBar1.TabStop = False
        toolBar1.TextAlign = Wisej.Web.ToolBarTextAlign.Right
        ' 
        ' btnOpen
        ' 
        btnOpen.ImageSource = "icon-open"
        btnOpen.IsDisposed = False
        btnOpen.Name = "btnOpen"
        btnOpen.Text = "Open"
        ' 
        ' btnSave
        ' 
        btnSave.ImageSource = "icon-save"
        btnSave.IsDisposed = False
        btnSave.Name = "btnSave"
        btnSave.Text = "Save"
        ' 
        ' btnNew
        ' 
        btnNew.ImageSource = "icon-new"
        btnNew.IsDisposed = False
        btnNew.Name = "btnNew"
        btnNew.Text = "New"
        ' 
        ' textBox1
        ' 
        textBox1.BorderStyle = Wisej.Web.BorderStyle.None
        textBox1.Dock = Wisej.Web.DockStyle.Fill
        textBox1.Location = New Drawing.Point(0, 48)
        textBox1.Multiline = True
        textBox1.Name = "textBox1"
        textBox1.Size = New Drawing.Size(613, 384)
        textBox1.TabIndex = 1
        ' 
        ' Window1
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(613, 432)
        Controls.Add(textBox1)
        Controls.Add(toolBar1)
        IconSource = "http://iconshow.me/media/images/social/flat-style-Metro-UI-Icons/Applications/png" & "/256/MetroUI-Notepad.png"
        Name = "Window1"
        Text = "Window1"
        AddHandler Load, New EventHandler(AddressOf Window1_Load)
        ResumeLayout(False)
        PerformLayout()
    End Sub


#End Region

    Friend WithEvents toolBar1 As Wisej.Web.ToolBar
    Friend WithEvents btnOpen As Wisej.Web.ToolBarButton
    Friend WithEvents btnSave As Wisej.Web.ToolBarButton
    Friend WithEvents btnNew As Wisej.Web.ToolBarButton
    Friend WithEvents textBox1 As Wisej.Web.TextBox
End Class
