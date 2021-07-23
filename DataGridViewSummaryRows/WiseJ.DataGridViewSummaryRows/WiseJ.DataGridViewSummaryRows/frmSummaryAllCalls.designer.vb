
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSummaryAllCalls
    Inherits WiseJ.Web.Form
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim dataGridViewCellStyle3 As WiseJ.Web.DataGridViewCellStyle = New WiseJ.Web.DataGridViewCellStyle()
        label1 = New WiseJ.Web.Label()
        dataGrid = New WiseJ.Web.DataGridView()
        buttonEdit = New WiseJ.Web.Button()
        buttonAdd = New WiseJ.Web.Button()
        btnLoadFromDataSource = New WiseJ.Web.Button()
        btnLoadData = New WiseJ.Web.Button()
        btnSummary1 = New WiseJ.Web.Button()
        btnSummary2 = New WiseJ.Web.Button()
        btnSummary3 = New WiseJ.Web.Button()
        btnSummary4 = New WiseJ.Web.Button()
        btnSummary8 = New WiseJ.Web.Button()
        btnSummary7 = New WiseJ.Web.Button()
        btnSummary6 = New WiseJ.Web.Button()
        btnSummary5 = New WiseJ.Web.Button()
        btnRemoveSumary = New WiseJ.Web.Button()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.Location = New System.Drawing.Point(36, 38)
        label1.Margin = New WiseJ.Web.Padding(12, 0, 12, 0)
        label1.Name = "label1"
        label1.Size = New System.Drawing.Size(152, 29)
        label1.TabIndex = 3
        label1.Text = "User Data:"
        ' 
        ' dataGrid
        ' 
        dataGrid.Anchor = WiseJ.Web.AnchorStyles.Top Or WiseJ.Web.AnchorStyles.Bottom Or WiseJ.Web.AnchorStyles.Left Or WiseJ.Web.AnchorStyles.Right
        dataGridViewCellStyle3.Alignment = WiseJ.Web.DataGridViewContentAlignment.MiddleLeft
        dataGrid.DefaultCellStyle = dataGridViewCellStyle3
        dataGrid.LiveResize = True
        dataGrid.Location = New System.Drawing.Point(36, 176)
        dataGrid.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        dataGrid.Name = "dataGrid"
        dataGrid.ReadOnly = True
        dataGrid.RowHeadersVisible = False
        dataGrid.ShowColumnVisibilityMenu = False
        dataGrid.Size = New System.Drawing.Size(811, 390)
        dataGrid.TabIndex = 1
        ' 
        ' buttonEdit
        ' 
        buttonEdit.Anchor = WiseJ.Web.AnchorStyles.Top Or WiseJ.Web.AnchorStyles.Right
        buttonEdit.AppearanceKey = "button-ok"
        buttonEdit.Location = New System.Drawing.Point(779, 38)
        buttonEdit.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        buttonEdit.Name = "buttonEdit"
        buttonEdit.Size = New System.Drawing.Size(74, 43)
        buttonEdit.TabIndex = 2
        buttonEdit.Text = "Edit"
        ' 
        ' buttonAdd
        ' 
        buttonAdd.Anchor = WiseJ.Web.AnchorStyles.Top Or WiseJ.Web.AnchorStyles.Right
        buttonAdd.AppearanceKey = "button"
        buttonAdd.Location = New System.Drawing.Point(656, 38)
        buttonAdd.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        buttonAdd.Name = "buttonAdd"
        buttonAdd.Size = New System.Drawing.Size(100, 43)
        buttonAdd.TabIndex = 4
        buttonAdd.Text = "Add New"
        ' 
        ' btnLoadFromDataSource
        ' 
        btnLoadFromDataSource.Font = New System.Drawing.Font("Helvetica", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        btnLoadFromDataSource.Location = New System.Drawing.Point(173, 46)
        btnLoadFromDataSource.Name = "btnLoadFromDataSource"
        btnLoadFromDataSource.Size = New System.Drawing.Size(143, 35)
        btnLoadFromDataSource.TabIndex = 5
        btnLoadFromDataSource.Text = "Load from DataSource"
        ' 
        ' btnLoadData
        ' 
        btnLoadData.Font = New System.Drawing.Font("Helvetica", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        btnLoadData.Location = New System.Drawing.Point(322, 46)
        btnLoadData.Name = "btnLoadData"
        btnLoadData.Size = New System.Drawing.Size(143, 35)
        btnLoadData.TabIndex = 6
        btnLoadData.Text = "Load Data"
        ' 
        ' btnSummary1
        ' 
        btnSummary1.Font = New System.Drawing.Font("Helvetica", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        btnSummary1.Location = New System.Drawing.Point(36, 96)
        btnSummary1.Name = "btnSummary1"
        btnSummary1.Size = New System.Drawing.Size(105, 35)
        btnSummary1.TabIndex = 7
        btnSummary1.Text = "Summary type 1"
        ' 
        ' btnSummary2
        ' 
        btnSummary2.Font = New System.Drawing.Font("Helvetica", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        btnSummary2.Location = New System.Drawing.Point(144, 96)
        btnSummary2.Name = "btnSummary2"
        btnSummary2.Size = New System.Drawing.Size(105, 35)
        btnSummary2.TabIndex = 8
        btnSummary2.Text = "Summary type 2"
        ' 
        ' btnSummary3
        ' 
        btnSummary3.Font = New System.Drawing.Font("Helvetica", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        btnSummary3.Location = New System.Drawing.Point(252, 96)
        btnSummary3.Name = "btnSummary3"
        btnSummary3.Size = New System.Drawing.Size(105, 35)
        btnSummary3.TabIndex = 9
        btnSummary3.Text = "Summary type 3"
        ' 
        ' btnSummary4
        ' 
        btnSummary4.Font = New System.Drawing.Font("Helvetica", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        btnSummary4.Location = New System.Drawing.Point(360, 96)
        btnSummary4.Name = "btnSummary4"
        btnSummary4.Size = New System.Drawing.Size(105, 35)
        btnSummary4.TabIndex = 10
        btnSummary4.Text = "Summary type 4"
        ' 
        ' btnSummary8
        ' 
        btnSummary8.Font = New System.Drawing.Font("Helvetica", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        btnSummary8.Location = New System.Drawing.Point(360, 135)
        btnSummary8.Name = "btnSummary8"
        btnSummary8.Size = New System.Drawing.Size(105, 35)
        btnSummary8.TabIndex = 14
        btnSummary8.Text = "Summary type 8"
        ' 
        ' btnSummary7
        ' 
        btnSummary7.Font = New System.Drawing.Font("Helvetica", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        btnSummary7.Location = New System.Drawing.Point(252, 135)
        btnSummary7.Name = "btnSummary7"
        btnSummary7.Size = New System.Drawing.Size(105, 35)
        btnSummary7.TabIndex = 13
        btnSummary7.Text = "Summary type 7"
        ' 
        ' btnSummary6
        ' 
        btnSummary6.Font = New System.Drawing.Font("Helvetica", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        btnSummary6.Location = New System.Drawing.Point(144, 135)
        btnSummary6.Name = "btnSummary6"
        btnSummary6.Size = New System.Drawing.Size(105, 35)
        btnSummary6.TabIndex = 12
        btnSummary6.Text = "Summary type 6"
        ' 
        ' btnSummary5
        ' 
        btnSummary5.Font = New System.Drawing.Font("Helvetica", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        btnSummary5.Location = New System.Drawing.Point(36, 135)
        btnSummary5.Name = "btnSummary5"
        btnSummary5.Size = New System.Drawing.Size(105, 35)
        btnSummary5.TabIndex = 11
        btnSummary5.Text = "Summary type 5"
        ' 
        ' btnRemoveSumary
        ' 
        btnRemoveSumary.Font = New System.Drawing.Font("Helvetica", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        btnRemoveSumary.Location = New System.Drawing.Point(471, 135)
        btnRemoveSumary.Name = "btnRemoveSumary"
        btnRemoveSumary.Size = New System.Drawing.Size(111, 35)
        btnRemoveSumary.TabIndex = 15
        btnRemoveSumary.Text = "Remove Summary"
        ' 
        ' frmSummaryAllCalls
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(12.0F, 26.0F)
        AutoScaleMode = WiseJ.Web.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(900, 593)
        Controls.Add(btnRemoveSumary)
        Controls.Add(btnSummary8)
        Controls.Add(btnSummary7)
        Controls.Add(btnSummary6)
        Controls.Add(btnSummary5)
        Controls.Add(btnSummary4)
        Controls.Add(btnSummary3)
        Controls.Add(btnSummary2)
        Controls.Add(btnSummary1)
        Controls.Add(btnLoadData)
        Controls.Add(btnLoadFromDataSource)
        Controls.Add(buttonAdd)
        Controls.Add(buttonEdit)
        Controls.Add(dataGrid)
        Controls.Add(label1)
        Font = New System.Drawing.Font("Helvetica", 16.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Margin = New WiseJ.Web.Padding(9, 0, 9, 0)
        MinimizeBox = False
        Name = "frmSummaryAllCalls"
        StartPosition = WiseJ.Web.FormStartPosition.CenterScreen
        Text = "Window1"
        CType(dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

#End Region

    Friend WithEvents label1 As WiseJ.Web.Label
    Friend WithEvents dataGrid As WiseJ.Web.DataGridView
    Friend WithEvents buttonEdit As WiseJ.Web.Button
    Friend WithEvents buttonAdd As WiseJ.Web.Button
    Friend WithEvents btnLoadFromDataSource As WiseJ.Web.Button
    Friend WithEvents btnLoadData As WiseJ.Web.Button
    Friend WithEvents btnSummary1 As WiseJ.Web.Button
    Friend WithEvents btnSummary2 As WiseJ.Web.Button
    Friend WithEvents btnSummary3 As WiseJ.Web.Button
    Friend WithEvents btnSummary4 As WiseJ.Web.Button
    Friend WithEvents btnSummary8 As WiseJ.Web.Button
    Friend WithEvents btnSummary7 As WiseJ.Web.Button
    Friend WithEvents btnSummary6 As WiseJ.Web.Button
    Friend WithEvents btnSummary5 As WiseJ.Web.Button
    Friend WithEvents btnRemoveSumary As WiseJ.Web.Button
End Class
