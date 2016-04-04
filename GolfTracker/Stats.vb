Public Class Stats
    Private adapter As New GolfDatabaseDataSetTableAdapters.StatsTableAdapter
    Public Shared Property LastError As String

    '/////////////////////
    '/The Insert method //
    '/////////////////////

    Public Function Insert(ByVal course As String, ByVal score As Integer, ByVal courseRating As Decimal, ByVal slopeRating As Decimal, ByVal golferId As Short, ByVal [date] As DateTime) As Boolean
        Try
            LastError = String.Empty
            adapter.Insert(course, score, courseRating, slopeRating, golferId, [date])
            Return True

        Catch ex As Exception
            LastError = ex.Message
            Return False

        End Try
    End Function

    '////////////////////////
    '// The Search method ///
    '////////////////////////


    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property
    Public Function GetGolferId(ByVal golferId As Short) As DataTable
        Dim table As DataTable = adapter.GetData() 'get all rows from Stats database 
        table.DefaultView.RowFilter = "GolferId = " & golferId  'limits to a single golfer
        Return table
    End Function


End Class
