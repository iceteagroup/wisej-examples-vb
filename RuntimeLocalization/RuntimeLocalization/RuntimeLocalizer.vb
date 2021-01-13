' Adapted from http://rtarlowski.blogspot.com/2011/02/c-change-form-language-at-runtime.html

' This class uses reflection and relies on each Control or Component having a "Name" property

Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Globalization
Imports System.Reflection
Imports Wisej.Web

Public Class RuntimeLocalizer
    Private ReadOnly _cultureInfo As CultureInfo

    Public Sub New()
        _cultureInfo = Application.CurrentCulture
    End Sub

    Public Sub ApplyResources(ByVal parent As Form)
        Dim mainForm = parent

        While mainForm.Owner IsNot Nothing
            mainForm = mainForm.Owner
        End While

        ApplyLanguage(mainForm, Nothing)
    End Sub

    Public Sub ApplyResources(ByVal parent As Page)
        ApplyLanguage(parent, Nothing)
    End Sub

    Private Sub ApplyLanguage(ByVal value As Object, ByVal resources As ComponentResourceManager)
        If TypeOf value Is Form OrElse TypeOf value Is Page Then
            resources = New ComponentResourceManager(value.GetType())
            resources.ApplyResources(value, "$this")
        End If

        Dim type As Type = value.GetType()

        For Each info In type.GetProperties()

            Select Case info.Name
                Case "Buttons", "Items", "Panels", "MenuItems", "DropDownItems", "Columns", "Controls", "OwnedForms", "SourceControl"

                    If info.PropertyType.GetInterface("IEnumerable") IsNot Nothing Then
                        Dim collection = CType(info.GetValue(value, Nothing), IEnumerable)

                        If collection IsNot Nothing Then
                            For Each o In collection
                                Dim objNameProp As PropertyInfo = o.GetType().GetProperty("Name")
                                ApplyResourceOnType(resources, o, objNameProp)
                            Next
                        End If
                    End If

                Case "ContextMenuStrip", "DropDownMenu"
                    Dim obj = info.GetValue(value, Nothing)

                    If obj IsNot Nothing Then
                        ApplyLanguage(obj, resources)
                        resources.ApplyResources(obj, info.Name, _cultureInfo)
                    End If

                Case Else
            End Select
        Next
    End Sub

    Private Sub ApplyResourceOnType(ByVal resources As ComponentResourceManager, ByVal o As Object, ByVal objNameProp As PropertyInfo)
        Select Case o.GetType().Name
            Case "ComboBox"

                For i = 0 To CType(o, ComboBox).Items.Count - 1
                    CType(o, ComboBox).Items(i) = resources.GetString(GetItemName(o, objNameProp, i), _cultureInfo)
                Next

            Case "ListBox"

                For i = 0 To CType(o, ListBox).Items.Count - 1
                    CType(o, ListBox).Items(i) = resources.GetString(GetItemName(o, objNameProp, i), _cultureInfo)
                    ' Other classes with string items
                Next

            Case Else

                If objNameProp IsNot Nothing Then
                    Dim name As String = objNameProp.GetValue(o, Nothing).ToString()
                    ApplyLanguage(o, resources)
                    resources.ApplyResources(o, name, _cultureInfo)
                End If
        End Select
    End Sub

    Private Function GetItemName(ByVal o As Object, ByVal objNameProp As PropertyInfo, ByVal i As Integer) As String
        Dim name = String.Format("{0}.{1}", objNameProp.GetValue(o, Nothing), "Items")
        If i <> 0 Then name = String.Format("{0}{1}", name, i)
        Return name
    End Function
End Class
