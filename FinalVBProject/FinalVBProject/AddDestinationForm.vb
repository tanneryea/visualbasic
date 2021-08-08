Public Class AddDestinationForm

    Private Sub DestinationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DestinationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DestinationDatabaseDataSet)

    End Sub

    Private Sub AddDestinationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DestinationBindingSource.AddNew()
        GhostCheckBox.Checked = False
        DemonCheckBox.Checked = False
        WitchCheckBox.Checked = False
        BoogiemanCheckBox.Checked = False
        GhoulCheckBox.Checked = False
        HouseRadioButton.Checked = True
        CemetaryRadioButton.Checked = False
        PrisonRadioButton.Checked = False
        LighthouseRadioButton.Checked = False
        OtherRadioButton.Checked = False
    End Sub

    Private Sub SaveAndCloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAndCloseToolStripMenuItem.Click
        Try
            Me.DestinationBindingSource.EndEdit()
            Me.DestinationTableAdapter.Update(DestinationDatabaseDataSet.Destination)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub CloseWithoutSavingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseWithoutSavingToolStripMenuItem.Click
        Me.DestinationBindingSource.CancelEdit()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Me.DestinationBindingSource.EndEdit()
            Me.DestinationTableAdapter.Update(DestinationDatabaseDataSet.Destination)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DestinationBindingSource.CancelEdit()
        Me.Close()
    End Sub
End Class