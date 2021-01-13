Imports System.ComponentModel

Namespace DataBinding.Model
    Public Class Vendor
        Implements INotifyPropertyChanged

#Region "Static Fields"

        Private Shared _lastId As Integer

#End Region

#Region "Business Properties"

        Private ReadOnly _vendorId As Integer

        Public ReadOnly Property VendorId As Integer
            Get
                Return _vendorId
            End Get
        End Property

        Private _firstName As String

        Public Property FirstName As String
            Get
                Return _firstName
            End Get
            Set(ByVal value As String)

                If Not Equals(_firstName, value) Then
                    _firstName = value
                    OnPropertyChanged(NameOf(Vendor.FirstName))
                    OnPropertyChanged(NameOf(Vendor.FullName))
                End If
            End Set
        End Property

        Private _lastName As String

        Public Property LastName As String
            Get
                Return _lastName
            End Get
            Set(ByVal value As String)

                If Not Equals(_lastName, value) Then
                    _lastName = value.ToUpper()
                    OnPropertyChanged(NameOf(Vendor.LastName))
                    OnPropertyChanged(NameOf(Vendor.FullName))
                End If
            End Set
        End Property

        Private _town As String

        Public Property Town As String
            Get
                Return _town
            End Get
            Set(ByVal value As String)

                If Not Equals(_town, value) Then
                    _town = value
                    OnPropertyChanged(NameOf(Vendor.Town))
                End If
            End Set
        End Property

        Private _state As States

        Public Property State As States
            Get
                Return _state
            End Get
            Set(ByVal value As States)

                If _state <> value Then
                    _state = value
                    OnPropertyChanged(NameOf(Vendor.State))
                End If
            End Set
        End Property

        Public ReadOnly Property FullName As String
            Get
                Return $"{_firstName} {_lastName}"
            End Get
        End Property

        Public Property IsNew As Boolean
            Get
                Return _IsNew
            End Get
            Private Set(ByVal value As Boolean)
                _IsNew = value
            End Set
        End Property

#End Region

#Region "State Properties"

        Private _IsNew As Boolean
#End Region

#Region "Constructor"

        Public Sub New()
            IsNew = True
            _vendorId = Threading.Interlocked.Increment(_lastId)
            OnPropertyChanged(NameOf(Vendor.VendorId))
        End Sub

#End Region

#Region "Business Methods"

        Public Sub Save()
            If Not VendorList.Contains(VendorId) Then
                VendorList.GetVendorList().Add(Me)
                IsNew = False
            End If
        End Sub

        Public Sub Delete()
            If VendorList.Contains(VendorId) Then VendorList.GetVendorList().Remove(Me)
        End Sub

#End Region

#Region "INotifyPropertyChanged Members"

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub OnPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

#End Region
    End Class
End Namespace
