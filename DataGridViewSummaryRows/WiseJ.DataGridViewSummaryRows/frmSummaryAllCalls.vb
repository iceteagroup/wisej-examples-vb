
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports Wisej.Web

''' <summary>
''' 
''' This is an awful example of data binding and handling!
''' 
''' The goal of this simple app is to show deep linking, not data management.
''' 
''' This window handles the Application.HashChanged and Application.ApplicationRefresh events
''' to read the hash from the URL and open the dialog used to edit the user id specified in the URL.
''' 
''' When the user edit dialog is opened, it saves the user id being edited
''' in the URL hash, when the dialog is closed, it removes the user id from the URL hash.
''' 
''' Navigating using the browser's back/forward arrows performs the deep linking functionality.
''' 
''' </summary>
Partial Public Class frmSummaryAllCalls
    Private DataTable As DataTable

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Window1_Load(ByVal sender As Object, ByVal args As EventArgs)
        ' detect changes to the hash in the URL.
        AddHandler Application.HashChanged, AddressOf Application_HashChanged

        ' handle the first hash value, if any.
        EditUser(Application.Hash)
    End Sub

    Private Sub Application_HashChanged(ByVal sender As Object, ByVal e As HashChangedEventArgs)
        EditUser(e.Hash)
    End Sub


    Private Sub btnLoadFromDataSource_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadFromDataSource.Click
        dataGrid.Rows.Clear()
        dataGrid.Columns.Clear()
        LoadFromDataSource()
    End Sub

    Private Sub btnLoadData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadData.Click

        dataGrid.Rows.Clear()
        dataGrid.Columns.Clear()
        LoadData()
    End Sub

    Private Sub btnSummary1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSummary1.Click
        Dim grid = dataGrid
        Dim style = New DataGridViewCellStyle() With {
    .BackColor = Color.YellowGreen,
    .Font = New Font(grid.Font, FontStyle.Bold)
}

        If dataGrid.Rows.Count > 0 Then
            dataGrid.AddSummaryRows(SummaryType.Sum, Nothing, dataGrid.Columns(6), style)
        End If

    End Sub

    Private Sub btnSummary2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSummary2.Click

        Dim grid = dataGrid
        Dim style = New DataGridViewCellStyle() With {
                            .BackColor = Color.BurlyWood,
                            .Font = New Font(grid.Font, FontStyle.Bold)
                        }


        If dataGrid.Rows.Count > 0 Then
            grid.AddSummaryRows(SummaryType.Sum, Nothing, "Total", style)
        End If
    End Sub

    Private Sub btnSummary3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSummary3.Click
        Dim grid = dataGrid

        Dim style = New DataGridViewCellStyle() With {
                                .BackColor = Color.Aquamarine,
                                .Font = New Font(grid.Font, FontStyle.Bold)
                            }

        If dataGrid.Rows.Count > 0 Then

            Dim oColumn = dataGrid.Columns(6)

            ' TODO - Overload method AddSummaryRows Not match
            ' grid.AddSummaryRows(SummaryType.Sum, Nothing, Nothing, oColumn, style)
        End If
    End Sub

    Private Sub btnSummary4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSummary4.Click
        Dim grid = dataGrid
        Dim style = New DataGridViewCellStyle() With {
    .BackColor = Color.Beige,
    .Font = New Font(grid.Font, FontStyle.Bold)
}

        If dataGrid.Rows.Count > 0 Then

            grid.AddSummaryRows(SummaryType.Sum, "", "", "Total", style)
        End If
    End Sub

    Private Sub btnSummary5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSummary5.Click
        Dim grid = dataGrid
        Dim style = New DataGridViewCellStyle() With {
    .BackColor = Color.Coral,
    .Font = New Font(grid.Font, FontStyle.Bold)
}

        If dataGrid.Rows.Count > 0 Then

            Dim oColumn = dataGrid.Columns(6)
            grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Below, Nothing, oColumn, style)
        End If
    End Sub

    Private Sub btnSummary6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSummary6.Click
        Dim grid = dataGrid
        Dim style = New DataGridViewCellStyle() With {
    .BackColor = Color.Gold,
    .Font = New Font(grid.Font, FontStyle.Bold)
}

        If dataGrid.Rows.Count > 0 Then

            Dim oColumn = dataGrid.Columns(6)
            grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Below, "", "Total", style)
        End If
    End Sub


    Private Sub btnSummary7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSummary7.Click
        Dim grid = dataGrid
        Dim style = New DataGridViewCellStyle() With {
    .BackColor = Color.Bisque,
    .Font = New Font(grid.Font, FontStyle.Bold)
}

        If dataGrid.Rows.Count > 0 Then
            grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Below, Nothing, Nothing, grid.Columns(6), style)
        End If
    End Sub

    Private Sub btnSummary8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSummary8.Click
        Dim grid = dataGrid
        Dim style = New DataGridViewCellStyle() With {
    .BackColor = Color.CornflowerBlue,
    .Font = New Font(grid.Font, FontStyle.Bold)
}


        If dataGrid.Rows.Count > 0 Then
            grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Below, "", "", "Total", style)
        End If
    End Sub

    Private Sub btnRemoveSumary_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemoveSumary.Click
        Dim bDataGridHasRows = dataGrid.Rows.Count > 0

        If bDataGridHasRows Then
            dataGrid.RemoveSummaryRows()

            'position in the first row
            Dim nRowIndex = 0
            Dim nColumnIndex = 0

            dataGrid.ClearSelection()
            dataGrid.CurrentCell = dataGrid(nColumnIndex, nRowIndex)
        End If
    End Sub

    Private Sub LoadFromDataSource()
        Dim table = CSharpImpl.__Assign(DataTable, New DataTable())
        table.Columns.Add("ID", GetType(Integer))
        table.Columns.Add("Name", GetType(String))
        table.Columns.Add("Last Name", GetType(String))
        table.Columns.Add("Role", GetType(String))
        table.Columns.Add("Activation Date", GetType(Date))
        table.Columns.Add("Expiration Date", GetType(Date))
        table.Columns.Add("Total", GetType(Double))

        table.Rows.Add(1, "Abraham", "Baldwin", "User", New DateTime(1785, 4, 5), New DateTime(1885, 4, 5), 100)
        table.Rows.Add(2, "Christopher", "Gadsden", "Administrator", New DateTime(1785, 4, 5), New DateTime(1885, 4, 5), 200)
        table.Rows.Add(3, "Francis", "Dana", "User", New DateTime(1785, 4, 5), New DateTime(1885, 4, 5), 5)
        table.Rows.Add(4, "Hugh", "Williamson", "Supervisor", New DateTime(1785, 4, 5), New DateTime(1885, 4, 5), 1300)
        table.Rows.Add(5, "Joseph", "Reed", "User", New DateTime(1785, 4, 5), New DateTime(1885, 4, 5), 1100)

        'this.dataGrid.DataSource = this.DataTable;
        dataGrid.Fill(DataTable)

        dataGrid.Columns("Activation Date").DefaultCellStyle.Format = "d"
        dataGrid.Columns("Expiration Date").DefaultCellStyle.Format = "d"


    End Sub

    Private Sub LoadData()
        Dim table = CSharpImpl.__Assign(DataTable, New DataTable())
        table.Columns.Add("ID", GetType(Integer))
        table.Columns.Add("Name", GetType(String))
        table.Columns.Add("Last Name", GetType(String))
        table.Columns.Add("Role", GetType(String))
        table.Columns.Add("Activation Date", GetType(Date))
        table.Columns.Add("Expiration Date", GetType(Date))
        table.Columns.Add("Total", GetType(Double))

        table.Rows.Add(1, "Abraham", "Baldwin", "User", New DateTime(1785, 4, 5), New DateTime(1885, 4, 5), 100)
        table.Rows.Add(2, "Christopher", "Gadsden", "Administrator", New DateTime(1785, 4, 5), New DateTime(1885, 4, 5), 200)
        table.Rows.Add(3, "Francis", "Dana", "User", New DateTime(1785, 4, 5), New DateTime(1885, 4, 5), 5)
        table.Rows.Add(4, "Hugh", "Williamson", "Supervisor", New DateTime(1785, 4, 5), New DateTime(1885, 4, 5), 1300)
        table.Rows.Add(5, "Joseph", "Reed", "User", New DateTime(1785, 4, 5), New DateTime(1885, 4, 5), 1100)

        For i = 0 To DataTable.Columns.Count
            Dim oColumn As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()

            If i = 0 Then
                oColumn.Name = "ID"
            End If

            If i = 6 Then
                oColumn.Name = "Total"
            End If

            dataGrid.Columns.Add(oColumn)
        Next


        dataGrid.Rows.Add(DataTable.Rows.Count)

        Dim row = 0
        For Each dr As DataRow In DataTable.Rows
            For i = 0 To 6
                dataGrid(i, row).Value = dr(i)
            Next

            Threading.Interlocked.Increment(row)
        Next

    End Sub

    Private Sub buttonEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonEdit.Click

        If dataGrid.Rows.Count > 0 Then
            EditUser(CurrentUserId)
        End If
    End Sub

    Private Sub buttonAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdd.Click
        If dataGrid.Rows.Count > 0 Then

            Dim newId = dataGrid.Rows.Max(Function(r) CInt(r(0).Value)) + 1

            Dim table = DataTable
            table.Rows.Add(newId, "", "", "User", Date.Now, Date.Now.AddYears(1))
            EditUser(newId, True)
        End If

    End Sub

    Private Sub dataGrid_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        EditUser(CurrentUserId)
    End Sub

    Private ReadOnly Property CurrentUserId As Integer
        Get
            Dim row = dataGrid.CurrentRow
            Return If(row IsNot Nothing, CInt(row(0).Value), -1)
        End Get
    End Property

    Private Sub EditUser(ByVal hash As String)
        Dim userId = -1
        If Integer.TryParse(hash, userId) Then
            EditUser(userId)
        Else
            EditUser(-1)
        End If
    End Sub

    Private Sub EditUser(ByVal id As Integer, ByVal Optional newRow As Boolean = False)
        ' close the current dialog, if still open.
        If userDialog IsNot Nothing Then
            userDialog.DialogResult = DialogResult.Abort
            userDialog.Close()
        End If

        If id < 0 Then Return

        ' find the row row edit.
        Dim row = dataGrid.Rows.FirstOrDefault(Function(r) CInt(r(0).Value) = id)
        If row Is Nothing Then
            MessageBox.Show("User not found: ID = " & id, modal:=False)
            Return
        End If

        If userDialog Is Nothing Then userDialog = New frmSummaryAllCallsUserDataDialog()

        ' update the hash to save the current deep linking location.
        Application.Hash = id.ToString()

        ' show the dialog and handle the closing event asynchronously (modeless).
        userDialog.Values = DataTable.Rows(row.Index).ItemArray
        userDialog.ShowDialog(Me, Sub(sender, result)
                                      ' clear the hash to update the current deep linking location.
                                      If result <> DialogResult.Abort Then Application.Hash = ""

                                      If result = DialogResult.OK Then
                                          ' this code is executed only after the dialog is closed.
                                          row.SetValues(userDialog.Values)
                                      ElseIf result = DialogResult.Cancel AndAlso newRow Then
                                          ' delete new row if cancel was pressed.
                                          dataGrid.Rows.Remove(row)
                                      End If
                                  End Sub)
    End Sub

    ' reference to the current user dialog.
    Private userDialog As frmSummaryAllCallsUserDataDialog

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class


End Class
