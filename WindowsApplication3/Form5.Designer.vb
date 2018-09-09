<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RedClr = New System.Windows.Forms.TrackBar()
        Me.GreenClr = New System.Windows.Forms.TrackBar()
        Me.BlueClr = New System.Windows.Forms.TrackBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WhiteClrBtn = New System.Windows.Forms.Button()
        Me.BlackClrBtn = New System.Windows.Forms.Button()
        Me.MagentaClrBtn = New System.Windows.Forms.Button()
        Me.CyanClrBtn = New System.Windows.Forms.Button()
        Me.GreenClrBtn = New System.Windows.Forms.Button()
        Me.BlueClrBtn = New System.Windows.Forms.Button()
        Me.YellowClrBtn = New System.Windows.Forms.Button()
        Me.orangeClrBtn = New System.Windows.Forms.Button()
        Me.RedClrBtn = New System.Windows.Forms.Button()
        Me.SilverClrBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnClr = New System.Windows.Forms.Button()
        Me.RedNumClr = New System.Windows.Forms.NumericUpDown()
        Me.GreenNumClr = New System.Windows.Forms.NumericUpDown()
        Me.BlueNumClr = New System.Windows.Forms.NumericUpDown()
        CType(Me.RedClr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreenClr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueClr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RedNumClr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreenNumClr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueNumClr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RedClr
        '
        Me.RedClr.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RedClr.Location = New System.Drawing.Point(36, 19)
        Me.RedClr.Maximum = 255
        Me.RedClr.Name = "RedClr"
        Me.RedClr.Size = New System.Drawing.Size(679, 45)
        Me.RedClr.TabIndex = 0
        '
        'GreenClr
        '
        Me.GreenClr.Location = New System.Drawing.Point(36, 66)
        Me.GreenClr.Maximum = 255
        Me.GreenClr.Name = "GreenClr"
        Me.GreenClr.Size = New System.Drawing.Size(679, 45)
        Me.GreenClr.TabIndex = 1
        '
        'BlueClr
        '
        Me.BlueClr.Location = New System.Drawing.Point(36, 113)
        Me.BlueClr.Maximum = 255
        Me.BlueClr.Name = "BlueClr"
        Me.BlueClr.Size = New System.Drawing.Size(679, 45)
        Me.BlueClr.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.WhiteClrBtn)
        Me.GroupBox1.Controls.Add(Me.BlackClrBtn)
        Me.GroupBox1.Controls.Add(Me.MagentaClrBtn)
        Me.GroupBox1.Controls.Add(Me.CyanClrBtn)
        Me.GroupBox1.Controls.Add(Me.GreenClrBtn)
        Me.GroupBox1.Controls.Add(Me.BlueClrBtn)
        Me.GroupBox1.Controls.Add(Me.YellowClrBtn)
        Me.GroupBox1.Controls.Add(Me.orangeClrBtn)
        Me.GroupBox1.Controls.Add(Me.RedClrBtn)
        Me.GroupBox1.Controls.Add(Me.SilverClrBtn)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnClr)
        Me.GroupBox1.Controls.Add(Me.BlueClr)
        Me.GroupBox1.Controls.Add(Me.RedClr)
        Me.GroupBox1.Controls.Add(Me.GreenClr)
        Me.GroupBox1.Controls.Add(Me.RedNumClr)
        Me.GroupBox1.Controls.Add(Me.GreenNumClr)
        Me.GroupBox1.Controls.Add(Me.BlueNumClr)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(721, 319)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RGB Color"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Basic color : "
        '
        'WhiteClrBtn
        '
        Me.WhiteClrBtn.BackColor = System.Drawing.Color.White
        Me.WhiteClrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WhiteClrBtn.Location = New System.Drawing.Point(486, 173)
        Me.WhiteClrBtn.Name = "WhiteClrBtn"
        Me.WhiteClrBtn.Size = New System.Drawing.Size(38, 28)
        Me.WhiteClrBtn.TabIndex = 16
        Me.WhiteClrBtn.UseVisualStyleBackColor = False
        '
        'BlackClrBtn
        '
        Me.BlackClrBtn.BackColor = System.Drawing.Color.Black
        Me.BlackClrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BlackClrBtn.Location = New System.Drawing.Point(442, 173)
        Me.BlackClrBtn.Name = "BlackClrBtn"
        Me.BlackClrBtn.Size = New System.Drawing.Size(38, 28)
        Me.BlackClrBtn.TabIndex = 15
        Me.BlackClrBtn.UseVisualStyleBackColor = False
        '
        'MagentaClrBtn
        '
        Me.MagentaClrBtn.BackColor = System.Drawing.Color.Magenta
        Me.MagentaClrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MagentaClrBtn.Location = New System.Drawing.Point(398, 173)
        Me.MagentaClrBtn.Name = "MagentaClrBtn"
        Me.MagentaClrBtn.Size = New System.Drawing.Size(38, 28)
        Me.MagentaClrBtn.TabIndex = 14
        Me.MagentaClrBtn.UseVisualStyleBackColor = False
        '
        'CyanClrBtn
        '
        Me.CyanClrBtn.BackColor = System.Drawing.Color.Cyan
        Me.CyanClrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CyanClrBtn.Location = New System.Drawing.Point(354, 173)
        Me.CyanClrBtn.Name = "CyanClrBtn"
        Me.CyanClrBtn.Size = New System.Drawing.Size(38, 28)
        Me.CyanClrBtn.TabIndex = 13
        Me.CyanClrBtn.UseVisualStyleBackColor = False
        '
        'GreenClrBtn
        '
        Me.GreenClrBtn.BackColor = System.Drawing.Color.Green
        Me.GreenClrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GreenClrBtn.Location = New System.Drawing.Point(310, 173)
        Me.GreenClrBtn.Name = "GreenClrBtn"
        Me.GreenClrBtn.Size = New System.Drawing.Size(38, 28)
        Me.GreenClrBtn.TabIndex = 12
        Me.GreenClrBtn.UseVisualStyleBackColor = False
        '
        'BlueClrBtn
        '
        Me.BlueClrBtn.BackColor = System.Drawing.Color.Blue
        Me.BlueClrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BlueClrBtn.Location = New System.Drawing.Point(266, 173)
        Me.BlueClrBtn.Name = "BlueClrBtn"
        Me.BlueClrBtn.Size = New System.Drawing.Size(38, 28)
        Me.BlueClrBtn.TabIndex = 11
        Me.BlueClrBtn.UseVisualStyleBackColor = False
        '
        'YellowClrBtn
        '
        Me.YellowClrBtn.BackColor = System.Drawing.Color.Yellow
        Me.YellowClrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YellowClrBtn.Location = New System.Drawing.Point(222, 173)
        Me.YellowClrBtn.Name = "YellowClrBtn"
        Me.YellowClrBtn.Size = New System.Drawing.Size(38, 28)
        Me.YellowClrBtn.TabIndex = 10
        Me.YellowClrBtn.UseVisualStyleBackColor = False
        '
        'orangeClrBtn
        '
        Me.orangeClrBtn.BackColor = System.Drawing.Color.Orange
        Me.orangeClrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.orangeClrBtn.Location = New System.Drawing.Point(178, 173)
        Me.orangeClrBtn.Name = "orangeClrBtn"
        Me.orangeClrBtn.Size = New System.Drawing.Size(38, 28)
        Me.orangeClrBtn.TabIndex = 9
        Me.orangeClrBtn.UseVisualStyleBackColor = False
        '
        'RedClrBtn
        '
        Me.RedClrBtn.BackColor = System.Drawing.Color.Red
        Me.RedClrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RedClrBtn.Location = New System.Drawing.Point(134, 173)
        Me.RedClrBtn.Name = "RedClrBtn"
        Me.RedClrBtn.Size = New System.Drawing.Size(38, 28)
        Me.RedClrBtn.TabIndex = 8
        Me.RedClrBtn.UseVisualStyleBackColor = False
        '
        'SilverClrBtn
        '
        Me.SilverClrBtn.BackColor = System.Drawing.Color.Silver
        Me.SilverClrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SilverClrBtn.Location = New System.Drawing.Point(90, 173)
        Me.SilverClrBtn.Name = "SilverClrBtn"
        Me.SilverClrBtn.Size = New System.Drawing.Size(38, 28)
        Me.SilverClrBtn.TabIndex = 7
        Me.SilverClrBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(296, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnClr
        '
        Me.BtnClr.BackColor = System.Drawing.Color.Black
        Me.BtnClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClr.Location = New System.Drawing.Point(640, 216)
        Me.BtnClr.Name = "BtnClr"
        Me.BtnClr.Size = New System.Drawing.Size(75, 32)
        Me.BtnClr.TabIndex = 6
        Me.BtnClr.UseVisualStyleBackColor = False
        '
        'RedNumClr
        '
        Me.RedNumClr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RedNumClr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedNumClr.Location = New System.Drawing.Point(6, 28)
        Me.RedNumClr.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.RedNumClr.Name = "RedNumClr"
        Me.RedNumClr.Size = New System.Drawing.Size(48, 16)
        Me.RedNumClr.TabIndex = 3
        '
        'GreenNumClr
        '
        Me.GreenNumClr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GreenNumClr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreenNumClr.Location = New System.Drawing.Point(6, 75)
        Me.GreenNumClr.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.GreenNumClr.Name = "GreenNumClr"
        Me.GreenNumClr.Size = New System.Drawing.Size(48, 16)
        Me.GreenNumClr.TabIndex = 4
        '
        'BlueNumClr
        '
        Me.BlueNumClr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BlueNumClr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlueNumClr.Location = New System.Drawing.Point(6, 122)
        Me.BlueNumClr.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.BlueNumClr.Name = "BlueNumClr"
        Me.BlueNumClr.Size = New System.Drawing.Size(48, 16)
        Me.BlueNumClr.TabIndex = 5
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(725, 321)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RGB Color"
        CType(Me.RedClr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GreenClr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueClr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RedNumClr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GreenNumClr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueNumClr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RedClr As System.Windows.Forms.TrackBar
    Friend WithEvents GreenClr As System.Windows.Forms.TrackBar
    Friend WithEvents BlueClr As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClr As System.Windows.Forms.Button
    Friend WithEvents RedNumClr As System.Windows.Forms.NumericUpDown
    Friend WithEvents GreenNumClr As System.Windows.Forms.NumericUpDown
    Friend WithEvents BlueNumClr As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WhiteClrBtn As System.Windows.Forms.Button
    Friend WithEvents BlackClrBtn As System.Windows.Forms.Button
    Friend WithEvents MagentaClrBtn As System.Windows.Forms.Button
    Friend WithEvents CyanClrBtn As System.Windows.Forms.Button
    Friend WithEvents GreenClrBtn As System.Windows.Forms.Button
    Friend WithEvents BlueClrBtn As System.Windows.Forms.Button
    Friend WithEvents YellowClrBtn As System.Windows.Forms.Button
    Friend WithEvents orangeClrBtn As System.Windows.Forms.Button
    Friend WithEvents RedClrBtn As System.Windows.Forms.Button
    Friend WithEvents SilverClrBtn As System.Windows.Forms.Button
End Class
