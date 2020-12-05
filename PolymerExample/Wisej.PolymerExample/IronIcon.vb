Imports System.ComponentModel
Imports Wisej.Web.Ext.Polymer

''' <summary>
''' Implementation of the iron-icon polymer widget.
''' </summary>
Public Class IronIcon
    Inherits PolymerWidget

    Public Sub New()
            ' define the element type.
            MyBase.ElementType = "iron-icon"
        End Sub


        ''' <summary>
        ''' Returns or sets the name of the icon to use. The name should be of the form: iconset_name:icon_name.
        ''' </summary>
        <DefaultValue("")>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Icon As String
            Get
                Return If(Properties.icon, "")
            End Get
            Set(ByVal value As String)
                Properties.icon = value
                Update()
            End Set
        End Property


        ''' <summary>
        ''' If using iron-icon without an iconset, you can set the src to be the URL of an 
        ''' individual icon image file. Note that this will take precedence over a given icon attribute.
        ''' </summary>
        <DefaultValue("")>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Src As String
            Get
                Return If(Properties.src, "")
            End Get
            Set(ByVal value As String)
                Properties.src = value
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
    End Class
