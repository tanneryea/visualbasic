Public Class AllDestinationsForm
    Private Sub AllDestinationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DestinationDatabaseDataSet.Destination' table. You can move, or remove it, as needed.
        Me.DestinationTableAdapter.Fill(Me.DestinationDatabaseDataSet.Destination)

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Me.DestinationTableAdapter.Update(Me.DestinationDatabaseDataSet.Destination)
    End Sub
End Class