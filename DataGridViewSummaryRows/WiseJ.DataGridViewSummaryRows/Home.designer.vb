<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits Wisej.Web.Page

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

#Region "Wisej Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.btnCase1 = New Wisej.Web.Button()
        Me.btnCase2 = New Wisej.Web.Button()
        Me.btnSummaryGroup = New Wisej.Web.Button()
        Me.btnAllCallsSummary = New Wisej.Web.Button()
        Me.SuspendLayout()
        '
        'btnCase1
        '
        Me.btnCase1.Location = New System.Drawing.Point(55, 194)
        Me.btnCase1.Name = "btnCase1"
        Me.btnCase1.Size = New System.Drawing.Size(227, 54)
        Me.btnCase1.TabIndex = 0
        Me.btnCase1.Text = "Huge Data 1"
        '
        'btnCase2
        '
        Me.btnCase2.Location = New System.Drawing.Point(55, 254)
        Me.btnCase2.Name = "btnCase2"
        Me.btnCase2.Size = New System.Drawing.Size(227, 53)
        Me.btnCase2.TabIndex = 1
        Me.btnCase2.Text = "Huge Data 2"
        '
        'btnSummaryGroup
        '
        Me.btnSummaryGroup.Location = New System.Drawing.Point(55, 135)
        Me.btnSummaryGroup.Name = "btnSummaryGroup"
        Me.btnSummaryGroup.Size = New System.Drawing.Size(227, 53)
        Me.btnSummaryGroup.TabIndex = 2
        Me.btnSummaryGroup.Text = "Sumamry Group"
        '
        'btnAllCallsSummary
        '
        Me.btnAllCallsSummary.Location = New System.Drawing.Point(55, 76)
        Me.btnAllCallsSummary.Name = "btnAllCallsSummary"
        Me.btnAllCallsSummary.Size = New System.Drawing.Size(227, 53)
        Me.btnAllCallsSummary.TabIndex = 3
        Me.btnAllCallsSummary.Text = "All Calls for Summary"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.btnAllCallsSummary)
        Me.Controls.Add(Me.btnSummaryGroup)
        Me.Controls.Add(Me.btnCase2)
        Me.Controls.Add(Me.btnCase1)
        Me.Name = "Home"
        Me.Size = New System.Drawing.Size(654, 667)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents btnCase1 As Wisej.Web.Button
    Private WithEvents btnCase2 As Wisej.Web.Button
    Private WithEvents btnSummaryGroup As Wisej.Web.Button
    Private WithEvents btnAllCallsSummary As Wisej.Web.Button
End Class
