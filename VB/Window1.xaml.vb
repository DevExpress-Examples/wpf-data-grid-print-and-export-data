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
            DataContext = New IssueList()
        End Sub
        Private Sub PreviewGrid(ByVal sender As Object, ByVal e As RoutedEventArgs)
            view.ShowPrintPreviewDialog(Me)
        End Sub
        Private Sub ExportToXls(ByVal sender As Object, ByVal e As RoutedEventArgs)
            view.ExportToXlsx("d:\grid_export.xlsx")
        End Sub
        Private Sub ExportToCsv(ByVal sender As Object, ByVal e As RoutedEventArgs)
            view.ExportToCsv("d:\grid_export.csv")
        End Sub
        Private Sub ExportToPng(ByVal sender As Object, ByVal e As RoutedEventArgs)
            view.ExportToImage("d:\grid_export.png")
        End Sub
    End Class
End Namespace
