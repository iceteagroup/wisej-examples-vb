
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ColorSlider
    Inherits Wisej.Web.UserControl
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
        Me.tableLayoutPanel1 = New Wisej.Web.TableLayoutPanel()
        Me.trackBarAll = New Wisej.Web.TrackBar()
        Me.trackBarB = New Wisej.Web.TrackBar()
        Me.trackBarG = New Wisej.Web.TrackBar()
        Me.trackBarR = New Wisej.Web.TrackBar()
        Me.tableLayoutPanel1.SuspendLayout()
        CType(Me.trackBarAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBarB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBarG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBarR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 4
        Me.tableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.trackBarAll, 3, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.trackBarB, 2, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.trackBarG, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.trackBarR, 0, 0)
        Me.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 1
        Me.tableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(350, 275)
        Me.tableLayoutPanel1.TabIndex = 0
        Me.tableLayoutPanel1.TabStop = True
        '
        'trackBarAll
        '
        Me.trackBarAll.AutoSize = False
        Me.trackBarAll.Dock = Wisej.Web.DockStyle.Fill
        Me.trackBarAll.Location = New System.Drawing.Point(264, 3)
        Me.trackBarAll.Maximum = 255
        Me.trackBarAll.Name = "trackBarAll"
        Me.trackBarAll.Orientation = Wisej.Web.Orientation.Vertical
        Me.trackBarAll.Size = New System.Drawing.Size(83, 269)
        Me.trackBarAll.TabIndex = 6
        Me.trackBarAll.TickStyle = Wisej.Web.TickStyle.None
        Me.trackBarAll.Value = 100
        '
        'trackBarB
        '
        Me.trackBarB.AutoSize = False
        Me.trackBarB.BackColor = System.Drawing.Color.Blue
        Me.trackBarB.Dock = Wisej.Web.DockStyle.Fill
        Me.trackBarB.Location = New System.Drawing.Point(177, 3)
        Me.trackBarB.Maximum = 255
        Me.trackBarB.Name = "trackBarB"
        Me.trackBarB.Orientation = Wisej.Web.Orientation.Vertical
        Me.trackBarB.Size = New System.Drawing.Size(81, 269)
        Me.trackBarB.TabIndex = 4
        Me.trackBarB.TickStyle = Wisej.Web.TickStyle.None
        Me.trackBarB.Value = 100
        '
        'trackBarG
        '
        Me.trackBarG.AutoSize = False
        Me.trackBarG.BackColor = System.Drawing.Color.Green
        Me.trackBarG.Dock = Wisej.Web.DockStyle.Fill
        Me.trackBarG.Location = New System.Drawing.Point(90, 3)
        Me.trackBarG.Maximum = 255
        Me.trackBarG.Name = "trackBarG"
        Me.trackBarG.Orientation = Wisej.Web.Orientation.Vertical
        Me.trackBarG.Size = New System.Drawing.Size(81, 269)
        Me.trackBarG.TabIndex = 2
        Me.trackBarG.TickStyle = Wisej.Web.TickStyle.None
        Me.trackBarG.Value = 100
        '
        'trackBarR
        '
        Me.trackBarR.AutoSize = False
        Me.trackBarR.BackColor = System.Drawing.Color.Red
        Me.trackBarR.Dock = Wisej.Web.DockStyle.Fill
        Me.trackBarR.Location = New System.Drawing.Point(3, 3)
        Me.trackBarR.Maximum = 255
        Me.trackBarR.Name = "trackBarR"
        Me.trackBarR.Orientation = Wisej.Web.Orientation.Vertical
        Me.trackBarR.Size = New System.Drawing.Size(81, 269)
        Me.trackBarR.TabIndex = 0
        Me.trackBarR.TickStyle = Wisej.Web.TickStyle.None
        Me.trackBarR.Value = 100
        '
        'ColorSlider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "ColorSlider"
        Me.Size = New System.Drawing.Size(350, 275)
        Me.tableLayoutPanel1.ResumeLayout(False)
        CType(Me.trackBarAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBarB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBarG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBarR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


#End Region

    Friend WithEvents tableLayoutPanel1 As Wisej.Web.TableLayoutPanel
    Friend WithEvents trackBarAll As Wisej.Web.TrackBar
    Friend WithEvents trackBarB As Wisej.Web.TrackBar
    Friend WithEvents trackBarG As Wisej.Web.TrackBar
    Friend WithEvents trackBarR As Wisej.Web.TrackBar
End Class
