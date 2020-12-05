Imports System
Imports Wisej.Web

Module Program

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Main()

        Application.Session.desktopPrimary = New PrimaryDesktop()
        Application.Session.desktopSecondary = New SecondaryDesktop()
        Application.Session.primaryWindow = New PrimaryForm()
        Application.Session.secondaryWindow = New SecondaryForm()
        Application.Session.switchWindow = New SwitchForm()
        Application.Desktop = Application.Session.desktopPrimary

        'Application.Desktop = New MyDesktop()
        'Dim window As New Window1()
        'window.Show()

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