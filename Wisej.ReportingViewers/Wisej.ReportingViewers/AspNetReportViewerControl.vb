Imports Microsoft.Reporting.WebForms
Imports System
Imports System.ComponentModel
Imports System.Web.UI.WebControls
Imports Wisej.Web
Imports Wisej.Web.Ext.AspNetControl

''' <summary>
''' Sample ReportViewer wrapper.
''' </summary>
<ToolboxItem(True)>
    Public Class AspNetReportViewerControl
        Inherits AspNetWrapper(Of ReportViewer)
        ''' <summary>
        ''' Returns or sets the URL of the Reporting Services server.
        ''' </summary>
        Public Property ServerUrl As String
            Get
                Return _serverUrl
            End Get
            Set(ByVal value As String)
                value = If(value, "")

                If Not Equals(_serverUrl, value) Then
                    _serverUrl = value
                    Update()
                End If
            End Set
        End Property

        Private _serverUrl As String = ""

        ''' <summary>
        ''' Returns or sets the path to the report on the server.
        ''' </summary>
        <DefaultValue("")>
        Public Property ReportPath As String
            Get
                Return _reportPath
            End Get
            Set(ByVal value As String)
                value = If(value, "")

                If Not Equals(_reportPath, value) Then
                    _reportPath = value
                    Update()
                End If
            End Set
        End Property

        Private _reportPath As String = ""

        ''' <summary>
        ''' Returns or sets the authentication user name.
        ''' </summary>
        '<ComponentModel.DefaultValue(Nothing)>
        <DefaultValue(DirectCast(Nothing, String))>
        Public Property UserName As String

        ''' <summary>
        ''' Returns or sets the authentication password.
        ''' </summary>
        '<ComponentModel.DefaultValueAttribute(Nothing)>
        <DefaultValue(DirectCast(Nothing, String))>
        Public Property Password As String

        ''' <summary>
        ''' Returns or sets the authentication domain name.
        ''' </summary>
        '<ComponentModel.DefaultValueAttribute(Nothing)>
        <DefaultValue(DirectCast(Nothing, String))>
        Public Property DomainName As String

        ''' <summary>
        ''' Returns or sets the <seecref="ProcessingMode"/> of the report viewer.
        ''' </summary>
        Public Property ProcessingMode As ProcessingMode

        ''' <summary>
        ''' Shows or hide the export controls.
        ''' </summary>
        Public Property ShowExportControls As Boolean

        Protected Overrides Sub OnInit(ByVal e As EventArgs)
            MyBase.OnInit(e)
            Dim viewer = WrappedControl

            If Not IsPostBack Then
                viewer.SizeToReportContent = True
                viewer.ProcessingMode = ProcessingMode

                If ProcessingMode = ProcessingMode.Local Then
                    viewer.LocalReport.ReportPath = ReportPath
                Else
                    viewer.ServerReport.ReportPath = ReportPath
                    viewer.ServerReport.ReportServerUrl = New Uri(ServerUrl)
                    If Not IsPostBack AndAlso Not Equals(UserName, Nothing) Then viewer.ServerReport.ReportServerCredentials = New ReportViewerCredentials(UserName, Password, DomainName)
                End If

                viewer.ShowExportControls = ShowExportControls
            End If

            ' attach the handled events to fire the event on the wrapper.
            If ToggleEvent IsNot Nothing Then AddHandler viewer.Toggle, AddressOf viewer_Toggle
            If BookmarkNavigationEvent IsNot Nothing Then AddHandler viewer.BookmarkNavigation, AddressOf viewer_BookmarkNavigation
            If PageNavigationEvent IsNot Nothing Then AddHandler viewer.PageNavigation, AddressOf viewer_PageNavigation
        End Sub

        Private Sub viewer_BookmarkNavigation(ByVal sender As Object, ByVal e As BookmarkNavigationEventArgs)
            ' this call is coming from the aspnet handler. if the
            ' event handler in the wisej application updates a control, we need
            ' either call Application.Update, or run the handler in an Update block to
            ' push any update back to the client after the block is executed.
            Application.Update(Me, Sub() RaiseEvent BookmarkNavigation(sender, e))
        End Sub

        Private Sub viewer_PageNavigation(ByVal sender As Object, ByVal e As PageNavigationEventArgs)
            Application.Update(Me, Sub() RaiseEvent PageNavigation(sender, e))
        End Sub

        Private Sub viewer_Toggle(ByVal sender As Object, ByVal e As CancelEventArgs)
            Application.Update(Me, Sub() RaiseEvent Toggle(sender, e))
        End Sub

        ''' <summary>
        ''' Toggle event.
        ''' </summary>
        Public Event Toggle As CancelEventHandler

        ''' <summary>
        ''' PageNavigation event.
        ''' </summary>
        Public Event PageNavigation As PageNavigationEventHandler

        ''' <summary>
        ''' BookmarkNavigation event.
        ''' </summary>
        Public Event BookmarkNavigation As BookmarkNavigationEventHandler
    End Class
