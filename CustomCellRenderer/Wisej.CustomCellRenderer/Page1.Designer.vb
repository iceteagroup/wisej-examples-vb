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
        Me.dataGridView1 = New Wisej.Web.DataGridView()
        Me.button1 = New Wisej.Web.Button()
        Me.Column0 = New Wisej.Web.DataGridViewColumn()
        Me.Column1 = New Wisej.Web.DataGridViewColumn()
        Me.Column2 = New Wisej.CustomCellRenderer.DataGridViewJSONColumn()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridView1
        '
        Me.dataGridView1.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Column0, Me.Column1, Me.Column2})
        Me.dataGridView1.Location = New System.Drawing.Point(72, 128)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(552, 425)
        Me.dataGridView1.TabIndex = 0
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(72, 35)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(136, 37)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Populate"
        '
        'Column0
        '
        Me.Column0.HeaderText = "Column0"
        Me.Column0.Name = "Column0"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(932, 626)
        Me.Text = "Page1"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


#End Region

    Friend WithEvents dataGridView1 As Web.DataGridView
    Friend WithEvents Column0 As Web.DataGridViewColumn
    Friend WithEvents Column1 As Web.DataGridViewColumn
    Friend WithEvents button1 As Web.Button
    Friend WithEvents Column2 As DataGridViewJSONColumn
End Class
