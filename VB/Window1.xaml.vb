Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Documents
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Printing

Namespace DXGrid_PrintGrid
    Partial Public Class Window1
        Inherits Window
        Public Sub New()
            InitializeComponent()
            grid.DataSource = IssueList.GetData()
        End Sub

        Private Sub PreviewGrid(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim link As New VisualDataNodeLink(CType(grid.View, TableView))
            link.ShowPrintPreviewDialog(Me)
        End Sub

        Private Sub ExportGrid(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim link As New VisualDataNodeLink(CType(grid.View, TableView))
            link.ExportToXlsx("c:\grid_export.xlsx")
        End Sub

    End Class

    Public Class IssueList
        Public Shared Function GetData() As List(Of IssueDataObject)
            Dim data As New List(Of IssueDataObject)()
            data.Add(New IssueDataObject() With {.IssueName = "Transaction History",
                                                 .IssueType = "Bug", .IsPrivate = True})
            data.Add(New IssueDataObject() With {.IssueName = "Ledger: Inconsistency",
                                                 .IssueType = "Bug", .IsPrivate = False})
            data.Add(New IssueDataObject() With {.IssueName = "Data Import",
                                                 .IssueType = "Request", .IsPrivate = False})
            data.Add(New IssueDataObject() With {.IssueName = "Data Archiving",
                                                 .IssueType = "Request", .IsPrivate = True})
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

End Namespace
