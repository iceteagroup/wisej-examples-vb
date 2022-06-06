
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
    Inherits Wisej.Web.Page

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.splitContainer1 = New Wisej.Web.SplitContainer()
        Me.monthCalendar1 = New Wisej.Web.MonthCalendar()
        Me.fullCalendar1 = New Wisej.Web.Ext.FullCalendar.FullCalendar()
        Me.toolBar1 = New Wisej.Web.ToolBar()
        Me.tbNew = New Wisej.Web.ToolBarButton()
        Me.tbBasicSep = New Wisej.Web.ToolBarButton()
        Me.tbBasicTitle = New Wisej.Web.ToolBarButton()
        Me.tbBasicDay = New Wisej.Web.ToolBarButton()
        Me.tbBasicWeek = New Wisej.Web.ToolBarButton()
        Me.tbBasicMonth = New Wisej.Web.ToolBarButton()
        Me.tbAgendaSep = New Wisej.Web.ToolBarButton()
        Me.tbAgendaTitle = New Wisej.Web.ToolBarButton()
        Me.tbAgendaDay = New Wisej.Web.ToolBarButton()
        Me.tbAgendaWeek = New Wisej.Web.ToolBarButton()
        Me.tbListSep = New Wisej.Web.ToolBarButton()
        Me.tbListTitle = New Wisej.Web.ToolBarButton()
        Me.tbListDay = New Wisej.Web.ToolBarButton()
        Me.tbListWeek = New Wisej.Web.ToolBarButton()
        Me.tbListMonth = New Wisej.Web.ToolBarButton()
        Me.tbListYear = New Wisej.Web.ToolBarButton()
        Me.imageList1 = New Wisej.Web.ImageList(Me.components)
        Me.styleSheet1 = New Wisej.Web.StyleSheet(Me.components)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = Wisej.Web.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 79)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.monthCalendar1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.fullCalendar1)
        Me.splitContainer1.Panel2.HeaderAlignment = Wisej.Web.HorizontalAlignment.Center
        Me.splitContainer1.Panel2.ShowCloseButton = False
        Me.splitContainer1.Panel2.ShowHeader = True
        Me.splitContainer1.Panel2.Text = "Scheduler"
        Me.splitContainer1.Size = New System.Drawing.Size(1056, 488)
        Me.splitContainer1.SplitterDistance = 264
        Me.splitContainer1.TabIndex = 3
        '
        'monthCalendar1
        '
        Me.monthCalendar1.BorderStyle = Wisej.Web.BorderStyle.None
        Me.monthCalendar1.CalendarDimensions = New System.Drawing.Size(1, 3)
        Me.monthCalendar1.Dock = Wisej.Web.DockStyle.Fill
        Me.monthCalendar1.Location = New System.Drawing.Point(0, 0)
        Me.monthCalendar1.MaxSelectionCount = 1
        Me.monthCalendar1.Name = "monthCalendar1"
        Me.monthCalendar1.Size = New System.Drawing.Size(262, 486)
        Me.monthCalendar1.TabIndex = 1
        '
        'fullCalendar1
        '
        Me.fullCalendar1.Dock = Wisej.Web.DockStyle.Fill
        Me.fullCalendar1.Name = "fullCalendar1"
        Me.fullCalendar1.Size = New System.Drawing.Size(784, 458)
        Me.fullCalendar1.TabIndex = 0
        Me.fullCalendar1.Text = "fullCalendar1"
        Me.fullCalendar1.TimeFormat = " "
        Me.fullCalendar1.View = Wisej.Web.Ext.FullCalendar.ViewType.AgendaWeek
        '
        'toolBar1
        '
        Me.toolBar1.BackColor = System.Drawing.Color.White
        Me.toolBar1.BackgroundImageLayout = Wisej.Web.ImageLayout.Center
        Me.toolBar1.BackgroundImageSource = "Images/toolbar-background.jpg"
        Me.toolBar1.Buttons.AddRange(New Wisej.Web.ToolBarButton() {Me.tbNew, Me.tbBasicSep, Me.tbBasicTitle, Me.tbBasicDay, Me.tbBasicWeek, Me.tbBasicMonth, Me.tbAgendaSep, Me.tbAgendaTitle, Me.tbAgendaDay, Me.tbAgendaWeek, Me.tbListSep, Me.tbListTitle, Me.tbListDay, Me.tbListWeek, Me.tbListMonth, Me.tbListYear})
        Me.toolBar1.ImageList = Me.imageList1
        Me.toolBar1.Location = New System.Drawing.Point(0, 0)
        Me.toolBar1.Name = "toolBar1"
        Me.toolBar1.Size = New System.Drawing.Size(1056, 79)
        Me.toolBar1.TabIndex = 2
        Me.toolBar1.TabStop = False
        '
        'tbNew
        '
        Me.tbNew.ImageSource = "resource.wx/Wisej.Ext.ModernUI/plus.svg"
        Me.tbNew.Name = "tbNew"
        Me.tbNew.Text = "New"
        '
        'tbBasicSep
        '
        Me.tbBasicSep.Name = "tbBasicSep"
        Me.tbBasicSep.Style = Wisej.Web.ToolBarButtonStyle.Separator
        Me.tbBasicSep.Text = "toolBarButton1"
        '
        'tbBasicTitle
        '
        Me.tbBasicTitle.AllowHtml = True
        Me.tbBasicTitle.Enabled = False
        Me.tbBasicTitle.Name = "tbBasicTitle"
        Me.tbBasicTitle.Text = "Basic<br/>View"
        '
        'tbBasicDay
        '
        Me.tbBasicDay.ImageSource = "resource.wx/Wisej.Ext.ModernUI/day.svg"
        Me.tbBasicDay.Name = "tbBasicDay"
        Me.tbBasicDay.Tag = "2"
        Me.tbBasicDay.Text = "Day"
        '
        'tbBasicWeek
        '
        Me.tbBasicWeek.ImageSource = "resource.wx/Wisej.Ext.ModernUI/week.svg"
        Me.tbBasicWeek.Name = "tbBasicWeek"
        Me.tbBasicWeek.Tag = "1"
        Me.tbBasicWeek.Text = "Week"
        '
        'tbBasicMonth
        '
        Me.tbBasicMonth.ImageSource = "resource.wx/Wisej.Ext.ModernUI/month.svg"
        Me.tbBasicMonth.Name = "tbBasicMonth"
        Me.tbBasicMonth.Tag = "0"
        Me.tbBasicMonth.Text = "Month"
        '
        'tbAgendaSep
        '
        Me.tbAgendaSep.Name = "tbAgendaSep"
        Me.tbAgendaSep.Style = Wisej.Web.ToolBarButtonStyle.Separator
        Me.tbAgendaSep.Text = "toolBarButton1"
        '
        'tbAgendaTitle
        '
        Me.tbAgendaTitle.AllowHtml = True
        Me.tbAgendaTitle.Enabled = False
        Me.tbAgendaTitle.Name = "tbAgendaTitle"
        Me.tbAgendaTitle.Text = "Agenda<br/>View"
        '
        'tbAgendaDay
        '
        Me.tbAgendaDay.ImageSource = "resource.wx/Wisej.Ext.ModernUI/day.svg"
        Me.tbAgendaDay.Name = "tbAgendaDay"
        Me.tbAgendaDay.Tag = "4"
        Me.tbAgendaDay.Text = "Day"
        '
        'tbAgendaWeek
        '
        Me.tbAgendaWeek.ImageSource = "resource.wx/Wisej.Ext.ModernUI/week.svg"
        Me.tbAgendaWeek.Name = "tbAgendaWeek"
        Me.tbAgendaWeek.Pushed = True
        Me.tbAgendaWeek.Tag = "3"
        Me.tbAgendaWeek.Text = "Week"
        '
        'tbListSep
        '
        Me.tbListSep.Name = "tbListSep"
        Me.tbListSep.Style = Wisej.Web.ToolBarButtonStyle.Separator
        Me.tbListSep.Text = "toolBarButton4"
        '
        'tbListTitle
        '
        Me.tbListTitle.AllowHtml = True
        Me.tbListTitle.Enabled = False
        Me.tbListTitle.Name = "tbListTitle"
        Me.tbListTitle.Text = "List<br/>View"
        Me.tbListTitle.Visible = False
        '
        'tbListDay
        '
        Me.tbListDay.ImageSource = "resource.wx/Wisej.Ext.ModernUI/day.svg"
        Me.tbListDay.Name = "tbListDay"
        Me.tbListDay.Tag = "8"
        Me.tbListDay.Text = "Day"
        Me.tbListDay.Visible = False
        '
        'tbListWeek
        '
        Me.tbListWeek.ImageSource = "resource.wx/Wisej.Ext.ModernUI/week.svg"
        Me.tbListWeek.Name = "tbListWeek"
        Me.tbListWeek.Tag = "7"
        Me.tbListWeek.Text = "Week"
        Me.tbListWeek.Visible = False
        '
        'tbListMonth
        '
        Me.tbListMonth.ImageSource = "resource.wx/Wisej.Ext.ModernUI/month.svg"
        Me.tbListMonth.Name = "tbListMonth"
        Me.tbListMonth.Tag = "6"
        Me.tbListMonth.Text = "Month"
        Me.tbListMonth.Visible = False
        '
        'tbListYear
        '
        Me.tbListYear.ImageSource = "resource.wx/Wisej.Ext.ModernUI/year.svg"
        Me.tbListYear.Name = "tbListYear"
        Me.tbListYear.Tag = "5"
        Me.tbListYear.Text = "Year"
        Me.tbListYear.Visible = False
        '
        'imageList1
        '
        Me.imageList1.ImageSize = New System.Drawing.Size(48, 48)
        '
        'styleSheet1
        '
        Me.styleSheet1.Styles = resources.GetString("styleSheet1.Styles")
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.toolBar1)
        Me.Name = "MainPage"
        Me.Size = New System.Drawing.Size(1056, 567)
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


