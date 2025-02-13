<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPreview
    Inherits Wisej.Web.Form
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

#Region "Wisej Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        pictureBox1 = New Web.PictureBox()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pictureBox1
        ' 
        pictureBox1.Dock = Web.DockStyle.Fill
        pictureBox1.Location = New Drawing.Point(0, 0)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Drawing.Size(819, 608)
        pictureBox1.SizeMode = Web.PictureBoxSizeMode.Zoom
        ' 
        ' frmPreview
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 18.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(819, 608)
        Controls.Add(pictureBox1)
        Name = "frmPreview"
        Text = "Preview"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

#End Region

    Public pictureBox1 As Web.PictureBox
End Class
