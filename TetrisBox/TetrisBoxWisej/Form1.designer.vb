<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits Wisej.Web.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gbxBackground = New Wisej.Web.GroupBox()
        Me.lnkBackgroundPicture = New Wisej.Web.LinkLabel()
        Me.radBackgroundPicture = New Wisej.Web.RadioButton()
        Me.cboGradientDirection = New Wisej.Web.ComboBox()
        Me.pnlBackgroundGradient2 = New Wisej.Web.Panel()
        Me.Label1 = New Wisej.Web.Label()
        Me.pnlBackgroundGradient1 = New Wisej.Web.Panel()
        Me.radBackgroundGradient = New Wisej.Web.RadioButton()
        Me.pnlBackgroundSolid = New Wisej.Web.Panel()
        Me.radBackgroundSolid = New Wisej.Web.RadioButton()
        Me.dlgBackgroundPicture = New Wisej.Web.OpenFileDialog(Me.components)
        Me.dlgColor = New Wisej.Web.ColorDialog(Me.components)
        Me.gbxBoardSize = New Wisej.Web.GroupBox()
        Me.Label4 = New Wisej.Web.Label()
        Me.numCellSize = New Wisej.Web.NumericUpDown()
        Me.Label3 = New Wisej.Web.Label()
        Me.numColumns = New Wisej.Web.NumericUpDown()
        Me.Label2 = New Wisej.Web.Label()
        Me.numRows = New Wisej.Web.NumericUpDown()
        Me.gbxBlockColors = New Wisej.Web.GroupBox()
        Me.Label11 = New Wisej.Web.Label()
        Me.Label10 = New Wisej.Web.Label()
        Me.Label9 = New Wisej.Web.Label()
        Me.pnlBlock7Color = New Wisej.Web.Panel()
        Me.pnlBlock6Color = New Wisej.Web.Panel()
        Me.pnlBlock5Color = New Wisej.Web.Panel()
        Me.Label8 = New Wisej.Web.Label()
        Me.Label7 = New Wisej.Web.Label()
        Me.Label6 = New Wisej.Web.Label()
        Me.Label5 = New Wisej.Web.Label()
        Me.pnlBlock4Color = New Wisej.Web.Panel()
        Me.pnlBlock3Color = New Wisej.Web.Panel()
        Me.pnlBlock2Color = New Wisej.Web.Panel()
        Me.pnlBlock1Color = New Wisej.Web.Panel()
        Me.gbxKeys = New Wisej.Web.GroupBox()
        Me.Label15 = New Wisej.Web.Label()
        Me.Label14 = New Wisej.Web.Label()
        Me.Label13 = New Wisej.Web.Label()
        Me.Label12 = New Wisej.Web.Label()
        Me.cboKeysDrop = New Wisej.Web.ComboBox()
        Me.cboKeysRotate = New Wisej.Web.ComboBox()
        Me.cboKeysRight = New Wisej.Web.ComboBox()
        Me.cboKeysLeft = New Wisej.Web.ComboBox()
        Me.gbxDifficulties = New Wisej.Web.GroupBox()
        Me.Label19 = New Wisej.Web.Label()
        Me.pnlUncompleteLine = New Wisej.Web.Panel()
        Me.Label18 = New Wisej.Web.Label()
        Me.numUncompleteLine = New Wisej.Web.NumericUpDown()
        Me.chkUncompleteLine = New Wisej.Web.CheckBox()
        Me.pnlRandomBlock = New Wisej.Web.Panel()
        Me.Label17 = New Wisej.Web.Label()
        Me.Label16 = New Wisej.Web.Label()
        Me.numRandomBlock = New Wisej.Web.NumericUpDown()
        Me.chkRandomBlock = New Wisej.Web.CheckBox()
        Me.GroupBox6 = New Wisej.Web.GroupBox()
        Me.Label22 = New Wisej.Web.Label()
        Me.Label21 = New Wisej.Web.Label()
        Me.Label20 = New Wisej.Web.Label()
        Me.tbrSpeed = New Wisej.Web.TrackBar()
        Me.btnResume = New Wisej.Web.Button()
        Me.btnPause = New Wisej.Web.Button()
        Me.btnStop = New Wisej.Web.Button()
        Me.btnStart = New Wisej.Web.Button()
        Me.GroupBox7 = New Wisej.Web.GroupBox()
        Me.lstEvents = New Wisej.Web.ListBox()
        Me.Label23 = New Wisej.Web.Label()
        Me.lnkArticle = New Wisej.Web.LinkLabel()
        Me.linkWiseJ = New Wisej.Web.LinkLabel()
        Me.TetrisBox1 = New TetrisBoxWisej.TetrisBox()
        Me.gbxBackground.SuspendLayout()
        Me.gbxBoardSize.SuspendLayout()
        CType(Me.numCellSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBlockColors.SuspendLayout()
        Me.gbxKeys.SuspendLayout()
        Me.gbxDifficulties.SuspendLayout()
        CType(Me.numUncompleteLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRandomBlock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.tbrSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.TetrisBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxBackground
        '
        Me.gbxBackground.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.gbxBackground.Controls.Add(Me.lnkBackgroundPicture)
        Me.gbxBackground.Controls.Add(Me.radBackgroundPicture)
        Me.gbxBackground.Controls.Add(Me.cboGradientDirection)
        Me.gbxBackground.Controls.Add(Me.pnlBackgroundGradient2)
        Me.gbxBackground.Controls.Add(Me.Label1)
        Me.gbxBackground.Controls.Add(Me.pnlBackgroundGradient1)
        Me.gbxBackground.Controls.Add(Me.radBackgroundGradient)
        Me.gbxBackground.Controls.Add(Me.pnlBackgroundSolid)
        Me.gbxBackground.Controls.Add(Me.radBackgroundSolid)
        Me.gbxBackground.Location = New System.Drawing.Point(691, 14)
        Me.gbxBackground.Name = "gbxBackground"
        Me.gbxBackground.Size = New System.Drawing.Size(305, 113)
        Me.gbxBackground.TabIndex = 1
        Me.gbxBackground.Text = "Background"
        '
        'lnkBackgroundPicture
        '
        Me.lnkBackgroundPicture.AutoSize = True
        Me.lnkBackgroundPicture.Location = New System.Drawing.Point(91, 93)
        Me.lnkBackgroundPicture.Name = "lnkBackgroundPicture"
        Me.lnkBackgroundPicture.Size = New System.Drawing.Size(83, 16)
        Me.lnkBackgroundPicture.TabIndex = 8
        Me.lnkBackgroundPicture.Text = "Select picture..."
        '
        'radBackgroundPicture
        '
        Me.radBackgroundPicture.Cursor = Wisej.Web.Cursors.Hand
        Me.radBackgroundPicture.Location = New System.Drawing.Point(4, 89)
        Me.radBackgroundPicture.Name = "radBackgroundPicture"
        Me.radBackgroundPicture.Size = New System.Drawing.Size(68, 23)
        Me.radBackgroundPicture.TabIndex = 7
        Me.radBackgroundPicture.Text = "Picture"
        '
        'cboGradientDirection
        '
        Me.cboGradientDirection.Cursor = Wisej.Web.Cursors.Hand
        Me.cboGradientDirection.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        Me.cboGradientDirection.FormattingEnabled = True
        Me.cboGradientDirection.Items.AddRange(New Object() {"Horizontal", "Vertical", "ForwardDiagonal", "BackwardDiagonal"})
        Me.cboGradientDirection.Location = New System.Drawing.Point(163, 59)
        Me.cboGradientDirection.Name = "cboGradientDirection"
        Me.cboGradientDirection.Size = New System.Drawing.Size(114, 22)
        Me.cboGradientDirection.TabIndex = 6
        '
        'pnlBackgroundGradient2
        '
        Me.pnlBackgroundGradient2.BackColor = System.Drawing.Color.Black
        Me.pnlBackgroundGradient2.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.pnlBackgroundGradient2.Cursor = Wisej.Web.Cursors.Hand
        Me.pnlBackgroundGradient2.Location = New System.Drawing.Point(135, 60)
        Me.pnlBackgroundGradient2.Name = "pnlBackgroundGradient2"
        Me.pnlBackgroundGradient2.Size = New System.Drawing.Size(25, 24)
        Me.pnlBackgroundGradient2.TabIndex = 5
        Me.pnlBackgroundGradient2.TabStop = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "to"
        '
        'pnlBackgroundGradient1
        '
        Me.pnlBackgroundGradient1.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlBackgroundGradient1.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.pnlBackgroundGradient1.Cursor = Wisej.Web.Cursors.Hand
        Me.pnlBackgroundGradient1.Location = New System.Drawing.Point(89, 60)
        Me.pnlBackgroundGradient1.Name = "pnlBackgroundGradient1"
        Me.pnlBackgroundGradient1.Size = New System.Drawing.Size(25, 24)
        Me.pnlBackgroundGradient1.TabIndex = 3
        Me.pnlBackgroundGradient1.TabStop = True
        '
        'radBackgroundGradient
        '
        Me.radBackgroundGradient.Cursor = Wisej.Web.Cursors.Hand
        Me.radBackgroundGradient.Location = New System.Drawing.Point(4, 60)
        Me.radBackgroundGradient.Name = "radBackgroundGradient"
        Me.radBackgroundGradient.Size = New System.Drawing.Size(78, 23)
        Me.radBackgroundGradient.TabIndex = 2
        Me.radBackgroundGradient.Text = "Gradient"
        '
        'pnlBackgroundSolid
        '
        Me.pnlBackgroundSolid.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlBackgroundSolid.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.pnlBackgroundSolid.Cursor = Wisej.Web.Cursors.Hand
        Me.pnlBackgroundSolid.Location = New System.Drawing.Point(89, 28)
        Me.pnlBackgroundSolid.Name = "pnlBackgroundSolid"
        Me.pnlBackgroundSolid.Size = New System.Drawing.Size(25, 24)
        Me.pnlBackgroundSolid.TabIndex = 1
        Me.pnlBackgroundSolid.TabStop = True
        '
        'radBackgroundSolid
        '
        Me.radBackgroundSolid.Checked = True
        Me.radBackgroundSolid.Cursor = Wisej.Web.Cursors.Hand
        Me.radBackgroundSolid.Location = New System.Drawing.Point(4, 28)
        Me.radBackgroundSolid.Name = "radBackgroundSolid"
        Me.radBackgroundSolid.Size = New System.Drawing.Size(88, 23)
        Me.radBackgroundSolid.TabIndex = 0
        Me.radBackgroundSolid.TabStop = True
        Me.radBackgroundSolid.Text = "Solid color"
        '
        'dlgBackgroundPicture
        '
        Me.dlgBackgroundPicture.Filter = "Picture files|*.jpg;*.png;*.gif;*.bmp"
        Me.dlgBackgroundPicture.Title = "Select background picture"
        '
        'gbxBoardSize
        '
        Me.gbxBoardSize.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.gbxBoardSize.Controls.Add(Me.Label4)
        Me.gbxBoardSize.Controls.Add(Me.numCellSize)
        Me.gbxBoardSize.Controls.Add(Me.Label3)
        Me.gbxBoardSize.Controls.Add(Me.numColumns)
        Me.gbxBoardSize.Controls.Add(Me.Label2)
        Me.gbxBoardSize.Controls.Add(Me.numRows)
        Me.gbxBoardSize.Location = New System.Drawing.Point(691, 133)
        Me.gbxBoardSize.Name = "gbxBoardSize"
        Me.gbxBoardSize.Size = New System.Drawing.Size(305, 128)
        Me.gbxBoardSize.TabIndex = 2
        Me.gbxBoardSize.Text = "Board size"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cell size:"
        '
        'numCellSize
        '
        Me.numCellSize.Location = New System.Drawing.Point(91, 103)
        Me.numCellSize.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.numCellSize.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numCellSize.Name = "numCellSize"
        Me.numCellSize.Size = New System.Drawing.Size(70, 22)
        Me.numCellSize.TabIndex = 8
        Me.numCellSize.TextAlign = Wisej.Web.HorizontalAlignment.Right
        Me.numCellSize.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Columns:"
        '
        'numColumns
        '
        Me.numColumns.Location = New System.Drawing.Point(91, 66)
        Me.numColumns.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numColumns.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.numColumns.Name = "numColumns"
        Me.numColumns.Size = New System.Drawing.Size(70, 22)
        Me.numColumns.TabIndex = 6
        Me.numColumns.TextAlign = Wisej.Web.HorizontalAlignment.Right
        Me.numColumns.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Rows:"
        '
        'numRows
        '
        Me.numRows.Location = New System.Drawing.Point(91, 28)
        Me.numRows.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.numRows.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.numRows.Name = "numRows"
        Me.numRows.Size = New System.Drawing.Size(70, 22)
        Me.numRows.TabIndex = 0
        Me.numRows.TextAlign = Wisej.Web.HorizontalAlignment.Right
        Me.numRows.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'gbxBlockColors
        '
        Me.gbxBlockColors.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.gbxBlockColors.Controls.Add(Me.Label11)
        Me.gbxBlockColors.Controls.Add(Me.Label10)
        Me.gbxBlockColors.Controls.Add(Me.Label9)
        Me.gbxBlockColors.Controls.Add(Me.pnlBlock7Color)
        Me.gbxBlockColors.Controls.Add(Me.pnlBlock6Color)
        Me.gbxBlockColors.Controls.Add(Me.pnlBlock5Color)
        Me.gbxBlockColors.Controls.Add(Me.Label8)
        Me.gbxBlockColors.Controls.Add(Me.Label7)
        Me.gbxBlockColors.Controls.Add(Me.Label6)
        Me.gbxBlockColors.Controls.Add(Me.Label5)
        Me.gbxBlockColors.Controls.Add(Me.pnlBlock4Color)
        Me.gbxBlockColors.Controls.Add(Me.pnlBlock3Color)
        Me.gbxBlockColors.Controls.Add(Me.pnlBlock2Color)
        Me.gbxBlockColors.Controls.Add(Me.pnlBlock1Color)
        Me.gbxBlockColors.Location = New System.Drawing.Point(691, 267)
        Me.gbxBlockColors.Name = "gbxBlockColors"
        Me.gbxBlockColors.Size = New System.Drawing.Size(305, 145)
        Me.gbxBlockColors.TabIndex = 3
        Me.gbxBlockColors.Text = "Block colors"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(131, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 16)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Type 7 Block:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(131, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Type 6 Block:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(131, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Type 5 Block:"
        '
        'pnlBlock7Color
        '
        Me.pnlBlock7Color.BackColor = System.Drawing.Color.Purple
        Me.pnlBlock7Color.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.pnlBlock7Color.Cursor = Wisej.Web.Cursors.Hand
        Me.pnlBlock7Color.Location = New System.Drawing.Point(216, 87)
        Me.pnlBlock7Color.Name = "pnlBlock7Color"
        Me.pnlBlock7Color.Size = New System.Drawing.Size(25, 24)
        Me.pnlBlock7Color.TabIndex = 14
        Me.pnlBlock7Color.TabStop = True
        '
        'pnlBlock6Color
        '
        Me.pnlBlock6Color.BackColor = System.Drawing.Color.Yellow
        Me.pnlBlock6Color.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.pnlBlock6Color.Cursor = Wisej.Web.Cursors.Hand
        Me.pnlBlock6Color.Location = New System.Drawing.Point(216, 54)
        Me.pnlBlock6Color.Name = "pnlBlock6Color"
        Me.pnlBlock6Color.Size = New System.Drawing.Size(25, 24)
        Me.pnlBlock6Color.TabIndex = 13
        Me.pnlBlock6Color.TabStop = True
        '
        'pnlBlock5Color
        '
        Me.pnlBlock5Color.BackColor = System.Drawing.Color.Brown
        Me.pnlBlock5Color.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.pnlBlock5Color.Cursor = Wisej.Web.Cursors.Hand
        Me.pnlBlock5Color.Location = New System.Drawing.Point(216, 22)
        Me.pnlBlock5Color.Name = "pnlBlock5Color"
        Me.pnlBlock5Color.Size = New System.Drawing.Size(25, 24)
        Me.pnlBlock5Color.TabIndex = 12
        Me.pnlBlock5Color.TabStop = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Type 4 Block:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Type 3 Block:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Type 2 Block:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Type 1 Block:"
        '
        'pnlBlock4Color
        '
        Me.pnlBlock4Color.BackColor = System.Drawing.Color.Aqua
        Me.pnlBlock4Color.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.pnlBlock4Color.Cursor = Wisej.Web.Cursors.Hand
        Me.pnlBlock4Color.Location = New System.Drawing.Point(90, 119)
        Me.pnlBlock4Color.Name = "pnlBlock4Color"
        Me.pnlBlock4Color.Size = New System.Drawing.Size(25, 24)
        Me.pnlBlock4Color.TabIndex = 5
        Me.pnlBlock4Color.TabStop = True
        '
        'pnlBlock3Color
        '
        Me.pnlBlock3Color.BackColor = System.Drawing.Color.Green
        Me.pnlBlock3Color.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.pnlBlock3Color.Cursor = Wisej.Web.Cursors.Hand
        Me.pnlBlock3Color.Location = New System.Drawing.Point(90, 87)
        Me.pnlBlock3Color.Name = "pnlBlock3Color"
        Me.pnlBlock3Color.Size = New System.Drawing.Size(25, 24)
        Me.pnlBlock3Color.TabIndex = 4
        Me.pnlBlock3Color.TabStop = True
        '
        'pnlBlock2Color
        '
        Me.pnlBlock2Color.BackColor = System.Drawing.Color.Blue
        Me.pnlBlock2Color.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.pnlBlock2Color.Cursor = Wisej.Web.Cursors.Hand
        Me.pnlBlock2Color.Location = New System.Drawing.Point(90, 54)
        Me.pnlBlock2Color.Name = "pnlBlock2Color"
        Me.pnlBlock2Color.Size = New System.Drawing.Size(25, 24)
        Me.pnlBlock2Color.TabIndex = 3
        Me.pnlBlock2Color.TabStop = True
        '
        'pnlBlock1Color
        '
        Me.pnlBlock1Color.BackColor = System.Drawing.Color.Red
        Me.pnlBlock1Color.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.pnlBlock1Color.Cursor = Wisej.Web.Cursors.Hand
        Me.pnlBlock1Color.Location = New System.Drawing.Point(90, 22)
        Me.pnlBlock1Color.Name = "pnlBlock1Color"
        Me.pnlBlock1Color.Size = New System.Drawing.Size(25, 24)
        Me.pnlBlock1Color.TabIndex = 2
        Me.pnlBlock1Color.TabStop = True
        '
        'gbxKeys
        '
        Me.gbxKeys.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.gbxKeys.Controls.Add(Me.Label15)
        Me.gbxKeys.Controls.Add(Me.Label14)
        Me.gbxKeys.Controls.Add(Me.Label13)
        Me.gbxKeys.Controls.Add(Me.Label12)
        Me.gbxKeys.Controls.Add(Me.cboKeysDrop)
        Me.gbxKeys.Controls.Add(Me.cboKeysRotate)
        Me.gbxKeys.Controls.Add(Me.cboKeysRight)
        Me.gbxKeys.Controls.Add(Me.cboKeysLeft)
        Me.gbxKeys.Location = New System.Drawing.Point(691, 419)
        Me.gbxKeys.Name = "gbxKeys"
        Me.gbxKeys.Size = New System.Drawing.Size(305, 96)
        Me.gbxKeys.TabIndex = 4
        Me.gbxKeys.Text = "Keys"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(140, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Drop:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(140, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Rotate:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Right:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Left:"
        '
        'cboKeysDrop
        '
        Me.cboKeysDrop.Cursor = Wisej.Web.Cursors.Hand
        Me.cboKeysDrop.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        Me.cboKeysDrop.FormattingEnabled = True
        Me.cboKeysDrop.Location = New System.Drawing.Point(182, 66)
        Me.cboKeysDrop.Name = "cboKeysDrop"
        Me.cboKeysDrop.Size = New System.Drawing.Size(81, 22)
        Me.cboKeysDrop.Sorted = True
        Me.cboKeysDrop.TabIndex = 10
        '
        'cboKeysRotate
        '
        Me.cboKeysRotate.Cursor = Wisej.Web.Cursors.Hand
        Me.cboKeysRotate.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        Me.cboKeysRotate.FormattingEnabled = True
        Me.cboKeysRotate.Location = New System.Drawing.Point(182, 28)
        Me.cboKeysRotate.Name = "cboKeysRotate"
        Me.cboKeysRotate.Size = New System.Drawing.Size(81, 22)
        Me.cboKeysRotate.Sorted = True
        Me.cboKeysRotate.TabIndex = 9
        '
        'cboKeysRight
        '
        Me.cboKeysRight.Cursor = Wisej.Web.Cursors.Hand
        Me.cboKeysRight.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        Me.cboKeysRight.FormattingEnabled = True
        Me.cboKeysRight.Location = New System.Drawing.Point(43, 66)
        Me.cboKeysRight.Name = "cboKeysRight"
        Me.cboKeysRight.Size = New System.Drawing.Size(81, 22)
        Me.cboKeysRight.Sorted = True
        Me.cboKeysRight.TabIndex = 8
        '
        'cboKeysLeft
        '
        Me.cboKeysLeft.Cursor = Wisej.Web.Cursors.Hand
        Me.cboKeysLeft.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        Me.cboKeysLeft.FormattingEnabled = True
        Me.cboKeysLeft.Location = New System.Drawing.Point(43, 28)
        Me.cboKeysLeft.Name = "cboKeysLeft"
        Me.cboKeysLeft.Size = New System.Drawing.Size(81, 22)
        Me.cboKeysLeft.Sorted = True
        Me.cboKeysLeft.TabIndex = 7
        '
        'gbxDifficulties
        '
        Me.gbxDifficulties.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.gbxDifficulties.Controls.Add(Me.Label19)
        Me.gbxDifficulties.Controls.Add(Me.pnlUncompleteLine)
        Me.gbxDifficulties.Controls.Add(Me.Label18)
        Me.gbxDifficulties.Controls.Add(Me.numUncompleteLine)
        Me.gbxDifficulties.Controls.Add(Me.chkUncompleteLine)
        Me.gbxDifficulties.Controls.Add(Me.pnlRandomBlock)
        Me.gbxDifficulties.Controls.Add(Me.Label17)
        Me.gbxDifficulties.Controls.Add(Me.Label16)
        Me.gbxDifficulties.Controls.Add(Me.numRandomBlock)
        Me.gbxDifficulties.Controls.Add(Me.chkRandomBlock)
        Me.gbxDifficulties.Location = New System.Drawing.Point(691, 522)
        Me.gbxDifficulties.Name = "gbxDifficulties"
        Me.gbxDifficulties.Size = New System.Drawing.Size(305, 187)
        Me.gbxDifficulties.TabIndex = 5
        Me.gbxDifficulties.Text = "Difficulties"
        '
        'Label19
        '
        Me.Label19.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(17, 147)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 32)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Uncomplete lines color:"
        '
        'pnlUncompleteLine
        '
        Me.pnlUncompleteLine.BackColor = System.Drawing.Color.Orange
        Me.pnlUncompleteLine.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.pnlUncompleteLine.Cursor = Wisej.Web.Cursors.Hand
        Me.pnlUncompleteLine.Location = New System.Drawing.Point(148, 144)
        Me.pnlUncompleteLine.Name = "pnlUncompleteLine"
        Me.pnlUncompleteLine.Size = New System.Drawing.Size(25, 24)
        Me.pnlUncompleteLine.TabIndex = 18
        Me.pnlUncompleteLine.TabStop = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(236, 101)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 16)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "new blocks"
        '
        'numUncompleteLine
        '
        Me.numUncompleteLine.Location = New System.Drawing.Point(167, 98)
        Me.numUncompleteLine.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.numUncompleteLine.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.numUncompleteLine.Name = "numUncompleteLine"
        Me.numUncompleteLine.Size = New System.Drawing.Size(63, 22)
        Me.numUncompleteLine.TabIndex = 16
        Me.numUncompleteLine.TextAlign = Wisej.Web.HorizontalAlignment.Right
        Me.numUncompleteLine.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'chkUncompleteLine
        '
        Me.chkUncompleteLine.AutoSize = False
        Me.chkUncompleteLine.Cursor = Wisej.Web.Cursors.Hand
        Me.chkUncompleteLine.Location = New System.Drawing.Point(4, 94)
        Me.chkUncompleteLine.Name = "chkUncompleteLine"
        Me.chkUncompleteLine.Size = New System.Drawing.Size(135, 36)
        Me.chkUncompleteLine.TabIndex = 15
        Me.chkUncompleteLine.Text = "Add an uncomplete line every"
        '
        'pnlRandomBlock
        '
        Me.pnlRandomBlock.BackColor = System.Drawing.Color.Orange
        Me.pnlRandomBlock.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.pnlRandomBlock.Cursor = Wisej.Web.Cursors.Hand
        Me.pnlRandomBlock.Location = New System.Drawing.Point(148, 64)
        Me.pnlRandomBlock.Name = "pnlRandomBlock"
        Me.pnlRandomBlock.Size = New System.Drawing.Size(25, 24)
        Me.pnlRandomBlock.TabIndex = 14
        Me.pnlRandomBlock.TabStop = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 72)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 16)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Random blocks color:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(236, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 16)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "new blocks"
        '
        'numRandomBlock
        '
        Me.numRandomBlock.Location = New System.Drawing.Point(165, 26)
        Me.numRandomBlock.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.numRandomBlock.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.numRandomBlock.Name = "numRandomBlock"
        Me.numRandomBlock.Size = New System.Drawing.Size(65, 22)
        Me.numRandomBlock.TabIndex = 1
        Me.numRandomBlock.TextAlign = Wisej.Web.HorizontalAlignment.Right
        Me.numRandomBlock.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'chkRandomBlock
        '
        Me.chkRandomBlock.AutoSize = False
        Me.chkRandomBlock.Cursor = Wisej.Web.Cursors.Hand
        Me.chkRandomBlock.Location = New System.Drawing.Point(4, 19)
        Me.chkRandomBlock.Name = "chkRandomBlock"
        Me.chkRandomBlock.Size = New System.Drawing.Size(155, 39)
        Me.chkRandomBlock.TabIndex = 0
        Me.chkRandomBlock.Text = "Add a random single-cell block every"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.tbrSpeed)
        Me.GroupBox6.Controls.Add(Me.btnResume)
        Me.GroupBox6.Controls.Add(Me.btnPause)
        Me.GroupBox6.Controls.Add(Me.btnStop)
        Me.GroupBox6.Controls.Add(Me.btnStart)
        Me.GroupBox6.Location = New System.Drawing.Point(463, 14)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(223, 184)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.Text = "Game control"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(4, 181)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 16)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Faster"
        '
        'Label21
        '
        Me.Label21.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(147, 181)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 16)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Slower"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(4, 119)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 16)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Game speed"
        '
        'tbrSpeed
        '
        Me.tbrSpeed.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.tbrSpeed.Location = New System.Drawing.Point(4, 143)
        Me.tbrSpeed.Maximum = 1000
        Me.tbrSpeed.Minimum = 100
        Me.tbrSpeed.Name = "tbrSpeed"
        Me.tbrSpeed.Size = New System.Drawing.Size(186, 34)
        Me.tbrSpeed.TabIndex = 4
        Me.tbrSpeed.TickStyle = Wisej.Web.TickStyle.None
        Me.tbrSpeed.Value = 1000
        '
        'btnResume
        '
        Me.btnResume.Cursor = Wisej.Web.Cursors.Hand
        Me.btnResume.Enabled = False
        Me.btnResume.Location = New System.Drawing.Point(100, 70)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(85, 35)
        Me.btnResume.TabIndex = 3
        Me.btnResume.Text = "Resume"
        '
        'btnPause
        '
        Me.btnPause.Cursor = Wisej.Web.Cursors.Hand
        Me.btnPause.Enabled = False
        Me.btnPause.Location = New System.Drawing.Point(4, 70)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(86, 35)
        Me.btnPause.TabIndex = 2
        Me.btnPause.Text = "Pause"
        '
        'btnStop
        '
        Me.btnStop.Cursor = Wisej.Web.Cursors.Hand
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(100, 28)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(86, 35)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        '
        'btnStart
        '
        Me.btnStart.Cursor = Wisej.Web.Cursors.Hand
        Me.btnStart.Location = New System.Drawing.Point(4, 28)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(86, 35)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.lstEvents)
        Me.GroupBox7.Location = New System.Drawing.Point(463, 204)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(223, 505)
        Me.GroupBox7.TabIndex = 7
        Me.GroupBox7.Text = "Events"
        '
        'lstEvents
        '
        Me.lstEvents.FormattingEnabled = True
        Me.lstEvents.ItemHeight = 15
        Me.lstEvents.Location = New System.Drawing.Point(7, 28)
        Me.lstEvents.Name = "lstEvents"
        Me.lstEvents.Size = New System.Drawing.Size(180, 471)
        Me.lstEvents.TabIndex = 0
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(466, 746)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(133, 16)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Original winform project"
        '
        'lnkArticle
        '
        Me.lnkArticle.AutoSize = True
        Me.lnkArticle.Location = New System.Drawing.Point(605, 746)
        Me.lnkArticle.Name = "lnkArticle"
        Me.lnkArticle.Size = New System.Drawing.Size(259, 16)
        Me.lnkArticle.TabIndex = 9
        Me.lnkArticle.Text = "Codeproject Create Falling Blocks games in .NET"
        '
        'linkWiseJ
        '
        Me.linkWiseJ.AutoSize = True
        Me.linkWiseJ.Font = New System.Drawing.Font("@windowTitle", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.linkWiseJ.LinkArea = New Wisej.Web.LinkArea(0, 16)
        Me.linkWiseJ.Location = New System.Drawing.Point(466, 721)
        Me.linkWiseJ.Name = "linkWiseJ"
        Me.linkWiseJ.Size = New System.Drawing.Size(133, 19)
        Me.linkWiseJ.TabIndex = 11
        Me.linkWiseJ.Text = "More about WiseJ"
        '
        'TetrisBox1
        '
        Me.TetrisBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.TetrisBox1.Location = New System.Drawing.Point(10, 14)
        Me.TetrisBox1.Name = "TetrisBox1"
        Me.TetrisBox1.RandomBlockColor = System.Drawing.Color.Orange
        Me.TetrisBox1.Size = New System.Drawing.Size(241, 481)
        Me.TetrisBox1.UncompleteRowColor = System.Drawing.Color.Orange
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 980)
        Me.Controls.Add(Me.linkWiseJ)
        Me.Controls.Add(Me.lnkArticle)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.gbxDifficulties)
        Me.Controls.Add(Me.gbxKeys)
        Me.Controls.Add(Me.gbxBlockColors)
        Me.Controls.Add(Me.gbxBoardSize)
        Me.Controls.Add(Me.gbxBackground)
        Me.Controls.Add(Me.TetrisBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.Text = "TetrisBox Test"
        Me.gbxBackground.ResumeLayout(False)
        Me.gbxBackground.PerformLayout()
        Me.gbxBoardSize.ResumeLayout(False)
        Me.gbxBoardSize.PerformLayout()
        CType(Me.numCellSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBlockColors.ResumeLayout(False)
        Me.gbxBlockColors.PerformLayout()
        Me.gbxKeys.ResumeLayout(False)
        Me.gbxKeys.PerformLayout()
        Me.gbxDifficulties.ResumeLayout(False)
        Me.gbxDifficulties.PerformLayout()
        CType(Me.numUncompleteLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRandomBlock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.tbrSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.TetrisBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TetrisBox1 As TetrisBoxWisej.TetrisBox
    Friend WithEvents gbxBackground As Wisej.Web.GroupBox
    Friend WithEvents radBackgroundSolid As Wisej.Web.RadioButton
    Friend WithEvents lnkBackgroundPicture As Wisej.Web.LinkLabel
    Friend WithEvents radBackgroundPicture As Wisej.Web.RadioButton
    Friend WithEvents cboGradientDirection As Wisej.Web.ComboBox
    Friend WithEvents pnlBackgroundGradient2 As Wisej.Web.Panel
    Friend WithEvents Label1 As Wisej.Web.Label
    Friend WithEvents pnlBackgroundGradient1 As Wisej.Web.Panel
    Friend WithEvents radBackgroundGradient As Wisej.Web.RadioButton
    Friend WithEvents pnlBackgroundSolid As Wisej.Web.Panel
    Friend WithEvents dlgBackgroundPicture As Wisej.Web.OpenFileDialog
    Friend WithEvents dlgColor As Wisej.Web.ColorDialog
    Friend WithEvents gbxBoardSize As Wisej.Web.GroupBox
    Friend WithEvents Label4 As Wisej.Web.Label
    Friend WithEvents numCellSize As Wisej.Web.NumericUpDown
    Friend WithEvents Label3 As Wisej.Web.Label
    Friend WithEvents numColumns As Wisej.Web.NumericUpDown
    Friend WithEvents Label2 As Wisej.Web.Label
    Friend WithEvents numRows As Wisej.Web.NumericUpDown
    Friend WithEvents gbxBlockColors As Wisej.Web.GroupBox
    Friend WithEvents Label11 As Wisej.Web.Label
    Friend WithEvents Label10 As Wisej.Web.Label
    Friend WithEvents Label9 As Wisej.Web.Label
    Friend WithEvents pnlBlock7Color As Wisej.Web.Panel
    Friend WithEvents pnlBlock6Color As Wisej.Web.Panel
    Friend WithEvents pnlBlock5Color As Wisej.Web.Panel
    Friend WithEvents Label8 As Wisej.Web.Label
    Friend WithEvents Label7 As Wisej.Web.Label
    Friend WithEvents Label6 As Wisej.Web.Label
    Friend WithEvents Label5 As Wisej.Web.Label
    Friend WithEvents pnlBlock4Color As Wisej.Web.Panel
    Friend WithEvents pnlBlock3Color As Wisej.Web.Panel
    Friend WithEvents pnlBlock2Color As Wisej.Web.Panel
    Friend WithEvents pnlBlock1Color As Wisej.Web.Panel
    Friend WithEvents gbxKeys As Wisej.Web.GroupBox
    Friend WithEvents Label15 As Wisej.Web.Label
    Friend WithEvents Label14 As Wisej.Web.Label
    Friend WithEvents Label13 As Wisej.Web.Label
    Friend WithEvents Label12 As Wisej.Web.Label
    Friend WithEvents cboKeysDrop As Wisej.Web.ComboBox
    Friend WithEvents cboKeysRotate As Wisej.Web.ComboBox
    Friend WithEvents cboKeysRight As Wisej.Web.ComboBox
    Friend WithEvents cboKeysLeft As Wisej.Web.ComboBox
    Friend WithEvents gbxDifficulties As Wisej.Web.GroupBox
    Friend WithEvents numRandomBlock As Wisej.Web.NumericUpDown
    Friend WithEvents chkRandomBlock As Wisej.Web.CheckBox
    Friend WithEvents Label16 As Wisej.Web.Label
    Friend WithEvents pnlRandomBlock As Wisej.Web.Panel
    Friend WithEvents Label17 As Wisej.Web.Label
    Friend WithEvents Label18 As Wisej.Web.Label
    Friend WithEvents numUncompleteLine As Wisej.Web.NumericUpDown
    Friend WithEvents chkUncompleteLine As Wisej.Web.CheckBox
    Friend WithEvents Label19 As Wisej.Web.Label
    Friend WithEvents pnlUncompleteLine As Wisej.Web.Panel
    Friend WithEvents GroupBox6 As Wisej.Web.GroupBox
    Friend WithEvents btnResume As Wisej.Web.Button
    Friend WithEvents btnPause As Wisej.Web.Button
    Friend WithEvents btnStop As Wisej.Web.Button
    Friend WithEvents btnStart As Wisej.Web.Button
    Friend WithEvents Label22 As Wisej.Web.Label
    Friend WithEvents Label21 As Wisej.Web.Label
    Friend WithEvents Label20 As Wisej.Web.Label
    Friend WithEvents tbrSpeed As Wisej.Web.TrackBar
    Friend WithEvents GroupBox7 As Wisej.Web.GroupBox
    Friend WithEvents lstEvents As Wisej.Web.ListBox
    Friend WithEvents Label23 As Wisej.Web.Label
    Friend WithEvents lnkArticle As Wisej.Web.LinkLabel
    Friend WithEvents linkWiseJ As LinkLabel
End Class
