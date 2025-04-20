Imports MySql.Data.MySqlClient
Public Class updateform1
    'Dim conn As New MySqlConnection("server=localhost; user id=root; password='admin'; database=gso_db")
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim dv As DataView
    Dim ds As New DataSet
    Dim cm As CurrencyManager


    Public Shared information As String

    Private Sub updateform1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundedButtons(savebtn)
        RoundedButtons(closebtn)

        'filldata()
        'databind()
        'showpositions()
    End Sub
    Public Sub showpositions()
        rextzxt.Text = cm.Position + 1 & "   " & "of" & "   " & cm.Count()
    End Sub

    Public Sub filldata()
        da = New MySqlDataAdapter("SELECT * FROM " & SELECTTXT.Text & "", conn)
        ds = New DataSet
        da.Fill(ds, "" & SELECTTXT.Text & "")
        dv = New DataView(ds.Tables("" & SELECTTXT.Text & ""))
        cm = CType(Me.BindingContext(dv), CurrencyManager)

    End Sub

    Public Sub databind()
        idtxt_1.DataBindings.Clear()
        productno.DataBindings.Clear()
        DateTimePicker1.DataBindings.Clear()
        desc.DataBindings.Clear()
        qty.DataBindings.Clear()
        unitissue.DataBindings.Clear()
        unitprice.DataBindings.Clear()

        totalcost.DataBindings.Clear()
        modeprocure.DataBindings.Clear()
        qty1.DataBindings.Clear()
        amnt1.DataBindings.Clear()
        qty2.DataBindings.Clear()
        amnt2.DataBindings.Clear()

        qty3.DataBindings.Clear()
        amnt3.DataBindings.Clear()
        qty4.DataBindings.Clear()
        amnt4.DataBindings.Clear()

        idtxt_1.DataBindings.Add("text", dv, "item_no")
        productno.DataBindings.Add("text", dv, "product_no")
        DateTimePicker1.DataBindings.Add("text", dv, "date_issue")
        desc.DataBindings.Add("text", dv, "description")
        qty.DataBindings.Add("text", dv, "qty")
        unitissue.DataBindings.Add("text", dv, "unit_of_issue")

        unitprice.DataBindings.Add("text", dv, "unit_price")
        totalcost.DataBindings.Add("text", dv, "total_cost")
        modeprocure.DataBindings.Add("text", dv, "mode_of_procure")

        qty1.DataBindings.Add("text", dv, "qty1")
        amnt1.DataBindings.Add("text", dv, "amnt1")

        qty2.DataBindings.Add("text", dv, "qty2")
        amnt2.DataBindings.Add("text", dv, "amnt2")

        qty3.DataBindings.Add("text", dv, "qty3")
        amnt3.DataBindings.Add("text", dv, "amnt3")

        qty4.DataBindings.Add("text", dv, "qty4")
        amnt4.DataBindings.Add("text", dv, "amnt4")

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
            'MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub



    Sub searchinfo()

        Try

            conn.Open()
            cmd = New MySqlCommand("select * from " & SELECTTXT.Text & " where item_no= '" & idtxt_1.Text & "'", conn)
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
            'MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

        Dim office As String = SELECTTXT.Text
        Dim office1 As String = binding.Text
        Try

            conn.Open()
            cmd = New MySqlCommand("update " & office & " set date_issue='" & DateTimePicker1.Text & "',description='" & desc.Text & "',qty='" & qty.Text & "',unit_of_issue='" & unitissue.Text & "',unit_price='" & unitprice.Text & "',total_cost='" & totalcost.Text & "',mode_of_procure='" & modeprocure.Text & "',qty1='" & qty1.Text & "',amnt1='" & amnt1.Text & "',qty2='" & qty2.Text & "',amnt2='" & amnt2.Text & "',qty3='" & qty3.Text & "',amnt3='" & amnt3.Text & "',qty4='" & qty4.Text & "',amnt4='" & amnt4.Text & "',jan='" & qty1.Text & "',apr='" & qty2.Text & "',jul='" & qty3.Text & "',oct='" & qty4.Text & "',department='" & SELECTTXT.Text & "' where product_no='" & productno.Text & "'", conn)
            cmd.ExecuteNonQuery()

            cmd = New MySqlCommand("update app set description='" & desc.Text & "',qty='" & qty_01.Text & "',unit_of_issue='" & unitissue_01.Text & "',unit_price='" & unitprc.Text & "',total_cost='" & totalcost_01.Text & "',mode_of_procure='" & modeproc.Text & "',qty1='" & qty1st.Text & "',amnt1='" & amnt1st.Text & "',qty2='" & qty2nd.Text & "',amnt2='" & amnt2nd.Text & "',qty3='" & qty3rd.Text & "',amnt3='" & amnt3rd.Text & "',qty4='" & qty4th.Text & "',amnt4='" & amnt4th.Text & "' where product_no='" & productno.Text & "'", conn)
            cmd.ExecuteNonQuery()

            cmd = New MySqlCommand("update tbl_po set description='" & desc.Text & "',qty='" & qty_01.Text & "',unit_of_issue='" & unitissue_01.Text & "',unit_price='" & unitprc.Text & "',total_cost='" & totalcost_01.Text & "' WHERE Product_no='" & productno.Text & "'", conn)
            cmd.ExecuteNonQuery()

            cmd = New MySqlCommand("update " & office1 & " set description='" & desc.Text & "',qty='" & qty.Text & "',unit_of_issue='" & unitissue.Text & "',unit_price='" & unitprice.Text & "',total_cost='" & totalcost.Text & "' where product_no='" & productno.Text & "'", conn)
            cmd.ExecuteNonQuery()

            cmd = New MySqlCommand("update ppmp set description='" & desc.Text & "',qty='" & qty_01.Text & "',unit_of_issue='" & unitissue_01.Text & "',unit_price='" & unitprc.Text & "',total_cost='" & totalcost_01.Text & "',jan='" & qty1st.Text & "',apr='" & qty2nd.Text & "',jul='" & qty3rd.Text & "',oct='" & qty4th.Text & "' where product_no='" & productno.Text & "'", conn)
            cmd.ExecuteNonQuery()

            cmd = New MySqlCommand("update tbl_pr set description='" & desc.Text & "',qty='" & qty_01.Text & "',unit_of_issue='" & unitissue_01.Text & "',unit_price='" & unitprc.Text & "',total_cost='" & totalcost_01.Text & "',mode_of_procure='" & modeproc.Text & "',qty1='" & qty1st.Text & "',amnt1='" & amnt1st.Text & "',qty2='" & qty2nd.Text & "',amnt2='" & amnt2nd.Text & "',qty3='" & qty3rd.Text & "',amnt3='" & amnt3rd.Text & "',qty4='" & qty4th.Text & "',amnt4='" & amnt4th.Text & "' where product_no='" & productno.Text & "'", conn)
            cmd.ExecuteNonQuery()

            MsgBox("Successfully updated", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        ViewForm.showdata()


        ViewForm.q_11()
        ViewForm.q_21()
        ViewForm.q_31()
        ViewForm.q_41()
        ViewForm.total_amnt1()

        Dim cc As Decimal = ViewForm.amount_01.Text
        ViewForm.amount_01.Text = cc.ToString("#,0.00")

        Dim dd As Decimal = ViewForm.amount_02.Text
        ViewForm.amount_02.Text = dd.ToString("#,0.00")

        Dim ff As Decimal = ViewForm.amount_03.Text
        ViewForm.amount_03.Text = ff.ToString("#,0.00")

        Dim gg As Decimal = ViewForm.amount_04.Text
        ViewForm.amount_04.Text = gg.ToString("#,0.00")

        Dim hh As Decimal = ViewForm.totalcost_txt1.Text
        ViewForm.totalcost_txt1.Text = hh.ToString("#,0.00")
    End Sub

    Private Sub qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qty.TextChanged, qty1.TextChanged, qty2.TextChanged, qty3.TextChanged, qty4.TextChanged
        qty.Text = Val(qty1.Text) + Val(qty2.Text) + Val(qty3.Text) + Val(qty4.Text)
    End Sub

    Private Sub qty2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qty2.TextChanged, subty.TextChanged
        'subty.Text = qty2.Text
    End Sub

    Private Sub sub_qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sub_qty.TextChanged, qty.TextChanged, qty_01.TextChanged, qty1.TextChanged, qty2.TextChanged, qty3.TextChanged, qty4.TextChanged
        sub_qty.Text = Val(qty1.Text) + Val(qty2.Text) + Val(qty3.Text) + Val(qty4.Text)

    End Sub

    Private Sub totalcost_01_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles totalcost_01.TextChanged, qty_01.TextChanged, unitprc.TextChanged
        totalcost_01.Text = Val(qty_01.Text) * Val(unitprc.Text)
    End Sub

    Private Sub amnt1st_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amnt1st.TextChanged, unitprice.TextChanged, sub_qty_01.TextChanged
        amnt1st.Text = Val(unitprice.Text) * Val(qty1st.Text)

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

    Private Sub amnt2nd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amnt2nd.TextChanged, unitprice.TextChanged, qty2nd.TextChanged
        amnt2nd.Text = Val(unitprice.Text) * Val(qty2nd.Text)
    End Sub

    Private Sub sub_qty_03_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sub_qty_03.TextChanged, qty3.TextChanged, qty3rd.TextChanged
        sub_qty_03.Text = Val(qty3.Text) + Val(qty3rd.Text)

    End Sub

    Private Sub amnt3rd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amnt3rd.TextChanged, unitprice.TextChanged, sub_qty_03.TextChanged

        amnt3rd.Text = Val(unitprice.Text) * Val(qty3rd.Text)
    End Sub

    Private Sub sub_qty_04_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sub_qty_04.TextChanged, qty4.TextChanged, qty4th.TextChanged
        sub_qty_04.Text = Val(qty4.Text) + Val(qty4th.Text)

    End Sub

    Private Sub amnt4th_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amnt4th.TextChanged, unitprice.TextChanged, sub_qty_04.TextChanged
        amnt4th.Text = Val(unitprice.Text) * Val(qty4th.Text)

    End Sub

    Private Sub productno_TextChanged(sender As Object, e As EventArgs) Handles productno.TextChanged
       
       
    End Sub

    Private Sub idtxt_1_TextChanged(sender As Object, e As EventArgs) Handles idtxt_1.TextChanged
        Try


            conn.Open()
            cmd = New MySqlCommand("select * from " & SELECTTXT.Text & " where product_no= '" & idtxt_1.Text & "'", conn)
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
            'MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub pr_no_TextChanged(sender As Object, e As EventArgs) Handles pr_no.TextChanged
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
            'MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'subty.Text = Val(qty2.Text) + Val(qty2nd.Text)
        'qty2nd.Text = subty.Text
        'Dim a As Integer = qty2nd.Text

        Dim a As Integer
        Dim b As Integer
        Dim i As Integer
        Dim c As Integer

        If Integer.TryParse(qty2nd.Text, i) AndAlso Integer.TryParse(subty.Text, a) AndAlso Integer.TryParse(qty2.Text, b) AndAlso Integer.TryParse(qty_01.Text, c) Then
            qty2nd.Text = CStr(i + a)
        Else
            MessageBox.Show("Please enter a number in both boxes.")
        End If
        b += 1
        c += 1

        qty2.Text = b.ToString
        qty_01.Text = c.ToString
    End Sub

   
   

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'subty.Text = Val(qty2nd.Text) - Val(qty2.Text)
        'qty2nd.Text = subty.Text
       
        Dim a As Integer
        Dim b As Integer
        Dim i As Integer
        Dim c As Integer

        If Integer.TryParse(qty2nd.Text, i) AndAlso Integer.TryParse(subty.Text, a) AndAlso Integer.TryParse(qty2.Text, b) AndAlso Integer.TryParse(qty_01.Text, c) Then
            qty2nd.Text = CStr(i - a)
        Else
            MessageBox.Show("Please enter a number in both boxes.")
        End If
        b -= 1
        c -= 1

        qty2.Text = b.ToString
        qty_01.Text = c.ToString
    End Sub

    Private Sub subty_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As Integer
        Dim b As Integer
        Dim i As Integer
        Dim c As Integer

        If Integer.TryParse(qty1st.Text, i) AndAlso Integer.TryParse(subty.Text, a) AndAlso Integer.TryParse(qty1.Text, b) AndAlso Integer.TryParse(qty_01.Text, c) Then
            qty1st.Text = CStr(i + a)
        Else
            'MessageBox.Show("Please enter a number in both boxes.")
        End If
        b += 1
        c += 1

        qty1.Text = b.ToString
        qty_01.Text = c.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As Integer
        Dim b As Integer
        Dim i As Integer
        Dim c As Integer

        If Integer.TryParse(qty1st.Text, i) AndAlso Integer.TryParse(subty.Text, a) AndAlso Integer.TryParse(qty1.Text, b) AndAlso Integer.TryParse(qty_01.Text, c) Then
            qty1st.Text = CStr(i - a)
        Else
            MessageBox.Show("Please enter a number in both boxes.")
        End If
        b -= 1
        c -= 1

        qty1.Text = b.ToString
        qty_01.Text = c.ToString
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim a As Integer
        Dim b As Integer
        Dim i As Integer
        Dim c As Integer

        If Integer.TryParse(qty3rd.Text, i) AndAlso Integer.TryParse(subty.Text, a) AndAlso Integer.TryParse(qty3.Text, b) AndAlso Integer.TryParse(qty_01.Text, c) Then
            qty3rd.Text = CStr(i + a)
        Else
            MessageBox.Show("Please enter a number in both boxes.")
        End If
        b += 1
        c += 1

        qty3.Text = b.ToString
        qty_01.Text = c.ToString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim a As Integer
        Dim b As Integer
        Dim i As Integer
        Dim c As Integer

        If Integer.TryParse(qty3rd.Text, i) AndAlso Integer.TryParse(subty.Text, a) AndAlso Integer.TryParse(qty3.Text, b) AndAlso Integer.TryParse(qty_01.Text, c) Then
            qty3rd.Text = CStr(i - a)
        Else
            MessageBox.Show("Please enter a number in both boxes.")
        End If
        b -= 1
        c -= 1

        qty3.Text = b.ToString
        qty_01.Text = c.ToString
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim a As Integer
        Dim b As Integer
        Dim i As Integer
        Dim c As Integer

        If Integer.TryParse(qty4th.Text, i) AndAlso Integer.TryParse(subty.Text, a) AndAlso Integer.TryParse(qty4.Text, b) AndAlso Integer.TryParse(qty_01.Text, c) Then
            qty4th.Text = CStr(i + a)

        Else
            MessageBox.Show("Please enter a number in both boxes.")
        End If
        b += 1
        c += 1
        qty4.Text = b.ToString

        qty_01.Text = c.ToString

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
       

        Dim a As Integer
        Dim b As Integer
        Dim i As Integer
        Dim c As Integer

        If Integer.TryParse(qty4th.Text, i) AndAlso Integer.TryParse(subty.Text, a) AndAlso Integer.TryParse(qty4.Text, b) AndAlso Integer.TryParse(qty_01.Text, c) Then
            qty4th.Text = CStr(i - a)

        Else
            MessageBox.Show("Please enter a number in both boxes.")
        End If
        b -= 1
        c -= 1
        qty4.Text = b.ToString

        qty_01.Text = c.ToString

    End Sub

   
    Private Sub total_txt_TextChanged(sender As Object, e As EventArgs) Handles total_txt.TextChanged

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        cm.Position = 0
        showpositions()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        cm.Position = cm.Position - 1
        showpositions()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        cm.Position = cm.Position + 1
        showpositions()
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        cm.Position = cm.Count - 1
        showpositions()
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Close()

      
        ViewForm.q_11()
        ViewForm.q_21()
        ViewForm.q_31()
        ViewForm.q_41()
        ViewForm.total_amnt1()

        Dim cc As Decimal = ViewForm.amount_01.Text
        ViewForm.amount_01.Text = cc.ToString("#,0.00")

        Dim dd As Decimal = ViewForm.amount_02.Text
        ViewForm.amount_02.Text = dd.ToString("#,0.00")

        Dim ff As Decimal = ViewForm.amount_03.Text
        ViewForm.amount_03.Text = ff.ToString("#,0.00")

        Dim gg As Decimal = ViewForm.amount_04.Text
        ViewForm.amount_04.Text = gg.ToString("#,0.00")

        Dim hh As Decimal = ViewForm.totalcost_txt1.Text
        ViewForm.totalcost_txt1.Text = hh.ToString("#,0.00")

    End Sub

    Private Sub po_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles po.TextChanged, SELECTTXT.TextChanged
        po.Text = SELECTTXT.Text

    End Sub

    Private Sub binding_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles binding.TextChanged, po.TextChanged, tail_po.TextChanged
        binding.Text = po.Text & tail_po.Text
    End Sub
End Class