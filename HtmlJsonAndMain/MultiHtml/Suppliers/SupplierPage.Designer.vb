﻿Imports System

Namespace MultiHtml.Suppliers

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SupplierPage
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
            Me.label1 = New Wisej.Web.Label()
            Me.url = New Wisej.Web.Label()
            Me.navigateToDefaultHtml = New Wisej.Web.Button()
            Me.navigateToDefault = New Wisej.Web.Button()
            Me.navigateToAdministration = New Wisej.Web.Button()
            Me.navigateToAdministrationHtml = New Wisej.Web.Button()
            Me.navigateToStatisticsHtml = New Wisej.Web.Button()
            Me.navigateToStatistics = New Wisej.Web.Button()
            Me.navigateToCustomersHtml = New Wisej.Web.Button()
            Me.navigateToCustomers = New Wisej.Web.Button()
            Me.jsonFile = New Wisej.Web.TextBox()
            Me.SuspendLayout()
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("default", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.label1.Location = New System.Drawing.Point(100, 500)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(275, 28)
            Me.label1.TabIndex = 2
            Me.label1.Text = "Suppliers sub-Application"
            '
            'url
            '
            Me.url.Location = New System.Drawing.Point(100, 50)
            Me.url.Name = "url"
            Me.url.Size = New System.Drawing.Size(601, 16)
            Me.url.TabIndex = 3
            Me.url.Text = "url"
            '
            'navigateToDefaultHtml
            '
            Me.navigateToDefaultHtml.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.navigateToDefaultHtml.Location = New System.Drawing.Point(550, 100)
            Me.navigateToDefaultHtml.Name = "navigateToDefaultHtml"
            Me.navigateToDefaultHtml.Size = New System.Drawing.Size(300, 40)
            Me.navigateToDefaultHtml.TabIndex = 7
            Me.navigateToDefaultHtml.Text = "Navigate to Default.html"
            '
            'navigateToDefault
            '
            Me.navigateToDefault.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.navigateToDefault.Location = New System.Drawing.Point(100, 100)
            Me.navigateToDefault.Name = "navigateToDefault"
            Me.navigateToDefault.Size = New System.Drawing.Size(300, 40)
            Me.navigateToDefault.TabIndex = 6
            Me.navigateToDefault.Text = "Navigate to Default"
            '
            'navigateToAdministration
            '
            Me.navigateToAdministration.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.navigateToAdministration.Location = New System.Drawing.Point(100, 200)
            Me.navigateToAdministration.Name = "navigateToAdministration"
            Me.navigateToAdministration.Size = New System.Drawing.Size(300, 40)
            Me.navigateToAdministration.TabIndex = 0
            Me.navigateToAdministration.Text = "Navigate to Administration"
            '
            'navigateToAdministrationHtml
            '
            Me.navigateToAdministrationHtml.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.navigateToAdministrationHtml.Location = New System.Drawing.Point(550, 200)
            Me.navigateToAdministrationHtml.Name = "navigateToAdministrationHtml"
            Me.navigateToAdministrationHtml.Size = New System.Drawing.Size(300, 40)
            Me.navigateToAdministrationHtml.TabIndex = 1
            Me.navigateToAdministrationHtml.Text = "Navigate to Administration.html"
            '
            'navigateToStatisticsHtml
            '
            Me.navigateToStatisticsHtml.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.navigateToStatisticsHtml.Location = New System.Drawing.Point(550, 300)
            Me.navigateToStatisticsHtml.Name = "navigateToStatisticsHtml"
            Me.navigateToStatisticsHtml.Size = New System.Drawing.Size(300, 40)
            Me.navigateToStatisticsHtml.TabIndex = 5
            Me.navigateToStatisticsHtml.Text = "Navigate to Statistics.html"
            '
            'navigateToStatistics
            '
            Me.navigateToStatistics.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.navigateToStatistics.Location = New System.Drawing.Point(100, 300)
            Me.navigateToStatistics.Name = "navigateToStatistics"
            Me.navigateToStatistics.Size = New System.Drawing.Size(300, 40)
            Me.navigateToStatistics.TabIndex = 4
            Me.navigateToStatistics.Text = "Navigate to Statistics"
            '
            'navigateToCustomersHtml
            '
            Me.navigateToCustomersHtml.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.navigateToCustomersHtml.Location = New System.Drawing.Point(550, 400)
            Me.navigateToCustomersHtml.Name = "navigateToCustomersHtml"
            Me.navigateToCustomersHtml.Size = New System.Drawing.Size(300, 40)
            Me.navigateToCustomersHtml.TabIndex = 7
            Me.navigateToCustomersHtml.Text = "Navigate to Customers/Default.html"
            '
            'navigateToCustomers
            '
            Me.navigateToCustomers.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.navigateToCustomers.Location = New System.Drawing.Point(100, 400)
            Me.navigateToCustomers.Name = "navigateToCustomers"
            Me.navigateToCustomers.Size = New System.Drawing.Size(300, 40)
            Me.navigateToCustomers.TabIndex = 6
            Me.navigateToCustomers.Text = "Navigate to Customers"
            '
            'jsonFile
            '
            Me.jsonFile.BorderStyle = Wisej.Web.BorderStyle.None
            Me.jsonFile.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.jsonFile.Location = New System.Drawing.Point(550, 500)
            Me.jsonFile.Multiline = True
            Me.jsonFile.Name = "jsonFile"
            Me.jsonFile.ReadOnly = True
            Me.jsonFile.Size = New System.Drawing.Size(500, 40)
            Me.jsonFile.TabIndex = 11
            Me.jsonFile.Text = "json:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """mainWindow"": ""MultiHtml.Suppliers.SupplierPage, MultiHtml"""
            '
            'SupplierPage
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
            Me.Controls.Add(Me.jsonFile)
            Me.Controls.Add(Me.navigateToCustomersHtml)
            Me.Controls.Add(Me.navigateToCustomers)
            Me.Controls.Add(Me.navigateToStatisticsHtml)
            Me.Controls.Add(Me.navigateToStatistics)
            Me.Controls.Add(Me.navigateToAdministrationHtml)
            Me.Controls.Add(Me.navigateToAdministration)
            Me.Controls.Add(Me.navigateToDefaultHtml)
            Me.Controls.Add(Me.navigateToDefault)
            Me.Controls.Add(Me.url)
            Me.Controls.Add(Me.label1)
            Me.Name = "SupplierPage"
            Me.Size = New System.Drawing.Size(856, 821)
            Me.Text = "Supplier Page"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Friend WithEvents label1 As Wisej.Web.Label
        Friend WithEvents url As Wisej.Web.Label
        Friend WithEvents navigateToDefault As Wisej.Web.Button
        Friend WithEvents navigateToDefaultHtml As Wisej.Web.Button
        Friend WithEvents navigateToAdministration As Wisej.Web.Button
        Friend WithEvents navigateToAdministrationHtml As Wisej.Web.Button
        Friend WithEvents navigateToStatisticsHtml As Wisej.Web.Button
        Friend WithEvents navigateToStatistics As Wisej.Web.Button
        Friend WithEvents navigateToCustomersHtml As Wisej.Web.Button
        Friend WithEvents navigateToCustomers As Wisej.Web.Button
        Friend WithEvents jsonFile As Wisej.Web.TextBox
    End Class
End Namespace
