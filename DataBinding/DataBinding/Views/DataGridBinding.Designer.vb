Namespace DataBinding.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class DataGridBinding
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
            Me.statesBindingSource = New Wisej.Web.BindingSource(Me.components)
            CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vendorListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.statesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dataGridView
            '
            Me.dataGridView.AllowUserToAddRows = True
            Me.dataGridView.AllowUserToResizeRows = False
            Me.dataGridView.AutoGenerateColumns = False
            Me.dataGridView.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dataGridView.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.colVendorid, Me.colFirstname, Me.colLastname, Me.colTown, Me.colState, Me.colFullname})
            Me.dataGridView.DataSource = Me.vendorListBindingSource
            Me.dataGridView.Dock = Wisej.Web.DockStyle.Top
            Me.dataGridView.Location = New System.Drawing.Point(0, 0)
            Me.dataGridView.MultiSelect = False
            Me.dataGridView.Name = "dataGridView"
            Me.dataGridView.RowHeadersWidthSizeMode = Wisej.Web.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
            Me.dataGridView.RowTemplate.Resizable = Wisej.Web.DataGridViewTriState.[False]
            Me.dataGridView.ShowColumnVisibilityMenu = False
            Me.dataGridView.Size = New System.Drawing.Size(738, 370)
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
            Me.colFirstname.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
            '
            'colLastname
            '
            Me.colLastname.DataPropertyName = "LastName"
            Me.colLastname.HeaderText = "Last Name"
            Me.colLastname.Name = "colLastname"
            '
            'colTown
            '
            Me.colTown.DataPropertyName = "Town"
            Me.colTown.HeaderText = "Town"
            Me.colTown.Name = "colTown"
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
            Me.vendorListBindingSource.RefreshValueOnChange = True
            '
            'statesBindingSource
            '
            Me.statesBindingSource.AllowNew = False
            '
            'DataGridBinding
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(738, 480)
            Me.Controls.Add(Me.dataGridView)
            Me.Name = "DataGridBinding"
            Me.Text = "DataGrid Binding"
            CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vendorListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.statesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Friend WithEvents dataGridView As Wisej.Web.DataGridView
        Friend WithEvents vendorListBindingSource As Wisej.Web.BindingSource
        Friend WithEvents colVendorid As Wisej.Web.DataGridViewTextBoxColumn
        Friend WithEvents colFirstname As Wisej.Web.DataGridViewTextBoxColumn
        Friend WithEvents colLastname As Wisej.Web.DataGridViewTextBoxColumn
        Friend WithEvents colTown As Wisej.Web.DataGridViewTextBoxColumn
        Friend WithEvents colFullname As Wisej.Web.DataGridViewTextBoxColumn
        Friend WithEvents colState As Wisej.Web.DataGridViewComboBoxColumn
        Friend WithEvents statesBindingSource As Wisej.Web.BindingSource
    End Class
End Namespace
