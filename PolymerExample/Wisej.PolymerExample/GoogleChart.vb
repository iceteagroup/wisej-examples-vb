Imports System
Imports System.ComponentModel
Imports Wisej.Web
Imports Wisej.Web.Ext.Polymer

''' <summary>
''' Implementation of the google-chart polymer widget.
''' </summary>
Public Class GoogleChart
        Inherits PolymerWidget

        Public Sub New()
            ' define the element type.
            MyBase.ElementType = "google-chart"

            ' define the events that we want to handle on the server side using WidgetEvent.
            MyBase.Events = {"google-chart-select"}

            ' initialize the properties that we want to update on the server when any event is fired.
            MyBase.Properties.selection = {New With {
                .row = 0,
                .column = 0
            }}
        End Sub


        ''' <summary>
        ''' Define a specialized event for when the selection changes
        ''' </summary>
        Public Event SelectionChanged As EventHandler


        ''' <summary>
        ''' Fires the SelectionChanged event.
        ''' </summary>
        ''' <paramname="e"></param>
        Protected Overridable Sub OnSelectionChanged(ByVal e As EventArgs)
            RaiseEvent SelectionChanged(Me, e)
        End Sub


        ''' <summary>
        ''' Returns or sets the chart type.
        ''' </summary>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Type As String
            Get
                Return If(Properties.type, String.Empty)
            End Get
            Set(ByVal value As String)
                Properties.type = value
                Update()
            End Set
        End Property


        ''' <summary>
        ''' Returns or sets the selected elements in the chart.
        ''' </summary>
        <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Selection As Object()
        Get
            Return Properties.selection
        End Get
        Set(ByVal value As Object())
            Properties.selection = value
            OnSelectionChanged(EventArgs.Empty)
            Update()
        End Set
    End Property


    ''' <summary>
    ''' Returns or sets the data to display.
    ''' </summary>
    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Data As Object
        Get
            Return Properties.data
        End Get
        Set(ByVal value As Object)
            Properties.data = value
            Update()
        End Set
    End Property


    ''' <summary>
    ''' Returns or sets the data columns.
    ''' </summary>
    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Cols As Object
        Get
            Return Properties.cols
        End Get
        Set(ByVal value As Object)
            Properties.cols = value
            Update()
        End Set
    End Property


    ''' <summary>
    ''' Returns or sets the data rows.
    ''' </summary>
    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Rows As Object
        Get
            Return Properties.rows
        End Get
        Set(ByVal value As Object)
            Properties.rows = value
            Update()
        End Set
    End Property


    ''' <summary>
    ''' Returns or sets the options.
    ''' </summary>
    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Options As Object
        Get
            If Properties.options Is Nothing Then Properties.options = New Object()
            Return Properties.options
        End Get
        Set(ByVal value As Object)
            Properties.options = value
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
        ''' Handle widget events to fire the specialized events.
        ''' </summary>
        ''' <paramname="e"></param>
        Protected Overrides Sub OnPolymerEvent(ByVal e As WidgetEventArgs)
            ' let the polymer widget implementation process the
            ' event first to update the incoming properties.
            MyBase.OnPolymerEvent(e)

            Select Case e.Type
                Case "google-chart-select"
                    OnSelectionChanged(EventArgs.Empty)
            End Select
        End Sub
    End Class
