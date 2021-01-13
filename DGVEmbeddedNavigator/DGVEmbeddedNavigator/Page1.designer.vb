Namespace DGVEmbeddedNavigator

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
            Me.buttonEmbeddedBindingNavigator = New Wisej.Web.Button()
            Me.buttonNavigationPanel = New Wisej.Web.Button()
            Me.SuspendLayout()
            '
            'buttonEmbeddedBindingNavigator
            '
            Me.buttonEmbeddedBindingNavigator.Font = New System.Drawing.Font("default", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.buttonEmbeddedBindingNavigator.Location = New System.Drawing.Point(100, 100)
            Me.buttonEmbeddedBindingNavigator.Name = "buttonEmbeddedBindingNavigator"
            Me.buttonEmbeddedBindingNavigator.Size = New System.Drawing.Size(300, 40)
            Me.buttonEmbeddedBindingNavigator.TabIndex = 0
            Me.buttonEmbeddedBindingNavigator.Text = "Embedded BindingNavigator"
            '
            'buttonNavigationPanel
            '
            Me.buttonNavigationPanel.Font = New System.Drawing.Font("default", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.buttonNavigationPanel.Location = New System.Drawing.Point(100, 230)
            Me.buttonNavigationPanel.Name = "buttonNavigationPanel"
            Me.buttonNavigationPanel.Size = New System.Drawing.Size(300, 40)
            Me.buttonNavigationPanel.TabIndex = 1
            Me.buttonNavigationPanel.Text = "Navigation Panel"
            '
            'Page1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
            Me.Controls.Add(Me.buttonNavigationPanel)
            Me.Controls.Add(Me.buttonEmbeddedBindingNavigator)
            Me.Name = "Page1"
            Me.Size = New System.Drawing.Size(854, 838)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Friend WithEvents buttonEmbeddedBindingNavigator As Wisej.Web.Button
        Friend WithEvents buttonNavigationPanel As Wisej.Web.Button
    End Class
End Namespace
