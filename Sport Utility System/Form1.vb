Imports System.Data.OleDb


Public Class Form1


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\THIRD SEMESTER\CSC301\LATEST  LATEST Sport Utility System\Sport Utility System\Customer_Login.accdb")
        Dim cmd As New OleDbCommand("SELECT*FROM Login WHERE Username= '" & txtUsername.Text & "' and Password='" & txtPassword.Text & "'", conn)
        Dim user As String = ""
        Dim pass As String = ""
        conn.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            user = sdr("Username")
            pass = sdr("Password")
            MessageBox.Show("Login Successfully!")
            grpInput.Visible = False
            grpCategory.Visible = True
            MenuStrip2.Visible = True
            MenuStrip1.Visible = False

        Else
            MessageBox.Show("Invalid username or password")
        End If
    End Sub

    Private Sub btnIndoor_Click(sender As Object, e As EventArgs) Handles btnIndoor.Click
        Me.Hide()
        Indoor.Show()
    End Sub

    Private Sub btnOutdoor_Click(sender As Object, e As EventArgs) Handles btnOutdoor.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnSignUp_Clicl(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub mnuNaviOutdoor_Click(sender As Object, e As EventArgs) Handles mnuNaviOutdoor.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Hide()
        Indoor.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        AboutUs.Show()
    End Sub

    Private Sub AdminToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem1.Click
        Form5.Show()
    End Sub

    Private Sub mnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        Application.Exit()
        Process.Start(Application.ExecutablePath)
    End Sub

    Private Sub btnShows_Click(sender As Object, e As EventArgs) Handles btnShows.Click
        If txtPassword.UseSystemPasswordChar = True Then

            txtPassword.UseSystemPasswordChar = False

        Else
            txtPassword.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub mnAboutUs_Click(sender As Object, e As EventArgs) Handles mnAboutUs.Click
        AboutUs.Show()
    End Sub
End Class