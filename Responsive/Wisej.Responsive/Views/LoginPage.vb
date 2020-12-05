Imports System
Imports System.Drawing
Imports Wisej.Web

Namespace Views

    Partial Public Class LoginPage

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub LoginPage_Accelerator(ByVal sender As Object, ByVal e As AcceleratorEventArgs)
            If e.KeyCode = Keys.Enter Then
                buttonLogin.PerformClick()
            End If
        End Sub

        Private Sub buttonLogin_Click(ByVal sender As Object, ByVal e As EventArgs)
            Login()
        End Sub

        Private Sub Login()
            Dim valid As Boolean = True
            errorProvider.SetError(textBoxUserName, Nothing)
            errorProvider.SetError(textBoxPassword, Nothing)

            If String.IsNullOrEmpty(textBoxUserName.Text) Then
                valid = False
                errorProvider.SetError(textBoxUserName, "Enter your user name.")
            End If

            If String.IsNullOrEmpty(textBoxPassword.Text) Then
                valid = False
                errorProvider.SetError(textBoxPassword, "Enter a valid password.")
            ElseIf Not Equals(textBoxPassword.Text, "demo") Then
                valid = False
                errorProvider.SetError(textBoxPassword, "Invalid password.")
            End If

            If valid Then
                Call New HomePage().Show()
                Dispose()
            End If
        End Sub

        Private Sub LoginPage_ResponsiveProfileChanged(ByVal sender As Object, ByVal e As ResponsiveProfileChangedEventArgs)
            If Width <= 450 Then
                ' Phone
                helpTip.Active = False
                panel.Width = 320
                panel.Left = (Width - panel.Width) / 2
            Else
                ' Phone Landscape, Tablet and Desktop
                helpTip.Active = True
                panel.Width = 420
                panel.Left = (Width - panel.Width) / 2
            End If

            If Height <= 450 Then
                ' Phone Landscape
                panel.Height = 320
                label1.ImageAlign = ContentAlignment.MiddleLeft
                panel.Top = (Height - panel.Height) / 2
            Else
                ' Phone Portrait, Tablet and Desktop
                panel.Height = 460
                label1.ImageAlign = ContentAlignment.TopCenter
                panel.Top = (Height - panel.Height) / 2
            End If

            If Width < 800 Then
                helpTip.Alignment = Placement.TopLeft
            Else
                helpTip.Alignment = Placement.RightMiddle
            End If
        End Sub

        Private Sub LoginPage_Load(ByVal sender As Object, ByVal e As EventArgs)
            MessageBox.Show("To test Wisej responsive features, activate Developer Tools in your browser and try device emulation." & Microsoft.VisualBasic.Constants.vbCrLf & " Enter an arbitrary user name to login.", "Wisej Reponsive Features", MessageBoxButtons.OK)
        End Sub
    End Class
End Namespace
