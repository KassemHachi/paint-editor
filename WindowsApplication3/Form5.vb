Public Class Form5
    Sub clrVlu()
        RedNumClr.Value = RedClr.Value
        BlueNumClr.Value = BlueClr.Value
        GreenNumClr.Value = GreenClr.Value
        BtnClr.BackColor = Color.FromArgb(RedClr.Value, BlueClr.Value, GreenClr.Value)
    End Sub
    Sub clrNum()
        RedClr.Value = RedNumClr.Value
        BlueClr.Value = BlueNumClr.Value
        GreenClr.Value = GreenNumClr.Value
        BtnClr.BackColor = Color.FromArgb(RedNumClr.Value, BlueNumClr.Value, GreenNumClr.Value)
    End Sub
    Sub clr()
        RedClr.Value = BtnClr.BackColor.R
        BlueClr.Value = BtnClr.BackColor.B
        GreenClr.Value = BtnClr.BackColor.G
        RedNumClr.Value = BtnClr.BackColor.R
        BlueNumClr.Value = BtnClr.BackColor.B
        GreenNumClr.Value = BtnClr.BackColor.G
    End Sub
    Private Sub RedClr_Scroll(sender As Object, e As EventArgs) Handles RedClr.Scroll

        clrVlu()
    End Sub

    Private Sub GreenClr_Scroll(sender As Object, e As EventArgs) Handles GreenClr.Scroll
        clrVlu()
    End Sub

    Private Sub BlueClr_Scroll(sender As Object, e As EventArgs) Handles BlueClr.Scroll
        clrVlu()
    End Sub

    Private Sub RedNumClr_ValueChanged(sender As Object, e As EventArgs) Handles RedNumClr.ValueChanged
        clrNum()
    End Sub

    Private Sub GreenNumClr_ValueChanged(sender As Object, e As EventArgs) Handles GreenNumClr.ValueChanged
        clrNum()
    End Sub

    Private Sub BlueNumClr_ValueChanged(sender As Object, e As EventArgs) Handles BlueNumClr.ValueChanged
        clrNum()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Dim col As KnownColor
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clr()
    End Sub

    Private Sub SilverClrBtn_Click(sender As Object, e As EventArgs) Handles SilverClrBtn.Click
        BtnClr.BackColor = SilverClrBtn.BackColor
    End Sub

    Private Sub RedClrBtn_Click(sender As Object, e As EventArgs) Handles RedClrBtn.Click
        BtnClr.BackColor = RedClrBtn.BackColor
    End Sub

    Private Sub orangeClrBtn_Click(sender As Object, e As EventArgs) Handles orangeClrBtn.Click
        BtnClr.BackColor = orangeClrBtn.BackColor
    End Sub

    Private Sub YellowClrBtn_Click(sender As Object, e As EventArgs) Handles YellowClrBtn.Click
        BtnClr.BackColor = YellowClrBtn.BackColor
    End Sub

    Private Sub BlueClrBtn_Click(sender As Object, e As EventArgs) Handles BlueClrBtn.Click
        BtnClr.BackColor = BlueClrBtn.BackColor
    End Sub

    Private Sub GreenClrBtn_Click(sender As Object, e As EventArgs) Handles GreenClrBtn.Click
        BtnClr.BackColor = GreenClrBtn.BackColor
    End Sub

    Private Sub CyanClrBtn_Click(sender As Object, e As EventArgs) Handles CyanClrBtn.Click
        BtnClr.BackColor = CyanClrBtn.BackColor
    End Sub

    Private Sub MagentaClrBtn_Click(sender As Object, e As EventArgs) Handles MagentaClrBtn.Click
        BtnClr.BackColor = MagentaClrBtn.BackColor
    End Sub

    Private Sub BlackClrBtn_Click(sender As Object, e As EventArgs) Handles BlackClrBtn.Click
        BtnClr.BackColor = BlackClrBtn.BackColor
    End Sub

    Private Sub WhiteClrBtn_Click(sender As Object, e As EventArgs) Handles WhiteClrBtn.Click
        BtnClr.BackColor = WhiteClrBtn.BackColor
    End Sub
End Class