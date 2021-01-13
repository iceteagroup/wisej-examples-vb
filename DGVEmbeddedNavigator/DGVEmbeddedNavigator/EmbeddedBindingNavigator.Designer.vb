Namespace DGVEmbeddedNavigator
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class EmbeddedBindingNavigator
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
            components = New ComponentModel.Container()
            dataGridView1 = New Wisej.Web.DataGridView()
            bindingNavigator = New Wisej.Web.BindingNavigator(components)
            buttonMoveFirst = New Wisej.Web.Button()
            buttonMovePrevious = New Wisej.Web.Button()
            separatorLeft = New Wisej.Web.Line()
            textBoxPosition = New Wisej.Web.TextBox()
            labelCount = New Wisej.Web.Label()
            separatorRight = New Wisej.Web.Line()
            buttonMoveNext = New Wisej.Web.Button()
            buttonMoveLast = New Wisej.Web.Button()
            separatorControl = New Wisej.Web.Line()
            buttonAddNew = New Wisej.Web.Button()
            buttonDelete = New Wisej.Web.Button()
            CType(dataGridView1, ComponentModel.ISupportInitialize).BeginInit()
            dataGridView1.SuspendLayout()
            CType(bindingNavigator, ComponentModel.ISupportInitialize).BeginInit()
            bindingNavigator.SuspendLayout()
            SuspendLayout()
            ' 
            ' dataGridView1
            ' 
            dataGridView1.Controls.Add(bindingNavigator)
            dataGridView1.Dock = Wisej.Web.DockStyle.Top
            dataGridView1.Location = New Drawing.Point(0, 0)
            dataGridView1.Name = "dataGridView1"
            dataGridView1.ShowFocusCell = False
            dataGridView1.Size = New Drawing.Size(613, 342)
            dataGridView1.TabIndex = 0
            ' 
            ' bindingNavigator
            ' 
            bindingNavigator.AddNewItem = buttonAddNew
            bindingNavigator.Controls.Add(buttonMoveFirst)
            bindingNavigator.Controls.Add(buttonMovePrevious)
            bindingNavigator.Controls.Add(separatorLeft)
            bindingNavigator.Controls.Add(textBoxPosition)
            bindingNavigator.Controls.Add(labelCount)
            bindingNavigator.Controls.Add(separatorRight)
            bindingNavigator.Controls.Add(buttonMoveNext)
            bindingNavigator.Controls.Add(buttonMoveLast)
            bindingNavigator.Controls.Add(separatorControl)
            bindingNavigator.Controls.Add(buttonAddNew)
            bindingNavigator.Controls.Add(buttonDelete)
            bindingNavigator.CountItem = labelCount
            bindingNavigator.DeleteItem = buttonDelete
            bindingNavigator.Dock = Wisej.Web.DockStyle.Top
            bindingNavigator.Location = New Drawing.Point(0, 0)
            bindingNavigator.MoveFirstItem = buttonMoveFirst
            bindingNavigator.MoveLastItem = buttonMoveLast
            bindingNavigator.MoveNextItem = buttonMoveNext
            bindingNavigator.MovePreviousItem = buttonMovePrevious
            bindingNavigator.Name = "bindingNavigator"
            bindingNavigator.PositionItem = textBoxPosition
            bindingNavigator.Size = New Drawing.Size(611, 34)
            bindingNavigator.TabIndex = 0
            ' 
            ' buttonMoveFirst
            ' 
            buttonMoveFirst.ImageSource = "icon-first"
            buttonMoveFirst.Location = New Drawing.Point(3, 3)
            buttonMoveFirst.Name = "buttonMoveFirst"
            buttonMoveFirst.Size = New Drawing.Size(37, 28)
            buttonMoveFirst.TabIndex = 0
            ' 
            ' buttonMovePrevious
            ' 
            buttonMovePrevious.ImageSource = "icon-left"
            buttonMovePrevious.Location = New Drawing.Point(46, 3)
            buttonMovePrevious.Name = "buttonMovePrevious"
            buttonMovePrevious.Size = New Drawing.Size(37, 28)
            buttonMovePrevious.TabIndex = 1
            ' 
            ' separatorLeft
            ' 
            separatorLeft.Location = New Drawing.Point(89, 3)
            separatorLeft.Name = "separatorLeft"
            separatorLeft.Orientation = Wisej.Web.Orientation.Vertical
            separatorLeft.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
            separatorLeft.Size = New Drawing.Size(14, 28)
            ' 
            ' textBoxPosition
            ' 
            textBoxPosition.AutoSize = False
            textBoxPosition.Location = New Drawing.Point(109, 3)
            textBoxPosition.Name = "textBoxPosition"
            textBoxPosition.Size = New Drawing.Size(50, 28)
            textBoxPosition.TabIndex = 6
            textBoxPosition.Text = "0"
            ' 
            ' labelCount
            ' 
            labelCount.Location = New Drawing.Point(165, 3)
            labelCount.Name = "labelCount"
            labelCount.Size = New Drawing.Size(39, 28)
            labelCount.TabIndex = 7
            labelCount.Text = "of {0}"
            labelCount.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' separatorRight
            ' 
            separatorRight.Location = New Drawing.Point(210, 3)
            separatorRight.Name = "separatorRight"
            separatorRight.Orientation = Wisej.Web.Orientation.Vertical
            separatorRight.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
            separatorRight.Size = New Drawing.Size(14, 28)
            ' 
            ' buttonMoveNext
            ' 
            buttonMoveNext.ImageSource = "icon-right"
            buttonMoveNext.Location = New Drawing.Point(230, 3)
            buttonMoveNext.Name = "buttonMoveNext"
            buttonMoveNext.Size = New Drawing.Size(37, 28)
            buttonMoveNext.TabIndex = 2
            ' 
            ' buttonMoveLast
            ' 
            buttonMoveLast.ImageSource = "icon-last"
            buttonMoveLast.Location = New Drawing.Point(273, 3)
            buttonMoveLast.Name = "buttonMoveLast"
            buttonMoveLast.Size = New Drawing.Size(37, 28)
            buttonMoveLast.TabIndex = 3
            ' 
            ' separatorControl
            ' 
            separatorControl.Location = New Drawing.Point(316, 3)
            separatorControl.Name = "separatorControl"
            separatorControl.Orientation = Wisej.Web.Orientation.Vertical
            separatorControl.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
            separatorControl.Size = New Drawing.Size(14, 28)
            ' 
            ' buttonAddNew
            ' 
            buttonAddNew.ImageSource = "table-row-new"
            buttonAddNew.Location = New Drawing.Point(336, 3)
            buttonAddNew.Name = "buttonAddNew"
            buttonAddNew.Size = New Drawing.Size(37, 28)
            buttonAddNew.TabIndex = 4
            ' 
            ' buttonDelete
            ' 
            buttonDelete.ImageSource = "icon-close"
            buttonDelete.Location = New Drawing.Point(379, 3)
            buttonDelete.Name = "buttonDelete"
            buttonDelete.Size = New Drawing.Size(37, 28)
            buttonDelete.TabIndex = 5
            ' 
            ' EmbeddedBindingNavigator
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
            AutoScaleMode = Wisej.Web.AutoScaleMode.Font
            ClientSize = New Drawing.Size(613, 432)
            Controls.Add(dataGridView1)
            Name = "EmbeddedBindingNavigator"
            Text = "Embedded BindingNavigator"
            CType(dataGridView1, ComponentModel.ISupportInitialize).EndInit()
            dataGridView1.ResumeLayout(False)
            CType(bindingNavigator, ComponentModel.ISupportInitialize).EndInit()
            bindingNavigator.ResumeLayout(False)
            ResumeLayout(False)
        End Sub

#End Region

        Friend WithEvents dataGridView1 As Wisej.Web.DataGridView
        Friend WithEvents bindingNavigator As Wisej.Web.BindingNavigator
        Friend WithEvents buttonAddNew As Wisej.Web.Button
        Friend WithEvents buttonMoveFirst As Wisej.Web.Button
        Friend WithEvents buttonMovePrevious As Wisej.Web.Button
        Friend WithEvents separatorLeft As Wisej.Web.Line
        Friend WithEvents textBoxPosition As Wisej.Web.TextBox
        Friend WithEvents labelCount As Wisej.Web.Label
        Friend WithEvents separatorRight As Wisej.Web.Line
        Friend WithEvents buttonMoveNext As Wisej.Web.Button
        Friend WithEvents buttonMoveLast As Wisej.Web.Button
        Friend WithEvents separatorControl As Wisej.Web.Line
        Friend WithEvents buttonDelete As Wisej.Web.Button
    End Class
End Namespace
