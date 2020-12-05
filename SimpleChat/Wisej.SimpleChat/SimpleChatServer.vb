Imports System
Imports System.Collections.Generic

Public Module SimpleChatServer
    Private Const ADMIN As String = "Admin"
    Private [SyncLock] As Object = New Object()
    Private UserNames As List(Of String) = New List(Of String)()
    Public Event IncomingMessage As SimpleChatServerEventHandler

    Public Sub Join(ByVal name As String)
        SyncLock [SyncLock]
            If String.Equals(name, ADMIN, StringComparison.InvariantCulture) Then Throw New Exception($"""{name}"" is reserved.")

            ' just make sure it's a unique name. It's not really necessary in this case, but it's a nice thing to do...
            If UserNames.Contains(name) Then Throw New Exception($"User ""{name}"" has already joined.")
            UserNames.Add(name)
            SendMessage(ADMIN, $"""{name}"" joined the chat.")
        End SyncLock
    End Sub

    Public Sub Leave(ByVal name As String)
        SyncLock [SyncLock]
            UserNames.Remove(name)
            SendMessage(ADMIN, $"""{name}"" left the chat.")
        End SyncLock
    End Sub

    Public Sub SendMessage(ByVal from As String, ByVal text As String)
        RaiseEvent IncomingMessage(New SimpleChatServerEventArgs(from, Date.Now, text))
    End Sub
End Module
