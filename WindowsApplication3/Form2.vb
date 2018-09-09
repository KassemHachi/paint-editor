Public Class Form2
    Sub Resent()
        PictureBox5.Image = PictureBox4.Image
        PictureBox4.Image = PictureBox3.Image
        PictureBox3.Image = PictureBox2.Image
        PictureBox2.Image = PictureBox1.Image
    End Sub
    Sub clr()
        PictureBox5.Image = Nothing
        PictureBox4.Image = Nothing
        PictureBox3.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox1.Image = Form1.PictureBox1.Image
    End Sub
    Sub enbl()
        If PictureBox1.Image Is Nothing Then
            PictureBox1.Enabled = False
        Else
            PictureBox1.Enabled = True
        End If
        If PictureBox2.Image Is Nothing Then
            PictureBox2.Enabled = False
        Else
            PictureBox2.Enabled = True
        End If
        If PictureBox3.Image Is Nothing Then
            PictureBox3.Enabled = False
        Else
            PictureBox3.Enabled = True
        End If
        If PictureBox4.Image Is Nothing Then
            PictureBox4.Enabled = False
        Else
            PictureBox4.Enabled = True
        End If
        If PictureBox5.Image Is Nothing Then
            PictureBox5.Enabled = False
        Else
            PictureBox5.Enabled = True
        End If
    End Sub
    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        If PictureBox1.Image Is Form1.RectangleShape1.BackgroundImage Then
        Else
            Me.Close()
            Form1.PictureBox1.Image = PictureBox1.Image
            clr()
        End If
    End Sub

    Private Sub PictureBox2_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox2.DoubleClick
        If PictureBox1.Image Is Form1.RectangleShape1.BackgroundImage Then
        Else
            Me.Close()
            Form1.PictureBox1.Image = PictureBox2.Image
            clr()
        End If
    End Sub

    Private Sub PictureBox3_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox3.DoubleClick
        If PictureBox1.Image Is Form1.RectangleShape1.BackgroundImage Then
        Else
            Me.Close()
            Form1.PictureBox1.Image = PictureBox3.Image
            clr()
        End If
    End Sub

    Private Sub PictureBox4_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox4.DoubleClick
        If PictureBox1.Image Is Form1.RectangleShape1.BackgroundImage Then
        Else
            Me.Close()
            Form1.PictureBox1.Image = PictureBox4.Image
            clr()
        End If
    End Sub

    Private Sub PictureBox5_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox5.DoubleClick
        If PictureBox1.Image Is Form1.RectangleShape1.BackgroundImage Then
        Else
            Me.Close()
            Form1.PictureBox1.Image = PictureBox5.Image
            clr()
        End If
    End Sub
End Class