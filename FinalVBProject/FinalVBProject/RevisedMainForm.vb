Public Class RevisedMainForm
    Public DestinationName As String
    Public DestinationRow As Integer
    Private Sub RevisedMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DestinationDatabaseDataSet.Destination' table. You can move, or remove it, as needed.
        Me.DestinationTableAdapter.Fill(Me.DestinationDatabaseDataSet.Destination)

    End Sub

    Private Sub AddNewDestinationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewDestinationToolStripMenuItem.Click
        Dim frmAddDestination As New AddDestinationForm
        frmAddDestination.ShowDialog()
        Me.DestinationTableAdapter.Fill(Me.DestinationDatabaseDataSet.Destination)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnView.Click
        DestinationName = DataGridView1.CurrentRow.Cells(0).Value
        Dim frmViewDestination As New FullViewForm
        frmViewDestination.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Response = MsgBox("Are You Sure You Want To Delete This?", MsgBoxStyle.OkCancel
               )
        If Response = 1 Then
            DestinationName = DataGridView1.CurrentRow.Cells(0).Value
            Me.DestinationTableAdapter.DeleteQuery(DestinationName)
            DestinationRow = DataGridView1.CurrentRow.Index
            DataGridView1.Rows.RemoveAt(DestinationRow)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SearchDestinationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchDestinationsToolStripMenuItem.Click
        Dim frmFindDestination As New FindDestinationForm
        frmFindDestination.ShowDialog()
    End Sub
End Class