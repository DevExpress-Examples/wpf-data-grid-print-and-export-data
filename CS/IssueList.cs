using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXGrid_PrintGrid {
    public class IssueList {
        public List<IssueDataObject> List { get; private set; }
        public IssueList() {
            List = GetIssueList();
        }
        List<IssueDataObject> GetIssueList() {
            List<IssueDataObject> data = new List<IssueDataObject>();
            data.Add(new IssueDataObject() { IssueName = "Transaction History", IssueType = "Bug", IsPrivate = true });
            data.Add(new IssueDataObject() { IssueName = "Ledger: Inconsistency", IssueType = "Bug", IsPrivate = false });
            data.Add(new IssueDataObject() { IssueName = "Data Import", IssueType = "Request", IsPrivate = false });
            data.Add(new IssueDataObject() { IssueName = "Data Archiving", IssueType = "Request", IsPrivate = true });
            return data;
        }
    }
    public class IssueDataObject {
        public string IssueName { get; set; }
        public string IssueType { get; set; }
        public bool IsPrivate { get; set; }
    }
}
