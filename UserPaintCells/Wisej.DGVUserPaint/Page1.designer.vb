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
        Me.label1 = New Wisej.Web.Label()
        Me.dataGridView1 = New Wisej.Web.DataGridView()
        Me.Column0 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Column2 = New Wisej.Web.DataGridViewComboBoxColumn()
        Me.Column1 = New Wisej.Web.DataGridViewColumn()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AllowHtml = True
        Me.label1.Location = New System.Drawing.Point(40, 56)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(577, 116)
        Me.label1.TabIndex = 0
        Me.label1.Text = "<span style=""font-size:6em"">User Paint Cells</span>"
        '
        'dataGridView1
        '
        Me.dataGridView1.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.dataGridView1.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Column0, Me.Column2, Me.Column1})
        Me.dataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditOnEnter
        Me.dataGridView1.Location = New System.Drawing.Point(40, 178)
        Me.dataGridView1.MinimumSize = New System.Drawing.Size(200, 350)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(669, 374)
        Me.dataGridView1.TabIndex = 1
        '
        'Column0
        '
        Me.Column0.HeaderText = "Values"
        Me.Column0.Name = "Column0"
        Me.Column0.Width = 300
        '
        'Column2
        '
        Me.Column2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        Me.Column2.HeaderText = "Type"
        Me.Column2.Items.AddRange(New Object() {"Bar", "Area", "Line", "Spline", "Column"})
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Sparkline"
        Me.Column1.MinimumWidth = 100
        Me.Column1.Name = "Column1"
        Me.Column1.UserPaint = True
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom
        Me.BackgroundImageSource = "Images/background.jpg"
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(945, 626)
        Me.Text = "Page1"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


#End Region

    Friend WithEvents label1 As Web.Label
    Friend WithEvents dataGridView1 As Web.DataGridView
    Friend WithEvents Column0 As Web.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As Web.DataGridViewColumn
    Friend WithEvents Column2 As Web.DataGridViewComboBoxColumn
End Class
