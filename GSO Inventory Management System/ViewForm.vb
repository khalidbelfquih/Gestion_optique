Imports MySql.Data.MySqlClient
Public Class ViewForm
    'Dim conn As New MySqlConnection("server=localhost; user id=root; password='admin'; database=gso_db")
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdata()
        RoundedButtons(generate_btn)

        q_11()
        q_21()
        q_31()
        q_41()
        total_amnt1()

        Dim cc As Decimal = amount_01.Text
        amount_01.Text = cc.ToString("#,0.00")

        Dim dd As Decimal = amount_02.Text
        amount_02.Text = dd.ToString("#,0.00")

        Dim ff As Decimal = amount_03.Text
        amount_03.Text = ff.ToString("#,0.00")

        Dim gg As Decimal = amount_04.Text
        amount_04.Text = gg.ToString("#,0.00")



        counttxt.Text = DataGridView1.RowCount
        update_user()
        logs_id()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DataGridView1.Rows(e.RowIndex)
            updateform.productno.Text = row.Cells("Product No").Value
            updateform.idtxt.Text = row.Cells("item #").Value
            updateform1.idtxt_1.Text = row.Cells("Product No").Value
            updateform1.pr_no.Text = row.Cells("Product No").Value




            q_11()
            q_21()
            q_31()
            q_41()
            total_amnt1()

            Dim cc As Decimal = amount_01.Text
            amount_01.Text = cc.ToString("#,0.00")

            Dim dd As Decimal = amount_02.Text
            amount_02.Text = dd.ToString("#,0.00")

            Dim ff As Decimal = amount_03.Text
            amount_03.Text = ff.ToString("#,0.00")

            Dim gg As Decimal = amount_04.Text
            amount_04.Text = gg.ToString("#,0.00")

            Dim hh As Decimal = totalcost_txt1.Text
            totalcost_txt1.Text = hh.ToString("#,0.00")
        End If
    End Sub
    Sub q_11()
        Dim num As Decimal

        Try
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select sum(amnt1) from " & departmenttxt.Text & " ", conn)
            cmd.ExecuteNonQuery()
            If IsDBNull(cmd.ExecuteScalar) Then
                num = 0
                amount_01.Text = num.ToString
            Else
                num = cmd.ExecuteScalar
                amount_01.Text = num.ToString

            End If
            amount_01.Text = String.Format("{0}", num)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub q_21()
        Dim num As Decimal

        Try
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select sum(amnt2) from " & departmenttxt.Text & " ", conn)
            cmd.ExecuteNonQuery()
            If IsDBNull(cmd.ExecuteScalar) Then
                num = 0
                amount_02.Text = num.ToString
            Else
                num = cmd.ExecuteScalar
                amount_02.Text = num.ToString

            End If
            amount_02.Text = String.Format("{0}", num)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub q_31()
        Dim num As Decimal

        Try
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select sum(amnt3) from " & departmenttxt.Text & " ", conn)
            cmd.ExecuteNonQuery()
            If IsDBNull(cmd.ExecuteScalar) Then
                num = 0
                amount_03.Text = num.ToString
            Else
                num = cmd.ExecuteScalar
                amount_03.Text = num.ToString

            End If
            amount_03.Text = String.Format("{0}", num)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub q_41()
        Dim num As Decimal

        Try
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select sum(amnt4) from " & departmenttxt.Text & " ", conn)
            cmd.ExecuteNonQuery()
            If IsDBNull(cmd.ExecuteScalar) Then
                num = 0
                amount_04.Text = num.ToString
            Else
                num = cmd.ExecuteScalar
                amount_04.Text = num.ToString

            End If
            amount_04.Text = String.Format("{0}", num)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub total_amnt1()
        Dim num As Decimal

        Try
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select sum(total_cost) from " & departmenttxt.Text & " ", conn)
            cmd.ExecuteNonQuery()
            If IsDBNull(cmd.ExecuteScalar) Then
                num = 0
                totalcost_txt1.Text = num
            Else
                num = cmd.ExecuteScalar
                totalcost_txt1.Text = num

            End If
            totalcost_txt1.Text = String.Format("{0}", num)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    
    End Sub
    Sub showdata()

        Dim ss As String = departmenttxt.Text
        Try
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select no as `Item #`,date_issue as `Date of Issue`,product_no as `Product No`,description as `Description`,qty as `Quantity`,unit_of_issue as `Unit of Issue`,unit_price as `Unit Price`,total_cost as `Total Cost`,mode_of_procure as `Mode of Procurement`,qty1 as `1st Quarter (Quantity)`,amnt1 as `1st Quarter (Amount)`,qty2 as `2nd Quarter (Quantity)`,amnt2 as `2nd Quarter (Amount)`,qty3 as `3rd Quarter (Quantity)`,amnt3 as `3rd Quarter (Amount)`,qty4 as `4th Quarter (Quantity)`,amnt4 as `4th Quarter (Amount)`,jan as `Jan`,feb as `Feb`, mar as `Mar`, apr as `Apr`, May as `May`, Jun as `Jun`, Jul as `Jul`,aug as `Aug`, sep as `Sep`, oct as `Oct`, nov as `Nov`,dece as `Dec` from " & ss & "", conn)
            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Columns("Description").Width = 250
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub showdata1()

        Dim ss As String = departmenttxt.Text
        Try
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select no as `Item #`,date_issue as `Date of Issue`,product_no as `Product No`,description as `Description`,(qty1 + qty2) as `QTY`,unit_of_issue as `Unit of Issue`,unit_price as `Unit Price`,(qty1 + qty2) * unit_price as `Total Cost`,mode_of_procure as `Mode of Procurement`,qty1 as `1st Quarter (Quantity)`,amnt1 as `1st Quarter (Amount)`,qty2 as `2nd Quarter (Quantity)`,amnt2 as `2nd Quarter (Amount)`,qty3 as `3rd Quarter (Quantity)`,amnt3 as `3rd Quarter (Amount)`,qty4 as `4th Quarter (Quantity)`,amnt4 as `4th Quarter (Amount)`,jan as `Jan`,feb as `Feb`, mar as `Mar`, apr as `Apr`, May as `May`, Jun as `Jun`, Jul as `Jul`,aug as `Aug`, sep as `Sep`, oct as `Oct`, nov as `Nov`,dece as `Dec` from " & ss & "", conn)
            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Columns("Description").Width = 250
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub UpdateInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateInformationToolStripMenuItem.Click
        updateform.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub UpdateInformationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateInformationToolStripMenuItem1.Click
        updateform1.ShowDialog()

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
       
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        showdata()
        Label3.Text = "0"

        q_11()
        q_21()
        q_31()
        q_41()
        total_amnt1()

        Dim cc As Decimal = amount_01.Text
        amount_01.Text = cc.ToString("#,0.00")

        Dim dd As Decimal = amount_02.Text
        amount_02.Text = dd.ToString("#,0.00")

        Dim ff As Decimal = amount_03.Text
        amount_03.Text = ff.ToString("#,0.00")

        Dim gg As Decimal = amount_04.Text
        amount_04.Text = gg.ToString("#,0.00")

        Dim hh As Decimal = totalcost_txt1.Text
        totalcost_txt1.Text = hh.ToString("#,0.00")

    End Sub

    Private Sub PPMPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PPMPToolStripMenuItem.Click
        'Dim dtable As New DataTable
        'dtable.Columns.Add("#", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Date Issue", Type.GetType("System.String"))
        'dtable.Columns.Add("Product No", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Description", Type.GetType("System.String"))
        'dtable.Columns.Add("Quantity", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Unit of Issue", Type.GetType("System.String"))
        'dtable.Columns.Add("Unit Price", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Total Cost", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Mode of Procurement", Type.GetType("System.String"))
        'dtable.Columns.Add("1st Quarter (Quantity)", Type.GetType("System.Int32"))
        'dtable.Columns.Add("1st Quarter (Amount)", Type.GetType("System.Int32"))
        'dtable.Columns.Add("2nd Quarter (Quantity)", Type.GetType("System.Int32"))
        'dtable.Columns.Add("2nd Quarter (Amount)", Type.GetType("System.Int32"))
        'dtable.Columns.Add("3rd Quarter (Quantity)", Type.GetType("System.Int32"))
        'dtable.Columns.Add("3rd Quarter (Amount)", Type.GetType("System.Int32"))
        'dtable.Columns.Add("4th Quarter (Quantity)", Type.GetType("System.Int32"))
        'dtable.Columns.Add("4th Quarter (Amount)", Type.GetType("System.Int32"))

        'For Each row As DataGridViewRow In DataGridView1.Rows
        '    dtable.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value, row.Cells(10).Value, row.Cells(11).Value, row.Cells(12).Value, row.Cells(13).Value, row.Cells(14).Value, row.Cells(15).Value, row.Cells(16).Value)
        'Next
        'Dim cryds As New PrintingReports_01
        'cryds.SetDataSource(dtable)

        'PrintForm.CrystalReportViewer1.ReportSource = cryds
        'cryds.SetParameterValue("p1", amount_01.Text)
        'cryds.SetParameterValue("p2", amount_02.Text)
        'cryds.SetParameterValue("p3", amount_03.Text)
        'cryds.SetParameterValue("p4", amount_04.Text)
        'cryds.SetParameterValue("totalp", totalcost_txt1.Text)
        PrintForm.Show()

        'Dim cc As Decimal = amount_01.Text
        'amount_01.Text = cc.ToString("#,0.00")

        'Dim dd As Decimal = amount_02.Text
        'amount_02.Text = dd.ToString("#,0.00")

        'Dim ff As Decimal = amount_03.Text
        'amount_03.Text = ff.ToString("#,0.00")

        'Dim gg As Decimal = amount_04.Text
        'amount_04.Text = gg.ToString("#,0.00")

        'Dim hh As Decimal = totalcost_txt1.Text
        'totalcost_txt1.Text = hh.ToString("#,0.00")
    End Sub

    Private Sub PPMPToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PPMPToolStripMenuItem1.Click
        'Dim dtable As New DataTable

        'dtable.Columns.Add("#", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Date Issue", Type.GetType("System.String"))
        'dtable.Columns.Add("Product No", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Description", Type.GetType("System.String"))
        'dtable.Columns.Add("Quantity", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Unit of Issue", Type.GetType("System.String"))
        'dtable.Columns.Add("Unit Price", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Total Cost", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Mode of Procurement", Type.GetType("System.String"))
        'dtable.Columns.Add("1st Quarter (Quantity)", Type.GetType("System.Int32"))
        'dtable.Columns.Add("1st Quarter (Amount)", Type.GetType("System.Int32"))
        'dtable.Columns.Add("2nd Quarter (Quantity)", Type.GetType("System.Int32"))
        'dtable.Columns.Add("2nd Quarter (Amount)", Type.GetType("System.Int32"))
        'dtable.Columns.Add("3rd Quarter (Quantity)", Type.GetType("System.Int32"))
        'dtable.Columns.Add("3rd Quarter (Amount)", Type.GetType("System.Int32"))
        'dtable.Columns.Add("4th Quarter (Quantity)", Type.GetType("System.Int32"))
        'dtable.Columns.Add("4th Quarter (Amount)", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Jan", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Feb", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Mar", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Apr", Type.GetType("System.Int32"))
        'dtable.Columns.Add("May", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Jun", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Jul", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Aug", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Sep", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Oct", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Nov", Type.GetType("System.Int32"))
        'dtable.Columns.Add("Dece", Type.GetType("System.Int32"))

        'For Each row As DataGridViewRow In DataGridView1.Rows
        '    dtable.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value, row.Cells(10).Value, row.Cells(11).Value, row.Cells(12).Value, row.Cells(13).Value, row.Cells(14).Value, row.Cells(15).Value, row.Cells(16).Value, row.Cells(17).Value, row.Cells(18).Value, row.Cells(19).Value, row.Cells(20).Value, row.Cells(21).Value, row.Cells(22).Value, row.Cells(23).Value, row.Cells(24).Value, row.Cells(25).Value, row.Cells(26).Value, row.Cells(27).Value, row.Cells(28).Value)
        'Next
        'Dim cryds As New PrintingReports_user_1

        'cryds.SetDataSource(dtable)
        'PrintForm.CrystalReportViewer1.ReportSource = cryds
        'cryds.SetParameterValue("p1", amount_01.Text)
        'cryds.SetParameterValue("p2", amount_02.Text)
        'cryds.SetParameterValue("p3", amount_03.Text)
        'cryds.SetParameterValue("p4", amount_04.Text)
        'cryds.SetParameterValue("totalp", totalcost_txt1.Text)

        PrintPPMP.Show()

        'Dim cc As Decimal = amount_01.Text
        'amount_01.Text = cc.ToString("#,0.00")

        'Dim dd As Decimal = amount_02.Text
        'amount_02.Text = dd.ToString("#,0.00")

        'Dim ff As Decimal = amount_03.Text
        'amount_03.Text = ff.ToString("#,0.00")

        'Dim gg As Decimal = amount_04.Text
        'amount_04.Text = gg.ToString("#,0.00")

        'Dim hh As Decimal = totalcost_txt1.Text
        'totalcost_txt1.Text = hh.ToString("#,0.00")

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
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            LoginForm.Show()
            Me.Hide()
        End If


        conn.Open()
        cmd = New MySqlCommand("update logs set logout='" & timetxt.Text & "' where log_id='" & idtxt.Text & "'", conn)
        cmd.ExecuteNonQuery()

        conn.Close()

    End Sub

    Private Sub select_cmb_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles select_cmb_2.SelectedIndexChanged
        If select_cmb_2.SelectedIndex = 0 Then

            Dim ss As String = departmenttxt.Text

            Try
                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("select no as `Item #`,date_issue as `Date of Issue`,product_no as `Product No`,description as `Description`,(qty1 + qty2) as `Quantity`,unit_of_issue as `Unit of Issue`,unit_price as `Unit Price`,(qty1 + qty2) * unit_price as `Total Cost`,mode_of_procure as `Mode of Procurement`,qty1 as `1st Quarter (Quantity)`,amnt1 as `1st Quarter (Amount)`,qty2 as `2nd Quarter (Quantity)`,amnt2 as `2nd Quarter (Amount)`,qty3 as `3rd Quarter (Quantity)`,amnt3 as `3rd Quarter (Amount)`,qty4 as `4th Quarter (Quantity)`,amnt4 as `4th Quarter (Amount)`,jan as `Jan`,feb as `Feb`, mar as `Mar`, apr as `Apr`, May as `May`, Jun as `Jun`, Jul as `Jul`,aug as `Aug`, sep as `Sep`, oct as `Oct`, nov as `Nov`,dece as `Dec` from " & ss & "", conn)
                da.SelectCommand = cmd
                dt.Clear()
                da.Fill(dt)
                DataGridView1.DataSource = dt
                DataGridView1.Columns("Description").Width = 250
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try

         

            Dim num As Decimal = 0
            For i As Decimal = 0 To DataGridView1.Rows.Count - 1 Step +1
                num = num + DataGridView1.Rows(i).Cells(7).Value
            Next
            Label3.Text = num.ToString()


            Dim aa As Decimal = Label3.Text
            Label3.Text = aa.ToString("#,0.00")

        ElseIf select_cmb_2.SelectedIndex = 1 Then

            Dim ss As String = departmenttxt.Text

            Try
                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("select no as `Item #`,date_issue as `Date of Issue`,product_no as `Product No`,description as `Description`,(qty3 + qty4) as `Quantity`,unit_of_issue as `Unit of Issue`,unit_price as `Unit Price`,(qty3 + qty4) * unit_price as `Total Cost`,mode_of_procure as `Mode of Procurement`,qty1 as `1st Quarter (Quantity)`,amnt1 as `1st Quarter (Amount)`,qty2 as `2nd Quarter (Quantity)`,amnt2 as `2nd Quarter (Amount)`,qty3 as `3rd Quarter (Quantity)`,amnt3 as `3rd Quarter (Amount)`,qty4 as `4th Quarter (Quantity)`,amnt4 as `4th Quarter (Amount)`,jan as `Jan`,feb as `Feb`, mar as `Mar`, apr as `Apr`, May as `May`, Jun as `Jun`, Jul as `Jul`,aug as `Aug`, sep as `Sep`, oct as `Oct`, nov as `Nov`,dece as `Dec` from " & ss & "", conn)
                da.SelectCommand = cmd
                dt.Clear()
                da.Fill(dt)
                DataGridView1.DataSource = dt
                DataGridView1.Columns("Description").Width = 250
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try



            Dim num As Decimal = 0
            For i As Decimal = 0 To DataGridView1.Rows.Count - 1 Step +1
                num = num + DataGridView1.Rows(i).Cells(7).Value
            Next
            Label3.Text = num.ToString()


            Dim aa As Decimal = Label3.Text
            Label3.Text = aa.ToString("#,0.00")

        ElseIf select_cmb_2.SelectedIndex = 2 Then

            Dim ss As String = departmenttxt.Text

            Try
                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("select no as `Item #`,date_issue as `Date of Issue`,product_no as `Product No`,description as `Description`,qty1 as `Quantity`,unit_of_issue as `Unit of Issue`,unit_price as `Unit Price`,(qty1 * unit_price) as `Total Cost`,mode_of_procure as `Mode of Procurement`,qty1 as `1st Quarter (Quantity)`,amnt1 as `1st Quarter (Amount)`,qty2 as `2nd Quarter (Quantity)`,amnt2 as `2nd Quarter (Amount)`,qty3 as `3rd Quarter (Quantity)`,amnt3 as `3rd Quarter (Amount)`,qty4 as `4th Quarter (Quantity)`,amnt4 as `4th Quarter (Amount)`,jan as `Jan`,feb as `Feb`, mar as `Mar`, apr as `Apr`, May as `May`, Jun as `Jun`, Jul as `Jul`,aug as `Aug`, sep as `Sep`, oct as `Oct`, nov as `Nov`,dece as `Dec` from " & ss & "", conn)
                da.SelectCommand = cmd
                dt.Clear()
                da.Fill(dt)
                DataGridView1.DataSource = dt
                DataGridView1.Columns("Description").Width = 250
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try



            Dim num As Decimal = 0
            For i As Decimal = 0 To DataGridView1.Rows.Count - 1 Step +1
                num = num + DataGridView1.Rows(i).Cells(7).Value
            Next
            Label3.Text = num.ToString()


            Dim aa As Decimal = Label3.Text
            Label3.Text = aa.ToString("#,0.00")

        ElseIf select_cmb_2.SelectedIndex = 3 Then

            Dim ss As String = departmenttxt.Text

            Try
                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("select no as `Item #`,date_issue as `Date of Issue`,product_no as `Product No`,description as `Description`,qty2 as `Quantity`,unit_of_issue as `Unit of Issue`,unit_price as `Unit Price`,(qty2 * unit_price) as `Total Cost`,mode_of_procure as `Mode of Procurement`,qty1 as `1st Quarter (Quantity)`,amnt1 as `1st Quarter (Amount)`,qty2 as `2nd Quarter (Quantity)`,amnt2 as `2nd Quarter (Amount)`,qty3 as `3rd Quarter (Quantity)`,amnt3 as `3rd Quarter (Amount)`,qty4 as `4th Quarter (Quantity)`,amnt4 as `4th Quarter (Amount)`,jan as `Jan`,feb as `Feb`, mar as `Mar`, apr as `Apr`, May as `May`, Jun as `Jun`, Jul as `Jul`,aug as `Aug`, sep as `Sep`, oct as `Oct`, nov as `Nov`,dece as `Dec` from " & ss & "", conn)
                da.SelectCommand = cmd
                dt.Clear()
                da.Fill(dt)
                DataGridView1.DataSource = dt
                DataGridView1.Columns("Description").Width = 250
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try



            Dim num As Decimal = 0
            For i As Decimal = 0 To DataGridView1.Rows.Count - 1 Step +1
                num = num + DataGridView1.Rows(i).Cells(7).Value
            Next
            Label3.Text = num.ToString()


            Dim aa As Decimal = Label3.Text
            Label3.Text = aa.ToString("#,0.00")

        ElseIf select_cmb_2.SelectedIndex = 4 Then

            Dim ss As String = departmenttxt.Text

            Try
                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("select no as `Item #`,date_issue as `Date of Issue`,product_no as `Product No`,description as `Description`,qty3 as `Quantity`,unit_of_issue as `Unit of Issue`,unit_price as `Unit Price`,(qty3 * unit_price) as `Total Cost`,mode_of_procure as `Mode of Procurement`,qty1 as `1st Quarter (Quantity)`,amnt1 as `1st Quarter (Amount)`,qty2 as `2nd Quarter (Quantity)`,amnt2 as `2nd Quarter (Amount)`,qty3 as `3rd Quarter (Quantity)`,amnt3 as `3rd Quarter (Amount)`,qty4 as `4th Quarter (Quantity)`,amnt4 as `4th Quarter (Amount)`,jan as `Jan`,feb as `Feb`, mar as `Mar`, apr as `Apr`, May as `May`, Jun as `Jun`, Jul as `Jul`,aug as `Aug`, sep as `Sep`, oct as `Oct`, nov as `Nov`,dece as `Dec` from " & ss & "", conn)
                da.SelectCommand = cmd
                dt.Clear()
                da.Fill(dt)
                DataGridView1.DataSource = dt
                DataGridView1.Columns("Description").Width = 250
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try



            Dim num As Decimal = 0
            For i As Decimal = 0 To DataGridView1.Rows.Count - 1 Step +1
                num = num + DataGridView1.Rows(i).Cells(7).Value
            Next
            Label3.Text = num.ToString()


            Dim aa As Decimal = Label3.Text
            Label3.Text = aa.ToString("#,0.00")

        ElseIf select_cmb_2.SelectedIndex = 5 Then

            Dim ss As String = departmenttxt.Text

            Try
                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("select no as `Item #`,date_issue as `Date of Issue`,product_no as `Product No`,description as `Description`,qty4 as `Quantity`,unit_of_issue as `Unit of Issue`,unit_price as `Unit Price`,(qty4 * unit_price) as `Total Cost`,mode_of_procure as `Mode of Procurement`,qty1 as `1st Quarter (Quantity)`,amnt1 as `1st Quarter (Amount)`,qty2 as `2nd Quarter (Quantity)`,amnt2 as `2nd Quarter (Amount)`,qty3 as `3rd Quarter (Quantity)`,amnt3 as `3rd Quarter (Amount)`,qty4 as `4th Quarter (Quantity)`,amnt4 as `4th Quarter (Amount)`,jan as `Jan`,feb as `Feb`, mar as `Mar`, apr as `Apr`, May as `May`, Jun as `Jun`, Jul as `Jul`,aug as `Aug`, sep as `Sep`, oct as `Oct`, nov as `Nov`,dece as `Dec` from " & ss & "", conn)
                da.SelectCommand = cmd
                dt.Clear()
                da.Fill(dt)
                DataGridView1.DataSource = dt
                DataGridView1.Columns("Description").Width = 250
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try



            Dim num As Decimal = 0
            For i As Decimal = 0 To DataGridView1.Rows.Count - 1 Step +1
                num = num + DataGridView1.Rows(i).Cells(7).Value
            Next
            Label3.Text = num.ToString()


            Dim aa As Decimal = Label3.Text
            Label3.Text = aa.ToString("#,0.00")

        ElseIf select_cmb_2.SelectedIndex = 6 Then

            Dim ss As String = departmenttxt.Text

            Try
                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("select no as `Item #`,date_issue as `Date of Issue`,product_no as `Product No`,description as `Description`,(qty1 + qty2 + qty3 + qty4) as `Quantity`,unit_of_issue as `Unit of Issue`,unit_price as `Unit Price`,(qty1 + qty2 + qty3 + qty4) * unit_price as `Total Cost`,mode_of_procure as `Mode of Procurement`,qty1 as `1st Quarter (Quantity)`,amnt1 as `1st Quarter (Amount)`,qty2 as `2nd Quarter (Quantity)`,amnt2 as `2nd Quarter (Amount)`,qty3 as `3rd Quarter (Quantity)`,amnt3 as `3rd Quarter (Amount)`,qty4 as `4th Quarter (Quantity)`,amnt4 as `4th Quarter (Amount)`,jan as `Jan`,feb as `Feb`, mar as `Mar`, apr as `Apr`, May as `May`, Jun as `Jun`, Jul as `Jul`,aug as `Aug`, sep as `Sep`, oct as `Oct`, nov as `Nov`,dece as `Dec` from " & ss & "", conn)
                da.SelectCommand = cmd
                dt.Clear()
                da.Fill(dt)
                DataGridView1.DataSource = dt
                DataGridView1.Columns("Description").Width = 250
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try



            Dim num As Decimal = 0
            For i As Decimal = 0 To DataGridView1.Rows.Count - 1 Step +1
                num = num + DataGridView1.Rows(i).Cells(7).Value
            Next
            Label3.Text = num.ToString()


            Dim aa As Decimal = Label3.Text
            Label3.Text = aa.ToString("#,0.00")

        End If

        Try
            conn.Open()
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                cmd = New MySqlCommand("UPDATE " & bind2.Text & " set description=@description,qty=@qty,unit_of_issue=@unit_of_issue,unit_price=@unit_price,total_cost=@total_cost where no=@no", conn)
                cmd.Parameters.AddWithValue("@no", DataGridView1.Rows(i).Cells(0).Value)
                cmd.Parameters.AddWithValue("@description", DataGridView1.Rows(i).Cells(3).Value)
                cmd.Parameters.AddWithValue("@qty", DataGridView1.Rows(i).Cells(4).Value)
                cmd.Parameters.AddWithValue("@unit_of_issue", DataGridView1.Rows(i).Cells(5).Value)
                cmd.Parameters.AddWithValue("@unit_price", DataGridView1.Rows(i).Cells(6).Value)
                cmd.Parameters.AddWithValue("@total_cost", DataGridView1.Rows(i).Cells(7).Value)

                cmd.ExecuteNonQuery()
            Next
            'MsgBox("Successfully update data...")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            update_po()

        End Try
    End Sub

    Sub kwentada()
        Dim num As Integer
        Try
            conn.Open()
            cmd = New MySqlCommand("select (qty1 + qty2) * unit_price, sum(total_cost) from " & departmenttxt.Text & "", conn)
            cmd.ExecuteNonQuery()
            If IsDBNull(cmd.ExecuteScalar) Then
                num = 0
                Label3.Text = num.ToString
            Else
                num = cmd.ExecuteScalar
                Label3.Text = num.ToString
            End If
            Label3.Text = String.Format("{0}", num)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub generate_btn_Click(sender As Object, e As EventArgs) Handles generate_btn.Click
        If select_cmb_2.SelectedIndex = 0 Then
            Dim dtable As New DataTable
            dtable.Columns.Add("#", Type.GetType("System.Int32"))
            dtable.Columns.Add("Date Issue", Type.GetType("System.String"))
            dtable.Columns.Add("Product No", Type.GetType("System.Int32"))
            dtable.Columns.Add("Description", Type.GetType("System.String"))
            dtable.Columns.Add("Quantity", Type.GetType("System.Int32"))
            dtable.Columns.Add("Unit of Issue", Type.GetType("System.String"))
            dtable.Columns.Add("Unit Price", Type.GetType("System.Int32"))
            dtable.Columns.Add("Total Cost", Type.GetType("System.Int32"))


            For Each row As DataGridViewRow In DataGridView1.Rows
                dtable.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value)
            Next
            Dim cryds As New PrintingReports_sub_09
            cryds.SetDataSource(dtable)

            PrintPR.CrystalReportViewer1.ReportSource = cryds
            cryds.SetParameterValue("Quarterly", select_cmb_2.Text)
            cryds.SetParameterValue("qty", Label3.Text)
            'cryds.SetParameterValue("p3", amount_03.Text)
            'cryds.SetParameterValue("p4", amount_04.Text)
            'cryds.SetParameterValue("totalp", totalcost_txt1.Text)
            PrintPR.Show()

            Dim cc As Decimal = amount_01.Text
            amount_01.Text = cc.ToString("#,0.00")

            Dim dd As Decimal = amount_02.Text
            amount_02.Text = dd.ToString("#,0.00")

            Dim ff As Decimal = amount_03.Text
            amount_03.Text = ff.ToString("#,0.00")

            Dim gg As Decimal = amount_04.Text
            amount_04.Text = gg.ToString("#,0.00")

            Dim hh As Decimal = totalcost_txt1.Text
            totalcost_txt1.Text = hh.ToString("#,0.00")


           

        ElseIf select_cmb_2.SelectedIndex = 1 Then
            Dim dtable As New DataTable
            dtable.Columns.Add("#", Type.GetType("System.Int32"))
            dtable.Columns.Add("Date Issue", Type.GetType("System.String"))
            dtable.Columns.Add("Product No", Type.GetType("System.Int32"))
            dtable.Columns.Add("Description", Type.GetType("System.String"))
            dtable.Columns.Add("Quantity", Type.GetType("System.Int32"))
            dtable.Columns.Add("Unit of Issue", Type.GetType("System.String"))
            dtable.Columns.Add("Unit Price", Type.GetType("System.Int32"))
            dtable.Columns.Add("Total Cost", Type.GetType("System.Int32"))


            For Each row As DataGridViewRow In DataGridView1.Rows
                dtable.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value)
            Next
            Dim cryds As New PrintingReports_sub_10
            cryds.SetDataSource(dtable)

            PrintPR.CrystalReportViewer1.ReportSource = cryds
            cryds.SetParameterValue("Quarterly", select_cmb_2.Text)
            cryds.SetParameterValue("qty", Label3.Text)
            'cryds.SetParameterValue("p3", amount_03.Text)
            'cryds.SetParameterValue("p4", amount_04.Text)
            'cryds.SetParameterValue("totalp", totalcost_txt1.Text)
            PrintPR.Show()

            Dim cc As Decimal = amount_01.Text
            amount_01.Text = cc.ToString("#,0.00")

            Dim dd As Decimal = amount_02.Text
            amount_02.Text = dd.ToString("#,0.00")

            Dim ff As Decimal = amount_03.Text
            amount_03.Text = ff.ToString("#,0.00")

            Dim gg As Decimal = amount_04.Text
            amount_04.Text = gg.ToString("#,0.00")

            Dim hh As Decimal = totalcost_txt1.Text
            totalcost_txt1.Text = hh.ToString("#,0.00")

        ElseIf select_cmb_2.SelectedIndex = 2 Then
            Dim dtable As New DataTable
            dtable.Columns.Add("#", Type.GetType("System.Int32"))
            dtable.Columns.Add("Date Issue", Type.GetType("System.String"))
            dtable.Columns.Add("Product No", Type.GetType("System.Int32"))
            dtable.Columns.Add("Description", Type.GetType("System.String"))
            dtable.Columns.Add("Quantity", Type.GetType("System.Int32"))
            dtable.Columns.Add("Unit of Issue", Type.GetType("System.String"))
            dtable.Columns.Add("Unit Price", Type.GetType("System.Int32"))
            dtable.Columns.Add("Total Cost", Type.GetType("System.Int32"))


            For Each row As DataGridViewRow In DataGridView1.Rows
                dtable.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value)
            Next
            Dim cryds As New PrintingReports_sub_11
            cryds.SetDataSource(dtable)

            PrintPR.CrystalReportViewer1.ReportSource = cryds
            cryds.SetParameterValue("Quarterly", select_cmb_2.Text)
            cryds.SetParameterValue("qty", Label3.Text)
            'cryds.SetParameterValue("p3", amount_03.Text)
            'cryds.SetParameterValue("p4", amount_04.Text)
            'cryds.SetParameterValue("totalp", totalcost_txt1.Text)
            PrintPR.Show()

            Dim cc As Decimal = amount_01.Text
            amount_01.Text = cc.ToString("#,0.00")

            Dim dd As Decimal = amount_02.Text
            amount_02.Text = dd.ToString("#,0.00")

            Dim ff As Decimal = amount_03.Text
            amount_03.Text = ff.ToString("#,0.00")

            Dim gg As Decimal = amount_04.Text
            amount_04.Text = gg.ToString("#,0.00")

            Dim hh As Decimal = totalcost_txt1.Text
            totalcost_txt1.Text = hh.ToString("#,0.00")

        ElseIf select_cmb_2.SelectedIndex = 3 Then

            Dim dtable As New DataTable
            dtable.Columns.Add("#", Type.GetType("System.Int32"))
            dtable.Columns.Add("Date Issue", Type.GetType("System.String"))
            dtable.Columns.Add("Product No", Type.GetType("System.Int32"))
            dtable.Columns.Add("Description", Type.GetType("System.String"))
            dtable.Columns.Add("Quantity", Type.GetType("System.Int32"))
            dtable.Columns.Add("Unit of Issue", Type.GetType("System.String"))
            dtable.Columns.Add("Unit Price", Type.GetType("System.Int32"))
            dtable.Columns.Add("Total Cost", Type.GetType("System.Int32"))


            For Each row As DataGridViewRow In DataGridView1.Rows
                dtable.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value)
            Next
            Dim cryds As New PrintingReports_sub_12
            cryds.SetDataSource(dtable)

            PrintPR.CrystalReportViewer1.ReportSource = cryds
            cryds.SetParameterValue("Quarterly", select_cmb_2.Text)
            cryds.SetParameterValue("qty", Label3.Text)
            'cryds.SetParameterValue("p3", amount_03.Text)
            'cryds.SetParameterValue("p4", amount_04.Text)
            'cryds.SetParameterValue("totalp", totalcost_txt1.Text)
            PrintPR.Show()

            Dim cc As Decimal = amount_01.Text
            amount_01.Text = cc.ToString("#,0.00")

            Dim dd As Decimal = amount_02.Text
            amount_02.Text = dd.ToString("#,0.00")

            Dim ff As Decimal = amount_03.Text
            amount_03.Text = ff.ToString("#,0.00")

            Dim gg As Decimal = amount_04.Text
            amount_04.Text = gg.ToString("#,0.00")

            Dim hh As Decimal = totalcost_txt1.Text
            totalcost_txt1.Text = hh.ToString("#,0.00")

        ElseIf select_cmb_2.SelectedIndex = 4 Then

            Dim dtable As New DataTable
            dtable.Columns.Add("#", Type.GetType("System.Int32"))
            dtable.Columns.Add("Date Issue", Type.GetType("System.String"))
            dtable.Columns.Add("Product No", Type.GetType("System.Int32"))
            dtable.Columns.Add("Description", Type.GetType("System.String"))
            dtable.Columns.Add("Quantity", Type.GetType("System.Int32"))
            dtable.Columns.Add("Unit of Issue", Type.GetType("System.String"))
            dtable.Columns.Add("Unit Price", Type.GetType("System.Int32"))
            dtable.Columns.Add("Total Cost", Type.GetType("System.Int32"))


            For Each row As DataGridViewRow In DataGridView1.Rows
                dtable.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value)
            Next
            Dim cryds As New PrintingReports_sub_13
            cryds.SetDataSource(dtable)

            PrintPR.CrystalReportViewer1.ReportSource = cryds
            cryds.SetParameterValue("Quarterly", select_cmb_2.Text)
            cryds.SetParameterValue("qty", Label3.Text)
            'cryds.SetParameterValue("p3", amount_03.Text)
            'cryds.SetParameterValue("p4", amount_04.Text)
            'cryds.SetParameterValue("totalp", totalcost_txt1.Text)
            PrintPR.Show()

            Dim cc As Decimal = amount_01.Text
            amount_01.Text = cc.ToString("#,0.00")

            Dim dd As Decimal = amount_02.Text
            amount_02.Text = dd.ToString("#,0.00")

            Dim ff As Decimal = amount_03.Text
            amount_03.Text = ff.ToString("#,0.00")

            Dim gg As Decimal = amount_04.Text
            amount_04.Text = gg.ToString("#,0.00")

            Dim hh As Decimal = totalcost_txt1.Text
            totalcost_txt1.Text = hh.ToString("#,0.00")

        ElseIf select_cmb_2.SelectedIndex = 5 Then

            Dim dtable As New DataTable
            dtable.Columns.Add("#", Type.GetType("System.Int32"))
            dtable.Columns.Add("Date Issue", Type.GetType("System.String"))
            dtable.Columns.Add("Product No", Type.GetType("System.Int32"))
            dtable.Columns.Add("Description", Type.GetType("System.String"))
            dtable.Columns.Add("Quantity", Type.GetType("System.Int32"))
            dtable.Columns.Add("Unit of Issue", Type.GetType("System.String"))
            dtable.Columns.Add("Unit Price", Type.GetType("System.Int32"))
            dtable.Columns.Add("Total Cost", Type.GetType("System.Int32"))


            For Each row As DataGridViewRow In DataGridView1.Rows
                dtable.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value)
            Next
            Dim cryds As New PrintingReports_sub_14
            cryds.SetDataSource(dtable)

            PrintPR.CrystalReportViewer1.ReportSource = cryds
            cryds.SetParameterValue("Quarterly", select_cmb_2.Text)
            cryds.SetParameterValue("qty", Label3.Text)
            'cryds.SetParameterValue("p3", amount_03.Text)
            'cryds.SetParameterValue("p4", amount_04.Text)
            'cryds.SetParameterValue("totalp", totalcost_txt1.Text)
            PrintPR.Show()

            Dim cc As Decimal = amount_01.Text
            amount_01.Text = cc.ToString("#,0.00")

            Dim dd As Decimal = amount_02.Text
            amount_02.Text = dd.ToString("#,0.00")

            Dim ff As Decimal = amount_03.Text
            amount_03.Text = ff.ToString("#,0.00")

            Dim gg As Decimal = amount_04.Text
            amount_04.Text = gg.ToString("#,0.00")

            Dim hh As Decimal = totalcost_txt1.Text
            totalcost_txt1.Text = hh.ToString("#,0.00")

        ElseIf select_cmb_2.SelectedIndex = 6 Then

            Dim dtable As New DataTable
            dtable.Columns.Add("#", Type.GetType("System.Int32"))
            dtable.Columns.Add("Date Issue", Type.GetType("System.String"))
            dtable.Columns.Add("Product No", Type.GetType("System.Int32"))
            dtable.Columns.Add("Description", Type.GetType("System.String"))
            dtable.Columns.Add("Quantity", Type.GetType("System.Int32"))
            dtable.Columns.Add("Unit of Issue", Type.GetType("System.String"))
            dtable.Columns.Add("Unit Price", Type.GetType("System.Int32"))
            dtable.Columns.Add("Total Cost", Type.GetType("System.Int32"))


            For Each row As DataGridViewRow In DataGridView1.Rows
                dtable.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value)
            Next
            Dim cryds As New PrintingReports_sub_14
            cryds.SetDataSource(dtable)

            PrintPR.CrystalReportViewer1.ReportSource = cryds
            cryds.SetParameterValue("Quarterly", select_cmb_2.Text)
            cryds.SetParameterValue("qty", Label3.Text)
            'cryds.SetParameterValue("p3", amount_03.Text)
            'cryds.SetParameterValue("p4", amount_04.Text)
            'cryds.SetParameterValue("totalp", totalcost_txt1.Text)
            PrintPR.Show()

            Dim cc As Decimal = amount_01.Text
            amount_01.Text = cc.ToString("#,0.00")

            Dim dd As Decimal = amount_02.Text
            amount_02.Text = dd.ToString("#,0.00")

            Dim ff As Decimal = amount_03.Text
            amount_03.Text = ff.ToString("#,0.00")

            Dim gg As Decimal = amount_04.Text
            amount_04.Text = gg.ToString("#,0.00")

            Dim hh As Decimal = totalcost_txt1.Text
            totalcost_txt1.Text = hh.ToString("#,0.00")
        End If


       
    End Sub

    Private Sub DeveloperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeveloperToolStripMenuItem.Click
        AboutMe.ShowDialog()
    End Sub
    Sub update_po()
        Try
            conn.Open()
            cmd = New MySqlCommand("update " & bind2.Text & " set bind_tb='" & select_cmb_2.Text & "'", conn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub update_user()
        Try
            conn.Open()
            cmd = New MySqlCommand("update " & bindtext.Text & " set end_user='" & usertxt.Text & "'", conn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub PurchaseOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseOrderToolStripMenuItem.Click
        PrintForm_01.Show()
    End Sub

    Private Sub bindtext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bindtext.TextChanged, departmenttxt.TextChanged, tailtext.TextChanged
        bindtext.Text = departmenttxt.Text & tailtext.Text
    End Sub

    Private Sub bind2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bind2.TextChanged, departmenttxt.TextChanged, tail2.TextChanged
        bind2.Text = departmenttxt.Text & tail2.Text
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Sub logs_id()
        Dim num As Integer
        Try
            conn.Open()
            cmd = New MySqlCommand("select MAX(log_id) from logs ", conn)
            cmd.ExecuteNonQuery()
            If IsDBNull(cmd.ExecuteScalar) Then
                num = 0
                idtxt.Text = num
            Else
                num = cmd.ExecuteScalar
                idtxt.Text = num
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timetxt.Text = TimeOfDay

    End Sub
End Class