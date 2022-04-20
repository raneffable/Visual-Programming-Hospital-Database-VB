Imports System.Data.SqlClient
Public Class EditDatabasePsikotropika
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
        da = New SqlDataAdapter("select * from Table_Psikotropika ", con)
        ds = New DataSet
        da.Fill(ds, "Table_Psikotropika")
        DGVPsikotropika.DataSource = (ds.Tables("Table_Psikotropika"))
        DGVPsikotropika.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub btnInputNarkotika_Click(sender As Object, e As EventArgs) Handles btnInputPsikotropika.Click
        Call koneksi()
        Dim input As String = " Insert into Table_Psikotropika values('" & txtItemCode.Text & "', '" & txtItemName.Text & "' , '" & txtItemType.Text & "')"
        cmd = New SqlCommand(input, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Inserted")
        Call kondisiawal()
    End Sub

    Private Sub btnEditPsikotropika_Click(sender As Object, e As EventArgs) Handles btnEditPsikotropika.Click
        Call koneksi()
        Dim edit As String = "Update  Table_Psikotropika set ItemCode = '" & txtItemCode.Text & "',ItemName= '" & txtItemName.Text & "',ItemType= '" & txtItemType.Text & "' where ItemCode='" & txtItemCode.Text & "'"
        cmd = New SqlCommand(edit, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Edited")
        Call kondisiawal()
    End Sub

    Private Sub btnDeletePsikotropika_Click(sender As Object, e As EventArgs) Handles btnDeletePsikotropika.Click
        Call koneksi()
        Dim delete As String = "Delete Table_Psikotropika where ItemCode='" & txtItemCode.Text & "'"
        cmd = New SqlCommand(delete, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Deleted")
        Call kondisiawal()
    End Sub

    Private Sub DGVPsikotropika_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPsikotropika.CellClick
        On Error Resume Next
        txtItemCode.Text = DGVPsikotropika.Rows(e.RowIndex).Cells(0).Value
        txtItemName.Text = DGVPsikotropika.Rows(e.RowIndex).Cells(1).Value
        txtItemType.Text = DGVPsikotropika.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub EditDatabasePsikotropika_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()

    End Sub
End Class