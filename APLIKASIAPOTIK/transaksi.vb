Imports MySql.Data.MySqlClient
Public Class transaksi
    Dim tgl As String

  


    Private Sub transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek("localhost", "root", "", "apotik")
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand

        cmd.CommandType = CommandType.Text
        tmpg.Text = tampung


        tgl = Format(tanggal.Value, "yyyy-MM-dd")
        trans.Text = 1
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        home.Show()
        home.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        conn.Open()

        cmd.CommandText = "select count(*)  from transaksii where kode='" & TextBox8.Text & "'"

        If tmpg.Text = 0 Then 'jika belum ada data
            cmd.CommandText = "insert into transaksii values ('" & trans.Text & "','" & tgl & "','" & TextBox8.Text & "','" & TextBox1.Text & "','" & TextBox9.Text & "','" & hrg.Text & "','" & jml.Text & "','" & tot.Text & "')"
        Else ' jika data sudah ada
            MsgBox("No ini sudah ada", vbCritical, "Pesan")
        End If



        cmd.Connection = conn


        ListBox6.Items.Add(TextBox8.Text)
        ListBox1.Items.Add(TextBox1.Text)
        ListBox2.Items.Add(TextBox9.Text)
        ListBox3.Items.Add(hrg.Text)
        ListBox4.Items.Add(jml.Text)
        ListBox5.Items.Add(tot.Text)

        TextBox8.Text = ""
        TextBox1.Text = ""
        TextBox9.Text = ""
        hrg.Text = ""
        jml.Text = ""
        tot.Text = ""

        trans.Enabled = True
        TextBox8.Enabled = True
        TextBox1.Enabled = True
        TextBox9.Enabled = True
        hrg.Enabled = True
        jml.Enabled = True
        tot.Enabled = True

        cmd.ExecuteNonQuery()
  
        TextBox8.Clear()
        TextBox1.Clear()
        TextBox9.Clear()
        hrg.Clear()
        jml.Clear()
        tot.Clear()



    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim totalbayar As Integer
        Dim t As Integer

        totalbayar = 0

        For t = 0 To ListBox5.Items.Count - 1
            totalbayar = totalbayar + Val(ListBox5.Items(t))

        Next
        Me.TextBox5.Text = totalbayar


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click



        Me.TextBox7.Text = Val(TextBox6.Text) - Val(TextBox5.Text)

        TextBox5.Text = FormatCurrency(TextBox5.Text)

        TextBox7.Text = FormatCurrency(TextBox7.Text)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        cariobat.Show()
        cariobat.Focus()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.tot.Text = Val(jml.Text) * Val(hrg.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        trans.Text = Val(trans.Text) + 1

        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox1.Clear()
        TextBox9.Clear()
        hrg.Clear()
        jml.Clear()
        tot.Clear()

        ListBox6.Items.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        cmd.CommandText = "select count(*)  from transaksii where kode='" & TextBox8.Text & "'"

        If tmpg.Text = 0 Then 'jika belum ada data
            cmd.CommandText = "insert into transaksi (tanggal,kode,nama,jenis,harga,qty,total) select tanggal,kode,nama,jenis,harga,qty,total from transaksii"
        Else ' jika data sudah ada
            MsgBox("No ini sudah ada", vbCritical, "Pesan")
        End If
            cmd.Connection = conn

        cmd.ExecuteNonQuery()


    

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        cmd.CommandText = "select count(*)  from transaksii where kode='" & TextBox8.Text & "'"
        If tmpg.Text = 0 Then 'jika belum ada data
            cmd.CommandText = "delete from transaksii where notrans = '" & trans.Text & "'"
        Else ' jika data sudah ada
            MsgBox("No ini sudah ada", vbCritical, "Pesan")
        End If

        cmd.Connection = conn

        cmd.ExecuteNonQuery()
    End Sub
End Class