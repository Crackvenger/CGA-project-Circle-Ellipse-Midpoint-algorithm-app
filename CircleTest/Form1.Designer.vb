﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.pbDrawing = New System.Windows.Forms.PictureBox()
        Me.btnCircle = New System.Windows.Forms.Button()
        Me.tbRadius = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbY = New System.Windows.Forms.TextBox()
        Me.tbX = New System.Windows.Forms.TextBox()
        Me.lblYcenter = New System.Windows.Forms.Label()
        Me.lblXcenter = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboShape = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEllipse = New System.Windows.Forms.Button()
        Me.ComboSize = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboColor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbRadiusY = New System.Windows.Forms.TextBox()
        Me.tbRadiusX = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lvData = New System.Windows.Forms.ListView()
        Me.ColumnHeaderX = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderY = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderShape = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderRadius = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderRadiusX = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderRadiusY = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderColor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClearScreen = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SaveLoadData = New System.Windows.Forms.MenuStrip()
        Me.ClickMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveYourDataHereToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadYourDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.fileNameTb = New System.Windows.Forms.TextBox()
        Me.fullPathTb = New System.Windows.Forms.TextBox()
        Me.directoryFileTb = New System.Windows.Forms.TextBox()
        CType(Me.pbDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SaveLoadData.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbDrawing
        '
        Me.pbDrawing.BackColor = System.Drawing.Color.White
        Me.pbDrawing.Location = New System.Drawing.Point(0, 42)
        Me.pbDrawing.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pbDrawing.Name = "pbDrawing"
        Me.pbDrawing.Size = New System.Drawing.Size(1204, 690)
        Me.pbDrawing.TabIndex = 1
        Me.pbDrawing.TabStop = False
        '
        'btnCircle
        '
        Me.btnCircle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCircle.Location = New System.Drawing.Point(593, 165)
        Me.btnCircle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCircle.Name = "btnCircle"
        Me.btnCircle.Size = New System.Drawing.Size(89, 39)
        Me.btnCircle.TabIndex = 6
        Me.btnCircle.Text = "Circle"
        Me.btnCircle.UseVisualStyleBackColor = True
        '
        'tbRadius
        '
        Me.tbRadius.Font = New System.Drawing.Font("Myanmar Text", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbRadius.Location = New System.Drawing.Point(116, 146)
        Me.tbRadius.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbRadius.Name = "tbRadius"
        Me.tbRadius.Size = New System.Drawing.Size(115, 38)
        Me.tbRadius.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Radius"
        '
        'tbY
        '
        Me.tbY.Font = New System.Drawing.Font("Myanmar Text", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbY.Location = New System.Drawing.Point(116, 90)
        Me.tbY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbY.Name = "tbY"
        Me.tbY.Size = New System.Drawing.Size(115, 38)
        Me.tbY.TabIndex = 3
        '
        'tbX
        '
        Me.tbX.Font = New System.Drawing.Font("Myanmar Text", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbX.Location = New System.Drawing.Point(116, 32)
        Me.tbX.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbX.Name = "tbX"
        Me.tbX.Size = New System.Drawing.Size(115, 38)
        Me.tbX.TabIndex = 2
        '
        'lblYcenter
        '
        Me.lblYcenter.AutoSize = True
        Me.lblYcenter.Location = New System.Drawing.Point(51, 90)
        Me.lblYcenter.Name = "lblYcenter"
        Me.lblYcenter.Size = New System.Drawing.Size(26, 32)
        Me.lblYcenter.TabIndex = 1
        Me.lblYcenter.Text = "Y"
        '
        'lblXcenter
        '
        Me.lblXcenter.AutoSize = True
        Me.lblXcenter.Location = New System.Drawing.Point(51, 35)
        Me.lblXcenter.Name = "lblXcenter"
        Me.lblXcenter.Size = New System.Drawing.Size(27, 32)
        Me.lblXcenter.TabIndex = 0
        Me.lblXcenter.Text = "X"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboShape)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnEllipse)
        Me.GroupBox1.Controls.Add(Me.ComboSize)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboColor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbRadiusY)
        Me.GroupBox1.Controls.Add(Me.btnCircle)
        Me.GroupBox1.Controls.Add(Me.tbRadiusX)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbX)
        Me.GroupBox1.Controls.Add(Me.lblXcenter)
        Me.GroupBox1.Controls.Add(Me.lblYcenter)
        Me.GroupBox1.Controls.Add(Me.tbY)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbRadius)
        Me.GroupBox1.Font = New System.Drawing.Font("Myanmar Text", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(92, 739)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(756, 256)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fill The Box"
        '
        'ComboShape
        '
        Me.ComboShape.Font = New System.Drawing.Font("Myanmar Text", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ComboShape.FormattingEnabled = True
        Me.ComboShape.Items.AddRange(New Object() {"Circle", "Ellipse"})
        Me.ComboShape.Location = New System.Drawing.Point(116, 200)
        Me.ComboShape.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboShape.Name = "ComboShape"
        Me.ComboShape.Size = New System.Drawing.Size(115, 37)
        Me.ComboShape.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 32)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Shape"
        '
        'btnEllipse
        '
        Me.btnEllipse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEllipse.Location = New System.Drawing.Point(593, 86)
        Me.btnEllipse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEllipse.Name = "btnEllipse"
        Me.btnEllipse.Size = New System.Drawing.Size(89, 39)
        Me.btnEllipse.TabIndex = 11
        Me.btnEllipse.Text = "Ellipse"
        Me.btnEllipse.UseVisualStyleBackColor = True
        '
        'ComboSize
        '
        Me.ComboSize.Font = New System.Drawing.Font("Myanmar Text", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ComboSize.FormattingEnabled = True
        Me.ComboSize.Location = New System.Drawing.Point(396, 200)
        Me.ComboSize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboSize.Name = "ComboSize"
        Me.ComboSize.Size = New System.Drawing.Size(115, 37)
        Me.ComboSize.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(315, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 32)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Size"
        '
        'ComboColor
        '
        Me.ComboColor.Font = New System.Drawing.Font("Myanmar Text", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ComboColor.FormattingEnabled = True
        Me.ComboColor.Location = New System.Drawing.Point(396, 140)
        Me.ComboColor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboColor.Name = "ComboColor"
        Me.ComboColor.Size = New System.Drawing.Size(115, 37)
        Me.ComboColor.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 32)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Color"
        '
        'tbRadiusY
        '
        Me.tbRadiusY.Font = New System.Drawing.Font("Myanmar Text", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbRadiusY.Location = New System.Drawing.Point(396, 93)
        Me.tbRadiusY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbRadiusY.Name = "tbRadiusY"
        Me.tbRadiusY.Size = New System.Drawing.Size(115, 38)
        Me.tbRadiusY.TabIndex = 12
        '
        'tbRadiusX
        '
        Me.tbRadiusX.Font = New System.Drawing.Font("Myanmar Text", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbRadiusX.Location = New System.Drawing.Point(396, 32)
        Me.tbRadiusX.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbRadiusX.Name = "tbRadiusX"
        Me.tbRadiusX.Size = New System.Drawing.Size(115, 38)
        Me.tbRadiusX.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(287, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 32)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Y Radius"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(286, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 32)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "X Radius"
        '
        'lvData
        '
        Me.lvData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderX, Me.ColumnHeaderY, Me.ColumnHeaderShape, Me.ColumnHeaderRadius, Me.ColumnHeaderRadiusX, Me.ColumnHeaderRadiusY, Me.ColumnHeaderColor, Me.ColumnHeaderSize})
        Me.lvData.ForeColor = System.Drawing.Color.Black
        Me.lvData.HideSelection = False
        Me.lvData.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lvData.Location = New System.Drawing.Point(1218, 112)
        Me.lvData.Name = "lvData"
        Me.lvData.Size = New System.Drawing.Size(567, 342)
        Me.lvData.TabIndex = 10
        Me.lvData.UseCompatibleStateImageBehavior = False
        Me.lvData.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderX
        '
        Me.ColumnHeaderX.Text = "X"
        '
        'ColumnHeaderY
        '
        Me.ColumnHeaderY.Text = "Y"
        '
        'ColumnHeaderShape
        '
        Me.ColumnHeaderShape.Text = "Shape"
        '
        'ColumnHeaderRadius
        '
        Me.ColumnHeaderRadius.Text = "Radius"
        '
        'ColumnHeaderRadiusX
        '
        Me.ColumnHeaderRadiusX.Text = "Radius X"
        '
        'ColumnHeaderRadiusY
        '
        Me.ColumnHeaderRadiusY.Text = "Radius Y"
        '
        'ColumnHeaderColor
        '
        Me.ColumnHeaderColor.Text = "Color"
        '
        'ColumnHeaderSize
        '
        Me.ColumnHeaderSize.Text = "Size"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClearScreen)
        Me.GroupBox2.Controls.Add(Me.btnRefresh)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Font = New System.Drawing.Font("Myanmar Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(925, 782)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(395, 194)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controler"
        '
        'btnClearScreen
        '
        Me.btnClearScreen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClearScreen.Font = New System.Drawing.Font("Myanmar Text", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnClearScreen.Location = New System.Drawing.Point(189, 122)
        Me.btnClearScreen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClearScreen.Name = "btnClearScreen"
        Me.btnClearScreen.Size = New System.Drawing.Size(120, 33)
        Me.btnClearScreen.TabIndex = 10
        Me.btnClearScreen.Text = "Clear Screen"
        Me.btnClearScreen.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRefresh.Font = New System.Drawing.Font("Myanmar Text", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnRefresh.Location = New System.Drawing.Point(203, 54)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(89, 33)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.Font = New System.Drawing.Font("Myanmar Text", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnUpdate.Location = New System.Drawing.Point(58, 124)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(89, 33)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.Font = New System.Drawing.Font("Myanmar Text", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnDelete.Location = New System.Drawing.Point(58, 54)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 33)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'SaveLoadData
        '
        Me.SaveLoadData.BackColor = System.Drawing.Color.DarkSalmon
        Me.SaveLoadData.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.SaveLoadData.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.SaveLoadData.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClickMeToolStripMenuItem})
        Me.SaveLoadData.Location = New System.Drawing.Point(0, 0)
        Me.SaveLoadData.Name = "SaveLoadData"
        Me.SaveLoadData.Size = New System.Drawing.Size(1797, 38)
        Me.SaveLoadData.TabIndex = 18
        Me.SaveLoadData.Text = "MenuStrip1"
        '
        'ClickMeToolStripMenuItem
        '
        Me.ClickMeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ClickMeToolStripMenuItem.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClickMeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveYourDataHereToolStripMenuItem, Me.LoadYourDataToolStripMenuItem})
        Me.ClickMeToolStripMenuItem.Font = New System.Drawing.Font("Segoe Script", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClickMeToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick
        Me.ClickMeToolStripMenuItem.Name = "ClickMeToolStripMenuItem"
        Me.ClickMeToolStripMenuItem.Size = New System.Drawing.Size(119, 34)
        Me.ClickMeToolStripMenuItem.Text = "Click Me "
        '
        'SaveYourDataHereToolStripMenuItem
        '
        Me.SaveYourDataHereToolStripMenuItem.Name = "SaveYourDataHereToolStripMenuItem"
        Me.SaveYourDataHereToolStripMenuItem.Size = New System.Drawing.Size(311, 38)
        Me.SaveYourDataHereToolStripMenuItem.Text = "Save Your Data Here"
        '
        'LoadYourDataToolStripMenuItem
        '
        Me.LoadYourDataToolStripMenuItem.Name = "LoadYourDataToolStripMenuItem"
        Me.LoadYourDataToolStripMenuItem.Size = New System.Drawing.Size(311, 38)
        Me.LoadYourDataToolStripMenuItem.Text = "Load Your Data"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Myanmar Text", 7.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(1218, 565)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 25)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "File Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Myanmar Text", 7.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(1218, 641)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 25)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Full Path"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Myanmar Text", 7.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(1218, 483)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 25)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Directory File"
        '
        'fileNameTb
        '
        Me.fileNameTb.Location = New System.Drawing.Point(1223, 595)
        Me.fileNameTb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fileNameTb.Name = "fileNameTb"
        Me.fileNameTb.Size = New System.Drawing.Size(554, 26)
        Me.fileNameTb.TabIndex = 78
        '
        'fullPathTb
        '
        Me.fullPathTb.Location = New System.Drawing.Point(1223, 671)
        Me.fullPathTb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fullPathTb.Name = "fullPathTb"
        Me.fullPathTb.Size = New System.Drawing.Size(554, 26)
        Me.fullPathTb.TabIndex = 77
        '
        'directoryFileTb
        '
        Me.directoryFileTb.Location = New System.Drawing.Point(1223, 513)
        Me.directoryFileTb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.directoryFileTb.Name = "directoryFileTb"
        Me.directoryFileTb.Size = New System.Drawing.Size(554, 26)
        Me.directoryFileTb.TabIndex = 76
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(1797, 1034)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.fileNameTb)
        Me.Controls.Add(Me.fullPathTb)
        Me.Controls.Add(Me.directoryFileTb)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lvData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbDrawing)
        Me.Controls.Add(Me.SaveLoadData)
        Me.MainMenuStrip = Me.SaveLoadData
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Circle and Ellipse"
        CType(Me.pbDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.SaveLoadData.ResumeLayout(False)
        Me.SaveLoadData.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbDrawing As PictureBox
    Friend WithEvents tbY As TextBox
    Friend WithEvents tbX As TextBox
    Friend WithEvents lblYcenter As Label
    Friend WithEvents lblXcenter As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbRadius As TextBox
    Friend WithEvents btnCircle As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboSize As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboColor As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbRadiusY As TextBox
    Friend WithEvents tbRadiusX As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lvData As ListView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnClearScreen As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents SaveLoadData As MenuStrip
    Friend WithEvents ClickMeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveYourDataHereToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadYourDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents fileNameTb As TextBox
    Friend WithEvents fullPathTb As TextBox
    Friend WithEvents directoryFileTb As TextBox
    Friend WithEvents btnEllipse As Button
    Friend WithEvents ComboShape As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ColumnHeaderX As ColumnHeader
    Friend WithEvents ColumnHeaderY As ColumnHeader
    Friend WithEvents ColumnHeaderShape As ColumnHeader
    Friend WithEvents ColumnHeaderRadius As ColumnHeader
    Friend WithEvents ColumnHeaderRadiusX As ColumnHeader
    Friend WithEvents ColumnHeaderRadiusY As ColumnHeader
    Friend WithEvents ColumnHeaderColor As ColumnHeader
    Friend WithEvents ColumnHeaderSize As ColumnHeader
End Class
