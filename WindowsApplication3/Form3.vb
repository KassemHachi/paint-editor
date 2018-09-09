Public Class Form3

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles Cup.CheckedChanged
        If Cup.Checked = False Then
            Img.Checked = True
            My.Settings.ImgEdt = True
            Form1.Button2.BackgroundImage = Form1.ImageList1.Images.Item(1)
            GroupBox3.Visible = True
            GroupBox1.Visible = False
        ElseIf Cup.Checked = True Then
            Img.Checked = False
            My.Settings.ImgEdt = False
            Form1.Button2.BackgroundImage = Form1.ImageList1.Images.Item(0)
            GroupBox3.Visible = False
            GroupBox1.Visible = True
        End If
    End Sub

    Private Sub Img_CheckedChanged(sender As Object, e As EventArgs) Handles Img.CheckedChanged
        If Img.Checked = False Then
            Cup.Checked = True
            My.Settings.ImgEdt = False
            GroupBox3.Visible = False
            GroupBox1.Visible = True
            Form1.Button2.BackgroundImage = Form1.ImageList1.Images.Item(0)
        ElseIf Img.Checked = True Then
            Cup.Checked = False
            My.Settings.ImgEdt = True
            Form1.Button2.BackgroundImage = Form1.ImageList1.Images.Item(1)
            GroupBox3.Visible = True
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub FlCup_CheckedChanged(sender As Object, e As EventArgs) Handles FlCup.CheckedChanged
        If FlCup.Checked = False Then
            CstmCup.Checked = True
            SzCupX.Enabled = True
            SzCupY.Enabled=True 
        ElseIf FlCup.Checked = True Then
            CstmCup.Checked = False
            SzCupX.Enabled = False
            SzCupY.Enabled = False
        End If
    End Sub

   
    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.Save()
    End Sub

    Private Sub BkClrImg_Click(sender As Object, e As EventArgs) Handles BkClrImg.Click
        If CD.ShowDialog = Windows.Forms.DialogResult.OK Then
            BkClrImg.BackColor = CD.Color
        End If
    End Sub

    Private Sub SzImgX_ValueChanged(sender As Object, e As EventArgs) Handles SzImgX.ValueChanged
        My.Settings.ImgSzX = SzImgX.Value

    End Sub

    Private Sub SzImgY_ValueChanged(sender As Object, e As EventArgs) Handles SzImgY.ValueChanged
        My.Settings.ImgSzY = SzImgY.Value
    End Sub

    Private Sub ChkHd_CheckedChanged(sender As Object, e As EventArgs) Handles ChkHd.CheckedChanged
        If ChkHd.Checked = True Then
            My.Settings.HidFrm = True
        Else
            My.Settings.HidFrm = False
        End If

    End Sub
End Class