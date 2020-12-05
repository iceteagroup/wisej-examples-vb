Imports System
Imports System.ComponentModel
Imports System.Drawing

Partial Public Class ColorSlider

    Public Sub New()
        InitializeComponent()
    End Sub


    ''' <summary>
    ''' Fired when the value of the color sliders changes.
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
    ''' Returns or sets a value indicating whether the track bars in the color slider
    ''' control show their value in a bubble when the user moves the slider.
    ''' </summary>
    <DefaultValue(True)>
    <Description("Returns or sets a value indicating whether the track bars in the color slider control show their value in a bubble when the user moves the slider")>
    Public Property ShowValueBubbles As Boolean
        Get
            Return _showValueBubbles
        End Get
        Set(ByVal value As Boolean)

            If (Me._showValueBubbles <> value) Then
                Me.trackBarAll.ShowValue = value
                Me.trackBarB.ShowValue = value
                Me.trackBarG.ShowValue = value
                Me.trackBarR.ShowValue = value
                Me._showValueBubbles = value
            End If

        End Set
    End Property

    Private _showValueBubbles As Boolean = True


    ''' <summary>
    ''' Returns the currently selected color.
    ''' </summary>
    <Browsable(False)>
    Public ReadOnly Property Color As Color
        Get
            Return Color.FromArgb(trackBarR.Value, trackBarG.Value, trackBarB.Value)
        End Get
    End Property

    Private Sub trackBar_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBarR.ValueChanged, trackBarG.ValueChanged, trackBarB.ValueChanged, trackBarAll.ValueChanged
        ' when sliding the All trackbar, adjust all sliders at the same time.
        ' and avoid re-entering the event.
        If sender Is trackBarAll Then
            _inValueChanged = True

            Try
                Me.trackBarB.Value = Me.trackBarAll.Value
                Me.trackBarG.Value = Me.trackBarAll.Value
                Me.trackBarR.Value = Me.trackBarAll.Value
                OnValueChanged(EventArgs.Empty)
            Finally
                Me._inValueChanged = False
            End Try


        ElseIf Not _inValueChanged Then
            OnValueChanged(EventArgs.Empty)
        End If
    End Sub

    Private _inValueChanged As Boolean = False

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class
