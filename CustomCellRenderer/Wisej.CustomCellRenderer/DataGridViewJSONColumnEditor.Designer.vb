<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataGridViewJSONColumnEditor
    Inherits Wisej.Web.FlexLayoutPanel
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
        textBox1 = New Web.TextBox()
        textBox2 = New Web.TextBox()
        textBox3 = New Web.TextBox()
        SuspendLayout()
        ' 
        ' textBox1
        ' 
        textBox1.Location = New Drawing.Point(3, 79)
        textBox1.Name = "textBox1"
        textBox1.Size = New Drawing.Size(322, 22)
        textBox1.TabIndex = 0
        ' 
        ' textBox2
        ' 
        textBox2.Location = New Drawing.Point(3, 41)
        textBox2.Name = "textBox2"
        textBox2.Size = New Drawing.Size(322, 22)
        textBox2.TabIndex = 1
        ' 
        ' textBox3
        ' 
        textBox3.Location = New Drawing.Point(3, 3)
        textBox3.Name = "textBox3"
        textBox3.Size = New Drawing.Size(322, 22)
        textBox3.TabIndex = 2
        ' 
        ' DataGridViewJSONColumnEditor
        ' 
        Controls.Add(textBox3)
        Controls.Add(textBox2)
        Controls.Add(textBox1)
        LayoutStyle = Web.FlexLayoutStyle.Vertical
        Name = "DataGridViewJSONColumnEditor"
        Size = New Drawing.Size(328, 221)
        ResumeLayout(False)
        PerformLayout()
    End Sub


#End Region

    Friend WithEvents textBox1 As Web.TextBox
    Friend WithEvents textBox3 As Web.TextBox
    Friend WithEvents textBox2 As Web.TextBox
End Class
