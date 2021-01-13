Imports System
Imports Wisej.Web
Imports System.Data

Partial Public Class DataTableWindow

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Page1_Load(ByVal sender As Object, ByVal e As EventArgs)
        dataGridView1.Columns(0).DataPropertyName = "ID"
        dataGridView1.Columns(1).DataPropertyName = "NAME"
        dataGridView1.Columns(2).DataPropertyName = "TYPE"
        dataGridView1.Columns(3).DataPropertyName = "THERAPIST"
        AddHandler dataGridView1.DataBindingComplete, AddressOf DataGridView1_DataBindingComplete
        dataGridView1.DataSource = New BindingSource(DefineData(), Nothing)
    End Sub

    Private Sub DataGridView1_DataBindingComplete(ByVal sender As Object, ByVal e As DataGridViewBindingCompleteEventArgs)
        SetParents()
    End Sub

    ''' <summary>
    ''' Set Parent Rows
    ''' </summary>
    Private Sub SetParents()
        Dim prevType = ""
        Dim ParentRow = 0

        For Each row In dataGridView1.Rows

            If Equals(row.Cells("colType").Value.ToString(), prevType) Then
                row.ParentRow = dataGridView1.Rows(ParentRow)
            Else
                row(1).Style.ColSpan = 2
                dataGridView1.Rows(ParentRow).Collapse()
                ParentRow = row.Index
            End If

            prevType = row.Cells("colType").Value.ToString()
        Next

        dataGridView1.Rows(ParentRow).Collapse()
    End Sub

    Private Function DefineData() As DataTable
        Dim dt As DataTable = New DataTable()
        dt.TableName = "Therapy"
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("NAME", GetType(String))
        dt.Columns.Add("TYPE", GetType(String))
        dt.Columns.Add("THERAPIST", GetType(String))

        ' preordered
        dt.Rows.Add(1, "Acupuncture", "Type 1", "")
        dt.Rows.Add(1, "", "Type 1", "Dr. Lucius Livius Andronicus")
        dt.Rows.Add(2, "", "Type 1", "Dr. Gnaeus Naevius")
        dt.Rows.Add(3, "", "Type 1", "Dr. Quintus Ennius")
        dt.Rows.Add(4, "Osmotherapy", "Type 2", "")
        dt.Rows.Add(4, "", "Type 2", "Dr. Marcus Pacuvius")
        dt.Rows.Add(5, "Prolotherapy", "Type 3", "")
        dt.Rows.Add(5, "", "Type 3", "Dr. Lucius Accius")
        dt.Rows.Add(6, "", "Type 3", "Dr. Titus Maccius Plautus")
        dt.Rows.Add(7, "Helminthic Therapy", "Type 4", "")
        dt.Rows.Add(7, "", "Type 4", "Dr. Publius Terentius Afer (Dr. Terence)")
        dt.Rows.Add(8, "Physiotherapy", "Type 5", "")
        dt.Rows.Add(8, "", "Type 5", "Dr. Marcus Porcius Cato (Dr. Cato the Elder)")
        dt.Rows.Add(9, "", "Type 5", "Dr. Gaius Lucilius")
        dt.Rows.Add(10, "", "Type 5", "Dr. Marcus Tullius Cicero")
        dt.Rows.Add(11, "", "Type 5", "Dr. Publius Ovidius Naso (Dr. Ovid)")
        dt.Rows.Add(11, "", "Type 5", "Dr. Gaius Valerius Catullus")
        Return dt
    End Function
End Class
