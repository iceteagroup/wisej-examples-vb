Imports Microsoft.Reporting.WebForms
Imports System.ComponentModel
Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AspNetReportViewer
    Inherits Wisej.Web.Form

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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

    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ReportPath As String


    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.reportViewer1 = New Wisej.ReportingViewers.AspNetReportViewerControl()
        Me.SuspendLayout()
        '
        'reportViewer1
        '
        Me.reportViewer1.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.reportViewer1.Location = New System.Drawing.Point(32, 26)
        Me.reportViewer1.Name = "reportViewer1"
        Me.reportViewer1.ScrollBars = False
        Me.reportViewer1.ShowExportControls = True
        Me.reportViewer1.Size = New System.Drawing.Size(611, 471)
        Me.reportViewer1.TabIndex = 0
        Me.reportViewer1.Text = "aspNetReportViewerControl1"
        '
        'AspNetReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 519)
        Me.Controls.Add(Me.reportViewer1)
        Me.Name = "AspNetReportViewer"
        Me.Text = "AspNetReportViewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents reportViewer1 As AspNetReportViewerControl

End Class
