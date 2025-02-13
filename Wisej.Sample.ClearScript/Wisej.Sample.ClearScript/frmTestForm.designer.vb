<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTestForm
    Inherits Wisej.Web.Form
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

#Region "Wisej Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        label1 = New Web.Label()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Drawing.Point(328, 87)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(47, 17)
        label1.TabIndex = 0
        label1.Text = "Label 1"
        ' 
        ' frmTestForm
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 18.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(685, 175)
        Controls.Add(label1)
        Name = "frmTestForm"
        Text = "Test Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

#End Region

    Public label1 As Web.Label
End Class
