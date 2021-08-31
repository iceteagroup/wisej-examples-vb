Imports System
Imports System.Web
Imports Wisej.Web
Imports Wisej.Web.Ext



<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class Page1
        Inherits Wisej.Web.Page
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

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
            Me.label1 = New Wisej.Web.Label()
            Me.button1 = New Wisej.Web.Button()
            Me.btnJQueryKnob = New Wisej.Web.Button()
            Me.btnJustGage = New Wisej.Web.Button()
            Me.btnCoolClock = New Wisej.Web.Button()
            Me.btnCountUp = New Wisej.Web.Button()
            Me.lblWisejExtLinkBubbles = New Wisej.Web.Label()
            Me.lblWisejExtLinkJQueryKnob = New Wisej.Web.Label()
            Me.lblWisejExtLinkJustGage = New Wisej.Web.Label()
            Me.lblWisejExtCoolClock = New Wisej.Web.Label()
            Me.lblWisejExtCountUp = New Wisej.Web.Label()
            Me.SuspendLayout()
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("default", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.label1.Location = New System.Drawing.Point(24, 25)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(107, 23)
            Me.label1.TabIndex = 0
            Me.label1.Text = "JSWidgets"
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(24, 68)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(167, 48)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Bubbles"
            '
            'btnJQueryKnob
            '
            Me.btnJQueryKnob.Location = New System.Drawing.Point(25, 132)
            Me.btnJQueryKnob.Name = "btnJQueryKnob"
            Me.btnJQueryKnob.Size = New System.Drawing.Size(167, 48)
            Me.btnJQueryKnob.TabIndex = 2
            Me.btnJQueryKnob.Text = "JQueryKnob"
            '
            'btnJustGage
            '
            Me.btnJustGage.Location = New System.Drawing.Point(24, 194)
            Me.btnJustGage.Name = "btnJustGage"
            Me.btnJustGage.Size = New System.Drawing.Size(167, 48)
            Me.btnJustGage.TabIndex = 3
            Me.btnJustGage.Text = "JustGage"
            '
            'btnCoolClock
            '
            Me.btnCoolClock.Location = New System.Drawing.Point(25, 258)
            Me.btnCoolClock.Name = "btnCoolClock"
            Me.btnCoolClock.Size = New System.Drawing.Size(167, 48)
            Me.btnCoolClock.TabIndex = 4
            Me.btnCoolClock.Text = "CoolClock"
            '
            'btnCountUp
            '
            Me.btnCountUp.Location = New System.Drawing.Point(25, 322)
            Me.btnCountUp.Name = "btnCountUp"
            Me.btnCountUp.Size = New System.Drawing.Size(167, 48)
            Me.btnCountUp.TabIndex = 5
            Me.btnCountUp.Text = "CountUp"
            '
            'lblWisejExtLinkBubbles
            '
            Me.lblWisejExtLinkBubbles.AllowHtml = True
            Me.lblWisejExtLinkBubbles.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.lblWisejExtLinkBubbles.Location = New System.Drawing.Point(211, 81)
            Me.lblWisejExtLinkBubbles.Name = "lblWisejExtLinkBubbles"
            Me.lblWisejExtLinkBubbles.Size = New System.Drawing.Size(340, 19)
            Me.lblWisejExtLinkBubbles.TabIndex = 11
            Me.lblWisejExtLinkBubbles.Text = "<a href=""https://github.com/iceteagroup/wisej-extensions/tree/2.2/Wisej.Web.Ext.B" &
    "ubbles"" target=""_blank"">Details about Bubbles extension</a>"
            '
            'lblWisejExtLinkJQueryKnob
            '
            Me.lblWisejExtLinkJQueryKnob.AllowHtml = True
            Me.lblWisejExtLinkJQueryKnob.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.lblWisejExtLinkJQueryKnob.Location = New System.Drawing.Point(211, 147)
            Me.lblWisejExtLinkJQueryKnob.Name = "lblWisejExtLinkJQueryKnob"
            Me.lblWisejExtLinkJQueryKnob.Size = New System.Drawing.Size(340, 19)
            Me.lblWisejExtLinkJQueryKnob.TabIndex = 12
            Me.lblWisejExtLinkJQueryKnob.Text = "<a href=""https://github.com/iceteagroup/wisej-extensions/tree/2.2/Wisej.Web.Ext.j" &
    "QueryKnob"" target=""_blank"">Details about JQueryKnob extension</a>"
            '
            'lblWisejExtLinkJustGage
            '
            Me.lblWisejExtLinkJustGage.AllowHtml = True
            Me.lblWisejExtLinkJustGage.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.lblWisejExtLinkJustGage.Location = New System.Drawing.Point(211, 209)
            Me.lblWisejExtLinkJustGage.Name = "lblWisejExtLinkJustGage"
            Me.lblWisejExtLinkJustGage.Size = New System.Drawing.Size(340, 19)
            Me.lblWisejExtLinkJustGage.TabIndex = 13
            Me.lblWisejExtLinkJustGage.Text = "<a href=""https://github.com/iceteagroup/wisej-extensions/tree/2.2/Wisej.Web.Ext.J" &
    "ustGage"" target=""_blank"">Details about JustGage extension</a>"
            '
            'lblWisejExtCoolClock
            '
            Me.lblWisejExtCoolClock.AllowHtml = True
            Me.lblWisejExtCoolClock.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.lblWisejExtCoolClock.Location = New System.Drawing.Point(211, 273)
            Me.lblWisejExtCoolClock.Name = "lblWisejExtCoolClock"
            Me.lblWisejExtCoolClock.Size = New System.Drawing.Size(340, 19)
            Me.lblWisejExtCoolClock.TabIndex = 14
            Me.lblWisejExtCoolClock.Text = "<a href=""https://github.com/iceteagroup/wisej-extensions/tree/2.2/Wisej.Web.Ext.C" &
    "oolClock"" target=""_blank"">Details about CoolClock extension</a>"
            '
            'lblWisejExtCountUp
            '
            Me.lblWisejExtCountUp.AllowHtml = True
            Me.lblWisejExtCountUp.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.lblWisejExtCountUp.Location = New System.Drawing.Point(211, 337)
            Me.lblWisejExtCountUp.Name = "lblWisejExtCountUp"
            Me.lblWisejExtCountUp.Size = New System.Drawing.Size(340, 19)
            Me.lblWisejExtCountUp.TabIndex = 15
            Me.lblWisejExtCountUp.Text = "<a href=""https://github.com/iceteagroup/wisej-extensions/tree/2.2/Wisej.Wisej.Web" &
    ".Ext.CountUp"" target=""_blank"">Details about CountUp extension</a>"
            '
            'Page1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
            Me.Controls.Add(Me.lblWisejExtCountUp)
            Me.Controls.Add(Me.lblWisejExtCoolClock)
            Me.Controls.Add(Me.lblWisejExtLinkJustGage)
            Me.Controls.Add(Me.lblWisejExtLinkJQueryKnob)
            Me.Controls.Add(Me.lblWisejExtLinkBubbles)
            Me.Controls.Add(Me.btnCountUp)
            Me.Controls.Add(Me.btnCoolClock)
            Me.Controls.Add(Me.btnJustGage)
            Me.Controls.Add(Me.btnJQueryKnob)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label1)
            Me.Name = "Page1"
            Me.Size = New System.Drawing.Size(1105, 609)
            Me.Text = "Page1"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Friend WithEvents label1 As Wisej.Web.Label
        Friend WithEvents button1 As Wisej.Web.Button
        Friend WithEvents btnJQueryKnob As Wisej.Web.Button
        Friend WithEvents btnJustGage As Wisej.Web.Button
        Friend WithEvents btnCoolClock As Wisej.Web.Button
        Friend WithEvents btnCountUp As Wisej.Web.Button
        Friend WithEvents lblWisejExtLinkBubbles As Wisej.Web.Label
        Friend WithEvents lblWisejExtLinkJQueryKnob As Wisej.Web.Label
        Friend WithEvents lblWisejExtLinkJustGage As Wisej.Web.Label
        Friend WithEvents lblWisejExtCoolClock As Wisej.Web.Label
        Friend WithEvents lblWisejExtCountUp As Wisej.Web.Label
    End Class
