<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Workspace
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
        Me.backButton = New Wisej.Web.Button()
        Me.dataGridView1 = New Wisej.Web.DataGridView()
        Me.Column0 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Column1 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Column2 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Column3 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Column4 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.errorButton = New Wisej.Web.Button()
        Me.usernameLabel = New Wisej.Web.Label()
        Me.newWorkspace = New Wisej.Web.Button()
        Me.workspaceLabel = New Wisej.Web.Label()
        Me.label3 = New Wisej.Web.Label()
        Me.label2 = New Wisej.Web.Label()
        Me.customerName = New Wisej.Web.TextBox()
        Me.settingsButton = New Wisej.Web.Button()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.label1.Location = New System.Drawing.Point(150, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(60, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "User:"
        '
        'backButton
        '
        Me.backButton.DialogResult = Wisej.Web.DialogResult.Cancel
        Me.backButton.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.backButton.Location = New System.Drawing.Point(150, 455)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(200, 40)
        Me.backButton.TabIndex = 1
        Me.backButton.Text = "Back to Main Page"
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = True
        Me.dataGridView1.AllowUserToDeleteRows = True
        Me.dataGridView1.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.dataGridView1.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Column0, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dataGridView1.Location = New System.Drawing.Point(150, 100)
        Me.dataGridView1.MinimumSize = New System.Drawing.Size(670, 325)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(670, 325)
        Me.dataGridView1.TabIndex = 2
        '
        'Column0
        '
        Me.Column0.FillWeight = 50.0!
        Me.Column0.HeaderText = "Nr."
        Me.Column0.Name = "Column0"
        Me.Column0.Width = 50
        '
        'Column1
        '
        Me.Column1.FillWeight = 200.0!
        Me.Column1.HeaderText = "Name"
        Me.Column1.MinimumWidth = 50
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.FillWeight = 200.0!
        Me.Column2.HeaderText = "Address"
        Me.Column2.MinimumWidth = 50
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.FillWeight = 50.0!
        Me.Column3.HeaderText = "Zip"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 50
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Country"
        Me.Column4.MinimumWidth = 20
        Me.Column4.Name = "Column4"
        '
        'errorButton
        '
        Me.errorButton.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.errorButton.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.errorButton.Location = New System.Drawing.Point(527, 534)
        Me.errorButton.Name = "errorButton"
        Me.errorButton.Size = New System.Drawing.Size(200, 40)
        Me.errorButton.TabIndex = 3
        Me.errorButton.Text = "Error"
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.usernameLabel.Location = New System.Drawing.Point(268, 25)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(80, 19)
        Me.usernameLabel.TabIndex = 4
        Me.usernameLabel.Text = "username"
        '
        'newWorkspace
        '
        Me.newWorkspace.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.newWorkspace.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.newWorkspace.Location = New System.Drawing.Point(527, 455)
        Me.newWorkspace.Name = "newWorkspace"
        Me.newWorkspace.Size = New System.Drawing.Size(200, 40)
        Me.newWorkspace.TabIndex = 5
        Me.newWorkspace.Text = "New Workspace"
        '
        'workspaceLabel
        '
        Me.workspaceLabel.AutoSize = True
        Me.workspaceLabel.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.workspaceLabel.Location = New System.Drawing.Point(268, 60)
        Me.workspaceLabel.Name = "workspaceLabel"
        Me.workspaceLabel.Size = New System.Drawing.Size(87, 19)
        Me.workspaceLabel.TabIndex = 7
        Me.workspaceLabel.Text = "workspace"
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.label3.Location = New System.Drawing.Point(150, 60)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(112, 25)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Workspace:"
        '
        'label2
        '
        Me.label2.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.label2.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.label2.Location = New System.Drawing.Point(557, 25)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 25)
        Me.label2.TabIndex = 8
        Me.label2.Text = "Customer"
        '
        'customerName
        '
        Me.customerName.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.customerName.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.customerName.Location = New System.Drawing.Point(557, 60)
        Me.customerName.Name = "customerName"
        Me.customerName.Size = New System.Drawing.Size(170, 22)
        Me.customerName.TabIndex = 9
        Me.customerName.Text = "Joe Bloggs"
        '
        'settingsButton
        '
        Me.settingsButton.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.settingsButton.Location = New System.Drawing.Point(150, 534)
        Me.settingsButton.Name = "settingsButton"
        Me.settingsButton.Size = New System.Drawing.Size(200, 40)
        Me.settingsButton.TabIndex = 10
        Me.settingsButton.Text = "Settings"
        '
        'Workspace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.CancelButton = Me.backButton
        Me.Controls.Add(Me.settingsButton)
        Me.Controls.Add(Me.customerName)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.workspaceLabel)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.newWorkspace)
        Me.Controls.Add(Me.usernameLabel)
        Me.Controls.Add(Me.errorButton)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.label1)
        Me.Name = "Workspace"
        Me.Size = New System.Drawing.Size(845, 586)
        Me.Text = "Workspace"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents backButton As Wisej.Web.Button
    Friend WithEvents dataGridView1 As Wisej.Web.DataGridView
    Friend WithEvents Column0 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents errorButton As Wisej.Web.Button
    Friend WithEvents usernameLabel As Wisej.Web.Label
    Friend WithEvents newWorkspace As Wisej.Web.Button
    Friend WithEvents workspaceLabel As Wisej.Web.Label
    Friend WithEvents label3 As Wisej.Web.Label
    Friend WithEvents label2 As Wisej.Web.Label
    Friend WithEvents customerName As Wisej.Web.TextBox
    Friend WithEvents settingsButton As Wisej.Web.Button
End Class
