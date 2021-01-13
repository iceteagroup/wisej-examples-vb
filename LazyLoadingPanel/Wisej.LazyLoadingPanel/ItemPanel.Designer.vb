<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ItemPanel
    Inherits Web.UserControl
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
        Me.icon = New Wisej.Web.PictureBox()
        Me.titleField = New Wisej.Web.Label()
        Me.textField = New Wisej.Web.Label()
        Me.action = New Wisej.Web.PictureBox()
        CType(Me.icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.action, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'icon
        '
        Me.icon.Location = New System.Drawing.Point(14, 18)
        Me.icon.Name = "icon"
        Me.icon.Size = New System.Drawing.Size(64, 64)
        '
        'titleField
        '
        Me.titleField.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.titleField.AutoEllipsis = True
        Me.titleField.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.titleField.Location = New System.Drawing.Point(95, 18)
        Me.titleField.Name = "titleField"
        Me.titleField.Size = New System.Drawing.Size(382, 20)
        Me.titleField.TabIndex = 1
        Me.titleField.Text = "label1"
        Me.titleField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textField
        '
        Me.textField.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.textField.Location = New System.Drawing.Point(95, 44)
        Me.textField.Name = "textField"
        Me.textField.Size = New System.Drawing.Size(412, 38)
        Me.textField.TabIndex = 2
        Me.textField.Text = "label1"
        '
        'action
        '
        Me.action.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.action.Cursor = Wisej.Web.Cursors.Hand
        Me.action.ImageSource = "icon-right"
        Me.action.Location = New System.Drawing.Point(491, 18)
        Me.action.Name = "action"
        Me.action.Size = New System.Drawing.Size(16, 16)
        '
        'ItemPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.action)
        Me.Controls.Add(Me.textField)
        Me.Controls.Add(Me.titleField)
        Me.Controls.Add(Me.icon)
        Me.Name = "ItemPanel"
        Me.Size = New System.Drawing.Size(525, 101)
        CType(Me.icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.action, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents icon As Web.PictureBox
    Friend WithEvents titleField As Web.Label
    Friend WithEvents textField As Web.Label
    Friend WithEvents action As Web.PictureBox
End Class
