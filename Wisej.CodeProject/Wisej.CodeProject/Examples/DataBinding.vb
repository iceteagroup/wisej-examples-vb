Imports System
Imports Wisej.Web
Imports System.IO

Partial Public Class DataBinding

    Public Sub New()
        InitializeComponent()
    End Sub

    Private dbFilePath As String

    Private Sub DataBinding_Load(ByVal sender As Object, ByVal e As EventArgs)
        ' duplicate the database to isolate it for the session.
        Dim sourcePath = Application.MapPath("~\App_Data\chinook.db")
        Dim targetPath = Application.MapPath("~\App_Data\chinook_" & Application.SessionId & ".db")
        dbFilePath = targetPath

        Try
            File.Copy(sourcePath, targetPath)
        Catch
        End Try

        AddHandler Application.ApplicationExit, AddressOf Application_ApplicationExit
        employeesTableAdapter.Connection = New Data.SQLite.SQLiteConnection("data source=" & targetPath & ";Pooling=False")
        LoadData()
    End Sub

    Private Sub Application_ApplicationExit(ByVal sender As Object, ByVal e As EventArgs)
        ' delete the session-cloned db file.
        employeesTableAdapter.Connection.Close()
        employeesTableAdapter.Connection.Dispose()
        employeesTableAdapter.Adapter.Dispose()

        Try
            File.Delete(dbFilePath)
        Catch
        End Try
    End Sub

    Private Sub dataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        dataGridView1.Tools("Save").Enabled = True
    End Sub

    Private Sub dataGridView1_ToolClick(ByVal sender As Object, ByVal e As ToolClickEventArgs)
        Select Case e.Tool.Name
            Case "Save"
                SaveData()
            Case "Add"
                AddNewRecord()
            Case "Delete"
                DeleteRecord()
            Case "Reload"
                LoadData()
        End Select
    End Sub

    Private Sub DeleteRecord()
        ' this method shows server-side modal.

        Try
            Dim row = If(dataGridView1.CurrentRow?.Index, -1)

            If row > -1 Then
                If MessageBox.Show("Are you sure you want to delete this record?", icon:=MessageBoxIcon.Question, buttons:=MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
                    employeesBindingSource.RemoveCurrent()
                    Dim count = employeesTableAdapter.Update(chinookDataSet.employees)
                    SetStatusText("Deleted 1 record.")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", icon:=MessageBoxIcon.Error, modal:=False)
        End Try
    End Sub

    Private Sub SaveData()
        Try
            employeesBindingSource.EndEdit()
            Dim count = employeesTableAdapter.Update(chinookDataSet.employees)
            dataGridView1.Tools("Save").Enabled = False
            AlertBox.Show("Saved!")
            SetStatusText("Saved " & count & " records.")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", icon:=MessageBoxIcon.Error, modal:=False)
        End Try
    End Sub

    Private Sub AddNewRecord()
        Try
            employeesBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", icon:=MessageBoxIcon.Error, modal:=False)
        End Try
    End Sub

    Private Sub SetStatusText(ByVal text As String)
        statusBar1.Text = text
    End Sub

    Private Sub LoadData()
        RemoveHandler dataGridView1.CellValueChanged, New DataGridViewCellEventHandler(AddressOf dataGridView1_CellValueChanged)
        employeesTableAdapter.Fill(chinookDataSet.employees)
        AddHandler dataGridView1.CellValueChanged, New DataGridViewCellEventHandler(AddressOf dataGridView1_CellValueChanged)
        SetStatusText("Loaded " & employeesBindingSource.Count & " records.")
    End Sub

    Private Sub dataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        dataGridView1.Tools("Delete").Enabled = dataGridView1.CurrentRow IsNot Nothing
    End Sub

    Private Sub dataGridView1_CellToolClick(ByVal sender As Object, ByVal e As DataGridViewToolClickEventArgs)
        AlertBox.Show("You clicked the sun tool. Nice work.")
    End Sub

    Private Sub textBox3_ToolClick(ByVal sender As Object, ByVal e As ToolClickEventArgs)
        If String.IsNullOrEmpty(textBox3.Text) Then
            AlertBox.Show("Cannot send an email to an empty address! ", icon:=MessageBoxIcon.Error)
        Else
            AlertBox.Show("I'm sending an email to " & textBox3.Text)
        End If
    End Sub

    Private Sub textBox2_ToolClick(ByVal sender As Object, ByVal e As ToolClickEventArgs)
        AlertBox.Show("This tool button does't do anything.")
    End Sub

    Private Sub dateTimePicker1_ToolClick(ByVal sender As Object, ByVal e As ToolClickEventArgs)
        AlertBox.Show("You clicked the sun tool. Nice work.")
    End Sub

    Private Sub dataGridView1_Enter(ByVal sender As Object, ByVal e As EventArgs)
        employeesBindingSource.EndEdit()
    End Sub
End Class
