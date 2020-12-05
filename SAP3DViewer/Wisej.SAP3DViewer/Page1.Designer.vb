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
        Me.components = New System.ComponentModel.Container()
        Dim FileSystemProvider1 As Wisej.Core.FileSystemProvider = New Wisej.Core.FileSystemProvider()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Page1))
        Me.button1 = New Wisej.Web.Button()
        Me.openFileDialog = New Wisej.Web.OpenFileDialog(Me.components)
        Me.comboBox1 = New Wisej.Web.ComboBox()
        Me.button2 = New Wisej.Web.Button()
        Me.comboBox2 = New Wisej.Web.ComboBox()
        Me.upload1 = New Wisej.Web.Upload()
        Me.groupBox1 = New Wisej.Web.GroupBox()
        Me.label1 = New Wisej.Web.Label()
        Me.flowLayoutPanel1 = New Wisej.Web.FlowLayoutPanel()
        Me.flexLayoutPanel2 = New Wisej.Web.FlexLayoutPanel()
        Me.widget1 = New Wisej.SAP3DViewer.VdsViewer()
        Me.flexLayoutPanel1 = New Wisej.Web.FlexLayoutPanel()
        Me.groupBox1.SuspendLayout()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.flexLayoutPanel2.SuspendLayout()
        Me.flexLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(3, 101)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(496, 57)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Load Server File"
        '
        'openFileDialog
        '
        Me.openFileDialog.Filter = "VDS (*.vds)|*.vds|All files (*.*)|*.*"
        Me.openFileDialog.InitialDirectory = "Project Files"
        FileSystemProvider1.Name = "Project Files"
        FileSystemProvider1.Root = "~\Samples\"
        Me.openFileDialog.Roots.Add(FileSystemProvider1)
        Me.openFileDialog.Title = "Select a VDS file."
        '
        'comboBox1
        '
        Me.comboBox1.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.comboBox1.AutoSize = False
        Me.comboBox1.DisplayMember = "name"
        Me.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        Me.comboBox1.Enabled = False
        Me.comboBox1.Location = New System.Drawing.Point(16, 34)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(474, 43)
        Me.comboBox1.TabIndex = 2
        Me.comboBox1.ValueMember = "id"
        '
        'button2
        '
        Me.button2.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.button2.Display = Wisej.Web.Display.Icon
        Me.button2.Enabled = False
        Me.button2.ImageSource = "node-closed"
        Me.button2.Location = New System.Drawing.Point(443, 100)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(47, 43)
        Me.button2.TabIndex = 3
        Me.button2.Text = "Play"
        '
        'comboBox2
        '
        Me.comboBox2.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.comboBox2.AutoSize = False
        Me.comboBox2.DisplayMember = "name"
        Me.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        Me.comboBox2.Enabled = False
        Me.comboBox2.Location = New System.Drawing.Point(16, 100)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(421, 43)
        Me.comboBox2.TabIndex = 4
        Me.comboBox2.ValueMember = "id"
        '
        'upload1
        '
        Me.upload1.HideValue = True
        Me.upload1.Location = New System.Drawing.Point(3, 35)
        Me.upload1.Name = "upload1"
        Me.upload1.Size = New System.Drawing.Size(496, 50)
        Me.upload1.TabIndex = 5
        Me.upload1.Text = "Load Client File"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.comboBox2)
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.Controls.Add(Me.comboBox1)
        Me.groupBox1.Location = New System.Drawing.Point(3, 174)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(496, 173)
        Me.groupBox1.TabIndex = 6
        Me.groupBox1.Text = "Play Steps"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(3, 3)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(496, 25)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Drag & Drop a VDS file"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.AutoSize = True
        Me.flowLayoutPanel1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.flowLayoutPanel1.Controls.Add(Me.flexLayoutPanel2)
        Me.flowLayoutPanel1.Controls.Add(Me.flexLayoutPanel1)
        Me.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Top
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(5, 5)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.ResponsiveProfiles.Add(CType(resources.GetObject("flowLayoutPanel1.ResponsiveProfiles"), Wisej.Base.ResponsiveProfile))
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(1016, 647)
        Me.flowLayoutPanel1.TabIndex = 8
        Me.flowLayoutPanel1.TabStop = True
        '
        'flexLayoutPanel2
        '
        Me.flexLayoutPanel2.AutoSize = True
        Me.flexLayoutPanel2.Controls.Add(Me.label1)
        Me.flexLayoutPanel2.Controls.Add(Me.widget1)
        Me.flowLayoutPanel1.SetFillWeight(Me.flexLayoutPanel2, 1)
        Me.flexLayoutPanel2.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical
        Me.flexLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.flexLayoutPanel2.MinimumSize = New System.Drawing.Size(300, 0)
        Me.flexLayoutPanel2.Name = "flexLayoutPanel2"
        Me.flexLayoutPanel2.ResponsiveProfiles.Add(CType(resources.GetObject("flexLayoutPanel2.ResponsiveProfiles"), Wisej.Base.ResponsiveProfile))
        Me.flexLayoutPanel2.ResponsiveProfiles.Add(CType(resources.GetObject("flexLayoutPanel2.ResponsiveProfiles1"), Wisej.Base.ResponsiveProfile))
        Me.flexLayoutPanel2.Size = New System.Drawing.Size(502, 641)
        Me.flexLayoutPanel2.Spacing = 4
        Me.flexLayoutPanel2.TabIndex = 8
        Me.flexLayoutPanel2.TabStop = True
        '
        'widget1
        '
        Me.widget1.AllowDrop = True
        Me.widget1.Location = New System.Drawing.Point(3, 38)
        Me.widget1.Name = "widget1"
        Me.widget1.ResponsiveProfiles.Add(CType(resources.GetObject("widget1.ResponsiveProfiles"), Wisej.Base.ResponsiveProfile))
        Me.widget1.ResponsiveProfiles.Add(CType(resources.GetObject("widget1.ResponsiveProfiles1"), Wisej.Base.ResponsiveProfile))
        Me.widget1.Size = New System.Drawing.Size(496, 600)
        Me.widget1.TabIndex = 0
        Me.widget1.Text = "widget1"
        '
        'flexLayoutPanel1
        '
        Me.flexLayoutPanel1.AutoSize = True
        Me.flexLayoutPanel1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.flexLayoutPanel1.Controls.Add(Me.upload1)
        Me.flexLayoutPanel1.Controls.Add(Me.button1)
        Me.flexLayoutPanel1.Controls.Add(Me.groupBox1)
        Me.flexLayoutPanel1.CssStyle = "transition:top 150ms, left 150ms"
        Me.flowLayoutPanel1.SetFillWeight(Me.flexLayoutPanel1, 1)
        Me.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical
        Me.flexLayoutPanel1.Location = New System.Drawing.Point(511, 3)
        Me.flexLayoutPanel1.MinimumSize = New System.Drawing.Size(300, 0)
        Me.flexLayoutPanel1.Name = "flexLayoutPanel1"
        Me.flexLayoutPanel1.Padding = New Wisej.Web.Padding(0, 32, 0, 0)
        Me.flexLayoutPanel1.Size = New System.Drawing.Size(502, 350)
        Me.flexLayoutPanel1.TabIndex = 9
        Me.flexLayoutPanel1.TabStop = True
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.flowLayoutPanel1)
        Me.Name = "Page1"
        Me.Padding = New Wisej.Web.Padding(5)
        Me.ResponsiveProfiles.Add(CType(resources.GetObject("$this.ResponsiveProfiles"), Wisej.Base.ResponsiveProfile))
        Me.ResponsiveProfiles.Add(CType(resources.GetObject("$this.ResponsiveProfiles1"), Wisej.Base.ResponsiveProfile))
        Me.Size = New System.Drawing.Size(1026, 569)
        Me.Text = "Page1"
        Me.groupBox1.ResumeLayout(False)
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.flowLayoutPanel1.PerformLayout()
        Me.flexLayoutPanel2.ResumeLayout(False)
        Me.flexLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


#End Region

    Friend WithEvents widget1 As VdsViewer
    Friend WithEvents button1 As Web.Button
    Friend WithEvents openFileDialog As Web.OpenFileDialog
    Friend WithEvents comboBox1 As Web.ComboBox
    Friend WithEvents button2 As Web.Button
    Friend WithEvents comboBox2 As Web.ComboBox
    Friend WithEvents upload1 As Web.Upload
    Friend WithEvents groupBox1 As Web.GroupBox
    Friend WithEvents label1 As Web.Label
    Friend WithEvents flowLayoutPanel1 As Web.FlowLayoutPanel
    Friend WithEvents flexLayoutPanel2 As Web.FlexLayoutPanel
    Friend WithEvents flexLayoutPanel1 As Web.FlexLayoutPanel
End Class
