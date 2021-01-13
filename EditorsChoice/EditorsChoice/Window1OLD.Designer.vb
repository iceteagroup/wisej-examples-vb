<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Window1OLD
    Inherits Wisej.Web.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Wisej Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TinyEditor1 = New Wisej.Web.Ext.TinyEditor.TinyEditor()
        Me.TinyMCE1 = New Wisej.Web.Ext.TinyMCE.TinyMCE()
        Me.CkEditor1 = New Wisej.Web.Ext.CKEditor.CKEditor()
        Me.SuspendLayout()
        '
        'TinyEditor1
        '
        Me.TinyEditor1.Location = New System.Drawing.Point(22, 3)
        Me.TinyEditor1.Name = "TinyEditor1"
        Me.TinyEditor1.Size = New System.Drawing.Size(241, 192)
        Me.TinyEditor1.TabIndex = 0
        Me.TinyEditor1.Text = "TinyEditor1"
        '
        'TinyMCE1
        '
        Me.TinyMCE1.Location = New System.Drawing.Point(22, 221)
        Me.TinyMCE1.Name = "TinyMCE1"
        Me.TinyMCE1.Size = New System.Drawing.Size(241, 159)
        Me.TinyMCE1.TabIndex = 1
        Me.TinyMCE1.Text = "TinyMCE1"
        '
        'CkEditor1
        '
        Me.CkEditor1.Location = New System.Drawing.Point(333, 3)
        Me.CkEditor1.Name = "CkEditor1"
        Me.CkEditor1.Options = CType(Wisej.Core.WisejSerializer.Parse("{""codeSnippet_theme"":""monokai_sublime"",""extraPlugins"":""codesnippet""}"), Wisej.Core.DynamicObject)
        Me.CkEditor1.Size = New System.Drawing.Size(445, 377)
        Me.CkEditor1.TabIndex = 2
        Me.CkEditor1.Text = "CkEditor1"
        '
        'Window1OLD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 432)
        Me.Controls.Add(Me.CkEditor1)
        Me.Controls.Add(Me.TinyMCE1)
        Me.Controls.Add(Me.TinyEditor1)
        Me.Name = "Window1OLD"
        Me.Text = "Window1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TinyEditor1 As Ext.TinyEditor.TinyEditor
    Friend WithEvents TinyMCE1 As Ext.TinyMCE.TinyMCE
    Friend WithEvents CkEditor1 As Ext.CKEditor.CKEditor
End Class
