Imports System

Namespace ChangedNames

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
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainPage))
            textBox1 = New Wisej.Web.TextBox()
            title = New Wisej.Web.Label()
            url = New Wisej.Web.Label()
            SuspendLayout()
            ' 
            ' textBox1
            ' 
            textBox1.Location = New Drawing.Point(30, 60)
            textBox1.Multiline = True
            textBox1.Name = "textBox1"
            textBox1.ReadOnly = True
            textBox1.Size = New Drawing.Size(870, 564)
            textBox1.TabIndex = 0
            textBox1.Text = resources.GetString("textBox1.Text")
            ' 
            ' title
            ' 
            title.AutoSize = True
            title.Font = New Drawing.Font("default", 24.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Pixel)
            title.Location = New Drawing.Point(30, 20)
            title.Name = "title"
            title.Size = New Drawing.Size(190, 30)
            title.TabIndex = 1
            title.Text = "ChangedNames"
            ' 
            ' url
            ' 
            url.Location = New Drawing.Point(539, 30)
            url.Name = "url"
            url.Size = New Drawing.Size(361, 16)
            url.TabIndex = 2
            url.Text = "url"
            url.TextAlign = Drawing.ContentAlignment.TopRight
            ' 
            ' MainPage
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
            AutoScaleMode = Wisej.Web.AutoScaleMode.Font
            Controls.Add(url)
            Controls.Add(title)
            Controls.Add(textBox1)
            Name = "MainPage"
            Size = New Drawing.Size(941, 804)
            Text = "Main Page"
            AddHandler Load, New EventHandler(AddressOf MainPage_Load)
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region

        Friend WithEvents textBox1 As Wisej.Web.TextBox
        Friend WithEvents title As Wisej.Web.Label
        Friend WithEvents url As Wisej.Web.Label
    End Class
End Namespace
