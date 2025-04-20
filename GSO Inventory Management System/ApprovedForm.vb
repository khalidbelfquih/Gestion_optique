Imports MySql.Data.MySqlClient
Public Class ApprovedForm
    Dim cmd As New MySqlCommand

    Private Sub ApprovedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload_data()
        RoundedButtons(updateData)
        count_lb.Text = PO_dgv.RowCount
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

    Sub reload_data()
        Dim adap As New MySqlDataAdapter
        Dim dtable1 As New DataTable

        Try
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select no as `Stock/Property No.`,date_issue as `Date of Issue`,description as `Description`,qty as `Quantity`,unit_of_issue as `Unit`,unit_price as `Unit Cost`,total_cost as `Amount`,Remarks as `Status`, tags as `No. of Lack Items` from tbl_po where remarks='Approved'", conn)
            adap.SelectCommand = cmd
            dtable1.Clear()
            adap.Fill(dtable1)
            PO_dgv.DataSource = dtable1
            PO_dgv.Columns("Description").Width = 630
            PO_dgv.Columns("No. of Lack Items").Width = 210
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub updateData_Click(sender As Object, e As EventArgs) Handles updateData.Click
        Try
            conn.Open()
            For i As Integer = 0 To PO_dgv.Rows.Count - 1
                cmd = New MySqlCommand("UPDATE tbl_po set description=@description,qty=@qty,unit_of_issue=@unit_of_issue,unit_price=@unit_price,total_cost=@total_cost,remarks=@remarks where no=@no", conn)
                cmd.Parameters.AddWithValue("@no", PO_dgv.Rows(i).Cells(1).Value)
                cmd.Parameters.AddWithValue("@description", PO_dgv.Rows(i).Cells(5).Value)
                cmd.Parameters.AddWithValue("@qty", PO_dgv.Rows(i).Cells(6).Value)
                cmd.Parameters.AddWithValue("@unit_of_issue", PO_dgv.Rows(i).Cells(7).Value)
                cmd.Parameters.AddWithValue("@unit_price", PO_dgv.Rows(i).Cells(8).Value)
                cmd.Parameters.AddWithValue("@total_cost", PO_dgv.Rows(i).Cells(9).Value)
                cmd.Parameters.AddWithValue("@remarks", PO_dgv.Rows(i).Cells(11).Value)
                cmd.ExecuteNonQuery()
            Next
            MsgBox("Successfully update data...")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub
End Class