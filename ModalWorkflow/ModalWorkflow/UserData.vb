Imports System

Public Class UserData
    Implements ICloneable

    Public Sub New()
        AccountCreation = Date.Now
        AccountExpiration = Date.Now
    End Sub

    Public Property Name As String
    Public Property LastName As String
    Public Property Role As UserRole
    Public Property AccountCreation As Date
    Public Property AccountExpiration As Date

    Public Function Clone() As Object Implements ICloneable.Clone
        Return MemberwiseClone()
    End Function
End Class

Public Enum UserRole
        User
        Contributor
        Editor
        Administrator
    End Enum
