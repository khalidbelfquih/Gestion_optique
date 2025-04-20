Imports MySql.Data.MySqlClient
Public Class Form2
    Dim cmd As New MySqlCommand
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedButtons(Button1)
        RoundedButtons(Button2)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO tbl_category(category)values(@category)", conn)
            cmd.Parameters.AddWithValue("category", cat_txt.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Success")
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conn.Close()
        End Try
        cat_txt.Text = ""


        FilterForm.categorylist_0001()
        FilterForm.categorylist_0002()
        FilterForm.categorylist_0003()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class