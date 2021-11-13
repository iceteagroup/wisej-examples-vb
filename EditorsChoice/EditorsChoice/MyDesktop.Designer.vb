Imports System

Namespace EditorsChoice

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MyDesktop
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
            Me.SuspendLayout()
            '
            'MyDesktop
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
            Me.Name = "MyDesktop"
            Me.Size = New System.Drawing.Size(999, 730)
            Me.ResumeLayout(False)

        End Sub

#End Region
    End Class
End Namespace
