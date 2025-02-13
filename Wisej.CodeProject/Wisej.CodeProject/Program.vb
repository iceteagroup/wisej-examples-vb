Imports System
Imports Wisej.Web

Module Program

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Main()

        Application.Desktop = New MyDesktop()

    End Sub

    Dim theCPUCounter As Random = New Random

    Friend ReadOnly Property CPU As Single
        Get
            ' returns a random number for this sample.
            ' returning the CPU Usage % requires elevated
            ' permissions on the server side.
            'theCPUCounter
            'TODO: lock is not supported at this time
            Return theCPUCounter.Next(50)
            ' return theCPUCounter.NextValue();
        End Get
    End Property

    ' ''' <summary>
    ' ''' You can use the entry method below
    ' ''' to receive the parameters from the URL in the args collection.
    ' ''' </summary>
    ' ''' <param name="args"></param>
    ' ''' <remarks></remarks>
    'Public Sub Main(args As NameValueCollection)

    'End Sub

End Module