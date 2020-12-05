Imports System
Imports System.ComponentModel
Imports Wisej.Web.Ext.Polymer

''' <summary>
''' Implementation of the paper-button polymer widget.
''' </summary>
<DefaultEvent("Click")>
    Public Class PaperButton
        Inherits PolymerWidget

        Public Sub New()
            ' define the element type.
            MyBase.ElementType = "paper-button"
        End Sub


        ''' <summary>
        ''' Returns or sets whether the element will not produce a ripple effect when interacted with via the pointer.
        ''' </summary>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property NoInk As Boolean
            Get
                Return If(Properties.noink, False)
            End Get
            Set(ByVal value As Boolean)
                Properties.noink = value
                Update()
            End Set
        End Property


        ''' <summary>
        ''' Returns or sets whether the button should be styled with a shadow.
        ''' </summary>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Raised As Boolean
            Get
                Return If(Properties.raised, False)
            End Get
            Set(ByVal value As Boolean)
                Properties.raised = value
                Update()
            End Set
        End Property


        ''' <summary>
        ''' Returns or sets whether the button toggles the active state with each tap or press of the spacebar.
        ''' </summary>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Toggles As Boolean
            Get
                Return If(Properties.toggles, False)
            End Get
            Set(ByVal value As Boolean)
                Properties.toggles = value
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
