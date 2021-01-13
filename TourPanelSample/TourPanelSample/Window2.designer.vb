Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window2
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
        tabControl1 = New Wisej.Web.TabControl()
        tabPage1 = New Wisej.Web.TabPage()
        tabPage2 = New Wisej.Web.TabPage()
        tabPage3 = New Wisej.Web.TabPage()
        tabPage4 = New Wisej.Web.TabPage()
        groupBox1 = New Wisej.Web.GroupBox()
        textBox1 = New Wisej.Web.TextBox()
        label1 = New Wisej.Web.Label()
        tabPage5 = New Wisej.Web.TabPage()
        tabPage6 = New Wisej.Web.TabPage()
        tabPage7 = New Wisej.Web.TabPage()
        tabPage8 = New Wisej.Web.TabPage()
        tabControl1.SuspendLayout()
        tabPage4.SuspendLayout()
        groupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabControl1
        ' 
        tabControl1.Controls.Add(tabPage1)
        tabControl1.Controls.Add(tabPage2)
        tabControl1.Controls.Add(tabPage3)
        tabControl1.Controls.Add(tabPage4)
        tabControl1.Controls.Add(tabPage5)
        tabControl1.Controls.Add(tabPage6)
        tabControl1.Controls.Add(tabPage7)
        tabControl1.Controls.Add(tabPage8)
        tabControl1.Location = New Drawing.Point(14, 26)
        tabControl1.Name = "tabControl1"
        tabControl1.PageInsets = New Wisej.Web.Padding(1, 35, 1, 1)
        tabControl1.Size = New Drawing.Size(788, 357)
        tabControl1.TabIndex = 0
        ' 
        ' tabPage1
        ' 
        tabPage1.Location = New Drawing.Point(1, 35)
        tabPage1.Name = "tabPage1"
        tabPage1.Text = "tabPage1"
        ' 
        ' tabPage2
        ' 
        tabPage2.Location = New Drawing.Point(1, 35)
        tabPage2.Name = "tabPage2"
        tabPage2.Text = "tabPage2"
        ' 
        ' tabPage3
        ' 
        tabPage3.Location = New Drawing.Point(1, 35)
        tabPage3.Name = "tabPage3"
        tabPage3.Text = "tabPage3"
        ' 
        ' tabPage4
        ' 
        tabPage4.Controls.Add(groupBox1)
        tabPage4.Location = New Drawing.Point(1, 35)
        tabPage4.Name = "tabPage4"
        tabPage4.Text = "tabPage4"
        ' 
        ' groupBox1
        ' 
        groupBox1.Collapsed = True
        groupBox1.Controls.Add(textBox1)
        groupBox1.Controls.Add(label1)
        groupBox1.Location = New Drawing.Point(9, 13)
        groupBox1.Name = "groupBox1"
        groupBox1.RestoreBounds = New Drawing.Rectangle(9, 13, 732, 285)
        groupBox1.Size = New Drawing.Size(732, 25)
        groupBox1.TabIndex = 0
        groupBox1.Text = "groupBox1"
        ' 
        ' textBox1
        ' 
        textBox1.Location = New Drawing.Point(191, 46)
        textBox1.Name = "textBox1"
        textBox1.Size = New Drawing.Size(527, 22)
        textBox1.TabIndex = 1
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Drawing.Point(17, 52)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(178, 16)
        label1.TabIndex = 0
        label1.Text = "Field in collapsed group box:"
        ' 
        ' tabPage5
        ' 
        tabPage5.Location = New Drawing.Point(1, 35)
        tabPage5.Name = "tabPage5"
        tabPage5.Text = "tabPage5"
        ' 
        ' tabPage6
        ' 
        tabPage6.Location = New Drawing.Point(1, 35)
        tabPage6.Name = "tabPage6"
        tabPage6.Text = "tabPage6"
        ' 
        ' tabPage7
        ' 
        tabPage7.Location = New Drawing.Point(1, 35)
        tabPage7.Name = "tabPage7"
        tabPage7.Text = "tabPage7"
        ' 
        ' tabPage8
        ' 
        tabPage8.Location = New Drawing.Point(1, 35)
        tabPage8.Name = "tabPage8"
        tabPage8.Text = "tabPage8"
        ' 
        ' Window2
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(836, 417)
        CloseBox = False
        Controls.Add(tabControl1)
        Location = New Drawing.Point(100, 100)
        Name = "Window2"
        Text = "Form2"
        tabControl1.ResumeLayout(False)
        tabPage4.ResumeLayout(False)
        groupBox1.ResumeLayout(False)
        groupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

#End Region

    Friend WithEvents tabControl1 As Wisej.Web.TabControl
    Friend WithEvents tabPage1 As Wisej.Web.TabPage
    Friend WithEvents tabPage2 As Wisej.Web.TabPage
    Friend WithEvents tabPage3 As Wisej.Web.TabPage
    Friend WithEvents tabPage4 As Wisej.Web.TabPage
    Friend WithEvents tabPage5 As Wisej.Web.TabPage
    Friend WithEvents tabPage6 As Wisej.Web.TabPage
    Friend WithEvents tabPage7 As Wisej.Web.TabPage
    Friend WithEvents tabPage8 As Wisej.Web.TabPage
    Friend WithEvents groupBox1 As Wisej.Web.GroupBox
    Friend WithEvents textBox1 As Wisej.Web.TextBox
    Friend WithEvents label1 As Wisej.Web.Label
End Class
