Imports System
Imports System.Globalization
Imports Wisej.Web

Partial Public Class Page1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Page1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        dateTimePicker.Value = Date.Today
        dataGridView.Rows.Add(Date.Now.ToString("dd/MM/yyyy HH:mm"), "Daily standup")
        dataGridView.Rows(0).Selected = False
        SetLanguageMenu()
    End Sub

    Public Sub SetLanguageMenu()
        Dim lang = GetLanguage()

        If Equals(lang, "fr") Then
            selectEnglish.Checked = False
            selectFrench.Checked = True
        Else
            selectEnglish.Checked = True
            selectFrench.Checked = False
        End If
    End Sub

    Private Function GetLanguage() As String
        Dim culture = Application.CurrentCulture
        Return culture.IetfLanguageTag.Substring(0, 2)
    End Function

    Private Sub selectlanguage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles selectFrench.Click, selectEnglish.Click
        Dim lang = GetLanguage()

        If Equals(lang, "fr") Then
            Application.CurrentCulture = CultureInfo.GetCultureInfo("en")
            selectEnglish.Checked = True
            selectFrench.Checked = False
        Else
            Application.CurrentCulture = CultureInfo.GetCultureInfo("fr")
            selectEnglish.Checked = False
            selectFrench.Checked = True
        End If

        Application.Reload()
        Call New RuntimeLocalizer().ApplyResources(Me)
    End Sub

    Private Sub showOnWindow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles showOnWindow.Click
        Using window = New Window1()
            window.ShowDialog()
        End Using
    End Sub
End Class
