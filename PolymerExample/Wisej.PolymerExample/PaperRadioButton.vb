Imports System
Imports System.ComponentModel
Imports Wisej.Web
Imports Wisej.Web.Ext.Polymer

''' <summary>
''' Implementation of the paper-radio-button polymer widget.
''' </summary>
<DefaultEvent("CheckedChanged")>
    Public Class PaperRadioButton
        Inherits PolymerWidget

        Public Sub New()
            ' define the element type.
            MyBase.ElementType = "paper-radio-button"

            ' define the events that we want to handle on the server side using WidgetEvent.
            MyBase.Events = {"change"}

            ' initialize the properties that we want to update on the server when any event is fired.
            MyBase.Properties.checked = False
        End Sub


        ''' <summary>
        ''' Define a specialized event for when the checked state changes
        ''' </summary>
        Public Event CheckedChanged As EventHandler


        ''' <summary>
        ''' Fires the CheckedChanged event.
        ''' </summary>
        ''' <paramname="e"></param>
        Protected Overridable Sub OnCheckedChanged(ByVal e As EventArgs)
            RaiseEvent CheckedChanged(Me, e)
        End Sub


        ''' <summary>
        ''' Returns or sets the checked state.
        ''' </summary>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Checked As Boolean
            Get
                Return If(Properties.checked, False)
            End Get
            Set(ByVal value As Boolean)

                If Checked <> value Then
                    Properties.checked = value
                    OnCheckedChanged(EventArgs.Empty)
                    Update()
                End If
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
                    OnCheckedChanged(EventArgs.Empty)
            End Select
        End Sub
    End Class
