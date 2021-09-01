<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolderProperties
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
        Me.btnOk = New Button()
        Me.lblCreationDate = New Label()
        Me.Label9 = New Label()
        Me.Line2 = New Line()
        Me.lblSize = New Label()
        Me.lblPath = New Label()
        Me.lblType = New Label()
        Me.Label4 = New Label()
        Me.Label3 = New Label()
        Me.Type = New Label()
        Me.Line1 = New Line()
        Me.txtbxPath = New TextBox()
        Me.PictureBox1 = New PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(340, 362)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 27)
        Me.btnOk.TabIndex = 30
        Me.btnOk.Text = "OK"
        '
        'lblCreationDate
        '
        Me.lblCreationDate.AutoSize = True
        Me.lblCreationDate.Location = New System.Drawing.Point(140, 335)
        Me.lblCreationDate.Name = "lblCreationDate"
        Me.lblCreationDate.Size = New System.Drawing.Size(9, 15)
        Me.lblCreationDate.TabIndex = 29
        Me.lblCreationDate.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 15)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Creation date"
        '
        'Line2
        '
        Me.Line2.Location = New System.Drawing.Point(33, 300)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(407, 20)
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(140, 248)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(9, 15)
        Me.lblSize.TabIndex = 27
        Me.lblSize.Text = "-"
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(140, 215)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(9, 15)
        Me.lblPath.TabIndex = 26
        Me.lblPath.Text = "-"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(140, 180)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(41, 15)
        Me.lblType.TabIndex = 25
        Me.lblType.Text = "Folder"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Path"
        '
        'Type
        '
        Me.Type.AutoSize = True
        Me.Type.Location = New System.Drawing.Point(33, 178)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(33, 15)
        Me.Type.TabIndex = 22
        Me.Type.Text = "Type"
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(33, 135)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(407, 20)
        '
        'txtbxPath
        '
        Me.txtbxPath.Location = New System.Drawing.Point(153, 66)
        Me.txtbxPath.Name = "txtbxPath"
        Me.txtbxPath.Size = New System.Drawing.Size(278, 22)
        Me.txtbxPath.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.ImageSource = "Resources\icons8_file_96px.png"
        Me.PictureBox1.Location = New System.Drawing.Point(50, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        '
        'FolderProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 424)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblCreationDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.txtbxPath)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FolderProperties"
        Me.Text = "FolderProperties"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOk As Button
    Friend WithEvents lblCreationDate As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Line2 As Line
    Friend WithEvents lblSize As Label
    Friend WithEvents lblPath As Label
    Friend WithEvents lblType As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Type As Label
    Friend WithEvents Line1 As Line
    Friend WithEvents txtbxPath As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
