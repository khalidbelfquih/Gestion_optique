Imports MySql.Data.MySqlClient
Module connect
    Public conn As MySqlConnection
    Public server As String = ""
    Public port As String = ""
    Public userID As String = ""
    Public password As String = ""
    Public database As String = ""

    Sub openconnection()

        Try
            Dim query As String = "server=127.0.0.1;port=3306;user=root;password=;database=gestion_optique;"
            conn = New MySqlConnection(query)
            If conn.State = ConnectionState.Closed Then

                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

            End If
        Catch ex As Exception
            MsgBox("Connection Failed!", MsgBoxStyle.Critical, "Information")

        Finally

        End Try
    End Sub





End Module
