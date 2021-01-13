Imports System

Partial Class TourPanel1
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
        Dim tourStep1 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep2 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep3 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep4 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep5 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep6 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep7 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep8 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep9 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep10 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep11 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep12 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep13 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep14 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep15 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep16 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep17 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep18 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep19 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        Dim tourStep20 As Wisej.Web.Ext.TourPanel.TourStep = New Wisej.Web.Ext.TourPanel.TourStep()
        ButtonsPanel.SuspendLayout()
        TitlePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' HtmlText
        ' 
        HtmlText.Location = New Drawing.Point(10, 64)
        HtmlText.Margin = New Wisej.Web.Padding(3, 10, 3, 10)
        ' 
        ' TitleLabel
        ' 
        TitleLabel.Dock = Wisej.Web.DockStyle.Fill
        TitleLabel.Location = New Drawing.Point(0, 0)
        TitleLabel.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' CloseButton
        ' 
        CloseButton.Display = Wisej.Web.Display.Icon
        CloseButton.Dock = Wisej.Web.DockStyle.Right
        CloseButton.Location = New Drawing.Point(646, 0)
        ' 
        ' PlayButton
        ' 
        PlayButton.Location = New Drawing.Point(343, 3)
        ' 
        ' NextButton
        ' 
        NextButton.Location = New Drawing.Point(587, 3)
        ' 
        ' BackButton
        ' 
        BackButton.Location = New Drawing.Point(491, 3)
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Drawing.Point(395, 3)
        ' 
        ' TourPanel1
        ' 
        Name = "TourPanel1"
        Padding = New Wisej.Web.Padding(10)
        tourStep1.TargetName = "Desktop.toolbar1"
        tourStep1.Text = "This is the desktop toolbar. Start your tour here<br/>" & Microsoft.VisualBasic.Constants.vbCrLf & "You can also start it wit" & "h AutoPlay on using the 2nd button."
        tourStep1.Title = "Desktop toolbar"
        tourStep2.Alignment = Wisej.Web.Placement.RightTop
        tourStep2.TargetName = "Window1"
        tourStep2.Text = "This is the first form." & Microsoft.VisualBasic.Constants.vbCrLf & "It includes some menus."
        tourStep2.Title = "Form1"
        tourStep3.TargetName = "Window1.menu.menuItem6"
        tourStep3.Text = "Here´s the help menu"
        tourStep3.Title = "Help menu"
        tourStep4.TargetName = "Window1.menu.menuItem1"
        tourStep4.Text = "Use the File menu to open/save/create a file"
        tourStep4.Title = "File menu"
        tourStep5.TargetName = "window1.txtFirstName"
        tourStep5.Text = "Type in your first name"
        tourStep5.Title = "First Name"
        tourStep6.TargetName = "Window1.txtName"
        tourStep6.Text = "Type in your last name"
        tourStep6.Title = "Name"
        tourStep7.Alignment = Wisej.Web.Placement.RightMiddle
        tourStep7.ShowClose = False
        tourStep7.TargetName = "Window1.cmbInterest"
        tourStep7.Text = "Select your interest"
        tourStep7.Title = "cmbInterest"
        tourStep8.Alignment = Wisej.Web.Placement.RightMiddle
        tourStep8.AllowPointerEvents = True
        tourStep8.TargetName = "Window1.cmbInterest/tools[0]"
        tourStep8.Text = "Please note that you can add new interests."
        tourStep8.Title = "Add new interest"
        tourStep9.TargetName = "Window2.tabControl1.tabPage4.groupBox1.textBox1"
        tourStep9.Text = "Activates Window2<br/>" & Microsoft.VisualBasic.Constants.vbCrLf & "Activates tabPage4 of tabControl1<br/>" & Microsoft.VisualBasic.Constants.vbCrLf & "Expands groupBox1" & "<br/>" & Microsoft.VisualBasic.Constants.vbCrLf & "Points to textBox1<br/>" & Microsoft.VisualBasic.Constants.vbCrLf
        tourStep9.Title = "Window - tabControl - tabPage - groupBox - textBox"
        tourStep10.TargetName = "Window2.tabControl1.tabPage2"
        tourStep10.Text = "Can also highlight a complete tabPage"
        tourStep10.Title = "TabPage2"
        tourStep11.TargetName = "Window2.tabControl1.tabPage3/button"
        tourStep11.Text = "Or the button needed to activate a tab"
        tourStep11.Title = "TabPage3 button"
        tourStep12.Alignment = Wisej.Web.Placement.RightMiddle
        tourStep12.TargetName = "Window3"
        tourStep12.Text = "Here we show how to point on various elements of a DataGridView"
        tourStep12.Title = "Form3"
        tourStep13.TargetName = "Window3.dataGridView1.colNAME"
        tourStep13.Text = "This is the name<br/>" & Microsoft.VisualBasic.Constants.vbCrLf & "The dgv contents are sorted by clicking on the col header " & Microsoft.VisualBasic.Constants.vbCrLf & "if you set the correct SortMode."
        tourStep13.Title = "colNAME"
        tourStep14.TargetName = "Window3.dataGridView1.colDEPARTMENT"
        tourStep14.Text = "Please note that columns are automatically scrolled into view."
        tourStep14.Title = "colDEPARTMENT"
        tourStep15.TargetName = "Window3.dataGridView1/column-button"
        tourStep15.Text = "With this button you can control which columns are displayed."
        tourStep15.Title = "Column Visibility Menu Button"
        tourStep16.Alignment = Wisej.Web.Placement.RightMiddle
        tourStep16.TargetName = "Window3.dataGridView1/tools[0]"
        tourStep16.Text = "Clicking on the + adds a new row to the DataGridView"
        tourStep16.Title = "Tool to add new rows"
        tourStep17.Tag = "Chrome"
        tourStep17.TargetName = "Window4.labelChrome"
        tourStep17.Text = "This step only appears for Chrome users"
        tourStep17.Title = "LabelChrome"
        tourStep18.Alignment = Wisej.Web.Placement.RightMiddle
        tourStep18.TargetName = "Window4.ckEditor1"
        tourStep18.Text = "This is an instance of the CKEditor</br>" & Microsoft.VisualBasic.Constants.vbCrLf & "Please note the text in <h3 style=""colo" & "r:blue"">blue</h3>"
        tourStep18.Title = "CKEditor"
        tourStep19.TargetName = "Window5.accordion1.accordionPanelGreen.checkBox1"
        tourStep19.Title = "Checkbox on green Panel"
        tourStep20.TargetName = "Window5.textBoxWatermark"
        tourStep20.Text = "Show watermark on textBoxes"
        tourStep20.Title = "Watermark"
        Steps = New Wisej.Web.Ext.TourPanel.TourStep() {tourStep1, tourStep2, tourStep3, tourStep4, tourStep5, tourStep6, tourStep7, tourStep8, tourStep9, tourStep10, tourStep11, tourStep12, tourStep13, tourStep14, tourStep15, tourStep16, tourStep17, tourStep18, tourStep19, tourStep20}
        ButtonsPanel.ResumeLayout(False)
        TitlePanel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

#End Region
End Class
