<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GagePopup
    Inherits Wisej.Web.UserPopup
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
        justGage1 = New Web.Ext.JustGage.JustGage()
        SuspendLayout()
        ' 
        ' justGage1
        ' 
        justGage1.BackColor = Drawing.Color.White
        justGage1.Dock = Web.DockStyle.Fill
        justGage1.ForeColor = Drawing.Color.White
        justGage1.LabelColor = Drawing.Color.GhostWhite
        justGage1.Location = New Drawing.Point(0, 0)
        justGage1.Name = "justGage1"
        justGage1.Size = New Drawing.Size(188, 181)
        justGage1.TabIndex = 0
        justGage1.Text = "CPU%"
        justGage1.Symbol = "%"
        justGage1.Value = 10.0F
        justGage1.ValueColor = Drawing.Color.Moccasin
        ' 
        ' GagePopup
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        BackColor = Drawing.Color.FromArgb(116, 63, 154, 191)
        Controls.Add(justGage1)
        Name = "GagePopup"
        Size = New Drawing.Size(188, 181)
        AddHandler VisibleChanged, New EventHandler(AddressOf GagePopup_VisibleChanged)
        ResumeLayout(False)
    End Sub

#End Region

    Friend WithEvents justGage1 As Web.Ext.JustGage.JustGage
End Class
