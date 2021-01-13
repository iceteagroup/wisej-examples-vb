Imports System
Imports Wisej.Web

Module Program

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Main()

        Application.Desktop = New MyDesktop()

        Dim window As Window1 = New Window1()
        window.Show()

        Dim window2 As Window2 = New Window2()
        window2.Show()

        Dim window3 As Window3 = New Window3()
        window3.Show()

        Dim window4 As Window4 = New Window4()
        window4.Show()

        Dim window5 As Window5 = New Window5()
        window5.Show()


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