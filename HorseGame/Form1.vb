Public Class Form1
    Public horse1speed, horse2speed As Integer
    Public horse1name, horse2name As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' 
        horse1name = My.Settings.at1isim
        horse2name = My.Settings.at2isim

        Label7.Text = horse1name
        Label8.Text = horse2name

        ' 1. AT
        Randomize()
        horse1speed = Math.Ceiling(Rnd() * 10)
        PictureBox1.Left = PictureBox1.Left + horse1speed

        ' 2. AT
        Randomize()
        horse2speed = Math.Ceiling(Rnd() * 10)
        PictureBox2.Left = PictureBox2.Left + horse2speed

        If PictureBox1.Left > Label1.Left Then
            Timer1.Stop()
            MsgBox(horse1name & " Win.")
            TextBox1.Text = horse1name & " Won the race.!"
            PictureBox1.Left = 12
            PictureBox2.Left = 12
        End If

        If PictureBox2.Left > Label1.Left Then
            Timer1.Stop()
            MsgBox(horse2name & " Win.")
            TextBox1.Text = horse2name & " Won the race.!"
            PictureBox1.Left = 12
            PictureBox2.Left = 12
        End If

        If PictureBox2.Left = Label1.Left Then
            Timer1.Stop()
            MsgBox("Ended together!.")
            TextBox1.Text = "Ended together!."
            PictureBox1.Left = 12
            PictureBox2.Left = 12
        End If

        If PictureBox1.Left > PictureBox2.Left Then
            TextBox1.Text = horse1name & " Now ahead."
        ElseIf PictureBox2.Left > PictureBox1.Left Then
            TextBox1.Text = horse2name & " Now ahead."
        ElseIf PictureBox1.Left = PictureBox2.Left Then
            TextBox1.Text = "It's an exciting race."
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        horse1name = My.Settings.at1isim
        horse2name = My.Settings.at2isim

        Label7.Text = horse1name
        Label8.Text = horse2name


        If My.Settings.at1isim = "" Or My.Settings.at2isim = "" Then
            changeName.ShowDialog()
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        changeName.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
End Class
