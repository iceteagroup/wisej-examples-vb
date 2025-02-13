<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Page1
    Inherits Wisej.Web.Page

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

    'NOTE: The following procedure is required by the Wisej Form Designer
    'It can be modified using the Wisej Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.listBox1 = New Wisej.Web.ListBox()
        Me.button1 = New Wisej.Web.Button()
        Me.button2 = New Wisej.Web.Button()
        Me.SuspendLayout()
        '
        'listBox1
        '
        Me.listBox1.LabelText = "Select a report"
        Me.listBox1.Location = New System.Drawing.Point(36, 46)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(284, 391)
        Me.listBox1.TabIndex = 0
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(36, 458)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(284, 56)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Use PdfReportViewer"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(36, 535)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(284, 56)
        Me.button2.TabIndex = 2
        Me.button2.Text = "Use AspNetReportViewer"
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.button2)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(997, 652)
        Me.Text = "Page1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listBox1 As ListBox
    Friend WithEvents button1 As Button
    Friend WithEvents button2 As Button
End Class
