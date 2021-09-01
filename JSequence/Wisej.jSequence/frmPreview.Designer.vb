Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPreview
    Inherits Wisej.Web.Form

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

#Region "Wisej Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()

        pictureBox1 = New Wisej.Web.PictureBox()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pictureBox1
        ' 
        pictureBox1.Dock = Wisej.Web.DockStyle.Fill
        pictureBox1.Location = New Drawing.Point(0, 0)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Drawing.Size(819, 608)
        pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom
        ' 
        ' frmPreview
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 18.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(819, 608)
        Controls.Add(pictureBox1)
        Name = "frmPreview"
        Text = "Preview"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

#End Region

    Public pictureBox1 As Wisej.Web.PictureBox
End Class
