Namespace Views

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class DashboardView
        Inherits ViewBase
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


#Region "Wisej Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim lineOptions1 As Web.Ext.ChartJS.LineOptions = New Web.Ext.ChartJS.LineOptions()
            flowLayoutPanel = New Web.FlowLayoutPanel()
            salesTargetGage = New Web.Ext.JustGage.JustGage()
            returnsGage = New Web.Ext.JustGage.JustGage()
            salesChart = New Web.Ext.ChartJS.ChartJS()
            flowLayoutPanel.SuspendLayout()
            SuspendLayout()
            ' 
            ' flowLayoutPanel
            ' 
            flowLayoutPanel.AutoScroll = True
            flowLayoutPanel.Controls.Add(salesTargetGage)
            flowLayoutPanel.Controls.Add(returnsGage)
            flowLayoutPanel.Controls.Add(salesChart)
            flowLayoutPanel.Dock = Web.DockStyle.Fill
            flowLayoutPanel.Location = New Drawing.Point(0, 33)
            flowLayoutPanel.Name = "flowLayoutPanel"
            flowLayoutPanel.Size = New Drawing.Size(740, 609)
            flowLayoutPanel.TabIndex = 2
            ' 
            ' salesTargetGage
            ' 
            flowLayoutPanel.SetFillWeight(salesTargetGage, 100)
            salesTargetGage.ForeColor = Drawing.Color.Green
            salesTargetGage.Location = New Drawing.Point(30, 30)
            salesTargetGage.Margin = New Web.Padding(30)
            salesTargetGage.MinimumSize = New Drawing.Size(200, 190)
            salesTargetGage.Name = "salesTargetGage"
            salesTargetGage.Size = New Drawing.Size(310, 196)
            salesTargetGage.Symbol = "%"
            salesTargetGage.TabIndex = 1
            salesTargetGage.Text = "Sales Target"
            salesTargetGage.Value = 0F
            ' 
            ' returnsGage
            ' 
            flowLayoutPanel.SetFillWeight(returnsGage, 100)
            flowLayoutPanel.SetFlowBreak(returnsGage, True)
            returnsGage.ForeColor = Drawing.Color.DarkRed
            returnsGage.Location = New Drawing.Point(400, 30)
            returnsGage.Margin = New Web.Padding(30)
            returnsGage.MinimumSize = New Drawing.Size(200, 190)
            returnsGage.Name = "returnsGage"
            returnsGage.Size = New Drawing.Size(310, 196)
            returnsGage.Symbol = "%"
            returnsGage.TabIndex = 2
            returnsGage.Text = "Returns"
            returnsGage.Value = 0F
            ' 
            ' salesChart
            ' 
            flowLayoutPanel.SetFillWeight(salesChart, 100)
            salesChart.Location = New Drawing.Point(30, 286)
            salesChart.Margin = New Web.Padding(30)
            salesChart.Name = "salesChart"
            salesChart.Options = lineOptions1
            salesChart.Size = New Drawing.Size(680, 329)
            salesChart.TabIndex = 0
            salesChart.Text = "Sales"
            ' 
            ' DashboardView
            ' 
            Controls.Add(flowLayoutPanel)
            Name = "DashboardView"
            Title = "Dashboard"
            Controls.SetChildIndex(flowLayoutPanel, 0)
            flowLayoutPanel.ResumeLayout(False)
            ResumeLayout(False)
        End Sub


#End Region

        Friend WithEvents flowLayoutPanel As Web.FlowLayoutPanel
        Friend WithEvents salesChart As Web.Ext.ChartJS.ChartJS
        Friend WithEvents salesTargetGage As Web.Ext.JustGage.JustGage
        Friend WithEvents returnsGage As Web.Ext.JustGage.JustGage
    End Class
End Namespace
