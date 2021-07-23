
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSummaryHugeData1
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
        dgvMaster = New WiseJ.Web.DataGridView()
        colVendorID = New WiseJ.Web.DataGridViewColumn()
        colSubTotal = New WiseJ.Web.DataGridViewColumn()
        colTaxAmt = New WiseJ.Web.DataGridViewColumn()
        colFreight = New WiseJ.Web.DataGridViewColumn()
        colTotalDue = New WiseJ.Web.DataGridViewColumn()
        btnLoadData = New WiseJ.Web.Button()
        btnAddSummaryRow = New WiseJ.Web.Button()
        button1 = New WiseJ.Web.Button()
        groupBox1 = New WiseJ.Web.GroupBox()
        lblTotalDue = New WiseJ.Web.Label()
        label6 = New WiseJ.Web.Label()
        lblFreight = New WiseJ.Web.Label()
        label5 = New WiseJ.Web.Label()
        lblTaxAmnt = New WiseJ.Web.Label()
        label4 = New WiseJ.Web.Label()
        lblSubTotal = New WiseJ.Web.Label()
        label2 = New WiseJ.Web.Label()
        lblHeaderCount = New WiseJ.Web.Label()
        label1 = New WiseJ.Web.Label()
        CType(dgvMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        groupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvMaster
        ' 
        dgvMaster.AutoGenerateColumns = False
        dgvMaster.Columns.AddRange(New WiseJ.Web.DataGridViewColumn() {colVendorID, colSubTotal, colTaxAmt, colFreight, colTotalDue})
        dgvMaster.Dock = WiseJ.Web.DockStyle.Top
        dgvMaster.Location = New System.Drawing.Point(0, 0)
        dgvMaster.Name = "dgvMaster"
        dgvMaster.Size = New System.Drawing.Size(1040, 345)
        dgvMaster.TabIndex = 1
        ' 
        ' colVendorID
        ' 
        colVendorID.DataPropertyName = "VendorID"
        colVendorID.HeaderText = "VendorID"
        colVendorID.Name = "colVendorID"
        ' 
        ' colSubTotal
        ' 
        colSubTotal.DataPropertyName = "SubTotal"
        colSubTotal.HeaderText = "SubTotal"
        colSubTotal.Name = "colSubTotal"
        ' 
        ' colTaxAmt
        ' 
        colTaxAmt.DataPropertyName = "TaxAmt"
        colTaxAmt.HeaderText = "TaxAmount"
        colTaxAmt.Name = "colTaxAmt"
        ' 
        ' colFreight
        ' 
        colFreight.DataPropertyName = "Freight"
        colFreight.HeaderText = "Freight"
        colFreight.Name = "colFreight"
        ' 
        ' colTotalDue
        ' 
        colTotalDue.DataPropertyName = "TotalDue"
        colTotalDue.HeaderText = "TotalDue"
        colTotalDue.Name = "colTotalDue"
        ' 
        ' btnLoadData
        ' 
        btnLoadData.Anchor = WiseJ.Web.AnchorStyles.Top Or WiseJ.Web.AnchorStyles.Bottom Or WiseJ.Web.AnchorStyles.Left
        btnLoadData.Location = New System.Drawing.Point(43, 368)
        btnLoadData.Name = "btnLoadData"
        btnLoadData.Size = New System.Drawing.Size(177, 27)
        btnLoadData.TabIndex = 2
        btnLoadData.Text = "Load Data"
        ' 
        ' btnAddSummaryRow
        ' 
        btnAddSummaryRow.Location = New System.Drawing.Point(43, 401)
        btnAddSummaryRow.Name = "btnAddSummaryRow"
        btnAddSummaryRow.Size = New System.Drawing.Size(177, 27)
        btnAddSummaryRow.TabIndex = 5
        btnAddSummaryRow.Text = "Add Summary Total"
        ' 
        ' button1
        ' 
        button1.Location = New System.Drawing.Point(43, 434)
        button1.Name = "button1"
        button1.Size = New System.Drawing.Size(177, 27)
        button1.TabIndex = 14
        button1.Text = "Add Summary by VendorID"
        ' 
        ' groupBox1
        ' 
        groupBox1.Controls.Add(lblTotalDue)
        groupBox1.Controls.Add(label6)
        groupBox1.Controls.Add(lblFreight)
        groupBox1.Controls.Add(label5)
        groupBox1.Controls.Add(lblTaxAmnt)
        groupBox1.Controls.Add(label4)
        groupBox1.Controls.Add(lblSubTotal)
        groupBox1.Controls.Add(label2)
        groupBox1.Controls.Add(lblHeaderCount)
        groupBox1.Controls.Add(label1)
        groupBox1.Location = New System.Drawing.Point(258, 365)
        groupBox1.Name = "groupBox1"
        groupBox1.Size = New System.Drawing.Size(282, 175)
        groupBox1.TabIndex = 15
        groupBox1.Text = "Just for compare with summary"
        ' 
        ' lblTotalDue
        ' 
        lblTotalDue.AutoSize = True
        lblTotalDue.Location = New System.Drawing.Point(135, 141)
        lblTotalDue.Name = "lblTotalDue"
        lblTotalDue.Size = New System.Drawing.Size(11, 15)
        lblTotalDue.TabIndex = 23
        lblTotalDue.Text = "0"
        ' 
        ' label6
        ' 
        label6.Anchor = WiseJ.Web.AnchorStyles.Top Or WiseJ.Web.AnchorStyles.Left Or WiseJ.Web.AnchorStyles.Right
        label6.AutoSize = True
        label6.Location = New System.Drawing.Point(16, 141)
        label6.Name = "label6"
        label6.Size = New System.Drawing.Size(60, 15)
        label6.TabIndex = 22
        label6.Text = "TotalDue: "
        ' 
        ' lblFreight
        ' 
        lblFreight.AutoSize = True
        lblFreight.Location = New System.Drawing.Point(135, 111)
        lblFreight.Name = "lblFreight"
        lblFreight.Size = New System.Drawing.Size(11, 15)
        lblFreight.TabIndex = 21
        lblFreight.Text = "0"
        ' 
        ' label5
        ' 
        label5.Anchor = WiseJ.Web.AnchorStyles.Top Or WiseJ.Web.AnchorStyles.Left Or WiseJ.Web.AnchorStyles.Right
        label5.AutoSize = True
        label5.Location = New System.Drawing.Point(16, 111)
        label5.Name = "label5"
        label5.Size = New System.Drawing.Size(48, 15)
        label5.TabIndex = 20
        label5.Text = "Freight: "
        ' 
        ' lblTaxAmnt
        ' 
        lblTaxAmnt.AutoSize = True
        lblTaxAmnt.Location = New System.Drawing.Point(135, 81)
        lblTaxAmnt.Name = "lblTaxAmnt"
        lblTaxAmnt.Size = New System.Drawing.Size(11, 15)
        lblTaxAmnt.TabIndex = 19
        lblTaxAmnt.Text = "0"
        ' 
        ' label4
        ' 
        label4.Anchor = WiseJ.Web.AnchorStyles.Top Or WiseJ.Web.AnchorStyles.Left Or WiseJ.Web.AnchorStyles.Right
        label4.AutoSize = True
        label4.Location = New System.Drawing.Point(16, 81)
        label4.Name = "label4"
        label4.Size = New System.Drawing.Size(74, 15)
        label4.TabIndex = 18
        label4.Text = "TaxAmount: "
        ' 
        ' lblSubTotal
        ' 
        lblSubTotal.AutoSize = True
        lblSubTotal.Location = New System.Drawing.Point(135, 51)
        lblSubTotal.Name = "lblSubTotal"
        lblSubTotal.Size = New System.Drawing.Size(11, 15)
        lblSubTotal.TabIndex = 17
        lblSubTotal.Text = "0"
        ' 
        ' label2
        ' 
        label2.Anchor = WiseJ.Web.AnchorStyles.Top Or WiseJ.Web.AnchorStyles.Left Or WiseJ.Web.AnchorStyles.Right
        label2.AutoSize = True
        label2.Location = New System.Drawing.Point(16, 51)
        label2.Name = "label2"
        label2.Size = New System.Drawing.Size(60, 15)
        label2.TabIndex = 16
        label2.Text = "SubTotal: "
        ' 
        ' lblHeaderCount
        ' 
        lblHeaderCount.AutoSize = True
        lblHeaderCount.Location = New System.Drawing.Point(135, 21)
        lblHeaderCount.Name = "lblHeaderCount"
        lblHeaderCount.Size = New System.Drawing.Size(11, 15)
        lblHeaderCount.TabIndex = 15
        lblHeaderCount.Text = "0"
        ' 
        ' label1
        ' 
        label1.Anchor = WiseJ.Web.AnchorStyles.Top Or WiseJ.Web.AnchorStyles.Left Or WiseJ.Web.AnchorStyles.Right
        label1.AutoSize = True
        label1.Location = New System.Drawing.Point(16, 21)
        label1.Name = "label1"
        label1.Size = New System.Drawing.Size(76, 15)
        label1.TabIndex = 14
        label1.Text = "Rows count: "
        ' 
        ' frmSummaryHugeData1
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = WiseJ.Web.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(1040, 559)
        Controls.Add(button1)
        Controls.Add(btnAddSummaryRow)
        Controls.Add(btnLoadData)
        Controls.Add(dgvMaster)
        Controls.Add(groupBox1)
        Name = "frmSummaryHugeData1"
        Text = "Window1"
        CType(dgvMaster, System.ComponentModel.ISupportInitialize).EndInit()
        groupBox1.ResumeLayout(False)
        groupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

#End Region

    Friend WithEvents dgvMaster As WiseJ.Web.DataGridView
    Friend WithEvents btnLoadData As WiseJ.Web.Button
    Friend WithEvents btnAddSummaryRow As WiseJ.Web.Button
    Friend WithEvents colSubTotal As WiseJ.Web.DataGridViewColumn
    Friend WithEvents colTaxAmt As WiseJ.Web.DataGridViewColumn
    Friend WithEvents colFreight As WiseJ.Web.DataGridViewColumn
    Friend WithEvents colTotalDue As WiseJ.Web.DataGridViewColumn
    Friend WithEvents colVendorID As WiseJ.Web.DataGridViewColumn
    Friend WithEvents button1 As WiseJ.Web.Button
    Friend WithEvents groupBox1 As WiseJ.Web.GroupBox
    Friend WithEvents lblTotalDue As WiseJ.Web.Label
    Friend WithEvents label6 As WiseJ.Web.Label
    Friend WithEvents lblFreight As WiseJ.Web.Label
    Friend WithEvents label5 As WiseJ.Web.Label
    Friend WithEvents lblTaxAmnt As WiseJ.Web.Label
    Friend WithEvents label4 As WiseJ.Web.Label
    Friend WithEvents lblSubTotal As WiseJ.Web.Label
    Friend WithEvents label2 As WiseJ.Web.Label
    Friend WithEvents lblHeaderCount As WiseJ.Web.Label
    Friend WithEvents label1 As WiseJ.Web.Label
End Class
