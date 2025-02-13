<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MandelbrotPanel
    Inherits Wisej.Web.UserControl
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
        SuspendLayout()
        ' 
        ' MandelbrotPanel
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6.0F, 17.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        Name = "MandelbrotPanel"
        Size = New Drawing.Size(355, 288)
        AddHandler Paint, New Web.PaintEventHandler(AddressOf MandelbrotPanel_Paint)
        ResumeLayout(False)
    End Sub

#End Region
End Class
