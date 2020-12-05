Partial Class SecondaryDesktop
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
        label1 = New Wisej.Web.Label()
        coolClock1 = New Wisej.Web.Ext.CoolClock.CoolClock()
        button1 = New Wisej.Web.Button()
        button2 = New Wisej.Web.Button()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.Dock = Wisej.Web.DockStyle.Top
        label1.Font = New Drawing.Font("default", 72.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Pixel)
        label1.Location = New Drawing.Point(0, 0)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(1025, 84)
        label1.TabIndex = 1
        label1.Text = "S E C O N D A R Y"
        label1.TextAlign = Drawing.ContentAlignment.TopRight
        ' 
        ' coolClock1
        ' 
        coolClock1.Anchor = Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right
        coolClock1.AppearanceKey = "coolclock"
        coolClock1.Location = New Drawing.Point(923, 90)
        coolClock1.Name = "coolClock1"
        coolClock1.Size = New Drawing.Size(100, 100)
        coolClock1.Skin = Wisej.Web.Ext.CoolClock.CoolClockSkin.Classic
        coolClock1.TabIndex = 2
        coolClock1.Text = "coolClock1"
        ' 
        ' button1
        ' 
        button1.Anchor = Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right
        button1.BackColor = Drawing.Color.FromName("@buttonText")
        button1.ForeColor = Drawing.Color.FromName("@buttonFace")
        button1.Location = New Drawing.Point(923, 220)
        button1.Name = "button1"
        button1.Size = New Drawing.Size(100, 26)
        button1.TabIndex = 3
        button1.Text = "Click me 1"
        ' 
        ' button2
        ' 
        button2.Anchor = Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right
        button2.BackColor = Drawing.Color.FromName("@buttonText")
        button2.ForeColor = Drawing.Color.FromName("@buttonFace")
        button2.Location = New Drawing.Point(923, 270)
        button2.Name = "button2"
        button2.Size = New Drawing.Size(100, 26)
        button2.TabIndex = 4
        button2.Text = "Click me 2"
        ' 
        ' SecondaryDesktop
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Controls.Add(button2)
        Controls.Add(button1)
        Controls.Add(coolClock1)
        Controls.Add(label1)
        Name = "SecondaryDesktop"
        Text = "Secondary Desktop"
        Size = New Drawing.Size(1025, 547)
        AddHandler Load, New EventHandler(AddressOf SecondaryDesktop_Load)
        ResumeLayout(False)
    End Sub

#End Region

    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents coolClock1 As Wisej.Web.Ext.CoolClock.CoolClock
    Friend WithEvents button1 As Wisej.Web.Button
    Friend WithEvents button2 As Wisej.Web.Button
End Class
