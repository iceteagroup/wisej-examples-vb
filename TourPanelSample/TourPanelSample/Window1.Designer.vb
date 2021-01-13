Imports System

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

#Region "Wisej Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim componentTool3 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        mainMenu1 = New Wisej.Web.MainMenu(components)
        menuItem1 = New Wisej.Web.MenuItem()
        menuItem3 = New Wisej.Web.MenuItem()
        menuItem2 = New Wisej.Web.MenuItem()
        menuItem4 = New Wisej.Web.MenuItem()
        menuItem6 = New Wisej.Web.MenuItem()
        menuItem7 = New Wisej.Web.MenuItem()
        label1 = New Wisej.Web.Label()
        label2 = New Wisej.Web.Label()
        label3 = New Wisej.Web.Label()
        panel1 = New Wisej.Web.Panel()
        checkBox2 = New Wisej.Web.CheckBox()
        checkBox1 = New Wisej.Web.CheckBox()
        txtFirstName = New Wisej.Web.TextBox()
        txtName = New Wisej.Web.TextBox()
        cmbInterest = New Wisej.Web.ComboBox()
        panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainMenu1
        ' 
        mainMenu1.MenuItems.AddRange(New Wisej.Web.MenuItem() {menuItem1, menuItem6})
        mainMenu1.Name = "mainMenu1"
        ' 
        ' menuItem1
        ' 
        menuItem1.Index = 0
        menuItem1.MenuItems.AddRange(New Wisej.Web.MenuItem() {menuItem3, menuItem2, menuItem4})
        menuItem1.Name = "menuItem1"
        menuItem1.Text = "File"
        ' 
        ' menuItem3
        ' 
        menuItem3.Index = 0
        menuItem3.Name = "menuItem3"
        menuItem3.Text = "New"
        ' 
        ' menuItem2
        ' 
        menuItem2.Index = 1
        menuItem2.Name = "menuItem2"
        menuItem2.Text = "Open"
        ' 
        ' menuItem4
        ' 
        menuItem4.Index = 2
        menuItem4.Name = "menuItem4"
        menuItem4.Text = "Save"
        ' 
        ' menuItem6
        ' 
        menuItem6.Index = 1
        menuItem6.MenuItems.AddRange(New Wisej.Web.MenuItem() {menuItem7})
        menuItem6.Name = "menuItem6"
        menuItem6.Text = "Help"
        ' 
        ' menuItem7
        ' 
        menuItem7.Index = 0
        menuItem7.Name = "menuItem7"
        menuItem7.Text = "About"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Drawing.Point(7, 19)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(82, 16)
        label1.TabIndex = 0
        label1.Text = "First Name *"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Drawing.Point(7, 53)
        label2.Name = "label2"
        label2.Size = New Drawing.Size(52, 16)
        label2.TabIndex = 1
        label2.Text = "Name *"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Drawing.Point(7, 88)
        label3.Name = "label3"
        label3.Size = New Drawing.Size(59, 16)
        label3.TabIndex = 2
        label3.Text = "Interests"
        ' 
        ' panel1
        ' 
        panel1.Collapsed = True
        panel1.Controls.Add(checkBox2)
        panel1.Controls.Add(checkBox1)
        panel1.Location = New Drawing.Point(8, 132)
        panel1.Name = "panel1"
        panel1.RestoreBounds = New Drawing.Rectangle(8, 132, 159, 119)
        panel1.ShowHeader = True
        panel1.Size = New Drawing.Size(159, 28)
        panel1.TabIndex = 3
        panel1.Text = "More information"
        ' 
        ' checkBox2
        ' 
        checkBox2.Location = New Drawing.Point(12, 51)
        checkBox2.Name = "checkBox2"
        checkBox2.Size = New Drawing.Size(123, 23)
        checkBox2.TabIndex = 1
        checkBox2.Text = "Special discount"
        ' 
        ' checkBox1
        ' 
        checkBox1.Location = New Drawing.Point(12, 22)
        checkBox1.Name = "checkBox1"
        checkBox1.Size = New Drawing.Size(106, 23)
        checkBox1.TabIndex = 0
        checkBox1.Text = "VIP customer"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Drawing.Point(104, 15)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Drawing.Size(265, 22)
        txtFirstName.TabIndex = 4
        ' 
        ' txtName
        ' 
        txtName.Location = New Drawing.Point(104, 51)
        txtName.Name = "txtName"
        txtName.Size = New Drawing.Size(265, 22)
        txtName.TabIndex = 5
        ' 
        ' cmbInterest
        ' 
        cmbInterest.Items.AddRange(New Object() {"Swimming", "Cooking", "Reading", "Football"})
        cmbInterest.Location = New Drawing.Point(104, 88)
        cmbInterest.Name = "cmbInterest"
        cmbInterest.Size = New Drawing.Size(264, 22)
        cmbInterest.TabIndex = 6
        componentTool3.ImageSource = "window-maximize"
        cmbInterest.Tools.AddRange(New Wisej.Web.ComponentTool() {componentTool3})
        AddHandler cmbInterest.ToolClick, New Wisej.Web.ToolClickEventHandler(AddressOf comboBox1_ToolClick)
        ' 
        ' Window1
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(1010, 673)
        CloseBox = False
        Controls.Add(cmbInterest)
        Controls.Add(txtName)
        Controls.Add(txtFirstName)
        Controls.Add(panel1)
        Controls.Add(label3)
        Controls.Add(label2)
        Controls.Add(label1)
        Location = New Drawing.Point(100, 100)
        Menu = mainMenu1
        Name = "Window1"
        Text = "Form1"
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

#End Region

    Friend WithEvents mainMenu1 As Wisej.Web.MainMenu
    Friend WithEvents menuItem1 As Wisej.Web.MenuItem
    Friend WithEvents menuItem3 As Wisej.Web.MenuItem
    Friend WithEvents menuItem2 As Wisej.Web.MenuItem
    Friend WithEvents menuItem4 As Wisej.Web.MenuItem
    Friend WithEvents menuItem6 As Wisej.Web.MenuItem
    Friend WithEvents menuItem7 As Wisej.Web.MenuItem
    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents label2 As Wisej.Web.Label
    Friend WithEvents label3 As Wisej.Web.Label
    Friend WithEvents panel1 As Wisej.Web.Panel
    Friend WithEvents checkBox2 As Wisej.Web.CheckBox
    Friend WithEvents checkBox1 As Wisej.Web.CheckBox
    Friend WithEvents txtFirstName As Wisej.Web.TextBox
    Friend WithEvents txtName As Wisej.Web.TextBox
    Friend WithEvents cmbInterest As Wisej.Web.ComboBox
End Class
