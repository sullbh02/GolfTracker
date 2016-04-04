Public Class PostScoreForm
    Private mStats As New Stats
    Private mGolfers As New Golfers

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ''/// Dont think i need this I think it auto sets date if not choosen
        Dim [date] As DateTime
        Try
            [date] = dtpDate.Value.Date

        Catch
            errProvider.SetError(dtpDate, "Select a date")
            Return
        End Try
        '///^^^^^^^^^^^^^^^

        Dim course As String = txtCourseName.Text
        Dim score As Integer = CInt(txtScore.Text)
        Dim courseRating As Decimal = CDec(txtCourseRating.Text)
        Dim slopeRating As Decimal = CDec(txtSlopeRating.Text)
        Dim golferId As Short = CShort(cboGolfer.SelectedValue)

        If mStats.Insert(course, score, courseRating, slopeRating, golferId, [date]) Then
            Me.Close()
        Else
            lblStatus.Text = "Cannot Post Score" & Stats.LastError
        End If
    End Sub

    Private Sub PostScoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fill the comboBox with the names of Golfers
        cboGolfer.DataSource = mGolfers.Items
        cboGolfer.DisplayMember = "Name"
        cboGolfer.ValueMember = "GolferId"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
