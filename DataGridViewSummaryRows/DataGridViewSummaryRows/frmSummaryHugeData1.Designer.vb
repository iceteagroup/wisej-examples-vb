<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSummaryHugeData1
    Inherits Wisej.Web.Form

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As ComponentModel.IContainer = Nothing

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
        Me.dgvMaster = New Wisej.Web.DataGridView()
        Me.colVendorID = New Wisej.Web.DataGridViewColumn()
        Me.colSubTotal = New Wisej.Web.DataGridViewColumn()
        Me.colTaxAmt = New Wisej.Web.DataGridViewColumn()
        Me.colFreight = New Wisej.Web.DataGridViewColumn()
        Me.colTotalDue = New Wisej.Web.DataGridViewColumn()
        Me.btnLoadData = New Wisej.Web.Button()
        Me.btnAddSummaryRow = New Wisej.Web.Button()
        Me.button1 = New Wisej.Web.Button()
        Me.groupBox1 = New Wisej.Web.GroupBox()
        Me.lblTotalDue = New Wisej.Web.Label()
        Me.label6 = New Wisej.Web.Label()
        Me.lblFreight = New Wisej.Web.Label()
        Me.label5 = New Wisej.Web.Label()
        Me.lblTaxAmnt = New Wisej.Web.Label()
        Me.label4 = New Wisej.Web.Label()
        Me.lblSubTotal = New Wisej.Web.Label()
        Me.label2 = New Wisej.Web.Label()
        Me.lblHeaderCount = New Wisej.Web.Label()
        Me.label1 = New Wisej.Web.Label()
        CType(Me.dgvMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMaster
        '
        Me.dgvMaster.AutoGenerateColumns = False
        Me.dgvMaster.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.colVendorID, Me.colSubTotal, Me.colTaxAmt, Me.colFreight, Me.colTotalDue})
        Me.dgvMaster.Dock = Wisej.Web.DockStyle.Top
        Me.dgvMaster.Location = New System.Drawing.Point(0, 0)
        Me.dgvMaster.Name = "dgvMaster"
        Me.dgvMaster.Size = New System.Drawing.Size(1040, 345)
        Me.dgvMaster.TabIndex = 1
        '
        'colVendorID
        '
        Me.colVendorID.DataPropertyName = "VendorID"
        Me.colVendorID.HeaderText = "VendorID"
        Me.colVendorID.Name = "colVendorID"
        '
        'colSubTotal
        '
        Me.colSubTotal.DataPropertyName = "SubTotal"
        Me.colSubTotal.HeaderText = "SubTotal"
        Me.colSubTotal.Name = "colSubTotal"
        '
        'colTaxAmt
        '
        Me.colTaxAmt.DataPropertyName = "TaxAmt"
        Me.colTaxAmt.HeaderText = "TaxAmount"
        Me.colTaxAmt.Name = "colTaxAmt"
        '
        'colFreight
        '
        Me.colFreight.DataPropertyName = "Freight"
        Me.colFreight.HeaderText = "Freight"
        Me.colFreight.Name = "colFreight"
        '
        'colTotalDue
        '
        Me.colTotalDue.DataPropertyName = "TotalDue"
        Me.colTotalDue.HeaderText = "TotalDue"
        Me.colTotalDue.Name = "colTotalDue"
        '
        'btnLoadData
        '
        Me.btnLoadData.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left), Wisej.Web.AnchorStyles)
        Me.btnLoadData.Location = New System.Drawing.Point(43, 368)
        Me.btnLoadData.Name = "btnLoadData"
        Me.btnLoadData.Size = New System.Drawing.Size(177, 27)
        Me.btnLoadData.TabIndex = 2
        Me.btnLoadData.Text = "Load Data"
        '
        'btnAddSummaryRow
        '
        Me.btnAddSummaryRow.Location = New System.Drawing.Point(43, 401)
        Me.btnAddSummaryRow.Name = "btnAddSummaryRow"
        Me.btnAddSummaryRow.Size = New System.Drawing.Size(177, 27)
        Me.btnAddSummaryRow.TabIndex = 5
        Me.btnAddSummaryRow.Text = "Add Summary Total"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(43, 434)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(177, 27)
        Me.button1.TabIndex = 14
        Me.button1.Text = "Add Summary by VendorID"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.lblTotalDue)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.lblFreight)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.lblTaxAmnt)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.lblSubTotal)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.lblHeaderCount)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(258, 365)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(282, 175)
        Me.groupBox1.TabIndex = 15
        Me.groupBox1.Text = "Just for compare with summary"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(135, 141)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(12, 15)
        Me.lblTotalDue.TabIndex = 23
        Me.lblTotalDue.Text = "0"
        '
        'label6
        '
        Me.label6.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(16, 141)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(61, 15)
        Me.label6.TabIndex = 22
        Me.label6.Text = "TotalDue: "
        '
        'lblFreight
        '
        Me.lblFreight.AutoSize = True
        Me.lblFreight.Location = New System.Drawing.Point(135, 111)
        Me.lblFreight.Name = "lblFreight"
        Me.lblFreight.Size = New System.Drawing.Size(12, 15)
        Me.lblFreight.TabIndex = 21
        Me.lblFreight.Text = "0"
        '
        'label5
        '
        Me.label5.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(16, 111)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(49, 15)
        Me.label5.TabIndex = 20
        Me.label5.Text = "Freight: "
        '
        'lblTaxAmnt
        '
        Me.lblTaxAmnt.AutoSize = True
        Me.lblTaxAmnt.Location = New System.Drawing.Point(135, 81)
        Me.lblTaxAmnt.Name = "lblTaxAmnt"
        Me.lblTaxAmnt.Size = New System.Drawing.Size(12, 15)
        Me.lblTaxAmnt.TabIndex = 19
        Me.lblTaxAmnt.Text = "0"
        '
        'label4
        '
        Me.label4.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(16, 81)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(75, 15)
        Me.label4.TabIndex = 18
        Me.label4.Text = "TaxAmount: "
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(135, 51)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(12, 15)
        Me.lblSubTotal.TabIndex = 17
        Me.lblSubTotal.Text = "0"
        '
        'label2
        '
        Me.label2.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(16, 51)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(60, 15)
        Me.label2.TabIndex = 16
        Me.label2.Text = "SubTotal: "
        '
        'lblHeaderCount
        '
        Me.lblHeaderCount.AutoSize = True
        Me.lblHeaderCount.Location = New System.Drawing.Point(135, 21)
        Me.lblHeaderCount.Name = "lblHeaderCount"
        Me.lblHeaderCount.Size = New System.Drawing.Size(12, 15)
        Me.lblHeaderCount.TabIndex = 15
        Me.lblHeaderCount.Text = "0"
        '
        'label1
        '
        Me.label1.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(76, 15)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Rows count: "
        '
        'frmSummaryHugeData1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 559)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.btnAddSummaryRow)
        Me.Controls.Add(Me.btnLoadData)
        Me.Controls.Add(Me.dgvMaster)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "frmSummaryHugeData1"
        Me.Text = "Window1"
        CType(Me.dgvMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents dgvMaster As Wisej.Web.DataGridView
    Friend WithEvents btnLoadData As Wisej.Web.Button
    Friend WithEvents btnAddSummaryRow As Wisej.Web.Button
    Friend WithEvents colSubTotal As Wisej.Web.DataGridViewColumn
    Friend WithEvents colTaxAmt As Wisej.Web.DataGridViewColumn
    Friend WithEvents colFreight As Wisej.Web.DataGridViewColumn
    Friend WithEvents colTotalDue As Wisej.Web.DataGridViewColumn
    Friend WithEvents colVendorID As Wisej.Web.DataGridViewColumn
    Friend WithEvents button1 As Wisej.Web.Button
    Friend WithEvents groupBox1 As Wisej.Web.GroupBox
    Friend WithEvents lblTotalDue As Wisej.Web.Label
    Friend WithEvents label6 As Wisej.Web.Label
    Friend WithEvents lblFreight As Wisej.Web.Label
    Friend WithEvents label5 As Wisej.Web.Label
    Friend WithEvents lblTaxAmnt As Wisej.Web.Label
    Friend WithEvents label4 As Wisej.Web.Label
    Friend WithEvents lblSubTotal As Wisej.Web.Label
    Friend WithEvents label2 As Wisej.Web.Label
    Friend WithEvents lblHeaderCount As Wisej.Web.Label
    Friend WithEvents label1 As Wisej.Web.Label
End Class
