Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Page1
    Inherits Wisej.Web.Page
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
        Me.smoothieChart1 = New Wisej.Web.Ext.SmoothieChart.SmoothieChart()
        Me.tableLayoutPanel1 = New Wisej.Web.TableLayoutPanel()
        Me.smoothieChart3 = New Wisej.Web.Ext.SmoothieChart.SmoothieChart()
        Me.smoothieChart2 = New Wisej.Web.Ext.SmoothieChart.SmoothieChart()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'smoothieChart1
        '
        Me.smoothieChart1.Dock = Wisej.Web.DockStyle.Fill
        Me.smoothieChart1.Location = New System.Drawing.Point(3, 3)
        Me.smoothieChart1.MaxValue = 100
        Me.smoothieChart1.MinValue = 0
        Me.smoothieChart1.Name = "smoothieChart1"
        Me.smoothieChart1.Size = New System.Drawing.Size(839, 140)
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.smoothieChart1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.smoothieChart3, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.smoothieChart2, 0, 2)
        Me.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 25.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 25.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(845, 586)
        Me.tableLayoutPanel1.TabIndex = 2
        Me.tableLayoutPanel1.TabStop = True
        '
        'smoothieChart3
        '
        Me.smoothieChart3.DataFrequency = 2000
        Me.smoothieChart3.Dock = Wisej.Web.DockStyle.Fill
        Me.smoothieChart3.FontSize = 20
        Me.smoothieChart3.Interpolation = Wisej.Web.Ext.SmoothieChart.InterpolationType.Linear
        Me.smoothieChart3.Location = New System.Drawing.Point(3, 149)
        Me.smoothieChart3.MaxValue = 100
        Me.smoothieChart3.MinValue = 0
        Me.smoothieChart3.Name = "smoothieChart3"
        Me.smoothieChart3.ShowTimeStamps = False
        Me.smoothieChart3.Size = New System.Drawing.Size(839, 140)
        Me.smoothieChart3.VerticalSections = 1
        '
        'smoothieChart2
        '
        Me.smoothieChart2.Dock = Wisej.Web.DockStyle.Fill
        Me.smoothieChart2.FontSize = 13
        Me.smoothieChart2.Interpolation = Wisej.Web.Ext.SmoothieChart.InterpolationType.Linear
        Me.smoothieChart2.Location = New System.Drawing.Point(3, 295)
        Me.smoothieChart2.MaxValue = 1000
        Me.smoothieChart2.MinValue = 0
        Me.smoothieChart2.Name = "smoothieChart2"
        Me.smoothieChart2.Size = New System.Drawing.Size(839, 288)
        Me.smoothieChart2.VerticalSections = 10
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(845, 586)
        Me.Text = "SmoothieChart Sample"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents smoothieChart1 As Wisej.Web.Ext.SmoothieChart.SmoothieChart
    Friend WithEvents tableLayoutPanel1 As Wisej.Web.TableLayoutPanel
    Friend WithEvents smoothieChart2 As Wisej.Web.Ext.SmoothieChart.SmoothieChart
    Friend WithEvents smoothieChart3 As Wisej.Web.Ext.SmoothieChart.SmoothieChart
End Class
