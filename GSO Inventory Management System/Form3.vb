Imports MySql.Data.MySqlClient
Public Class Form3_dep
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Close()
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

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedButtons(savebtn)
        RoundedButtons(closebtn)

        update_po()
    End Sub
    Sub update_po()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tbl_po", conn)
            dr = cmd.ExecuteReader()
            If Not dr Is Nothing Then
                dr.Read()
                po_no.Text = dr.Item("po_no").ToString
                po_date.Text = dr.Item("po_date").ToString
                mode_procure.Text = dr.Item("mode_of_procure").ToString

                fundtxt.Text = dr.Item("fund").ToString
                suppliertxt.Text = dr.Item("supplier").ToString
                addresstxt.Text = dr.Item("address").ToString
                tintxt.Text = dr.Item("tin").ToString
                pod.Text = dr.Item("place_deliver").ToString
                dod.Text = dr.Item("date_deliver").ToString
                dt.Text = dr.Item("deliver_term").ToString
                pt.Text = dr.Item("payment_term").ToString
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("update tbl_po set po_no='" & po_no.Text & "',po_date='" & po_date.Text & "',mode_of_procure='" & mode_procure.Text & "',fund='" & fundtxt.Text & "',supplier='" & suppliertxt.Text & "',address='" & addresstxt.Text & "',tin='" & tintxt.Text & "',place_deliver='" & pod.Text & "',date_deliver='" & dod.Text & "',deliver_term='" & dt.Text & "',payment_term='" & pt.Text & "',end_user='" & persontxt.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("File Updated", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class