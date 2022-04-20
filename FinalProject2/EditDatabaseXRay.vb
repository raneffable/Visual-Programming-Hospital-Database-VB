Imports System.Data.SqlClient
Public Class EditDatabaseXRay
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
        da = New SqlDataAdapter("select * from Table_XRay ", con)
        ds = New DataSet
        da.Fill(ds, "Table_XRay")
        DGVXRay.DataSource = (ds.Tables("Table_XRay"))
        DGVXRay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub DGVXRay_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVXRay.CellClick
        On Error Resume Next
        txtItemCode.Text = DGVXRay.Rows(e.RowIndex).Cells(0).Value
        txtItemName.Text = DGVXRay.Rows(e.RowIndex).Cells(1).Value
        txtItemType.Text = DGVXRay.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub btnInputXRay_Click(sender As Object, e As EventArgs) Handles btnInputXRay.Click
        Call koneksi()
        Dim input As String = " Insert into Table_XRay values('" & txtItemCode.Text & "', '" & txtItemName.Text & "' , '" & txtItemType.Text & "')"
        cmd = New SqlCommand(input, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Inserted")
        Call kondisiawal()
    End Sub

    Private Sub btnEditXRay_Click(sender As Object, e As EventArgs) Handles btnEditXRay.Click
        Call koneksi()
        Dim edit As String = "Update  Table_XRay set MedicalDevicesCode = '" & txtItemCode.Text & "',MedicalDevicesName= '" & txtItemName.Text & "',MedicalDevicesType= '" & txtItemType.Text & "' where MedicalDevicesCode='" & txtItemCode.Text & "'"
        cmd = New SqlCommand(edit, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Edited")
        Call kondisiawal()
    End Sub

    Private Sub btnDeleteXRay_Click(sender As Object, e As EventArgs) Handles btnDeleteXRay.Click
        Call koneksi()
        Dim delete As String = "Delete Table_XRay where MedicalDevicesCode='" & txtItemCode.Text & "'"
        cmd = New SqlCommand(delete, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Deleted")
        Call kondisiawal()
    End Sub

    Private Sub EditDatabaseXRay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()

    End Sub
End Class