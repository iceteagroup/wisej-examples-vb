Imports System

Namespace Views
    Partial Class frmReport
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
            ucReport11 = New ucReport1()
            SuspendLayout()
            ' 
            ' ucReport11
            ' 
            ucReport11.Dock = Wisej.Web.DockStyle.Fill
            ucReport11.Name = "ucReport11"
            ucReport11.Size = New Drawing.Size(795, 537)
            ucReport11.TabIndex = 0
            ' 
            ' frmReport
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
            AutoScaleMode = Wisej.Web.AutoScaleMode.Font
            ClientSize = New Drawing.Size(795, 537)
            Controls.Add(ucReport11)
            Name = "frmReport"
            Text = "frmReport"
            ResumeLayout(False)
        End Sub

#End Region

        Private ucReport11 As ucReport1
    End Class
End Namespace
