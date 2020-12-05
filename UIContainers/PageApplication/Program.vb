Imports System
Imports Wisej.Web

Module Program

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Main()

        Application.Session.pagePrimary = New PrimaryPage()
        Application.Session.pageSecondary = New SecondaryPage()
        Application.Session.primaryWindow = New PrimaryForm()
        Application.Session.secondaryWindow = New SecondaryForm()
        Application.Session.switchWindow = New SwitchForm()
        Application.MainPage = Application.Session.pagePrimary

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