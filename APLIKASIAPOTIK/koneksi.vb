Imports MySql.Data.MySqlClient

Module koneksi

    Public cmd As New MySqlCommand
    Public myadapter As New MySqlDataAdapter
    Public conn As New MySql.Data.MySqlClient.MySqlConnection
    Public tampung As Byte = 0

    Public Sub konek(ByVal server As String, ByVal user As String, ByVal pass As String, ByVal db As String)
        If conn.State = ConnectionState.Closed Then
            Dim myString As String = "server=" & server _
            & ";user=" & user _
            & ";password=" & pass _
            & ";database=" & db
            Try
                conn.ConnectionString = myString
                conn.Open()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox(ex.Message)
                End
            End Try
        End If
    End Sub
    Public Sub disconnect()
        Try
            conn.Open()
        Catch ex As MySql.Data.MySqlClient.MySqlException
        End Try
    End Sub
End Module
