Imports System
Imports Wisej.Web

Namespace Views
    Partial Public Class HomePage


        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub optionsPanel1_OptionClick(ByVal sender As Object, ByVal args As Panels.OptionsPanel.OptionClickedEventArgs)
            ' create or activate the view that corresponds to the clicked option button.
            Dim viewName As String = args.ViewName
            Dim view As Control = CType(Application.FindComponent(Function(o) TypeOf o Is Control AndAlso Equals(CType(o, Control).Name, viewName)), Control)

            If view IsNot Nothing Then
                view.BringToFront()
            Else
                Dim type As Type = Type.GetType("Wisej.Responsive.Views." & viewName, True)
                view = CType(Activator.CreateInstance(type), Control)
                view.Parent = WorkspacePanel
                view.Dock = DockStyle.Fill
                AddHandler view.Disposed, Sub(s, e) optionsPanel1.UpdateState()
                optionsPanel1.UpdateState()
            End If
        End Sub
    End Class
End Namespace
