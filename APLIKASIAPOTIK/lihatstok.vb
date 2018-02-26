Imports MySql.Data.MySqlClient
Public Class lihatstok
    Dim kode, nama, jenis, harga, jump As String
    Dim jumlah As Byte

    Private Sub displaydata()

        Dim adt As New MySqlDataAdapter("select kode,nama,jenis,harga from stokobat", conn)
        Dim dt As New DataTable("stokobat")
        adt.Fill(dt)
        DataGridView1.DataSource = dt
        '    conn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        'conn.Open()
        Dim adp As New MySqlDataAdapter("select * from stokobat where kode='" & TextBox1.Text & "'", conn)
        Dim dt As New DataTable("stokobat")
        adp.Fill(dt)
        DataGridView1.DataSource = dt

        'conn.Close()

    End Sub








    Private Sub lihatstok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek("localhost", "root", "", "apotik")
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
        cmd.CommandType = CommandType.Text

        displaydata()
    End Sub







    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        cmd.CommandText = "select count(*) from stokobat"
        'jumlah = cmd.ExecuteScalar

        cmd.CommandText = "select * from stokobat order by kode"
        displaydata()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        home.Show()
        home.Focus()
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tampung = 1

        Dim i As Integer = Nothing
        i = DataGridView1.CurrentRow.Index
        With DataGridView1
            inputstok.TextBox5.Text = .Item(0, i).Value
            inputstok.TextBox1.Text = .Item(1, i).Value
            inputstok.ComboBox1.Text = .Item(2, i).Value
            inputstok.TextBox2.Text = .Item(3, i).Value
            inputstok.TextBox3.Text = .Item(4, i).Value
        End With

       
        inputstok.Show()
        inputstok.TextBox5.Enabled = True
    End Sub
    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim tanya As String
        tanya = MsgBox("Yakin Dihapus kode='" & TextBox1.Text & "'", vbYesNo, "Pesan")
        If tanya = vbYes Then

            Dim adp As New MySqlDataAdapter("delete from stokobat where kode='" & TextBox1.Text & "'", conn)
            Dim dt As New DataTable("stokobat")
            adp.Fill(dt)
            DataGridView1.DataSource = dt



            cmd.CommandText = "select count(*) from stokobat"

            cmd.CommandText = "select * from stokobat order by no"
            displaydata()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class