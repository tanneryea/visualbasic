Public Class FullViewForm
    Private Sub FullViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DestinationTableAdapter.Fill(Me.ViewDestinationDataSet.Destination, RevisedMainForm.DestinationName)
    End Sub
End Class