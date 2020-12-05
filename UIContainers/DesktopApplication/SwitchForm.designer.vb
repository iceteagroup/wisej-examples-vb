<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SwitchForm
    Inherits Wisej.Web.Form
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
        button1 = New Wisej.Web.Button()
        SuspendLayout()
        ' 
        ' button1
        ' 
        button1.Location = New Drawing.Point(58, 59)
        button1.Name = "button1"
        button1.Size = New Drawing.Size(186, 26)
        button1.TabIndex = 0
        button1.Text = "Switch Desktop"
        AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
        ' 
        ' SwitchForm
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(298, 156)
        ControlBox = False
        Controls.Add(button1)
        Name = "SwitchForm"
        StartPosition = Wisej.Web.FormStartPosition.Manual
        Text = "Switch Form"
        TopMost = True
        ResumeLayout(False)
    End Sub

#End Region

    Friend WithEvents button1 As Wisej.Web.Button
End Class
