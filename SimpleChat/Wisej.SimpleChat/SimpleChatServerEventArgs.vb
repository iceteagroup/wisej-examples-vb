Imports System

Public Class SimpleChatServerEventArgs
    Inherits System.EventArgs

    Private _TimeStamp As System.DateTime, _From As String, _Message As String

    Public Sub New(ByVal from As String, ByVal timeStamp As System.DateTime, ByVal message As String)
        Me.From = from
        Me.TimeStamp = timeStamp
        Me.Message = message
    End Sub

    Public Property TimeStamp As System.DateTime
        Get
            Return _TimeStamp
        End Get
        Private Set(ByVal value As System.DateTime)
            _TimeStamp = value
        End Set
    End Property

    Public Property From As String
        Get
            Return _From
        End Get
        Private Set(ByVal value As String)
            _From = value
        End Set
    End Property

    Public Property Message As String
        Get
            Return _Message
        End Get
        Private Set(ByVal value As String)
            _Message = value
        End Set
    End Property
End Class
