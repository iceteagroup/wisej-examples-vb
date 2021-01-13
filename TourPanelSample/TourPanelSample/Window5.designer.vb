Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window5
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
        accordion1 = New Wisej.Web.Accordion()
        accordionPanelGreen = New Wisej.Web.AccordionPanel()
        checkBox1 = New Wisej.Web.CheckBox()
        accordionPanelRed = New Wisej.Web.AccordionPanel()
        textBoxWatermark = New Wisej.Web.TextBox()
        CType(accordion1, ComponentModel.ISupportInitialize).BeginInit()
        accordion1.SuspendLayout()
        accordionPanelGreen.SuspendLayout()
        SuspendLayout()
        ' 
        ' accordion1
        ' 
        accordion1.Controls.Add(accordionPanelGreen)
        accordion1.Controls.Add(accordionPanelRed)
        accordion1.Location = New Drawing.Point(14, 12)
        accordion1.Name = "accordion1"
        accordion1.SelectedIndex = 0
        accordion1.Size = New Drawing.Size(801, 229)
        accordion1.TabIndex = 0
        ' 
        ' accordionPanelGreen
        ' 
        accordionPanelGreen.BackColor = Drawing.Color.Chartreuse
        accordionPanelGreen.Controls.Add(checkBox1)
        accordionPanelGreen.Location = New Drawing.Point(0, 201)
        accordionPanelGreen.Name = "accordionPanelGreen"
        accordionPanelGreen.RestoreBounds = New Drawing.Rectangle(0, 201, 801, 201)
        accordionPanelGreen.Size = New Drawing.Size(801, 28)
        accordionPanelGreen.Text = "green Panel"
        ' 
        ' checkBox1
        ' 
        checkBox1.Location = New Drawing.Point(17, 20)
        checkBox1.Name = "checkBox1"
        checkBox1.Size = New Drawing.Size(91, 23)
        checkBox1.TabIndex = 0
        checkBox1.Text = "checkBox1"
        ' 
        ' accordionPanelRed
        ' 
        accordionPanelRed.BackColor = Drawing.Color.DarkRed
        accordionPanelRed.Location = New Drawing.Point(0, 0)
        accordionPanelRed.Name = "accordionPanelRed"
        accordionPanelRed.Size = New Drawing.Size(801, 201)
        accordionPanelRed.Text = "red Panel"
        ' 
        ' textBoxWatermark
        ' 
        textBoxWatermark.Location = New Drawing.Point(14, 260)
        textBoxWatermark.Name = "textBoxWatermark"
        textBoxWatermark.Size = New Drawing.Size(342, 22)
        textBoxWatermark.TabIndex = 1
        textBoxWatermark.Watermark = "Type your text here"
        ' 
        ' Window5
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(836, 325)
        CloseBox = False
        Controls.Add(textBoxWatermark)
        Controls.Add(accordion1)
        Location = New Drawing.Point(100, 100)
        Name = "Window5"
        Text = "Form5"
        CType(accordion1, ComponentModel.ISupportInitialize).EndInit()
        accordion1.ResumeLayout(False)
        accordionPanelGreen.ResumeLayout(False)
        accordionPanelGreen.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

#End Region

    Friend WithEvents accordion1 As Wisej.Web.Accordion
    Friend WithEvents accordionPanelRed As Wisej.Web.AccordionPanel
    Friend WithEvents accordionPanelGreen As Wisej.Web.AccordionPanel
    Friend WithEvents checkBox1 As Wisej.Web.CheckBox
    Public textBoxWatermark As Wisej.Web.TextBox
End Class
