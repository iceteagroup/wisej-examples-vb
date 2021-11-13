Imports System
Imports System.Data
Imports System.IO

Public Class dataUtility
    Implements IDisposable

    Private _dataPath As String
    Private _dataFileXML As String
    Private _data As DataTable

    Public Function LoadData() As Boolean
        Dim result = False
        _data = LoadDataXML()

        If _data.Rows.Count > 0 Then
            result = True
        End If

        Return result
    End Function

    Private Function LoadDataXML() As DataTable
        ' Create a new DataSet and read sales data file 
        '    data.xml into the first DataTable.
        Dim dataSet As DataSet = New DataSet()
        Dim _reportPath = Path.Combine(_dataPath, _dataFileXML)
        dataSet.ReadXml(_reportPath)
        Return dataSet.Tables(0)
    End Function

    Public Property DataPath As String
        Get
            Return _dataPath
        End Get
        Set(ByVal value As String)
            _dataPath = value
        End Set
    End Property

    Public Property DataFileXML As String
        Get
            Return _dataFileXML
        End Get
        Set(ByVal value As String)
            _dataFileXML = value
        End Set
    End Property

    Public Property Data As DataTable
        Get
            Return _data
        End Get
        Set(ByVal value As DataTable)
            _data = value
        End Set
    End Property

    Public Sub Dispose() Implements IDisposable.Dispose
        If Data IsNot Nothing Then
            Data = Nothing
        End If

        Throw New NotImplementedException()
    End Sub
End Class
