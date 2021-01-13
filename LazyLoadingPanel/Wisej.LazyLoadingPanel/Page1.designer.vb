
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
        containerPanel1 = New ContainerPanel()
        SuspendLayout()
        ' 
        ' containerPanel1
        ' 
        containerPanel1.AutoScroll = True
        containerPanel1.BorderStyle = Web.BorderStyle.Solid
        containerPanel1.Location = New Drawing.Point(100, 74)
        containerPanel1.Name = "containerPanel1"
        containerPanel1.Size = New Drawing.Size(384, 582)
        containerPanel1.TabIndex = 0
        AddHandler containerPanel1.LoadPanels, New EventHandler(AddressOf containerPanel1_LoadPanels)
        ' 
        ' Page1
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        Controls.Add(containerPanel1)
        Name = "Page1"
        Size = New Drawing.Size(1277, 850)
        Text = "Page1"
        ResumeLayout(False)
    End Sub

#End Region

    Friend WithEvents containerPanel1 As ContainerPanel
End Class
