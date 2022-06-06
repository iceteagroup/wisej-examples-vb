Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Page1
    Inherits Wisej.Web.Page


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Page1))
        Me.button1 = New Wisej.Web.Button()
        Me.label1 = New Wisej.Web.Label()
        Me.button2 = New Wisej.Web.Button()
        Me.button3 = New Wisej.Web.Button()
        Me.button4 = New Wisej.Web.Button()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(38, 129)
        Me.button1.Name = "button1"
        Me.button1.Padding = New Wisej.Web.Padding(50, 0, 0, 0)
        Me.button1.Size = New System.Drawing.Size(459, 36)
        Me.button1.TabIndex = 0
        Me.button1.Text = "1. Download PDF"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(38, 38)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(459, 85)
        Me.label1.TabIndex = 1
        Me.label1.Text = resources.GetString("label1.Text")
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(38, 188)
        Me.button2.Name = "button2"
        Me.button2.Padding = New Wisej.Web.Padding(50, 0, 0, 0)
        Me.button2.Size = New System.Drawing.Size(459, 36)
        Me.button2.TabIndex = 2
        Me.button2.Text = "2. Download and open PDF"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(38, 247)
        Me.button3.Name = "button3"
        Me.button3.Padding = New Wisej.Web.Padding(50, 0, 0, 0)
        Me.button3.Size = New System.Drawing.Size(459, 36)
        Me.button3.TabIndex = 3
        Me.button3.Text = "3. Download PDF with FileStream"
        Me.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(38, 306)
        Me.button4.Name = "button4"
        Me.button4.Padding = New Wisej.Web.Padding(50, 0, 0, 0)
        Me.button4.Size = New System.Drawing.Size(459, 36)
        Me.button4.TabIndex = 4
        Me.button4.Text = "4. Download ZIP created in memory"
        Me.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(1025, 820)
        Me.Text = "Page1"
        Me.ResumeLayout(False)

    End Sub


#End Region

    Friend WithEvents button1 As Web.Button
    Friend WithEvents label1 As Web.Label
    Friend WithEvents button2 As Web.Button
    Friend WithEvents button3 As Web.Button
    Friend WithEvents button4 As Web.Button
End Class
