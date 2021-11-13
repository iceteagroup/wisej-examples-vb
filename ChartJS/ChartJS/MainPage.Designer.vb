
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.flowLayoutPanel1 = New Wisej.Web.FlowLayoutPanel()
        Me.chartJS1 = New Wisej.Web.Ext.ChartJS.ChartJS()
        Me.chartJS2 = New Wisej.Web.Ext.ChartJS.ChartJS()
        Me.chartJS4 = New Wisej.Web.Ext.ChartJS.ChartJS()
        Me.chartJS6 = New Wisej.Web.Ext.ChartJS.ChartJS()
        Me.chartJS5 = New Wisej.Web.Ext.ChartJS.ChartJS()
        Me.chartJS3 = New Wisej.Web.Ext.ChartJS.ChartJS()
        Me.flowLayoutPanel2 = New Wisej.Web.FlowLayoutPanel()
        Me.button1 = New Wisej.Web.Button()
        Me.panel1 = New Wisej.Web.Panel()
        Me.label1 = New Wisej.Web.Label()
        Me.trackBar = New Wisej.Web.TrackBar()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.flowLayoutPanel2.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.trackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.flowLayoutPanel1.AutoSize = True
        Me.flowLayoutPanel1.Controls.Add(Me.chartJS1)
        Me.flowLayoutPanel1.Controls.Add(Me.chartJS2)
        Me.flowLayoutPanel1.Controls.Add(Me.chartJS4)
        Me.flowLayoutPanel1.Controls.Add(Me.chartJS6)
        Me.flowLayoutPanel1.Controls.Add(Me.chartJS5)
        Me.flowLayoutPanel1.Controls.Add(Me.chartJS3)
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(67, 241)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(1228, 960)
        Me.flowLayoutPanel1.TabIndex = 15
        Me.flowLayoutPanel1.TabStop = True
        '
        'chartJS1
        '
        Me.chartJS1.AppearanceKey = "chartjs"
        Me.flowLayoutPanel1.SetFillWeight(Me.chartJS1, 100)
        Me.chartJS1.Labels = New String() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        Me.chartJS1.Location = New System.Drawing.Point(10, 10)
        Me.chartJS1.Margin = New Wisej.Web.Padding(10)
        Me.chartJS1.MinimumSize = New System.Drawing.Size(300, 300)
        Me.chartJS1.Name = "chartJS1"
        Me.chartJS1.Options.Legend.Display = False
        Me.chartJS1.Size = New System.Drawing.Size(594, 300)
        Me.chartJS1.TabIndex = 3
        Me.chartJS1.Text = "Line Chart"
        '
        'chartJS2
        '
        Me.chartJS2.AppearanceKey = "chartjs"
        Me.chartJS2.ChartType = Wisej.Web.Ext.ChartJS.ChartType.Bar
        Me.flowLayoutPanel1.SetFillWeight(Me.chartJS2, 100)
        Me.flowLayoutPanel1.SetFlowBreak(Me.chartJS2, True)
        Me.chartJS2.Labels = New String() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        Me.chartJS2.Location = New System.Drawing.Point(624, 10)
        Me.chartJS2.Margin = New Wisej.Web.Padding(10)
        Me.chartJS2.MinimumSize = New System.Drawing.Size(300, 300)
        Me.chartJS2.Name = "chartJS2"
        Me.chartJS2.Options.Title.Text = "Bar Chart"
        Me.chartJS2.Size = New System.Drawing.Size(594, 300)
        Me.chartJS2.TabIndex = 4
        Me.chartJS2.Text = "Bar Chart"
        '
        'chartJS4
        '
        Me.chartJS4.AppearanceKey = "chartjs"
        Me.chartJS4.ChartType = Wisej.Web.Ext.ChartJS.ChartType.Radar
        Me.flowLayoutPanel1.SetFillWeight(Me.chartJS4, 100)
        Me.chartJS4.Labels = New String() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        Me.chartJS4.Location = New System.Drawing.Point(10, 330)
        Me.chartJS4.Margin = New Wisej.Web.Padding(10)
        Me.chartJS4.MinimumSize = New System.Drawing.Size(200, 200)
        Me.chartJS4.Name = "chartJS4"
        Me.chartJS4.Size = New System.Drawing.Size(287, 300)
        Me.chartJS4.TabIndex = 6
        Me.chartJS4.Text = "Radar Chart"
        '
        'chartJS6
        '
        Me.chartJS6.AppearanceKey = "chartjs"
        Me.chartJS6.ChartType = Wisej.Web.Ext.ChartJS.ChartType.PolarArea
        Me.flowLayoutPanel1.SetFillWeight(Me.chartJS6, 100)
        Me.chartJS6.Labels = New String() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        Me.chartJS6.Location = New System.Drawing.Point(317, 330)
        Me.chartJS6.Margin = New Wisej.Web.Padding(10)
        Me.chartJS6.MinimumSize = New System.Drawing.Size(200, 200)
        Me.chartJS6.Name = "chartJS6"
        Me.chartJS6.Options.Legend.Display = False
        Me.chartJS6.Size = New System.Drawing.Size(287, 300)
        Me.chartJS6.TabIndex = 8
        Me.chartJS6.Text = "Polar Area Chart"
        '
        'chartJS5
        '
        Me.chartJS5.AppearanceKey = "chartjs"
        Me.chartJS5.ChartType = Wisej.Web.Ext.ChartJS.ChartType.Doughnut
        Me.flowLayoutPanel1.SetFillWeight(Me.chartJS5, 100)
        Me.chartJS5.Labels = New String() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        Me.chartJS5.Location = New System.Drawing.Point(624, 330)
        Me.chartJS5.Margin = New Wisej.Web.Padding(10)
        Me.chartJS5.MinimumSize = New System.Drawing.Size(200, 200)
        Me.chartJS5.Name = "chartJS5"
        Me.chartJS5.Options.Legend.Display = False
        Me.chartJS5.Options.Title.Text = "Doughnut Chart"
        Me.chartJS5.Size = New System.Drawing.Size(287, 300)
        Me.chartJS5.TabIndex = 7
        Me.chartJS5.Text = "Doughnut Chart"
        '
        'chartJS3
        '
        Me.chartJS3.AppearanceKey = "chartjs"
        Me.chartJS3.ChartType = Wisej.Web.Ext.ChartJS.ChartType.Pie
        Me.flowLayoutPanel1.SetFillWeight(Me.chartJS3, 100)
        Me.chartJS3.Labels = New String() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        Me.chartJS3.Location = New System.Drawing.Point(931, 330)
        Me.chartJS3.Margin = New Wisej.Web.Padding(10)
        Me.chartJS3.MinimumSize = New System.Drawing.Size(200, 200)
        Me.chartJS3.Name = "chartJS3"
        Me.chartJS3.Options.Legend.Display = False
        Me.chartJS3.Size = New System.Drawing.Size(287, 300)
        Me.chartJS3.TabIndex = 5
        Me.chartJS3.Text = "Pie Chart"
        '
        'flowLayoutPanel2
        '
        Me.flowLayoutPanel2.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.flowLayoutPanel2.Controls.Add(Me.button1)
        Me.flowLayoutPanel2.Controls.Add(Me.panel1)
        Me.flowLayoutPanel2.Location = New System.Drawing.Point(67, 40)
        Me.flowLayoutPanel2.Name = "flowLayoutPanel2"
        Me.flowLayoutPanel2.Padding = New Wisej.Web.Padding(0, 15, 0, 0)
        Me.flowLayoutPanel2.Size = New System.Drawing.Size(1199, 169)
        Me.flowLayoutPanel2.TabIndex = 16
        Me.flowLayoutPanel2.TabStop = True
        Me.flowLayoutPanel2.WrapContents = False
        '
        'button1
        '
        Me.button1.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.button1.AppearanceKey = "button-ok"
        Me.flowLayoutPanel2.SetFillWeight(Me.button1, 100)
        Me.button1.Font = New System.Drawing.Font("default", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.button1.Location = New System.Drawing.Point(3, 18)
        Me.button1.Margin = New Wisej.Web.Padding(3, 3, 20, 3)
        Me.button1.MinimumSize = New System.Drawing.Size(150, 0)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(730, 128)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Randomize"
        '
        'panel1
        '
        Me.panel1.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.trackBar)
        Me.panel1.Location = New System.Drawing.Point(756, 18)
        Me.panel1.MaximumSize = New System.Drawing.Size(440, 128)
        Me.panel1.MinimumSize = New System.Drawing.Size(440, 128)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(440, 128)
        Me.panel1.TabIndex = 13
        Me.panel1.TabStop = True
        '
        'label1
        '
        Me.label1.AllowHtml = True
        Me.label1.Location = New System.Drawing.Point(12, 3)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(401, 82)
        Me.label1.TabIndex = 10
        Me.label1.Text = resources.GetString("label1.Text")
        '
        'trackBar
        '
        Me.trackBar.Location = New System.Drawing.Point(26, 86)
        Me.trackBar.Maximum = 5000
        Me.trackBar.Name = "trackBar"
        Me.trackBar.Size = New System.Drawing.Size(387, 34)
        Me.trackBar.TabIndex = 11
        Me.trackBar.TickFrequency = 200
        Me.trackBar.TickStyle = Wisej.Web.TickStyle.None
        Me.trackBar.Value = 300
        '
        'MainPage
        '
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.None
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 50)
        Me.Controls.Add(Me.flowLayoutPanel2)
        Me.Controls.Add(Me.flowLayoutPanel1)
        Me.Font = New System.Drawing.Font("default", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Margin = New Wisej.Web.Padding(7, 0, 7, 0)
        Me.Name = "MainPage"
        Me.Size = New System.Drawing.Size(1264, 796)
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.flowLayoutPanel2.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.trackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


#End Region

    Friend WithEvents flowLayoutPanel1 As Wisej.Web.FlowLayoutPanel
    Friend WithEvents chartJS1 As Wisej.Web.Ext.ChartJS.ChartJS
    Friend WithEvents chartJS2 As Wisej.Web.Ext.ChartJS.ChartJS
    Friend WithEvents chartJS4 As Wisej.Web.Ext.ChartJS.ChartJS
    Friend WithEvents chartJS6 As Wisej.Web.Ext.ChartJS.ChartJS
    Friend WithEvents chartJS5 As Wisej.Web.Ext.ChartJS.ChartJS
    Friend WithEvents chartJS3 As Wisej.Web.Ext.ChartJS.ChartJS
    Friend WithEvents flowLayoutPanel2 As Wisej.Web.FlowLayoutPanel
    Friend WithEvents button1 As Wisej.Web.Button
    Friend WithEvents panel1 As Wisej.Web.Panel
    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents trackBar As Wisej.Web.TrackBar
End Class

