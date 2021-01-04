Public Class subfrmCust

    Public Delegate Sub SaveEvent()

    Public Event SaveCustomer As SaveEvent

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Validate the input and process as needed

        'Raise the event to notify the main form
        RaiseEvent SaveCustomer()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtId.Clear()
        txtName.Clear()
    End Sub
End Class
