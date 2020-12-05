Imports Wisej.Web.Ext.RibbonBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window1
    Inherits Wisej.Web.Form
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
        Dim ComponentTool1 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Dim ComponentTool2 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Me.ribbonBar = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.ribbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.ribbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.ribbonBarItemButton1 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ribbonBarItemButton2 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ribbonBarItemButton3 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ribbonBarItemSeparator1 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemSeparator()
        Me.ribbonBarItemButton4 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ribbonBarItemButton5 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ribbonBarItemButton6 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.menuItem1 = New Wisej.Web.MenuItem()
        Me.menuItem2 = New Wisej.Web.MenuItem()
        Me.ribbonBarGroup2 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.ribbonBarItemSplitButton1 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemSplitButton()
        Me.menuItem3 = New Wisej.Web.MenuItem()
        Me.menuItem4 = New Wisej.Web.MenuItem()
        Me.ribbonBarItemButton7 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ribbonBarItemCheckBox1 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemCheckBox()
        Me.ribbonBarItemCheckBox2 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemCheckBox()
        Me.ribbonBarPage2 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.ribbonBarGroup3 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.ribbonBarItemTextBox1 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemTextBox()
        Me.ribbonBarItemTextBox2 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemTextBox()
        Me.ribbonBarItemComboBox1 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemComboBox()
        Me.ribbonBarGroup4 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.ribbonBarItemControl1 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemControl()
        Me.themePicker1 = New Wisej.RibbonBar.ThemePicker()
        Me.ribbonBarPage3 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.ribbonBarGroup5 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.ribbonBarItemButtonGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButtonGroup()
        Me.ribbonBarItemButton12 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ribbonBarItemButton13 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ribbonBarItemButton14 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ribbonBarItemButton15 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ribbonBarItemButton16 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ribbonBarItemButtonGroup2 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButtonGroup()
        Me.ribbonBarItemButton17 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ribbonBarItemButton18 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ribbonBarItemButton19 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ribbonBarItemButton20 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ribbonBarItemButton21 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.SuspendLayout()
        '
        'ribbonBar
        '
        '
        '
        '
        Me.ribbonBar.AppButton.ImageSource = "icon-preview?color=#3FBEBF"
        Me.ribbonBar.AppButton.Text = "FIle"
        Me.ribbonBar.AppButton.Visible = True
        Me.ribbonBar.Name = "ribbonBar"
        Me.ribbonBar.Pages.Add(Me.ribbonBarPage1)
        Me.ribbonBar.Pages.Add(Me.ribbonBarPage2)
        Me.ribbonBar.Pages.Add(Me.ribbonBarPage3)
        Me.ribbonBar.Size = New System.Drawing.Size(896, 145)
        ComponentTool1.ImageSource = "messagebox-question?color=#3600FF"
        ComponentTool1.Name = "Help"
        ComponentTool1.Position = Wisej.Web.LeftRightAlignment.Left
        ComponentTool2.ImageSource = "icon-settings?color=#FF1700"
        ComponentTool2.Name = "Settings"
        Me.ribbonBar.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool1, ComponentTool2})
        '
        'ribbonBarPage1
        '
        Me.ribbonBarPage1.Groups.Add(Me.ribbonBarGroup1)
        Me.ribbonBarPage1.Groups.Add(Me.ribbonBarGroup2)
        Me.ribbonBarPage1.Text = "Home"
        '
        'ribbonBarGroup1
        '
        Me.ribbonBarGroup1.Items.Add(Me.ribbonBarItemButton1)
        Me.ribbonBarGroup1.Items.Add(Me.ribbonBarItemButton2)
        Me.ribbonBarGroup1.Items.Add(Me.ribbonBarItemButton3)
        Me.ribbonBarGroup1.Items.Add(Me.ribbonBarItemSeparator1)
        Me.ribbonBarGroup1.Items.Add(Me.ribbonBarItemButton4)
        Me.ribbonBarGroup1.Items.Add(Me.ribbonBarItemButton5)
        Me.ribbonBarGroup1.Items.Add(Me.ribbonBarItemButton6)
        Me.ribbonBarGroup1.Text = "Clipboard"
        '
        'ribbonBarItemButton1
        '
        Me.ribbonBarItemButton1.ImageSource = "ribbon-pin"
        Me.ribbonBarItemButton1.Name = "ribbonBarItemButton1"
        Me.ribbonBarItemButton1.Text = "Pin to quick panel"
        Me.ribbonBarItemButton1.ToolTipText = "Adds the item to the quick access panel."
        '
        'ribbonBarItemButton2
        '
        Me.ribbonBarItemButton2.ImageSource = "ribbon-copy"
        Me.ribbonBarItemButton2.Name = "ribbonBarItemButton2"
        Me.ribbonBarItemButton2.Text = "Copy"
        '
        'ribbonBarItemButton3
        '
        Me.ribbonBarItemButton3.ImageSource = "ribbon-paste"
        Me.ribbonBarItemButton3.Name = "ribbonBarItemButton3"
        Me.ribbonBarItemButton3.Text = "Paste"
        '
        'ribbonBarItemSeparator1
        '
        Me.ribbonBarItemSeparator1.Name = "ribbonBarItemSeparator1"
        '
        'ribbonBarItemButton4
        '
        Me.ribbonBarItemButton4.ImageSource = "ribbon-cut"
        Me.ribbonBarItemButton4.Name = "ribbonBarItemButton4"
        Me.ribbonBarItemButton4.Orientation = Wisej.Web.Orientation.Horizontal
        Me.ribbonBarItemButton4.Text = "Cut"
        '
        'ribbonBarItemButton5
        '
        Me.ribbonBarItemButton5.ImageSource = "ribbon-copy"
        Me.ribbonBarItemButton5.Name = "ribbonBarItemButton5"
        Me.ribbonBarItemButton5.Orientation = Wisej.Web.Orientation.Horizontal
        Me.ribbonBarItemButton5.Text = "Copy special..."
        '
        'ribbonBarItemButton6
        '
        Me.ribbonBarItemButton6.ImageSource = "ribbon-paste"
        Me.ribbonBarItemButton6.MenuItems.AddRange(New Wisej.Web.MenuItem() {Me.menuItem1, Me.menuItem2})
        Me.ribbonBarItemButton6.Name = "ribbonBarItemButton6"
        Me.ribbonBarItemButton6.Orientation = Wisej.Web.Orientation.Horizontal
        Me.ribbonBarItemButton6.Text = "Paste special"
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.Name = "menuItem1"
        Me.menuItem1.Text = "Only text"
        '
        'menuItem2
        '
        Me.menuItem2.Index = 1
        Me.menuItem2.Name = "menuItem2"
        Me.menuItem2.Text = "Preserve formatting"
        '
        'ribbonBarGroup2
        '
        Me.ribbonBarGroup2.Items.Add(Me.ribbonBarItemSplitButton1)
        Me.ribbonBarGroup2.Items.Add(Me.ribbonBarItemButton7)
        Me.ribbonBarGroup2.Items.Add(Me.ribbonBarItemCheckBox1)
        Me.ribbonBarGroup2.Items.Add(Me.ribbonBarItemCheckBox2)
        Me.ribbonBarGroup2.ShowButton = True
        Me.ribbonBarGroup2.Text = "New"
        '
        'ribbonBarItemSplitButton1
        '
        Me.ribbonBarItemSplitButton1.ImageSource = "ribbon-add-file"
        Me.ribbonBarItemSplitButton1.MenuItems.AddRange(New Wisej.Web.MenuItem() {Me.menuItem3, Me.menuItem4})
        Me.ribbonBarItemSplitButton1.Name = "ribbonBarItemSplitButton1"
        Me.ribbonBarItemSplitButton1.Text = "File"
        '
        'menuItem3
        '
        Me.menuItem3.IconSource = "resource.wx/Wisej.Ext.FontAwesome/archive.svg?color=#FF8F00"
        Me.menuItem3.Index = 0
        Me.menuItem3.Name = "menuItem3"
        Me.menuItem3.Text = "Archive"
        '
        'menuItem4
        '
        Me.menuItem4.IconSource = "resource.wx/Wisej.Ext.FontAwesome/bar-chart.svg?color=#00FF00"
        Me.menuItem4.Index = 1
        Me.menuItem4.Name = "menuItem4"
        Me.menuItem4.Text = "Chart"
        '
        'ribbonBarItemButton7
        '
        Me.ribbonBarItemButton7.ImageSource = "ribbon-add-folder"
        Me.ribbonBarItemButton7.Name = "ribbonBarItemButton7"
        Me.ribbonBarItemButton7.Text = "Folder"
        '
        'ribbonBarItemCheckBox1
        '
        Me.ribbonBarItemCheckBox1.Name = "ribbonBarItemCheckBox1"
        Me.ribbonBarItemCheckBox1.Text = "Overwrite"
        '
        'ribbonBarItemCheckBox2
        '
        Me.ribbonBarItemCheckBox2.Name = "ribbonBarItemCheckBox2"
        Me.ribbonBarItemCheckBox2.Text = "Save to cloud"
        '
        'ribbonBarPage2
        '
        Me.ribbonBarPage2.Groups.Add(Me.ribbonBarGroup3)
        Me.ribbonBarPage2.Groups.Add(Me.ribbonBarGroup4)
        Me.ribbonBarPage2.Text = "&Options"
        '
        'ribbonBarGroup3
        '
        Me.ribbonBarGroup3.Items.Add(Me.ribbonBarItemTextBox1)
        Me.ribbonBarGroup3.Items.Add(Me.ribbonBarItemTextBox2)
        Me.ribbonBarGroup3.Items.Add(Me.ribbonBarItemComboBox1)
        Me.ribbonBarGroup3.Text = "Settings"
        '
        'ribbonBarItemTextBox1
        '
        Me.ribbonBarItemTextBox1.ImageSource = "icon-settings?color=#3FBF47"
        Me.ribbonBarItemTextBox1.Name = "ribbonBarItemTextBox1"
        Me.ribbonBarItemTextBox1.Text = "Profile Name"
        '
        'ribbonBarItemTextBox2
        '
        Me.ribbonBarItemTextBox2.ImageSource = "icon-settings?color=#3FBF47"
        Me.ribbonBarItemTextBox2.Name = "ribbonBarItemTextBox2"
        Me.ribbonBarItemTextBox2.Text = "Unique ID"
        '
        'ribbonBarItemComboBox1
        '
        Me.ribbonBarItemComboBox1.ImageSource = "menu-overflow?color=#DF00FF"
        Me.ribbonBarItemComboBox1.Name = "ribbonBarItemComboBox1"
        Me.ribbonBarItemComboBox1.Text = "User Level"
        '
        'ribbonBarGroup4
        '
        Me.ribbonBarGroup4.Items.Add(Me.ribbonBarItemControl1)
        Me.ribbonBarGroup4.Text = "Themes"
        '
        'ribbonBarItemControl1
        '
        Me.ribbonBarItemControl1.Control = Me.themePicker1
        Me.ribbonBarItemControl1.Name = "ribbonBarItemControl1"
        Me.ribbonBarItemControl1.Text = "ribbonBarItemControl1"
        '
        'themePicker1
        '
        Me.themePicker1.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.themePicker1.Location = New System.Drawing.Point(14, 163)
        Me.themePicker1.Name = "themePicker1"
        Me.themePicker1.TabIndex = 1
        '
        'ribbonBarPage3
        '
        Me.ribbonBarPage3.Groups.Add(Me.ribbonBarGroup5)
        Me.ribbonBarPage3.TabBackColor = System.Drawing.Color.FromArgb(79, 191, 63)
        Me.ribbonBarPage3.TabForeColor = System.Drawing.Color.FromArgb(244, 244, 244)
        Me.ribbonBarPage3.Text = "Edit"
        '
        'ribbonBarGroup5
        '
        Me.ribbonBarGroup5.Items.Add(Me.ribbonBarItemButtonGroup1)
        Me.ribbonBarGroup5.Items.Add(Me.ribbonBarItemButtonGroup2)
        Me.ribbonBarGroup5.Text = "Formatting"
        '
        'ribbonBarItemButtonGroup1
        '
        Me.ribbonBarItemButtonGroup1.Buttons.Add(Me.ribbonBarItemButton12)
        Me.ribbonBarItemButtonGroup1.Buttons.Add(Me.ribbonBarItemButton13)
        Me.ribbonBarItemButtonGroup1.Buttons.Add(Me.ribbonBarItemButton14)
        Me.ribbonBarItemButtonGroup1.Buttons.Add(Me.ribbonBarItemButton15)
        Me.ribbonBarItemButtonGroup1.Buttons.Add(Me.ribbonBarItemButton16)
        Me.ribbonBarItemButtonGroup1.Name = "ribbonBarItemButtonGroup1"
        '
        'ribbonBarItemButton12
        '
        Me.ribbonBarItemButton12.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/align-center.svg"
        Me.ribbonBarItemButton12.Name = "ribbonBarItemButton12"
        Me.ribbonBarItemButton12.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'ribbonBarItemButton13
        '
        Me.ribbonBarItemButton13.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/align-justify.svg"
        Me.ribbonBarItemButton13.Name = "ribbonBarItemButton13"
        Me.ribbonBarItemButton13.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'ribbonBarItemButton14
        '
        Me.ribbonBarItemButton14.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/anchor.svg"
        Me.ribbonBarItemButton14.Name = "ribbonBarItemButton14"
        Me.ribbonBarItemButton14.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'ribbonBarItemButton15
        '
        Me.ribbonBarItemButton15.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/arrows-alt.svg"
        Me.ribbonBarItemButton15.Name = "ribbonBarItemButton15"
        Me.ribbonBarItemButton15.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'ribbonBarItemButton16
        '
        Me.ribbonBarItemButton16.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/code.svg"
        Me.ribbonBarItemButton16.Name = "ribbonBarItemButton16"
        Me.ribbonBarItemButton16.Orientation = Wisej.Web.Orientation.Horizontal
        Me.ribbonBarItemButton16.Text = "Source"
        '
        'ribbonBarItemButtonGroup2
        '
        Me.ribbonBarItemButtonGroup2.Buttons.Add(Me.ribbonBarItemButton17)
        Me.ribbonBarItemButtonGroup2.Buttons.Add(Me.ribbonBarItemButton18)
        Me.ribbonBarItemButtonGroup2.Buttons.Add(Me.ribbonBarItemButton19)
        Me.ribbonBarItemButtonGroup2.Buttons.Add(Me.ribbonBarItemButton20)
        Me.ribbonBarItemButtonGroup2.Buttons.Add(Me.ribbonBarItemButton21)
        Me.ribbonBarItemButtonGroup2.Name = "ribbonBarItemButtonGroup2"
        '
        'ribbonBarItemButton17
        '
        Me.ribbonBarItemButton17.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/arrow-circle-o-down.svg"
        Me.ribbonBarItemButton17.Name = "ribbonBarItemButton17"
        Me.ribbonBarItemButton17.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'ribbonBarItemButton18
        '
        Me.ribbonBarItemButton18.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/arrow-circle-o-left.svg"
        Me.ribbonBarItemButton18.Name = "ribbonBarItemButton18"
        Me.ribbonBarItemButton18.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'ribbonBarItemButton19
        '
        Me.ribbonBarItemButton19.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/arrow-circle-o-right.svg"
        Me.ribbonBarItemButton19.Name = "ribbonBarItemButton19"
        Me.ribbonBarItemButton19.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'ribbonBarItemButton20
        '
        Me.ribbonBarItemButton20.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/arrow-circle-o-up.svg"
        Me.ribbonBarItemButton20.Name = "ribbonBarItemButton20"
        Me.ribbonBarItemButton20.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'ribbonBarItemButton21
        '
        Me.ribbonBarItemButton21.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/android.svg?color=#FF7700"
        Me.ribbonBarItemButton21.Name = "ribbonBarItemButton21"
        Me.ribbonBarItemButton21.Orientation = Wisej.Web.Orientation.Horizontal
        Me.ribbonBarItemButton21.Text = "Wizard"
        '
        'Window1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 467)
        Me.Controls.Add(Me.ribbonBar)
        Me.Name = "Window1"
        Me.Text = "Window1"
        Me.ResumeLayout(False)

    End Sub


