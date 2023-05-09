Imports System


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.textBox1 = New Wisej.Web.TextBox()
        Me.title = New Wisej.Web.Label()
        Me.url = New Wisej.Web.Label()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(30, 60)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ReadOnly = True
        Me.textBox1.Size = New System.Drawing.Size(870, 564)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("default", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.title.Location = New System.Drawing.Point(30, 20)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(178, 28)
        Me.title.TabIndex = 1
        Me.title.Text = "ChangedNames"
        '
        'url
        '
        Me.url.Location = New System.Drawing.Point(539, 30)
        Me.url.Name = "url"
        Me.url.Size = New System.Drawing.Size(361, 16)
        Me.url.TabIndex = 2
        Me.url.Text = "url"
        Me.url.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.url)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "MainPage"
        Me.Size = New System.Drawing.Size(662, 522)
        Me.Text = "Main Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents textBox1 As Wisej.Web.TextBox
        Friend WithEvents title As Wisej.Web.Label
        Friend WithEvents url As Wisej.Web.Label
    End Class
