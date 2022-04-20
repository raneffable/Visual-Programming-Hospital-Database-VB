Imports System.Data.SqlClient
Public Class FullItemListForm

    Dim con As SqlConnection
    Dim da, da1, da2, da3, da4, da5 As SqlDataAdapter
    Dim ds, ds1, ds2, ds3, ds4, ds5 As DataSet

    Private Sub btnEditDatabaseThermometer_Click(sender As Object, e As EventArgs) Handles btnEditDatabaseThermometer.Click
        EditDatabaseThermometer.Show()

    End Sub

    Private Sub btnEditDatabaseXRay_Click(sender As Object, e As EventArgs) Handles btnEditDatabaseXRay.Click
        EditDatabaseXRay.Show()

    End Sub

    Private Sub btnEditDatabaseSyringe_Click(sender As Object, e As EventArgs) Handles btnEditDatabaseSyringe.Click
        EditDatabaseSyringe.Show()
    End Sub

    Dim mydb As String

    Private Sub btnEditDatabasePsikotropika_Click(sender As Object, e As EventArgs) Handles btnEditDatabasePsikotropika.Click
        EditDatabasePsikotropika.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call kondisiawal()

    End Sub

    Private Sub btnEditDatabaseNarkotika_Click(sender As Object, e As EventArgs) Handles btnEditDatabaseNarkotika.Click
        EditDatabaseNarkotika.Show()

    End Sub



    Private Sub btnEditDatabaseAntiBiotik_Click(sender As Object, e As EventArgs) Handles btnEditDatabaseAntiBiotik.Click
        EditDatabaseAntiBiotik.Show()
    End Sub

    Private Sub FullItemListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub

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

        da1 = New SqlDataAdapter("select * from Table_Narkotika ", con)
        ds1 = New DataSet
        da1.Fill(ds1, "Table_Narkotika ")
        DGVNarkotika.DataSource = (ds1.Tables("Table_Narkotika "))
        DGVNarkotika.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        da2 = New SqlDataAdapter("select * from Table_Psikotropika ", con)
        ds2 = New DataSet
        da2.Fill(ds2, "Table_Psikotropika")
        DGVPsikotropika.DataSource = (ds2.Tables("Table_Psikotropika"))
        DGVPsikotropika.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        da3 = New SqlDataAdapter("select * from Table_Syringe", con)
        ds3 = New DataSet
        da3.Fill(ds3, "Table_Syringe")
        DGVSyringe.DataSource = (ds3.Tables("Table_Syringe"))
        DGVSyringe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        da4 = New SqlDataAdapter("select * from Table_XRay ", con)
        ds4 = New DataSet
        da4.Fill(ds4, "Table_XRay")
        DGVXRay.DataSource = (ds4.Tables("Table_XRay"))
        DGVXRay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        da5 = New SqlDataAdapter("select * from Table_Thermometer ", con)
        ds5 = New DataSet
        da5.Fill(ds5, "Table_Thermometer")
        DGVThermometer.DataSource = (ds5.Tables("Table_Thermometer"))
        DGVThermometer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub





End Class