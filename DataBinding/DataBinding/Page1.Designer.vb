<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Page1
    Inherits Wisej.Web.Page

    'Overrides dispose to clean up the component list.
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Form Designer
    'It can be modified using the Wisej Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Page1
        '
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 432)
        Me.Name = "Page1"
        Me.Text = "Page1"
        Me.ResumeLayout(False)

    End Sub

End Class
