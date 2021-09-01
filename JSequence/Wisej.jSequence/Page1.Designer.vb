Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Page1
    Inherits Wisej.Web.Page
    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

#Region "Wisej Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.txtSequence = New Wisej.Web.TextBox()
        Me.btnTransform = New Wisej.Web.Button()
        Me.cmbBorderStyle = New Wisej.Web.ComboBox()
        Me.cmbTheme = New Wisej.Web.ComboBox()
        Me.btnDownload = New Wisej.Web.Button()
        Me.sequence = New Wisej.Web.Ext.jSequence.Sequence()
        Me.btnPreview = New Wisej.Web.Button()
        Me.lblWisejExtLink = New Wisej.Web.Label()
        Me.lbljSequenceLink = New Wisej.Web.Label()
        Me.SuspendLayout()
        '
        'txtSequence
        '
        Me.txtSequence.AcceptsReturn = True
        Me.txtSequence.LabelText = "Sequence text"
        Me.txtSequence.Location = New System.Drawing.Point(33, 15)
        Me.txtSequence.Multiline = True
        Me.txtSequence.Name = "txtSequence"
        Me.txtSequence.Size = New System.Drawing.Size(470, 404)
        Me.txtSequence.TabIndex = 1
        Me.txtSequence.Text = "Andrew->China: Says Hello " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Note right of China: China thinks\nabout it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "China-->" &
    "Andrew: How are you?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Andrew->>China: I am good thanks!"
        Me.txtSequence.Watermark = "Write something here"
        '
        'btnTransform
        '
        Me.btnTransform.Location = New System.Drawing.Point(33, 425)
        Me.btnTransform.Name = "btnTransform"
        Me.btnTransform.Size = New System.Drawing.Size(187, 82)
        Me.btnTransform.TabIndex = 2
        Me.btnTransform.Text = "Transform"
        '
        'cmbBorderStyle
        '
        Me.cmbBorderStyle.Items.AddRange(New Object() {"None", "Solid", "Dotted", "Dashed", "Double"})
        Me.cmbBorderStyle.LabelText = "Border Style"
        Me.cmbBorderStyle.Location = New System.Drawing.Point(852, 43)
        Me.cmbBorderStyle.Name = "cmbBorderStyle"
        Me.cmbBorderStyle.Size = New System.Drawing.Size(198, 42)
        Me.cmbBorderStyle.TabIndex = 3
        Me.cmbBorderStyle.Watermark = "Select border style"
        '
        'cmbTheme
        '
        Me.cmbTheme.Items.AddRange(New Object() {"Simple", "Hand"})
        Me.cmbTheme.LabelText = "Theme"
        Me.cmbTheme.Location = New System.Drawing.Point(616, 43)
        Me.cmbTheme.Name = "cmbTheme"
        Me.cmbTheme.Size = New System.Drawing.Size(198, 42)
        Me.cmbTheme.TabIndex = 4
        Me.cmbTheme.Watermark = "Select theme"
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(253, 425)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(250, 82)
        Me.btnDownload.TabIndex = 5
        Me.btnDownload.Text = "Download"
        '
        'sequence
        '
        Me.sequence.Anchor = CType((Wisej.Web.AnchorStyles.Left Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.sequence.Location = New System.Drawing.Point(616, 121)
        Me.sequence.Name = "sequence"
        Me.sequence.Size = New System.Drawing.Size(490, 590)
        Me.sequence.TabIndex = 0
        Me.sequence.Text = "sequence1"
        Me.sequence.UML = "Andrew->China: Says Hello " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Note right of China: China thinks\nabout it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "China-->" &
    "Andrew: How are you?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Andrew->>China: I am good thanks!"
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(33, 526)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(470, 71)
        Me.btnPreview.TabIndex = 6
        Me.btnPreview.Text = "Preview in Picture Box"
        '
        'lblWisejExtLink
        '
        Me.lblWisejExtLink.AllowHtml = True
        Me.lblWisejExtLink.AutoSize = True
        Me.lblWisejExtLink.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblWisejExtLink.Location = New System.Drawing.Point(31, 692)
        Me.lblWisejExtLink.Name = "lblWisejExtLink"
        Me.lblWisejExtLink.Size = New System.Drawing.Size(1004, 19)
        Me.lblWisejExtLink.TabIndex = 8
        Me.lblWisejExtLink.Text = "<a href=""https://github.com/iceteagroup/wisej-extensions/tree/2.2/Wisej.Web.Ext.j" &
    "Sequence"" target=""_blank"">Wisej jSequence Extention</a>"
        '
        'lbljSequenceLink
        '
        Me.lbljSequenceLink.AllowHtml = True
        Me.lbljSequenceLink.AutoSize = True
        Me.lbljSequenceLink.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbljSequenceLink.Location = New System.Drawing.Point(33, 737)
        Me.lbljSequenceLink.Name = "lbljSequenceLink"
        Me.lbljSequenceLink.Size = New System.Drawing.Size(1029, 19)
        Me.lbljSequenceLink.TabIndex = 8
        Me.lbljSequenceLink.Text = "<a href="" https://bramp.github.io/js-sequence-diagrams/"" target=""_blank"">For more" &
    " help, visit  https://bramp.github.io/js-sequence-diagrams/</a>"
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.lbljSequenceLink)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.cmbTheme)
        Me.Controls.Add(Me.cmbBorderStyle)
        Me.Controls.Add(Me.btnTransform)
        Me.Controls.Add(Me.txtSequence)
        Me.Controls.Add(Me.sequence)
        Me.Controls.Add(Me.lblWisejExtLink)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(816, 803)
        Me.Text = "Wisej JSequence Sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private sequence As Wisej.Web.Ext.jSequence.Sequence
    Private txtSequence As Wisej.Web.TextBox
    Public WithEvents btnTransform As Wisej.Web.Button
    Public WithEvents cmbBorderStyle As Wisej.Web.ComboBox
    Public WithEvents cmbTheme As Wisej.Web.ComboBox
    Public WithEvents btnDownload As Wisej.Web.Button
    Public WithEvents btnPreview As Wisej.Web.Button
    Private lblWisejExtLink As Wisej.Web.Label
    Private lbljSequenceLink As Wisej.Web.Label
End Class

