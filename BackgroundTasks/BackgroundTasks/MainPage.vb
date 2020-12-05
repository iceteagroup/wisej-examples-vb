Imports System
Imports Wisej.Web

Public Partial Class MainPage

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)

            'sortBox1.Delay = CSharpImpl.__Assign(sortBox2.Delay, CSharpImpl.__Assign(sortBox3.Delay, numericUpDown1.Value))

            sortBox3.Delay = CInt(numericUpDown1.Value)
            sortBox2.Delay = sortBox3.Delay
            sortBox1.Delay = sortBox2.Delay

        End Sub

        Private Sub sortBox_SortCompleted(ByVal sender As Object, ByVal e As EventArgs)
            notification.Show("Sort Completed!", "SortBox: " & CType(sender, Control).Name & " has just finished sorting.", "http://iconshow.me/download.php?file=path/media/images/Application/Common-Icon/png/64/Information.png")
        End Sub

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class

