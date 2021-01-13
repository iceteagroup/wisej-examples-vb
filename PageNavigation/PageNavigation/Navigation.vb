Imports System
Imports Wisej.Web
Imports System.Runtime.CompilerServices

Friend Module Navigation
    Public Property PreviousPage As Page
        Get
            Return Application.Session.PreviousPage
        End Get
        Private Set(ByVal value As Page)
            Application.Session.PreviousPage = value
        End Set
    End Property

    Public Sub Navigate(ByVal page As Page)
        PreviousPage = Application.MainPage
        page.Show()
    End Sub

    Public Function Navigate(ByVal pageType As Type, ParamArray args As Object()) As Page
        PreviousPage = Application.MainPage
        Dim page = Application.OpenPages(pageType.Name)
        If page Is Nothing Then page = CType(Activator.CreateInstance(pageType, args), Page)
        page.Show()
        Return page
    End Function

    Public Function WorkspaceNavigate(ByVal pageName As String) As Page
        PreviousPage = Application.MainPage
        Dim page = CType(Application.OpenPages(pageName), Workspace)
        If page Is Nothing Then page = New Workspace(pageName)
        page?.Show()
        Return page
    End Function

    Public Sub NavigateBack()
        PreviousPage.Show()
    End Sub

    <Extension()>
    Public Sub Close(ByVal page As Page)
        page.Dispose()
        PreviousPage.Show()
    End Sub
End Module
