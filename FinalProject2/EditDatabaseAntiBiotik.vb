Imports System.Data.SqlClient
Public Class EditDatabaseAntiBiotik
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
        da = New SqlDataAdapter("select * from Table_AntiBiotik ", con)
        ds = New DataSet
        da.Fill(ds, "Table_AntiBiotik")
        DGVAntiBiotik.DataSource = (ds.Tables("Table_AntiBiotik"))
        DGVAntiBiotik.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub btnInputAntiBiotik_Click(sender As Object, e As EventArgs) Handles btnInputAntiBiotik.Click
        Call koneksi()
        Dim input As String = " Insert into Table_AntiBiotik values('" & txtItemCode.Text & "', '" & txtItemName.Text & "' , '" & txtItemType.Text & "')"
        cmd = New SqlCommand(input, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Inserted")
        Call kondisiawal()
    End Sub

    Private Sub btnEditAntiBiotik_Click(sender As Object, e As EventArgs) Handles btnEditAntiBiotik.Click
        Call koneksi()
        Dim edit As String = "Update  Table_AntiBiotik set ItemCode = '" & txtItemCode.Text & "',ItemName= '" & txtItemName.Text & "',ItemType= '" & txtItemType.Text & "' where ItemCode='" & txtItemCode.Text & "'"
        cmd = New SqlCommand(edit, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Edited")
        Call kondisiawal()
    End Sub

    Private Sub btnDeleteAntiBiotik_Click(sender As Object, e As EventArgs) Handles btnDeleteAntiBiotik.Click
        Call koneksi()
        Dim delete As String = "Delete Table_AntiBiotik where ItemCode='" & txtItemCode.Text & "'"
        cmd = New SqlCommand(delete, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Deleted")
        Call kondisiawal()
    End Sub

    Private Sub EditDatabaseAntiBiotik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()

    End Sub

    Private Sub DGVAntiBiotik_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAntiBiotik.CellClick
        On Error Resume Next
        txtItemCode.Text = DGVAntiBiotik.Rows(e.RowIndex).Cells(0).Value
        txtItemName.Text = DGVAntiBiotik.Rows(e.RowIndex).Cells(1).Value
        txtItemType.Text = DGVAntiBiotik.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class