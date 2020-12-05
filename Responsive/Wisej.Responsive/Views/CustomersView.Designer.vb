Namespace Views

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CustomersView
        Inherits ViewBase
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer

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
            dataGridView1 = New Web.DataGridView()
            Column3 = New Web.DataGridViewButtonColumn()
            colName = New Web.DataGridViewColumn()
            colLastName = New Web.DataGridViewColumn()
            colPurchases = New Web.DataGridViewColumn()
            toolBar1 = New Web.ToolBar()
            toolBarButton1 = New Web.ToolBarButton()
            toolBarButton2 = New Web.ToolBarButton()
            toolBarButton3 = New Web.ToolBarButton()
            CType(dataGridView1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' dataGridView1
            ' 
            dataGridView1.Columns.AddRange(New Web.DataGridViewColumn() {Column3, colName, colLastName, colPurchases})
            dataGridView1.Dock = Web.DockStyle.Fill
            dataGridView1.Location = New Drawing.Point(0, 82)
            dataGridView1.Name = "dataGridView1"
            dataGridView1.RowHeadersMinimumWidth = 2
            dataGridView1.Size = New Drawing.Size(740, 560)
            dataGridView1.TabIndex = 2
            ' 
            ' Column3
            ' 
            Column3.HeaderText = "Column3"
            Column3.Name = "Column3"
            Column3.Text = "Edit"
            Column3.UseColumnTextForButtonValue = True
            ' 
            ' colName
            ' 
            colName.HeaderText = "Name"
            colName.Name = "colName"
            colName.Width = 200
            ' 
            ' colLastName
            ' 
            colLastName.HeaderText = "Last Name"
            colLastName.Name = "colLastName"
            colLastName.Width = 200
            ' 
            ' colPurchases
            ' 
            colPurchases.HeaderText = "Purchases"
            colPurchases.Name = "colPurchases"
            colPurchases.Width = 150
            ' 
            ' toolBar1
            ' 
            toolBar1.BackColor = Drawing.Color.Transparent
            toolBar1.Buttons.AddRange(New Web.ToolBarButton() {toolBarButton1, toolBarButton2, toolBarButton3})
            toolBar1.Location = New Drawing.Point(0, 33)
            toolBar1.Name = "toolBar1"
            toolBar1.Size = New Drawing.Size(740, 49)
            toolBar1.TabIndex = 3
            toolBar1.TabStop = False
            ' 
            ' toolBarButton1
            ' 
            toolBarButton1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/add-user-button.svg"
            toolBarButton1.Margin = New Web.Padding(5, 0, 5, 0)
            toolBarButton1.Name = "toolBarButton1"
            toolBarButton1.Padding = New Web.Padding(5)
            toolBarButton1.Text = "New"
            ' 
            ' toolBarButton2
            ' 
            toolBarButton2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/close-button.svg"
            toolBarButton2.Margin = New Web.Padding(5, 0, 5, 0)
            toolBarButton2.Name = "toolBarButton2"
            toolBarButton2.Padding = New Web.Padding(5)
            toolBarButton2.Text = "Delete"
            ' 
            ' toolBarButton3
            ' 
            toolBarButton3.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/searching-magnifying-glass.svg"
            toolBarButton3.Margin = New Web.Padding(5, 0, 5, 0)
            toolBarButton3.Name = "toolBarButton3"
            toolBarButton3.Padding = New Web.Padding(5)
            toolBarButton3.Text = "Search"
            ' 
            ' CustomersView
            ' 
            Controls.Add(dataGridView1)
            Controls.Add(toolBar1)
            Name = "CustomersView"
            Title = "Customers"
            Controls.SetChildIndex(toolBar1, 0)
            Controls.SetChildIndex(dataGridView1, 0)
            CType(dataGridView1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub


#End Region

        Friend WithEvents dataGridView1 As Web.DataGridView
        Friend WithEvents Column3 As Web.DataGridViewButtonColumn
        Friend WithEvents colName As Web.DataGridViewColumn
        Friend WithEvents colLastName As Web.DataGridViewColumn
        Friend WithEvents colPurchases As Web.DataGridViewColumn
        Friend WithEvents toolBar1 As Web.ToolBar
        Friend WithEvents toolBarButton1 As Web.ToolBarButton
        Friend WithEvents toolBarButton2 As Web.ToolBarButton
        Friend WithEvents toolBarButton3 As Web.ToolBarButton
    End Class
End Namespace
