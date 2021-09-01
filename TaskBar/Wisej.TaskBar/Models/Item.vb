Namespace Wisej.TaskBar.Models
    Public Class Item

        Public Sub New(extension As String,
                       id As String,
                       name As String,
                       type As String,
                       path As String,
                       size As String)
            Me.Name = name
            Me.Id = id
            Me.Extension = extension
            Me.Type = type
            Me.Path = path
            Me.Size = size


        End Sub

        Private _id As String
        Public Property Id() As String
            Get
                Return Me._id
            End Get
            Set(value As String)
                _id = value
            End Set
        End Property

        Private _name As String
        Public Property Name() As String
            Get
                Return Me._name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property

        Private _path As String
        Public Property Path() As String
            Get
                Return Me._path
            End Get
            Set(value As String)
                _path = value
            End Set
        End Property

        Private _extension As String
        Public Property Extension() As String
            Get
                Return Me._extension
            End Get
            Set(value As String)
                _extension = value
            End Set
        End Property

        Private _size As String
        Public Property Size() As String
            Get
                Return Me._size
            End Get
            Set(value As String)
                _size = value
            End Set
        End Property

        Private _type As ItemType
        Public Property Type() As ItemType
            Get
                Return Me._type
            End Get
            Set(value As ItemType)
                _type = value
            End Set
        End Property
    End Class

    Public Enum ItemType
        Folder
        File
        Shortcut
    End Enum
End Namespace

