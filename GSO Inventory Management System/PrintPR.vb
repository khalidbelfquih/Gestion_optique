Imports MySql.Data.MySqlClient
Public Class PrintPR
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim da, data1, data2 As New MySqlDataAdapter
    Dim dt, dtable1, dtable2 As New DataTable
    Dim p(7) As MySqlParameter
    Private Sub PrintPR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

End Class