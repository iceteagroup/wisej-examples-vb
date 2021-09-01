<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
    Inherits Page

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.btnSimpleWindow = New Button()
        Me.btnFileExplorer = New Button()
        Me.label1 = New Label()
        Me.TaskBar1 = New Ext.TaskBar.TaskBar()
        Me.SuspendLayout()
        '
        'btnSimpleWindow
        '
        Me.btnSimpleWindow.ImageSource = "Resources\icons8_statistics_96px.png"
        Me.btnSimpleWindow.ImageSpacing = 0
        Me.btnSimpleWindow.Location = New System.Drawing.Point(202, 45)
        Me.btnSimpleWindow.Name = "btnSimpleWindow"
        Me.btnSimpleWindow.Padding = New Padding(20)
        Me.btnSimpleWindow.Size = New System.Drawing.Size(150, 130)
        Me.btnSimpleWindow.TabIndex = 4
        Me.btnSimpleWindow.TextImageRelation = TextImageRelation.Overlay
        Me.btnSimpleWindow.ToolTipText = "Simple window"
        '
        'btnFileExplorer
        '
        Me.btnFileExplorer.ImageSource = "Resources\icons8_folder_96px.png"
        Me.btnFileExplorer.ImageSpacing = 0
        Me.btnFileExplorer.Location = New System.Drawing.Point(29, 45)
        Me.btnFileExplorer.Name = "btnFileExplorer"
        Me.btnFileExplorer.Padding = New Padding(20)
        Me.btnFileExplorer.Size = New System.Drawing.Size(150, 130)
        Me.btnFileExplorer.TabIndex = 3
        Me.btnFileExplorer.TextImageRelation = TextImageRelation.Overlay
        Me.btnFileExplorer.ToolTipText = "File Explorer"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Dock = DockStyle.Top
        Me.label1.Font = New System.Drawing.Font("@windowTitle", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Margin = New Padding(13)
        Me.label1.Name = "label1"
        Me.label1.Padding = New Padding(10, 10, 10, 0)
        Me.label1.Size = New System.Drawing.Size(1153, 29)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Apps"
        '
        'TaskBar1
        '
        Me.TaskBar1.Location = New System.Drawing.Point(0, 623)
        Me.TaskBar1.Name = "TaskBar1"
        Me.TaskBar1.Size = New System.Drawing.Size(1153, 48)
        Me.TaskBar1.TabIndex = 7
        Me.TaskBar1.Text = "TaskBar1"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.Controls.Add(Me.TaskBar1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnSimpleWindow)
        Me.Controls.Add(Me.btnFileExplorer)
        Me.Name = "MainPage"
        Me.Size = New System.Drawing.Size(1153, 671)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnSimpleWindow As Button
    Private WithEvents btnFileExplorer As Button
    Private WithEvents label1 As Label
    Friend WithEvents TaskBar1 As Ext.TaskBar.TaskBar
End Class
