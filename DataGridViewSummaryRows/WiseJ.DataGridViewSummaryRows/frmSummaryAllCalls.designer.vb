<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSummaryAllCalls
    Inherits Wisej.Web.Form
    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.label1 = New Wisej.Web.Label()
        Me.dataGrid = New Wisej.Web.DataGridView()
        Me.buttonEdit = New Wisej.Web.Button()
        Me.buttonAdd = New Wisej.Web.Button()
        Me.btnLoadFromDataSource = New Wisej.Web.Button()
        Me.btnLoadData = New Wisej.Web.Button()
        Me.btnSummary1 = New Wisej.Web.Button()
        Me.btnSummary2 = New Wisej.Web.Button()
        Me.btnSummary3 = New Wisej.Web.Button()
        Me.btnSummary4 = New Wisej.Web.Button()
        Me.btnSummary8 = New Wisej.Web.Button()
        Me.btnSummary7 = New Wisej.Web.Button()
        Me.btnSummary6 = New Wisej.Web.Button()
        Me.btnSummary5 = New Wisej.Web.Button()
        Me.btnRemoveSumary = New Wisej.Web.Button()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(36, 39)
        Me.label1.Margin = New Wisej.Web.Padding(12, 0, 12, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(152, 30)
        Me.label1.TabIndex = 3
        Me.label1.Text = "User Data:"
        '
        'dataGrid
        '
        Me.dataGrid.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft
        Me.dataGrid.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataGrid.LiveResize = True
        Me.dataGrid.Location = New System.Drawing.Point(36, 183)
        Me.dataGrid.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.ReadOnly = True
        Me.dataGrid.RowHeadersVisible = False
        Me.dataGrid.ShowColumnVisibilityMenu = False
        Me.dataGrid.Size = New System.Drawing.Size(809, 403)
        Me.dataGrid.TabIndex = 1
        '
        'buttonEdit
        '
        Me.buttonEdit.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.buttonEdit.AppearanceKey = "button-ok"
        Me.buttonEdit.Location = New System.Drawing.Point(779, 39)
        Me.buttonEdit.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.buttonEdit.Name = "buttonEdit"
        Me.buttonEdit.Size = New System.Drawing.Size(74, 45)
        Me.buttonEdit.TabIndex = 2
        Me.buttonEdit.Text = "Edit"
        '
        'buttonAdd
        '
        Me.buttonAdd.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.buttonAdd.AppearanceKey = "button"
        Me.buttonAdd.Location = New System.Drawing.Point(656, 39)
        Me.buttonAdd.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.buttonAdd.Name = "buttonAdd"
        Me.buttonAdd.Size = New System.Drawing.Size(100, 45)
        Me.buttonAdd.TabIndex = 4
        Me.buttonAdd.Text = "Add New"
        '
        'btnLoadFromDataSource
        '
        Me.btnLoadFromDataSource.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLoadFromDataSource.Location = New System.Drawing.Point(173, 48)
        Me.btnLoadFromDataSource.Name = "btnLoadFromDataSource"
        Me.btnLoadFromDataSource.Size = New System.Drawing.Size(143, 36)
        Me.btnLoadFromDataSource.TabIndex = 5
        Me.btnLoadFromDataSource.Text = "Load from DataSource"
        '
        'btnLoadData
        '
        Me.btnLoadData.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLoadData.Location = New System.Drawing.Point(322, 48)
        Me.btnLoadData.Name = "btnLoadData"
        Me.btnLoadData.Size = New System.Drawing.Size(143, 36)
        Me.btnLoadData.TabIndex = 6
        Me.btnLoadData.Text = "Load Data"
        '
        'btnSummary1
        '
        Me.btnSummary1.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSummary1.Location = New System.Drawing.Point(36, 100)
        Me.btnSummary1.Name = "btnSummary1"
        Me.btnSummary1.Size = New System.Drawing.Size(105, 36)
        Me.btnSummary1.TabIndex = 7
        Me.btnSummary1.Text = "Summary type 1"
        '
        'btnSummary2
        '
        Me.btnSummary2.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSummary2.Location = New System.Drawing.Point(144, 100)
        Me.btnSummary2.Name = "btnSummary2"
        Me.btnSummary2.Size = New System.Drawing.Size(105, 36)
        Me.btnSummary2.TabIndex = 8
        Me.btnSummary2.Text = "Summary type 2"
        '
        'btnSummary3
        '
        Me.btnSummary3.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSummary3.Location = New System.Drawing.Point(252, 100)
        Me.btnSummary3.Name = "btnSummary3"
        Me.btnSummary3.Size = New System.Drawing.Size(105, 36)
        Me.btnSummary3.TabIndex = 9
        Me.btnSummary3.Text = "Summary type 3"
        '
        'btnSummary4
        '
        Me.btnSummary4.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSummary4.Location = New System.Drawing.Point(360, 100)
        Me.btnSummary4.Name = "btnSummary4"
        Me.btnSummary4.Size = New System.Drawing.Size(105, 36)
        Me.btnSummary4.TabIndex = 10
        Me.btnSummary4.Text = "Summary type 4"
        '
        'btnSummary8
        '
        Me.btnSummary8.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSummary8.Location = New System.Drawing.Point(360, 140)
        Me.btnSummary8.Name = "btnSummary8"
        Me.btnSummary8.Size = New System.Drawing.Size(105, 36)
        Me.btnSummary8.TabIndex = 14
        Me.btnSummary8.Text = "Summary type 8"
        '
        'btnSummary7
        '
        Me.btnSummary7.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSummary7.Location = New System.Drawing.Point(252, 140)
        Me.btnSummary7.Name = "btnSummary7"
        Me.btnSummary7.Size = New System.Drawing.Size(105, 36)
        Me.btnSummary7.TabIndex = 13
        Me.btnSummary7.Text = "Summary type 7"
        '
        'btnSummary6
        '
        Me.btnSummary6.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSummary6.Location = New System.Drawing.Point(144, 140)
        Me.btnSummary6.Name = "btnSummary6"
        Me.btnSummary6.Size = New System.Drawing.Size(105, 36)
        Me.btnSummary6.TabIndex = 12
        Me.btnSummary6.Text = "Summary type 6"
        '
        'btnSummary5
        '
        Me.btnSummary5.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSummary5.Location = New System.Drawing.Point(36, 140)
        Me.btnSummary5.Name = "btnSummary5"
        Me.btnSummary5.Size = New System.Drawing.Size(105, 36)
        Me.btnSummary5.TabIndex = 11
        Me.btnSummary5.Text = "Summary type 5"
        '
        'btnRemoveSumary
        '
        Me.btnRemoveSumary.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRemoveSumary.Location = New System.Drawing.Point(471, 140)
        Me.btnRemoveSumary.Name = "btnRemoveSumary"
        Me.btnRemoveSumary.Size = New System.Drawing.Size(111, 36)
        Me.btnRemoveSumary.TabIndex = 15
        Me.btnRemoveSumary.Text = "Remove Summary"
        '
        'frmSummaryAllCalls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 27.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 616)
        Me.Controls.Add(Me.btnRemoveSumary)
        Me.Controls.Add(Me.btnSummary8)
        Me.Controls.Add(Me.btnSummary7)
        Me.Controls.Add(Me.btnSummary6)
        Me.Controls.Add(Me.btnSummary5)
        Me.Controls.Add(Me.btnSummary4)
        Me.Controls.Add(Me.btnSummary3)
        Me.Controls.Add(Me.btnSummary2)
        Me.Controls.Add(Me.btnSummary1)
        Me.Controls.Add(Me.btnLoadData)
        Me.Controls.Add(Me.btnLoadFromDataSource)
        Me.Controls.Add(Me.buttonAdd)
        Me.Controls.Add(Me.buttonEdit)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Helvetica", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New Wisej.Web.Padding(9, 0, 9, 0)
        Me.MinimizeBox = False
        Me.Name = "frmSummaryAllCalls"
        Me.StartPosition = Wisej.Web.FormStartPosition.CenterScreen
        Me.Text = "Window1"
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents dataGrid As Wisej.Web.DataGridView
    Friend WithEvents buttonEdit As Wisej.Web.Button
    Friend WithEvents buttonAdd As Wisej.Web.Button
    Friend WithEvents btnLoadFromDataSource As Wisej.Web.Button
    Friend WithEvents btnLoadData As Wisej.Web.Button
    Friend WithEvents btnSummary1 As Wisej.Web.Button
    Friend WithEvents btnSummary2 As Wisej.Web.Button
    Friend WithEvents btnSummary3 As Wisej.Web.Button
    Friend WithEvents btnSummary4 As Wisej.Web.Button
    Friend WithEvents btnSummary8 As Wisej.Web.Button
    Friend WithEvents btnSummary7 As Wisej.Web.Button
    Friend WithEvents btnSummary6 As Wisej.Web.Button
    Friend WithEvents btnSummary5 As Wisej.Web.Button
    Friend WithEvents btnRemoveSumary As Wisej.Web.Button
End Class
