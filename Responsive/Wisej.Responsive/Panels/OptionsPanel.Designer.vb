Namespace Panels

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class OptionsPanel
        Inherits UserControl
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
            components = New ComponentModel.Container()
            buttonProducts = New Button()
            imageList = New ImageList(components)
            pictureBox1 = New PictureBox()
            label1 = New Label()
            buttonCustomers = New Button()
            buttonDashboard = New Button()
            styleSheet = New StyleSheet(components)
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' buttonProducts
            ' 
            buttonProducts.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            buttonProducts.ImageList = imageList
            buttonProducts.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/shopping-cart.svg"
            buttonProducts.Location = New Drawing.Point(0, 119)
            buttonProducts.Name = "buttonProducts"
            buttonProducts.Size = New Drawing.Size(250, 77)
            buttonProducts.TabIndex = 0
            buttonProducts.Text = "Products"
            buttonProducts.TextAlign = Drawing.ContentAlignment.MiddleLeft
            AddHandler buttonProducts.Click, New EventHandler(AddressOf button_Click)
            ' 
            ' imageList
            ' 
            imageList.ImageSize = New Drawing.Size(32, 32)
            ' 
            ' pictureBox1
            ' 
            pictureBox1.ImageSource = "Images/Wisej-Logo-64x64.png"
            pictureBox1.Location = New Drawing.Point(16, 14)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(65, 69)
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            pictureBox1.TabIndex = 1
            ' 
            ' label1
            ' 
            label1.AllowHtml = True
            label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            label1.Font = New Drawing.Font("default", 20.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
            label1.Location = New Drawing.Point(113, 14)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(134, 69)
            label1.TabIndex = 2
            label1.Text = "ACME" & Microsoft.VisualBasic.Constants.vbCrLf & "Hardware" & Microsoft.VisualBasic.Constants.vbCrLf
            label1.TextAlign = Drawing.ContentAlignment.MiddleLeft
            ' 
            ' buttonCustomers
            ' 
            buttonCustomers.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            buttonCustomers.ImageList = imageList
            buttonCustomers.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/users-social-symbol.svg"
            buttonCustomers.Location = New Drawing.Point(0, 196)
            buttonCustomers.Name = "buttonCustomers"
            buttonCustomers.Size = New Drawing.Size(250, 77)
            buttonCustomers.TabIndex = 3
            buttonCustomers.Text = "Customers"
            buttonCustomers.TextAlign = Drawing.ContentAlignment.MiddleLeft
            AddHandler buttonCustomers.Click, New EventHandler(AddressOf button_Click)
            ' 
            ' buttonDashboard
            ' 
            buttonDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            buttonDashboard.ImageList = imageList
            buttonDashboard.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/medium-wifi-signal-with-two-bars.svg"
            buttonDashboard.Location = New Drawing.Point(0, 273)
            buttonDashboard.Name = "buttonDashboard"
            buttonDashboard.Size = New Drawing.Size(250, 77)
            buttonDashboard.TabIndex = 4
            buttonDashboard.Text = "Dashboard"
            buttonDashboard.TextAlign = Drawing.ContentAlignment.MiddleLeft
            AddHandler buttonDashboard.Click, New EventHandler(AddressOf button_Click)
            ' 
            ' styleSheet
            ' 
            styleSheet.Styles = ".active" & Microsoft.VisualBasic.Constants.vbCrLf & "{" & Microsoft.VisualBasic.Constants.vbCrLf & "    border-bottom: 4px solid yellow;" & Microsoft.VisualBasic.Constants.vbCrLf & "}"
            ' 
            ' OptionsPanel
            ' 
            AutoScaleDimensions = New Drawing.SizeF(11.0F, 23.0F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Drawing.Color.FromArgb(59, 63, 191, 179)
            Controls.Add(buttonDashboard)
            Controls.Add(buttonCustomers)
            Controls.Add(label1)
            Controls.Add(pictureBox1)
            Controls.Add(buttonProducts)
            Font = New Drawing.Font("default", 14.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
            Name = "OptionsPanel"
            Size = New Drawing.Size(250, 680)
            AddHandler Load, New EventHandler(AddressOf OptionsPanel_Load)
            AddHandler ResponsiveProfileChanged, New ResponsiveProfileChangedEventHandler(AddressOf OptionsPanel_ResponsiveProfileChanged)
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub


#End Region

        Friend WithEvents buttonProducts As Button
        Friend WithEvents pictureBox1 As PictureBox
        Friend WithEvents label1 As Label
        Friend WithEvents imageList As ImageList
        Friend WithEvents buttonCustomers As Button
        Friend WithEvents buttonDashboard As Button
        Friend WithEvents styleSheet As StyleSheet
    End Class
End Namespace
