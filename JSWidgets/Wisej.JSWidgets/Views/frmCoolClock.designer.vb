Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCoolClock
    Inherits Wisej.Web.Form
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer

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
        Me.coolClock1 = New Wisej.Web.Ext.CoolClock.CoolClock()
        Me.cbClockSkin = New Wisej.Web.ComboBox()
        Me.cbClockType = New Wisej.Web.ComboBox()
        Me.SuspendLayout()
        '
        'coolClock1
        '
        Me.coolClock1.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.coolClock1.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.coolClock1.Location = New System.Drawing.Point(228, 63)
        Me.coolClock1.Name = "coolClock1"
        Me.coolClock1.Size = New System.Drawing.Size(257, 241)
        Me.coolClock1.Skin = Wisej.Web.Ext.CoolClock.CoolClockSkin.SwissRail
        Me.coolClock1.Text = "coolClock1"
        '
        'cbClockSkin
        '
        Me.cbClockSkin.LabelText = "Clock Skin"
        Me.cbClockSkin.Location = New System.Drawing.Point(30, 63)
        Me.cbClockSkin.Name = "cbClockSkin"
        Me.cbClockSkin.Size = New System.Drawing.Size(174, 42)
        Me.cbClockSkin.TabIndex = 1
        '
        'cbClockType
        '
        Me.cbClockType.LabelText = "Clock Type"
        Me.cbClockType.Location = New System.Drawing.Point(30, 133)
        Me.cbClockType.Name = "cbClockType"
        Me.cbClockType.Size = New System.Drawing.Size(174, 42)
        Me.cbClockType.TabIndex = 2
        '
        'frmCoolClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 471)
        Me.Controls.Add(Me.cbClockType)
        Me.Controls.Add(Me.cbClockSkin)
        Me.Controls.Add(Me.coolClock1)
        Me.Name = "frmCoolClock"
        Me.Text = "frmCoolClock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents coolClock1 As Wisej.Web.Ext.CoolClock.CoolClock
    Friend WithEvents cbClockSkin As Wisej.Web.ComboBox
    Friend WithEvents cbClockType As Wisej.Web.ComboBox
End Class
