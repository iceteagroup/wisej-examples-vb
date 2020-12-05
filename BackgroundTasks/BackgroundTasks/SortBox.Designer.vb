
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SortBox
    Inherits Wisej.Web.UserControl
    ''' <summary> 
    ''' Required designer variable.
    ''' </summary>

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

#Region "Component Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        _canvas = New Wisej.Web.Canvas()
        titleField = New Wisej.Web.Label()
        buttonSort = New Wisej.Web.Button()
        SuspendLayout()
        ' 
        ' canvas
        ' 
        _canvas.Anchor = Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Left Or Wisej.Web.AnchorStyles.Right
        _canvas.BorderStyle = Wisej.Web.BorderStyle.Solid
        _canvas.Location = New Drawing.Point(10, 53)
        _canvas.Name = "canvas"
        _canvas.Size = New Drawing.Size(475, 300)
        _canvas.TabIndex = 0
        AddHandler _canvas.Redraw, New EventHandler(AddressOf canvas_Redraw)
        ' 
        ' title
        ' 
        titleField.AutoSize = False
        titleField.Dock = Wisej.Web.DockStyle.Top
        titleField.ForeColor = Drawing.Color.FromName("@windowText")
        titleField.Location = New Drawing.Point(10, 10)
        titleField.Name = "title"
        titleField.Size = New Drawing.Size(475, 37)
        titleField.TabIndex = 1
        titleField.Text = "Title"
        titleField.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' buttonSort
        ' 
        buttonSort.Dock = Wisej.Web.DockStyle.Bottom
        buttonSort.Location = New Drawing.Point(10, 364)
        buttonSort.Margin = New Wisej.Web.Padding(3, 8, 3, 3)
        buttonSort.Name = "buttonSort"
        buttonSort.Size = New Drawing.Size(475, 46)
        buttonSort.TabIndex = 2
        buttonSort.Text = "SORT"
        AddHandler buttonSort.Click, New EventHandler(AddressOf buttonSort_Click)
        ' 
        ' SortBox
        ' 
        Controls.Add(_canvas)
        Controls.Add(buttonSort)
        Controls.Add(titleField)
        Name = "SortBox"
        Padding = New Wisej.Web.Padding(10)
        Size = New Drawing.Size(495, 420)
        ResumeLayout(False)
    End Sub


#End Region

    'TODO:custom adjust
    Friend WithEvents _canvas As Wisej.Web.Canvas

    Friend WithEvents titleField As Wisej.Web.Label
    Friend WithEvents buttonSort As Wisej.Web.Button
End Class
