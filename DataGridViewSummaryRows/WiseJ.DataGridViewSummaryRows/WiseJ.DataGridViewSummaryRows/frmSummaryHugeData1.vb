Imports System
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports Wisej.Web
Imports Wisej.Web.Ext.DataGridViewSummaryRow
Imports WiseJ.DataGridViewSummaryRows.data

Partial Public Class frmSummaryHugeData1
    Inherits Form

    Private _dsData As DataSet
    Private masterBindingSource As BindingSource = New BindingSource()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnLoadData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadData.Click
        LoadData()
        LoadGrid()
    End Sub

    Private Sub btnAddSummaryRow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddSummaryRow.Click
        'AppDomainSetup summary rows allways after fill the datagrid
        AddSummaryTotal()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        AddCount()
    End Sub

    Private Sub LoadData()
        Dim result = False
        Dim oData As dataPurchaseDataSet = New dataPurchaseDataSet()
        result = oData.LoadData(Path.Combine(Application.StartupPath, "data"), "dataPurchaseHeader.xml", "header")
        _dsData = New DataSet()
        _dsData = oData.DsData
        masterBindingSource.DataSource = _dsData
        masterBindingSource.DataMember = "header"
    End Sub

    Private Sub LoadGrid()
        Dim i = 0
        Dim sValue = ""
        Dim dSubTotal As Double = 0
        Dim dTaxAmount As Double = 0
        Dim dFreight As Double = 0
        Dim dTotalDue As Double = 0

        ' Fill datagrid with data 
        ' and calculate totals in columns for compare with
        ' SummaryRow

        dgvMaster.Rows.Clear()
        dgvMaster.RowCount = masterBindingSource.Count

        'this is an awful manner for load data.
        'Is only for ejemplify
        For Each dataRow As DataRow In _dsData.Tables(0).Rows
            dgvMaster(0, i).Value = dataRow("VendorID")
            dgvMaster(1, i).Value = dataRow("SubTotal")
            sValue = dataRow("SubTotal").ToString()
            dSubTotal += Double.Parse(sValue)
            dgvMaster(2, i).Value = dataRow("TaxAmt")
            sValue = dataRow("TaxAmt").ToString()
            dTaxAmount += Double.Parse(sValue)
            dgvMaster(3, i).Value = dataRow("Freight")
            sValue = dataRow("Freight").ToString()
            dFreight += Double.Parse(sValue)
            dgvMaster(4, i).Value = dataRow("TotalDue")
            sValue = dataRow("TotalDue").ToString()
            dTotalDue += Double.Parse(sValue)
            i += 1
        Next

        lblHeaderCount.Text = masterBindingSource.Count.ToString()
        lblSubTotal.Text = dSubTotal.ToString("C0")
        lblTaxAmnt.Text = dTaxAmount.ToString("C0")
        lblFreight.Text = dFreight.ToString("C0")
        lblTotalDue.Text = dTotalDue.ToString("C0")
    End Sub

    Private Sub AddSummaryTotal()
        Dim grid = dgvMaster
        Dim GridTotals As DataGridViewRow() = Nothing

        For i = 1 To grid.ColumnCount - 1
            GridTotals = grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Above, Nothing, Nothing, grid.Columns(i), TotalStyle)
        Next
    End Sub

    Private Sub AddCount()
        Dim grid = dgvMaster

        For i = 1 To grid.ColumnCount - 1
            grid.AddSummaryRows(SummaryType.Sum, colVendorID, grid.Columns(i), TotalRowStyle)
        Next
    End Sub

    Private Shared TotalStyle As DataGridViewCellStyle = New DataGridViewCellStyle() With {
        .BackColor = Color.YellowGreen,
        .Format = "C0",
        .Font = New Font("Helvetica", 10, FontStyle.Bold, GraphicsUnit.Point),
        .Alignment = DataGridViewContentAlignment.MiddleRight
    }
    Private Shared TotalRowStyle As DataGridViewCellStyle = New DataGridViewCellStyle() With {
        .BackColor = Color.Aqua,
        .Format = "C0",
        .Font = New Font("Helvetica", 10, FontStyle.Bold, GraphicsUnit.Point),
        .Alignment = DataGridViewContentAlignment.MiddleRight
    }
End Class
