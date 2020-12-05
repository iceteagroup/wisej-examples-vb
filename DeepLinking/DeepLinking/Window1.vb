Imports System
Imports System.Data
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
Public Partial Class Window1

        Private DataTable As DataTable

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Window1_Load(ByVal sender As Object, ByVal args As EventArgs)
            LoadUserData()

            ' detect changes to the hash in the URL.
            AddHandler Application.HashChanged, AddressOf Application_HashChanged

            ' detect when the browser's reloads the page (the user hit refresh).
            AddHandler Application.ApplicationRefresh, AddressOf Application_ApplicationRefresh

            ' detach all static events when disposed.
            AddHandler Disposed, AddressOf Window1_Disposed

            ' handle the hash value in the URL when this window
            ' is first loaded. the HashChanged event is fired only when
            ' the hash changes in the browser.
            EditUser(Application.Hash)
        End Sub

        Private Sub Window1_Disposed(ByVal sender As Object, ByVal e As EventArgs)
            RemoveHandler Application.HashChanged, AddressOf Application_HashChanged
            RemoveHandler Application.ApplicationRefresh, AddressOf Application_ApplicationRefresh
        End Sub

        Private Sub Application_ApplicationRefresh(ByVal sender As Object, ByVal e As EventArgs)
            EditUser(Application.Hash)
        End Sub

        Private Sub Application_HashChanged(ByVal sender As Object, ByVal e As HashChangedEventArgs)
            EditUser(e.Hash)
        End Sub

        Private Sub LoadUserData()
            Dim table = CSharpImpl.__Assign(DataTable, New DataTable())
            table.Columns.Add("ID", GetType(Integer))
            table.Columns.Add("Name", GetType(String))
            table.Columns.Add("Last Name", GetType(String))
            table.Columns.Add("Role", GetType(String))
            table.Columns.Add("Activation Date", GetType(Date))
            table.Columns.Add("Expiration Date", GetType(Date))
            table.Rows.Add(1, "Abraham", "Baldwin", "User", New DateTime(1785, 4, 5), New DateTime(1885, 4, 5))
            table.Rows.Add(2, "Christopher", "Gadsden", "Administrator", New DateTime(1785, 4, 5), New DateTime(1885, 4, 5))
            table.Rows.Add(3, "Francis", "Dana", "User", New DateTime(1785, 4, 5), New DateTime(1885, 4, 5))
            table.Rows.Add(4, "Hugh", "Williamson", "Supervisor", New DateTime(1785, 4, 5), New DateTime(1885, 4, 5))
            table.Rows.Add(5, "Joseph", "Reed", "User", New DateTime(1785, 4, 5), New DateTime(1885, 4, 5))
            dataGrid.DataSource = DataTable
            dataGrid.Columns("Activation Date").DefaultCellStyle.Format = "d"
            dataGrid.Columns("Expiration Date").DefaultCellStyle.Format = "d"
        End Sub

        Private Sub buttonEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
            EditUser(CurrentUserId)
        End Sub

        Private Sub buttonAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim newId = dataGrid.Rows.Max(Function(r) CInt(r(0).Value)) + 1
            Dim table As DataTable = DataTable
            table.Rows.Add(newId, "", "", "User", Date.Now, Date.Now.AddYears(1))
            EditUser(newId, True)
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
            If Integer.TryParse(hash, userId) Then EditUser(userId)
        End Sub

        Private Sub EditUser(ByVal id As Integer, ByVal Optional newRow As Boolean = False)
            ' close the current dialog, if still open.
            If userDialog IsNot Nothing Then
                userDialog.DialogResult = DialogResult.Abort
                userDialog.Close()
            End If


            ' find the row row edit.
            Dim row = dataGrid.Rows.FirstOrDefault(Function(r) CInt(r(0).Value) = id)

            If row Is Nothing Then
                MessageBox.Show("User not found: ID = " & id)

                ' clear the hash to update the current deep linking location.
                Application.Hash = ""
                Return
            End If

            If userDialog Is Nothing Then userDialog = New UserDataDialog()

            ' update the hash to save the current deep linking location.
            Application.Hash = id.ToString()

            ' show the dialog and handle the closing event asynchronously (modeless).
            userDialog.Values = DataTable.Rows(row.Index).ItemArray
            userDialog.ShowDialog(Me, Sub(sender, result)
                                          ' clear the hash to update the current deep linking location.
                                          Application.Hash = ""

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
        Private userDialog As UserDataDialog

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
