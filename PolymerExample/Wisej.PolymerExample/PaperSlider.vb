Imports System
Imports System.ComponentModel
Imports Wisej.Web
Imports Wisej.Web.Ext.Polymer

''' <summary>
''' Implementation of the paper-slider polymer widget.
''' </summary>
<DefaultEvent("ValueChanged")>
    Public Class PaperSlider
        Inherits PolymerWidget

        Public Sub New()
            ' define the element type.
            MyBase.ElementType = "paper-slider"

            ' define the events that we want to handle on the server side using WidgetEvent.
            MyBase.Events = {"change"}

            ' initialize the properties that we want to update on the server when any event is fired.
            MyBase.Properties.value = 0
            MyBase.Properties.pin = True
        End Sub


        ''' <summary>
        ''' Define a specialized event for when the value changes
        ''' </summary>
        Public Event ValueChanged As EventHandler


        ''' <summary>
        ''' Fires the ValueChanged event.
        ''' </summary>
        ''' <paramname="e"></param>
        Protected Overridable Sub OnValueChanged(ByVal e As EventArgs)
            RaiseEvent ValueChanged(Me, e)
        End Sub


        ''' <summary>
        ''' Returns or sets the value of the slider.
        ''' </summary>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Value As Integer
            Get
                Return If(Properties.value, 0)
            End Get
            Set(ByVal value As Integer)
                Properties.value = value
                OnValueChanged(EventArgs.Empty)
                Update()
            End Set
        End Property


        ''' <summary>
        ''' Returns or sets whether the slider shows a pin with the value when sliding.
        ''' </summary>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property ShowPin As Boolean
            Get
                Return If(Properties.pin, False)
            End Get
            Set(ByVal value As Boolean)
                Properties.pin = value
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


    ''' <summary>
    ''' Handle widget events to fire the specialized events.
    ''' </summary>
    ''' <paramname="e"></param>
    Protected Overrides Sub OnPolymerEvent(ByVal e As WidgetEventArgs)
            ' let the polymer widget implementation process the
            ' event first to update the incoming properties.
            MyBase.OnPolymerEvent(e)

            Select Case e.Type
                Case "change"
                    OnValueChanged(EventArgs.Empty)
            End Select
        End Sub
    End Class
