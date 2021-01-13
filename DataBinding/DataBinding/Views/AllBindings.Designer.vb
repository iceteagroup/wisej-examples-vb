Namespace DataBinding.Views

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AllBindings
        Inherits Wisej.Web.Form
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
            Me.components = New System.ComponentModel.Container()
            Me.dataGridView = New Wisej.Web.DataGridView()
            Me.colVendorid = New Wisej.Web.DataGridViewTextBoxColumn()
            Me.colFirstname = New Wisej.Web.DataGridViewTextBoxColumn()
            Me.colLastname = New Wisej.Web.DataGridViewTextBoxColumn()
            Me.colTown = New Wisej.Web.DataGridViewTextBoxColumn()
            Me.colState = New Wisej.Web.DataGridViewComboBoxColumn()
            Me.colFullname = New Wisej.Web.DataGridViewTextBoxColumn()
            Me.vendorListBindingSource = New Wisej.Web.BindingSource(Me.components)
            Me.idLabel = New Wisej.Web.Label()
            Me.idTextBox = New Wisej.Web.Label()
            Me.vendorBindingSource = New Wisej.Web.BindingSource(Me.components)
            Me.firstNameLabel = New Wisej.Web.Label()
            Me.firstNameTextBox = New Wisej.Web.TextBox()
            Me.lastNameLabel = New Wisej.Web.Label()
            Me.lastNameTextBox = New Wisej.Web.TextBox()
            Me.townLabel = New Wisej.Web.Label()
            Me.townTextBox = New Wisej.Web.TextBox()
            Me.stateLabel = New Wisej.Web.Label()
            Me.stateComboBox = New Wisej.Web.ComboBox()
            Me.fullNameLabel = New Wisej.Web.Label()
            Me.fullNameTextBox = New Wisej.Web.Label()
            Me.saveButton = New Wisej.Web.Button()
            Me.newButton = New Wisej.Web.Button()
            Me.removeButton = New Wisej.Web.Button()
            Me.statesBindingSource = New Wisej.Web.BindingSource(Me.components)
            CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vendorListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.statesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dataGridView
            '
            Me.dataGridView.AllowUserToResizeRows = False
            Me.dataGridView.AutoGenerateColumns = False
            Me.dataGridView.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dataGridView.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.colVendorid, Me.colFirstname, Me.colLastname, Me.colTown, Me.colState, Me.colFullname})
            Me.dataGridView.DataSource = Me.vendorListBindingSource
            Me.dataGridView.Dock = Wisej.Web.DockStyle.Top
            Me.dataGridView.KeepSameRowHeight = True
            Me.dataGridView.Location = New System.Drawing.Point(0, 0)
            Me.dataGridView.MultiSelect = False
            Me.dataGridView.Name = "dataGridView"
            Me.dataGridView.ReadOnly = True
            Me.dataGridView.RowHeadersWidthSizeMode = Wisej.Web.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
            Me.dataGridView.RowTemplate.Resizable = Wisej.Web.DataGridViewTriState.[False]
            Me.dataGridView.ShowColumnVisibilityMenu = False
            Me.dataGridView.Size = New System.Drawing.Size(738, 283)
            Me.dataGridView.TabIndex = 1
            '
            'colVendorid
            '
            Me.colVendorid.DataPropertyName = "VendorId"
            Me.colVendorid.HeaderText = "Id"
            Me.colVendorid.Name = "colVendorid"
            Me.colVendorid.ReadOnly = True
            Me.colVendorid.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
            Me.colVendorid.Width = 50
            '
            'colFirstname
            '
            Me.colFirstname.DataPropertyName = "FirstName"
            Me.colFirstname.HeaderText = "First Name"
            Me.colFirstname.Name = "colFirstname"
            Me.colFirstname.ReadOnly = True
            Me.colFirstname.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
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
            'colState
            '
            Me.colState.DataPropertyName = "State"
            Me.colState.HeaderText = "State"
            Me.colState.Name = "colState"
            '
            'colFullname
            '
            Me.colFullname.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill
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
            Me.idLabel.Location = New System.Drawing.Point(34, 310)
            Me.idLabel.Name = "idLabel"
            Me.idLabel.Size = New System.Drawing.Size(73, 16)
            Me.idLabel.TabIndex = 10
            Me.idLabel.Text = "Id"
            '
            'idTextBox
            '
            Me.idTextBox.AutoSize = True
            Me.idTextBox.DataBindings.Add(New Wisej.Web.Binding("Text", Me.vendorBindingSource, "VendorId", True))
            Me.idTextBox.Location = New System.Drawing.Point(107, 310)
            Me.idTextBox.Name = "idTextBox"
            Me.idTextBox.Size = New System.Drawing.Size(4, 15)
            Me.idTextBox.TabIndex = 1
            '
            'vendorBindingSource
            '
            Me.vendorBindingSource.DataSource = GetType(DataBinding.Model.Vendor)
            Me.vendorBindingSource.RefreshValueOnChange = True
            '
            'firstNameLabel
            '
            Me.firstNameLabel.Location = New System.Drawing.Point(34, 334)
            Me.firstNameLabel.Name = "firstNameLabel"
            Me.firstNameLabel.Size = New System.Drawing.Size(73, 16)
            Me.firstNameLabel.TabIndex = 2
            Me.firstNameLabel.Text = "First Name"
            '
            'firstNameTextBox
            '
            Me.firstNameTextBox.DataBindings.Add(New Wisej.Web.Binding("Text", Me.vendorBindingSource, "FirstName", True))
            Me.firstNameTextBox.Location = New System.Drawing.Point(107, 330)
            Me.firstNameTextBox.Name = "firstNameTextBox"
            Me.firstNameTextBox.Size = New System.Drawing.Size(207, 22)
            Me.firstNameTextBox.TabIndex = 3
            '
            'lastNameLabel
            '
            Me.lastNameLabel.Location = New System.Drawing.Point(34, 358)
            Me.lastNameLabel.Name = "lastNameLabel"
            Me.lastNameLabel.Size = New System.Drawing.Size(73, 16)
            Me.lastNameLabel.TabIndex = 4
            Me.lastNameLabel.Text = "Last Name"
            '
            'lastNameTextBox
            '
            Me.lastNameTextBox.DataBindings.Add(New Wisej.Web.Binding("Text", Me.vendorBindingSource, "LastName", True))
            Me.lastNameTextBox.Location = New System.Drawing.Point(107, 354)
            Me.lastNameTextBox.Name = "lastNameTextBox"
            Me.lastNameTextBox.Size = New System.Drawing.Size(207, 22)
            Me.lastNameTextBox.TabIndex = 5
            '
            'townLabel
            '
            Me.townLabel.Location = New System.Drawing.Point(34, 382)
            Me.townLabel.Name = "townLabel"
            Me.townLabel.Size = New System.Drawing.Size(73, 16)
            Me.townLabel.TabIndex = 6
            Me.townLabel.Text = "Town"
            '
            'townTextBox
            '
            Me.townTextBox.DataBindings.Add(New Wisej.Web.Binding("Text", Me.vendorBindingSource, "Town", True))
            Me.townTextBox.Location = New System.Drawing.Point(107, 378)
            Me.townTextBox.Name = "townTextBox"
            Me.townTextBox.Size = New System.Drawing.Size(207, 22)
            Me.townTextBox.TabIndex = 7
            '
            'stateLabel
            '
            Me.stateLabel.Location = New System.Drawing.Point(34, 406)
            Me.stateLabel.Name = "stateLabel"
            Me.stateLabel.Size = New System.Drawing.Size(69, 16)
            Me.stateLabel.TabIndex = 8
            Me.stateLabel.Text = "State"
            '
            'stateComboBox
            '
            Me.stateComboBox.DataBindings.Add(New Wisej.Web.Binding("Text", Me.vendorBindingSource, "State", True))
            Me.stateComboBox.Location = New System.Drawing.Point(107, 404)
            Me.stateComboBox.Name = "stateComboBox"
            Me.stateComboBox.Size = New System.Drawing.Size(207, 22)
            Me.stateComboBox.TabIndex = 9
            '
            'fullNameLabel
            '
            Me.fullNameLabel.Location = New System.Drawing.Point(34, 430)
            Me.fullNameLabel.Name = "fullNameLabel"
            Me.fullNameLabel.Size = New System.Drawing.Size(73, 16)
            Me.fullNameLabel.TabIndex = 8
            Me.fullNameLabel.Text = "Full Name"
            '
            'fullNameTextBox
            '
            Me.fullNameTextBox.AutoSize = True
            Me.fullNameTextBox.DataBindings.Add(New Wisej.Web.Binding("Text", Me.vendorBindingSource, "FullName", True))
            Me.fullNameTextBox.Location = New System.Drawing.Point(107, 430)
            Me.fullNameTextBox.Name = "fullNameTextBox"
            Me.fullNameTextBox.Size = New System.Drawing.Size(4, 15)
            Me.fullNameTextBox.TabIndex = 9
            '
            'saveButton
            '
            Me.saveButton.Location = New System.Drawing.Point(626, 330)
            Me.saveButton.Name = "saveButton"
            Me.saveButton.Size = New System.Drawing.Size(80, 26)
            Me.saveButton.TabIndex = 11
            Me.saveButton.Text = "Save"
            '
            'newButton
            '
            Me.newButton.Location = New System.Drawing.Point(626, 375)
            Me.newButton.Name = "newButton"
            Me.newButton.Size = New System.Drawing.Size(80, 26)
            Me.newButton.TabIndex = 12
            Me.newButton.Text = "New"
            '
            'removeButton
            '
            Me.removeButton.Location = New System.Drawing.Point(626, 420)
            Me.removeButton.Name = "removeButton"
            Me.removeButton.Size = New System.Drawing.Size(80, 26)
            Me.removeButton.TabIndex = 12
            Me.removeButton.Text = "Remove"
            '
            'statesBindingSource
            '
            Me.statesBindingSource.AllowNew = False
            '
            'AllBindings
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(738, 460)
            Me.Controls.Add(Me.dataGridView)
            Me.Controls.Add(Me.removeButton)
            Me.Controls.Add(Me.newButton)
            Me.Controls.Add(Me.saveButton)
            Me.Controls.Add(Me.fullNameTextBox)
            Me.Controls.Add(Me.fullNameLabel)
            Me.Controls.Add(Me.townTextBox)
            Me.Controls.Add(Me.townLabel)
            Me.Controls.Add(Me.stateComboBox)
            Me.Controls.Add(Me.stateLabel)
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
            CType(Me.statesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Friend WithEvents dataGridView As Wisej.Web.DataGridView
        Friend WithEvents vendorListBindingSource As Wisej.Web.BindingSource
        Friend WithEvents colVendorid As Wisej.Web.DataGridViewTextBoxColumn
        Friend WithEvents colFirstname As Wisej.Web.DataGridViewTextBoxColumn
        Friend WithEvents colLastname As Wisej.Web.DataGridViewTextBoxColumn
        Friend WithEvents colTown As Wisej.Web.DataGridViewTextBoxColumn
        Friend WithEvents colState As Wisej.Web.DataGridViewComboBoxColumn
        Friend WithEvents colFullname As Wisej.Web.DataGridViewTextBoxColumn
        Friend WithEvents idLabel As Wisej.Web.Label
        Friend WithEvents idTextBox As Wisej.Web.Label
        Friend WithEvents firstNameLabel As Wisej.Web.Label
        Friend WithEvents firstNameTextBox As Wisej.Web.TextBox
        Friend WithEvents lastNameLabel As Wisej.Web.Label
        Friend WithEvents lastNameTextBox As Wisej.Web.TextBox
        Friend WithEvents townLabel As Wisej.Web.Label
        Friend WithEvents townTextBox As Wisej.Web.TextBox
        Friend WithEvents stateLabel As Wisej.Web.Label
        Friend WithEvents stateComboBox As Wisej.Web.ComboBox
        Friend WithEvents fullNameLabel As Wisej.Web.Label
        Friend WithEvents fullNameTextBox As Wisej.Web.Label
        Friend WithEvents saveButton As Wisej.Web.Button
        Friend WithEvents newButton As Wisej.Web.Button
        Friend WithEvents removeButton As Wisej.Web.Button
        Friend WithEvents vendorBindingSource As Wisej.Web.BindingSource
        Friend WithEvents statesBindingSource As Wisej.Web.BindingSource
    End Class
End Namespace
