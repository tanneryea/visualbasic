Public Class FindDestinationForm
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Me.DestinationTableAdapter.Fill(Me.FindDestinationDataSet.Destination, txtDestinationName.Text)
    End Sub


End Class