#End Region

    Friend WithEvents fullCalendar1 As Web.Ext.FullCalendar.FullCalendar
    Friend WithEvents monthCalendar1 As Web.MonthCalendar
    Friend WithEvents toolBar1 As Web.ToolBar
    Friend WithEvents tbNew As Web.ToolBarButton
    Friend WithEvents tbBasicDay As Web.ToolBarButton
    Friend WithEvents tbBasicWeek As Web.ToolBarButton
    Friend WithEvents imageList1 As Web.ImageList
    Friend WithEvents tbBasicMonth As Web.ToolBarButton
    Friend WithEvents tbBasicSep As Web.ToolBarButton
    Friend WithEvents tbAgendaSep As Web.ToolBarButton
    Friend WithEvents splitContainer1 As Web.SplitContainer
    Friend WithEvents tbBasicTitle As Web.ToolBarButton
    Friend WithEvents tbAgendaTitle As Web.ToolBarButton
    Friend WithEvents tbAgendaDay As Web.ToolBarButton
    Friend WithEvents tbAgendaWeek As Web.ToolBarButton
    Friend WithEvents tbListSep As Web.ToolBarButton
    Friend WithEvents tbListTitle As Web.ToolBarButton
    Friend WithEvents tbListDay As Web.ToolBarButton
    Friend WithEvents tbListWeek As Web.ToolBarButton
    Friend WithEvents tbListMonth As Web.ToolBarButton
    Friend WithEvents tbListYear As Web.ToolBarButton
    Friend WithEvents styleSheet1 As Web.StyleSheet
End Class
