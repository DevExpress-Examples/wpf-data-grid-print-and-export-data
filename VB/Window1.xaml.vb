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
            DataContext = New IssueList()
		End Sub
        Private Sub PreviewGrid(ByVal sender As Object, ByVal e As RoutedEventArgs)
            view.ShowPrintPreviewDialog(Me)
        End Sub
        Private Sub ExportGrid(ByVal sender As Object, ByVal e As RoutedEventArgs)
            view.ExportToXlsx("c:\grid_export.xlsx")
        End Sub
    End Class
End Namespace
