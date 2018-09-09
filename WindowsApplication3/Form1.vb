Public Class Form1
    Dim timp As New DateTime()
    Sub Cupt()
        timp = Now()
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(PictureBox1.Size.Width, PictureBox1.Size.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, -9, -144, bounds.Size, CopyPixelOperation.SourceCopy)
        PictureBox1.Image = screenshot
    End Sub
    Sub his()
        Form2.Resent()
        Form2.PictureBox1.Image = PictureBox1.Image
        Form2.enbl()
    End Sub
    Sub rest()
        '################ Grps
        RecOvl.Visible = False
        TextGrp.Visible = False
        ImageGrp.Visible = False
        DrawingGrp.Visible = False
        CrpGrp.Visible = False
        IcnGrp.Visible = False
        '############# RecOvl  ##############
        With RectangleShape1
            .BorderColor = Color.Black
            .BorderWidth = 1
            .BorderStyle = Drawing2D.DashStyle.Solid
            .BackStyle = PowerPacks.BackStyle.Transparent
            .BackColor = Color.Transparent
            .Size = New Size(200, 200)
            .Location = New Point(4, 5)
            .Visible = False
        End With
        With OvalShape1
            .BorderColor = Color.Black
            .BorderWidth = 1
            .BorderStyle = Drawing2D.DashStyle.Solid
            .BackStyle = PowerPacks.BackStyle.Transparent
            .BackColor = Color.Transparent
            .Size = New Size(200, 200)
            .Location = New Point(4, 5)
            .Visible = False
        End With
      

        CLRbkRECovl.BackColor = Me.BackColor
        CLRbrdrRECovl.BackColor = Color.Black
        BkTrnprntChk.Checked = True
        BrdrChkTrnsprnRecOvl.Checked = False
        BrdrSzRECovl.Value = 1
        With ComboBox1
            .SelectedIndex = 0
            .Text = "Solid"
        End With

        SzRecOvlX.Value = 200
        SzRecOvlY.Value = 200
        PositionX.Value = PositionX.Minimum
        PositionY.Value = PositionY.Minimum
        '########## Text ##################
        BkClrTxt.BackColor = Me.BackColor
        ChkTxtTrnspr.Checked = True
        FrClrTxt.BackColor = Color.Black
        With Text1
            .Font = Label1.Font
            .ForeColor = Color.Black
            .BackColor = Color.Transparent
            .Location = New Point(9, 26)
            .Visible = False
            .Text = "Text"
        End With
        EdtTxt.Text = "Text"
        PositionTxtX.Value = PositionTxtX.Minimum
        PositionTxtY.Value = PositionTxtY.Minimum
        SzTxt.Value = 8
        '########## Image ##################
        With RectangleShape2
            .BackgroundImage = Nothing
            .Size = New Size(200, 200)
            .Location = New Point(6, 7)
            .Visible = False
        End With
        PthIMG.Text = ""
        SzImgX.Value = 200
        SzImgY.Value = 200
        PositionImgX.Value = PositionImgX.Minimum
        PositionImgY.Value = PositionImgY.Minimum
        '########## Drawing ##################
        ClrDrng.BackColor = Color.Black
        SzDrng.Value = 5
        ShwDrngChk.Checked = False
        myBrush = Brushes.Black
        '########## Icon ##################
        With IcnT
            .Font = New Font("Wingdings", 8)
            .ForeColor = Color.Black
            .Visible = False
            .Text = ""
        End With
        SzIcn.Value = 8
        ComboBox3.Text = ""
        ClrIcn.BackColor = Color.Black

    End Sub

    Private Sub StngPic_Click(sender As Object, e As EventArgs) Handles StngPic.Click
        Form3.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.clr()
        PictureBox1.Image = Nothing
        If Form3.Cup.Checked = True And Form3.Img.Checked = False Then
            If Form3.ChkHd.Checked = True Then
                Me.Opacity = 0
                Me.ShowInTaskbar = False

            End If


            Dim bounds As Rectangle
            Dim screenshot As System.Drawing.Bitmap
            Dim graph As Graphics
            bounds = Screen.PrimaryScreen.Bounds
            If Form3.CstmCup.Checked = False And Form3.FlCup.Checked = True Then
                screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            ElseIf Form3.CstmCup.Checked = True And Form3.FlCup.Checked = False Then
                screenshot = New System.Drawing.Bitmap(Form3.SzCupX.Value, Form3.SzCupY.Value, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            End If
            graph = Graphics.FromImage(screenshot)
            graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
            PictureBox1.Image = screenshot
            Me.Opacity = 100
            Me.ShowInTaskbar = True

        ElseIf Form3.Cup.Checked = False And Form3.Img.Checked = True Then
            PictureBox1.BackColor = Form3.BkClrImg.BackColor
            PictureBox1.Size = New Size(Form3.SzImgX.Value, Form3.SzImgY.Value)

        End If
        PictureBox1.BorderStyle = BorderStyle.None
        ToolsGrp.Enabled = True
        his()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.SendToBack()
        RectangleShape1.BringToFront()
        RectangleShape2.BringToFront()
        RectangleShape3.BringToFront()
        OvalShape1.BringToFront()
        Text1.Parent = PictureBox1
        IcnT.Parent = PictureBox1
        If My.Settings.ImgEdt = True Then
            Form3.Cup.Checked = False
            Form3.Img.Checked = True
            Button2.BackgroundImage = ImageList1.Images.Item(1)
            Form3.SzImgX.Value = My.Settings.ImgSzX
            Form3.SzImgY.Value = My.Settings.ImgSzY
        Else
            Form3.Cup.Checked = True
            Form3.Img.Checked = False
            Button2.BackgroundImage = ImageList1.Images.Item(0)
        End If
      
        If My.Settings.CupSzFl = True Then
            Form3.CstmCup.Checked = False
            Form3.SzCupX.Enabled = False
            Form3.FlCup.Checked = True
            Form3.SzCupY.Enabled = False
        Else
            Form3.CstmCup.Checked = True
            Form3.SzCupX.Enabled = True
            Form3.FlCup.Checked = False
            Form3.SzCupY.Enabled = True
            Form3.SzCupY.Value = My.Settings.CupSzY
            Form3.SzCupX.Value = My.Settings.CupSzX
        End If
        Form3.ChkHd.Checked = My.Settings.HidFrm
    End Sub
    '########################## Properties RecOvl #######################################################
   
    Private Sub CLRbkRECovl_Click(sender As Object, e As EventArgs) Handles CLRbkRECovl.Click
        Form5.BtnClr.BackColor = CLRbkRECovl.BackColor
        Form5.ShowDialog()
        If OvalShape1.Visible = True Then
            CLRbkRECovl.BackColor = Form5.BtnClr.BackColor
            OvalShape1.BackColor = Form5.BtnClr.BackColor
        ElseIf RectangleShape1.Visible = True Then
            CLRbkRECovl.BackColor = Form5.BtnClr.BackColor
            RectangleShape1.BackColor = Form5.BtnClr.BackColor

        End If

    End Sub

  
    Private Sub CLRbrdrRECovl_Click(sender As Object, e As EventArgs) Handles CLRbrdrRECovl.Click
        Form5.BtnClr.BackColor = CLRbrdrRECovl.BackColor
        Form5.ShowDialog()
        If OvalShape1.Visible = True Then
            CLRbrdrRECovl.BackColor = Form5.BtnClr.BackColor
            OvalShape1.BorderColor = Form5.BtnClr.BackColor
            BrdrChkTrnsprnRecOvl.Checked = False
        ElseIf RectangleShape1.Visible = True Then
            CLRbrdrRECovl.BackColor = Form5.BtnClr.BackColor
            RectangleShape1.BorderColor = Form5.BtnClr.BackColor
            BrdrChkTrnsprnRecOvl.Checked = False
        End If

    End Sub

    Private Sub BkTrnprntChk_CheckedChanged(sender As Object, e As EventArgs) Handles BkTrnprntChk.CheckedChanged
        If OvalShape1.Visible = True Then
            If BkTrnprntChk.Checked = True Then
                OvalShape1.BackStyle = PowerPacks.BackStyle.Transparent
            ElseIf BkTrnprntChk.Checked = False Then
                OvalShape1.BackStyle = PowerPacks.BackStyle.Opaque
                OvalShape1.BackColor = CLRbkRECovl.BackColor
            End If
        ElseIf RectangleShape1.Visible = True Then
            If BkTrnprntChk.Checked = True Then
                RectangleShape1.BackStyle = PowerPacks.BackStyle.Transparent
            ElseIf BkTrnprntChk.Checked = False Then
                RectangleShape1.BackStyle = PowerPacks.BackStyle.Opaque
                RectangleShape1.BackColor = CLRbkRECovl.BackColor
            End If
        End If
        Me.Refresh()
    End Sub

   
    Private Sub BrdrSzRECovl_ValueChanged(sender As Object, e As EventArgs) Handles BrdrSzRECovl.ValueChanged
        If OvalShape1.Visible = True Then
            OvalShape1.BorderWidth = BrdrSzRECovl.Value
        ElseIf RectangleShape1.Visible = True Then
            RectangleShape1.BorderWidth = BrdrSzRECovl.Value
        End If
        Me.Refresh()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If OvalShape1.Visible = True Then
            With OvalShape1


                Select Case ComboBox1.SelectedIndex
                    Case 0
                        .BorderStyle = Drawing2D.DashStyle.Solid
                    Case 1
                        .BorderStyle = Drawing2D.DashStyle.Dash
                    Case 2
                        .BorderStyle = Drawing2D.DashStyle.DashDot
                    Case 3
                        .BorderStyle = Drawing2D.DashStyle.DashDotDot
                    Case 4
                        .BorderStyle = Drawing2D.DashStyle.Dot
                End Select
            End With

        ElseIf RectangleShape1.Visible = True Then
            With RectangleShape1


                Select Case ComboBox1.SelectedIndex
                    Case 0
                        .BorderStyle = Drawing2D.DashStyle.Solid
                    Case 1
                        .BorderStyle = Drawing2D.DashStyle.Dash
                    Case 2
                        .BorderStyle = Drawing2D.DashStyle.DashDot
                    Case 3
                        .BorderStyle = Drawing2D.DashStyle.DashDotDot
                    Case 4
                        .BorderStyle = Drawing2D.DashStyle.Dot
                End Select
            End With
        End If
        Me.Refresh()
    End Sub

    Private Sub SzRecOvlX_ValueChanged(sender As Object, e As EventArgs) Handles SzRecOvlX.ValueChanged
        If OvalShape1.Visible = True Then
            OvalShape1.Size = New Size(SzRecOvlX.Value, SzRecOvlY.Value)
        ElseIf RectangleShape1.Visible = True Then
            RectangleShape1.Size = New Size(SzRecOvlX.Value, SzRecOvlY.Value)
        End If
        Me.Refresh()
    End Sub
    Private Sub SzRecOvlY_ValueChanged(sender As Object, e As EventArgs) Handles SzRecOvlY.ValueChanged
        If OvalShape1.Visible = True Then
            OvalShape1.Size = New Size(SzRecOvlX.Value, SzRecOvlY.Value)
        ElseIf RectangleShape1.Visible = True Then
            RectangleShape1.Size = New Size(SzRecOvlX.Value, SzRecOvlY.Value)
        End If
        Me.Refresh()
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.DoubleClick
        Form4.NumericUpDown1.Value = PositionX.Value
        Form4.NumericUpDown2.Value = PositionY.Value
        Form4.ShowDialog()
        PositionX.Value = Form4.NumericUpDown1.Value
        PositionY.Value = Form4.NumericUpDown2.Value
        Label6.Text = "Location : (" & PositionX.Value & "," & PositionY.Value & ")"
        If OvalShape1.Visible = True Then
            OvalShape1.Location = New Point(PositionX.Value, PositionY.Value)
        ElseIf RectangleShape1.Visible = True Then
            RectangleShape1.Location = New Point(PositionX.Value, PositionY.Value)
        End If
    End Sub

    Private Sub SvRecOvl_Click(sender As Object, e As EventArgs) Handles SvRecOvl.Click
        Cupt()
        rest()
        his()

    End Sub
    Private Sub CnslRecOvl_Click(sender As Object, e As EventArgs) Handles CnslRecOvl.Click
        rest()
        Me.Refresh()
    End Sub

    '########################## Tools #######################################################


    Private Sub NewRec_Click(sender As Object, e As EventArgs) Handles NewRec.Click
        rest()
        RectangleShape1.Visible = True
        RecOvl.Visible = True
        Me.Refresh()
    End Sub

    Private Sub NewOval_Click(sender As Object, e As EventArgs) Handles NewOval.Click
        rest()
        OvalShape1.Visible = True
        RecOvl.Visible = True
        Me.Refresh()
    End Sub

    Private Sub NewImage_Click(sender As Object, e As EventArgs) Handles NewImage.Click
        rest()
        RectangleShape2.Visible = True
        ImageGrp.Visible = True
        Me.Refresh()
    End Sub


    Private Sub NewText_Click(sender As Object, e As EventArgs) Handles NewText.Click
        rest()
        Text1.Visible = True
        TextGrp.Visible = True
        Me.Refresh()
        ComboBox2.Text = Text1.Font.Name
    End Sub

    Private Sub NewDawing_Click(sender As Object, e As EventArgs) Handles NewDawing.Click
        rest()
        DrawingGrp.Visible = True
        ShwDrngChk.Checked = True
    End Sub
    Private Sub NewIcn_Click(sender As Object, e As EventArgs) Handles NewIcn.Click
        rest()
        IcnGrp.Visible = True
        IcnT.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CrpGrp.Visible = True
        RectangleShape3.Visible = True
    End Sub

    Private Sub SvPic_Click(sender As Object, e As EventArgs) Handles SvPic.Click
        Dim filesavedialog1 As New SaveFileDialog
        SFD.Title = "Save Image"
        SFD.FileName = "IMG-Editor" & timp.ToString("HH-mm-dd-MM-yyyy") & ".jpg"
        SFD.Filter = "JPEG File| .jpg"
        Try
            If SFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBox1.Image.Save(SFD.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub FrmHis_Click(sender As Object, e As EventArgs) Handles FrmHis.Click
        Form2.enbl()
        Form2.ShowDialog()
    End Sub

    '########################## Properties ImageGrp #######################################################

    Private Sub OpnImg_Click(sender As Object, e As EventArgs) Handles OpnImg.Click
        Try
            OFD.Filter = "Bitmap |*.bmp| JPG | *.jpg | GIF | *.gif | All Files|*.*"

            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                PthIMG.Text = OFD.FileName
                RectangleShape2.BackgroundImage = Image.FromFile(OFD.FileName)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SzImgX_ValueChanged(sender As Object, e As EventArgs) Handles SzImgX.ValueChanged
        RectangleShape2.Size = New Size(SzImgX.Value, SzImgY.Value)
        Me.Refresh()
    End Sub

    Private Sub SzImgY_ValueChanged(sender As Object, e As EventArgs) Handles SzImgY.ValueChanged
        RectangleShape2.Size = New Size(SzImgX.Value, SzImgY.Value)
        Me.Refresh()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.DoubleClick
        Form4.NumericUpDown1.Value = PositionImgX.Value
        Form4.NumericUpDown2.Value = PositionImgY.Value
        Form4.ShowDialog()
        PositionImgX.Value = Form4.NumericUpDown1.Value
        PositionImgY.Value = Form4.NumericUpDown2.Value
        Label11.Text = "Location : (" & PositionImgX.Value & "," & PositionImgY.Value & ")"
        RectangleShape3.Location = New Point(PositionImgX.Value, PositionImgY.Value)
    End Sub

    Private Sub SvImg_Click(sender As Object, e As EventArgs) Handles SvImg.Click
        Cupt()
        rest()
        his()
    End Sub

    Private Sub CnslImg_Click(sender As Object, e As EventArgs) Handles CnslImg.Click
        rest()
        Me.Refresh()
    End Sub

    '########################## Properties TextGrp #######################################################

    Private Sub BkClrTxt_Click(sender As Object, e As EventArgs) Handles BkClrTxt.Click
        Form5.BtnClr.BackColor = BkClrTxt.BackColor
        Form5.ShowDialog()
        BkClrTxt.BackColor = Form5.BtnClr.BackColor
        Text1.BackColor = Form5.BtnClr.BackColor
        ChkTxtTrnspr.Checked = False

    End Sub

    Private Sub FrClrTxt_Click(sender As Object, e As EventArgs) Handles FrClrTxt.Click
        Form5.BtnClr.BackColor = FrClrTxt.BackColor
        Form5.ShowDialog()
        FrClrTxt.BackColor = Form5.BtnClr.BackColor
        Text1.ForeColor = Form5.BtnClr.BackColor


    End Sub

    Private Sub ChkTxtTrnspr_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTxtTrnspr.CheckedChanged
        If ChkTxtTrnspr.Checked = False Then
            Text1.BackColor = BkClrTxt.BackColor
        ElseIf ChkTxtTrnspr.Checked = True Then
            Text1.BackColor = Color.Transparent

        End If
        Me.Refresh()
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            ComboBox2.Text = ComboBox2.SelectedItem.ToString
            Text1.Font = New Font(ComboBox2.Text, SzTxt.Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SzTxt_ValueChanged(sender As Object, e As EventArgs) Handles SzTxt.ValueChanged
        Text1.Font = New Font(ComboBox2.Text, SzTxt.Value)
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.DoubleClick
        Form4.NumericUpDown1.Value = PositionTxtX.Value
        Form4.NumericUpDown2.Value = PositionTxtY.Value
        Form4.ShowDialog()
        PositionTxtX.Value = Form4.NumericUpDown1.Value
        PositionTxtY.Value = Form4.NumericUpDown2.Value
        Label12.Text = "Location : (" & PositionTxtX.Value & "," & PositionTxtY.Value & ")"
        Text1.Location = New Point(PositionTxtX.Value, PositionTxtY.Value)
    End Sub

    Private Sub SvTxt_Click(sender As Object, e As EventArgs) Handles SvTxt.Click
        Cupt()
        rest()
        his()
    End Sub

    Private Sub CnslTxt_Click(sender As Object, e As EventArgs) Handles CnslTxt.Click
        rest()

    End Sub
    Private Sub EdtTxt_TextChanged(sender As Object, e As EventArgs) Handles EdtTxt.TextChanged
        Text1.Text = EdtTxt.Text
    End Sub

    '########################## moving ###############################
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

  
    Private Sub PositionY_Scroll(sender As Object, e As EventArgs) Handles PositionY.Scroll
        If RectangleShape1.Visible = True Then
            RectangleShape1.Location = New Point(PositionX.Value, PositionY.Value)
        ElseIf OvalShape1.Visible = True Then
            OvalShape1.Location = New Point(PositionX.Value, PositionY.Value)
        End If
        Label6.Text = "Location : (" & PositionX.Value & "," & PositionY.Value & ")"
        Me.Refresh()
    End Sub

    Private Sub PositionX_Scroll(sender As Object, e As EventArgs) Handles PositionX.Scroll
        If RectangleShape1.Visible = True Then
            RectangleShape1.Location = New Point(PositionX.Value, PositionY.Value)
        ElseIf OvalShape1.Visible = True Then
            OvalShape1.Location = New Point(PositionX.Value, PositionY.Value)
        End If
        Label6.Text = "Location : (" & PositionX.Value & "," & PositionY.Value & ")"
        Me.Refresh()
    End Sub

    Private Sub PositionImgX_Scroll(sender As Object, e As EventArgs) Handles PositionImgX.Scroll
        RectangleShape2.Location = New Point(PositionImgX.Value, PositionImgY.Value)
        Label11.Text = "Location : (" & PositionImgX.Value & "," & PositionImgY.Value & ")"
        Me.Refresh()
    End Sub

    Private Sub PositionImgY_Scroll(sender As Object, e As EventArgs) Handles PositionImgY.Scroll
        RectangleShape2.Location = New Point(PositionImgX.Value, PositionImgY.Value)
        Label11.Text = "Location : (" & PositionImgX.Value & "," & PositionImgY.Value & ")"
        Me.Refresh()
    End Sub

    Private Sub PositionTxtX_Scroll(sender As Object, e As EventArgs) Handles PositionTxtX.Scroll
        Text1.Location = New Point(PositionTxtX.Value, PositionTxtY.Value)
        Label12.Text = "Location : (" & PositionTxtX.Value & "," & PositionTxtY.Value & ")"
        Me.Refresh()
    End Sub

    Private Sub PositionTxtY_Scroll(sender As Object, e As EventArgs) Handles PositionTxtY.Scroll
        Text1.Location = New Point(PositionTxtX.Value, PositionTxtY.Value)
        Label12.Text = "Location : (" & PositionTxtX.Value & "," & PositionTxtY.Value & ")"
        Me.Refresh()
    End Sub

   


   
    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click
        Dim allFonts As New Drawing.Text.InstalledFontCollection
        Dim fontFamilies() As FontFamily = allFonts.Families()
        ComboBox2.Items.Clear()
        For Each myFont As FontFamily In fontFamilies
            ComboBox2.Items.Add(myFont.Name)

        Next


    End Sub

    Private Sub BrdrChkTrnsprnRecOvl_CheckedChanged(sender As Object, e As EventArgs) Handles BrdrChkTrnsprnRecOvl.CheckedChanged
        If OvalShape1.Visible = True Then
            If BrdrChkTrnsprnRecOvl.Checked = True Then
                OvalShape1.BorderColor = Color.Transparent
            ElseIf BrdrChkTrnsprnRecOvl.Checked = False Then
                OvalShape1.BorderColor = CLRbrdrRECovl.BackColor
            End If
        ElseIf RectangleShape1.Visible = True Then
            If BrdrChkTrnsprnRecOvl.Checked = True Then
                RectangleShape1.BorderColor = Color.Transparent
            ElseIf BrdrChkTrnsprnRecOvl.Checked = False Then
                RectangleShape1.BorderColor = CLRbrdrRECovl.BackColor
            End If
        End If
        Me.Refresh()
    End Sub
    '########################## Properties DrngGrp #######################################################

    Dim down = False
    Dim myBrush = Brushes.Black


    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If ShwDrngChk.Checked = True Then
            down = True
        End If

    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If ShwDrngChk.Checked = True Then
            If down = True Then
                PictureBox1.Cursor = Cursors.Cross
                PictureBox1.CreateGraphics.FillEllipse(myBrush, e.X, e.Y, SzDrng.Value, SzDrng.Value)

            End If

        End If

    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        If ShwDrngChk.Checked = True Then
            down = False
            PictureBox1.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub ClrDrng_Click(sender As Object, e As EventArgs) Handles ClrDrng.Click
        Form5.BtnClr.BackColor = ClrDrng.BackColor
        Form5.ShowDialog()
        myBrush = New SolidBrush(Form5.BtnClr.BackColor)
        ClrDrng.BackColor = Form5.BtnClr.BackColor
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = Form2.PictureBox1.Image
        rest()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Cupt()
        rest()
        his()
        PictureBox1.Image = Form2.PictureBox1.Image
    End Sub
    '########################## Grp Crp ##########################################
    Private Sub PositionCrpX_Scroll(sender As Object, e As EventArgs) Handles PositionCrpX.Scroll
        If (RectangleShape3.Size.Width + RectangleShape3.Location.X) < 1041 And (RectangleShape3.Size.Height + RectangleShape3.Location.Y) < 574 Then
            RectangleShape3.Location = New Point(PositionCrpX.Value, PositionCrpY.Value)
        Else
            RectangleShape3.Size = New Size(200, 200)
            RectangleShape3.Location = New Point(100, 100)
        End If
        Me.Refresh()
    End Sub

    Private Sub PositionCrpY_Scroll(sender As Object, e As EventArgs) Handles PositionCrpY.Scroll
        If (RectangleShape3.Size.Width + RectangleShape3.Location.X) < 1041 And (RectangleShape3.Size.Height + RectangleShape3.Location.Y) < 574 Then
            RectangleShape3.Location = New Point(PositionCrpX.Value, PositionCrpY.Value)
        Else
            RectangleShape3.Size = New Size(200, 200)
            RectangleShape3.Location = New Point(100, 100)
        End If
        Me.Refresh()
    End Sub

    Private Sub SzCrpX_ValueChanged(sender As Object, e As EventArgs) Handles SzCrpX.ValueChanged
        If (RectangleShape3.Size.Width + RectangleShape3.Location.X) < 1041 And (RectangleShape3.Size.Height + RectangleShape3.Location.Y) < 574 Then
            RectangleShape3.Size = New Size(SzCrpX.Value, SzCrpY.Value)
        Else
            RectangleShape3.Size = New Size(200, 200)
            RectangleShape3.Location = New Point(100, 100)
        End If

            Me.Refresh()
    End Sub

    Private Sub SzCrpY_ValueChanged(sender As Object, e As EventArgs) Handles SzCrpY.ValueChanged
        If (RectangleShape3.Size.Width + RectangleShape3.Location.X) < 1041 And (RectangleShape3.Size.Height + RectangleShape3.Location.Y) < 574 Then
            RectangleShape3.Size = New Size(SzCrpX.Value, SzCrpY.Value)
        Else
            RectangleShape3.Size = New Size(200, 200)
            RectangleShape3.Location = New Point(100, 100)
        End If
        Me.Refresh()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RectangleShape3.Visible = False
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(RectangleShape3.Size.Width, RectangleShape3.Size.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, (-RectangleShape3.Location.X - 4), (-RectangleShape3.Location.Y - 143), bounds.Size, CopyPixelOperation.SourceCopy)
        PictureBox1.Image = screenshot
        PictureBox1.Size = New Size(RectangleShape3.Size.Width, RectangleShape3.Size.Height)
    End Sub


    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox3.Text = ComboBox3.SelectedItem
        If ComboBox3.Text = "Folder" Then
            IcnT.Text = "0"
        ElseIf ComboBox3.Text = "Folder open" Then
            IcnT.Text = "1"
        ElseIf ComboBox3.Text = "File" Then
            IcnT.Text = "2"
        ElseIf ComboBox3.Text = "File 2" Then
            IcnT.Text = "3"
        ElseIf ComboBox3.Text = "Files" Then
            IcnT.Text = "4"
        ElseIf ComboBox3.Text = "Hand" Then
            IcnT.Text = "I"
        ElseIf ComboBox3.Text = "Hand up" Then
            IcnT.Text = "G"
        ElseIf ComboBox3.Text = "Hand down" Then
            IcnT.Text = "H"
        ElseIf ComboBox3.Text = "Hand left" Then
            IcnT.Text = "E"
        ElseIf ComboBox3.Text = "Hand right" Then
            IcnT.Text = "F"
        ElseIf ComboBox3.Text = "Hand like" Then
            IcnT.Text = "C"
        ElseIf ComboBox3.Text = "Hand dislike" Then
            IcnT.Text = "D"
        ElseIf ComboBox3.Text = "Keyborder" Then
            IcnT.Text = "7"
        ElseIf ComboBox3.Text = "Mouse" Then
            IcnT.Text = "8"
        ElseIf ComboBox3.Text = "Face smile" Then
            IcnT.Text = "J"
        ElseIf ComboBox3.Text = "Face normal" Then
            IcnT.Text = "K"
        ElseIf ComboBox3.Text = "Face angry" Then
            IcnT.Text = "L"
        ElseIf ComboBox3.Text = "Sun" Then
            IcnT.Text = "R"
        ElseIf ComboBox3.Text = "Crescent" Then
            IcnT.Text = "Z"
        ElseIf ComboBox3.Text = "Plane" Then
            IcnT.Text = "Q"
        ElseIf ComboBox3.Text = "Bomb" Then
            IcnT.Text = "M"
        End If
    End Sub

   
    Private Sub ClrIcn_Click(sender As Object, e As EventArgs) Handles ClrIcn.Click
        Form5.BtnClr.BackColor = ClrIcn.BackColor
        Form5.ShowDialog()
        ClrIcn.BackColor = Form5.BtnClr.BackColor
        IcnT.ForeColor = Form5.BtnClr.BackColor
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles SzIcn.Scroll
        IcnT.Font = New Font("Wingdings", SzIcn.Value)
    End Sub

    Private Sub SvIcn_Click(sender As Object, e As EventArgs) Handles SvIcn.Click
        Cupt()
        rest()
        his()
    End Sub

    '########################## Properties IcnGrp #######################################################

    Private Sub PositionIcnX_Scroll(sender As Object, e As EventArgs) Handles PositionIcnX.Scroll
        IcnT.Location = New Point(PositionIcnX.Value, PositionIcnY.Value)
        Label18.Text = "Location : (" & PositionIcnX.Value & "," & PositionIcnY.Value & ")"
        Me.Refresh()
    End Sub

    Private Sub PositionIcnY_Scroll(sender As Object, e As EventArgs) Handles PositionIcnY.Scroll
        IcnT.Location = New Point(PositionIcnX.Value, PositionIcnY.Value)
        Label18.Text = "Location : (" & PositionIcnX.Value & "," & PositionIcnY.Value & ")"
        Me.Refresh()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.DoubleClick
        Form4.NumericUpDown1.Value = PositionIcnX.Value
        Form4.NumericUpDown2.Value = PositionIcnY.Value
        Form4.ShowDialog()
        PositionIcnX.Value = Form4.NumericUpDown1.Value
        PositionIcnY.Value = Form4.NumericUpDown2.Value
        Label12.Text = "Location : (" & PositionIcnX.Value & "," & PositionIcnY.Value & ")"
        IcnT.Location = New Point(PositionIcnX.Value, PositionIcnY.Value)
    End Sub

    Private Sub CnslIcn_Click(sender As Object, e As EventArgs) Handles CnslIcn.Click
        rest()
    End Sub
End Class
