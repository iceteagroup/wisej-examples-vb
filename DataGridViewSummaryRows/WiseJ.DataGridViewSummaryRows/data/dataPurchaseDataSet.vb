Imports System
Imports System.Data
Imports System.IO

Namespace WiseJ.DataGridViewSummaryRows.data
    Public Class dataPurchaseDataSet
        Private _dtHeader, _dtDetail As DataTable
        Private _dsData As DataSet

        Public Property DsData As DataSet
            Get
                Return _dsData
            End Get
            Set(ByVal value As DataSet)
                _dsData = value
            End Set
        End Property

        Public Function LoadData(ByVal sPath As String, ByVal sFileXML As String, ByVal sTableName As String) As Boolean
            Dim result As Boolean
            result = False

            ' Create a new DataSet and read sales data file 
            If DsData Is Nothing Then
                DsData = New DataSet()
            End If

            Dim _dsDataXML As DataSet = New DataSet()
            Dim _reportPath = Path.Combine(sPath, sFileXML)
            _dsDataXML.ReadXml(_reportPath)

            'Add table from readed XmlFile into DataSet
            Dim dtData As DataTable = New DataTable()
            dtData = _dsDataXML.Tables(0).Copy()
            dtData.TableName = sTableName
            DsData.Tables.Add(dtData)
            result = True
            Return result
        End Function

        Public Function SetDataRelation(ByVal RelationName As String, ByVal tableParent As String, ByVal tableChild As String, ByVal tableParentID As String, ByVal tableChildID As String) As Boolean
            Dim result = False

            Try
                ' Establish a relationship between the two tables.
                Dim relation As DataRelation = New DataRelation(RelationName, DsData.Tables(tableParent).Columns(tableParentID), DsData.Tables(tableChild).Columns(tableChildID))
                DsData.Relations.Add(relation)
                result = True
            Catch __unusedException1__ As Exception
                Throw
            End Try

            Return result
        End Function

        Private Function LoadXmlFile(ByVal XMLFIle As String, ByVal dt As DataTable) As Boolean
            Dim result As Boolean
            result = False
            Return result
        End Function
    End Class
End Namespace
