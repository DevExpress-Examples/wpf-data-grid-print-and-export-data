Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DXGrid_PrintGrid
    Public Class IssueList
        Private privateList As List(Of IssueDataObject)
        Public Property List() As List(Of IssueDataObject)
            Get
                Return privateList
            End Get
            Private Set(ByVal value As List(Of IssueDataObject))
                privateList = value
            End Set
        End Property
        Public Sub New()
            List = GetIssueList()
        End Sub
        Private Function GetIssueList() As List(Of IssueDataObject)
            Dim data As New List(Of IssueDataObject)()
            data.Add(New IssueDataObject() With {.IssueName = "Transaction History", .IssueType = "Bug", .IsPrivate = True})
            data.Add(New IssueDataObject() With {.IssueName = "Ledger: Inconsistency", .IssueType = "Bug", .IsPrivate = False})
            data.Add(New IssueDataObject() With {.IssueName = "Data Import", .IssueType = "Request", .IsPrivate = False})
            data.Add(New IssueDataObject() With {.IssueName = "Data Archiving", .IssueType = "Request", .IsPrivate = True})
            Return data
        End Function
    End Class
    Public Class IssueDataObject
        Public Property IssueName() As String
        Public Property IssueType() As String
        Public Property IsPrivate() As Boolean
    End Class
End Namespace
