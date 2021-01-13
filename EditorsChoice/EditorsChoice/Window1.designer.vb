Imports System

Namespace EditorsChoice

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class Window1
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
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

#Region "Wisej Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim ExternalPlugin1 As Wisej.Web.Ext.CKEditor.ExternalPlugin = New Wisej.Web.Ext.CKEditor.ExternalPlugin()
            Me.ckEditor1 = New Wisej.Web.Ext.CKEditor.CKEditor()
            Me.timer1 = New Wisej.Web.Timer(Me.components)
            Me.ckEditor2 = New Wisej.Web.Ext.CKEditor.CKEditor()
            Me.Tinyeditor1 = New Wisej.Web.Ext.TinyEditor.TinyEditor()
            Me.label1 = New Wisej.Web.Label()
            Me.label2 = New Wisej.Web.Label()
            Me.label3 = New Wisej.Web.Label()
            Me.label4 = New Wisej.Web.Label()
            Me.tinyMCE1 = New Wisej.Web.Ext.TinyMCE.TinyMCE()
            Me.cbLiveSync = New Wisej.Web.CheckBox()
            Me.tableLayoutPanel1 = New Wisej.Web.TableLayoutPanel()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'ckEditor1
            '
            Me.ckEditor1.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
            ExternalPlugin1.Name = "codesnippet"
            ExternalPlugin1.Url = "ckeditor/plugins/codesnippet"
            Me.ckEditor1.ExternalPlugins = New Wisej.Web.Ext.CKEditor.ExternalPlugin() {ExternalPlugin1}
            Me.ckEditor1.Location = New System.Drawing.Point(16, 40)
            Me.ckEditor1.Name = "ckEditor1"
            Me.ckEditor1.Options = CType(Wisej.Core.WisejSerializer.Parse("{""codeSnippet_theme"":""monokai_sublime"",""extraPlugins"":""codesnippet""}"), Wisej.Core.DynamicObject)
            Me.ckEditor1.Size = New System.Drawing.Size(964, 372)
            Me.ckEditor1.TabIndex = 0
            Me.ckEditor1.Text = "ckEditor1"
            '
            'timer1
            '
            '
            'ckEditor2
            '
            Me.ckEditor2.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
            Me.ckEditor2.Location = New System.Drawing.Point(3, 37)
            Me.ckEditor2.Name = "ckEditor2"
            Me.ckEditor2.Options = CType(Wisej.Core.WisejSerializer.Parse("{""toolbar"":[[""Bold"",""Italic"",""Image"",""Smiley"",""Styles"",""Format"",""Font"",""FontSize""" &
        "]],""allowedContent"":true}"), Wisej.Core.DynamicObject)
            Me.ckEditor2.Size = New System.Drawing.Size(313, 448)
            Me.ckEditor2.TabIndex = 3
            Me.ckEditor2.Text = "ckEditor2"
            '
            'Tinyeditor1
            '
            Me.Tinyeditor1.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
            Me.Tinyeditor1.FontNames = New String() {"Verdana", "Arial", "Georgia", "Trebuchet MS", "Courier New"}
            Me.Tinyeditor1.Location = New System.Drawing.Point(322, 37)
            Me.Tinyeditor1.Name = "Tinyeditor1"
            Me.Tinyeditor1.Size = New System.Drawing.Size(322, 448)
            Me.Tinyeditor1.TabIndex = 4
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("default, Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label1.Location = New System.Drawing.Point(16, 15)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(136, 17)
            Me.label1.TabIndex = 5
            Me.label1.Text = "CKEditor 1 (master)"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("default, Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label2.Location = New System.Drawing.Point(3, 3)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(76, 17)
            Me.label2.TabIndex = 6
            Me.label2.Text = "CKEditor 2"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("default, Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label3.Location = New System.Drawing.Point(650, 3)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(72, 17)
            Me.label3.TabIndex = 7
            Me.label3.Text = "TinyEditor"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("default, Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label4.Location = New System.Drawing.Point(322, 3)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(66, 17)
            Me.label4.TabIndex = 8
            Me.label4.Text = "TinyMCE"
            '
            'tinyMCE1
            '
            Me.tinyMCE1.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
            Me.tinyMCE1.Location = New System.Drawing.Point(650, 37)
            Me.tinyMCE1.Name = "tinyMCE1"
            Me.tinyMCE1.Size = New System.Drawing.Size(314, 448)
            Me.tinyMCE1.TabIndex = 9
            Me.tinyMCE1.Text = "tinyMCE1"
            '
            'cbLiveSync
            '
            Me.cbLiveSync.Location = New System.Drawing.Point(16, 432)
            Me.cbLiveSync.Name = "cbLiveSync"
            Me.cbLiveSync.Size = New System.Drawing.Size(82, 22)
            Me.cbLiveSync.TabIndex = 10
            Me.cbLiveSync.Text = "live sync"
            '
            'tableLayoutPanel1
            '
            Me.tableLayoutPanel1.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
            Me.tableLayoutPanel1.ColumnCount = 3
            Me.tableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33.0!))
            Me.tableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 34.0!))
            Me.tableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33.0!))
            Me.tableLayoutPanel1.Controls.Add(Me.label3, 2, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.label2, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.tinyMCE1, 2, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.label4, 1, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.ckEditor2, 0, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.Tinyeditor1, 1, 1)
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(16, 462)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 2
            Me.tableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 7.162534!))
            Me.tableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 92.83746!))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(967, 488)
            Me.tableLayoutPanel1.TabIndex = 11
            Me.tableLayoutPanel1.TabStop = True
            '
            'Window1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
            Me.AutoScroll = True
            Me.AutoScrollMinSize = New System.Drawing.Size(1029, 966)
            Me.ClientSize = New System.Drawing.Size(948, 848)
            Me.CloseBox = False
            Me.ControlBox = False
            Me.Controls.Add(Me.tableLayoutPanel1)
            Me.Controls.Add(Me.cbLiveSync)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.ckEditor1)
            Me.KeepOnScreen = True
            Me.Movable = False
            Me.Name = "Window1"
            Me.Text = "Editors choice"
            Me.WindowState = Wisej.Web.FormWindowState.Maximized
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Friend WithEvents ckEditor1 As Wisej.Web.Ext.CKEditor.CKEditor
        Friend WithEvents timer1 As Wisej.Web.Timer
        Friend WithEvents ckEditor2 As Wisej.Web.Ext.CKEditor.CKEditor
        Friend WithEvents Tinyeditor1 As Wisej.Web.Ext.TinyEditor.TinyEditor
        Friend WithEvents label1 As Wisej.Web.Label
        Friend WithEvents label2 As Wisej.Web.Label
        Friend WithEvents label3 As Wisej.Web.Label
        Friend WithEvents label4 As Wisej.Web.Label
        Friend WithEvents tinyMCE1 As Wisej.Web.Ext.TinyMCE.TinyMCE
        Friend WithEvents cbLiveSync As Wisej.Web.CheckBox
        Friend WithEvents tableLayoutPanel1 As Wisej.Web.TableLayoutPanel
    End Class
End Namespace
