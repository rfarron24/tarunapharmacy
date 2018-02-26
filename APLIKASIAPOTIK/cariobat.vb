Imports MySql.Data.MySqlClient
Public Class cariobat
    Private Sub displaydata()

        Dim adp As New MySqlDataAdapter("select kode,nama,jenis,harga from stokobat", conn)
        Dim dt As New DataTable("stokobat")
        adp.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        conn.Open()
        Dim adp As New MySqlDataAdapter("select * from stokobat where kode='" & TextBox1.Text & "'", conn)
        Dim dt As New DataTable("stokobat")
        adp.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub
    Dim kode, nama, jenis, harga As String
    Private Sub cariobat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        displaydata()
    End Sub

 

    

    Private Sub DataGridView1_CelClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer = Nothing
        i = DataGridView1.CurrentRow.Index
        With DataGridView1
            transaksi.TextBox8.Text = .Item(0, i).Value
            transaksi.TextBox1.Text = .Item(1, i).Value
            transaksi.TextBox9.Text = .Item(2, i).Value
            transaksi.hrg.Text = .Item(3, i).Value

        End With

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer = Nothing
        i = DataGridView1.CurrentRow.Index
        With DataGridView1
            transaksi.TextBox8.Text = .Item(0, i).Value
            transaksi.TextBox1.Text = .Item(1, i).Value
            transaksi.TextBox9.Text = .Item(2, i).Value
            transaksi.hrg.Text = .Item(3, i).Value
            Me.Close()
            transaksi.Show()

        End With
    End Sub
 

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cmd.CommandText = "select count(*) from stokobat"
        'jumlah = cmd.ExecuteScalar

        cmd.CommandText = "select * from stokobat order by kode"
        displaydata()
    End Sub
End Class