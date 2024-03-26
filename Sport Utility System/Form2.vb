Imports System.Reflection
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form2
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim intResponse As Integer
        intResponse = MsgBox("Are you sure want cancel?", vbYesNo + vbQuestion, "Cancel Order")
        If intResponse = MsgBoxResult.Yes Then
            Me.Hide()
        End If

    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        Dim strAddress As String
        Dim strPaymentType As String = ""
        Dim decTotalPrice As Decimal
        Dim decSubTotal As Decimal


        decTotalPrice = Indoor.getTotalValue() + Form3.getTotalValue()

        strAddress = txtAddress.Text
        If cbxPayment.SelectedIndex = 0 Then
            strPaymentType = "Debit/Credit ( 3 % off )"
            decSubTotal = decTotalPrice - (decTotalPrice * 0.03)
        ElseIf cbxPayment.SelectedIndex = 1 Then





            strPaymentType = "E - Wallet(5% off )"
            decSubTotal = decTotalPrice - (decTotalPrice * 0.05)
        ElseIf cbxPayment.SelectedIndex = 2 Then
            strPaymentType = "COD (Cash on Delivery)"
            decSubTotal = decTotalPrice
        End If





        If strAddress = String.Empty Then
            MsgBox("Please enter your address!", vbOKOnly + vbExclamation, "Error")
        Else
            If cbxPayment.SelectedIndex = -1 Then
                MsgBox("Choose A Payment Method", vbOKOnly + vbExclamation, "Error")
            Else
                Dim intChoice As Integer
                intChoice = MsgBox("Are you sure you want to proceed for checkout ?", vbYesNo + vbExclamation, "Checkout")
                If intChoice = MsgBoxResult.Yes Then
                    'User information
                    lstOutput.Items.Add("-------------------------------------------------------------------")
                    lstOutput.Items.Add(String.Format("{0,-29} {1,0}", "Address: ", strAddress))
                    lstOutput.Items.Add(String.Format("{0,-20} {1,0}", "Payment Method: ", strPaymentType))
                    lstOutput.Items.Add(String.Format("{0,-29} {1,0}", "Total Price: ", FormatCurrency(decTotalPrice)))
                    lstOutput.Items.Add(String.Format("{0,-29} {1,0}", "Sub Total: ", FormatCurrency(decSubTotal)))


                    'Outdoor items bought by user (if any)
                    lstOutput.Items.Add("-------------------------------------------------------------------")
                    lstOutput.Items.Add("Outdoor Items Bought: ")
                    For intX As Integer = 0 To (Form3.strOutdoor.Length - 1)
                        Dim strOut As String = Form3.strOutdoor(intX)
                        lstOutput.Items.Add(strOut & vbCrLf)
                    Next

                    'Indoor items bought by user (if any)
                    lstOutput.Items.Add("-------------------------------------------------------------------")
                    lstOutput.Items.Add("Indoor Items Bought: ")
                    For intX As Integer = 0 To (Indoor.strIndoor.Length - 1)
                        Dim strOut As String = Indoor.strIndoor(intX)
                        lstOutput.Items.Add(strOut & vbCrLf)
                    Next

                    btnCancel.Visible = False
                    btnBack.Visible = True
                End If
            End If
        End If







    End Sub

    Private Sub mnAboutUs_Click(sender As Object, e As EventArgs) Handles mnAboutUs.Click
        AboutUs.Show()
    End Sub

    Public Sub InputValidation()
        If cbxPayment.SelectedIndex = -1 Then
            MsgBox("Choose A Payment Method", vbOKOnly + vbExclamation, "Error")
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub mnuEditPrint_Click(sender As Object, e As EventArgs) Handles mnuEditPrint.Click
        pdPrint.Print()
    End Sub

    Private Sub mnuEditPrintPReview_Click(sender As Object, e As EventArgs) Handles mnuEditPrintPReview.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub pdPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        e.Graphics.DrawString("CUSTOMER RECEIPT", New Font("Courier", 13, FontStyle.Bold), Brushes.Black, 0, 100)

        Dim startY As Integer = 150
        Dim intC As Integer

        For intC = 0 To lstOutput.Items.Count - 1
            e.Graphics.DrawString(lstOutput.Items(intC).ToString(), New Font("Courier", 13, FontStyle.Bold), Brushes.Black, 12, startY)
            startY += 20
        Next
    End Sub

    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub mnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        Application.Exit()
        Process.Start(Application.ExecutablePath)
    End Sub
End Class