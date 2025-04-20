Imports MySql.Data.MySqlClient
Public Class PO_Update_Form
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub PO_Update_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedButtons(updateData)
        RoundedButtons(closebtn)
    End Sub

    Private Sub RoundedButtons(j As Button)
        j.FlatAppearance.BorderSize = 0
        j.FlatStyle = FlatStyle.Flat
        j.BackColor = Color.Black
        j.ForeColor = Color.White
        j.Cursor = Cursors.Hand
        j.Font = New Font("Century Gothic", 12)

        Dim v As New Drawing2D.GraphicsPath
        v.StartFigure()

        v.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        v.AddLine(40, 0, j.Width - 40, 0)

        v.AddArc(New Rectangle(j.Width - 40, 0, 40, 40), -90, 90)
        v.AddLine(j.Width, 40, j.Width, j.Height - 40)

        v.AddArc(New Rectangle(j.Width - 40, j.Height - 40, 40, 40), 0, 90)
        v.AddLine(j.Width - 40, j.Height, 40, j.Height)

        v.AddArc(New Rectangle(0, j.Height - 40, 40, 40), 90, 90)
        v.CloseAllFigures()

        j.Region = New Region(v)

    End Sub

    Private Sub updateData_Click(sender As Object, e As EventArgs) Handles updateData.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE tbl_po set remarks='" & status_txt.Text & "',tags='" & tags_txt.Text & "' where product_no='" & product_no.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub

    Private Sub product_no_TextChanged(sender As Object, e As EventArgs) Handles product_no.TextChanged
        Try
            conn.Open()
            cmd = New MySqlCommand("select * from tbl_po where product_no='" & product_no.Text & "'", conn)
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()
                tags_txt.Text = dr.Item("tags").ToString
                status_txt.Text = dr.Item("remarks").ToString
                dr.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Close()
    End Sub
End Class