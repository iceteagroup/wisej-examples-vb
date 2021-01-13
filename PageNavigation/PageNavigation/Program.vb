Imports System
Imports System.ComponentModel
Imports Wisej.Web

Module Program

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Main()

        Application.Session.Username = String.Empty
        AddHandler Application.ThreadException, AddressOf Application_ThreadException
        AddHandler Application.SessionTimeout, AddressOf Application_SessionTimeout
        Navigate(GetType(Login))
    End Sub

    Private Sub Application_ThreadException(ByVal sender As Object, ByVal e As Threading.ThreadExceptionEventArgs)
        Dim faultPageName = Application.MainPage.Name
        Dim page = CType(Application.OpenPages("ErrorPage"), ErrorPage)

        If page IsNot Nothing Then
            page.FaultPageName = faultPageName
            page.Message = e.Exception.Message
            page.Show()
        Else
            Call New ErrorPage With {
                .FaultPageName = faultPageName,
                .Message = e.Exception.Message
            }.Show()
        End If
    End Sub

    Private Sub Application_SessionTimeout(ByVal sender As Object, ByVal e As HandledEventArgs)
        ' override default timeout management
        e.Handled = True

        ' use your own timeout manager
        'TimeoutManager.DoManage();
    End Sub

    ' ''' <summary>
    ' ''' You can use the entry method below
    ' ''' to receive the parameters from the URL in the args collection.
    ' ''' </summary>
    ' ''' <param name="args"></param>
    ' ''' <remarks></remarks>
    'Public Sub Main(args As NameValueCollection)

    'End Sub

End Module