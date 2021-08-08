Public Class MainForm
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub ListAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListAllToolStripMenuItem.Click
        Dim frmAllDestinations As New AllDestinationsForm
        frmAllDestinations.ShowDialog()
    End Sub

    Private Sub AddDestinationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDestinationToolStripMenuItem.Click
        Dim frmAddDestination As New AddDestinationForm
        frmAddDestination.ShowDialog()
    End Sub

    Private Sub FindDestinationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindDestinationToolStripMenuItem.Click
        Dim frmFindDestination As New FindDestinationForm
        frmFindDestination.ShowDialog()
    End Sub
End Class
