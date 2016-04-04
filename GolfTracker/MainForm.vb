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
End Class