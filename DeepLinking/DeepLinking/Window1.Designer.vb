Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window1
    Inherits Wisej.Web.Form
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


#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim dataGridViewCellStyle1 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        label1 = New Wisej.Web.Label()
        dataGrid = New Wisej.Web.DataGridView()
        buttonEdit = New Wisej.Web.Button()
        buttonAdd = New Wisej.Web.Button()
        CType(dataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.Location = New Drawing.Point(27, 35)
        label1.Margin = New Wisej.Web.Padding(9, 0, 9, 0)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(114, 27)
        label1.TabIndex = 3
        label1.Text = "User Data:"
        ' 
        ' dataGrid
        ' 
        dataGrid.Anchor = Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Left Or Wisej.Web.AnchorStyles.Right
        dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft
        dataGrid.DefaultCellStyle = dataGridViewCellStyle1
        dataGrid.LiveResize = True
        dataGrid.Location = New Drawing.Point(27, 95)
        dataGrid.Name = "dataGrid"
        dataGrid.ReadOnly = True
        dataGrid.RowHeadersVisible = False
        dataGrid.ShowColumnVisibilityMenu = False
        dataGrid.Size = New Drawing.Size(613, 378)
        dataGrid.TabIndex = 1
        AddHandler dataGrid.CellDoubleClick, New Wisej.Web.DataGridViewCellEventHandler(AddressOf dataGrid_CellDoubleClick)
        ' 
        ' buttonEdit
        ' 
        buttonEdit.Anchor = Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right
        buttonEdit.AppearanceKey = "button-ok"
        buttonEdit.Location = New Drawing.Point(487, 35)
        buttonEdit.Name = "buttonEdit"
        buttonEdit.Size = New Drawing.Size(153, 40)
        buttonEdit.TabIndex = 2
        buttonEdit.Text = "Edit"
        AddHandler buttonEdit.Click, New EventHandler(AddressOf buttonEdit_Click)
        ' 
        ' buttonAdd
        ' 
        buttonAdd.Anchor = Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right
        buttonAdd.AppearanceKey = "button"
        buttonAdd.Location = New Drawing.Point(316, 35)
        buttonAdd.Name = "buttonAdd"
        buttonAdd.Size = New Drawing.Size(153, 40)
        buttonAdd.TabIndex = 4
        buttonAdd.Text = "Add New"
        AddHandler buttonAdd.Click, New EventHandler(AddressOf buttonAdd_Click)
        ' 
        ' Window1
        ' 
        AutoScaleDimensions = New Drawing.SizeF(9.0F, 24.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(675, 508)
        Controls.Add(buttonAdd)
        Controls.Add(buttonEdit)
        Controls.Add(dataGrid)
        Controls.Add(label1)
        CloseBox = False
        Font = New Drawing.Font("Helvetica", 16.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Margin = New Wisej.Web.Padding(9, 0, 9, 0)
        MinimizeBox = False
        Name = "Window1"
        StartPosition = Wisej.Web.FormStartPosition.CenterScreen
        Text = "Window1"
        AddHandler Load, New EventHandler(AddressOf Window1_Load)
        CType(dataGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub


#End Region

    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents dataGrid As Wisej.Web.DataGridView
    Friend WithEvents buttonEdit As Wisej.Web.Button
    Friend WithEvents buttonAdd As Wisej.Web.Button
End Class
