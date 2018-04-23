Imports System.Collections.Generic

Public Class IssueList
    Public Property List As List(Of IssueDataObject)
    Public Sub New()
        List = GetIssueList()
    End Sub
    Public Shared Function GetIssueList() As List(Of IssueDataObject)
        Dim data As New List(Of IssueDataObject)()
        data.Add(New IssueDataObject() With {.IssueName = "Transaction History", .IssueType = "Bug", .IsPrivate = True})
        data.Add(New IssueDataObject() With {.IssueName = "Ledger: Inconsistency", .IssueType = "Bug", .IsPrivate = False})
        data.Add(New IssueDataObject() With {.IssueName = "Data Import", .IssueType = "Request", .IsPrivate = False})
        data.Add(New IssueDataObject() With {.IssueName = "Data Archiving", .IssueType = "Request", .IsPrivate = True})
        Return data
    End Function
End Class

Public Class IssueDataObject
    Private privateIssueName As String
    Public Property IssueName() As String
        Get
            Return privateIssueName
        End Get
        Set(ByVal value As String)
            privateIssueName = value
        End Set
    End Property
    Private privateIssueType As String
    Public Property IssueType() As String
        Get
            Return privateIssueType
        End Get
        Set(ByVal value As String)
            privateIssueType = value
        End Set
    End Property
    Private privateIsPrivate As Boolean
    Public Property IsPrivate() As Boolean
        Get
            Return privateIsPrivate
        End Get
        Set(ByVal value As Boolean)
            privateIsPrivate = value
        End Set
    End Property
End Class
