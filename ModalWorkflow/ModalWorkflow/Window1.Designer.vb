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
        Dim DataGridViewCellStyle1 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.label1 = New Wisej.Web.Label()
        Me.dataGrid = New Wisej.Web.DataGridView()
        Me.columnProperty = New Wisej.Web.DataGridViewColumn()
        Me.columnValue = New Wisej.Web.DataGridViewColumn()
        Me.buttonOK = New Wisej.Web.Button()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(36, 38)
        Me.label1.Margin = New Wisej.Web.Padding(12, 0, 12, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(152, 29)
        Me.label1.TabIndex = 3
        Me.label1.Text = "User Data:"
        '
        'dataGrid
        '
        Me.dataGrid.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.dataGrid.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.columnProperty, Me.columnValue})
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft
        Me.dataGrid.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataGrid.LiveResize = True
        Me.dataGrid.Location = New System.Drawing.Point(36, 103)
        Me.dataGrid.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.RowHeadersVisible = False
        Me.dataGrid.ShowColumnVisibilityMenu = False
        Me.dataGrid.Size = New System.Drawing.Size(709, 407)
        Me.dataGrid.TabIndex = 1
        '
        'columnProperty
        '
        Me.columnProperty.HeaderText = "Property"
        Me.columnProperty.MinimumWidth = 13
        Me.columnProperty.Name = "columnProperty"
        Me.columnProperty.Width = 267
        '
        'columnValue
        '
        Me.columnValue.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill
        Me.columnValue.HeaderText = "Value"
        Me.columnValue.Name = "columnValue"
        '
        'buttonOK
        '
        Me.buttonOK.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.buttonOK.AppearanceKey = "button-ok"
        Me.buttonOK.Location = New System.Drawing.Point(544, 38)
        Me.buttonOK.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.buttonOK.Name = "buttonOK"
        Me.buttonOK.Size = New System.Drawing.Size(204, 43)
        Me.buttonOK.TabIndex = 2
        Me.buttonOK.Text = "Edit"
        '
        'Window1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 26.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 550)
        Me.Controls.Add(Me.buttonOK)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Helvetica", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New Wisej.Web.Padding(9, 0, 9, 0)
        Me.MinimizeBox = False
        Me.Name = "Window1"
        Me.StartPosition = Wisej.Web.FormStartPosition.CenterScreen
        Me.Text = "Window1"
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


#End Region

    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents dataGrid As Wisej.Web.DataGridView
    Friend WithEvents columnProperty As Wisej.Web.DataGridViewColumn
    Friend WithEvents columnValue As Wisej.Web.DataGridViewColumn
    Friend WithEvents buttonOK As Wisej.Web.Button
End Class
