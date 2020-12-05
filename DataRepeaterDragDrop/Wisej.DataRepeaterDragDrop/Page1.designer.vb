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
        Me.dataRepeater1 = New Wisej.Web.DataRepeater()
        Me.textBox1 = New Wisej.Web.TextBox()
        Me.modelBindingSource = New Wisej.Web.BindingSource(Me.components)
        Me.label1 = New Wisej.Web.Label()
        Me.button1 = New Wisej.Web.Button()
        Me.button2 = New Wisej.Web.Button()
        CType(Me.dataRepeater1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataRepeater1.ItemTemplate.SuspendLayout()
        Me.dataRepeater1.SuspendLayout()
        CType(Me.modelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataRepeater1
        '
        Me.dataRepeater1.AllowDrag = True
        Me.dataRepeater1.AllowDrop = True
        Me.dataRepeater1.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left), Wisej.Web.AnchorStyles)
        Me.dataRepeater1.ItemSize = New System.Drawing.Size(200, 100)
        '
        'dataRepeater1.ItemTemplate
        '
        Me.dataRepeater1.ItemTemplate.Controls.Add(Me.textBox1)
        Me.dataRepeater1.ItemTemplate.Controls.Add(Me.label1)
        Me.dataRepeater1.ItemTemplate.Size = New System.Drawing.Size(393, 100)
        Me.dataRepeater1.Location = New System.Drawing.Point(44, 43)
        Me.dataRepeater1.Name = "dataRepeater1"
        Me.dataRepeater1.Size = New System.Drawing.Size(395, 465)
        Me.dataRepeater1.TabIndex = 0
        Me.dataRepeater1.Text = "dataRepeater1"
        '
        'textBox1
        '
        Me.textBox1.DataBindings.Add(New Wisej.Web.Binding("Text", Me.modelBindingSource, "Name", True))
        Me.textBox1.LabelText = "Name"
        Me.textBox1.Location = New System.Drawing.Point(24, 43)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(331, 42)
        Me.textBox1.TabIndex = 1
        '
        'modelBindingSource
        '
        Me.modelBindingSource.DataSource = GetType(Wisej.DataRepeaterDragDrop.Model)
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.DataBindings.Add(New Wisej.Web.Binding("Text", Me.modelBindingSource, "ID", True))
        Me.label1.Location = New System.Drawing.Point(24, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(39, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "label1"
        '
        'button1
        '
        Me.button1.Display = Wisej.Web.Display.Icon
        Me.button1.Enabled = False
        Me.button1.ImageSource = "icon-up"
        Me.button1.Location = New System.Drawing.Point(465, 44)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(64, 53)
        Me.button1.TabIndex = 1
        Me.button1.Text = "button1"
        '
        'button2
        '
        Me.button2.Display = Wisej.Web.Display.Icon
        Me.button2.Enabled = False
        Me.button2.ImageSource = "icon-down"
        Me.button2.Location = New System.Drawing.Point(465, 123)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(64, 53)
        Me.button2.TabIndex = 2
        Me.button2.Text = "button2"
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.dataRepeater1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(932, 543)
        Me.Text = "Page1"
        Me.dataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.dataRepeater1.ItemTemplate.PerformLayout()
        CType(Me.dataRepeater1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataRepeater1.ResumeLayout(False)
        CType(Me.modelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


#End Region

    Friend WithEvents dataRepeater1 As Web.DataRepeater
    Friend WithEvents textBox1 As Web.TextBox
    Friend WithEvents label1 As Web.Label
    Friend WithEvents modelBindingSource As Web.BindingSource
    Friend WithEvents button1 As Web.Button
    Friend WithEvents button2 As Web.Button
End Class
