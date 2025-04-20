Imports MySql.Data.MySqlClient
Public Class FilterForm

    Private Sub FilterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedButtons(filter_btn)
        RoundedButtons(filterBTN)
        RoundedButtons(gen_all_1)
        RoundedButtons(gen_all_2)
        RoundedButtons(filter_po)
        RoundedButtons(generate_po)
        categorylist_0001()
        categorylist_0002()
        categorylist_0003()
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

    Private Sub filter_btn_Click(sender As Object, e As EventArgs) Handles filter_btn.Click
        If selected_cmb.SelectedIndex = 0 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from app where category='" & category_txt.Text & "'"
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "app")
                conn.Close()
                Dim cryds As New PrintingReports
                cryds.SetDataSource(ds.Tables(0))

                Form1.CrystalReportViewer1.ReportSource = cryds
                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

        ElseIf selected_cmb.SelectedIndex = 1 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from ppmp where category='" & category_txt.Text & "'"
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "ppmp")
                conn.Close()
                Dim cryds As New PrintingReports_02
                cryds.SetDataSource(ds.Tables(0))

                Form1.CrystalReportViewer1.ReportSource = cryds
                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()
        End If

       


        Form1.dashboard.Visible = False
        Form1.reports_panel.Visible = True
        Form1.tableforms.Visible = False
        Form1.addpanel.Visible = False
        Form1.department_panel.Visible = False
        Form1.purchase_order_panel.Visible = False


    End Sub
    Sub categorylist_0001()
        Dim adap As New MySqlDataAdapter
        Dim dt As New DataTable

        conn.Open()
        adap = New MySqlDataAdapter("select * from tbl_category", conn)
        dt.Clear()
        adap.Fill(dt)

        category_txt.DisplayMember = "category"
        category_txt.DataSource = dt

        conn.Dispose()
        conn.Close()

    End Sub

    Sub categorylist_0002()
        Dim adap As New MySqlDataAdapter
        Dim dt As New DataTable

        conn.Open()
        adap = New MySqlDataAdapter("select * from tbl_category", conn)
        dt.Clear()
        adap.Fill(dt)

        categorytxt_002.DisplayMember = "category"

        categorytxt_002.DataSource = dt

        conn.Dispose()
        conn.Close()

    End Sub
    Sub categorylist_0003()
        Dim adap As New MySqlDataAdapter
        Dim dt As New DataTable

        conn.Open()
        adap = New MySqlDataAdapter("select * from tbl_category", conn)
        dt.Clear()
        adap.Fill(dt)

        category_po.DisplayMember = "category"
        category_po.DataSource = dt

        conn.Dispose()
        conn.Close()

    End Sub
    Private Sub filterBTN_Click(sender As Object, e As EventArgs) Handles filterBTN.Click

        '---------------------------- PURCHASE REQUEST ------------------------------------

        If select_cmb_2.SelectedIndex = 0 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from tbl_pr where category='" & categorytxt_002.Text & "'"
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "tbl_pr")
                conn.Close()
                Dim cryds As New PrintingReports_03
                cryds.SetDataSource(ds.Tables(0))
                cryds.SetParameterValue("Quarterly", T3.Text)
                cryds.SetParameterValue("PrNo", Form1.pr_no.Text)
                cryds.SetParameterValue("DateIssue", Form1.pr_date.Text)
                Form1.CrystalReportViewer1.ReportSource = cryds

                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

        ElseIf select_cmb_2.SelectedIndex = 1 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from tbl_pr where category='" & categorytxt_002.Text & "'"
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "tbl_pr")
                conn.Close()
                Dim cryds As New PrintingReports_04
                cryds.SetDataSource(ds.Tables(0))
                cryds.SetParameterValue("Quarterly", T3.Text)
                cryds.SetParameterValue("PrNo", Form1.pr_no.Text)
                cryds.SetParameterValue("DateIssue", Form1.pr_date.Text)
                Form1.CrystalReportViewer1.ReportSource = cryds

                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

        ElseIf select_cmb_2.SelectedIndex = 2 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from tbl_pr where category='" & categorytxt_002.Text & "'"
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "tbl_pr")
                conn.Close()
                Dim cryds As New PrintingReports_05
                cryds.SetDataSource(ds.Tables(0))
                cryds.SetParameterValue("Quarterly", T3.Text)
                cryds.SetParameterValue("PrNo", Form1.pr_no.Text)
                cryds.SetParameterValue("DateIssue", Form1.pr_date.Text)
                Form1.CrystalReportViewer1.ReportSource = cryds

                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()


        ElseIf select_cmb_2.SelectedIndex = 3 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from tbl_pr where category='" & categorytxt_002.Text & "'"
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "tbl_pr")
                conn.Close()
                Dim cryds As New PrintingReports_06
                cryds.SetDataSource(ds.Tables(0))
                cryds.SetParameterValue("Quarterly", T3.Text)
                cryds.SetParameterValue("PrNo", Form1.pr_no.Text)
                cryds.SetParameterValue("DateIssue", Form1.pr_date.Text)
                Form1.CrystalReportViewer1.ReportSource = cryds

                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

        ElseIf select_cmb_2.SelectedIndex = 4 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from tbl_pr where category='" & categorytxt_002.Text & "'"
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "tbl_pr")
                conn.Close()
                Dim cryds As New PrintingReports_07
                cryds.SetDataSource(ds.Tables(0))
                cryds.SetParameterValue("Quarterly", T3.Text)
                cryds.SetParameterValue("PrNo", Form1.pr_no.Text)
                cryds.SetParameterValue("DateIssue", Form1.pr_date.Text)
                Form1.CrystalReportViewer1.ReportSource = cryds

                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

        ElseIf select_cmb_2.SelectedIndex = 5 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from tbl_pr where category='" & categorytxt_002.Text & "'"
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "tbl_pr")
                conn.Close()
                Dim cryds As New PrintingReports_08
                cryds.SetDataSource(ds.Tables(0))
                cryds.SetParameterValue("Quarterly", T3.Text)
                cryds.SetParameterValue("PrNo", Form1.pr_no.Text)
                cryds.SetParameterValue("DateIssue", Form1.pr_date.Text)
                Form1.CrystalReportViewer1.ReportSource = cryds

                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

        ElseIf select_cmb_2.SelectedIndex = 6 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from tbl_pr where category='" & categorytxt_002.Text & "'"
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "tbl_pr")
                conn.Close()
                Dim cryds As New PrintingReports_All
                cryds.SetDataSource(ds.Tables(0))
                cryds.SetParameterValue("Quarterly", T3.Text)
                cryds.SetParameterValue("PrNo", Form1.pr_no.Text)
                cryds.SetParameterValue("DateIssue", Form1.pr_date.Text)
                Form1.CrystalReportViewer1.ReportSource = cryds

                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

        End If


        Form1.dashboard.Visible = False
        Form1.reports_panel.Visible = True
        Form1.tableforms.Visible = False
        Form1.addpanel.Visible = False
        Form1.department_panel.Visible = False
        Form1.purchase_order_panel.Visible = False
    End Sub

    Private Sub remarks_btn_Click(sender As Object, e As EventArgs) Handles remarks_btn.Click
        If select_cmb_2.Text = "" Then
            MsgBox("Please Select Purchase Request first", MsgBoxStyle.Critical, "Confirm")
        Else
            If select_cmb_2.SelectedIndex = 0 Then

                Try
                    Dim ds As New DataSet
                    Dim query As String
                    query = "select * from app"
                    Dim da As New MySqlDataAdapter(query, conn)
                    da.Fill(ds, "app")
                    conn.Close()
                    Dim cryds As New RemarksReport_01
                    cryds.SetDataSource(ds.Tables(0))
                    Form1.CrystalReportViewer1.ReportSource = cryds

                    Form1.CrystalReportViewer1.Refresh()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conn.Close()
                End Try
                conn.Close()
            ElseIf select_cmb_2.SelectedIndex = 1 Then
                Try
                    Dim ds As New DataSet
                    Dim query As String
                    query = "select * from app"
                    Dim da As New MySqlDataAdapter(query, conn)
                    da.Fill(ds, "app")
                    conn.Close()
                    Dim cryds As New RemarksReport_02
                    cryds.SetDataSource(ds.Tables(0))
                    Form1.CrystalReportViewer1.ReportSource = cryds

                    Form1.CrystalReportViewer1.Refresh()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conn.Close()
                End Try
                conn.Close()

            ElseIf select_cmb_2.SelectedIndex = 2 Then
                Try
                    Dim ds As New DataSet
                    Dim query As String
                    query = "select * from app"
                    Dim da As New MySqlDataAdapter(query, conn)
                    da.Fill(ds, "app")
                    conn.Close()
                    Dim cryds As New RemarksReport_03
                    cryds.SetDataSource(ds.Tables(0))
                    Form1.CrystalReportViewer1.ReportSource = cryds

                    Form1.CrystalReportViewer1.Refresh()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conn.Close()
                End Try
                conn.Close()

            ElseIf select_cmb_2.SelectedIndex = 3 Then
                Try
                    Dim ds As New DataSet
                    Dim query As String
                    query = "select * from app"
                    Dim da As New MySqlDataAdapter(query, conn)
                    da.Fill(ds, "app")
                    conn.Close()
                    Dim cryds As New RemarksReport_04
                    cryds.SetDataSource(ds.Tables(0))
                    Form1.CrystalReportViewer1.ReportSource = cryds
                    Form1.CrystalReportViewer1.Refresh()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conn.Close()
                End Try
                conn.Close()

            ElseIf select_cmb_2.SelectedIndex = 4 Then
                Try
                    Dim ds As New DataSet
                    Dim query As String
                    query = "select * from app"
                    Dim da As New MySqlDataAdapter(query, conn)
                    da.Fill(ds, "app")
                    conn.Close()
                    Dim cryds As New RemarksReport_05
                    cryds.SetDataSource(ds.Tables(0))
                    Form1.CrystalReportViewer1.ReportSource = cryds
                    Form1.CrystalReportViewer1.Refresh()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conn.Close()
                End Try
                conn.Close()

            ElseIf select_cmb_2.SelectedIndex = 5 Then
                Try
                    Dim ds As New DataSet
                    Dim query As String
                    query = "select * from app"
                    Dim da As New MySqlDataAdapter(query, conn)
                    da.Fill(ds, "app")
                    conn.Close()
                    Dim cryds As New RemarksReport_06
                    cryds.SetDataSource(ds.Tables(0))
                    Form1.CrystalReportViewer1.ReportSource = cryds
                    Form1.CrystalReportViewer1.Refresh()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conn.Close()
                End Try
                conn.Close()
            End If


        End If

    End Sub

    Private Sub T1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T1.TextChanged, select_cmb_2.TextChanged
        T1.Text = select_cmb_2.Text
    End Sub

    Private Sub T2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T2.TextChanged, categorytxt_002.TextChanged
        T2.Text = categorytxt_002.Text
    End Sub

    Private Sub T3_TextChanged(sender As Object, e As EventArgs) Handles T3.TextChanged, T1.TextChanged, T2.TextChanged
        T3.Text = T1.Text & "-" & T2.Text
    End Sub

    Private Sub gen_all_1_Click(sender As Object, e As EventArgs) Handles gen_all_1.Click
        If selected_cmb.SelectedIndex = 0 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from app "
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "app")
                conn.Close()
                Dim cryds As New PrintingReports
                cryds.SetDataSource(ds.Tables(0))

                Form1.CrystalReportViewer1.ReportSource = cryds
                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

        ElseIf selected_cmb.SelectedIndex = 1 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from ppmp"
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "ppmp")
                conn.Close()
                Dim cryds As New PrintingReports_02
                cryds.SetDataSource(ds.Tables(0))

                Form1.CrystalReportViewer1.ReportSource = cryds
                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()
        End If




        Form1.dashboard.Visible = False
        Form1.reports_panel.Visible = True
        Form1.tableforms.Visible = False
        Form1.addpanel.Visible = False
        Form1.department_panel.Visible = False
        Form1.purchase_order_panel.Visible = False

    End Sub

    Private Sub gen_all_2_Click(sender As Object, e As EventArgs) Handles gen_all_2.Click
        '---------------------------- PURCHASE REQUEST GENERATE ALL RECORDS ------------------------------------

        If select_cmb_2.SelectedIndex = 0 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from tbl_pr "
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "tbl_pr")
                conn.Close()
                Dim cryds As New PrintingReports_03
                cryds.SetDataSource(ds.Tables(0))
                cryds.SetParameterValue("Quarterly", T3.Text)
                cryds.SetParameterValue("PrNo", Form1.pr_no.Text)
                cryds.SetParameterValue("DateIssue", Form1.pr_date.Text)
                Form1.CrystalReportViewer1.ReportSource = cryds

                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

        ElseIf select_cmb_2.SelectedIndex = 1 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from tbl_pr "
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "tbl_pr")
                conn.Close()
                Dim cryds As New PrintingReports_04
                cryds.SetDataSource(ds.Tables(0))
                cryds.SetParameterValue("Quarterly", T3.Text)
                cryds.SetParameterValue("PrNo", Form1.pr_no.Text)
                cryds.SetParameterValue("DateIssue", Form1.pr_date.Text)
                Form1.CrystalReportViewer1.ReportSource = cryds

                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

        ElseIf select_cmb_2.SelectedIndex = 2 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from tbl_pr "
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "tbl_pr")
                conn.Close()
                Dim cryds As New PrintingReports_05
                cryds.SetDataSource(ds.Tables(0))
                cryds.SetParameterValue("Quarterly", T3.Text)
                cryds.SetParameterValue("PrNo", Form1.pr_no.Text)
                cryds.SetParameterValue("DateIssue", Form1.pr_date.Text)
                Form1.CrystalReportViewer1.ReportSource = cryds

                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()


        ElseIf select_cmb_2.SelectedIndex = 3 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from tbl_pr"
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "tbl_pr")
                conn.Close()
                Dim cryds As New PrintingReports_06
                cryds.SetDataSource(ds.Tables(0))
                cryds.SetParameterValue("Quarterly", T3.Text)
                cryds.SetParameterValue("PrNo", Form1.pr_no.Text)
                cryds.SetParameterValue("DateIssue", Form1.pr_date.Text)
                Form1.CrystalReportViewer1.ReportSource = cryds

                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

        ElseIf select_cmb_2.SelectedIndex = 4 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from tbl_pr "
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "tbl_pr")
                conn.Close()
                Dim cryds As New PrintingReports_07
                cryds.SetDataSource(ds.Tables(0))
                cryds.SetParameterValue("Quarterly", T3.Text)
                cryds.SetParameterValue("PrNo", Form1.pr_no.Text)
                cryds.SetParameterValue("DateIssue", Form1.pr_date.Text)
                Form1.CrystalReportViewer1.ReportSource = cryds

                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

        ElseIf select_cmb_2.SelectedIndex = 5 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from tbl_pr "
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "tbl_pr")
                conn.Close()
                Dim cryds As New PrintingReports_08
                cryds.SetDataSource(ds.Tables(0))
                cryds.SetParameterValue("Quarterly", T3.Text)
                cryds.SetParameterValue("PrNo", Form1.pr_no.Text)
                cryds.SetParameterValue("DateIssue", Form1.pr_date.Text)
                Form1.CrystalReportViewer1.ReportSource = cryds

                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

        ElseIf select_cmb_2.SelectedIndex = 6 Then
            Try
                Dim ds As New DataSet
                Dim query As String
                'p(0) = New MySqlParameter("@HH_id", MySqlDbType.String)
                'p(0).Value = text_hh_id.Text
                query = "select * from tbl_pr "
                Dim cmd As New MySqlDataAdapter(query, conn)
                'cmd.SelectCommand.Parameters.Add(p(0))
                cmd.Fill(ds, "tbl_pr")
                conn.Close()
                Dim cryds As New PrintingReports_All
                cryds.SetDataSource(ds.Tables(0))
                cryds.SetParameterValue("Quarterly", T3.Text)
                cryds.SetParameterValue("PrNo", Form1.pr_no.Text)
                cryds.SetParameterValue("DateIssue", Form1.pr_date.Text)
                Form1.CrystalReportViewer1.ReportSource = cryds

                Form1.CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            conn.Close()

        End If


        Form1.dashboard.Visible = False
        Form1.reports_panel.Visible = True
        Form1.tableforms.Visible = False
        Form1.addpanel.Visible = False
        Form1.department_panel.Visible = False
        Form1.purchase_order_panel.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3_dep.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles filter_po.Click
        'dtable1.Clear()
        'dtable2.Clear()
        Try
            Dim ds As New DataSet
            Dim query As String
            query = "select * from tbl_po where category='" & category_po.Text & "'"
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds, "tbl_po")
            conn.Close()
            Dim cryds As New PrintReportFor_PO
            'view()
            'cryds.Database.Tables("tbl_pr").SetDataSource(dtable1)
            'cryds.Database.Tables("tbl_po").SetDataSource(dtable2)
            cryds.SetDataSource(ds.Tables(0))
            cryds.SetParameterValue("PrNo", Form1.pr_no.Text)
            Form1.CrystalReportViewer1.ReportSource = cryds
            Form1.CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        conn.Close()

        Form1.dashboard.Visible = False
        Form1.reports_panel.Visible = True
        Form1.tableforms.Visible = False
        Form1.addpanel.Visible = False
        Form1.department_panel.Visible = False
        Form1.purchase_order_panel.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles generate_po.Click
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
            'view()
            'cryds.Database.Tables("tbl_pr").SetDataSource(dtable1)
            'cryds.Database.Tables("tbl_po").SetDataSource(dtable2)
            cryds.SetDataSource(ds.Tables(0))
            cryds.SetParameterValue("PrNo", Form1.pr_no.Text)
            Form1.CrystalReportViewer1.ReportSource = cryds
            Form1.CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        conn.Close()

        Form1.dashboard.Visible = False
        Form1.reports_panel.Visible = True
        Form1.tableforms.Visible = False
        Form1.addpanel.Visible = False
        Form1.department_panel.Visible = False
        Form1.purchase_order_panel.Visible = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        IssuePR_dep.ShowDialog()
    End Sub
End Class