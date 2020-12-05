Imports System
Imports System.Linq
Imports Wisej.Web

Namespace Panels
    Partial Public Class OptionsPanel
        Public Sub New()
            InitializeComponent()
        End Sub

        ' Fired when one of the option buttons is clicked.
        Public Event OptionClick As OptionClickedEventHandler


        ' Adapts the panel to the device.
        Private Sub OptionsPanel_ResponsiveProfileChanged(ByVal sender As Object, ByVal e As ResponsiveProfileChangedEventArgs)
            Dim display = Web.Display.Both

            If Application.Browser.Size.Width < 450 Then
                display = Display.Icon
                label1.Visible = False
                Width = 90
            Else
                label1.Visible = True
                Width = 250
            End If

            For Each c As Control In Controls
                Dim button = TryCast(c, Button)
                If button IsNot Nothing Then button.Display = display
            Next
        End Sub


        ' binds the buttons to the corresponding view names.
        Private Sub OptionsPanel_Load(ByVal sender As Object, ByVal e As EventArgs)
            buttonProducts.UserData.ViewName = "ProductsView"
            buttonDashboard.UserData.ViewName = "DashboardView"
            buttonCustomers.UserData.ViewName = "CustomersView"
        End Sub

        Public Sub UpdateState()
            ' update the state of the button to reflect whether
            ' the corresponding view is created.
            For Each c As Control In Controls
                Dim button = TryCast(c, Button)

                If button IsNot Nothing Then
                    Dim viewName As String = button.UserData.ViewName
                    Dim view As Control = CType(Application.FindComponent(Function(o) TypeOf o Is Control AndAlso Equals(CType(o, Control).Name, viewName)), Control)

                    If view Is Nothing OrElse view.IsDisposed OrElse view.Disposing Then
                        styleSheet.SetCssClass(c, Nothing)
                    Else
                        styleSheet.SetCssClass(c, "active")
                    End If
                End If
            Next
        End Sub

        Private Sub button_Click(ByVal sender As Object, ByVal e As EventArgs)
            RaiseEvent OptionClick(Me, New OptionClickedEventArgs(CType(sender, Button)))
        End Sub


        ''' <summary>
        ''' Handler for the OptionClicked event.
        ''' </summary>
        ''' <paramname="sender"></param>
        ''' <paramname="e"></param>
        Public Delegate Sub OptionClickedEventHandler(ByVal sender As Object, ByVal e As OptionClickedEventArgs)


        ''' <summary>
        ''' Data for the OptionClickedEventHandler event handler.
        ''' </summary>
        Public Class OptionClickedEventArgs
            Inherits EventArgs

            Private _ViewName As String

            Friend Sub New(ByVal button As Button)
                ViewName = button.UserData.ViewName
            End Sub

            Public Property ViewName As String
                Get
                    Return _ViewName
                End Get
                Private Set(ByVal value As String)
                    _ViewName = value
                End Set
            End Property
        End Class
    End Class
End Namespace
