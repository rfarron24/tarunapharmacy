Imports MySql.Data.MySqlClient

Public Class lihatpenjualan
    Dim jumlah As Byte
    Private Sub displaydata()

        Dim adt As New MySqlDataAdapter("select tanggal,kode,nama,jenis,harga,qty,total from transaksi", conn)
        Dim dt As New DataTable("transaksi")
        adt.Fill(dt)
        DataGridView1.DataSource = dt
        ' conn.Close()
    End Sub
    Private Sub lihatpenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek("localhost", "root", "", "apotik")
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
        cmd.CommandType = CommandType.Text

        displaydata()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        home.Show()
        home.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim adp As New MySqlDataAdapter("select * from transaksi where kode='" & TextBox1.Text & "'", conn)
        Dim dt As New DataTable("transaksi")
        adp.Fill(dt)
        DataGridView1.DataSource = dt

        'conn.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        cmd.CommandText = "select count(*) from transaksi"
        'jumlah = cmd.ExecuteScalar

        cmd.CommandText = "select * from transaksi order by tanggal"
        displaydata()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim tanya As String
        tanya = MsgBox("Yakin Dihapus kode='" & TextBox1.Text & "'", vbYesNo, "Pesan")
        If tanya = vbYes Then

            Dim adp As New MySqlDataAdapter("delete from transaksi where kode='" & TextBox1.Text & "'", conn)
            Dim dt As New DataTable("transaksi")
            adp.Fill(dt)
            DataGridView1.DataSource = dt



            cmd.CommandText = "select count(*) from transaksi"

            cmd.CommandText = "select * from transaksi order by tanggal"
            displaydata()
        End If
    End Sub
End Class