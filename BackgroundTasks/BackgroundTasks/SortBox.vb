Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Threading
Imports Wisej.Web

Partial Public Class SortBox
    Inherits UserControl

    ' gap between lines.
    Private gap As Integer = 2

    ' line width;
    Private lineWidth As Integer = 2

    ' values to sort.
    Private values As Integer() = New Integer(-1) {}

    ' sorted flag.
    Private sorted As Boolean = False

    Public Sub New()
        InitializeComponent()
        Delay = 10
    End Sub

    Public Event SortCompleted As EventHandler

    Private Sub buttonSort_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' reshuffle.
        If sorted Then
            sorted = False
            GenerateLines()
            DrawLines()
        End If

        Select Case SortMode
            Case SortMode.BubbleSort
                Application.StartTask(Sub() RunBubbleSort())
            Case SortMode.QuickSort
                Application.StartTask(Sub() RunQuickSort())
            Case SortMode.SelectionSort
                Application.StartTask(Sub() RunSelectionSort())
        End Select
    End Sub

    Private Sub RunSelectionSort()
        Dim stopwatch As Stopwatch = New Stopwatch()
        buttonSort.Enabled = False
        buttonSort.Text = "Sorting..."
        Dim i = 0
        Dim max = values.Length - 1
        stopwatch.Start()

        While i <= max - 1
            Dim k = max

            While k >= i + 1

                If values(i) > values(k) Then
                    SwapValue(i, k)
                End If

                k = k - 1
            End While

            i = i + 1
        End While

        stopwatch.Stop()
        RaiseEvent SortCompleted(Me, EventArgs.Empty)
        AlertBox.Show("SelectionSort completed in " & stopwatch.ElapsedMilliseconds & " milliseconds.")
        sorted = True
        buttonSort.Enabled = True
        buttonSort.Text = "SORT"
        Application.Update(Me)
    End Sub

    Private Sub RunQuickSort()
        Dim stopwatch As Stopwatch = New Stopwatch()
        buttonSort.Enabled = False
        buttonSort.Text = "Sorting..."
        stopwatch.Start()
        DoQuickSort(0, values.Length - 1)
        stopwatch.Stop()
        RaiseEvent SortCompleted(Me, EventArgs.Empty)
        AlertBox.Show("QuickSort completed in " & stopwatch.ElapsedMilliseconds & " milliseconds.")
        sorted = True
        buttonSort.Enabled = True
        buttonSort.Text = "SORT"
        Application.Update(Me)
    End Sub

    Private Sub DoQuickSort(ByVal low As Integer, ByVal high As Integer)
        Dim lo = low
        Dim hi = high

        'TODO:custom adjust
        Dim mid = values(CInt((lo + hi) / 2))


        While True

            While values(lo) < mid
                lo = lo + 1
            End While

            While values(hi) > mid
                hi = hi - 1
            End While

            If lo <= hi Then
                SwapValue(lo, hi)
                lo = lo + 1
                hi = hi - 1
            End If

            If lo > hi Then
                Exit While
            End If
        End While

        If hi > low Then
            DoQuickSort(low, hi)
        End If

        If lo < high Then
            DoQuickSort(lo, high)
        End If
    End Sub

    Private Sub RunBubbleSort()
        Dim stopwatch As Stopwatch = New Stopwatch()
        buttonSort.Enabled = False
        buttonSort.Text = "Sorting..."
        Dim i = 0
        Dim max = values.Length - 1
        stopwatch.Start()

        While i <= max
            Dim k = 0

            While k <= max - 1

                If values(k) > values(k + 1) Then
                    SwapValue(k, k + 1)
                End If

                k = k + 1
            End While

            i = i + 1
        End While

        stopwatch.Stop()
        RaiseEvent SortCompleted(Me, EventArgs.Empty)
        AlertBox.Show("BubbleSort completed in " & stopwatch.ElapsedMilliseconds & " milliseconds.")
        sorted = True
        buttonSort.Enabled = True
        buttonSort.Text = "SORT"
        Application.Update(Me)
    End Sub

    Private Sub SwapValue(ByVal a As Integer, ByVal b As Integer)
        Dim t = values(a)
        values(a) = values(b)
        values(b) = t
        Dim canvas = Me._canvas
        Dim rect = DisplayRectangle
        canvas.LiveUpdate = True

        Try
            ' clear the previous lines
            canvas.BeginPath()
            canvas.StrokeStyle = BackColor
            canvas.LineWidth = lineWidth
            Dim y = a * (lineWidth + gap) + 1
            canvas.MoveTo(0, y)
            canvas.LineTo(rect.Width, y)
            y = b * (lineWidth + gap) + 1
            canvas.MoveTo(0, y)
            canvas.LineTo(rect.Width, y)
            canvas.Stroke()

            ' draw the swapped lines.
            canvas.BeginPath()
            canvas.StrokeStyle = ForeColor
            y = a * (lineWidth + gap) + 1
            canvas.MoveTo(0, y)
            canvas.LineTo(values(a), y)
            y = b * (lineWidth + gap) + 1
            canvas.MoveTo(0, y)
            canvas.LineTo(values(b), y)
            canvas.Stroke()
        Finally
            canvas.LiveUpdate = False
        End Try

        Application.Update(Me)
        Thread.Sleep(Delay)
    End Sub

    Public Property Title As String
        Get
            Return titleField.Text
        End Get
        Set(ByVal value As String)
            titleField.Text = value
        End Set
    End Property

    Public Property SortMode As SortMode
    Public Property Delay As Integer

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        GenerateLines()
    End Sub

    Private Sub GenerateLines()
        Dim rand As Random = New Random()

        'TODO: custom adjust
        values = New Integer(CInt(_canvas.Height / (lineWidth + gap) - 1)) {}

        Dim i As Integer = 0, length As Integer = values.Length

        While i < length
            values(i) = rand.Next(Width)
            i += 1
        End While
    End Sub

    Private Sub DrawLines()
        Dim canvas = Me._canvas
        Dim rect = DisplayRectangle

        ' clear the canvas.
        canvas.BeginPath()
        canvas.ClearRect(rect)

        ' set the line color.
        canvas.StrokeStyle = ForeColor

        ' calculate the size if the line of the line.
        canvas.LineWidth = lineWidth

        'TODO: custom adjust
        'Dim pos As Point = CSharpImpl.__Assign(pos, New Point(0, 1))
        Dim pos As Point = New Point(0, 1)


        Dim i As Integer = 0, length As Integer = values.Length

        While i < length
            canvas.MoveTo(pos)
            canvas.LineTo(values(i), pos.Y)
            pos.Y += canvas.LineWidth + gap
            i += 1
        End While

        canvas.Stroke()
    End Sub

    Private Sub canvas_Redraw(ByVal sender As Object, ByVal e As EventArgs)
        DrawLines()
    End Sub

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class

Public Enum SortMode
        BubbleSort
        SelectionSort
        QuickSort
    End Enum
