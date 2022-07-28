<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSummaryHugeData2
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
        Me.dgvMaster = New Wisej.Web.DataGridView()
        Me.btnSummary2 = New Wisej.Web.Button()
        Me.lblStockedQty = New Wisej.Web.Label()
        Me.label4 = New Wisej.Web.Label()
        Me.lblUnitPrice = New Wisej.Web.Label()
        Me.label2 = New Wisej.Web.Label()
        Me.btnAddSummaryRow = New Wisej.Web.Button()
        Me.lblHeaderCount = New Wisej.Web.Label()
        Me.label1 = New Wisej.Web.Label()
        Me.btnLoadData = New Wisej.Web.Button()
        Me.btnSummary3 = New Wisej.Web.Button()
        Me.btnLoadDataFullCols = New Wisej.Web.Button()
        Me.btnRemoveSummary = New Wisej.Web.Button()
        Me.groupBox1 = New Wisej.Web.GroupBox()
        CType(Me.dgvMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMaster
        '
        Me.dgvMaster.Dock = Wisej.Web.DockStyle.Top
        Me.dgvMaster.Location = New System.Drawing.Point(0, 0)
        Me.dgvMaster.Name = "dgvMaster"
        Me.dgvMaster.Size = New System.Drawing.Size(1040, 361)
        Me.dgvMaster.TabIndex = 2
        '
        'btnSummary2
        '
        Me.btnSummary2.Location = New System.Drawing.Point(218, 451)
        Me.btnSummary2.Name = "btnSummary2"
        Me.btnSummary2.Size = New System.Drawing.Size(167, 27)
        Me.btnSummary2.TabIndex = 27
        Me.btnSummary2.Text = " Summary Group Above"
        '
        'lblStockedQty
        '
        Me.lblStockedQty.AutoSize = True
        Me.lblStockedQty.Location = New System.Drawing.Point(139, 86)
        Me.lblStockedQty.Name = "lblStockedQty"
        Me.lblStockedQty.Size = New System.Drawing.Size(12, 15)
        Me.lblStockedQty.TabIndex = 22
        Me.lblStockedQty.Text = "0"
        '
        'label4
        '
        Me.label4.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(20, 86)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(79, 15)
        Me.label4.TabIndex = 21
        Me.label4.Text = "Stocked Qty: "
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.AutoSize = True
        Me.lblUnitPrice.Location = New System.Drawing.Point(139, 56)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(12, 15)
        Me.lblUnitPrice.TabIndex = 20
        Me.lblUnitPrice.Text = "0"
        '
        'label2
        '
        Me.label2.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(20, 56)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 15)
        Me.label2.TabIndex = 19
        Me.label2.Text = "Unit Price: "
        '
        'btnAddSummaryRow
        '
        Me.btnAddSummaryRow.Location = New System.Drawing.Point(218, 384)
        Me.btnAddSummaryRow.Name = "btnAddSummaryRow"
        Me.btnAddSummaryRow.Size = New System.Drawing.Size(167, 27)
        Me.btnAddSummaryRow.TabIndex = 18
        Me.btnAddSummaryRow.Text = "Summary Totals Below"
        '
        'lblHeaderCount
        '
        Me.lblHeaderCount.AutoSize = True
        Me.lblHeaderCount.Location = New System.Drawing.Point(139, 26)
        Me.lblHeaderCount.Name = "lblHeaderCount"
        Me.lblHeaderCount.Size = New System.Drawing.Size(12, 15)
        Me.lblHeaderCount.TabIndex = 17
        Me.lblHeaderCount.Text = "0"
        '
        'label1
        '
        Me.label1.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(20, 26)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(76, 15)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Rows count: "
        '
        'btnLoadData
        '
        Me.btnLoadData.Location = New System.Drawing.Point(45, 385)
        Me.btnLoadData.Name = "btnLoadData"
        Me.btnLoadData.Size = New System.Drawing.Size(167, 27)
        Me.btnLoadData.TabIndex = 15
        Me.btnLoadData.Text = "Load Data"
        '
        'btnSummary3
        '
        Me.btnSummary3.Location = New System.Drawing.Point(218, 418)
        Me.btnSummary3.Name = "btnSummary3"
        Me.btnSummary3.Size = New System.Drawing.Size(167, 27)
        Me.btnSummary3.TabIndex = 28
        Me.btnSummary3.Text = "Summary Group Below"
        '
        'btnLoadDataFullCols
        '
        Me.btnLoadDataFullCols.Location = New System.Drawing.Point(45, 418)
        Me.btnLoadDataFullCols.Name = "btnLoadDataFullCols"
        Me.btnLoadDataFullCols.Size = New System.Drawing.Size(167, 27)
        Me.btnLoadDataFullCols.TabIndex = 29
        Me.btnLoadDataFullCols.Text = "Load Data Full Cols"
        '
        'btnRemoveSummary
        '
        Me.btnRemoveSummary.Location = New System.Drawing.Point(218, 484)
        Me.btnRemoveSummary.Name = "btnRemoveSummary"
        Me.btnRemoveSummary.Size = New System.Drawing.Size(167, 27)
        Me.btnRemoveSummary.TabIndex = 30
        Me.btnRemoveSummary.Text = "Remove Summary"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.lblStockedQty)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.lblUnitPrice)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.lblHeaderCount)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(415, 384)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(247, 127)
        Me.groupBox1.TabIndex = 31
        Me.groupBox1.Text = "Just for compare with summary"
        '
        'frmSummaryHugeData2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 562)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btnRemoveSummary)
        Me.Controls.Add(Me.btnLoadDataFullCols)
        Me.Controls.Add(Me.btnSummary3)
        Me.Controls.Add(Me.btnSummary2)
        Me.Controls.Add(Me.btnAddSummaryRow)
        Me.Controls.Add(Me.btnLoadData)
        Me.Controls.Add(Me.dgvMaster)
        Me.Name = "frmSummaryHugeData2"
        Me.Text = "frmSumaryGroup"
        CType(Me.dgvMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents dgvMaster As Wisej.Web.DataGridView
    Friend WithEvents btnSummary2 As Wisej.Web.Button
    Friend WithEvents lblStockedQty As Wisej.Web.Label
    Friend WithEvents label4 As Wisej.Web.Label
    Friend WithEvents lblUnitPrice As Wisej.Web.Label
    Friend WithEvents label2 As Wisej.Web.Label
    Friend WithEvents btnAddSummaryRow As Wisej.Web.Button
    Friend WithEvents lblHeaderCount As Wisej.Web.Label
    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents btnLoadData As Wisej.Web.Button
    Friend WithEvents btnSummary3 As Wisej.Web.Button
    Friend WithEvents btnLoadDataFullCols As Wisej.Web.Button
    Friend WithEvents btnRemoveSummary As Wisej.Web.Button
    Friend WithEvents groupBox1 As Wisej.Web.GroupBox
End Class
