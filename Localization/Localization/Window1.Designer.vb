
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Window1))
        Me.comboBox1 = New Wisej.Web.ComboBox()
        Me.label1 = New Wisej.Web.Label()
        Me.label2 = New Wisej.Web.Label()
        Me.labelCurrency = New Wisej.Web.Label()
        Me.labelDateTime = New Wisej.Web.Label()
        Me.label5 = New Wisej.Web.Label()
        Me.labelNumber = New Wisej.Web.Label()
        Me.label4 = New Wisej.Web.Label()
        Me.button1 = New Wisej.Web.Button()
        Me.SuspendLayout()
        '
        'comboBox1
        '
        Me.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1"), resources.GetString("comboBox1.Items2"), resources.GetString("comboBox1.Items3"), resources.GetString("comboBox1.Items4"), resources.GetString("comboBox1.Items5")})
        resources.ApplyResources(Me.comboBox1, "comboBox1")
        Me.comboBox1.Name = "comboBox1"
        '
        'label1
        '
        resources.ApplyResources(Me.label1, "label1")
        Me.label1.Name = "label1"
        '
        'label2
        '
        resources.ApplyResources(Me.label2, "label2")
        Me.label2.Name = "label2"
        '
        'labelCurrency
        '
        resources.ApplyResources(Me.labelCurrency, "labelCurrency")
        Me.labelCurrency.Name = "labelCurrency"
        '
        'labelDateTime
        '
        resources.ApplyResources(Me.labelDateTime, "labelDateTime")
        Me.labelDateTime.Name = "labelDateTime"
        '
        'label5
        '
        resources.ApplyResources(Me.label5, "label5")
        Me.label5.Name = "label5"
        '
        'labelNumber
        '
        resources.ApplyResources(Me.labelNumber, "labelNumber")
        Me.labelNumber.Name = "labelNumber"
        '
        'label4
        '
        resources.ApplyResources(Me.label4, "label4")
        Me.label4.Name = "label4"
        '
        'button1
        '
        resources.ApplyResources(Me.button1, "button1")
        Me.button1.Name = "button1"
        '
        'Window1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.labelNumber)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.labelDateTime)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.labelCurrency)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.comboBox1)
        Me.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Window1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


#End Region

    Friend WithEvents comboBox1 As Wisej.Web.ComboBox
    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents label2 As Wisej.Web.Label
    Friend WithEvents labelCurrency As Wisej.Web.Label
    Friend WithEvents labelDateTime As Wisej.Web.Label
    Friend WithEvents label5 As Wisej.Web.Label
    Friend WithEvents labelNumber As Wisej.Web.Label
    Friend WithEvents label4 As Wisej.Web.Label
    Friend WithEvents button1 As Wisej.Web.Button
End Class
