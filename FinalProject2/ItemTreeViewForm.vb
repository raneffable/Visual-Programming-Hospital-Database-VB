Imports System.Data.SqlClient
Public Class ItemTreeViewForm

    Dim con As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim mydb As String
    Dim da2 As SqlDataAdapter
    Dim ds2 As DataSet
    Sub koneksi()
        mydb = "Server =LAPTOP-BUCLP43I\MSSQLSERVER01; Database =LoginForm ;Integrated Security=True"
        con = New SqlConnection(mydb)
        If con.State = ConnectionState.Closed Then con.Open()

    End Sub


    Sub kondisiawal()
        Call koneksi()
        da = New SqlDataAdapter("select * from Table_TreeView ", con)
        ds = New DataSet
        da.Fill(ds, "Table_TreeView")
        DataGridView1.DataSource = (ds.Tables("Table_TreeView"))
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        da2 = New SqlDataAdapter("select * from Table_TreeView2 ", con)
        ds2 = New DataSet
        da2.Fill(ds2, "Table_TreeView2")
        DataGridView2.DataSource = (ds2.Tables("Table_TreeView2"))
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub ItemMasterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tvLeft_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvLeft.AfterSelect
        If tvLeft.SelectedNode.Name = "nodeAntiBiotik" Then
            Call koneksi()
            da = New SqlDataAdapter("select * from Table_AntiBiotik  ", con)
            ds = New DataSet
            da.Fill(ds, "Table_AntiBiotik")
            DataGridView1.DataSource = (ds.Tables("Table_AntiBiotik"))
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        ElseIf tvLeft.SelectedNode.Name = "nodeNarkotika" Then
            Call koneksi()
            da = New SqlDataAdapter("select * from Table_Narkotika  ", con)
            ds = New DataSet
            da.Fill(ds, "Table_Narkotika")
            DataGridView1.DataSource = (ds.Tables("Table_Narkotika"))
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        ElseIf tvLeft.SelectedNode.Name = "nodePsikotropika" Then
            Call koneksi()
            da = New SqlDataAdapter("select * from Table_Psikotropika  ", con)
            ds = New DataSet
            da.Fill(ds, "Table_Psikotropika")
            DataGridView1.DataSource = (ds.Tables("Table_Psikotropika"))
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        ElseIf tvLeft.SelectedNode.Name = "nodeXRay" Then
            Call koneksi()
            da2 = New SqlDataAdapter("select * from Table_XRay ", con)
            ds2 = New DataSet
            da2.Fill(ds2, "Table_XRay")
            DataGridView2.DataSource = (ds2.Tables("Table_XRay"))
            DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        ElseIf tvLeft.SelectedNode.Name = "nodeSyringe" Then
            Call koneksi()
            da2 = New SqlDataAdapter("select * from Table_Syringe", con)
            ds2 = New DataSet
            da2.Fill(ds2, "Table_Syringe")
            DataGridView2.DataSource = (ds2.Tables("Table_Syringe"))
            DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        ElseIf tvLeft.SelectedNode.Name = "nodeThermometer" Then
            Call koneksi()
            da2 = New SqlDataAdapter("select * from Table_Thermometer ", con)
            ds2 = New DataSet
            da2.Fill(ds2, "Table_Thermometer")
            DataGridView2.DataSource = (ds2.Tables("Table_Thermometer"))
            DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        End If
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub
End Class