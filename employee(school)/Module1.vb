Imports MySql.Data.MysqlClient
Module Module1
    Private conn As MySqlConnection ' Make conn private to avoid accidental modification

    Public Sub DbConnect()
        Dim dbname As String = "dbit2aemployee"
        Dim username As String = "root"
        Dim password As String = "password" 'my sql server pwd'
        Dim server As String = "localhost" 'pc ipadd'

        ' Establish a new connection
        conn = New MySqlConnection() ' Create a new connection object here
        conn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & dbname & ""

        Try
            If conn.State <> ConnectionState.Open Then ' Check if connection is not open
                conn.Open() ' Open connection
                MsgBox("Connected!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module