<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrimaryPage
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
        label1 = New Wisej.Web.Label()
        button1 = New Wisej.Web.Button()
        button2 = New Wisej.Web.Button()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.BackColor = Drawing.Color.LemonChiffon
        label1.Dock = Wisej.Web.DockStyle.Top
        label1.Font = New Drawing.Font("default", 72.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Pixel)
        label1.Location = New Drawing.Point(0, 0)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(1025, 84)
        label1.TabIndex = 1
        label1.Text = "P R I M A R Y"
        label1.TextAlign = Drawing.ContentAlignment.TopRight
        ' 
        ' button1
        ' 
        button1.Anchor = Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right
        button1.BackColor = Drawing.Color.LemonChiffon
        button1.Font = New Drawing.Font("default", 24.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Pixel)
        button1.ForeColor = Drawing.Color.Black
        button1.Location = New Drawing.Point(818, 100)
        button1.Name = "button1"
        button1.Size = New Drawing.Size(200, 50)
        button1.TabIndex = 2
        button1.Text = "Show Windows"
        AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
        ' 
        ' button2
        ' 
        button2.Anchor = Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right
        button2.BackColor = Drawing.Color.LemonChiffon
        button2.Font = New Drawing.Font("default", 18.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Pixel)
        button2.ForeColor = Drawing.Color.Black
        button2.Location = New Drawing.Point(818, 200)
        button2.Name = "button2"
        button2.Size = New Drawing.Size(200, 50)
        button2.TabIndex = 5
        button2.Text = "Click and Update"
        ' 
        ' PrimaryPage
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Controls.Add(button2)
        Controls.Add(button1)
        Controls.Add(label1)
        Name = "PrimaryPage"
        Size = New Drawing.Size(1025, 547)
        Text = "Primary Page"
        AddHandler Load, New EventHandler(AddressOf PrimaryPage_Load)
        ResumeLayout(False)
    End Sub

#End Region

    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents button1 As Wisej.Web.Button
    Friend WithEvents button2 As Wisej.Web.Button
End Class
