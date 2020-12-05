<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
    Inherits Wisej.Web.Page
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As ComponentModel.IContainer = Nothing


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


#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.flowLayoutPanel = New Wisej.Web.FlowLayoutPanel()
        Me.sortBox1 = New BackgroundTasks.SortBox()
        Me.sortBox3 = New BackgroundTasks.SortBox()
        Me.sortBox2 = New BackgroundTasks.SortBox()
        Me.label1 = New Wisej.Web.Label()
        Me.numericUpDown1 = New Wisej.Web.NumericUpDown()
        Me.label3 = New Wisej.Web.Label()
        Me.panel1 = New Wisej.Web.Panel()
        Me.notification = New Wisej.Web.Ext.Notification.Notification(Me.components)
        Me.flowLayoutPanel.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'flowLayoutPanel
        '
        Me.flowLayoutPanel.AutoSize = True
        Me.flowLayoutPanel.Controls.Add(Me.sortBox1)
        Me.flowLayoutPanel.Controls.Add(Me.sortBox3)
        Me.flowLayoutPanel.Controls.Add(Me.sortBox2)
        Me.flowLayoutPanel.Dock = Wisej.Web.DockStyle.Top
        Me.flowLayoutPanel.Location = New System.Drawing.Point(0, 177)
        Me.flowLayoutPanel.Margin = New Wisej.Web.Padding(7, 0, 7, 0)
        Me.flowLayoutPanel.Name = "flowLayoutPanel"
        Me.flowLayoutPanel.Size = New System.Drawing.Size(972, 746)
        Me.flowLayoutPanel.TabIndex = 7
        Me.flowLayoutPanel.TabStop = True
        '
        'sortBox1
        '
        Me.sortBox1.BackColor = System.Drawing.Color.FromName("@window")
        Me.sortBox1.ForeColor = System.Drawing.Color.Crimson
        Me.sortBox1.Location = New System.Drawing.Point(14, 11)
        Me.sortBox1.Margin = New Wisej.Web.Padding(14, 11, 14, 11)
        Me.sortBox1.Name = "sortBox1"
        Me.sortBox1.Padding = New Wisej.Web.Padding(14, 11, 14, 11)
        Me.sortBox1.Size = New System.Drawing.Size(413, 351)
        Me.sortBox1.TabIndex = 5
        Me.sortBox1.Title = "Bubble Sort"
        '
        'sortBox3
        '
        Me.sortBox3.BackColor = System.Drawing.Color.FromName("@window")
        Me.sortBox3.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.sortBox3.Location = New System.Drawing.Point(455, 11)
        Me.sortBox3.Margin = New Wisej.Web.Padding(14, 11, 14, 11)
        Me.sortBox3.Name = "sortBox3"
        Me.sortBox3.Padding = New Wisej.Web.Padding(14, 11, 14, 11)
        Me.sortBox3.Size = New System.Drawing.Size(413, 351)
        Me.sortBox3.SortMode = BackgroundTasks.SortMode.SelectionSort
        Me.sortBox3.TabIndex = 5
        Me.sortBox3.Title = "Selection Sort"
        '
        'sortBox2
        '
        Me.sortBox2.BackColor = System.Drawing.Color.FromName("@window")
        Me.sortBox2.ForeColor = System.Drawing.Color.SteelBlue
        Me.sortBox2.Location = New System.Drawing.Point(14, 384)
        Me.sortBox2.Margin = New Wisej.Web.Padding(14, 11, 14, 11)
        Me.sortBox2.Name = "sortBox2"
        Me.sortBox2.Padding = New Wisej.Web.Padding(14, 11, 14, 11)
        Me.sortBox2.Size = New System.Drawing.Size(413, 351)
        Me.sortBox2.SortMode = BackgroundTasks.SortMode.QuickSort
        Me.sortBox2.TabIndex = 4
        Me.sortBox2.Title = "Quick Sort"
        '
        'label1
        '
        Me.label1.Dock = Wisej.Web.DockStyle.Top
        Me.label1.Font = New System.Drawing.Font("default", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.label1.Image = Global.BackgroundTasks.My.Resources.Resources._64x64
        Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Margin = New Wisej.Web.Padding(7, 0, 7, 0)
        Me.label1.Name = "label1"
        Me.label1.Padding = New Wisej.Web.Padding(20)
        Me.label1.Size = New System.Drawing.Size(972, 88)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Parallel Sorting"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numericUpDown1
        '
        Me.numericUpDown1.AutoSize = False
        Me.numericUpDown1.Location = New System.Drawing.Point(266, 29)
        Me.numericUpDown1.Margin = New Wisej.Web.Padding(7, 0, 7, 0)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numericUpDown1.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(119, 28)
        Me.numericUpDown1.TabIndex = 10
        Me.numericUpDown1.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.label3.Location = New System.Drawing.Point(14, 12)
        Me.label3.Margin = New Wisej.Web.Padding(7, 0, 7, 0)
        Me.label3.Name = "label3"
        Me.label3.Padding = New Wisej.Web.Padding(20)
        Me.label3.Size = New System.Drawing.Size(238, 64)
        Me.label3.TabIndex = 11
        Me.label3.Text = "Delay between swaps (ms)"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Dock = Wisej.Web.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 88)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(972, 89)
        Me.panel1.TabIndex = 12
        Me.panel1.TabStop = True
        '
        'MainPage
        '
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.None
        Me.AutoScroll = True
        Me.Controls.Add(Me.flowLayoutPanel)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Margin = New Wisej.Web.Padding(7, 0, 7, 0)
        Me.Name = "MainPage"
        Me.Size = New System.Drawing.Size(972, 492)
        Me.flowLayoutPanel.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


#End Region

    Friend WithEvents sortBox1 As SortBox
    Friend WithEvents sortBox2 As SortBox
    Friend WithEvents sortBox3 As SortBox
    Friend WithEvents flowLayoutPanel As Wisej.Web.FlowLayoutPanel
    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents numericUpDown1 As Wisej.Web.NumericUpDown
    Friend WithEvents label3 As Wisej.Web.Label
    Friend WithEvents panel1 As Wisej.Web.Panel
    Friend WithEvents notification As Wisej.Web.Ext.Notification.Notification
End Class

