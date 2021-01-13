Namespace DataBinding

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MainPage
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
            Me.textBoxBindingButton = New Wisej.Web.Button()
            Me.dataGridBindingButton = New Wisej.Web.Button()
            Me.allBindingsButton = New Wisej.Web.Button()
            Me.SuspendLayout()
            '
            'textBoxBindingButton
            '
            Me.textBoxBindingButton.BackColor = System.Drawing.Color.SeaGreen
            Me.textBoxBindingButton.Font = New System.Drawing.Font("default", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.textBoxBindingButton.ForeColor = System.Drawing.Color.White
            Me.textBoxBindingButton.Location = New System.Drawing.Point(72, 90)
            Me.textBoxBindingButton.Name = "textBoxBindingButton"
            Me.textBoxBindingButton.Size = New System.Drawing.Size(175, 37)
            Me.textBoxBindingButton.TabIndex = 0
            Me.textBoxBindingButton.Text = "Text Box Binding"
            '
            'dataGridBindingButton
            '
            Me.dataGridBindingButton.BackColor = System.Drawing.Color.SteelBlue
            Me.dataGridBindingButton.Font = New System.Drawing.Font("default", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.dataGridBindingButton.ForeColor = System.Drawing.Color.White
            Me.dataGridBindingButton.Location = New System.Drawing.Point(72, 160)
            Me.dataGridBindingButton.Name = "dataGridBindingButton"
            Me.dataGridBindingButton.Size = New System.Drawing.Size(175, 37)
            Me.dataGridBindingButton.TabIndex = 1
            Me.dataGridBindingButton.Text = "DataGrid Binding"
            '
            'allBindingsButton
            '
            Me.allBindingsButton.BackColor = System.Drawing.Color.Orange
            Me.allBindingsButton.Font = New System.Drawing.Font("default", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.allBindingsButton.ForeColor = System.Drawing.Color.White
            Me.allBindingsButton.Location = New System.Drawing.Point(72, 230)
            Me.allBindingsButton.Name = "allBindingsButton"
            Me.allBindingsButton.Size = New System.Drawing.Size(175, 37)
            Me.allBindingsButton.TabIndex = 2
            Me.allBindingsButton.Text = "All Bindings"
            '
            'MainPage
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
            Me.Controls.Add(Me.allBindingsButton)
            Me.Controls.Add(Me.dataGridBindingButton)
            Me.Controls.Add(Me.textBoxBindingButton)
            Me.Name = "MainPage"
            Me.Size = New System.Drawing.Size(752, 829)
            Me.Text = "Main Page"
            Me.ResumeLayout(False)

        End Sub

#End Region

        Friend WithEvents textBoxBindingButton As Wisej.Web.Button
        Friend WithEvents dataGridBindingButton As Wisej.Web.Button
        Friend WithEvents allBindingsButton As Wisej.Web.Button
    End Class
End Namespace
