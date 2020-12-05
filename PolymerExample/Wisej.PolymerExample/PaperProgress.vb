Imports System
Imports System.ComponentModel
Imports Wisej.Web.Ext.Polymer

''' <summary>
''' Implementation of the paper-progress polymer widget.
''' </summary>
Public Class PaperProgress
        Inherits PolymerWidget

        Public Sub New()
            ' define the element type.
            MyBase.ElementType = "paper-progress"
        End Sub


        ''' <summary>
        ''' Returns or sets the minimum value.
        ''' </summary>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Min As Integer
            Get
                Return If(Properties.min, 0)
            End Get
            Set(ByVal value As Integer)
                Properties.min = value
                Update()
            End Set
        End Property


        ''' <summary>
        ''' Returns or sets the maximum value.
        ''' </summary>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Max As Integer
            Get
                Return If(Properties.max, 0)
            End Get
            Set(ByVal value As Integer)
                Properties.max = value
                Update()
            End Set
        End Property


        ''' <summary>
        ''' Returns or sets the value.
        ''' </summary>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Value As Integer
            Get
                Return If(Properties.value, 0)
            End Get
            Set(ByVal value As Integer)
                Properties.value = value
                Update()
            End Set
        End Property


        ''' <summary>
        ''' Returns or sets the secondary-progress value.
        ''' </summary>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property SecondaryProgress As Integer
            Get
                Return If(Me.Properties("secondary-progress"), 0)
            End Get
            Set(ByVal value As Integer)
                Me.Properties("secondary-progress") = value
                Update()
            End Set
        End Property


        ''' <summary>
        ''' Returns or sets the polymer element type.
        ''' </summary>
        <Browsable(False)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overrides Property ElementType As String
            Get
                Return MyBase.ElementType
            End Get
            Set(ByVal value As String)
            End Set
        End Property


        ''' <summary>
        ''' Returns or sets the events from the polymer widget to handle on the server side.
        ''' </summary>
        <Browsable(False)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overrides Property Events As String()
            Get
                Return MyBase.Events
            End Get
            Set(ByVal value As String())
                MyBase.Events = value
            End Set
        End Property


    ''' <summary>
    ''' Returns or sets the specified property values on the polymer widget
    ''' and defines the properties to receive back when an event is fired.
    ''' </summary>
    <Browsable(False)>
    Public Overrides Property Properties As Object
        Get
            Return MyBase.Properties
        End Get
        Set(ByVal value As Object)
            MyBase.Properties = value
        End Set
    End Property
End Class
