
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContainerPanel
    Inherits Wisej.Web.UserControl
    ''' <summary> 
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer

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
        Me.ajaxLoader = New Wisej.Web.PictureBox()
        Me.loaderPanel = New Wisej.Web.Panel()
        Me.label1 = New Wisej.Web.Label()
        CType(Me.ajaxLoader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.loaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ajaxLoader
        '
        Me.ajaxLoader.Anchor = Wisej.Web.AnchorStyles.None
        Me.ajaxLoader.ImageSource = "ajax-loader"
        Me.ajaxLoader.Location = New System.Drawing.Point(76, 18)
        Me.ajaxLoader.Name = "ajaxLoader"
        Me.ajaxLoader.Size = New System.Drawing.Size(83, 47)
        Me.ajaxLoader.SizeMode = Wisej.Web.PictureBoxSizeMode.CenterImage
        '
        'loaderPanel
        '
        Me.loaderPanel.Controls.Add(Me.label1)
        Me.loaderPanel.Controls.Add(Me.ajaxLoader)
        Me.loaderPanel.Dock = Wisej.Web.DockStyle.Top
        Me.loaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.loaderPanel.Name = "loaderPanel"
        Me.loaderPanel.Size = New System.Drawing.Size(341, 78)
        Me.loaderPanel.TabIndex = 1
        Me.loaderPanel.TabStop = True
        '
        'label1
        '
        Me.label1.Anchor = Wisej.Web.AnchorStyles.None
        Me.label1.Location = New System.Drawing.Point(182, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 47)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Loading..."
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContainerPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.loaderPanel)
        Me.MinimumSize = New System.Drawing.Size(340, 500)
        Me.Name = "ContainerPanel"
        Me.ResizableEdges = CType((Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.ScrollBars = Wisej.Web.ScrollBars.Vertical
        Me.Size = New System.Drawing.Size(340, 500)
        CType(Me.ajaxLoader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.loaderPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents ajaxLoader As Web.PictureBox
    Friend WithEvents loaderPanel As Web.Panel
    Friend WithEvents label1 As Web.Label
End Class
