Namespace DataBinding.Views
    Partial Class DataGridBinding
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
            CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vendorListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dataGridView
            '
            Me.dataGridView.AllowUserToResizeRows = False
            Me.dataGridView.AutoGenerateColumns = False
            Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colVendorid, Me.colFirstname, Me.colLastname, Me.colTown, Me.colFullname})
            Me.dataGridView.DataSource = Me.vendorListBindingSource
            Me.dataGridView.Dock = System.Windows.Forms.DockStyle.Top
            Me.dataGridView.Location = New System.Drawing.Point(0, 0)
            Me.dataGridView.MultiSelect = False
            Me.dataGridView.Name = "dataGridView"
            Me.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
            Me.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dataGridView.Size = New System.Drawing.Size(738, 344)
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
            Me.colFirstname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
            'DataGridBinding
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(738, 446)
            Me.Controls.Add(Me.dataGridView)
            Me.Name = "DataGridBinding"
            Me.Text = "DataGrid Binding"
            CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vendorListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Friend WithEvents dataGridView As Windows.Forms.DataGridView
        Friend WithEvents vendorListBindingSource As Windows.Forms.BindingSource
        Friend WithEvents colVendorid As Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colFirstname As Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colLastname As Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colTown As Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colFullname As Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace
