<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.btnCircle = New System.Windows.Forms.Button()
        Me.pbDrawing = New System.Windows.Forms.PictureBox()
        Me.btnElipse = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.tbRadius = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbY = New System.Windows.Forms.TextBox()
        Me.tbX = New System.Windows.Forms.TextBox()
        Me.lblYcenter = New System.Windows.Forms.Label()
        Me.lblXcenter = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        CType(Me.pbDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCircle
        '
        Me.btnCircle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCircle.Location = New System.Drawing.Point(1056, 774)
        Me.btnCircle.Name = "btnCircle"
        Me.btnCircle.Size = New System.Drawing.Size(136, 60)
        Me.btnCircle.TabIndex = 0
        Me.btnCircle.Text = "Circle"
        Me.btnCircle.UseVisualStyleBackColor = True
        '
        'pbDrawing
        '
        Me.pbDrawing.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbDrawing.BackColor = System.Drawing.Color.White
        Me.pbDrawing.Location = New System.Drawing.Point(520, 35)
        Me.pbDrawing.Name = "pbDrawing"
        Me.pbDrawing.Size = New System.Drawing.Size(1022, 716)
        Me.pbDrawing.TabIndex = 1
        Me.pbDrawing.TabStop = False
        '
        'btnElipse
        '
        Me.btnElipse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnElipse.Location = New System.Drawing.Point(1259, 774)
        Me.btnElipse.Name = "btnElipse"
        Me.btnElipse.Size = New System.Drawing.Size(143, 60)
        Me.btnElipse.TabIndex = 2
        Me.btnElipse.Text = "Elipse"
        Me.btnElipse.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.btnDraw)
        Me.Panel1.Controls.Add(Me.tbRadius)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tbY)
        Me.Panel1.Controls.Add(Me.tbX)
        Me.Panel1.Controls.Add(Me.lblYcenter)
        Me.Panel1.Controls.Add(Me.lblXcenter)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 855)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Shape"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Circle", "Elipse"})
        Me.ComboBox1.Location = New System.Drawing.Point(222, 105)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(120, 28)
        Me.ComboBox1.TabIndex = 7
        '
        'btnDraw
        '
        Me.btnDraw.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDraw.Location = New System.Drawing.Point(142, 203)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(94, 38)
        Me.btnDraw.TabIndex = 6
        Me.btnDraw.Text = "Draw"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'tbRadius
        '
        Me.tbRadius.Location = New System.Drawing.Point(222, 56)
        Me.tbRadius.Name = "tbRadius"
        Me.tbRadius.Size = New System.Drawing.Size(74, 26)
        Me.tbRadius.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Radius"
        '
        'tbY
        '
        Me.tbY.Location = New System.Drawing.Point(68, 108)
        Me.tbY.Name = "tbY"
        Me.tbY.Size = New System.Drawing.Size(74, 26)
        Me.tbY.TabIndex = 3
        '
        'tbX
        '
        Me.tbX.Location = New System.Drawing.Point(68, 56)
        Me.tbX.Name = "tbX"
        Me.tbX.Size = New System.Drawing.Size(74, 26)
        Me.tbX.TabIndex = 2
        '
        'lblYcenter
        '
        Me.lblYcenter.AutoSize = True
        Me.lblYcenter.Location = New System.Drawing.Point(33, 108)
        Me.lblYcenter.Name = "lblYcenter"
        Me.lblYcenter.Size = New System.Drawing.Size(19, 20)
        Me.lblYcenter.TabIndex = 1
        Me.lblYcenter.Text = "Y"
        '
        'lblXcenter
        '
        Me.lblXcenter.AutoSize = True
        Me.lblXcenter.Location = New System.Drawing.Point(33, 56)
        Me.lblXcenter.Name = "lblXcenter"
        Me.lblXcenter.Size = New System.Drawing.Size(20, 20)
        Me.lblXcenter.TabIndex = 0
        Me.lblXcenter.Text = "X"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblX.Location = New System.Drawing.Point(554, 774)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(30, 17)
        Me.lblX.TabIndex = 4
        Me.lblX.Text = "X - "
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblY.Location = New System.Drawing.Point(554, 817)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(30, 17)
        Me.lblY.TabIndex = 5
        Me.lblY.Text = "Y - "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(1597, 855)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnElipse)
        Me.Controls.Add(Me.pbDrawing)
        Me.Controls.Add(Me.btnCircle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCircle As Button
    Friend WithEvents pbDrawing As PictureBox
    Friend WithEvents btnElipse As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbY As TextBox
    Friend WithEvents tbX As TextBox
    Friend WithEvents lblYcenter As Label
    Friend WithEvents lblXcenter As Label
    Friend WithEvents lblX As Label
    Friend WithEvents lblY As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbRadius As TextBox
    Friend WithEvents btnDraw As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
