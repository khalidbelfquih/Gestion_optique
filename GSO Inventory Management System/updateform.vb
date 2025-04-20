Imports MySql.Data.MySqlClient
Public Class updateform
    'Dim conn As New MySqlConnection("server=localhost; user id=root; password='admin'; database=gso_db")
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Public Shared information As String

    Private Sub updateform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchinfo()
        RoundedButtons(savebtn)
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
    Sub unitprice1()
        Dim dr As MySqlDataReader
        Try
            conn.Open()
            cmd = New MySqlCommand("select * from app  where product_no='" & pr_no.Text & "'", conn)
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()

                pr_no.Text = dr.Item("product_no").ToString
                desc_01.Text = dr.Item("description").ToString
                qty_01.Text = dr.Item("qty").ToString
                unitprc.Text = dr.Item("unit_price").ToString
                unitissue_01.Text = dr.Item("unit_of_issue").ToString
                totalcost_01.Text = dr.Item("total_cost").ToString
                modeproc.Text = dr.Item("mode_of_procure").ToString
                qty1st.Text = dr.Item("qty1").ToString
                amnt1st.Text = dr.Item("amnt1").ToString

                qty2nd.Text = dr.Item("qty2").ToString
                amnt2nd.Text = dr.Item("amnt2").ToString
                qty3rd.Text = dr.Item("qty3").ToString
                amnt3rd.Text = dr.Item("amnt3").ToString
                qty4th.Text = dr.Item("qty4").ToString
                amnt4th.Text = dr.Item("amnt4").ToString
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

   

    Sub searchinfo()
        Try
            conn.Open()
            cmd = New MySqlCommand("select * from " & SELECTTXT.Text & " where item_no= '" & idtxt.Text & "'", conn)
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()

                productno.Text = dr.Item("product_no").ToString
                desc.Text = dr.Item("description").ToString
                qty.Text = dr.Item("qty").ToString
                unitissue.Text = dr.Item("unit_of_issue").ToString
                unitprice.Text = dr.Item("unit_price").ToString
                totalcost.Text = dr.Item("total_cost").ToString
                modeprocure.Text = dr.Item("mode_of_procure").ToString
                qty1.Text = dr.Item("qty1").ToString
                amnt1.Text = dr.Item("amnt1").ToString
                qty2.Text = dr.Item("qty2").ToString
                amnt2.Text = dr.Item("amnt2").ToString
                qty3.Text = dr.Item("qty3").ToString
                amnt3.Text = dr.Item("amnt3").ToString
                qty4.Text = dr.Item("qty4").ToString
                amnt4.Text = dr.Item("amnt4").ToString
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

        Dim office As String = SELECTTXT.Text
        Try
            conn.Open()
            cmd = New MySqlCommand("update " & office & " set date_issue='" & DateTimePicker1.Text & "',description='" & desc.Text & "',qty='" & qty.Text & "',unit_of_issue='" & unitissue.Text & "',unit_price='" & unitprice.Text & "',total_cost='" & totalcost.Text & "',mode_of_procure='" & modeprocure.Text & "',qty1='" & qty1.Text & "',amnt1='" & amnt1.Text & "',qty2='" & qty2.Text & "',amnt2='" & amnt2.Text & "',qty3='" & qty3.Text & "',amnt3='" & amnt3.Text & "',qty4='" & qty4.Text & "',amnt4='" & amnt4.Text & "',department='" & SELECTTXT.Text & "' where product_no='" & productno.Text & "'", conn)
            cmd.ExecuteNonQuery()

            cmd = New MySqlCommand("update app set description='" & desc.Text & "',qty='" & sub_qty.Text & "',unit_of_issue='" & unitissue_01.Text & "',unit_price='" & unitprc.Text & "',total_cost='" & totalcost_01.Text & "',mode_of_procure='" & modeproc.Text & "',qty1='" & sub_qty_01.Text & "',amnt1='" & amnt1st.Text & "',qty2='" & sub_qty_02.Text & "',amnt2='" & amnt2nd.Text & "',qty3='" & sub_qty_03.Text & "',amnt3='" & amnt3rd.Text & "',qty4='" & sub_qty_04.Text & "',amnt4='" & amnt4th.Text & "' where product_no='" & productno.Text & "'", conn)
            cmd.ExecuteNonQuery()

            MsgBox("Successfully updated", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        ViewForm.showdata()
    End Sub

    Private Sub qty_TextChanged(sender As Object, e As EventArgs) Handles qty.TextChanged

    End Sub

  
    Private Sub sub_qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sub_qty.TextChanged, qty.TextChanged, qty_01.TextChanged, qty1.TextChanged, qty2.TextChanged, qty3.TextChanged, qty4.TextChanged
        sub_qty.Text = Val(qty1.Text) + Val(qty2.Text) + Val(qty3.Text) + Val(qty4.Text)

    End Sub

    Private Sub totalcost_01_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles totalcost_01.TextChanged, sub_qty.TextChanged, unitprc.TextChanged
        totalcost_01.Text = Val(sub_qty.Text) * Val(unitprc.Text)
    End Sub

   

    Private Sub amnt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amnt1.TextChanged, unitprice.TextChanged, qty1.TextChanged
        amnt1.Text = Val(unitprice.Text) * Val(qty1.Text)

    End Sub

    Private Sub totalcost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles totalcost.TextChanged, qty.TextChanged, unitprice.TextChanged
        totalcost.Text = Val(qty.Text) * Val(unitprice.Text)

    End Sub

    Private Sub amnt2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amnt2.TextChanged, unitprice.TextChanged, qty2.TextChanged
        amnt2.Text = Val(unitprice.Text) * Val(qty2.Text)

    End Sub

    Private Sub amnt3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amnt3.TextChanged, unitprice.TextChanged, qty3.TextChanged

        amnt3.Text = Val(unitprice.Text) * Val(qty3.Text)
    End Sub

    Private Sub amnt4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amnt4.TextChanged, unitprice.TextChanged, qty4.TextChanged

        amnt4.Text = Val(unitprice.Text) * Val(qty4.Text)
    End Sub

    Private Sub sub_qty_01_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sub_qty_01.TextChanged, qty1.TextChanged, qty1st.TextChanged
        sub_qty_01.Text = Val(qty1.Text) + Val(qty1st.Text)

    End Sub


    Private Sub sub_qty_02_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sub_qty_02.TextChanged, qty2nd.TextChanged, qty2.TextChanged
        sub_qty_02.Text = Val(qty2.Text) + Val(qty2nd.Text)

    End Sub

   

    Private Sub sub_qty_03_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sub_qty_03.TextChanged, qty3.TextChanged, qty3rd.TextChanged
        sub_qty_03.Text = Val(qty3.Text) + Val(qty3rd.Text)

    End Sub

   

    Private Sub sub_qty_04_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sub_qty_04.TextChanged, qty4.TextChanged, qty4th.TextChanged
        sub_qty_04.Text = Val(qty4.Text) + Val(qty4th.Text)

    End Sub

   

    Private Sub productno_TextChanged(sender As Object, e As EventArgs) Handles productno.TextChanged
        Dim dr As MySqlDataReader
        Try
            conn.Open()
            cmd = New MySqlCommand("select * from app where product_no='" & productno.Text & "'", conn)
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()

                pr_no.Text = dr.Item("product_no").ToString
                desc_01.Text = dr.Item("department").ToString
                qty_01.Text = dr.Item("qty").ToString
                unitprc.Text = dr.Item("unit_price").ToString
                unitissue_01.Text = dr.Item("unit_of_issue").ToString
                totalcost_01.Text = dr.Item("total_cost").ToString
                modeproc.Text = dr.Item("mode_of_procure").ToString
                qty1st.Text = dr.Item("qty1").ToString
                amnt1st.Text = dr.Item("amnt1").ToString

                qty2nd.Text = dr.Item("qty2").ToString
                amnt2nd.Text = dr.Item("amnt2").ToString
                qty3rd.Text = dr.Item("qty3").ToString
                amnt3rd.Text = dr.Item("amnt3").ToString
                qty4th.Text = dr.Item("qty4").ToString
                amnt4th.Text = dr.Item("amnt4").ToString
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub pr_no_TextChanged(sender As Object, e As EventArgs) Handles pr_no.TextChanged
      
    End Sub

    Private Sub SELECTTXT_TextChanged(sender As Object, e As EventArgs) Handles SELECTTXT.TextChanged

    End Sub

    Private Sub amnt1st_TextChanged(sender As Object, e As EventArgs) Handles amnt1st.TextChanged

    End Sub

    Private Sub amnt2nd_TextChanged(sender As Object, e As EventArgs) Handles amnt2nd.TextChanged

    End Sub
End Class