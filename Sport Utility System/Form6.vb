Public Class Form6
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Customer_LoginDataSet)
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Customer_LoginDataSet1.Outdoor' table. You can move, or remove it, as needed.
        Me.OutdoorTableAdapter.Fill(Me.Customer_LoginDataSet1.Outdoor)
        'TODO: This line of code loads data into the 'Customer_LoginDataSet1.Indoor' table. You can move, or remove it, as needed.
        Me.IndoorTableAdapter.Fill(Me.Customer_LoginDataSet1.Indoor)


    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub
End Class