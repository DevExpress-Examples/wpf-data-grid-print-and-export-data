using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Printing;

namespace DXGrid_PrintGrid {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = IssueList.GetData();
        }

        private void PreviewGrid(object sender, RoutedEventArgs e) {
            PrintableControlLink link = new PrintableControlLink((TableView)grid.View);
            link.ShowPrintPreviewDialog(this);
        }

        private void ExportGrid(object sender, RoutedEventArgs e) {
            PrintableControlLink link = new PrintableControlLink((TableView)grid.View);
            link.ExportToXlsx(@"c:\grid_export.xlsx");
        }

    }
    
    public class IssueList {
        static public List<IssueDataObject> GetData() {
            List<IssueDataObject> data = new List<IssueDataObject>();
            data.Add(new IssueDataObject() { IssueName = "Transaction History", 
                        IssueType = "Bug", IsPrivate = true });
            data.Add(new IssueDataObject() { IssueName = "Ledger: Inconsistency", 
                        IssueType = "Bug", IsPrivate = false });
            data.Add(new IssueDataObject() { IssueName = "Data Import", 
                        IssueType = "Request", IsPrivate = false });
            data.Add(new IssueDataObject() { IssueName = "Data Archiving", 
                        IssueType = "Request", IsPrivate = true });
            return data;
        }
    }

    public class IssueDataObject {
        public string IssueName { get; set; }
        public string IssueType { get; set; }
        public bool IsPrivate { get; set; }
    }
}
