Imports System
Imports System.Drawing
Imports System.Globalization
Imports Wisej.Web
Imports Wisej.Web.Ext.DataGridViewSummaryRow

Public Class frmSummaryGroup

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        FillData(1)
        FillData(2)
        FillData(3)
        FillData(4)
        AddAggregations()
    End Sub

    Private Sub FillData(ByVal quarter As Integer)
        Dim grid = dataGridView1

        ' add data for quarter/month.
        For i = 0 To Items.Length - 1
            Dim index = grid.Rows.Add()
            grid(0, index).Value = $"Quarter {quarter}"
            grid(1, index).Value = Items(i)

            For m = 0 To 12 - 1
                grid(m + 2, index).Value = Values(m, i)
                grid(m + 2, index).Style = AmountStyle
            Next
        Next
    End Sub

    Private Shared Items As String() = {"General Supplies", "Printer Ink", "Paper", "Postage"}
    Private Shared Values(,) As Integer = {{17, 20, 43, 42},
                                           {39, 21, 44, 30},
                                           {55, 8, 9, 65},
                                           {79, 43, 14, 20},
                                           {17, 20, 43, 42},
                                           {39, 21, 44, 30},
                                           {55, 8, 9, 65},
                                           {79, 43, 14, 20},
                                           {17, 20, 43, 42},
                                           {39, 21, 44, 30},
                                           {55, 8, 9, 65},
                                           {79, 43, 14, 20}
                                          }

    Private Sub AddAggregations()
        ' sum all expenses grouped by quarter (column 0)
        Dim totals As DataGridViewRow() = Nothing
        Dim grid = dataGridView1

        For m = 0 To 12 - 1
            totals = grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Above, grid.Columns(0), grid.Columns(m + 2), TotalStyle)
        Next

        ' add total label and group headers
        For Each t In totals
            t(1).Value = "Office Supplies"
            t(1).Style = TotalTitleStyle
            grid.Rows.Insert(t.Index)
            grid.Rows.Insert(t.Index)

            ' quarter label.
            Dim quarter = grid.Rows(t.Index - 2)
            quarter(2).Value = t(0).Value
            quarter(2).Style = QuarterStyle
            t(0).Value = Nothing
            Dim months = grid.Rows(t.Index - 1)
            Dim monthNames = DateTimeFormatInfo.CurrentInfo.AbbreviatedMonthNames

            For m = 0 To 12 - 1
                months(CInt(m + 2)).Value = monthNames(m).ToUpper()
                months(CInt(m + 2)).Style = MonthStyle
            Next
        Next
    End Sub

    Private Shared QuarterStyle As DataGridViewCellStyle = New DataGridViewCellStyle() With {
        .ColSpan = 12,
        .BackColor = Color.FromArgb(241, 166, 0),
        .ForeColor = Color.White,
        .Padding = New Padding(40, 0, 0, 0),
        .CssStyle = "border: 1px solid white"
    }
    Private Shared AmountStyle As DataGridViewCellStyle = New DataGridViewCellStyle() With {
        .Format = "C0",
        .Alignment = DataGridViewContentAlignment.MiddleRight
    }
    Private Shared TotalStyle As DataGridViewCellStyle = New DataGridViewCellStyle() With {
        .Format = "C0",
        .Font = New Font("Helvetica", 12, FontStyle.Bold, GraphicsUnit.Point),
        .Alignment = DataGridViewContentAlignment.MiddleRight
    }
    Private Shared TotalTitleStyle As DataGridViewCellStyle = New DataGridViewCellStyle() With {
        .Font = New Font("Helvetica", 12, FontStyle.Bold, GraphicsUnit.Point),
        .Alignment = DataGridViewContentAlignment.MiddleLeft
    }
    Private Shared MonthStyle As DataGridViewCellStyle = New DataGridViewCellStyle() With {
        .BackColor = Color.FromArgb(250, 203, 89),
        .ForeColor = Color.White,
        .Alignment = DataGridViewContentAlignment.MiddleCenter,
        .CssStyle = "border: 1px solid white"
    }
End Class
