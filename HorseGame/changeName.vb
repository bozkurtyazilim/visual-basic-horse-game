Public Class changeName

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.Reset()

        My.Settings.at1isim = TextBox1.Text
        My.Settings.at2isim = TextBox2.Text
        My.Settings.Save()

        Form1.Label7.Text = My.Settings.at1isim
        Form1.Label8.Text = My.Settings.at2isim

        Form1.Show()
        Me.Close()
    End Sub

    Private Sub isimgir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.at1isim
        TextBox2.Text = My.Settings.at2isim

        Form1.horse1name = My.Settings.at1isim
        Form1.horse2name = My.Settings.at2isim

        Form1.Label7.Text = Form1.horse1name
        Form1.Label8.Text = Form1.horse2name
    End Sub
End Class