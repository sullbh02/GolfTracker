Imports System.Data.SqlClient

Public Class RoundResultsForm
    Private mStats As New Stats
    Private mGolfers As New Golfers
    Private loading As Boolean = True


    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        dgvStats.DataSource = mStats.Items
    End Sub

    Private Sub RoundResultsForm_Load() Handles MyBase.Load
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

        Dim golfers As List(Of Golfers)



    End Sub
End Class