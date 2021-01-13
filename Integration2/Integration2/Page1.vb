Imports System
Imports System.Data
Imports System.Web.Script.Serialization
Imports System.Collections.Generic
Imports Wisej.Web
Imports System.IO
Imports System.Drawing

Partial Public Class Page1

    Public Sub New()
        InitSearchEngines()
        InitializeComponent()
    End Sub

    Private dtSearchEngines As DataTable = New DataTable()
    Private Creating As Boolean = True

    ''' <summary>
    ''' Initialize data
    ''' </summary>
    Private Sub InitSearchEngines()
        dtSearchEngines.Columns.Add("text", GetType(String))
        dtSearchEngines.Columns.Add("url", GetType(String))
        dtSearchEngines.Columns.Add("frequency", GetType(Integer))
        dtSearchEngines.Rows.Add("Yahoo!", "http://search.yahoo.com/", 20)
        dtSearchEngines.Rows.Add("DuckDuckGo", "https://duckduckgo.com/", 5)
        dtSearchEngines.Rows.Add("Bing", "http://www.bing.com/", 23)
        dtSearchEngines.Rows.Add("Blekko", "http://blekko.com/", 4)
        dtSearchEngines.Rows.Add("Alhea", "http://www.alhea.com/", 3)
        dtSearchEngines.Rows.Add("MyWebSearch", "http://home.mywebsearch.com/index.jhtml", 10)
        dtSearchEngines.Rows.Add("Infospace", "http://infospace.com/", 8)
        dtSearchEngines.Rows.Add("Google", "https://www.google.com/", 24)
        dtSearchEngines.Rows.Add("Dogpile", "http://www.dogpile.com/", 4)
        dtSearchEngines.Rows.Add("Wow", "http://www.wow.com/", 14)
        dtSearchEngines.Rows.Add("Info", "http://www.info.com/", 6)
        dtSearchEngines.Rows.Add("WebCrawler", "http://www.webcrawler.com/", 12)
        dtSearchEngines.Rows.Add("Contenko", "http://www.contenko.com/", 3)
        dtSearchEngines.Rows.Add("Aol Search", "http://search.aol.com", 16)
    End Sub

    Private Sub Page1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' create columns
        dataGridViewSearchEngines.Columns(0).DataPropertyName = "text"
        dataGridViewSearchEngines.Columns(1).DataPropertyName = "url"
        dataGridViewSearchEngines.Columns(2).DataPropertyName = "frequency"
        ' bind to data
        dataGridViewSearchEngines.DataSource = New BindingSource(dtSearchEngines, Nothing)
        AddHandler dataGridViewSearchEngines.CellClick, AddressOf DataGridView1_CellClick
        Creating = False
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        ' handle link column
        If e.ColumnIndex = 1 Then
            ' only if the link is clicked, not somewhere else in the cell
            If Equals(e.Role, "link") Then
                If e.RowIndex >= 0 Then
                    ' may need to allow popups in chrome etc.
                    Application.Navigate(dtSearchEngines.Rows(e.RowIndex)("url").ToString(), "_blank")
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Populate TagCloud from DataTable
    ''' </summary>
    ''' <paramname="sender"></param>
    ''' <paramname="e"></param>
    Private Sub widgetTagCloud_WebRequest(ByVal sender As Object, ByVal e As WebRequestEventArgs)
        e.Response.ContentType = "application /json"
        e.Response.Write(DataTableToJson(dtSearchEngines))
    End Sub

    ''' <summary>
    ''' Converts a DataTable to a JSON string
    ''' </summary>
    ''' <paramname="dt"></param>
    ''' <returns></returns>
    Private Function DataTableToJson(ByVal dt As DataTable) As String
        Dim list = New List(Of Dictionary(Of String, Object))()

        For Each row As DataRow In dt.Rows
            Dim dict = New Dictionary(Of String, Object)()

            For Each col As DataColumn In dt.Columns
                dict(col.ColumnName) = row(col)
            Next

            list.Add(dict)
        Next

        Dim serializer As JavaScriptSerializer = New JavaScriptSerializer()
        Dim json = serializer.Serialize(list)
        Return json
    End Function

    ''' <summary>
    ''' When the frequency cell is edited, update slider and TagCloud
    ''' </summary>
    ''' <paramname="sender"></param>
    ''' <paramname="e"></param>
    Private Sub dataGridViewSearchEngines_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        If e.ColumnIndex = 2 AndAlso Not Creating Then
            ' empty cell -> 1
            If dtSearchEngines.Rows(e.RowIndex)("frequency") Is DBNull.Value Then dtSearchEngines.Rows(e.RowIndex)("frequency") = 1
            Dim value = Convert.ToInt32(dtSearchEngines.Rows(e.RowIndex)("frequency"))
            ' set to max / min value
            If value > 25 Then
                value = 25
            ElseIf value < 1 Then
                value = 1
            End If

            RefreshTagCloud()
            Dim sfSlider As SFSlider = TryCast(dataGridViewSearchEngines.Rows(e.RowIndex)("colSlider").Control, SFSlider)
            sfSlider.Eval("this.setValue(" & value & ")")
            dataGridViewSearchEngines.BindingContext(dataGridViewSearchEngines.DataSource).EndCurrentEdit()
        End If
    End Sub

    ''' <summary>
    ''' Create the sliders as controls in the 4th column
    ''' </summary>
    ''' <paramname="sender"></param>
    ''' <paramname="e"></param>
    Private Sub dataGridViewSearchEngines_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs)
        For i = 0 To dataGridViewSearchEngines.Rows.Count - 1
            Dim sfSlider As SFSlider = New SFSlider() With {
                .Value = Convert.ToInt32(dtSearchEngines.Rows(i)("frequency"))
            }
            dataGridViewSearchEngines.Rows(i)("colSlider").Control = sfSlider
            sfSlider.Dock = DockStyle.Fill
            sfSlider.UserData.Row = i
            AddHandler sfSlider.WidgetEvent, AddressOf SfSlider_WidgetEvent
        Next
    End Sub

    ''' <summary>
    ''' A sliders value has changed
    ''' </summary>
    ''' <paramname="sender"></param>
    ''' <paramname="e"></param>
    Private Sub SfSlider_WidgetEvent(ByVal sender As Object, ByVal e As WidgetEventArgs)
        Dim sfSlider As SFSlider = TryCast(sender, SFSlider)

        If sfSlider IsNot Nothing Then
            If Equals(e.Type, "change") Then
                Dim row As Integer = sfSlider.UserData.Row
                dtSearchEngines.Rows(row)("frequency") = e.Data
                RefreshTagCloud()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Refresh the TagCloud
    ''' </summary>
    Private Sub RefreshTagCloud()
        widgetTagCloud.Call("refreshItems")
    End Sub

    ''' <summary>
    ''' Handles clicks on the TagCloud
    ''' </summary>
    ''' <paramname="sender"></param>
    ''' <paramname="e"></param>
    Private Sub widgetTagCloud_WidgetEvent(ByVal sender As Object, ByVal e As WidgetEventArgs)
        AlertBox.Show("clicked on " & e.Data.url & ": " + e.Data.text)
    End Sub

    Private Sub widgetSignature_WidgetEvent(ByVal sender As Object, ByVal e As WidgetEventArgs) Handles widgetSignature.WidgetEvent
        Select Case e.Type
            Case "change"
                OnSignatureChanged(e.Data.lastImage)
        End Select
    End Sub

    Private Sub OnSignatureChanged(ByVal imageData As String)
        pictureBox1.Image = ImageFromBase64(imageData)
    End Sub

    ''' <summary>
    ''' Returns the Image encoded in a base64 string.
    ''' </summary>
    ''' <paramname="base64"></param>
    ''' <returns></returns>
    Private Shared Function ImageFromBase64(ByVal base64 As String) As Image
        ' data:image/gif;base64,R0lGODlhCQAJAIABAAAAAAAAACH5BAEAAAEALAAAAAAJAAkAAAILjI+py+0NojxyhgIAOw==
        Try
            If String.IsNullOrEmpty(base64) Then Return Nothing
            Dim pos = base64.IndexOf("base64,")
            If pos < 0 Then Return Nothing
            base64 = base64.Substring(pos + 7)
            Dim buffer = Convert.FromBase64String(base64)
            Dim stream As MemoryStream = New MemoryStream(buffer)
            Return New Bitmap(stream)
        Catch
        End Try

        Return Nothing
    End Function
End Class
