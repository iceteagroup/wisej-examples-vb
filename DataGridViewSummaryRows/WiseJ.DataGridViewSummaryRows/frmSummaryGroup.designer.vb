<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSummaryGroup
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

#Region "Wisej Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim dataGridViewCellStyle1 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        dataGridView1 = New Wisej.Web.DataGridView()
        Column0 = New Wisej.Web.DataGridViewColumn()
        Column1 = New Wisej.Web.DataGridViewColumn()
        Column2 = New Wisej.Web.DataGridViewColumn()
        Column3 = New Wisej.Web.DataGridViewColumn()
        Column4 = New Wisej.Web.DataGridViewColumn()
        Column5 = New Wisej.Web.DataGridViewColumn()
        Column7 = New Wisej.Web.DataGridViewColumn()
        Column6 = New Wisej.Web.DataGridViewColumn()
        Column8 = New Wisej.Web.DataGridViewColumn()
        Column9 = New Wisej.Web.DataGridViewColumn()
        Column10 = New Wisej.Web.DataGridViewColumn()
        Column11 = New Wisej.Web.DataGridViewColumn()
        Column12 = New Wisej.Web.DataGridViewColumn()
        Column13 = New Wisej.Web.DataGridViewColumn()
        CType(dataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dataGridView1
        ' 
        dataGridView1.AutoSize = True
        dataGridView1.BorderStyle = Wisej.Web.BorderStyle.None
        dataGridView1.CellBorderStyle = Wisej.Web.DataGridViewCellBorderStyle.None
        dataGridView1.ColumnHeadersVisible = False
        dataGridView1.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Column0, Column1, Column2, Column3, Column4, Column5, Column7, Column6, Column8, Column9, Column10, Column11, Column12, Column13})
        dataGridViewCellStyle1.BackColor = Drawing.Color.White
        dataGridViewCellStyle1.ForeColor = Drawing.Color.Black
        dataGridView1.DefaultCellStyle = dataGridViewCellStyle1
        dataGridView1.DefaultRowHeight = 24
        dataGridView1.Font = New Drawing.Font("default, Helvetica", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        dataGridView1.Location = New Drawing.Point(18, 47)
        dataGridView1.MinimumSize = New Drawing.Size(0, 50)
        dataGridView1.Name = "dataGridView1"
        dataGridView1.RowHeadersVisible = False
        dataGridView1.Size = New Drawing.Size(1090, 50)
        dataGridView1.TabIndex = 0
        ' 
        ' Column0
        ' 
        Column0.HeaderText = "Column0"
        Column0.Name = "Column0"
        Column0.Visible = False
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Column1"
        Column1.Name = "Column1"
        Column1.Width = 130
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Column2"
        Column2.Name = "Column2"
        Column2.Width = 80
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Column3"
        Column3.Name = "Column3"
        Column3.Width = 80
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Column4"
        Column4.Name = "Column4"
        Column4.Width = 80
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Column5"
        Column5.Name = "Column5"
        Column5.Width = 80
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Column7"
        Column7.Name = "Column7"
        Column7.Width = 80
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Column6"
        Column6.Name = "Column6"
        Column6.Width = 80
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Column8"
        Column8.Name = "Column8"
        Column8.Width = 80
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Column9"
        Column9.Name = "Column9"
        Column9.Width = 80
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Column10"
        Column10.Name = "Column10"
        Column10.Width = 80
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Column11"
        Column11.Name = "Column11"
        Column11.Width = 80
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Column12"
        Column12.Name = "Column12"
        Column12.Width = 80
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "Column13"
        Column13.Name = "Column13"
        Column13.Width = 80
        ' 
        ' frmSummaryGroup
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        AutoScroll = True
        AutoScrollMargin = New Drawing.Size(0, 50)
        ClientSize = New Drawing.Size(883, 607)
        Controls.Add(dataGridView1)
        Name = "frmSummaryGroup"
        Text = "Summary Group"
        CType(dataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region

    Friend WithEvents dataGridView1 As Wisej.Web.DataGridView
    Friend WithEvents Column0 As Wisej.Web.DataGridViewColumn
    Friend WithEvents Column1 As Wisej.Web.DataGridViewColumn
    Friend WithEvents Column2 As Wisej.Web.DataGridViewColumn
    Friend WithEvents Column3 As Wisej.Web.DataGridViewColumn
    Friend WithEvents Column4 As Wisej.Web.DataGridViewColumn
    Friend WithEvents Column5 As Wisej.Web.DataGridViewColumn
    Friend WithEvents Column7 As Wisej.Web.DataGridViewColumn
    Friend WithEvents Column6 As Wisej.Web.DataGridViewColumn
    Friend WithEvents Column8 As Wisej.Web.DataGridViewColumn
    Friend WithEvents Column9 As Wisej.Web.DataGridViewColumn
    Friend WithEvents Column10 As Wisej.Web.DataGridViewColumn
    Friend WithEvents Column11 As Wisej.Web.DataGridViewColumn
    Friend WithEvents Column12 As Wisej.Web.DataGridViewColumn
    Friend WithEvents Column13 As Wisej.Web.DataGridViewColumn
End Class
