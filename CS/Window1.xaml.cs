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
        private void ExportGrid(object sender, RoutedEventArgs e) {
            view.ExportToXlsx(@"c:\grid_export.xlsx");
        }
    }
}
