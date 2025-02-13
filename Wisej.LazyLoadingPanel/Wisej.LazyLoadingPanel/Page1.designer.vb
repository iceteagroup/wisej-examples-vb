
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
        Me.containerPanel1 = New Wisej.LazyLoadingPanel.ContainerPanel()
        Me.SuspendLayout()
        '
        'containerPanel1
        '
        Me.containerPanel1.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.containerPanel1.Location = New System.Drawing.Point(100, 74)
        Me.containerPanel1.Name = "containerPanel1"
        Me.containerPanel1.Size = New System.Drawing.Size(384, 582)
        Me.containerPanel1.TabIndex = 0
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.containerPanel1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(842, 627)
        Me.Text = "Page1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents containerPanel1 As ContainerPanel
End Class
