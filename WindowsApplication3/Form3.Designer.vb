<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.FlCup = New System.Windows.Forms.RadioButton()
        Me.CstmCup = New System.Windows.Forms.RadioButton()
        Me.SzCupX = New System.Windows.Forms.NumericUpDown()
        Me.SzCupY = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkHd = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Cup = New System.Windows.Forms.RadioButton()
        Me.Img = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BkClrImg = New System.Windows.Forms.Button()
        Me.SzImgY = New System.Windows.Forms.NumericUpDown()
        Me.SzImgX = New System.Windows.Forms.NumericUpDown()
        Me.CD = New System.Windows.Forms.ColorDialog()
        CType(Me.SzCupX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SzCupY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SzImgY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SzImgX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlCup
        '
        Me.FlCup.AutoSize = True
        Me.FlCup.Checked = True
        Me.FlCup.ForeColor = System.Drawing.Color.White
        Me.FlCup.Location = New System.Drawing.Point(6, 54)
        Me.FlCup.Name = "FlCup"
        Me.FlCup.Size = New System.Drawing.Size(37, 17)
        Me.FlCup.TabIndex = 0
        Me.FlCup.TabStop = True
        Me.FlCup.Text = "Fill"
        Me.FlCup.UseVisualStyleBackColor = True
        '
        'CstmCup
        '
        Me.CstmCup.AutoSize = True
        Me.CstmCup.ForeColor = System.Drawing.Color.White
        Me.CstmCup.Location = New System.Drawing.Point(6, 77)
        Me.CstmCup.Name = "CstmCup"
        Me.CstmCup.Size = New System.Drawing.Size(60, 17)
        Me.CstmCup.TabIndex = 1
        Me.CstmCup.Text = "Custom"
        Me.CstmCup.UseVisualStyleBackColor = True
        '
        'SzCupX
        '
        Me.SzCupX.Enabled = False
        Me.SzCupX.Location = New System.Drawing.Point(6, 100)
        Me.SzCupX.Maximum = New Decimal(New Integer() {1378, 0, 0, 0})
        Me.SzCupX.Minimum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.SzCupX.Name = "SzCupX"
        Me.SzCupX.Size = New System.Drawing.Size(109, 20)
        Me.SzCupX.TabIndex = 2
        Me.SzCupX.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'SzCupY
        '
        Me.SzCupY.Enabled = False
        Me.SzCupY.Location = New System.Drawing.Point(154, 100)
        Me.SzCupY.Maximum = New Decimal(New Integer() {800, 0, 0, 0})
        Me.SzCupY.Minimum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.SzCupY.Name = "SzCupY"
        Me.SzCupY.Size = New System.Drawing.Size(109, 20)
        Me.SzCupY.TabIndex = 3
        Me.SzCupY.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkHd)
        Me.GroupBox1.Controls.Add(Me.FlCup)
        Me.GroupBox1.Controls.Add(Me.SzCupY)
        Me.GroupBox1.Controls.Add(Me.CstmCup)
        Me.GroupBox1.Controls.Add(Me.SzCupX)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 136)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cupture Setting"
        Me.GroupBox1.Visible = False
        '
        'ChkHd
        '
        Me.ChkHd.AutoSize = True
        Me.ChkHd.Checked = True
        Me.ChkHd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkHd.Location = New System.Drawing.Point(6, 19)
        Me.ChkHd.Name = "ChkHd"
        Me.ChkHd.Size = New System.Drawing.Size(116, 17)
        Me.ChkHd.TabIndex = 4
        Me.ChkHd.Text = "Hide when cupture"
        Me.ChkHd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Cup)
        Me.GroupBox2.Controls.Add(Me.Img)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 124)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Setting startup"
        '
        'Cup
        '
        Me.Cup.AutoSize = True
        Me.Cup.Checked = True
        Me.Cup.ForeColor = System.Drawing.Color.White
        Me.Cup.Location = New System.Drawing.Point(29, 37)
        Me.Cup.Name = "Cup"
        Me.Cup.Size = New System.Drawing.Size(87, 17)
        Me.Cup.TabIndex = 2
        Me.Cup.TabStop = True
        Me.Cup.Text = "New Cupture"
        Me.Cup.UseVisualStyleBackColor = True
        '
        'Img
        '
        Me.Img.AutoSize = True
        Me.Img.ForeColor = System.Drawing.Color.White
        Me.Img.Location = New System.Drawing.Point(156, 37)
        Me.Img.Name = "Img"
        Me.Img.Size = New System.Drawing.Size(107, 17)
        Me.Img.TabIndex = 3
        Me.Img.Text = "New blank image"
        Me.Img.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BkClrImg)
        Me.GroupBox3.Controls.Add(Me.SzImgY)
        Me.GroupBox3.Controls.Add(Me.SzImgX)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(570, 136)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Setting Image"
        Me.GroupBox3.Visible = False
        '
        'BkClrImg
        '
        Me.BkClrImg.BackColor = System.Drawing.Color.White
        Me.BkClrImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BkClrImg.Location = New System.Drawing.Point(6, 19)
        Me.BkClrImg.Name = "BkClrImg"
        Me.BkClrImg.Size = New System.Drawing.Size(75, 40)
        Me.BkClrImg.TabIndex = 4
        Me.BkClrImg.UseVisualStyleBackColor = False
        '
        'SzImgY
        '
        Me.SzImgY.Location = New System.Drawing.Point(154, 65)
        Me.SzImgY.Maximum = New Decimal(New Integer() {573, 0, 0, 0})
        Me.SzImgY.Minimum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.SzImgY.Name = "SzImgY"
        Me.SzImgY.Size = New System.Drawing.Size(109, 20)
        Me.SzImgY.TabIndex = 3
        Me.SzImgY.Value = New Decimal(New Integer() {573, 0, 0, 0})
        '
        'SzImgX
        '
        Me.SzImgX.Location = New System.Drawing.Point(6, 65)
        Me.SzImgX.Maximum = New Decimal(New Integer() {1043, 0, 0, 0})
        Me.SzImgX.Minimum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.SzImgX.Name = "SzImgX"
        Me.SzImgX.Size = New System.Drawing.Size(109, 20)
        Me.SzImgX.TabIndex = 2
        Me.SzImgX.Value = New Decimal(New Integer() {1043, 0, 0, 0})
        '
        'CD
        '
        Me.CD.Color = System.Drawing.Color.White
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(589, 286)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(605, 325)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(605, 325)
        Me.Name = "Form3"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting"
        CType(Me.SzCupX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SzCupY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.SzImgY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SzImgX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlCup As System.Windows.Forms.RadioButton
    Friend WithEvents CstmCup As System.Windows.Forms.RadioButton
    Friend WithEvents SzCupX As System.Windows.Forms.NumericUpDown
    Friend WithEvents SzCupY As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Cup As System.Windows.Forms.RadioButton
    Friend WithEvents Img As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BkClrImg As System.Windows.Forms.Button
    Friend WithEvents SzImgY As System.Windows.Forms.NumericUpDown
    Friend WithEvents SzImgX As System.Windows.Forms.NumericUpDown
    Friend WithEvents ChkHd As System.Windows.Forms.CheckBox
    Friend WithEvents CD As System.Windows.Forms.ColorDialog
End Class
