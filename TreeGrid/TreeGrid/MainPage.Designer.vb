<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
    Inherits Wisej.Web.Page
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
        Me.dataTable = New Wisej.Web.Button()
        Me.objectList = New Wisej.Web.Button()
        Me.SuspendLayout()
        '
        'dataTable
        '
        Me.dataTable.Font = New System.Drawing.Font("default", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dataTable.Location = New System.Drawing.Point(100, 100)
        Me.dataTable.Name = "dataTable"
        Me.dataTable.Size = New System.Drawing.Size(300, 40)
        Me.dataTable.TabIndex = 0
        Me.dataTable.Text = "DataTable example"
        '
        'objectList
        '
        Me.objectList.Font = New System.Drawing.Font("default", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.objectList.Location = New System.Drawing.Point(100, 250)
        Me.objectList.Name = "objectList"
        Me.objectList.Size = New System.Drawing.Size(300, 40)
        Me.objectList.TabIndex = 1
        Me.objectList.Text = "Object List example"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.objectList)
        Me.Controls.Add(Me.dataTable)
        Me.Name = "MainPage"
        Me.Size = New System.Drawing.Size(930, 829)
        Me.Text = "TreeGrid Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents dataTable As Wisej.Web.Button
    Friend WithEvents objectList As Wisej.Web.Button
End Class
