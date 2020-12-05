Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window1
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
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Window1))
        columnProperty = New Wisej.Web.DataGridViewColumn()
        columnValue = New Wisej.Web.DataGridViewColumn()
        label1 = New Wisej.Web.Label()
        label2 = New Wisej.Web.Label()
        textBox1 = New Wisej.Web.TextBox()
        checkBox1 = New Wisej.Web.CheckBox()
        javaScript = New Wisej.Web.JavaScript(components)
        SuspendLayout()
        ' 
        ' columnProperty
        ' 
        columnProperty.HeaderText = "Property"
        columnProperty.Name = "columnProperty"
        columnProperty.Width = 200
        ' 
        ' columnValue
        ' 
        columnValue.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill
        columnValue.HeaderText = "Value"
        columnValue.Name = "columnValue"
        ' 
        ' label1
        ' 
        label1.AllowHtml = True
        label1.AutoSize = False
        label1.Location = New Drawing.Point(21, 31)
        label1.Margin = New Wisej.Web.Padding(-1, -1, -1, -1)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(264, 276)
        label1.TabIndex = 4
        label1.Text = resources.GetString("label1.Text")
        ' 
        ' label2
        ' 
        label2.AutoSize = False
        label2.BorderStyle = Wisej.Web.BorderStyle.Dotted
        label2.Font = New Drawing.Font("Comic Sans MS", 40.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        label2.Location = New Drawing.Point(330, 193)
        label2.Margin = New Wisej.Web.Padding(3, 4, 3, 4)
        label2.Name = "label2"
        label2.Size = New Drawing.Size(241, 98)
        label2.TabIndex = 1
        label2.Text = "A"
        label2.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' textBox1
        ' 
        textBox1.AutoSize = False
        javaScript.SetJavaScript(textBox1, resources.GetString("textBox1.JavaScript"))
        textBox1.Location = New Drawing.Point(330, 36)
        textBox1.Margin = New Wisej.Web.Padding(3, 4, 3, 4)
        textBox1.Name = "textBox1"
        textBox1.Size = New Drawing.Size(241, 48)
        textBox1.TabIndex = 2
        textBox1.Watermark = "Type here"
        AddHandler textBox1.KeyPress, New Wisej.Web.KeyPressEventHandler(AddressOf textBox1_KeyPress)
        ' 
        ' checkBox1
        ' 
        checkBox1.Location = New Drawing.Point(330, 116)
        checkBox1.Margin = New Wisej.Web.Padding(3, 4, 3, 4)
        checkBox1.Name = "checkBox1"
        checkBox1.Size = New Drawing.Size(195, 31)
        checkBox1.TabIndex = 3
        checkBox1.Text = "Handle ""A"" on the client"
        ' 
        ' Window1
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 20.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(614, 328)
        Controls.Add(checkBox1)
        Controls.Add(textBox1)
        Controls.Add(label2)
        Controls.Add(label1)
        Font = New Drawing.Font("default", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed
        Margin = New Wisej.Web.Padding(7, 0, 7, 0)
        MinimizeBox = False
        Name = "Window1"
        StartPosition = Wisej.Web.FormStartPosition.CenterScreen
        Text = "Window1"
        ResumeLayout(False)
        PerformLayout()
    End Sub


#End Region

    Friend WithEvents columnProperty As Wisej.Web.DataGridViewColumn
    Friend WithEvents columnValue As Wisej.Web.DataGridViewColumn
    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents label2 As Wisej.Web.Label
    Friend WithEvents textBox1 As Wisej.Web.TextBox
    Friend WithEvents checkBox1 As Wisej.Web.CheckBox
    Friend WithEvents javaScript As Wisej.Web.JavaScript
End Class
