Imports Wisej.Web

Namespace Views

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ViewBase
        Inherits UserControl
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


#Region "Wisej Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            buttonClose = New Web.Button()
            labelTitle = New Web.Label()
            SuspendLayout()
            ' 
            ' buttonClose
            ' 
            buttonClose.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Right
            buttonClose.ImageSource = "icon-close"
            buttonClose.Location = New Drawing.Point(688, 0)
            buttonClose.Name = "buttonClose"
            buttonClose.Size = New Drawing.Size(50, 33)
            buttonClose.TabIndex = 0
            AddHandler buttonClose.Click, New EventHandler(AddressOf buttonClose_Click)
            ' 
            ' labelTitle
            ' 
            labelTitle.BackColor = Drawing.Color.FromName("@buttonFace")
            labelTitle.Dock = Web.DockStyle.Top
            labelTitle.ForeColor = Drawing.Color.FromName("@buttonText")
            labelTitle.Location = New Drawing.Point(0, 0)
            labelTitle.Name = "labelTitle"
            labelTitle.Size = New Drawing.Size(740, 33)
            labelTitle.TabIndex = 1
            labelTitle.Text = "label1"
            labelTitle.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' ViewBase
            ' 
            BackColor = Drawing.Color.White
            Controls.Add(buttonClose)
            Controls.Add(labelTitle)
            Name = "ViewBase"
            Size = New Drawing.Size(740, 642)
            ResumeLayout(False)
        End Sub


#End Region

        Friend WithEvents buttonClose As Web.Button
        Friend WithEvents labelTitle As Web.Label
    End Class
End Namespace
