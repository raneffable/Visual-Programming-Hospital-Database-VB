Imports System.Data.SqlClient
Public Class EditDatabaseThermometer
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
        da = New SqlDataAdapter("select * from Table_Thermometer ", con)
        ds = New DataSet
        da.Fill(ds, "Table_Thermometer")
        DGVThermometer.DataSource = (ds.Tables("Table_Thermometer"))
        DGVThermometer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub DGVThermometer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVThermometer.CellClick
        On Error Resume Next
        txtItemCode.Text = DGVThermometer.Rows(e.RowIndex).Cells(0).Value
        txtItemName.Text = DGVThermometer.Rows(e.RowIndex).Cells(1).Value
        txtItemType.Text = DGVThermometer.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub btnInputThermometer_Click(sender As Object, e As EventArgs) Handles btnInputThermometer.Click
        Call koneksi()
        Dim input As String = " Insert into Table_Thermometer values('" & txtItemCode.Text & "', '" & txtItemName.Text & "' , '" & txtItemType.Text & "')"
        cmd = New SqlCommand(input, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Inserted")
        Call kondisiawal()
    End Sub

    Private Sub btnEditThermometer_Click(sender As Object, e As EventArgs) Handles btnEditThermometer.Click
        Call koneksi()
        Dim edit As String = "Update  Table_Thermometer set MedicalDevicesCode = '" & txtItemCode.Text & "',MedicalDevicesName= '" & txtItemName.Text & "',MedicalDevicesType= '" & txtItemType.Text & "' where MedicalDevicesCode='" & txtItemCode.Text & "'"
        cmd = New SqlCommand(edit, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Edited")
        Call kondisiawal()
    End Sub

    Private Sub btnDeleteThermometer_Click(sender As Object, e As EventArgs) Handles btnDeleteThermometer.Click
        Call koneksi()
        Dim delete As String = "Delete Table_Thermometer where MedicalDevicesCode='" & txtItemCode.Text & "'"
        cmd = New SqlCommand(delete, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Deleted")
        Call kondisiawal()
    End Sub

    Private Sub EditDatabaseThermometer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()

    End Sub
End Class