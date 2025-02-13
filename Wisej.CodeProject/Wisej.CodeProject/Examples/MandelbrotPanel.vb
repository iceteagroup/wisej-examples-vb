Imports System.Drawing
Imports Wisej.Web

Partial Public Class MandelbrotPanel

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub MandelbrotPanel_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
        m_Xmin = MIN_X
        m_Xmax = MAX_X
        m_Ymin = MIN_Y
        m_Ymax = MAX_Y
        MaxIterations = 64
        DrawMandelbrot(e.Graphics, Size)
    End Sub

#Region "Draw Mandelbrot"

    Private m_Xmin, m_Xmax, m_Ymin, m_Ymax As Double
    Public MaxIterations As Integer
    Public Zr, Zim, Z2r, Z2im As Double
    Private Shared Colors As Color() = New Color() {Color.Black, Color.Red, Color.FromArgb(255, 128, 0), Color.Yellow, Color.FromArgb(0, 192, 0), Color.Cyan, Color.Blue, Color.FromArgb(255, 0, 255)}
    Private Const MIN_X As Double = -2.2
    Private Const MAX_X As Double = 1
    Private Const MIN_Y As Double = -1.2
    Private Const MAX_Y As Double = 1.2

    Private Sub DrawMandelbrot(ByVal graphics As Graphics, ByVal size As Size)
        Dim count = 0
        Dim start = Date.Now

        ' Work until the magnitude squared > 4.
        Const MAX_MAG_SQUARED = 4

        ' Make a Bitmap to draw on.
        Using bm As Bitmap = New Bitmap(size.Width, size.Height)

            ' Clear.
            graphics.Clear(Color.White)

            ' Adjust the coordinate bounds to fit picCanvas.
            AdjustAspect()

            ' dReaC is the change in the real part
            ' (X value) for C. dImaC is the change in the
            ' imaginary part (Y value).
            Dim wid = size.Width
            Dim hgt = size.Height
            Dim dReaC = (m_Xmax - m_Xmin) / (wid - 1)
            Dim dImaC = (m_Ymax - m_Ymin) / (hgt - 1)

            ' Calculate the values.
            Dim num_colors = Colors.Length
            Dim ReaC = m_Xmin

            For X = 0 To wid - 1
                Dim ImaC = m_Ymin

                For Y = 0 To hgt - 1
                    Dim ReaZ = Zr
                    Dim ImaZ = Zim
                    Dim ReaZ2 = Z2r
                    Dim ImaZ2 = Z2im
                    Dim clr = 1

                    While clr < MaxIterations AndAlso ReaZ2 + ImaZ2 < MAX_MAG_SQUARED
                        ' Calculate Z(clr).
                        ReaZ2 = ReaZ * ReaZ
                        ImaZ2 = ImaZ * ImaZ
                        ImaZ = 2 * ImaZ * ReaZ + ImaC
                        ReaZ = ReaZ2 - ImaZ2 + ReaC
                        clr += 1
                        count += 1
                    End While

                    ' Set the pixel's value.
                    bm.SetPixel(X, Y, Colors(clr Mod num_colors))
                    ImaC += dImaC
                    count += 1
                Next

                ReaC += dReaC
            Next

            Dim elapsed = Date.Now - start
            graphics.DrawImageUnscaled(bm, 0, 0)
            graphics.DrawString(String.Format("{0} Pixels", count.ToString("0,000")), SystemFonts.DefaultFont, Brushes.Black, 50, 50)
            graphics.DrawString(String.Format("{0} Milliseconds", CInt(elapsed.TotalMilliseconds)), SystemFonts.DefaultFont, Brushes.Black, 50, 80)
        End Using
    End Sub

    Private Sub AdjustAspect()
        Dim hgt, wid, mid As Double
        Dim want_aspect = (m_Ymax - m_Ymin) / (m_Xmax - m_Xmin)
        Dim picCanvas_aspect = Height / Width

        If want_aspect > picCanvas_aspect Then
            ' The selected area is too tall and thin.
            ' Make it wider.
            wid = (m_Ymax - m_Ymin) / picCanvas_aspect
            mid = (m_Xmin + m_Xmax) / 2
            m_Xmin = mid - wid / 2
            m_Xmax = mid + wid / 2
        Else
            ' The selected area is too short and wide.
            ' Make it taller.
            hgt = (m_Xmax - m_Xmin) * picCanvas_aspect
            mid = (m_Ymin + m_Ymax) / 2
            m_Ymin = mid - hgt / 2
            m_Ymax = mid + hgt / 2
        End If
    End Sub

#End Region

End Class
