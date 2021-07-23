Imports System
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports Wisej.Web
Imports Wisej.Web.Ext.DataGridViewSummaryRow
Imports WiseJ.DataGridViewSummaryRows.data

Partial Public Class frmSummaryHugeData2


    Private colPurchaseOrderID As DataGridViewColumn
    Private colOrderQty As DataGridViewColumn
    Private colName As DataGridViewColumn
    Private colUnitPrice As DataGridViewColumn
    Private colStockedQty As DataGridViewColumn
    Private colModifiedDate As DataGridViewColumn
    Private _dsData As DataSet
    Private detailBindingSource As BindingSource = New BindingSource()
    Private bFullCols As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmSumaryGroup_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnLoadData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadData.Click
        If dgvMaster.Columns.Count > 0 Then
            dgvMaster.Columns.Clear()
            dgvMaster.AutoGenerateColumns = False
        End If

        DataGridCreateColumns()
        LoadData()
        bFullCols = False
        LoadGrid()
    End Sub

    Private Sub btnLoadDataFullCols_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadDataFullCols.Click
        If dgvMaster.Columns.Count > 0 Then
            dgvMaster.Columns.Clear()
            dgvMaster.AutoGenerateColumns = True
        End If

        LoadData()
        bFullCols = True
        LoadGrid2()
    End Sub

    Private Sub btnAddSummaryRow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddSummaryRow.Click
        AddSummary1()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSummary2.Click
        AddSummary2()
    End Sub

    Private Sub btnSummary3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSummary3.Click
        AddSummary3()
    End Sub

    Private Sub btnRemoveSummary_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemoveSummary.Click
        RemoveSummaryGroup()
    End Sub

    Private Sub AddSummary1()
        Dim grid = dgvMaster
        Dim bDataGridHasRows = dgvMaster.Rows.Count > 0

        If bDataGridHasRows Then
            If bFullCols = False Then
                For i = 3 To 5 - 1
                    grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Below, Nothing, Nothing, grid.Columns(i), TotalStyle)
                Next
            Else

                For i = 6 To 10
                    grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Below, Nothing, Nothing, grid.Columns(i), TotalStyle)
                Next
            End If
        End If

        'position in the last row
        If bDataGridHasRows Then
            Dim nRowIndex = dgvMaster.Rows.Count - 1
            Dim nColumnIndex = 0
            dgvMaster.ClearSelection()
            dgvMaster.CurrentCell = dgvMaster(nColumnIndex, nRowIndex)
        End If
    End Sub

    Private Sub AddSummary2()
        Dim grid = dgvMaster

        If dgvMaster.Rows.Count > 0 Then
            If bFullCols = False Then
                For i = 3 To 5 - 1
                    grid.AddSummaryRows(SummaryType.Sum, colPurchaseOrderID, colUnitPrice, TotalRowStyle)
                Next
            Else

                For i = 6 To 10
                    ' grid.Columns[0] is group column for  colPurchaseOrderID
                    grid.AddSummaryRows(SummaryType.Sum, grid.Columns(0), grid.Columns(i), TotalRowStyle)
                Next
            End If
        End If
    End Sub

    Private Sub RemoveSummaryGroup()
        Dim bDataGridHasRows = dgvMaster.Rows.Count > 0

        If bDataGridHasRows Then
            dgvMaster.RemoveSummaryRows()

            'position in the first row
            Dim nRowIndex = 0
            Dim nColumnIndex = 0
            dgvMaster.ClearSelection()
            dgvMaster.CurrentCell = dgvMaster(nColumnIndex, nRowIndex)
        End If
    End Sub

    Private Sub AddSummary3()
        Dim grid = dgvMaster

        If dgvMaster.Rows.Count > 0 Then
            If bFullCols = False Then
                For i = 3 To 5 - 1
                    grid.AddSummaryRows(SummaryType.Sum, "colPurchaseOrderID", "colUnitPrice", TotalRowStyle)
                Next
            Else

                For i = 6 To 10
                    ' names in dataPurchaseDetail.xml for fields
                    grid.AddSummaryRows(SummaryType.Sum, "PurchaseOrderID", "UnitPrice", TotalRowStyle)
                Next
            End If
        End If
    End Sub

    Private Sub DataGridCreateColumns()
        colPurchaseOrderID = New DataGridViewColumn()
        colOrderQty = New DataGridViewColumn()
        colName = New DataGridViewColumn()
        colUnitPrice = New DataGridViewColumn()
        colStockedQty = New DataGridViewColumn()
        colModifiedDate = New DataGridViewColumn()
        colPurchaseOrderID.HeaderText = "Order ID"
        colPurchaseOrderID.Name = "colPurchaseOrderID"
        colOrderQty.HeaderText = "Order Qty"
        colOrderQty.Name = "colOrderQty"
        colName.HeaderText = "Product"
        colName.Name = "colName"
        colUnitPrice.HeaderText = "Unit Price"
        colUnitPrice.Name = "colUnitPrice"
        colStockedQty.HeaderText = "Stocket Qty"
        colStockedQty.Name = "colStockedQty"
        colModifiedDate.HeaderText = "Date"
        colModifiedDate.Name = "colModifiedDate"
        dgvMaster.Columns.Add(colPurchaseOrderID)
        dgvMaster.Columns.Add(colOrderQty)
        dgvMaster.Columns.Add(colName)
        dgvMaster.Columns.Add(colUnitPrice)
        dgvMaster.Columns.Add(colStockedQty)
        dgvMaster.Columns.Add(colModifiedDate)
    End Sub

    Private Sub LoadData()
        Dim result = False
        Dim oData As dataPurchaseDataSet = New dataPurchaseDataSet()
        result = oData.LoadData(Path.Combine(Application.StartupPath, "data"), "dataPurchaseDetail.xml", "detail")
        _dsData = New DataSet()
        _dsData = oData.DsData
        detailBindingSource.DataSource = _dsData
        detailBindingSource.DataMember = "detail"
    End Sub

    Private Sub LoadGrid()
        Dim i = 0
        Dim sValue = ""
        Dim dUnitPrice As Double = 0
        Dim dStockedQty As Double = 0
        Dim rowsLoaded = _dsData.Tables(0).Rows.Count

        ' This is the recommended way to load datagridview when will be use with SummaryRows
        Dim oTable = _dsData.Tables(0)
        dgvMaster.RowCount = rowsLoaded

        For Each dataRow As DataRow In _dsData.Tables(0).Rows
            dgvMaster(0, i).Value = dataRow("PurchaseOrderID")
            dgvMaster(1, i).Value = dataRow("OrderQty")
            sValue = dataRow("OrderQty").ToString()
            dgvMaster(2, i).Value = dataRow("Name")
            sValue = dataRow("Name").ToString()
            dgvMaster(3, i).Value = dataRow("UnitPrice")
            sValue = dataRow("UnitPrice").ToString()
            dUnitPrice += Double.Parse(sValue)
            dgvMaster(4, i).Value = dataRow("StockedQty")
            sValue = dataRow("StockedQty").ToString()
            dStockedQty += Double.Parse(sValue)
            dgvMaster(5, i).Value = dataRow("ModifiedDate")
            sValue = dataRow("ModifiedDate").ToString()
            i += 1
        Next

        lblHeaderCount.Text = detailBindingSource.Count.ToString()
        lblUnitPrice.Text = dUnitPrice.ToString("C0")
        lblStockedQty.Text = dStockedQty.ToString("C0")
    End Sub

    Private Sub LoadGrid2()
        Dim i = 0
        Dim sValue = ""
        Dim dUnitPrice As Double = 0
        Dim dStockedQty As Double = 0
        Dim rowsLoaded = 0

        ' This is the recommended way to load datagridview when will be use with SummaryRows
        Dim oTable = _dsData.Tables(0)

        If oTable IsNot Nothing Then
            rowsLoaded = dgvMaster.Fill(oTable)
        End If

        For Each dataRow As DataRow In _dsData.Tables(0).Rows
            sValue = dataRow("OrderQty").ToString()
            sValue = dataRow("Name").ToString()
            sValue = dataRow("UnitPrice").ToString()
            dUnitPrice += Double.Parse(sValue)
            sValue = dataRow("StockedQty").ToString()
            dStockedQty += Double.Parse(sValue)
            sValue = dataRow("ModifiedDate").ToString()
            i += 1
        Next

        lblHeaderCount.Text = detailBindingSource.Count.ToString()
        lblUnitPrice.Text = dUnitPrice.ToString("C0")
        lblStockedQty.Text = dStockedQty.ToString("C0")
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
