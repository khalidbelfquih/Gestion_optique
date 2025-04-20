Imports MySql.Data.MySqlClient
Public Class TableForm
    'Dim conn As New MySqlConnection("server=localhost; user id=root; password='admin'; database=gso_db")
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub TableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedButtons(addbtn_D)

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
        Dim str As String = ComboBox1.Text
        Try
            conn.Open()
            cmd = New MySqlCommand("create table if not exists " & str & "(`item_no`int(11) AUTO_INCREMENT NOT NULL,`date_issue` date not null DEFAULT '0000-00-00',`product_no` int(20) not null,`description` varchar(250) not null,`qty` int(20) not null,`unit_of_issue` varchar(250) not null,`unit_price` int(20) not null,`total_cost` int(20) not null,`mode_of_procure` varchar(250) not null,`qty1` int(20) not null,`amnt1` int(20) not null,`qty2` int(20) not null,`amnt2` int(20) not null,`qty3` int(20) not null,`amnt3` int(20) not null,`qty4` int(20) not null,`amnt4` int(20) not null,`name_of_lgu` varchar(250) not null,`ctrl_no` varchar(250) not null,`department` varchar(250) not null,`plan_amnt` varchar(250) not null,`net` int(50) not null,`source_of_fund` varchar(250) not null,PRIMARY KEY(`item_no`))", conn)
            cmd.ExecuteNonQuery()
            MsgBox("success")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str1 As String = ComboBox2.Text
        Try
            conn.Open()
            cmd = New MySqlCommand("insert into " & str1 & "(date_issue,product_no,description) select date_issue,product_no,description from tbl_product", conn)
            cmd.ExecuteNonQuery()
            MsgBox("success")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub addbtn_D_Click(sender As Object, e As EventArgs) Handles addbtn_D.Click

        Dim str As String = name_d.Text
        Dim str1 As String = bindtext.Text
        Dim str2 As String = bind2.Text
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM department d LEFT JOIN sub_department s ON d.id=s.id WHERE d.department='" & name_d.Text & "'", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then

                MsgBox("Duplicate Entry!", MsgBoxStyle.Critical, "Duplicate")

                conn.Close()
            Else
                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("insert into department(department)values(@department)", conn)
                cmd.Parameters.AddWithValue("department", name_d.Text)
                cmd.ExecuteNonQuery()

                cmd = New MySqlCommand("create table if not exists " & str & "(`item_no` int(11) AUTO_INCREMENT NOT NULL,`no` int(11) NOT NULL,`date_issue` date not null DEFAULT '0000-00-00',`product_no` int(20) not null,`description` varchar(250) not null,`qty` int(20) not null,`unit_of_issue` varchar(250) not null,`unit_price` decimal(20,2) not null,`total_cost` decimal(20,2) not null,`mode_of_procure` varchar(250) not null,`qty1` int(20) not null,`amnt1` decimal(20,2) not null,`qty2` int(20) not null,`amnt2` decimal(20,2) not null,`qty3` int(20) not null,`amnt3` decimal(20,2) not null,`qty4` int(20) not null,`amnt4` decimal(20,2) not null,`jan` int(20) not null,`feb` int(20) not null,`mar` int(20) not null,`apr` int(20) not null,`may` int(20) not null,`jun` int(20) not null,`jul` int(20) not null,`aug` int(20) not null,`sep` int(20) not null,`oct` int(20) not null,`nov` int(20) not null,`dece` int(20) not null,`category` varchar(250) not null,`remarks` varchar(250) not null,`name_of_lgu` varchar(250) not null,`ctrl_no` varchar(250) not null,`department` varchar(250) not null,`plan_amnt` varchar(250) not null,`net` int(50) not null,`source_of_fund` varchar(250) not null,`year` int(20) not null, PRIMARY KEY(`item_no`))", conn)
                cmd.ExecuteNonQuery()

                cmd = New MySqlCommand("create table if not exists " & str1 & "(`item_no` int(11) AUTO_INCREMENT NOT NULL,`no` int(11) NOT NULL,`PO_no`varchar(250) NOT NULL,`PO_date` date not null DEFAULT '2024-01-25',`date_issue` date not null DEFAULT '0000-00-00',`product_no` int(20) not null,`description` varchar(250) not null,`qty` int(20) not null,`unit_of_issue` varchar(250) not null,`unit_price` decimal(20,2) not null,`total_cost` decimal(20,2) not null,`mode_of_procure` varchar(250) not null,`remarks` varchar(250) not null,`tags` varchar(250) not null,`category` varchar(250) not null,`supplier` varchar(250) not null,`address` varchar(250) not null,`tin` varchar(250) not null,`fund` varchar(250) not null,`place_deliver` varchar(250) not null,`date_deliver` date not null DEFAULT '2024-01-25',`deliver_term` varchar(250) not null,`payment_term` varchar(250) not null,`name_of_lgu` varchar(250) not null,`ctrl_no` varchar(250) not null,`department` varchar(250) not null,`plan_amnt` decimal(20,2) not null,`net` decimal(20,2) not null,`source_of_fund` varchar(250) not null,`year` int(20) not null,`end_user` varchar(250) not null,PRIMARY KEY(`item_no`))", conn)
                cmd.ExecuteNonQuery()

                cmd = New MySqlCommand("create table if not exists " & str2 & "(`item_no`int(11) AUTO_INCREMENT NOT NULL,`no`int(11) NOT NULL,`PR_no` varchar(250) NOT NULL,`date_PR` date not null DEFAULT '2024-01-25',`date_issue` date not null DEFAULT '0000-00-00',`product_no` int(20) not null,`description` varchar(250) not null,`qty` int(20) not null,`unit_of_issue` varchar(250) not null,`unit_price` decimal(20,2) not null,`total_cost` decimal(20,2) not null,`mode_of_procure` varchar(250) not null,`qty1` int(20) not null,`amnt1` decimal(20,2) not null,`qty2` int(20) not null,`amnt2` decimal(20,2) not null,`qty3` int(20) not null,`amnt3` decimal(20,2) not null,`qty4` int(20) not null,`amnt4` decimal(20,2) not null,`category` varchar(250) not null,`remarks` varchar(250) not null,`name_of_lgu` varchar(250) not null,`ctrl_no` varchar(250) not null,`department` varchar(250) not null,`plan_amnt` decimal(20,2) not null,`net` decimal(20,2) not null,`source_of_fund` varchar(250) not null,`year` int(20) not null,`bind_tb` varchar(250) not null, PRIMARY KEY(`item_no`))", conn)
                cmd.ExecuteNonQuery()

                MsgBox("success")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try


        
    End Sub

    Private Sub name_d_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles name_d.TextChanged, sub_depart.TextChanged
        sub_depart.Text = name_d.Text
        dep2.Text = name_d.Text
    End Sub

    Private Sub bindtext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bindtext.TextChanged, sub_depart.TextChanged, tail_txt.TextChanged
        bindtext.Text = sub_depart.Text & tail_txt.Text
    End Sub

    Private Sub bind2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bind2.TextChanged, dep2.TextChanged, tail2.TextChanged
        bind2.Text = dep2.Text & tail2.Text
    End Sub
End Class