Imports System.Data.OleDb

Public Class Form4
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSignPassword.UseSystemPasswordChar = True

    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\THIRD SEMESTER\CSC301\LATEST  LATEST Sport Utility System\Sport Utility System\Customer_Login.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()

        ' Check if the username already exists
        Dim checkCommand As String = "SELECT COUNT(*) FROM Login WHERE [Username] = @Username"
        Dim checkCmd As New OleDbCommand(checkCommand, myconnection)
        checkCmd.Parameters.Add(New OleDbParameter("@Username", txtSignUsername.Text))

        Dim userCount As Integer = CInt(checkCmd.ExecuteScalar())

        If userCount > 0 Then
            ' Username already exists, show a messagebox
            MessageBox.Show("Username already taken. Please choose a different username.")
            myconnection.Close()
            Return
        End If

        ' Continue with the signup process since the username is unique
        Dim command As String = "INSERT INTO Login ([Username],[Password]) VALUES (@Username, @Password)"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("@Username", txtSignUsername.Text))
        cmd.Parameters.Add(New OleDbParameter("@Password", txtSignPassword.Text))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtSignUsername.Clear()
            txtSignPassword.Clear()
            MessageBox.Show("Thank You For Signing Up, Enjoy Shopping!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Hide()
        Form1.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If txtSignPassword.UseSystemPasswordChar = True Then

            txtSignPassword.UseSystemPasswordChar = False

        Else
            txtSignPassword.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class