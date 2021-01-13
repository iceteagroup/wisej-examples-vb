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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Window1))
        Dim DataGridViewCellStyle1 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.dateTimePicker = New Wisej.Web.DateTimePicker()
        Me.label1 = New Wisej.Web.Label()
        Me.statusBar = New Wisej.Web.StatusBar()
        Me.statusBarPanel1 = New Wisej.Web.StatusBarPanel()
        Me.menuBar = New Wisej.Web.MenuBar()
        Me.menuItem1 = New Wisej.Web.MenuItem()
        Me.menuItem2 = New Wisej.Web.MenuItem()
        Me.menuItem3 = New Wisej.Web.MenuItem()
        Me.menuItem4 = New Wisej.Web.MenuItem()
        Me.menuItem5 = New Wisej.Web.MenuItem()
        Me.menuItem8 = New Wisej.Web.MenuItem()
        Me.selectEnglish = New Wisej.Web.MenuItem()
        Me.selectFrench = New Wisej.Web.MenuItem()
        Me.button1 = New Wisej.Web.Button()
        Me.toolBar1 = New Wisej.Web.ToolBar()
        Me.toolBarButton1 = New Wisej.Web.ToolBarButton()
        Me.contextMenu = New Wisej.Web.ContextMenu()
        Me.menuItem6 = New Wisej.Web.MenuItem()
        Me.menuItem7 = New Wisej.Web.MenuItem()
        Me.toolBarButton4 = New Wisej.Web.ToolBarButton()
        Me.toolBarButton2 = New Wisej.Web.ToolBarButton()
        Me.toolBarButton3 = New Wisej.Web.ToolBarButton()
        Me.textBox1 = New Wisej.Web.TextBox()
        Me.label2 = New Wisej.Web.Label()
        Me.button2 = New Wisej.Web.Button()
        Me.groupBox = New Wisej.Web.GroupBox()
        Me.label4 = New Wisej.Web.Label()
        Me.numericUpDown1 = New Wisej.Web.NumericUpDown()
        Me.hourUpDown = New Wisej.Web.NumericUpDown()
        Me.label3 = New Wisej.Web.Label()
        Me.textBox2 = New Wisej.Web.TextBox()
        Me.dataGridView = New Wisej.Web.DataGridView()
        Me.Column1 = New Wisej.Web.DataGridViewColumn()
        Me.Column3 = New Wisej.Web.DataGridViewColumn()
        Me.groupBox.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hourUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dateTimePicker
        '
        Me.dateTimePicker.Checked = False
        resources.ApplyResources(Me.dateTimePicker, "dateTimePicker")
        Me.dateTimePicker.Name = "dateTimePicker"
        Me.dateTimePicker.Value = New Date(CType(0, Long))
        '
        'label1
        '
        resources.ApplyResources(Me.label1, "label1")
        Me.label1.Name = "label1"
        '
        'statusBar
        '
        resources.ApplyResources(Me.statusBar, "statusBar")
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Panels.AddRange(New Wisej.Web.StatusBarPanel() {Me.statusBarPanel1})
        '
        'statusBarPanel1
        '
        Me.statusBarPanel1.Name = "statusBarPanel1"
        resources.ApplyResources(Me.statusBarPanel1, "statusBarPanel1")
        '
        'menuBar
        '
        resources.ApplyResources(Me.menuBar, "menuBar")
        Me.menuBar.MenuItems.AddRange(New Wisej.Web.MenuItem() {Me.menuItem1, Me.menuItem5, Me.menuItem8})
        Me.menuBar.Name = "menuBar"
        Me.menuBar.TabStop = False
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New Wisej.Web.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4})
        Me.menuItem1.Name = "menuItem1"
        resources.ApplyResources(Me.menuItem1, "menuItem1")
        '
        'menuItem2
        '
        Me.menuItem2.Index = 0
        Me.menuItem2.Name = "menuItem2"
        resources.ApplyResources(Me.menuItem2, "menuItem2")
        '
        'menuItem3
        '
        Me.menuItem3.Index = 1
        Me.menuItem3.Name = "menuItem3"
        resources.ApplyResources(Me.menuItem3, "menuItem3")
        '
        'menuItem4
        '
        Me.menuItem4.Index = 2
        Me.menuItem4.Name = "menuItem4"
        resources.ApplyResources(Me.menuItem4, "menuItem4")
        '
        'menuItem5
        '
        Me.menuItem5.Index = 1
        Me.menuItem5.Name = "menuItem5"
        resources.ApplyResources(Me.menuItem5, "menuItem5")
        '
        'menuItem8
        '
        Me.menuItem8.Index = 2
        Me.menuItem8.MenuItems.AddRange(New Wisej.Web.MenuItem() {Me.selectEnglish, Me.selectFrench})
        Me.menuItem8.Name = "menuItem8"
        resources.ApplyResources(Me.menuItem8, "menuItem8")
        '
        'selectEnglish
        '
        Me.selectEnglish.Checked = True
        Me.selectEnglish.Index = 0
        Me.selectEnglish.Name = "selectEnglish"
        Me.selectEnglish.RadioCheck = True
        resources.ApplyResources(Me.selectEnglish, "selectEnglish")
        '
        'selectFrench
        '
        Me.selectFrench.Index = 1
        Me.selectFrench.Name = "selectFrench"
        Me.selectFrench.RadioCheck = True
        resources.ApplyResources(Me.selectFrench, "selectFrench")
        '
        'button1
        '
        resources.ApplyResources(Me.button1, "button1")
        Me.button1.Name = "button1"
        '
        'toolBar1
        '
        Me.toolBar1.Buttons.AddRange(New Wisej.Web.ToolBarButton() {Me.toolBarButton1, Me.toolBarButton4, Me.toolBarButton2, Me.toolBarButton3})
        resources.ApplyResources(Me.toolBar1, "toolBar1")
        Me.toolBar1.Name = "toolBar1"
        Me.toolBar1.TabStop = False
        '
        'toolBarButton1
        '
        Me.toolBarButton1.DropDownMenu = Me.contextMenu
        Me.toolBarButton1.Name = "toolBarButton1"
        Me.toolBarButton1.Style = Wisej.Web.ToolBarButtonStyle.DropDownButton
        resources.ApplyResources(Me.toolBarButton1, "toolBarButton1")
        '
        'contextMenu
        '
        Me.contextMenu.MenuItems.AddRange(New Wisej.Web.MenuItem() {Me.menuItem6, Me.menuItem7})
        Me.contextMenu.Name = "contextMenu"
        '
        'menuItem6
        '
        Me.menuItem6.Index = 0
        Me.menuItem6.Name = "menuItem6"
        resources.ApplyResources(Me.menuItem6, "menuItem6")
        '
        'menuItem7
        '
        Me.menuItem7.Index = 1
        Me.menuItem7.Name = "menuItem7"
        resources.ApplyResources(Me.menuItem7, "menuItem7")
        '
        'toolBarButton4
        '
        Me.toolBarButton4.Name = "toolBarButton4"
        Me.toolBarButton4.Style = Wisej.Web.ToolBarButtonStyle.Separator
        resources.ApplyResources(Me.toolBarButton4, "toolBarButton4")
        '
        'toolBarButton2
        '
        Me.toolBarButton2.Name = "toolBarButton2"
        resources.ApplyResources(Me.toolBarButton2, "toolBarButton2")
        '
        'toolBarButton3
        '
        Me.toolBarButton3.Name = "toolBarButton3"
        resources.ApplyResources(Me.toolBarButton3, "toolBarButton3")
        '
        'textBox1
        '
        resources.ApplyResources(Me.textBox1, "textBox1")
        Me.textBox1.Name = "textBox1"
        '
        'label2
        '
        resources.ApplyResources(Me.label2, "label2")
        Me.label2.Name = "label2"
        '
        'button2
        '
        resources.ApplyResources(Me.button2, "button2")
        Me.button2.Name = "button2"
        '
        'groupBox
        '
        Me.groupBox.Controls.Add(Me.label4)
        Me.groupBox.Controls.Add(Me.numericUpDown1)
        Me.groupBox.Controls.Add(Me.hourUpDown)
        Me.groupBox.Controls.Add(Me.label3)
        Me.groupBox.Controls.Add(Me.textBox2)
        Me.groupBox.Controls.Add(Me.label1)
        Me.groupBox.Controls.Add(Me.button2)
        Me.groupBox.Controls.Add(Me.dateTimePicker)
        Me.groupBox.Controls.Add(Me.label2)
        Me.groupBox.Controls.Add(Me.button1)
        Me.groupBox.Controls.Add(Me.textBox1)
        resources.ApplyResources(Me.groupBox, "groupBox")
        Me.groupBox.Name = "groupBox"
        '
        'label4
        '
        resources.ApplyResources(Me.label4, "label4")
        Me.label4.Name = "label4"
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        resources.ApplyResources(Me.numericUpDown1, "numericUpDown1")
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {55, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        '
        'hourUpDown
        '
        resources.ApplyResources(Me.hourUpDown, "hourUpDown")
        Me.hourUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.hourUpDown.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.hourUpDown.Name = "hourUpDown"
        Me.hourUpDown.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'label3
        '
        resources.ApplyResources(Me.label3, "label3")
        Me.label3.Name = "label3"
        '
        'textBox2
        '
        resources.ApplyResources(Me.textBox2, "textBox2")
        Me.textBox2.Name = "textBox2"
        '
        'dataGridView
        '
        resources.ApplyResources(Me.dataGridView, "dataGridView")
        Me.dataGridView.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Column1, Me.Column3})
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.ShowFocusCell = False
        '
        'Column1
        '
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.FillWeight = 110.0!
        resources.ApplyResources(Me.Column1, "Column1")
        Me.Column1.Name = "Column1"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill
        resources.ApplyResources(Me.Column3, "Column3")
        Me.Column3.Name = "Column3"
        '
        'Window1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.dataGridView)
        Me.Controls.Add(Me.groupBox)
        Me.Controls.Add(Me.toolBar1)
        Me.Controls.Add(Me.menuBar)
        Me.Controls.Add(Me.statusBar)
        Me.Name = "Window1"
        Me.groupBox.ResumeLayout(False)
        Me.groupBox.PerformLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hourUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents dateTimePicker As Wisej.Web.DateTimePicker
    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents statusBar As Wisej.Web.StatusBar
    Friend WithEvents statusBarPanel1 As Wisej.Web.StatusBarPanel
    Friend WithEvents menuBar As Wisej.Web.MenuBar
    Friend WithEvents menuItem1 As Wisej.Web.MenuItem
    Friend WithEvents menuItem2 As Wisej.Web.MenuItem
    Friend WithEvents menuItem3 As Wisej.Web.MenuItem
    Friend WithEvents menuItem4 As Wisej.Web.MenuItem
    Friend WithEvents menuItem5 As Wisej.Web.MenuItem
    Friend WithEvents button1 As Wisej.Web.Button
    Friend WithEvents toolBar1 As Wisej.Web.ToolBar
    Friend WithEvents textBox1 As Wisej.Web.TextBox
    Friend WithEvents label2 As Wisej.Web.Label
    Friend WithEvents button2 As Wisej.Web.Button
    Friend WithEvents groupBox As Wisej.Web.GroupBox
    Friend WithEvents toolBarButton1 As Wisej.Web.ToolBarButton
    Friend WithEvents toolBarButton4 As Wisej.Web.ToolBarButton
    Friend WithEvents toolBarButton2 As Wisej.Web.ToolBarButton
    Friend WithEvents toolBarButton3 As Wisej.Web.ToolBarButton
    Friend WithEvents dataGridView As Wisej.Web.DataGridView
    Friend WithEvents menuItem8 As Wisej.Web.MenuItem
    Friend WithEvents selectEnglish As Wisej.Web.MenuItem
    Friend WithEvents selectFrench As Wisej.Web.MenuItem
    Friend WithEvents contextMenu As Wisej.Web.ContextMenu
    Friend WithEvents menuItem6 As Wisej.Web.MenuItem
    Friend WithEvents menuItem7 As Wisej.Web.MenuItem
    Friend WithEvents Column1 As Wisej.Web.DataGridViewColumn
    Friend WithEvents Column3 As Wisej.Web.DataGridViewColumn
    Friend WithEvents label3 As Wisej.Web.Label
    Friend WithEvents textBox2 As Wisej.Web.TextBox
    Friend WithEvents hourUpDown As Wisej.Web.NumericUpDown
    Friend WithEvents label4 As Wisej.Web.Label
    Friend WithEvents numericUpDown1 As Wisej.Web.NumericUpDown
End Class
