Public Class Golfers
    Private adapter As New GolfDatabaseDataSetTableAdapters.GolfersTableAdapter

    Public Shared Property LastError As String
    'Returns a dataTable containing all the Golfers sorting them by Name
    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Name"
            Return table
        End Get
    End Property

    Public Function Insert(ByVal name As String, ByVal courseName As String) As Boolean
        Try
            LastError = String.Empty
            adapter.Insert(name, courseName)
            Return True

        Catch ex As Exception
            LastError = ex.Message
            Return False

        End Try
    End Function
End Class
