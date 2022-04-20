Imports System.Data.SqlClient
Public Class DoctorForm

    Dim con As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim rd As SqlDataReader
    Dim ds As DataSet
    Dim mydb As String
    Dim gender As String
    Sub koneksi()
        mydb = "Server =LAPTOP-BUCLP43I\MSSQLSERVER01; Database =LoginForm ;Integrated Security=True"
        con = New SqlConnection(mydb)
        If con.State = ConnectionState.Closed Then con.Open()

    End Sub

    Sub radio()

        If rdbtnMale.Checked = True Then
            gender = rdbtnMale.Text
        Else
            gender = rdbtnFemale.Text
        End If
    End Sub
    Sub kondisiawal()
        Call koneksi()
        da = New SqlDataAdapter("select * from Table_Doctor ", con)
        ds = New DataSet
        da.Fill(ds, "Table_Doctor")
        DGVDoctor.DataSource = (ds.Tables("Table_Doctor"))
        DGVDoctor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Call clear()

    End Sub

    Sub clear()
        txtDoctorID.Text = ""
        txtDoctorName.Text = ""

    End Sub

    Private Sub DoctorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Call koneksi()
        Call radio()
        Dim input As String = " Insert into Table_Doctor values('" & txtDoctorID.Text & "', '" & txtDoctorName.Text & "' ,'" & gender & "', '" & HomeForm.lblcubo.Text & "')"
        cmd = New SqlCommand(input, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Inserted")
        Call kondisiawal()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call koneksi()
        Call radio()
        Dim edit As String = "Update  Table_Doctor set DoctorID = '" & txtDoctorID.Text & "',DoctorName= '" & txtDoctorName.Text & "',DoctorGender= '" & gender & "' where DoctorID='" & txtDoctorID.Text & "'"
        cmd = New SqlCommand(edit, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Edited")
        Call kondisiawal()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call koneksi()
        Dim delete As String = "Delete Table_Doctor where DoctorID='" & txtDoctorID.Text & "'"
        cmd = New SqlCommand(delete, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data have been Deleted")
        Call kondisiawal()
    End Sub

    Private Sub txtDoctorID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDoctorID.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            Call radio()
            cmd = New SqlCommand("Select * from Table_Doctor where DoctorID= '" & txtDoctorID.Text & "' ", con)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                txtDoctorName.Text = rd.Item("DoctorName")

            Else
                MsgBox("No one data with that ID")
            End If

        End If

    End Sub

    Private Sub DGVDoctor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDoctor.CellClick
        On Error Resume Next
        txtDoctorID.Text = DGVDoctor.Rows(e.RowIndex).Cells(0).Value
        txtDoctorName.Text = DGVDoctor.Rows(e.RowIndex).Cells(1).Value
        If Trim(DGVDoctor.Rows(e.RowIndex).Cells(2).Value) = "Male" Then
            rdbtnFemale.Checked = False
            rdbtnMale.Checked = True
        Else
            rdbtnFemale.Checked = True
            rdbtnMale.Checked = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class