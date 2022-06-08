Imports System.Windows

Namespace DXGrid_PrintGrid

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = IssueList.GetIssues()
        End Sub

        Private Sub PreviewGrid(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.view.ShowPrintPreviewDialog(Me)
        End Sub

        Private Sub ExportToXls(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.view.ExportToXlsx("d:\grid_export.xlsx")
        End Sub

        Private Sub ExportToCsv(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.view.ExportToCsv("d:\grid_export.csv")
        End Sub

        Private Sub ExportToPng(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.view.ExportToImage("d:\grid_export.png")
        End Sub
    End Class
End Namespace
