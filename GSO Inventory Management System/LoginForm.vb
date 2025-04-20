Imports MySql.Data.MySqlClient
Imports System.Environment
Imports System.Net

Public Class LoginForm
    'Dim conn As New MySqlConnection("server=localhost; user id=root; password='admin'; database=gso_db")
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim dr As MySqlDataReader
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedButtons(logbtn)
        RoundedButtons(closebtn)
        RoundedButtons(regbtn)
        RoundedBtn(signupbtn)
        RoundedBtn(Signbtn)


        ip_address()

    End Sub
    Sub ip_address()


    End Sub
    Sub listdepartmentzzzzz()
        'Dim adapt As New MySqlDataAdapter
        ''Dim dtable As New DataTable

        'conn.Close()
        'conn.Open()
        'adapt = New MySqlDataAdapter("select * from sub_department", conn)
        'dt.Clear()
        'adapt.Fill(dt)

        'selectiontxt.DisplayMember = "department"
        'selectiontxt.DataSource = dt


        'conn.Dispose()
        'conn.Close()



        Dim adapt1 As New MySqlDataAdapter
        Dim dt1 As New DataTable
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If


        adapt1 = New MySqlDataAdapter("select * from sub_department", conn)
        'dt1.Clear()
        adapt1.Fill(dt1)

        selectiontxt.DisplayMember = "department"
        selectiontxt.DataSource = dt1

        'conn.Dispose()

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Sub listdepartment_02()
        Dim adapt As New MySqlDataAdapter
        'Dim dtable As New DataTable



        adapt = New MySqlDataAdapter("select * from sub_department", conn)
        adapt.Fill(dt)

        Form1.select_combo.DisplayMember = "department"
        Form1.select_combo.DataSource = dt


        'conn.Dispose()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
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

    Private Sub RoundedBtn(j As Button)
        j.FlatAppearance.BorderSize = 0
        j.FlatStyle = FlatStyle.Flat
        j.BackColor = Color.Green
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

    Private Sub regbtn_Click(sender As Object, e As EventArgs) Handles regbtn.Click
        If fname.Text = "" Then
            MsgBox("Please fill out the fields")
        ElseIf untxt.Text = "" Then
            MsgBox("Please fill out the fields")
        ElseIf pwtxt.Text = "" Then
            MsgBox("Please fill out the fields")
        ElseIf Not pwtxt.Text = confirmtxt.Text Then
            MsgBox("Mismatch Password")
        Else
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                cmd = New MySqlCommand("insert into register(fullname,department,username,password,confirm_p)values(@fullname,@department,@username,@password,@confirm_p)", conn)
                cmd.Parameters.AddWithValue("fullname", fname.Text)
                cmd.Parameters.AddWithValue("department", selectiontxt.Text)
                cmd.Parameters.AddWithValue("username", untxt.Text)
                cmd.Parameters.AddWithValue("password", pwtxt.Text)
                cmd.Parameters.AddWithValue("confirm_p", confirmtxt.Text)
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                MsgBox("Success")
                login_panel.Visible = True
                register_panel.Visible = False
            End Try


        End If

        fname.Text = ""
        selectiontxt.SelectedIndex = 0
        untxt.Text = ""
        pwtxt.Text = ""
        confirmtxt.Text = ""

    End Sub

    Private Sub signupbtn_Click(sender As Object, e As EventArgs) Handles signupbtn.Click

        listdepartmentzzzzz()


        register_panel.Visible = True
        login_panel.Visible = False

        Signbtn.Visible = True
        signupbtn.Visible = False

        'listdepartment_01()
    End Sub

    Private Sub logbtn_Click(sender As Object, e As EventArgs) Handles logbtn.Click
        Dim cmd As New MySqlCommand

        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim query As String
            query = "select * from register where Username='" & txt_un.Text & "' and Password='" & txt_pw.Text & "'"
            cmd = New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader

            Dim count As Integer
            count = 0
            While dr.Read
                count = count + 1
            End While
            If count = 1 Then
                Dim Usertype = dr.GetString("usertype")
                If Usertype = "Administrator" Then
                    For j = 0 To 500
                        'Form1.Show()
                        Form1.nametxt.Text = dr.Item("fullname").ToString
                        Form1.dep.Text = dr.Item("department").ToString
                        updateform.SELECTTXT.Text = dr.Item("department").ToString
                        updateform1.SELECTTXT.Text = dr.Item("department").ToString
                        Form1.Show()
                        Me.Hide()

                    Next


                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                    'conn.Dispose()
                    MsgBox("Welcome Administrator", MsgBoxStyle.Information)


                ElseIf count = 1 Then
                    Dim User = dr.GetString("usertype")
                    If User = "" Then
                        For j = 0 To 500


                        Next

                        Form1.nametxt.Text = dr.Item("fullname").ToString
                        Form1.dep.Text = dr.Item("department").ToString
                        updateform.SELECTTXT.Text = dr.Item("department").ToString
                        updateform1.SELECTTXT.Text = dr.Item("department").ToString
                        ViewForm.departmenttxt.Text = dr.Item("department").ToString
                        ViewForm.usertxt.Text = dr.Item("fullname").ToString
                        ViewForm.sub_txt_01.Text = ViewForm.usertxt.Text & " - " & ViewForm.departmenttxt.Text

                        'Form1.Show()
                        ViewForm.Show()
                        Me.Hide()

                        MsgBox("Welcome User", MsgBoxStyle.Information)

                        If conn.State = ConnectionState.Open Then
                            conn.Close()
                        End If
                        'conn.Dispose()


                        ViewForm.q_11()
                        ViewForm.q_21()
                        ViewForm.q_31()
                        ViewForm.q_41()
                        ViewForm.total_amnt1()
                        '------------- Show Data -------------
                        ViewForm.showdata()

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


                    End If


                End If



            Else
                MsgBox("Access Denied...", MsgBoxStyle.Critical, "Information")

            End If


        Catch ex As Exception

        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        End Try
        txt_un.Text = ""
        txt_pw.Text = ""

        ViewForm.counttxt.Text = ViewForm.DataGridView1.RowCount
        update_logs()
        ViewForm.logs_id()

    End Sub


    Public Sub update_logs()

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into logs(Date,FullName,Login)values('" & datetxt.Text & "','" & Form1.nametxt.Text & "','" & timetxt.Text & "')"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

    End Sub
    Private Sub conntxt_Click(sender As Object, e As EventArgs)




        openconnection()

            listdepartment_02()








    End Sub





    Private Sub Signbtn_Click(sender As Object, e As EventArgs) Handles Signbtn.Click
        register_panel.Visible = False
        login_panel.Visible = True
        Signbtn.Visible = False
        signupbtn.Visible = True
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        End
    End Sub

    Private Sub connect_panel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub closetxt_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timetxt.Text = TimeOfDay
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        datetxt.Text = Format(Now, "yyyy-MM-dd")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Try
        '    conn.Open()
        '    cmd.Connection = conn
        '    cmd.CommandType = CommandType.Text
        '    cmd.CommandText = "insert into logs(Date,FullName,Login)values('" & datetxt.Text & "','" & txt_un.Text & "','" & timetxt.Text & "')"
        '    cmd.ExecuteNonQuery()

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    conn.Close()
        'End Try

    End Sub
End Class