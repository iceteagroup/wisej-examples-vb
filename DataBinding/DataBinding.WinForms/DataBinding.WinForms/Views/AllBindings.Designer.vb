Namespace DataBinding.Views
    Partial Class AllBindings
        Inherits Form
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
            Me.components = New System.ComponentModel.Container()
            Me.dataGridView = New System.Windows.Forms.DataGridView()
            Me.colVendorid = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colFirstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colLastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colTown = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colFullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.vendorListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.idLabel = New System.Windows.Forms.Label()
            Me.idTextBox = New System.Windows.Forms.Label()
            Me.vendorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.firstNameLabel = New System.Windows.Forms.Label()
            Me.firstNameTextBox = New System.Windows.Forms.TextBox()
            Me.lastNameLabel = New System.Windows.Forms.Label()
            Me.lastNameTextBox = New System.Windows.Forms.TextBox()
            Me.townLabel = New System.Windows.Forms.Label()
            Me.townTextBox = New System.Windows.Forms.TextBox()
            Me.fullNameLabel = New System.Windows.Forms.Label()
            Me.fullNameTextBox = New System.Windows.Forms.Label()
            Me.saveButton = New System.Windows.Forms.Button()
            Me.newButton = New System.Windows.Forms.Button()
            Me.removeButton = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vendorListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dataGridView
            '
            Me.dataGridView.AllowUserToAddRows = False
            Me.dataGridView.AllowUserToDeleteRows = False
            Me.dataGridView.AllowUserToResizeRows = False
            Me.dataGridView.AutoGenerateColumns = False
            Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colVendorid, Me.colFirstname, Me.colLastname, Me.colTown, Me.colFullname})
            Me.dataGridView.DataSource = Me.vendorListBindingSource
            Me.dataGridView.Dock = System.Windows.Forms.DockStyle.Top
            Me.dataGridView.Location = New System.Drawing.Point(0, 0)
            Me.dataGridView.MultiSelect = False
            Me.dataGridView.Name = "dataGridView"
            Me.dataGridView.ReadOnly = True
            Me.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
            Me.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dataGridView.Size = New System.Drawing.Size(738, 287)
            Me.dataGridView.TabIndex = 1
            '
            'colVendorid
            '
            Me.colVendorid.DataPropertyName = "VendorId"
            Me.colVendorid.HeaderText = "Id"
            Me.colVendorid.Name = "colVendorid"
            Me.colVendorid.ReadOnly = True
            Me.colVendorid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.colVendorid.Width = 50
            '
            'colFirstname
            '
            Me.colFirstname.DataPropertyName = "FirstName"
            Me.colFirstname.HeaderText = "First Name"
            Me.colFirstname.Name = "colFirstname"
            Me.colFirstname.ReadOnly = True
            Me.colFirstname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'colLastname
            '
            Me.colLastname.DataPropertyName = "LastName"
            Me.colLastname.HeaderText = "Last Name"
            Me.colLastname.Name = "colLastname"
            Me.colLastname.ReadOnly = True
            '
            'colTown
            '
            Me.colTown.DataPropertyName = "Town"
            Me.colTown.HeaderText = "Town"
            Me.colTown.Name = "colTown"
            Me.colTown.ReadOnly = True
            Me.colTown.Width = 150
            '
            'colFullname
            '
            Me.colFullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.colFullname.DataPropertyName = "FullName"
            Me.colFullname.HeaderText = "Full Name"
            Me.colFullname.Name = "colFullname"
            Me.colFullname.ReadOnly = True
            '
            'vendorListBindingSource
            '
            Me.vendorListBindingSource.DataSource = GetType(DataBinding.Model.VendorList)
            '
            'idLabel
            '
            Me.idLabel.Location = New System.Drawing.Point(34, 308)
            Me.idLabel.Name = "idLabel"
            Me.idLabel.Size = New System.Drawing.Size(13, 17)
            Me.idLabel.TabIndex = 10
            Me.idLabel.Text = "Id"
            '
            'idTextBox
            '
            Me.idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.vendorBindingSource, "VendorId", True))
            Me.idTextBox.Location = New System.Drawing.Point(95, 306)
            Me.idTextBox.Name = "idTextBox"
            Me.idTextBox.Size = New System.Drawing.Size(0, 17)
            Me.idTextBox.TabIndex = 1
            '
            'vendorBindingSource
            '
            Me.vendorBindingSource.DataSource = GetType(DataBinding.Model.Vendor)
            '
            'firstNameLabel
            '
            Me.firstNameLabel.Location = New System.Drawing.Point(34, 331)
            Me.firstNameLabel.Name = "firstNameLabel"
            Me.firstNameLabel.Size = New System.Drawing.Size(55, 17)
            Me.firstNameLabel.TabIndex = 2
            Me.firstNameLabel.Text = "First Name"
            '
            'firstNameTextBox
            '
            Me.firstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.vendorBindingSource, "FirstName", True))
            Me.firstNameTextBox.Location = New System.Drawing.Point(95, 329)
            Me.firstNameTextBox.Name = "firstNameTextBox"
            Me.firstNameTextBox.Size = New System.Drawing.Size(207, 20)
            Me.firstNameTextBox.TabIndex = 3
            '
            'lastNameLabel
            '
            Me.lastNameLabel.Location = New System.Drawing.Point(34, 349)
            Me.lastNameLabel.Name = "lastNameLabel"
            Me.lastNameLabel.Size = New System.Drawing.Size(54, 17)
            Me.lastNameLabel.TabIndex = 4
            Me.lastNameLabel.Text = "Last Name"
            '
            'lastNameTextBox
            '
            Me.lastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.vendorBindingSource, "LastName", True))
            Me.lastNameTextBox.Location = New System.Drawing.Point(95, 351)
            Me.lastNameTextBox.Name = "lastNameTextBox"
            Me.lastNameTextBox.Size = New System.Drawing.Size(207, 20)
            Me.lastNameTextBox.TabIndex = 5
            '
            'townLabel
            '
            Me.townLabel.Location = New System.Drawing.Point(34, 371)
            Me.townLabel.Name = "townLabel"
            Me.townLabel.Size = New System.Drawing.Size(30, 17)
            Me.townLabel.TabIndex = 6
            Me.townLabel.Text = "Town"
            '
            'townTextBox
            '
            Me.townTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.vendorBindingSource, "Town", True))
            Me.townTextBox.Location = New System.Drawing.Point(95, 373)
            Me.townTextBox.Name = "townTextBox"
            Me.townTextBox.Size = New System.Drawing.Size(207, 20)
            Me.townTextBox.TabIndex = 7
            '
            'fullNameLabel
            '
            Me.fullNameLabel.Location = New System.Drawing.Point(34, 394)
            Me.fullNameLabel.Name = "fullNameLabel"
            Me.fullNameLabel.Size = New System.Drawing.Size(207, 19)
            Me.fullNameLabel.TabIndex = 8
            Me.fullNameLabel.Text = "Full Name"
            '
            'fullNameTextBox
            '
            Me.fullNameTextBox.AutoSize = True
            Me.fullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.vendorBindingSource, "FullName", True))
            Me.fullNameTextBox.Location = New System.Drawing.Point(95, 396)
            Me.fullNameTextBox.Name = "fullNameTextBox"
            Me.fullNameTextBox.Size = New System.Drawing.Size(0, 13)
            Me.fullNameTextBox.TabIndex = 9
            '
            'saveButton
            '
            Me.saveButton.Location = New System.Drawing.Point(626, 306)
            Me.saveButton.Name = "saveButton"
            Me.saveButton.Size = New System.Drawing.Size(80, 24)
            Me.saveButton.TabIndex = 11
            Me.saveButton.Text = "Save"
            '
            'newButton
            '
            Me.newButton.Location = New System.Drawing.Point(626, 348)
            Me.newButton.Name = "newButton"
            Me.newButton.Size = New System.Drawing.Size(80, 24)
            Me.newButton.TabIndex = 12
            Me.newButton.Text = "New"
            '
            'removeButton
            '
            Me.removeButton.Location = New System.Drawing.Point(626, 390)
            Me.removeButton.Name = "removeButton"
            Me.removeButton.Size = New System.Drawing.Size(80, 24)
            Me.removeButton.TabIndex = 12
            Me.removeButton.Text = "Remove"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(328, 354)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(197, 13)
            Me.label1.TabIndex = 15
            Me.label1.Text = "This should be converted to Upper case"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(328, 400)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(187, 13)
            Me.label2.TabIndex = 16
            Me.label2.Text = "Last name is converted to Upper case"
            '
            'AllBindings
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(738, 427)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.dataGridView)
            Me.Controls.Add(Me.removeButton)
            Me.Controls.Add(Me.newButton)
            Me.Controls.Add(Me.saveButton)
            Me.Controls.Add(Me.fullNameTextBox)
            Me.Controls.Add(Me.fullNameLabel)
            Me.Controls.Add(Me.townTextBox)
            Me.Controls.Add(Me.townLabel)
            Me.Controls.Add(Me.lastNameTextBox)
            Me.Controls.Add(Me.lastNameLabel)
            Me.Controls.Add(Me.firstNameTextBox)
            Me.Controls.Add(Me.firstNameLabel)
            Me.Controls.Add(Me.idTextBox)
            Me.Controls.Add(Me.idLabel)
            Me.Name = "AllBindings"
            Me.Text = "All Bindings"
            CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vendorListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Friend WithEvents dataGridView As Windows.Forms.DataGridView
        Friend WithEvents vendorListBindingSource As Windows.Forms.BindingSource
        Friend WithEvents colVendorid As Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colFirstname As Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colLastname As Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colTown As Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colFullname As Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents idLabel As Windows.Forms.Label
        Friend WithEvents idTextBox As Windows.Forms.Label
        Friend WithEvents firstNameLabel As Windows.Forms.Label
        Friend WithEvents firstNameTextBox As Windows.Forms.TextBox
        Friend WithEvents lastNameLabel As Windows.Forms.Label
        Friend WithEvents lastNameTextBox As Windows.Forms.TextBox
        Friend WithEvents townLabel As Windows.Forms.Label
        Friend WithEvents townTextBox As Windows.Forms.TextBox
        Friend WithEvents fullNameLabel As Windows.Forms.Label
        Friend WithEvents fullNameTextBox As Windows.Forms.Label
        Friend WithEvents saveButton As Windows.Forms.Button
        Friend WithEvents newButton As Windows.Forms.Button
        Friend WithEvents removeButton As Windows.Forms.Button
        Friend WithEvents vendorBindingSource As Windows.Forms.BindingSource
        Friend WithEvents label1 As Windows.Forms.Label
        Friend WithEvents label2 As Windows.Forms.Label
    End Class
End Namespace
