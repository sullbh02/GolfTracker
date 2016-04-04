Public Class GolfersForm
    Private Sub Golfers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GolfDatabaseDataSet.Golfers' table. You can move, or remove it, as needed.
        Me.GolfersTableAdapter.Fill(Me.GolfDatabaseDataSet.Golfers)

    End Sub
End Class