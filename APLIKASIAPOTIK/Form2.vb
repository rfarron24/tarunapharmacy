Imports MySql.Data.MySqlClient

Public Class form2

    Private Sub form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek("localhost", "root", "", "apotik")
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
        cmd.CommandType = CommandType.Text

        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("kapsul")
        ComboBox1.Items.Add("tablet")
        ComboBox1.Items.Add("sirup")
        TextBox4.Text = tampung

        tampung = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tampung = 0
        Me.Close()
        home.Show()
        home.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim jumlah As Byte


        If tampung = 0 Then
            If TextBox5.Text = "" Or TextBox1.Text = "" Then
                MsgBox("Kode dan Nama Harus Di isi", vbCritical, "Pesan")
                Exit Sub
            End If
            cmd.CommandText = "select count(*)  from stokobat where kode='" & TextBox5.Text & "'"

            If jumlah < 1 Then 'jika belum ada data
                cmd.CommandText = "insert into stokobat values ('" & TextBox5.Text & "','" & TextBox1.Text & "','" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
            Else ' jika data sudah ada
                MsgBox("Data Item ini sudah ada", vbCritical, "Pesan")
            End If
        End If
        '//akhir 

      


        cmd.Connection = conn

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.Clear()

        cmd.ExecuteNonQuery()
        bersih()

    End Sub


    Private Sub bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""

        TextBox3.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        lihatstok.Show()
        lihatstok.Focus()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class