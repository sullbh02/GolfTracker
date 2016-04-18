Public Class MainForm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RoundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoundToolStripMenuItem.Click
        PostScoreForm.ShowDialog()
    End Sub

    Private Sub RoundsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoundsToolStripMenuItem.Click
        RoundResultsForm.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem1.Click
        GolfersForm.ShowDialog()
    End Sub

    Private Sub HandicapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HandicapToolStripMenuItem.Click
        HandicapForm.ShowDialog()

    End Sub



    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        AddGolferForm.ShowDialog()
    End Sub
End Class