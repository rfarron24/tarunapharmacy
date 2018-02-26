Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek("localhost", "root", "", "apotik")
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT count(nama) from stokobat"
        cmd.Connection = conn
        MessageBox.Show(cmd.ExecuteScalar.ToString)
    End Sub


End Class