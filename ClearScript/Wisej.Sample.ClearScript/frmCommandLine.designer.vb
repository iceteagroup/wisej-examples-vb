<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCommandLine
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmCommandLine))
        txtCommandLine = New Web.TextBox()
        SuspendLayout()
        ' 
        ' txtCommandLine
        ' 
        txtCommandLine.AcceptsReturn = True
        txtCommandLine.BackColor = Drawing.Color.FromArgb(61, 61, 61)
        txtCommandLine.BorderStyle = Web.BorderStyle.None
        txtCommandLine.Dock = Web.DockStyle.Fill
        txtCommandLine.Font = New Drawing.Font("default, Times New Roman", 14.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Pixel)
        txtCommandLine.ForeColor = Drawing.Color.FromArgb(63, 191, 107)
        txtCommandLine.Location = New Drawing.Point(0, 0)
        txtCommandLine.Multiline = True
        txtCommandLine.Name = "txtCommandLine"
        txtCommandLine.Size = New Drawing.Size(1107, 715)
        txtCommandLine.TabIndex = 0
        txtCommandLine.Text = resources.GetString("txtCommandLine.Text")
        AddHandler txtCommandLine.KeyPress, New Web.KeyPressEventHandler(AddressOf txtCommandLine_KeyPress)
        ' 
        ' frmCommandLine
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 18.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(1107, 715)
        Controls.Add(txtCommandLine)
        Name = "frmCommandLine"
        Text = "Command Line"
        AddHandler Load, New EventHandler(AddressOf frmCommandLine_Load)
        ResumeLayout(False)
        PerformLayout()
    End Sub

#End Region

    Private txtCommandLine As Web.TextBox
End Class
