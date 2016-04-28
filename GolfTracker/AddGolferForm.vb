Public Class AddGolferForm
    Private mGolfers As New Golfers
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim name As String
        If txtName.Text.Length = 0 Or IsNumeric(txtName.Text) Then
            errProvider.SetError(txtName, "Enter a valid name")
            MessageBox.Show("Please enter a valid name")
            txtName.Focus()
        Else
            errProvider.SetError(txtName, String.Empty)
            name = txtName.Text

        End If

        Dim courseName As String
        If txtCourseName.Text.Length = 0 Or IsNumeric(txtCourseName.Text) Then
            errProvider.SetError(txtCourseName, "Enter a valid course name")
            MessageBox.Show("Enter a valid course name")
            txtCourseName.Focus()
        Else
            errProvider.SetError(txtCourseName, String.Empty)
            courseName = txtCourseName.Text
        End If

        If mGolfers.Insert(name, courseName) Then
            Me.Close()
        Else
            lblStatus.Text = "Cannot Add Golfer" & Stats.LastError


        End If

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class