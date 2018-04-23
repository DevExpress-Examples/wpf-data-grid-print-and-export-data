using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Printing;

namespace DXGrid_PrintGrid {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            DataContext = new IssueList();
        }
        private void PreviewGrid(object sender, RoutedEventArgs e) {
            view.ShowPrintPreviewDialog(this);
        }
        private void ExportToXls(object sender, RoutedEventArgs e) {
            view.ExportToXlsx(@"d:\grid_export.xlsx");
        }
        private void ExportToCsv(object sender, RoutedEventArgs e) {
            view.ExportToCsv(@"d:\grid_export.csv");
        }
        private void ExportToPng(object sender, RoutedEventArgs e) {
            view.ExportToImage(@"d:\grid_export.png");
        }
    }
}
