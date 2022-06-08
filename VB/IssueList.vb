Imports System.Collections.ObjectModel

Namespace DXGrid_PrintGrid

    Public Class IssueList

        Public Shared Function GetIssues() As ObservableCollection(Of IssueData)
            Dim data As ObservableCollection(Of IssueData) = New ObservableCollection(Of IssueData)()
            data.Add(New IssueData() With {.IssueName = "Transaction History", .IssueType = "Bug", .IsPrivate = True})
            data.Add(New IssueData() With {.IssueName = "Ledger: Inconsistency", .IssueType = "Bug", .IsPrivate = False})
            data.Add(New IssueData() With {.IssueName = "Data Import", .IssueType = "Request", .IsPrivate = False})
            data.Add(New IssueData() With {.IssueName = "Data Archiving", .IssueType = "Request", .IsPrivate = True})
            Return data
        End Function
    End Class

    Public Class IssueData

        Public Property IssueName As String

        Public Property IssueType As String

        Public Property IsPrivate As Boolean
    End Class
End Namespace
