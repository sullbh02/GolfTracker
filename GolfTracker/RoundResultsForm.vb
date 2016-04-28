Imports System.Data.SqlClient

Public Class RoundResultsForm
    Private mStats As New Stats
    Private mGolfers As New Golfers
    Private loading As Boolean = True



    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        dgvStats.DataSource = mStats.Items
    End Sub

    Private Sub RoundResultsForm_Load() Handles MyBase.Load

        'TableAdapter is set to sort table by lowest score
        'Because we need lowest score to always be in the first row the table is LOCKED from sorting

        Me.StatsTableAdapter.Fill(Me.GolfDatabaseDataSet.Stats)
        With cboGolfers.ComboBox
            .DataSource = mGolfers.Items
            .DisplayMember = "Name"
            .ValueMember = "golferId"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = -1

        End With
        loading = False

    End Sub

    Private Sub cboGolfer_SelectedIndexChanged() Handles cboGolfers.SelectedIndexChanged
        If Not loading Then
            Dim golferId As Short = CShort(cboGolfers.ComboBox.SelectedValue)
            dgvStats.DataSource = mStats.GetGolferId(golferId)
        End If
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim num As Integer

        num = dgvStats.RowCount - 1
        MessageBox.Show("Scores: " & num)

    End Sub

    Private Sub btnHandicap_Click(sender As Object, e As EventArgs) Handles btnHandicap.Click
        Dim numScores As Integer 'store number of scores
        Dim lowScore As Integer 'store low score
        Dim courseRating As Double 'store course rating
        Dim slopeRating As Double 'store slope rating
        Dim hIndex As Double 'store handicap index

        numScores = dgvStats.RowCount - 1


        If numScores <= 4 Then
            lblLow.Text = dgvStats.Rows(0).Cells(2).Value
            lblDifferential.Text = "ERROR"

            MessageBox.Show("Need Five Scores for OFFICAL handicap")

            'if number of scores recorded is 5 or less we only need one score to get handicap differental 
            'So we take the lowest score --- the lowest score will be stored in the first ROW 
        ElseIf numScores <= 5 Then
            lowScore = dgvStats.Rows(0).Cells(2).Value 'Low score will be in row 1 cell 3 
            'Next we need the CourseRating and SlopeRating
            courseRating = dgvStats.Rows(0).Cells(3).Value 'Course Rating is stored in cell 4
            slopeRating = dgvStats.Rows(0).Cells(4).Value  'Slope Rating is stored in cell 5 
            hIndex = (((lowScore - courseRating) * 113) / slopeRating) * 0.96 ' The handicap index
            lblDifferential.Text = Math.Round(hIndex, 2) 'Rounds to two decimal places xx.xx
            lblLow.Text = lowScore

            'if the number of scores is between 6-8 we use TWO to get the index
        ElseIf numScores >= 6 And numScores <= 8 Then
            lowScore = (dgvStats.Rows(0).Cells(2).Value + dgvStats.Rows(1).Cells(2).Value) / 2
            courseRating = (dgvStats.Rows(0).Cells(3).Value + dgvStats.Rows(1).Cells(3).Value) / 2
            slopeRating = (dgvStats.Rows(0).Cells(4).Value + dgvStats.Rows(1).Cells(4).Value) / 2
            hIndex = (((lowScore - courseRating) * 113) / slopeRating) * 0.96
            lblDifferential.Text = Math.Round(hIndex, 2)
            lblLow.Text = dgvStats.Rows(0).Cells(2).Value

            'if the number of scores is between 9-10 we use THREE lowest scores to get the index
        ElseIf numScores >= 9 And numScores <= 10 Then
            lowScore = (dgvStats.Rows(0).Cells(2).Value + dgvStats.Rows(1).Cells(2).Value + dgvStats.Rows(2).Cells(2).Value) / 3
            courseRating = (dgvStats.Rows(0).Cells(3).Value + dgvStats.Rows(1).Cells(3).Value + dgvStats.Rows(2).Cells(3).Value) / 3
            slopeRating = (dgvStats.Rows(0).Cells(4).Value + dgvStats.Rows(1).Cells(4).Value + dgvStats.Rows(2).Cells(4).Value) / 3
            hIndex = (((lowScore - courseRating) * 113) / slopeRating) * 0.96
            lblDifferential.Text = Math.Round(hIndex, 2)
            lblLow.Text = dgvStats.Rows(0).Cells(2).Value

            'if the number of scores is between 11-12 we use the FOUR lowest scores to get the index
        ElseIf numScores >= 11 And numScores <= 12 Then
            lowScore = (dgvStats.Rows(0).Cells(2).Value + dgvStats.Rows(1).Cells(2).Value + dgvStats.Rows(2).Cells(2).Value + dgvStats.Rows(3).Cells(2).Value) / 4
            courseRating = (dgvStats.Rows(0).Cells(3).Value + dgvStats.Rows(1).Cells(3).Value + dgvStats.Rows(2).Cells(3).Value + dgvStats.Rows(3).Cells(3).Value) / 4
            slopeRating = (dgvStats.Rows(0).Cells(4).Value + dgvStats.Rows(1).Cells(4).Value + dgvStats.Rows(2).Cells(4).Value + dgvStats.Rows(3).Cells(4).Value) / 4
            hIndex = (((lowScore - courseRating) * 113) / slopeRating) * 0.96
            lblDifferential.Text = Math.Round(hIndex, 2)
            lblLow.Text = dgvStats.Rows(0).Cells(2).Value

            'if the number of scores is between 13 and 14 we use the FIVE lowest scores to get the index
        ElseIf numScores >= 13 And numScores <= 14 Then
            lowScore = (dgvStats.Rows(0).Cells(2).Value + dgvStats.Rows(1).Cells(2).Value + dgvStats.Rows(2).Cells(2).Value + dgvStats.Rows(3).Cells(2).Value + dgvStats.Rows(4).Cells(2).Value) / 5
            courseRating = (dgvStats.Rows(0).Cells(3).Value + dgvStats.Rows(1).Cells(3).Value + dgvStats.Rows(2).Cells(3).Value + dgvStats.Rows(3).Cells(3).Value + dgvStats.Rows(4).Cells(3).Value) / 5
            slopeRating = (dgvStats.Rows(0).Cells(4).Value + dgvStats.Rows(1).Cells(4).Value + dgvStats.Rows(2).Cells(4).Value + dgvStats.Rows(3).Cells(4).Value + dgvStats.Rows(4).Cells(4).Value) / 5
            hIndex = (((lowScore - courseRating) * 113) / slopeRating) * 0.96
            lblDifferential.Text = Math.Round(hIndex, 2)
            lblLow.Text = dgvStats.Rows(0).Cells(2).Value
            'if the number of scores is between 15 and 16 we use the lowest SIX scores to get the index
        ElseIf numScores >= 15 And numScores <= 16 Then
            lowScore = (dgvStats.Rows(0).Cells(2).Value + dgvStats.Rows(1).Cells(2).Value + dgvStats.Rows(2).Cells(2).Value + dgvStats.Rows(3).Cells(2).Value + dgvStats.Rows(4).Cells(2).Value + dgvStats.Rows(5).Cells(2).Value) / 6
            courseRating = (dgvStats.Rows(0).Cells(3).Value + dgvStats.Rows(1).Cells(3).Value + dgvStats.Rows(2).Cells(3).Value + dgvStats.Rows(3).Cells(3).Value + dgvStats.Rows(4).Cells(3).Value + dgvStats.Rows(5).Cells(3).Value) / 6
            slopeRating = (dgvStats.Rows(0).Cells(4).Value + dgvStats.Rows(1).Cells(4).Value + dgvStats.Rows(2).Cells(4).Value + dgvStats.Rows(3).Cells(4).Value + dgvStats.Rows(4).Cells(4).Value + dgvStats.Rows(5).Cells(4).Value) / 6
            hIndex = (((lowScore - courseRating) * 113) / slopeRating) * 0.96
            lblDifferential.Text = Math.Round(hIndex, 2)
            lblLow.Text = dgvStats.Rows(0).Cells(2).Value

            'if the number of scores is 17 we use the SEVEN lowest scores to get the index
        ElseIf numScores = 17 Then
            lowScore = (dgvStats.Rows(0).Cells(2).Value + dgvStats.Rows(1).Cells(2).Value + dgvStats.Rows(2).Cells(2).Value + dgvStats.Rows(3).Cells(2).Value + dgvStats.Rows(4).Cells(2).Value + dgvStats.Rows(5).Cells(2).Value + dgvStats.Rows(6).Cells(2).Value) / 7
            courseRating = (dgvStats.Rows(0).Cells(3).Value + dgvStats.Rows(1).Cells(3).Value + dgvStats.Rows(2).Cells(3).Value + dgvStats.Rows(3).Cells(3).Value + dgvStats.Rows(4).Cells(3).Value + dgvStats.Rows(5).Cells(3).Value + dgvStats.Rows(6).Cells(3).Value) / 7
            slopeRating = (dgvStats.Rows(0).Cells(4).Value + dgvStats.Rows(1).Cells(4).Value + dgvStats.Rows(2).Cells(4).Value + dgvStats.Rows(3).Cells(4).Value + dgvStats.Rows(4).Cells(4).Value + dgvStats.Rows(5).Cells(4).Value + dgvStats.Rows(6).Cells(4).Value) / 7
            hIndex = (((lowScore - courseRating) * 113) / slopeRating) * 0.96
            lblDifferential.Text = Math.Round(hIndex, 2)
            lblLow.Text = dgvStats.Rows(0).Cells(2).Value

            'if the number of scores is 18 we use the EIGHT lowest scores to get the index
        ElseIf numScores = 18 Then
            lowScore = (dgvStats.Rows(0).Cells(2).Value + dgvStats.Rows(1).Cells(2).Value + dgvStats.Rows(2).Cells(2).Value + dgvStats.Rows(3).Cells(2).Value + dgvStats.Rows(4).Cells(2).Value + dgvStats.Rows(5).Cells(2).Value + dgvStats.Rows(6).Cells(2).Value + dgvStats.Rows(7).Cells(2).Value) / 8
            courseRating = (dgvStats.Rows(0).Cells(3).Value + dgvStats.Rows(1).Cells(3).Value + dgvStats.Rows(2).Cells(3).Value + dgvStats.Rows(3).Cells(3).Value + dgvStats.Rows(4).Cells(3).Value + dgvStats.Rows(5).Cells(3).Value + dgvStats.Rows(6).Cells(3).Value + dgvStats.Rows(7).Cells(3).Value) / 8
            slopeRating = (dgvStats.Rows(0).Cells(4).Value + dgvStats.Rows(1).Cells(4).Value + dgvStats.Rows(2).Cells(4).Value + dgvStats.Rows(3).Cells(4).Value + dgvStats.Rows(4).Cells(4).Value + dgvStats.Rows(5).Cells(4).Value + dgvStats.Rows(6).Cells(4).Value + dgvStats.Rows(7).Cells(4).Value) / 8
            hIndex = (((lowScore - courseRating) * 113) / slopeRating) * 0.96
            lblDifferential.Text = Math.Round(hIndex, 2)
            lblLow.Text = dgvStats.Rows(0).Cells(2).Value

            'if the number of scores is 19 we use the NINE lowest scores to get the index
        ElseIf numScores = 19 Then
            lowScore = (dgvStats.Rows(0).Cells(2).Value + dgvStats.Rows(1).Cells(2).Value + dgvStats.Rows(2).Cells(2).Value + dgvStats.Rows(3).Cells(2).Value + dgvStats.Rows(4).Cells(2).Value + dgvStats.Rows(5).Cells(2).Value + dgvStats.Rows(6).Cells(2).Value + dgvStats.Rows(7).Cells(2).Value + dgvStats.Rows(8).Cells(2).Value) / 9
            courseRating = (dgvStats.Rows(0).Cells(3).Value + dgvStats.Rows(1).Cells(3).Value + dgvStats.Rows(2).Cells(3).Value + dgvStats.Rows(3).Cells(3).Value + dgvStats.Rows(4).Cells(3).Value + dgvStats.Rows(5).Cells(3).Value + dgvStats.Rows(6).Cells(3).Value + dgvStats.Rows(7).Cells(3).Value + dgvStats.Rows(8).Cells(3).Value) / 9
            slopeRating = (dgvStats.Rows(0).Cells(4).Value + dgvStats.Rows(1).Cells(4).Value + dgvStats.Rows(2).Cells(4).Value + dgvStats.Rows(3).Cells(4).Value + dgvStats.Rows(4).Cells(4).Value + dgvStats.Rows(5).Cells(4).Value + dgvStats.Rows(6).Cells(4).Value + dgvStats.Rows(7).Cells(4).Value + dgvStats.Rows(8).Cells(4).Value) / 9
            hIndex = (((lowScore - courseRating) * 113) / slopeRating) * 0.96
            lblDifferential.Text = Math.Round(hIndex, 2)
            lblLow.Text = dgvStats.Rows(0).Cells(2).Value


            'if the number of scores is 20 we use the TEN lowest scores to get the index
        ElseIf numScores >= 20 Then
            lowScore = (dgvStats.Rows(0).Cells(2).Value + dgvStats.Rows(1).Cells(2).Value + dgvStats.Rows(2).Cells(2).Value + dgvStats.Rows(3).Cells(2).Value + dgvStats.Rows(4).Cells(2).Value + dgvStats.Rows(5).Cells(2).Value + dgvStats.Rows(6).Cells(2).Value + dgvStats.Rows(7).Cells(2).Value + dgvStats.Rows(8).Cells(2).Value + dgvStats.Rows(9).Cells(2).Value) / 10
            courseRating = (dgvStats.Rows(0).Cells(3).Value + dgvStats.Rows(1).Cells(3).Value + dgvStats.Rows(2).Cells(3).Value + dgvStats.Rows(3).Cells(3).Value + dgvStats.Rows(4).Cells(3).Value + dgvStats.Rows(5).Cells(3).Value + dgvStats.Rows(6).Cells(3).Value + dgvStats.Rows(7).Cells(3).Value + dgvStats.Rows(8).Cells(3).Value + dgvStats.Rows(9).Cells(3).Value) / 10
            slopeRating = (dgvStats.Rows(0).Cells(4).Value + dgvStats.Rows(1).Cells(4).Value + dgvStats.Rows(2).Cells(4).Value + dgvStats.Rows(3).Cells(4).Value + dgvStats.Rows(4).Cells(4).Value + dgvStats.Rows(5).Cells(4).Value + dgvStats.Rows(6).Cells(4).Value + dgvStats.Rows(7).Cells(4).Value + dgvStats.Rows(8).Cells(4).Value + dgvStats.Rows(9).Cells(4).Value) / 10
            hIndex = (((lowScore - courseRating) * 113) / slopeRating) * 0.96
            lblDifferential.Text = Math.Round(hIndex, 2)
            lblLow.Text = dgvStats.Rows(0).Cells(2).Value
        End If

    End Sub



    ' Delete function to enable deleting rounds
    Public Function Delete(ByVal RoundId As Integer) As Boolean
        Dim rowsAffected As Integer = StatsTableAdapter.Delete(RoundId)
        Return rowsAffected > 0
    End Function

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If dgvStats.SelectedRows.Count > 0 Then
            Dim rId As Short = CShort(dgvStats.SelectedRows(0).Cells(0).Value)
            If StatsTableAdapter.Delete(rId) Then
                dgvStats.DataSource = mStats.Items
            Else
                MessageBox.Show("Unable to delete this this round")
            End If
        End If
    End Sub
End Class