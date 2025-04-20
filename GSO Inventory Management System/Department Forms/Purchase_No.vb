Imports MySql.Data.MySqlClient
Public Class Purchase_No
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub Purchase_No_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedButtons(savebtn)
        RoundedButtons(closebtn)

        Dim ss As String = Form1.bind_02.Text
        Try
            conn.Open()
            cmd = New MySqlCommand("select * from " & ss & "", conn)
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()
                pr_txt.Text = dr.Item("PR_no").ToString
                date_issue.Text = dr.Item("date_PR").ToString
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
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

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Dim ss As String = Form1.bind_02.Text
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE " & ss & " set pr_no='" & pr_txt.Text & "',date_pr='" & date_issue.Text & "'", conn)
            cmd.ExecuteNonQuery()

            MsgBox("Data Updated")
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