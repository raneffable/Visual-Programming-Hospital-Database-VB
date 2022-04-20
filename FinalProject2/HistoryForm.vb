Imports System.Data.SqlClient
Public Class HistoryForm

    Dim con As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand

    Dim rd As SqlDataReader
    Dim ds As DataSet
    Dim mydb As String

    Dim item As ListViewItem


    Sub koneksi()
        mydb = "Server =LAPTOP-BUCLP43I\MSSQLSERVER01; Database =LoginForm ;Integrated Security=True"
        con = New SqlConnection(mydb)
        If con.State = ConnectionState.Closed Then con.Open()

    End Sub



    Private Sub HistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()


        Try
            Dim cmd As New SqlCommand


            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = " select * from Table_History"

            rd = cmd.ExecuteReader
            lv.Items.Clear()
            While (rd.Read())
                item = lv.Items.Add(rd("ItemName"))
                With item
                    .SubItems.Add(rd("Amount"))
                    .SubItems.Add(rd("Price"))
                    .SubItems.Add(rd("TotalPrice"))
                End With
            End While
        Catch ex As Exception

        End Try
        'lv.Columns.Add("Name Item", 190, HorizontalAlignment.Center)
        'lv.Columns.Add("Amount", 100, HorizontalAlignment.Center)
        'lv.Columns.Add("Price", 120, HorizontalAlignment.Center)
        'lv.Columns.Add("TotalPrice", 120, HorizontalAlignment.Center)
        lv.View = View.Details
        lv.FullRowSelect = True
        lv.GridLines = True

        Dim nameitem As String
        Dim itemid() As String = {"Penisilin", "Sefalosporin", "Aminoglikosida", "Amoxicillin", "Morfin", "Kokain", "Heroin", "Opium", "Ekstasi", "SabuSabu", "Sedatin", "ObatTidur", "Intramuskular", "Suubkutan", "Intradermal", "Diagnostic", "Rontgen", "USG", "Digital", "DotDigital", "Infrared"}
        For Each nameitem In itemid
            cmbboxItemName.Items.Add(nameitem)
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call koneksi()
        Dim input As String = "insert into table_History(ItemName,Amount,Price,TotalPrice)values ('" & cmbboxItemName.Text & "','" & txtAmount.Text & "' , '" & txtPrice.Text & "','" & txtTotalPrice.Text & "') "
        cmd = New SqlCommand(input, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Inserted")


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class