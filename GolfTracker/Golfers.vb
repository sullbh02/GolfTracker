Public Class Golfers
    Private adapter As New GolfDatabaseDataSetTableAdapters.GolfersTableAdapter

    'Returns a dataTable containing all the Golfers sorting them by Name
    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Name"
            Return table
        End Get
    End Property
End Class
