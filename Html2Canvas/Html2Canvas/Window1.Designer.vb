<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Window1
    Inherits Wisej.Web.Form

    'Overrides dispose to clean up the component list.
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
        Me.Button1 = New Wisej.Web.Button()
        Me.Button2 = New Wisej.Web.Button()
        Me.Button3 = New Wisej.Web.Button()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.Label2 = New Wisej.Web.Label()
        Me.Label = New Wisej.Web.Label()
        Me.Label1 = New Wisej.Web.Label()
        Me.PictureBox1 = New Wisej.Web.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(29, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "print window"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(29, 89)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 43)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "print panel"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(29, 142)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 43)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "print browser"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromName("@text-placeholder")
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label)
        Me.Panel1.Location = New System.Drawing.Point(29, 222)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(439, 301)
        Me.Panel1.TabIndex = 3
        Me.Panel1.TabStop = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(31, 32)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(36, 15)
        Me.Label.TabIndex = 1
        Me.Label.Text = "Label"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(534, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Result"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(534, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(418, 383)
        Me.PictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom
        '
        'Window1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 729)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Window1"
        Me.Text = "HTML2Canvas Sample"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
