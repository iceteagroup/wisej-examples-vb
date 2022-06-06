Imports System
Imports System.ComponentModel
Imports DataBinding.DataBinding
Imports Wisej.Web

Module Program

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Main()

        Dim lMain = New MainPage()
        lMain.Show()
        AddHandler Application.SessionTimeout, AddressOf Application_SessionTimeout

    End Sub

    Private Sub Application_SessionTimeout(ByVal sender As Object, ByVal e As HandledEventArgs)
        ' you can display a form and override the default session timeout dialog.
        e.Handled = True
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

