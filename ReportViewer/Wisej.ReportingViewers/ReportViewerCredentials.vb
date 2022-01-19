Imports Microsoft.Reporting.WebForms
Imports System.Net
Imports System.Security.Principal
Imports System.Runtime.InteropServices

Friend Class ReportViewerCredentials
    Implements IReportServerCredentials

    Private userName As String
    Private password As String
    Private domainName As String

    Public Sub New(ByVal UserName As String, ByVal Password As String, ByVal DomainName As String)
        Me.userName = UserName
        Me.password = Password
        Me.domainName = DomainName
    End Sub

    Public ReadOnly Property ImpersonationUser As WindowsIdentity Implements IReportServerCredentials.ImpersonationUser
        Get
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property NetworkCredentials As ICredentials Implements IReportServerCredentials.NetworkCredentials
        Get
            Return New NetworkCredential(userName, password, domainName)
        End Get
    End Property

    Private Function GetFormsCredentials(<Out> ByRef authCookie As Cookie, <Out> ByRef userName As String, <Out> ByRef password As String, <Out> ByRef authority As String) As Boolean Implements IReportServerCredentials.GetFormsCredentials
        authCookie = Nothing
        userName = Nothing
        password = Nothing
        authority = Nothing
        Return False
    End Function
End Class
