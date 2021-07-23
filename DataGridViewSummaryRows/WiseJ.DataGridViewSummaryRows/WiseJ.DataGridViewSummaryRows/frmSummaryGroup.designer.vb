Partial Class frmSummaryGroup
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


#Region "Wisej Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim dataGridViewCellStyle1 As WiseJ.Web.DataGridViewCellStyle = New WiseJ.Web.DataGridViewCellStyle()
        dataGridView1 = New WiseJ.Web.DataGridView()
        Column0 = New WiseJ.Web.DataGridViewColumn()
        Column1 = New WiseJ.Web.DataGridViewColumn()
        Column2 = New WiseJ.Web.DataGridViewColumn()
        Column3 = New WiseJ.Web.DataGridViewColumn()
        Column4 = New WiseJ.Web.DataGridViewColumn()
        Column5 = New WiseJ.Web.DataGridViewColumn()
        Column7 = New WiseJ.Web.DataGridViewColumn()
        Column6 = New WiseJ.Web.DataGridViewColumn()
        Column8 = New WiseJ.Web.DataGridViewColumn()
        Column9 = New WiseJ.Web.DataGridViewColumn()
        Column10 = New WiseJ.Web.DataGridViewColumn()
        Column11 = New WiseJ.Web.DataGridViewColumn()
        Column12 = New WiseJ.Web.DataGridViewColumn()
        Column13 = New WiseJ.Web.DataGridViewColumn()
        CType(dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dataGridView1
        ' 
        dataGridView1.AutoSize = True
        dataGridView1.BorderStyle = WiseJ.Web.BorderStyle.None
        dataGridView1.CellBorderStyle = WiseJ.Web.DataGridViewCellBorderStyle.None
        dataGridView1.ColumnHeadersVisible = False
        dataGridView1.Columns.AddRange(New WiseJ.Web.DataGridViewColumn() {Column0, Column1, Column2, Column3, Column4, Column5, Column7, Column6, Column8, Column9, Column10, Column11, Column12, Column13})
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        dataGridView1.DefaultCellStyle = dataGridViewCellStyle1
        dataGridView1.DefaultRowHeight = 24
        dataGridView1.Font = New System.Drawing.Font("default, Helvetica", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        dataGridView1.Location = New System.Drawing.Point(18, 47)
        dataGridView1.MinimumSize = New System.Drawing.Size(0, 50)
        dataGridView1.Name = "dataGridView1"
        dataGridView1.RowHeadersVisible = False
        dataGridView1.Size = New System.Drawing.Size(1090, 50)
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
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = WiseJ.Web.AutoScaleMode.Font
        AutoScroll = True
        AutoScrollMargin = New System.Drawing.Size(0, 50)
        ClientSize = New System.Drawing.Size(883, 607)
        Controls.Add(dataGridView1)
        Name = "frmSummaryGroup"
        Text = "Summary Group"
        CType(dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

#End Region

    Friend WithEvents dataGridView1 As WiseJ.Web.DataGridView
    Friend WithEvents Column0 As WiseJ.Web.DataGridViewColumn
    Friend WithEvents Column1 As WiseJ.Web.DataGridViewColumn
    Friend WithEvents Column2 As WiseJ.Web.DataGridViewColumn
    Friend WithEvents Column3 As WiseJ.Web.DataGridViewColumn
    Friend WithEvents Column4 As WiseJ.Web.DataGridViewColumn
    Friend WithEvents Column5 As WiseJ.Web.DataGridViewColumn
    Friend WithEvents Column7 As WiseJ.Web.DataGridViewColumn
    Friend WithEvents Column6 As WiseJ.Web.DataGridViewColumn
    Friend WithEvents Column8 As WiseJ.Web.DataGridViewColumn
    Friend WithEvents Column9 As WiseJ.Web.DataGridViewColumn
    Friend WithEvents Column10 As WiseJ.Web.DataGridViewColumn
    Friend WithEvents Column11 As WiseJ.Web.DataGridViewColumn
    Friend WithEvents Column12 As WiseJ.Web.DataGridViewColumn
    Friend WithEvents Column13 As WiseJ.Web.DataGridViewColumn
End Class
