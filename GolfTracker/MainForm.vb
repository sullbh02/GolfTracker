Public Class MainForm
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub RoundToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RoundToolStripMenuItem1.Click
        PostScoreForm.ShowDialog()
    End Sub

    Private Sub RoundToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RoundToolStripMenuItem2.Click
        RoundResultsForm.ShowDialog()
    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        AddGolferForm.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem2.Click
        GolfersForm.ShowDialog()
    End Sub
End Class