Imports System

Partial Class Window1
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
        Me.btnReport = New Wisej.Web.Button()
        Me.SuspendLayout()
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(56, 53)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(121, 31)
        Me.btnReport.TabIndex = 0
        Me.btnReport.Text = "Report"
        '
        'Window1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 432)
        Me.Controls.Add(Me.btnReport)
        Me.Name = "Window1"
        Me.Text = "Window1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public WithEvents btnReport As Wisej.Web.Button
End Class
