Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class PrintForm
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim da, data1, data2 As New MySqlDataAdapter
    Dim dt, dtable1, dtable2 As New DataTable
    Dim p(7) As MySqlParameter
    Private Sub PrintForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ds As New DataSet
            Dim query As String
            query = "select * from " & ViewForm.departmenttxt.Text & ""
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds, "'" & ViewForm.departmenttxt.Text & "'")
            conn.Close()
            Dim cryds As New PrintingReports
            cryds.SetDataSource(ds.Tables(0))
            'cryds.SetParameterValue("PrNo", pr_no.Text)
            CrystalReportViewer1.ReportSource = cryds
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        conn.Close()
    End Sub

   
    'Public Sub New(sTitle As String)
    '    InitializeComponent()

    '    Try
    '        Dim ds As New DataSet
    '        'Dim query As String
    '        'query = "select * from tbl_po"
    '        'Dim da As New MySqlDataAdapter(query, conn)
    '        'da.Fill(ds, "tbl_po")
    '        'conn.Close()
    '        Dim cryds As New PrintReportFor_PO
    '        view()
    '        'cryds.Database.Tables("tbl_pr").SetDataSource(dtable1)
    '        cryds.Database.Tables("tbl_po").SetDataSource(dtable2)
    '        cryds.SetDataSource(ds.Tables(0))
    '        'cryds.SetParameterValue("PrNo", pr_no.Text)
    '        CrystalReportViewer1.ReportSource = cryds
    '        CrystalReportViewer1.Refresh()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        conn.Close()
    '    End Try
    '    conn.Close()
    'End Sub

End Class