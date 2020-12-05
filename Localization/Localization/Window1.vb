Imports System
Imports System.Resources
Imports Wisej.Web

Partial Public Class Window1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Window1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        SetValues()

        ' get notified when the browser is refreshed.
        AddHandler Application.ApplicationRefresh, AddressOf Application_ApplicationRefresh
    End Sub

    Private Sub Application_ApplicationRefresh(ByVal sender As Object, ByVal e As EventArgs)
        SetValues()
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
        ' refresh the browser using the new language.
        Dim languages As String() = {"auto", "en", "de", "it", "fr", "es"}
        Application.Navigate(Application.StartupUri.ToString() & "?lang=" & languages(comboBox1.SelectedIndex))
    End Sub

    Private Sub SetValues()
        labelNumber.Text = 12345678.ToString("c")
        labelCurrency.Text = 12345678.ToString("c")
        labelDateTime.Text = Date.Now.ToString("F")
        Dim RS = New ResourceManager("Localization.Resources", [GetType]().Assembly)
        Text = RS.GetString("Title")
        button1.Text = RS.GetString("ShowMessageBox")
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        MessageBox.Show("The buttons are localized", buttons:=MessageBoxButtons.YesNoCancel, modal:=False)
    End Sub
End Class
