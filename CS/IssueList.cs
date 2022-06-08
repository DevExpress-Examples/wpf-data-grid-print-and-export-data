using System.Collections.ObjectModel;

namespace DXGrid_PrintGrid {
    public class IssueList {
        public static ObservableCollection<IssueData> GetIssues() {
            ObservableCollection<IssueData> data = new ObservableCollection<IssueData>();
            data.Add(new IssueData() { IssueName = "Transaction History", IssueType = "Bug", IsPrivate = true });
            data.Add(new IssueData() { IssueName = "Ledger: Inconsistency", IssueType = "Bug", IsPrivate = false });
            data.Add(new IssueData() { IssueName = "Data Import", IssueType = "Request", IsPrivate = false });
            data.Add(new IssueData() { IssueName = "Data Archiving", IssueType = "Request", IsPrivate = true });
            return data;
        }
    }
    public class IssueData {
        public string IssueName { get; set; }
        public string IssueType { get; set; }
        public bool IsPrivate { get; set; }
    }
}
