Imports System
Imports Wisej.Web
Imports Wisej.Ext.ClearScript
Imports Microsoft.ClearScript

Partial Public Class frmCommandLine

    Private engine As ScriptEngine
    Private code As String = ""

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmCommandLine_Load(ByVal sender As Object, ByVal e As EventArgs)
        txtCommandLine.Text += Microsoft.VisualBasic.Constants.vbLf
        engine = Wisej.Ext.ClearScript.ClearScript.Create(EngineType.V8)
        engine.AddHostObject("log", Me)
    End Sub

    Public Sub Import(ByVal objName As String, ByVal objType As String, ByVal objNameSpace As String)
        Dim type = System.Type.GetType(objNameSpace & "."c & objType)
        Dim obj = Activator.CreateInstance(type)
        engine.AddHostObject(objName, obj)
    End Sub

    Public Sub Output(ByVal obj As Object)
        txtCommandLine.Text += obj.ToString() & Microsoft.VisualBasic.Constants.vbLf
        txtCommandLine.SelectionStart = txtCommandLine.Text.Length
    End Sub

    Private Sub txtCommandLine_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)


        If e.KeyChar = Char.ConvertFromUtf32(Keys.Return) Then
            code += txtCommandLine.Lines(txtCommandLine.Lines.Length - 2)

            If code.Contains("exec") Then
                code = code.Replace("exec", "")
                engine.Execute(code)
                code = ""
            End If

            If code.Contains("clear") Then
                code = ""
                txtCommandLine.Clear()
                txtCommandLine.SelectionStart = txtCommandLine.Text.Length
            End If

            If code.Contains("help") Then
                txtCommandLine.Text += "How to use: " & Microsoft.VisualBasic.Constants.vbLf
                txtCommandLine.Text += "Write your code like you would on a regular text editor, then type in exec on a new line to execute your commands " & Microsoft.VisualBasic.Constants.vbLf
                txtCommandLine.Text += "To clear the CLI, just type in clear: " & Microsoft.VisualBasic.Constants.vbLf
                txtCommandLine.Text += "To switch to another engine, just type in switch followed by the engine type: " & Microsoft.VisualBasic.Constants.vbLf
                txtCommandLine.Text += "example: switch vbscript to code using vbscipt, type switch v8 to go back to javascript " & Microsoft.VisualBasic.Constants.vbLf
                txtCommandLine.Text += "you can dynamically import Objects/Classes in this CLI, just type in import <your_object_name> <object_namespace> <object_type> " & Microsoft.VisualBasic.Constants.vbLf
                txtCommandLine.Text += "Using ClearScript is fun :D " & Microsoft.VisualBasic.Constants.vbLf
                txtCommandLine.SelectionStart = txtCommandLine.Text.Length
                code = ""
            End If

            If code.Contains("switch") Then
                If (code.Contains("vbscript") Or code.Contains("vbs")) Then
                    Try
                        engine = Wisej.Ext.ClearScript.ClearScript.Create(EngineType.VBScript)
                        engine.AddHostObject("log", Me)
                        txtCommandLine.Text += "Switched to VBScript " & Microsoft.VisualBasic.Constants.vbLf
                        code = ""
                        txtCommandLine.SelectionStart = txtCommandLine.Text.Length
                    Catch ex As ExecutionEngineException
                        Me.Output(ex.Message)
                        code = ""
                    End Try
                ElseIf code.Contains("v8") Then
                    engine = Wisej.Ext.ClearScript.ClearScript.Create(EngineType.V8)
                    engine.AddHostObject("log", Me)
                    txtCommandLine.Text += "Switched to V8 " & Microsoft.VisualBasic.Constants.vbLf
                    code = ""
                    txtCommandLine.SelectionStart = txtCommandLine.Text.Length
                Else
                    Me.Output("Missing engine type, please type 'switch vbscript' or 'switch v8' to change engine types")
                    code = ""
                End If
            End If

            If code.Contains("import") Then
                Dim command = code.Substring(code.IndexOf("import"))
                Dim command_array = command.Split(" "c)

                If command.Length < 4 Then
                    Me.Output("Error, please type import <object_name> <object_namespace> <object_type>")
                    code = ""
                Else

                    Try
                        Import(command_array(1), command_array(3), command_array(2))
                        code = ""
                    Catch
                        Me.Output("Please verify that you typed the right command, or verify that the type of object you provided exists")
                    End Try
                End If
            End If

            e.Handled = True
        End If
    End Sub
End Class
