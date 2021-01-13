Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChildMdi
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
        label1 = New Wisej.Web.Label()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Drawing.Font("default", 18.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Pixel)
        label1.ForeColor = Drawing.Color.FromName("@activeCaption")
        label1.Location = New Drawing.Point(109, 95)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(112, 22)
        label1.TabIndex = 0
        label1.Text = "I am a Form"
        ' 
        ' ChildMdi
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(488, 256)
        Controls.Add(label1)
        Name = "ChildMdi"
        Text = "ChildMdi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

#End Region

    Private label1 As Wisej.Web.Label
End Class
