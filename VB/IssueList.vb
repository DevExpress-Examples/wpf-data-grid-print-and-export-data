Imports System.Collections.Generic

Namespace DXGrid_PrintGrid

    Public Class IssueList

        Private _List As List(Of DXGrid_PrintGrid.IssueDataObject)

        Public Property List As List(Of IssueDataObject)
            Get
                Return _List
            End Get

            Private Set(ByVal value As List(Of IssueDataObject))
                _List = value
            End Set
        End Property

        Public Sub New()
            List = GetIssueList()
        End Sub

        Private Function GetIssueList() As List(Of IssueDataObject)
            Dim data As List(Of IssueDataObject) = New List(Of IssueDataObject)()
            data.Add(New IssueDataObject() With {.IssueName = "Transaction History", .IssueType = "Bug", .IsPrivate = True})
            data.Add(New IssueDataObject() With {.IssueName = "Ledger: Inconsistency", .IssueType = "Bug", .IsPrivate = False})
            data.Add(New IssueDataObject() With {.IssueName = "Data Import", .IssueType = "Request", .IsPrivate = False})
            data.Add(New IssueDataObject() With {.IssueName = "Data Archiving", .IssueType = "Request", .IsPrivate = True})
            Return data
        End Function
    End Class

    Public Class IssueDataObject

        Public Property IssueName As String

        Public Property IssueType As String

        Public Property IsPrivate As Boolean
    End Class
End Namespace
