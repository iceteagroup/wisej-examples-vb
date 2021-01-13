Namespace DataBinding
    Partial Class MainForm
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

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            textBoxBindingButton = New Windows.Forms.Button()
            dataGridBindingButton = New Windows.Forms.Button()
            allBindingsButton = New Windows.Forms.Button()
            SuspendLayout()
            ' 
            ' textBoxBindingButton
            ' 
            textBoxBindingButton.BackColor = Drawing.Color.SeaGreen
            textBoxBindingButton.Font = New Drawing.Font("default", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
            textBoxBindingButton.ForeColor = Drawing.Color.White
            textBoxBindingButton.Location = New Drawing.Point(72, 90)
            textBoxBindingButton.Name = "textBoxBindingButton"
            textBoxBindingButton.Size = New Drawing.Size(175, 37)
            textBoxBindingButton.TabIndex = 0
            textBoxBindingButton.Text = "Text Box Binding"
            textBoxBindingButton.UseVisualStyleBackColor = False
            AddHandler textBoxBindingButton.Click, New EventHandler(AddressOf textBoxBindingButton_Click)
            ' 
            ' dataGridBindingButton
            ' 
            dataGridBindingButton.BackColor = Drawing.Color.SteelBlue
            dataGridBindingButton.Font = New Drawing.Font("default", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
            dataGridBindingButton.ForeColor = Drawing.Color.White
            dataGridBindingButton.Location = New Drawing.Point(72, 160)
            dataGridBindingButton.Name = "dataGridBindingButton"
            dataGridBindingButton.Size = New Drawing.Size(175, 37)
            dataGridBindingButton.TabIndex = 1
            dataGridBindingButton.Text = "DataGrid Binding"
            dataGridBindingButton.UseVisualStyleBackColor = False
            AddHandler dataGridBindingButton.Click, New EventHandler(AddressOf dataGridBindingButton_Click)
            ' 
            ' allBindingsButton
            ' 
            allBindingsButton.BackColor = Drawing.Color.Orange
            allBindingsButton.Font = New Drawing.Font("default", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
            allBindingsButton.ForeColor = Drawing.Color.White
            allBindingsButton.Location = New Drawing.Point(72, 230)
            allBindingsButton.Name = "allBindingsButton"
            allBindingsButton.Size = New Drawing.Size(175, 37)
            allBindingsButton.TabIndex = 2
            allBindingsButton.Text = "All Bindings"
            allBindingsButton.UseVisualStyleBackColor = False
            AddHandler allBindingsButton.Click, New EventHandler(AddressOf allBindingsButton_Click)
            ' 
            ' MainForm
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(1025, 548)
            Controls.Add(allBindingsButton)
            Controls.Add(dataGridBindingButton)
            Controls.Add(textBoxBindingButton)
            Name = "MainForm"
            Text = "Main Form"
            ResumeLayout(False)
        End Sub

#End Region

        Private textBoxBindingButton As Windows.Forms.Button
        Private dataGridBindingButton As Windows.Forms.Button
        Private allBindingsButton As Windows.Forms.Button
    End Class
End Namespace
