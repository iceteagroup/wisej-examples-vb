<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataBinding
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
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

#Region "Wisej Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim componentTool2 As Web.ComponentTool = New Web.ComponentTool()
        Dim componentTool3 As Web.ComponentTool = New Web.ComponentTool()
        Dim componentTool4 As Web.ComponentTool = New Web.ComponentTool()
        Dim componentTool5 As Web.ComponentTool = New Web.ComponentTool()
        Dim componentTool1 As Web.ComponentTool = New Web.ComponentTool()
        Dim componentTool6 As Web.ComponentTool = New Web.ComponentTool()
        Dim componentTool7 As Web.ComponentTool = New Web.ComponentTool()
        Dim componentTool8 As Web.ComponentTool = New Web.ComponentTool()
        Dim componentTool9 As Web.ComponentTool = New Web.ComponentTool()
        dataGridView1 = New Web.DataGridView()
        colEmployeeid = New Web.DataGridViewTextBoxColumn()
        colFirstname = New Web.DataGridViewTextBoxColumn()
        colLastname = New Web.DataGridViewTextBoxColumn()
        colTitle = New Web.DataGridViewComboBoxColumn()
        colBirthdate = New Web.DataGridViewDateTimePickerColumn()
        colPhone = New Web.DataGridViewMaskedTextBoxColumn()
        colEmail = New Web.DataGridViewTextBoxColumn()
        statusBar1 = New Web.StatusBar()
        employeesBindingSource = New Web.BindingSource(components)
        chinookDataSet = New chinookDataSet()
        textBox1 = New Web.TextBox()
        label1 = New Web.Label()
        label2 = New Web.Label()
        textBox2 = New Web.TextBox()
        label3 = New Web.Label()
        dateTimePicker1 = New Web.DateTimePicker()
        label4 = New Web.Label()
        comboBox1 = New Web.ComboBox()
        label5 = New Web.Label()
        tableLayoutPanel1 = New Web.TableLayoutPanel()
        textBox3 = New Web.TextBox()
        maskedTextBox1 = New Web.MaskedTextBox()
        label6 = New Web.Label()
        employeesTableAdapter = New chinookDataSetTableAdapters.employeesTableAdapter()
        CType(dataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        dataGridView1.SuspendLayout()
        CType(employeesBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(chinookDataSet, ComponentModel.ISupportInitialize).BeginInit()
        tableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dataGridView1
        ' 
        dataGridView1.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Bottom Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right
        dataGridView1.AutoGenerateColumns = False
        dataGridView1.Columns.AddRange(New Web.DataGridViewColumn() {colEmployeeid, colFirstname, colLastname, colTitle, colBirthdate, colPhone, colEmail})
        dataGridView1.Controls.Add(statusBar1)
        dataGridView1.DataSource = employeesBindingSource
        dataGridView1.EditMode = Web.DataGridViewEditMode.EditOnEnter
        dataGridView1.Location = New Drawing.Point(37, 264)
        dataGridView1.Name = "dataGridView1"
        dataGridView1.Size = New Drawing.Size(839, 311)
        dataGridView1.TabIndex = 1
        componentTool2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/square-add-button.svg?color=#3F76BF"
        componentTool2.Name = "Add"
        componentTool2.Position = Web.LeftRightAlignment.Left
        componentTool3.Enabled = False
        componentTool3.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/save-button.svg?color=#3FBF47"
        componentTool3.Name = "Save"
        componentTool3.Position = Web.LeftRightAlignment.Left
        componentTool4.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/refresh-button.svg?color=#003EFF"
        componentTool4.Name = "Reload"
        componentTool4.Position = Web.LeftRightAlignment.Left
        componentTool5.Enabled = False
        componentTool5.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/rubbish-bin-delete-button.svg?color=#7A7A7A"
        componentTool5.Name = "Delete"
        dataGridView1.Tools.AddRange(New Web.ComponentTool() {componentTool2, componentTool3, componentTool4, componentTool5})
        AddHandler dataGridView1.SelectionChanged, New EventHandler(AddressOf dataGridView1_SelectionChanged)
        AddHandler dataGridView1.ToolClick, New Web.ToolClickEventHandler(AddressOf dataGridView1_ToolClick)
        AddHandler dataGridView1.CellToolClick, New Web.DataGridViewToolClickEventHandler(AddressOf dataGridView1_CellToolClick)
        AddHandler dataGridView1.Enter, New EventHandler(AddressOf dataGridView1_Enter)
        ' 
        ' colEmployeeid
        ' 
        colEmployeeid.DataPropertyName = "EmployeeId"
        colEmployeeid.HeaderText = "ID"
        colEmployeeid.Name = "colEmployeeid"
        colEmployeeid.ReadOnly = True
        colEmployeeid.Width = 50
        ' 
        ' colFirstname
        ' 
        colFirstname.DataPropertyName = "FirstName"
        colFirstname.HeaderText = "Name"
        colFirstname.Name = "colFirstname"
        colFirstname.Width = 150
        ' 
        ' colLastname
        ' 
        colLastname.DataPropertyName = "LastName"
        colLastname.HeaderText = "Last Name"
        colLastname.Name = "colLastname"
        colLastname.Width = 150
        ' 
        ' colTitle
        ' 
        colTitle.DataPropertyName = "Title"
        colTitle.DropDownStyle = Web.ComboBoxStyle.DropDownList
        colTitle.HeaderText = "Title"
        colTitle.Items.AddRange(New Object() {"General Manager", "Sales Manager", "Sales Support Agent", "IT Manager", "IT Staff"})
        colTitle.Name = "colTitle"
        ' 
        ' colBirthdate
        ' 
        colBirthdate.DataPropertyName = "BirthDate"
        colBirthdate.Format = Web.DateTimePickerFormat.Long
        colBirthdate.HeaderText = "Birth Date"
        colBirthdate.Name = "colBirthdate"
        componentTool1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/shining-sun.svg?color=#FEC14C"
        colBirthdate.Tools.AddRange(New Web.ComponentTool() {componentTool1})
        colBirthdate.Width = 150
        ' 
        ' colPhone
        ' 
        colPhone.DataPropertyName = "Phone"
        colPhone.HeaderText = "Phone"
        colPhone.Mask = "(999) 000-0000"
        colPhone.Name = "colPhone"
        ' 
        ' colEmail
        ' 
        colEmail.DataPropertyName = "Email"
        colEmail.HeaderText = "Email"
        colEmail.Name = "colEmail"
        colEmail.Width = 150
        ' 
        ' statusBar1
        ' 
        statusBar1.BackgroundImageLayout = Web.ImageLayout.Zoom
        statusBar1.Location = New Drawing.Point(0, 287)
        statusBar1.Name = "statusBar1"
        statusBar1.ShowPanels = False
        statusBar1.Size = New Drawing.Size(837, 22)
        statusBar1.SizingGrip = False
        statusBar1.TabIndex = 0
        statusBar1.Text = "statusBar1"
        ' 
        ' employeesBindingSource
        ' 
        employeesBindingSource.DataMember = "employees"
        employeesBindingSource.DataSource = chinookDataSet
        ' 
        ' chinookDataSet
        ' 
        chinookDataSet.DataSetName = "chinookDataSet"
        chinookDataSet.SchemaSerializationMode = Data.SchemaSerializationMode.IncludeSchema
        ' 
        ' textBox1
        ' 
        textBox1.AutoSize = False
        textBox1.DataBindings.Add(New Web.Binding("Text", employeesBindingSource, "FirstName", True))
        textBox1.Dock = Web.DockStyle.Fill
        textBox1.Location = New Drawing.Point(8, 58)
        textBox1.Margin = New Web.Padding(8)
        textBox1.Name = "textBox1"
        textBox1.Size = New Drawing.Size(204, 34)
        textBox1.TabIndex = 1
        textBox1.Watermark = "Enter a name"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Dock = Web.DockStyle.Fill
        label1.Location = New Drawing.Point(8, 8)
        label1.Margin = New Web.Padding(8)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(204, 34)
        label1.TabIndex = 0
        label1.Text = "&Name"
        label1.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Dock = Web.DockStyle.Fill
        label2.Location = New Drawing.Point(228, 8)
        label2.Margin = New Web.Padding(8)
        label2.Name = "label2"
        label2.Size = New Drawing.Size(204, 34)
        label2.TabIndex = 2
        label2.Text = "&Last Name"
        label2.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' textBox2
        ' 
        textBox2.AutoSize = False
        textBox2.DataBindings.Add(New Web.Binding("Text", employeesBindingSource, "LastName", True))
        textBox2.Dock = Web.DockStyle.Fill
        textBox2.Location = New Drawing.Point(228, 58)
        textBox2.Margin = New Web.Padding(8)
        textBox2.Name = "textBox2"
        textBox2.Size = New Drawing.Size(204, 34)
        textBox2.TabIndex = 3
        componentTool6.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/birthday-cake.svg"
        componentTool7.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/underline-text-button.svg"
        textBox2.Tools.AddRange(New Web.ComponentTool() {componentTool6, componentTool7})
        AddHandler textBox2.ToolClick, New Web.ToolClickEventHandler(AddressOf textBox2_ToolClick)
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Dock = Web.DockStyle.Fill
        label3.Location = New Drawing.Point(624, 8)
        label3.Margin = New Web.Padding(8)
        label3.Name = "label3"
        label3.Size = New Drawing.Size(207, 34)
        label3.TabIndex = 6
        label3.Text = "&Date of Birth"
        label3.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' dateTimePicker1
        ' 
        dateTimePicker1.AutoSize = False
        dateTimePicker1.DataBindings.Add(New Web.Binding("Value", employeesBindingSource, "BirthDate", True))
        dateTimePicker1.Dock = Web.DockStyle.Fill
        dateTimePicker1.Location = New Drawing.Point(624, 58)
        dateTimePicker1.Margin = New Web.Padding(8)
        dateTimePicker1.Name = "dateTimePicker1"
        dateTimePicker1.Size = New Drawing.Size(207, 34)
        dateTimePicker1.TabIndex = 7
        componentTool8.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/shining-sun.svg?color=#FFA700"
        dateTimePicker1.Tools.AddRange(New Web.ComponentTool() {componentTool8})
        dateTimePicker1.Value = New DateTime(2017, 8, 25, 17, 55, 6, 102)
        AddHandler dateTimePicker1.ToolClick, New Web.ToolClickEventHandler(AddressOf dateTimePicker1_ToolClick)
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Dock = Web.DockStyle.Fill
        label4.Location = New Drawing.Point(448, 8)
        label4.Margin = New Web.Padding(8)
        label4.Name = "label4"
        label4.Size = New Drawing.Size(160, 34)
        label4.TabIndex = 4
        label4.Text = "&Title"
        label4.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' comboBox1
        ' 
        comboBox1.AutoSize = False
        comboBox1.DataBindings.Add(New Web.Binding("Text", employeesBindingSource, "Title", True))
        comboBox1.Dock = Web.DockStyle.Fill
        comboBox1.DropDownStyle = Web.ComboBoxStyle.DropDownList
        comboBox1.Items.AddRange(New Object() {"General Manager", "Sales Manager", "Sales Support Agent", "IT Manager", "IT Staff"})
        comboBox1.Location = New Drawing.Point(448, 58)
        comboBox1.Margin = New Web.Padding(8)
        comboBox1.Name = "comboBox1"
        comboBox1.Size = New Drawing.Size(160, 34)
        comboBox1.TabIndex = 5
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        tableLayoutPanel1.SetColumnSpan(label5, 2)
        label5.Dock = Web.DockStyle.Fill
        label5.Location = New Drawing.Point(228, 108)
        label5.Margin = New Web.Padding(8)
        label5.Name = "label5"
        label5.Size = New Drawing.Size(380, 34)
        label5.TabIndex = 10
        label5.Text = "E&Mail"
        label5.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' tableLayoutPanel1
        ' 
        tableLayoutPanel1.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right
        tableLayoutPanel1.ColumnCount = 4
        tableLayoutPanel1.ColumnStyles.Add(New Web.ColumnStyle(Web.SizeType.Percent, 50.0F))
        tableLayoutPanel1.ColumnStyles.Add(New Web.ColumnStyle(Web.SizeType.Percent, 50.0F))
        tableLayoutPanel1.ColumnStyles.Add(New Web.ColumnStyle(Web.SizeType.Percent, 40.0F))
        tableLayoutPanel1.ColumnStyles.Add(New Web.ColumnStyle(Web.SizeType.Percent, 50.0F))
        tableLayoutPanel1.Controls.Add(textBox3, 1, 3)
        tableLayoutPanel1.Controls.Add(maskedTextBox1, 0, 3)
        tableLayoutPanel1.Controls.Add(label1, 0, 0)
        tableLayoutPanel1.Controls.Add(textBox1, 0, 1)
        tableLayoutPanel1.Controls.Add(label5, 1, 2)
        tableLayoutPanel1.Controls.Add(comboBox1, 2, 1)
        tableLayoutPanel1.Controls.Add(label2, 1, 0)
        tableLayoutPanel1.Controls.Add(label4, 2, 0)
        tableLayoutPanel1.Controls.Add(textBox2, 1, 1)
        tableLayoutPanel1.Controls.Add(label3, 3, 0)
        tableLayoutPanel1.Controls.Add(dateTimePicker1, 3, 1)
        tableLayoutPanel1.Controls.Add(label6, 0, 2)
        tableLayoutPanel1.Location = New Drawing.Point(37, 30)
        tableLayoutPanel1.Name = "tableLayoutPanel1"
        tableLayoutPanel1.RowCount = 4
        tableLayoutPanel1.RowStyles.Add(New Web.RowStyle(Web.SizeType.Percent, 50.0F))
        tableLayoutPanel1.RowStyles.Add(New Web.RowStyle(Web.SizeType.Percent, 50.0F))
        tableLayoutPanel1.RowStyles.Add(New Web.RowStyle(Web.SizeType.Percent, 50.0F))
        tableLayoutPanel1.RowStyles.Add(New Web.RowStyle(Web.SizeType.Percent, 50.0F))
        tableLayoutPanel1.Size = New Drawing.Size(839, 203)
        tableLayoutPanel1.TabIndex = 0
        ' 
        ' textBox3
        ' 
        textBox3.AutoSize = False
        tableLayoutPanel1.SetColumnSpan(textBox3, 2)
        textBox3.DataBindings.Add(New Web.Binding("Text", employeesBindingSource, "Email", True))
        textBox3.Dock = Web.DockStyle.Fill
        textBox3.Location = New Drawing.Point(223, 153)
        textBox3.Name = "textBox3"
        textBox3.Size = New Drawing.Size(390, 47)
        textBox3.TabIndex = 11
        componentTool9.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/write-email-envelope-button.svg"
        componentTool9.Name = "Send Email"
        textBox3.Tools.AddRange(New Web.ComponentTool() {componentTool9})
        AddHandler textBox3.ToolClick, New Web.ToolClickEventHandler(AddressOf textBox3_ToolClick)
        ' 
        ' maskedTextBox1
        ' 
        maskedTextBox1.AutoSize = False
        maskedTextBox1.DataBindings.Add(New Web.Binding("Text", employeesBindingSource, "Phone", True))
        maskedTextBox1.Dock = Web.DockStyle.Fill
        maskedTextBox1.Location = New Drawing.Point(3, 153)
        maskedTextBox1.Mask = "(999) 000-0000"
        maskedTextBox1.Name = "maskedTextBox1"
        maskedTextBox1.Size = New Drawing.Size(214, 47)
        maskedTextBox1.TabIndex = 9
        maskedTextBox1.Text = "(   )    -"
        ' 
        ' label6
        ' 
        label6.Dock = Web.DockStyle.Fill
        label6.Location = New Drawing.Point(8, 108)
        label6.Margin = New Web.Padding(8)
        label6.Name = "label6"
        label6.Size = New Drawing.Size(204, 34)
        label6.TabIndex = 8
        label6.Text = "&Phone"
        label6.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' employeesTableAdapter
        ' 
        employeesTableAdapter.ClearBeforeFill = True
        ' 
        ' DataBinding
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(913, 610)
        Controls.Add(tableLayoutPanel1)
        Controls.Add(dataGridView1)
        IconSource = "resource.wx/Wisej.Ext.MaterialDesign/server-rack-with-three-levels.svg?color=#BF3" & "F3F"
        Name = "DataBinding"
        Text = "DataBinding Example"
        AddHandler Load, New EventHandler(AddressOf DataBinding_Load)
        CType(dataGridView1, ComponentModel.ISupportInitialize).EndInit()
        dataGridView1.ResumeLayout(False)
        CType(employeesBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(chinookDataSet, ComponentModel.ISupportInitialize).EndInit()
        tableLayoutPanel1.ResumeLayout(False)
        tableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

#End Region

    Private dataGridView1 As Web.DataGridView
    Private textBox1 As Web.TextBox
    Private label1 As Web.Label
    Private label2 As Web.Label
    Private textBox2 As Web.TextBox
    Private label3 As Web.Label
    Private dateTimePicker1 As Web.DateTimePicker
    Private label4 As Web.Label
    Private comboBox1 As Web.ComboBox
    Private tableLayoutPanel1 As Web.TableLayoutPanel
    Private label5 As Web.Label
    Private statusBar1 As Web.StatusBar
    Private colEmployeeid As Web.DataGridViewTextBoxColumn
    Private colLastname As Web.DataGridViewTextBoxColumn
    Private colFirstname As Web.DataGridViewTextBoxColumn
    Private colBirthdate As Web.DataGridViewDateTimePickerColumn
    Private colEmail As Web.DataGridViewTextBoxColumn
    Private employeesBindingSource As Web.BindingSource
    Private chinookDataSet As chinookDataSet
    Private employeesTableAdapter As chinookDataSetTableAdapters.employeesTableAdapter
    Private colTitle As Web.DataGridViewComboBoxColumn
    Private colPhone As Web.DataGridViewMaskedTextBoxColumn
    Private textBox3 As Web.TextBox
    Private maskedTextBox1 As Web.MaskedTextBox
    Private label6 As Web.Label
End Class
