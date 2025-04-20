Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports MetroFramework.Forms
Imports MetroFramework.Components

Public Class administration
    'Dim conn As New MySqlConnection("server=localhost; user id=root; password='admin'; database=gso_db")
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim da, data1, data2 As New MySqlDataAdapter
    Dim dt, dtable1, dtable2 As New DataTable
    Dim p(7) As MySqlParameter
    Dim numcheck As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        logs_panel.Visible = False
        reports_panel.Visible = False 'Products.ShowDialog()
        dashboard.Visible = False
        tableforms.Visible = False
        addpanel.Visible = True
        department_panel.Visible = False
        purchase_order_panel.Visible = False


        prtxt.Visible = False
        potxt.Visible = False
        DateTimePicker2.Visible = False
        DateTimePicker1.Visible = True

        desc.Text = ""
        unitpricetxt.Text = ""
        remarks_txt.Text = ""


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        logs_panel.Visible = False
        dashboard.Visible = False
        reports_panel.Visible = True
        tableforms.Visible = False
        addpanel.Visible = False
        department_panel.Visible = False
        purchase_order_panel.Visible = False
        prtxt.Visible = False
        potxt.Visible = False

    End Sub

    Sub view()
        cmd = New MySqlCommand("select pr_no from tbl_pr", conn)
        data1 = New MySqlDataAdapter(cmd)
        data1.Fill(dtable1)

        cmd = New MySqlCommand("select * from tbl_po", conn)
        data2 = New MySqlDataAdapter(cmd)
        data2.Fill(dtable2)

        'conn.Dispose()
        conn.Close()
    End Sub












    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroStyleManager1.Owner = Me
        MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light
        MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue

        RoundedButtons(IssuePR_btn)
        RoundedButtons(print_po)
        RoundedButtons(updateData)

        RoundedButtons(printbtn)

        RoundedButtons(addbtn_D)
        RoundedButtons(filter_BTNs)
        filterbuttons(filterBTNs)
        RoundedButtons(prtxt)
        RoundedButtons(potxt)












        Dim c As Decimal = q1.Text
        q1.Text = c.ToString("#,0.00")

        Dim d As Decimal = q2.Text
        q2.Text = d.ToString("#,0.00")

        Dim f As Decimal = q3.Text
        q3.Text = f.ToString("#,0.00")

        Dim g As Decimal = q4.Text
        q4.Text = g.ToString("#,0.00")

        Dim h As Decimal = total.Text
        total.Text = h.ToString("#,0.00")








    End Sub
    Sub authorized_person()
        Dim ss As String = bindtxt_01.Text
        Try
            conn.Open()
            cmd = New MySqlCommand("select * from " & ss & " ", conn)
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()
                persontxt.Text = dr.Item("end_user").ToString
                persontxt1.Text = dr.Item("end_user").ToString
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Sub dep_issue_pr()
        Dim ss As String = bind_02.Text
        Try
            conn.Open()
            cmd = New MySqlCommand("select * from " & ss & " ", conn)
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()
                date_pr.Text = dr.Item("PR_no").ToString
                combinetxt.Text = dr.Item("bind_tb").ToString
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub quarter_update_year()
        Try
            conn.Open()
            cmd = New MySqlCommand("update tbl_quarter set year='" & yeartxt.Text & "'", conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub chartquarter()


        Try
            conn.Close()
            conn.Open()
            Dim query As String
            query = "select * from gso_db.tbl_quarter"
            Dim cmd As New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Chart1.Series("Chart").Points.AddXY(dr.GetString("quarter"), dr.GetInt32("number"))
                Chart1.Refresh()
            End While
            'Chart1.Series.Clear()
            conn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            'conn.Dispose()
        End Try
    End Sub

    Sub updatequarterly1()
        Try
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("update tbl_quarter set number='" & q1.Text & "' where id=1", conn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub updatequarterly2()
        Try
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("update tbl_quarter set number='" & q2.Text & "' where id=2", conn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub updatequarterly3()
        Try
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("update tbl_quarter set number='" & q3.Text & "' where id=3", conn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub updatequarterly4()
        Try
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("update tbl_quarter set number='" & q4.Text & "' where id=4", conn)
            cmd.ExecuteNonQuery()

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

    Private Sub filterbuttons(j As Button)
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

    Private Sub RoundedButtons_01(j As Button)
        j.FlatAppearance.BorderSize = 0
        j.FlatStyle = FlatStyle.Flat
        j.BackColor = Color.Teal
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
    Private Sub savebtn_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        dashboard.Visible = True
        tableforms.Visible = False
        addpanel.Visible = False
        department_panel.Visible = False
        reports_panel.Visible = False
        purchase_order_panel.Visible = False
        logs_panel.Visible = False

        prtxt.Visible = False
        potxt.Visible = False

    End Sub

    Private Sub tblebtn_Click(sender As Object, e As EventArgs) Handles tblebtn.Click

        logs_panel.Visible = False
        prtxt.Visible = False
        potxt.Visible = False
        purchase_order_panel.Visible = False
        reports_panel.Visible = False
        dashboard.Visible = False
        tableforms.Visible = True
        addpanel.Visible = False
        department_panel.Visible = False

        authorized_person()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DataGridView1.Rows(e.RowIndex)
            sub_item.Text = row.Cells("Item #").Value.ToString
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Dim column As String = DataGridView1.Columns(e.ColumnIndex).Name
        'If column = "Column17" Then
        '    Try
        '        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        '        updateform.information = row.Cells("Column1").Value
        '        updateform.Show()

        '    Catch ex As Exception


        '    End Try
        'End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        reports_panel.Visible = False
        dashboard.Visible = False
        tableforms.Visible = False
        addpanel.Visible = False
        department_panel.Visible = True
        purchase_order_panel.Visible = False
        prtxt.Visible = False
        potxt.Visible = False
        logs_panel.Visible = False
    End Sub

    Sub listdepartment_01()
        Dim adapt As New MySqlDataAdapter
        'Dim dtable As New DataTable

        conn.Close()
        conn.Open()
        Dim query As String
        query = "select * from sub_department"
        adapt = New MySqlDataAdapter(query, conn)
        dt.Clear()
        adapt.Fill(dt)

        select_combo.DisplayMember = "Department"
        select_combo.DataSource = dt


        'conn.Dispose()
        conn.Close()
    End Sub

    Private Sub searhtext_TextChanged(sender As Object, e As EventArgs) Handles searhtext.TextChanged
        Try
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select no as `Item #`,date_issue as `Date of Issue`,product_no as `Product No`,description as `Description`,qty as `Quantity`,unit_of_issue as `Unit of Issue`,unit_price as `Unit Price`,total_cost as `Total Cost`,mode_of_procure as `Mode of Procurement`,qty1 as `1st Quarter (Quantity)`,amnt1 as `1st Quarter (Amount)`,qty2 as `2nd Quarter (Quantity)`,amnt2 as `2nd Quarter (Amount)`,qty3 as `3rd Quarter (Quantity)`,amnt3 as `3rd Quarter (Amount)`,qty4 as `4th Quarter (Quantity)`,amnt4 as `4th Quarter (Amount)` from app where description like '%" & searhtext.Text & "%'", conn)
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

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

        'Dim column As String = dgv.Columns(e.ColumnIndex).Name
        'If column = "Column20" Then

        '    Dim row As DataGridViewRow = dgv.Rows(e.RowIndex)
        '    infos = row.Cells("Column18").Value
        '    Dim str As String = depart.Text
        '    'searchinfo()


        '    Try
        '        If MsgBox("You want to insert data", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
        '            conn.Open()
        '            cmd = New MySqlCommand("insert into " & str & "(date_issue,product_no,description) select date_issue,product_no,description from tbl_product", conn)
        '            cmd.ExecuteNonQuery()

        '        End If
        '        MsgBox("sucess")

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    Finally
        '        conn.Close()
        '    End Try



        'End If
    End Sub


    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgv.Rows(e.RowIndex)
            depart.Text = row.Cells("Department").Value

        End If
    End Sub

    Private Sub InsertDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertDataToolStripMenuItem.Click
        Dim str As String = depart.Text
        Dim str1 As String = bindtext.Text
        Dim str2 As String = sub_bind_01.Text
        Try
            If MsgBox("You want to insert data", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then

                conn.Open()
                cmd = New MySqlCommand("insert into " & str & "(no,date_issue,product_no,description,unit_of_issue,unit_price,category,remarks,year) select no,date_issue,product_no,description,unit_of_issue,unit_price,category,remarks,year from tbl_product", conn)
                cmd.ExecuteNonQuery()

                cmd = New MySqlCommand("insert into " & str1 & "(no,date_issue,product_no,description,unit_of_issue,unit_price,category,remarks,year) select no,date_issue,product_no,description,unit_of_issue,unit_price,category,remarks,year from tbl_product", conn)
                cmd.ExecuteNonQuery()

                cmd = New MySqlCommand("insert into " & str2 & "(no,date_issue,product_no,description,unit_of_issue,unit_price,category,remarks,year) select no,date_issue,product_no,description,unit_of_issue,unit_price,category,remarks,year from tbl_product", conn)
                cmd.ExecuteNonQuery()

                cmd = New MySqlCommand("insert into sub_department(department) select department from department where department='" & depart.Text & "'", conn)
                cmd.ExecuteNonQuery()

                cmd = New MySqlCommand("delete from department where department='" & depart.Text & "'", conn)
                cmd.ExecuteNonQuery()

                MsgBox("sucess")
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            conn.Close()

            'listdepartment_01()
        End Try
    End Sub


    Private Sub addbtn_D_Click(sender As Object, e As EventArgs) Handles addbtn_D.Click
        TableForm.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            Login.Show()
            Me.Hide()
        End If

        conn.Open()
        cmd = New MySqlCommand("update logs set logout='" & time_txt.Text & "' where log_id='" & idtxt.Text & "'", conn)
        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub select_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles select_combo.SelectedIndexChanged

        Try
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select no as `Item #`,date_issue as `Date of Issue`,product_no as `Product No`,description as `Description`,qty as `Quantity`,unit_of_issue as `Unit of Issue`,unit_price as `Unit Price`,total_cost as `Total Cost`,mode_of_procure as `Mode of Procurement`,qty1 as `1st Quarter (Quantity)`,amnt1 as `1st Quarter (Amount)`,qty2 as `2nd Quarter (Quantity)`,amnt2 as `2nd Quarter (Amount)`,qty3 as `3rd Quarter (Quantity)`,amnt3 as `3rd Quarter (Amount)`,qty4 as `4th Quarter (Quantity)`,amnt4 as `4th Quarter (Amount)` from " & select_combo.Text & "", conn)
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


        dep_issue_pr()
        authorized_person()
        Dim cc As Decimal = amount_01.Text
        amount_01.Text = cc.ToString("#,0.00")

        Dim dd As Decimal = amount_02.Text
        amount_02.Text = dd.ToString("#,0.00")

        Dim ff As Decimal = amount_03.Text
        amount_03.Text = ff.ToString("#,0.00")

        Dim gg As Decimal = amount_04.Text
        amount_04.Text = gg.ToString("#,0.00")

        'Dim hh As Decimal = TOT_COST.Text
        'TOT_COST.Text = hh.ToString("#,0.00")
    End Sub

    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click


        If report_select.SelectedIndex = 0 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                query = "select * from " & select_combo.Text & ""
                Dim da As New MySqlDataAdapter(query, conn)
                da.Fill(ds, "'" & select_combo.Text & "'")
                conn.Close()
                Dim cryds As New PrintingReports
                cryds.SetDataSource(ds.Tables(0))
                CrystalReportViewer1.ReportSource = cryds
                CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

            dashboard.Visible = False
            reports_panel.Visible = True
            tableforms.Visible = False
            addpanel.Visible = False
            department_panel.Visible = False
            purchase_order_panel.Visible = False

        ElseIf report_select.SelectedIndex = 1 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                query = "select * from " & select_combo.Text & ""
                Dim da As New MySqlDataAdapter(query, conn)
                da.Fill(ds, "'" & select_combo.Text & "'")
                conn.Close()
                Dim cryds As New PrintingReports_02_ppmp
                cryds.SetDataSource(ds.Tables(0))
                CrystalReportViewer1.ReportSource = cryds
                CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

            dashboard.Visible = False
            reports_panel.Visible = True
            tableforms.Visible = False
            addpanel.Visible = False
            department_panel.Visible = False
            purchase_order_panel.Visible = False

        ElseIf report_select.SelectedIndex = 2 Then
            Try
                Dim ds As New DataSet
                Dim query As String

                query = "select * from " & bind_02.Text & ""
                Dim cmd As New MySqlDataAdapter(query, conn)
                cmd.Fill(ds, "'" & bind_02.Text & "'")
                conn.Close()
                Dim cryds As New PrintingReports_03_pr
                cryds.SetDataSource(ds.Tables(0))
                cryds.SetParameterValue("Quarterly", combinetxt.Text)
                'cryds.SetParameterValue("PrNo", pr_no.Text)
                'cryds.SetParameterValue("DateIssue", pr_date.Text)
                CrystalReportViewer1.ReportSource = cryds
                CrystalReportViewer1.Refresh()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

            dashboard.Visible = False
            reports_panel.Visible = True
            tableforms.Visible = False
            addpanel.Visible = False
            department_panel.Visible = False
            purchase_order_panel.Visible = False
            dep_issue_pr()

        ElseIf report_select.SelectedIndex = 3 Then

            Try
                Dim ds As New DataSet
                Dim query As String
                query = "select * from " & bindtxt_01.Text & ""
                Dim cmd As New MySqlDataAdapter(query, conn)
                cmd.Fill(ds, "'" & bindtxt_01.Text & "'")
                conn.Close()
                Dim cryds As New PrintReportFor_PO_02
                cryds.SetDataSource(ds.Tables(0))

                cryds.SetParameterValue("PrNo", date_pr.Text)
                cryds.SetParameterValue("person", persontxt.Text)
                CrystalReportViewer1.ReportSource = cryds
                CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()
            dashboard.Visible = False
            reports_panel.Visible = True
            tableforms.Visible = False
            addpanel.Visible = False
            department_panel.Visible = False
            purchase_order_panel.Visible = False

        End If

    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs)
        dashboard.Visible = True
        tableforms.Visible = False
        addpanel.Visible = False
        department_panel.Visible = False
        reports_panel.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.ShowDialog()
        prtxt.Visible = False
        potxt.Visible = False
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub remarks_cmb_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UpdateInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateInformationToolStripMenuItem.Click


        PO_Update_Form.ShowDialog()
    End Sub

    Private Sub sub_item_TextChanged(sender As Object, e As EventArgs) Handles sub_item.TextChanged
        Try
            conn.Open()
            cmd = New MySqlCommand("select * from tbl_product where no='" & sub_item.Text & "'", conn)
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()
                item_no.Text = dr.Item("no").ToString
                DateTimePicker2.Text = dr.Item("date_issue").ToString
                product_no.Text = dr.Item("product_no").ToString
                desc.Text = dr.Item("description").ToString
                qty_0001.Text = dr.Item("qty").ToString

                unitpricetxt.Text = dr.Item("unit_price").ToString


                remarks_txt.Text = dr.Item("remarks").ToString
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub item_no_TextChanged(sender As Object, e As EventArgs)

    End Sub





    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        dashboard.Visible = False
        tableforms.Visible = False
        addpanel.Visible = False
        department_panel.Visible = False
        reports_panel.Visible = False
        purchase_order_panel.Visible = True
        logs_panel.Visible = False
        prtxt.Visible = False
        potxt.Visible = False

        reload_data()

        count_lb.Text = PO_dgv.RowCount()
    End Sub

    Private Sub PO_dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PO_dgv.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = PO_dgv.Rows(e.RowIndex)
            PO_Update_Form.product_no.Text = row.Cells("Product No").Value.ToString
        End If
    End Sub

    Private Sub PO_dgv_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles PO_dgv.CellValueChanged
        'If e.RowIndex < 0 Then Return
        'Dim ischck As Boolean = CBool(PO_dgv.Rows(e.RowIndex).Cells(0).Value)
        'If ischck Then
        '    numcheck += 1
        'Else
        '    numcheck -= 1
        'End If
        'count_lb.Text = numcheck
    End Sub

    Private Sub PO_dgv_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles PO_dgv.CurrentCellDirtyStateChanged
        'If PO_dgv.IsCurrentCellDirty Then
        '    PO_dgv.CommitEdit(DataGridViewDataErrorContexts.Commit)

        'End If
    End Sub

    Sub reload_data()
        Dim adap As New MySqlDataAdapter
        Dim dtable1 As New DataTable

        Try
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select item_no as `#`,no as `Stock/Property No.`,po_no as `P.O. No.`,date_issue as `Date of Issue`,product_no as `Product No`,description as `Description`,qty as `Quantity`,unit_of_issue as `Unit`,unit_price as `Unit Cost`,total_cost as `Amount`,mode_of_procure,Remarks as `Status`,tags as `No. of Lack Item` from tbl_po", conn)
            adap.SelectCommand = cmd
            dtable1.Clear()
            adap.Fill(dtable1)
            PO_dgv.DataSource = dtable1
            PO_dgv.Columns("Description").Width = 450

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
                cmd = New MySqlCommand("UPDATE tbl_po set description=@description,qty=@qty,unit_of_issue=@unit_of_issue,unit_price=@unit_price,total_cost=@total_cost,remarks=@remarks,tags=@tags where no=@no", conn)
                cmd.Parameters.AddWithValue("@no", PO_dgv.Rows(i).Cells(1).Value)
                cmd.Parameters.AddWithValue("@description", PO_dgv.Rows(i).Cells(5).Value)
                cmd.Parameters.AddWithValue("@qty", PO_dgv.Rows(i).Cells(6).Value)
                cmd.Parameters.AddWithValue("@unit_of_issue", PO_dgv.Rows(i).Cells(7).Value)
                cmd.Parameters.AddWithValue("@unit_price", PO_dgv.Rows(i).Cells(8).Value)
                cmd.Parameters.AddWithValue("@total_cost", PO_dgv.Rows(i).Cells(9).Value)
                cmd.Parameters.AddWithValue("@remarks", PO_dgv.Rows(i).Cells(11).Value)
                cmd.Parameters.AddWithValue("@tags", PO_dgv.Rows(i).Cells(12).Value)
                cmd.ExecuteNonQuery()
            Next
            MsgBox("Successfully update data...")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub PO_dgv_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles PO_dgv.CellFormatting
        'For Each row As DataGridViewRow In PO_dgv.Rows
        '    If row.Cells(11).Value = "Pending" Then
        '        PO_dgv.DefaultCellStyle.BackColor = Color.Red
        '        PO_dgv.ForeColor = Color.White
        '    ElseIf row.Cells(11).Value = "Approved" Then
        '        PO_dgv.DefaultCellStyle.BackColor = Color.Green
        '        PO_dgv.ForeColor = Color.White
        '    End If
        'Next
    End Sub

    Private Sub IssuePRNoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssuePRNoToolStripMenuItem.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        ApprovedForm.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        PendingForm.ShowDialog()
    End Sub

    Private Sub PO_dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PO_dgv.CellContentClick

    End Sub

    Private Sub print_po_Click(sender As Object, e As EventArgs) Handles print_po.Click
        'dtable1.Clear()
        'dtable2.Clear()
        Try
            Dim ds As New DataSet
            Dim query As String
            query = "select * from tbl_po"
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds, "tbl_po")
            conn.Close()
            Dim cryds As New PrintReportFor_PO

            cryds.SetDataSource(ds.Tables(0))
            cryds.SetParameterValue("PrNo", pr_no.Text)
            CrystalReportViewer1.ReportSource = cryds
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        conn.Close()

        dashboard.Visible = False
        reports_panel.Visible = True
        tableforms.Visible = False
        addpanel.Visible = False
        department_panel.Visible = False
        purchase_order_panel.Visible = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles IssuePR_btn.Click
        Form3_dep.ShowDialog()
    End Sub

    Private Sub report_select_SelectedIndexChanged(sender As Object, e As EventArgs) Handles report_select.SelectedIndexChanged
        If report_select.SelectedIndex = 0 Then
            prtxt.Visible = False
            potxt.Visible = False
        ElseIf report_select.SelectedIndex = 1 Then
            prtxt.Visible = False
            potxt.Visible = False
        ElseIf report_select.SelectedIndex = 2 Then
            prtxt.Visible = True
            potxt.Visible = False
        ElseIf report_select.SelectedIndex = 3 Then
            prtxt.Visible = False
            potxt.Visible = True
        End If
    End Sub

    Private Sub bindtext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bindtext.TextChanged, sub_depart.TextChanged, tail_txt.TextChanged
        bindtext.Text = sub_depart.Text & tail_txt.Text
    End Sub

    Private Sub sub_depart_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sub_depart.TextChanged, depart.TextChanged
        sub_depart.Text = depart.Text
    End Sub

    Private Sub bindtxt_01_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bindtxt_01.TextChanged, select_combo.TextChanged, tailtxt.TextChanged
        bindtxt_01.Text = select_combo.Text & tailtxt.Text
    End Sub

    Private Sub cmb_span_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_span.SelectedIndexChanged
        Try
            Dim ds As New DataSet
            Dim query As String
            query = "select * from tbl_quarter where year='" & cmb_span.Text & "'"
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds, "tbl_quarter")
            conn.Close()
            Dim cryds As New spanyear
            cryds.SetDataSource(ds.Tables(0))
            CrystalReportViewer1.ReportSource = cryds
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox("No data " & ex.Message)
        Finally
            conn.Close()
        End Try
        conn.Close()

        dashboard.Visible = False
        reports_panel.Visible = True
        tableforms.Visible = False
        addpanel.Visible = False
        department_panel.Visible = False
        purchase_order_panel.Visible = False
    End Sub

    Private Sub category_txt_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles filterBTNs.Click
        FilterForm.ShowDialog()
        FilterForm.categorylist_0001()
        FilterForm.categorylist_0002()
        FilterForm.categorylist_0003()
    End Sub

    Private Sub ViewInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewInformationToolStripMenuItem.Click
        reports_panel.Visible = False
        dashboard.Visible = False
        tableforms.Visible = False
        addpanel.Visible = True
        department_panel.Visible = False

        DateTimePicker2.Visible = True
        DateTimePicker1.Visible = False

    End Sub

    Private Sub prtxt_Click(sender As Object, e As EventArgs) Handles prtxt.Click
        Purchase_No.ShowDialog()
    End Sub

    Private Sub Button10_Click_2(sender As Object, e As EventArgs) Handles Button10.Click
        dashboard.Visible = False
        tableforms.Visible = False
        addpanel.Visible = False
        department_panel.Visible = False
        reports_panel.Visible = False
        purchase_order_panel.Visible = False
        logs_panel.Visible = True
        prtxt.Visible = False
        potxt.Visible = False

        prtxt.Visible = False
        potxt.Visible = False
    End Sub

    Private Sub potxt_Click(sender As Object, e As EventArgs) Handles potxt.Click
        Purchase_Order.ShowDialog()
    End Sub

    Private Sub sub_pr_01_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sub_pr_01.TextChanged, depart.TextChanged
        sub_pr_01.Text = depart.Text
    End Sub

    Private Sub sub_bind_01_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sub_bind_01.TextChanged, sub_pr_01.TextChanged, sub_tail_01.TextChanged
        sub_bind_01.Text = sub_pr_01.Text & sub_tail_01.Text
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub dep_Click(sender As Object, e As EventArgs) Handles dep.Click

    End Sub

    Private Sub nametxt_Click(sender As Object, e As EventArgs) Handles nametxt.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub addpanel_Paint(sender As Object, e As PaintEventArgs) Handles addpanel.Paint

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub select_cat_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub unitissuetxt_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub tableforms_Paint(sender As Object, e As PaintEventArgs) Handles tableforms.Paint

    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub TOT_COST_Click(sender As Object, e As EventArgs) Handles TOT_COST.Click

    End Sub

    Private Sub amount_04_Click(sender As Object, e As EventArgs) Handles amount_04.Click

    End Sub

    Private Sub amount_03_Click(sender As Object, e As EventArgs) Handles amount_03.Click

    End Sub

    Private Sub amount_02_Click(sender As Object, e As EventArgs) Handles amount_02.Click

    End Sub

    Private Sub amount_01_Click(sender As Object, e As EventArgs) Handles amount_01.Click

    End Sub

    Private Sub dgv_all_Click(sender As Object, e As EventArgs) Handles dgv_all.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub ContextMenuStrip4_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip4.Opening

    End Sub

    Private Sub ContextMenuStrip2_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening

    End Sub

    Private Sub dashboard_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub q1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub q2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub q3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub q4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub total_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub approved_txt_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel15_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub pending_txt_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub reports_panel_Paint(sender As Object, e As PaintEventArgs) Handles reports_panel.Paint

    End Sub

    Private Sub Panel11_Paint(sender As Object, e As PaintEventArgs) Handles Panel11.Paint

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint

    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click

    End Sub

    Private Sub purchase_order_panel_Paint(sender As Object, e As PaintEventArgs) Handles purchase_order_panel.Paint

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub count_lb_Click(sender As Object, e As EventArgs) Handles count_lb.Click

    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

    End Sub

    Private Sub pr_date_ValueChanged(sender As Object, e As EventArgs) Handles pr_date.ValueChanged

    End Sub

    Private Sub ContextMenuStrip3_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip3.Opening

    End Sub

    Private Sub logs_panel_Paint(sender As Object, e As PaintEventArgs) Handles logs_panel.Paint

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub d2_ValueChanged(sender As Object, e As EventArgs) Handles d2.ValueChanged

    End Sub

    Private Sub d1_ValueChanged(sender As Object, e As EventArgs) Handles d1.ValueChanged

    End Sub

    Private Sub idtxt_TextChanged(sender As Object, e As EventArgs) Handles idtxt.TextChanged

    End Sub

    Private Sub time_txt_Click(sender As Object, e As EventArgs) Handles time_txt.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub remarks_txt_TextChanged(sender As Object, e As EventArgs) Handles remarks_txt.TextChanged

    End Sub

    Private Sub yeartxt_TextChanged(sender As Object, e As EventArgs) Handles yeartxt.TextChanged

    End Sub

    Private Sub unitpricetxt_TextChanged(sender As Object, e As EventArgs) Handles unitpricetxt.TextChanged

    End Sub

    Private Sub qty_0001_TextChanged(sender As Object, e As EventArgs) Handles qty_0001.TextChanged

    End Sub

    Private Sub desc_TextChanged(sender As Object, e As EventArgs) Handles desc.TextChanged

    End Sub

    Private Sub product_no_TextChanged(sender As Object, e As EventArgs) Handles product_no.TextChanged

    End Sub

    Private Sub item_no_TextChanged_1(sender As Object, e As EventArgs) Handles item_no.TextChanged

    End Sub

    Private Sub date_pr_TextChanged(sender As Object, e As EventArgs) Handles date_pr.TextChanged

    End Sub

    Private Sub combinetxt_TextChanged(sender As Object, e As EventArgs) Handles combinetxt.TextChanged

    End Sub

    Private Sub persontxt_TextChanged(sender As Object, e As EventArgs) Handles persontxt.TextChanged

    End Sub

    Private Sub persontxt1_TextChanged(sender As Object, e As EventArgs) Handles persontxt1.TextChanged

    End Sub

    Private Sub pr_no_TextChanged(sender As Object, e As EventArgs) Handles pr_no.TextChanged

    End Sub








    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click

    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click

    End Sub

    Private Sub RoundedCornerTextbox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bind_02.TextChanged, select_combo.TextChanged, tail_02.TextChanged
        bind_02.Text = select_combo.Text & tail_02.Text
    End Sub

    Private Sub department_panel_Paint(sender As Object, e As PaintEventArgs) Handles department_panel.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time_txt.Text = TimeOfDay
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles filter_BTNs.Click
        Try
            Dim dt As New DataTable
            Dim cmd As New MySqlCommand("select date as `Date`,fullname as `Full name`, login as `Time in`, logout as `Time Out` from logs where date BETWEEN @d1 AND @d2", conn)

            cmd.Parameters.AddWithValue("@d1", d1.Text)
            cmd.Parameters.AddWithValue("@d2", d2.Text)

            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)

            DataGridView2.DataSource = dt




        Catch ex As Exception

        End Try
    End Sub
End Class
