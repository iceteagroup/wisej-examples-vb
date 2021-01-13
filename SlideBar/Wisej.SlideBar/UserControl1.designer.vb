Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl1
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
        label1 = New Web.Label()
        checkBox1 = New Web.CheckBox()
        checkBox2 = New Web.CheckBox()
        checkBox3 = New Web.CheckBox()
        checkBox4 = New Web.CheckBox()
        panel1 = New Web.Panel()
        button1 = New Web.Button()
        button2 = New Web.Button()
        button3 = New Web.Button()
        panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.AllowHtml = True
        label1.AutoSize = True
        label1.Location = New Drawing.Point(8, 11)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(133, 16)
        label1.TabIndex = 0
        label1.Text = "<b>User Control</b>"
        ' 
        ' checkBox1
        ' 
        checkBox1.Location = New Drawing.Point(10, 37)
        checkBox1.Name = "checkBox1"
        checkBox1.Size = New Drawing.Size(76, 23)
        checkBox1.TabIndex = 1
        checkBox1.Text = "Option 1"
        ' 
        ' checkBox2
        ' 
        checkBox2.Location = New Drawing.Point(10, 66)
        checkBox2.Name = "checkBox2"
        checkBox2.Size = New Drawing.Size(76, 23)
        checkBox2.TabIndex = 2
        checkBox2.Text = "Option 2"
        ' 
        ' checkBox3
        ' 
        checkBox3.Location = New Drawing.Point(10, 95)
        checkBox3.Name = "checkBox3"
        checkBox3.Size = New Drawing.Size(76, 23)
        checkBox3.TabIndex = 3
        checkBox3.Text = "Option 3"
        ' 
        ' checkBox4
        ' 
        checkBox4.Location = New Drawing.Point(10, 124)
        checkBox4.Name = "checkBox4"
        checkBox4.Size = New Drawing.Size(76, 23)
        checkBox4.TabIndex = 4
        checkBox4.Text = "Option 3"
        ' 
        ' panel1
        ' 
        panel1.BorderStyle = Web.BorderStyle.Double
        panel1.Controls.Add(button3)
        panel1.Controls.Add(button2)
        panel1.Controls.Add(button1)
        panel1.Location = New Drawing.Point(101, 29)
        panel1.Name = "panel1"
        panel1.ShowCloseButton = False
        panel1.ShowHeader = True
        panel1.Size = New Drawing.Size(111, 125)
        panel1.TabIndex = 5
        panel1.Text = "Actions"
        ' 
        ' button1
        ' 
        button1.Location = New Drawing.Point(11, 10)
        button1.Name = "button1"
        button1.Size = New Drawing.Size(88, 21)
        button1.TabIndex = 0
        button1.Text = "Action 1"
        ' 
        ' button2
        ' 
        button2.Location = New Drawing.Point(11, 40)
        button2.Name = "button2"
        button2.Size = New Drawing.Size(88, 21)
        button2.TabIndex = 1
        button2.Text = "Action 2"
        ' 
        ' button3
        ' 
        button3.Location = New Drawing.Point(11, 69)
        button3.Name = "button3"
        button3.Size = New Drawing.Size(88, 21)
        button3.TabIndex = 2
        button3.Text = "Action 3"
        ' 
        ' UserControl1
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        Controls.Add(panel1)
        Controls.Add(checkBox4)
        Controls.Add(checkBox3)
        Controls.Add(checkBox2)
        Controls.Add(checkBox1)
        Controls.Add(label1)
        Name = "UserControl1"
        Size = New Drawing.Size(225, 172)
        panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

#End Region

    Friend WithEvents label1 As Web.Label
    Friend WithEvents checkBox1 As Web.CheckBox
    Friend WithEvents checkBox2 As Web.CheckBox
    Friend WithEvents checkBox3 As Web.CheckBox
    Friend WithEvents checkBox4 As Web.CheckBox
    Friend WithEvents panel1 As Web.Panel
    Friend WithEvents button3 As Web.Button
    Friend WithEvents button2 As Web.Button
    Friend WithEvents button1 As Web.Button
End Class
