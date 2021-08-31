Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq

Public Class AppData
    Public Delegate Sub CustomEventHandler(ByVal sender As Object, ByVal args As Models.MessageEventArgs)
    Public Shared Event RaiseNewMessage As EventHandler(Of Models.MessageEventArgs)
    Private Shared [SyncLock] As Object = New Object()
    Private Shared _connectedUser As IEnumerable(Of Models.User)
    ''' <value>
    ''' Get all connected user
    ''' </value>
    Public Shared ReadOnly Property ConnectedUser As IEnumerable(Of Models.User)
        Get
            If _connectedUser Is Nothing Then _connectedUser = New List(Of Models.User)()
            Return _connectedUser
        End Get
    End Property

    ''' <summary>
    ''' Add user to connected user.
    ''' </summary>
    ''' <paramname="user">User we want to add.</param>
    Public Shared Sub AddUser(ByVal user As Models.User)
        Dim existingUser = ConnectedUser.FirstOrDefault(Function(u) Equals(u.SessionId, user.SessionId) OrElse Equals(u.Username, user.Username))
        If existingUser IsNot Nothing Then Throw New Exception("User already exist")
        CType(ConnectedUser, List(Of Models.User)).Add(user)
    End Sub

    Private Shared _messages As BindingList(Of Models.Message)
    ''' <value>
    ''' Get all Messages sended.
    ''' </value>
    Public Shared ReadOnly Property Messages As BindingList(Of Models.Message)
        Get
            If _messages Is Nothing Then _messages = New BindingList(Of Models.Message)()
            Return _messages
        End Get
    End Property
    ''' <summary>
    ''' Add new message send.
    ''' </summary>
    ''' <paramname="message">Message we want to send.</param>
    Public Shared Sub AddMessage(ByVal message As Models.Message)
        SyncLock [SyncLock]
            Dim userExist = ConnectedUser.FirstOrDefault(Function(u) Equals(u.SessionId, message.Sender.SessionId) AndAlso Equals(u.Username, message.Sender.Username))
            If userExist Is Nothing Then Throw New Exception("User not found")
            Messages.Add(message)
            RaiseEvent RaiseNewMessage(userExist, New Models.MessageEventArgs(message))
        End SyncLock
    End Sub
End Class
