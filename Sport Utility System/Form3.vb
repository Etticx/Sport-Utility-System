Imports System.Data.OleDb

Public Class Form3

    Dim dblTotPriceOut As Double = 0.0
    Dim intResponse As Integer
    Public strOutdoor(7) As String
    Dim intX As Integer = -1
    Dim strFormat As String = "{0,-29}{1,0}"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboType.Text = "Choose"
        cboBikeQty1.Text = "Quantity"
        cboBikeQty2.Text = "Quantity"
        cboBallsQty1.Text = "Quantity"
        cboBallsQty2.Text = "Quantity"
        cboSportwearQty1.Text = "Quantity"
        cboSportwearQty2.Text = "Quantity"
        cboFamQty1.Text = "Quantity"
        cboFamQty2.Text = "Quantity"

    End Sub

    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        ' Hide all group boxes initially
        grpBalls.Visible = False
        grpBicycle.Visible = False
        grpFamily.Visible = False
        grpSportwear.Visible = False

        ' Show the corresponding group box based on the selected item
        Select Case cboType.SelectedItem.ToString()
            Case "Bicycle"
                grpBicycle.Visible = True
            Case "Balls"
                grpBalls.Visible = True
            Case "Family"
                grpFamily.Visible = True
            Case "SportWears"
                grpSportwear.Visible = True
        End Select
    End Sub


    Private Function GetItemPrice(itemName As String) As Double
        Dim price As Double = 0.0
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\THIRD SEMESTER\CSC301\LATEST  LATEST Sport Utility System\Sport Utility System\Customer_Login.accdb;Persist Security Info=False;"

        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT Price FROM Outdoor WHERE Item_Name = @ItemName"

                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@ItemName", itemName)

                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        price = Convert.ToDouble(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle the exception (e.g., log the error, show a message to the user)
            MessageBox.Show($"Error retrieving price: {ex.Message}")
        End Try

        Return price
    End Function

    Private Function CalculatePrice(itemName As String, quantity As Integer) As Double
        ' Retrieve the price from the database
        Dim itemPrice As Double = GetItemPrice(itemName)

        ' Update the total price
        Select Case quantity
            Case 1
                dblTotPriceOut += itemPrice
            Case 2
                dblTotPriceOut += itemPrice * 2
            Case 3
                dblTotPriceOut += itemPrice * 3
            Case 4
                dblTotPriceOut += itemPrice * 4
            Case 5
                dblTotPriceOut += itemPrice * 5
        End Select

        Return dblTotPriceOut
    End Function


    Private Sub grpBalls_Enter(sender As Object, e As EventArgs) Handles grpBalls.Enter

    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

    'Calculation Family Part
    Private Sub btnFamilyAdd1_Click(sender As Object, e As EventArgs) Handles btnFamilyAdd1.Click
        If cboFamQty1.SelectedIndex = -1 Then
            MsgBox("Choose a quantity", vbOKOnly & vbExclamation, "Error")
        Else
            intResponse = MsgBox("Do you want to proceed ?", vbYesNo + vbQuestion, "Add to Cart")
            If intResponse = MsgBoxResult.Yes Then
                dblTotPriceOut = CalculatePrice("Inflatable Kayak", cboFamQty1.SelectedIndex + 1)
                intX += 1
                strOutdoor(intX) = String.Format(strFormat, "Inflatable Kayak", "X" & (cboFamQty1.SelectedIndex + 1))
            End If
        End If
    End Sub

    Private Sub btnFamilyAdd2_Click(sender As Object, e As EventArgs) Handles btnFamilyAdd2.Click
        If cboFamQty2.SelectedIndex = -1 Then
            MsgBox("Choose a quantity", vbOKOnly & vbExclamation, "Error")
        Else
            intResponse = MsgBox("Do you want to proceed ?", vbYesNo + vbQuestion, "Add to Cart")
            If intResponse = MsgBoxResult.Yes Then
                dblTotPriceOut = CalculatePrice("Arpasas Tent", cboFamQty2.SelectedIndex + 1)
                intX += 1
                strOutdoor(intX) = String.Format(strFormat, "Arpasas Tent", "X" & (cboFamQty2.SelectedIndex + 1))
            End If
        End If
    End Sub

    'Calculation Sportwear Part
    Private Sub btnSportwearAdd1_Click(sender As Object, e As EventArgs) Handles btnSportwearAdd1.Click
        If cboSportwearQty1.SelectedIndex = -1 Then
            MsgBox("Choose a quantity", vbOKOnly & vbExclamation, "Error")
        Else
            intResponse = MsgBox("Do you want to proceed ?", vbYesNo + vbQuestion, "Add to Cart")
            If intResponse = MsgBoxResult.Yes Then
                dblTotPriceOut = CalculatePrice("Crocs Boot", cboSportwearQty1.SelectedIndex + 1)
                intX += 1
                strOutdoor(intX) = String.Format(strFormat, "Crocs Boot", "X" & (cboSportwearQty1.SelectedIndex + 1))
            End If
        End If

    End Sub

    Private Sub btnSportwearAdd2_Click(sender As Object, e As EventArgs) Handles btnSportwearAdd2.Click
        If cboSportwearQty2.SelectedIndex = -1 Then
            MsgBox("Choose a quantity", vbOKOnly & vbExclamation, "Error")
        Else
            intResponse = MsgBox("Do you want to proceed ?", vbYesNo + vbQuestion, "Add to Cart")
            If intResponse = MsgBoxResult.Yes Then
                dblTotPriceOut = CalculatePrice("Waterproof jacket", cboSportwearQty2.SelectedIndex + 1)
                intX += 1
                strOutdoor(intX) = String.Format(strFormat, "Waterproof jacket", "X" & (cboSportwearQty2.SelectedIndex + 1))
            End If
        End If
    End Sub

    Private Sub btnBallsAdd1_Click(sender As Object, e As EventArgs) Handles btnBallsAdd1.Click
        If cboBallsQty1.SelectedIndex = -1 Then
            MsgBox("Choose a quantity", vbOKOnly & vbExclamation, "Error")
        Else
            intResponse = MsgBox("Do you want to proceed ?", vbYesNo + vbQuestion, "Add to Cart")
            If intResponse = MsgBoxResult.Yes Then
                dblTotPriceOut = CalculatePrice("Inesis Golf Balls", cboBallsQty1.SelectedIndex + 1)
                intX += 1
                strOutdoor(intX) = String.Format(strFormat, "Inesis Golf Balls", "X" & (cboBallsQty1.SelectedIndex + 1))
            End If
        End If
    End Sub

    Private Sub btnBallsAdd2_Click(sender As Object, e As EventArgs) Handles btnBallsAdd2.Click
        If cboBallsQty2.SelectedIndex = -1 Then
            MsgBox("Choose a quantity", vbOKOnly & vbExclamation, "Error")
        Else
            intResponse = MsgBox("Do you want to proceed ?", vbYesNo + vbQuestion, "Add to Cart")
            If intResponse = MsgBoxResult.Yes Then
                dblTotPriceOut = CalculatePrice("Kipsta Football", cboBallsQty2.SelectedIndex + 1)
                intX += 1
                strOutdoor(intX) = String.Format(strFormat, "Kipsta Football", "X" & (cboBallsQty1.SelectedIndex + 1))
            End If
        End If
    End Sub

    Private Sub btnBikeAdd1_Click(sender As Object, e As EventArgs) Handles btnBikeAdd1.Click
        If cboBikeQty1.SelectedIndex = -1 Then
            MsgBox("Choose a quantity", vbOKOnly & vbExclamation, "Error")
        Else
            intResponse = MsgBox("Do you want to proceed ?", vbYesNo + vbQuestion, "Add to Cart")
            If intResponse = MsgBoxResult.Yes Then
                dblTotPriceOut = CalculatePrice("Riverside Bicycle", cboBikeQty1.SelectedIndex + 1)
                intX += 1
                strOutdoor(intX) = String.Format(strFormat, "Riverside Bicycle", "X" & (cboBikeQty1.SelectedIndex + 1))
            End If
        End If
    End Sub

    Private Sub btnBikeAdd2_Click(sender As Object, e As EventArgs) Handles btnBikeAdd2.Click
        If cboBikeQty2.SelectedIndex = -1 Then
            MsgBox("Choose a quantity", vbOKOnly & vbExclamation, "Error")
        Else
            intResponse = MsgBox("Do you want to proceed ?", vbYesNo + vbQuestion, "Add to Cart")
            If intResponse = MsgBoxResult.Yes Then
                dblTotPriceOut = CalculatePrice("Triban Bicycle", cboBikeQty2.SelectedIndex + 1)
                intX += 1
                strOutdoor(intX) = String.Format(strFormat, "Triban Bicycle", "X" & (cboBikeQty2.SelectedIndex + 1))
            End If
        End If
    End Sub

    Private Sub btnProceedToCheckout_Click(sender As Object, e As EventArgs) Handles btnProceedToCheckout.Click
        Dim intResponse As Integer
        intResponse = MsgBox("Are you sure you want to proceed to checkout form ?", vbYesNo + vbQuestion, "Proceed")
        If intResponse = MsgBoxResult.Yes Then
            Form2.Show()
        End If

    End Sub

    Public Function getTotalValue() As Double
        Return dblTotPriceOut
    End Function

    Private Sub btnBackToCategory_Click(sender As Object, e As EventArgs) Handles btnBackToCategory.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub mnuNaviHome_Click(sender As Object, e As EventArgs) Handles mnuNaviHome.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub mnuNaviIndoor_Click(sender As Object, e As EventArgs) Handles mnuNaviIndoor.Click
        Me.Hide()
        Indoor.Show()
    End Sub

    Private Sub mnAboutUs_Click(sender As Object, e As EventArgs) Handles mnAboutUs.Click
        AboutUs.Show()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub mnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        Application.Exit()
        Process.Start(Application.ExecutablePath)
    End Sub
End Class
