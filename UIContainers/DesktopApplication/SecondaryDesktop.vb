﻿Imports System
Imports Wisej.Web

Partial Public Class SecondaryDesktop

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub SecondaryDesktop_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim switchForm = Application.Session.switchWindow
        switchForm.Show()
        Dim primaryForm = Application.Session.primaryWindow
        primaryForm.Show()
        Dim secondaryForm = Application.Session.secondaryWindow
        secondaryForm.Show()
    End Sub
End Class
