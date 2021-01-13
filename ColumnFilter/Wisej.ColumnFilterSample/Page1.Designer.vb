Imports System

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
        Me.components = New System.ComponentModel.Container()
        Me.label1 = New Wisej.Web.Label()
        Me.dataGridView1 = New Wisej.Web.DataGridView()
        Me.Column0 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Column1 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Column2 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Column3 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Column4 = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.SimpleColumnFilter = New Wisej.Web.Ext.ColumnFilter.ColumnFilter(Me.components)
        Me.WhereColumnFilter = New Wisej.Web.Ext.ColumnFilter.ColumnFilter(Me.components)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleColumnFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WhereColumnFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AllowHtml = True
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(23, 40)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(227, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "<big>Wisej ColumnFilter sample</big>"
        '
        'dataGridView1
        '
        Me.dataGridView1.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Column0, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dataGridView1.Location = New System.Drawing.Point(23, 79)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(868, 432)
        Me.dataGridView1.TabIndex = 1
        '
        'Column0
        '
        Me.Column0.HeaderText = "Name"
        Me.Column0.Name = "Column0"
        Me.SimpleColumnFilter.SetShowFilter(Me.Column0, True)
        Me.Column0.Width = 200
        '
        'Column1
        '
        Me.Column1.HeaderText = "Last Name"
        Me.Column1.Name = "Column1"
        Me.WhereColumnFilter.SetShowFilter(Me.Column1, True)
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Birth Date"
        Me.Column2.Name = "Column2"
        Me.WhereColumnFilter.SetShowFilter(Me.Column2, True)
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "ID"
        Me.Column3.Name = "Column3"
        Me.WhereColumnFilter.SetShowFilter(Me.Column3, True)
        '
        'Column4
        '
        Me.Column4.HeaderText = "Active"
        Me.Column4.Name = "Column4"
        Me.SimpleColumnFilter.SetShowFilter(Me.Column4, True)
        '
        'SimpleColumnFilter
        '
        Me.SimpleColumnFilter.FilteredImageSource = "icon-search?color=#FF1700"
        Me.SimpleColumnFilter.FilterPanelType = GetType(Wisej.Web.Ext.ColumnFilter.SimpleColumnFilterPanel)
        Me.SimpleColumnFilter.ImageSource = "icon-search"
        '
        'WhereColumnFilter
        '
        Me.WhereColumnFilter.FilteredImageSource = "table-row-editing?color=#FF1700"
        Me.WhereColumnFilter.FilterPanelType = GetType(Wisej.Web.Ext.ColumnFilter.WhereColumnFilterPanel)
        Me.WhereColumnFilter.ImageSource = "table-row-editing"
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(846, 729)
        Me.Text = "Page1"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleColumnFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WhereColumnFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents label1 As Label
    Friend WithEvents dataGridView1 As DataGridView
    Friend WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents SimpleColumnFilter As Ext.ColumnFilter.ColumnFilter
    Friend WithEvents WhereColumnFilter As Ext.ColumnFilter.ColumnFilter
    Friend WithEvents Column4 As DataGridViewCheckBoxColumn
End Class