#End Region

    Friend WithEvents ribbonBar As Web.Ext.RibbonBar.RibbonBar
    Friend WithEvents ribbonBarPage1 As RibbonBarPage
    Friend WithEvents ribbonBarPage2 As RibbonBarPage
    Friend WithEvents ribbonBarGroup1 As RibbonBarGroup
    Friend WithEvents ribbonBarGroup2 As RibbonBarGroup
    Friend WithEvents ribbonBarGroup3 As RibbonBarGroup
    Friend WithEvents ribbonBarGroup4 As RibbonBarGroup
    Friend WithEvents ribbonBarItemButton1 As RibbonBarItemButton
    Friend WithEvents ribbonBarItemButton2 As RibbonBarItemButton
    Friend WithEvents ribbonBarItemButton3 As RibbonBarItemButton
    Friend WithEvents ribbonBarItemSeparator1 As RibbonBarItemSeparator
    Friend WithEvents ribbonBarItemButton4 As RibbonBarItemButton
    Friend WithEvents ribbonBarItemButton5 As RibbonBarItemButton
    Friend WithEvents ribbonBarItemButton6 As RibbonBarItemButton
    Friend WithEvents menuItem1 As Web.MenuItem
    Friend WithEvents menuItem2 As Web.MenuItem
    Friend WithEvents ribbonBarItemSplitButton1 As RibbonBarItemSplitButton
    Friend WithEvents menuItem3 As Web.MenuItem
    Friend WithEvents menuItem4 As Web.MenuItem
    Friend WithEvents ribbonBarItemButton7 As RibbonBarItemButton
    Friend WithEvents ribbonBarItemCheckBox1 As RibbonBarItemCheckBox
    Friend WithEvents ribbonBarItemCheckBox2 As RibbonBarItemCheckBox
    Friend WithEvents ribbonBarItemTextBox1 As RibbonBarItemTextBox
    Friend WithEvents ribbonBarItemTextBox2 As RibbonBarItemTextBox
    Friend WithEvents ribbonBarItemComboBox1 As RibbonBarItemComboBox
    Friend WithEvents ribbonBarItemControl1 As RibbonBarItemControl
    Friend WithEvents themePicker1 As ThemePicker
    Friend WithEvents ribbonBarPage3 As RibbonBarPage
    Friend WithEvents ribbonBarGroup5 As RibbonBarGroup
    Friend WithEvents ribbonBarItemButtonGroup1 As RibbonBarItemButtonGroup
    Friend WithEvents ribbonBarItemButton12 As RibbonBarItemButton
    Friend WithEvents ribbonBarItemButton13 As RibbonBarItemButton
    Friend WithEvents ribbonBarItemButton14 As RibbonBarItemButton
    Friend WithEvents ribbonBarItemButton15 As RibbonBarItemButton
    Friend WithEvents ribbonBarItemButton16 As RibbonBarItemButton
    Friend WithEvents ribbonBarItemButtonGroup2 As RibbonBarItemButtonGroup
    Friend WithEvents ribbonBarItemButton17 As RibbonBarItemButton
    Friend WithEvents ribbonBarItemButton18 As RibbonBarItemButton
    Friend WithEvents ribbonBarItemButton19 As RibbonBarItemButton
    Friend WithEvents ribbonBarItemButton20 As RibbonBarItemButton
    Friend WithEvents ribbonBarItemButton21 As RibbonBarItemButton
End Class
