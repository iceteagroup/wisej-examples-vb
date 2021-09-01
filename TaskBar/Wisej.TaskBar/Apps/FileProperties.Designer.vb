<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileProperties
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
        Me.PictureBox1 = New PictureBox()
        Me.lblType2 = New Label()
        Me.Panel1 = New Panel()
        Me.txtbxPath = New TextBox()
        Me.Line1 = New Line()
        Me.Label2 = New Label()
        Me.Label3 = New Label()
        Me.Label4 = New Label()
        Me.lblSize = New Label()
        Me.lblPath = New Label()
        Me.lblType = New Label()
        Me.Line2 = New Line()
        Me.lblCreationDate = New Label()
        Me.Label9 = New Label()
        Me.btnOk = New Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ImageSource = "Resources\icons8_file_96px.png"
        Me.PictureBox1.Location = New System.Drawing.Point(46, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        '
        'lblType2
        '
        Me.lblType2.AutoSize = True
        Me.lblType2.Dock = DockStyle.Fill
        Me.lblType2.Font = New System.Drawing.Font("defaultBold", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblType2.Location = New System.Drawing.Point(0, 0)
        Me.lblType2.Name = "lblType2"
        Me.lblType2.ResizableEdges = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
        Me.lblType2.Size = New System.Drawing.Size(136, 24)
        Me.lblType2.TabIndex = 1
        Me.lblType2.Text = "-"
        Me.lblType2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblType2)
        Me.Panel1.Location = New System.Drawing.Point(12, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(136, 24)
        Me.Panel1.TabIndex = 3
        Me.Panel1.TabStop = True
        '
        'txtbxPath
        '
        Me.txtbxPath.Location = New System.Drawing.Point(149, 51)
        Me.txtbxPath.Name = "txtbxPath"
        Me.txtbxPath.Size = New System.Drawing.Size(278, 22)
        Me.txtbxPath.TabIndex = 4
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(29, 120)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(407, 20)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Label4"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(136, 233)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(9, 15)
        Me.lblSize.TabIndex = 11
        Me.lblSize.Text = "-"
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(136, 200)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(9, 15)
        Me.lblPath.TabIndex = 10
        Me.lblPath.Text = "-"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(136, 165)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(9, 15)
        Me.lblType.TabIndex = 9
        Me.lblType.Text = "-"
        '
        'Line2
        '
        Me.Line2.Location = New System.Drawing.Point(29, 285)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(407, 20)
        '
        'lblCreationDate
        '
        Me.lblCreationDate.AutoSize = True
        Me.lblCreationDate.Location = New System.Drawing.Point(136, 320)
        Me.lblCreationDate.Name = "lblCreationDate"
        Me.lblCreationDate.Size = New System.Drawing.Size(9, 15)
        Me.lblCreationDate.TabIndex = 15
        Me.lblCreationDate.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Label9"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(336, 347)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 27)
        Me.btnOk.TabIndex = 16
        Me.btnOk.Text = "OK"
        '
        'FileProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 415)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblCreationDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.txtbxPath)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FileProperties"
        Me.Text = "File Properties"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblType2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtbxPath As TextBox
    Friend WithEvents Line1 As Line
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents lblPath As Label
    Friend WithEvents lblType As Label
    Friend WithEvents Line2 As Line
    Friend WithEvents lblCreationDate As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnOk As Button
End Class
