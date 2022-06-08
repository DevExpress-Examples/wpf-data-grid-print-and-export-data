using System.Windows;

namespace DXGrid_PrintGrid {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = IssueList.GetIssues();
        }
        void PreviewGrid(object sender, RoutedEventArgs e) {
            view.ShowPrintPreviewDialog(this);
        }
        void ExportToXls(object sender, RoutedEventArgs e) {
            view.ExportToXlsx(@"d:\grid_export.xlsx");
        }
        void ExportToCsv(object sender, RoutedEventArgs e) {
            view.ExportToCsv(@"d:\grid_export.csv");
        }
        void ExportToPng(object sender, RoutedEventArgs e) {
            view.ExportToImage(@"d:\grid_export.png");
        }
    }
}
