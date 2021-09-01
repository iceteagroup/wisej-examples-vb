<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FileExplorer
    Inherits Form

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.Panel2 = New Panel()
        Me.btnGo = New Button()
        Me.btnParentFolder = New Button()
        Me.txtbxCurrentPath = New TextBox()
        Me.Label1 = New Label()
        Me.list = New ListView()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnGo)
        Me.Panel2.Controls.Add(Me.btnParentFolder)
        Me.Panel2.Controls.Add(Me.txtbxCurrentPath)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1378, 100)
        Me.Panel2.TabIndex = 0
        Me.Panel2.TabStop = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(1254, 66)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(100, 27)
        Me.btnGo.TabIndex = 3
        Me.btnGo.Text = "Go"
        '
        'btnParentFolder
        '
        Me.btnParentFolder.Location = New System.Drawing.Point(21, 66)
        Me.btnParentFolder.Name = "btnParentFolder"
        Me.btnParentFolder.Size = New System.Drawing.Size(100, 27)
        Me.btnParentFolder.TabIndex = 2
        Me.btnParentFolder.Text = "Parent folder"
        '
        'txtbxCurrentPath
        '
        Me.txtbxCurrentPath.Location = New System.Drawing.Point(22, 22)
        Me.txtbxCurrentPath.Name = "txtbxCurrentPath"
        Me.txtbxCurrentPath.Size = New System.Drawing.Size(1332, 22)
        Me.txtbxCurrentPath.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Each item has a MenuContext"
        '
        'list
        '
        Me.list.Dock = DockStyle.Fill
        Me.list.Location = New System.Drawing.Point(0, 100)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(1378, 511)
        Me.list.TabIndex = 1
        Me.list.View = View.Tile
        '
        'FileExplorer
        '
        Me.ClientSize = New System.Drawing.Size(1378, 611)
        Me.Controls.Add(Me.list)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FileExplorer"
        Me.Text = "File Explorer"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGo As Button
    Friend WithEvents btnParentFolder As Button
    Friend WithEvents txtbxCurrentPath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents list As ListView
End Class
