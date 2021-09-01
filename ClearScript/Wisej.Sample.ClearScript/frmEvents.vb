Imports System
Imports Wisej.Web
Imports Wisej.Ext.ClearScript
Imports Microsoft.ClearScript

Partial Public Class frmEvents

    Private engine As ScriptEngine

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEvents_Load(ByVal sender As Object, ByVal e As EventArgs)

        engine = Wisej.Ext.ClearScript.ClearScript.Create(EngineType.V8)

        engine.AddHostObject("form", Me)
        engine.AddHostObject("form2", New frmTestForm())
        engine.AddHostType("alert", GetType(AlertBox))
        engine.AddHostType("msgBox", GetType(MessageBox))
        engine.Execute("
                form.btnForm.Click.connect((s,e) => {
                 form.btnForm.Text = 'Clicked';
                 form2.label1.Text = 'Opened from an event connected to ClearScript';
                 form2.Show();
            });
            ")
        engine.Execute("
                form.txtKeyPress.KeyPress.connect((s,e) => {
                 form.lblKeyPressResult.Text = 'Key pressed: '+e.KeyChar;
            });
            ")
        engine.Execute("
                form.btnAlert.Click.connect((s,e) => {
                 alert.Show('Hello from ClearScript');
            });
            ")
        engine.Execute("
                form.btnMsgBox.Click.connect((s,e) => {
                 msgBox.Show('Hello, I came from ClearScript :D');
            });
            ")
    End Sub
End Class
