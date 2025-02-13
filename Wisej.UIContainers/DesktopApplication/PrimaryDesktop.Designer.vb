<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrimaryDesktop
    Inherits Wisej.Web.Desktop
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

#Region "Component Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.label1 = New Wisej.Web.Label()
        Me.coolClock1 = New Wisej.Web.Ext.CoolClock.CoolClock()
        Me.button1 = New Wisej.Web.Button()
        Me.button2 = New Wisej.Web.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Dock = Wisej.Web.DockStyle.Top
        Me.label1.Font = New System.Drawing.Font("default", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(869, 84)
        Me.label1.TabIndex = 1
        Me.label1.Text = "P R I M A R Y"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'coolClock1
        '
        Me.coolClock1.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.coolClock1.Location = New System.Drawing.Point(767, 90)
        Me.coolClock1.Name = "coolClock1"
        Me.coolClock1.Text = "coolClock1"
        '
        'button1
        '
        Me.button1.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.button1.BackColor = System.Drawing.Color.FromName("@buttonText")
        Me.button1.ForeColor = System.Drawing.Color.FromName("@buttonFace")
        Me.button1.Location = New System.Drawing.Point(767, 220)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(100, 26)
        Me.button1.TabIndex = 3
        Me.button1.Text = "Click me 1"
        '
        'button2
        '
        Me.button2.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.button2.BackColor = System.Drawing.Color.FromName("@buttonText")
        Me.button2.ForeColor = System.Drawing.Color.FromName("@buttonFace")
        Me.button2.Location = New System.Drawing.Point(767, 270)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(100, 26)
        Me.button2.TabIndex = 4
        Me.button2.Text = "Click me 2"
        '
        'PrimaryDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.coolClock1)
        Me.Controls.Add(Me.label1)
        Me.Name = "PrimaryDesktop"
        Me.Size = New System.Drawing.Size(869, 796)
        Me.Text = "Primary Desktop"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents coolClock1 As Wisej.Web.Ext.CoolClock.CoolClock
    Friend WithEvents button1 As Wisej.Web.Button
    Friend WithEvents button2 As Wisej.Web.Button
End Class
