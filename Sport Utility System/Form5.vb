Imports System.Data.OleDb

Public Class Form5
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\THIRD SEMESTER\CSC301\LATEST  LATEST Sport Utility System\Sport Utility System\Customer_Login.accdb")
        Dim cmd As New OleDbCommand("SELECT*FROM Admin WHERE Username= '" & txtUsername.Text & "' and Password='" & txtPassword.Text & "'", conn)
        Dim user As String = ""
        Dim pass As String = ""
        conn.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            user = sdr("Username")
            pass = sdr("Password")
            MessageBox.Show("Login Successfully!")
            Me.Hide()
            Form6.Show()
        Else
            MessageBox.Show("Invalid username or password")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form5_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnPass_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        If txtPassword.UseSystemPasswordChar = True Then

            txtPassword.UseSystemPasswordChar = False

        Else
            txtPassword.UseSystemPasswordChar = True

        End If
    End Sub
End Class