Imports System.Data.SqlClient
Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim con As SqlConnection = New SqlConnection("Server =LAPTOP-BUCLP43I\MSSQLSERVER01; Database= LoginForm;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from Table_Login where Username = '" + txtUsername.Text + "'and Password ='" + txtPassword.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim table As New DataTable()

        sda.Fill(table)

        If (table.Rows.Count > 0) Then
            Dim userid = Convert.ToInt32(table.Rows(0)("UserID"))
            MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            WelcomeForm.Show()
            Me.Hide()
            HomeForm.lblcubo.Text = userid

        Else
            MessageBox.Show("Username or Password Incorrect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"

        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"
        txtUsername.Focus()

    End Sub

End Class
