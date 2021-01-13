Imports System
Imports TreeGrid.Model
Imports Wisej.Web

Partial Public Class ObjectListWindow

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Page1_Load(ByVal sender As Object, ByVal e As EventArgs)

        Dim therapyList = Model.TherapyList.Instance()
        Dim therapistList = Model.TherapistList.Instance()

        For Each therapy In therapyList
            dataGridView.Rows.Add(therapy.TherapyId, therapy.TherapyName, "")
            Dim currentTherapyRow = dataGridView.Rows(dataGridView.RowCount - 1)
            currentTherapyRow(1).Style.ColSpan = 2

            For Each therapist In therapistList

                If therapist.TherapyId = therapy.TherapyId Then
                    dataGridView.Rows.Add(therapist.TherapyId, "", therapist.TherapistName)
                    dataGridView.Rows(dataGridView.RowCount - 1).ParentRow = currentTherapyRow
                End If
            Next

            currentTherapyRow.Collapse()
        Next
    End Sub
End Class
