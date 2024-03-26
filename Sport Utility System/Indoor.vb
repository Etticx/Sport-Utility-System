Imports System.Data.OleDb

Public Class Indoor
    Dim dblIntotprice As Double = 0
    Dim intResponse As Integer
    Dim strIndoorItems As String
    Public strIndoor(7) As String
    Dim intX As Integer = -1
    Dim strFormat As String = "{0,-29}{1,0}"


    Private Sub cboEquipment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEquipment.SelectedIndexChanged

        'Group box display'
        If cboEquipment.SelectedIndex = 0 Then
            grpItems.Visible = True
            grpItems2.Visible = False
            grpItems3.Visible = False
            grpItems4.Visible = False
        ElseIf cboEquipment.SelectedIndex = 1 Then
            grpItems.Visible = False
            grpItems2.Visible = True
            grpItems3.Visible = False
            grpItems4.Visible = False
        ElseIf cboEquipment.SelectedIndex = 2 Then
            grpItems.Visible = False
            grpItems2.Visible = False
            grpItems3.Visible = True
            grpItems4.Visible = False
        Else
            grpItems.Visible = False
            grpItems2.Visible = False
            grpItems3.Visible = False
            grpItems4.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Choose Equipment Combo box'
        cboEquipment.Text = "Choose"
        cboEquipment.Items.Add("Dumbbells")
        cboEquipment.Items.Add("Yoga Mats")
        cboEquipment.Items.Add("Dart Boards")
        cboEquipment.Items.Add("Hand Grippers")

        'hexagon Dumbbells  Quantity
        cboQuantityHexDumb.Text = "Quantity"
        cboQuantityHexDumb.Items.Add("1")
        cboQuantityHexDumb.Items.Add("2")
        cboQuantityHexDumb.Items.Add("3")
        cboQuantityHexDumb.Items.Add("4")
        cboQuantityHexDumb.Items.Add("5")

        'Compact Dumbbells Quantity'
        cboQuantityComDumb.Text = "Quantity"
        cboQuantityComDumb.Items.Add("1")
        cboQuantityComDumb.Items.Add("2")
        cboQuantityComDumb.Items.Add("3")
        cboQuantityComDumb.Items.Add("4")
        cboQuantityComDumb.Items.Add("5")

        'Premium Yoga Mats'
        cboQuantityPremYogaMat.Text = "Quantity"
        cboQuantityPremYogaMat.Items.Add("1")
        cboQuantityPremYogaMat.Items.Add("2")
        cboQuantityPremYogaMat.Items.Add("3")
        cboQuantityPremYogaMat.Items.Add("4")
        cboQuantityPremYogaMat.Items.Add("5")

        'Standard Yoga Mats'
        cboQuantityStandYogaMat.Text = "Quantity"
        cboQuantityStandYogaMat.Items.Add("1")
        cboQuantityStandYogaMat.Items.Add("2")
        cboQuantityStandYogaMat.Items.Add("3")
        cboQuantityStandYogaMat.Items.Add("4")
        cboQuantityStandYogaMat.Items.Add("5")

        'DartBoards'
        cboQuantityDartBoards.Text = "Quantity"
        cboQuantityDartBoards.Items.Add("1")
        cboQuantityDartBoards.Items.Add("2")
        cboQuantityDartBoards.Items.Add("3")
        cboQuantityDartBoards.Items.Add("4")
        cboQuantityDartBoards.Items.Add("5")

        'Premium DartBoards'
        cboQuantityPremDartBoards.Text = "Quantity"
        cboQuantityPremDartBoards.Items.Add("1")
        cboQuantityPremDartBoards.Items.Add("2")
        cboQuantityPremDartBoards.Items.Add("3")
        cboQuantityPremDartBoards.Items.Add("4")
        cboQuantityPremDartBoards.Items.Add("5")

        'Hand Grippers'
        cboQuantityHandGrippers.Text = "Quantity"
        cboQuantityHandGrippers.Items.Add("1")
        cboQuantityHandGrippers.Items.Add("2")
        cboQuantityHandGrippers.Items.Add("3")
        cboQuantityHandGrippers.Items.Add("4")
        cboQuantityHandGrippers.Items.Add("5")

        'Electronic Hand Grippers'
        cboQuantityElecHandGrippers.Text = "Quantity"
        cboQuantityElecHandGrippers.Items.Add("1")
        cboQuantityElecHandGrippers.Items.Add("2")
        cboQuantityElecHandGrippers.Items.Add("3")
        cboQuantityElecHandGrippers.Items.Add("4")
        cboQuantityElecHandGrippers.Items.Add("5")


    End Sub
    Private Function GetItemPrice(itemName As String) As Double
        Dim price As Double = 0.0
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\THIRD SEMESTER\CSC301\LATEST  LATEST Sport Utility System\Sport Utility System\Customer_Login.accdb;Persist Security Info=False;"

        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT Price FROM Indoor WHERE Item_Name = @ItemName"

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
                dblIntotprice += itemPrice
            Case 2
                dblIntotprice += itemPrice * 2
            Case 3
                dblIntotprice += itemPrice * 3
            Case 4
                dblIntotprice += itemPrice * 4
            Case 5
                dblIntotprice += itemPrice * 5
        End Select

        Return dblIntotprice
    End Function

    Private Sub btnAddHexDumbbells_Click(sender As Object, e As EventArgs) Handles btnAddHexDumbbells.Click

        'Calculation hexagon dumbbells'

        If cboQuantityHexDumb.SelectedIndex = -1 Then
            MsgBox("Choose a quantity", vbOKOnly & vbExclamation, "Error")
        Else
            intResponse = MsgBox("Do you want to proceed ?", vbYesNo + vbQuestion, "Add to Cart")
            If intResponse = MsgBoxResult.Yes Then
                dblIntotprice = CalculatePrice("Hexagon Dumbells", cboQuantityHexDumb.SelectedIndex + 1)
                intX += 1
                strIndoor(intX) = String.Format(strFormat, "Hexagon Dumbells", "X" & (cboQuantityHexDumb.SelectedIndex + 1))
            End If
        End If

    End Sub

    Private Sub btnAddComDumbbells_Click(sender As Object, e As EventArgs) Handles btnAddComDumbbells.Click

        'calculation compact dumbbells'

        If cboQuantityComDumb.SelectedIndex = -1 Then
            MsgBox("Choose a quantity", vbOKOnly & vbExclamation, "Error")
        Else
            intResponse = MsgBox("Do you want to proceed ?", vbYesNo + vbQuestion, "Add to Cart")
            If intResponse = MsgBoxResult.Yes Then
                dblIntotprice = CalculatePrice("Compact Dumbells", cboQuantityComDumb.SelectedIndex + 1)
                intX += 1
                strIndoor(intX) = String.Format(strFormat, "Compact Dumbells", "X" & (cboQuantityComDumb.SelectedIndex + 1))
            End If
        End If

    End Sub

    Private Sub btnAddPremYogaMat_Click(sender As Object, e As EventArgs) Handles btnAddPremYogaMat.Click

        'calculation Premium Yoga Mat'

        If cboQuantityPremYogaMat.SelectedIndex = -1 Then
            MsgBox("Choose a quantity", vbOKOnly & vbExclamation, "Error")
        Else
            intResponse = MsgBox("Do you want to proceed ?", vbYesNo + vbQuestion, "Add to Cart")
            If intResponse = MsgBoxResult.Yes Then
                dblIntotprice = CalculatePrice("Premium Yoga Mats", cboQuantityPremYogaMat.SelectedIndex + 1)
                intX += 1
                strIndoor(intX) = String.Format(strFormat, "Premium Yoga Maths", "X" & (cboQuantityPremYogaMat.SelectedIndex + 1))
            End If
        End If

    End Sub

    Private Sub btnAddStandYogaMat_Click(sender As Object, e As EventArgs) Handles btnAddStandYogaMat.Click

        'calculation standard yoga mat'

        If cboQuantityStandYogaMat.SelectedIndex = -1 Then
            MsgBox("Choose a quantity", vbOKOnly & vbExclamation, "Error")
        Else
            intResponse = MsgBox("Do you want to proceed ?", vbYesNo + vbQuestion, "Add to Cart")
            If intResponse = MsgBoxResult.Yes Then
                dblIntotprice = CalculatePrice("Standard Yoga Mats", cboQuantityStandYogaMat.SelectedIndex + 1)
                intX += 1
                strIndoor(intX) = String.Format(strFormat, "Standard Yoga Mats", "X" & (cboQuantityStandYogaMat.SelectedIndex + 1))
            End If
        End If


    End Sub

    Private Sub btnAddDartBoards_Click(sender As Object, e As EventArgs) Handles btnAddDartBoards.Click

        'calculation dart boards'

        If cboQuantityDartBoards.SelectedIndex = -1 Then
            MsgBox("Choose a quantity", vbOKOnly & vbExclamation, "Error")
        Else
            intResponse = MsgBox("Do you want to proceed ?", vbYesNo + vbQuestion, "Add to Cart")
            If intResponse = MsgBoxResult.Yes Then
                dblIntotprice = CalculatePrice("Dart Boards", cboQuantityDartBoards.SelectedIndex + 1)
                intX += 1
                strIndoor(intX) = String.Format(strFormat, "Dart Boards", "X" & (cboQuantityDartBoards.SelectedIndex + 1))
            End If
        End If


    End Sub

    Private Sub btnAddPremDartBoards_Click(sender As Object, e As EventArgs) Handles btnAddPremDartBoards.Click

        'calulation premium dart boards' 

        If cboQuantityPremDartBoards.SelectedIndex = -1 Then
            MsgBox("Choose a quantity", vbOKOnly & vbExclamation, "Error")
        Else
            intResponse = MsgBox("Do you want to proceed ?", vbYesNo + vbQuestion, "Add to Cart")
            If intResponse = MsgBoxResult.Yes Then
                dblIntotprice = CalculatePrice("Premium Dart Boards", cboQuantityPremDartBoards.SelectedIndex + 1)
                intX += 1
                strIndoor(intX) = String.Format(strFormat, "Premium Dart Boards", "X" & (cboQuantityPremDartBoards.SelectedIndex + 1))
            End If
        End If

    End Sub

    Private Sub btnAddHandGrippers_Click(sender As Object, e As EventArgs) Handles btnAddHandGrippers.Click

        'calculation hand grippers'

        If cboQuantityHandGrippers.SelectedIndex = -1 Then
            MsgBox("Choose a quantity", vbOKOnly & vbExclamation, "Error")
        Else
            intResponse = MsgBox("Do you want to proceed ?", vbYesNo + vbQuestion, "Add to Cart")
            If intResponse = MsgBoxResult.Yes Then
                dblIntotprice = CalculatePrice("Hand Grippers", cboQuantityHandGrippers.SelectedIndex + 1)
                intX += 1
                strIndoor(intX) = String.Format(strFormat, "Hand Grippers", "X" & (cboQuantityHandGrippers.SelectedIndex + 1))
            End If
        End If


    End Sub

    Private Sub btnAddElecHandGrippers_Click(sender As Object, e As EventArgs) Handles btnAddElecHandGrippers.Click

        'calculation electronic hand grippers'

        If cboQuantityElecHandGrippers.SelectedIndex = -1 Then
            MsgBox("Choose a quantity", vbOKOnly & vbExclamation, "Error")
        Else
            intResponse = MsgBox("Do you want to proceed ?", vbYesNo + vbQuestion, "Add to Cart")
            If intResponse = MsgBoxResult.Yes Then
                dblIntotprice = CalculatePrice("Electronic Hand Grippers", cboQuantityElecHandGrippers.SelectedIndex + 1)
                intX += 1
                strIndoor(intX) = String.Format(strFormat, "Electronic Hand Grippers", "X" & (cboQuantityElecHandGrippers.SelectedIndex + 1))
            End If
        End If


    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub grpItems4_Enter(sender As Object, e As EventArgs) Handles grpItems4.Enter

    End Sub

    Private Sub btnProceedToCheckout_Click(sender As Object, e As EventArgs) Handles btnProceedToCheckout.Click
        Form2.Show()
    End Sub

    Private Sub btnBackToCategory_Click(sender As Object, e As EventArgs) Handles btnBackToCategory.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Public Function getTotalValue() As Double
        Return dblIntotprice
    End Function

    Private Sub mnuNaviOutdoor_Click(sender As Object, e As EventArgs) Handles mnuNaviOutdoor.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub mnuNaviHome_Click(sender As Object, e As EventArgs) Handles mnuNaviHome.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        AboutUs.Show()
    End Sub

    Private Sub mnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        Application.Exit()
        Process.Start(Application.ExecutablePath)
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Form5.Show()
    End Sub
End Class
