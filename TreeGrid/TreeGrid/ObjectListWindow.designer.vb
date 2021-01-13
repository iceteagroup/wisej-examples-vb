<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ObjectListWindow
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
        dataGridView = New Wisej.Web.DataGridView()
        colId = New Wisej.Web.DataGridViewColumn()
        colName = New Wisej.Web.DataGridViewColumn()
        colTherapist = New Wisej.Web.DataGridViewColumn()
        CType(dataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dataGridView1
        ' 
        dataGridView.AutoGenerateColumns = False
        dataGridView.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {colId, colName, colTherapist})
        dataGridView.Location = New Drawing.Point(17, 19)
        dataGridView.Name = "dataGridView"
        dataGridView.ShowColumnVisibilityMenu = False
        dataGridView.ShowFocusCell = False
        dataGridView.Size = New Drawing.Size(500, 475)
        dataGridView.TabIndex = 0
        ' 
        ' colId
        ' 
        colId.HeaderText = "ID"
        colId.Name = "colId"
        colId.Visible = False
        ' 
        ' colName
        ' 
        colName.HeaderText = "Therapy Name"
        colName.Name = "colName"
        colName.Width = 150
        ' 
        ' colTherapist
        ' 
        colTherapist.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill
        colTherapist.HeaderText = "Therapist"
        colTherapist.Name = "colTherapist"
        ' 
        ' ObjectListWindow
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(533, 509)
        Controls.Add(dataGridView)
        Name = "ObjectListWindow"
        Text = "Object List Example"
        AddHandler Load, New EventHandler(AddressOf Page1_Load)
        CType(dataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

#End Region

    Friend WithEvents dataGridView As Wisej.Web.DataGridView
    Friend WithEvents colId As Wisej.Web.DataGridViewColumn
    Friend WithEvents colName As Wisej.Web.DataGridViewColumn
    Friend WithEvents colTherapist As Wisej.Web.DataGridViewColumn
End Class
