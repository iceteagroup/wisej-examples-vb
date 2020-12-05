Imports Wisej.Web

Public Class DataGridViewJSONColumn
    Inherits DataGridViewTextBoxColumn

    Public Sub New()
        Editor = New DataGridViewJSONColumnEditor()
    End Sub

    Public Overrides Property CellRenderer As String
        Get
            Return "my.JSONCellRenderer"
        End Get
        Set(ByVal value As String)
        End Set
    End Property
End Class
