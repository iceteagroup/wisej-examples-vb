<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HtmlEditorExample
    Inherits Wisej.Web.Form
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As ComponentModel.IContainer

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

#Region "Wisej Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        ckEditor1 = New Web.Ext.CKEditor.CKEditor()
        button1 = New Web.Button()
        SuspendLayout()
        ' 
        ' ckEditor1
        ' 
        ckEditor1.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Bottom Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right
        ckEditor1.Location = New Drawing.Point(26, 37)
        ckEditor1.Name = "ckEditor1"
        ckEditor1.Options = CType(Core.WisejSerializer.Parse("{}"), Core.DynamicObject)
        ckEditor1.Size = New Drawing.Size(988, 567)
        ckEditor1.TabIndex = 0
        ckEditor1.Text = "ckEditor1"
        ' 
        ' button1
        ' 
        button1.Anchor = Web.AnchorStyles.Bottom
        button1.Location = New Drawing.Point(449, 631)
        button1.Name = "button1"
        button1.Size = New Drawing.Size(155, 58)
        button1.TabIndex = 1
        button1.Text = "Close"
        AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
        ' 
        ' HtmlEditorExample
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(1052, 714)
        Controls.Add(button1)
        Controls.Add(ckEditor1)
        IconSource = "resource.wx/Wisej.Ext.MaterialDesign/android-logo-1.svg?color=#BF3FB5"
        Name = "HtmlEditorExample"
        Text = "HTML Editor (CKEditor)"
        AddHandler Load, New EventHandler(AddressOf HtmlEditorExample_Load)
        ResumeLayout(False)
    End Sub

#End Region

    Friend WithEvents ckEditor1 As Web.Ext.CKEditor.CKEditor
    Friend WithEvents button1 As Web.Button
End Class
