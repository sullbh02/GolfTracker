Public Class GolfersForm
    Private mGolfers As New Golfers
    Private Sub Golfers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GolfersTableAdapter.Fill(Me.GolfDatabaseDataSet.Golfers)
    End Sub

    'Delete function to enable deleting golfers 
    Public Function Delete(ByVal GolferId As Integer) As Boolean
        Dim rowsAffected As Integer = GolfersTableAdapter.Delete(GolferId)
        Return rowsAffected > 0
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvGolfers.SelectedRows.Count > 0 Then
            Dim gId As Short = CShort(dgvGolfers.SelectedRows(0).Cells(0).Value)
            If GolfersTableAdapter.Delete(gId) Then
                dgvGolfers.DataSource = mGolfers.Items
            Else
                MessageBox.Show("Unable to delete this this golfer")
            End If
        End If
    End Sub
End Class