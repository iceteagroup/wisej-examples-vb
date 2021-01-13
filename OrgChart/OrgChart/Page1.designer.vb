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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Page1))
        Dim Package1 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package2 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package3 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Me.widget1 = New Wisej.Web.Widget()
        Me.button1 = New Wisej.Web.Button()
        Me.SuspendLayout()
        '
        'widget1
        '
        Me.widget1.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.widget1.InitScript = resources.GetString("widget1.InitScript")
        Me.widget1.Location = New System.Drawing.Point(136, 137)
        Me.widget1.Name = "widget1"
        Me.widget1.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
        Package1.Integrity = Nothing
        Package1.Name = "jquery.js"
        Package1.Source = "https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"
        Package2.Integrity = Nothing
        Package2.Name = "orgchart.js"
        Package2.Source = "https://rawgit.com/dabeng/OrgChart/master/dist/js/jquery.orgchart.js"
        Package3.Integrity = Nothing
        Package3.Name = "orgchart.css"
        Package3.Source = "https://rawgit.com/dabeng/OrgChart/master/dist/css/jquery.orgchart.css"
        Me.widget1.Packages.Add(Package1)
        Me.widget1.Packages.Add(Package2)
        Me.widget1.Packages.Add(Package3)
        Me.widget1.Size = New System.Drawing.Size(661, 523)
        Me.widget1.TabIndex = 0
        Me.widget1.Text = "widget1"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(141, 53)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(128, 47)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Change Data"
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.widget1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(842, 838)
        Me.Text = "Page1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents widget1 As Widget
    Friend WithEvents button1 As Button
End Class
