Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window3
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
        Dim ComponentTool1 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Me.dataGridView1 = New Wisej.Web.DataGridView()
        Me.colID = New Wisej.Web.DataGridViewColumn()
        Me.colFIRSTNAME = New Wisej.Web.DataGridViewColumn()
        Me.colNAME = New Wisej.Web.DataGridViewColumn()
        Me.colACTIVE = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.colDEPARTMENT = New Wisej.Web.DataGridViewComboBoxColumn()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridView1
        '
        Me.dataGridView1.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.colID, Me.colFIRSTNAME, Me.colNAME, Me.colACTIVE, Me.colDEPARTMENT})
        Me.dataGridView1.Location = New System.Drawing.Point(27, 27)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(594, 356)
        Me.dataGridView1.TabIndex = 0
        ComponentTool1.ImageSource = "spinner-plus"
        ComponentTool1.Position = Wisej.Web.LeftRightAlignment.Left
        ComponentTool1.ToolTipText = "Add new row"
        Me.dataGridView1.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool1})
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.Width = 70
        '
        'colFIRSTNAME
        '
        Me.colFIRSTNAME.HeaderText = "First Name"
        Me.colFIRSTNAME.Name = "colFIRSTNAME"
        Me.colFIRSTNAME.Width = 200
        '
        'colNAME
        '
        Me.colNAME.HeaderText = "Name"
        Me.colNAME.Name = "colNAME"
        Me.colNAME.SortMode = Wisej.Web.DataGridViewColumnSortMode.Automatic
        Me.colNAME.Width = 200
        '
        'colACTIVE
        '
        Me.colACTIVE.HeaderText = "Active"
        Me.colACTIVE.Name = "colACTIVE"
        Me.colACTIVE.Width = 70
        '
        'colDEPARTMENT
        '
        Me.colDEPARTMENT.HeaderText = "Department"
        Me.colDEPARTMENT.Items.AddRange(New Object() {"IT", "Finance", "Administration"})
        Me.colDEPARTMENT.Name = "colDEPARTMENT"
        '
        'Window3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 417)
        Me.CloseBox = False
        Me.Controls.Add(Me.dataGridView1)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Name = "Window3"
        Me.Text = "Form3"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents dataGridView1 As Wisej.Web.DataGridView
    Friend WithEvents colID As Wisej.Web.DataGridViewColumn
    Friend WithEvents colFIRSTNAME As Wisej.Web.DataGridViewColumn
    Friend WithEvents colNAME As Wisej.Web.DataGridViewColumn
    Friend WithEvents colACTIVE As Wisej.Web.DataGridViewCheckBoxColumn
    Friend WithEvents colDEPARTMENT As Wisej.Web.DataGridViewComboBoxColumn
End Class
