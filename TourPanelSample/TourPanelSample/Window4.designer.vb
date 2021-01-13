Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window4
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
        Me.labelChrome = New Wisej.Web.Label()
        Me.ckEditor1 = New Wisej.Web.Ext.CKEditor.CKEditor()
        Me.SuspendLayout()
        '
        'labelChrome
        '
        Me.labelChrome.AutoSize = True
        Me.labelChrome.Location = New System.Drawing.Point(17, 14)
        Me.labelChrome.Name = "labelChrome"
        Me.labelChrome.Size = New System.Drawing.Size(244, 15)
        Me.labelChrome.TabIndex = 0
        Me.labelChrome.Text = "This label is only visible for Chrome users"
        '
        'ckEditor1
        '
        Me.ckEditor1.Location = New System.Drawing.Point(16, 41)
        Me.ckEditor1.Name = "ckEditor1"
        Me.ckEditor1.Size = New System.Drawing.Size(801, 289)
        Me.ckEditor1.TabIndex = 1
        Me.ckEditor1.Text = "ckEditor1"
        '
        'Window4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 367)
        Me.CloseBox = False
        Me.Controls.Add(Me.ckEditor1)
        Me.Controls.Add(Me.labelChrome)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Name = "Window4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents labelChrome As Wisej.Web.Label
    Friend WithEvents ckEditor1 As Wisej.Web.Ext.CKEditor.CKEditor
End Class
