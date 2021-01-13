Namespace DGVEmbeddedNavigator

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class NavigationPanel
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
            dataGridView1 = New Wisej.Web.DataGridView()
            panel = New Wisej.Web.FlowLayoutPanel()
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
            panel.SuspendLayout()
            SuspendLayout()
            ' 
            ' dataGridView1
            ' 
            dataGridView1.Controls.Add(panel)
            dataGridView1.Dock = Wisej.Web.DockStyle.Top
            dataGridView1.Location = New Drawing.Point(0, 0)
            dataGridView1.Name = "dataGridView1"
            dataGridView1.ShowFocusCell = False
            dataGridView1.Size = New Drawing.Size(612, 342)
            dataGridView1.TabIndex = 1
            ' 
            ' panel
            ' 
            panel.Controls.Add(buttonMoveFirst)
            panel.Controls.Add(buttonMovePrevious)
            panel.Controls.Add(separatorLeft)
            panel.Controls.Add(textBoxPosition)
            panel.Controls.Add(labelCount)
            panel.Controls.Add(separatorRight)
            panel.Controls.Add(buttonMoveNext)
            panel.Controls.Add(buttonMoveLast)
            panel.Controls.Add(separatorControl)
            panel.Controls.Add(buttonAddNew)
            panel.Controls.Add(buttonDelete)
            panel.Dock = Wisej.Web.DockStyle.Top
            panel.Location = New Drawing.Point(0, 0)
            panel.Name = "panel"
            panel.ScrollBars = Wisej.Web.ScrollBars.None
            panel.Size = New Drawing.Size(610, 30)
            panel.TabIndex = 0
            ' 
            ' buttonMoveFirst
            ' 
            buttonMoveFirst.BackgroundImageSource = "icon-first?color=#FFFFFF"
            buttonMoveFirst.Display = Wisej.Web.Display.Icon
            buttonMoveFirst.Location = New Drawing.Point(4, 4)
            buttonMoveFirst.Margin = New Wisej.Web.Padding(4)
            buttonMoveFirst.Name = "buttonMoveFirst"
            buttonMoveFirst.Size = New Drawing.Size(24, 22)
            buttonMoveFirst.TabIndex = 0
            ' 
            ' buttonMovePrevious
            ' 
            buttonMovePrevious.BackgroundImageSource = "icon-left?color=#FFFFFF"
            buttonMovePrevious.Display = Wisej.Web.Display.Icon
            buttonMovePrevious.Location = New Drawing.Point(36, 4)
            buttonMovePrevious.Margin = New Wisej.Web.Padding(4)
            buttonMovePrevious.Name = "buttonMovePrevious"
            buttonMovePrevious.Size = New Drawing.Size(24, 22)
            buttonMovePrevious.TabIndex = 1
            ' 
            ' separatorLeft
            ' 
            separatorLeft.Location = New Drawing.Point(68, 4)
            separatorLeft.Margin = New Wisej.Web.Padding(4)
            separatorLeft.Name = "separatorLeft"
            separatorLeft.Orientation = Wisej.Web.Orientation.Vertical
            separatorLeft.Size = New Drawing.Size(6, 22)
            ' 
            ' textBoxPosition
            ' 
            textBoxPosition.Location = New Drawing.Point(82, 4)
            textBoxPosition.Margin = New Wisej.Web.Padding(4)
            textBoxPosition.Name = "textBoxPosition"
            textBoxPosition.Size = New Drawing.Size(100, 22)
            textBoxPosition.TabIndex = 2
            textBoxPosition.Text = "0"
            ' 
            ' labelCount
            ' 
            labelCount.AutoSize = True
            labelCount.ImageAlign = Drawing.ContentAlignment.BottomCenter
            labelCount.Location = New Drawing.Point(190, 6)
            labelCount.Margin = New Wisej.Web.Padding(4, 6, 4, 4)
            labelCount.Name = "labelCount"
            labelCount.Size = New Drawing.Size(39, 16)
            labelCount.TabIndex = 3
            labelCount.Text = "of {0}"
            labelCount.TextAlign = Drawing.ContentAlignment.BottomCenter
            ' 
            ' separatorRight
            ' 
            separatorRight.Location = New Drawing.Point(237, 4)
            separatorRight.Margin = New Wisej.Web.Padding(4)
            separatorRight.Name = "separatorRight"
            separatorRight.Orientation = Wisej.Web.Orientation.Vertical
            separatorRight.Size = New Drawing.Size(6, 22)
            ' 
            ' buttonMoveNext
            ' 
            buttonMoveNext.BackgroundImageSource = "icon-right?color=#FFFFFF"
            buttonMoveNext.Display = Wisej.Web.Display.Icon
            buttonMoveNext.Location = New Drawing.Point(251, 4)
            buttonMoveNext.Margin = New Wisej.Web.Padding(4)
            buttonMoveNext.Name = "buttonMoveNext"
            buttonMoveNext.Size = New Drawing.Size(24, 22)
            buttonMoveNext.TabIndex = 4
            ' 
            ' buttonMoveLast
            ' 
            buttonMoveLast.BackgroundImageSource = "icon-last?color=#FFFFFF"
            buttonMoveLast.Display = Wisej.Web.Display.Icon
            buttonMoveLast.Location = New Drawing.Point(283, 4)
            buttonMoveLast.Margin = New Wisej.Web.Padding(4)
            buttonMoveLast.Name = "buttonMoveLast"
            buttonMoveLast.Size = New Drawing.Size(24, 22)
            buttonMoveLast.TabIndex = 5
            ' 
            ' separatorControl
            ' 
            separatorControl.Location = New Drawing.Point(315, 4)
            separatorControl.Margin = New Wisej.Web.Padding(4)
            separatorControl.Name = "separatorControl"
            separatorControl.Orientation = Wisej.Web.Orientation.Vertical
            separatorControl.Size = New Drawing.Size(6, 22)
            ' 
            ' buttonAddNew
            ' 
            buttonAddNew.BackgroundImageSource = "table-row-new?color=#FFFFFF"
            buttonAddNew.Display = Wisej.Web.Display.Icon
            buttonAddNew.Location = New Drawing.Point(329, 4)
            buttonAddNew.Margin = New Wisej.Web.Padding(4)
            buttonAddNew.Name = "buttonAddNew"
            buttonAddNew.Size = New Drawing.Size(30, 22)
            buttonAddNew.TabIndex = 6
            ' 
            ' buttonDelete
            ' 
            buttonDelete.BackgroundImageSource = "icon-close?color=#FFFFFF"
            buttonDelete.Display = Wisej.Web.Display.Icon
            buttonDelete.Location = New Drawing.Point(367, 4)
            buttonDelete.Margin = New Wisej.Web.Padding(4)
            buttonDelete.Name = "buttonDelete"
            buttonDelete.Size = New Drawing.Size(30, 22)
            buttonDelete.TabIndex = 7
            ' 
            ' NavigationPanel
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
            AutoScaleMode = Wisej.Web.AutoScaleMode.Font
            ClientSize = New Drawing.Size(612, 480)
            Controls.Add(dataGridView1)
            Name = "NavigationPanel"
            Text = "Navigation Panel"
            CType(dataGridView1, ComponentModel.ISupportInitialize).EndInit()
            dataGridView1.ResumeLayout(False)
            panel.ResumeLayout(False)
            panel.PerformLayout()
            ResumeLayout(False)
        End Sub

#End Region

        Friend WithEvents dataGridView1 As Wisej.Web.DataGridView
        Friend WithEvents panel As Wisej.Web.FlowLayoutPanel
        Friend WithEvents buttonMoveFirst As Wisej.Web.Button
        Friend WithEvents buttonMovePrevious As Wisej.Web.Button
        Friend WithEvents separatorLeft As Wisej.Web.Line
        Friend WithEvents labelCount As Wisej.Web.Label
        Friend WithEvents textBoxPosition As Wisej.Web.TextBox
        Friend WithEvents separatorRight As Wisej.Web.Line
        Friend WithEvents buttonMoveNext As Wisej.Web.Button
        Friend WithEvents buttonMoveLast As Wisej.Web.Button
        Friend WithEvents separatorControl As Wisej.Web.Line
        Friend WithEvents buttonAddNew As Wisej.Web.Button
        Friend WithEvents buttonDelete As Wisej.Web.Button
    End Class
End Namespace
