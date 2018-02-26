Public Class home

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Close()
        login.Show()
        login.Focus()
    End Sub

    Private Sub DATASTOKBARANGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATASTOKBARANGToolStripMenuItem.Click

        inputstok.Show()
        inputstok.Focus()
    End Sub

    Private Sub TRANSAKSIPEMBELIANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRANSAKSIPEMBELIANToolStripMenuItem.Click

        transaksi.Show()
        transaksi.Focus()
    End Sub

   

    Private Sub STOKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOKToolStripMenuItem.Click

        lihatstok.Show()
        lihatstok.Focus()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Form2.Show()
        Form2.Focus()
    End Sub

    Private Sub PENJUALANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENJUALANToolStripMenuItem.Click

        lihatpenjualan.Show()
        lihatpenjualan.Focus()
    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        transaksi.Show()
        transaksi.Focus()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        lihatstok.Show()
        lihatstok.Focus()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

        lihatpenjualan.Show()
        lihatpenjualan.Focus()
    End Sub

    Private Sub PENJUALANOBATToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENJUALANOBATToolStripMenuItem.Click

        lappenjualan.Show()
        lappenjualan.Focus()
    End Sub

 
   
End Class