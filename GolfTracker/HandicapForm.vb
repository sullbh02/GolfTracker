Imports System.Data.SqlClient
Imports System.Linq

Public Class HandicapForm
    Private Sub Handicap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Figure out how to calculate handicap using LINQ 
        'Maybe have a message box pop up with the selected Golfers Handicap based on 5 scores.

        Dim db As New GolfStatsDataContext
        'fills dgv with all the scores with the lowest score first 
        Dim query = From Stats In db.Stats
                    Where Stats.Score
                    Select Stats
                    Order By Stats.Score Ascending
        dgvHandicap.DataSource = query

        'Counts the number of scores 
        Dim numScores As Integer
        numScores = Aggregate Stats In db.Stats
                            Into Count(Stats.Score)
        lblCount.Text = numScores

        Dim lowScore As Integer 'store low score
        Dim courseRating As Double 'store course rating
        Dim slopeRating As Double 'store slope rating
        Dim hIndex As Double 'store handicap index

        'if number of scores is less than 5 we cannot caluclate handicap
        If numScores <= 4 Then
            lblLow.Text = dgvHandicap.Rows(0).Cells(2).Value
            lblDifferential.Text = "ERROR"
            lblCount.Text = numScores
            MessageBox.Show("Need Five scores to calculate handicap")
        End If
        'if number of scores recorded is 5 or less we only need one score to get handicap differental 
        'So we take the lowest score --- the lowest score will be stored in the first ROW 
        If numScores <= 5 Then
            lowScore = dgvHandicap.Rows(0).Cells(2).Value 'Low score will be in row 1 cell 3 
            lblLow.Text = lowScore
            'Next we need the CourseRating and SlopeRating
            courseRating = dgvHandicap.Rows(0).Cells(3).Value 'Course Rating is stored in cell 4
            slopeRating = dgvHandicap.Rows(0).Cells(4).Value  'Slope Rating is stored in cell 5 
            hIndex = (((lowScore - courseRating) * 113) / slopeRating) * 0.96 ' The handicap index
            lblDifferential.Text = Math.Round(hIndex, 2) 'Rounds to two decimal places xx.xx

            'if the number of scores is between 6-8 we use TWO to get the index
        ElseIf numScores >= 6 And numScores <= 8 Then
            lowScore = (dgvHandicap.Rows(0).Cells(2).Value + dgvHandicap.Rows(1).Cells(2).Value) / 2
            courseRating = (dgvHandicap.Rows(0).Cells(3).Value + dgvHandicap.Rows(1).Cells(3).Value) / 2
            slopeRating = (dgvHandicap.Rows(0).Cells(4).Value + dgvHandicap.Rows(1).Cells(4).Value) / 2
            hIndex = (((lowScore - courseRating) * 113) / slopeRating) * 0.96
            lblDifferential.Text = Math.Round(hIndex, 2)
            lblLow.Text = dgvHandicap.Rows(0).Cells(2).Value

            'if the number os scores is between 9-10 we use THREE lowest scores to get the index
        ElseIf numScores >= 9 And numScores <= 10 Then
            lowScore = (dgvHandicap.Rows(0).Cells(2).Value + dgvHandicap.Rows(1).Cells(2).Value + dgvHandicap.Rows(2).Cells(2).Value) / 3
            courseRating = (dgvHandicap.Rows(0).Cells(3).Value + dgvHandicap.Rows(1).Cells(3).Value + dgvHandicap.Rows(2).Cells(3).Value) / 3
            slopeRating = (dgvHandicap.Rows(0).Cells(4).Value + dgvHandicap.Rows(1).Cells(4).Value + dgvHandicap.Rows(2).Cells(4).Value) / 3
            lblDifferential.Text = Math.Round(hIndex, 2)
            lblLow.Text = dgvHandicap.Rows(0).Cells(2).Value
        End If

        'if the number of scores is between 11-12 we use the FOUR lowest scores to get the index
        'insert  code

        'if the number of scores is between 13 and 14 we use the FIVE lowest scores to get the index
        'insert code

        'if the number of scores is between 15 and 16 we use the lowest SIX scores to get the index
        'insert code

        'if the number of scores is 17 we use the SEVEN lowest scores to get the index
        'insert code

        'if the number of scores is 18 we use the EIGHT lowest scores to get the index
        'insert  code

        'if the number of scores is 19 we use the NINE lowest scores to get the index
        'insert code

        'if the number of scores is 20 we use the TEN lowest scores to get the index
        'insert code

















    End Sub
End Class