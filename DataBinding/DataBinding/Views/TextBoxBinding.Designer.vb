Namespace DataBinding.Views

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class TextBoxBinding
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
            Me.closeButton = New Wisej.Web.Button()
            Me.statesBindingSource = New Wisej.Web.BindingSource(Me.components)
            CType(Me.vendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.statesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'idLabel
            '
            Me.idLabel.Location = New System.Drawing.Point(40, 45)
            Me.idLabel.Name = "idLabel"
            Me.idLabel.Size = New System.Drawing.Size(69, 16)
            Me.idLabel.TabIndex = 10
            Me.idLabel.Text = "Id"
            '
            'idTextBox
            '
            Me.idTextBox.DataBindings.Add(New Wisej.Web.Binding("Text", Me.vendorBindingSource, "VendorId", True))
            Me.idTextBox.Location = New System.Drawing.Point(140, 43)
            Me.idTextBox.Name = "idTextBox"
            Me.idTextBox.Size = New System.Drawing.Size(0, 18)
            Me.idTextBox.TabIndex = 1
            '
            'vendorBindingSource
            '
            Me.vendorBindingSource.DataSource = GetType(DataBinding.Model.Vendor)
            Me.vendorBindingSource.RefreshValueOnChange = True
            '
            'firstNameLabel
            '
            Me.firstNameLabel.Location = New System.Drawing.Point(40, 100)
            Me.firstNameLabel.Name = "firstNameLabel"
            Me.firstNameLabel.Size = New System.Drawing.Size(69, 16)
            Me.firstNameLabel.TabIndex = 2
            Me.firstNameLabel.Text = "First Name"
            '
            'firstNameTextBox
            '
            Me.firstNameTextBox.DataBindings.Add(New Wisej.Web.Binding("Text", Me.vendorBindingSource, "FirstName", True))
            Me.firstNameTextBox.Location = New System.Drawing.Point(140, 98)
            Me.firstNameTextBox.Name = "firstNameTextBox"
            Me.firstNameTextBox.Size = New System.Drawing.Size(207, 22)
            Me.firstNameTextBox.TabIndex = 3
            '
            'lastNameLabel
            '
            Me.lastNameLabel.Location = New System.Drawing.Point(40, 155)
            Me.lastNameLabel.Name = "lastNameLabel"
            Me.lastNameLabel.Size = New System.Drawing.Size(69, 16)
            Me.lastNameLabel.TabIndex = 4
            Me.lastNameLabel.Text = "Last Name"
            '
            'lastNameTextBox
            '
            Me.lastNameTextBox.DataBindings.Add(New Wisej.Web.Binding("Text", Me.vendorBindingSource, "LastName", True))
            Me.lastNameTextBox.Location = New System.Drawing.Point(140, 153)
            Me.lastNameTextBox.Name = "lastNameTextBox"
            Me.lastNameTextBox.Size = New System.Drawing.Size(207, 22)
            Me.lastNameTextBox.TabIndex = 5
            '
            'townLabel
            '
            Me.townLabel.Location = New System.Drawing.Point(40, 210)
            Me.townLabel.Name = "townLabel"
            Me.townLabel.Size = New System.Drawing.Size(69, 16)
            Me.townLabel.TabIndex = 6
            Me.townLabel.Text = "Town"
            '
            'townTextBox
            '
            Me.townTextBox.DataBindings.Add(New Wisej.Web.Binding("Text", Me.vendorBindingSource, "Town", True))
            Me.townTextBox.Location = New System.Drawing.Point(140, 208)
            Me.townTextBox.Name = "townTextBox"
            Me.townTextBox.Size = New System.Drawing.Size(207, 22)
            Me.townTextBox.TabIndex = 7
            '
            'stateLabel
            '
            Me.stateLabel.Location = New System.Drawing.Point(40, 265)
            Me.stateLabel.Name = "stateLabel"
            Me.stateLabel.Size = New System.Drawing.Size(69, 16)
            Me.stateLabel.TabIndex = 8
            Me.stateLabel.Text = "State"
            '
            'stateComboBox
            '
            Me.stateComboBox.DataBindings.Add(New Wisej.Web.Binding("Text", Me.vendorBindingSource, "State", True))
            Me.stateComboBox.Location = New System.Drawing.Point(140, 263)
            Me.stateComboBox.Name = "stateComboBox"
            Me.stateComboBox.Size = New System.Drawing.Size(207, 22)
            Me.stateComboBox.TabIndex = 9
            '
            'fullNameLabel
            '
            Me.fullNameLabel.Location = New System.Drawing.Point(40, 320)
            Me.fullNameLabel.Name = "fullNameLabel"
            Me.fullNameLabel.Size = New System.Drawing.Size(69, 16)
            Me.fullNameLabel.TabIndex = 10
            Me.fullNameLabel.Text = "Full Name"
            '
            'fullNameTextBox
            '
            Me.fullNameTextBox.AutoSize = True
            Me.fullNameTextBox.DataBindings.Add(New Wisej.Web.Binding("Text", Me.vendorBindingSource, "FullName", True))
            Me.fullNameTextBox.Location = New System.Drawing.Point(140, 320)
            Me.fullNameTextBox.Name = "fullNameTextBox"
            Me.fullNameTextBox.Size = New System.Drawing.Size(4, 15)
            Me.fullNameTextBox.TabIndex = 11
            '
            'saveButton
            '
            Me.saveButton.Location = New System.Drawing.Point(40, 414)
            Me.saveButton.Name = "saveButton"
            Me.saveButton.Size = New System.Drawing.Size(80, 26)
            Me.saveButton.TabIndex = 11
            Me.saveButton.Text = "Save"
            '
            'newButton
            '
            Me.newButton.Location = New System.Drawing.Point(140, 414)
            Me.newButton.Name = "newButton"
            Me.newButton.Size = New System.Drawing.Size(80, 26)
            Me.newButton.TabIndex = 12
            Me.newButton.Text = "New"
            '
            'removeButton
            '
            Me.removeButton.Location = New System.Drawing.Point(240, 414)
            Me.removeButton.Name = "removeButton"
            Me.removeButton.Size = New System.Drawing.Size(80, 26)
            Me.removeButton.TabIndex = 12
            Me.removeButton.Text = "Remove"
            '
            'closeButton
            '
            Me.closeButton.Location = New System.Drawing.Point(360, 414)
            Me.closeButton.Name = "closeButton"
            Me.closeButton.Size = New System.Drawing.Size(80, 26)
            Me.closeButton.TabIndex = 13
            Me.closeButton.Text = "Close"
            '
            'statesBindingSource
            '
            Me.statesBindingSource.AllowNew = False
            '
            'TextBoxBinding
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(488, 511)
            Me.Controls.Add(Me.closeButton)
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
            Me.Name = "TextBoxBinding"
            Me.Text = "TextBox Binding"
            CType(Me.vendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.statesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

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
        Friend WithEvents closeButton As Wisej.Web.Button
        Friend WithEvents vendorBindingSource As Wisej.Web.BindingSource
        Friend WithEvents statesBindingSource As Wisej.Web.BindingSource
    End Class
End Namespace
