Imports System.Data.SqlClient
Public Class EditDatabaseNarkotika
    Dim con As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim mydb As String

    Sub koneksi()
        mydb = "Server =LAPTOP-BUCLP43I\MSSQLSERVER01; Database =LoginForm ;Integrated Security=True"
        con = New SqlConnection(mydb)
        If con.State = ConnectionState.Closed Then con.Open()

    End Sub

    Sub kondisiawal()
        Call koneksi()
        da = New SqlDataAdapter("select * from Table_Narkotika ", con)
        ds = New DataSet
        da.Fill(ds, "Table_Narkotika")
        DGVNarkotika.DataSource = (ds.Tables("Table_Narkotika"))
        DGVNarkotika.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub btnInputNarkotika_Click(sender As Object, e As EventArgs) Handles btnInputNarkotika.Click
        Call koneksi()
        Dim input As String = " Insert into Table_Narkotika values('" & txtItemCode.Text & "', '" & txtItemName.Text & "' , '" & txtItemType.Text & "')"
        cmd = New SqlCommand(input, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Inserted")
        Call kondisiawal()
    End Sub

    Private Sub btnEditNarkotika_Click(sender As Object, e As EventArgs) Handles btnEditNarkotika.Click
        Call koneksi()
        Dim edit As String = "Update  Table_Narkotika set ItemCode = '" & txtItemCode.Text & "',ItemName= '" & txtItemName.Text & "',ItemType= '" & txtItemType.Text & "' where ItemCode='" & txtItemCode.Text & "'"
        cmd = New SqlCommand(edit, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Edited")
        Call kondisiawal()
    End Sub

    Private Sub btnDeleteNarkotika_Click(sender As Object, e As EventArgs) Handles btnDeleteNarkotika.Click
        Call koneksi()
        Dim delete As String = "Delete Table_Narkotika where ItemCode='" & txtItemCode.Text & "'"
        cmd = New SqlCommand(delete, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Deleted")
        Call kondisiawal()
    End Sub

    Private Sub DGVNarkotika_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVNarkotika.CellClick
        On Error Resume Next
        txtItemCode.Text = DGVNarkotika.Rows(e.RowIndex).Cells(0).Value
        txtItemName.Text = DGVNarkotika.Rows(e.RowIndex).Cells(1).Value
        txtItemType.Text = DGVNarkotika.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub EditDatabaseNarkotika_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class