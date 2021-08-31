Imports System

Namespace Models

    Public Class Message
        Public Property Id As String
        Public Property Content As String
        Public Property Sender As User
        Public Property [Date] As Date

        Public Overrides Function ToString() As String
            Return $"{Sender.Username} FROM {Sender.SessionId}  AT {[Date]} : {Content}"
        End Function
    End Class

    Public Class MessageEventArgs
        Inherits EventArgs

        Public Property Message As Message

        Public Sub New(ByVal message As Message)
            Me.Message = message
        End Sub
    End Class

End Namespace
