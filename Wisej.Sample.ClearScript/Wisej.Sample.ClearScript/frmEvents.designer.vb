<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEvents
    Inherits Wisej.Web.Form
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
        btnForm = New Web.Button()
        txtKeyPress = New Web.TextBox()
        btnAlert = New Web.Button()
        btnMsgBox = New Web.Button()
        lblKeyPressResult = New Web.Label()
        SuspendLayout()
        ' 
        ' btnForm
        ' 
        btnForm.Location = New Drawing.Point(18, 33)
        btnForm.Name = "btnForm"
        btnForm.Size = New Drawing.Size(180, 52)
        btnForm.TabIndex = 0
        btnForm.Text = "Click me!"
        ' 
        ' txtKeyPress
        ' 
        txtKeyPress.LabelText = "Write something!"
        txtKeyPress.Location = New Drawing.Point(18, 113)
        txtKeyPress.Name = "txtKeyPress"
        txtKeyPress.Size = New Drawing.Size(614, 41)
        txtKeyPress.TabIndex = 1
        ' 
        ' btnAlert
        ' 
        btnAlert.Location = New Drawing.Point(628, 171)
        btnAlert.Name = "btnAlert"
        btnAlert.Size = New Drawing.Size(129, 41)
        btnAlert.TabIndex = 2
        btnAlert.Text = "Alert"
        ' 
        ' btnMsgBox
        ' 
        btnMsgBox.Location = New Drawing.Point(464, 171)
        btnMsgBox.Name = "btnMsgBox"
        btnMsgBox.Size = New Drawing.Size(142, 41)
        btnMsgBox.TabIndex = 3
        btnMsgBox.Text = "MessageBox"
        ' 
        ' lblKeyPressResult
        ' 
        lblKeyPressResult.AutoSize = True
        lblKeyPressResult.Location = New Drawing.Point(18, 161)
        lblKeyPressResult.Name = "lblKeyPressResult"
        lblKeyPressResult.Size = New Drawing.Size(39, 17)
        lblKeyPressResult.TabIndex = 4
        lblKeyPressResult.Text = "label1"
        ' 
        ' frmEvents
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 18.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(760, 233)
        Controls.Add(lblKeyPressResult)
        Controls.Add(btnMsgBox)
        Controls.Add(btnAlert)
        Controls.Add(txtKeyPress)
        Controls.Add(btnForm)
        Name = "frmEvents"
        Text = "Events Sample"
        AddHandler Load, New EventHandler(AddressOf frmEvents_Load)
        ResumeLayout(False)
        PerformLayout()
    End Sub

#End Region

    Public btnForm As Web.Button
    Public txtKeyPress As Web.TextBox
    Public btnAlert As Web.Button
    Public btnMsgBox As Web.Button
    Public lblKeyPressResult As Web.Label
End Class
