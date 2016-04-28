Public Class PostScoreForm
    Private mStats As New Stats
    Private mGolfers As New Golfers


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Input validation

        Dim [date] As DateTime
        Try
            [date] = dtpDate.Value.Date

        Catch
            errProvider.SetError(dtpDate, "Select a date")
            Return
        End Try

        'Input validatin for COURSE NAME
        Dim course As String

        If txtCourseName.Text.Length = 0 Or IsNumeric(txtCourseName.Text) Then
            errProvider.SetError(txtCourseName, "Enter a course name")
            MessageBox.Show("Input Error, Please try posting a score again.")
            txtCourseName.Focus()
        Else
            errProvider.SetError(txtCourseName, String.Empty)
            course = txtCourseName.Text
        End If

        'Input validation for SCORE 
        Dim score As Integer

        If Not IsNumeric(txtScore.Text) Then
            errProvider.SetError(txtScore, "Please enter a Score.")
            MessageBox.Show("Score ERROR, Please try posting a score again.")
            txtScore.Focus()
        Else
            errProvider.SetError(txtScore, String.Empty)
            score = CInt(txtScore.Text)
        End If

        'Input validaion for COURSE RATING
        Dim courseRating As Decimal

        If Not IsNumeric(txtCourseRating.Text) Then
            errProvider.SetError(txtCourseRating, "Enter valid rating")
            MessageBox.Show("Course Rating ERROR, Please try posting a score again.")
            txtCourseRating.Focus()
        Else
            errProvider.SetError(txtCourseRating, String.Empty)
            courseRating = CDec(txtCourseRating.Text)
        End If

        'Input validation for SLOPE RATING
        Dim slopeRating As Decimal

        If Not IsNumeric(txtSlopeRating.Text) Then
            errProvider.SetError(txtSlopeRating, "Enter valid rating")
            MessageBox.Show("Slope Rating ERROR, Please try posting a score again.")
            txtSlopeRating.Focus()
        Else
            errProvider.SetError(txtSlopeRating, String.Empty)
            slopeRating = CDec(txtSlopeRating.Text)
        End If

        'Input validatoin for GolferID 
        Dim golferId As Short
        If cboGolfer.SelectedValue = 0 Then
            errProvider.SetError(cboGolfer, "Select golfer")
            MessageBox.Show("Golfer Selection ERROR, Please try posting a score again.")
            cboGolfer.Focus()
        Else
            errProvider.SetError(cboGolfer, String.Empty)
            golferId = CShort(cboGolfer.SelectedValue)
        End If

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
