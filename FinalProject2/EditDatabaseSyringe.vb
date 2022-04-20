Imports System.Data.SqlClient
Public Class EditDatabaseSyringe
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
        da = New SqlDataAdapter("select * from Table_Syringe ", con)
        ds = New DataSet
        da.Fill(ds, "Table_Syringe")
        DGVSyringe.DataSource = (ds.Tables("Table_Syringe"))
        DGVSyringe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub DGVSyringe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSyringe.CellClick
        On Error Resume Next
        txtItemCode.Text = DGVSyringe.Rows(e.RowIndex).Cells(0).Value
        txtItemName.Text = DGVSyringe.Rows(e.RowIndex).Cells(1).Value
        txtItemType.Text = DGVSyringe.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub btnInputSyringe_Click(sender As Object, e As EventArgs) Handles btnInputSyringe.Click
        Call koneksi()
        Dim input As String = " Insert into Table_Syringe values('" & txtItemCode.Text & "', '" & txtItemName.Text & "' , '" & txtItemType.Text & "')"
        cmd = New SqlCommand(input, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Inserted")
        Call kondisiawal()
    End Sub

    Private Sub btnEditSyringe_Click(sender As Object, e As EventArgs) Handles btnEditSyringe.Click
        Call koneksi()
        Dim edit As String = "Update  Table_Syringe set MedicalDevicesCode = '" & txtItemCode.Text & "',MedicalDevicesName= '" & txtItemName.Text & "',MedicalDevicesType= '" & txtItemType.Text & "' where MedicalDevicesCode='" & txtItemCode.Text & "'"
        cmd = New SqlCommand(edit, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Edited")
        Call kondisiawal()
    End Sub

    Private Sub btnDeleteSyringe_Click(sender As Object, e As EventArgs) Handles btnDeleteSyringe.Click
        Call koneksi()
        Dim delete As String = "Delete Table_Syringe where MedicalDevicesCode='" & txtItemCode.Text & "'"
        cmd = New SqlCommand(delete, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Deleted")
        Call kondisiawal()
    End Sub

    Private Sub EditDatabaseSyringe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()

    End Sub


End Class